//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingpayments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingpaymentsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildMobileB2B))]
        public IBodyWorkflowAction<MobileB2BResponse> MobileB2B([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodyproviderInput> bodyprovider, [WorkflowExpression] Func<bodytransferTypeInput> bodytransferType, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodydestinationChannel, [WorkflowExpression] Func<string> bodydestinationAccount)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MobileB2BResponse> __BuildMobileB2B(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyproductName, WorkflowExpression<bodyproviderInput> bodyprovider, WorkflowExpression<bodytransferTypeInput> bodytransferType, WorkflowExpression<bodycurrencyCodeInput> bodycurrencyCode, WorkflowExpression<double> bodyamount, WorkflowExpression<string> bodydestinationChannel, WorkflowExpression<string> bodydestinationAccount)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            WorkflowExpression.Validate(bodyprovider, nameof(bodyprovider), required: true);
            WorkflowExpression.Validate(bodytransferType, nameof(bodytransferType), required: true);
            WorkflowExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: true);
            WorkflowExpression.Validate(bodydestinationChannel, nameof(bodydestinationChannel), required: true);
            WorkflowExpression.Validate(bodydestinationAccount, nameof(bodydestinationAccount), required: true);
            return new DeferredBodyAction<MobileB2BResponse>(() =>
            {
                var apiCallPath = "/mobile/b2b/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(bodyproductName);
                bodypropCount++;
                body["provider"] = ExpressionConverter.ConvertO(bodyprovider);
                bodypropCount++;
                body["transferType"] = ExpressionConverter.ConvertO(bodytransferType);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                bodypropCount++;
                body["destinationChannel"] = ExpressionConverter.ConvertO(bodydestinationChannel);
                bodypropCount++;
                body["destinationAccount"] = ExpressionConverter.ConvertO(bodydestinationAccount);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildFetchWalletBalance))]
        public IBodyWorkflowAction<FetchWalletBalanceResponse> FetchWalletBalance([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchWalletBalanceResponse> __BuildFetchWalletBalance(WorkflowExpression<string> username)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<FetchWalletBalanceResponse>(() =>
            {
                var apiCallPath = "/query/wallet/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                return new ApiConnectionAction<FetchWalletBalanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildWalletTransfer))]
        public IBodyWorkflowAction<WalletTransferResponse> WalletTransfer([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<int> bodytargetProductCode, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WalletTransferResponse> __BuildWalletTransfer(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyproductName, WorkflowExpression<int> bodytargetProductCode, WorkflowExpression<bodycurrencyCodeInput> bodycurrencyCode, WorkflowExpression<double> bodyamount)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            WorkflowExpression.Validate(bodytargetProductCode, nameof(bodytargetProductCode), required: true);
            WorkflowExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: true);
            return new DeferredBodyAction<WalletTransferResponse>(() =>
            {
                var apiCallPath = "/transfer/wallet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(bodyproductName);
                bodypropCount++;
                body["targetProductCode"] = ExpressionConverter.ConvertO(bodytargetProductCode);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildFetchWalletTransactions))]
        public IBodyWorkflowAction<FetchWalletTransactionsResponse> FetchWalletTransactions([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> count, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchWalletTransactionsResponse> __BuildFetchWalletTransactions(WorkflowExpression<string> username, WorkflowExpression<int> pageNumber, WorkflowExpression<int> count, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            WorkflowExpression.Validate(count, nameof(count), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<FetchWalletTransactionsResponse>(() =>
            {
                var apiCallPath = "/query/wallet/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(pageNumber);
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                return new ApiConnectionAction<FetchWalletTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildTopUpStash))]
        public IBodyWorkflowAction<TopUpStashResponse> TopUpStash([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TopUpStashResponse> __BuildTopUpStash(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyproductName, WorkflowExpression<bodycurrencyCodeInput> bodycurrencyCode, WorkflowExpression<double> bodyamount)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            WorkflowExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: true);
            return new DeferredBodyAction<TopUpStashResponse>(() =>
            {
                var apiCallPath = "/topup/stash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(bodyproductName);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildFetchProductTransactions))]
        public IBodyWorkflowAction<FetchProductTransactionsResponse> FetchProductTransactions([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> productName, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> count, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<categoryInput> category = null, [WorkflowExpression] Func<providerInput> provider = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<destinationInput> destination = null, [WorkflowExpression] Func<string> providerChannel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchProductTransactionsResponse> __BuildFetchProductTransactions(WorkflowExpression<string> username, WorkflowExpression<string> productName, WorkflowExpression<int> pageNumber, WorkflowExpression<int> count, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<categoryInput> category = null, WorkflowExpression<providerInput> provider = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<sourceInput> source = null, WorkflowExpression<destinationInput> destination = null, WorkflowExpression<string> providerChannel = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(productName, nameof(productName), required: true);
            WorkflowExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            WorkflowExpression.Validate(count, nameof(count), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(provider, nameof(provider), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(destination, nameof(destination), required: false);
            WorkflowExpression.Validate(providerChannel, nameof(providerChannel), required: false);
            return new DeferredBodyAction<FetchProductTransactionsResponse>(() =>
            {
                var apiCallPath = "/query/transaction/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["productName"] = ExpressionConverter.Convert(productName);
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(pageNumber);
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (provider != null)
                    callPayload.Queries["provider"] = ExpressionConverter.Convert(provider);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (destination != null)
                    callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                if (providerChannel != null)
                    callPayload.Queries["providerChannel"] = ExpressionConverter.Convert(providerChannel);
                return new ApiConnectionAction<FetchProductTransactionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildMobileCheckout))]
        public IBodyWorkflowAction<MobileCheckoutResponse> MobileCheckout([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<string> bodyphoneNumber, [WorkflowExpression] Func<bodycurrencyCodeInput> bodycurrencyCode, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodyproviderChannel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MobileCheckoutResponse> __BuildMobileCheckout(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyproductName, WorkflowExpression<string> bodyphoneNumber, WorkflowExpression<bodycurrencyCodeInput> bodycurrencyCode, WorkflowExpression<double> bodyamount, WorkflowExpression<string> bodyproviderChannel = null)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            WorkflowExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: true);
            WorkflowExpression.Validate(bodyproviderChannel, nameof(bodyproviderChannel), required: false);
            return new DeferredBodyAction<MobileCheckoutResponse>(() =>
            {
                var apiCallPath = "/mobile/checkout/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(bodyproductName);
                if (bodyproviderChannel != null)
                {
                    body["providerChannel"] = ExpressionConverter.ConvertO(bodyproviderChannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        [WorkflowExpressionFactory(nameof(__BuildMobileB2C))]
        public IBodyWorkflowAction<MobileB2CResponse> MobileB2C([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyproductName, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MobileB2CResponse> __BuildMobileB2C(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyproductName, WorkflowExpression<bodyrecipientsInputItem[]> bodyrecipients)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyproductName, nameof(bodyproductName), required: true);
            WorkflowExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            return new DeferredBodyAction<MobileB2CResponse>(() =>
            {
                var apiCallPath = "/mobile/b2c/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(bodyproductName);
                bodypropCount++;
                body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyproviderInput
    {
        Mpesa,
        TigoTanzania,
        Athena
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytransferTypeInput
    {
        BusinessBuyGoods,
        BusinessPayBill,
        DisburseFundsToBusiness,
        BusinessToBusinessTransfer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum providerInput
    {
        Mpesa,
        Segovia,
        Flutterwave,
        Admin,
        Athena
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Success,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sourceInput
    {
        [EnumMember(Value = "phoneNumber")]
        PhoneNumber,
        BankAccount,
        Card,
        Wallet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecipientsInputItemCurrencyCodeType
    {
        KES,
        UGX,
        TZS,
        USD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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