//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asite
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsiteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asite")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL(Expression<Func<string>> downloadUrl)
        {
            var __workflow_downloadUrl = WorkflowExpression.Compile(downloadUrl, nameof(downloadUrl), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/downloadFileByUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(__workflow_downloadUrl);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asite")]
        public IBodyWorkflowAction<string> SETFILEMETADATA(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<object>> items = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/saveMetadataForUpload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_items);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asite")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> metadataId, Expression<Func<string>> fileBinary = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            var __workflow_fileBinary = WorkflowExpression.Compile(fileBinary, nameof(fileBinary), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/uploadFileFromExternalSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["metadataId"] = ExpressionConverter.Convert(__workflow_metadataId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileBinary);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class AsiteTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodytriggerName = WorkflowExpression.Compile(bodytriggerName, nameof(bodytriggerName), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/asitePullDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["resourceId"] = ExpressionConverter.ConvertO(__workflow_bodytriggerName);
                body["resourceType"] = 1;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodytriggerName = WorkflowExpression.Compile(bodytriggerName, nameof(bodytriggerName), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/asitePullAppFormDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["resourceId"] = ExpressionConverter.ConvertO(__workflow_bodytriggerName);
                body["resourceType"] = 1;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asite;

    public partial class WorkflowManagedActions
    {
        public AsiteActions Asite(string connectionId) => new AsiteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsiteTriggers Asite(string connectionId) => new AsiteTriggers(connectionId);
    }
}
