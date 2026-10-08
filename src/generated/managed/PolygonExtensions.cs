//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Polygon
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolygonActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetDailyOpenClose))]
        public IBodyWorkflowAction<GetDailyOpenCloseResponse> GetDailyOpenClose([WorkflowExpression] Func<string> stocksTicker, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<bool> adjusted = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDailyOpenCloseResponse> __BuildGetDailyOpenClose(WorkflowExpression<string> stocksTicker, WorkflowExpression<string> date, WorkflowExpression<bool> adjusted = null)
        {
            WorkflowExpression.Validate(stocksTicker, nameof(stocksTicker), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: true);
            WorkflowExpression.Validate(adjusted, nameof(adjusted), required: false);
            return new DeferredBodyAction<GetDailyOpenCloseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/open-close/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(stocksTicker, 1), ExpressionConverter.ConvertWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (adjusted != null)
                    callPayload.Queries["adjusted"] = ExpressionConverter.Convert(adjusted);
                return new ApiConnectionAction<GetDailyOpenCloseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetTickers))]
        public IBodyWorkflowAction<GetTickersResponse> GetTickers([WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<marketInput> market = null, [WorkflowExpression] Func<string> exchange = null, [WorkflowExpression] Func<string> cusip = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTickersResponse> __BuildGetTickers(WorkflowExpression<string> ticker = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<marketInput> market = null, WorkflowExpression<string> exchange = null, WorkflowExpression<string> cusip = null, WorkflowExpression<string> cik = null, WorkflowExpression<string> date = null, WorkflowExpression<string> search = null, WorkflowExpression<bool> active = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<sortInput> sort = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(ticker, nameof(ticker), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(market, nameof(market), required: false);
            WorkflowExpression.Validate(exchange, nameof(exchange), required: false);
            WorkflowExpression.Validate(cusip, nameof(cusip), required: false);
            WorkflowExpression.Validate(cik, nameof(cik), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(active, nameof(active), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetTickersResponse>(() =>
            {
                var apiCallPath = "/v3/reference/tickers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticker != null)
                    callPayload.Queries["ticker"] = ExpressionConverter.Convert(ticker);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (market != null)
                    callPayload.Queries["market"] = ExpressionConverter.Convert(market);
                if (exchange != null)
                    callPayload.Queries["exchange"] = ExpressionConverter.Convert(exchange);
                if (cusip != null)
                    callPayload.Queries["cusip"] = ExpressionConverter.Convert(cusip);
                if (cik != null)
                    callPayload.Queries["cik"] = ExpressionConverter.Convert(cik);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(active);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<GetTickersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetTickerDetails))]
        public IBodyWorkflowAction<GetTickerDetailsResponse> GetTickerDetails([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> date = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTickerDetailsResponse> __BuildGetTickerDetails(WorkflowExpression<string> ticker, WorkflowExpression<string> date = null)
        {
            WorkflowExpression.Validate(ticker, nameof(ticker), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            return new DeferredBodyAction<GetTickerDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/reference/tickers/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticker, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                return new ApiConnectionAction<GetTickerDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetTickerEvents))]
        public IBodyWorkflowAction<GetTickerEventsResponse> GetTickerEvents([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> types = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTickerEventsResponse> __BuildGetTickerEvents(WorkflowExpression<string> id, WorkflowExpression<string> types = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(types, nameof(types), required: false);
            return new DeferredBodyAction<GetTickerEventsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vX/reference/tickers/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(types);
                return new ApiConnectionAction<GetTickerEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetStockSplits))]
        public IBodyWorkflowAction<GetStockSplitsResponse> GetStockSplits([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> executionDate = null, [WorkflowExpression] Func<bool> reverseSplit = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<sortInput> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStockSplitsResponse> __BuildGetStockSplits(WorkflowExpression<string> ticker, WorkflowExpression<string> executionDate = null, WorkflowExpression<bool> reverseSplit = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<int> limit = null, WorkflowExpression<sortInput> sort = null)
        {
            WorkflowExpression.Validate(ticker, nameof(ticker), required: true);
            WorkflowExpression.Validate(executionDate, nameof(executionDate), required: false);
            WorkflowExpression.Validate(reverseSplit, nameof(reverseSplit), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetStockSplitsResponse>(() =>
            {
                var apiCallPath = "/v3/reference/splits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = ExpressionConverter.Convert(ticker);
                if (executionDate != null)
                    callPayload.Queries["execution_date"] = ExpressionConverter.Convert(executionDate);
                if (reverseSplit != null)
                    callPayload.Queries["reverse_split"] = ExpressionConverter.Convert(reverseSplit);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<GetStockSplitsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetStockDividends))]
        public IBodyWorkflowAction<GetStockDividendsResponse> GetStockDividends([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> exDividendDate = null, [WorkflowExpression] Func<string> recordDate = null, [WorkflowExpression] Func<string> declarationDate = null, [WorkflowExpression] Func<string> payDate = null, [WorkflowExpression] Func<frequencyInput> frequency = null, [WorkflowExpression] Func<double> cashAmount = null, [WorkflowExpression] Func<dividendTypeInput> dividendType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStockDividendsResponse> __BuildGetStockDividends(WorkflowExpression<string> ticker, WorkflowExpression<string> exDividendDate = null, WorkflowExpression<string> recordDate = null, WorkflowExpression<string> declarationDate = null, WorkflowExpression<string> payDate = null, WorkflowExpression<frequencyInput> frequency = null, WorkflowExpression<double> cashAmount = null, WorkflowExpression<dividendTypeInput> dividendType = null)
        {
            WorkflowExpression.Validate(ticker, nameof(ticker), required: true);
            WorkflowExpression.Validate(exDividendDate, nameof(exDividendDate), required: false);
            WorkflowExpression.Validate(recordDate, nameof(recordDate), required: false);
            WorkflowExpression.Validate(declarationDate, nameof(declarationDate), required: false);
            WorkflowExpression.Validate(payDate, nameof(payDate), required: false);
            WorkflowExpression.Validate(frequency, nameof(frequency), required: false);
            WorkflowExpression.Validate(cashAmount, nameof(cashAmount), required: false);
            WorkflowExpression.Validate(dividendType, nameof(dividendType), required: false);
            return new DeferredBodyAction<GetStockDividendsResponse>(() =>
            {
                var apiCallPath = "/v3/reference/dividends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = ExpressionConverter.Convert(ticker);
                if (exDividendDate != null)
                    callPayload.Queries["ex_dividend_date"] = ExpressionConverter.Convert(exDividendDate);
                if (recordDate != null)
                    callPayload.Queries["record_date"] = ExpressionConverter.Convert(recordDate);
                if (declarationDate != null)
                    callPayload.Queries["declaration_date"] = ExpressionConverter.Convert(declarationDate);
                if (payDate != null)
                    callPayload.Queries["pay_date"] = ExpressionConverter.Convert(payDate);
                if (frequency != null)
                    callPayload.Queries["frequency"] = ExpressionConverter.Convert(frequency);
                if (cashAmount != null)
                    callPayload.Queries["cash_amount"] = ExpressionConverter.Convert(cashAmount);
                if (dividendType != null)
                    callPayload.Queries["dividend_type"] = ExpressionConverter.Convert(dividendType);
                return new ApiConnectionAction<GetStockDividendsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetStockFinancialDetails))]
        public IBodyWorkflowAction<GetStockFinancialDetailsResponse> GetStockFinancialDetails([WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<string> sic = null, [WorkflowExpression] Func<string> filingDate = null, [WorkflowExpression] Func<string> periodOfReportDate = null, [WorkflowExpression] Func<timeframeInput> timeframe = null, [WorkflowExpression] Func<bool> includeSources = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<sortInput> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStockFinancialDetailsResponse> __BuildGetStockFinancialDetails(WorkflowExpression<string> ticker = null, WorkflowExpression<string> cik = null, WorkflowExpression<string> companyName = null, WorkflowExpression<string> sic = null, WorkflowExpression<string> filingDate = null, WorkflowExpression<string> periodOfReportDate = null, WorkflowExpression<timeframeInput> timeframe = null, WorkflowExpression<bool> includeSources = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<int> limit = null, WorkflowExpression<sortInput> sort = null)
        {
            WorkflowExpression.Validate(ticker, nameof(ticker), required: false);
            WorkflowExpression.Validate(cik, nameof(cik), required: false);
            WorkflowExpression.Validate(companyName, nameof(companyName), required: false);
            WorkflowExpression.Validate(sic, nameof(sic), required: false);
            WorkflowExpression.Validate(filingDate, nameof(filingDate), required: false);
            WorkflowExpression.Validate(periodOfReportDate, nameof(periodOfReportDate), required: false);
            WorkflowExpression.Validate(timeframe, nameof(timeframe), required: false);
            WorkflowExpression.Validate(includeSources, nameof(includeSources), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetStockFinancialDetailsResponse>(() =>
            {
                var apiCallPath = "/vX/reference/financials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticker != null)
                    callPayload.Queries["ticker"] = ExpressionConverter.Convert(ticker);
                if (cik != null)
                    callPayload.Queries["cik"] = ExpressionConverter.Convert(cik);
                if (companyName != null)
                    callPayload.Queries["company_name"] = ExpressionConverter.Convert(companyName);
                if (sic != null)
                    callPayload.Queries["sic"] = ExpressionConverter.Convert(sic);
                if (filingDate != null)
                    callPayload.Queries["filing_date"] = ExpressionConverter.Convert(filingDate);
                if (periodOfReportDate != null)
                    callPayload.Queries["period_of_report_date"] = ExpressionConverter.Convert(periodOfReportDate);
                if (timeframe != null)
                    callPayload.Queries["timeframe"] = ExpressionConverter.Convert(timeframe);
                if (includeSources != null)
                    callPayload.Queries["include_sources"] = ExpressionConverter.Convert(includeSources);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<GetStockFinancialDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchanges))]
        public IBodyWorkflowAction<GetExchangesResponse> GetExchanges([WorkflowExpression] Func<assetClassInput> assetClass = null, [WorkflowExpression] Func<localeInput> locale = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExchangesResponse> __BuildGetExchanges(WorkflowExpression<assetClassInput> assetClass = null, WorkflowExpression<localeInput> locale = null)
        {
            WorkflowExpression.Validate(assetClass, nameof(assetClass), required: false);
            WorkflowExpression.Validate(locale, nameof(locale), required: false);
            return new DeferredBodyAction<GetExchangesResponse>(() =>
            {
                var apiCallPath = "/v3/reference/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (assetClass != null)
                    callPayload.Queries["asset_class"] = ExpressionConverter.Convert(assetClass);
                if (locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
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