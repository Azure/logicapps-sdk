//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Quickbaseip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QuickbaseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CreateAppResponse, ApiConnectionActionConfiguration> CreateApp(Expression<Func<CreateAppInput>> generated = null)
        {
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CreateAppResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/apps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CreateAppResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetAppResponse, ApiConnectionActionConfiguration> GetApp(Expression<Func<string>> appId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredBodyAction<GetAppResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/apps/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteAppResponse, ApiConnectionActionConfiguration> DeleteApp(Expression<Func<string>> appId, Expression<Func<DeleteAppInput>> generated = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<DeleteAppResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/apps/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<DeleteAppResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<UpdateAppResponse, ApiConnectionActionConfiguration> UpdateApp(Expression<Func<string>> appId, Expression<Func<UpdateAppInput>> generated = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<UpdateAppResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/apps/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<UpdateAppResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetAppEventsResponseItem[], ApiConnectionActionConfiguration> GetAppEvents(Expression<Func<string>> appId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredBodyAction<GetAppEventsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/apps/{0}/events", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppEventsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CopyAppResponse, ApiConnectionActionConfiguration> CopyApp(Expression<Func<string>> appId, Expression<Func<CopyAppInput>> generated = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CopyAppResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/apps/{0}/copy", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CopyAppResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetAppTablesResponseItem[], ApiConnectionActionConfiguration> GetAppTables(Expression<Func<string>> appId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredBodyAction<GetAppTablesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                return new ApiConnectionAction<GetAppTablesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CreateTableResponse, ApiConnectionActionConfiguration> CreateTable(Expression<Func<string>> appId, Expression<Func<CreateTableInput>> generated = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CreateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CreateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetTableResponse, ApiConnectionActionConfiguration> GetTable(Expression<Func<string>> appId, Expression<Func<string>> tableId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<GetTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteTableResponse, ApiConnectionActionConfiguration> DeleteTable(Expression<Func<string>> appId, Expression<Func<string>> tableId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<DeleteTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                return new ApiConnectionAction<DeleteTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<UpdateTableResponse, ApiConnectionActionConfiguration> UpdateTable(Expression<Func<string>> appId, Expression<Func<string>> tableId, Expression<Func<UpdateTableInput>> generated = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<UpdateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<UpdateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetRelationshipsResponse, ApiConnectionActionConfiguration> GetRelationships(Expression<Func<string>> tableId, Expression<Func<int>> skip = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<GetRelationshipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/relationships", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<GetRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CreateRelationshipResponse, ApiConnectionActionConfiguration> CreateRelationship(Expression<Func<string>> tableId, Expression<Func<CreateRelationshipInput>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CreateRelationshipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/relationship", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CreateRelationshipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteRelationshipResponse, ApiConnectionActionConfiguration> DeleteRelationship(Expression<Func<string>> tableId, Expression<Func<double>> relationshipId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            return new DeferredBodyAction<DeleteRelationshipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/relationship/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteRelationshipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<UpdateRelationshipResponse, ApiConnectionActionConfiguration> UpdateRelationship(Expression<Func<string>> tableId, Expression<Func<double>> relationshipId, Expression<Func<UpdateRelationshipInput>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<UpdateRelationshipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tables/{0}/relationship/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<UpdateRelationshipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetTableReportsResponseItem[], ApiConnectionActionConfiguration> GetTableReports(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<GetTableReportsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                return new ApiConnectionAction<GetTableReportsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetReportResponse, ApiConnectionActionConfiguration> GetReport(Expression<Func<string>> tableId, Expression<Func<string>> reportId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<GetReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reports/{0}", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                return new ApiConnectionAction<GetReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<RunReportResponse, ApiConnectionActionConfiguration> RunReport(Expression<Func<string>> tableId, Expression<Func<string>> reportId, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<object>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<RunReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reports/{0}/run", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<RunReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetFieldsResponseItem[], ApiConnectionActionConfiguration> GetFields(Expression<Func<string>> tableId, Expression<Func<bool>> includeFieldPerms = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_includeFieldPerms = WorkflowExpression.Compile(includeFieldPerms, nameof(includeFieldPerms), required: false);
            return new DeferredBodyAction<GetFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                callPayload.Queries["includeFieldPerms"] = Convert.ToString(false);
                if (__workflow_includeFieldPerms != null)
                    callPayload.Queries["includeFieldPerms"] = ExpressionConverter.Convert(__workflow_includeFieldPerms);
                return new ApiConnectionAction<GetFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteFieldsResponse, ApiConnectionActionConfiguration> DeleteFields(Expression<Func<string>> tableId, Expression<Func<DeleteFieldsInput>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<DeleteFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<DeleteFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CreateFieldResponse, ApiConnectionActionConfiguration> CreateField(Expression<Func<string>> tableId, Expression<Func<CreateFieldInput>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CreateFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CreateFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetFieldResponse, ApiConnectionActionConfiguration> GetField(Expression<Func<string>> tableId, Expression<Func<int>> fieldId, Expression<Func<bool>> includeFieldPerms = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_includeFieldPerms = WorkflowExpression.Compile(includeFieldPerms, nameof(includeFieldPerms), required: false);
            return new DeferredBodyAction<GetFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fields/{0}", __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                callPayload.Queries["includeFieldPerms"] = Convert.ToString(false);
                if (__workflow_includeFieldPerms != null)
                    callPayload.Queries["includeFieldPerms"] = ExpressionConverter.Convert(__workflow_includeFieldPerms);
                return new ApiConnectionAction<GetFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<UpdateFieldResponse, ApiConnectionActionConfiguration> UpdateField(Expression<Func<string>> tableId, Expression<Func<int>> fieldId, Expression<Func<UpdateFieldInput>> generated = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<UpdateFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fields/{0}", __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<UpdateFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetFieldsUsageResponseItem[], ApiConnectionActionConfiguration> GetFieldsUsage(Expression<Func<string>> tableId, Expression<Func<int>> skip = null, Expression<Func<int>> top = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetFieldsUsageResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields/usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetFieldsUsageResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetFieldUsageResponseItem[], ApiConnectionActionConfiguration> GetFieldUsage(Expression<Func<string>> tableId, Expression<Func<int>> fieldId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<GetFieldUsageResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fields/usage/{0}", __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tableId"] = ExpressionConverter.Convert(__workflow_tableId);
                return new ApiConnectionAction<GetFieldUsageResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<RunFormulaResponse, ApiConnectionActionConfiguration> RunFormula(Expression<Func<RunFormulaInput>> generated = null)
        {
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<RunFormulaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/formula/run";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<RunFormulaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteRecordsResponse, ApiConnectionActionConfiguration> DeleteRecords(Expression<Func<DeleteRecordsInput>> generated = null)
        {
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<DeleteRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/records";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<DeleteRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<RunQueryResponse, ApiConnectionActionConfiguration> RunQuery(Expression<Func<RunQueryInput>> generated = null)
        {
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<RunQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/records/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<RunQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<GetTempTokenDBIdResponse, ApiConnectionActionConfiguration> GetTempTokenDBId(Expression<Func<string>> dbid, Expression<Func<string>> qBAppToken = null)
        {
            var __workflow_dbid = WorkflowExpression.Compile(dbid, nameof(dbid), required: true);
            var __workflow_qBAppToken = WorkflowExpression.Compile(qBAppToken, nameof(qBAppToken), required: false);
            return new DeferredBodyAction<GetTempTokenDBIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/auth/temporary/{0}", __workflow_dbid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_qBAppToken != null)
                    callPayload.Headers["QB-App-Token"] = ExpressionConverter.Convert(__workflow_qBAppToken);
                return new ApiConnectionAction<GetTempTokenDBIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<CloneUserTokenResponse, ApiConnectionActionConfiguration> CloneUserToken(Expression<Func<CloneUserTokenInput>> generated = null)
        {
            var __workflow_generated = WorkflowExpression.Compile(generated, nameof(generated), required: false);
            return new DeferredBodyAction<CloneUserTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/usertoken/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_generated != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_generated);
                return new ApiConnectionAction<CloneUserTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeactivateUserTokenResponse, ApiConnectionActionConfiguration> DeactivateUserToken()
        {
            return new DeferredBodyAction<DeactivateUserTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/usertoken/deactivate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeactivateUserTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteUserTokenResponse, ApiConnectionActionConfiguration> DeleteUserToken()
        {
            return new DeferredBodyAction<DeleteUserTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/usertoken";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteUserTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<string>> tableId, Expression<Func<int>> recordId, Expression<Func<int>> fieldId, Expression<Func<int>> versionNumber)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_versionNumber = WorkflowExpression.Compile(versionNumber, nameof(versionNumber), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}/{1}/{2}/{3}", __workflow_tableId.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1), __workflow_versionNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickbaseip")]
        public IBodyWorkflowAction<DeleteFileResponse, ApiConnectionActionConfiguration> DeleteFile(Expression<Func<string>> tableId, Expression<Func<int>> recordId, Expression<Func<int>> fieldId, Expression<Func<int>> versionNumber)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_versionNumber = WorkflowExpression.Compile(versionNumber, nameof(versionNumber), required: true);
            return new DeferredBodyAction<DeleteFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}/{1}/{2}/{3}", __workflow_tableId.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1), __workflow_versionNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteFileResponse>(callPayload);
            });
        }
    }

    public class QuickbaseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateAppResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hasEveryoneOnTheInternet")]
        public bool HasEveryoneOnTheInternet { get; set; }

        [JsonProperty("variables")]
        public Variable1[] Variables { get; set; }

        [JsonProperty("dataClassification")]
        public string DataClassification { get; set; }
    }

    public class Variable1
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateAppInput
    {
        [JsonProperty("assignToken")]
        public bool? AssignToken { get; set; }

        [JsonProperty("variables")]
        public Variable[] Variables { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Variable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetAppResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hasEveryoneOnTheInternet")]
        public bool HasEveryoneOnTheInternet { get; set; }

        [JsonProperty("variables")]
        public Variable1[] Variables { get; set; }

        [JsonProperty("dataClassification")]
        public string DataClassification { get; set; }
    }

    public class DeleteAppResponse
    {
        [JsonProperty("deletedAppId")]
        public string DeletedAppId { get; set; }
    }

    public class DeleteAppInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class UpdateAppResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hasEveryoneOnTheInternet")]
        public bool HasEveryoneOnTheInternet { get; set; }

        [JsonProperty("variables")]
        public Variable1[] Variables { get; set; }

        [JsonProperty("dataClassification")]
        public string DataClassification { get; set; }
    }

    public class UpdateAppInput
    {
        [JsonProperty("variables")]
        public Variable[] Variables { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetAppEventsResponseItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("owner")]
        public GetAppEventsResponseItemOwnerType Owner { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("tableId")]
        public string TableId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAppEventsResponseItemOwnerType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }

    public class CopyAppResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hasEveryoneOnTheInternet")]
        public bool HasEveryoneOnTheInternet { get; set; }

        [JsonProperty("variables")]
        public Variable1[] Variables { get; set; }

        [JsonProperty("ancestorId")]
        public string AncestorId { get; set; }

        [JsonProperty("dataClassification")]
        public string DataClassification { get; set; }
    }

    public class CopyAppInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        [JsonProperty("assignUserToken")]
        public bool AssignUserToken { get; set; }

        [JsonProperty("excludeFiles")]
        public bool ExcludeFiles { get; set; }

        [JsonProperty("keepData")]
        public bool KeepData { get; set; }

        [JsonProperty("usersAndRoles")]
        public bool UsersAndRoles { get; set; }
    }

    public class GetAppTablesResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nextRecordId")]
        public int NextRecordId { get; set; }

        [JsonProperty("nextFieldId")]
        public int NextFieldId { get; set; }

        [JsonProperty("defaultSortFieldId")]
        public int DefaultSortFieldId { get; set; }

        [JsonProperty("defaultSortOrder")]
        public string DefaultSortOrder { get; set; }

        [JsonProperty("keyFieldId")]
        public int KeyFieldId { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("sizeLimit")]
        public string SizeLimit { get; set; }

        [JsonProperty("spaceUsed")]
        public string SpaceUsed { get; set; }

        [JsonProperty("spaceRemaining")]
        public string SpaceRemaining { get; set; }
    }

    public class CreateTableResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("nextRecordId")]
        public int NextRecordId { get; set; }

        [JsonProperty("nextFieldId")]
        public int NextFieldId { get; set; }

        [JsonProperty("defaultSortFieldId")]
        public int DefaultSortFieldId { get; set; }

        [JsonProperty("defaultSortOrder")]
        public DefaultSortOrder DefaultSortOrder { get; set; }

        [JsonProperty("keyFieldId")]
        public int KeyFieldId { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("sizeLimit")]
        public string SizeLimit { get; set; }

        [JsonProperty("spaceUsed")]
        public string SpaceUsed { get; set; }

        [JsonProperty("spaceRemaining")]
        public string SpaceRemaining { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DefaultSortOrder
    {
        ASC,
        DESC
    }

    public class CreateTableInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetTableResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("nextRecordId")]
        public int NextRecordId { get; set; }

        [JsonProperty("nextFieldId")]
        public int NextFieldId { get; set; }

        [JsonProperty("defaultSortFieldId")]
        public int DefaultSortFieldId { get; set; }

        [JsonProperty("defaultSortOrder")]
        public DefaultSortOrder DefaultSortOrder { get; set; }

        [JsonProperty("keyFieldId")]
        public int KeyFieldId { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("sizeLimit")]
        public string SizeLimit { get; set; }

        [JsonProperty("spaceUsed")]
        public string SpaceUsed { get; set; }

        [JsonProperty("spaceRemaining")]
        public string SpaceRemaining { get; set; }
    }

    public class DeleteTableResponse
    {
        [JsonProperty("deletedTableId")]
        public string DeletedTableId { get; set; }
    }

    public class UpdateTableResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("nextRecordId")]
        public int NextRecordId { get; set; }

        [JsonProperty("nextFieldId")]
        public int NextFieldId { get; set; }

        [JsonProperty("defaultSortFieldId")]
        public int DefaultSortFieldId { get; set; }

        [JsonProperty("defaultSortOrder")]
        public DefaultSortOrder DefaultSortOrder { get; set; }

        [JsonProperty("keyFieldId")]
        public int KeyFieldId { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("sizeLimit")]
        public string SizeLimit { get; set; }

        [JsonProperty("spaceUsed")]
        public string SpaceUsed { get; set; }

        [JsonProperty("spaceRemaining")]
        public string SpaceRemaining { get; set; }
    }

    public class UpdateTableInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pluralRecordName")]
        public string PluralRecordName { get; set; }

        [JsonProperty("singleRecordName")]
        public string SingleRecordName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetRelationshipsResponse
    {
        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class Relationship
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentTableId")]
        public string ParentTableId { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("foreignKeyField")]
        public ForeignKeyField ForeignKeyField { get; set; }

        [JsonProperty("isCrossApp")]
        public bool IsCrossApp { get; set; }

        [JsonProperty("lookupFields")]
        public LookupField[] LookupFields { get; set; }

        [JsonProperty("summaryFields")]
        public SummaryField[] SummaryFields { get; set; }
    }

    public class ForeignKeyField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class LookupField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SummaryField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("totalRelationships")]
        public int TotalRelationships { get; set; }

        [JsonProperty("numRelationships")]
        public int NumRelationships { get; set; }
    }

    public class CreateRelationshipResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentTableId")]
        public string ParentTableId { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("foreignKeyField")]
        public ForeignKeyField ForeignKeyField { get; set; }

        [JsonProperty("isCrossApp")]
        public bool IsCrossApp { get; set; }

        [JsonProperty("lookupFields")]
        public LookupField[] LookupFields { get; set; }

        [JsonProperty("summaryFields")]
        public SummaryField[] SummaryFields { get; set; }
    }

    public class CreateRelationshipInput
    {
        [JsonProperty("summaryFields")]
        public SummaryField1[] SummaryFields { get; set; }

        [JsonProperty("lookupFieldIds")]
        public int[] LookupFieldIds { get; set; }

        [JsonProperty("parentTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentTableId { get; set; }

        [JsonProperty("foreignKeyField")]
        public ForeignKeyField1 ForeignKeyField { get; set; }
    }

    public class SummaryField1
    {
        [JsonProperty("summaryFid")]
        public double SummaryFid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("accumulationType")]
        public AccumulationType AccumulationType { get; set; }

        [JsonProperty("where")]
        public string Where { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccumulationType
    {
        AVG,
        SUM,
        MAX,
        MIN,
        [EnumMember(Value = "STD-DEV")]
        STDDEV,
        COUNT,
        [EnumMember(Value = "COMBINED-TEXT")]
        COMBINEDTEXT,
        [EnumMember(Value = "DISTINCT-COUNT")]
        DISTINCTCOUNT
    }

    public class ForeignKeyField1
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class DeleteRelationshipResponse
    {
        [JsonProperty("relationshipId")]
        public int RelationshipId { get; set; }
    }

    public class UpdateRelationshipResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentTableId")]
        public string ParentTableId { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("foreignKeyField")]
        public ForeignKeyField ForeignKeyField { get; set; }

        [JsonProperty("isCrossApp")]
        public bool IsCrossApp { get; set; }

        [JsonProperty("lookupFields")]
        public LookupField[] LookupFields { get; set; }

        [JsonProperty("summaryFields")]
        public SummaryField[] SummaryFields { get; set; }
    }

    public class UpdateRelationshipInput
    {
        [JsonProperty("summaryFields")]
        public SummaryField1[] SummaryFields { get; set; }

        [JsonProperty("lookupFieldIds")]
        public int[] LookupFieldIds { get; set; }
    }

    public class GetTableReportsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("query")]
        public JToken Query { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("usedLast")]
        public string UsedLast { get; set; }

        [JsonProperty("usedCount")]
        public int UsedCount { get; set; }
    }

    public class GetReportResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("usedLast")]
        public string UsedLast { get; set; }

        [JsonProperty("usedCount")]
        public int UsedCount { get; set; }
    }

    public class Query
    {
        [JsonProperty("tableId")]
        public string TableId { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("formulaFields")]
        public FormulaField[] FormulaFields { get; set; }
    }

    public class FormulaField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("fieldType")]
        public FieldType FieldType { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("decimalPrecision")]
        public int DecimalPrecision { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldType
    {
        [EnumMember(Value = "rich-text")]
        RichText,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "numeric")]
        Numeric,
        [EnumMember(Value = "currency")]
        Currency,
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "timeofday")]
        Timeofday,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "multiuser")]
        Multiuser,
        [EnumMember(Value = "url")]
        Url
    }

    public class RunReportResponse
    {
        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata1 Metadata { get; set; }
    }

    public class Field
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("labelOverride")]
        public string LabelOverride { get; set; }
    }

    public class Metadata1
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("numFields")]
        public int NumFields { get; set; }

        [JsonProperty("top")]
        public int Top { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("numRecords")]
        public int NumRecords { get; set; }
    }

    public class GetFieldsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("noWrap")]
        public bool NoWrap { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool AppearsByDefault { get; set; }

        [JsonProperty("findEnabled")]
        public bool FindEnabled { get; set; }

        [JsonProperty("unique")]
        public bool Unique { get; set; }

        [JsonProperty("doesDataCopy")]
        public bool DoesDataCopy { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("audited")]
        public bool Audited { get; set; }

        [JsonProperty("properties")]
        public GetFieldsResponseItemPropertiesType Properties { get; set; }

        [JsonProperty("permissions")]
        public GetFieldsResponseItemPermissionsTypeItem[] Permissions { get; set; }

        [JsonProperty("addToForms")]
        public bool AddToForms { get; set; }
    }

    public class GetFieldsResponseItemPropertiesType
    {
        [JsonProperty("primaryKey")]
        public bool PrimaryKey { get; set; }

        [JsonProperty("foreignKey")]
        public bool ForeignKey { get; set; }

        [JsonProperty("numLines")]
        public int NumLines { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("appendOnly")]
        public bool AppendOnly { get; set; }

        [JsonProperty("allowHTML")]
        public bool AllowHTML { get; set; }

        [JsonProperty("sortAsGiven")]
        public bool SortAsGiven { get; set; }

        [JsonProperty("carryChoices")]
        public bool CarryChoices { get; set; }

        [JsonProperty("allowNewChoices")]
        public bool AllowNewChoices { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("numberFormat")]
        public int NumberFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("doesAverage")]
        public bool DoesAverage { get; set; }

        [JsonProperty("doesTotal")]
        public bool DoesTotal { get; set; }

        [JsonProperty("blankIsZero")]
        public bool BlankIsZero { get; set; }
    }

    public class GetFieldsResponseItemPermissionsTypeItem
    {
        [JsonProperty("permissionType")]
        public string PermissionType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }
    }

    public class DeleteFieldsResponse
    {
        [JsonProperty("deletedFieldIds")]
        public int[] DeletedFieldIds { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }

    public class DeleteFieldsInput
    {
        [JsonProperty("fieldIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] FieldIds { get; set; }
    }

    public class CreateFieldResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("noWrap")]
        public bool NoWrap { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool AppearsByDefault { get; set; }

        [JsonProperty("findEnabled")]
        public bool FindEnabled { get; set; }

        [JsonProperty("unique")]
        public bool Unique { get; set; }

        [JsonProperty("doesDataCopy")]
        public bool DoesDataCopy { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("audited")]
        public bool Audited { get; set; }

        [JsonProperty("properties")]
        public Properties1 Properties { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }
    }

    public class Properties1
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("doesTotal")]
        public bool DoesTotal { get; set; }

        [JsonProperty("autoSave")]
        public bool AutoSave { get; set; }

        [JsonProperty("defaultValueLuid")]
        public int DefaultValueLuid { get; set; }

        [JsonProperty("maxVersions")]
        public int MaxVersions { get; set; }

        [JsonProperty("carryChoices")]
        public bool CarryChoices { get; set; }

        [JsonProperty("format")]
        public int Format { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("linkText")]
        public string LinkText { get; set; }

        [JsonProperty("parentFieldId")]
        public int ParentFieldId { get; set; }

        [JsonProperty("displayTimezone")]
        public bool DisplayTimezone { get; set; }

        [JsonProperty("summaryTargetFieldId")]
        public int SummaryTargetFieldId { get; set; }

        [JsonProperty("allowNewChoices")]
        public bool AllowNewChoices { get; set; }

        [JsonProperty("masterChoiceFieldId")]
        public int MasterChoiceFieldId { get; set; }

        [JsonProperty("defaultToday")]
        public bool DefaultToday { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("lookupTargetFieldId")]
        public int LookupTargetFieldId { get; set; }

        [JsonProperty("summaryFunction")]
        public SummaryFunction SummaryFunction { get; set; }

        [JsonProperty("sourceFieldId")]
        public int SourceFieldId { get; set; }

        [JsonProperty("masterTableTag")]
        public string MasterTableTag { get; set; }

        [JsonProperty("doesAverage")]
        public bool DoesAverage { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("seeVersions")]
        public bool SeeVersions { get; set; }

        [JsonProperty("displayMonth")]
        public string DisplayMonth { get; set; }

        [JsonProperty("numLines")]
        public int NumLines { get; set; }

        [JsonProperty("displayEmail")]
        public string DisplayEmail { get; set; }

        [JsonProperty("defaultKind")]
        public string DefaultKind { get; set; }

        [JsonProperty("coverText")]
        public string CoverText { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("masterChoiceTableId")]
        public int MasterChoiceTableId { get; set; }

        [JsonProperty("targetFieldId")]
        public int TargetFieldId { get; set; }

        [JsonProperty("displayUser")]
        public string DisplayUser { get; set; }

        [JsonProperty("blankIsZero")]
        public bool BlankIsZero { get; set; }

        [JsonProperty("exact")]
        public bool Exact { get; set; }

        [JsonProperty("startField")]
        public int StartField { get; set; }

        [JsonProperty("defaultDomain")]
        public string DefaultDomain { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("choicesLuid")]
        public JToken[] ChoicesLuid { get; set; }

        [JsonProperty("abbreviate")]
        public bool Abbreviate { get; set; }

        [JsonProperty("xmlTag")]
        public string XmlTag { get; set; }

        [JsonProperty("targetTableName")]
        public string TargetTableName { get; set; }

        [JsonProperty("numberFormat")]
        public int NumberFormat { get; set; }

        [JsonProperty("appearsAs")]
        public string AppearsAs { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("currencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }

        [JsonProperty("displayImages")]
        public bool DisplayImages { get; set; }

        [JsonProperty("foreignKey")]
        public bool ForeignKey { get; set; }

        [JsonProperty("displayDayOfWeek")]
        public bool DisplayDayOfWeek { get; set; }

        [JsonProperty("summaryReferenceFieldId")]
        public int SummaryReferenceFieldId { get; set; }

        [JsonProperty("commaStart")]
        public int CommaStart { get; set; }

        [JsonProperty("choices")]
        public string[] Choices { get; set; }

        [JsonProperty("targetTableId")]
        public string TargetTableId { get; set; }

        [JsonProperty("displayRelative")]
        public bool DisplayRelative { get; set; }

        [JsonProperty("compositeFields")]
        public JToken[] CompositeFields { get; set; }

        [JsonProperty("versionMode")]
        public VersionMode VersionMode { get; set; }

        [JsonProperty("displayTime")]
        public bool DisplayTime { get; set; }

        [JsonProperty("durationField")]
        public int DurationField { get; set; }

        [JsonProperty("snapFieldId")]
        public int SnapFieldId { get; set; }

        [JsonProperty("hours24")]
        public bool Hours24 { get; set; }

        [JsonProperty("sortAlpha")]
        public bool SortAlpha { get; set; }

        [JsonProperty("sortAsGiven")]
        public bool SortAsGiven { get; set; }

        [JsonProperty("hasExtension")]
        public bool HasExtension { get; set; }

        [JsonProperty("workWeek")]
        public int WorkWeek { get; set; }

        [JsonProperty("useNewWindow")]
        public bool UseNewWindow { get; set; }

        [JsonProperty("appendOnly")]
        public bool AppendOnly { get; set; }

        [JsonProperty("displayAsLink")]
        public bool DisplayAsLink { get; set; }

        [JsonProperty("allowHTML")]
        public bool AllowHTML { get; set; }

        [JsonProperty("lookupReferenceFieldId")]
        public int LookupReferenceFieldId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummaryFunction
    {
        AVG,
        SUM,
        MAX,
        MIN,
        [EnumMember(Value = "STD-DEV")]
        STDDEV,
        COUNT,
        [EnumMember(Value = "COMBINED-TEXT")]
        COMBINEDTEXT,
        [EnumMember(Value = "DISTINCT-COUNT")]
        DISTINCTCOUNT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CurrencyFormat
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "right")]
        Right,
        [EnumMember(Value = "middle")]
        Middle
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VersionMode
    {
        [EnumMember(Value = "keepallversions")]
        Keepallversions,
        [EnumMember(Value = "keeplastversions")]
        Keeplastversions
    }

    public class Permission
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("permissionType")]
        public string PermissionType { get; set; }

        [JsonProperty("roleId")]
        public int RoleId { get; set; }
    }

    public class CreateFieldInput
    {
        [JsonProperty("audited")]
        public bool? Audited { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("bold")]
        public bool? Bold { get; set; }

        [JsonProperty("properties")]
        public Properties2 Properties { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool? AppearsByDefault { get; set; }

        [JsonProperty("fieldType", DefaultValueHandling = DefaultValueHandling.Include)]
        public FieldType2 FieldType { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("addToForms")]
        public bool? AddToForms { get; set; }

        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; }

        [JsonProperty("findEnabled")]
        public bool? FindEnabled { get; set; }

        [JsonProperty("noWrap")]
        public bool? NoWrap { get; set; }
    }

    public class Properties2
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("doesTotal")]
        public bool DoesTotal { get; set; }

        [JsonProperty("autoSave")]
        public bool AutoSave { get; set; }

        [JsonProperty("defaultValueLuid")]
        public int DefaultValueLuid { get; set; }

        [JsonProperty("maxVersions")]
        public int MaxVersions { get; set; }

        [JsonProperty("format")]
        public int Format { get; set; }

        [JsonProperty("carryChoices")]
        public bool CarryChoices { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("linkText")]
        public string LinkText { get; set; }

        [JsonProperty("parentFieldId")]
        public int ParentFieldId { get; set; }

        [JsonProperty("displayTimezone")]
        public bool DisplayTimezone { get; set; }

        [JsonProperty("allowNewChoices")]
        public bool AllowNewChoices { get; set; }

        [JsonProperty("defaultToday")]
        public bool DefaultToday { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("sourceFieldId")]
        public int SourceFieldId { get; set; }

        [JsonProperty("doesAverage")]
        public bool DoesAverage { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("displayMonth")]
        public string DisplayMonth { get; set; }

        [JsonProperty("seeVersions")]
        public bool SeeVersions { get; set; }

        [JsonProperty("numLines")]
        public int NumLines { get; set; }

        [JsonProperty("defaultKind")]
        public string DefaultKind { get; set; }

        [JsonProperty("displayEmail")]
        public string DisplayEmail { get; set; }

        [JsonProperty("coverText")]
        public string CoverText { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("targetFieldId")]
        public int TargetFieldId { get; set; }

        [JsonProperty("displayUser")]
        public string DisplayUser { get; set; }

        [JsonProperty("blankIsZero")]
        public bool BlankIsZero { get; set; }

        [JsonProperty("exact")]
        public bool Exact { get; set; }

        [JsonProperty("defaultDomain")]
        public string DefaultDomain { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("abbreviate")]
        public bool Abbreviate { get; set; }

        [JsonProperty("numberFormat")]
        public int NumberFormat { get; set; }

        [JsonProperty("targetTableName")]
        public string TargetTableName { get; set; }

        [JsonProperty("appearsAs")]
        public string AppearsAs { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("currencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }

        [JsonProperty("displayImages")]
        public bool DisplayImages { get; set; }

        [JsonProperty("displayDayOfWeek")]
        public bool DisplayDayOfWeek { get; set; }

        [JsonProperty("commaStart")]
        public int CommaStart { get; set; }

        [JsonProperty("choices")]
        public string[] Choices { get; set; }

        [JsonProperty("targetTableId")]
        public string TargetTableId { get; set; }

        [JsonProperty("displayRelative")]
        public bool DisplayRelative { get; set; }

        [JsonProperty("compositeFields")]
        public JToken[] CompositeFields { get; set; }

        [JsonProperty("displayTime")]
        public bool DisplayTime { get; set; }

        [JsonProperty("versionMode")]
        public VersionMode VersionMode { get; set; }

        [JsonProperty("snapFieldId")]
        public int SnapFieldId { get; set; }

        [JsonProperty("hours24")]
        public bool Hours24 { get; set; }

        [JsonProperty("sortAlpha")]
        public bool SortAlpha { get; set; }

        [JsonProperty("sortAsGiven")]
        public bool SortAsGiven { get; set; }

        [JsonProperty("hasExtension")]
        public bool HasExtension { get; set; }

        [JsonProperty("useNewWindow")]
        public bool UseNewWindow { get; set; }

        [JsonProperty("appendOnly")]
        public bool AppendOnly { get; set; }

        [JsonProperty("displayAsLink")]
        public bool DisplayAsLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldType2
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "text-multiple-choice")]
        TextMultipleChoice,
        [EnumMember(Value = "text-multi-line")]
        TextMultiLine,
        [EnumMember(Value = "rich-text")]
        RichText,
        [EnumMember(Value = "numeric")]
        Numeric,
        [EnumMember(Value = "currency")]
        Currency,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "multitext")]
        Multitext,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "timeofday")]
        Timeofday,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "multiuser")]
        Multiuser,
        [EnumMember(Value = "address")]
        Address,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "file")]
        File
    }

    public class GetFieldResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("noWrap")]
        public bool NoWrap { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool AppearsByDefault { get; set; }

        [JsonProperty("findEnabled")]
        public bool FindEnabled { get; set; }

        [JsonProperty("unique")]
        public bool Unique { get; set; }

        [JsonProperty("doesDataCopy")]
        public bool DoesDataCopy { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("audited")]
        public bool Audited { get; set; }

        [JsonProperty("properties")]
        public Properties1 Properties { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }
    }

    public class UpdateFieldResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("noWrap")]
        public bool NoWrap { get; set; }

        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool AppearsByDefault { get; set; }

        [JsonProperty("findEnabled")]
        public bool FindEnabled { get; set; }

        [JsonProperty("unique")]
        public bool Unique { get; set; }

        [JsonProperty("doesDataCopy")]
        public bool DoesDataCopy { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("audited")]
        public bool Audited { get; set; }

        [JsonProperty("properties")]
        public Properties1 Properties { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }
    }

    public class UpdateFieldInput
    {
        [JsonProperty("audited")]
        public bool? Audited { get; set; }

        [JsonProperty("fieldHelp")]
        public string FieldHelp { get; set; }

        [JsonProperty("bold")]
        public bool? Bold { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("properties")]
        public Properties5 Properties { get; set; }

        [JsonProperty("appearsByDefault")]
        public bool? AppearsByDefault { get; set; }

        [JsonProperty("unique")]
        public bool? Unique { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("addToForms")]
        public bool? AddToForms { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("findEnabled")]
        public bool? FindEnabled { get; set; }

        [JsonProperty("noWrap")]
        public bool? NoWrap { get; set; }
    }

    public class Properties5
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("doesTotal")]
        public bool DoesTotal { get; set; }

        [JsonProperty("autoSave")]
        public bool AutoSave { get; set; }

        [JsonProperty("defaultValueLuid")]
        public int DefaultValueLuid { get; set; }

        [JsonProperty("maxVersions")]
        public int MaxVersions { get; set; }

        [JsonProperty("format")]
        public int Format { get; set; }

        [JsonProperty("carryChoices")]
        public bool CarryChoices { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("linkText")]
        public string LinkText { get; set; }

        [JsonProperty("parentFieldId")]
        public int ParentFieldId { get; set; }

        [JsonProperty("displayTimezone")]
        public bool DisplayTimezone { get; set; }

        [JsonProperty("summaryTargetFieldId")]
        public int SummaryTargetFieldId { get; set; }

        [JsonProperty("allowNewChoices")]
        public bool AllowNewChoices { get; set; }

        [JsonProperty("defaultToday")]
        public bool DefaultToday { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("lookupTargetFieldId")]
        public int LookupTargetFieldId { get; set; }

        [JsonProperty("summaryFunction")]
        public SummaryFunction3 SummaryFunction { get; set; }

        [JsonProperty("sourceFieldId")]
        public int SourceFieldId { get; set; }

        [JsonProperty("doesAverage")]
        public bool DoesAverage { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("displayMonth")]
        public string DisplayMonth { get; set; }

        [JsonProperty("seeVersions")]
        public bool SeeVersions { get; set; }

        [JsonProperty("numLines")]
        public int NumLines { get; set; }

        [JsonProperty("defaultKind")]
        public string DefaultKind { get; set; }

        [JsonProperty("displayEmail")]
        public string DisplayEmail { get; set; }

        [JsonProperty("coverText")]
        public string CoverText { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("summaryQuery")]
        public string SummaryQuery { get; set; }

        [JsonProperty("targetFieldId")]
        public int TargetFieldId { get; set; }

        [JsonProperty("displayUser")]
        public string DisplayUser { get; set; }

        [JsonProperty("blankIsZero")]
        public bool BlankIsZero { get; set; }

        [JsonProperty("exact")]
        public bool Exact { get; set; }

        [JsonProperty("defaultDomain")]
        public string DefaultDomain { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("abbreviate")]
        public bool Abbreviate { get; set; }

        [JsonProperty("numberFormat")]
        public int NumberFormat { get; set; }

        [JsonProperty("targetTableName")]
        public string TargetTableName { get; set; }

        [JsonProperty("appearsAs")]
        public string AppearsAs { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("currencyFormat")]
        public CurrencyFormat CurrencyFormat { get; set; }

        [JsonProperty("displayImages")]
        public bool DisplayImages { get; set; }

        [JsonProperty("displayDayOfWeek")]
        public bool DisplayDayOfWeek { get; set; }

        [JsonProperty("summaryReferenceFieldId")]
        public int SummaryReferenceFieldId { get; set; }

        [JsonProperty("commaStart")]
        public int CommaStart { get; set; }

        [JsonProperty("choices")]
        public string[] Choices { get; set; }

        [JsonProperty("targetTableId")]
        public string TargetTableId { get; set; }

        [JsonProperty("displayRelative")]
        public bool DisplayRelative { get; set; }

        [JsonProperty("compositeFields")]
        public JToken[] CompositeFields { get; set; }

        [JsonProperty("summaryTableId")]
        public string SummaryTableId { get; set; }

        [JsonProperty("displayTime")]
        public bool DisplayTime { get; set; }

        [JsonProperty("versionMode")]
        public VersionMode VersionMode { get; set; }

        [JsonProperty("snapFieldId")]
        public int SnapFieldId { get; set; }

        [JsonProperty("hours24")]
        public bool Hours24 { get; set; }

        [JsonProperty("sortAlpha")]
        public bool SortAlpha { get; set; }

        [JsonProperty("sortAsGiven")]
        public bool SortAsGiven { get; set; }

        [JsonProperty("hasExtension")]
        public bool HasExtension { get; set; }

        [JsonProperty("useNewWindow")]
        public bool UseNewWindow { get; set; }

        [JsonProperty("appendOnly")]
        public bool AppendOnly { get; set; }

        [JsonProperty("displayAsLink")]
        public bool DisplayAsLink { get; set; }

        [JsonProperty("lookupReferenceFieldId")]
        public int LookupReferenceFieldId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummaryFunction3
    {
        AVG,
        SUM,
        MAX,
        MIN,
        [EnumMember(Value = "STD-DEV")]
        STDDEV,
        COUNT,
        [EnumMember(Value = "COMBINED-TEXT")]
        COMBINEDTEXT,
        [EnumMember(Value = "DISTINCT-COUNT")]
        DISTINCTCOUNT
    }

    public class GetFieldsUsageResponseItem
    {
        [JsonProperty("field")]
        public GetFieldsUsageResponseItemFieldType Field { get; set; }

        [JsonProperty("usage")]
        public GetFieldsUsageResponseItemUsageType Usage { get; set; }
    }

    public class GetFieldsUsageResponseItemFieldType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageType
    {
        [JsonProperty("actions")]
        public GetFieldsUsageResponseItemUsageTypeActionsType Actions { get; set; }

        [JsonProperty("appHomePages")]
        public GetFieldsUsageResponseItemUsageTypeAppHomePagesType AppHomePages { get; set; }

        [JsonProperty("defaultReports")]
        public GetFieldsUsageResponseItemUsageTypeDefaultReportsType DefaultReports { get; set; }

        [JsonProperty("exactForms")]
        public GetFieldsUsageResponseItemUsageTypeExactFormsType ExactForms { get; set; }

        [JsonProperty("fields")]
        public GetFieldsUsageResponseItemUsageTypeFieldsType Fields { get; set; }

        [JsonProperty("forms")]
        public GetFieldsUsageResponseItemUsageTypeFormsType Forms { get; set; }

        [JsonProperty("notifications")]
        public GetFieldsUsageResponseItemUsageTypeNotificationsType Notifications { get; set; }

        [JsonProperty("personalReports")]
        public GetFieldsUsageResponseItemUsageTypePersonalReportsType PersonalReports { get; set; }

        [JsonProperty("relationships")]
        public GetFieldsUsageResponseItemUsageTypeRelationshipsType Relationships { get; set; }

        [JsonProperty("reminders")]
        public GetFieldsUsageResponseItemUsageTypeRemindersType Reminders { get; set; }

        [JsonProperty("reports")]
        public GetFieldsUsageResponseItemUsageTypeReportsType Reports { get; set; }

        [JsonProperty("roles")]
        public GetFieldsUsageResponseItemUsageTypeRolesType Roles { get; set; }

        [JsonProperty("webhooks")]
        public GetFieldsUsageResponseItemUsageTypeWebhooksType Webhooks { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeActionsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeAppHomePagesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeDefaultReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeExactFormsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeFieldsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeFormsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeNotificationsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypePersonalReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeRelationshipsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeRemindersType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeRolesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldsUsageResponseItemUsageTypeWebhooksType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItem
    {
        [JsonProperty("field")]
        public GetFieldUsageResponseItemFieldType Field { get; set; }

        [JsonProperty("usage")]
        public GetFieldUsageResponseItemUsageType Usage { get; set; }
    }

    public class GetFieldUsageResponseItemFieldType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetFieldUsageResponseItemUsageType
    {
        [JsonProperty("actions")]
        public GetFieldUsageResponseItemUsageTypeActionsType Actions { get; set; }

        [JsonProperty("appHomePages")]
        public GetFieldUsageResponseItemUsageTypeAppHomePagesType AppHomePages { get; set; }

        [JsonProperty("defaultReports")]
        public GetFieldUsageResponseItemUsageTypeDefaultReportsType DefaultReports { get; set; }

        [JsonProperty("exactForms")]
        public GetFieldUsageResponseItemUsageTypeExactFormsType ExactForms { get; set; }

        [JsonProperty("fields")]
        public GetFieldUsageResponseItemUsageTypeFieldsType Fields { get; set; }

        [JsonProperty("forms")]
        public GetFieldUsageResponseItemUsageTypeFormsType Forms { get; set; }

        [JsonProperty("notifications")]
        public GetFieldUsageResponseItemUsageTypeNotificationsType Notifications { get; set; }

        [JsonProperty("personalReports")]
        public GetFieldUsageResponseItemUsageTypePersonalReportsType PersonalReports { get; set; }

        [JsonProperty("relationships")]
        public GetFieldUsageResponseItemUsageTypeRelationshipsType Relationships { get; set; }

        [JsonProperty("reminders")]
        public GetFieldUsageResponseItemUsageTypeRemindersType Reminders { get; set; }

        [JsonProperty("reports")]
        public GetFieldUsageResponseItemUsageTypeReportsType Reports { get; set; }

        [JsonProperty("roles")]
        public GetFieldUsageResponseItemUsageTypeRolesType Roles { get; set; }

        [JsonProperty("webhooks")]
        public GetFieldUsageResponseItemUsageTypeWebhooksType Webhooks { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeActionsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeAppHomePagesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeDefaultReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeExactFormsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeFieldsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeFormsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeNotificationsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypePersonalReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeRelationshipsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeRemindersType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeReportsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeRolesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetFieldUsageResponseItemUsageTypeWebhooksType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class RunFormulaResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class RunFormulaInput
    {
        [JsonProperty("formula", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Formula { get; set; }

        [JsonProperty("rid")]
        public int? Rid { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }
    }

    public class DeleteRecordsResponse
    {
        [JsonProperty("numberDeleted")]
        public int NumberDeleted { get; set; }
    }

    public class DeleteRecordsInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("where", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Where { get; set; }
    }

    public class RunQueryResponse
    {
        [JsonProperty("fields")]
        public Fields2[] Fields { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata1 Metadata { get; set; }
    }

    public class Fields2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunQueryInput
    {
        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("where")]
        public string Where { get; set; }

        [JsonProperty("groupBy")]
        public GroupBy[] GroupBy { get; set; }

        [JsonProperty("sortBy")]
        public JToken SortBy { get; set; }

        [JsonProperty("select")]
        public JToken[] Select { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }
    }

    public class Options
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("compareWithAppLocalTime")]
        public bool CompareWithAppLocalTime { get; set; }

        [JsonProperty("top")]
        public int Top { get; set; }
    }

    public class GroupBy
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("grouping")]
        public Grouping Grouping { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Grouping
    {
        ASC,
        DESC,
        [EnumMember(Value = "equal-values")]
        EqualValues
    }

    public class GetTempTokenDBIdResponse
    {
        [JsonProperty("temporaryAuthorization")]
        public string TemporaryAuthorization { get; set; }
    }

    public class CloneUserTokenResponse
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("apps")]
        public App[] Apps { get; set; }

        [JsonProperty("lastUsed")]
        public string LastUsed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class App
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CloneUserTokenInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class DeactivateUserTokenResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DeleteUserTokenResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DeleteFileResponse
    {
        [JsonProperty("versionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("uploaded")]
        public string Uploaded { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }
    }

    public class Creator
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Quickbaseip;

    public partial class WorkflowManagedActions
    {
        public QuickbaseipActions Quickbaseip(string connectionId) => new QuickbaseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public QuickbaseipTriggers Quickbaseip(string connectionId) => new QuickbaseipTriggers(connectionId);
    }
}