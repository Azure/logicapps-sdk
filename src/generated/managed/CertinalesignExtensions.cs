//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certinalesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CertinalesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionResponse> CreateTransaction([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodymailmessage = null, [WorkflowExpression] Func<bodynotificationSubscriptionsInputItem[]> bodynotificationSubscriptions = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexpiryAndRemindersexpiresAtTimestamp = null, [WorkflowExpression] Func<string> bodyexpiryAndRemindersremindFromTimestamp = null, [WorkflowExpression] Func<int> bodyexpiryAndRemindersreminderFrequency = null, [WorkflowExpression] Func<bool> bodysignatureBlockDefault = null, [WorkflowExpression] Func<bodyparticipantsInputItem[]> bodyparticipants = null, [WorkflowExpression] Func<bodyccUsersInputItem[]> bodyccUsers = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/il/rssp/v1/transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                var mailObject = new JObject();
                var mailObjectpropCount = 0;
                if (bodymailmessage != null)
                {
                    mailObject["message"] = SourceExpressionConverter.ConvertToken(bodymailmessage);
                    mailObjectpropCount++;
                }

                if (mailObjectpropCount > 0)
                {
                    body["mail"] = mailObject;
                    bodypropCount++;
                }

                if (bodynotificationSubscriptions != null)
                {
                    body["notificationSubscriptions"] = SourceExpressionConverter.ConvertToken(bodynotificationSubscriptions);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                var expiryAndRemindersObject = new JObject();
                var expiryAndRemindersObjectpropCount = 0;
                if (bodyexpiryAndRemindersexpiresAtTimestamp != null)
                {
                    expiryAndRemindersObject["expiresAtTimestamp"] = SourceExpressionConverter.ConvertToken(bodyexpiryAndRemindersexpiresAtTimestamp);
                    expiryAndRemindersObjectpropCount++;
                }

                if (bodyexpiryAndRemindersremindFromTimestamp != null)
                {
                    expiryAndRemindersObject["remindFromTimestamp"] = SourceExpressionConverter.ConvertToken(bodyexpiryAndRemindersremindFromTimestamp);
                    expiryAndRemindersObjectpropCount++;
                }

                if (bodyexpiryAndRemindersreminderFrequency != null)
                {
                    expiryAndRemindersObject["reminderFrequency"] = SourceExpressionConverter.ConvertToken(bodyexpiryAndRemindersreminderFrequency);
                    expiryAndRemindersObjectpropCount++;
                }

                if (expiryAndRemindersObjectpropCount > 0)
                {
                    body["expiryAndReminders"] = expiryAndRemindersObject;
                    bodypropCount++;
                }

                var signatureBlockObject = new JObject();
                var signatureBlockObjectpropCount = 0;
                if (bodysignatureBlockDefault != null)
                {
                    signatureBlockObject["default"] = SourceExpressionConverter.ConvertToken(bodysignatureBlockDefault);
                    signatureBlockObjectpropCount++;
                }

                if (signatureBlockObjectpropCount > 0)
                {
                    body["signatureBlock"] = signatureBlockObject;
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodyccUsers != null)
                {
                    body["ccUsers"] = SourceExpressionConverter.ConvertToken(bodyccUsers);
                    bodypropCount++;
                }

                if (bodydocuments != null)
                {
                    body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTransactionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<object> DownloadDocuments([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<string> documentType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/il/rssp/v1/transactions/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentType"] = SourceExpressionConverter.ConvertO(documentType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers([WorkflowExpression] Func<int> bodypageNumber, [WorkflowExpression] Func<int> bodyrecordsPerPage)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/il/auth/v1/users/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pageNo"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
                body["perPageRecords"] = SourceExpressionConverter.ConvertToken(bodyrecordsPerPage);
                body["paginatedResponse"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<GetUserDetailsResponse> GetUserDetails([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/il/auth/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return callPayload;
            }

            return new ApiConnectionAction<GetUserDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyphoneCountryCode = null, [WorkflowExpression] Func<string[]> bodyroles = null, [WorkflowExpression] Func<bool> bodyfinalMailDisabled = null, [WorkflowExpression] Func<bool> bodyreminderMailDisabled = null, [WorkflowExpression] Func<bool> bodysenderMailDisabled = null, [WorkflowExpression] Func<bool> bodyintegrationUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/il/auth/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemailAddress != null)
                {
                    body["emailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["dateFormat"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyphoneCountryCode != null)
                {
                    body["phoneCountryCode"] = SourceExpressionConverter.ConvertToken(bodyphoneCountryCode);
                    bodypropCount++;
                }

                if (bodyroles != null)
                {
                    body["roles"] = SourceExpressionConverter.ConvertToken(bodyroles);
                    bodypropCount++;
                }

                if (bodyfinalMailDisabled != null)
                {
                    body["finalMailDisabled"] = SourceExpressionConverter.ConvertToken(bodyfinalMailDisabled);
                    bodypropCount++;
                }

                if (bodyreminderMailDisabled != null)
                {
                    body["reminderMailDisabled"] = SourceExpressionConverter.ConvertToken(bodyreminderMailDisabled);
                    bodypropCount++;
                }

                if (bodysenderMailDisabled != null)
                {
                    body["senderMailDisabled"] = SourceExpressionConverter.ConvertToken(bodysenderMailDisabled);
                    bodypropCount++;
                }

                if (bodyintegrationUser != null)
                {
                    body["integrationUser"] = SourceExpressionConverter.ConvertToken(bodyintegrationUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IWorkflowAction DeleteSubscription([WorkflowExpression] Func<string> webhookId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/unsubscribe/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webhookId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionUsingTemplateResponse> CreateTransactionUsingTemplate([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<string[]> bodysecondaryTemplateIds = null, [WorkflowExpression] Func<string> bodymailmessage = null, [WorkflowExpression] Func<bodynotificationSubscriptionsInputItem[]> bodynotificationSubscriptions = null, [WorkflowExpression] Func<bodyparticipantsInputItem2[]> bodyparticipants = null, [WorkflowExpression] Func<bodyccUsersInputItem[]> bodyccUsers = null, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/il/rssp/v1/transactions/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodysecondaryTemplateIds != null)
                {
                    body["secondaryTemplateIds"] = SourceExpressionConverter.ConvertToken(bodysecondaryTemplateIds);
                    bodypropCount++;
                }

                var mailObject = new JObject();
                var mailObjectpropCount = 0;
                if (bodymailmessage != null)
                {
                    mailObject["message"] = SourceExpressionConverter.ConvertToken(bodymailmessage);
                    mailObjectpropCount++;
                }

                if (mailObjectpropCount > 0)
                {
                    body["mail"] = mailObject;
                    bodypropCount++;
                }

                if (bodynotificationSubscriptions != null)
                {
                    body["notificationSubscriptions"] = SourceExpressionConverter.ConvertToken(bodynotificationSubscriptions);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodyccUsers != null)
                {
                    body["ccUsers"] = SourceExpressionConverter.ConvertToken(bodyccUsers);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTransactionUsingTemplateResponse>(BuildSourceInput);
        }
    }

    public class CertinalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TransactionStatusChanged([WorkflowExpression] Func<eventTypeInputItem[]> eventType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = SourceExpressionConverter.ConvertO(eventType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
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

    public class CreateTransactionResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CreateTransactionResponseDataType Data { get; set; }
    }

    public class CreateTransactionResponseDataType
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class bodynotificationSubscriptionsInputItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("transactionEvents")]
        public string[] TransactionEvents { get; set; }

        [JsonProperty("participantEvents")]
        public string[] ParticipantEvents { get; set; }
    }

    public class bodyparticipantsInputItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("candidates")]
        public bodyparticipantsInputItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("fields")]
        public bodyparticipantsInputItemFieldsTypeItem[] Fields { get; set; }
    }

    public class bodyparticipantsInputItemCandidatesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("authenticationInfo")]
        public bodyparticipantsInputItemCandidatesTypeItemAuthenticationInfoType AuthenticationInfo { get; set; }

        [JsonProperty("deliveryChannels")]
        public string[] DeliveryChannels { get; set; }
    }

    public class bodyparticipantsInputItemCandidatesTypeItemAuthenticationInfoType
    {
        [JsonProperty("authenticationMode")]
        public string AuthenticationMode { get; set; }

        [JsonProperty("authenticationModeValue")]
        public string AuthenticationModeValue { get; set; }
    }

    public class bodyparticipantsInputItemFieldsTypeItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("pages")]
        public string[] Pages { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("textareaLineCount")]
        public string TextareaLineCount { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("xposition")]
        public double Xposition { get; set; }

        [JsonProperty("yposition")]
        public double Yposition { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("textarea")]
        public bool Textarea { get; set; }

        [JsonProperty("topBottom")]
        public bool TopBottom { get; set; }

        [JsonProperty("vertical")]
        public bool Vertical { get; set; }

        [JsonProperty("radioGroupId")]
        public string RadioGroupId { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }
    }

    public class bodyccUsersInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("deletable")]
        public bool Deletable { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }
    }

    public class bodycustomFieldsInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("details")]
        public bodycustomFieldsInputItemDetailsType Details { get; set; }
    }

    public class bodycustomFieldsInputItemDetailsType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class ListUsersResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ListUsersResponseDataType Data { get; set; }
    }

    public class ListUsersResponseDataType
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("perPageRecords")]
        public int PerPageRecords { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }

        [JsonProperty("records")]
        public ListUsersResponseDataTypeRecordsTypeItem[] Records { get; set; }
    }

    public class ListUsersResponseDataTypeRecordsTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("finalMailDisabled")]
        public bool FinalMailDisabled { get; set; }

        [JsonProperty("reminderMailDisabled")]
        public bool ReminderMailDisabled { get; set; }

        [JsonProperty("senderMailDisabled")]
        public bool SenderMailDisabled { get; set; }

        [JsonProperty("integrationUser")]
        public bool IntegrationUser { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }

    public class GetUserDetailsResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetUserDetailsResponseDataType Data { get; set; }
    }

    public class GetUserDetailsResponseDataType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("finalMailDisabled")]
        public bool FinalMailDisabled { get; set; }

        [JsonProperty("reminderMailDisabled")]
        public bool ReminderMailDisabled { get; set; }

        [JsonProperty("senderMailDisabled")]
        public bool SenderMailDisabled { get; set; }

        [JsonProperty("integrationUser")]
        public bool IntegrationUser { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }

    public class CreateUserResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CreateUserResponseDataType Data { get; set; }
    }

    public class CreateUserResponseDataType
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class CreateTransactionUsingTemplateResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CreateTransactionUsingTemplateResponseDataType Data { get; set; }
    }

    public class CreateTransactionUsingTemplateResponseDataType
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class bodyparticipantsInputItem2
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("autoProcess")]
        public bool AutoProcess { get; set; }

        [JsonProperty("fields")]
        public bodyparticipantsInputItemFieldsTypeItem2[] Fields { get; set; }

        [JsonProperty("candidates")]
        public bodyparticipantsInputItemCandidatesTypeItem2[] Candidates { get; set; }
    }

    public class bodyparticipantsInputItemFieldsTypeItem2
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyparticipantsInputItemCandidatesTypeItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("deliveryChannels")]
        public string[] DeliveryChannels { get; set; }

        [JsonProperty("customSMSBody")]
        public string CustomSMSBody { get; set; }

        [JsonProperty("attachments")]
        public bodyparticipantsInputItemCandidatesTypeItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class bodyparticipantsInputItemCandidatesTypeItemAttachmentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }

    public enum eventTypeInputItem
    {
        SENT,
        PENDING,
        COMPLETED,
        DECLINED,
        CANCELLED,
        EXPIRED
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Certinalesign;

    public partial class WorkflowManagedActions
    {
        public CertinalesignActions Certinalesign(string connectionId) => new CertinalesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CertinalesignTriggers Certinalesign(string connectionId) => new CertinalesignTriggers(connectionId);
    }
}