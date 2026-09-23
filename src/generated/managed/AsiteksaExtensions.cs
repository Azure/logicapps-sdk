//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asiteksa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsiteksaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL([WorkflowExpression] Func<string> downloadUrl)
        {
            var apiCallPath = "/downloadFileByUrl";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(downloadUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<string> SETFILEMETADATA([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<object> items = null)
        {
            var apiCallPath = "/saveMetadataForUpload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Body = ExpressionConverter.ConvertO(items);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> fileBinary = null)
        {
            var apiCallPath = "/uploadFileFromExternalSystem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Queries["metadataId"] = ExpressionConverter.Convert(metadataId);
            callPayload.Body = ExpressionConverter.ConvertO(fileBinary);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AsiteksaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/asitePullDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = ExpressionConverter.ConvertO(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/asitePullAppFormDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = ExpressionConverter.ConvertO(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asiteksa;

    public partial class WorkflowManagedActions
    {
        public AsiteksaActions Asiteksa(string connectionId) => new AsiteksaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsiteksaTriggers Asiteksa(string connectionId) => new AsiteksaTriggers(connectionId);
    }
}