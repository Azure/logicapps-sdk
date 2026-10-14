//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openpm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OpenpmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<PackagesResponse> PackagesGET(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            return new DeferredBodyAction<PackagesResponse>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PackagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesPOST(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymachineName = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyversion = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodypublishedAt = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymachineDescription = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyopenapi = null)
        {
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodymachineName = bodymachineName == null ? null : WorkflowExpression.Compile(bodymachineName);
            WorkflowExpression.Validate(__workflow_bodymachineName, nameof(bodymachineName), required: false);
            var __workflow_bodydomain = bodydomain == null ? null : WorkflowExpression.Compile(bodydomain);
            WorkflowExpression.Validate(__workflow_bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyversion = bodyversion == null ? null : WorkflowExpression.Compile(bodyversion);
            WorkflowExpression.Validate(__workflow_bodyversion, nameof(bodyversion), required: false);
            var __workflow_bodycreatedAt = bodycreatedAt == null ? null : WorkflowExpression.Compile(bodycreatedAt);
            WorkflowExpression.Validate(__workflow_bodycreatedAt, nameof(bodycreatedAt), required: false);
            var __workflow_bodyupdatedAt = bodyupdatedAt == null ? null : WorkflowExpression.Compile(bodyupdatedAt);
            WorkflowExpression.Validate(__workflow_bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            var __workflow_bodypublishedAt = bodypublishedAt == null ? null : WorkflowExpression.Compile(bodypublishedAt);
            WorkflowExpression.Validate(__workflow_bodypublishedAt, nameof(bodypublishedAt), required: false);
            var __workflow_bodylogoUrl = bodylogoUrl == null ? null : WorkflowExpression.Compile(bodylogoUrl);
            WorkflowExpression.Validate(__workflow_bodylogoUrl, nameof(bodylogoUrl), required: false);
            var __workflow_bodycontactEmail = bodycontactEmail == null ? null : WorkflowExpression.Compile(bodycontactEmail);
            WorkflowExpression.Validate(__workflow_bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymachineDescription = bodymachineDescription == null ? null : WorkflowExpression.Compile(bodymachineDescription);
            WorkflowExpression.Validate(__workflow_bodymachineDescription, nameof(bodymachineDescription), required: false);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyopenapi = bodyopenapi == null ? null : WorkflowExpression.Compile(bodyopenapi);
            WorkflowExpression.Validate(__workflow_bodyopenapi, nameof(bodyopenapi), required: false);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymachineName != null)
                {
                    body["machine_name"] = ExpressionConverter.ConvertO(__workflow_bodymachineName);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(__workflow_bodycreatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(__workflow_bodypublishedAt);
                    bodypropCount++;
                }

                if (__workflow_bodylogoUrl != null)
                {
                    body["logo_url"] = ExpressionConverter.ConvertO(__workflow_bodylogoUrl);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmail != null)
                {
                    body["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodymachineDescription != null)
                {
                    body["machine_description"] = ExpressionConverter.ConvertO(__workflow_bodymachineDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyopenapi != null)
                {
                    body["openapi"] = ExpressionConverter.ConvertO(__workflow_bodyopenapi);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Package>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package[]> PackagesLookupGET(Expression<Func<string>> ids = null)
        {
            var __workflow_ids = ids == null ? null : WorkflowExpression.Compile(ids);
            WorkflowExpression.Validate(__workflow_ids, nameof(ids), required: false);
            return new DeferredBodyAction<Package[]>(() =>
            {
                var apiCallPath = "/packages/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<Package[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesByPackageIdGET(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = packageId == null ? null : WorkflowExpression.Compile(packageId);
            WorkflowExpression.Validate(__workflow_packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Package>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesByPackageIdPOST(Expression<Func<string>> packageId, Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymachineName = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyversion = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodypublishedAt = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymachineDescription = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyopenapi = null)
        {
            var __workflow_packageId = packageId == null ? null : WorkflowExpression.Compile(packageId);
            WorkflowExpression.Validate(__workflow_packageId, nameof(packageId), required: true);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodymachineName = bodymachineName == null ? null : WorkflowExpression.Compile(bodymachineName);
            WorkflowExpression.Validate(__workflow_bodymachineName, nameof(bodymachineName), required: false);
            var __workflow_bodydomain = bodydomain == null ? null : WorkflowExpression.Compile(bodydomain);
            WorkflowExpression.Validate(__workflow_bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyversion = bodyversion == null ? null : WorkflowExpression.Compile(bodyversion);
            WorkflowExpression.Validate(__workflow_bodyversion, nameof(bodyversion), required: false);
            var __workflow_bodycreatedAt = bodycreatedAt == null ? null : WorkflowExpression.Compile(bodycreatedAt);
            WorkflowExpression.Validate(__workflow_bodycreatedAt, nameof(bodycreatedAt), required: false);
            var __workflow_bodyupdatedAt = bodyupdatedAt == null ? null : WorkflowExpression.Compile(bodyupdatedAt);
            WorkflowExpression.Validate(__workflow_bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            var __workflow_bodypublishedAt = bodypublishedAt == null ? null : WorkflowExpression.Compile(bodypublishedAt);
            WorkflowExpression.Validate(__workflow_bodypublishedAt, nameof(bodypublishedAt), required: false);
            var __workflow_bodylogoUrl = bodylogoUrl == null ? null : WorkflowExpression.Compile(bodylogoUrl);
            WorkflowExpression.Validate(__workflow_bodylogoUrl, nameof(bodylogoUrl), required: false);
            var __workflow_bodycontactEmail = bodycontactEmail == null ? null : WorkflowExpression.Compile(bodycontactEmail);
            WorkflowExpression.Validate(__workflow_bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymachineDescription = bodymachineDescription == null ? null : WorkflowExpression.Compile(bodymachineDescription);
            WorkflowExpression.Validate(__workflow_bodymachineDescription, nameof(bodymachineDescription), required: false);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyopenapi = bodyopenapi == null ? null : WorkflowExpression.Compile(bodyopenapi);
            WorkflowExpression.Validate(__workflow_bodyopenapi, nameof(bodyopenapi), required: false);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymachineName != null)
                {
                    body["machine_name"] = ExpressionConverter.ConvertO(__workflow_bodymachineName);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(__workflow_bodycreatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(__workflow_bodypublishedAt);
                    bodypropCount++;
                }

                if (__workflow_bodylogoUrl != null)
                {
                    body["logo_url"] = ExpressionConverter.ConvertO(__workflow_bodylogoUrl);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmail != null)
                {
                    body["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodymachineDescription != null)
                {
                    body["machine_description"] = ExpressionConverter.ConvertO(__workflow_bodymachineDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyopenapi != null)
                {
                    body["openapi"] = ExpressionConverter.ConvertO(__workflow_bodyopenapi);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Package>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<PackagesOpenapiResponse> PackagesOpenapiByPackageIdGET(Expression<Func<string>> packageId, Expression<Func<formatInput>> format = null)
        {
            var __workflow_packageId = packageId == null ? null : WorkflowExpression.Compile(packageId);
            WorkflowExpression.Validate(__workflow_packageId, nameof(packageId), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            return new DeferredBodyAction<PackagesOpenapiResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/openapi", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction<PackagesOpenapiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin> PackagesAiPluginByPackageIdGET(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = packageId == null ? null : WorkflowExpression.Compile(packageId);
            WorkflowExpression.Validate(__workflow_packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<AiPlugin>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/ai-plugin", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AiPlugin>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsSearchGET(Expression<Func<string>> query, Expression<Func<int>> limit = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            return new DeferredBodyAction<AiPlugin[]>(() =>
            {
                var apiCallPath = "/ai-plugins/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<AiPlugin[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsLookupGET(Expression<Func<string>> ids = null)
        {
            var __workflow_ids = ids == null ? null : WorkflowExpression.Compile(ids);
            WorkflowExpression.Validate(__workflow_ids, nameof(ids), required: false);
            return new DeferredBodyAction<AiPlugin[]>(() =>
            {
                var apiCallPath = "/ai-plugins/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<AiPlugin[]>(callPayload);
            });
        }
    }

    public class OpenpmTriggers([ConnectionName] string connectionId)
    {
    }

    public class PackagesResponse
    {
        [JsonProperty("items")]
        public PackageLite[] Items { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class PackageLite
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("machine_name")]
        public string MachineName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("machine_description")]
        public string MachineDescription { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class Package
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("machine_name")]
        public string MachineName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("machine_description")]
        public string MachineDescription { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("openapi")]
        public string Openapi { get; set; }
    }

    public class PackagesOpenapiResponse
    {
        [JsonProperty("openapi")]
        public string Openapi { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public class Info
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "yaml")]
        Yaml
    }

    public class AiPlugin
    {
        [JsonProperty("schema_version")]
        public string SchemaVersion { get; set; }

        [JsonProperty("name_for_human")]
        public string NameForHuman { get; set; }

        [JsonProperty("name_for_model")]
        public string NameForModel { get; set; }

        [JsonProperty("description_for_human")]
        public string DescriptionForHuman { get; set; }

        [JsonProperty("description_for_model")]
        public string DescriptionForModel { get; set; }

        [JsonProperty("auth")]
        public Auth Auth { get; set; }

        [JsonProperty("api")]
        public Api Api { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class Auth
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Api
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_user_authenticated")]
        public bool IsUserAuthenticated { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openpm;

    public partial class WorkflowManagedActions
    {
        public OpenpmActions Openpm(string connectionId) => new OpenpmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenpmTriggers Openpm(string connectionId) => new OpenpmTriggers(connectionId);
    }
}
