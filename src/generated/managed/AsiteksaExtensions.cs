//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asiteksa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsiteksaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL([WorkflowExpression] Func<string> downloadUrl)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/downloadFileByUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadUrl"] = SourceExpressionConverter.ConvertO(downloadUrl);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<string> SETFILEMETADATA([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<object> items = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/saveMetadataForUpload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(items);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteksa")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> fileBinary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/uploadFileFromExternalSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Queries["metadataId"] = SourceExpressionConverter.ConvertO(metadataId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fileBinary);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class AsiteksaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/asitePullDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["resourceId"] = SourceExpressionConverter.ConvertToken(bodytriggerName);
                body["resourceType"] = 1;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/asitePullAppFormDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["resourceId"] = SourceExpressionConverter.ConvertToken(bodytriggerName);
                body["resourceType"] = 1;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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