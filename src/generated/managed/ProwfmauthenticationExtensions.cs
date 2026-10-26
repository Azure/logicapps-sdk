//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prowfmauthentication
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProwfmauthenticationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prowfmauthentication")]
        public IBodyWorkflowAction<GetAccessTokenResponse, ApiConnectionActionConfiguration> GetAccessToken(Expression<Func<GetAccessTokenInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAccessTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/authentication/access_token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAccessTokenResponse>(callPayload);
            });
        }
    }

    public class ProwfmauthenticationTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAccessTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
    }

    public class GetAccessTokenInput
    {
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("client_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientId { get; set; }

        [JsonProperty("client_secret", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientSecret { get; set; }

        [JsonProperty("grant_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string GrantType { get; set; } = "password";

        [JsonProperty("auth_chain", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string AuthChain { get; set; } = "OAuthLdapService";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prowfmauthentication;

    public partial class WorkflowManagedActions
    {
        public ProwfmauthenticationActions Prowfmauthentication(string connectionId) => new ProwfmauthenticationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProwfmauthenticationTriggers Prowfmauthentication(string connectionId) => new ProwfmauthenticationTriggers(connectionId);
    }
}