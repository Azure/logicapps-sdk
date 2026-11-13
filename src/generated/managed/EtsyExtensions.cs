//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Etsy
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EtsyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "etsy")]
        public IBodyWorkflowAction<Payments, ApiConnectionActionConfiguration> PaymentsGet(Expression<Func<int>> shopId, Expression<Func<string>> paymentIds)
        {
            var __workflow_shopId = WorkflowExpression.Compile(shopId, nameof(shopId), required: true);
            var __workflow_paymentIds = WorkflowExpression.Compile(paymentIds, nameof(paymentIds), required: true);
            return new DeferredBodyAction<Payments, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/shops/{0}/payments", __workflow_shopId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["payment-ids"] = ExpressionConverter.Convert(__workflow_paymentIds);
                return new ApiConnectionAction<Payments>(callPayload);
            });
        }
    }

    public class EtsyTriggers([ConnectionName] string connectionId)
    {
    }

    public class Payments
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public Payment[] Results { get; set; }
    }

    public class Payment
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("buyer_user_id")]
        public int BuyerUserId { get; set; }

        [JsonProperty("shop_id")]
        public int ShopId { get; set; }

        [JsonProperty("receipt_id")]
        public int ReceiptId { get; set; }

        [JsonProperty("amount_gross")]
        public Money AmountGross { get; set; }

        [JsonProperty("amount_fees")]
        public Money AmountFees { get; set; }

        [JsonProperty("amount_net")]
        public Money AmountNet { get; set; }

        [JsonProperty("posted_gross")]
        public Money PostedGross { get; set; }

        [JsonProperty("posted_fees")]
        public Money PostedFees { get; set; }

        [JsonProperty("posted_net")]
        public Money PostedNet { get; set; }

        [JsonProperty("adjusted_gross")]
        public Money AdjustedGross { get; set; }

        [JsonProperty("adjusted_fees")]
        public Money AdjustedFees { get; set; }

        [JsonProperty("adjusted_net")]
        public Money AdjustedNet { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("shop_currency")]
        public string ShopCurrency { get; set; }

        [JsonProperty("buyer_currency")]
        public string BuyerCurrency { get; set; }

        [JsonProperty("shipping_user_id")]
        public int UserShippingId { get; set; }

        [JsonProperty("shipping_address_id")]
        public int ShippingAddressId { get; set; }

        [JsonProperty("billing_address_id")]
        public int BillingAddressId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipped_timestamp")]
        public int ShippedTimestamp { get; set; }

        [JsonProperty("create_timestamp")]
        public int CreatedTimestamp { get; set; }

        [JsonProperty("update_timestamp")]
        public int UpdateTimestamp { get; set; }

        [JsonProperty("payment_adjustments")]
        public PaymentAdjustment[] PaymentAdjustments { get; set; }
    }

    public class Money
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("divisor")]
        public int Divisor { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public class PaymentAdjustment
    {
        [JsonProperty("payment_adjustment_id")]
        public int PaymentAdjustmentId { get; set; }

        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("reason_code")]
        public string ReasonCode { get; set; }

        [JsonProperty("buyer_total_adjustment_amount")]
        public int TotalAdjustmentAmount { get; set; }

        [JsonProperty("shop_total_adjustment_amount")]
        public int ShopTotalAdjustmentAmount { get; set; }

        [JsonProperty("total_fee_adjustment_amount")]
        public int TotalFeeAdjustmentAmount { get; set; }

        [JsonProperty("create_timestamp")]
        public int CreatedTimestamp { get; set; }

        [JsonProperty("update_timestamp")]
        public int UpdateTimestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Etsy;

    public partial class WorkflowManagedActions
    {
        public EtsyActions Etsy(string connectionId) => new EtsyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EtsyTriggers Etsy(string connectionId) => new EtsyTriggers(connectionId);
    }
}