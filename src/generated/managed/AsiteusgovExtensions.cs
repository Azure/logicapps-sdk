//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asiteusgov
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AsiteusgovActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL(Expression<Func<string>> downloadUrl)
        {
            var __workflow_downloadUrl = downloadUrl == null ? null : WorkflowExpression.Compile(downloadUrl);
            WorkflowExpression.Validate(__workflow_downloadUrl, nameof(downloadUrl), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/downloadFileByUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(__workflow_downloadUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<string> SETFILEMETADATA(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<object>> items = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_items = items == null ? null : WorkflowExpression.Compile(items);
            WorkflowExpression.Validate(__workflow_items, nameof(items), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/saveMetadataForUpload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_items);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> metadataId, Expression<Func<string>> fileBinary = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_fileName = fileName == null ? null : WorkflowExpression.Compile(fileName);
            WorkflowExpression.Validate(__workflow_fileName, nameof(fileName), required: true);
            var __workflow_metadataId = metadataId == null ? null : WorkflowExpression.Compile(metadataId);
            WorkflowExpression.Validate(__workflow_metadataId, nameof(metadataId), required: true);
            var __workflow_fileBinary = fileBinary == null ? null : WorkflowExpression.Compile(fileBinary);
            WorkflowExpression.Validate(__workflow_fileBinary, nameof(fileBinary), required: false);
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
            });
        }
    }

    public class AsiteusgovTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_bodytriggerName = bodytriggerName == null ? null : WorkflowExpression.Compile(bodytriggerName);
            WorkflowExpression.Validate(__workflow_bodytriggerName, nameof(bodytriggerName), required: true);
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
            });
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_bodytriggerName = bodytriggerName == null ? null : WorkflowExpression.Compile(bodytriggerName);
            WorkflowExpression.Validate(__workflow_bodytriggerName, nameof(bodytriggerName), required: true);
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
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asiteusgov;

    public partial class WorkflowManagedActions
    {
        public AsiteusgovActions Asiteusgov(string connectionId) => new AsiteusgovActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsiteusgovTriggers Asiteusgov(string connectionId) => new AsiteusgovTriggers(connectionId);
    }
}
