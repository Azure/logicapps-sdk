//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bizzyadmin
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BizzyadminActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<AdminRedactBotMessagePayload> AdminRedactBotMessage(Expression<Func<string>> contentmessageReference, Expression<Func<string>> contentredactionMessage)
        {
            var apiCallPath = "/api/triggers/admin/redactBotMessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["messageRef"] = ExpressionConverter.ConvertO(contentmessageReference);
            contentpropCount++;
            content["redactionMessage"] = ExpressionConverter.ConvertO(contentredactionMessage);
            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<AdminRedactBotMessagePayload>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[]> GetAdminItem(Expression<Func<int>> type)
        {
            var apiCallPath = String.Format("/api/triggers/admin/AdminItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken> CreateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content = null)
        {
            var apiCallPath = String.Format("/api/triggers/admin/AdminItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[]> UpdateAdminItem(Expression<Func<int>> type, Expression<Func<object>> content = null)
        {
            var apiCallPath = String.Format("/api/triggers/admin/AdminItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken> GetAdminItemById(Expression<Func<int>> type, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/triggers/admin/AdminItems/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IWorkflowAction DeleteAdminItem(Expression<Func<int>> type, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/triggers/admin/AdminItems/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class BizzyadminTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPostSkillModified(Expression<Func<string[]>> webHookfilters = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerAdmin_SkillModified";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
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

            return new ApiConnectionTrigger<WebHook>(callPayload, triggerName, recurrence);
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