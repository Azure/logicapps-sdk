//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prowfmauthentication
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ProwfmauthenticationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prowfmauthentication")]
        public IBodyWorkflowAction<GetAccessTokenResponse> GetAccessToken(Expression<Func<string>> bodyusername, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyclientId, Expression<Func<string>> bodyclientSecret)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodyclientId = bodyclientId == null ? null : WorkflowExpression.Compile(bodyclientId);
            WorkflowExpression.Validate(__workflow_bodyclientId, nameof(bodyclientId), required: true);
            var __workflow_bodyclientSecret = bodyclientSecret == null ? null : WorkflowExpression.Compile(bodyclientSecret);
            WorkflowExpression.Validate(__workflow_bodyclientSecret, nameof(bodyclientSecret), required: true);
            return new DeferredBodyAction<GetAccessTokenResponse>(() =>
            {
                var apiCallPath = "/api/authentication/access_token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["client_id"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                bodypropCount++;
                body["client_secret"] = ExpressionConverter.ConvertO(__workflow_bodyclientSecret);
                body["grant_type"] = "password";
                bodypropCount++;
                body["auth_chain"] = "OAuthLdapService";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
