//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seebotrunlink
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeebotrunlinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<GetLinksResponse, ApiConnectionActionConfiguration> GetLinks(Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey, Expression<Func<searchTypesInput>> searchTypes, Expression<Func<int>> domainId)
        {
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            var __workflow_searchTypes = WorkflowExpression.Compile(searchTypes, nameof(searchTypes), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<GetLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                callPayload.Queries["per_page"] = Convert.ToString(-1);
                callPayload.Queries["search_types"] = ExpressionConverter.Convert(__workflow_searchTypes);
                callPayload.Queries["domain_id"] = ExpressionConverter.Convert(__workflow_domainId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                return new ApiConnectionAction<GetLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreateLinkResponse, ApiConnectionActionConfiguration> CreateLink(Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey, Expression<Func<CreateLinkInput>> body)
        {
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<GetDomainsResponse, ApiConnectionActionConfiguration> GetDomains(Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey)
        {
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            return new DeferredBodyAction<GetDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                return new ApiConnectionAction<GetDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLink(Expression<Func<int>> id, Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<UpdateLinkResponse, ApiConnectionActionConfiguration> UpdateLink(Expression<Func<int>> id, Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey, Expression<Func<UpdateLinkInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePredefinedLink(Expression<Func<int>> id, Expression<Func<string>> key, Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}/predefined/{1}", __workflow_id.WithUrlEncoding(1), __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreatePredefinedLinkResponse, ApiConnectionActionConfiguration> CreatePredefinedLink(Expression<Func<int>> id, Expression<Func<string>> key, Expression<Func<int>> xSBRUserId, Expression<Func<string>> xSBRTokenKey, Expression<Func<CreatePredefinedLinkInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_xSBRUserId = WorkflowExpression.Compile(xSBRUserId, nameof(xSBRUserId), required: true);
            var __workflow_xSBRTokenKey = WorkflowExpression.Compile(xSBRTokenKey, nameof(xSBRTokenKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatePredefinedLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/links/{0}/predefined/{1}", __workflow_id.WithUrlEncoding(1), __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = ExpressionConverter.Convert(__workflow_xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = ExpressionConverter.Convert(__workflow_xSBRTokenKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePredefinedLinkResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CreateLinkInput
    {
        [JsonProperty("cache", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Cache { get; set; } = true;

        [JsonProperty("domain_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DomainId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("redirect", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Redirect { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLinkInputStatusType Status { get; set; } = CreateLinkInputStatusType.Active;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLinkInputTypeType Type { get; set; } = CreateLinkInputTypeType.Default;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLinkInputStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLinkInputTypeType
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

    public class UpdateLinkInput
    {
        [JsonProperty("cache", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Cache { get; set; } = true;

        [JsonProperty("domain_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DomainId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("redirect", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Redirect { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateLinkInputStatusType Status { get; set; } = UpdateLinkInputStatusType.Active;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateLinkInputStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
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

    public class CreatePredefinedLinkInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("redirect", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Redirect { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
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