//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudskyaddins
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudskyaddinsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IBodyWorkflowAction<PowerAutomateUIApiValidateUserIdentityTokenResponse, ApiConnectionActionConfiguration> ValidateUserIdentityToken(Expression<Func<ValidateUserIdentityTokenInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PowerAutomateUIApiValidateUserIdentityTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomateui/v1/useridentitytoken/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PowerAutomateUIApiValidateUserIdentityTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendHttpRequest(Expression<Func<SendHttpRequestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudskyaddinsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PowerAutomateUIApiValidateUserIdentityTokenResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("family_name")]
        public string LastName { get; set; }

        [JsonProperty("given_name")]
        public string FirstName { get; set; }

        [JsonProperty("application_id")]
        public string SKYApplicationId { get; set; }

        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }
    }

    public class ValidateUserIdentityTokenInput
    {
        [JsonProperty("uit", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentityToken { get; set; }

        [JsonProperty("application_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApplicationId { get; set; }
    }

    public class SendHttpRequestInput
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendHttpRequestInputMethodType Method { get; set; } = SendHttpRequestInputMethodType.GET;

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RelativePath { get; set; }

        [JsonProperty("query")]
        public JToken QueryParameters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendHttpRequestInputMethodType
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudskyaddins;

    public partial class WorkflowManagedActions
    {
        public BlackbaudskyaddinsActions Blackbaudskyaddins(string connectionId) => new BlackbaudskyaddinsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudskyaddinsTriggers Blackbaudskyaddins(string connectionId) => new BlackbaudskyaddinsTriggers(connectionId);
    }
}