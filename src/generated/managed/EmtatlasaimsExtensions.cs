//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emtatlasaims
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmtatlasaimsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        [WorkflowExpressionFactory(nameof(__BuildListAssetsConfigurationBaseline))]
        public IBodyWorkflowAction<ListBaseline[]> ListAssetsConfigurationBaseline([WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBaseline[]> __BuildListAssetsConfigurationBaseline(WorkflowValue<string> baseUrl, WorkflowValue<string> status = null)
        {
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            WorkflowValue.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ListBaseline[]>(() =>
            {
                var apiCallPath = "/aimsapi/assets/configuration/base_line/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
                return new ApiConnectionAction<ListBaseline[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        [WorkflowExpressionFactory(nameof(__BuildGetAssetsConfigurationBaseline))]
        public IBodyWorkflowAction<ListBaseline> GetAssetsConfigurationBaseline([WorkflowExpression] Func<string> baselineId, [WorkflowExpression] Func<string> baseUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBaseline> __BuildGetAssetsConfigurationBaseline(WorkflowValue<string> baselineId, WorkflowValue<string> baseUrl)
        {
            WorkflowValue.Validate(baselineId, nameof(baselineId), required: true);
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            return new DeferredBodyAction<ListBaseline>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aimsapi/assets/configuration/base_line/{0}/", ExpressionConverter.ConvertWithUrlEncoding(baselineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
                return new ApiConnectionAction<ListBaseline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emtatlasaims")]
        [WorkflowExpressionFactory(nameof(__BuildAssetsSearch))]
        public IBodyWorkflowAction<AssetSearchResult> AssetsSearch([WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> bodycontractId = null, [WorkflowExpression] Func<int> bodypageNumber = null, [WorkflowExpression] Func<int> bodypageSize = null, [WorkflowExpression] Func<string> bodymodifiedDategreaterThan = null, [WorkflowExpression] Func<string> bodymodifiedDatelessThan = null, [WorkflowExpression] Func<string> bodysortKey = null, [WorkflowExpression] Func<string> bodysortOrder = null, [WorkflowExpression] Func<string[]> bodyfilteredAssetClassCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssetSearchResult> __BuildAssetsSearch(WorkflowValue<string> baseUrl, WorkflowValue<string> bodycontractId = null, WorkflowValue<int> bodypageNumber = null, WorkflowValue<int> bodypageSize = null, WorkflowValue<string> bodymodifiedDategreaterThan = null, WorkflowValue<string> bodymodifiedDatelessThan = null, WorkflowValue<string> bodysortKey = null, WorkflowValue<string> bodysortOrder = null, WorkflowValue<string[]> bodyfilteredAssetClassCode = null)
        {
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            WorkflowValue.Validate(bodycontractId, nameof(bodycontractId), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: false);
            WorkflowValue.Validate(bodymodifiedDategreaterThan, nameof(bodymodifiedDategreaterThan), required: false);
            WorkflowValue.Validate(bodymodifiedDatelessThan, nameof(bodymodifiedDatelessThan), required: false);
            WorkflowValue.Validate(bodysortKey, nameof(bodysortKey), required: false);
            WorkflowValue.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            WorkflowValue.Validate(bodyfilteredAssetClassCode, nameof(bodyfilteredAssetClassCode), required: false);
            return new DeferredBodyAction<AssetSearchResult>(() =>
            {
                var apiCallPath = "/aimsapi/assets/search/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontractId != null)
                {
                    body["contract"] = ExpressionConverter.ConvertO(bodycontractId);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodypageSize != null)
                {
                    body["pageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                    bodypropCount++;
                }

                var modifiedDateObject = new JObject();
                var modifiedDateObjectpropCount = 0;
                if (bodymodifiedDategreaterThan != null)
                {
                    modifiedDateObject["gt"] = ExpressionConverter.ConvertO(bodymodifiedDategreaterThan);
                    modifiedDateObjectpropCount++;
                }

                if (bodymodifiedDatelessThan != null)
                {
                    modifiedDateObject["lt"] = ExpressionConverter.ConvertO(bodymodifiedDatelessThan);
                    modifiedDateObjectpropCount++;
                }

                if (modifiedDateObjectpropCount > 0)
                {
                    body["modified_date"] = modifiedDateObject;
                    bodypropCount++;
                }

                if (bodysortKey != null)
                {
                    body["sortKey"] = ExpressionConverter.ConvertO(bodysortKey);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["sortOrder"] = ExpressionConverter.ConvertO(bodysortOrder);
                    bodypropCount++;
                }

                if (bodyfilteredAssetClassCode != null)
                {
                    body["filteredAssetClassCode"] = ExpressionConverter.ConvertO(bodyfilteredAssetClassCode);
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
        [WorkflowExpressionFactory(nameof(__BuildGetUserData))]
        public IBodyWorkflowAction<UserDataResponseDoc> GetUserData([WorkflowExpression] Func<string> baseUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDataResponseDoc> __BuildGetUserData(WorkflowValue<string> baseUrl)
        {
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            return new DeferredBodyAction<UserDataResponseDoc>(() =>
            {
                var apiCallPath = "/aimsapi/user/user_data/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
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
