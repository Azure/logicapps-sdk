//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clicksendpostcards
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClicksendpostcardsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendpostcards")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMedia))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMedia([WorkflowExpression] Func<string> bodycontent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMedia(WorkflowExpression<string> bodycontent)
        {
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["convert"] = Convert.ToString("postcard");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendpostcards")]
        [WorkflowExpressionFactory(nameof(__BuildSendPostcard))]
        public IBodyWorkflowAction<SendPostcardResponse> SendPostcard([WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients, [WorkflowExpression] Func<string[]> bodyfileUrls)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendPostcardResponse> __BuildSendPostcard(WorkflowExpression<bodyrecipientsInputItem[]> bodyrecipients, WorkflowExpression<string[]> bodyfileUrls)
        {
            WorkflowExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            WorkflowExpression.Validate(bodyfileUrls, nameof(bodyfileUrls), required: true);
            return new DeferredBodyAction<SendPostcardResponse>(() =>
            {
                var apiCallPath = "/post/postcards/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                body["source"] = "MSPowerAutomate-pc";
                bodypropCount++;
                bodypropCount++;
                body["file_urls"] = ExpressionConverter.ConvertO(bodyfileUrls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendPostcardResponse>(callPayload);
            });
        }
    }

    public class ClicksendpostcardsTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadMediaResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public UploadMediaResponseDataType Data { get; set; }
    }

    public class UploadMediaResponseDataType
    {
        [JsonProperty("upload_id")]
        public int UploadId { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("date_delete")]
        public int DateDelete { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("_url")]
        public string Url { get; set; }
    }

    public class SendPostcardResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SendPostcardResponseDataType Data { get; set; }
    }

    public class SendPostcardResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("recipients")]
        public SendPostcardResponseDataTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("_currency")]
        public SendPostcardResponseDataTypeCurrencyType Currency { get; set; }
    }

    public class SendPostcardResponseDataTypeRecipientsTypeItem
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("subaccount_id")]
        public int SubaccountId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("address_name")]
        public string AddressName { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_postal_code")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("return_address_id")]
        public int ReturnAddressId { get; set; }

        [JsonProperty("schedule")]
        public int Schedule { get; set; }

        [JsonProperty("post_price")]
        public string PostPrice { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("_file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("_return_address")]
        public SendPostcardResponseDataTypeRecipientsTypeItemReturnAddressType ReturnAddress { get; set; }

        [JsonProperty("_api_username")]
        public string ApiUsername { get; set; }
    }

    public class SendPostcardResponseDataTypeRecipientsTypeItemReturnAddressType
    {
        [JsonProperty("return_address_id")]
        public int ReturnAddressId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("address_name")]
        public string AddressName { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_postal_code")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }
    }

    public class SendPostcardResponseDataTypeCurrencyType
    {
        [JsonProperty("currency_name_short")]
        public string CurrencyNameShort { get; set; }

        [JsonProperty("currency_prefix_d")]
        public string CurrencyPrefixD { get; set; }

        [JsonProperty("currency_prefix_c")]
        public string CurrencyPrefixC { get; set; }

        [JsonProperty("currency_name_long")]
        public string CurrencyNameLong { get; set; }
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("address_name")]
        public string AddressName { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_postal_code")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("return_address_id")]
        public int ReturnAddressId { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clicksendpostcards;

    public partial class WorkflowManagedActions
    {
        public ClicksendpostcardsActions Clicksendpostcards(string connectionId) => new ClicksendpostcardsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClicksendpostcardsTriggers Clicksendpostcards(string connectionId) => new ClicksendpostcardsTriggers(connectionId);
    }
}