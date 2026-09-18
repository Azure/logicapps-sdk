//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Financialconductauth
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinancialconductauthActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<CommonSearchResponse> CommonSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<typeInput> type)
        {
            var apiCallPath = "/services/V0.1/Search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<CommonSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<IndividualsDetailsByIRNResponse> IndividualsDetailsByIRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> iRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(iRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IndividualsDetailsByIRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmDetailsByFRNResponse> FirmDetailsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmDetailsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<ProductDetailsByPRNResponse> ProductDetailsByPRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pRN)
        {
            var apiCallPath = String.Format("/services/V0.1/CIS/{0}", ExpressionConverter.ConvertWithUrlEncoding(pRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProductDetailsByPRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<SubfundDetailsByPRNResponse> SubfundDetailsByPRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pRN)
        {
            var apiCallPath = String.Format("/services/V0.1/CIS/{0}/Subfund", ExpressionConverter.ConvertWithUrlEncoding(pRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SubfundDetailsByPRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<ProductOtherNameDetailsByPRNResponse> ProductOtherNameDetailsByPRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pRN)
        {
            var apiCallPath = String.Format("/services/V0.1/CIS/{0}/Names", ExpressionConverter.ConvertWithUrlEncoding(pRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProductOtherNameDetailsByPRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<IndividualDisciplinaryHistoryByIRNResponse> IndividualDisciplinaryHistoryByIRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> iRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Individuals/{0}/DisciplinaryHistory", ExpressionConverter.ConvertWithUrlEncoding(iRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IndividualDisciplinaryHistoryByIRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmOtherNamesByFRNResponse> FirmOtherNamesByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Names", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmOtherNamesByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmAddressByFRNResponse> FirmAddressByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Address", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmAddressByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmIndividualsByFRNResponse> FirmIndividualsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Individuals", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmIndividualsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmActivitiesAndPermissionsByFRNResponse> FirmActivitiesAndPermissionsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Permissions", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmActivitiesAndPermissionsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRequirementsInvestmentTypesByFRNandREQREFResponse> FirmRequirementsInvestmentTypesByFRNandREQREF([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> rEQREF)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Requirements/{1}/InvestmentTypes", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1), ExpressionConverter.ConvertWithUrlEncoding(rEQREF, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmRequirementsInvestmentTypesByFRNandREQREFResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRegulatorsByFRNResponse> FirmRegulatorsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Regulators/", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmRegulatorsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmPassportByFRNResponse> FirmPassportByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Passports/", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmPassportByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmExclusionsByFRNResponse> FirmExclusionsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Exclusions", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmExclusionsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmDisciplinaryHistoryByFRNResponse> FirmDisciplinaryHistoryByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/DisciplinaryHistory", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmDisciplinaryHistoryByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRequirementsByFRNResponse> FirmRequirementsByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Requirements", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmRequirementsByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmWaiverByFRNResponse> FirmWaiverByFRN([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Waivers", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmWaiverByFRNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmPassportPermissionByFRNandCountryResponse> FirmPassportPermissionByFRNandCountry([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fRN, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> country)
        {
            var apiCallPath = String.Format("/services/V0.1/Firm/{0}/Passports/{1}/Permission/", ExpressionConverter.ConvertWithUrlEncoding(fRN, 1), ExpressionConverter.ConvertWithUrlEncoding(country, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirmPassportPermissionByFRNandCountryResponse>(callPayload);
        }
    }

    public class FinancialconductauthTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommonSearchResponse
    {
        public string Status { get; set; }
        public CommonSearchResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public CommonSearchResponseDataTypeItem[] Data { get; set; }
    }

    public class CommonSearchResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class CommonSearchResponseDataTypeItem
    {
        public string URL { get; set; }
        public string Status { get; set; }

        [JsonProperty("Reference Number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("Type of business or Individual")]
        public string TypeOfBusinessOrIndividual { get; set; }
        public string Name { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "firm")]
        Firm,
        [EnumMember(Value = "fund")]
        Fund
    }

    public class IndividualsDetailsByIRNResponse
    {
        public string Status { get; set; }
        public IndividualsDetailsByIRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public IndividualsDetailsByIRNResponseDataTypeItem[] Data { get; set; }
    }

    public class IndividualsDetailsByIRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class IndividualsDetailsByIRNResponseDataTypeItem
    {
        public IndividualsDetailsByIRNResponseDataTypeItemDetailsType Details { get; set; }

        [JsonProperty("Workplace Location 1")]
        public IndividualsDetailsByIRNResponseDataTypeItemWorkplaceLocation1Type WorkplaceLocation1 { get; set; }
    }

    public class IndividualsDetailsByIRNResponseDataTypeItemDetailsType
    {
        public string Status { get; set; }

        [JsonProperty("Disciplinary History")]
        public string DisciplinaryHistory { get; set; }

        [JsonProperty("Roles & Activities")]
        public string RolesActivities { get; set; }
        public string IRN { get; set; }

        [JsonProperty("Commonly Used Name")]
        public string CommonlyUsedName { get; set; }

        [JsonProperty("Full Name")]
        public string FullName { get; set; }
    }

    public class IndividualsDetailsByIRNResponseDataTypeItemWorkplaceLocation1Type
    {
        [JsonProperty("Firm Name")]
        public string FirmName { get; set; }

        [JsonProperty("Location 1")]
        public string Location1 { get; set; }
    }

    public class FirmDetailsByFRNResponse
    {
        public string Status { get; set; }
        public FirmDetailsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmDetailsByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmDetailsByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmDetailsByFRNResponseDataTypeItem
    {
        public string Name { get; set; }
        public string Individuals { get; set; }
        public string Requirements { get; set; }
        public string Permission { get; set; }
        public string Passport { get; set; }
        public string Regulators { get; set; }

        [JsonProperty("Appointed Representative")]
        public string AppointedRepresentative { get; set; }
        public string Address { get; set; }
        public string Waivers { get; set; }
        public string Exclusions { get; set; }
        public string DisciplinaryHistory { get; set; }

        [JsonProperty("System Timestamp")]
        public string SystemTimestamp { get; set; }

        [JsonProperty("Exceptional Info Details")]
        public FirmDetailsByFRNResponseDataTypeItemExceptionalInfoDetailsTypeItem[] ExceptionalInfoDetails { get; set; }

        [JsonProperty("Status Effective Date")]
        public string StatusEffectiveDate { get; set; }

        [JsonProperty("E-Money Agent Status")]
        public string EMoneyAgentStatus { get; set; }

        [JsonProperty("PSD / EMD Effective Date")]
        public string PSDEMDEffectiveDate { get; set; }

        [JsonProperty("Client Money Permission")]
        public string ClientMoneyPermission { get; set; }

        [JsonProperty("Sub Status Effective from")]
        public string SubStatusEffectiveFrom { get; set; }

        [JsonProperty("Sub-Status")]
        public string SubStatus { get; set; }

        [JsonProperty("Mutual Society Number")]
        public string MutualSocietyNumber { get; set; }

        [JsonProperty("Companies House Number")]
        public string CompaniesHouseNumber { get; set; }

        [JsonProperty("MLRs Status Effective Date")]
        public string MLRsStatusEffectiveDate { get; set; }

        [JsonProperty("MLRs Status")]
        public string MLRsStatus { get; set; }

        [JsonProperty("E-Money Agent Effective Date")]
        public string EMoneyAgentEffectiveDate { get; set; }

        [JsonProperty("PSD Agent Effective date")]
        public string PSDAgentEffectiveDate { get; set; }

        [JsonProperty("PSD Agent Status")]
        public string PSDAgentStatus { get; set; }

        [JsonProperty("PSD / EMD Status")]
        public string PSDEMDStatus { get; set; }
        public string Status { get; set; }

        [JsonProperty("Business Type")]
        public string BusinessType { get; set; }

        [JsonProperty("Organisation Name")]
        public string OrganisationName { get; set; }
        public string FRN { get; set; }
    }

    public class FirmDetailsByFRNResponseDataTypeItemExceptionalInfoDetailsTypeItem
    {
        [JsonProperty("Exceptional Info Title")]
        public string ExceptionalInfoTitle { get; set; }

        [JsonProperty("Exceptional Info Body")]
        public string ExceptionalInfoBody { get; set; }
    }

    public class ProductDetailsByPRNResponse
    {
        public string Status { get; set; }
        public ProductDetailsByPRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public ProductDetailsByPRNResponseDataTypeItem[] Data { get; set; }
    }

    public class ProductDetailsByPRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class ProductDetailsByPRNResponseDataTypeItem
    {
        [JsonProperty("Sub-funds")]
        public string SubFunds { get; set; }

        [JsonProperty("Other Name")]
        public string OtherName { get; set; }

        [JsonProperty("CIS Depositary")]
        public string CISDepositary { get; set; }

        [JsonProperty("CIS Depositary Name")]
        public string CISDepositaryName { get; set; }

        [JsonProperty("Operator Name")]
        public string OperatorName { get; set; }
        public string Operator { get; set; }

        [JsonProperty("MMF Term Type")]
        public string MMFTermType { get; set; }

        [JsonProperty("MMF NAV Type")]
        public string MMFNAVType { get; set; }

        [JsonProperty("Effective Date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("Scheme Type")]
        public string SchemeType { get; set; }

        [JsonProperty("Product Type")]
        public string ProductType { get; set; }

        [JsonProperty("ICVC Registration No")]
        public string ICVCRegistrationNo { get; set; }
        public string Status { get; set; }
    }

    public class SubfundDetailsByPRNResponse
    {
        public string Status { get; set; }
        public SubfundDetailsByPRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public SubfundDetailsByPRNResponseDataTypeItem[] Data { get; set; }
    }

    public class SubfundDetailsByPRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class SubfundDetailsByPRNResponseDataTypeItem
    {
        public string URL { get; set; }

        [JsonProperty("Sub-Fund Type")]
        public string SubFundType { get; set; }
        public string Name { get; set; }
    }

    public class ProductOtherNameDetailsByPRNResponse
    {
        public string Status { get; set; }
        public ProductOtherNameDetailsByPRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public ProductOtherNameDetailsByPRNResponseDataTypeItem[] Data { get; set; }
    }

    public class ProductOtherNameDetailsByPRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class ProductOtherNameDetailsByPRNResponseDataTypeItem
    {
        [JsonProperty("Effective To")]
        public string EffectiveTo { get; set; }

        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }

        [JsonProperty("Product Other Name")]
        public string ProductOtherName { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIRNResponse
    {
        public string Status { get; set; }
        public IndividualDisciplinaryHistoryByIRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public IndividualDisciplinaryHistoryByIRNResponseDataTypeItem[] Data { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIRNResponseDataTypeItem
    {
        public string TypeofDescription { get; set; }
        public string TypeofAction { get; set; }
        public string EnforcementType { get; set; }
        public string ActionEffectiveFrom { get; set; }
    }

    public class FirmOtherNamesByFRNResponse
    {
        public string Status { get; set; }
        public FirmOtherNamesByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmOtherNamesByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmOtherNamesByFRNResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmOtherNamesByFRNResponseDataTypeItem
    {
        [JsonProperty("Current Names")]
        public FirmOtherNamesByFRNResponseDataTypeItemCurrentNamesTypeItem[] CurrentNames { get; set; }

        [JsonProperty("Previous Names")]
        public FirmOtherNamesByFRNResponseDataTypeItemPreviousNamesTypeItem[] PreviousNames { get; set; }
    }

    public class FirmOtherNamesByFRNResponseDataTypeItemCurrentNamesTypeItem
    {
        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
    }

    public class FirmOtherNamesByFRNResponseDataTypeItemPreviousNamesTypeItem
    {
        [JsonProperty("Effective To")]
        public string EffectiveTo { get; set; }

        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
    }

    public class FirmAddressByFRNResponse
    {
        public string Status { get; set; }
        public FirmAddressByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmAddressByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmAddressByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmAddressByFRNResponseDataTypeItem
    {
        public string URL { get; set; }

        [JsonProperty("Website Address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("Phone Number")]
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Town { get; set; }

        [JsonProperty("Address Line 4")]
        public string AddressLine4 { get; set; }

        [JsonProperty("Address Line 3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("Address Line 2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("Address Line 1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("Address Type")]
        public string AddressType { get; set; }
    }

    public class FirmIndividualsByFRNResponse
    {
        public string Status { get; set; }
        public FirmIndividualsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmIndividualsByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmIndividualsByFRNResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmIndividualsByFRNResponseDataTypeItem
    {
        public string Status { get; set; }
        public string URL { get; set; }
        public string IRN { get; set; }
        public string Name { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponse
    {
        public string Status { get; set; }
        public FirmActivitiesAndPermissionsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmActivitiesAndPermissionsByFRNResponseDataType Data { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataType
    {
        [JsonProperty("Acting as a CBTL advisor")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeActingAsACBTLAdvisorTypeItem[] ActingAsACBTLAdvisor { get; set; }

        [JsonProperty("Acting as a CBTL Administrator")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeActingAsACBTLAdministratorTypeItem2[] ActingAsACBTLAdministrator { get; set; }

        [JsonProperty("CBTL Status")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeCBTLStatusTypeItem[] CBTLStatus { get; set; }

        [JsonProperty("CBTL Effective Date")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeCBTLEffectiveDateTypeItem[] CBTLEffectiveDate { get; set; }

        [JsonProperty("Entering into Regulated Consumer Hire Agreements as owner")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeEnteringIntoRegulatedConsumerHireAgreementsAsOwnerTypeItem[] EnteringIntoRegulatedConsumerHireAgreementsAsOwner { get; set; }

        [JsonProperty("Agreeing to carry on a regulated activity")]
        public FirmActivitiesAndPermissionsByFRNResponseDataTypeAgreeingToCarryOnARegulatedActivityTypeItem[] AgreeingToCarryOnARegulatedActivity { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeActingAsACBTLAdvisorTypeItem
    {
        [JsonProperty("Acting as a CBTL advisor")]
        public string[] ActingAsACBTLAdvisor { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeActingAsACBTLAdministratorTypeItem2
    {
        [JsonProperty("Limitation Not Found")]
        public string[] LimitationNotFound { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeCBTLStatusTypeItem
    {
        [JsonProperty("CBTL Status")]
        public string[] CBTLStatus { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeCBTLEffectiveDateTypeItem
    {
        [JsonProperty("CBTL Effective Date")]
        public string[] CBTLEffectiveDate { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeEnteringIntoRegulatedConsumerHireAgreementsAsOwnerTypeItem
    {
        public string[] Limitation { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFRNResponseDataTypeAgreeingToCarryOnARegulatedActivityTypeItem
    {
        [JsonProperty("Limitation Not Found")]
        public string[] LimitationNotFound { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandREQREFResponse
    {
        public string Status { get; set; }
        public FirmRequirementsInvestmentTypesByFRNandREQREFResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRequirementsInvestmentTypesByFRNandREQREFResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandREQREFResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandREQREFResponseDataTypeItem
    {
        [JsonProperty("Investment Type Name")]
        public string InvestmentTypeName { get; set; }
    }

    public class FirmRegulatorsByFRNResponse
    {
        public string Status { get; set; }
        public FirmRegulatorsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRegulatorsByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRegulatorsByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRegulatorsByFRNResponseDataTypeItem
    {
        [JsonProperty("Termination Date")]
        public string TerminationDate { get; set; }

        [JsonProperty("Effective Date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("Regulator Name")]
        public string RegulatorName { get; set; }
    }

    public class FirmPassportByFRNResponse
    {
        public string Status { get; set; }
        public FirmPassportByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmPassportByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmPassportByFRNResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmPassportByFRNResponseDataTypeItem
    {
        public FirmPassportByFRNResponseDataTypeItemPassportsTypeItem[] Passports { get; set; }
    }

    public class FirmPassportByFRNResponseDataTypeItemPassportsTypeItem
    {
        public string PassportDirection { get; set; }
        public string Permissions { get; set; }
        public string Country { get; set; }
    }

    public class FirmExclusionsByFRNResponse
    {
        [JsonProperty(";Status")]
        public string Status { get; set; }
        public FirmExclusionsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmExclusionsByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmExclusionsByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmExclusionsByFRNResponseDataTypeItem
    {
        [JsonProperty("PSD2_Exclusion_Type")]
        public string PSD2ExclusionType { get; set; }

        [JsonProperty("Particular_Exclusion_relied_upon")]
        public string ParticularExclusionReliedUpon { get; set; }

        [JsonProperty("Description_of_services")]
        public string DescriptionOfServices { get; set; }
    }

    public class FirmDisciplinaryHistoryByFRNResponse
    {
        public string Status { get; set; }
        public FirmDisciplinaryHistoryByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmDisciplinaryHistoryByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmDisciplinaryHistoryByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmDisciplinaryHistoryByFRNResponseDataTypeItem
    {
        public string TypeofDescription { get; set; }
        public string TypeofAction { get; set; }
        public string EnforcementType { get; set; }
        public string ActionEffectiveFrom { get; set; }
    }

    public class FirmRequirementsByFRNResponse
    {
        public string Status { get; set; }
        public FirmRequirementsByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRequirementsByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRequirementsByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRequirementsByFRNResponseDataTypeItem
    {
        [JsonProperty("Effective Date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("Derivatives as incidental services only.")]
        public string DerivativesAsIncidentalServicesOnly { get; set; }

        [JsonProperty("Requirement Reference")]
        public string RequirementReference { get; set; }

        [JsonProperty("Financial Promotions Requirement")]
        public string FinancialPromotionsRequirement { get; set; }

        [JsonProperty("Financial Promotions Investment Types")]
        public string FinancialPromotionsInvestmentTypes { get; set; }
    }

    public class FirmWaiverByFRNResponse
    {
        public string Status { get; set; }
        public FirmWaiverByFRNResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmWaiverByFRNResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmWaiverByFRNResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmWaiverByFRNResponseDataTypeItem
    {
        [JsonProperty("Waivers_Discretions_URL")]
        public string WaiversDiscretionsURL { get; set; }

        [JsonProperty("Waivers_Discretions")]
        public string WaiversDiscretions { get; set; }

        [JsonProperty("Rule_ArticleNo")]
        public string[] RuleArticleNo { get; set; }
    }

    public class FirmPassportPermissionByFRNandCountryResponse
    {
        public string Status { get; set; }
        public FirmPassportPermissionByFRNandCountryResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmPassportPermissionByFRNandCountryResponseDataTypeItem[] Data { get; set; }
        public string PassportType { get; set; }
        public string PassportDirection { get; set; }
        public string Directive { get; set; }
        public string Country { get; set; }
    }

    public class FirmPassportPermissionByFRNandCountryResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmPassportPermissionByFRNandCountryResponseDataTypeItem
    {
        public FirmPassportPermissionByFRNandCountryResponseDataTypeItemPermissionsTypeItem[] Permissions { get; set; }
    }

    public class FirmPassportPermissionByFRNandCountryResponseDataTypeItemPermissionsTypeItem
    {
        public string Name { get; set; }
        public string[] InvestmentTypes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Financialconductauth;

    public partial class WorkflowManagedActions
    {
        public FinancialconductauthActions Financialconductauth(string connectionId) => new FinancialconductauthActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinancialconductauthTriggers Financialconductauth(string connectionId) => new FinancialconductauthTriggers(connectionId);
    }
}