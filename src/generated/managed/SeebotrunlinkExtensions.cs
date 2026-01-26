//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seebotrunlink
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeebotrunlinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<GetLinksResponse> GetLinks(Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey, Expression<Func<searchTypesInput>> searchTypes, Expression<Func<int>> domainId)
        {
            var apiCallPath = "/links";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            callPayload.Queries["per_page"] = Convert.ToString(-1);
            callPayload.Queries["search_types"] = ExpressionConverter.Convert(searchTypes);
            callPayload.Queries["domain_id"] = ExpressionConverter.Convert(domainId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            return new ApiConnectionAction<GetLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink(Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey, Expression<Func<bool>> bodycache, Expression<Func<int>> bodydomainId, Expression<Func<string>> bodyname, Expression<Func<string>> bodypath, Expression<Func<string>> bodyredirect, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<bodytypeInput>> bodytype)
        {
            var apiCallPath = "/links";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cache"] = ExpressionConverter.ConvertO(bodycache);
            bodypropCount++;
            body["domain_id"] = ExpressionConverter.ConvertO(bodydomainId);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["redirect"] = ExpressionConverter.ConvertO(bodyredirect);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<GetDomainsResponse> GetDomains(Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey)
        {
            var apiCallPath = "/domains";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            return new ApiConnectionAction<GetDomainsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction DeleteLink(Expression<Func<int>> id, Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey)
        {
            var apiCallPath = String.Format("/links/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<UpdateLinkResponse> UpdateLink(Expression<Func<int>> id, Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey, Expression<Func<bool>> bodycache, Expression<Func<int>> bodydomainId, Expression<Func<string>> bodyname, Expression<Func<string>> bodypath, Expression<Func<string>> bodyredirect, Expression<Func<bodystatusInput>> bodystatus)
        {
            var apiCallPath = String.Format("/links/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cache"] = ExpressionConverter.ConvertO(bodycache);
            bodypropCount++;
            body["domain_id"] = ExpressionConverter.ConvertO(bodydomainId);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["redirect"] = ExpressionConverter.ConvertO(bodyredirect);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction DeletePredefinedLink(Expression<Func<int>> id, Expression<Func<string>> key, Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey)
        {
            var apiCallPath = String.Format("/links/{0}/predefined/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreatePredefinedLinkResponse> CreatePredefinedLink(Expression<Func<int>> id, Expression<Func<string>> key, Expression<Func<int>> xSBRUserID, Expression<Func<string>> xSBRTokenKey, Expression<Func<string>> bodypath, Expression<Func<string>> bodyredirect, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = String.Format("/links/{0}/predefined/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(xSBRUserID);
            callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(xSBRTokenKey);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["redirect"] = ExpressionConverter.ConvertO(bodyredirect);
            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePredefinedLinkResponse>(callPayload);
        }
    }

    public class SeebotrunlinkTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLinksResponse
    {
        [JsonProperty("data")]
        public GetLinksResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetLinksResponseMetaType Meta { get; set; }
    }

    public class GetLinksResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        [JsonProperty("cache")]
        public bool Cache { get; set; }

        [JsonProperty("health_checked_at")]
        public string HealthCheckedAt { get; set; }

        [JsonProperty("domain_id")]
        public int DomainId { get; set; }

        [JsonProperty("generated_url")]
        public string GeneratedUrl { get; set; }

        [JsonProperty("domain")]
        public GetLinksResponseDataTypeItemDomainType Domain { get; set; }
    }

    public class GetLinksResponseDataTypeItemDomainType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("default_root_url")]
        public string DefaultRootUrl { get; set; }

        [JsonProperty("default_catchall_url")]
        public string DefaultCatchallUrl { get; set; }
    }

    public class GetLinksResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public enum searchTypesInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "predefined")]
        Predefined,
        [EnumMember(Value = "trackable_chat")]
        TrackableChat,
        [EnumMember(Value = "trackable_text")]
        TrackableText
    }

    public class CreateLinkResponse
    {
        [JsonProperty("data")]
        public CreateLinkResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public CreateLinkResponseMetaType Meta { get; set; }
    }

    public class CreateLinkResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        [JsonProperty("cache")]
        public bool Cache { get; set; }

        [JsonProperty("health_checked_at")]
        public string HealthCheckedAt { get; set; }

        [JsonProperty("domain_id")]
        public int DomainId { get; set; }

        [JsonProperty("generated_url")]
        public string GeneratedUrl { get; set; }

        [JsonProperty("domain")]
        public CreateLinkResponseDataTypeItemDomainType Domain { get; set; }
    }

    public class CreateLinkResponseDataTypeItemDomainType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("default_root_url")]
        public string DefaultRootUrl { get; set; }

        [JsonProperty("default_catchall_url")]
        public string DefaultCatchallUrl { get; set; }
    }

    public class CreateLinkResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "predefined")]
        Predefined,
        [EnumMember(Value = "trackable_chat")]
        TrackableChat,
        [EnumMember(Value = "trackable_text")]
        TrackableText
    }

    public class GetDomainsResponse
    {
        [JsonProperty("data")]
        public GetDomainsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetDomainsResponseMetaType Meta { get; set; }
    }

    public class GetDomainsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("default_root_url")]
        public string DefaultRootUrl { get; set; }

        [JsonProperty("default_catchall_url")]
        public string DefaultCatchallUrl { get; set; }
    }

    public class GetDomainsResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public class UpdateLinkResponse
    {
        [JsonProperty("data")]
        public UpdateLinkResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public UpdateLinkResponseMetaType Meta { get; set; }
    }

    public class UpdateLinkResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }

        [JsonProperty("cache")]
        public bool Cache { get; set; }

        [JsonProperty("health_checked_at")]
        public string HealthCheckedAt { get; set; }

        [JsonProperty("domain_id")]
        public int DomainId { get; set; }

        [JsonProperty("generated_url")]
        public string GeneratedUrl { get; set; }

        [JsonProperty("domain")]
        public UpdateLinkResponseDataTypeItemDomainType Domain { get; set; }
    }

    public class UpdateLinkResponseDataTypeItemDomainType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("default_root_url")]
        public string DefaultRootUrl { get; set; }

        [JsonProperty("default_catchall_url")]
        public string DefaultCatchallUrl { get; set; }
    }

    public class UpdateLinkResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public class CreatePredefinedLinkResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("generated_url")]
        public string GeneratedUrl { get; set; }

        [JsonProperty("link_id")]
        public int LinkId { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seebotrunlink;

    public partial class WorkflowManagedActions
    {
        public SeebotrunlinkActions Seebotrunlink(string connectionId) => new SeebotrunlinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeebotrunlinkTriggers Seebotrunlink(string connectionId) => new SeebotrunlinkTriggers(connectionId);
    }
}