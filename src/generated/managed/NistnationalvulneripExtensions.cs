//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nistnationalvulnerip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NistnationalvulneripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nistnationalvulnerip")]
        public IBodyWorkflowAction<GetCVECollectionResponse> GetCVECollection([WorkflowExpression] Func<addOnsInput> addOns = null, [WorkflowExpression] Func<string> cpeMatchString = null, [WorkflowExpression] Func<string> cvssV2Metrics = null, [WorkflowExpression] Func<cvssV2SeverityInput> cvssV2Severity = null, [WorkflowExpression] Func<string> cvssV3Metrics = null, [WorkflowExpression] Func<cvssV3SeverityInput> cvssV3Severity = null, [WorkflowExpression] Func<string> cweId = null, [WorkflowExpression] Func<bool> includeMatchStringChange = null, [WorkflowExpression] Func<bool> isExactMatch = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> modStartDate = null, [WorkflowExpression] Func<string> modEndDate = null, [WorkflowExpression] Func<string> pubStartDate = null, [WorkflowExpression] Func<string> pubEndDate = null, [WorkflowExpression] Func<int> resultsPerPage = null, [WorkflowExpression] Func<int> startIndex = null)
        {
            SourceExpression.Validate(addOns, nameof(addOns), required: false);
            SourceExpression.Validate(cpeMatchString, nameof(cpeMatchString), required: false);
            SourceExpression.Validate(cvssV2Metrics, nameof(cvssV2Metrics), required: false);
            SourceExpression.Validate(cvssV2Severity, nameof(cvssV2Severity), required: false);
            SourceExpression.Validate(cvssV3Metrics, nameof(cvssV3Metrics), required: false);
            SourceExpression.Validate(cvssV3Severity, nameof(cvssV3Severity), required: false);
            SourceExpression.Validate(cweId, nameof(cweId), required: false);
            SourceExpression.Validate(includeMatchStringChange, nameof(includeMatchStringChange), required: false);
            SourceExpression.Validate(isExactMatch, nameof(isExactMatch), required: false);
            SourceExpression.Validate(keyword, nameof(keyword), required: false);
            SourceExpression.Validate(modStartDate, nameof(modStartDate), required: false);
            SourceExpression.Validate(modEndDate, nameof(modEndDate), required: false);
            SourceExpression.Validate(pubStartDate, nameof(pubStartDate), required: false);
            SourceExpression.Validate(pubEndDate, nameof(pubEndDate), required: false);
            SourceExpression.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            SourceExpression.Validate(startIndex, nameof(startIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cves/1.0/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (addOns != null)
                    callPayload.Queries["addOns"] = SourceExpressionConverter.Convert(addOns);
                if (cpeMatchString != null)
                    callPayload.Queries["cpeMatchString"] = SourceExpressionConverter.ConvertO(cpeMatchString);
                if (cvssV2Metrics != null)
                    callPayload.Queries["cvssV2Metrics"] = SourceExpressionConverter.ConvertO(cvssV2Metrics);
                if (cvssV2Severity != null)
                    callPayload.Queries["cvssV2Severity"] = SourceExpressionConverter.Convert(cvssV2Severity);
                if (cvssV3Metrics != null)
                    callPayload.Queries["cvssV3Metrics"] = SourceExpressionConverter.ConvertO(cvssV3Metrics);
                if (cvssV3Severity != null)
                    callPayload.Queries["cvssV3Severity"] = SourceExpressionConverter.Convert(cvssV3Severity);
                if (cweId != null)
                    callPayload.Queries["cweId"] = SourceExpressionConverter.ConvertO(cweId);
                if (includeMatchStringChange != null)
                    callPayload.Queries["includeMatchStringChange"] = SourceExpressionConverter.ConvertO(includeMatchStringChange);
                if (isExactMatch != null)
                    callPayload.Queries["isExactMatch"] = SourceExpressionConverter.ConvertO(isExactMatch);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (modStartDate != null)
                    callPayload.Queries["modStartDate"] = SourceExpressionConverter.ConvertO(modStartDate);
                if (modEndDate != null)
                    callPayload.Queries["modEndDate"] = SourceExpressionConverter.ConvertO(modEndDate);
                if (pubStartDate != null)
                    callPayload.Queries["pubStartDate"] = SourceExpressionConverter.ConvertO(pubStartDate);
                if (pubEndDate != null)
                    callPayload.Queries["pubEndDate"] = SourceExpressionConverter.ConvertO(pubEndDate);
                if (resultsPerPage != null)
                    callPayload.Queries["resultsPerPage"] = SourceExpressionConverter.ConvertO(resultsPerPage);
                if (startIndex != null)
                    callPayload.Queries["startIndex"] = SourceExpressionConverter.ConvertO(startIndex);
                return callPayload;
            }

            return new ApiConnectionAction<GetCVECollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nistnationalvulnerip")]
        public IBodyWorkflowAction<GetCPECollectionResponse> GetCPECollection([WorkflowExpression] Func<addOnsInput> addOns = null, [WorkflowExpression] Func<string> cpeMatchString = null, [WorkflowExpression] Func<bool> includeDeprecated = null, [WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> modStartDate = null, [WorkflowExpression] Func<string> modEndDate = null, [WorkflowExpression] Func<int> resultsPerPage = null, [WorkflowExpression] Func<int> startIndex = null)
        {
            SourceExpression.Validate(addOns, nameof(addOns), required: false);
            SourceExpression.Validate(cpeMatchString, nameof(cpeMatchString), required: false);
            SourceExpression.Validate(includeDeprecated, nameof(includeDeprecated), required: false);
            SourceExpression.Validate(keyword, nameof(keyword), required: false);
            SourceExpression.Validate(modStartDate, nameof(modStartDate), required: false);
            SourceExpression.Validate(modEndDate, nameof(modEndDate), required: false);
            SourceExpression.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            SourceExpression.Validate(startIndex, nameof(startIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cpes/1.0/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (addOns != null)
                    callPayload.Queries["addOns"] = SourceExpressionConverter.Convert(addOns);
                callPayload.Queries["cpeMatchString"] = Convert.ToString("cpe:2.3:*:microsoft");
                if (cpeMatchString != null)
                    callPayload.Queries["cpeMatchString"] = SourceExpressionConverter.ConvertO(cpeMatchString);
                callPayload.Queries["includeDeprecated"] = Convert.ToString(false);
                if (includeDeprecated != null)
                    callPayload.Queries["includeDeprecated"] = SourceExpressionConverter.ConvertO(includeDeprecated);
                if (keyword != null)
                    callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (modStartDate != null)
                    callPayload.Queries["modStartDate"] = SourceExpressionConverter.ConvertO(modStartDate);
                if (modEndDate != null)
                    callPayload.Queries["modEndDate"] = SourceExpressionConverter.ConvertO(modEndDate);
                if (resultsPerPage != null)
                    callPayload.Queries["resultsPerPage"] = SourceExpressionConverter.ConvertO(resultsPerPage);
                if (startIndex != null)
                    callPayload.Queries["startIndex"] = SourceExpressionConverter.ConvertO(startIndex);
                return callPayload;
            }

            return new ApiConnectionAction<GetCPECollectionResponse>(BuildSourceInput);
        }
    }

    public class NistnationalvulneripTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCVECollectionResponse
    {
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("result")]
        public GetCVECollectionResponseResultType Result { get; set; }
    }

    public class GetCVECollectionResponseResultType
    {
        [JsonProperty("CVE_data_type")]
        public string CVEDataType { get; set; }

        [JsonProperty("CVE_data_format")]
        public string CVEDataFormat { get; set; }

        [JsonProperty("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonProperty("CVE_data_timestamp")]
        public string CVEDataTimestamp { get; set; }

        [JsonProperty("CVE_Items")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItem[] CVEItems { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItem
    {
        [JsonProperty("cve")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveType Cve { get; set; }

        [JsonProperty("configurations")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsType Configurations { get; set; }

        [JsonProperty("impact")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactType Impact { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveType
    {
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("data_format")]
        public string DataFormat { get; set; }

        [JsonProperty("data_version")]
        public string DataVersion { get; set; }

        [JsonProperty("CVE_data_meta")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeCVEDataMetaType CVEDataMeta { get; set; }

        [JsonProperty("problemtype")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeType Problemtype { get; set; }

        [JsonProperty("references")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeReferencesType References { get; set; }

        [JsonProperty("description")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeDescriptionType Description { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeCVEDataMetaType
    {
        public string ID { get; set; }
        public string ASSIGNER { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeType
    {
        [JsonProperty("problemtype_data")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItem[] ProblemtypeData { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItem
    {
        [JsonProperty("description")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItemDescriptionTypeItem[] Description { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeProblemtypeTypeProblemtypeDataTypeItemDescriptionTypeItem
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeReferencesType
    {
        [JsonProperty("reference_data")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeReferencesTypeReferenceDataTypeItem[] ReferenceData { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeReferencesTypeReferenceDataTypeItem
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

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeDescriptionType
    {
        [JsonProperty("description_data")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeDescriptionTypeDescriptionDataTypeItem[] DescriptionData { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemCveTypeDescriptionTypeDescriptionDataTypeItem
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsType
    {
        [JsonProperty("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonProperty("nodes")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItem[] Nodes { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("children")]
        public JToken[] Children { get; set; }

        [JsonProperty("cpe_match")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItem[] CpeMatch { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItem
    {
        [JsonProperty("vulnerable")]
        public bool Vulnerable { get; set; }

        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("versionEndExcluding")]
        public string VersionEndExcluding { get; set; }

        [JsonProperty("cpe_name")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItemCpeNameTypeItem[] CpeName { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemConfigurationsTypeNodesTypeItemCpeMatchTypeItemCpeNameTypeItem
    {
        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactType
    {
        [JsonProperty("baseMetricV3")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV3Type BaseMetricV3 { get; set; }

        [JsonProperty("baseMetricV2")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV2Type BaseMetricV2 { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV3Type
    {
        [JsonProperty("cvssV3")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV3TypeCvssV3Type CvssV3 { get; set; }

        [JsonProperty("exploitabilityScore")]
        public JToken ExploitabilityScore { get; set; }

        [JsonProperty("impactScore")]
        public JToken ImpactScore { get; set; }
    }

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV3TypeCvssV3Type
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

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV2Type
    {
        [JsonProperty("cvssV2")]
        public GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV2TypeCvssV2Type CvssV2 { get; set; }

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

    public class GetCVECollectionResponseResultTypeCVEItemsTypeItemImpactTypeBaseMetricV2TypeCvssV2Type
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

    public enum addOnsInput
    {
        [EnumMember(Value = "cves")]
        Cves
    }

    public enum cvssV2SeverityInput
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public enum cvssV3SeverityInput
    {
        LOW,
        MEDIUM,
        HIGH,
        CRITICAL
    }

    public class GetCPECollectionResponse
    {
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("result")]
        public GetCPECollectionResponseResultType Result { get; set; }
    }

    public class GetCPECollectionResponseResultType
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
        public GetCPECollectionResponseResultTypeCpesTypeItem[] Cpes { get; set; }
    }

    public class GetCPECollectionResponseResultTypeCpesTypeItem
    {
        [JsonProperty("deprecated")]
        public bool Deprecated { get; set; }

        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("titles")]
        public GetCPECollectionResponseResultTypeCpesTypeItemTitlesTypeItem[] Titles { get; set; }

        [JsonProperty("refs")]
        public JToken[] Refs { get; set; }

        [JsonProperty("deprecatedBy")]
        public JToken[] DeprecatedBy { get; set; }

        [JsonProperty("vulnerabilities")]
        public JToken[] Vulnerabilities { get; set; }
    }

    public class GetCPECollectionResponseResultTypeCpesTypeItemTitlesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nistnationalvulnerip;

    public partial class WorkflowManagedActions
    {
        public NistnationalvulneripActions Nistnationalvulnerip(string connectionId) => new NistnationalvulneripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NistnationalvulneripTriggers Nistnationalvulnerip(string connectionId) => new NistnationalvulneripTriggers(connectionId);
    }
}