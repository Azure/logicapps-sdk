//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixsmartflows
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixsmartflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<InvokeMCPInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<GetDocumentsResponse[], ApiConnectionActionConfiguration> GetDocuments(Expression<Func<GetDocumentsInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetDocumentsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetDocumentsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse, ApiConnectionActionConfiguration> GetExecutionStatus(Expression<Func<GetExecutionStatusInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<FlowExecutionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ExecutionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<DownloadDocumentInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/DownloadDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse, ApiConnectionActionConfiguration> ExecuteFlow(Expression<Func<ExecuteFlowInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<FlowExecutionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ExecuteFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportPackage(Expression<Func<ExportPackageInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> BackupPackage(Expression<Func<BackupPackageInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Backup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ExperlogixsmartflowsTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeMCPInput
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class GetDocumentsResponse
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class GetDocumentsInput
    {
        [JsonProperty("executionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExecutionId { get; set; }
    }

    public class FlowExecutionResponse
    {
        [JsonProperty("executionId")]
        public string ExecutionId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("flowExecutionPanelUrl")]
        public string FlowExecutionPanelUrl { get; set; }
    }

    public class GetExecutionStatusInput
    {
        [JsonProperty("executionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExecutionId { get; set; }
    }

    public class DownloadDocumentInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class ExecuteFlowInput
    {
        [JsonProperty("flowId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowId { get; set; }

        [JsonProperty("executionData", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ExecutionData { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("enableAsynchronousRequestReplyPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableAsynchronousRequestReplyPattern { get; set; } = true;
    }

    public class ExportPackageInput
    {
        [JsonProperty("recordType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExportPackageInputRecordTypeType RecordType { get; set; }

        [JsonProperty("exportMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExportPackageInputExportModeType ExportMode { get; set; } = ExportPackageInputExportModeType.All;

        [JsonProperty("records")]
        public JToken Records { get; set; }

        [JsonProperty("includeAllDependencies", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeAllDependencies { get; set; } = true;

        [JsonProperty("includeTemplateHistory", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeTemplateHistory { get; set; } = false;

        [JsonProperty("includeSamples", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeSamples { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExportPackageInputRecordTypeType
    {
        Flow,
        Template,
        DataSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExportPackageInputExportModeType
    {
        All,
        [EnumMember(Value = "Select")]
        SelectRecords
    }

    public class BackupPackageInput
    {
        [JsonProperty("includeHistory", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeHistory { get; set; } = false;

        [JsonProperty("00000000-0000-0000-0000-000000000000", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? _00000000000000000000000000000000 { get; set; } = false;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixsmartflows;

    public partial class WorkflowManagedActions
    {
        public ExperlogixsmartflowsActions Experlogixsmartflows(string connectionId) => new ExperlogixsmartflowsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExperlogixsmartflowsTriggers Experlogixsmartflows(string connectionId) => new ExperlogixsmartflowsTriggers(connectionId);
    }
}