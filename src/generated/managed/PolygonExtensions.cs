//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Polygon
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolygonActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetDailyOpenCloseResponse> GetDailyOpenClose(Expression<Func<string>> stocksTicker, Expression<Func<string>> date, Expression<Func<bool>> adjusted = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/open-close/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stocksTicker, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (adjusted != null)
                callPayload.Queries["adjusted"] = CSharpExpressionConverter.ConvertO(adjusted);
            return new ApiConnectionAction<GetDailyOpenCloseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickersResponse> GetTickers(Expression<Func<string>> ticker = null, Expression<Func<typeInput>> type = null, Expression<Func<marketInput>> market = null, Expression<Func<string>> exchange = null, Expression<Func<string>> cusip = null, Expression<Func<string>> cik = null, Expression<Func<string>> date = null, Expression<Func<string>> search = null, Expression<Func<bool>> active = null, Expression<Func<orderInput>> order = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/v3/reference/tickers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ticker != null)
                callPayload.Queries["ticker"] = CSharpExpressionConverter.ConvertO(ticker);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            if (market != null)
                callPayload.Queries["market"] = CSharpExpressionConverter.Convert(market);
            if (exchange != null)
                callPayload.Queries["exchange"] = CSharpExpressionConverter.ConvertO(exchange);
            if (cusip != null)
                callPayload.Queries["cusip"] = CSharpExpressionConverter.ConvertO(cusip);
            if (cik != null)
                callPayload.Queries["cik"] = CSharpExpressionConverter.ConvertO(cik);
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (active != null)
                callPayload.Queries["active"] = CSharpExpressionConverter.ConvertO(active);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.Convert(sort);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<GetTickersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerDetailsResponse> GetTickerDetails(Expression<Func<string>> ticker, Expression<Func<string>> date = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/reference/tickers/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticker, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            return new ApiConnectionAction<GetTickerDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerEventsResponse> GetTickerEvents(Expression<Func<string>> id, Expression<Func<string>> types = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/vX/reference/tickers/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (types != null)
                callPayload.Queries["types"] = CSharpExpressionConverter.ConvertO(types);
            return new ApiConnectionAction<GetTickerEventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockSplitsResponse> GetStockSplits(Expression<Func<string>> ticker, Expression<Func<string>> executionDate = null, Expression<Func<bool>> reverseSplit = null, Expression<Func<orderInput>> order = null, Expression<Func<int>> limit = null, Expression<Func<sortInput>> sort = null)
        {
            var apiCallPath = "/v3/reference/splits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ticker"] = CSharpExpressionConverter.ConvertO(ticker);
            if (executionDate != null)
                callPayload.Queries["execution_date"] = CSharpExpressionConverter.ConvertO(executionDate);
            if (reverseSplit != null)
                callPayload.Queries["reverse_split"] = CSharpExpressionConverter.ConvertO(reverseSplit);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            callPayload.Queries["limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetStockSplitsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockDividendsResponse> GetStockDividends(Expression<Func<string>> ticker, Expression<Func<string>> exDividendDate = null, Expression<Func<string>> recordDate = null, Expression<Func<string>> declarationDate = null, Expression<Func<string>> payDate = null, Expression<Func<frequencyInput>> frequency = null, Expression<Func<double>> cashAmount = null, Expression<Func<dividendTypeInput>> dividendType = null)
        {
            var apiCallPath = "/v3/reference/dividends";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ticker"] = CSharpExpressionConverter.ConvertO(ticker);
            if (exDividendDate != null)
                callPayload.Queries["ex_dividend_date"] = CSharpExpressionConverter.ConvertO(exDividendDate);
            if (recordDate != null)
                callPayload.Queries["record_date"] = CSharpExpressionConverter.ConvertO(recordDate);
            if (declarationDate != null)
                callPayload.Queries["declaration_date"] = CSharpExpressionConverter.ConvertO(declarationDate);
            if (payDate != null)
                callPayload.Queries["pay_date"] = CSharpExpressionConverter.ConvertO(payDate);
            if (frequency != null)
                callPayload.Queries["frequency"] = CSharpExpressionConverter.Convert(frequency);
            if (cashAmount != null)
                callPayload.Queries["cash_amount"] = CSharpExpressionConverter.ConvertO(cashAmount);
            if (dividendType != null)
                callPayload.Queries["dividend_type"] = CSharpExpressionConverter.Convert(dividendType);
            return new ApiConnectionAction<GetStockDividendsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockFinancialDetailsResponse> GetStockFinancialDetails(Expression<Func<string>> ticker = null, Expression<Func<string>> cik = null, Expression<Func<string>> companyName = null, Expression<Func<string>> sic = null, Expression<Func<string>> filingDate = null, Expression<Func<string>> periodOfReportDate = null, Expression<Func<timeframeInput>> timeframe = null, Expression<Func<bool>> includeSources = null, Expression<Func<orderInput>> order = null, Expression<Func<int>> limit = null, Expression<Func<sortInput>> sort = null)
        {
            var apiCallPath = "/vX/reference/financials";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ticker != null)
                callPayload.Queries["ticker"] = CSharpExpressionConverter.ConvertO(ticker);
            if (cik != null)
                callPayload.Queries["cik"] = CSharpExpressionConverter.ConvertO(cik);
            if (companyName != null)
                callPayload.Queries["company_name"] = CSharpExpressionConverter.ConvertO(companyName);
            if (sic != null)
                callPayload.Queries["sic"] = CSharpExpressionConverter.ConvertO(sic);
            if (filingDate != null)
                callPayload.Queries["filing_date"] = CSharpExpressionConverter.ConvertO(filingDate);
            if (periodOfReportDate != null)
                callPayload.Queries["period_of_report_date"] = CSharpExpressionConverter.ConvertO(periodOfReportDate);
            if (timeframe != null)
                callPayload.Queries["timeframe"] = CSharpExpressionConverter.Convert(timeframe);
            if (includeSources != null)
                callPayload.Queries["include_sources"] = CSharpExpressionConverter.ConvertO(includeSources);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetStockFinancialDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetExchangesResponse> GetExchanges(Expression<Func<assetClassInput>> assetClass = null, Expression<Func<localeInput>> locale = null)
        {
            var apiCallPath = "/v3/reference/exchanges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (assetClass != null)
                callPayload.Queries["asset_class"] = CSharpExpressionConverter.Convert(assetClass);
            if (locale != null)
                callPayload.Queries["locale"] = CSharpExpressionConverter.Convert(locale);
            return new ApiConnectionAction<GetExchangesResponse>(callPayload);
        }
    }

    public class PolygonTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDailyOpenCloseResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("afterHours")]
        public double AfterHours { get; set; }

        [JsonProperty("preMarket")]
        public double PreMarket { get; set; }
    }

    public class GetTickersResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public GetTickersResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetTickersResponseResultsTypeItem
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("composite_figi")]
        public string CompositeFigi { get; set; }

        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary_exchange")]
        public string PrimaryExchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum typeInput
    {
        CS,
        ADRC,
        ADRP,
        ADRR,
        UNIT,
        RIGHT,
        PFD,
        FUND,
        SP,
        WARRANT,
        INDEX,
        ETF,
        ETN,
        OS,
        GDR,
        OTHER,
        NYRS,
        AGEN,
        EQLK,
        BOND,
        ADRW,
        BASKET,
        LT
    }

    public enum marketInput
    {
        [EnumMember(Value = "stocks")]
        Stocks,
        [EnumMember(Value = "crypto")]
        Crypto,
        [EnumMember(Value = "fx")]
        Fx,
        [EnumMember(Value = "otc")]
        Otc,
        [EnumMember(Value = "indices")]
        Indices
    }

    public enum orderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public enum sortInput
    {
        [EnumMember(Value = "filing_date")]
        FilingDate,
        [EnumMember(Value = "period_of_report_date")]
        PeriodOfReportDate
    }

    public class GetTickerDetailsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("results")]
        public GetTickerDetailsResponseResultsType Results { get; set; }
    }

    public class GetTickerDetailsResponseResultsType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("address")]
        public GetTickerDetailsResponseResultsTypeAddressType Address { get; set; }

        [JsonProperty("branding")]
        public GetTickerDetailsResponseResultsTypeBrandingType Branding { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("composite_figi")]
        public string CompositeFigi { get; set; }

        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("market_cap")]
        public double MarketCap { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary_exchange")]
        public string PrimaryExchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("total_employees")]
        public int TotalEmployees { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("weighted_shares_outstanding")]
        public double WeightedSharesOutstanding { get; set; }
    }

    public class GetTickerDetailsResponseResultsTypeAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetTickerDetailsResponseResultsTypeBrandingType
    {
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }
    }

    public class GetTickerEventsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("results")]
        public GetTickerEventsResponseResultsType Results { get; set; }
    }

    public class GetTickerEventsResponseResultsType
    {
        [JsonProperty("events")]
        public GetTickerEventsResponseResultsTypeEventsTypeItem[] Events { get; set; }
    }

    public class GetTickerEventsResponseResultsTypeEventsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("ticker_change")]
        public GetTickerEventsResponseResultsTypeEventsTypeItemTickerChangeType TickerChange { get; set; }
    }

    public class GetTickerEventsResponseResultsTypeEventsTypeItemTickerChangeType
    {
        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public class GetStockSplitsResponse
    {
        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        [JsonProperty("results")]
        public GetStockSplitsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetStockSplitsResponseResultsTypeItem
    {
        [JsonProperty("execution_date")]
        public string ExecutionDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("split_from")]
        public int SplitFrom { get; set; }

        [JsonProperty("split_to")]
        public int SplitTo { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public class GetStockDividendsResponse
    {
        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        [JsonProperty("results")]
        public GetStockDividendsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetStockDividendsResponseResultsTypeItem
    {
        [JsonProperty("cash_amount")]
        public double CashAmount { get; set; }

        [JsonProperty("declaration_date")]
        public string DeclarationDate { get; set; }

        [JsonProperty("ex_dividend_date")]
        public string ExDividendDate { get; set; }

        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pay_date")]
        public string PayDate { get; set; }

        [JsonProperty("record_date")]
        public string RecordDate { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public enum frequencyInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "12")]
        _12
    }

    public enum dividendTypeInput
    {
        CD,
        SC,
        LT,
        ST
    }

    public class GetStockFinancialDetailsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("results")]
        public GetStockFinancialDetailsResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItem
    {
        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("filing_date")]
        public string FilingDate { get; set; }

        [JsonProperty("fiscal_period")]
        public string FiscalPeriod { get; set; }

        [JsonProperty("fiscal_year")]
        public string FiscalYear { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("source_filing_file_url")]
        public string SourceFilingFileUrl { get; set; }

        [JsonProperty("financials")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsType Financials { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsType
    {
        [JsonProperty("balance_sheet")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetType BalanceSheet { get; set; }

        [JsonProperty("income_statement")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementType IncomeStatement { get; set; }

        [JsonProperty("cash_flow_statement")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeCashFlowStatementType CashFlowStatement { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetType
    {
        [JsonProperty("assets")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeAssetsType Assets { get; set; }

        [JsonProperty("liabilities")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeLiabilitiesType Liabilities { get; set; }

        [JsonProperty("equity")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeEquityType Equity { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeAssetsType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeLiabilitiesType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeBalanceSheetTypeEquityType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementType
    {
        [JsonProperty("revenue")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementTypeRevenueType Revenue { get; set; }

        [JsonProperty("net_income")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementTypeNetIncomeType NetIncome { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementTypeRevenueType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeIncomeStatementTypeNetIncomeType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeCashFlowStatementType
    {
        [JsonProperty("net_cash_flow")]
        public GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeCashFlowStatementTypeNetCashFlowType NetCashFlow { get; set; }
    }

    public class GetStockFinancialDetailsResponseResultsTypeItemFinancialsTypeCashFlowStatementTypeNetCashFlowType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public enum timeframeInput
    {
        [EnumMember(Value = "annual")]
        Annual,
        [EnumMember(Value = "quarterly")]
        Quarterly,
        [EnumMember(Value = "ttm")]
        Ttm
    }

    public class GetExchangesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("results")]
        public GetExchangesResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetExchangesResponseResultsTypeItem
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("asset_class")]
        public string AssetClass { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("mic")]
        public string Mic { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operating_mic")]
        public string OperatingMic { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum assetClassInput
    {
        [EnumMember(Value = "stocks")]
        Stocks,
        [EnumMember(Value = "options")]
        Options,
        [EnumMember(Value = "crypto")]
        Crypto,
        [EnumMember(Value = "fx")]
        Fx
    }

    public enum localeInput
    {
        [EnumMember(Value = "us")]
        Us,
        [EnumMember(Value = "global")]
        Global
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Polygon;

    public partial class WorkflowManagedActions
    {
        public PolygonActions Polygon(string connectionId) => new PolygonActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PolygonTriggers Polygon(string connectionId) => new PolygonTriggers(connectionId);
    }
}