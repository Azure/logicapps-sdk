//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acsidentity
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcsidentityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IBodyWorkflowAction<CreateCommunicationIdentityResponse> CreateCommunicationIdentity([WorkflowExpression] Func<TokenScopes[]> bodytokenScopes = null)
        {
            var apiCallPath = "/identities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytokenScopes != null)
            {
                body["createTokenWithScopes"] = ExpressionConverter.ConvertO(bodytokenScopes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCommunicationIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IWorkflowAction DeleteCommunicationIdentity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> identityId)
        {
            var apiCallPath = String.Format("/identities/{0}", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IBodyWorkflowAction<AccessTokenInfo> IssueIdentityAccessToken([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> identityId, [WorkflowExpression] Func<TokenScopes[]> bodytokenScopes)
        {
            var apiCallPath = String.Format("/identities/{0}/:issueAccessToken", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["scopes"] = ExpressionConverter.ConvertO(bodytokenScopes);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AccessTokenInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IWorkflowAction RevokeIdentityAccessTokens([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> identityId)
        {
            var apiCallPath = String.Format("/identities/{0}/:revokeAccessTokens", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AcsidentityTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateCommunicationIdentityResponse
    {
        [JsonProperty("identity")]
        public CreateCommunicationIdentityResponseIdentityType Identity { get; set; }

        [JsonProperty("accessToken")]
        public AccessTokenInfo AccessToken { get; set; }
    }

    public class CreateCommunicationIdentityResponseIdentityType
    {
        [JsonProperty("id")]
        public string UserID { get; set; }
    }

    public class AccessTokenInfo
    {
        [JsonProperty("token")]
        public string AccessToken { get; set; }

        [JsonProperty("expiresOn")]
        public string TokenExpiry { get; set; }
    }

    public enum TokenScopes
    {
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "voip")]
        Voip
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acsidentity;

    public partial class WorkflowManagedActions
    {
        public AcsidentityActions Acsidentity(string connectionId) => new AcsidentityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcsidentityTriggers Acsidentity(string connectionId) => new AcsidentityTriggers(connectionId);
    }
}