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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FILEDOWNLOADBYURL(Expression<Func<string>> downloadUrl)
        {
            var __workflow_downloadUrl = WorkflowExpression.Compile(downloadUrl, nameof(downloadUrl), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/downloadFileByUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(__workflow_downloadUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asite")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SETFILEMETADATA(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<object>> items)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asite")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UPLOADBINARYFILE(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> metadataId, Expression<Func<string>> fileBinary)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            var __workflow_fileBinary = WorkflowExpression.Compile(fileBinary, nameof(fileBinary), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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

    public class AsiteTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ASITETRIGGEREVENT(Expression<Func<string>> projectId, Expression<Func<BodyInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/asitePullDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ASITETRIGGEREVENTAPPFORM(Expression<Func<string>> projectId, Expression<Func<BodyInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/asitePullAppFormDataWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        public BodyInput(string triggerName)
        {
            this.TriggerName = triggerName;
        }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerName { get; set; }

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int ResourceType { get; set; } = 1;
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