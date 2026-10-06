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
        public IBodyWorkflowAction<EnterpriseGetResponse> EnterpriseGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/enterprise/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EnterpriseGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<ProjectGetResponseItem[]> ProjectGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<ProjectGetAResponse> ProjectGetA([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreePlantResponse> TreePlant([WorkflowExpression] Func<int> bodytreeCount = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytreeCount != null)
                {
                    body["treeCount"] = SourceExpressionConverter.ConvertToken(bodytreeCount);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TreePlantResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountResponse> TreeCount([WorkflowExpression] Func<string> enterpriseId = null, [WorkflowExpression] Func<string> user = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tree";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (enterpriseId != null)
                    callPayload.Queries["enterpriseId"] = SourceExpressionConverter.ConvertO(enterpriseId);
                if (user != null)
                    callPayload.Queries["user"] = SourceExpressionConverter.ConvertO(user);
                return callPayload;
            }

            return new ApiConnectionAction<TreeCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeDetailsResponse> TreeDetails([WorkflowExpression] Func<string> uuidOfTreePlanted)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tree/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uuidOfTreePlanted, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TreeDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountMonthResponse> TreeCountMonth([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> yYYYMM)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/enterprise/{0}/treeCount/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(yYYYMM, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TreeCountMonthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountDatesResponse> TreeCountDates([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/enterprise/{0}/treeCount", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<TreeCountDatesResponse>(BuildSourceInput);
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

namespace Microsoft.Azure.Workflows.Sdk
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