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
        public IBodyWorkflowAction<CreateTransactionResponse> CreateTransaction(Expression<Func<string>> bodyname, Expression<Func<string>> bodymailmessage = null, Expression<Func<bodynotificationSubscriptionsInputItem[]>> bodynotificationSubscriptions = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexpiryAndRemindersexpiresAtTimestamp = null, Expression<Func<string>> bodyexpiryAndRemindersremindFromTimestamp = null, Expression<Func<int>> bodyexpiryAndRemindersreminderFrequency = null, Expression<Func<bool>> bodysignatureBlockdefault = null, Expression<Func<bodyparticipantsInputItem[]>> bodyparticipants = null, Expression<Func<bodyccUsersInputItem[]>> bodyccUsers = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var apiCallPath = "/il/rssp/v1/transactions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            var mailObject = new JObject();
            var mailObjectpropCount = 0;
            if (bodymailmessage != null)
            {
                mailObject["message"] = ExpressionConverter.ConvertO(bodymailmessage);
                mailObjectpropCount++;
            }

            if (mailObjectpropCount > 0)
            {
                body["mail"] = mailObject;
                bodypropCount++;
            }

            if (bodynotificationSubscriptions != null)
            {
                body["notificationSubscriptions"] = ExpressionConverter.ConvertO(bodynotificationSubscriptions);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            var expiryAndRemindersObject = new JObject();
            var expiryAndRemindersObjectpropCount = 0;
            if (bodyexpiryAndRemindersexpiresAtTimestamp != null)
            {
                expiryAndRemindersObject["expiresAtTimestamp"] = ExpressionConverter.ConvertO(bodyexpiryAndRemindersexpiresAtTimestamp);
                expiryAndRemindersObjectpropCount++;
            }

            if (bodyexpiryAndRemindersremindFromTimestamp != null)
            {
                expiryAndRemindersObject["remindFromTimestamp"] = ExpressionConverter.ConvertO(bodyexpiryAndRemindersremindFromTimestamp);
                expiryAndRemindersObjectpropCount++;
            }

            if (bodyexpiryAndRemindersreminderFrequency != null)
            {
                expiryAndRemindersObject["reminderFrequency"] = ExpressionConverter.ConvertO(bodyexpiryAndRemindersreminderFrequency);
                expiryAndRemindersObjectpropCount++;
            }

            if (expiryAndRemindersObjectpropCount > 0)
            {
                body["expiryAndReminders"] = expiryAndRemindersObject;
                bodypropCount++;
            }

            var signatureBlockObject = new JObject();
            var signatureBlockObjectpropCount = 0;
            if (bodysignatureBlockdefault != null)
            {
                signatureBlockObject["default"] = ExpressionConverter.ConvertO(bodysignatureBlockdefault);
                signatureBlockObjectpropCount++;
            }

            if (signatureBlockObjectpropCount > 0)
            {
                body["signatureBlock"] = signatureBlockObject;
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodyccUsers != null)
            {
                body["ccUsers"] = ExpressionConverter.ConvertO(bodyccUsers);
                bodypropCount++;
            }

            if (bodydocuments != null)
            {
                body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["customFields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTransactionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<object> DownloadDocuments(Expression<Func<string>> transactionId, Expression<Func<string>> documentType)
        {
            var apiCallPath = String.Format("/il/rssp/v1/transactions/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentType"] = ExpressionConverter.Convert(documentType);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodyrecordsPerPage)
        {
            var apiCallPath = "/il/auth/v1/users/all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pageNo"] = ExpressionConverter.ConvertO(bodypageNumber);
            bodypropCount++;
            body["perPageRecords"] = ExpressionConverter.ConvertO(bodyrecordsPerPage);
            body["paginatedResponse"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<GetUserDetailsResponse> GetUserDetails(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/il/auth/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            return new ApiConnectionAction<GetUserDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser(Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyphoneCountryCode = null, Expression<Func<string[]>> bodyroles = null, Expression<Func<bool>> bodyfinalMailDisabled = null, Expression<Func<bool>> bodyreminderMailDisabled = null, Expression<Func<bool>> bodysenderMailDisabled = null, Expression<Func<bool>> bodyintegrationUser = null)
        {
            var apiCallPath = "/il/auth/v1/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemailAddress != null)
            {
                body["emailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["dateFormat"] = ExpressionConverter.ConvertO(bodydateFormat);
                bodypropCount++;
            }

            if (bodysalutation != null)
            {
                body["salutation"] = ExpressionConverter.ConvertO(bodysalutation);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyphoneCountryCode != null)
            {
                body["phoneCountryCode"] = ExpressionConverter.ConvertO(bodyphoneCountryCode);
                bodypropCount++;
            }

            if (bodyroles != null)
            {
                body["roles"] = ExpressionConverter.ConvertO(bodyroles);
                bodypropCount++;
            }

            if (bodyfinalMailDisabled != null)
            {
                body["finalMailDisabled"] = ExpressionConverter.ConvertO(bodyfinalMailDisabled);
                bodypropCount++;
            }

            if (bodyreminderMailDisabled != null)
            {
                body["reminderMailDisabled"] = ExpressionConverter.ConvertO(bodyreminderMailDisabled);
                bodypropCount++;
            }

            if (bodysenderMailDisabled != null)
            {
                body["senderMailDisabled"] = ExpressionConverter.ConvertO(bodysenderMailDisabled);
                bodypropCount++;
            }

            if (bodyintegrationUser != null)
            {
                body["integrationUser"] = ExpressionConverter.ConvertO(bodyintegrationUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IWorkflowAction DeleteSubscription(Expression<Func<string>> webhookId)
        {
            var apiCallPath = String.Format("/webhooks/unsubscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(webhookId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionUsingTemplateResponse> CreateTransactionUsingTemplate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string[]>> bodysecondaryTemplateIds = null, Expression<Func<string>> bodymailmessage = null, Expression<Func<bodynotificationSubscriptionsInputItem[]>> bodynotificationSubscriptions = null, Expression<Func<bodyparticipantsInputItem2[]>> bodyparticipants = null, Expression<Func<bodyccUsersInputItem[]>> bodyccUsers = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var apiCallPath = "/il/rssp/v1/transactions/templates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodysecondaryTemplateIds != null)
            {
                body["secondaryTemplateIds"] = ExpressionConverter.ConvertO(bodysecondaryTemplateIds);
                bodypropCount++;
            }

            var mailObject = new JObject();
            var mailObjectpropCount = 0;
            if (bodymailmessage != null)
            {
                mailObject["message"] = ExpressionConverter.ConvertO(bodymailmessage);
                mailObjectpropCount++;
            }

            if (mailObjectpropCount > 0)
            {
                body["mail"] = mailObject;
                bodypropCount++;
            }

            if (bodynotificationSubscriptions != null)
            {
                body["notificationSubscriptions"] = ExpressionConverter.ConvertO(bodynotificationSubscriptions);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodyccUsers != null)
            {
                body["ccUsers"] = ExpressionConverter.ConvertO(bodyccUsers);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["customFields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTransactionUsingTemplateResponse>(callPayload);
        }
    }

    public class CertinalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TransactionStatusChanged(Expression<Func<eventTypeInputItem[]>> eventType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["eventType"] = ExpressionConverter.Convert(eventType);
            callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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