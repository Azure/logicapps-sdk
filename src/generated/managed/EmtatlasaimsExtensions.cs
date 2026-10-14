//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emtatlasaims
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EmtatlasaimsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        public IBodyWorkflowAction<ListBaseline[]> ListAssetsConfigurationBaseline(Expression<Func<string>> baseUrl, Expression<Func<string>> status = null)
        {
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            return new DeferredBodyAction<ListBaseline[]>(() =>
            {
                var apiCallPath = "/aimsapi/assets/configuration/base_line/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                return new ApiConnectionAction<ListBaseline[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        public IBodyWorkflowAction<ListBaseline> GetAssetsConfigurationBaseline(Expression<Func<string>> baselineId, Expression<Func<string>> baseUrl)
        {
            var __workflow_baselineId = baselineId == null ? null : WorkflowExpression.Compile(baselineId);
            WorkflowExpression.Validate(__workflow_baselineId, nameof(baselineId), required: true);
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            return new DeferredBodyAction<ListBaseline>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aimsapi/assets/configuration/base_line/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baselineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                return new ApiConnectionAction<ListBaseline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        public IBodyWorkflowAction<AssetSearchResult> AssetsSearch(Expression<Func<string>> baseUrl, Expression<Func<string>> bodycontractId = null, Expression<Func<int>> bodypageNumber = null, Expression<Func<int>> bodypageSize = null, Expression<Func<string>> bodymodifiedDategreaterThan = null, Expression<Func<string>> bodymodifiedDatelessThan = null, Expression<Func<string>> bodysortKey = null, Expression<Func<string>> bodysortOrder = null, Expression<Func<string[]>> bodyfilteredAssetClassCode = null)
        {
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            var __workflow_bodycontractId = bodycontractId == null ? null : WorkflowExpression.Compile(bodycontractId);
            WorkflowExpression.Validate(__workflow_bodycontractId, nameof(bodycontractId), required: false);
            var __workflow_bodypageNumber = bodypageNumber == null ? null : WorkflowExpression.Compile(bodypageNumber);
            WorkflowExpression.Validate(__workflow_bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodypageSize = bodypageSize == null ? null : WorkflowExpression.Compile(bodypageSize);
            WorkflowExpression.Validate(__workflow_bodypageSize, nameof(bodypageSize), required: false);
            var __workflow_bodymodifiedDategreaterThan = bodymodifiedDategreaterThan == null ? null : WorkflowExpression.Compile(bodymodifiedDategreaterThan);
            WorkflowExpression.Validate(__workflow_bodymodifiedDategreaterThan, nameof(bodymodifiedDategreaterThan), required: false);
            var __workflow_bodymodifiedDatelessThan = bodymodifiedDatelessThan == null ? null : WorkflowExpression.Compile(bodymodifiedDatelessThan);
            WorkflowExpression.Validate(__workflow_bodymodifiedDatelessThan, nameof(bodymodifiedDatelessThan), required: false);
            var __workflow_bodysortKey = bodysortKey == null ? null : WorkflowExpression.Compile(bodysortKey);
            WorkflowExpression.Validate(__workflow_bodysortKey, nameof(bodysortKey), required: false);
            var __workflow_bodysortOrder = bodysortOrder == null ? null : WorkflowExpression.Compile(bodysortOrder);
            WorkflowExpression.Validate(__workflow_bodysortOrder, nameof(bodysortOrder), required: false);
            var __workflow_bodyfilteredAssetClassCode = bodyfilteredAssetClassCode == null ? null : WorkflowExpression.Compile(bodyfilteredAssetClassCode);
            WorkflowExpression.Validate(__workflow_bodyfilteredAssetClassCode, nameof(bodyfilteredAssetClassCode), required: false);
            return new DeferredBodyAction<AssetSearchResult>(() =>
            {
                var apiCallPath = "/aimsapi/assets/search/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontractId != null)
                {
                    body["contract"] = ExpressionConverter.ConvertO(__workflow_bodycontractId);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypageSize != null)
                {
                    body["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                    bodypropCount++;
                }

                var modifiedDateObject = new JObject();
                var modifiedDateObjectpropCount = 0;
                if (__workflow_bodymodifiedDategreaterThan != null)
                {
                    modifiedDateObject["gt"] = ExpressionConverter.ConvertO(__workflow_bodymodifiedDategreaterThan);
                    modifiedDateObjectpropCount++;
                }

                if (__workflow_bodymodifiedDatelessThan != null)
                {
                    modifiedDateObject["lt"] = ExpressionConverter.ConvertO(__workflow_bodymodifiedDatelessThan);
                    modifiedDateObjectpropCount++;
                }

                if (modifiedDateObjectpropCount > 0)
                {
                    body["modified_date"] = modifiedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysortKey != null)
                {
                    body["sortKey"] = ExpressionConverter.ConvertO(__workflow_bodysortKey);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyfilteredAssetClassCode != null)
                {
                    body["filteredAssetClassCode"] = ExpressionConverter.ConvertO(__workflow_bodyfilteredAssetClassCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AssetSearchResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        public IBodyWorkflowAction<UserDataResponseDoc> GetUserData(Expression<Func<string>> baseUrl)
        {
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            return new DeferredBodyAction<UserDataResponseDoc>(() =>
            {
                var apiCallPath = "/aimsapi/user/user_data/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                return new ApiConnectionAction<UserDataResponseDoc>(callPayload);
            });
        }
    }

    public class EmtatlasaimsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListBaseline
    {
        [JsonProperty("id")]
        public string BaselineId { get; set; }

        [JsonProperty("contract_id")]
        public string ContractId { get; set; }

        [JsonProperty("name")]
        public string BaselineName { get; set; }

        [JsonProperty("created_date")]
        public string CreatedDate { get; set; }

        [JsonProperty("modified_date")]
        public string ModifiedDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("contract_status_info")]
        public ContractStatusInfo[] ContractStatusInfo { get; set; }
    }

    public class ContractStatusInfo
    {
        [JsonProperty("contract_id")]
        public string ContractId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("contract_name")]
        public string ContractName { get; set; }

        [JsonProperty("baseline_sync_in_progress")]
        public string BaselineSynchronizationStatus { get; set; }
    }

    public class AssetSearchResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("result")]
        public AssetSearchResultResultTypeItem[] Result { get; set; }
    }

    public class AssetSearchResultResultTypeItem
    {
        [JsonProperty("contract")]
        public string ContractId { get; set; }

        [JsonProperty("discipline")]
        public string Discipline { get; set; }

        [JsonProperty("sub_discipline")]
        public string Subdiscipline { get; set; }

        [JsonProperty("function")]
        public string Function { get; set; }

        [JsonProperty("sub_functional_unit")]
        public string SubfunctionalUnit { get; set; }

        [JsonProperty("changeset")]
        public string Changeset { get; set; }

        [JsonProperty("class_name")]
        public string ClassName { get; set; }

        [JsonProperty("class_code")]
        public string ClassCode { get; set; }

        [JsonProperty("tag_code")]
        public string TagCode { get; set; }

        [JsonProperty("change_flag")]
        public string ChangeFlag { get; set; }

        [JsonProperty("attribute")]
        public JToken Attribute { get; set; }

        [JsonProperty("import_source")]
        public string ImportSource { get; set; }

        [JsonProperty("imported_datetime")]
        public string ImportedDatetime { get; set; }

        [JsonProperty("modified_date")]
        public string ModifiedDate { get; set; }

        [JsonProperty("relatedWith")]
        public JToken[] RelatedWith { get; set; }

        [JsonProperty("relatedTo")]
        public JToken[] RelatedTo { get; set; }

        [JsonProperty("num_parent_relations")]
        public int NumberOfParentRelations { get; set; }
    }

    public class UserDataResponseDoc
    {
        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("contract_list")]
        public Contract[] ContractsList { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("default_module")]
        public string DefaultModule { get; set; }
    }

    public class Contract
    {
        [JsonProperty("contract")]
        public string ContractId { get; set; }

        [JsonProperty("contract_name")]
        public string ContractName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emtatlasaims;

    public partial class WorkflowManagedActions
    {
        public EmtatlasaimsActions Emtatlasaims(string connectionId) => new EmtatlasaimsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmtatlasaimsTriggers Emtatlasaims(string connectionId) => new EmtatlasaimsTriggers(connectionId);
    }
}
