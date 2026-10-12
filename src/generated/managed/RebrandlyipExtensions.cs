//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rebrandlyip
{
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
        [WorkflowExpressionFactory(nameof(__BuildListLinks))]
        public IBodyWorkflowAction<ListLinksResponseItem[]> ListLinks([WorkflowExpression] Func<string> domainId = null, [WorkflowExpression] Func<string> slashtag = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderDirInput> orderDir = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> workspace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListLinksResponseItem[]> __BuildListLinks(WorkflowExpression<string> domainId = null, WorkflowExpression<string> slashtag = null, WorkflowExpression<orderByInput> orderBy = null, WorkflowExpression<orderDirInput> orderDir = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> workspace = null)
        {
            WorkflowExpression.Validate(domainId, nameof(domainId), required: false);
            WorkflowExpression.Validate(slashtag, nameof(slashtag), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowExpression.Validate(orderDir, nameof(orderDir), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<ListLinksResponseItem[]>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (domainId != null)
                    callPayload.Queries["domain.id"] = ExpressionConverter.Convert(domainId);
                if (slashtag != null)
                    callPayload.Queries["slashtag"] = ExpressionConverter.Convert(slashtag);
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(orderBy);
                if (orderDir != null)
                    callPayload.Queries["orderDir"] = ExpressionConverter.Convert(orderDir);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(workspace);
                return new ApiConnectionAction<ListLinksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLink))]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink([WorkflowExpression] Func<string> bodydestination = null, [WorkflowExpression] Func<string> bodyslashtag = null, [WorkflowExpression] Func<string> bodydomainid = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateLinkResponse> __BuildCreateLink(WorkflowExpression<string> bodydestination = null, WorkflowExpression<string> bodyslashtag = null, WorkflowExpression<string> bodydomainid = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(bodydestination, nameof(bodydestination), required: false);
            WorkflowExpression.Validate(bodyslashtag, nameof(bodyslashtag), required: false);
            WorkflowExpression.Validate(bodydomainid, nameof(bodydomainid), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<CreateLinkResponse>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestination != null)
                {
                    body["destination"] = ExpressionConverter.ConvertO(bodydestination);
                    bodypropCount++;
                }

                if (bodyslashtag != null)
                {
                    body["slashtag"] = ExpressionConverter.ConvertO(bodyslashtag);
                    bodypropCount++;
                }

                var domainObject = new JObject();
                var domainObjectpropCount = 0;
                if (bodydomainid != null)
                {
                    domainObject["id"] = ExpressionConverter.ConvertO(bodydomainid);
                    domainObjectpropCount++;
                }

                if (domainObjectpropCount > 0)
                {
                    body["domain"] = domainObject;
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        [WorkflowExpressionFactory(nameof(__BuildListWorkspaces))]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[]> ListWorkspaces([WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderDirInput> orderDir = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[]> __BuildListWorkspaces(WorkflowExpression<orderByInput> orderBy = null, WorkflowExpression<orderDirInput> orderDir = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowExpression.Validate(orderDir, nameof(orderDir), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListWorkspacesResponseItem[]>(() =>
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(orderBy);
                if (orderDir != null)
                    callPayload.Queries["orderDir"] = ExpressionConverter.Convert(orderDir);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<ListWorkspacesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLink))]
        public IBodyWorkflowAction<GetLinkResponse> GetLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLinkResponse> __BuildGetLink(WorkflowExpression<string> id, WorkflowExpression<string> workspace = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<GetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/links/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(workspace);
                return new ApiConnectionAction<GetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteLink))]
        public IBodyWorkflowAction<DeleteLinkResponse> DeleteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteLinkResponse> __BuildDeleteLink(WorkflowExpression<string> id, WorkflowExpression<string> workspace = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<DeleteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/links/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(workspace);
                return new ApiConnectionAction<DeleteLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLink))]
        public IBodyWorkflowAction<UpdateLinkResponse> UpdateLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null, [WorkflowExpression] Func<string> bodydestinationURL = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateLinkResponse> __BuildUpdateLink(WorkflowExpression<string> id, WorkflowExpression<string> workspace = null, WorkflowExpression<string> bodydestinationURL = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(workspace, nameof(workspace), required: false);
            WorkflowExpression.Validate(bodydestinationURL, nameof(bodydestinationURL), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<UpdateLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/links/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = ExpressionConverter.Convert(workspace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestinationURL != null)
                {
                    body["destination"] = ExpressionConverter.ConvertO(bodydestinationURL);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateLinkResponse>(callPayload);
            });
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