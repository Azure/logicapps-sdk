//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prowfmauthentication
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProwfmauthenticationActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prowfmauthentication")]
        [WorkflowExpressionFactory(nameof(__BuildGetAccessToken))]
        public IBodyWorkflowAction<GetAccessTokenResponse> GetAccessToken([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyclientId, [WorkflowExpression] Func<string> bodyclientSecret)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prowfmauthentication")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAccessTokenResponse> __BuildGetAccessToken(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodypassword, WorkflowExpression<string> bodyclientId, WorkflowExpression<string> bodyclientSecret)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodyclientId, nameof(bodyclientId), required: true);
            WorkflowExpression.Validate(bodyclientSecret, nameof(bodyclientSecret), required: true);
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
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["client_id"] = ExpressionConverter.ConvertO(bodyclientId);
                bodypropCount++;
                body["client_secret"] = ExpressionConverter.ConvertO(bodyclientSecret);
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