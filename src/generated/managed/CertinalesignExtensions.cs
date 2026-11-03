//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certinalesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CertinalesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<string>> bodyname, Expression<Func<string>> bodymailmessage = null, Expression<Func<bodynotificationSubscriptionsInputItem[]>> bodynotificationSubscriptions = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexpiryAndRemindersexpiresAtTimestamp = null, Expression<Func<string>> bodyexpiryAndRemindersremindFromTimestamp = null, Expression<Func<int>> bodyexpiryAndRemindersreminderFrequency = null, Expression<Func<bool>> bodysignatureBlockDefault = null, Expression<Func<bodyparticipantsInputItem[]>> bodyparticipants = null, Expression<Func<bodyccUsersInputItem[]>> bodyccUsers = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodymailmessage = WorkflowExpression.Compile(bodymailmessage, nameof(bodymailmessage), required: false);
            var __workflow_bodynotificationSubscriptions = WorkflowExpression.Compile(bodynotificationSubscriptions, nameof(bodynotificationSubscriptions), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexpiryAndRemindersexpiresAtTimestamp = WorkflowExpression.Compile(bodyexpiryAndRemindersexpiresAtTimestamp, nameof(bodyexpiryAndRemindersexpiresAtTimestamp), required: false);
            var __workflow_bodyexpiryAndRemindersremindFromTimestamp = WorkflowExpression.Compile(bodyexpiryAndRemindersremindFromTimestamp, nameof(bodyexpiryAndRemindersremindFromTimestamp), required: false);
            var __workflow_bodyexpiryAndRemindersreminderFrequency = WorkflowExpression.Compile(bodyexpiryAndRemindersreminderFrequency, nameof(bodyexpiryAndRemindersreminderFrequency), required: false);
            var __workflow_bodysignatureBlockDefault = WorkflowExpression.Compile(bodysignatureBlockDefault, nameof(bodysignatureBlockDefault), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            var __workflow_bodyccUsers = WorkflowExpression.Compile(bodyccUsers, nameof(bodyccUsers), required: false);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<CreateTransactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/rssp/v1/transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                var mailObject = new JObject();
                var mailObjectpropCount = 0;
                if (__workflow_bodymailmessage != null)
                {
                    mailObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymailmessage);
                    mailObjectpropCount++;
                }

                if (mailObjectpropCount > 0)
                {
                    body["mail"] = mailObject;
                    bodypropCount++;
                }

                if (__workflow_bodynotificationSubscriptions != null)
                {
                    body["notificationSubscriptions"] = ExpressionConverter.ConvertO(__workflow_bodynotificationSubscriptions);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                var expiryAndRemindersObject = new JObject();
                var expiryAndRemindersObjectpropCount = 0;
                if (__workflow_bodyexpiryAndRemindersexpiresAtTimestamp != null)
                {
                    expiryAndRemindersObject["expiresAtTimestamp"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryAndRemindersexpiresAtTimestamp);
                    expiryAndRemindersObjectpropCount++;
                }

                if (__workflow_bodyexpiryAndRemindersremindFromTimestamp != null)
                {
                    expiryAndRemindersObject["remindFromTimestamp"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryAndRemindersremindFromTimestamp);
                    expiryAndRemindersObjectpropCount++;
                }

                if (__workflow_bodyexpiryAndRemindersreminderFrequency != null)
                {
                    expiryAndRemindersObject["reminderFrequency"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryAndRemindersreminderFrequency);
                    expiryAndRemindersObjectpropCount++;
                }

                if (expiryAndRemindersObjectpropCount > 0)
                {
                    body["expiryAndReminders"] = expiryAndRemindersObject;
                    bodypropCount++;
                }

                var signatureBlockObject = new JObject();
                var signatureBlockObjectpropCount = 0;
                if (__workflow_bodysignatureBlockDefault != null)
                {
                    signatureBlockObject["default"] = ExpressionConverter.ConvertO(__workflow_bodysignatureBlockDefault);
                    signatureBlockObjectpropCount++;
                }

                if (signatureBlockObjectpropCount > 0)
                {
                    body["signatureBlock"] = signatureBlockObject;
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (__workflow_bodyccUsers != null)
                {
                    body["ccUsers"] = ExpressionConverter.ConvertO(__workflow_bodyccUsers);
                    bodypropCount++;
                }

                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTransactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadDocuments(Expression<Func<string>> transactionId, Expression<Func<string>> documentType)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_documentType = WorkflowExpression.Compile(documentType, nameof(documentType), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/il/rssp/v1/transactions/{0}/documents", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentType"] = ExpressionConverter.Convert(__workflow_documentType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodyrecordsPerPage)
        {
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: true);
            var __workflow_bodyrecordsPerPage = WorkflowExpression.Compile(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: true);
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/auth/v1/users/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pageNo"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                bodypropCount++;
                body["perPageRecords"] = ExpressionConverter.ConvertO(__workflow_bodyrecordsPerPage);
                body["paginatedResponse"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<GetUserDetailsResponse, ApiConnectionActionConfiguration> GetUserDetails(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/il/auth/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return new ApiConnectionAction<GetUserDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyphoneCountryCode = null, Expression<Func<string[]>> bodyroles = null, Expression<Func<bool>> bodyfinalMailDisabled = null, Expression<Func<bool>> bodyreminderMailDisabled = null, Expression<Func<bool>> bodysenderMailDisabled = null, Expression<Func<bool>> bodyintegrationUser = null)
        {
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyphoneCountryCode = WorkflowExpression.Compile(bodyphoneCountryCode, nameof(bodyphoneCountryCode), required: false);
            var __workflow_bodyroles = WorkflowExpression.Compile(bodyroles, nameof(bodyroles), required: false);
            var __workflow_bodyfinalMailDisabled = WorkflowExpression.Compile(bodyfinalMailDisabled, nameof(bodyfinalMailDisabled), required: false);
            var __workflow_bodyreminderMailDisabled = WorkflowExpression.Compile(bodyreminderMailDisabled, nameof(bodyreminderMailDisabled), required: false);
            var __workflow_bodysenderMailDisabled = WorkflowExpression.Compile(bodysenderMailDisabled, nameof(bodysenderMailDisabled), required: false);
            var __workflow_bodyintegrationUser = WorkflowExpression.Compile(bodyintegrationUser, nameof(bodyintegrationUser), required: false);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/auth/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemailAddress != null)
                {
                    body["emailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["dateFormat"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneCountryCode != null)
                {
                    body["phoneCountryCode"] = ExpressionConverter.ConvertO(__workflow_bodyphoneCountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyroles != null)
                {
                    body["roles"] = ExpressionConverter.ConvertO(__workflow_bodyroles);
                    bodypropCount++;
                }

                if (__workflow_bodyfinalMailDisabled != null)
                {
                    body["finalMailDisabled"] = ExpressionConverter.ConvertO(__workflow_bodyfinalMailDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderMailDisabled != null)
                {
                    body["reminderMailDisabled"] = ExpressionConverter.ConvertO(__workflow_bodyreminderMailDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodysenderMailDisabled != null)
                {
                    body["senderMailDisabled"] = ExpressionConverter.ConvertO(__workflow_bodysenderMailDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodyintegrationUser != null)
                {
                    body["integrationUser"] = ExpressionConverter.ConvertO(__workflow_bodyintegrationUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSubscription(Expression<Func<string>> webhookId)
        {
            var __workflow_webhookId = WorkflowExpression.Compile(webhookId, nameof(webhookId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/unsubscribe/{0}", __workflow_webhookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionUsingTemplateResponse, ApiConnectionActionConfiguration> CreateTransactionUsingTemplate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string[]>> bodysecondaryTemplateIds = null, Expression<Func<string>> bodymailmessage = null, Expression<Func<bodynotificationSubscriptionsInputItem[]>> bodynotificationSubscriptions = null, Expression<Func<bodyparticipantsInputItem2[]>> bodyparticipants = null, Expression<Func<bodyccUsersInputItem[]>> bodyccUsers = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodysecondaryTemplateIds = WorkflowExpression.Compile(bodysecondaryTemplateIds, nameof(bodysecondaryTemplateIds), required: false);
            var __workflow_bodymailmessage = WorkflowExpression.Compile(bodymailmessage, nameof(bodymailmessage), required: false);
            var __workflow_bodynotificationSubscriptions = WorkflowExpression.Compile(bodynotificationSubscriptions, nameof(bodynotificationSubscriptions), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            var __workflow_bodyccUsers = WorkflowExpression.Compile(bodyccUsers, nameof(bodyccUsers), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<CreateTransactionUsingTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/rssp/v1/transactions/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodysecondaryTemplateIds != null)
                {
                    body["secondaryTemplateIds"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryTemplateIds);
                    bodypropCount++;
                }

                var mailObject = new JObject();
                var mailObjectpropCount = 0;
                if (__workflow_bodymailmessage != null)
                {
                    mailObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymailmessage);
                    mailObjectpropCount++;
                }

                if (mailObjectpropCount > 0)
                {
                    body["mail"] = mailObject;
                    bodypropCount++;
                }

                if (__workflow_bodynotificationSubscriptions != null)
                {
                    body["notificationSubscriptions"] = ExpressionConverter.ConvertO(__workflow_bodynotificationSubscriptions);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (__workflow_bodyccUsers != null)
                {
                    body["ccUsers"] = ExpressionConverter.ConvertO(__workflow_bodyccUsers);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTransactionUsingTemplateResponse>(callPayload);
            });
        }
    }

    public class CertinalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TransactionStatusChanged(Expression<Func<eventTypeInputItem[]>> eventType, FlowRecurrence recurrence = null)
        {
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(__workflow_eventType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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