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
        [WorkflowExpressionFactory(nameof(__BuildProjectList))]
        public IBodyWorkflowAction<ProjectListResponseItem[]> ProjectList([WorkflowExpression] Func<string> status)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectListResponseItem[]> __BuildProjectList(WorkflowValue<string> status)
        {
            WorkflowValue.Validate(status, nameof(status), required: true);
            return new DeferredBodyAction<ProjectListResponseItem[]>(() =>
            {
                var apiCallPath = "/api/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<ProjectListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildProjectDetails))]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectDetailsResponse> __BuildProjectDetails(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildSitesList))]
        public IBodyWorkflowAction<SitesListResponseItem[]> SitesList([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SitesListResponseItem[]> __BuildSitesList(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<SitesListResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/projects/{0}/planting-sites", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitesListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildSpeciesList))]
        public IBodyWorkflowAction<SpeciesListResponseItem[]> SpeciesList([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpeciesListResponseItem[]> __BuildSpeciesList(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<SpeciesListResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/projects/{0}/species", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpeciesListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildSpeciesDetails))]
        public IBodyWorkflowAction<SpeciesDetailsResponse> SpeciesDetails([WorkflowExpression] Func<string> speciesId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpeciesDetailsResponse> __BuildSpeciesDetails(WorkflowValue<string> speciesId)
        {
            WorkflowValue.Validate(speciesId, nameof(speciesId), required: true);
            return new DeferredBodyAction<SpeciesDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/species/{0}", ExpressionConverter.ConvertWithUrlEncoding(speciesId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpeciesDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildForestDetails))]
        public IBodyWorkflowAction<ForestDetailsResponse> ForestDetails([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ForestDetailsResponse> __BuildForestDetails(WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ForestDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/forests/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ForestDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildForestTreeCount))]
        public IBodyWorkflowAction<ForestTreeCountResponse> ForestTreeCount([WorkflowExpression] Func<string> userSlug, [WorkflowExpression] Func<string> period)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ForestTreeCountResponse> __BuildForestTreeCount(WorkflowValue<string> userSlug, WorkflowValue<string> period)
        {
            WorkflowValue.Validate(userSlug, nameof(userSlug), required: true);
            WorkflowValue.Validate(period, nameof(period), required: true);
            return new DeferredBodyAction<ForestTreeCountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/forests/{0}/tree_counter/{1}", ExpressionConverter.ConvertWithUrlEncoding(userSlug, 1), ExpressionConverter.ConvertWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ForestTreeCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildPlant))]
        public IBodyWorkflowAction<PlantResponse> Plant([WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null, [WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyspeciesId = null, [WorkflowExpression] Func<int> bodyquantity = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlantResponse> __BuildPlant(WorkflowValue<bodyrecipientsInputItem[]> bodyrecipients = null, WorkflowValue<int> bodyplanterId = null, WorkflowValue<int> bodyspeciesId = null, WorkflowValue<int> bodyquantity = null, WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodyrecipients, nameof(bodyrecipients), required: false);
            WorkflowValue.Validate(bodyplanterId, nameof(bodyplanterId), required: false);
            WorkflowValue.Validate(bodyspeciesId, nameof(bodyspeciesId), required: false);
            WorkflowValue.Validate(bodyquantity, nameof(bodyquantity), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<PlantResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyresponsibleName = null, [WorkflowExpression] Func<string> bodyorganizationWebsite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserResponse> __BuildCreateUser(WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodypassword = null, WorkflowValue<string> bodyresponsibleName = null, WorkflowValue<string> bodyorganizationWebsite = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowValue.Validate(bodyresponsibleName, nameof(bodyresponsibleName), required: false);
            WorkflowValue.Validate(bodyorganizationWebsite, nameof(bodyorganizationWebsite), required: false);
            return new DeferredBodyAction<CreateUserResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildTreeTemplateDetails))]
        public IBodyWorkflowAction<TreeTemplateDetailsResponse> TreeTemplateDetails([WorkflowExpression] Func<string> planterId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TreeTemplateDetailsResponse> __BuildTreeTemplateDetails(WorkflowValue<string> planterId)
        {
            WorkflowValue.Validate(planterId, nameof(planterId), required: true);
            return new DeferredBodyAction<TreeTemplateDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tree_templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(planterId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TreeTemplateDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTreeTemplate))]
        public IBodyWorkflowAction<UpdateTreeTemplateResponse> UpdateTreeTemplate([WorkflowExpression] Func<string> planterId, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTreeTemplateResponse> __BuildUpdateTreeTemplate(WorkflowValue<string> planterId, WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(planterId, nameof(planterId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<UpdateTreeTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tree_templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(planterId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "treenationip")]
        [WorkflowExpressionFactory(nameof(__BuildBuyCredit))]
        public IBodyWorkflowAction<BuyCreditResponse> BuyCredit([WorkflowExpression] Func<int> bodyplanterId = null, [WorkflowExpression] Func<int> bodyamount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuyCreditResponse> __BuildBuyCredit(WorkflowValue<int> bodyplanterId = null, WorkflowValue<int> bodyamount = null)
        {
            WorkflowValue.Validate(bodyplanterId, nameof(bodyplanterId), required: false);
            WorkflowValue.Validate(bodyamount, nameof(bodyamount), required: false);
            return new DeferredBodyAction<BuyCreditResponse>(() =>
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
