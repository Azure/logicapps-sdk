//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Experlogixsmartflows
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixsmartflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixsmartflows")]
        public IBodyWorkflowAction<GetDocumentsResponse[]> GetDocuments(Expression<Func<string>> reqexecutionId)
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
        public IBodyWorkflowAction<FlowExecutionResponse> GetExecutionStatus(Expression<Func<string>> reqexecutionId)
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
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> reqdocumentId)
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
        public IBodyWorkflowAction<FlowExecutionResponse> ExecuteFlow(Expression<Func<string>> reqflowId, Expression<Func<object>> reqexecutionData, Expression<Func<int>> reqpriority = null, Expression<Func<bool>> reqenableAsynchronousRequestReplyPattern = null)
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
                req["enableAsynchronousRequestReplyPattern"] = ExpressionConverter.ConvertO(reqenableAsynchronousRequestReplyPattern);
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
                req["includeTemplateHistory"] = ExpressionConverter.ConvertO(reqincludeTemplateHistory);
                reqpropCount++;
            }

            if (reqincludeSamples != null)
            {
                req["includeSamples"] = ExpressionConverter.ConvertO(reqincludeSamples);
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
            callPayload.Queries["overwriteExisting"] = ExpressionConverter.Convert(overwriteExisting);
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
            req["includeHistory"] = ExpressionConverter.ConvertO(reqincludeHistory);
            if (req00000000000000000000000000000000 != null)
            {
                req["00000000-0000-0000-0000-000000000000"] = ExpressionConverter.ConvertO(req00000000000000000000000000000000);
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
    using Microsoft.Azure.Workflows.Sdk.Experlogixsmartflows;

    public partial class WorkflowManagedActions
    {
        public ExperlogixsmartflowsActions Experlogixsmartflows(string connectionId) => new ExperlogixsmartflowsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExperlogixsmartflowsTriggers Experlogixsmartflows(string connectionId) => new ExperlogixsmartflowsTriggers(connectionId);
    }
}