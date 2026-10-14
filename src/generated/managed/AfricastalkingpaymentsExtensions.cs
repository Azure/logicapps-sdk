//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingpayments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AfricastalkingpaymentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<MobileB2BResponse> MobileB2B(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodyproviderInput>> bodyprovider, Expression<Func<bodytransferTypeInput>> bodytransferType, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount, Expression<Func<string>> bodydestinationChannel, Expression<Func<string>> bodydestinationAccount)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_bodyprovider = bodyprovider == null ? null : WorkflowExpression.Compile(bodyprovider);
            WorkflowExpression.Validate(__workflow_bodyprovider, nameof(bodyprovider), required: true);
            var __workflow_bodytransferType = bodytransferType == null ? null : WorkflowExpression.Compile(bodytransferType);
            WorkflowExpression.Validate(__workflow_bodytransferType, nameof(bodytransferType), required: true);
            var __workflow_bodycurrencyCode = bodycurrencyCode == null ? null : WorkflowExpression.Compile(bodycurrencyCode);
            WorkflowExpression.Validate(__workflow_bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyamount = bodyamount == null ? null : WorkflowExpression.Compile(bodyamount);
            WorkflowExpression.Validate(__workflow_bodyamount, nameof(bodyamount), required: true);
            var __workflow_bodydestinationChannel = bodydestinationChannel == null ? null : WorkflowExpression.Compile(bodydestinationChannel);
            WorkflowExpression.Validate(__workflow_bodydestinationChannel, nameof(bodydestinationChannel), required: true);
            var __workflow_bodydestinationAccount = bodydestinationAccount == null ? null : WorkflowExpression.Compile(bodydestinationAccount);
            WorkflowExpression.Validate(__workflow_bodydestinationAccount, nameof(bodydestinationAccount), required: true);
            return new DeferredBodyAction<MobileB2BResponse>(() =>
            {
                var apiCallPath = "/mobile/b2b/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                bodypropCount++;
                body["provider"] = ExpressionConverter.ConvertO(__workflow_bodyprovider);
                bodypropCount++;
                body["transferType"] = ExpressionConverter.ConvertO(__workflow_bodytransferType);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                bodypropCount++;
                body["destinationChannel"] = ExpressionConverter.ConvertO(__workflow_bodydestinationChannel);
                bodypropCount++;
                body["destinationAccount"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAccount);
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
        public IBodyWorkflowAction<FetchWalletBalanceResponse> FetchWalletBalance(Expression<Func<string>> username)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            return new DeferredBodyAction<FetchWalletBalanceResponse>(() =>
            {
                var apiCallPath = "/query/wallet/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                return new ApiConnectionAction<FetchWalletBalanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingpayments")]
        public IBodyWorkflowAction<WalletTransferResponse> WalletTransfer(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<int>> bodytargetProductCode, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_bodytargetProductCode = bodytargetProductCode == null ? null : WorkflowExpression.Compile(bodytargetProductCode);
            WorkflowExpression.Validate(__workflow_bodytargetProductCode, nameof(bodytargetProductCode), required: true);
            var __workflow_bodycurrencyCode = bodycurrencyCode == null ? null : WorkflowExpression.Compile(bodycurrencyCode);
            WorkflowExpression.Validate(__workflow_bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyamount = bodyamount == null ? null : WorkflowExpression.Compile(bodyamount);
            WorkflowExpression.Validate(__workflow_bodyamount, nameof(bodyamount), required: true);
            return new DeferredBodyAction<WalletTransferResponse>(() =>
            {
                var apiCallPath = "/transfer/wallet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                bodypropCount++;
                body["targetProductCode"] = ExpressionConverter.ConvertO(__workflow_bodytargetProductCode);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
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
        public IBodyWorkflowAction<FetchWalletTransactionsResponse> FetchWalletTransactions(Expression<Func<string>> username, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_pageNumber = pageNumber == null ? null : WorkflowExpression.Compile(pageNumber);
            WorkflowExpression.Validate(__workflow_pageNumber, nameof(pageNumber), required: true);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: true);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<FetchWalletTransactionsResponse>(() =>
            {
                var apiCallPath = "/query/wallet/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
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
        public IBodyWorkflowAction<TopUpStashResponse> TopUpStash(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_bodycurrencyCode = bodycurrencyCode == null ? null : WorkflowExpression.Compile(bodycurrencyCode);
            WorkflowExpression.Validate(__workflow_bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyamount = bodyamount == null ? null : WorkflowExpression.Compile(bodyamount);
            WorkflowExpression.Validate(__workflow_bodyamount, nameof(bodyamount), required: true);
            return new DeferredBodyAction<TopUpStashResponse>(() =>
            {
                var apiCallPath = "/topup/stash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
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
        public IBodyWorkflowAction<FetchProductTransactionsResponse> FetchProductTransactions(Expression<Func<string>> username, Expression<Func<string>> productName, Expression<Func<int>> pageNumber, Expression<Func<int>> count, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<categoryInput>> category = null, Expression<Func<providerInput>> provider = null, Expression<Func<statusInput>> status = null, Expression<Func<sourceInput>> source = null, Expression<Func<destinationInput>> destination = null, Expression<Func<string>> providerChannel = null)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_productName = productName == null ? null : WorkflowExpression.Compile(productName);
            WorkflowExpression.Validate(__workflow_productName, nameof(productName), required: true);
            var __workflow_pageNumber = pageNumber == null ? null : WorkflowExpression.Compile(pageNumber);
            WorkflowExpression.Validate(__workflow_pageNumber, nameof(pageNumber), required: true);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: true);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            var __workflow_category = category == null ? null : WorkflowExpression.Compile(category);
            WorkflowExpression.Validate(__workflow_category, nameof(category), required: false);
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: false);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: false);
            var __workflow_providerChannel = providerChannel == null ? null : WorkflowExpression.Compile(providerChannel);
            WorkflowExpression.Validate(__workflow_providerChannel, nameof(providerChannel), required: false);
            return new DeferredBodyAction<FetchProductTransactionsResponse>(() =>
            {
                var apiCallPath = "/query/transaction/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
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
        public IBodyWorkflowAction<MobileCheckoutResponse> MobileCheckout(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<string>> bodyphoneNumber, Expression<Func<bodycurrencyCodeInput>> bodycurrencyCode, Expression<Func<double>> bodyamount, Expression<Func<string>> bodyproviderChannel = null)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_bodyphoneNumber = bodyphoneNumber == null ? null : WorkflowExpression.Compile(bodyphoneNumber);
            WorkflowExpression.Validate(__workflow_bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            var __workflow_bodycurrencyCode = bodycurrencyCode == null ? null : WorkflowExpression.Compile(bodycurrencyCode);
            WorkflowExpression.Validate(__workflow_bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyamount = bodyamount == null ? null : WorkflowExpression.Compile(bodyamount);
            WorkflowExpression.Validate(__workflow_bodyamount, nameof(bodyamount), required: true);
            var __workflow_bodyproviderChannel = bodyproviderChannel == null ? null : WorkflowExpression.Compile(bodyproviderChannel);
            WorkflowExpression.Validate(__workflow_bodyproviderChannel, nameof(bodyproviderChannel), required: false);
            return new DeferredBodyAction<MobileCheckoutResponse>(() =>
            {
                var apiCallPath = "/mobile/checkout/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                if (__workflow_bodyproviderChannel != null)
                {
                    body["providerChannel"] = ExpressionConverter.ConvertO(__workflow_bodyproviderChannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
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
        public IBodyWorkflowAction<MobileB2CResponse> MobileB2C(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyproductName, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients)
        {
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyproductName = bodyproductName == null ? null : WorkflowExpression.Compile(bodyproductName);
            WorkflowExpression.Validate(__workflow_bodyproductName, nameof(bodyproductName), required: true);
            var __workflow_bodyrecipients = bodyrecipients == null ? null : WorkflowExpression.Compile(bodyrecipients);
            WorkflowExpression.Validate(__workflow_bodyrecipients, nameof(bodyrecipients), required: true);
            return new DeferredBodyAction<MobileB2CResponse>(() =>
            {
                var apiCallPath = "/mobile/b2c/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["productName"] = ExpressionConverter.ConvertO(__workflow_bodyproductName);
                bodypropCount++;
                body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
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
