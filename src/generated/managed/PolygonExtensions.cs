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
        public IBodyWorkflowAction<GetDailyOpenCloseResponse> GetDailyOpenClose([WorkflowExpression] Func<string> stocksTicker, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<bool> adjusted = null)
        {
            SourceExpression.Validate(stocksTicker, nameof(stocksTicker), required: true);
            SourceExpression.Validate(date, nameof(date), required: true);
            SourceExpression.Validate(adjusted, nameof(adjusted), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/open-close/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stocksTicker, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (adjusted != null)
                    callPayload.Queries["adjusted"] = SourceExpressionConverter.ConvertO(adjusted);
                return callPayload;
            }

            return new ApiConnectionAction<GetDailyOpenCloseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickersResponse> GetTickers([WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<marketInput> market = null, [WorkflowExpression] Func<string> exchange = null, [WorkflowExpression] Func<string> cusip = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(ticker, nameof(ticker), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(market, nameof(market), required: false);
            SourceExpression.Validate(exchange, nameof(exchange), required: false);
            SourceExpression.Validate(cusip, nameof(cusip), required: false);
            SourceExpression.Validate(cik, nameof(cik), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(active, nameof(active), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/reference/tickers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticker != null)
                    callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (market != null)
                    callPayload.Queries["market"] = SourceExpressionConverter.Convert(market);
                if (exchange != null)
                    callPayload.Queries["exchange"] = SourceExpressionConverter.ConvertO(exchange);
                if (cusip != null)
                    callPayload.Queries["cusip"] = SourceExpressionConverter.ConvertO(cusip);
                if (cik != null)
                    callPayload.Queries["cik"] = SourceExpressionConverter.ConvertO(cik);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetTickersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerDetailsResponse> GetTickerDetails([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(ticker, nameof(ticker), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/reference/tickers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticker, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<GetTickerDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetTickerEventsResponse> GetTickerEvents([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> types = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(types, nameof(types), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/vX/reference/tickers/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (types != null)
                    callPayload.Queries["types"] = SourceExpressionConverter.ConvertO(types);
                return callPayload;
            }

            return new ApiConnectionAction<GetTickerEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockSplitsResponse> GetStockSplits([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> executionDate = null, [WorkflowExpression] Func<bool> reverseSplit = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<sortInput> sort = null)
        {
            SourceExpression.Validate(ticker, nameof(ticker), required: true);
            SourceExpression.Validate(executionDate, nameof(executionDate), required: false);
            SourceExpression.Validate(reverseSplit, nameof(reverseSplit), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/reference/splits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (executionDate != null)
                    callPayload.Queries["execution_date"] = SourceExpressionConverter.ConvertO(executionDate);
                if (reverseSplit != null)
                    callPayload.Queries["reverse_split"] = SourceExpressionConverter.ConvertO(reverseSplit);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                return callPayload;
            }

            return new ApiConnectionAction<GetStockSplitsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockDividendsResponse> GetStockDividends([WorkflowExpression] Func<string> ticker, [WorkflowExpression] Func<string> exDividendDate = null, [WorkflowExpression] Func<string> recordDate = null, [WorkflowExpression] Func<string> declarationDate = null, [WorkflowExpression] Func<string> payDate = null, [WorkflowExpression] Func<frequencyInput> frequency = null, [WorkflowExpression] Func<double> cashAmount = null, [WorkflowExpression] Func<dividendTypeInput> dividendType = null)
        {
            SourceExpression.Validate(ticker, nameof(ticker), required: true);
            SourceExpression.Validate(exDividendDate, nameof(exDividendDate), required: false);
            SourceExpression.Validate(recordDate, nameof(recordDate), required: false);
            SourceExpression.Validate(declarationDate, nameof(declarationDate), required: false);
            SourceExpression.Validate(payDate, nameof(payDate), required: false);
            SourceExpression.Validate(frequency, nameof(frequency), required: false);
            SourceExpression.Validate(cashAmount, nameof(cashAmount), required: false);
            SourceExpression.Validate(dividendType, nameof(dividendType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/reference/dividends";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (exDividendDate != null)
                    callPayload.Queries["ex_dividend_date"] = SourceExpressionConverter.ConvertO(exDividendDate);
                if (recordDate != null)
                    callPayload.Queries["record_date"] = SourceExpressionConverter.ConvertO(recordDate);
                if (declarationDate != null)
                    callPayload.Queries["declaration_date"] = SourceExpressionConverter.ConvertO(declarationDate);
                if (payDate != null)
                    callPayload.Queries["pay_date"] = SourceExpressionConverter.ConvertO(payDate);
                if (frequency != null)
                    callPayload.Queries["frequency"] = SourceExpressionConverter.Convert(frequency);
                if (cashAmount != null)
                    callPayload.Queries["cash_amount"] = SourceExpressionConverter.ConvertO(cashAmount);
                if (dividendType != null)
                    callPayload.Queries["dividend_type"] = SourceExpressionConverter.Convert(dividendType);
                return callPayload;
            }

            return new ApiConnectionAction<GetStockDividendsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetStockFinancialDetailsResponse> GetStockFinancialDetails([WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<string> sic = null, [WorkflowExpression] Func<string> filingDate = null, [WorkflowExpression] Func<string> periodOfReportDate = null, [WorkflowExpression] Func<timeframeInput> timeframe = null, [WorkflowExpression] Func<bool> includeSources = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<sortInput> sort = null)
        {
            SourceExpression.Validate(ticker, nameof(ticker), required: false);
            SourceExpression.Validate(cik, nameof(cik), required: false);
            SourceExpression.Validate(companyName, nameof(companyName), required: false);
            SourceExpression.Validate(sic, nameof(sic), required: false);
            SourceExpression.Validate(filingDate, nameof(filingDate), required: false);
            SourceExpression.Validate(periodOfReportDate, nameof(periodOfReportDate), required: false);
            SourceExpression.Validate(timeframe, nameof(timeframe), required: false);
            SourceExpression.Validate(includeSources, nameof(includeSources), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/vX/reference/financials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticker != null)
                    callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (cik != null)
                    callPayload.Queries["cik"] = SourceExpressionConverter.ConvertO(cik);
                if (companyName != null)
                    callPayload.Queries["company_name"] = SourceExpressionConverter.ConvertO(companyName);
                if (sic != null)
                    callPayload.Queries["sic"] = SourceExpressionConverter.ConvertO(sic);
                if (filingDate != null)
                    callPayload.Queries["filing_date"] = SourceExpressionConverter.ConvertO(filingDate);
                if (periodOfReportDate != null)
                    callPayload.Queries["period_of_report_date"] = SourceExpressionConverter.ConvertO(periodOfReportDate);
                if (timeframe != null)
                    callPayload.Queries["timeframe"] = SourceExpressionConverter.Convert(timeframe);
                if (includeSources != null)
                    callPayload.Queries["include_sources"] = SourceExpressionConverter.ConvertO(includeSources);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                return callPayload;
            }

            return new ApiConnectionAction<GetStockFinancialDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polygon")]
        public IBodyWorkflowAction<GetExchangesResponse> GetExchanges([WorkflowExpression] Func<assetClassInput> assetClass = null, [WorkflowExpression] Func<localeInput> locale = null)
        {
            SourceExpression.Validate(assetClass, nameof(assetClass), required: false);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/reference/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (assetClass != null)
                    callPayload.Queries["asset_class"] = SourceExpressionConverter.Convert(assetClass);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.Convert(locale);
                return callPayload;
            }

            return new ApiConnectionAction<GetExchangesResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _12 = 12
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