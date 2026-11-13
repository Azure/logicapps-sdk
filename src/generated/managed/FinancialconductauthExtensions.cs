//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Financialconductauth
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinancialconductauthActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<CommonSearchResponse, ApiConnectionActionConfiguration> CommonSearch(Expression<Func<string>> q, Expression<Func<TypeInput>> type)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<CommonSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/V0.1/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<CommonSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<IndividualsDetailsByIrnResponse, ApiConnectionActionConfiguration> IndividualsDetailsByIrn(Expression<Func<string>> irn)
        {
            var __workflow_irn = WorkflowExpression.Compile(irn, nameof(irn), required: true);
            return new DeferredBodyAction<IndividualsDetailsByIrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Individuals/{0}", __workflow_irn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IndividualsDetailsByIrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmDetailsByFrnResponse, ApiConnectionActionConfiguration> FirmDetailsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmDetailsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmDetailsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<ProductDetailsByPrnResponse, ApiConnectionActionConfiguration> ProductDetailsByPrn(Expression<Func<string>> prn)
        {
            var __workflow_prn = WorkflowExpression.Compile(prn, nameof(prn), required: true);
            return new DeferredBodyAction<ProductDetailsByPrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/CIS/{0}", __workflow_prn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProductDetailsByPrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<SubfundDetailsByPrnResponse, ApiConnectionActionConfiguration> SubfundDetailsByPrn(Expression<Func<string>> prn)
        {
            var __workflow_prn = WorkflowExpression.Compile(prn, nameof(prn), required: true);
            return new DeferredBodyAction<SubfundDetailsByPrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/CIS/{0}/Subfund", __workflow_prn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubfundDetailsByPrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<ProductOtherNameDetailsByPrnResponse, ApiConnectionActionConfiguration> ProductOtherNameDetailsByPrn(Expression<Func<string>> prn)
        {
            var __workflow_prn = WorkflowExpression.Compile(prn, nameof(prn), required: true);
            return new DeferredBodyAction<ProductOtherNameDetailsByPrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/CIS/{0}/Names", __workflow_prn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProductOtherNameDetailsByPrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<IndividualDisciplinaryHistoryByIrnResponse, ApiConnectionActionConfiguration> IndividualDisciplinaryHistoryByIrn(Expression<Func<string>> irn)
        {
            var __workflow_irn = WorkflowExpression.Compile(irn, nameof(irn), required: true);
            return new DeferredBodyAction<IndividualDisciplinaryHistoryByIrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Individuals/{0}/DisciplinaryHistory", __workflow_irn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IndividualDisciplinaryHistoryByIrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmOtherNamesByFrnResponse, ApiConnectionActionConfiguration> FirmOtherNamesByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmOtherNamesByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Names", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmOtherNamesByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmAddressByFrnResponse, ApiConnectionActionConfiguration> FirmAddressByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmAddressByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Address", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmAddressByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmIndividualsByFrnResponse, ApiConnectionActionConfiguration> FirmIndividualsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmIndividualsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Individuals", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmIndividualsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmActivitiesAndPermissionsByFrnResponse, ApiConnectionActionConfiguration> FirmActivitiesAndPermissionsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmActivitiesAndPermissionsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Permissions", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmActivitiesAndPermissionsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRequirementsInvestmentTypesByFRNandReqrefResponse, ApiConnectionActionConfiguration> FirmRequirementsInvestmentTypesByFRNandReqref(Expression<Func<string>> frn, Expression<Func<string>> reqref)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            var __workflow_reqref = WorkflowExpression.Compile(reqref, nameof(reqref), required: true);
            return new DeferredBodyAction<FirmRequirementsInvestmentTypesByFRNandReqrefResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Requirements/{1}/InvestmentTypes", __workflow_frn.WithUrlEncoding(1), __workflow_reqref.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmRequirementsInvestmentTypesByFRNandReqrefResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRegulatorsByFrnResponse, ApiConnectionActionConfiguration> FirmRegulatorsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmRegulatorsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Regulators/", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmRegulatorsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmPassportByFrnResponse, ApiConnectionActionConfiguration> FirmPassportByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmPassportByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Passports/", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmPassportByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmExclusionsByFrnResponse, ApiConnectionActionConfiguration> FirmExclusionsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmExclusionsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Exclusions", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmExclusionsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmDisciplinaryHistoryByFrnResponse, ApiConnectionActionConfiguration> FirmDisciplinaryHistoryByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmDisciplinaryHistoryByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/DisciplinaryHistory", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmDisciplinaryHistoryByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmRequirementsByFrnResponse, ApiConnectionActionConfiguration> FirmRequirementsByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmRequirementsByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Requirements", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmRequirementsByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmWaiverByFrnResponse, ApiConnectionActionConfiguration> FirmWaiverByFrn(Expression<Func<string>> frn)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            return new DeferredBodyAction<FirmWaiverByFrnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Waivers", __workflow_frn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmWaiverByFrnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "financialconductauth")]
        public IBodyWorkflowAction<FirmPassportPermissionByFRNandCountryResponse, ApiConnectionActionConfiguration> FirmPassportPermissionByFRNandCountry(Expression<Func<string>> frn, Expression<Func<string>> country)
        {
            var __workflow_frn = WorkflowExpression.Compile(frn, nameof(frn), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            return new DeferredBodyAction<FirmPassportPermissionByFRNandCountryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/V0.1/Firm/{0}/Passports/{1}/Permission/", __workflow_frn.WithUrlEncoding(1), __workflow_country.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirmPassportPermissionByFRNandCountryResponse>(callPayload);
            });
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
        [JsonProperty("URL")]
        public string Url { get; set; }
        public string Status { get; set; }

        [JsonProperty("Reference Number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("Type of business or Individual")]
        public string TypeOfBusinessOrIndividual { get; set; }
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInput
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "firm")]
        Firm,
        [EnumMember(Value = "fund")]
        Fund
    }

    public class IndividualsDetailsByIrnResponse
    {
        public string Status { get; set; }
        public IndividualsDetailsByIrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public IndividualsDetailsByIrnResponseDataTypeItem[] Data { get; set; }
    }

    public class IndividualsDetailsByIrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class IndividualsDetailsByIrnResponseDataTypeItem
    {
        public IndividualsDetailsByIrnResponseDataTypeItemDetailsType Details { get; set; }

        [JsonProperty("Workplace Location 1")]
        public IndividualsDetailsByIrnResponseDataTypeItemWorkplaceLocation1Type WorkplaceLocation1 { get; set; }
    }

    public class IndividualsDetailsByIrnResponseDataTypeItemDetailsType
    {
        public string Status { get; set; }

        [JsonProperty("Disciplinary History")]
        public string DisciplinaryHistory { get; set; }

        [JsonProperty("Roles & Activities")]
        public string RolesActivities { get; set; }

        [JsonProperty("IRN")]
        public string Irn { get; set; }

        [JsonProperty("Commonly Used Name")]
        public string CommonlyUsedName { get; set; }

        [JsonProperty("Full Name")]
        public string FullName { get; set; }
    }

    public class IndividualsDetailsByIrnResponseDataTypeItemWorkplaceLocation1Type
    {
        [JsonProperty("Firm Name")]
        public string FirmName { get; set; }

        [JsonProperty("Location 1")]
        public string Location1 { get; set; }
    }

    public class FirmDetailsByFrnResponse
    {
        public string Status { get; set; }
        public FirmDetailsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmDetailsByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmDetailsByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmDetailsByFrnResponseDataTypeItem
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
        public FirmDetailsByFrnResponseDataTypeItemExceptionalInfoDetailsTypeItem[] ExceptionalInfoDetails { get; set; }

        [JsonProperty("Status Effective Date")]
        public string StatusEffectiveDate { get; set; }

        [JsonProperty("E-Money Agent Status")]
        public string EMoneyAgentStatus { get; set; }

        [JsonProperty("PSD / EMD Effective Date")]
        public string PsdEmdEffectiveDate { get; set; }

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
        public string MlrsStatusEffectiveDate { get; set; }

        [JsonProperty("MLRs Status")]
        public string MlrsStatus { get; set; }

        [JsonProperty("E-Money Agent Effective Date")]
        public string EMoneyAgentEffectiveDate { get; set; }

        [JsonProperty("PSD Agent Effective date")]
        public string PsdAgentEffectiveDate { get; set; }

        [JsonProperty("PSD Agent Status")]
        public string PsdAgentStatus { get; set; }

        [JsonProperty("PSD / EMD Status")]
        public string PsdEmdStatus { get; set; }
        public string Status { get; set; }

        [JsonProperty("Business Type")]
        public string BusinessType { get; set; }

        [JsonProperty("Organisation Name")]
        public string OrganisationName { get; set; }

        [JsonProperty("FRN")]
        public string Frn { get; set; }
    }

    public class FirmDetailsByFrnResponseDataTypeItemExceptionalInfoDetailsTypeItem
    {
        [JsonProperty("Exceptional Info Title")]
        public string ExceptionalInfoTitle { get; set; }

        [JsonProperty("Exceptional Info Body")]
        public string ExceptionalInfoBody { get; set; }
    }

    public class ProductDetailsByPrnResponse
    {
        public string Status { get; set; }
        public ProductDetailsByPrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public ProductDetailsByPrnResponseDataTypeItem[] Data { get; set; }
    }

    public class ProductDetailsByPrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class ProductDetailsByPrnResponseDataTypeItem
    {
        [JsonProperty("Sub-funds")]
        public string SubFunds { get; set; }

        [JsonProperty("Other Name")]
        public string OtherName { get; set; }

        [JsonProperty("CIS Depositary")]
        public string CisDepositary { get; set; }

        [JsonProperty("CIS Depositary Name")]
        public string CisDepositaryName { get; set; }

        [JsonProperty("Operator Name")]
        public string OperatorName { get; set; }
        public string Operator { get; set; }

        [JsonProperty("MMF Term Type")]
        public string MmfTermType { get; set; }

        [JsonProperty("MMF NAV Type")]
        public string MmfNavType { get; set; }

        [JsonProperty("Effective Date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("Scheme Type")]
        public string SchemeType { get; set; }

        [JsonProperty("Product Type")]
        public string ProductType { get; set; }

        [JsonProperty("ICVC Registration No")]
        public string IcvcRegistrationNo { get; set; }
        public string Status { get; set; }
    }

    public class SubfundDetailsByPrnResponse
    {
        public string Status { get; set; }
        public SubfundDetailsByPrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public SubfundDetailsByPrnResponseDataTypeItem[] Data { get; set; }
    }

    public class SubfundDetailsByPrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class SubfundDetailsByPrnResponseDataTypeItem
    {
        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("Sub-Fund Type")]
        public string SubFundType { get; set; }
        public string Name { get; set; }
    }

    public class ProductOtherNameDetailsByPrnResponse
    {
        public string Status { get; set; }
        public ProductOtherNameDetailsByPrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public ProductOtherNameDetailsByPrnResponseDataTypeItem[] Data { get; set; }
    }

    public class ProductOtherNameDetailsByPrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class ProductOtherNameDetailsByPrnResponseDataTypeItem
    {
        [JsonProperty("Effective To")]
        public string EffectiveTo { get; set; }

        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }

        [JsonProperty("Product Other Name")]
        public string ProductOtherName { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIrnResponse
    {
        public string Status { get; set; }
        public IndividualDisciplinaryHistoryByIrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public IndividualDisciplinaryHistoryByIrnResponseDataTypeItem[] Data { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class IndividualDisciplinaryHistoryByIrnResponseDataTypeItem
    {
        public string TypeofDescription { get; set; }
        public string TypeofAction { get; set; }
        public string EnforcementType { get; set; }
        public string ActionEffectiveFrom { get; set; }
    }

    public class FirmOtherNamesByFrnResponse
    {
        public string Status { get; set; }
        public FirmOtherNamesByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmOtherNamesByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmOtherNamesByFrnResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmOtherNamesByFrnResponseDataTypeItem
    {
        [JsonProperty("Current Names")]
        public FirmOtherNamesByFrnResponseDataTypeItemCurrentNamesTypeItem[] CurrentNames { get; set; }

        [JsonProperty("Previous Names")]
        public FirmOtherNamesByFrnResponseDataTypeItemPreviousNamesTypeItem[] PreviousNames { get; set; }
    }

    public class FirmOtherNamesByFrnResponseDataTypeItemCurrentNamesTypeItem
    {
        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
    }

    public class FirmOtherNamesByFrnResponseDataTypeItemPreviousNamesTypeItem
    {
        [JsonProperty("Effective To")]
        public string EffectiveTo { get; set; }

        [JsonProperty("Effective From")]
        public string EffectiveFrom { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
    }

    public class FirmAddressByFrnResponse
    {
        public string Status { get; set; }
        public FirmAddressByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmAddressByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmAddressByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmAddressByFrnResponseDataTypeItem
    {
        [JsonProperty("URL")]
        public string Url { get; set; }

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

    public class FirmIndividualsByFrnResponse
    {
        public string Status { get; set; }
        public FirmIndividualsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmIndividualsByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmIndividualsByFrnResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmIndividualsByFrnResponseDataTypeItem
    {
        public string Status { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("IRN")]
        public string Irn { get; set; }
        public string Name { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponse
    {
        public string Status { get; set; }
        public FirmActivitiesAndPermissionsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmActivitiesAndPermissionsByFrnResponseDataType Data { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataType
    {
        [JsonProperty("Acting as a CBTL advisor")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdvisorTypeItem[] ActingAsACbtlAdvisor { get; set; }

        [JsonProperty("Acting as a CBTL administrator")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdministratorTypeItem[] ActingAsACbtlAdministrator { get; set; }

        [JsonProperty("CBTL Status")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeCbtlStatusTypeItem[] CbtlStatus { get; set; }

        [JsonProperty("CBTL Effective Date")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeCbtlEffectiveDateTypeItem[] CbtlEffectiveDate { get; set; }

        [JsonProperty("Entering into Regulated Consumer Hire Agreements as owner")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeEnteringIntoRegulatedConsumerHireAgreementsAsOwnerTypeItem[] EnteringIntoRegulatedConsumerHireAgreementsAsOwner { get; set; }

        [JsonProperty("Agreeing to carry on a regulated activity")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeAgreeingToCarryOnARegulatedActivityTypeItem[] AgreeingToCarryOnARegulatedActivity { get; set; }

        [JsonProperty("Acting as a CBTL Administrator")]
        public FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdministrator2TypeItem[] ActingAsACbtlAdministrator2 { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdvisorTypeItem
    {
        [JsonProperty("Acting as a CBTL advisor")]
        public string[] ActingAsACbtlAdvisor { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdministratorTypeItem
    {
        [JsonProperty("Acting as a CBTL administrator")]
        public string[] ActingAsACbtlAdministrator { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeCbtlStatusTypeItem
    {
        [JsonProperty("CBTL Status")]
        public string[] CbtlStatus { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeCbtlEffectiveDateTypeItem
    {
        [JsonProperty("CBTL Effective Date")]
        public string[] CbtlEffectiveDate { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeEnteringIntoRegulatedConsumerHireAgreementsAsOwnerTypeItem
    {
        public string[] Limitation { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeAgreeingToCarryOnARegulatedActivityTypeItem
    {
        [JsonProperty("Limitation Not Found")]
        public string[] LimitationNotFound { get; set; }
    }

    public class FirmActivitiesAndPermissionsByFrnResponseDataTypeActingAsACbtlAdministrator2TypeItem
    {
        [JsonProperty("Limitation Not Found")]
        public string[] LimitationNotFound { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandReqrefResponse
    {
        public string Status { get; set; }
        public FirmRequirementsInvestmentTypesByFRNandReqrefResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRequirementsInvestmentTypesByFRNandReqrefResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandReqrefResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRequirementsInvestmentTypesByFRNandReqrefResponseDataTypeItem
    {
        [JsonProperty("Investment Type Name")]
        public string InvestmentTypeName { get; set; }
    }

    public class FirmRegulatorsByFrnResponse
    {
        public string Status { get; set; }
        public FirmRegulatorsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRegulatorsByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRegulatorsByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRegulatorsByFrnResponseDataTypeItem
    {
        [JsonProperty("Termination Date")]
        public string TerminationDate { get; set; }

        [JsonProperty("Effective Date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("Regulator Name")]
        public string RegulatorName { get; set; }
    }

    public class FirmPassportByFrnResponse
    {
        public string Status { get; set; }
        public FirmPassportByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmPassportByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmPassportByFrnResponseResultInfoType
    {
        public string Next { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmPassportByFrnResponseDataTypeItem
    {
        public FirmPassportByFrnResponseDataTypeItemPassportsTypeItem[] Passports { get; set; }
    }

    public class FirmPassportByFrnResponseDataTypeItemPassportsTypeItem
    {
        public string PassportDirection { get; set; }
        public string Permissions { get; set; }
        public string Country { get; set; }
    }

    public class FirmExclusionsByFrnResponse
    {
        [JsonProperty(";Status")]
        public string Status { get; set; }
        public FirmExclusionsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmExclusionsByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmExclusionsByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmExclusionsByFrnResponseDataTypeItem
    {
        [JsonProperty("PSD2_Exclusion_Type")]
        public string Psd2ExclusionType { get; set; }

        [JsonProperty("Particular_Exclusion_relied_upon")]
        public string ParticularExclusionReliedUpon { get; set; }

        [JsonProperty("Description_of_services")]
        public string DescriptionOfServices { get; set; }
    }

    public class FirmDisciplinaryHistoryByFrnResponse
    {
        public string Status { get; set; }
        public FirmDisciplinaryHistoryByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmDisciplinaryHistoryByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmDisciplinaryHistoryByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmDisciplinaryHistoryByFrnResponseDataTypeItem
    {
        public string TypeofDescription { get; set; }
        public string TypeofAction { get; set; }
        public string EnforcementType { get; set; }
        public string ActionEffectiveFrom { get; set; }
    }

    public class FirmRequirementsByFrnResponse
    {
        public string Status { get; set; }
        public FirmRequirementsByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmRequirementsByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmRequirementsByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmRequirementsByFrnResponseDataTypeItem
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

    public class FirmWaiverByFrnResponse
    {
        public string Status { get; set; }
        public FirmWaiverByFrnResponseResultInfoType ResultInfo { get; set; }
        public string Message { get; set; }
        public FirmWaiverByFrnResponseDataTypeItem[] Data { get; set; }
    }

    public class FirmWaiverByFrnResponseResultInfoType
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }

    public class FirmWaiverByFrnResponseDataTypeItem
    {
        [JsonProperty("Waivers_Discretions_URL")]
        public string WaiversDiscretionsUrl { get; set; }

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