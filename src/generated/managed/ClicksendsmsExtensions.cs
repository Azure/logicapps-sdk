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
        public IBodyWorkflowAction<SmsSendResponse, ApiConnectionActionConfiguration> SmsSend(Expression<Func<bodymessagesInputItem[]>> bodymessages)
        {
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
            return new DeferredBodyAction<SmsSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SmsSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SmsCampaignSendResponse, ApiConnectionActionConfiguration> SmsCampaignSend(Expression<Func<int>> bodylistId, Expression<Func<string>> bodyname, Expression<Func<string>> bodybody, Expression<Func<bodysendersInputItem[]>> bodysenders, Expression<Func<string>> bodyfrom = null, Expression<Func<int>> bodyschedule = null, Expression<Func<string>> bodyurlToShorten = null)
        {
            var __workflow_bodylistId = WorkflowExpression.Compile(bodylistId, nameof(bodylistId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: true);
            var __workflow_bodysenders = WorkflowExpression.Compile(bodysenders, nameof(bodysenders), required: true);
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyschedule = WorkflowExpression.Compile(bodyschedule, nameof(bodyschedule), required: false);
            var __workflow_bodyurlToShorten = WorkflowExpression.Compile(bodyurlToShorten, nameof(bodyurlToShorten), required: false);
            return new DeferredBodyAction<SmsCampaignSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms-campaigns/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_id"] = ExpressionConverter.ConvertO(__workflow_bodylistId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                if (__workflow_bodyschedule != null)
                {
                    body["schedule"] = ExpressionConverter.ConvertO(__workflow_bodyschedule);
                    bodypropCount++;
                }

                if (__workflow_bodyurlToShorten != null)
                {
                    body["url_to_shorten"] = ExpressionConverter.ConvertO(__workflow_bodyurlToShorten);
                    bodypropCount++;
                }

                bodypropCount++;
                body["senders"] = ExpressionConverter.ConvertO(__workflow_bodysenders);
                body["source"] = "MSPowerAutomate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SmsCampaignSendResponse>(callPayload);
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
        public IBodyWorkflowAction<CreateListResponse, ApiConnectionActionConfiguration> CreateList(Expression<Func<string>> bodylistName)
        {
            var __workflow_bodylistName = WorkflowExpression.Compile(bodylistName, nameof(bodylistName), required: true);
            return new DeferredBodyAction<CreateListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_name"] = ExpressionConverter.ConvertO(__workflow_bodylistName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateListResponse>(callPayload);
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
        public IBodyWorkflowAction<CreateListContactResponse, ApiConnectionActionConfiguration> CreateListContact(Expression<Func<int>> listId, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyphoneNumber, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfaxNumber = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodyaddressCountry = null, Expression<Func<string>> bodyaddressState = null, Expression<Func<string>> bodyaddressCity = null, Expression<Func<string>> bodycustom1 = null, Expression<Func<string>> bodycustom3 = null, Expression<Func<string>> bodyaddressPostalCode = null, Expression<Func<string>> bodycustom2 = null, Expression<Func<string>> bodycustom4 = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfaxNumber = WorkflowExpression.Compile(bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            var __workflow_bodyorganizationName = WorkflowExpression.Compile(bodyorganizationName, nameof(bodyorganizationName), required: false);
            var __workflow_bodyaddressCountry = WorkflowExpression.Compile(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            var __workflow_bodyaddressState = WorkflowExpression.Compile(bodyaddressState, nameof(bodyaddressState), required: false);
            var __workflow_bodyaddressCity = WorkflowExpression.Compile(bodyaddressCity, nameof(bodyaddressCity), required: false);
            var __workflow_bodycustom1 = WorkflowExpression.Compile(bodycustom1, nameof(bodycustom1), required: false);
            var __workflow_bodycustom3 = WorkflowExpression.Compile(bodycustom3, nameof(bodycustom3), required: false);
            var __workflow_bodyaddressPostalCode = WorkflowExpression.Compile(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            var __workflow_bodycustom2 = WorkflowExpression.Compile(bodycustom2, nameof(bodycustom2), required: false);
            var __workflow_bodycustom4 = WorkflowExpression.Compile(bodycustom4, nameof(bodycustom4), required: false);
            var __workflow_bodyaddressLine1 = WorkflowExpression.Compile(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = WorkflowExpression.Compile(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            return new DeferredBodyAction<CreateListContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/contacts", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                bodypropCount++;
                body["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxNumber != null)
                {
                    body["fax_number"] = ExpressionConverter.ConvertO(__workflow_bodyfaxNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationName != null)
                {
                    body["organization_name"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationName);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCountry != null)
                {
                    body["address_country"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressState != null)
                {
                    body["address_state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCity != null)
                {
                    body["address_city"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodycustom1 != null)
                {
                    body["custom_1"] = ExpressionConverter.ConvertO(__workflow_bodycustom1);
                    bodypropCount++;
                }

                if (__workflow_bodycustom3 != null)
                {
                    body["custom_3"] = ExpressionConverter.ConvertO(__workflow_bodycustom3);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressPostalCode != null)
                {
                    body["address_postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycustom2 != null)
                {
                    body["custom_2"] = ExpressionConverter.ConvertO(__workflow_bodycustom2);
                    bodypropCount++;
                }

                if (__workflow_bodycustom4 != null)
                {
                    body["custom_4"] = ExpressionConverter.ConvertO(__workflow_bodycustom4);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine1 != null)
                {
                    body["address_line_1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["address_line_2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateListContactResponse>(callPayload);
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
        public IBodyWorkflowAction<SendMmsResponse, ApiConnectionActionConfiguration> SendMms(Expression<Func<bodymessagesInputItem2[]>> bodymessages, Expression<Func<string>> bodymediaFile)
        {
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
            var __workflow_bodymediaFile = WorkflowExpression.Compile(bodymediaFile, nameof(bodymediaFile), required: true);
            return new DeferredBodyAction<SendMmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                bodypropCount++;
                body["media_file"] = ExpressionConverter.ConvertO(__workflow_bodymediaFile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMedia(Expression<Func<convertInput>> convert, Expression<Func<string>> bodycontent)
        {
            var __workflow_convert = WorkflowExpression.Compile(convert, nameof(convert), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: true);
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["convert"] = ExpressionConverter.Convert(__workflow_convert);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
    }

    public class ClicksendsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SmsInboundAutomation(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/ms-flow/automations/sms/inbound";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["message_search_type"] = 0;
                bodypropCount++;
                body["message_search_term"] = "*";
                bodypropCount++;
                body["action_address"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["dedicated_number"] = "*";
                bodypropCount++;
                body["rule_name"] = "Power-Automate";
                bodypropCount++;
                body["webhook_type"] = "json";
                bodypropCount++;
                body["action"] = "URL";
                bodypropCount++;
                body["enabled"] = 1;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodymessagesInputItem
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class SmsCampaignSendResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class bodysendersInputItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("sender_type")]
        public string SenderType { get; set; }

        [JsonProperty("sender_country_code")]
        public string SenderCountryCode { get; set; }
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

    public class DeleteListResponse
    {
        [JsonProperty("http_code")]
        public int HttpCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("response_msg")]
        public string ResponseMsg { get; set; }
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

    public class bodymessagesInputItem2
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
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