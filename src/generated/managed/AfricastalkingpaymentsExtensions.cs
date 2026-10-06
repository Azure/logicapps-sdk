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
        public IBodyWorkflowAction<MobileB2BResponse> MobileB2B([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodyproviderInput> bodyprovider, [WorkflowExpression] Func<bodytransferTypeInput> bodytransferType, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodydestinationChannel, [WorkflowExpression] Func<string> bodydestinationAccount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mobile/b2b/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["productName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                bodypropCount++;
                body["provider"] = SourceExpressionConverter.Convert(bodyprovider);
                bodypropCount++;
                body["transferType"] = SourceExpressionConverter.Convert(bodytransferType);
                bodypropCount++;
                body["currencyCode"] = SourceExpressionConverter.Convert(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                bodypropCount++;
                body["destinationChannel"] = SourceExpressionConverter.ConvertToken(bodydestinationChannel);
                bodypropCount++;
                body["destinationAccount"] = SourceExpressionConverter.ConvertToken(bodydestinationAccount);
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
                return callPayload;
            }

            return new ApiConnectionAction<MobileB2BResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletBalanceResponse> FetchWalletBalance([WorkflowExpression] Func<string> username)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/wallet/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                return callPayload;
            }

            return new ApiConnectionAction<FetchWalletBalanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<WalletTransferResponse> WalletTransfer([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<int> bodytargetProductCode, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/transfer/wallet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["productName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                bodypropCount++;
                body["targetProductCode"] = SourceExpressionConverter.ConvertToken(bodytargetProductCode);
                bodypropCount++;
                body["currencyCode"] = SourceExpressionConverter.Convert(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
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
                return callPayload;
            }

            return new ApiConnectionAction<WalletTransferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletTransactionsResponse> FetchWalletTransactions([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> count, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/wallet/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<FetchWalletTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<TopUpStashResponse> TopUpStash([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/topup/stash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["productName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                bodypropCount++;
                body["currencyCode"] = SourceExpressionConverter.Convert(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
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
                return callPayload;
            }

            return new ApiConnectionAction<TopUpStashResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchProductTransactionsResponse> FetchProductTransactions([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> productName, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> count, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<categoryInput> category = null, [WorkflowExpression] Func<providerInput> provider = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<destinationInput> destination = null, [WorkflowExpression] Func<string> providerChannel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/transaction/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["productName"] = SourceExpressionConverter.ConvertO(productName);
                callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.Convert(category);
                if (provider != null)
                    callPayload.Queries["provider"] = SourceExpressionConverter.Convert(provider);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.Convert(source);
                if (destination != null)
                    callPayload.Queries["destination"] = SourceExpressionConverter.Convert(destination);
                if (providerChannel != null)
                    callPayload.Queries["providerChannel"] = SourceExpressionConverter.ConvertO(providerChannel);
                return callPayload;
            }

            return new ApiConnectionAction<FetchProductTransactionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileCheckoutResponse> MobileCheckout([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<string> bodyphoneNumber, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodyproviderChannel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mobile/checkout/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["productName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                if (bodyproviderChannel != null)
                {
                    body["providerChannel"] = SourceExpressionConverter.ConvertToken(bodyproviderChannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                bodypropCount++;
                body["currencyCode"] = SourceExpressionConverter.Convert(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
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
                return callPayload;
            }

            return new ApiConnectionAction<MobileCheckoutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2CResponse> MobileB2C([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mobile/b2c/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["productName"] = SourceExpressionConverter.ConvertToken(bodyproductName);
                bodypropCount++;
                body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MobileB2CResponse>(BuildSourceInput);
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