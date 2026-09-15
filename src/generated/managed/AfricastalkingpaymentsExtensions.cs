//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingpayments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingpaymentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2BResponse> MobileB2B(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodyproviderInput>> bodyprovider, Expression<Func<bodytransferTypeInput>> bodytransferType, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount, Expression<Func<string>> bodydestinationChannel, Expression<Func<string>> bodydestinationAccount)
        {
            var apiCallPath = "/mobile/b2b/request";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["productName"] = CSharpExpressionConverter.ConvertToken(bodyproductName);
            bodypropCount++;
            body["provider"] = CSharpExpressionConverter.Convert(bodyprovider);
            bodypropCount++;
            body["transferType"] = CSharpExpressionConverter.Convert(bodytransferType);
            bodypropCount++;
            body["currencyCode"] = CSharpExpressionConverter.Convert(bodycurrencyCode);
            bodypropCount++;
            body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
            bodypropCount++;
            body["destinationChannel"] = CSharpExpressionConverter.ConvertToken(bodydestinationChannel);
            bodypropCount++;
            body["destinationAccount"] = CSharpExpressionConverter.ConvertToken(bodydestinationAccount);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MobileB2BResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletBalanceResponse> FetchWalletBalance(Expression<Func<string>> username)
        {
            var apiCallPath = "/query/wallet/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            return new ApiConnectionAction<FetchWalletBalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<WalletTransferResponse> WalletTransfer(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<int>> bodytargetProductCode, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount)
        {
            var apiCallPath = "/transfer/wallet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["productName"] = CSharpExpressionConverter.ConvertToken(bodyproductName);
            bodypropCount++;
            body["targetProductCode"] = CSharpExpressionConverter.ConvertToken(bodytargetProductCode);
            bodypropCount++;
            body["currencyCode"] = CSharpExpressionConverter.Convert(bodycurrencyCode);
            bodypropCount++;
            body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WalletTransferResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletTransactionsResponse> FetchWalletTransactions(Expression<Func<string>> username, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/query/wallet/fetch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["pageNumber"] = CSharpExpressionConverter.ConvertO(pageNumber);
            callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            return new ApiConnectionAction<FetchWalletTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<TopUpStashResponse> TopUpStash(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount)
        {
            var apiCallPath = "/topup/stash";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["productName"] = CSharpExpressionConverter.ConvertToken(bodyproductName);
            bodypropCount++;
            body["currencyCode"] = CSharpExpressionConverter.Convert(bodycurrencyCode);
            bodypropCount++;
            body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TopUpStashResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchProductTransactionsResponse> FetchProductTransactions(Expression<Func<string>> username, Expression<Func<string>> productName, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<categoryInput>> category = null, Expression<Func<providerInput>> provider = null, Expression<Func<statusInput>> status = null, Expression<Func<sourceInput>> source = null, Expression<Func<destinationInput>> destination = null, Expression<Func<string>> providerChannel = null)
        {
            var apiCallPath = "/query/transaction/fetch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["productName"] = CSharpExpressionConverter.ConvertO(productName);
            callPayload.Queries["pageNumber"] = CSharpExpressionConverter.ConvertO(pageNumber);
            callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (category != null)
                callPayload.Queries["category"] = CSharpExpressionConverter.Convert(category);
            if (provider != null)
                callPayload.Queries["provider"] = CSharpExpressionConverter.Convert(provider);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.Convert(status);
            if (source != null)
                callPayload.Queries["source"] = CSharpExpressionConverter.Convert(source);
            if (destination != null)
                callPayload.Queries["destination"] = CSharpExpressionConverter.Convert(destination);
            if (providerChannel != null)
                callPayload.Queries["providerChannel"] = CSharpExpressionConverter.ConvertO(providerChannel);
            return new ApiConnectionAction<FetchProductTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileCheckoutResponse> MobileCheckout(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<string>> bodyphoneNumber, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount, Expression<Func<string>> bodyproviderChannel = null)
        {
            var apiCallPath = "/mobile/checkout/request";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["productName"] = CSharpExpressionConverter.ConvertToken(bodyproductName);
            if (bodyproviderChannel != null)
            {
                body["providerChannel"] = CSharpExpressionConverter.ConvertToken(bodyproviderChannel);
                bodypropCount++;
            }

            bodypropCount++;
            body["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
            bodypropCount++;
            body["currencyCode"] = CSharpExpressionConverter.Convert(bodycurrencyCode);
            bodypropCount++;
            body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MobileCheckoutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2CResponse> MobileB2C(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients)
        {
            var apiCallPath = "/mobile/b2c/request";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["productName"] = CSharpExpressionConverter.ConvertToken(bodyproductName);
            bodypropCount++;
            body["recipients"] = CSharpExpressionConverter.ConvertToken(bodyrecipients);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MobileB2CResponse>(callPayload);
        }
    }

    public class AfricastalkingpaymentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class MobileB2BResponse
    {
        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionFee")]
        public string TransactionFee { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public enum bodyproviderInput
    {
        Mpesa,
        TigoTanzania,
        Athena
    }

    public enum bodytransferTypeInput
    {
        BusinessBuyGoods,
        BusinessPayBill,
        DisburseFundsToBusiness,
        BusinessToBusinessTransfer
    }

    public enum bodycurrencyCodeInput
    {
        KES,
        UGX,
        TZS,
        USD
    }

    public class FetchWalletBalanceResponse
    {
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class WalletTransferResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class FetchWalletTransactionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("responses")]
        public FetchWalletTransactionsResponseResponsesTypeItem[] Responses { get; set; }
    }

    public class FetchWalletTransactionsResponseResponsesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("transactionData")]
        public FetchWalletTransactionsResponseResponsesTypeItemTransactionDataType TransactionData { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class FetchWalletTransactionsResponseResponsesTypeItemTransactionDataType
    {
        [JsonProperty("requestMetadata")]
        public FetchWalletTransactionsResponseResponsesTypeItemTransactionDataTypeRequestMetadataType RequestMetadata { get; set; }

        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("destinationType")]
        public string DestinationType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("transactionFee")]
        public string TransactionFee { get; set; }

        [JsonProperty("providerRefId")]
        public string ProviderRefId { get; set; }

        [JsonProperty("providerMetadata")]
        public FetchWalletTransactionsResponseResponsesTypeItemTransactionDataTypeProviderMetadataType ProviderMetadata { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("transactionDate")]
        public string TransactionDate { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }

    public class FetchWalletTransactionsResponseResponsesTypeItemTransactionDataTypeRequestMetadataType
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class FetchWalletTransactionsResponseResponsesTypeItemTransactionDataTypeProviderMetadataType
    {
        [JsonProperty("recipientIsRegistered")]
        public string RecipientIsRegistered { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }
    }

    public class TopUpStashResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class FetchProductTransactionsResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("responses")]
        public FetchProductTransactionsResponseResponsesTypeItem[] Responses { get; set; }
    }

    public class FetchProductTransactionsResponseResponsesTypeItem
    {
        [JsonProperty("requestMetadata")]
        public FetchProductTransactionsResponseResponsesTypeItemRequestMetadataType RequestMetadata { get; set; }

        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("destinationType")]
        public string DestinationType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("transactionFee")]
        public string TransactionFee { get; set; }

        [JsonProperty("providerRefId")]
        public string ProviderRefId { get; set; }

        [JsonProperty("providerMetadata")]
        public FetchProductTransactionsResponseResponsesTypeItemProviderMetadataType ProviderMetadata { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("transactionDate")]
        public string TransactionDate { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }

    public class FetchProductTransactionsResponseResponsesTypeItemRequestMetadataType
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class FetchProductTransactionsResponseResponsesTypeItemProviderMetadataType
    {
        [JsonProperty("recipientIsRegistered")]
        public string RecipientIsRegistered { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }
    }

    public enum categoryInput
    {
        BankCheckout,
        CardCheckout,
        MobileCheckout,
        MobileC2B,
        MobileB2C,
        MobileB2B,
        BankTransfer,
        WalletTransfer,
        UserStashTopup
    }

    public enum providerInput
    {
        Mpesa,
        Segovia,
        Flutterwave,
        Admin,
        Athena
    }

    public enum statusInput
    {
        Success,
        Failed
    }

    public enum sourceInput
    {
        [EnumMember(Value = "phoneNumber")]
        PhoneNumber,
        BankAccount,
        Card,
        Wallet
    }

    public enum destinationInput
    {
        [EnumMember(Value = "phoneNumber")]
        PhoneNumber,
        BankAccount,
        Card,
        Wallet
    }

    public class MobileCheckoutResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class MobileB2CResponse
    {
        [JsonProperty("entries")]
        public MobileB2CResponseEntriesTypeItem[] Entries { get; set; }

        [JsonProperty("numQueued")]
        public int NumQueued { get; set; }

        [JsonProperty("totalTransactionFee")]
        public string TotalTransactionFee { get; set; }

        [JsonProperty("totalValue")]
        public string TotalValue { get; set; }
    }

    public class MobileB2CResponseEntriesTypeItem
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("transactionFee")]
        public string TransactionFee { get; set; }
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("currencyCode")]
        public bodyrecipientsInputItemCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("reason")]
        public bodyrecipientsInputItemReasonType Reason { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public enum bodyrecipientsInputItemCurrencyCodeType
    {
        KES,
        UGX,
        TZS,
        USD
    }

    public enum bodyrecipientsInputItemReasonType
    {
        SalaryPayment,
        SalaryPaymentWithWithdrawalChargePaid,
        BusinessPayment,
        BusinessPaymentWithWithdrawalChargePaid,
        PromotionPayment
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingpayments;

    public partial class WorkflowManagedActions
    {
        public AfricastalkingpaymentsActions Africastalkingpayments(string connectionId) => new AfricastalkingpaymentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AfricastalkingpaymentsTriggers Africastalkingpayments(string connectionId) => new AfricastalkingpaymentsTriggers(connectionId);
    }
}