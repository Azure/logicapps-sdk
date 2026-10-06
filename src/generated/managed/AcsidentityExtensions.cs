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
        [WorkflowExpressionFactory(nameof(__BuildCreateCommunicationIdentity))]
        public IBodyWorkflowAction<CreateCommunicationIdentityResponse> CreateCommunicationIdentity([WorkflowExpression] Func<TokenScopes[]> bodytokenScopes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCommunicationIdentityResponse> __BuildCreateCommunicationIdentity(WorkflowExpression<TokenScopes[]> bodytokenScopes = null)
        {
            WorkflowExpression.Validate(bodytokenScopes, nameof(bodytokenScopes), required: false);
            return new DeferredBodyAction<CreateCommunicationIdentityResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteCommunicationIdentity))]
        public IWorkflowAction DeleteCommunicationIdentity([WorkflowExpression] Func<string> identityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteCommunicationIdentity(WorkflowExpression<string> identityId)
        {
            WorkflowExpression.Validate(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/identities/{0}", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [WorkflowExpressionFactory(nameof(__BuildIssueIdentityAccessToken))]
        public IBodyWorkflowAction<AccessTokenInfo> IssueIdentityAccessToken([WorkflowExpression] Func<string> identityId, [WorkflowExpression] Func<TokenScopes[]> bodytokenScopes)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccessTokenInfo> __BuildIssueIdentityAccessToken(WorkflowExpression<string> identityId, WorkflowExpression<TokenScopes[]> bodytokenScopes)
        {
            WorkflowExpression.Validate(identityId, nameof(identityId), required: true);
            WorkflowExpression.Validate(bodytokenScopes, nameof(bodytokenScopes), required: true);
            return new DeferredBodyAction<AccessTokenInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/identities/{0}/:issueAccessToken", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [WorkflowExpressionFactory(nameof(__BuildRevokeIdentityAccessTokens))]
        public IWorkflowAction RevokeIdentityAccessTokens([WorkflowExpression] Func<string> identityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRevokeIdentityAccessTokens(WorkflowExpression<string> identityId)
        {
            WorkflowExpression.Validate(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/identities/{0}/:revokeAccessTokens", ExpressionConverter.ConvertWithUrlEncoding(identityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                return new ApiConnectionAction(callPayload);
            });
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