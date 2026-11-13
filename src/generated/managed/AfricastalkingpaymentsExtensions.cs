//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingpayments
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingpaymentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2BResponse, ApiConnectionActionConfiguration> MobileB2B(Expression<Func<MobileB2BBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MobileB2BResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mobile/b2b/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MobileB2BResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletBalanceResponse, ApiConnectionActionConfiguration> FetchWalletBalance(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredBodyAction<FetchWalletBalanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/wallet/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<FetchWalletBalanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<WalletTransferResponse, ApiConnectionActionConfiguration> WalletTransfer(Expression<Func<WalletTransferBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WalletTransferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/transfer/wallet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WalletTransferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchWalletTransactionsResponse, ApiConnectionActionConfiguration> FetchWalletTransactions(Expression<Func<string>> userName, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<FetchWalletTransactionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/wallet/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<FetchWalletTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<TopUpStashResponse, ApiConnectionActionConfiguration> TopUpStash(Expression<Func<TopUpStashBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TopUpStashResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/topup/stash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TopUpStashResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<FetchProductTransactionsResponse, ApiConnectionActionConfiguration> FetchProductTransactions(Expression<Func<string>> userName, Expression<Func<string>> productName, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<CategoryInput>> category = null, Expression<Func<ProviderInput>> provider = null, Expression<Func<StatusInput>> status = null, Expression<Func<SourceInput>> source = null, Expression<Func<DestinationInput>> destination = null, Expression<Func<string>> providerChannel = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_productName = WorkflowExpression.Compile(productName, nameof(productName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_providerChannel = WorkflowExpression.Compile(providerChannel, nameof(providerChannel), required: false);
            return new DeferredBodyAction<FetchProductTransactionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/transaction/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Queries["productName"] = ExpressionConverter.Convert(__workflow_productName);
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_provider != null)
                    callPayload.Queries["provider"] = ExpressionConverter.Convert(__workflow_provider);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_destination != null)
                    callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_providerChannel != null)
                    callPayload.Queries["providerChannel"] = ExpressionConverter.Convert(__workflow_providerChannel);
                return new ApiConnectionAction<FetchProductTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileCheckoutResponse, ApiConnectionActionConfiguration> MobileCheckout(Expression<Func<MobileCheckoutBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MobileCheckoutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mobile/checkout/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MobileCheckoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2CResponse, ApiConnectionActionConfiguration> MobileB2C(Expression<Func<MobileB2CBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MobileB2CResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mobile/b2c/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MobileB2CResponse>(callPayload);
            });
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

    public class MobileB2BBodyInput
    {
        public MobileB2BBodyInput(string userName, string productName, BodyInputProviderType provider, BodyInputTransferTypeType transferType, MobileB2BBodyInputCurrencyCodeType currencyCode, double amount, string destinationChannel, string destinationAccount)
        {
            this.UserName = userName;
            this.ProductName = productName;
            this.Provider = provider;
            this.TransferType = transferType;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
            this.DestinationChannel = destinationChannel;
            this.DestinationAccount = destinationAccount;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("productName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }

        [JsonProperty("provider", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputProviderType Provider { get; set; }

        [JsonProperty("transferType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTransferTypeType TransferType { get; set; }

        [JsonProperty("currencyCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public MobileB2BBodyInputCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("destinationChannel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationChannel { get; set; }

        [JsonProperty("destinationAccount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationAccount { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Metadata { get; set; } = JToken.Parse("{}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputProviderType
    {
        Mpesa,
        TigoTanzania,
        Athena
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTransferTypeType
    {
        BusinessBuyGoods,
        BusinessPayBill,
        DisburseFundsToBusiness,
        BusinessToBusinessTransfer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MobileB2BBodyInputCurrencyCodeType
    {
        [EnumMember(Value = "KES")]
        Kes,
        [EnumMember(Value = "UGX")]
        Ugx,
        [EnumMember(Value = "NGN")]
        Ngn,
        [EnumMember(Value = "USD")]
        Usd,
        [EnumMember(Value = "TZS")]
        Tzs
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

    public class WalletTransferBodyInput
    {
        public WalletTransferBodyInput(string userName, string productName, int targetProductCode, MobileCheckoutBodyInputCurrencyCodeType currencyCode, double amount)
        {
            this.UserName = userName;
            this.ProductName = productName;
            this.TargetProductCode = targetProductCode;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("productName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }

        [JsonProperty("targetProductCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TargetProductCode { get; set; }

        [JsonProperty("currencyCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public MobileCheckoutBodyInputCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Metadata { get; set; } = JToken.Parse("{}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MobileCheckoutBodyInputCurrencyCodeType
    {
        [EnumMember(Value = "KES")]
        Kes,
        [EnumMember(Value = "UGX")]
        Ugx,
        [EnumMember(Value = "TZS")]
        Tzs,
        [EnumMember(Value = "USD")]
        Usd
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

    public class TopUpStashBodyInput
    {
        public TopUpStashBodyInput(string userName, string productName, MobileCheckoutBodyInputCurrencyCodeType currencyCode, double amount)
        {
            this.UserName = userName;
            this.ProductName = productName;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("productName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }

        [JsonProperty("currencyCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public MobileCheckoutBodyInputCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Metadata { get; set; } = JToken.Parse("{}");
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProviderInput
    {
        Mpesa,
        Segovia,
        Flutterwave,
        Admin,
        Athena
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInput
    {
        Success,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourceInput
    {
        [EnumMember(Value = "phoneNumber")]
        PhoneNumber,
        BankAccount,
        Card,
        Wallet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DestinationInput
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

    public class MobileCheckoutBodyInput
    {
        public MobileCheckoutBodyInput(string userName, string productName, string phoneNumber, MobileCheckoutBodyInputCurrencyCodeType currencyCode, double amount)
        {
            this.UserName = userName;
            this.ProductName = productName;
            this.PhoneNumber = phoneNumber;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("productName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }

        [JsonProperty("currencyCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public MobileCheckoutBodyInputCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Metadata { get; set; } = JToken.Parse("{}");
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

    public class MobileB2CBodyInput
    {
        public MobileB2CBodyInput(string userName, string productName, BodyInputRecipientsTypeItem[] recipients)
        {
            this.UserName = userName;
            this.ProductName = productName;
            this.Recipients = recipients;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("productName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProductName { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecipientsTypeItem[] Recipients { get; set; }
    }

    public class BodyInputRecipientsTypeItem
    {
        public BodyInputRecipientsTypeItem(string phoneNumber, BodyInputRecipientsTypeItemCurrencyCodeType currencyCode, double amount)
        {
            this.PhoneNumber = phoneNumber;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
        }

        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }

        [JsonProperty("currencyCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecipientsTypeItemCurrencyCodeType CurrencyCode { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("providerChannel")]
        public string ProviderChannel { get; set; }

        [JsonProperty("reason")]
        public BodyInputRecipientsTypeItemReasonType? Reason { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Metadata { get; set; } = JToken.Parse("{}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRecipientsTypeItemCurrencyCodeType
    {
        [EnumMember(Value = "KES")]
        Kes,
        [EnumMember(Value = "UGX")]
        Ugx,
        [EnumMember(Value = "TZS")]
        Tzs,
        [EnumMember(Value = "USD")]
        Usd
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRecipientsTypeItemReasonType
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