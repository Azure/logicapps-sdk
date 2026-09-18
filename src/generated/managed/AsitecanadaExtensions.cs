//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asitecanada
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsitecanadaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asitecanada")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL([WorkflowExpression] Func<string> downloadUrl)
        {
            SourceExpression.Validate(downloadUrl, nameof(downloadUrl), required: true);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asitecanada")]
        public IBodyWorkflowAction<string> SETFILEMETADATA([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<object> items = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(items, nameof(items), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asitecanada")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> fileBinary = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(metadataId, nameof(metadataId), required: true);
            SourceExpression.Validate(fileBinary, nameof(fileBinary), required: false);
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

    public class AsitecanadaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/asitePullDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "@listCallbackUrl()";
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
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/asitePullAppFormDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "@listCallbackUrl()";
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asitecanada;

    public partial class WorkflowManagedActions
    {
        public AsitecanadaActions Asitecanada(string connectionId) => new AsitecanadaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsitecanadaTriggers Asitecanada(string connectionId) => new AsitecanadaTriggers(connectionId);
    }
}