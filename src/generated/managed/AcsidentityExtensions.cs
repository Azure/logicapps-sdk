//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acsidentity
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcsidentityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IBodyWorkflowAction<CreateCommunicationIdentityResponse> CreateCommunicationIdentity(Expression<Func<TokenScopes[]>> bodytokenScopes = null)
        {
            var __workflow_bodytokenScopes = WorkflowExpression.Compile(bodytokenScopes, nameof(bodytokenScopes), required: false);
            return new DeferredBodyAction<CreateCommunicationIdentityResponse>(() =>
            {
                var apiCallPath = "/identities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytokenScopes != null)
                {
                    body["createTokenWithScopes"] = ExpressionConverter.ConvertO(__workflow_bodytokenScopes);
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
        public IWorkflowAction DeleteCommunicationIdentity(Expression<Func<string>> identityId)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/identities/{0}", __workflow_identityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IBodyWorkflowAction<AccessTokenInfo> IssueIdentityAccessToken(Expression<Func<string>> identityId, Expression<Func<TokenScopes[]>> bodytokenScopes)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            var __workflow_bodytokenScopes = WorkflowExpression.Compile(bodytokenScopes, nameof(bodytokenScopes), required: true);
            return new DeferredBodyAction<AccessTokenInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/identities/{0}/:issueAccessToken", __workflow_identityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scopes"] = ExpressionConverter.ConvertO(__workflow_bodytokenScopes);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AccessTokenInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IWorkflowAction RevokeIdentityAccessTokens(Expression<Func<string>> identityId)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/identities/{0}/:revokeAccessTokens", __workflow_identityId.WithUrlEncoding(1)));
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
