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
        public IBodyWorkflowAction<PackagesResponse> PackagesGET([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = "/packages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<PackagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesPOST([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymachineName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyversion = null, [WorkflowExpression] Func<string> bodycreatedAt = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymachineDescription = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyopenapi = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package[]> PackagesLookupGET([WorkflowExpression] Func<string> ids = null)
        {
            var apiCallPath = "/packages/lookup";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            return new ApiConnectionAction<Package[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesByPackageIdGET([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Package>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<Package> PackagesByPackageIdPOST([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymachineName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyversion = null, [WorkflowExpression] Func<string> bodycreatedAt = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymachineDescription = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyopenapi = null)
        {
            var apiCallPath = String.Format("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<PackagesOpenapiResponse> PackagesOpenapiByPackageIdGET([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId, [WorkflowExpression] Func<formatInput> format = null)
        {
            var apiCallPath = String.Format("/packages/{0}/openapi", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            return new ApiConnectionAction<PackagesOpenapiResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin> PackagesAiPluginByPackageIdGET([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/ai-plugin", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AiPlugin>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsSearchGET([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<int> limit = null)
        {
            var apiCallPath = "/ai-plugins/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<AiPlugin[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openpm")]
        public IBodyWorkflowAction<AiPlugin[]> AiPluginsLookupGET([WorkflowExpression] Func<string> ids = null)
        {
            var apiCallPath = "/ai-plugins/lookup";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            return new ApiConnectionAction<AiPlugin[]>(callPayload);
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