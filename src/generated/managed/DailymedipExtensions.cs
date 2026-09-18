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
        public IBodyWorkflowAction<ApplicationNumberResponse> ApplicationNumber([WorkflowExpression] Func<string> applicationNumber = null, [WorkflowExpression] Func<string> marketingCategoryCode = null, [WorkflowExpression] Func<string> setid = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(applicationNumber, nameof(applicationNumber), required: false);
            SourceExpression.Validate(marketingCategoryCode, nameof(marketingCategoryCode), required: false);
            SourceExpression.Validate(setid, nameof(setid), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/applicationnumbers.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (applicationNumber != null)
                    callPayload.Queries["application_number"] = SourceExpressionConverter.ConvertO(applicationNumber);
                if (marketingCategoryCode != null)
                    callPayload.Queries["marketing_category_code"] = SourceExpressionConverter.ConvertO(marketingCategoryCode);
                if (setid != null)
                    callPayload.Queries["setid"] = SourceExpressionConverter.ConvertO(setid);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<ApplicationNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugClassResponse> DrugClass([WorkflowExpression] Func<string> drugClassCode = null, [WorkflowExpression] Func<string> drugClassCodingSystem = null, [WorkflowExpression] Func<classCodeTypeInput> classCodeType = null, [WorkflowExpression] Func<string> className = null, [WorkflowExpression] Func<string> uniiCode = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(drugClassCode, nameof(drugClassCode), required: false);
            SourceExpression.Validate(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            SourceExpression.Validate(classCodeType, nameof(classCodeType), required: false);
            SourceExpression.Validate(className, nameof(className), required: false);
            SourceExpression.Validate(uniiCode, nameof(uniiCode), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/drugclasses.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = SourceExpressionConverter.ConvertO(drugClassCode);
                if (drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = SourceExpressionConverter.ConvertO(drugClassCodingSystem);
                callPayload.Queries["class_code_type"] = Convert.ToString("all");
                if (classCodeType != null)
                    callPayload.Queries["class_code_type"] = SourceExpressionConverter.Convert(classCodeType);
                if (className != null)
                    callPayload.Queries["class_name"] = SourceExpressionConverter.ConvertO(className);
                if (uniiCode != null)
                    callPayload.Queries["unii_code"] = SourceExpressionConverter.ConvertO(uniiCode);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<DrugClassResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<DrugNameResponse> DrugName([WorkflowExpression] Func<string> drugName = null, [WorkflowExpression] Func<nameTypeInput> nameType = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(drugName, nameof(drugName), required: false);
            SourceExpression.Validate(nameType, nameof(nameType), required: false);
            SourceExpression.Validate(manufacturer, nameof(manufacturer), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/drugnames.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (drugName != null)
                    callPayload.Queries["drug_name"] = SourceExpressionConverter.ConvertO(drugName);
                callPayload.Queries["name_type"] = Convert.ToString("both");
                if (nameType != null)
                    callPayload.Queries["name_type"] = SourceExpressionConverter.Convert(nameType);
                if (manufacturer != null)
                    callPayload.Queries["manufacturer"] = SourceExpressionConverter.ConvertO(manufacturer);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<DrugNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<NDCResponse> NDC([WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/ndcs.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<NDCResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<RxCUIResponse> RxCUI([WorkflowExpression] Func<rxttyInput> rxtty = null, [WorkflowExpression] Func<string> rxstring = null, [WorkflowExpression] Func<int> rxcui = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(rxtty, nameof(rxtty), required: false);
            SourceExpression.Validate(rxstring, nameof(rxstring), required: false);
            SourceExpression.Validate(rxcui, nameof(rxcui), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/rxcuis.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rxtty"] = Convert.ToString("PSN");
                if (rxtty != null)
                    callPayload.Queries["rxtty"] = SourceExpressionConverter.Convert(rxtty);
                if (rxstring != null)
                    callPayload.Queries["rxstring"] = SourceExpressionConverter.ConvertO(rxstring);
                if (rxcui != null)
                    callPayload.Queries["rxcui"] = SourceExpressionConverter.ConvertO(rxcui);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<RxCUIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLAllResponse> SPLAll([WorkflowExpression] Func<string> applicationNumber = null, [WorkflowExpression] Func<bool> boxedWarning = null, [WorkflowExpression] Func<deaScheduleCodeInput> deaScheduleCode = null, [WorkflowExpression] Func<string> doctype = null, [WorkflowExpression] Func<string> drugClassCode = null, [WorkflowExpression] Func<string> drugClassCodingSystem = null, [WorkflowExpression] Func<string> drugName = null, [WorkflowExpression] Func<nameTypeInput> nameType = null, [WorkflowExpression] Func<string> labeler = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<string> marketingCategoryCode = null, [WorkflowExpression] Func<string> ndc = null, [WorkflowExpression] Func<string> publishedDate = null, [WorkflowExpression] Func<publishedDateComparisonInput> publishedDateComparison = null, [WorkflowExpression] Func<string> rxcui = null, [WorkflowExpression] Func<string> uniiCode = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(applicationNumber, nameof(applicationNumber), required: false);
            SourceExpression.Validate(boxedWarning, nameof(boxedWarning), required: false);
            SourceExpression.Validate(deaScheduleCode, nameof(deaScheduleCode), required: false);
            SourceExpression.Validate(doctype, nameof(doctype), required: false);
            SourceExpression.Validate(drugClassCode, nameof(drugClassCode), required: false);
            SourceExpression.Validate(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            SourceExpression.Validate(drugName, nameof(drugName), required: false);
            SourceExpression.Validate(nameType, nameof(nameType), required: false);
            SourceExpression.Validate(labeler, nameof(labeler), required: false);
            SourceExpression.Validate(manufacturer, nameof(manufacturer), required: false);
            SourceExpression.Validate(marketingCategoryCode, nameof(marketingCategoryCode), required: false);
            SourceExpression.Validate(ndc, nameof(ndc), required: false);
            SourceExpression.Validate(publishedDate, nameof(publishedDate), required: false);
            SourceExpression.Validate(publishedDateComparison, nameof(publishedDateComparison), required: false);
            SourceExpression.Validate(rxcui, nameof(rxcui), required: false);
            SourceExpression.Validate(uniiCode, nameof(uniiCode), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/spls.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (applicationNumber != null)
                    callPayload.Queries["application_number"] = SourceExpressionConverter.ConvertO(applicationNumber);
                if (boxedWarning != null)
                    callPayload.Queries["boxed_warning"] = SourceExpressionConverter.ConvertO(boxedWarning);
                callPayload.Queries["dea_schedule_code"] = Convert.ToString("none");
                if (deaScheduleCode != null)
                    callPayload.Queries["dea_schedule_code"] = SourceExpressionConverter.Convert(deaScheduleCode);
                if (doctype != null)
                    callPayload.Queries["doctype"] = SourceExpressionConverter.ConvertO(doctype);
                if (drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = SourceExpressionConverter.ConvertO(drugClassCode);
                if (drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = SourceExpressionConverter.ConvertO(drugClassCodingSystem);
                if (drugName != null)
                    callPayload.Queries["drug_name"] = SourceExpressionConverter.ConvertO(drugName);
                callPayload.Queries["name_type"] = Convert.ToString("both");
                if (nameType != null)
                    callPayload.Queries["name_type"] = SourceExpressionConverter.Convert(nameType);
                if (labeler != null)
                    callPayload.Queries["labeler"] = SourceExpressionConverter.ConvertO(labeler);
                if (manufacturer != null)
                    callPayload.Queries["manufacturer"] = SourceExpressionConverter.ConvertO(manufacturer);
                if (marketingCategoryCode != null)
                    callPayload.Queries["marketing_category_code"] = SourceExpressionConverter.ConvertO(marketingCategoryCode);
                if (ndc != null)
                    callPayload.Queries["ndc"] = SourceExpressionConverter.ConvertO(ndc);
                if (publishedDate != null)
                    callPayload.Queries["published_date"] = SourceExpressionConverter.ConvertO(publishedDate);
                callPayload.Queries["published_date_comparison"] = Convert.ToString("lt");
                if (publishedDateComparison != null)
                    callPayload.Queries["published_date_comparison"] = SourceExpressionConverter.Convert(publishedDateComparison);
                if (rxcui != null)
                    callPayload.Queries["rxcui"] = SourceExpressionConverter.ConvertO(rxcui);
                if (uniiCode != null)
                    callPayload.Queries["unii_code"] = SourceExpressionConverter.ConvertO(uniiCode);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<SPLAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLHistoryResponse> SPLHistory([WorkflowExpression] Func<string> sETID)
        {
            SourceExpression.Validate(sETID, nameof(sETID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/spls/{0}/history.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sETID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPLHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLMediaResponse> SPLMedia([WorkflowExpression] Func<string> sETID)
        {
            SourceExpression.Validate(sETID, nameof(sETID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/spls/{0}/media.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sETID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPLMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLNDCResponse> SPLNDC([WorkflowExpression] Func<string> sETID)
        {
            SourceExpression.Validate(sETID, nameof(sETID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/spls/{0}/ndcs.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sETID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPLNDCResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<SPLPackagingResponse> SPLPackaging([WorkflowExpression] Func<string> sETID)
        {
            SourceExpression.Validate(sETID, nameof(sETID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/spls/{0}/packaging.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sETID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPLPackagingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dailymedip")]
        public IBodyWorkflowAction<UNIIResponse> UNII([WorkflowExpression] Func<string> activeMoiety = null, [WorkflowExpression] Func<string> drugClassCode = null, [WorkflowExpression] Func<string> drugClassCodingSystem = null, [WorkflowExpression] Func<string> rxcui = null, [WorkflowExpression] Func<string> uniiCode = null, [WorkflowExpression] Func<int> pagesize = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(activeMoiety, nameof(activeMoiety), required: false);
            SourceExpression.Validate(drugClassCode, nameof(drugClassCode), required: false);
            SourceExpression.Validate(drugClassCodingSystem, nameof(drugClassCodingSystem), required: false);
            SourceExpression.Validate(rxcui, nameof(rxcui), required: false);
            SourceExpression.Validate(uniiCode, nameof(uniiCode), required: false);
            SourceExpression.Validate(pagesize, nameof(pagesize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/uniis.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (activeMoiety != null)
                    callPayload.Queries["active_moiety"] = SourceExpressionConverter.ConvertO(activeMoiety);
                if (drugClassCode != null)
                    callPayload.Queries["drug_class_code"] = SourceExpressionConverter.ConvertO(drugClassCode);
                if (drugClassCodingSystem != null)
                    callPayload.Queries["drug_class_coding_system"] = SourceExpressionConverter.ConvertO(drugClassCodingSystem);
                if (rxcui != null)
                    callPayload.Queries["rxcui"] = SourceExpressionConverter.ConvertO(rxcui);
                if (uniiCode != null)
                    callPayload.Queries["unii_code"] = SourceExpressionConverter.ConvertO(uniiCode);
                if (pagesize != null)
                    callPayload.Queries["pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<UNIIResponse>(BuildSourceInput);
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