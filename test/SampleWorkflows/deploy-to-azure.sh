#!/bin/bash

#
# Azure Logic Apps Deployment Script
#
# This script deploys the generated workflow artifacts to an Azure Logic Apps (Standard) instance.
# It assumes you are already logged in via 'az login'.
#
# Usage:
#   ./deploy-to-azure.sh --subscription-id <id> --resource-group <rg> --logic-app-name <name> [--location <location>] [--artifacts-path <path>]
#
# Examples:
#   ./deploy-to-azure.sh --subscription-id "12345678-1234-1234-1234-123456789abc" --resource-group "myResourceGroup" --logic-app-name "myLogicApp"
#   ./deploy-to-azure.sh --subscription-id "12345678-1234-1234-1234-123456789abc" --resource-group "myResourceGroup" --logic-app-name "myLogicApp" --location "westus2"
#

set -e

# Default values
LOCATION="eastus"
ARTIFACTS_PATH="./LogicApp"

# Color codes
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
CYAN='\033[0;36m'
NC='\033[0m' # No Color

# Parse arguments
while [[ $# -gt 0 ]]; do
    case $1 in
        --subscription-id)
            SUBSCRIPTION_ID="$2"
            shift 2
            ;;
        --resource-group)
            RESOURCE_GROUP="$2"
            shift 2
            ;;
        --logic-app-name)
            LOGIC_APP_NAME="$2"
            shift 2
            ;;
        --location)
            LOCATION="$2"
            shift 2
            ;;
        --artifacts-path)
            ARTIFACTS_PATH="$2"
            shift 2
            ;;
        -h|--help)
            echo "Usage: $0 --subscription-id <id> --resource-group <rg> --logic-app-name <name> [--location <location>] [--artifacts-path <path>]"
            exit 0
            ;;
        *)
            echo -e "${RED}Unknown parameter: $1${NC}"
            exit 1
            ;;
    esac
done

# Validate required parameters
if [ -z "$SUBSCRIPTION_ID" ] || [ -z "$RESOURCE_GROUP" ] || [ -z "$LOGIC_APP_NAME" ]; then
    echo -e "${RED}Error: Missing required parameters${NC}"
    echo "Usage: $0 --subscription-id <id> --resource-group <rg> --logic-app-name <name> [--location <location>] [--artifacts-path <path>]"
    exit 1
fi

echo -e "${CYAN}========================================"
echo "Azure Logic Apps Deployment Script"
echo "========================================${NC}"
echo ""

# Verify artifacts path exists
if [ ! -d "$ARTIFACTS_PATH" ]; then
    echo -e "${RED}Error: Artifacts path not found: $ARTIFACTS_PATH${NC}"
    echo "Please run 'dotnet run' first to generate the artifacts."
    exit 1
fi

echo -e "${YELLOW}Configuration:${NC}"
echo "  Subscription ID: $SUBSCRIPTION_ID"
echo "  Resource Group:  $RESOURCE_GROUP"
echo "  Logic App Name:  $LOGIC_APP_NAME"
echo "  Location:        $LOCATION"
echo "  Artifacts Path:  $ARTIFACTS_PATH"
echo ""

# Set subscription context
echo -e "${GREEN}Setting subscription context...${NC}"
az account set --subscription "$SUBSCRIPTION_ID"

# Check if resource group exists, create if not
echo -e "${GREEN}Checking resource group...${NC}"
if ! az group exists --name "$RESOURCE_GROUP" --output tsv | grep -q "true"; then
    echo -e "  ${YELLOW}Creating resource group '$RESOURCE_GROUP' in '$LOCATION'...${NC}"
    az group create --name "$RESOURCE_GROUP" --location "$LOCATION" --output none
else
    echo -e "  Resource group '$RESOURCE_GROUP' exists."
fi

# Check if Logic App exists
echo -e "${GREEN}Checking Logic App existence...${NC}"
if ! az logicapp show --name "$LOGIC_APP_NAME" --resource-group "$RESOURCE_GROUP" &>/dev/null; then
    echo -e "  ${YELLOW}Logic App does not exist. Creating new Logic App (Standard)...${NC}"

    # Create storage account for Logic App
    STORAGE_ACCOUNT_NAME=$(echo "${LOGIC_APP_NAME}sa" | tr '[:upper:]' '[:lower:]' | tr -cd '[:alnum:]' | cut -c1-24)
    echo -e "  ${YELLOW}Creating storage account '$STORAGE_ACCOUNT_NAME'...${NC}"

    az storage account create \
        --name "$STORAGE_ACCOUNT_NAME" \
        --resource-group "$RESOURCE_GROUP" \
        --location "$LOCATION" \
        --sku Standard_LRS \
        --output none

    # Create Logic App (Standard)
    echo -e "  ${YELLOW}Creating Logic App '$LOGIC_APP_NAME'...${NC}"
    az logicapp create \
        --name "$LOGIC_APP_NAME" \
        --resource-group "$RESOURCE_GROUP" \
        --storage-account "$STORAGE_ACCOUNT_NAME" \
        --output none
else
    echo -e "  Logic App '$LOGIC_APP_NAME' exists."
fi

# Process connections.json if it exists
CONNECTIONS_FILE="$ARTIFACTS_PATH/connections.json"
if [ -f "$CONNECTIONS_FILE" ]; then
    echo -e "${GREEN}Processing connections.json...${NC}"

    # Count connections
    CONNECTION_COUNT=$(jq '.managedApiConnections | length' "$CONNECTIONS_FILE")
    echo -e "  ${YELLOW}Found $CONNECTION_COUNT connection(s)${NC}"

    # Create each connection
    jq -r '.managedApiConnections | keys[]' "$CONNECTIONS_FILE" | while read -r CONNECTION_NAME; do
        # Extract connector name from API ID
        CONNECTOR_NAME=$(jq -r ".managedApiConnections[\"$CONNECTION_NAME\"].api.id" "$CONNECTIONS_FILE" | awk -F'/' '{print $NF}')

        echo -e "    ${YELLOW}Creating API connection: $CONNECTION_NAME (Connector: $CONNECTOR_NAME)${NC}"

        # Create connection
        az resource create \
            --resource-group "$RESOURCE_GROUP" \
            --resource-type "Microsoft.Web/connections" \
            --name "$CONNECTION_NAME" \
            --location "$LOCATION" \
            --properties "{\"api\": {\"id\": \"/subscriptions/$SUBSCRIPTION_ID/providers/Microsoft.Web/locations/$LOCATION/managedApis/$CONNECTOR_NAME\"}, \"displayName\": \"$CONNECTION_NAME\"}" \
            --output none 2>/dev/null && echo -e "      ${GREEN}✓ Connection created successfully${NC}" || echo -e "      ${YELLOW}⚠ Connection may already exist or requires manual configuration${NC}"
    done

    # Update connections.json with actual resource IDs
    echo -e "  ${YELLOW}Updating connections.json with actual Azure resource IDs...${NC}"

    TEMP_CONNECTIONS=$(mktemp)
    jq --arg sub "$SUBSCRIPTION_ID" --arg rg "$RESOURCE_GROUP" --arg loc "$LOCATION" '
        .managedApiConnections |= with_entries(
            .value.api.id = (.value.api.id | split("/")[-1] as $connector |
                "/subscriptions/\($sub)/providers/Microsoft.Web/locations/\($loc)/managedApis/\($connector)") |
            .value.connection.id = "/subscriptions/\($sub)/resourceGroups/\($rg)/providers/Microsoft.Web/connections/\(.key)"
        )
    ' "$CONNECTIONS_FILE" > "$TEMP_CONNECTIONS"

    mv "$TEMP_CONNECTIONS" "$CONNECTIONS_FILE"
    echo -e "    ${GREEN}✓ Updated connections.json${NC}"
fi

# Deploy workflows
echo -e "${GREEN}Deploying workflows...${NC}"

# Create a zip file for deployment
TEMP_ZIP=$(mktemp -u).zip
cd "$ARTIFACTS_PATH"
zip -r "$TEMP_ZIP" . > /dev/null
cd - > /dev/null

WORKFLOW_COUNT=$(find "$ARTIFACTS_PATH" -mindepth 1 -maxdepth 1 -type d | wc -l)
echo -e "  ${YELLOW}Found $WORKFLOW_COUNT workflow(s) to deploy${NC}"

# Deploy using Azure CLI
az logicapp deployment source config-zip \
    --name "$LOGIC_APP_NAME" \
    --resource-group "$RESOURCE_GROUP" \
    --src "$TEMP_ZIP" \
    --output none

# Clean up temp file
rm -f "$TEMP_ZIP"

echo -e "      ${GREEN}✓ Workflows deployed successfully${NC}"

# Get Logic App URL
echo ""
echo -e "${GREEN}Deployment completed!${NC}"
echo ""
echo -e "${CYAN}Logic App Details:${NC}"
echo "  Name: $LOGIC_APP_NAME"
echo "  Resource Group: $RESOURCE_GROUP"
echo "  Portal URL: https://portal.azure.com/#resource/subscriptions/$SUBSCRIPTION_ID/resourceGroups/$RESOURCE_GROUP/providers/Microsoft.Web/sites/$LOGIC_APP_NAME"
echo ""
echo -e "${YELLOW}Next Steps:${NC}"
echo "  1. Configure API connections in Azure Portal if needed"
echo "  2. Enable workflows in the Logic App"
echo "  3. Test your workflows"
echo ""
echo -e "${CYAN}To view your Logic App in Azure Portal, visit:${NC}"
echo -e "${BLUE}https://portal.azure.com/#resource/subscriptions/$SUBSCRIPTION_ID/resourceGroups/$RESOURCE_GROUP/providers/Microsoft.Web/sites/$LOGIC_APP_NAME${NC}"
echo ""
