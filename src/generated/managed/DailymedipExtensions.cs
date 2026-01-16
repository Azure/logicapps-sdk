//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dailymedip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DailymedipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<ApplicationNumberResponse> ApplicationNumber(Expression<Func<string>> applicationNumber = null, Expression<Func<string>> marketingCategoryCode = null, Expression<Func<string>> setid = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/applicationnumbers.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (applicationNumber != null)
                callPayload.Queries["application_number"] = ExpressionConverter.Convert(applicationNumber);
            if (marketingCategoryCode != null)
                callPayload.Queries["marketing_category_code"] = ExpressionConverter.Convert(marketingCategoryCode);
            if (setid != null)
                callPayload.Queries["setid"] = ExpressionConverter.Convert(setid);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<ApplicationNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugClassResponse> DrugClass(Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<classCodeTypeInput>> classCodeType = null, Expression<Func<string>> className = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/drugclasses.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (drugClassCode != null)
                callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(drugClassCode);
            if (drugClassCodingSystem != null)
                callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(drugClassCodingSystem);
            callPayload.Queries["class_code_type"] = Convert.ToString("all");
            if (classCodeType != null)
                callPayload.Queries["class_code_type"] = ExpressionConverter.Convert(classCodeType);
            if (className != null)
                callPayload.Queries["class_name"] = ExpressionConverter.Convert(className);
            if (uniiCode != null)
                callPayload.Queries["unii_code"] = ExpressionConverter.Convert(uniiCode);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<DrugClassResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugNameResponse> DrugName(Expression<Func<string>> drugName = null, Expression<Func<nameTypeInput>> nameType = null, Expression<Func<string>> manufacturer = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/drugnames.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (drugName != null)
                callPayload.Queries["drug_name"] = ExpressionConverter.Convert(drugName);
            callPayload.Queries["name_type"] = Convert.ToString("both");
            if (nameType != null)
                callPayload.Queries["name_type"] = ExpressionConverter.Convert(nameType);
            if (manufacturer != null)
                callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(manufacturer);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<DrugNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<NDCResponse> NDC(Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/ndcs.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<NDCResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<RxCUIResponse> RxCUI(Expression<Func<rxttyInput>> rxtty = null, Expression<Func<string>> rxstring = null, Expression<Func<int>> rxcui = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/rxcuis.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["rxtty"] = Convert.ToString("PSN");
            if (rxtty != null)
                callPayload.Queries["rxtty"] = ExpressionConverter.Convert(rxtty);
            if (rxstring != null)
                callPayload.Queries["rxstring"] = ExpressionConverter.Convert(rxstring);
            if (rxcui != null)
                callPayload.Queries["rxcui"] = ExpressionConverter.Convert(rxcui);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<RxCUIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLAllResponse> SPLAll(Expression<Func<string>> applicationNumber = null, Expression<Func<bool>> boxedWarning = null, Expression<Func<deaScheduleCodeInput>> deaScheduleCode = null, Expression<Func<string>> doctype = null, Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<string>> drugName = null, Expression<Func<nameTypeInput>> nameType = null, Expression<Func<string>> labeler = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> marketingCategoryCode = null, Expression<Func<string>> ndc = null, Expression<Func<string>> publishedDate = null, Expression<Func<publishedDateComparisonInput>> publishedDateComparison = null, Expression<Func<string>> rxcui = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/spls.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (applicationNumber != null)
                callPayload.Queries["application_number"] = ExpressionConverter.Convert(applicationNumber);
            if (boxedWarning != null)
                callPayload.Queries["boxed_warning"] = ExpressionConverter.Convert(boxedWarning);
            callPayload.Queries["dea_schedule_code"] = Convert.ToString("none");
            if (deaScheduleCode != null)
                callPayload.Queries["dea_schedule_code"] = ExpressionConverter.Convert(deaScheduleCode);
            if (doctype != null)
                callPayload.Queries["doctype"] = ExpressionConverter.Convert(doctype);
            if (drugClassCode != null)
                callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(drugClassCode);
            if (drugClassCodingSystem != null)
                callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(drugClassCodingSystem);
            if (drugName != null)
                callPayload.Queries["drug_name"] = ExpressionConverter.Convert(drugName);
            callPayload.Queries["name_type"] = Convert.ToString("both");
            if (nameType != null)
                callPayload.Queries["name_type"] = ExpressionConverter.Convert(nameType);
            if (labeler != null)
                callPayload.Queries["labeler"] = ExpressionConverter.Convert(labeler);
            if (manufacturer != null)
                callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(manufacturer);
            if (marketingCategoryCode != null)
                callPayload.Queries["marketing_category_code"] = ExpressionConverter.Convert(marketingCategoryCode);
            if (ndc != null)
                callPayload.Queries["ndc"] = ExpressionConverter.Convert(ndc);
            if (publishedDate != null)
                callPayload.Queries["published_date"] = ExpressionConverter.Convert(publishedDate);
            callPayload.Queries["published_date_comparison"] = Convert.ToString("lt");
            if (publishedDateComparison != null)
                callPayload.Queries["published_date_comparison"] = ExpressionConverter.Convert(publishedDateComparison);
            if (rxcui != null)
                callPayload.Queries["rxcui"] = ExpressionConverter.Convert(rxcui);
            if (uniiCode != null)
                callPayload.Queries["unii_code"] = ExpressionConverter.Convert(uniiCode);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<SPLAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLHistoryResponse> SPLHistory(Expression<Func<string>> sETID)
        {
            var apiCallPath = String.Format("/v2/spls/{0}/history.json", ExpressionConverter.ConvertWithUrlEncoding(sETID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPLHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLMediaResponse> SPLMedia(Expression<Func<string>> sETID)
        {
            var apiCallPath = String.Format("/v2/spls/{0}/media.json", ExpressionConverter.ConvertWithUrlEncoding(sETID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPLMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLNDCResponse> SPLNDC(Expression<Func<string>> sETID)
        {
            var apiCallPath = String.Format("/v2/spls/{0}/ndcs.json", ExpressionConverter.ConvertWithUrlEncoding(sETID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPLNDCResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLPackagingResponse> SPLPackaging(Expression<Func<string>> sETID)
        {
            var apiCallPath = String.Format("/v2/spls/{0}/packaging.json", ExpressionConverter.ConvertWithUrlEncoding(sETID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPLPackagingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<UNIIResponse> UNII(Expression<Func<string>> activeMoiety = null, Expression<Func<string>> drugClassCode = null, Expression<Func<string>> drugClassCodingSystem = null, Expression<Func<string>> rxcui = null, Expression<Func<string>> uniiCode = null, Expression<Func<int>> pagesize = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/v2/uniis.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (activeMoiety != null)
                callPayload.Queries["active_moiety"] = ExpressionConverter.Convert(activeMoiety);
            if (drugClassCode != null)
                callPayload.Queries["drug_class_code"] = ExpressionConverter.Convert(drugClassCode);
            if (drugClassCodingSystem != null)
                callPayload.Queries["drug_class_coding_system"] = ExpressionConverter.Convert(drugClassCodingSystem);
            if (rxcui != null)
                callPayload.Queries["rxcui"] = ExpressionConverter.Convert(rxcui);
            if (uniiCode != null)
                callPayload.Queries["unii_code"] = ExpressionConverter.Convert(uniiCode);
            if (pagesize != null)
                callPayload.Queries["pagesize"] = ExpressionConverter.Convert(pagesize);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<UNIIResponse>(callPayload);
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

    public enum classCodeTypeInput
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

    public enum nameTypeInput
    {
        [EnumMember(Value = "both")]
        Both,
        [EnumMember(Value = "generic")]
        Generic,
        [EnumMember(Value = "brand")]
        Brand
    }

    public class NDCResponse
    {
        [JsonProperty("metadata")]
        public NDCResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public NDCResponseDataTypeItem[] Data { get; set; }
    }

    public class NDCResponseMetadataType
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

    public class NDCResponseDataTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }
    }

    public class RxCUIResponse
    {
        [JsonProperty("metadata")]
        public RxCUIResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public RxCUIResponseDataTypeItem[] Data { get; set; }
    }

    public class RxCUIResponseMetadataType
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

    public class RxCUIResponseDataTypeItem
    {
        [JsonProperty("rxcui")]
        public string Rxcui { get; set; }

        [JsonProperty("rxstring")]
        public string Rxstring { get; set; }

        [JsonProperty("rxtty")]
        public string Rxtty { get; set; }
    }

    public enum rxttyInput
    {
        PSN,
        SBD,
        SCD,
        BPCK,
        GPCK,
        SY
    }

    public class SPLAllResponse
    {
        [JsonProperty("metadata")]
        public SPLAllResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SPLAllResponseDataTypeItem[] Data { get; set; }
    }

    public class SPLAllResponseMetadataType
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

    public class SPLAllResponseDataTypeItem
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

    public enum deaScheduleCodeInput
    {
        [EnumMember(Value = "none")]
        None,
        C48672,
        C48675,
        C48676,
        C48677,
        C48679
    }

    public enum publishedDateComparisonInput
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

    public class SPLHistoryResponse
    {
        [JsonProperty("metadata")]
        public SPLHistoryResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SPLHistoryResponseDataType Data { get; set; }
    }

    public class SPLHistoryResponseMetadataType
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

    public class SPLHistoryResponseDataType
    {
        [JsonProperty("history")]
        public SPLHistoryResponseDataTypeHistoryTypeItem[] History { get; set; }

        [JsonProperty("spl")]
        public SPLHistoryResponseDataTypeSplType Spl { get; set; }
    }

    public class SPLHistoryResponseDataTypeHistoryTypeItem
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }
    }

    public class SPLHistoryResponseDataTypeSplType
    {
        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SPLMediaResponse
    {
        [JsonProperty("metadata")]
        public SPLMediaResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SPLMediaResponseDataType Data { get; set; }
    }

    public class SPLMediaResponseMetadataType
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

    public class SPLMediaResponseDataType
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("media")]
        public SPLMediaResponseDataTypeMediaTypeItem[] Media { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SPLMediaResponseDataTypeMediaTypeItem
    {
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SPLNDCResponse
    {
        [JsonProperty("metadata")]
        public SPLNDCResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SPLNDCResponseDataType Data { get; set; }
    }

    public class SPLNDCResponseMetadataType
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

    public class SPLNDCResponseDataType
    {
        [JsonProperty("ndcs")]
        public SPLNDCResponseDataTypeNdcsTypeItem[] Ndcs { get; set; }

        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SPLNDCResponseDataTypeNdcsTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }
    }

    public class SPLPackagingResponse
    {
        [JsonProperty("metadata")]
        public SPLPackagingResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public SPLPackagingResponseDataType Data { get; set; }
    }

    public class SPLPackagingResponseMetadataType
    {
        [JsonProperty("current_url")]
        public string CurrentUrl { get; set; }

        [JsonProperty("db_published_date")]
        public string DbPublishedDate { get; set; }
    }

    public class SPLPackagingResponseDataType
    {
        [JsonProperty("spl_version")]
        public string SplVersion { get; set; }

        [JsonProperty("products")]
        public SPLPackagingResponseDataTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("setid")]
        public string Setid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItem
    {
        [JsonProperty("parts")]
        public SPLPackagingResponseDataTypeProductsTypeItemPartsType Parts { get; set; }

        [JsonProperty("active_ingredients")]
        public SPLPackagingResponseDataTypeProductsTypeItemActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("packaging")]
        public SPLPackagingResponseDataTypeProductsTypeItemPackagingTypeItem[] Packaging { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_name_generic")]
        public string ProductNameGeneric { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemPartsType
    {
        [JsonProperty("item")]
        public SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemType Item { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemType
    {
        [JsonProperty("part_number")]
        public string PartNumber { get; set; }

        [JsonProperty("active_ingredients")]
        public SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypeActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("total_product_quantity")]
        public string TotalProductQuantity { get; set; }

        [JsonProperty("packaging")]
        public SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypePackagingTypeItem[] Packaging { get; set; }

        [JsonProperty("part_name")]
        public string PartName { get; set; }

        [JsonProperty("part_code")]
        public string PartCode { get; set; }

        [JsonProperty("package_quantity")]
        public string PackageQuantity { get; set; }

        [JsonProperty("part_name_generic")]
        public string PartNameGeneric { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypeActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemPartsTypeItemTypePackagingTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }

        [JsonProperty("package_descriptions")]
        public string[] PackageDescriptions { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }

    public class SPLPackagingResponseDataTypeProductsTypeItemPackagingTypeItem
    {
        [JsonProperty("ndc")]
        public string Ndc { get; set; }

        [JsonProperty("package_descriptions")]
        public string[] PackageDescriptions { get; set; }
    }

    public class UNIIResponse
    {
        [JsonProperty("metadata")]
        public UNIIResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public UNIIResponseDataTypeItem[] Data { get; set; }
    }

    public class UNIIResponseMetadataType
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

    public class UNIIResponseDataTypeItem
    {
        [JsonProperty("unii_code")]
        public string UniiCode { get; set; }

        [JsonProperty("active_moiety")]
        public string ActiveMoiety { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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