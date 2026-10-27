//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clicksendsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClicksendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SmsSendResponse, ApiConnectionActionConfiguration> SmsSend(Expression<Func<SmsSendInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SmsSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SmsSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<CreateListResponse, ApiConnectionActionConfiguration> CreateList(Expression<Func<CreateListInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<GetContactListsResponse, ApiConnectionActionConfiguration> GetContactLists(Expression<Func<int>> page = null, Expression<Func<int>> limit = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetContactListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GetContactListsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendVoiceResponse, ApiConnectionActionConfiguration> SendVoice(Expression<Func<SendVoiceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendVoiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/voice/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendVoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<DeleteListResponse, ApiConnectionActionConfiguration> DeleteList(Expression<Func<int>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<DeleteListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<CreateListContactResponse, ApiConnectionActionConfiguration> CreateListContact(Expression<Func<int>> listId, Expression<Func<CreateListContactInput>> body)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateListContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/contacts", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateListContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<ViewListContactsResponse, ApiConnectionActionConfiguration> ViewListContacts(Expression<Func<int>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<ViewListContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/contacts", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<DeleteListContactResponse, ApiConnectionActionConfiguration> DeleteListContact(Expression<Func<int>> listId, Expression<Func<int>> contactId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<DeleteListContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/contacts/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteListContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendMmsResponse, ApiConnectionActionConfiguration> SendMms(Expression<Func<SendMmsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendFaxResponse, ApiConnectionActionConfiguration> SendFax(Expression<Func<SendFaxInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendFaxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fax/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendFaxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMedia(Expression<Func<convertInput>> convert, Expression<Func<UploadMediaInput>> body)
        {
            var __workflow_convert = WorkflowExpression.Compile(convert, nameof(convert), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["convert"] = ExpressionConverter.Convert(__workflow_convert);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SearchContactListResponse, ApiConnectionActionConfiguration> SearchContactList(Expression<Func<string>> q)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<SearchContactListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search/contacts-lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<SearchContactListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendLetterResponse, ApiConnectionActionConfiguration> SendLetter(Expression<Func<SendLetterInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendLetterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/post/letters/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendLetterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendPostcardResponse, ApiConnectionActionConfiguration> SendPostcard(Expression<Func<SendPostcardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendPostcardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/post/postcards/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendPostcardResponse>(callPayload);
            });
        }
    }

    public class ClicksendsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SmsInboundAutomation(Expression<Func<SmsInboundAutomationInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/ms-flow/automations/sms/inbound";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SmsSendResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SmsSendResponseDataType Data { get; set; }
    }

    public class SmsSendResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("messages")]
        public SmsSendResponseDataTypeMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("_currency")]
        public SmsSendResponseDataTypeCurrencyType Currency { get; set; }
    }

    public class SmsSendResponseDataTypeMessagesTypeItem
    {
        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("message_parts")]
        public int MessageParts { get; set; }

        [JsonProperty("message_price")]
        public string MessagePrice { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("subaccount_id")]
        public int SubaccountId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SmsSendResponseDataTypeCurrencyType
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

    public class SmsSendInput
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public SmsSendInputMessagesTypeItem[] Messages { get; set; }
    }

    public class SmsSendInputMessagesTypeItem
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "MSPowerAutomate";
    }

    public class CreateListResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public CreateListResponseDataType Data { get; set; }
    }

    public class CreateListResponseDataType
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("list_email_id")]
        public string ListEmailId { get; set; }

        [JsonProperty("_contacts_count")]
        public int ContactsCount { get; set; }
    }

    public class CreateListInput
    {
        [JsonProperty("list_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }
    }

    public class GetContactListsResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public GetContactListsResponseDataType Data { get; set; }
    }

    public class GetContactListsResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("data")]
        public GetContactListsResponseDataTypeDataTypeItem[] Data { get; set; }
    }

    public class GetContactListsResponseDataTypeDataTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("list_email_id")]
        public string ListEmailId { get; set; }

        [JsonProperty("_contacts_count")]
        public int ContactsCount { get; set; }

        [JsonProperty("_import_in_progress")]
        public int ImportInProgress { get; set; }

        [JsonProperty("_optout_in_progress")]
        public int OptoutInProgress { get; set; }
    }

    public class SendVoiceResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SendVoiceResponseDataType Data { get; set; }
    }

    public class SendVoiceResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("messages")]
        public SendVoiceResponseDataTypeMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("_currency")]
        public SendVoiceResponseDataTypeCurrencyType Currency { get; set; }
    }

    public class SendVoiceResponseDataTypeMessagesTypeItem
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("subaccount_id")]
        public int SubaccountId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("to_type")]
        public string ToType { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("voice")]
        public string Voice { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("schedule")]
        public int Schedule { get; set; }

        [JsonProperty("message_parts")]
        public int MessageParts { get; set; }

        [JsonProperty("message_price")]
        public string MessagePrice { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("require_input")]
        public int RequireInput { get; set; }

        [JsonProperty("machine_detection")]
        public int MachineDetection { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SendVoiceResponseDataTypeCurrencyType
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

    public class SendVoiceInput
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceInputMessagesTypeItem[] Messages { get; set; }
    }

    public class SendVoiceInputMessagesTypeItem
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("lang", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Lang { get; set; } = "en-us";

        [JsonProperty("voice", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceInputMessagesTypeItemVoiceType Voice { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("require_input")]
        public SendVoiceInputMessagesTypeItemRequireInputType? RequireInput { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "MSPowerAutomate";

        [JsonProperty("machine_detection")]
        public SendVoiceInputMessagesTypeItemMachineDetectionType? MachineDetection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendVoiceInputMessagesTypeItemVoiceType
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    public enum SendVoiceInputMessagesTypeItemRequireInputType
    {
        _1 = 1,
        _0 = 0
    }

    public enum SendVoiceInputMessagesTypeItemMachineDetectionType
    {
        _1 = 1,
        _0 = 0
    }

    public class DeleteListResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }
    }

    public class CreateListContactResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public CreateListContactResponseDataType Data { get; set; }
    }

    public class CreateListContactResponseDataType
    {
        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("custom_1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom_2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom_3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom_4")]
        public string Custom4 { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("fax_number")]
        public string FaxNumber { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

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

        [JsonProperty("_list_name")]
        public string ListName { get; set; }
    }

    public class CreateListContactInput
    {
        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("phone_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fax_number")]
        public string FaxNumber { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("custom_1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom_3")]
        public string Custom3 { get; set; }

        [JsonProperty("address_postal_code")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("custom_2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom_4")]
        public string Custom4 { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }
    }

    public class ViewListContactsResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public ViewListContactsResponseDataType Data { get; set; }
    }

    public class ViewListContactsResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("data")]
        public ViewListContactsResponseDataTypeDataTypeItem[] Data { get; set; }
    }

    public class ViewListContactsResponseDataTypeDataTypeItem
    {
        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("custom_1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom_2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom_3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom_4")]
        public string Custom4 { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public int DateUpdated { get; set; }

        [JsonProperty("fax_number")]
        public string FaxNumber { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

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

        [JsonProperty("_list_name")]
        public string ListName { get; set; }
    }

    public class DeleteListContactResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }
    }

    public class SendMmsResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SendMmsResponseDataType Data { get; set; }
    }

    public class SendMmsResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("messages")]
        public SendMmsResponseDataTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class SendMmsResponseDataTypeMessagesTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("message_parts")]
        public int MessageParts { get; set; }

        [JsonProperty("message_price")]
        public string MessagePrice { get; set; }

        [JsonProperty("_media_file_url")]
        public string MediaFileUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SendMmsInput
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMmsInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("media_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MediaFile { get; set; }
    }

    public class SendMmsInputMessagesTypeItem
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "MSPowerAutomate";
    }

    public class SendFaxResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SendFaxResponseDataType Data { get; set; }
    }

    public class SendFaxResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("messages")]
        public SendFaxResponseDataTypeMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("_currency")]
        public SendFaxResponseDataTypeCurrencyType Currency { get; set; }
    }

    public class SendFaxResponseDataTypeMessagesTypeItem
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("subaccount_id")]
        public int SubaccountId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("message_pages")]
        public int MessagePages { get; set; }

        [JsonProperty("message_price")]
        public string MessagePrice { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("status_text")]
        public string StatusText { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("_file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SendFaxResponseDataTypeCurrencyType
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

    public class SendFaxInput
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendFaxInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("file_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileUrl { get; set; }
    }

    public class SendFaxInputMessagesTypeItem
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "MSPowerAutomate";

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum convertInput
    {
        [EnumMember(Value = "fax")]
        Fax,
        [EnumMember(Value = "mms")]
        Mms,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "postcard")]
        Postcard
    }

    public class UploadMediaInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    public class SearchContactListResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SearchContactListResponseDataType Data { get; set; }
    }

    public class SearchContactListResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("data")]
        public SearchContactListResponseDataTypeDataTypeItem[] Data { get; set; }
    }

    public class SearchContactListResponseDataTypeDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contacts_count")]
        public int ContactsCount { get; set; }
    }

    public class SendLetterResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public SendLetterResponseDataType Data { get; set; }
    }

    public class SendLetterResponseDataType
    {
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("queued_count")]
        public int QueuedCount { get; set; }

        [JsonProperty("recipients")]
        public SendLetterResponseDataTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("_currency")]
        public SendLetterResponseDataTypeCurrencyType Currency { get; set; }
    }

    public class SendLetterResponseDataTypeRecipientsTypeItem
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

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("colour")]
        public int Colour { get; set; }

        [JsonProperty("duplex")]
        public int Duplex { get; set; }

        [JsonProperty("post_pages")]
        public int PostPages { get; set; }

        [JsonProperty("post_price")]
        public string PostPrice { get; set; }

        [JsonProperty("priority_post")]
        public int PriorityPost { get; set; }

        [JsonProperty("date_added")]
        public int DateAdded { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("_file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("_return_address")]
        public SendLetterResponseDataTypeRecipientsTypeItemReturnAddressType ReturnAddress { get; set; }

        [JsonProperty("_api_username")]
        public string ApiUsername { get; set; }
    }

    public class SendLetterResponseDataTypeRecipientsTypeItemReturnAddressType
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

    public class SendLetterResponseDataTypeCurrencyType
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

    public class SendLetterInput
    {
        [JsonProperty("file_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileUrl { get; set; }

        [JsonProperty("template_used")]
        public SendLetterInputTemplateUsedType? TemplateUsed { get; set; }

        [JsonProperty("colour", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendLetterInputColourType Colour { get; set; }

        [JsonProperty("duplex", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendLetterInputDuplexType Duplex { get; set; }

        [JsonProperty("priority_post")]
        public SendLetterInputPriorityPostType? PriorityPost { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendLetterInputRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "MSPowerAutomate";
    }

    public enum SendLetterInputTemplateUsedType
    {
        _1 = 1,
        _0 = 0
    }

    public enum SendLetterInputColourType
    {
        _0 = 0,
        _1 = 1
    }

    public enum SendLetterInputDuplexType
    {
        _0 = 0,
        _1 = 1
    }

    public enum SendLetterInputPriorityPostType
    {
        _1 = 1,
        _0 = 0
    }

    public class SendLetterInputRecipientsTypeItem
    {
        [JsonProperty("address_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressName { get; set; }

        [JsonProperty("address_city", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressCity { get; set; }

        [JsonProperty("address_state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressState { get; set; }

        [JsonProperty("address_postal_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address_country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressCountry { get; set; }

        [JsonProperty("return_address_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ReturnAddressId { get; set; }

        [JsonProperty("address_line_1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }
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

    public class SendPostcardInput
    {
        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendPostcardInputRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("file_urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] FileUrls { get; set; }
    }

    public class SendPostcardInputRecipientsTypeItem
    {
        [JsonProperty("address_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressName { get; set; }

        [JsonProperty("address_city", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressCity { get; set; }

        [JsonProperty("address_state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressState { get; set; }

        [JsonProperty("address_postal_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressPostalCode { get; set; }

        [JsonProperty("address_country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressCountry { get; set; }

        [JsonProperty("return_address_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ReturnAddressId { get; set; }

        [JsonProperty("address_line_1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }
    }

    public class SmsInboundAutomationInput
    {
        [JsonProperty("message_search_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int MessageSearchType { get; set; } = 0;

        [JsonProperty("message_search_term", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string MessageSearchTerm { get; set; } = "*";

        [JsonProperty("action_address", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ActionAddress { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("dedicated_number", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DedicatedNumber { get; set; } = "*";

        [JsonProperty("rule_name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string RuleName { get; set; } = "Power-Automate";

        [JsonProperty("webhook_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookType { get; set; } = "json";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "URL";

        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int Enabled { get; set; } = 1;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clicksendsms;

    public partial class WorkflowManagedActions
    {
        public ClicksendsmsActions Clicksendsms(string connectionId) => new ClicksendsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClicksendsmsTriggers Clicksendsms(string connectionId) => new ClicksendsmsTriggers(connectionId);
    }
}