//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nistnvdip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NistnvdipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nistnvdip")]
        public IBodyWorkflowAction<GetCveCollectionResponse, ApiConnectionActionConfiguration> GetCveCollection(Expression<Func<GetCveCollectionAddOnsInput>> addOns = null, Expression<Func<string>> cpeMatchString = null, Expression<Func<string>> cvssV2Metrics = null, Expression<Func<CvssV2SeverityInput>> cvssV2Severity = null, Expression<Func<string>> cvssV3Metrics = null, Expression<Func<CvssV3SeverityInput>> cvssV3Severity = null, Expression<Func<string>> cweId = null, Expression<Func<bool>> includeMatchStringChange = null, Expression<Func<bool>> isExactMatch = null, Expression<Func<string>> keyword = null, Expression<Func<string>> modStartDate = null, Expression<Func<string>> modEndDate = null, Expression<Func<string>> pubStartDate = null, Expression<Func<string>> pubEndDate = null, Expression<Func<int>> resultsPerPage = null, Expression<Func<int>> startIndex = null)
        {
            var __workflow_addOns = WorkflowExpression.Compile(addOns, nameof(addOns), required: false);
            var __workflow_cpeMatchString = WorkflowExpression.Compile(cpeMatchString, nameof(cpeMatchString), required: false);
            var __workflow_cvssV2Metrics = WorkflowExpression.Compile(cvssV2Metrics, nameof(cvssV2Metrics), required: false);
            var __workflow_cvssV2Severity = WorkflowExpression.Compile(cvssV2Severity, nameof(cvssV2Severity), required: false);
            var __workflow_cvssV3Metrics = WorkflowExpression.Compile(cvssV3Metrics, nameof(cvssV3Metrics), required: false);
            var __workflow_cvssV3Severity = WorkflowExpression.Compile(cvssV3Severity, nameof(cvssV3Severity), required: false);
            var __workflow_cweId = WorkflowExpression.Compile(cweId, nameof(cweId), required: false);
            var __workflow_includeMatchStringChange = WorkflowExpression.Compile(includeMatchStringChange, nameof(includeMatchStringChange), required: false);
            var __workflow_isExactMatch = WorkflowExpression.Compile(isExactMatch, nameof(isExactMatch), required: false);
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: false);
            var __workflow_modStartDate = WorkflowExpression.Compile(modStartDate, nameof(modStartDate), required: false);
            var __workflow_modEndDate = WorkflowExpression.Compile(modEndDate, nameof(modEndDate), required: false);
            var __workflow_pubStartDate = WorkflowExpression.Compile(pubStartDate, nameof(pubStartDate), required: false);
            var __workflow_pubEndDate = WorkflowExpression.Compile(pubEndDate, nameof(pubEndDate), required: false);
            var __workflow_resultsPerPage = WorkflowExpression.Compile(resultsPerPage, nameof(resultsPerPage), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            return new DeferredBodyAction<GetCveCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cves/1.0/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOns != null)
                    callPayload.Queries["addOns"] = ExpressionConverter.Convert(__workflow_addOns);
                if (__workflow_cpeMatchString != null)
                    callPayload.Queries["cpeMatchString"] = ExpressionConverter.Convert(__workflow_cpeMatchString);
                if (__workflow_cvssV2Metrics != null)
                    callPayload.Queries["cvssV2Metrics"] = ExpressionConverter.Convert(__workflow_cvssV2Metrics);
                if (__workflow_cvssV2Severity != null)
                    callPayload.Queries["cvssV2Severity"] = ExpressionConverter.Convert(__workflow_cvssV2Severity);
                if (__workflow_cvssV3Metrics != null)
                    callPayload.Queries["cvssV3Metrics"] = ExpressionConverter.Convert(__workflow_cvssV3Metrics);
                if (__workflow_cvssV3Severity != null)
                    callPayload.Queries["cvssV3Severity"] = ExpressionConverter.Convert(__workflow_cvssV3Severity);
                if (__workflow_cweId != null)
                    callPayload.Queries["cweId"] = ExpressionConverter.Convert(__workflow_cweId);
                if (__workflow_includeMatchStringChange != null)
                    callPayload.Queries["includeMatchStringChange"] = ExpressionConverter.Convert(__workflow_includeMatchStringChange);
                if (__workflow_isExactMatch != null)
                    callPayload.Queries["isExactMatch"] = ExpressionConverter.Convert(__workflow_isExactMatch);
                if (__workflow_keyword != null)
                    callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                if (__workflow_modStartDate != null)
                    callPayload.Queries["modStartDate"] = ExpressionConverter.Convert(__workflow_modStartDate);
                if (__workflow_modEndDate != null)
                    callPayload.Queries["modEndDate"] = ExpressionConverter.Convert(__workflow_modEndDate);
                if (__workflow_pubStartDate != null)
                    callPayload.Queries["pubStartDate"] = ExpressionConverter.Convert(__workflow_pubStartDate);
                if (__workflow_pubEndDate != null)
                    callPayload.Queries["pubEndDate"] = ExpressionConverter.Convert(__workflow_pubEndDate);
                if (__workflow_resultsPerPage != null)
                    callPayload.Queries["resultsPerPage"] = ExpressionConverter.Convert(__workflow_resultsPerPage);
                if (__workflow_startIndex != null)
                    callPayload.Queries["startIndex"] = ExpressionConverter.Convert(__workflow_startIndex);
                return new ApiConnectionAction<GetCveCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nistnvdip")]
        public IBodyWorkflowAction<GetCpeCollectionResponse, ApiConnectionActionConfiguration> GetCpeCollection(Expression<Func<GetCpeCollectionAddOnsInput>> addOns = null, Expression<Func<string>> cpeMatchString = null, Expression<Func<bool>> includeDeprecated = null, Expression<Func<string>> keyword = null, Expression<Func<string>> modStartDate = null, Expression<Func<string>> modEndDate = null, Expression<Func<int>> resultsPerPage = null, Expression<Func<int>> startIndex = null)
        {
            var __workflow_addOns = WorkflowExpression.Compile(addOns, nameof(addOns), required: false);
            var __workflow_cpeMatchString = WorkflowExpression.Compile(cpeMatchString, nameof(cpeMatchString), required: false);
            var __workflow_includeDeprecated = WorkflowExpression.Compile(includeDeprecated, nameof(includeDeprecated), required: false);
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: false);
            var __workflow_modStartDate = WorkflowExpression.Compile(modStartDate, nameof(modStartDate), required: false);
            var __workflow_modEndDate = WorkflowExpression.Compile(modEndDate, nameof(modEndDate), required: false);
            var __workflow_resultsPerPage = WorkflowExpression.Compile(resultsPerPage, nameof(resultsPerPage), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            return new DeferredBodyAction<GetCpeCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cpes/1.0/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOns != null)
                    callPayload.Queries["addOns"] = ExpressionConverter.Convert(__workflow_addOns);
                callPayload.Queries["cpeMatchString"] = Convert.ToString("cpe:2.3:*:microsoft");
                if (__workflow_cpeMatchString != null)
                    callPayload.Queries["cpeMatchString"] = ExpressionConverter.Convert(__workflow_cpeMatchString);
                callPayload.Queries["includeDeprecated"] = Convert.ToString(false);
                if (__workflow_includeDeprecated != null)
                    callPayload.Queries["includeDeprecated"] = ExpressionConverter.Convert(__workflow_includeDeprecated);
                if (__workflow_keyword != null)
                    callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                if (__workflow_modStartDate != null)
                    callPayload.Queries["modStartDate"] = ExpressionConverter.Convert(__workflow_modStartDate);
                if (__workflow_modEndDate != null)
                    callPayload.Queries["modEndDate"] = ExpressionConverter.Convert(__workflow_modEndDate);
                if (__workflow_resultsPerPage != null)
                    callPayload.Queries["resultsPerPage"] = ExpressionConverter.Convert(__workflow_resultsPerPage);
                if (__workflow_startIndex != null)
                    callPayload.Queries["startIndex"] = ExpressionConverter.Convert(__workflow_startIndex);
                return new ApiConnectionAction<GetCpeCollectionResponse>(callPayload);
            });
        }
    }

    public class NistnvdipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCveCollectionResponse
    {
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("result")]
        public GetCveCollectionResponseResultType Result { get; set; }
    }

    public class GetCveCollectionResponseResultType
    {
        [JsonProperty("CVE_data_type")]
        public string CveDataType { get; set; }

        [JsonProperty("CVE_data_format")]
        public string CveDataFormat { get; set; }

        [JsonProperty("CVE_data_version")]
        public string CveDataVersion { get; set; }

        [JsonProperty("CVE_data_timestamp")]
        public string CveDataTimestamp { get; set; }

        [JsonProperty("CVE_Items")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItem[] CveItems { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItem
    {
        [JsonProperty("cve")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveType Cve { get; set; }

        [JsonProperty("configurations")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsType Configurations { get; set; }

        [JsonProperty("impact")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemImpactType Impact { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveType
    {
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("data_format")]
        public string DataFormat { get; set; }

        [JsonProperty("data_version")]
        public string DataVersion { get; set; }

        [JsonProperty("CVE_data_meta")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeCveDataMetaType CveDataMeta { get; set; }

        [JsonProperty("problemtype")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeType Problemtype { get; set; }

        [JsonProperty("references")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeReferencesType References { get; set; }

        [JsonProperty("description")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeDescriptionType Description { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeCveDataMetaType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("ASSIGNER")]
        public string Assigner { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeType
    {
        [JsonProperty("problemtype_data")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItem[] ProblemtypeData { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItem
    {
        [JsonProperty("description")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItemDescriptionTypeItem[] Description { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItemDescriptionTypeItem
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeReferencesType
    {
        [JsonProperty("reference_data")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeReferencesTypeReferenceDataTypeItem[] ReferenceData { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeReferencesTypeReferenceDataTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refsource")]
        public string Refsource { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeDescriptionType
    {
        [JsonProperty("description_data")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeDescriptionTypeDescriptionDataTypeItem[] DescriptionData { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemCveTypeDescriptionTypeDescriptionDataTypeItem
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsType
    {
        [JsonProperty("CVE_data_version")]
        public string CveDataVersion { get; set; }

        [JsonProperty("nodes")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItem[] Nodes { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("children")]
        public JToken[] Children { get; set; }

        [JsonProperty("cpe_match")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItem[] CpeMatch { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItem
    {
        [JsonProperty("vulnerable")]
        public bool Vulnerable { get; set; }

        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("versionEndExcluding")]
        public string VersionEndExcluding { get; set; }

        [JsonProperty("cpe_name")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItemCpeNameTypeItem[] CpeName { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItemCpeNameTypeItem
    {
        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemImpactType
    {
        [JsonProperty("baseMetricV3")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV3Type BaseMetricV3 { get; set; }

        [JsonProperty("baseMetricV2")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV2Type BaseMetricV2 { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV3Type
    {
        [JsonProperty("cvssV3")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV3TypeCvssV3Type CvssV3 { get; set; }

        [JsonProperty("exploitabilityScore")]
        public JToken ExploitabilityScore { get; set; }

        [JsonProperty("impactScore")]
        public JToken ImpactScore { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV3TypeCvssV3Type
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vectorString")]
        public string VectorString { get; set; }

        [JsonProperty("attackVector")]
        public string AttackVector { get; set; }

        [JsonProperty("attackComplexity")]
        public string AttackComplexity { get; set; }

        [JsonProperty("privilegesRequired")]
        public string PrivilegesRequired { get; set; }

        [JsonProperty("userInteraction")]
        public string UserInteraction { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonProperty("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonProperty("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonProperty("baseScore")]
        public JToken BaseScore { get; set; }

        [JsonProperty("baseSeverity")]
        public string BaseSeverity { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV2Type
    {
        [JsonProperty("cvssV2")]
        public GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV2TypeCvssV2Type CvssV2 { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("exploitabilityScore")]
        public JToken ExploitabilityScore { get; set; }

        [JsonProperty("impactScore")]
        public JToken ImpactScore { get; set; }

        [JsonProperty("acInsufInfo")]
        public bool AcInsufInfo { get; set; }

        [JsonProperty("obtainAllPrivilege")]
        public bool ObtainAllPrivilege { get; set; }

        [JsonProperty("obtainUserPrivilege")]
        public bool ObtainUserPrivilege { get; set; }

        [JsonProperty("obtainOtherPrivilege")]
        public bool ObtainOtherPrivilege { get; set; }

        [JsonProperty("userInteractionRequired")]
        public bool UserInteractionRequired { get; set; }
    }

    public class GetCveCollectionResponseResultTypeCveItemsTypeItemImpactTypeBaseMetricV2TypeCvssV2Type
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vectorString")]
        public string VectorString { get; set; }

        [JsonProperty("accessVector")]
        public string AccessVector { get; set; }

        [JsonProperty("accessComplexity")]
        public string AccessComplexity { get; set; }

        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonProperty("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonProperty("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonProperty("baseScore")]
        public JToken BaseScore { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetCveCollectionAddOnsInput
    {
        [EnumMember(Value = "dictionaryCpes")]
        DictionaryCpes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CvssV2SeverityInput
    {
        [EnumMember(Value = "LOW")]
        Low,
        [EnumMember(Value = "MEDIUM")]
        Medium,
        [EnumMember(Value = "HIGH")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CvssV3SeverityInput
    {
        [EnumMember(Value = "LOW")]
        Low,
        [EnumMember(Value = "MEDIUM")]
        Medium,
        [EnumMember(Value = "HIGH")]
        High,
        [EnumMember(Value = "CRITICAL")]
        Critical
    }

    public class GetCpeCollectionResponse
    {
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("result")]
        public GetCpeCollectionResponseResultType Result { get; set; }
    }

    public class GetCpeCollectionResponseResultType
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("feedVersion")]
        public string FeedVersion { get; set; }

        [JsonProperty("cpeCount")]
        public int CpeCount { get; set; }

        [JsonProperty("feedTimestamp")]
        public string FeedTimestamp { get; set; }

        [JsonProperty("cpes")]
        public GetCpeCollectionResponseResultTypeCpesTypeItem[] Cpes { get; set; }
    }

    public class GetCpeCollectionResponseResultTypeCpesTypeItem
    {
        [JsonProperty("deprecated")]
        public bool Deprecated { get; set; }

        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("titles")]
        public GetCpeCollectionResponseResultTypeCpesTypeItemTitlesTypeItem[] Titles { get; set; }

        [JsonProperty("refs")]
        public JToken[] Refs { get; set; }

        [JsonProperty("deprecatedBy")]
        public JToken[] DeprecatedBy { get; set; }

        [JsonProperty("vulnerabilities")]
        public JToken[] Vulnerabilities { get; set; }
    }

    public class GetCpeCollectionResponseResultTypeCpesTypeItemTitlesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetCpeCollectionAddOnsInput
    {
        [EnumMember(Value = "cves")]
        Cves
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nistnvdip;

    public partial class WorkflowManagedActions
    {
        public NistnvdipActions Nistnvdip(string connectionId) => new NistnvdipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NistnvdipTriggers Nistnvdip(string connectionId) => new NistnvdipTriggers(connectionId);
    }
}