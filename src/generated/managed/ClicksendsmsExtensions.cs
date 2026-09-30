//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clicksendsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClicksendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SmsSendResponse> SmsSend([WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SmsSendResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<CreateListResponse> CreateList([WorkflowExpression] Func<string> bodylistName)
        {
            SourceExpression.Validate(bodylistName, nameof(bodylistName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_name"] = SourceExpressionConverter.ConvertToken(bodylistName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<GetContactListsResponse> GetContactLists([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactListsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendVoiceResponse> SendVoice([WorkflowExpression] Func<bodymessagesInputItem2[]> bodymessages)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/voice/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendVoiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<DeleteListResponse> DeleteList([WorkflowExpression] Func<int> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<CreateListContactResponse> CreateListContact([WorkflowExpression] Func<int> listId, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyphoneNumber, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfaxNumber = null, [WorkflowExpression] Func<string> bodyorganizationName = null, [WorkflowExpression] Func<string> bodyaddressCountry = null, [WorkflowExpression] Func<string> bodyaddressState = null, [WorkflowExpression] Func<string> bodyaddressCity = null, [WorkflowExpression] Func<string> bodycustom1 = null, [WorkflowExpression] Func<string> bodycustom3 = null, [WorkflowExpression] Func<string> bodyaddressPostalCode = null, [WorkflowExpression] Func<string> bodycustom2 = null, [WorkflowExpression] Func<string> bodycustom4 = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            SourceExpression.Validate(bodyorganizationName, nameof(bodyorganizationName), required: false);
            SourceExpression.Validate(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            SourceExpression.Validate(bodyaddressState, nameof(bodyaddressState), required: false);
            SourceExpression.Validate(bodyaddressCity, nameof(bodyaddressCity), required: false);
            SourceExpression.Validate(bodycustom1, nameof(bodycustom1), required: false);
            SourceExpression.Validate(bodycustom3, nameof(bodycustom3), required: false);
            SourceExpression.Validate(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            SourceExpression.Validate(bodycustom2, nameof(bodycustom2), required: false);
            SourceExpression.Validate(bodycustom4, nameof(bodycustom4), required: false);
            SourceExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            SourceExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
                body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfaxNumber != null)
                {
                    body["fax_number"] = SourceExpressionConverter.ConvertToken(bodyfaxNumber);
                    bodypropCount++;
                }

                if (bodyorganizationName != null)
                {
                    body["organization_name"] = SourceExpressionConverter.ConvertToken(bodyorganizationName);
                    bodypropCount++;
                }

                if (bodyaddressCountry != null)
                {
                    body["address_country"] = SourceExpressionConverter.ConvertToken(bodyaddressCountry);
                    bodypropCount++;
                }

                if (bodyaddressState != null)
                {
                    body["address_state"] = SourceExpressionConverter.ConvertToken(bodyaddressState);
                    bodypropCount++;
                }

                if (bodyaddressCity != null)
                {
                    body["address_city"] = SourceExpressionConverter.ConvertToken(bodyaddressCity);
                    bodypropCount++;
                }

                if (bodycustom1 != null)
                {
                    body["custom_1"] = SourceExpressionConverter.ConvertToken(bodycustom1);
                    bodypropCount++;
                }

                if (bodycustom3 != null)
                {
                    body["custom_3"] = SourceExpressionConverter.ConvertToken(bodycustom3);
                    bodypropCount++;
                }

                if (bodyaddressPostalCode != null)
                {
                    body["address_postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (bodycustom2 != null)
                {
                    body["custom_2"] = SourceExpressionConverter.ConvertToken(bodycustom2);
                    bodypropCount++;
                }

                if (bodycustom4 != null)
                {
                    body["custom_4"] = SourceExpressionConverter.ConvertToken(bodycustom4);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["address_line_1"] = SourceExpressionConverter.ConvertToken(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["address_line_2"] = SourceExpressionConverter.ConvertToken(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateListContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<ViewListContactsResponse> ViewListContacts([WorkflowExpression] Func<int> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<DeleteListContactResponse> DeleteListContact([WorkflowExpression] Func<int> listId, [WorkflowExpression] Func<int> contactId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteListContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendMmsResponse> SendMms([WorkflowExpression] Func<bodymessagesInputItem222[]> bodymessages, [WorkflowExpression] Func<string> bodymediaFile)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodymediaFile, nameof(bodymediaFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                bodypropCount++;
                body["media_file"] = SourceExpressionConverter.ConvertToken(bodymediaFile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMmsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendFaxResponse> SendFax([WorkflowExpression] Func<bodymessagesInputItem2222[]> bodymessages, [WorkflowExpression] Func<string> bodyfileUrl)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fax/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                bodypropCount++;
                body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendFaxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMedia([WorkflowExpression] Func<convertInput> convert, [WorkflowExpression] Func<string> bodycontent)
        {
            SourceExpression.Validate(convert, nameof(convert), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["convert"] = SourceExpressionConverter.Convert(convert);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SearchContactListResponse> SearchContactList([WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search/contacts-lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<SearchContactListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendLetterResponse> SendLetter([WorkflowExpression] Func<string> bodyfileUrl, [WorkflowExpression] Func<bodycolourInput> bodycolour, [WorkflowExpression] Func<bodyduplexInput> bodyduplex, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients, [WorkflowExpression] Func<bodytemplateUsedInput> bodytemplateUsed = null, [WorkflowExpression] Func<bodypriorityPostInput> bodypriorityPost = null)
        {
            SourceExpression.Validate(bodyfileUrl, nameof(bodyfileUrl), required: true);
            SourceExpression.Validate(bodycolour, nameof(bodycolour), required: true);
            SourceExpression.Validate(bodyduplex, nameof(bodyduplex), required: true);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            SourceExpression.Validate(bodytemplateUsed, nameof(bodytemplateUsed), required: false);
            SourceExpression.Validate(bodypriorityPost, nameof(bodypriorityPost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/post/letters/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_url"] = SourceExpressionConverter.ConvertToken(bodyfileUrl);
                if (bodytemplateUsed != null)
                {
                    body["template_used"] = SourceExpressionConverter.Convert(bodytemplateUsed);
                    bodypropCount++;
                }

                bodypropCount++;
                body["colour"] = SourceExpressionConverter.Convert(bodycolour);
                bodypropCount++;
                body["duplex"] = SourceExpressionConverter.Convert(bodyduplex);
                if (bodypriorityPost != null)
                {
                    body["priority_post"] = SourceExpressionConverter.Convert(bodypriorityPost);
                    bodypropCount++;
                }

                bodypropCount++;
                body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                body["source"] = "MSPowerAutomate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendLetterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clicksendsms")]
        public IBodyWorkflowAction<SendPostcardResponse> SendPostcard([WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients, [WorkflowExpression] Func<string[]> bodyfileUrls)
        {
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: true);
            SourceExpression.Validate(bodyfileUrls, nameof(bodyfileUrls), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/post/postcards/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                bodypropCount++;
                body["file_urls"] = SourceExpressionConverter.ConvertToken(bodyfileUrls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendPostcardResponse>(BuildSourceInput);
        }
    }

    public class ClicksendsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SmsInboundAutomation(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public class bodymessagesInputItem2
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("voice")]
        public bodymessagesInputItemVoiceType Voice { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("require_input")]
        public bodymessagesInputItemRequireInputType RequireInput { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("machine_detection")]
        public bodymessagesInputItemMachineDetectionType MachineDetection { get; set; }
    }

    public enum bodymessagesInputItemVoiceType
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    public enum bodymessagesInputItemRequireInputType
    {
        _1 = 1,
        _0 = 0
    }

    public enum bodymessagesInputItemMachineDetectionType
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

    public class bodymessagesInputItem222
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

    public class bodymessagesInputItem2222
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("custom_string")]
        public string CustomString { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }
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

    public enum bodycolourInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum bodyduplexInput
    {
        _0 = 0,
        _1 = 1
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

    public enum bodytemplateUsedInput
    {
        _1 = 1,
        _0 = 0
    }

    public enum bodypriorityPostInput
    {
        _1 = 1,
        _0 = 0
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