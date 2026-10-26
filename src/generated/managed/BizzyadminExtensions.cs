//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bizzyadmin
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BizzyadminActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<AdminRedactBotMessagePayload, ApiConnectionActionConfiguration> AdminRedactBotMessage(Expression<Func<AdminRedactBotMessageInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<AdminRedactBotMessagePayload, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/admin/redactBotMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<AdminRedactBotMessagePayload>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetAdminItem(Expression<Func<int>> type)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/admin/AdminItems/{0}", __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/admin/AdminItems/{0}", __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> UpdateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/admin/AdminItems/{0}", __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAdminItemById(Expression<Func<int>> type, Expression<Func<string>> id)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/admin/AdminItems/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAdminItem(Expression<Func<int>> type, Expression<Func<string>> id)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/admin/AdminItems/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BizzyadminTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsPostSkillModified(Expression<Func<WebHookRegistrationsPostSkillModifiedInput>> webHook, FlowRecurrence recurrence = null)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerAdmin_SkillModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AdminRedactBotMessagePayload
    {
        [JsonProperty("response")]
        public string Response { get; set; }
    }

    public class AdminRedactBotMessageInput
    {
        [JsonProperty("messageRef", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageReference { get; set; }

        [JsonProperty("redactionMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RedactionMessage { get; set; }
    }

    public class WebHook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("webHookUri")]
        public string WebHookUri { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class WebHookRegistrationsPostSkillModifiedInput
    {
        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bizzyadmin;

    public partial class WorkflowManagedActions
    {
        public BizzyadminActions Bizzyadmin(string connectionId) => new BizzyadminActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BizzyadminTriggers Bizzyadmin(string connectionId) => new BizzyadminTriggers(connectionId);
    }
}