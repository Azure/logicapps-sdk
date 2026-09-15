//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixsmartflows
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixsmartflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var apiCallPath = "/runtime/webhooks/mcp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mcpSessionId != null)
                callPayload.Headers["Mcp-Session-Id"] = CSharpExpressionConverter.ConvertO(mcpSessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = CSharpExpressionConverter.ConvertToken(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = CSharpExpressionConverter.ConvertToken(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = CSharpExpressionConverter.ConvertToken(queryRequestmethod);
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
        public IBodyWorkflowAction<GetDocumentsResponse[]> GetDocuments(Expression<Func<string>> reqexecutionId)
        {
            var apiCallPath = "/api/Documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["executionId"] = CSharpExpressionConverter.ConvertToken(reqexecutionId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<GetDocumentsResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> GetExecutionStatus(Expression<Func<string>> reqexecutionId)
        {
            var apiCallPath = "/api/ExecutionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["executionId"] = CSharpExpressionConverter.ConvertToken(reqexecutionId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<FlowExecutionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> reqdocumentId)
        {
            var apiCallPath = "/api/DownloadDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["documentId"] = CSharpExpressionConverter.ConvertToken(reqdocumentId);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> ExecuteFlow(Expression<Func<string>> reqflowId, Expression<Func<object>> reqexecutionData, Expression<Func<int>> reqpriority = null, Expression<Func<bool>> reqenableAsynchronousRequestReplyPattern = null)
        {
            var apiCallPath = "/api/ExecuteFlow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["flowId"] = CSharpExpressionConverter.ConvertToken(reqflowId);
            reqpropCount++;
            req["executionData"] = CSharpExpressionConverter.ConvertToken(reqexecutionData);
            if (reqpriority != null)
            {
                req["priority"] = CSharpExpressionConverter.ConvertToken(reqpriority);
                reqpropCount++;
            }

            if (reqenableAsynchronousRequestReplyPattern != null)
            {
                if (reqenableAsynchronousRequestReplyPattern != null)
                {
                    req["enableAsynchronousRequestReplyPattern"] = CSharpExpressionConverter.ConvertToken(reqenableAsynchronousRequestReplyPattern);
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
        public IBodyWorkflowAction<string> ExportPackage(Expression<Func<reqrecordTypeInput>> reqrecordType, Expression<Func<reqexportModeInput>> reqexportMode, Expression<Func<bool>> reqincludeAllDependencies, Expression<Func<object>> reqrecords = null, Expression<Func<bool>> reqincludeTemplateHistory = null, Expression<Func<bool>> reqincludeSamples = null)
        {
            var apiCallPath = "/api/Export";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["recordType"] = CSharpExpressionConverter.Convert(reqrecordType);
            reqpropCount++;
            req["exportMode"] = CSharpExpressionConverter.Convert(reqexportMode);
            if (reqrecords != null)
            {
                req["records"] = CSharpExpressionConverter.ConvertToken(reqrecords);
                reqpropCount++;
            }

            reqpropCount++;
            req["includeAllDependencies"] = CSharpExpressionConverter.ConvertToken(reqincludeAllDependencies);
            if (reqincludeTemplateHistory != null)
            {
                if (reqincludeTemplateHistory != null)
                {
                    req["includeTemplateHistory"] = CSharpExpressionConverter.ConvertToken(reqincludeTemplateHistory);
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
                    req["includeSamples"] = CSharpExpressionConverter.ConvertToken(reqincludeSamples);
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
        public IWorkflowAction ImportPackage(Expression<Func<object>> package, Expression<Func<bool>> overwriteExisting)
        {
            var apiCallPath = "/api/Import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["overwriteExisting"] = CSharpExpressionConverter.ConvertO(overwriteExisting);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> BackupPackage(Expression<Func<bool>> reqincludeHistory, Expression<Func<bool>> req00000000000000000000000000000000 = null)
        {
            var apiCallPath = "/api/Backup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["includeHistory"] = CSharpExpressionConverter.ConvertToken(reqincludeHistory);
            if (req00000000000000000000000000000000 != null)
            {
                if (req00000000000000000000000000000000 != null)
                {
                    req["00000000-0000-0000-0000-000000000000"] = CSharpExpressionConverter.ConvertToken(req00000000000000000000000000000000);
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
        public IWorkflowAction RestorePackage(Expression<Func<object>> package)
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