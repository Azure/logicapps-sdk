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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFILEDOWNLOADBYURL(WorkflowExpression<string> downloadUrl)
        {
            WorkflowExpression.Validate(downloadUrl, nameof(downloadUrl), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSETFILEMETADATA(WorkflowExpression<string> projectId, WorkflowExpression<string> folderId, WorkflowExpression<object> items = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(items, nameof(items), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUPLOADBINARYFILE(WorkflowExpression<string> projectId, WorkflowExpression<string> folderId, WorkflowExpression<string> fileName, WorkflowExpression<string> metadataId, WorkflowExpression<string> fileBinary = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(metadataId, nameof(metadataId), required: true);
            WorkflowExpression.Validate(fileBinary, nameof(fileBinary), required: false);
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
        public IWorkflowTrigger ASITETRIGGEREVENT([WorkflowExpression] Func<string> projectId,[WorkflowExpression] Func<string> bodytriggerName,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildASITETRIGGEREVENT(WorkflowExpression<string> projectId,WorkflowExpression<string> bodytriggerName,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildASITETRIGGEREVENTAPPFORM))]
        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM([WorkflowExpression] Func<string> projectId,[WorkflowExpression] Func<string> bodytriggerName,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildASITETRIGGEREVENTAPPFORM(WorkflowExpression<string> projectId,WorkflowExpression<string> bodytriggerName,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodytriggerName, nameof(bodytriggerName), required: true);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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