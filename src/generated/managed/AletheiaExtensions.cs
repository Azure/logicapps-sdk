//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aletheia
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AletheiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EntityFilingsResponseItem[], ApiConnectionActionConfiguration> EntityFilings(Expression<Func<string>> id, Expression<Func<string>> filing = null, Expression<Func<int>> before = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filing = WorkflowExpression.Compile(filing, nameof(filing), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<EntityFilingsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityFilings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_filing != null)
                    callPayload.Queries["filing"] = ExpressionConverter.Convert(__workflow_filing);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                return new ApiConnectionAction<EntityFilingsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<OpenForm4Response, ApiConnectionActionConfiguration> OpenForm4(Expression<Func<string>> filingurl)
        {
            var __workflow_filingurl = WorkflowExpression.Compile(filingurl, nameof(filingurl), required: true);
            return new DeferredBodyAction<OpenForm4Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/OpenForm4";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filingurl"] = ExpressionConverter.Convert(__workflow_filingurl);
                return new ApiConnectionAction<OpenForm4Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<OpenCommonFinancialsResponse, ApiConnectionActionConfiguration> OpenCommonFinancials(Expression<Func<string>> filingurl)
        {
            var __workflow_filingurl = WorkflowExpression.Compile(filingurl, nameof(filingurl), required: true);
            return new DeferredBodyAction<OpenCommonFinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/OpenCommonFinancials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filingurl"] = ExpressionConverter.Convert(__workflow_filingurl);
                return new ApiConnectionAction<OpenCommonFinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<SearchEntitiesResponseItem[], ApiConnectionActionConfiguration> SearchEntities(Expression<Func<string>> term, Expression<Func<int>> top = null)
        {
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<SearchEntitiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchEntities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                callPayload.Queries["top"] = Convert.ToString(12);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<SearchEntitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetEntityResponse, ApiConnectionActionConfiguration> GetEntity(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetEntityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetFilingResponse, ApiConnectionActionConfiguration> GetFiling(Expression<Func<string>> id = null, Expression<Func<string>> url = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: false);
            return new DeferredBodyAction<GetFilingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetFiling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                return new ApiConnectionAction<GetFilingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<LatestTransactionsResponseItem[], ApiConnectionActionConfiguration> LatestTransactions(Expression<Func<string>> issuer = null, Expression<Func<int>> owner = null, Expression<Func<int>> top = null, Expression<Func<string>> before = null, Expression<Func<int>> securitytype = null, Expression<Func<int>> transactiontype = null, Expression<Func<bool>> cascade = null)
        {
            var __workflow_issuer = WorkflowExpression.Compile(issuer, nameof(issuer), required: false);
            var __workflow_owner = WorkflowExpression.Compile(owner, nameof(owner), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_securitytype = WorkflowExpression.Compile(securitytype, nameof(securitytype), required: false);
            var __workflow_transactiontype = WorkflowExpression.Compile(transactiontype, nameof(transactiontype), required: false);
            var __workflow_cascade = WorkflowExpression.Compile(cascade, nameof(cascade), required: false);
            return new DeferredBodyAction<LatestTransactionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LatestTransactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_issuer != null)
                    callPayload.Queries["issuer"] = ExpressionConverter.Convert(__workflow_issuer);
                if (__workflow_owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(__workflow_owner);
                callPayload.Queries["top"] = Convert.ToString(20);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_securitytype != null)
                    callPayload.Queries["securitytype"] = ExpressionConverter.Convert(__workflow_securitytype);
                if (__workflow_transactiontype != null)
                    callPayload.Queries["transactiontype"] = ExpressionConverter.Convert(__workflow_transactiontype);
                if (__workflow_cascade != null)
                    callPayload.Queries["cascade"] = ExpressionConverter.Convert(__workflow_cascade);
                return new ApiConnectionAction<LatestTransactionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<AffiliatedOwnersResponseItem[], ApiConnectionActionConfiguration> AffiliatedOwners(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AffiliatedOwnersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AffiliatedOwners";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<AffiliatedOwnersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<GetCommonFinancialsResponse, ApiConnectionActionConfiguration> GetCommonFinancials(Expression<Func<string>> id, Expression<Func<periodInput>> period = null, Expression<Func<string>> before = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<GetCommonFinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CommonFinancials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_period != null)
                    callPayload.Queries["period"] = ExpressionConverter.Convert(__workflow_period);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                return new ApiConnectionAction<GetCommonFinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<FinancialFactTrendResponseItem[], ApiConnectionActionConfiguration> FinancialFactTrend(Expression<Func<string>> id, Expression<Func<int>> label, Expression<Func<int>> period = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_label = WorkflowExpression.Compile(label, nameof(label), required: true);
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<FinancialFactTrendResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialFactTrend";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["label"] = ExpressionConverter.Convert(__workflow_label);
                if (__workflow_period != null)
                    callPayload.Queries["period"] = ExpressionConverter.Convert(__workflow_period);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                return new ApiConnectionAction<FinancialFactTrendResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<SearchEarningsCallsResponseItem[], ApiConnectionActionConfiguration> SearchEarningsCalls(Expression<Func<string>> company = null, Expression<Func<int>> year = null, Expression<Func<string>> quarter = null, Expression<Func<int>> top = null)
        {
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_quarter = WorkflowExpression.Compile(quarter, nameof(quarter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<SearchEarningsCallsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchEarningsCalls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_quarter != null)
                    callPayload.Queries["quarter"] = ExpressionConverter.Convert(__workflow_quarter);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<SearchEarningsCallsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EarningsCallResponse, ApiConnectionActionConfiguration> EarningsCall(Expression<Func<string>> company, Expression<Func<int>> year = null, Expression<Func<string>> quarter = null, Expression<Func<int>> begin = null, Expression<Func<int>> end = null)
        {
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_quarter = WorkflowExpression.Compile(quarter, nameof(quarter), required: false);
            var __workflow_begin = WorkflowExpression.Compile(begin, nameof(begin), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<EarningsCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EarningsCall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_quarter != null)
                    callPayload.Queries["quarter"] = ExpressionConverter.Convert(__workflow_quarter);
                if (__workflow_begin != null)
                    callPayload.Queries["begin"] = ExpressionConverter.Convert(__workflow_begin);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<EarningsCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<EarningsCallHighlightsResponseItem[], ApiConnectionActionConfiguration> EarningsCallHighlights(Expression<Func<string>> company, Expression<Func<int>> year, Expression<Func<string>> quarter, Expression<Func<int>> category = null, Expression<Func<int>> top = null)
        {
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_quarter = WorkflowExpression.Compile(quarter, nameof(quarter), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<EarningsCallHighlightsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EarningsCallHighlights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                callPayload.Queries["quarter"] = ExpressionConverter.Convert(__workflow_quarter);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<EarningsCallHighlightsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<CryptoQuoteResponse, ApiConnectionActionConfiguration> CryptoQuote(Expression<Func<string>> symbol)
        {
            var __workflow_symbol = WorkflowExpression.Compile(symbol, nameof(symbol), required: true);
            return new DeferredBodyAction<CryptoQuoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Crypto";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["symbol"] = ExpressionConverter.Convert(__workflow_symbol);
                return new ApiConnectionAction<CryptoQuoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aletheia")]
        public IBodyWorkflowAction<StockDataV2Response, ApiConnectionActionConfiguration> StockData(Expression<Func<string>> symbol, Expression<Func<string>> fields = null)
        {
            var __workflow_symbol = WorkflowExpression.Compile(symbol, nameof(symbol), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<StockDataV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/StockData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["symbol"] = ExpressionConverter.Convert(__workflow_symbol);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Headers["Accept-Version"] = Convert.ToString(2);
                return new ApiConnectionAction<StockDataV2Response>(callPayload);
            });
        }
    }

    public class AletheiaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewFilings(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/SubscribeToNewFilingsWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["endpoint"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> InsiderTrading(Expression<Func<string>> bodyissuer = null, Expression<Func<int>> bodyowner = null, Expression<Func<bodytransactionTypeInput>> bodytransactionType = null, Expression<Func<bodysecurityTypeInput>> bodysecurityType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyissuer = WorkflowExpression.Compile(bodyissuer, nameof(bodyissuer), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodytransactionType = WorkflowExpression.Compile(bodytransactionType, nameof(bodytransactionType), required: false);
            var __workflow_bodysecurityType = WorkflowExpression.Compile(bodysecurityType, nameof(bodysecurityType), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/SubscribeToInsiderTradingWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["endpoint"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyissuer != null)
                {
                    body["issuer"] = ExpressionConverter.ConvertO(__workflow_bodyissuer);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionType != null)
                {
                    body["transactionType"] = ExpressionConverter.ConvertO(__workflow_bodytransactionType);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityType != null)
                {
                    body["securityType"] = ExpressionConverter.ConvertO(__workflow_bodysecurityType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
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
        _0 = 0,
        _1 = 1
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

    public enum bodytransactionTypeInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _16 = 16,
        _17 = 17,
        _18 = 18,
        _19 = 19
    }

    public enum bodysecurityTypeInput
    {
        _0 = 0,
        _1 = 1
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