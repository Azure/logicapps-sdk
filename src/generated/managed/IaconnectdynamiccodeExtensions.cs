//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectdynamiccodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ImportAssemblyFromLocalFile(Expression<Func<ImportAssemblyFromLocalFileInput>> importAssemblyFromLocalFile)
        {
            var __workflow_importAssemblyFromLocalFile = WorkflowExpression.Compile(importAssemblyFromLocalFile, nameof(importAssemblyFromLocalFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_importAssemblyFromLocalFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddAssemblySearchFolder(Expression<Func<AddAssemblySearchFolderInput>> addAssemblySearchFolder)
        {
            var __workflow_addAssemblySearchFolder = WorkflowExpression.Compile(addAssemblySearchFolder, nameof(addAssemblySearchFolder), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addAssemblySearchFolder);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ClearAssemblySearchFolders(Expression<Func<ClearAssemblySearchFoldersInput>> clearAssemblySearchFolders)
        {
            var __workflow_clearAssemblySearchFolders = WorkflowExpression.Compile(clearAssemblySearchFolders, nameof(clearAssemblySearchFolders), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_clearAssemblySearchFolders);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse, ApiConnectionActionConfiguration> IsPowerShellAutomationInstalled(Expression<Func<IsPowerShellAutomationInstalledInput>> isPowerShellAutomationInstalled)
        {
            var __workflow_isPowerShellAutomationInstalled = WorkflowExpression.Compile(isPowerShellAutomationInstalled, nameof(isPowerShellAutomationInstalled), required: true);
            return new DeferredBodyAction<IsPowerShellAutomationInstalledResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isPowerShellAutomationInstalled);
                return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse, ApiConnectionActionConfiguration> IsPowerShellModuleInstalled(Expression<Func<IsPowerShellModuleInstalledInput>> isPowerShellModuleInstalled)
        {
            var __workflow_isPowerShellModuleInstalled = WorkflowExpression.Compile(isPowerShellModuleInstalled, nameof(isPowerShellModuleInstalled), required: true);
            return new DeferredBodyAction<IsPowerShellModuleInstalledResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isPowerShellModuleInstalled);
                return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunPowerShellAutomationScript(Expression<Func<RunPowerShellAutomationScriptInput>> runPowerShellAutomationScript)
        {
            var __workflow_runPowerShellAutomationScript = WorkflowExpression.Compile(runPowerShellAutomationScript, nameof(runPowerShellAutomationScript), required: true);
            return new DeferredBodyAction<RunPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScript);
                return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetPowerShellVersionResponse, ApiConnectionActionConfiguration> GetPowerShellVersion(Expression<Func<GetPowerShellVersionInput>> getPowerShellVersion)
        {
            var __workflow_getPowerShellVersion = WorkflowExpression.Compile(getPowerShellVersion, nameof(getPowerShellVersion), required: true);
            return new DeferredBodyAction<GetPowerShellVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getPowerShellVersion);
                return new ApiConnectionAction<GetPowerShellVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchResponse, ApiConnectionActionConfiguration> GetRegexMatch(Expression<Func<GetRegexMatchInput>> getRegexMatch)
        {
            var __workflow_getRegexMatch = WorkflowExpression.Compile(getRegexMatch, nameof(getRegexMatch), required: true);
            return new DeferredBodyAction<GetRegexMatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRegexMatch);
                return new ApiConnectionAction<GetRegexMatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchesResponse, ApiConnectionActionConfiguration> GetRegexMatches(Expression<Func<GetRegexMatchesInput>> getRegexMatches)
        {
            var __workflow_getRegexMatches = WorkflowExpression.Compile(getRegexMatches, nameof(getRegexMatches), required: true);
            return new DeferredBodyAction<GetRegexMatchesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRegexMatches);
                return new ApiConnectionAction<GetRegexMatchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexSplitResponse, ApiConnectionActionConfiguration> GetRegexSplit(Expression<Func<GetRegexSplitInput>> getRegexSplit)
        {
            var __workflow_getRegexSplit = WorkflowExpression.Compile(getRegexSplit, nameof(getRegexSplit), required: true);
            return new DeferredBodyAction<GetRegexSplitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRegexSplit);
                return new ApiConnectionAction<GetRegexSplitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse, ApiConnectionActionConfiguration> GetRegexGroupMatches(Expression<Func<GetRegexGroupMatchesInput>> getRegexGroupMatches)
        {
            var __workflow_getRegexGroupMatches = WorkflowExpression.Compile(getRegexGroupMatches, nameof(getRegexGroupMatches), required: true);
            return new DeferredBodyAction<GetRegexGroupMatchesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatches);
                return new ApiConnectionAction<GetRegexGroupMatchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<CreateJsonFromInputVariablesResponse, ApiConnectionActionConfiguration> CreateJsonFromInputVariables(Expression<Func<CreateJsonFromInputVariablesInput>> createJsonFromInputVariables)
        {
            var __workflow_createJsonFromInputVariables = WorkflowExpression.Compile(createJsonFromInputVariables, nameof(createJsonFromInputVariables), required: true);
            return new DeferredBodyAction<CreateJsonFromInputVariablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createJsonFromInputVariables);
                return new ApiConnectionAction<CreateJsonFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetJsonTableFromStringArrayResponse, ApiConnectionActionConfiguration> GetJsonTableFromStringArray(Expression<Func<GetJsonTableFromStringArrayInput>> getJsonTableFromStringArray)
        {
            var __workflow_getJsonTableFromStringArray = WorkflowExpression.Compile(getJsonTableFromStringArray, nameof(getJsonTableFromStringArray), required: true);
            return new DeferredBodyAction<GetJsonTableFromStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getJsonTableFromStringArray);
                return new ApiConnectionAction<GetJsonTableFromStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterJsonTableResponse, ApiConnectionActionConfiguration> FilterJsonTable(Expression<Func<FilterJsonTableInput>> filterJsonTable)
        {
            var __workflow_filterJsonTable = WorkflowExpression.Compile(filterJsonTable, nameof(filterJsonTable), required: true);
            return new DeferredBodyAction<FilterJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_filterJsonTable);
                return new ApiConnectionAction<FilterJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterTableResponse, ApiConnectionActionConfiguration> FilterTable(Expression<Func<FilterTableInput>> filterTable)
        {
            var __workflow_filterTable = WorkflowExpression.Compile(filterTable, nameof(filterTable), required: true);
            return new DeferredBodyAction<FilterTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_filterTable);
                return new ApiConnectionAction<FilterTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortTableResponse, ApiConnectionActionConfiguration> SortTable(Expression<Func<SortTableInput>> sortTable)
        {
            var __workflow_sortTable = WorkflowExpression.Compile(sortTable, nameof(sortTable), required: true);
            return new DeferredBodyAction<SortTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/SortTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sortTable);
                return new ApiConnectionAction<SortTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortJsonTableResponse, ApiConnectionActionConfiguration> SortJsonTable(Expression<Func<SortJsonTableInput>> sortJsonTable)
        {
            var __workflow_sortJsonTable = WorkflowExpression.Compile(sortJsonTable, nameof(sortJsonTable), required: true);
            return new DeferredBodyAction<SortJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/SortJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sortJsonTable);
                return new ApiConnectionAction<SortJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse, ApiConnectionActionConfiguration> GetTableFromStringArray(Expression<Func<GetTableFromStringArrayInput>> getTableFromStringArray)
        {
            var __workflow_getTableFromStringArray = WorkflowExpression.Compile(getTableFromStringArray, nameof(getTableFromStringArray), required: true);
            return new DeferredBodyAction<GetTableFromStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getTableFromStringArray);
                return new ApiConnectionAction<GetTableFromStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromJsonResponse, ApiConnectionActionConfiguration> GetTableFromJson(Expression<Func<GetTableFromJsonInput>> getTableFromJson)
        {
            var __workflow_getTableFromJson = WorkflowExpression.Compile(getTableFromJson, nameof(getTableFromJson), required: true);
            return new DeferredBodyAction<GetTableFromJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getTableFromJson);
                return new ApiConnectionAction<GetTableFromJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortStringArrayResponse, ApiConnectionActionConfiguration> SortStringArray(Expression<Func<SortStringArrayInput>> sortStringArray)
        {
            var __workflow_sortStringArray = WorkflowExpression.Compile(sortStringArray, nameof(sortStringArray), required: true);
            return new DeferredBodyAction<SortStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/SortStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sortStringArray);
                return new ApiConnectionAction<SortStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterStringArrayResponse, ApiConnectionActionConfiguration> FilterStringArray(Expression<Func<FilterStringArrayInput>> filterStringArray)
        {
            var __workflow_filterStringArray = WorkflowExpression.Compile(filterStringArray, nameof(filterStringArray), required: true);
            return new DeferredBodyAction<FilterStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_filterStringArray);
                return new ApiConnectionAction<FilterStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse, ApiConnectionActionConfiguration> InsertRowInStringArray(Expression<Func<InsertRowInStringArrayInput>> insertRowInStringArray)
        {
            var __workflow_insertRowInStringArray = WorkflowExpression.Compile(insertRowInStringArray, nameof(insertRowInStringArray), required: true);
            return new DeferredBodyAction<InsertRowInStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_insertRowInStringArray);
                return new ApiConnectionAction<InsertRowInStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInTableResponse, ApiConnectionActionConfiguration> InsertRowInTable(Expression<Func<InsertRowInTableInput>> insertRowInTable)
        {
            var __workflow_insertRowInTable = WorkflowExpression.Compile(insertRowInTable, nameof(insertRowInTable), required: true);
            return new DeferredBodyAction<InsertRowInTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_insertRowInTable);
                return new ApiConnectionAction<InsertRowInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJsonTableResponse, ApiConnectionActionConfiguration> InsertRowInJsonTable(Expression<Func<InsertRowInJsonTableInput>> insertRowInJsonTable)
        {
            var __workflow_insertRowInJsonTable = WorkflowExpression.Compile(insertRowInJsonTable, nameof(insertRowInJsonTable), required: true);
            return new DeferredBodyAction<InsertRowInJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_insertRowInJsonTable);
                return new ApiConnectionAction<InsertRowInJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJsonTableFromInputVariablesResponse, ApiConnectionActionConfiguration> InsertRowInJsonTableFromInputVariables(Expression<Func<InsertRowInJsonTableFromInputVariablesInput>> insertRowInJsonTableFromInputVariables)
        {
            var __workflow_insertRowInJsonTableFromInputVariables = WorkflowExpression.Compile(insertRowInJsonTableFromInputVariables, nameof(insertRowInJsonTableFromInputVariables), required: true);
            return new DeferredBodyAction<InsertRowInJsonTableFromInputVariablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_insertRowInJsonTableFromInputVariables);
                return new ApiConnectionAction<InsertRowInJsonTableFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse, ApiConnectionActionConfiguration> DeleteItemsInStringArray(Expression<Func<DeleteItemsInStringArrayInput>> deleteItemsInStringArray)
        {
            var __workflow_deleteItemsInStringArray = WorkflowExpression.Compile(deleteItemsInStringArray, nameof(deleteItemsInStringArray), required: true);
            return new DeferredBodyAction<DeleteItemsInStringArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteItemsInStringArray);
                return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInTableResponse, ApiConnectionActionConfiguration> DeleteRowsInTable(Expression<Func<DeleteRowsInTableInput>> deleteRowsInTable)
        {
            var __workflow_deleteRowsInTable = WorkflowExpression.Compile(deleteRowsInTable, nameof(deleteRowsInTable), required: true);
            return new DeferredBodyAction<DeleteRowsInTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteRowsInTable);
                return new ApiConnectionAction<DeleteRowsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInJsonTableResponse, ApiConnectionActionConfiguration> DeleteRowsInJsonTable(Expression<Func<DeleteRowsInJsonTableInput>> deleteRowsInJsonTable)
        {
            var __workflow_deleteRowsInJsonTable = WorkflowExpression.Compile(deleteRowsInJsonTable, nameof(deleteRowsInJsonTable), required: true);
            return new DeferredBodyAction<DeleteRowsInJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteRowsInJsonTable);
                return new ApiConnectionAction<DeleteRowsInJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInTableResponse, ApiConnectionActionConfiguration> RenameColumnInTable(Expression<Func<RenameColumnInTableInput>> renameColumnInTable)
        {
            var __workflow_renameColumnInTable = WorkflowExpression.Compile(renameColumnInTable, nameof(renameColumnInTable), required: true);
            return new DeferredBodyAction<RenameColumnInTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_renameColumnInTable);
                return new ApiConnectionAction<RenameColumnInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInJsonTableResponse, ApiConnectionActionConfiguration> RenameColumnInJsonTable(Expression<Func<RenameColumnInJsonTableInput>> renameColumnInJsonTable)
        {
            var __workflow_renameColumnInJsonTable = WorkflowExpression.Compile(renameColumnInJsonTable, nameof(renameColumnInJsonTable), required: true);
            return new DeferredBodyAction<RenameColumnInJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_renameColumnInJsonTable);
                return new ApiConnectionAction<RenameColumnInJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse, ApiConnectionActionConfiguration> DeleteColumnsInTable(Expression<Func<DeleteColumnsInTableInput>> deleteColumnsInTable)
        {
            var __workflow_deleteColumnsInTable = WorkflowExpression.Compile(deleteColumnsInTable, nameof(deleteColumnsInTable), required: true);
            return new DeferredBodyAction<DeleteColumnsInTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteColumnsInTable);
                return new ApiConnectionAction<DeleteColumnsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInJsonTableResponse, ApiConnectionActionConfiguration> DeleteColumnsInJsonTable(Expression<Func<DeleteColumnsInJsonTableInput>> deleteColumnsInJsonTable)
        {
            var __workflow_deleteColumnsInJsonTable = WorkflowExpression.Compile(deleteColumnsInJsonTable, nameof(deleteColumnsInJsonTable), required: true);
            return new DeferredBodyAction<DeleteColumnsInJsonTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteColumnsInJsonTable);
                return new ApiConnectionAction<DeleteColumnsInJsonTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse, ApiConnectionActionConfiguration> GetStringArrayFromTableColumn(Expression<Func<GetStringArrayFromTableColumnInput>> getStringArrayFromTableColumn)
        {
            var __workflow_getStringArrayFromTableColumn = WorkflowExpression.Compile(getStringArrayFromTableColumn, nameof(getStringArrayFromTableColumn), required: true);
            return new DeferredBodyAction<GetStringArrayFromTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getStringArrayFromTableColumn);
                return new ApiConnectionAction<GetStringArrayFromTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromJsonTableColumnResponse, ApiConnectionActionConfiguration> GetStringArrayFromJsonTableColumn(Expression<Func<GetStringArrayFromJsonTableColumnInput>> getStringArrayFromJsonTableColumn)
        {
            var __workflow_getStringArrayFromJsonTableColumn = WorkflowExpression.Compile(getStringArrayFromJsonTableColumn, nameof(getStringArrayFromJsonTableColumn), required: true);
            return new DeferredBodyAction<GetStringArrayFromJsonTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getStringArrayFromJsonTableColumn);
                return new ApiConnectionAction<GetStringArrayFromJsonTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringFromJsonTableCellResponse, ApiConnectionActionConfiguration> GetStringFromJsonTableCell(Expression<Func<GetStringFromJsonTableCellInput>> getStringFromJsonTableCell)
        {
            var __workflow_getStringFromJsonTableCell = WorkflowExpression.Compile(getStringFromJsonTableCell, nameof(getStringFromJsonTableCell), required: true);
            return new DeferredBodyAction<GetStringFromJsonTableCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getStringFromJsonTableCell);
                return new ApiConnectionAction<GetStringFromJsonTableCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringBetweenResponse, ApiConnectionActionConfiguration> GetStringBetween(Expression<Func<GetStringBetweenInput>> getStringBetween)
        {
            var __workflow_getStringBetween = WorkflowExpression.Compile(getStringBetween, nameof(getStringBetween), required: true);
            return new DeferredBodyAction<GetStringBetweenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringBetween";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getStringBetween);
                return new ApiConnectionAction<GetStringBetweenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse, ApiConnectionActionConfiguration> LoadIAConnectLookupTable(Expression<Func<LoadIAConnectLookupTableInput>> loadIAConnectLookupTable)
        {
            var __workflow_loadIAConnectLookupTable = WorkflowExpression.Compile(loadIAConnectLookupTable, nameof(loadIAConnectLookupTable), required: true);
            return new DeferredBodyAction<LoadIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_loadIAConnectLookupTable);
                return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse, ApiConnectionActionConfiguration> GetIAConnectLookupTableSummary(Expression<Func<GetIAConnectLookupTableSummaryInput>> getIAConnectLookupTableSummary)
        {
            var __workflow_getIAConnectLookupTableSummary = WorkflowExpression.Compile(getIAConnectLookupTableSummary, nameof(getIAConnectLookupTableSummary), required: true);
            return new DeferredBodyAction<GetIAConnectLookupTableSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectLookupTableSummary);
                return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse, ApiConnectionActionConfiguration> RemoveIAConnectLookupTable(Expression<Func<RemoveIAConnectLookupTableInput>> removeIAConnectLookupTable)
        {
            var __workflow_removeIAConnectLookupTable = WorkflowExpression.Compile(removeIAConnectLookupTable, nameof(removeIAConnectLookupTable), required: true);
            return new DeferredBodyAction<RemoveIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_removeIAConnectLookupTable);
                return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse, ApiConnectionActionConfiguration> RemoveAllIAConnectLookupTables(Expression<Func<RemoveAllIAConnectLookupTablesInput>> removeAllIAConnectLookupTables)
        {
            var __workflow_removeAllIAConnectLookupTables = WorkflowExpression.Compile(removeAllIAConnectLookupTables, nameof(removeAllIAConnectLookupTables), required: true);
            return new DeferredBodyAction<RemoveAllIAConnectLookupTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_removeAllIAConnectLookupTables);
                return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration> LookupValueFromIAConnectLookupTable(Expression<Func<LookupValueFromIAConnectLookupTableInput>> lookupValueFromIAConnectLookupTable)
        {
            var __workflow_lookupValueFromIAConnectLookupTable = WorkflowExpression.Compile(lookupValueFromIAConnectLookupTable, nameof(lookupValueFromIAConnectLookupTable), required: true);
            return new DeferredBodyAction<LookupValueFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTable);
                return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration> LookupColumnsFromIAConnectLookupTable(Expression<Func<LookupColumnsFromIAConnectLookupTableInput>> lookupColumnsFromIAConnectLookupTable)
        {
            var __workflow_lookupColumnsFromIAConnectLookupTable = WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTable, nameof(lookupColumnsFromIAConnectLookupTable), required: true);
            return new DeferredBodyAction<LookupColumnsFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTable);
                return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse, ApiConnectionActionConfiguration> RemoveCharactersFromString(Expression<Func<RemoveCharactersFromStringInput>> removeCharactersFromString)
        {
            var __workflow_removeCharactersFromString = WorkflowExpression.Compile(removeCharactersFromString, nameof(removeCharactersFromString), required: true);
            return new DeferredBodyAction<RemoveCharactersFromStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_removeCharactersFromString);
                return new ApiConnectionAction<RemoveCharactersFromStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse, ApiConnectionActionConfiguration> GetColumnFromIAConnectList(Expression<Func<GetColumnFromIAConnectListInput>> getColumnFromIAConnectList)
        {
            var __workflow_getColumnFromIAConnectList = WorkflowExpression.Compile(getColumnFromIAConnectList, nameof(getColumnFromIAConnectList), required: true);
            return new DeferredBodyAction<GetColumnFromIAConnectListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectList);
                return new ApiConnectionAction<GetColumnFromIAConnectListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse, ApiConnectionActionConfiguration> GetIAConnectListContents(Expression<Func<GetIAConnectListContentsInput>> getIAConnectListContents)
        {
            var __workflow_getIAConnectListContents = WorkflowExpression.Compile(getIAConnectListContents, nameof(getIAConnectListContents), required: true);
            return new DeferredBodyAction<GetIAConnectListContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectListContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectListContents);
                return new ApiConnectionAction<GetIAConnectListContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration> LookupDataCellsFromIAConnectLookupTable(Expression<Func<LookupDataCellsFromIAConnectLookupTableInput>> lookupDataCellsFromIAConnectLookupTable)
        {
            var __workflow_lookupDataCellsFromIAConnectLookupTable = WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTable, nameof(lookupDataCellsFromIAConnectLookupTable), required: true);
            return new DeferredBodyAction<LookupDataCellsFromIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTable);
                return new ApiConnectionAction<LookupDataCellsFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse, ApiConnectionActionConfiguration> GetIAConnectLookupTableContents(Expression<Func<GetIAConnectLookupTableContentsInput>> getIAConnectLookupTableContents)
        {
            var __workflow_getIAConnectLookupTableContents = WorkflowExpression.Compile(getIAConnectLookupTableContents, nameof(getIAConnectLookupTableContents), required: true);
            return new DeferredBodyAction<GetIAConnectLookupTableContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectLookupTableContents);
                return new ApiConnectionAction<GetIAConnectLookupTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCsvToIAConnectLookupTableResponse, ApiConnectionActionConfiguration> UploadCsvToIAConnectLookupTable(Expression<Func<UploadCsvToIAConnectLookupTableInput>> uploadCsvToIAConnectLookupTable)
        {
            var __workflow_uploadCsvToIAConnectLookupTable = WorkflowExpression.Compile(uploadCsvToIAConnectLookupTable, nameof(uploadCsvToIAConnectLookupTable), required: true);
            return new DeferredBodyAction<UploadCsvToIAConnectLookupTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uploadCsvToIAConnectLookupTable);
                return new ApiConnectionAction<UploadCsvToIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCsvToIAConnectListResponse, ApiConnectionActionConfiguration> UploadCsvToIAConnectList(Expression<Func<UploadCsvToIAConnectListInput>> uploadCsvToIAConnectList)
        {
            var __workflow_uploadCsvToIAConnectList = WorkflowExpression.Compile(uploadCsvToIAConnectList, nameof(uploadCsvToIAConnectList), required: true);
            return new DeferredBodyAction<UploadCsvToIAConnectListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uploadCsvToIAConnectList);
                return new ApiConnectionAction<UploadCsvToIAConnectListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<ConvertArrayToJsonResponse, ApiConnectionActionConfiguration> ConvertArrayToJson(Expression<Func<ConvertArrayToJsonInput>> convertArrayToJson)
        {
            var __workflow_convertArrayToJson = WorkflowExpression.Compile(convertArrayToJson, nameof(convertArrayToJson), required: true);
            return new DeferredBodyAction<ConvertArrayToJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_convertArrayToJson);
                return new ApiConnectionAction<ConvertArrayToJsonResponse>(callPayload);
            });
        }
    }

    public class IaconnectdynamiccodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImportAssemblyFromLocalFileInput
    {
        public ImportAssemblyFromLocalFileInput(string localAssemblyFilePath, string assemblyName)
        {
            this.LocalAssemblyFilePath = localAssemblyFilePath;
            this.AssemblyName = assemblyName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocalAssemblyFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssemblyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AddAssemblySearchFolderInput
    {
        public AddAssemblySearchFolderInput(string folderPath)
        {
            this.FolderPath = folderPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ClearAssemblySearchFoldersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsPowerShellAutomationInstalledResponse
    {
        public bool PowerShellAutomationIsInstalled { get; set; }
    }

    public class IsPowerShellAutomationInstalledInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsPowerShellModuleInstalledResponse
    {
        public bool PowerShellModuleIsInstalled { get; set; }
    }

    public class IsPowerShellModuleInstalledInput
    {
        public IsPowerShellModuleInstalledInput(string powerShellModuleName)
        {
            this.PowerShellModuleName = powerShellModuleName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PowerShellModuleName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunPowerShellAutomationScriptResponse
    {
        [JsonProperty("PowerShellJSONOutput")]
        public string PowerShellJsonOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class RunPowerShellAutomationScriptInput
    {
        public string PowerShellScriptContents { get; set; }
        public string ComputerName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsNoResultAnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnComplexTypes { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBooleanAsBoolean { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNumericAsDecimal { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDateAsDate { get; set; } = false;

        [JsonProperty("PropertiesToReturnAsCollectionJSON")]
        public string PropertiesToReturnAsCollectionJson { get; set; }
        public RunPowerShellAutomationScriptInputAuthenticationMechanismType? AuthenticationMechanism { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ConnectionAttempts { get; set; } = 1;

        [JsonProperty("Username")]
        public string UserName { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunScriptAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScriptContainsStoredPassword { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogVerboseOutput { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnSecureStrings { get; set; } = false;

        [JsonProperty("PropertyNamesToSerializeJSON")]
        public string PropertyNamesToSerializeJson { get; set; }

        [JsonProperty("PropertyTypesToSerializeJSON")]
        public string PropertyTypesToSerializeJson { get; set; }
        public RunPowerShellAutomationScriptInputPowerShellCommandParametersTypeItem[] PowerShellCommandParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunPowerShellAutomationScriptInputAuthenticationMechanismType
    {
        Basic,
        Credssp,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public class RunPowerShellAutomationScriptInputPowerShellCommandParametersTypeItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public bool? BooleanValue { get; set; }
        public double? DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class GetPowerShellVersionResponse
    {
        public int PowerShellMajorVersion { get; set; }
        public int PowerShellMinorVersion { get; set; }
    }

    public class GetPowerShellVersionInput
    {
        public string ComputerName { get; set; }
        public GetPowerShellVersionInputAuthenticationMechanismType? AuthenticationMechanism { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ConnectionAttempts { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetPowerShellVersionInputAuthenticationMechanismType
    {
        Basic,
        Credssp,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public class GetRegexMatchResponse
    {
        public bool SuccessfulMatch { get; set; }
        public string MatchStringValue { get; set; }
        public int MatchIndex { get; set; }
        public int MatchStringLength { get; set; }
    }

    public class GetRegexMatchInput
    {
        public GetRegexMatchInput(string textToMatch, string regex)
        {
            this.TextToMatch = textToMatch;
            this.Regex = regex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextToMatch { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Regex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RegexTimeoutInSeconds { get; set; } = 10;
    }

    public class GetRegexMatchesResponse
    {
        public JToken[] OutputArray { get; set; }
        public int NumberOfElementsInOutput { get; set; }
    }

    public class GetRegexMatchesInput
    {
        public GetRegexMatchesInput(string textToMatch, string regex)
        {
            this.TextToMatch = textToMatch;
            this.Regex = regex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextToMatch { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Regex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumMatches { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrimResults { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyResults { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RegexTimeoutInSeconds { get; set; } = 10;
    }

    public class GetRegexSplitResponse
    {
        public JToken[] OutputArray { get; set; }
        public int NumberOfElementsInOutput { get; set; }
    }

    public class GetRegexSplitInput
    {
        public GetRegexSplitInput(string textToSplit, string regex)
        {
            this.TextToSplit = textToSplit;
            this.Regex = regex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextToSplit { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Regex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrimResults { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyResults { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RegexTimeoutInSeconds { get; set; } = 10;
    }

    public class GetRegexGroupMatchesResponse
    {
        public GetRegexGroupMatchesResponseRegexGroupsTypeItem[] RegexGroups { get; set; }
        public int NumberOfRegexGroups { get; set; }
    }

    public class GetRegexGroupMatchesResponseRegexGroupsTypeItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class GetRegexGroupMatchesInput
    {
        public GetRegexGroupMatchesInput(string textToMatch, string regex)
        {
            this.TextToMatch = textToMatch;
            this.Regex = regex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextToMatch { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Regex { get; set; }
        public string[] GroupsToRetrieve { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RegexTimeoutInSeconds { get; set; } = 10;
    }

    public class CreateJsonFromInputVariablesResponse
    {
        [JsonProperty("OutputJSON")]
        public string OutputJson { get; set; }
    }

    public class CreateJsonFromInputVariablesInput
    {
        public CreateJsonFromInputVariablesInput(CreateJsonFromInputVariablesInputInputVariablesTypeItem[] inputVariables)
        {
            this.InputVariables = inputVariables;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateJsonFromInputVariablesInputInputVariablesTypeItem[] InputVariables { get; set; }

        [JsonProperty("ReturnAsJSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ReturnAsJsonTable { get; set; } = true;
    }

    public class CreateJsonFromInputVariablesInputInputVariablesTypeItem
    {
        public string PropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateJsonFromInputVariablesInputInputVariablesTypeItemDataTypeType? DataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.CreateJsonFromInputVariablesInputInputVariablesTypeItemDataTypeType.String;
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateJsonFromInputVariablesInputInputVariablesTypeItemDataTypeType
    {
        String,
        Integer,
        Float,
        Boolean
    }

    public class GetJsonTableFromStringArrayResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetJsonTableFromStringArrayInput
    {
        public GetJsonTableFromStringArrayInput(string[] inputArray, string columnName)
        {
            this.InputArray = inputArray;
            this.ColumnName = columnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DropEmptyItems { get; set; } = false;
    }

    public class FilterJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class FilterJsonTableInput
    {
        public FilterJsonTableInput(string jsonTable, string filter)
        {
            this.JsonTable = jsonTable;
            this.Filter = filter;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filter { get; set; }
        public string SortColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending { get; set; } = true;
        public string SortColumnName2 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending2 { get; set; } = true;
        public string SortColumnName3 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending3 { get; set; } = true;
    }

    public class FilterTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class FilterTableInput
    {
        public FilterTableInput(JToken[] inputTable, string filter)
        {
            this.InputTable = inputTable;
            this.Filter = filter;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filter { get; set; }
        public string SortColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending { get; set; } = true;
        public string SortColumnName2 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending2 { get; set; } = true;
        public string SortColumnName3 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending3 { get; set; } = true;
    }

    public class SortTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class SortTableInput
    {
        public SortTableInput(JToken[] inputTable, string sortColumnName)
        {
            this.InputTable = inputTable;
            this.SortColumnName = sortColumnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SortColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Ascending { get; set; } = true;
        public string SortColumnName2 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending2 { get; set; } = true;
        public string SortColumnName3 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending3 { get; set; } = true;
    }

    public class SortJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class SortJsonTableInput
    {
        public SortJsonTableInput(string jsonTable, string sortColumnName)
        {
            this.JsonTable = jsonTable;
            this.SortColumnName = sortColumnName;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SortColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending { get; set; } = true;
        public string SortColumnName2 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending2 { get; set; } = true;
        public string SortColumnName3 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending3 { get; set; } = true;
    }

    public class GetTableFromStringArrayResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetTableFromStringArrayInput
    {
        public GetTableFromStringArrayInput(string[] inputArray, string columnName)
        {
            this.InputArray = inputArray;
            this.ColumnName = columnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DropEmptyItems { get; set; } = false;
    }

    public class GetTableFromJsonResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetTableFromJsonInput
    {
        public GetTableFromJsonInput(string jsonTable)
        {
            this.JsonTable = jsonTable;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartRowIndex { get; set; } = 1;
        public int? NumberOfRowsToRetrieve { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? StartColumnIndex { get; set; } = 1;
        public string StartColumnName { get; set; }
        public int? NumberOfColumnsToRetrieve { get; set; }
    }

    public class SortStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class SortStringArrayInput
    {
        public SortStringArrayInput(string[] inputArray)
        {
            this.InputArray = inputArray;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ascending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;
    }

    public class FilterStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class FilterStringArrayInput
    {
        public FilterStringArrayInput(string[] inputArray, string columnName, string filter)
        {
            this.InputArray = inputArray;
            this.ColumnName = columnName;
            this.Filter = filter;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filter { get; set; }
    }

    public class InsertRowInStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class InsertRowInStringArrayInput
    {
        public InsertRowInStringArrayInput(string[] inputArray, int rowIndex)
        {
            this.InputArray = inputArray;
            this.RowIndex = rowIndex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; }
        public string ValueToInsert { get; set; }
    }

    public class InsertRowInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class InsertRowInTableInput
    {
        public InsertRowInTableInput(JToken[] inputTable, int rowIndex)
        {
            this.InputTable = inputTable;
            this.RowIndex = rowIndex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; }

        [JsonProperty("RowToInsertJSON")]
        public string RowToInsertJson { get; set; }
    }

    public class InsertRowInJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class InsertRowInJsonTableInput
    {
        public InsertRowInJsonTableInput(string jsonTable, int rowIndex)
        {
            this.JsonTable = jsonTable;
            this.RowIndex = rowIndex;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; }

        [JsonProperty("RowToInsertJSON")]
        public string RowToInsertJson { get; set; }
    }

    public class InsertRowInJsonTableFromInputVariablesResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class InsertRowInJsonTableFromInputVariablesInput
    {
        public InsertRowInJsonTableFromInputVariablesInput(string jsonTable, int rowIndex, InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItem[] rowToInsertInputVariables)
        {
            this.JsonTable = jsonTable;
            this.RowIndex = rowIndex;
            this.RowToInsertInputVariables = rowToInsertInputVariables;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItem[] RowToInsertInputVariables { get; set; }
    }

    public class InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItem
    {
        public string PropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItemDataTypeType? DataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItemDataTypeType.String;
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InsertRowInJsonTableFromInputVariablesInputRowToInsertInputVariablesTypeItemDataTypeType
    {
        String,
        Integer,
        Float,
        Boolean
    }

    public class DeleteItemsInStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class DeleteItemsInStringArrayInput
    {
        public DeleteItemsInStringArrayInput(string[] inputArray, int startItemIndex)
        {
            this.InputArray = inputArray;
            this.StartItemIndex = startItemIndex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] InputArray { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartItemIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfItemsToDelete { get; set; } = 1;
    }

    public class DeleteRowsInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteRowsInTableInput
    {
        public DeleteRowsInTableInput(JToken[] inputTable, int startRowIndex)
        {
            this.InputTable = inputTable;
            this.StartRowIndex = startRowIndex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfRowsToDelete { get; set; } = 1;
    }

    public class DeleteRowsInJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteRowsInJsonTableInput
    {
        public DeleteRowsInJsonTableInput(string jsonTable, int startRowIndex)
        {
            this.JsonTable = jsonTable;
            this.StartRowIndex = startRowIndex;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfRowsToDelete { get; set; } = 1;
    }

    public class RenameColumnInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class RenameColumnInTableInput
    {
        public RenameColumnInTableInput(JToken[] inputTable, string sourceColumnName, string newColumnName)
        {
            this.InputTable = inputTable;
            this.SourceColumnName = sourceColumnName;
            this.NewColumnName = newColumnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewColumnName { get; set; }
    }

    public class RenameColumnInJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class RenameColumnInJsonTableInput
    {
        public RenameColumnInJsonTableInput(string jsonTable, string sourceColumnName, string newColumnName)
        {
            this.JsonTable = jsonTable;
            this.SourceColumnName = sourceColumnName;
            this.NewColumnName = newColumnName;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewColumnName { get; set; }
    }

    public class DeleteColumnsInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteColumnsInTableInput
    {
        public DeleteColumnsInTableInput(JToken[] inputTable)
        {
            this.InputTable = inputTable;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }
        public int? StartColumnIndex { get; set; }
        public string ColumnNameToDelete { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfColumnsToDelete { get; set; } = 1;
    }

    public class DeleteColumnsInJsonTableResponse
    {
        [JsonProperty("OutputJSONTable")]
        public string OutputJsonTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteColumnsInJsonTableInput
    {
        public DeleteColumnsInJsonTableInput(string jsonTable)
        {
            this.JsonTable = jsonTable;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }
        public int? StartColumnIndex { get; set; }
        public string ColumnNameToDelete { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfColumnsToDelete { get; set; } = 1;
    }

    public class GetStringArrayFromTableColumnResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class GetStringArrayFromTableColumnInput
    {
        public GetStringArrayFromTableColumnInput(JToken[] inputTable)
        {
            this.InputTable = inputTable;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputTable { get; set; }
        public int? ColumnIndex { get; set; }
        public string ColumnName { get; set; }
    }

    public class GetStringArrayFromJsonTableColumnResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class GetStringArrayFromJsonTableColumnInput
    {
        public GetStringArrayFromJsonTableColumnInput(string jsonTable)
        {
            this.JsonTable = jsonTable;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }
        public int? ColumnIndex { get; set; }
        public string ColumnName { get; set; }
    }

    public class GetStringFromJsonTableCellResponse
    {
        public string OutputString { get; set; }
    }

    public class GetStringFromJsonTableCellInput
    {
        public GetStringFromJsonTableCellInput(string jsonTable)
        {
            this.JsonTable = jsonTable;
        }

        [JsonProperty("JSONTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JsonTable { get; set; }
        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
        public string ColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FallBackIfCellDoesNotExist { get; set; } = false;
        public string FallbackValue { get; set; }
    }

    public class GetStringBetweenResponse
    {
        public bool SearchStringFound { get; set; }
        public string StringBetween { get; set; }
    }

    public class GetStringBetweenInput
    {
        public string InputString { get; set; }
        public string StartSearchString { get; set; }
        public string EndSearchString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchLineByLine { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ThrowExceptionIfNotFound { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrimResult { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;
    }

    public class LoadIAConnectLookupTableResponse
    {
        public int NumberOfLookupTablesLoaded { get; set; }
        public int NumberOfLookupTablesFailedToLoad { get; set; }
    }

    public class LoadIAConnectLookupTableInput
    {
        public LoadIAConnectLookupTableInput(string path)
        {
            this.Path = path;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RaiseExceptionIfAnyTableFailsToLoad { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetIAConnectLookupTableSummaryResponse
    {
        [JsonProperty("LookupTablesJSON")]
        public GetIAConnectLookupTableSummaryResponseLookupTablesJsonTypeItem[] LookupTablesJson { get; set; }
        public int NumberOfLookupTables { get; set; }
    }

    public class GetIAConnectLookupTableSummaryResponseLookupTablesJsonTypeItem
    {
        public string Name { get; set; }
        public int ThenColumnIndex { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfUniqueHeaderProperties { get; set; }
    }

    public class GetIAConnectLookupTableSummaryInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RemoveIAConnectLookupTableResponse
    {
        public bool RemoveIAConnectLookupTableResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RemoveIAConnectLookupTableInput
    {
        public RemoveIAConnectLookupTableInput(string lookupTableName)
        {
            this.LookupTableName = lookupTableName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RemoveAllIAConnectLookupTablesResponse
    {
        public bool RemoveAllIAConnectLookupTablesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RemoveAllIAConnectLookupTablesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LookupValueFromIAConnectLookupTableResponse
    {
        public string OutputLookupValue { get; set; }
    }

    public class LookupValueFromIAConnectLookupTableInput
    {
        public LookupValueFromIAConnectLookupTableInput(string lookupTableName, string searchResultValueColumnName)
        {
            this.LookupTableName = lookupTableName;
            this.SearchResultValueColumnName = searchResultValueColumnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty("InputDataJSON")]
        public string InputDataJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchResultValueColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchResultValueColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfNoMatch { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LookupColumnsFromIAConnectLookupTableResponse
    {
        [JsonProperty("OutputLookupTableJSON")]
        public string OutputLookupTableJson { get; set; }
        public JToken[] OutputLookupTable { get; set; }
        public JToken[] OutputLookupArray { get; set; }
        public int NumberOfRowsInOutput { get; set; }
    }

    public class LookupColumnsFromIAConnectLookupTableInput
    {
        public LookupColumnsFromIAConnectLookupTableInput(string lookupTableName, string searchResultTableColumnName)
        {
            this.LookupTableName = lookupTableName;
            this.SearchResultTableColumnName = searchResultTableColumnName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty("InputDataJSON")]
        public string InputDataJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchResultTableColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfNoMatch { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBlankCells { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public LookupColumnsFromIAConnectLookupTableInputReturnFormatType? ReturnFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.LookupColumnsFromIAConnectLookupTableInputReturnFormatType.Json;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LookupColumnsFromIAConnectLookupTableInputReturnFormatType
    {
        [EnumMember(Value = "JSON")]
        Json,
        Array,
        Table
    }

    public class RemoveCharactersFromStringResponse
    {
        public string OutputString { get; set; }
    }

    public class RemoveCharactersFromStringInput
    {
        public string InputString { get; set; }
        public string CharactersToRemoveFromInputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveDiacriticsFromInputString { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveNonAlphaNumericFromInputString { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveNumericFromInputString { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveLowercaseCharactersFromInputString { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveUppercaseCharactersFromInputString { get; set; } = false;
    }

    public class GetColumnFromIAConnectListResponse
    {
        [JsonProperty("OutputListJSON")]
        public string OutputListJson { get; set; }
        public JToken[] OutputList { get; set; }
        public JToken[] OutputListArray { get; set; }
        public int NumberOfRowsInOutput { get; set; }
    }

    public class GetColumnFromIAConnectListInput
    {
        public GetColumnFromIAConnectListInput(string listName)
        {
            this.ListName = listName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchColumnIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBlankCells { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FallBackIfListDoesNotExist { get; set; } = false;
        public string FallbackValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GetColumnFromIAConnectListInputReturnFormatType? ReturnFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.GetColumnFromIAConnectListInputReturnFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetColumnFromIAConnectListInputReturnFormatType
    {
        [EnumMember(Value = "JSON")]
        Json,
        Array,
        Table
    }

    public class GetIAConnectListContentsResponse
    {
        [JsonProperty("OutputListJSON")]
        public string OutputListJson { get; set; }
        public JToken[] OutputList { get; set; }

        [JsonProperty("OutputListCSV")]
        public string OutputListCsv { get; set; }
        public int NumberOfRowsInOutput { get; set; }
        public int NumberOfColumnsInOutput { get; set; }
    }

    public class GetIAConnectListContentsInput
    {
        public GetIAConnectListContentsInput(string listName)
        {
            this.ListName = listName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIAConnectListContentsInputReturnFormatType? ReturnFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.GetIAConnectListContentsInputReturnFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetIAConnectListContentsInputReturnFormatType
    {
        [EnumMember(Value = "JSON")]
        Json,
        Table,
        [EnumMember(Value = "CSV")]
        Csv
    }

    public class LookupDataCellsFromIAConnectLookupTableResponse
    {
        [JsonProperty("OutputLookupTableJSON")]
        public string OutputLookupTableJson { get; set; }
        public JToken[] OutputLookupTable { get; set; }
        public int NumberOfCellsInOutput { get; set; }
    }

    public class LookupDataCellsFromIAConnectLookupTableInput
    {
        public LookupDataCellsFromIAConnectLookupTableInput(string lookupTableName)
        {
            this.LookupTableName = lookupTableName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty("InputDataJSON")]
        public string InputDataJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfNoMatch { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBlankCells { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public LookupDataCellsFromIAConnectLookupTableInputReturnFormatType? ReturnFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.LookupDataCellsFromIAConnectLookupTableInputReturnFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LookupDataCellsFromIAConnectLookupTableInputReturnFormatType
    {
        [EnumMember(Value = "JSON")]
        Json,
        Table
    }

    public class GetIAConnectLookupTableContentsResponse
    {
        [JsonProperty("OutputLookupTableJSON")]
        public string OutputLookupTableJson { get; set; }
        public JToken[] OutputLookupTable { get; set; }

        [JsonProperty("OutputLookupTableCSV")]
        public string OutputLookupTableCsv { get; set; }
        public int NumberOfRowsInOutput { get; set; }
        public int NumberOfColumnsInOutput { get; set; }
    }

    public class GetIAConnectLookupTableContentsInput
    {
        public GetIAConnectLookupTableContentsInput(string lookupTableName)
        {
            this.LookupTableName = lookupTableName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIAConnectLookupTableContentsInputReturnFormatType? ReturnFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode.GetIAConnectLookupTableContentsInputReturnFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetIAConnectLookupTableContentsInputReturnFormatType
    {
        [EnumMember(Value = "JSON")]
        Json,
        Table,
        [EnumMember(Value = "CSV")]
        Csv
    }

    public class UploadCsvToIAConnectLookupTableResponse
    {
        [JsonProperty("UploadCSVToIAConnectLookupTableResult")]
        public bool UploadCsvToIAConnectLookupTableResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UploadCsvToIAConnectLookupTableInput
    {
        public UploadCsvToIAConnectLookupTableInput(string lookupTableName, string csvData)
        {
            this.LookupTableName = lookupTableName;
            this.CsvData = csvData;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupTableName { get; set; }

        [JsonProperty("CSVData", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CsvData { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateLookupTableIfNotExist { get; set; } = false;
    }

    public class UploadCsvToIAConnectListResponse
    {
        [JsonProperty("UploadCSVToIAConnectListResult")]
        public bool UploadCsvToIAConnectListResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UploadCsvToIAConnectListInput
    {
        public UploadCsvToIAConnectListInput(string listName, string csvData)
        {
            this.ListName = listName;
            this.CsvData = csvData;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty("CSVData", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CsvData { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateListIfNotExist { get; set; } = false;
    }

    public class ConvertArrayToJsonResponse
    {
        [JsonProperty("OutputJSON")]
        public string OutputJson { get; set; }
    }

    public class ConvertArrayToJsonInput
    {
        public ConvertArrayToJsonInput(JToken[] inputObject)
        {
            this.InputObject = inputObject;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] InputObject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode;

    public partial class WorkflowManagedActions
    {
        public IaconnectdynamiccodeActions Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectdynamiccodeTriggers Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeTriggers(connectionId);
    }
}