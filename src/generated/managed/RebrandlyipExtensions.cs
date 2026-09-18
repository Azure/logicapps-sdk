//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rebrandlyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RebrandlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<GetAccountDetailsResponse> GetAccountDetails()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAccountDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListDomainsResponseItem[]> ListDomains()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDomainsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListLinksResponseItem[]> ListLinks([WorkflowExpression] Func<string> domainId = null, [WorkflowExpression] Func<string> slashtag = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderDirInput> orderDir = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> workspace = null)
        {
            SourceExpression.Validate(domainId, nameof(domainId), required: false);
            SourceExpression.Validate(slashtag, nameof(slashtag), required: false);
            SourceExpression.Validate(orderBy, nameof(orderBy), required: false);
            SourceExpression.Validate(orderDir, nameof(orderDir), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(workspace, nameof(workspace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (domainId != null)
                    callPayload.Queries["domain.id"] = SourceExpressionConverter.ConvertO(domainId);
                if (slashtag != null)
                    callPayload.Queries["slashtag"] = SourceExpressionConverter.ConvertO(slashtag);
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = SourceExpressionConverter.Convert(orderBy);
                if (orderDir != null)
                    callPayload.Queries["orderDir"] = SourceExpressionConverter.Convert(orderDir);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionAction<ListLinksResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink([WorkflowExpression] Func<string> bodydestination = null, [WorkflowExpression] Func<string> bodyslashtag = null, [WorkflowExpression] Func<string> bodydomainid = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(bodydestination, nameof(bodydestination), required: false);
            SourceExpression.Validate(bodyslashtag, nameof(bodyslashtag), required: false);
            SourceExpression.Validate(bodydomainid, nameof(bodydomainid), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestination != null)
                {
                    body["destination"] = SourceExpressionConverter.ConvertToken(bodydestination);
                    bodypropCount++;
                }

                if (bodyslashtag != null)
                {
                    body["slashtag"] = SourceExpressionConverter.ConvertToken(bodyslashtag);
                    bodypropCount++;
                }

                var domainObject = new JObject();
                var domainObjectpropCount = 0;
                if (bodydomainid != null)
                {
                    domainObject["id"] = SourceExpressionConverter.ConvertToken(bodydomainid);
                    domainObjectpropCount++;
                }

                if (domainObjectpropCount > 0)
                {
                    body["domain"] = domainObject;
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[]> ListWorkspaces([WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderDirInput> orderDir = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(orderBy, nameof(orderBy), required: false);
            SourceExpression.Validate(orderDir, nameof(orderDir), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = SourceExpressionConverter.Convert(orderBy);
                if (orderDir != null)
                    callPayload.Queries["orderDir"] = SourceExpressionConverter.Convert(orderDir);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<ListWorkspacesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<GetLinkResponse> GetLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(workspace, nameof(workspace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionAction<GetLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<DeleteLinkResponse> DeleteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(workspace, nameof(workspace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrandlyip")]
        public IBodyWorkflowAction<UpdateLinkResponse> UpdateLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workspace = null, [WorkflowExpression] Func<string> bodydestinationURL = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(workspace, nameof(workspace), required: false);
            SourceExpression.Validate(bodydestinationURL, nameof(bodydestinationURL), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Headers["Workspace"] = SourceExpressionConverter.ConvertO(workspace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestinationURL != null)
                {
                    body["destination"] = SourceExpressionConverter.ConvertToken(bodydestinationURL);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateLinkResponse>(BuildSourceInput);
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

    public enum orderByInput
    {
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        [EnumMember(Value = "updatedAt")]
        UpdatedAt
    }

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