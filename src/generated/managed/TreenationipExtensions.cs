//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Treenationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TreenationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectListResponseItem[]> ProjectList([WorkflowExpression] Func<string> status)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SitesListResponseItem[]> SitesList([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/projects/{0}/planting-sites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SitesListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesListResponseItem[]> SpeciesList([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/projects/{0}/species", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpeciesListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<SpeciesDetailsResponse> SpeciesDetails([WorkflowExpression] Func<string> speciesId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/species/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(speciesId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpeciesDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestDetailsResponse> ForestDetails([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forests/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ForestDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<ForestTreeCountResponse> ForestTreeCount([WorkflowExpression] Func<string> userSlug, [WorkflowExpression] Func<string> period)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forests/{0}/tree_counter/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userSlug, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ForestTreeCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<PlantResponse> Plant([WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null, [WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyspeciesId = null, [WorkflowExpression] Func<int> bodyquantity = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/plant";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrecipients != null)
                {
                    body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                    bodypropCount++;
                }

                if (bodyplanterId != null)
                {
                    body["planter_id"] = SourceExpressionConverter.ConvertToken(bodyplanterId);
                    bodypropCount++;
                }

                if (bodyspeciesId != null)
                {
                    body["species_id"] = SourceExpressionConverter.ConvertToken(bodyspeciesId);
                    bodypropCount++;
                }

                if (bodyquantity != null)
                {
                    body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlantResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyresponsibleName = null, [WorkflowExpression] Func<string> bodyorganizationWebsite = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/user/b2b";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyresponsibleName != null)
                {
                    body["responsible_name"] = SourceExpressionConverter.ConvertToken(bodyresponsibleName);
                    bodypropCount++;
                }

                if (bodyorganizationWebsite != null)
                {
                    body["organization_website"] = SourceExpressionConverter.ConvertToken(bodyorganizationWebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<TreeTemplateDetailsResponse> TreeTemplateDetails([WorkflowExpression] Func<string> planterId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tree_templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planterId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TreeTemplateDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<UpdateTreeTemplateResponse> UpdateTreeTemplate([WorkflowExpression] Func<string> planterId, [WorkflowExpression] Func<string> bodymessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tree_templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planterId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTreeTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        public IBodyWorkflowAction<BuyCreditResponse> BuyCredit([WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyamount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/credit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyplanterId != null)
                {
                    body["planter_id"] = SourceExpressionConverter.ConvertToken(bodyplanterId);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuyCreditResponse>(BuildSourceInput);
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