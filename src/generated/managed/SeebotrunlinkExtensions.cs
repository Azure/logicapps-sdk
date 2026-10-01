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
        public IBodyWorkflowAction<GetLinksResponse> GetLinks([WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey, [WorkflowExpression] Func<searchTypesInput> searchTypes, [WorkflowExpression] Func<int> domainId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                callPayload.Queries["per_page"] = Convert.ToString(-1);
                callPayload.Queries["search_types"] = SourceExpressionConverter.Convert(searchTypes);
                callPayload.Queries["domain_id"] = SourceExpressionConverter.ConvertO(domainId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetLinksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink([WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey, [WorkflowExpression] Func<bool> bodycache, [WorkflowExpression] Func<int> bodydomainId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyredirect, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<bodytypeInput> bodytype)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/links";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cache"] = SourceExpressionConverter.ConvertToken(bodycache);
                bodypropCount++;
                body["domain_id"] = SourceExpressionConverter.ConvertToken(bodydomainId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["redirect"] = SourceExpressionConverter.ConvertToken(bodyredirect);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<GetDomainsResponse> GetDomains([WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetDomainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction DeleteLink([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<UpdateLinkResponse> UpdateLink([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey, [WorkflowExpression] Func<bool> bodycache, [WorkflowExpression] Func<int> bodydomainId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyredirect, [WorkflowExpression] Func<bodystatusInput> bodystatus)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cache"] = SourceExpressionConverter.ConvertToken(bodycache);
                bodypropCount++;
                body["domain_id"] = SourceExpressionConverter.ConvertToken(bodydomainId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["redirect"] = SourceExpressionConverter.ConvertToken(bodyredirect);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IWorkflowAction DeletePredefinedLink([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}/predefined/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seebotrunlink")]
        public IBodyWorkflowAction<CreatePredefinedLinkResponse> CreatePredefinedLink([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<int> xSBRUserId, [WorkflowExpression] Func<string> xSBRTokenKey, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyredirect, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/links/{0}/predefined/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["X-SBR-UserID"] = SourceExpressionConverter.ConvertO(xSBRUserId);
                callPayload.Headers["X-SBR-TokenKey"] = SourceExpressionConverter.ConvertO(xSBRTokenKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["redirect"] = SourceExpressionConverter.ConvertToken(bodyredirect);
                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePredefinedLinkResponse>(BuildSourceInput);
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