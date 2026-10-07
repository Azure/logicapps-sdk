//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openpm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenpmActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildPackagesGET))]
        public IBodyWorkflowAction<PackagesResponse> PackagesGET([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PackagesResponse> __BuildPackagesGET(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<PackagesResponse>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<PackagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildPackagesPOST))]
        public IBodyWorkflowAction<Package> PackagesPOST([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymachineName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyversion = null, [WorkflowExpression] Func<string> bodycreatedAt = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymachineDescription = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyopenapi = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Package> __BuildPackagesPOST(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodymachineName = null, WorkflowExpression<string> bodydomain = null, WorkflowExpression<string> bodyversion = null, WorkflowExpression<string> bodycreatedAt = null, WorkflowExpression<string> bodyupdatedAt = null, WorkflowExpression<string> bodypublishedAt = null, WorkflowExpression<string> bodylogoUrl = null, WorkflowExpression<string> bodycontactEmail = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodymachineDescription = null, WorkflowExpression<string> bodyuserId = null, WorkflowExpression<string> bodyopenapi = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodymachineName, nameof(bodymachineName), required: false);
            WorkflowExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            WorkflowExpression.Validate(bodycreatedAt, nameof(bodycreatedAt), required: false);
            WorkflowExpression.Validate(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            WorkflowExpression.Validate(bodypublishedAt, nameof(bodypublishedAt), required: false);
            WorkflowExpression.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodymachineDescription, nameof(bodymachineDescription), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyopenapi, nameof(bodyopenapi), required: false);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodymachineName != null)
                {
                    body["machine_name"] = ExpressionConverter.ConvertO(bodymachineName);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(bodyversion);
                    bodypropCount++;
                }

                if (bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(bodycreatedAt);
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(bodypublishedAt);
                    bodypropCount++;
                }

                if (bodylogoUrl != null)
                {
                    body["logo_url"] = ExpressionConverter.ConvertO(bodylogoUrl);
                    bodypropCount++;
                }

                if (bodycontactEmail != null)
                {
                    body["contact_email"] = ExpressionConverter.ConvertO(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodymachineDescription != null)
                {
                    body["machine_description"] = ExpressionConverter.ConvertO(bodymachineDescription);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyopenapi != null)
                {
                    body["openapi"] = ExpressionConverter.ConvertO(bodyopenapi);
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
        [WorkflowExpressionFactory(nameof(__BuildPackagesLookupGET))]
        public IBodyWorkflowAction<Package[]> PackagesLookupGET([WorkflowExpression] Func<string> ids = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Package[]> __BuildPackagesLookupGET(WorkflowExpression<string> ids = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            return new DeferredBodyAction<Package[]>(() =>
            {
                var apiCallPath = "/packages/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                return new ApiConnectionAction<Package[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildPackagesByPackageIdGET))]
        public IBodyWorkflowAction<Package> PackagesByPackageIdGET([WorkflowExpression] Func<string> packageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Package> __BuildPackagesByPackageIdGET(WorkflowExpression<string> packageId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Package>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildPackagesByPackageIdPOST))]
        public IBodyWorkflowAction<Package> PackagesByPackageIdPOST([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymachineName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyversion = null, [WorkflowExpression] Func<string> bodycreatedAt = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymachineDescription = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyopenapi = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Package> __BuildPackagesByPackageIdPOST(WorkflowExpression<string> packageId, WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodymachineName = null, WorkflowExpression<string> bodydomain = null, WorkflowExpression<string> bodyversion = null, WorkflowExpression<string> bodycreatedAt = null, WorkflowExpression<string> bodyupdatedAt = null, WorkflowExpression<string> bodypublishedAt = null, WorkflowExpression<string> bodylogoUrl = null, WorkflowExpression<string> bodycontactEmail = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodymachineDescription = null, WorkflowExpression<string> bodyuserId = null, WorkflowExpression<string> bodyopenapi = null)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodymachineName, nameof(bodymachineName), required: false);
            WorkflowExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            WorkflowExpression.Validate(bodycreatedAt, nameof(bodycreatedAt), required: false);
            WorkflowExpression.Validate(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            WorkflowExpression.Validate(bodypublishedAt, nameof(bodypublishedAt), required: false);
            WorkflowExpression.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodymachineDescription, nameof(bodymachineDescription), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyopenapi, nameof(bodyopenapi), required: false);
            return new DeferredBodyAction<Package>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodymachineName != null)
                {
                    body["machine_name"] = ExpressionConverter.ConvertO(bodymachineName);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(bodyversion);
                    bodypropCount++;
                }

                if (bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(bodycreatedAt);
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(bodypublishedAt);
                    bodypropCount++;
                }

                if (bodylogoUrl != null)
                {
                    body["logo_url"] = ExpressionConverter.ConvertO(bodylogoUrl);
                    bodypropCount++;
                }

                if (bodycontactEmail != null)
                {
                    body["contact_email"] = ExpressionConverter.ConvertO(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodymachineDescription != null)
                {
                    body["machine_description"] = ExpressionConverter.ConvertO(bodymachineDescription);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyopenapi != null)
                {
                    body["openapi"] = ExpressionConverter.ConvertO(bodyopenapi);
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
        [WorkflowExpressionFactory(nameof(__BuildPackagesOpenapiByPackageIdGET))]
        public IBodyWorkflowAction<PackagesOpenapiResponse> PackagesOpenapiByPackageIdGET([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PackagesOpenapiResponse> __BuildPackagesOpenapiByPackageIdGET(WorkflowExpression<string> packageId, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredBodyAction<PackagesOpenapiResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/openapi", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction<PackagesOpenapiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildPackagesAiPluginByPackageIdGET))]
        public IBodyWorkflowAction<AiPlugin> PackagesAiPluginByPackageIdGET([WorkflowExpression] Func<string> packageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AiPlugin> __BuildPackagesAiPluginByPackageIdGET(WorkflowExpression<string> packageId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<AiPlugin>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/ai-plugin", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AiPlugin>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildAiPluginsSearchGET))]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsSearchGET([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AiPlugin[]> __BuildAiPluginsSearchGET(WorkflowExpression<string> query, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AiPlugin[]>(() =>
            {
                var apiCallPath = "/ai-plugins/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction<AiPlugin[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [WorkflowExpressionFactory(nameof(__BuildAiPluginsLookupGET))]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsLookupGET([WorkflowExpression] Func<string> ids = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AiPlugin[]> __BuildAiPluginsLookupGET(WorkflowExpression<string> ids = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            return new DeferredBodyAction<AiPlugin[]>(() =>
            {
                var apiCallPath = "/ai-plugins/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
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