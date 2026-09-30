//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixsmartflows
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixsmartflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction InvokeMCP([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            var apiCallPath = "/runtime/webhooks/mcp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mcpSessionId != null)
                callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(mcpSessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<GetDocumentsResponse[]> GetDocuments([WorkflowExpression] Func<string> reqexecutionId)
        {
            var apiCallPath = "/api/Documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["executionId"] = ExpressionConverter.ConvertO(reqexecutionId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<GetDocumentsResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> GetExecutionStatus([WorkflowExpression] Func<string> reqexecutionId)
        {
            var apiCallPath = "/api/ExecutionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["executionId"] = ExpressionConverter.ConvertO(reqexecutionId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> reqdocumentId)
        {
            var apiCallPath = "/api/DownloadDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["documentId"] = ExpressionConverter.ConvertO(reqdocumentId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> ExecuteFlow([WorkflowExpression] Func<string> reqflowId, [WorkflowExpression] Func<object> reqexecutionData, [WorkflowExpression] Func<int> reqpriority = null, [WorkflowExpression] Func<bool> reqenableAsynchronousRequestReplyPattern = null)
        {
            var apiCallPath = "/api/ExecuteFlow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["flowId"] = ExpressionConverter.ConvertO(reqflowId);
            reqpropCount++;
            req["executionData"] = ExpressionConverter.ConvertO(reqexecutionData);
            if (reqpriority != null)
            {
                req["priority"] = ExpressionConverter.ConvertO(reqpriority);
                reqpropCount++;
            }

            if (reqenableAsynchronousRequestReplyPattern != null)
            {
                if (reqenableAsynchronousRequestReplyPattern != null)
                {
                    req["enableAsynchronousRequestReplyPattern"] = ExpressionConverter.ConvertO(reqenableAsynchronousRequestReplyPattern);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> ExportPackage([WorkflowExpression] Func<reqrecordTypeInput> reqrecordType, [WorkflowExpression] Func<reqexportModeInput> reqexportMode, [WorkflowExpression] Func<bool> reqincludeAllDependencies, [WorkflowExpression] Func<object> reqrecords = null, [WorkflowExpression] Func<bool> reqincludeTemplateHistory = null, [WorkflowExpression] Func<bool> reqincludeSamples = null)
        {
            var apiCallPath = "/api/Export";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["recordType"] = ExpressionConverter.ConvertO(reqrecordType);
            reqpropCount++;
            req["exportMode"] = ExpressionConverter.ConvertO(reqexportMode);
            if (reqrecords != null)
            {
                req["records"] = ExpressionConverter.ConvertO(reqrecords);
                reqpropCount++;
            }

            reqpropCount++;
            req["includeAllDependencies"] = ExpressionConverter.ConvertO(reqincludeAllDependencies);
            if (reqincludeTemplateHistory != null)
            {
                if (reqincludeTemplateHistory != null)
                {
                    req["includeTemplateHistory"] = ExpressionConverter.ConvertO(reqincludeTemplateHistory);
                    reqpropCount++;
                }

                reqpropCount++;
            }
            else
            {
                req["includeTemplateHistory"] = false;
                reqpropCount++;
            }

            if (reqincludeSamples != null)
            {
                if (reqincludeSamples != null)
                {
                    req["includeSamples"] = ExpressionConverter.ConvertO(reqincludeSamples);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction ImportPackage([WorkflowExpression] Func<object> package, [WorkflowExpression] Func<bool> overwriteExisting)
        {
            var apiCallPath = "/api/Import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["overwriteExisting"] = ExpressionConverter.Convert(overwriteExisting);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> BackupPackage([WorkflowExpression] Func<bool> reqincludeHistory, [WorkflowExpression] Func<bool> req00000000000000000000000000000000 = null)
        {
            var apiCallPath = "/api/Backup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["includeHistory"] = ExpressionConverter.ConvertO(reqincludeHistory);
            if (req00000000000000000000000000000000 != null)
            {
                if (req00000000000000000000000000000000 != null)
                {
                    req["00000000-0000-0000-0000-000000000000"] = ExpressionConverter.ConvertO(req00000000000000000000000000000000);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction RestorePackage([WorkflowExpression] Func<object> package)
        {
            var apiCallPath = "/api/Restore";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
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

    public enum reqrecordTypeInput
    {
        Flow,
        Template,
        DataSet
    }

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