//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Digitalhumaniip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DigitalhumaniipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<EnterpriseGetResponse> EnterpriseGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<EnterpriseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enterprise/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EnterpriseGetResponse>(callPayload);
            });
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
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreePlantResponse> TreePlant(Expression<Func<int>> bodytreeCount = null, Expression<Func<string>> bodyenterpriseId = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodyuser = null)
        {
            var __workflow_bodytreeCount = bodytreeCount == null ? null : WorkflowExpression.Compile(bodytreeCount);
            WorkflowExpression.Validate(__workflow_bodytreeCount, nameof(bodytreeCount), required: false);
            var __workflow_bodyenterpriseId = bodyenterpriseId == null ? null : WorkflowExpression.Compile(bodyenterpriseId);
            WorkflowExpression.Validate(__workflow_bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodyuser = bodyuser == null ? null : WorkflowExpression.Compile(bodyuser);
            WorkflowExpression.Validate(__workflow_bodyuser, nameof(bodyuser), required: false);
            return new DeferredBodyAction<TreePlantResponse>(() =>
            {
                var apiCallPath = "/tree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytreeCount != null)
                {
                    body["treeCount"] = ExpressionConverter.ConvertO(__workflow_bodytreeCount);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TreePlantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountResponse> TreeCount(Expression<Func<string>> enterpriseId = null, Expression<Func<string>> user = null)
        {
            var __workflow_enterpriseId = enterpriseId == null ? null : WorkflowExpression.Compile(enterpriseId);
            WorkflowExpression.Validate(__workflow_enterpriseId, nameof(enterpriseId), required: false);
            var __workflow_user = user == null ? null : WorkflowExpression.Compile(user);
            WorkflowExpression.Validate(__workflow_user, nameof(user), required: false);
            return new DeferredBodyAction<TreeCountResponse>(() =>
            {
                var apiCallPath = "/tree";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_enterpriseId != null)
                    callPayload.Queries["enterpriseId"] = ExpressionConverter.Convert(__workflow_enterpriseId);
                if (__workflow_user != null)
                    callPayload.Queries["user"] = ExpressionConverter.Convert(__workflow_user);
                return new ApiConnectionAction<TreeCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeDetailsResponse> TreeDetails(Expression<Func<string>> uuidOfTreePlanted)
        {
            var __workflow_uuidOfTreePlanted = uuidOfTreePlanted == null ? null : WorkflowExpression.Compile(uuidOfTreePlanted);
            WorkflowExpression.Validate(__workflow_uuidOfTreePlanted, nameof(uuidOfTreePlanted), required: true);
            return new DeferredBodyAction<TreeDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tree/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_uuidOfTreePlanted, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TreeDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountMonthResponse> TreeCountMonth(Expression<Func<string>> id, Expression<Func<string>> yYYYMM)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_yYYYMM = yYYYMM == null ? null : WorkflowExpression.Compile(yYYYMM);
            WorkflowExpression.Validate(__workflow_yYYYMM, nameof(yYYYMM), required: true);
            return new DeferredBodyAction<TreeCountMonthResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enterprise/{0}/treeCount/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_yYYYMM, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TreeCountMonthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "digitalhumaniip")]
        public IBodyWorkflowAction<TreeCountDatesResponse> TreeCountDates(Expression<Func<string>> id, Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: true);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<TreeCountDatesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enterprise/{0}/treeCount", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<TreeCountDatesResponse>(callPayload);
            });
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
