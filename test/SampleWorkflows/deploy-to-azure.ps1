<#
.SYNOPSIS
    Deploys Logic App workflows to Azure Logic Apps (Standard)

.DESCRIPTION
    This script deploys the generated workflow artifacts to an Azure Logic Apps (Standard) instance.
    It assumes you are already logged in via 'az login'.

.PARAMETER SubscriptionId
    The Azure subscription ID where the Logic App will be deployed

.PARAMETER ResourceGroup
    The resource group name where the Logic App exists or will be created

.PARAMETER LogicAppName
    The name of the Logic App (Standard) instance

.PARAMETER Location
    The Azure region for deployment (default: eastus)

.PARAMETER ArtifactsPath
    Path to the generated artifacts folder (default: ./LogicApp)

.EXAMPLE
    .\deploy-to-azure.ps1 -SubscriptionId "12345678-1234-1234-1234-123456789abc" -ResourceGroup "myResourceGroup" -LogicAppName "myLogicApp"

.EXAMPLE
    .\deploy-to-azure.ps1 -SubscriptionId "12345678-1234-1234-1234-123456789abc" -ResourceGroup "myResourceGroup" -LogicAppName "myLogicApp" -Location "westus2"
#>

param(
    [Parameter(Mandatory = $true)]
    [string]$SubscriptionId,

    [Parameter(Mandatory = $true)]
    [string]$ResourceGroup,

    [Parameter(Mandatory = $true)]
    [string]$LogicAppName,

    [Parameter(Mandatory = $false)]
    [string]$Location = "eastus",

    [Parameter(Mandatory = $false)]
    [string]$ArtifactsPath = "./LogicApp"
)

# Set error action preference
$ErrorActionPreference = "Stop"

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Azure Logic Apps Deployment Script" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Verify artifacts path exists
if (-not (Test-Path $ArtifactsPath)) {
    Write-Error "Artifacts path not found: $ArtifactsPath. Please run 'dotnet run' first to generate the artifacts."
    exit 1
}

Write-Host "Configuration:" -ForegroundColor Yellow
Write-Host "  Subscription ID: $SubscriptionId"
Write-Host "  Resource Group:  $ResourceGroup"
Write-Host "  Logic App Name:  $LogicAppName"
Write-Host "  Location:        $Location"
Write-Host "  Artifacts Path:  $ArtifactsPath"
Write-Host ""

# Set subscription context
Write-Host "Setting subscription context..." -ForegroundColor Green
az account set --subscription $SubscriptionId
if ($LASTEXITCODE -ne 0) {
    Write-Error "Failed to set subscription context. Please ensure you're logged in with 'az login'."
    exit 1
}

# Check if resource group exists, create if not
Write-Host "Checking resource group..." -ForegroundColor Green
$rgExists = az group exists --name $ResourceGroup
if ($rgExists -eq "false") {
    Write-Host "  Creating resource group '$ResourceGroup' in '$Location'..." -ForegroundColor Yellow
    az group create --name $ResourceGroup --location $Location
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Failed to create resource group."
        exit 1
    }
} else {
    Write-Host "  Resource group '$ResourceGroup' exists." -ForegroundColor Gray
}

# Check if Logic App exists
Write-Host "Checking Logic App existence..." -ForegroundColor Green
$logicAppExists = az logicapp show --name $LogicAppName --resource-group $ResourceGroup 2>$null
if ($LASTEXITCODE -ne 0) {
    Write-Host "  Logic App does not exist. Creating new Logic App (Standard)..." -ForegroundColor Yellow

    # Create storage account for Logic App
    $storageAccountName = ($LogicAppName -replace '[^a-z0-9]', '').ToLower().Substring(0, [Math]::Min(24, $LogicAppName.Length)) + "sa"
    Write-Host "  Creating storage account '$storageAccountName'..." -ForegroundColor Yellow

    az storage account create `
        --name $storageAccountName `
        --resource-group $ResourceGroup `
        --location $Location `
        --sku Standard_LRS

    if ($LASTEXITCODE -ne 0) {
        Write-Error "Failed to create storage account."
        exit 1
    }

    # Create Logic App (Standard)
    Write-Host "  Creating Logic App '$LogicAppName'..." -ForegroundColor Yellow
    az logicapp create `
        --name $LogicAppName `
        --resource-group $ResourceGroup `
        --storage-account $storageAccountName

    if ($LASTEXITCODE -ne 0) {
        Write-Error "Failed to create Logic App."
        exit 1
    }
} else {
    Write-Host "  Logic App '$LogicAppName' exists." -ForegroundColor Gray
}

# Process connections.json if it exists
$connectionsFile = Join-Path $ArtifactsPath "connections.json"
if (Test-Path $connectionsFile) {
    Write-Host "Processing connections.json..." -ForegroundColor Green

    $connectionsContent = Get-Content $connectionsFile -Raw | ConvertFrom-Json

    if ($connectionsContent.managedApiConnections) {
        Write-Host "  Found $($connectionsContent.managedApiConnections.PSObject.Properties.Count) connection(s)" -ForegroundColor Yellow

        foreach ($connectionName in $connectionsContent.managedApiConnections.PSObject.Properties.Name) {
            $connection = $connectionsContent.managedApiConnections.$connectionName

            # Extract connector name from API ID
            $apiId = $connection.api.id
            $connectorName = $apiId.Split('/')[-1]

            Write-Host "    Creating API connection: $connectionName (Connector: $connectorName)" -ForegroundColor Yellow

            # Create API connection
            $connectionResourceId = "/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Web/connections/$connectionName"

            # Create connection using ARM template
            $connectionTemplate = @{
                properties = @{
                    displayName = $connectionName
                    api = @{
                        id = "/subscriptions/$SubscriptionId/providers/Microsoft.Web/locations/$Location/managedApis/$connectorName"
                    }
                }
            } | ConvertTo-Json -Depth 10

            # Deploy connection
            az resource create `
                --resource-group $ResourceGroup `
                --resource-type "Microsoft.Web/connections" `
                --name $connectionName `
                --properties $connectionTemplate `
                --location $Location 2>$null

            if ($LASTEXITCODE -eq 0) {
                Write-Host "      ✓ Connection created successfully" -ForegroundColor Green
            } else {
                Write-Host "      ⚠ Connection may already exist or requires manual configuration" -ForegroundColor Yellow
            }
        }
    }

    # Update connections.json with actual resource IDs
    Write-Host "  Updating connections.json with actual Azure resource IDs..." -ForegroundColor Yellow

    foreach ($connectionName in $connectionsContent.managedApiConnections.PSObject.Properties.Name) {
        $connection = $connectionsContent.managedApiConnections.$connectionName
        $apiId = $connection.api.id
        $connectorName = $apiId.Split('/')[-1]

        # Update with actual values
        $connectionsContent.managedApiConnections.$connectionName.api.id = "/subscriptions/$SubscriptionId/providers/Microsoft.Web/locations/$Location/managedApis/$connectorName"
        $connectionsContent.managedApiConnections.$connectionName.connection.id = "/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Web/connections/$connectionName"
    }

    # Save updated connections.json
    $connectionsContent | ConvertTo-Json -Depth 10 | Set-Content $connectionsFile
    Write-Host "    ✓ Updated connections.json" -ForegroundColor Green
}

# Deploy workflows
Write-Host "Deploying workflows..." -ForegroundColor Green

# Get all workflow directories
$workflowDirs = Get-ChildItem -Path $ArtifactsPath -Directory

if ($workflowDirs.Count -eq 0) {
    Write-Warning "No workflow directories found in $ArtifactsPath"
} else {
    Write-Host "  Found $($workflowDirs.Count) workflow(s) to deploy" -ForegroundColor Yellow

    foreach ($workflowDir in $workflowDirs) {
        $workflowName = $workflowDir.Name
        $workflowFile = Join-Path $workflowDir.FullName "workflow.json"

        if (Test-Path $workflowFile) {
            Write-Host "    Deploying workflow: $workflowName" -ForegroundColor Yellow

            # Deploy using Azure CLI
            az logicapp deployment source config-zip `
                --name $LogicAppName `
                --resource-group $ResourceGroup `
                --src (Compress-Archive -Path "$ArtifactsPath\*" -DestinationPath "$env:TEMP\logicapp-deploy.zip" -Force -PassThru).FullName

            if ($LASTEXITCODE -eq 0) {
                Write-Host "      ✓ Workflow deployed successfully" -ForegroundColor Green
            }
        } else {
            Write-Warning "    workflow.json not found in $($workflowDir.FullName)"
        }
    }
}

# Get Logic App URL
Write-Host ""
Write-Host "Deployment completed!" -ForegroundColor Green
Write-Host ""
Write-Host "Logic App Details:" -ForegroundColor Cyan
Write-Host "  Name: $LogicAppName"
Write-Host "  Resource Group: $ResourceGroup"
Write-Host "  Portal URL: https://portal.azure.com/#resource/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Web/sites/$LogicAppName"
Write-Host ""
Write-Host "Next Steps:" -ForegroundColor Yellow
Write-Host "  1. Configure API connections in Azure Portal if needed"
Write-Host "  2. Enable workflows in the Logic App"
Write-Host "  3. Test your workflows"
Write-Host ""
Write-Host "To view your Logic App in Azure Portal, visit:" -ForegroundColor Cyan
Write-Host "https://portal.azure.com/#resource/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Web/sites/$LogicAppName" -ForegroundColor Blue
Write-Host ""
