//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudmerchantser
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudmerchantserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudmerchantser")]
        public IBodyWorkflowAction<PaymentsApiDisbursementCollection, ApiConnectionActionConfiguration> ListDisbursements(Expression<Func<string>> paymentConfigurationId, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_paymentConfigurationId = WorkflowExpression.Compile(paymentConfigurationId, nameof(paymentConfigurationId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<PaymentsApiDisbursementCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/payments/v1/disbursements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["payment_configuration_id"] = ExpressionConverter.Convert(__workflow_paymentConfigurationId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<PaymentsApiDisbursementCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudmerchantser")]
        public IBodyWorkflowAction<PaymentsApiTransactionCollection, ApiConnectionActionConfiguration> ListDisbursementTransactions(Expression<Func<string>> paymentConfigurationId, Expression<Func<string>> disbursementId, Expression<Func<int>> page)
        {
            var __workflow_paymentConfigurationId = WorkflowExpression.Compile(paymentConfigurationId, nameof(paymentConfigurationId), required: true);
            var __workflow_disbursementId = WorkflowExpression.Compile(disbursementId, nameof(disbursementId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            return new DeferredBodyAction<PaymentsApiTransactionCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/v1/disbursements/{0}/transactions", __workflow_disbursementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["payment_configuration_id"] = ExpressionConverter.Convert(__workflow_paymentConfigurationId);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PaymentsApiTransactionCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudmerchantser")]
        public IBodyWorkflowAction<PaymentsApiTransaction, ApiConnectionActionConfiguration> GetTransaction(Expression<Func<string>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<PaymentsApiTransaction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/v1/transactions/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaymentsApiTransaction>(callPayload);
            });
        }
    }

    public class BlackbaudmerchantserTriggers([ConnectionName] string connectionId)
    {
    }

    public class PaymentsApiDisbursementCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PaymentsApiDisbursement[] Value { get; set; }
    }

    public class PaymentsApiDisbursement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PaymentsApiTransactionCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PaymentsApiTransaction[] Value { get; set; }
    }

    public class PaymentsApiTransaction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("additional_fee")]
        public int AdditionalFee { get; set; }

        [JsonProperty("application_fee")]
        public int ApplicationFee { get; set; }

        [JsonProperty("total_fees")]
        public int TotalFees { get; set; }

        [JsonProperty("net_amount")]
        public int NetAmount { get; set; }

        [JsonProperty("transaction_date")]
        public string TransactionDate { get; set; }

        [JsonProperty("transaction_type")]
        public PaymentsApiTransactionTransactionTypeType TransactionType { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("terminal_type")]
        public PaymentsApiTransactionTerminalTypeType TerminalType { get; set; }

        [JsonProperty("donor_ip_address")]
        public string DonorIPAddress { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("account_type")]
        public PaymentsApiTransactionAccountTypeType AccountType { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("credit_card")]
        public PaymentsApiCreditCardInfo CreditCard { get; set; }

        [JsonProperty("billing_info")]
        public PaymentsApiBillingInfo BillingInfo { get; set; }

        [JsonProperty("pay_pal_reference_id")]
        public string PayPalReferenceId { get; set; }

        [JsonProperty("reference_transaction_id")]
        public string ReferenceTransactionId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("authorization_code")]
        public string GatewayResultCode { get; set; }

        [JsonProperty("fraud_result")]
        public PaymentsApiFraudResult FraudResult { get; set; }

        [JsonProperty("pending_date")]
        public string PendingDate { get; set; }

        [JsonProperty("transaction_category")]
        public string TransactionCategory { get; set; }

        [JsonProperty("is_live")]
        public bool IsLive { get; set; }

        [JsonProperty("state")]
        public PaymentsApiTransactionStateType State { get; set; }

        [JsonProperty("disbursement_status")]
        public PaymentsApiTransactionDisbursementStatusType DisbursementStatus { get; set; }

        [JsonProperty("related_transactions")]
        public PaymentsApiRelatedTransaction[] RelatedTransactions { get; set; }

        [JsonProperty("gateway_result")]
        public PaymentsApiGatewayResult GatewayResult { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiTransactionTransactionTypeType
    {
        CardNotPresent,
        CardPresent,
        DirectDebit,
        TransactionBatch,
        DirectDebitBatch,
        OfflineBatch,
        Refund,
        DirectDebitRefund,
        ChargeBack,
        DirectDebitReturn
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiTransactionTerminalTypeType
    {
        Unknown,
        AutomatedDispensingMachine,
        SelfServiceTerminal,
        LimitedAmountTerminal,
        MobilePayDevice,
        ChipAndPIN,
        VerifoneP400
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiTransactionAccountTypeType
    {
        Checking,
        Savings,
        [EnumMember(Value = "Corporate checkings")]
        CorporateCheckings,
        [EnumMember(Value = "Corporate savings")]
        CorporateSavings
    }

    public class PaymentsApiCreditCardInfo
    {
        [JsonProperty("card_type")]
        public string Type { get; set; }

        [JsonProperty("exp_month")]
        public int ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpirationYear { get; set; }

        [JsonProperty("last_four")]
        public string LastFourDigits { get; set; }

        [JsonProperty("name")]
        public string CardholderName { get; set; }

        [JsonProperty("pay_pal_funding_source")]
        public PaymentsApiCreditCardInfoPayPalFundingSourceType PayPalFundingSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiCreditCardInfoPayPalFundingSourceType
    {
        Unknown,
        PayPal,
        Venmo
    }

    public class PaymentsApiBillingInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("post_code")]
        public string PostalCode { get; set; }
    }

    public class PaymentsApiFraudResult
    {
        [JsonProperty("result_code")]
        public PaymentsApiFraudResultResultCodeType ResultCode { get; set; }

        [JsonProperty("risk_score")]
        public int RiskScore { get; set; }

        [JsonProperty("risk_threshold")]
        public int RiskThreshold { get; set; }

        [JsonProperty("anonymous_proxy_result")]
        public PaymentsApiFraudResultAnonymousProxyResultType AnonymousProxyResult { get; set; }

        [JsonProperty("bin_and_ip_country_result")]
        public PaymentsApiFraudResultBinAndIPCountryResultType BinAndIPCountryResult { get; set; }

        [JsonProperty("high_risk_country_result")]
        public PaymentsApiFraudResultHighRiskCountryResultType HighRiskCountryResult { get; set; }

        [JsonProperty("velocity_result")]
        public PaymentsApiFraudResultVelocityResultType VelocityResult { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiFraudResultResultCodeType
    {
        NotProcessed,
        Passed,
        FailedProcessingError,
        FailedProfileSettings,
        MissingRequiredLicensekey,
        MissingRequiredField,
        NonRoutableIP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiFraudResultAnonymousProxyResultType
    {
        NotProcessed,
        Pass,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiFraudResultBinAndIPCountryResultType
    {
        NotProcessed,
        Pass,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiFraudResultHighRiskCountryResultType
    {
        NotProcessed,
        Pass,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiFraudResultVelocityResultType
    {
        NotProcessed,
        Pass,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiTransactionStateType
    {
        Unknown,
        Processed,
        Failed,
        Refunded,
        Pending,
        Authorized,
        Voided,
        Created
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiTransactionDisbursementStatusType
    {
        Disbursable,
        DoNotDisburse,
        Disbursed
    }

    public class PaymentsApiRelatedTransaction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("transaction_type")]
        public PaymentsApiRelatedTransactionTransactionTypeType TransactionType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentsApiRelatedTransactionTransactionTypeType
    {
        Refund,
        DirectDebitRefund,
        DirectDebitReturn,
        ChargeBack,
        ReverseChargeback,
        Adjustment
    }

    public class PaymentsApiGatewayResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudmerchantser;

    public partial class WorkflowManagedActions
    {
        public BlackbaudmerchantserActions Blackbaudmerchantser(string connectionId) => new BlackbaudmerchantserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudmerchantserTriggers Blackbaudmerchantser(string connectionId) => new BlackbaudmerchantserTriggers(connectionId);
    }
}