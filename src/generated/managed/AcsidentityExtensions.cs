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
        public IBodyWorkflowAction<CreateCommunicationIdentityResponse, ApiConnectionActionConfiguration> CreateCommunicationIdentity(Expression<Func<CreateCommunicationIdentityInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateCommunicationIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/identities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCommunicationIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCommunicationIdentity(Expression<Func<string>> identityId)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/identities/{0}", __workflow_identityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IBodyWorkflowAction<AccessTokenInfo, ApiConnectionActionConfiguration> IssueIdentityAccessToken(Expression<Func<string>> identityId, Expression<Func<IssueIdentityAccessTokenInput>> body)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AccessTokenInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/identities/{0}/:issueAccessToken", __workflow_identityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-03-07");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccessTokenInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsidentity")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RevokeIdentityAccessTokens(Expression<Func<string>> identityId)
        {
            var __workflow_identityId = WorkflowExpression.Compile(identityId, nameof(identityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
        public string UserId { get; set; }
    }

    public class AccessTokenInfo
    {
        [JsonProperty("token")]
        public string AccessToken { get; set; }

        [JsonProperty("expiresOn")]
        public string TokenExpiry { get; set; }
    }

    public class CreateCommunicationIdentityInput
    {
        [JsonProperty("createTokenWithScopes")]
        public TokenScopes[] TokenScopes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TokenScopes
    {
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "voip")]
        Voip
    }

    public class IssueIdentityAccessTokenInput
    {
        [JsonProperty("scopes", DefaultValueHandling = DefaultValueHandling.Include)]
        public TokenScopes[] TokenScopes { get; set; } = new TokenScopes[]
        {
            (TokenScopes)0
        };
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