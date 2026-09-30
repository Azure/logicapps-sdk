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
        public IBodyWorkflowAction<AdminRedactBotMessagePayload> AdminRedactBotMessage([WorkflowExpression] Func<string> contentmessageReference, [WorkflowExpression] Func<string> contentredactionMessage)
        {
            SourceExpression.Validate(contentmessageReference, nameof(contentmessageReference), required: true);
            SourceExpression.Validate(contentredactionMessage, nameof(contentredactionMessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/admin/redactBotMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["messageRef"] = SourceExpressionConverter.ConvertToken(contentmessageReference);
                contentpropCount++;
                content["redactionMessage"] = SourceExpressionConverter.ConvertToken(contentredactionMessage);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdminRedactBotMessagePayload>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[]> GetAdminItem([WorkflowExpression] Func<int> type)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/admin/AdminItems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken> CreateAdminItem([WorkflowExpression] Func<int> type, [WorkflowExpression] Func<object> content = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(content, nameof(content), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/admin/AdminItems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(content);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken[]> UpdateAdminItem([WorkflowExpression] Func<int> type, [WorkflowExpression] Func<object> content = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(content, nameof(content), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/admin/AdminItems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(content);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IBodyWorkflowAction<JToken> GetAdminItemById([WorkflowExpression] Func<int> type, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/admin/AdminItems/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzyadmin")]
        public IWorkflowAction DeleteAdminItem([WorkflowExpression] Func<int> type, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/admin/AdminItems/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class BizzyadminTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPostSkillModified([WorkflowExpression] Func<string[]> webHookfilters = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/webhooks/registerAdmin_SkillModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (webHookfilters != null)
                {
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHook>(BuildSourceInput, triggerName, recurrence);
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