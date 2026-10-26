//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Treenationip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TreenationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectListResponseItem[], ApiConnectionActionConfiguration> ProjectList(Expression<Func<string>> status)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyAction<ProjectListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ProjectListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectDetailsResponse, ApiConnectionActionConfiguration> ProjectDetails(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SitesListResponseItem[], ApiConnectionActionConfiguration> SitesList(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<SitesListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/projects/{0}/planting-sites", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitesListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesListResponseItem[], ApiConnectionActionConfiguration> SpeciesList(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<SpeciesListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/projects/{0}/species", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpeciesListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesDetailsResponse, ApiConnectionActionConfiguration> SpeciesDetails(Expression<Func<string>> speciesId)
        {
            var __workflow_speciesId = WorkflowExpression.Compile(speciesId, nameof(speciesId), required: true);
            return new DeferredBodyAction<SpeciesDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/species/{0}", __workflow_speciesId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpeciesDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestDetailsResponse, ApiConnectionActionConfiguration> ForestDetails(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ForestDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forests/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ForestDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestTreeCountResponse, ApiConnectionActionConfiguration> ForestTreeCount(Expression<Func<string>> userSlug, Expression<Func<string>> period)
        {
            var __workflow_userSlug = WorkflowExpression.Compile(userSlug, nameof(userSlug), required: true);
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: true);
            return new DeferredBodyAction<ForestTreeCountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forests/{0}/tree_counter/{1}", __workflow_userSlug.WithUrlEncoding(1), __workflow_period.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ForestTreeCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<PlantResponse, ApiConnectionActionConfiguration> Plant(Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients = null, Expression<Func<int>> bodyplanterId = null, Expression<Func<int>> bodyspeciesId = null, Expression<Func<int>> bodyquantity = null, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodyrecipients = WorkflowExpression.Compile(bodyrecipients, nameof(bodyrecipients), required: false);
            var __workflow_bodyplanterId = WorkflowExpression.Compile(bodyplanterId, nameof(bodyplanterId), required: false);
            var __workflow_bodyspeciesId = WorkflowExpression.Compile(bodyspeciesId, nameof(bodyspeciesId), required: false);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<PlantResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/plant";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrecipients != null)
                {
                    body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
                    bodypropCount++;
                }

                if (__workflow_bodyplanterId != null)
                {
                    body["planter_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanterId);
                    bodypropCount++;
                }

                if (__workflow_bodyspeciesId != null)
                {
                    body["species_id"] = ExpressionConverter.ConvertO(__workflow_bodyspeciesId);
                    bodypropCount++;
                }

                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyresponsibleName = null, Expression<Func<string>> bodyorganizationWebsite = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyresponsibleName = WorkflowExpression.Compile(bodyresponsibleName, nameof(bodyresponsibleName), required: false);
            var __workflow_bodyorganizationWebsite = WorkflowExpression.Compile(bodyorganizationWebsite, nameof(bodyorganizationWebsite), required: false);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/user/b2b";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibleName != null)
                {
                    body["responsible_name"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibleName);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationWebsite != null)
                {
                    body["organization_website"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationWebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<TreeTemplateDetailsResponse, ApiConnectionActionConfiguration> TreeTemplateDetails(Expression<Func<string>> planterId)
        {
            var __workflow_planterId = WorkflowExpression.Compile(planterId, nameof(planterId), required: true);
            return new DeferredBodyAction<TreeTemplateDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tree_templates/{0}", __workflow_planterId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TreeTemplateDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<UpdateTreeTemplateResponse, ApiConnectionActionConfiguration> UpdateTreeTemplate(Expression<Func<string>> planterId, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_planterId = WorkflowExpression.Compile(planterId, nameof(planterId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<UpdateTreeTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tree_templates/{0}", __workflow_planterId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTreeTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<BuyCreditResponse, ApiConnectionActionConfiguration> BuyCredit(Expression<Func<int>> bodyplanterId = null, Expression<Func<int>> bodyamount = null)
        {
            var __workflow_bodyplanterId = WorkflowExpression.Compile(bodyplanterId, nameof(bodyplanterId), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            return new DeferredBodyAction<BuyCreditResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/credit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyplanterId != null)
                {
                    body["planter_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanterId);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuyCreditResponse>(callPayload);
            });
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