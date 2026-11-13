//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dailymedip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DailymedipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<ApplicationNumberResponse, ApiConnectionActionConfiguration> ApplicationNumber(Expression<Func<string>> applicationNumber = null, Expression<Func<string>> marketingCategoryCode = null, Expression<Func<string>> setid = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_applicationNumber = WorkflowExpression.Compile(applicationNumber, nameof(applicationNumber), required: false);
            var __workflow_marketingCategoryCode = WorkflowExpression.Compile(marketingCategoryCode, nameof(marketingCategoryCode), required: false);
            var __workflow_setid = WorkflowExpression.Compile(setid, nameof(setid), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ApplicationNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/applicationnumbers.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_applicationNumber != null)
                    callPayload.Queries["application_number"] = ExpressionConverter.Convert(__workflow_applicationNumber);
                if (__workflow_marketingCategoryCode != null)
                    callPayload.Queries["marketing_category_code"] = ExpressionConverter.Convert(__workflow_marketingCategoryCode);
                if (__workflow_setid != null)
                    callPayload.Queries["setid"] = ExpressionConverter.Convert(__workflow_setid);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ApplicationNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugClassResponse, ApiConnectionActionConfiguration> DrugClass(Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<ClassCodeTypeInput>> classCodeType = null, Expression<Func<string>> className = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_drugClassCode = WorkflowExpression.Compile(drugClassCode, nameof(drugClassCode), required: false);
            var __workflow_drugClassCodingSystem = WorkflowExpression.Compile(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            var __workflow_classCodeType = WorkflowExpression.Compile(classCodeType, nameof(classCodeType), required: false);
            var __workflow_className = WorkflowExpression.Compile(className, nameof(className), required: false);
            var __workflow_uniiCode = WorkflowExpression.Compile(uniiCode, nameof(uniiCode), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DrugClassResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/drugclasses.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(__workflow_drugClassCode);
                if (__workflow_drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(__workflow_drugClassCodingSystem);
                callPayload.Queries["class_code_type"] = Convert.ToString("all");
                if (__workflow_classCodeType != null)
                    callPayload.Queries["class_code_type"] = ExpressionConverter.Convert(__workflow_classCodeType);
                if (__workflow_className != null)
                    callPayload.Queries["class_name"] = ExpressionConverter.Convert(__workflow_className);
                if (__workflow_uniiCode != null)
                    callPayload.Queries["unii_code"] = ExpressionConverter.Convert(__workflow_uniiCode);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DrugClassResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugNameResponse, ApiConnectionActionConfiguration> DrugName(Expression<Func<string>> drugName = null, Expression<Func<NameTypeInput>> nameType = null, Expression<Func<string>> manufacturer = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_drugName = WorkflowExpression.Compile(drugName, nameof(drugName), required: false);
            var __workflow_nameType = WorkflowExpression.Compile(nameType, nameof(nameType), required: false);
            var __workflow_manufacturer = WorkflowExpression.Compile(manufacturer, nameof(manufacturer), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DrugNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/drugnames.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_drugName != null)
                    callPayload.Queries["drug_name"] = ExpressionConverter.Convert(__workflow_drugName);
                callPayload.Queries["name_type"] = Convert.ToString("both");
                if (__workflow_nameType != null)
                    callPayload.Queries["name_type"] = ExpressionConverter.Convert(__workflow_nameType);
                if (__workflow_manufacturer != null)
                    callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(__workflow_manufacturer);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DrugNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<NdcResponse, ApiConnectionActionConfiguration> Ndc(Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<NdcResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/ndcs.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<NdcResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<RxCuiResponse, ApiConnectionActionConfiguration> RxCui(Expression<Func<RxttyInput>> rxtty = null, Expression<Func<string>> rxstring = null, Expression<Func<int>> rxcui = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_rxtty = WorkflowExpression.Compile(rxtty, nameof(rxtty), required: false);
            var __workflow_rxstring = WorkflowExpression.Compile(rxstring, nameof(rxstring), required: false);
            var __workflow_rxcui = WorkflowExpression.Compile(rxcui, nameof(rxcui), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<RxCuiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/rxcuis.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rxtty"] = Convert.ToString("PSN");
                if (__workflow_rxtty != null)
                    callPayload.Queries["rxtty"] = ExpressionConverter.Convert(__workflow_rxtty);
                if (__workflow_rxstring != null)
                    callPayload.Queries["rxstring"] = ExpressionConverter.Convert(__workflow_rxstring);
                if (__workflow_rxcui != null)
                    callPayload.Queries["rxcui"] = ExpressionConverter.Convert(__workflow_rxcui);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<RxCuiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SplAllResponse, ApiConnectionActionConfiguration> SplAll(Expression<Func<string>> applicationNumber = null, Expression<Func<bool>> boxedWarning = null, Expression<Func<DeaScheduleCodeInput>> deaScheduleCode = null, Expression<Func<string>> doctype = null, Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<string>> drugName = null, Expression<Func<NameTypeInput>> nameType = null, Expression<Func<string>> labeler = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> marketingCategoryCode = null, Expression<Func<string>> ndc = null, Expression<Func<string>> publishedDate = null, Expression<Func<PublishedDateComparisonInput>> publishedDateComparison = null, Expression<Func<string>> rxcui = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_applicationNumber = WorkflowExpression.Compile(applicationNumber, nameof(applicationNumber), required: false);
            var __workflow_boxedWarning = WorkflowExpression.Compile(boxedWarning, nameof(boxedWarning), required: false);
            var __workflow_deaScheduleCode = WorkflowExpression.Compile(deaScheduleCode, nameof(deaScheduleCode), required: false);
            var __workflow_doctype = WorkflowExpression.Compile(doctype, nameof(doctype), required: false);
            var __workflow_drugClassCode = WorkflowExpression.Compile(drugClassCode, nameof(drugClassCode), required: false);
            var __workflow_drugClassCodingSystem = WorkflowExpression.Compile(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            var __workflow_drugName = WorkflowExpression.Compile(drugName, nameof(drugName), required: false);
            var __workflow_nameType = WorkflowExpression.Compile(nameType, nameof(nameType), required: false);
            var __workflow_labeler = WorkflowExpression.Compile(labeler, nameof(labeler), required: false);
            var __workflow_manufacturer = WorkflowExpression.Compile(manufacturer, nameof(manufacturer), required: false);
            var __workflow_marketingCategoryCode = WorkflowExpression.Compile(marketingCategoryCode, nameof(marketingCategoryCode), required: false);
            var __workflow_ndc = WorkflowExpression.Compile(ndc, nameof(ndc), required: false);
            var __workflow_publishedDate = WorkflowExpression.Compile(publishedDate, nameof(publishedDate), required: false);
            var __workflow_publishedDateComparison = WorkflowExpression.Compile(publishedDateComparison, nameof(publishedDateComparison), required: false);
            var __workflow_rxcui = WorkflowExpression.Compile(rxcui, nameof(rxcui), required: false);
            var __workflow_uniiCode = WorkflowExpression.Compile(uniiCode, nameof(uniiCode), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SplAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/spls.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_applicationNumber != null)
                    callPayload.Queries["application_number"] = ExpressionConverter.Convert(__workflow_applicationNumber);
                if (__workflow_boxedWarning != null)
                    callPayload.Queries["boxed_warning"] = ExpressionConverter.Convert(__workflow_boxedWarning);
                callPayload.Queries["dea_schedule_code"] = Convert.ToString("none");
                if (__workflow_deaScheduleCode != null)
                    callPayload.Queries["dea_schedule_code"] = ExpressionConverter.Convert(__workflow_deaScheduleCode);
                if (__workflow_doctype != null)
                    callPayload.Queries["doctype"] = ExpressionConverter.Convert(__workflow_doctype);
                if (__workflow_drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(__workflow_drugClassCode);
                if (__workflow_drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(__workflow_drugClassCodingSystem);
                if (__workflow_drugName != null)
                    callPayload.Queries["drug_name"] = ExpressionConverter.Convert(__workflow_drugName);
                callPayload.Queries["name_type"] = Convert.ToString("both");
                if (__workflow_nameType != null)
                    callPayload.Queries["name_type"] = ExpressionConverter.Convert(__workflow_nameType);
                if (__workflow_labeler != null)
                    callPayload.Queries["labeler"] = ExpressionConverter.Convert(__workflow_labeler);
                if (__workflow_manufacturer != null)
                    callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(__workflow_manufacturer);
                if (__workflow_marketingCategoryCode != null)
                    callPayload.Queries["marketing_category_code"] = ExpressionConverter.Convert(__workflow_marketingCategoryCode);
                if (__workflow_ndc != null)
                    callPayload.Queries["ndc"] = ExpressionConverter.Convert(__workflow_ndc);
                if (__workflow_publishedDate != null)
                    callPayload.Queries["published_date"] = ExpressionConverter.Convert(__workflow_publishedDate);
                callPayload.Queries["published_date_comparison"] = Convert.ToString("lt");
                if (__workflow_publishedDateComparison != null)
                    callPayload.Queries["published_date_comparison"] = ExpressionConverter.Convert(__workflow_publishedDateComparison);
                if (__workflow_rxcui != null)
                    callPayload.Queries["rxcui"] = ExpressionConverter.Convert(__workflow_rxcui);
                if (__workflow_uniiCode != null)
                    callPayload.Queries["unii_code"] = ExpressionConverter.Convert(__workflow_uniiCode);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SplAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SplHistoryResponse, ApiConnectionActionConfiguration> SplHistory(Expression<Func<string>> setid)
        {
            var __workflow_setid = WorkflowExpression.Compile(setid, nameof(setid), required: true);
            return new DeferredBodyAction<SplHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/spls/{0}/history.json", __workflow_setid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SplHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SplMediaResponse, ApiConnectionActionConfiguration> SplMedia(Expression<Func<string>> setid)
        {
            var __workflow_setid = WorkflowExpression.Compile(setid, nameof(setid), required: true);
            return new DeferredBodyAction<SplMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/spls/{0}/media.json", __workflow_setid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SplMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SplndcResponse, ApiConnectionActionConfiguration> Splndc(Expression<Func<string>> setid)
        {
            var __workflow_setid = WorkflowExpression.Compile(setid, nameof(setid), required: true);
            return new DeferredBodyAction<SplndcResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/spls/{0}/ndcs.json", __workflow_setid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SplndcResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SplPackagingResponse, ApiConnectionActionConfiguration> SplPackaging(Expression<Func<string>> setid)
        {
            var __workflow_setid = WorkflowExpression.Compile(setid, nameof(setid), required: true);
            return new DeferredBodyAction<SplPackagingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/spls/{0}/packaging.json", __workflow_setid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SplPackagingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<UniiResponse, ApiConnectionActionConfiguration> Unii(Expression<Func<string>> activeMoiety = null, Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<string>> rxcui = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var __workflow_activeMoiety = WorkflowExpression.Compile(activeMoiety, nameof(activeMoiety), required: false);
            var __workflow_drugClassCode = WorkflowExpression.Compile(drugClassCode, nameof(drugClassCode), required: false);
            var __workflow_drugClassCodingSystem = WorkflowExpression.Compile(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            var __workflow_rxcui = WorkflowExpression.Compile(rxcui, nameof(rxcui), required: false);
            var __workflow_uniiCode = WorkflowExpression.Compile(uniiCode, nameof(uniiCode), required: false);
            var __workflow_pagesize = WorkflowExpression.Compile(pagesize, nameof(pagesize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<UniiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/uniis.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_activeMoiety != null)
                    callPayload.Queries["active_moiety"] = ExpressionConverter.Convert(__workflow_activeMoiety);
                if (__workflow_drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(__workflow_drugClassCode);
                if (__workflow_drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(__workflow_drugClassCodingSystem);
                if (__workflow_rxcui != null)
                    callPayload.Queries["rxcui"] = ExpressionConverter.Convert(__workflow_rxcui);
                if (__workflow_uniiCode != null)
                    callPayload.Queries["unii_code"] = ExpressionConverter.Convert(__workflow_uniiCode);
                if (__workflow_pagesize != null)
                    callPayload.Queries["pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<UniiResponse>(callPayload);
            });
        }
    }

    public class DailymedipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApplicationNumberResponse
    {
        [JsonProperty("metadata")]
        public ApplicationNumberResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public ApplicationNumberResponseDataTypeItem[] Data { get; set; }
    }

    public class ApplicationNumberResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class ApplicationNumberResponseDataTypeItem
    {
        [JsonProperty("marketing_category_code")]
        public string MarketingCategoryCode { get; set; }

        [JsonProperty("application_number")]
        public string ApplicationNumber { get; set; }
    }

    public class DrugClassResponse
    {
        [JsonProperty("metadata")]
        public DrugClassResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public DrugClassResponseDataTypeItem[] Data { get; set; }
    }

    public class DrugClassResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class DrugClassResponseDataTypeItem
    {
        [JsonProperty("codingSystem")]
        public string CodingSystem { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClassCodeTypeInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "epc")]
        Epc,
        [EnumMember(Value = "moa")]
        Moa,
        [EnumMember(Value = "pe")]
        Pe,
        [EnumMember(Value = "ci")]
        Ci
    }

    public class DrugNameResponse
    {
        [JsonProperty("metadata")]
        public DrugNameResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public DrugNameResponseDataTypeItem[] Data { get; set; }
    }

    public class DrugNameResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class DrugNameResponseDataTypeItem
    {
        [JsonProperty("name_type")]
        public string NameType { get; set; }

        [JsonProperty("drug_name")]
        public string DrugName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NameTypeInput
    {
        [EnumMember(Value = "both")]
        Both,
        [EnumMember(Value = "generic")]
        Generic,
        [EnumMember(Value = "brand")]
        Brand
    }

    public class NdcResponse
    {
        [JsonProperty("metadata")]
        public NdcResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public NdcResponseDataTypeItem[] Data { get; set; }
    }

    public class NdcResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class NdcResponseDataTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }
    }

    public class RxCuiResponse
    {
        [JsonProperty("metadata")]
        public RxCuiResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public RxCuiResponseDataTypeItem[] Data { get; set; }
    }

    public class RxCuiResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class RxCuiResponseDataTypeItem
    {
        [JsonProperty("rxcui")]
        public string Rxcui { get; set; }

        [JsonProperty("rxstring")]
        public string Rxstring { get; set; }

        [JsonProperty("rxtty")]
        public string Rxtty { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RxttyInput
    {
        [EnumMember(Value = "PSN")]
        Psn,
        [EnumMember(Value = "SBD")]
        Sbd,
        [EnumMember(Value = "SCD")]
        Scd,
        [EnumMember(Value = "BPCK")]
        Bpck,
        [EnumMember(Value = "GPCK")]
        Gpck,
        SY
    }

    public class SplAllResponse
    {
        [JsonProperty("metadata")]
        public SplAllResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SplAllResponseDataTypeItem[] Data { get; set; }
    }

    public class SplAllResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class SplAllResponseDataTypeItem
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeaScheduleCodeInput
    {
        [EnumMember(Value = "none")]
        None,
        C48672,
        C48675,
        C48676,
        C48677,
        C48679
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PublishedDateComparisonInput
    {
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "lte")]
        Lte,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "gte")]
        Gte,
        [EnumMember(Value = "eq")]
        Eq
    }

    public class SplHistoryResponse
    {
        [JsonProperty("metadata")]
        public SplHistoryResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SplHistoryResponseDataType Data { get; set; }
    }

    public class SplHistoryResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("db_published_date")]
        public string DbPublishedDate { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class SplHistoryResponseDataType
    {
        [JsonProperty("history")]
        public SplHistoryResponseDataTypeHistoryTypeItem[] History { get; set; }

        [JsonProperty("spl")]
        public SplHistoryResponseDataTypeSplType Spl { get; set; }
    }

    public class SplHistoryResponseDataTypeHistoryTypeItem
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }
    }

    public class SplHistoryResponseDataTypeSplType
    {
        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SplMediaResponse
    {
        [JsonProperty("metadata")]
        public SplMediaResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SplMediaResponseDataType Data { get; set; }
    }

    public class SplMediaResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class SplMediaResponseDataType
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("media")]
        public SplMediaResponseDataTypeMediaTypeItem[] Media { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SplMediaResponseDataTypeMediaTypeItem
    {
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SplndcResponse
    {
        [JsonProperty("metadata")]
        public SplndcResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SplndcResponseDataType Data { get; set; }
    }

    public class SplndcResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("db_published_date")]
        public string DbPublishedDate { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class SplndcResponseDataType
    {
        [JsonProperty("ndcs")]
        public SplndcResponseDataTypeNdcsTypeItem[] Ndcs { get; set; }

        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SplndcResponseDataTypeNdcsTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }
    }

    public class SplPackagingResponse
    {
        [JsonProperty("metadata")]
        public SplPackagingResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SplPackagingResponseDataType Data { get; set; }
    }

    public class SplPackagingResponseMetadataType
    {
        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("db_published_date")]
        public string DbPublishedDate { get; set; }
    }

    public class SplPackagingResponseDataType
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("products")]
        public SplPackagingResponseDataTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItem
    {
        [JsonProperty("parts")]
        public SplPackagingResponseDataTypeProductsTypeItemPartsType Parts { get; set; }

        [JsonProperty("active_ingredients")]
        public SplPackagingResponseDataTypeProductsTypeItemActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("packaging")]
        public SplPackagingResponseDataTypeProductsTypeItemPackagingTypeItem[] Packaging { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_name_generic")]
        public string ProductNameGeneric { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemPartsType
    {
        [JsonProperty("item")]
        public SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemType Item { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemType
    {
        [JsonProperty("part_number")]
        public string PartNumber { get; set; }

        [JsonProperty("active_ingredients")]
        public SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypeActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("total_product_quantity")]
        public string TotalProductQuantity { get; set; }

        [JsonProperty("packaging")]
        public SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypePackagingTypeItem[] Packaging { get; set; }

        [JsonProperty("part_name")]
        public string PartName { get; set; }

        [JsonProperty("part_code")]
        public string PartCode { get; set; }

        [JsonProperty("package_quantity")]
        public string PackageQuantity { get; set; }

        [JsonProperty("part_name_generic")]
        public string PartNameGeneric { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypeActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypePackagingTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }

        [JsonProperty("package_descriptions")]
        public string[] PackageDescriptions { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }

    public class SplPackagingResponseDataTypeProductsTypeItemPackagingTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }

        [JsonProperty("package_descriptions")]
        public string[] PackageDescriptions { get; set; }
    }

    public class UniiResponse
    {
        [JsonProperty("metadata")]
        public UniiResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public UniiResponseDataTypeItem[] Data { get; set; }
    }

    public class UniiResponseMetadataType
    {
        [JsonProperty("elements_per_page")]
        public int ElementsPerPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_elements")]
        public int TotalElements { get; set; }

        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class UniiResponseDataTypeItem
    {
        [JsonProperty("unii_code")]
        public string UniiCode { get; set; }

        [JsonProperty("active_moiety")]
        public string ActiveMoiety { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dailymedip;

    public partial class WorkflowManagedActions
    {
        public DailymedipActions Dailymedip(string connectionId) => new DailymedipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DailymedipTriggers Dailymedip(string connectionId) => new DailymedipTriggers(connectionId);
    }
}