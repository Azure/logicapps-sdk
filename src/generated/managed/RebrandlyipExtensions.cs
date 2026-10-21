//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rebrandlyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RebrandlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<GetAccountDetailsResponse> GetAccountDetails()
        {
            var apiCallPath = "/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAccountDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListDomainsResponseItem[]> ListDomains()
        {
            var apiCallPath = "/domains";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListDomainsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListLinksResponseItem[]> ListLinks(Expression<Func<string>> domainId = null, Expression<Func<string>> slashtag = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderDirInput>> orderDir = null, Expression<Func<int>> limit = null, Expression<Func<string>> workspace = null)
        {
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: false);
            var __workflow_slashtag = WorkflowExpression.Compile(slashtag, nameof(slashtag), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_orderDir = WorkflowExpression.Compile(orderDir, nameof(orderDir), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<ListLinksResponseItem[]>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_domainId != null)
                    callPayload.Queries["domain.id"] = ExpressionConverter.Convert(__workflow_domainId);
                if (__workflow_slashtag != null)
                    callPayload.Queries["slashtag"] = ExpressionConverter.Convert(__workflow_slashtag);
                if (__workflow_orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_orderDir != null)
                    callPayload.Queries["orderDir"] = ExpressionConverter.Convert(__workflow_orderDir);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionAction<ListLinksResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink(Expression<Func<string>> bodydestination = null, Expression<Func<string>> bodyslashtag = null, Expression<Func<string>> bodydomainid = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_bodydestination = WorkflowExpression.Compile(bodydestination, nameof(bodydestination), required: false);
            var __workflow_bodyslashtag = WorkflowExpression.Compile(bodyslashtag, nameof(bodyslashtag), required: false);
            var __workflow_bodydomainid = WorkflowExpression.Compile(bodydomainid, nameof(bodydomainid), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<CreateLinkResponse>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestination != null)
                {
                    body["destination"] = ExpressionConverter.ConvertO(__workflow_bodydestination);
                    bodypropCount++;
                }

                if (__workflow_bodyslashtag != null)
                {
                    body["slashtag"] = ExpressionConverter.ConvertO(__workflow_bodyslashtag);
                    bodypropCount++;
                }

                var domainObject = new JObject();
                var domainObjectpropCount = 0;
                if (__workflow_bodydomainid != null)
                {
                    domainObject["id"] = ExpressionConverter.ConvertO(__workflow_bodydomainid);
                    domainObjectpropCount++;
                }

                if (domainObjectpropCount > 0)
                {
                    body["domain"] = domainObject;
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[]> ListWorkspaces(Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderDirInput>> orderDir = null, Expression<Func<int>> limit = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_orderDir = WorkflowExpression.Compile(orderDir, nameof(orderDir), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListWorkspacesResponseItem[]>(() =>
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_orderDir != null)
                    callPayload.Queries["orderDir"] = ExpressionConverter.Convert(__workflow_orderDir);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListWorkspacesResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<GetLinkResponse> GetLink(Expression<Func<string>> id, Expression<Func<string>> workspace = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<GetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionAction<GetLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<DeleteLinkResponse> DeleteLink(Expression<Func<string>> id, Expression<Func<string>> workspace = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<DeleteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionAction<DeleteLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<UpdateLinkResponse> UpdateLink(Expression<Func<string>> id, Expression<Func<string>> workspace = null, Expression<Func<string>> bodydestinationURL = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            var __workflow_bodydestinationURL = WorkflowExpression.Compile(bodydestinationURL, nameof(bodydestinationURL), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<UpdateLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestinationURL != null)
                {
                    body["destination"] = ExpressionConverter.ConvertO(__workflow_bodydestinationURL);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class RebrandlyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAccountDetailsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subscription")]
        public GetAccountDetailsResponseSubscriptionType Subscription { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionType
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("limits")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsType Limits { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsType
    {
        [JsonProperty("links")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeLinksType Links { get; set; }

        [JsonProperty("domains")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeDomainsType Domains { get; set; }

        [JsonProperty("workspaces")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeWorkspacesType Workspaces { get; set; }

        [JsonProperty("teammates")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeTeammatesType Teammates { get; set; }

        [JsonProperty("tags")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeTagsType Tags { get; set; }

        [JsonProperty("scripts")]
        public GetAccountDetailsResponseSubscriptionTypeLimitsTypeScriptsType Scripts { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeLinksType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeDomainsType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeWorkspacesType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeTeammatesType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeTagsType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class GetAccountDetailsResponseSubscriptionTypeLimitsTypeScriptsType
    {
        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class ListDomainsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class ListLinksResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slashtag")]
        public string Slashtag { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public ListLinksResponseItemDomainType Domain { get; set; }
    }

    public class ListLinksResponseItemDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderByInput
    {
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        [EnumMember(Value = "updatedAt")]
        UpdatedAt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderDirInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CreateLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slashtag")]
        public string Slashtag { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public CreateLinkResponseDomainType Domain { get; set; }
    }

    public class CreateLinkResponseDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class ListWorkspacesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class GetLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slashtag")]
        public string Slashtag { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public GetLinkResponseDomainType Domain { get; set; }
    }

    public class GetLinkResponseDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class DeleteLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slashtag")]
        public string Slashtag { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public DeleteLinkResponseDomainType Domain { get; set; }
    }

    public class DeleteLinkResponseDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public class UpdateLinkResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slashtag")]
        public string Slashtag { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public UpdateLinkResponseDomainType Domain { get; set; }
    }

    public class UpdateLinkResponseDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rebrandlyip;

    public partial class WorkflowManagedActions
    {
        public RebrandlyipActions Rebrandlyip(string connectionId) => new RebrandlyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RebrandlyipTriggers Rebrandlyip(string connectionId) => new RebrandlyipTriggers(connectionId);
    }
}
