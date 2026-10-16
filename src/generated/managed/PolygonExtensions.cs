//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Polygon
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolygonActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetDailyOpenCloseResponse> GetDailyOpenClose(Expression<Func<string>> stocksTicker, Expression<Func<string>> date, Expression<Func<bool>> adjusted = null)
        {
            var __workflow_stocksTicker = WorkflowExpression.Compile(stocksTicker, nameof(stocksTicker), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            var __workflow_adjusted = WorkflowExpression.Compile(adjusted, nameof(adjusted), required: false);
            return new DeferredBodyAction<GetDailyOpenCloseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/open-close/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stocksTicker, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_adjusted != null)
                    callPayload.Queries["adjusted"] = ExpressionConverter.Convert(__workflow_adjusted);
                return new ApiConnectionAction<GetDailyOpenCloseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickersResponse> GetTickers(Expression<Func<string>> ticker = null, Expression<Func<typeInput>> type = null, Expression<Func<marketInput>> market = null, Expression<Func<string>> exchange = null, Expression<Func<string>> cusip = null, Expression<Func<string>> cik = null, Expression<Func<string>> date = null, Expression<Func<string>> search = null, Expression<Func<bool>> active = null, Expression<Func<orderInput>> order = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limit = null)
        {
            var __workflow_ticker = WorkflowExpression.Compile(ticker, nameof(ticker), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_market = WorkflowExpression.Compile(market, nameof(market), required: false);
            var __workflow_exchange = WorkflowExpression.Compile(exchange, nameof(exchange), required: false);
            var __workflow_cusip = WorkflowExpression.Compile(cusip, nameof(cusip), required: false);
            var __workflow_cik = WorkflowExpression.Compile(cik, nameof(cik), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetTickersResponse>(() =>
            {
                var apiCallPath = "/v3/reference/tickers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ticker != null)
                    callPayload.Queries["ticker"] = ExpressionConverter.Convert(__workflow_ticker);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_market != null)
                    callPayload.Queries["market"] = ExpressionConverter.Convert(__workflow_market);
                if (__workflow_exchange != null)
                    callPayload.Queries["exchange"] = ExpressionConverter.Convert(__workflow_exchange);
                if (__workflow_cusip != null)
                    callPayload.Queries["cusip"] = ExpressionConverter.Convert(__workflow_cusip);
                if (__workflow_cik != null)
                    callPayload.Queries["cik"] = ExpressionConverter.Convert(__workflow_cik);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GetTickersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerDetailsResponse> GetTickerDetails(Expression<Func<string>> ticker, Expression<Func<string>> date = null)
        {
            var __workflow_ticker = WorkflowExpression.Compile(ticker, nameof(ticker), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            return new DeferredBodyAction<GetTickerDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/reference/tickers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticker, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<GetTickerDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerEventsResponse> GetTickerEvents(Expression<Func<string>> id, Expression<Func<string>> types = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_types = WorkflowExpression.Compile(types, nameof(types), required: false);
            return new DeferredBodyAction<GetTickerEventsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vX/reference/tickers/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(__workflow_types);
                return new ApiConnectionAction<GetTickerEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockSplitsResponse> GetStockSplits(Expression<Func<string>> ticker, Expression<Func<string>> executionDate = null, Expression<Func<bool>> reverseSplit = null, Expression<Func<orderInput>> order = null, Expression<Func<int>> limit = null, Expression<Func<sortInput>> sort = null)
        {
            var __workflow_ticker = WorkflowExpression.Compile(ticker, nameof(ticker), required: true);
            var __workflow_executionDate = WorkflowExpression.Compile(executionDate, nameof(executionDate), required: false);
            var __workflow_reverseSplit = WorkflowExpression.Compile(reverseSplit, nameof(reverseSplit), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetStockSplitsResponse>(() =>
            {
                var apiCallPath = "/v3/reference/splits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = ExpressionConverter.Convert(__workflow_ticker);
                if (__workflow_executionDate != null)
                    callPayload.Queries["execution_date"] = ExpressionConverter.Convert(__workflow_executionDate);
                if (__workflow_reverseSplit != null)
                    callPayload.Queries["reverse_split"] = ExpressionConverter.Convert(__workflow_reverseSplit);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetStockSplitsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockDividendsResponse> GetStockDividends(Expression<Func<string>> ticker, Expression<Func<string>> exDividendDate = null, Expression<Func<string>> recordDate = null, Expression<Func<string>> declarationDate = null, Expression<Func<string>> payDate = null, Expression<Func<frequencyInput>> frequency = null, Expression<Func<double>> cashAmount = null, Expression<Func<dividendTypeInput>> dividendType = null)
        {
            var __workflow_ticker = WorkflowExpression.Compile(ticker, nameof(ticker), required: true);
            var __workflow_exDividendDate = WorkflowExpression.Compile(exDividendDate, nameof(exDividendDate), required: false);
            var __workflow_recordDate = WorkflowExpression.Compile(recordDate, nameof(recordDate), required: false);
            var __workflow_declarationDate = WorkflowExpression.Compile(declarationDate, nameof(declarationDate), required: false);
            var __workflow_payDate = WorkflowExpression.Compile(payDate, nameof(payDate), required: false);
            var __workflow_frequency = WorkflowExpression.Compile(frequency, nameof(frequency), required: false);
            var __workflow_cashAmount = WorkflowExpression.Compile(cashAmount, nameof(cashAmount), required: false);
            var __workflow_dividendType = WorkflowExpression.Compile(dividendType, nameof(dividendType), required: false);
            return new DeferredBodyAction<GetStockDividendsResponse>(() =>
            {
                var apiCallPath = "/v3/reference/dividends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = ExpressionConverter.Convert(__workflow_ticker);
                if (__workflow_exDividendDate != null)
                    callPayload.Queries["ex_dividend_date"] = ExpressionConverter.Convert(__workflow_exDividendDate);
                if (__workflow_recordDate != null)
                    callPayload.Queries["record_date"] = ExpressionConverter.Convert(__workflow_recordDate);
                if (__workflow_declarationDate != null)
                    callPayload.Queries["declaration_date"] = ExpressionConverter.Convert(__workflow_declarationDate);
                if (__workflow_payDate != null)
                    callPayload.Queries["pay_date"] = ExpressionConverter.Convert(__workflow_payDate);
                if (__workflow_frequency != null)
                    callPayload.Queries["frequency"] = ExpressionConverter.Convert(__workflow_frequency);
                if (__workflow_cashAmount != null)
                    callPayload.Queries["cash_amount"] = ExpressionConverter.Convert(__workflow_cashAmount);
                if (__workflow_dividendType != null)
                    callPayload.Queries["dividend_type"] = ExpressionConverter.Convert(__workflow_dividendType);
                return new ApiConnectionAction<GetStockDividendsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockFinancialDetailsResponse> GetStockFinancialDetails(Expression<Func<string>> ticker = null, Expression<Func<string>> cik = null, Expression<Func<string>> companyName = null, Expression<Func<string>> sic = null, Expression<Func<string>> filingDate = null, Expression<Func<string>> periodOfReportDate = null, Expression<Func<timeframeInput>> timeframe = null, Expression<Func<bool>> includeSources = null, Expression<Func<orderInput>> order = null, Expression<Func<int>> limit = null, Expression<Func<sortInput>> sort = null)
        {
            var __workflow_ticker = WorkflowExpression.Compile(ticker, nameof(ticker), required: false);
            var __workflow_cik = WorkflowExpression.Compile(cik, nameof(cik), required: false);
            var __workflow_companyName = WorkflowExpression.Compile(companyName, nameof(companyName), required: false);
            var __workflow_sic = WorkflowExpression.Compile(sic, nameof(sic), required: false);
            var __workflow_filingDate = WorkflowExpression.Compile(filingDate, nameof(filingDate), required: false);
            var __workflow_periodOfReportDate = WorkflowExpression.Compile(periodOfReportDate, nameof(periodOfReportDate), required: false);
            var __workflow_timeframe = WorkflowExpression.Compile(timeframe, nameof(timeframe), required: false);
            var __workflow_includeSources = WorkflowExpression.Compile(includeSources, nameof(includeSources), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetStockFinancialDetailsResponse>(() =>
            {
                var apiCallPath = "/vX/reference/financials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ticker != null)
                    callPayload.Queries["ticker"] = ExpressionConverter.Convert(__workflow_ticker);
                if (__workflow_cik != null)
                    callPayload.Queries["cik"] = ExpressionConverter.Convert(__workflow_cik);
                if (__workflow_companyName != null)
                    callPayload.Queries["company_name"] = ExpressionConverter.Convert(__workflow_companyName);
                if (__workflow_sic != null)
                    callPayload.Queries["sic"] = ExpressionConverter.Convert(__workflow_sic);
                if (__workflow_filingDate != null)
                    callPayload.Queries["filing_date"] = ExpressionConverter.Convert(__workflow_filingDate);
                if (__workflow_periodOfReportDate != null)
                    callPayload.Queries["period_of_report_date"] = ExpressionConverter.Convert(__workflow_periodOfReportDate);
                if (__workflow_timeframe != null)
                    callPayload.Queries["timeframe"] = ExpressionConverter.Convert(__workflow_timeframe);
                if (__workflow_includeSources != null)
                    callPayload.Queries["include_sources"] = ExpressionConverter.Convert(__workflow_includeSources);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetStockFinancialDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetExchangesResponse> GetExchanges(Expression<Func<assetClassInput>> assetClass = null, Expression<Func<localeInput>> locale = null)
        {
            var __workflow_assetClass = WorkflowExpression.Compile(assetClass, nameof(assetClass), required: false);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: false);
            return new DeferredBodyAction<GetExchangesResponse>(() =>
            {
                var apiCallPath = "/v3/reference/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_assetClass != null)
                    callPayload.Queries["asset_class"] = ExpressionConverter.Convert(__workflow_assetClass);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                return new ApiConnectionAction<GetExchangesResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
