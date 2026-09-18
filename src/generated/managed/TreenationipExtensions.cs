//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Treenationip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TreenationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectListResponseItem[]> ProjectList([WorkflowExpression] Func<string> status)
        {
            var apiCallPath = "/api/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ProjectListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> projectId)
        {
            var apiCallPath = String.Format("/api/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SitesListResponseItem[]> SitesList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> projectId)
        {
            var apiCallPath = String.Format("/api/projects/{0}/planting-sites", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SitesListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesListResponseItem[]> SpeciesList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> projectId)
        {
            var apiCallPath = String.Format("/api/projects/{0}/species", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpeciesListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesDetailsResponse> SpeciesDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> speciesId)
        {
            var apiCallPath = String.Format("/api/species/{0}", ExpressionConverter.ConvertWithUrlEncoding(speciesId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpeciesDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestDetailsResponse> ForestDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userId)
        {
            var apiCallPath = String.Format("/api/forests/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ForestDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestTreeCountResponse> ForestTreeCount([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userSlug, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> period)
        {
            var apiCallPath = String.Format("/api/forests/{0}/tree_counter/{1}", ExpressionConverter.ConvertWithUrlEncoding(userSlug, 1), ExpressionConverter.ConvertWithUrlEncoding(period, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ForestTreeCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<PlantResponse> Plant([WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null, [WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyspeciesId = null, [WorkflowExpression] Func<int> bodyquantity = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            var apiCallPath = "/api/plant";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrecipients != null)
            {
                body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                bodypropCount++;
            }

            if (bodyplanterId != null)
            {
                body["planter_id"] = ExpressionConverter.ConvertO(bodyplanterId);
                bodypropCount++;
            }

            if (bodyspeciesId != null)
            {
                body["species_id"] = ExpressionConverter.ConvertO(bodyspeciesId);
                bodypropCount++;
            }

            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlantResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyresponsibleName = null, [WorkflowExpression] Func<string> bodyorganizationWebsite = null)
        {
            var apiCallPath = "/api/user/b2b";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyresponsibleName != null)
            {
                body["responsible_name"] = ExpressionConverter.ConvertO(bodyresponsibleName);
                bodypropCount++;
            }

            if (bodyorganizationWebsite != null)
            {
                body["organization_website"] = ExpressionConverter.ConvertO(bodyorganizationWebsite);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<TreeTemplateDetailsResponse> TreeTemplateDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planterId)
        {
            var apiCallPath = String.Format("/api/tree_templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(planterId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TreeTemplateDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<UpdateTreeTemplateResponse> UpdateTreeTemplate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planterId, [WorkflowExpression] Func<string> bodymessage = null)
        {
            var apiCallPath = String.Format("/api/tree_templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(planterId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTreeTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<BuyCreditResponse> BuyCredit([WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyamount = null)
        {
            var apiCallPath = "/api/credit";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyplanterId != null)
            {
                body["planter_id"] = ExpressionConverter.ConvertO(bodyplanterId);
                bodypropCount++;
            }

            if (bodyamount != null)
            {
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuyCreditResponse>(callPayload);
        }
    }

    public class TreenationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProjectListResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("species_price_from")]
        public double SpeciesPriceFrom { get; set; }
    }

    public class ProjectDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("species_price_from")]
        public double SpeciesPriceFrom { get; set; }
    }

    public class SitesListResponseItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("polygon_data")]
        public string PolygonData { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class SpeciesListResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("life_time_CO2")]
        public int LifeTimeCO2 { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }
    }

    public class SpeciesDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("life_time_CO2")]
        public int LifeTimeCO2 { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("common_names")]
        public string CommonNames { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("particularities")]
        public string Particularities { get; set; }

        [JsonProperty("planter_likes")]
        public string PlanterLikes { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("average_natural_life_span")]
        public int AverageNaturalLifeSpan { get; set; }

        [JsonProperty("co2_offset")]
        public int Co2Offset { get; set; }

        [JsonProperty("co2_offset_period")]
        public string Co2OffsetPeriod { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("category")]
        public SpeciesDetailsResponseCategoryType Category { get; set; }

        [JsonProperty("foliage")]
        public SpeciesDetailsResponseFoliageType Foliage { get; set; }

        [JsonProperty("origin_type")]
        public SpeciesDetailsResponseOriginTypeType OriginType { get; set; }
    }

    public class SpeciesDetailsResponseCategoryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpeciesDetailsResponseFoliageType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpeciesDetailsResponseOriginTypeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ForestDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("co2_compensated")]
        public double Co2Compensated { get; set; }

        [JsonProperty("tree_count")]
        public string TreeCount { get; set; }
    }

    public class ForestTreeCountResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PlantResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("trees")]
        public PlantResponseTreesTypeItem[] Trees { get; set; }

        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }
    }

    public class PlantResponseTreesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("collect_url")]
        public string CollectUrl { get; set; }

        [JsonProperty("certificate_url")]
        public string CertificateUrl { get; set; }
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CreateUserResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("forest_url")]
        public string ForestUrl { get; set; }
    }

    public class TreeTemplateDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("planter_id")]
        public int PlanterId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("species_id")]
        public int SpeciesId { get; set; }

        [JsonProperty("package_quantity")]
        public int PackageQuantity { get; set; }

        [JsonProperty("price_per_tree")]
        public int PricePerTree { get; set; }

        [JsonProperty("total_price")]
        public int TotalPrice { get; set; }
    }

    public class UpdateTreeTemplateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("planter_id")]
        public int PlanterId { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("species_id")]
        public int SpeciesId { get; set; }

        [JsonProperty("package_quantity")]
        public int PackageQuantity { get; set; }

        [JsonProperty("price_per_tree")]
        public int PricePerTree { get; set; }

        [JsonProperty("total_price")]
        public int TotalPrice { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BuyCreditResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Treenationip;

    public partial class WorkflowManagedActions
    {
        public TreenationipActions Treenationip(string connectionId) => new TreenationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TreenationipTriggers Treenationip(string connectionId) => new TreenationipTriggers(connectionId);
    }
}