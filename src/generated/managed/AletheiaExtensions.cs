//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aletheia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AletheiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<StockDataV2Response> StockDataV2(Expression<Func<string>> symbol, Expression<Func<string>> fields = null)
        {
            var apiCallPath = "/v2/StockData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            callPayload.Headers["Accept-Version"] = Convert.ToString(2);
            return new ApiConnectionAction<StockDataV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EntityFilingsResponseItem[]> EntityFilings(Expression<Func<string>> id, Expression<Func<string>> filing = null, Expression<Func<int>> before = null)
        {
            var apiCallPath = "/EntityFilings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (filing != null)
                callPayload.Queries["filing"] = ExpressionConverter.Convert(filing);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            return new ApiConnectionAction<EntityFilingsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<OpenForm4Response> OpenForm4(Expression<Func<string>> filingurl)
        {
            var apiCallPath = "/OpenForm4";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filingurl"] = ExpressionConverter.Convert(filingurl);
            return new ApiConnectionAction<OpenForm4Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<OpenCommonFinancialsResponse> OpenCommonFinancials(Expression<Func<string>> filingurl)
        {
            var apiCallPath = "/OpenCommonFinancials";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filingurl"] = ExpressionConverter.Convert(filingurl);
            return new ApiConnectionAction<OpenCommonFinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<SearchEntitiesResponseItem[]> SearchEntities(Expression<Func<string>> term, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/SearchEntities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            callPayload.Queries["top"] = Convert.ToString(12);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<SearchEntitiesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetEntityResponse> GetEntity(Expression<Func<string>> id)
        {
            var apiCallPath = "/GetEntity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<GetEntityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetFilingResponse> GetFiling(Expression<Func<string>> id = null, Expression<Func<string>> url = null)
        {
            var apiCallPath = "/GetFiling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (url != null)
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            return new ApiConnectionAction<GetFilingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<LatestTransactionsResponseItem[]> LatestTransactions(Expression<Func<string>> issuer = null, Expression<Func<int>> owner = null, Expression<Func<int>> top = null, Expression<Func<string>> before = null, Expression<Func<int>> securitytype = null, Expression<Func<int>> transactiontype = null, Expression<Func<bool>> cascade = null)
        {
            var apiCallPath = "/LatestTransactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (issuer != null)
                callPayload.Queries["issuer"] = ExpressionConverter.Convert(issuer);
            if (owner != null)
                callPayload.Queries["owner"] = ExpressionConverter.Convert(owner);
            callPayload.Queries["top"] = Convert.ToString(20);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (securitytype != null)
                callPayload.Queries["securitytype"] = ExpressionConverter.Convert(securitytype);
            if (transactiontype != null)
                callPayload.Queries["transactiontype"] = ExpressionConverter.Convert(transactiontype);
            if (cascade != null)
                callPayload.Queries["cascade"] = ExpressionConverter.Convert(cascade);
            return new ApiConnectionAction<LatestTransactionsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<AffiliatedOwnersResponseItem[]> AffiliatedOwners(Expression<Func<string>> id)
        {
            var apiCallPath = "/AffiliatedOwners";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<AffiliatedOwnersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetCommonFinancialsResponse> GetCommonFinancials(Expression<Func<string>> id, Expression<Func<periodInput>> period = null, Expression<Func<string>> before = null)
        {
            var apiCallPath = "/CommonFinancials";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (period != null)
                callPayload.Queries["period"] = ExpressionConverter.Convert(period);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            return new ApiConnectionAction<GetCommonFinancialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<FinancialFactTrendResponseItem[]> FinancialFactTrend(Expression<Func<string>> id, Expression<Func<int>> label, Expression<Func<int>> period = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var apiCallPath = "/FinancialFactTrend";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["label"] = ExpressionConverter.Convert(label);
            if (period != null)
                callPayload.Queries["period"] = ExpressionConverter.Convert(period);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            return new ApiConnectionAction<FinancialFactTrendResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<SearchEarningsCallsResponseItem[]> SearchEarningsCalls(Expression<Func<string>> company = null, Expression<Func<int>> year = null, Expression<Func<string>> quarter = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/SearchEarningsCalls";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (year != null)
                callPayload.Queries["year"] = ExpressionConverter.Convert(year);
            if (quarter != null)
                callPayload.Queries["quarter"] = ExpressionConverter.Convert(quarter);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<SearchEarningsCallsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EarningsCallResponse> EarningsCall(Expression<Func<string>> company, Expression<Func<int>> year = null, Expression<Func<string>> quarter = null, Expression<Func<int>> begin = null, Expression<Func<int>> end = null)
        {
            var apiCallPath = "/EarningsCall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (year != null)
                callPayload.Queries["year"] = ExpressionConverter.Convert(year);
            if (quarter != null)
                callPayload.Queries["quarter"] = ExpressionConverter.Convert(quarter);
            if (begin != null)
                callPayload.Queries["begin"] = ExpressionConverter.Convert(begin);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<EarningsCallResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EarningsCallHighlightsResponseItem[]> EarningsCallHighlights(Expression<Func<string>> company, Expression<Func<int>> year, Expression<Func<string>> quarter, Expression<Func<int>> category = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/EarningsCallHighlights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            callPayload.Queries["year"] = ExpressionConverter.Convert(year);
            callPayload.Queries["quarter"] = ExpressionConverter.Convert(quarter);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<EarningsCallHighlightsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<CryptoQuoteResponse> CryptoQuote(Expression<Func<string>> symbol)
        {
            var apiCallPath = "/Crypto";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["symbol"] = ExpressionConverter.Convert(symbol);
            return new ApiConnectionAction<CryptoQuoteResponse>(callPayload);
        }
    }

    public class AletheiaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewFilings(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/SubscribeToNewFilingsWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["endpoint"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger InsiderTrading(Expression<Func<string>> bodyissuer = null, Expression<Func<int>> bodyowner = null, Expression<Func<bodytransactionTypeInput>> bodytransactionType = null, Expression<Func<bodysecurityTypeInput>> bodysecurityType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/SubscribeToInsiderTradingWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["endpoint"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodytransactionType != null)
            {
                body["transactionType"] = ExpressionConverter.ConvertO(bodytransactionType);
                bodypropCount++;
            }

            if (bodysecurityType != null)
            {
                body["securityType"] = ExpressionConverter.ConvertO(bodysecurityType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class StockDataV2Response
    {
        public string Symbol { get; set; }
        public int FullTimeEmployees { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public double Open { get; set; }
        public int AverageVolume90Day { get; set; }
        public string Exchange { get; set; }
        public double DayHigh { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public double Change { get; set; }
        public double PreviousClose { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public int Volume { get; set; }
        public double MarketCap { get; set; }
        public double ChangePercent { get; set; }
        public double DayLow { get; set; }
        public double BidPrice { get; set; }
        public int BidQuantity { get; set; }
        public double AskPrice { get; set; }
        public int AskQuantity { get; set; }
        public int AverageVolume10Day { get; set; }
        public double YearLow { get; set; }
        public double YearHigh { get; set; }
        public double Beta { get; set; }
        public double PriceEarningsRatio { get; set; }
        public double EarningsPerShare { get; set; }
        public string EarningsDate { get; set; }
        public double ForwardDividend { get; set; }
        public double ForwardDividendYield { get; set; }
        public string ExDividendDate { get; set; }
        public double YearTargetEstimate { get; set; }
        public string LastFiscalYearEnd { get; set; }
        public string LastFiscalQuarterEnd { get; set; }
        public double ProfitMargin { get; set; }
        public double OperatingMargin { get; set; }
        public double ReturnOnAssets { get; set; }
        public double ReturnOnEquity { get; set; }
        public double Revenue { get; set; }
        public double RevenuePerShare { get; set; }
        public double QuarterlyRevenueGrowth { get; set; }
        public double GrossProfit { get; set; }
        public double EDBITDA { get; set; }
        public double NetIncomeAvailableToCommon { get; set; }
        public double QuarterlyEarningsGrowth { get; set; }
        public double Cash { get; set; }
        public double CashPerShare { get; set; }
        public double Debt { get; set; }
        public double DebtToEquityRatio { get; set; }
        public double CurrentRatio { get; set; }
        public double BookValuePerShare { get; set; }
        public double OperatingCashFlow { get; set; }
        public double LeveredFreeCashFlow { get; set; }
        public double YearChangePercent { get; set; }
        public double SP500YearChangePercent { get; set; }
        public double MovingAverage50Day { get; set; }
        public double MovingAverage200Day { get; set; }
        public double SharesOutstanding { get; set; }
        public double Float { get; set; }
        public double PercentHeldByInsiders { get; set; }
        public double PercentHeldByInstitutions { get; set; }
        public double SharesShort { get; set; }
        public double ShortRatio { get; set; }
        public double ShortPercentOfFloat { get; set; }
        public double ShortPercentOfSharesOutstanding { get; set; }
        public double ForwardAnnualDividend { get; set; }
        public double ForwardAnnualDividendYield { get; set; }
        public double TrailingAnnualDividend { get; set; }
        public double TrailingAnnualDividendYield { get; set; }
        public double FiveYearAverageDividendYield { get; set; }
        public double DividendPayoutRatio { get; set; }
        public string DividendDate { get; set; }
        public string LastSplitFactor { get; set; }
        public string LastSplitDate { get; set; }
    }

    public class EntityFilingsResponseItem
    {
        public string InteractiveDataUrl { get; set; }
        public string Filing { get; set; }
        public string DocumentsUrl { get; set; }
        public string Description { get; set; }
        public string FilingDate { get; set; }
    }

    public class OpenForm4Response
    {
        public string SchemaVersion { get; set; }
        public string PeriodOfReport { get; set; }
        public string DocumentType { get; set; }
        public string IssuerCik { get; set; }
        public string IssuerName { get; set; }
        public string IssuerTradingSymbol { get; set; }
        public string OwnerName { get; set; }
        public string OwnerCik { get; set; }
        public string OwnerStreet1 { get; set; }
        public string OwnerStreet2 { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerStateCode { get; set; }
        public string OwnerZipCode { get; set; }
        public bool OwnerIsOfficer { get; set; }
        public string OwnerOfficerTitle { get; set; }
        public OpenForm4ResponseNonDerivativeTransactionsTypeItem[] NonDerivativeTransactions { get; set; }
        public OpenForm4ResponseDerivativeTransactionsTypeItem[] DerivativeTransactions { get; set; }
    }

    public class OpenForm4ResponseNonDerivativeTransactionsTypeItem
    {
        public string SecurityTitle { get; set; }
        public double SecuritiesOwnedFollowingTransaction { get; set; }
        public int DirectOrIndirectOwnership { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionCode { get; set; }
        public double TransactionQuantity { get; set; }
        public double TransactionPricePerSecurity { get; set; }
        public int AcquiredOrDisposed { get; set; }
    }

    public class OpenForm4ResponseDerivativeTransactionsTypeItem
    {
        public double ConversionOrExercisePrice { get; set; }
        public string Exersisable { get; set; }
        public string Expiration { get; set; }
        public string UnderlyingSecurityTitle { get; set; }
        public double UnderlyingSecurityQuantity { get; set; }
        public string SecurityTitle { get; set; }
        public double SecuritiesOwnedFollowingTransaction { get; set; }
        public int DirectOrIndirectOwnership { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionCode { get; set; }
        public double TransactionQuantity { get; set; }
        public double TransactionPricePerSecurity { get; set; }
        public int AcquiredOrDisposed { get; set; }
    }

    public class OpenCommonFinancialsResponse
    {
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public double Revenue { get; set; }
        public double SellingGeneralAndAdministrativeExpense { get; set; }
        public double ResearchAndDevelopmentExpense { get; set; }
        public double OperatingIncome { get; set; }
        public double NetIncome { get; set; }
        public double Assets { get; set; }
        public double Liabilities { get; set; }
        public double Equity { get; set; }
        public double Cash { get; set; }
        public double CurrentAssets { get; set; }
        public double CurrentLiabilities { get; set; }
        public double RetainedEarnings { get; set; }
        public double CommonStockSharesOutstanding { get; set; }
        public double OperatingCashFlows { get; set; }
        public double InvestingCashFlows { get; set; }
        public double FinancingCashFlows { get; set; }
        public double ProceedsFromIssuanceOfDebt { get; set; }
        public double PaymentsOfDebt { get; set; }
        public double DividendsPaid { get; set; }
    }

    public class SearchEntitiesResponseItem
    {
        public int Cik { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class GetEntityResponse
    {
        public int Cik { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class GetFilingResponse
    {
        public string Id { get; set; }
        public string FilingUrl { get; set; }
        public int AccessionP1 { get; set; }
        public int AccessionP2 { get; set; }
        public int AccessionP3 { get; set; }
        public int FilingType { get; set; }
        public string ReportedOn { get; set; }

        [JsonProperty("_Issuer")]
        public string Issuer { get; set; }

        [JsonProperty("_Owner")]
        public string Owner { get; set; }
    }

    public class LatestTransactionsResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("_FromFiling")]
        public LatestTransactionsResponseItemFromFilingType FromFiling { get; set; }
        public int EntryType { get; set; }
        public double QuantityOwnedFollowingTransaction { get; set; }
        public int DirectIndirect { get; set; }
        public string SecurityTitle { get; set; }
        public int SecurityType { get; set; }
        public int AcquiredDisposed { get; set; }
        public double Quantity { get; set; }
        public double PricePerSecurity { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionCode { get; set; }
        public double ConversionOrExercisePrice { get; set; }
        public string ExercisableDate { get; set; }
        public string ExpirationDate { get; set; }
        public string UnderlyingSecurityTitle { get; set; }
        public double UnderlyingSecurityQuantity { get; set; }
    }

    public class LatestTransactionsResponseItemFromFilingType
    {
        public string Id { get; set; }
        public string FilingUrl { get; set; }
        public int AccessionP1 { get; set; }
        public int AccessionP2 { get; set; }
        public int AccessionP3 { get; set; }
        public string FilingType { get; set; }
        public string ReportedOn { get; set; }

        [JsonProperty("_Issuer")]
        public LatestTransactionsResponseItemFromFilingTypeIssuerType Issuer { get; set; }

        [JsonProperty("_Owner")]
        public LatestTransactionsResponseItemFromFilingTypeOwnerType Owner { get; set; }
    }

    public class LatestTransactionsResponseItemFromFilingTypeIssuerType
    {
        public int Cik { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class LatestTransactionsResponseItemFromFilingTypeOwnerType
    {
        public int Cik { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class AffiliatedOwnersResponseItem
    {
        public int Cik { get; set; }
        public string Name { get; set; }
    }

    public class GetCommonFinancialsResponse
    {
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public GetCommonFinancialsResponseFactsType Facts { get; set; }
    }

    public class GetCommonFinancialsResponseFactsType
    {
        public double RetainedEarnings { get; set; }
        public double OperatingIncome { get; set; }
        public double Revenue { get; set; }
        public double SellingGeneralAndAdministrativeExpense { get; set; }
        public double ResearchAndDevelopmentExpense { get; set; }
        public double Assets { get; set; }
        public double NetIncome { get; set; }
        public double ProceedsFromIssuanceOfDebt { get; set; }
        public double OperatingCashFlows { get; set; }
        public double CurrentLiabilities { get; set; }
        public double Equity { get; set; }
        public double DividendsPaid { get; set; }
        public double Liabilities { get; set; }
        public double CommonStockSharesOutstanding { get; set; }
        public double CurrentAssets { get; set; }
        public double InvestingCashFlows { get; set; }
        public double FinancingCashFlows { get; set; }
        public double Cash { get; set; }
    }

    public enum periodInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class FinancialFactTrendResponseItem
    {
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public double Value { get; set; }
    }

    public class SearchEarningsCallsResponseItem
    {
        public string Id { get; set; }
        public SearchEarningsCallsResponseItemCompanyType Company { get; set; }
        public int Period { get; set; }
        public int Year { get; set; }
        public string HeldAt { get; set; }
    }

    public class SearchEarningsCallsResponseItemCompanyType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class EarningsCallResponse
    {
        public string Id { get; set; }
        public int Year { get; set; }
        public int Period { get; set; }
        public EarningsCallResponseCompanyType Company { get; set; }
        public EarningsCallResponseRemarksTypeItem[] Remarks { get; set; }
    }

    public class EarningsCallResponseCompanyType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TradingSymbol { get; set; }
    }

    public class EarningsCallResponseRemarksTypeItem
    {
        public int SequenceNumber { get; set; }
        public string Remark { get; set; }
        public EarningsCallResponseRemarksTypeItemSpokenByType SpokenBy { get; set; }
    }

    public class EarningsCallResponseRemarksTypeItemSpokenByType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsExternal { get; set; }
    }

    public class EarningsCallHighlightsResponseItem
    {
        public string Id { get; set; }
        public string Remark { get; set; }
        public EarningsCallHighlightsResponseItemSpokenByType SpokenBy { get; set; }
        public EarningsCallHighlightsResponseItemHighlightsTypeItem[] Highlights { get; set; }
    }

    public class EarningsCallHighlightsResponseItemSpokenByType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsExternal { get; set; }
    }

    public class EarningsCallHighlightsResponseItemHighlightsTypeItem
    {
        public int BeginPosition { get; set; }
        public int EndPosition { get; set; }
        public int Category { get; set; }
        public int Rating { get; set; }
    }

    public class CryptoQuoteResponse
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DollarChange { get; set; }
        public double PercentChange { get; set; }
        public double DayLow { get; set; }
        public double DayHigh { get; set; }
        public double YearLow { get; set; }
        public double YearHigh { get; set; }
        public double MarketCap { get; set; }
        public int Volume { get; set; }
        public string DataCollected { get; set; }
    }

    public enum bodytransactionTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "17")]
        _17,
        [EnumMember(Value = "18")]
        _18,
        [EnumMember(Value = "19")]
        _19
    }

    public enum bodysecurityTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aletheia;

    public partial class WorkflowManagedActions
    {
        public AletheiaActions Aletheia(string connectionId) => new AletheiaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AletheiaTriggers Aletheia(string connectionId) => new AletheiaTriggers(connectionId);
    }
}