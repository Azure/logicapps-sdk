//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gsaanalytics
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GsaanalyticsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaanalytics")]
        public IBodyWorkflowAction<Reports[]> GetReportData(Expression<Func<reportNameInput>> reportName, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/reports/{0}/data", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            return new ApiConnectionAction<Reports[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaanalytics")]
        public IBodyWorkflowAction<Reports[]> GetAgencyReportData(Expression<Func<agencyNameInput>> agencyName, Expression<Func<reportNameInput>> reportName, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/agencies/{0}/reports/{1}/data", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(agencyName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            return new ApiConnectionAction<Reports[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaanalytics")]
        public IBodyWorkflowAction<Reports[]> GetDomainReportData(Expression<Func<string>> domain, Expression<Func<reportNameInput>> reportName, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/domain/{0}/reports/{1}/data", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            return new ApiConnectionAction<Reports[]>(callPayload);
        }
    }

    public class GsaanalyticsTriggers([ConnectionName] string connectionId)
    {
    }

    public class Reports
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("report_name")]
        public string ReportName { get; set; }

        [JsonProperty("report_agency")]
        public string ReportAgency { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("active_visitors")]
        public int ActiveVisitors { get; set; }

        [JsonProperty("avg_session_duration")]
        public double AvgSessionDuration { get; set; }

        [JsonProperty("bounce_rate")]
        public double BounceRate { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("event_label")]
        public string EventLabel { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("landing_page")]
        public string LandingPage { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("mobile_device")]
        public string MobileDevice { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("pageviews")]
        public int Pageviews { get; set; }

        [JsonProperty("pageviews_per_session")]
        public int PageviewsPerSession { get; set; }

        [JsonProperty("screen_resolution")]
        public string ScreenResolution { get; set; }

        [JsonProperty("session_default_channel_group")]
        public string SessionDefaultChannelGroup { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("total_events")]
        public int TotalEvents { get; set; }

        [JsonProperty("users")]
        public int Users { get; set; }

        [JsonProperty("visits")]
        public int Visits { get; set; }
    }

    public enum reportNameInput
    {
        [EnumMember(Value = "download")]
        Download,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "second-level-domain")]
        SecondLevelDomain
    }

    public enum agencyNameInput
    {
        [EnumMember(Value = "agency-international-development")]
        AgencyForInternationalDevelopment,
        [EnumMember(Value = "american-battle-monuments-commission")]
        AmericanBattleMonumentsCommission,
        [EnumMember(Value = "commodity-futures-trading-commission")]
        CommodityFuturesTradingCommission,
        [EnumMember(Value = "consumer-financial-protection-bureau")]
        ConsumerFinancialProtectionBureau,
        [EnumMember(Value = "consumer-product-safety-commission")]
        ConsumerProductSafetyCommission,
        [EnumMember(Value = "corporation-national-community-service")]
        CorporationForNationalAndCommunityService,
        [EnumMember(Value = "defense-nuclear-facilities-safety-board")]
        DefenseNuclearFacilitiesSafetyBoard,
        [EnumMember(Value = "agriculture")]
        DepartmentOfAgriculture,
        [EnumMember(Value = "commerce")]
        DepartmentOfCommerce,
        [EnumMember(Value = "defense")]
        DepartmentOfDefense,
        [EnumMember(Value = "education")]
        DepartmentOfEducation,
        [EnumMember(Value = "energy")]
        DepartmentOfEnergy,
        [EnumMember(Value = "health-human-services")]
        DepartmentOfHealthAndHumanServices,
        [EnumMember(Value = "homeland-security")]
        DepartmentOfHomelandSecurity,
        [EnumMember(Value = "housing-urban-development")]
        DepartmentOfHousingAndUrbanDevelopment,
        [EnumMember(Value = "interior")]
        DepartmentOfTheInterior,
        [EnumMember(Value = "justice")]
        DepartmentOfJustice,
        [EnumMember(Value = "labor")]
        DepartmentOfLabor,
        [EnumMember(Value = "state")]
        DepartmentOfState,
        [EnumMember(Value = "transportation")]
        DepartmentOfTransportation,
        [EnumMember(Value = "treasury")]
        DepartmentOfTheTreasury,
        [EnumMember(Value = "veterans-affairs")]
        DepartmentOfVeteransAffairs,
        [EnumMember(Value = "environmental-protection-agency")]
        EnvironmentalProtectionAgency,
        [EnumMember(Value = "equal-employment-opportunity-commission")]
        EqualEmploymentOpportunityCommission,
        [EnumMember(Value = "executive-office-president")]
        ExecutiveOfficeOfThePresident,
        [EnumMember(Value = "farm-credit-administration")]
        FarmCreditAdministration,
        [EnumMember(Value = "federal-deposit-insurance-corporation")]
        FederalDepositInsuranceCorporation,
        [EnumMember(Value = "federal-election-commission")]
        FederalElectionCommission,
        [EnumMember(Value = "federal-energy-regulatory-commission")]
        FederalEnergyRegulatoryCommission,
        [EnumMember(Value = "federal-housing-finance-agency")]
        FederalHousingFinanceAgency,
        [EnumMember(Value = "federal-maritime-commission")]
        FederalMaritimeCommission,
        [EnumMember(Value = "federal-mine-safety-health-review-commission")]
        FederalMineSafetyAndHealthReviewCommission,
        [EnumMember(Value = "federal-retirement-thrift-investment-board")]
        FederalRetirementThriftInvestmentBoard,
        [EnumMember(Value = "federal-trade-commission")]
        FederalTradeCommission,
        [EnumMember(Value = "general-services-administration")]
        GeneralServicesAdministration,
        [EnumMember(Value = "institute-museum-library-services")]
        InstituteOfMuseumAndLibraryServices,
        [EnumMember(Value = "inter-american-foundation")]
        InterAmericanFoundation,
        [EnumMember(Value = "international-development-finance-corporation")]
        InternationalDevelopmentFinanceCorporation,
        [EnumMember(Value = "merit-systems-protection-board")]
        MeritSystemsProtectionBoard,
        [EnumMember(Value = "millennium-challenge-corporation")]
        MillenniumChallengeCorporation,
        [EnumMember(Value = "national-aeronautics-space-administration")]
        NationalAeronauticsAndSpaceAdministration,
        [EnumMember(Value = "national-archives-records-administration")]
        NationalArchivesAndRecordsAdministration,
        [EnumMember(Value = "national-capital-planning-commission")]
        NationalCapitalPlanningCommission,
        [EnumMember(Value = "national-council-disability")]
        NationalCouncilOnDisability,
        [EnumMember(Value = "national-credit-union-administration")]
        NationalCreditUnionAdministration,
        [EnumMember(Value = "national-education-association")]
        NationalEducationAssociation,
        [EnumMember(Value = "national-endowment-humanities")]
        NationalEndowmentForTheHumanities,
        [EnumMember(Value = "national-labor-relations-board")]
        NationalLaborRelationsBoard,
        [EnumMember(Value = "national-mediation-board")]
        NationalMediationBoard,
        [EnumMember(Value = "national-reconnaissance-office")]
        NationalReconnaissanceOffice,
        [EnumMember(Value = "national-science-foundation")]
        NationalScienceFoundation,
        [EnumMember(Value = "national-transportation-safety-board")]
        NationalTransportationSafetyBoard,
        [EnumMember(Value = "nuclear-regulatory-commission")]
        NuclearRegulatoryCommission,
        [EnumMember(Value = "nuclear-waste-technical-review-board")]
        NuclearWasteTechnicalReviewBoard,
        [EnumMember(Value = "office-director-national-intelligence")]
        OfficeOfTheDirectorOfNationalIntelligence,
        [EnumMember(Value = "office-government-ethics")]
        OfficeOfGovernmentEthics,
        [EnumMember(Value = "office-navajo-hopi-indian-relocation")]
        OfficeOfNavajoAndHopiIndianRelocation,
        [EnumMember(Value = "office-personnel-management")]
        OfficeOfPersonnelManagement,
        [EnumMember(Value = "peace-corps")]
        PeaceCorps,
        [EnumMember(Value = "pension-benefit-guaranty-corporation")]
        PensionBenefitGuarantyCorporation,
        [EnumMember(Value = "postal-regulatory-commission")]
        PostalRegulatoryCommission,
        [EnumMember(Value = "privacy-civil-liberties-oversight-board")]
        PrivacyAndCivilLibertiesOversightBoard,
        [EnumMember(Value = "public-buildings-reform-board")]
        PublicBuildingsReformBoard,
        [EnumMember(Value = "securities-exchange-commission")]
        SecuritiesAndExchangeCommission,
        [EnumMember(Value = "small-business-administration")]
        SmallBusinessAdministration,
        [EnumMember(Value = "social-security-administration")]
        SocialSecurityAdministration,
        [EnumMember(Value = "special-inspector-general-afghanistan-restoration")]
        SpecialInspectorGeneralForAfghanistanReconstruction,
        [EnumMember(Value = "surface-transportation-board")]
        SurfaceTransportationBoard,
        [EnumMember(Value = "udall-foundation")]
        UdallFoundation,
        [EnumMember(Value = "access-board")]
        USAccessBoard,
        [EnumMember(Value = "agency-global-media")]
        USAgencyForGlobalMedia,
        [EnumMember(Value = "commission-civil-rights")]
        USCommissionOnCivilRights,
        [EnumMember(Value = "international-trade-commission")]
        USInternationalTradeCommission,
        [EnumMember(Value = "postal-inspection-service")]
        USPostalInspectionService,
        [EnumMember(Value = "postal-service")]
        USPostalService,
        [EnumMember(Value = "railroad-retirement-board")]
        USRailroadRetirementBoard,
        [EnumMember(Value = "trade-development-agency")]
        USTradeAndDevelopmentAgency
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gsaanalytics;

    public partial class WorkflowManagedActions
    {
        public GsaanalyticsActions Gsaanalytics(string connectionId) => new GsaanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GsaanalyticsTriggers Gsaanalytics(string connectionId) => new GsaanalyticsTriggers(connectionId);
    }
}