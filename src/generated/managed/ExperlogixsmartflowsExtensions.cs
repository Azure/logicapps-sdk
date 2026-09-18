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
        public IWorkflowAction InvokeMCP([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            SourceExpression.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = SourceExpressionConverter.ConvertO(mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<GetDocumentsResponse[]> GetDocuments([WorkflowExpression] Func<string> reqexecutionId)
        {
            SourceExpression.Validate(reqexecutionId, nameof(reqexecutionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["executionId"] = SourceExpressionConverter.ConvertToken(reqexecutionId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentsResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> GetExecutionStatus([WorkflowExpression] Func<string> reqexecutionId)
        {
            SourceExpression.Validate(reqexecutionId, nameof(reqexecutionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ExecutionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["executionId"] = SourceExpressionConverter.ConvertToken(reqexecutionId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FlowExecutionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> reqdocumentId)
        {
            SourceExpression.Validate(reqdocumentId, nameof(reqdocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DownloadDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["documentId"] = SourceExpressionConverter.ConvertToken(reqdocumentId);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<FlowExecutionResponse> ExecuteFlow([WorkflowExpression] Func<string> reqflowId, [WorkflowExpression] Func<object> reqexecutionData, [WorkflowExpression] Func<int> reqpriority = null, [WorkflowExpression] Func<bool> reqenableAsynchronousRequestReplyPattern = null)
        {
            SourceExpression.Validate(reqflowId, nameof(reqflowId), required: true);
            SourceExpression.Validate(reqexecutionData, nameof(reqexecutionData), required: true);
            SourceExpression.Validate(reqpriority, nameof(reqpriority), required: false);
            SourceExpression.Validate(reqenableAsynchronousRequestReplyPattern, nameof(reqenableAsynchronousRequestReplyPattern), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ExecuteFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["flowId"] = SourceExpressionConverter.ConvertToken(reqflowId);
                reqpropCount++;
                req["executionData"] = SourceExpressionConverter.ConvertToken(reqexecutionData);
                if (reqpriority != null)
                {
                    req["priority"] = SourceExpressionConverter.ConvertToken(reqpriority);
                    reqpropCount++;
                }

                if (reqenableAsynchronousRequestReplyPattern != null)
                {
                    if (reqenableAsynchronousRequestReplyPattern != null)
                    {
                        req["enableAsynchronousRequestReplyPattern"] = SourceExpressionConverter.ConvertToken(reqenableAsynchronousRequestReplyPattern);
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
                return callPayload;
            }

            return new ApiConnectionAction<FlowExecutionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> ExportPackage([WorkflowExpression] Func<reqrecordTypeInput> reqrecordType, [WorkflowExpression] Func<reqexportModeInput> reqexportMode, [WorkflowExpression] Func<bool> reqincludeAllDependencies, [WorkflowExpression] Func<object> reqrecords = null, [WorkflowExpression] Func<bool> reqincludeTemplateHistory = null, [WorkflowExpression] Func<bool> reqincludeSamples = null)
        {
            SourceExpression.Validate(reqrecordType, nameof(reqrecordType), required: true);
            SourceExpression.Validate(reqexportMode, nameof(reqexportMode), required: true);
            SourceExpression.Validate(reqincludeAllDependencies, nameof(reqincludeAllDependencies), required: true);
            SourceExpression.Validate(reqrecords, nameof(reqrecords), required: false);
            SourceExpression.Validate(reqincludeTemplateHistory, nameof(reqincludeTemplateHistory), required: false);
            SourceExpression.Validate(reqincludeSamples, nameof(reqincludeSamples), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["recordType"] = SourceExpressionConverter.Convert(reqrecordType);
                reqpropCount++;
                req["exportMode"] = SourceExpressionConverter.Convert(reqexportMode);
                if (reqrecords != null)
                {
                    req["records"] = SourceExpressionConverter.ConvertToken(reqrecords);
                    reqpropCount++;
                }

                reqpropCount++;
                req["includeAllDependencies"] = SourceExpressionConverter.ConvertToken(reqincludeAllDependencies);
                if (reqincludeTemplateHistory != null)
                {
                    if (reqincludeTemplateHistory != null)
                    {
                        req["includeTemplateHistory"] = SourceExpressionConverter.ConvertToken(reqincludeTemplateHistory);
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
                        req["includeSamples"] = SourceExpressionConverter.ConvertToken(reqincludeSamples);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction ImportPackage([WorkflowExpression] Func<object> package, [WorkflowExpression] Func<bool> overwriteExisting)
        {
            SourceExpression.Validate(package, nameof(package), required: true);
            SourceExpression.Validate(overwriteExisting, nameof(overwriteExisting), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["overwriteExisting"] = SourceExpressionConverter.ConvertO(overwriteExisting);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<string> BackupPackage([WorkflowExpression] Func<bool> reqincludeHistory, [WorkflowExpression] Func<bool> req00000000000000000000000000000000 = null)
        {
            SourceExpression.Validate(reqincludeHistory, nameof(reqincludeHistory), required: true);
            SourceExpression.Validate(req00000000000000000000000000000000, nameof(req00000000000000000000000000000000), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Backup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["includeHistory"] = SourceExpressionConverter.ConvertToken(reqincludeHistory);
                if (req00000000000000000000000000000000 != null)
                {
                    if (req00000000000000000000000000000000 != null)
                    {
                        req["00000000-0000-0000-0000-000000000000"] = SourceExpressionConverter.ConvertToken(req00000000000000000000000000000000);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IWorkflowAction RestorePackage([WorkflowExpression] Func<object> package)
        {
            SourceExpression.Validate(package, nameof(package), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Restore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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