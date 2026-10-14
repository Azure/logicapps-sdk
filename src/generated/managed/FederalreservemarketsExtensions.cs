//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Federalreservemarkets
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class FederalreservemarketsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreservemarkets")]
        public IBodyWorkflowAction<GetTreasurySecuritiesOperationsByStatusResponse> GetTreasurySecuritiesOperationsByStatus(Expression<Func<operationInput>> operation, Expression<Func<statusInput>> status, Expression<Func<includeInput>> include, Expression<Func<formatInput>> format)
        {
            var __workflow_operation = operation == null ? null : WorkflowExpression.Compile(operation);
            WorkflowExpression.Validate(__workflow_operation, nameof(operation), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: true);
            var __workflow_include = include == null ? null : WorkflowExpression.Compile(include);
            WorkflowExpression.Validate(__workflow_include, nameof(include), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: true);
            return new DeferredBodyAction<GetTreasurySecuritiesOperationsByStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tsy/{0}/{1}/{2}/latest.{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_operation, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_status, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_include, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTreasurySecuritiesOperationsByStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreservemarkets")]
        public IBodyWorkflowAction<GetSecuritiesLendingOperationsResponse> GetSecuritiesLendingOperations(Expression<Func<operationInput>> operation, Expression<Func<includeInput>> include, Expression<Func<formatInput>> format)
        {
            var __workflow_operation = operation == null ? null : WorkflowExpression.Compile(operation);
            WorkflowExpression.Validate(__workflow_operation, nameof(operation), required: true);
            var __workflow_include = include == null ? null : WorkflowExpression.Compile(include);
            WorkflowExpression.Validate(__workflow_include, nameof(include), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: true);
            return new DeferredBodyAction<GetSecuritiesLendingOperationsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/seclending/{0}/results/{1}/latest.{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_operation, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_include, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSecuritiesLendingOperationsResponse>(callPayload);
            });
        }
    }

    public class FederalreservemarketsTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetTreasurySecuritiesOperationsByStatusResponse
    {
        [JsonProperty("treasury")]
        public GetTreasurySecuritiesOperationsByStatusResponseTreasuryType Treasury { get; set; }
    }

    public class GetTreasurySecuritiesOperationsByStatusResponseTreasuryType
    {
        [JsonProperty("auctions")]
        public TreasurySecuritiesOperation[] Auctions { get; set; }
    }

    public class TreasurySecuritiesOperation
    {
        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("auctionStatus")]
        public string AuctionStatus { get; set; }

        [JsonProperty("operationType")]
        public string OperationType { get; set; }

        [JsonProperty("operationDate")]
        public string OperationDate { get; set; }

        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }

        [JsonProperty("maturityRangeStart")]
        public string MaturityRangeStart { get; set; }

        [JsonProperty("maturityRangeEnd")]
        public string MaturityRangeEnd { get; set; }

        [JsonProperty("operationDirection")]
        public string OperationDirection { get; set; }

        [JsonProperty("auctionMethod")]
        public string AuctionMethod { get; set; }

        [JsonProperty("releaseTime")]
        public string ReleaseTime { get; set; }

        [JsonProperty("closeTime")]
        public string CloseTime { get; set; }

        [JsonProperty("totalParAmtSubmitted")]
        public string TotalParAmtSubmitted { get; set; }

        [JsonProperty("totalParAmtAccepted")]
        public string TotalParAmtAccepted { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("details")]
        public TreasurySecuritiesOperationDetailsTypeItem[] Details { get; set; }
    }

    public class TreasurySecuritiesOperationDetailsTypeItem
    {
        [JsonProperty("inclusionIndicator")]
        public string InclusionIndicator { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("securityDescription")]
        public string SecurityDescription { get; set; }

        [JsonProperty("parAmountAccepted")]
        public string ParAmountAccepted { get; set; }

        [JsonProperty("weightedAvgAccptPrice")]
        public string WeightedAvgAccptPrice { get; set; }

        [JsonProperty("leastFavoriteAccptPrice")]
        public string LeastFavoriteAccptPrice { get; set; }

        [JsonProperty("percentAllottedleastFavoriteAccptPrice")]
        public string PercentAllottedleastFavoriteAccptPrice { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum operationInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "seclending")]
        Seclending,
        [EnumMember(Value = "extensions")]
        Extensions
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "announcements")]
        Announcements,
        [EnumMember(Value = "results")]
        Results,
        [EnumMember(Value = "operations")]
        Operations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum includeInput
    {
        [EnumMember(Value = "summary")]
        Summary,
        [EnumMember(Value = "details")]
        Details
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xlsx")]
        Xlsx
    }

    public class GetSecuritiesLendingOperationsResponse
    {
        [JsonProperty("seclending")]
        public GetSecuritiesLendingOperationsResponseSeclendingType Seclending { get; set; }
    }

    public class GetSecuritiesLendingOperationsResponseSeclendingType
    {
        [JsonProperty("operations")]
        public SecuritiesLendingOperation[] Operations { get; set; }
    }

    public class SecuritiesLendingOperation
    {
        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("auctionStatus")]
        public string AuctionStatus { get; set; }

        [JsonProperty("operationType")]
        public string OperationType { get; set; }

        [JsonProperty("operationDate")]
        public string OperationDate { get; set; }

        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("releaseTime")]
        public string ReleaseTime { get; set; }

        [JsonProperty("closeTime")]
        public string CloseTime { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("totalParAmtSubmitted")]
        public int TotalParAmtSubmitted { get; set; }

        [JsonProperty("totalParAmtAccepted")]
        public int TotalParAmtAccepted { get; set; }

        [JsonProperty("totalParAmtExtended")]
        public int TotalParAmtExtended { get; set; }

        [JsonProperty("details")]
        public SecuritiesLendingOperationDetailsTypeItem[] Details { get; set; }
    }

    public class SecuritiesLendingOperationDetailsTypeItem
    {
        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("securityDescription")]
        public string SecurityDescription { get; set; }

        [JsonProperty("parAmtSubmitted")]
        public int ParAmtSubmitted { get; set; }

        [JsonProperty("parAmtAccepted")]
        public int ParAmtAccepted { get; set; }

        [JsonProperty("parAmtExtended")]
        public int ParAmtExtended { get; set; }

        [JsonProperty("weightedAverageRate")]
        public double WeightedAverageRate { get; set; }

        [JsonProperty("somaHoldings")]
        public int SomaHoldings { get; set; }

        [JsonProperty("theoAvailToBorrow")]
        public int TheoAvailToBorrow { get; set; }

        [JsonProperty("actualAvailToBorrow")]
        public int ActualAvailToBorrow { get; set; }

        [JsonProperty("outstandingLoans")]
        public int OutstandingLoans { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Federalreservemarkets;

    public partial class WorkflowManagedActions
    {
        public FederalreservemarketsActions Federalreservemarkets(string connectionId) => new FederalreservemarketsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FederalreservemarketsTriggers Federalreservemarkets(string connectionId) => new FederalreservemarketsTriggers(connectionId);
    }
}
