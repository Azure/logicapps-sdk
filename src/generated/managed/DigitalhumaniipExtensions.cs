//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Digitalhumaniip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DigitalhumaniipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<EnterpriseGetResponse> EnterpriseGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/enterprise/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EnterpriseGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<ProjectGetResponseItem[]> ProjectGet()
        {
            var apiCallPath = "/project";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<ProjectGetAResponse> ProjectGetA(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreePlantResponse> TreePlant(Expression<Func<int>> bodytreeCount = null, Expression<Func<string>> bodyenterpriseId = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodyuser = null)
        {
            var apiCallPath = "/tree";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytreeCount != null)
            {
                body["treeCount"] = ExpressionConverter.ConvertO(bodytreeCount);
                bodypropCount++;
            }

            if (bodyenterpriseId != null)
            {
                body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodyuser != null)
            {
                body["user"] = ExpressionConverter.ConvertO(bodyuser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TreePlantResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountResponse> TreeCount(Expression<Func<string>> enterpriseId = null, Expression<Func<string>> user = null)
        {
            var apiCallPath = "/tree";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (enterpriseId != null)
                callPayload.Queries["enterpriseId"] = ExpressionConverter.Convert(enterpriseId);
            if (user != null)
                callPayload.Queries["user"] = ExpressionConverter.Convert(user);
            return new ApiConnectionAction<TreeCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeDetailsResponse> TreeDetails(Expression<Func<string>> uuidOfTreePlanted)
        {
            var apiCallPath = String.Format("/tree/{0}", ExpressionConverter.ConvertWithUrlEncoding(uuidOfTreePlanted, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TreeDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountMonthResponse> TreeCountMonth(Expression<Func<string>> id, Expression<Func<string>> yYYYMM)
        {
            var apiCallPath = String.Format("/enterprise/{0}/treeCount/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(yYYYMM, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TreeCountMonthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountDatesResponse> TreeCountDates(Expression<Func<string>> id, Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var apiCallPath = String.Format("/enterprise/{0}/treeCount", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<TreeCountDatesResponse>(callPayload);
        }
    }

    public class DigitalhumaniipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EnterpriseGetResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contact")]
        public EnterpriseGetResponseContactType Contact { get; set; }
    }

    public class EnterpriseGetResponseContactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reforestationProjectDescription_en")]
        public string ReforestationProjectDescriptionEn { get; set; }

        [JsonProperty("reforestationProjectState_en")]
        public string ReforestationProjectStateEn { get; set; }

        [JsonProperty("reforestationProjectCountry_en")]
        public string ReforestationProjectCountryEn { get; set; }

        [JsonProperty("reforestationProjectWebsite_en")]
        public string ReforestationProjectWebsiteEn { get; set; }

        [JsonProperty("reforestationCompanyName_en")]
        public string ReforestationCompanyNameEn { get; set; }
    }

    public class ProjectGetAResponse
    {
        [JsonProperty("reforestationCompanyName_fr")]
        public string ReforestationCompanyNameFr { get; set; }

        [JsonProperty("reforestationProjectImageURL_en")]
        public string ReforestationProjectImageURLEn { get; set; }

        [JsonProperty("reforestationCompanyName_en")]
        public string ReforestationCompanyNameEn { get; set; }

        [JsonProperty("reforestationProjectCountry_en")]
        public string ReforestationProjectCountryEn { get; set; }

        [JsonProperty("reforestationCompanyAddress_en")]
        public string ReforestationCompanyAddressEn { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("reforestationProjectWebsite_en")]
        public string ReforestationProjectWebsiteEn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reforestationProjectWebsite_fr")]
        public string ReforestationProjectWebsiteFr { get; set; }

        [JsonProperty("reforestationProjectCountry_fr")]
        public string ReforestationProjectCountryFr { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("reforestationProjectDescription_fr")]
        public string ReforestationProjectDescriptionFr { get; set; }

        [JsonProperty("reforestationProjectDescription_en")]
        public string ReforestationProjectDescriptionEn { get; set; }

        [JsonProperty("reforestationCompanyWebsite_fr")]
        public string ReforestationCompanyWebsiteFr { get; set; }

        [JsonProperty("reforestationCompanyWebsite_en")]
        public string ReforestationCompanyWebsiteEn { get; set; }

        [JsonProperty("reforestationCompanyAddress_fr")]
        public string ReforestationCompanyAddressFr { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reforestationProjectImageURL_fr")]
        public string ReforestationProjectImageURLFr { get; set; }
    }

    public class TreePlantResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("treeCount")]
        public int TreeCount { get; set; }

        [JsonProperty("enterpriseId")]
        public string EnterpriseId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class TreeCountResponse
    {
        [JsonProperty("enterpriseId")]
        public string EnterpriseId { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class TreeDetailsResponse
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("treeCount")]
        public int TreeCount { get; set; }

        [JsonProperty("enterpriseId")]
        public string EnterpriseId { get; set; }
    }

    public class TreeCountMonthResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class TreeCountDatesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Digitalhumaniip;

    public partial class WorkflowManagedActions
    {
        public DigitalhumaniipActions Digitalhumaniip(string connectionId) => new DigitalhumaniipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DigitalhumaniipTriggers Digitalhumaniip(string connectionId) => new DigitalhumaniipTriggers(connectionId);
    }
}