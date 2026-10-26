//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LsegfinancialanalytiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<CreateJobResponse, ApiConnectionActionConfiguration> CreateJob(Expression<Func<CreateJobInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/create-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<JobStatusResponse, ApiConnectionActionConfiguration> JobStatus(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<JobStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/job-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction<JobStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkPyAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<BulkPyAnalyticsInput>> body = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkIndicData(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<BulkIndicDataInput>> body = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse, ApiConnectionActionConfiguration> UploadSecuritiesList(Expression<Func<string>> jobName, Expression<Func<UploadSecuritiesListInput>> body = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadSecuritiesListDefaultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/upload-securities-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadSecuritiesListDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<CreateUdisResponse, ApiConnectionActionConfiguration> CreateUdis(Expression<Func<string>> jobName, Expression<Func<CreateUdisInput>> body)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUdisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/create-udis";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUdisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseJob(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/close-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse, ApiConnectionActionConfiguration> RetrieveBulkResults(Expression<Func<string>> jobName, Expression<Func<outputFormatInput>> outputFormat, Expression<Func<RetrieveBulkResultsInput>> body = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_outputFormat = WorkflowExpression.Compile(outputFormat, nameof(outputFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RetrieveBulkResultsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Output format"] = ExpressionConverter.Convert(__workflow_outputFormat);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RetrieveBulkResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<IndicDataResponse, ApiConnectionActionConfiguration> IndicData(Expression<Func<IndicDataInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IndicDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IndicDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<PyAnalyticResponse, ApiConnectionActionConfiguration> PyAnalytics(Expression<Func<PyAnalyticsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PyAnalyticResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PyAnalyticResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkScenarioAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<BulkScenarioAnalyticsV3Input>> body = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v3/bulk-scenario-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LsegfinancialanalytiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateJobResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class CreateJobInput
    {
        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class JobStatusResponse
    {
        [JsonProperty("exitStatus")]
        public string ExitStatus { get; set; }

        [JsonProperty("onHold")]
        public bool OnHold { get; set; }
    }

    public class BulkPyAnalyticsInput
    {
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestId { get; set; }

        [JsonProperty("curveType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkPyAnalyticsInputCurveTypeType CurveType { get; set; } = BulkPyAnalyticsInputCurveTypeType.TreasuryModelCurve;

        [JsonProperty("currency")]
        public BulkPyAnalyticsInputCurrencyType? Currency { get; set; }

        [JsonProperty("pricingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PricingDate { get; set; } = "Previous Close";

        [JsonProperty("settlementType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SettlementType { get; set; } = "Market";

        [JsonProperty("prepayType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkPyAnalyticsInputPrepayTypeType PrepayType { get; set; } = BulkPyAnalyticsInputPrepayTypeType.Default;

        [JsonProperty("prepayRate")]
        public int? PrepayRate { get; set; }

        [JsonProperty("calculatePartialDurations4pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations4pt { get; set; } = false;

        [JsonProperty("calculatePartialDurations7pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations7pt { get; set; } = false;

        [JsonProperty("retrieveModelProjections", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RetrieveModelProjections { get; set; } = false;

        [JsonProperty("retrieveOas")]
        public bool? RetrieveOas { get; set; }

        [JsonProperty("optionModel")]
        public BulkPyAnalyticsInputOptionModelType? OptionModel { get; set; }

        [JsonProperty("volatilityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkPyAnalyticsInputVolatilityTypeType? VolatilityType { get; set; } = BulkPyAnalyticsInputVolatilityTypeType.Default;

        [JsonProperty("prepayDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrepayDuration { get; set; } = false;

        [JsonProperty("volatilityDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VolatilityDuration { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkPyAnalyticsInputCurveTypeType
    {
        [EnumMember(Value = "On The Run Curve")]
        OnTheRunCurve,
        [EnumMember(Value = "Treasury Model Curve")]
        TreasuryModelCurve,
        [EnumMember(Value = "Swap Curve")]
        SwapCurve,
        [EnumMember(Value = "Swap RFR Curve")]
        SwapRFRCurve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkPyAnalyticsInputCurrencyType
    {
        USD,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkPyAnalyticsInputPrepayTypeType
    {
        Default,
        Model,
        CPR,
        PSA,
        PreExpModel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkPyAnalyticsInputOptionModelType
    {
        OAS,
        OASEDUR,
        YCMARGIN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkPyAnalyticsInputVolatilityTypeType
    {
        MarketWSkew,
        LMMSOFR,
        LMMSOFRFLAT,
        Default
    }

    public class BulkIndicDataInput
    {
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestId { get; set; }
    }

    public class UploadSecuritiesListDefaultResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public class UploadSecuritiesListInput
    {
        [JsonProperty("securitiesList", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecuritiesList { get; set; }

        [JsonProperty("udiIdentifiers")]
        public string UdiIdentifiers { get; set; }
    }

    public class CreateUdisResponse
    {
        [JsonProperty("udiIdentifiers")]
        public string UdiIdentifiers { get; set; }
    }

    public class CreateUdisInput
    {
        [JsonProperty("userInstruments", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserInstruments { get; set; }
    }

    public class RetrieveBulkResultsResponse
    {
        [JsonProperty("results")]
        public string Results { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum outputFormatInput
    {
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "json")]
        Json
    }

    public class RetrieveBulkResultsInput
    {
        [JsonProperty("payload", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Payload { get; set; }
    }

    public class IndicDataResponse
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("cfi")]
        public string Cfi { get; set; }

        [JsonProperty("ric")]
        public string Ric { get; set; }

        [JsonProperty("wkn")]
        public string Wkn { get; set; }

        [JsonProperty("figi")]
        public string Figi { get; set; }

        [JsonProperty("frtbSector")]
        public string FrtbSector { get; set; }

        [JsonProperty("frtbRiskWeight")]
        public double FrtbRiskWeight { get; set; }

        [JsonProperty("frtbBucketNumber")]
        public int FrtbBucketNumber { get; set; }

        [JsonProperty("frtbCreditQuality")]
        public string FrtbCreditQuality { get; set; }

        [JsonProperty("frtbRiskClassification")]
        public string FrtbRiskClassification { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("moody")]
        public MoodyRating[] Moody { get; set; }

        [JsonProperty("permId")]
        public string PermId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("putFlag")]
        public bool PutFlag { get; set; }

        [JsonProperty("callFlag")]
        public bool CallFlag { get; set; }

        [JsonProperty("cobsCode")]
        public string CobsCode { get; set; }

        [JsonProperty("country2")]
        public string Country2 { get; set; }

        [JsonProperty("country3")]
        public string Country3 { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dayCount")]
        public string DayCount { get; set; }

        [JsonProperty("glicCode")]
        public string GlicCode { get; set; }

        [JsonProperty("regSFlag")]
        public bool RegSFlag { get; set; }

        [JsonProperty("sinkFlag")]
        public bool SinkFlag { get; set; }

        [JsonProperty("callDelay")]
        public int CallDelay { get; set; }

        [JsonProperty("cmaTicker")]
        public string CmaTicker { get; set; }

        [JsonProperty("datedDate")]
        public string DatedDate { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("p144AFlag")]
        public bool P144AFlag { get; set; }

        [JsonProperty("extendFlag")]
        public string ExtendFlag { get; set; }

        [JsonProperty("isoCountry")]
        public string IsoCountry { get; set; }

        [JsonProperty("issuePrice")]
        public double IssuePrice { get; set; }

        [JsonProperty("issueYield")]
        public double IssueYield { get; set; }

        [JsonProperty("issuerName")]
        public string IssuerName { get; set; }

        [JsonProperty("issuerNameLanguage")]
        public string IssuerNameLanguage { get; set; }

        [JsonProperty("marketType")]
        public string MarketType { get; set; }

        [JsonProperty("securityId")]
        public string SecurityId { get; set; }

        [JsonProperty("vPointType")]
        public string VPointType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("esgBondFlag")]
        public bool EsgBondFlag { get; set; }

        [JsonProperty("indexRating")]
        public string IndexRating { get; set; }

        [JsonProperty("issueAmount")]
        public double IssueAmount { get; set; }

        [JsonProperty("issueSpread")]
        public double IssueSpread { get; set; }

        [JsonProperty("lowerRating")]
        public string LowerRating { get; set; }

        [JsonProperty("paymentFreq")]
        public int PaymentFreq { get; set; }

        [JsonProperty("securedFlag")]
        public bool SecuredFlag { get; set; }

        [JsonProperty("tierCapital")]
        public string TierCapital { get; set; }

        [JsonProperty("deliveryFlag")]
        public string DeliveryFlag { get; set; }

        [JsonProperty("euroCallFlag")]
        public bool EuroCallFlag { get; set; }

        [JsonProperty("indexCountry")]
        public string IndexCountry { get; set; }

        [JsonProperty("industryCode")]
        public string IndustryCode { get; set; }

        [JsonProperty("issuerTicker")]
        public string IssuerTicker { get; set; }

        [JsonProperty("lowestRating")]
        public string LowestRating { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("middleRating")]
        public string MiddleRating { get; set; }

        [JsonProperty("minimumPiece")]
        public double MinimumPiece { get; set; }

        [JsonProperty("nextCallDate")]
        public string NextCallDate { get; set; }

        [JsonProperty("parentTicker")]
        public string ParentTicker { get; set; }

        [JsonProperty("securityType")]
        public string SecurityType { get; set; }

        [JsonProperty("chapter11Flag")]
        public bool Chapter11Flag { get; set; }

        [JsonProperty("currentCoupon")]
        public double CurrentCoupon { get; set; }

        [JsonProperty("debtClassCode")]
        public string DebtClassCode { get; set; }

        [JsonProperty("greenBondFlag")]
        public bool GreenBondFlag { get; set; }

        [JsonProperty("highestRating")]
        public string HighestRating { get; set; }

        [JsonProperty("inDefaultFlag")]
        public bool InDefaultFlag { get; set; }

        [JsonProperty("incomeCountry")]
        public string IncomeCountry { get; set; }

        [JsonProperty("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonProperty("makeWholeFlag")]
        public bool MakeWholeFlag { get; set; }

        [JsonProperty("nextCallPrice")]
        public double NextCallPrice { get; set; }

        [JsonProperty("seniorityType")]
        public string SeniorityType { get; set; }

        [JsonProperty("assetClassCode")]
        public string AssetClassCode { get; set; }

        [JsonProperty("cgmiSectorCode")]
        public string CgmiSectorCode { get; set; }

        [JsonProperty("incomeCountry3")]
        public string IncomeCountry3 { get; set; }

        [JsonProperty("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonProperty("issueBenchmark")]
        public double IssueBenchmark { get; set; }

        [JsonProperty("issuerCountry2")]
        public string IssuerCountry2 { get; set; }

        [JsonProperty("issuerCountry3")]
        public string IssuerCountry3 { get; set; }

        [JsonProperty("lowestRatingNf")]
        public string LowestRatingNf { get; set; }

        [JsonProperty("risingStarFlag")]
        public bool RisingStarFlag { get; set; }

        [JsonProperty("vPointCategory")]
        public string VPointCategory { get; set; }

        [JsonProperty("bloombergTicker")]
        public string BloombergTicker { get; set; }

        [JsonProperty("fallenAngelFlag")]
        public bool FallenAngelFlag { get; set; }

        [JsonProperty("firstCouponDate")]
        public string FirstCouponDate { get; set; }

        [JsonProperty("industrySubCode")]
        public string IndustrySubCode { get; set; }

        [JsonProperty("outstandingDate")]
        public string OutstandingDate { get; set; }

        [JsonProperty("redemptionValue")]
        public double RedemptionValue { get; set; }

        [JsonProperty("restrictionDate")]
        public string RestrictionDate { get; set; }

        [JsonProperty("securitySubType")]
        public string SecuritySubType { get; set; }

        [JsonProperty("tradeConvention")]
        public string TradeConvention { get; set; }

        [JsonProperty("securityCalcType")]
        public string SecurityCalcType { get; set; }

        [JsonProperty("assetClassSubCode")]
        public string AssetClassSubCode { get; set; }

        [JsonProperty("esgEnvScore")]
        public double EsgEnvScore { get; set; }

        [JsonProperty("esgGovScore")]
        public double EsgGovScore { get; set; }

        [JsonProperty("esgSocScore")]
        public double EsgSocScore { get; set; }

        [JsonProperty("esgGlobalScore")]
        public double EsgGlobalScore { get; set; }

        [JsonProperty("esgCommunityScore")]
        public double EsgCommunityScore { get; set; }

        [JsonProperty("esgEmissionsScore")]
        public double EsgEmissionsScore { get; set; }

        [JsonProperty("esgWorkforceScore")]
        public double EsgWorkforceScore { get; set; }

        [JsonProperty("esgInnovationScore")]
        public double EsgInnovationScore { get; set; }

        [JsonProperty("esgManagementScore")]
        public double EsgManagementScore { get; set; }

        [JsonProperty("esgCsrStrategyScore")]
        public double EsgCsrStrategyScore { get; set; }

        [JsonProperty("esgHumanRightsScore")]
        public double EsgHumanRightsScore { get; set; }

        [JsonProperty("esgResourceUseScore")]
        public double EsgResourceUseScore { get; set; }

        [JsonProperty("esgShareholdersScore")]
        public double EsgShareholdersScore { get; set; }

        [JsonProperty("esgProductResponsibilityScore")]
        public double EsgProductResponsibilityScore { get; set; }

        [JsonProperty("finalMaturityDate")]
        public string FinalMaturityDate { get; set; }

        [JsonProperty("modifiedTimeStamp")]
        public string ModifiedTimeStamp { get; set; }

        [JsonProperty("outstandingAmount")]
        public double OutstandingAmount { get; set; }

        [JsonProperty("parentDescription")]
        public string ParentDescription { get; set; }

        [JsonProperty("issuerLowestRating")]
        public string IssuerLowestRating { get; set; }

        [JsonProperty("issuerMiddleRating")]
        public string IssuerMiddleRating { get; set; }

        [JsonProperty("dataUnderwriterList")]
        public UnderwriterItem[] DataUnderwriterList { get; set; }

        [JsonProperty("industryDescription")]
        public string IndustryDescription { get; set; }

        [JsonProperty("issuerHighestRating")]
        public string IssuerHighestRating { get; set; }

        [JsonProperty("leveragedBuyoutFlag")]
        public bool LeveragedBuyoutFlag { get; set; }

        [JsonProperty("clearingOrganization")]
        public string ClearingOrganization { get; set; }

        [JsonProperty("currentHighYieldFlag")]
        public bool CurrentHighYieldFlag { get; set; }

        [JsonProperty("dataCallScheduleList")]
        public CallScheduleItem[] DataCallScheduleList { get; set; }

        [JsonProperty("debtClassDescription")]
        public string DebtClassDescription { get; set; }

        [JsonProperty("privatePlacementFlag")]
        public bool PrivatePlacementFlag { get; set; }

        [JsonProperty("cgmiSectorDescription")]
        public string CgmiSectorDescription { get; set; }

        [JsonProperty("originalHighYieldFlag")]
        public bool OriginalHighYieldFlag { get; set; }

        [JsonProperty("americanEuropeanOption")]
        public string AmericanEuropeanOption { get; set; }

        [JsonProperty("defaultHorizonPyMethod")]
        public string DefaultHorizonPyMethod { get; set; }

        [JsonProperty("industrySubDescription")]
        public string IndustrySubDescription { get; set; }

        [JsonProperty("assetClassSubDescription")]
        public string AssetClassSubDescription { get; set; }
    }

    public class MoodyRating
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class UnderwriterItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("split")]
        public double Split { get; set; }
    }

    public class CallScheduleItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public class IndicDataInput
    {
        [JsonProperty("identifier", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identifier { get; set; }

        [JsonProperty("idType")]
        public IndicDataInputIdTypeType? IdType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IndicDataInputIdTypeType
    {
        [EnumMember(Value = "SecurityIDEntry")]
        SecurityIdEntry,
        [EnumMember(Value = "SecurityID")]
        SecurityId,
        CUSIP,
        ISIN,
        REGSISIN,
        SEDOL,
        Identifier,
        ChinaInterbankCode,
        ShanghaiExchangeCode,
        ShenzhenExchangeCode,
        [EnumMember(Value = "MXTickerID")]
        MXTickerId
    }

    public class PyAnalyticResponse
    {
        [JsonProperty("oas")]
        public double Oas { get; set; }

        [JsonProperty("wal")]
        public double Wal { get; set; }

        [JsonProperty("dv01")]
        public double Dv01 { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("yield")]
        public double Yield { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("cdYield")]
        public double CdYield { get; set; }

        [JsonProperty("cmmType")]
        public int CmmType { get; set; }

        [JsonProperty("pyLevel")]
        public string PyLevel { get; set; }

        [JsonProperty("zSpread")]
        public double ZSpread { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("ziSpread")]
        public double ZiSpread { get; set; }

        [JsonProperty("znSpread")]
        public double ZnSpread { get; set; }

        [JsonProperty("benchmark")]
        public string Benchmark { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("convexity")]
        public double Convexity { get; set; }

        [JsonProperty("curveDate")]
        public string CurveDate { get; set; }

        [JsonProperty("curveType")]
        public string CurveType { get; set; }

        [JsonProperty("fullPrice")]
        public double FullPrice { get; set; }

        [JsonProperty("modelCode")]
        public int ModelCode { get; set; }

        [JsonProperty("creditLoss")]
        public double CreditLoss { get; set; }

        [JsonProperty("prepayRate")]
        public double PrepayRate { get; set; }

        [JsonProperty("prepayType")]
        public string PrepayType { get; set; }

        [JsonProperty("securityID")]
        public string SecurityId { get; set; }

        [JsonProperty("spreadDV01")]
        public double SpreadDV01 { get; set; }

        [JsonProperty("tsyCurveID")]
        public string TsyCurveId { get; set; }

        [JsonProperty("accruedDays")]
        public int AccruedDays { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("grossSpread")]
        public double GrossSpread { get; set; }

        [JsonProperty("pricingDate")]
        public string PricingDate { get; set; }

        [JsonProperty("swapCurveID")]
        public string SwapCurveId { get; set; }

        [JsonProperty("currentYield")]
        public double CurrentYield { get; set; }

        [JsonProperty("effectiveWAL")]
        public double EffectiveWAL { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("nextCallDate")]
        public string NextCallDate { get; set; }

        [JsonProperty("securityType")]
        public string SecurityType { get; set; }

        [JsonProperty("staticSpread")]
        public double StaticSpread { get; set; }

        [JsonProperty("volModelType")]
        public string VolModelType { get; set; }

        [JsonProperty("yieldToWorst")]
        public double YieldToWorst { get; set; }

        [JsonProperty("convexityCost")]
        public double ConvexityCost { get; set; }

        [JsonProperty("currentCoupon")]
        public double CurrentCoupon { get; set; }

        [JsonProperty("effectiveCV01")]
        public double EffectiveCV01 { get; set; }

        [JsonProperty("effectiveDV01")]
        public double EffectiveDV01 { get; set; }

        [JsonProperty("cmoProcessTime")]
        public int CmoProcessTime { get; set; }

        [JsonProperty("effectiveYield")]
        public double EffectiveYield { get; set; }

        [JsonProperty("marketSettings")]
        public MarketSettings MarketSettings { get; set; }

        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }

        [JsonProperty("spreadDuration")]
        public double SpreadDuration { get; set; }

        [JsonProperty("accruedInterest")]
        public double AccruedInterest { get; set; }

        [JsonProperty("annualizedYield")]
        public double AnnualizedYield { get; set; }

        [JsonProperty("compoundingFreq")]
        public int CompoundingFreq { get; set; }

        [JsonProperty("convexityEffect")]
        public double ConvexityEffect { get; set; }

        [JsonProperty("dataPpmProjList")]
        public DataPpmProjList[] DataPpmProjList { get; set; }

        [JsonProperty("forwardMeasures")]
        public ForwardMeasures ForwardMeasures { get; set; }

        [JsonProperty("nextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [JsonProperty("spreadConvexity")]
        public double SpreadConvexity { get; set; }

        [JsonProperty("yearsToMaturity")]
        public double YearsToMaturity { get; set; }

        [JsonProperty("yieldToNextCall")]
        public double YieldToNextCall { get; set; }

        [JsonProperty("economicExposure")]
        public double EconomicExposure { get; set; }

        [JsonProperty("macaulayDuration")]
        public double MacaulayDuration { get; set; }

        [JsonProperty("settleDateFactor")]
        public double SettleDateFactor { get; set; }

        [JsonProperty("spreadToActCurve")]
        public double SpreadToActCurve { get; set; }

        [JsonProperty("spreadToTsyCurve")]
        public double SpreadToTsyCurve { get; set; }

        [JsonProperty("yieldCurveMargin")]
        public double YieldCurveMargin { get; set; }

        [JsonProperty("yieldToWorstCall")]
        public double YieldToWorstCall { get; set; }

        [JsonProperty("effectiveDuration")]
        public double EffectiveDuration { get; set; }

        [JsonProperty("macaulayConvexity")]
        public double MacaulayConvexity { get; set; }

        [JsonProperty("spreadToBenchmark")]
        public double SpreadToBenchmark { get; set; }

        [JsonProperty("spreadToSwapCurve")]
        public double SpreadToSwapCurve { get; set; }

        [JsonProperty("spreadToWorstCall")]
        public double SpreadToWorstCall { get; set; }

        [JsonProperty("currentAccrualDate")]
        public string CurrentAccrualDate { get; set; }

        [JsonProperty("effectiveConvexity")]
        public double EffectiveConvexity { get; set; }

        [JsonProperty("moatsCurrentCoupon")]
        public double MoatsCurrentCoupon { get; set; }

        [JsonProperty("optionModelCurveID")]
        public string OptionModelCurveId { get; set; }

        [JsonProperty("yieldCurveDuration")]
        public double YieldCurveDuration { get; set; }

        [JsonProperty("benchmarkToNextCall")]
        public string BenchmarkToNextCall { get; set; }

        [JsonProperty("durationToWorstCase")]
        public double DurationToWorstCase { get; set; }

        [JsonProperty("semiAnnualizedYield")]
        public double SemiAnnualizedYield { get; set; }

        [JsonProperty("spreadToRFRSwapCurve")]
        public double SpreadToRFRSwapCurve { get; set; }

        [JsonProperty("yearsToFinalMaturity")]
        public double YearsToFinalMaturity { get; set; }

        [JsonProperty("spreadDurationTreasury")]
        public double SpreadDurationTreasury { get; set; }

        [JsonProperty("dataPartialDurationList")]
        public DataPartialDurationList[] DataPartialDurationList { get; set; }

        [JsonProperty("fundedEffectiveDuration")]
        public double FundedEffectiveDuration { get; set; }

        [JsonProperty("effectiveDurationPriceUp")]
        public double EffectiveDurationPriceUp { get; set; }

        [JsonProperty("fundedEffectiveConvexity")]
        public double FundedEffectiveConvexity { get; set; }

        [JsonProperty("lastPrincipalPaymentDate")]
        public string LastPrincipalPaymentDate { get; set; }

        [JsonProperty("firstPrincipalPaymentDate")]
        public string FirstPrincipalPaymentDate { get; set; }

        [JsonProperty("effectiveDurationPriceDown")]
        public double EffectiveDurationPriceDown { get; set; }

        [JsonProperty("spreadToActCurveToNextCall")]
        public double SpreadToActCurveToNextCall { get; set; }

        [JsonProperty("spreadToTsyCurveToNextCall")]
        public double SpreadToTsyCurveToNextCall { get; set; }

        [JsonProperty("spreadToBenchmarkToNextCall")]
        public double SpreadToBenchmarkToNextCall { get; set; }

        [JsonProperty("spreadToSwapCurveToNextCall")]
        public double SpreadToSwapCurveToNextCall { get; set; }

        [JsonProperty("principalWritedownCreditLoss")]
        public double PrincipalWritedownCreditLoss { get; set; }

        [JsonProperty("cumulativeLossToNextCallCurrent")]
        public double CumulativeLossToNextCallCurrent { get; set; }

        [JsonProperty("cumulativeLossToNextCallOriginal")]
        public double CumulativeLossToNextCallOriginal { get; set; }

        [JsonProperty("cumulativeDefaultToNextCallCurrent")]
        public double CumulativeDefaultToNextCallCurrent { get; set; }

        [JsonProperty("cumulativeDefaultToNextCallOriginal")]
        public double CumulativeDefaultToNextCallOriginal { get; set; }

        [JsonProperty("spreadToTsyCurveAtBenchmarkTenor")]
        public double SpreadToTsyCurveAtBenchmarkTenor { get; set; }

        [JsonProperty("spreadToBenchmarkToWorstCall")]
        public double SpreadToBenchmarkToWorstCall { get; set; }

        [JsonProperty("spreadToActCurveToWorstCall")]
        public double SpreadToActCurveToWorstCall { get; set; }

        [JsonProperty("currentCouponSpreadConvexity")]
        public double CurrentCouponSpreadConvexity { get; set; }

        [JsonProperty("currentCouponSpreadSensitivity")]
        public double CurrentCouponSpreadSensitivity { get; set; }
    }

    public class MarketSettings
    {
        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }
    }

    public class DataPpmProjList
    {
        [JsonProperty("oneYear")]
        public double OneYear { get; set; }

        [JsonProperty("longTerm")]
        public double LongTerm { get; set; }

        [JsonProperty("oneMonth")]
        public double OneMonth { get; set; }

        [JsonProperty("sixMonth")]
        public double SixMonth { get; set; }

        [JsonProperty("prepayType")]
        public string PrepayType { get; set; }

        [JsonProperty("threeMonth")]
        public double ThreeMonth { get; set; }
    }

    public class ForwardMeasures
    {
        [JsonProperty("wal")]
        public double Wal { get; set; }

        [JsonProperty("yield")]
        public double Yield { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("cumulativeLoss")]
        public double CumulativeLoss { get; set; }

        [JsonProperty("cumulativeDefaults")]
        public double CumulativeDefaults { get; set; }
    }

    public class DataPartialDurationList
    {
        [JsonProperty("partialDV01")]
        public double PartialDV01 { get; set; }

        [JsonProperty("partialDuration")]
        public double PartialDuration { get; set; }

        [JsonProperty("partialDurationYear")]
        public double PartialDurationYear { get; set; }

        [JsonProperty("partialDurationPriceUp")]
        public double PartialDurationPriceUp { get; set; }

        [JsonProperty("partialDurationPriceDown")]
        public double PartialDurationPriceDown { get; set; }
    }

    public class PyAnalyticsInput
    {
        [JsonProperty("identifier", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identifier { get; set; }

        [JsonProperty("idType")]
        public PyAnalyticsInputIdTypeType? IdType { get; set; }

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Level { get; set; }

        [JsonProperty("retrieveOas")]
        public bool? RetrieveOas { get; set; }

        [JsonProperty("optionModel")]
        public PyAnalyticsInputOptionModelType? OptionModel { get; set; }

        [JsonProperty("curveType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PyAnalyticsInputCurveTypeType CurveType { get; set; } = PyAnalyticsInputCurveTypeType.TreasuryModelCurve;

        [JsonProperty("currency")]
        public PyAnalyticsInputCurrencyType? Currency { get; set; }

        [JsonProperty("pricingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PricingDate { get; set; } = "Previous Close";

        [JsonProperty("settlementType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SettlementType { get; set; } = "Market";

        [JsonProperty("prepayType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PyAnalyticsInputPrepayTypeType PrepayType { get; set; } = PyAnalyticsInputPrepayTypeType.Default;

        [JsonProperty("prepayRate")]
        public int? PrepayRate { get; set; }

        [JsonProperty("calculatePartialDurations4pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations4pt { get; set; } = false;

        [JsonProperty("calculatePartialDurations7pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations7pt { get; set; } = false;

        [JsonProperty("retrieveModelProjections", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RetrieveModelProjections { get; set; } = false;

        [JsonProperty("volatilityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PyAnalyticsInputVolatilityTypeType VolatilityType { get; set; } = PyAnalyticsInputVolatilityTypeType.Default;

        [JsonProperty("prepayDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrepayDuration { get; set; } = false;

        [JsonProperty("volatilityDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VolatilityDuration { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputIdTypeType
    {
        [EnumMember(Value = "SecurityIDEntry")]
        SecurityIdEntry,
        [EnumMember(Value = "SecurityID")]
        SecurityId,
        CUSIP,
        ISIN,
        REGSISIN,
        SEDOL,
        Identifier,
        ChinaInterbankCode,
        ShanghaiExchangeCode,
        ShenzhenExchangeCode,
        [EnumMember(Value = "MXTickerID")]
        MXTickerId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputOptionModelType
    {
        OAS,
        OASEDUR,
        YCMARGIN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputCurveTypeType
    {
        [EnumMember(Value = "On The Run Curve")]
        OnTheRunCurve,
        [EnumMember(Value = "Treasury Model Curve")]
        TreasuryModelCurve,
        [EnumMember(Value = "Swap Curve")]
        SwapCurve,
        [EnumMember(Value = "Swap RFR Curve")]
        SwapRFRCurve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputCurrencyType
    {
        USD,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputPrepayTypeType
    {
        Default,
        Model,
        CPR,
        PSA,
        PreExpModel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PyAnalyticsInputVolatilityTypeType
    {
        MarketWSkew,
        LMMSOFR,
        LMMSOFRFLAT,
        Default
    }

    public class BulkScenarioAnalyticsV3Input
    {
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestId { get; set; }

        [JsonProperty("curveType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkScenarioAnalyticsV3InputCurveTypeType CurveType { get; set; } = BulkScenarioAnalyticsV3InputCurveTypeType.TreasuryModelCurve;

        [JsonProperty("currency")]
        public BulkScenarioAnalyticsV3InputCurrencyType? Currency { get; set; }

        [JsonProperty("pricingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PricingDate { get; set; } = "Previous Close";

        [JsonProperty("settlementType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SettlementType { get; set; } = "Market";

        [JsonProperty("prepayType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkScenarioAnalyticsV3InputPrepayTypeType PrepayType { get; set; } = BulkScenarioAnalyticsV3InputPrepayTypeType.Default;

        [JsonProperty("prepayRate")]
        public int? PrepayRate { get; set; }

        [JsonProperty("calculatePartialDurations4pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations4pt { get; set; } = false;

        [JsonProperty("calculatePartialDurations7pt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculatePartialDurations7pt { get; set; } = false;

        [JsonProperty("retrieveModelProjections", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RetrieveModelProjections { get; set; } = false;

        [JsonProperty("volatilityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkScenarioAnalyticsV3InputVolatilityTypeType VolatilityType { get; set; } = BulkScenarioAnalyticsV3InputVolatilityTypeType.Default;

        [JsonProperty("horizonMonths")]
        public int? HorizonMonths { get; set; }

        [JsonProperty("horizonDays")]
        public int? HorizonDays { get; set; }

        [JsonProperty("calculateHorizonEffectiveMeasures", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CalculateHorizonEffectiveMeasures { get; set; } = false;

        [JsonProperty("calculateHorizonOptionMeasures", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CalculateHorizonOptionMeasures { get; set; } = false;

        [JsonProperty("useForwardIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseForwardIndex { get; set; } = false;

        [JsonProperty("immediateForwardShift", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ImmediateForwardShift { get; set; } = false;

        [JsonProperty("scenarioCashflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScenarioCashflow { get; set; } = false;

        [JsonProperty("calcPrepaySensitivity", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CalcPrepaySensitivity { get; set; } = false;

        [JsonProperty("horizonPYMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public BulkScenarioAnalyticsV3InputHorizonPYMethodType HorizonPYMethod { get; set; } = BulkScenarioAnalyticsV3InputHorizonPYMethodType.Default;
        public ScenarioV3[] Scenarios { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkScenarioAnalyticsV3InputCurveTypeType
    {
        [EnumMember(Value = "On The Run Curve")]
        OnTheRunCurve,
        [EnumMember(Value = "Treasury Model Curve")]
        TreasuryModelCurve,
        [EnumMember(Value = "Swap Curve")]
        SwapCurve,
        [EnumMember(Value = "Swap RFR Curve")]
        SwapRFRCurve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkScenarioAnalyticsV3InputCurrencyType
    {
        USD,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkScenarioAnalyticsV3InputPrepayTypeType
    {
        Default,
        Model,
        CPR,
        PSA,
        PreExpModel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkScenarioAnalyticsV3InputVolatilityTypeType
    {
        MarketWSkew,
        LMMSOFR,
        LMMSOFRFLAT,
        [EnumMember(Value = "default")]
        Default
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BulkScenarioAnalyticsV3InputHorizonPYMethodType
    {
        [EnumMember(Value = "OAS Change")]
        OASChange,
        [EnumMember(Value = "Spread Change")]
        SpreadChange,
        [EnumMember(Value = "DM Change")]
        DMChange,
        [EnumMember(Value = "Static Spread Change")]
        StaticSpreadChange,
        [EnumMember(Value = "Volatility Change")]
        VolatilityChange,
        Default
    }

    public class ScenarioV3
    {
        [JsonProperty("scenarioID")]
        public string ScenarioId { get; set; }

        [JsonProperty("scenarioType")]
        public ScenarioV3ScenarioTypeType ScenarioType { get; set; }

        [JsonProperty("scenarioTiming")]
        public ScenarioV3ScenarioTimingType ScenarioTiming { get; set; }

        [JsonProperty("reinvestmentRate")]
        public string ReinvestmentRate { get; set; }

        [JsonProperty("swapSpreadConstant")]
        public ScenarioV3SwapSpreadConstantType SwapSpreadConstant { get; set; }

        [JsonProperty("interpolationType")]
        public ScenarioV3InterpolationTypeType InterpolationType { get; set; }

        [JsonProperty("curveShifts")]
        public CurveShiftV3[] CurveShifts { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3ScenarioTypeType
    {
        [EnumMember(Value = "Forward Shift (User Scenario)")]
        ForwardShiftUserScenario,
        [EnumMember(Value = "Implied Forward Shift (User Scenario)")]
        ImpliedForwardShiftUserScenario,
        [EnumMember(Value = "Par Shift (User Scenario)")]
        ParShiftUserScenario,
        [EnumMember(Value = "Spot Shift (User Scenario)")]
        SpotShiftUserScenario,
        [EnumMember(Value = "Bear Steep 50 (System Scenario)")]
        BearSteep50SystemScenario,
        [EnumMember(Value = "Bear Steep 100 (System Scenario)")]
        BearSteep100SystemScenario,
        [EnumMember(Value = "Bear Flat 50 (System Scenario)")]
        BearFlat50SystemScenario,
        [EnumMember(Value = "Bear Flat 100 (System Scenario)")]
        BearFlat100SystemScenario,
        [EnumMember(Value = "Bull Steep 50 (System Scenario)")]
        BullSteep50SystemScenario,
        [EnumMember(Value = "Bull Steep 100 (System Scenario)")]
        BullSteep100SystemScenario,
        [EnumMember(Value = "Bull Flat 50 (System Scenario)")]
        BullFlat50SystemScenario,
        [EnumMember(Value = "Bull Flat 100 (System Scenario)")]
        BullFlat100SystemScenario,
        [EnumMember(Value = "Par Shift 300 (System Scenario)")]
        ParShift300SystemScenario2,
        [EnumMember(Value = "Par Shift 200 (System Scenario)")]
        ParShift200SystemScenario2,
        [EnumMember(Value = "Par Shift 100 (System Scenario)")]
        ParShift100SystemScenario2,
        [EnumMember(Value = "Par Shift 50 (System Scenario)")]
        ParShift50SystemScenario2,
        [EnumMember(Value = "Par Shift 25 (System Scenario)")]
        ParShift25SystemScenario2,
        [EnumMember(Value = "Par Shift 0 (System Scenario)")]
        ParShift0SystemScenario,
        [EnumMember(Value = "Par Shift -25 (System Scenario)")]
        ParShift25SystemScenario,
        [EnumMember(Value = "Par Shift -50 (System Scenario)")]
        ParShift50SystemScenario,
        [EnumMember(Value = "Par Shift -100 (System Scenario)")]
        ParShift100SystemScenario,
        [EnumMember(Value = "Par Shift -200 (System Scenario)")]
        ParShift200SystemScenario,
        [EnumMember(Value = "Par Shift -300 (System Scenario)")]
        ParShift300SystemScenario,
        [EnumMember(Value = "Spot Shift 300 (System Scenario)")]
        SpotShift300SystemScenario2,
        [EnumMember(Value = "Spot Shift 200 (System Scenario)")]
        SpotShift200SystemScenario2,
        [EnumMember(Value = "Spot Shift 100 (System Scenario)")]
        SpotShift100SystemScenario2,
        [EnumMember(Value = "Spot Shift 50 (System Scenario)")]
        SpotShift50SystemScenario2,
        [EnumMember(Value = "Spot Shift 25 (System Scenario)")]
        SpotShift25SystemScenario2,
        [EnumMember(Value = "Spot Shift 0 (System Scenario)")]
        SpotShift0SystemScenario,
        [EnumMember(Value = "Spot Shift -25 (System Scenario)")]
        SpotShift25SystemScenario,
        [EnumMember(Value = "Spot Shift -50 (System Scenario)")]
        SpotShift50SystemScenario,
        [EnumMember(Value = "Spot Shift -100 (System Scenario)")]
        SpotShift100SystemScenario,
        [EnumMember(Value = "Spot Shift -200 (System Scenario)")]
        SpotShift200SystemScenario,
        [EnumMember(Value = "Spot Shift -300 (System Scenario)")]
        SpotShift300SystemScenario,
        [EnumMember(Value = "Fwd Shift 300 (System Scenario)")]
        FwdShift300SystemScenario2,
        [EnumMember(Value = "Fwd Shift 200 (System Scenario)")]
        FwdShift200SystemScenario2,
        [EnumMember(Value = "Fwd Shift 100 (System Scenario)")]
        FwdShift100SystemScenario2,
        [EnumMember(Value = "Fwd Shift 50 (System Scenario)")]
        FwdShift50SystemScenario2,
        [EnumMember(Value = "Fwd Shift 25 (System Scenario)")]
        FwdShift25SystemScenario2,
        [EnumMember(Value = "Fwd Shift 0 (System Scenario)")]
        FwdShift0SystemScenario,
        [EnumMember(Value = "Fwd Shift -25 (System Scenario)")]
        FwdShift25SystemScenario,
        [EnumMember(Value = "Fwd Shift -50 (System Scenario)")]
        FwdShift50SystemScenario,
        [EnumMember(Value = "Fwd Shift -100 (System Scenario)")]
        FwdShift100SystemScenario,
        [EnumMember(Value = "Fwd Shift -200 (System Scenario)")]
        FwdShift200SystemScenario,
        [EnumMember(Value = "Fwd Shift -300 (System Scenario)")]
        FwdShift300SystemScenario,
        [EnumMember(Value = "ImplFwd Shift 300 (System Scenario)")]
        ImplFwdShift300SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 200 (System Scenario)")]
        ImplFwdShift200SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 100 (System Scenario)")]
        ImplFwdShift100SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 50 (System Scenario)")]
        ImplFwdShift50SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 25 (System Scenario)")]
        ImplFwdShift25SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 0 (System Scenario)")]
        ImplFwdShift0SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -25 (System Scenario)")]
        ImplFwdShift25SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -50 (System Scenario)")]
        ImplFwdShift50SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -100 (System Scenario)")]
        ImplFwdShift100SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -200 (System Scenario)")]
        ImplFwdShift200SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -300 (System Scenario)")]
        ImplFwdShift300SystemScenario
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3ScenarioTimingType
    {
        Immediate,
        Gradual,
        AtHorizon
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3SwapSpreadConstantType
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3InterpolationTypeType
    {
        Years,
        Yields,
        PrincipalComponents
    }

    public class CurveShiftV3
    {
        [JsonProperty("curveShiftYear")]
        public double CurveShiftYear { get; set; }

        [JsonProperty("curveShiftValue")]
        public double CurveShiftValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti;

    public partial class WorkflowManagedActions
    {
        public LsegfinancialanalytiActions Lsegfinancialanalyti(string connectionId) => new LsegfinancialanalytiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LsegfinancialanalytiTriggers Lsegfinancialanalyti(string connectionId) => new LsegfinancialanalytiTriggers(connectionId);
    }
}