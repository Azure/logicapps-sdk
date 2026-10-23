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
        public IWorkflowAction InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
                    queryRequestpropCount++;
                }

                var resultObject = new JObject();
                var resultObjectpropCount = 0;
                if (resultObjectpropCount > 0)
                {
                    queryRequest["result"] = resultObject;
                    queryRequestpropCount++;
                }

                var errorObject = new JObject();
                var errorObjectpropCount = 0;
                if (errorObjectpropCount > 0)
                {
                    queryRequest["error"] = errorObject;
                    queryRequestpropCount++;
                }

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<GetDocumentsResponse[]> GetDocuments(Expression<Func<string>> reqexecutionId)
        {
            var __workflow_reqexecutionId = WorkflowExpression.Compile(reqexecutionId, nameof(reqexecutionId), required: true);
            return new DeferredBodyAction<GetDocumentsResponse[]>(() =>
            {
                var apiCallPath = "/api/Documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["executionId"] = ExpressionConverter.ConvertO(__workflow_reqexecutionId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetDocumentsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> GetExecutionStatus(Expression<Func<string>> reqexecutionId)
        {
            var __workflow_reqexecutionId = WorkflowExpression.Compile(reqexecutionId, nameof(reqexecutionId), required: true);
            return new DeferredBodyAction<FlowExecutionResponse>(() =>
            {
                var apiCallPath = "/api/ExecutionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["executionId"] = ExpressionConverter.ConvertO(__workflow_reqexecutionId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> reqdocumentId)
        {
            var __workflow_reqdocumentId = WorkflowExpression.Compile(reqdocumentId, nameof(reqdocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/DownloadDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["documentId"] = ExpressionConverter.ConvertO(__workflow_reqdocumentId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> ExecuteFlow(Expression<Func<string>> reqflowId, Expression<Func<object>> reqexecutionData, Expression<Func<int>> reqpriority = null, Expression<Func<bool>> reqenableAsynchronousRequestReplyPattern = null)
        {
            var __workflow_reqflowId = WorkflowExpression.Compile(reqflowId, nameof(reqflowId), required: true);
            var __workflow_reqexecutionData = WorkflowExpression.Compile(reqexecutionData, nameof(reqexecutionData), required: true);
            var __workflow_reqpriority = WorkflowExpression.Compile(reqpriority, nameof(reqpriority), required: false);
            var __workflow_reqenableAsynchronousRequestReplyPattern = WorkflowExpression.Compile(reqenableAsynchronousRequestReplyPattern, nameof(reqenableAsynchronousRequestReplyPattern), required: false);
            return new DeferredBodyAction<FlowExecutionResponse>(() =>
            {
                var apiCallPath = "/api/ExecuteFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["flowId"] = ExpressionConverter.ConvertO(__workflow_reqflowId);
                reqpropCount++;
                req["executionData"] = ExpressionConverter.ConvertO(__workflow_reqexecutionData);
                if (__workflow_reqpriority != null)
                {
                    req["priority"] = ExpressionConverter.ConvertO(__workflow_reqpriority);
                    reqpropCount++;
                }

                if (__workflow_reqenableAsynchronousRequestReplyPattern != null)
                {
                    if (__workflow_reqenableAsynchronousRequestReplyPattern != null)
                    {
                        req["enableAsynchronousRequestReplyPattern"] = ExpressionConverter.ConvertO(__workflow_reqenableAsynchronousRequestReplyPattern);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["enableAsynchronousRequestReplyPattern"] = true;
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> ExportPackage(Expression<Func<reqrecordTypeInput>> reqrecordType, Expression<Func<reqexportModeInput>> reqexportMode, Expression<Func<bool>> reqincludeAllDependencies, Expression<Func<object>> reqrecords = null, Expression<Func<bool>> reqincludeTemplateHistory = null, Expression<Func<bool>> reqincludeSamples = null)
        {
            var __workflow_reqrecordType = WorkflowExpression.Compile(reqrecordType, nameof(reqrecordType), required: true);
            var __workflow_reqexportMode = WorkflowExpression.Compile(reqexportMode, nameof(reqexportMode), required: true);
            var __workflow_reqincludeAllDependencies = WorkflowExpression.Compile(reqincludeAllDependencies, nameof(reqincludeAllDependencies), required: true);
            var __workflow_reqrecords = WorkflowExpression.Compile(reqrecords, nameof(reqrecords), required: false);
            var __workflow_reqincludeTemplateHistory = WorkflowExpression.Compile(reqincludeTemplateHistory, nameof(reqincludeTemplateHistory), required: false);
            var __workflow_reqincludeSamples = WorkflowExpression.Compile(reqincludeSamples, nameof(reqincludeSamples), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["recordType"] = ExpressionConverter.ConvertO(__workflow_reqrecordType);
                reqpropCount++;
                req["exportMode"] = ExpressionConverter.ConvertO(__workflow_reqexportMode);
                if (__workflow_reqrecords != null)
                {
                    req["records"] = ExpressionConverter.ConvertO(__workflow_reqrecords);
                    reqpropCount++;
                }

                reqpropCount++;
                req["includeAllDependencies"] = ExpressionConverter.ConvertO(__workflow_reqincludeAllDependencies);
                if (__workflow_reqincludeTemplateHistory != null)
                {
                    if (__workflow_reqincludeTemplateHistory != null)
                    {
                        req["includeTemplateHistory"] = ExpressionConverter.ConvertO(__workflow_reqincludeTemplateHistory);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["includeTemplateHistory"] = false;
                    reqpropCount++;
                }

                if (__workflow_reqincludeSamples != null)
                {
                    if (__workflow_reqincludeSamples != null)
                    {
                        req["includeSamples"] = ExpressionConverter.ConvertO(__workflow_reqincludeSamples);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["includeSamples"] = false;
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction ImportPackage(Expression<Func<object>> package, Expression<Func<bool>> overwriteExisting)
        {
            var __workflow_package = WorkflowExpression.Compile(package, nameof(package), required: true);
            var __workflow_overwriteExisting = WorkflowExpression.Compile(overwriteExisting, nameof(overwriteExisting), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["overwriteExisting"] = ExpressionConverter.Convert(__workflow_overwriteExisting);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> BackupPackage(Expression<Func<bool>> reqincludeHistory, Expression<Func<bool>> req00000000000000000000000000000000 = null)
        {
            var __workflow_reqincludeHistory = WorkflowExpression.Compile(reqincludeHistory, nameof(reqincludeHistory), required: true);
            var __workflow_req00000000000000000000000000000000 = WorkflowExpression.Compile(req00000000000000000000000000000000, nameof(req00000000000000000000000000000000), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Backup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["includeHistory"] = ExpressionConverter.ConvertO(__workflow_reqincludeHistory);
                if (__workflow_req00000000000000000000000000000000 != null)
                {
                    if (__workflow_req00000000000000000000000000000000 != null)
                    {
                        req["00000000-0000-0000-0000-000000000000"] = ExpressionConverter.ConvertO(__workflow_req00000000000000000000000000000000);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["00000000-0000-0000-0000-000000000000"] = false;
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction RestorePackage(Expression<Func<object>> package)
        {
            var __workflow_package = WorkflowExpression.Compile(package, nameof(package), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Restore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ExperlogixsmartflowsTriggers([ConnectionName] string connectionId)
    {
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reqrecordTypeInput
    {
        Flow,
        Template,
        DataSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reqexportModeInput
    {
        All,
        [EnumMember(Value = "Select")]
        SelectRecords
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
