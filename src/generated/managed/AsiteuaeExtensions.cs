//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asiteuae
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsiteuaeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteuae")]
        [WorkflowExpressionFactory(nameof(__BuildFILEDOWNLOADBYURL))]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL([WorkflowExpression] Func<string> downloadUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFILEDOWNLOADBYURL(WorkflowValue<string> downloadUrl)
        {
            WorkflowValue.Validate(downloadUrl, nameof(downloadUrl), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/downloadFileByUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(downloadUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteuae")]
        [WorkflowExpressionFactory(nameof(__BuildSETFILEMETADATA))]
        public IBodyWorkflowAction<string> SETFILEMETADATA([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<object> items = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSETFILEMETADATA(WorkflowValue<string> projectId, WorkflowValue<string> folderId, WorkflowValue<object> items = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(items, nameof(items), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/saveMetadataForUpload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Body = ExpressionConverter.ConvertO(items);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteuae")]
        [WorkflowExpressionFactory(nameof(__BuildUPLOADBINARYFILE))]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> fileBinary = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUPLOADBINARYFILE(WorkflowValue<string> projectId, WorkflowValue<string> folderId, WorkflowValue<string> fileName, WorkflowValue<string> metadataId, WorkflowValue<string> fileBinary = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(metadataId, nameof(metadataId), required: true);
            WorkflowValue.Validate(fileBinary, nameof(fileBinary), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }
    }

    public class AsiteuaeTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildASITETRIGGEREVENT))]
        public IWorkflowTrigger ASITETRIGGEREVENT([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildASITETRIGGEREVENT(WorkflowValue<string> projectId, WorkflowValue<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildASITETRIGGEREVENTAPPFORM))]
        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildASITETRIGGEREVENTAPPFORM(WorkflowValue<string> projectId, WorkflowValue<string> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asiteuae;

    public partial class WorkflowManagedActions
    {
        public AsiteuaeActions Asiteuae(string connectionId) => new AsiteuaeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsiteuaeTriggers Asiteuae(string connectionId) => new AsiteuaeTriggers(connectionId);
    }
}
