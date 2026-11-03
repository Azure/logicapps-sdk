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
        public IBodyWorkflowAction<AdminRedactBotMessagePayload, ApiConnectionActionConfiguration> AdminRedactBotMessage(Expression<Func<string>> contentmessageReference, Expression<Func<string>> contentredactionMessage)
        {
            var __workflow_contentmessageReference = WorkflowExpression.Compile(contentmessageReference, nameof(contentmessageReference), required: true);
            var __workflow_contentredactionMessage = WorkflowExpression.Compile(contentredactionMessage, nameof(contentredactionMessage), required: true);
            return new DeferredBodyAction<AdminRedactBotMessagePayload, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/admin/redactBotMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["messageRef"] = ExpressionConverter.ConvertO(__workflow_contentmessageReference);
                contentpropCount++;
                content["redactionMessage"] = ExpressionConverter.ConvertO(__workflow_contentredactionMessage);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
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
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> UpdateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
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
        public IBodyWorkflowTrigger<WebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsPostSkillModified(Expression<Func<string[]>> webHookfilters = null, FlowRecurrence recurrence = null)
        {
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            return new DeferredBodyTrigger<WebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerAdmin_SkillModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
                    webHookpropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    webHook["headers"] = headersObject;
                    webHookpropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    webHook["properties"] = propertiesObject;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AdminRedactBotMessagePayload
    {
        [JsonProperty("response")]
        public string Response { get; set; }
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