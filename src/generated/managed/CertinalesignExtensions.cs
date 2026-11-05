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
        public IBodyWorkflowAction<GetTransactionDetailsResponse, ApiConnectionActionConfiguration> GetTransactionDetails(Expression<Func<string>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<GetTransactionDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/il/rssp/v1/transactions/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                return new ApiConnectionAction<GetTransactionDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certinalesign")]
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<CreateTransactionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTransactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/rssp/v1/transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers(Expression<Func<ListUsersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/auth/v1/users/all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/auth/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<CreateTransactionUsingTemplateResponse, ApiConnectionActionConfiguration> CreateTransactionUsingTemplate(Expression<Func<CreateTransactionUsingTemplateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateTransactionUsingTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/il/rssp/v1/transactions/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTransactionUsingTemplateResponse>(callPayload);
            });
        }
    }

    public class CertinalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TransactionStatusChanged(Expression<Func<EventTypeInputItem[]>> eventType, FlowRecurrence recurrence = null)
        {
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(__workflow_eventType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                callPayload.Body = new TransactionStatusChangedBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetTransactionDetailsResponse
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetTransactionDetailsResponseDataType Data { get; set; }
    }

    public class GetTransactionDetailsResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("mail")]
        public GetTransactionDetailsResponseDataTypeMailType Mail { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("createdBy")]
        public GetTransactionDetailsResponseDataTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("sentDate")]
        public string SentDate { get; set; }

        [JsonProperty("lastActionPerformedBy")]
        public GetTransactionDetailsResponseDataTypeLastActionPerformedByType LastActionPerformedBy { get; set; }

        [JsonProperty("expiryAndReminders")]
        public GetTransactionDetailsResponseDataTypeExpiryAndRemindersType ExpiryAndReminders { get; set; }

        [JsonProperty("participants")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("ccUsers")]
        public GetTransactionDetailsResponseDataTypeCcUsersTypeItem[] CcUsers { get; set; }

        [JsonProperty("documents")]
        public GetTransactionDetailsResponseDataTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("customFields")]
        public GetTransactionDetailsResponseDataTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("notificationSubscriptions")]
        public JToken[] NotificationSubscriptions { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("additionalDocuments")]
        public GetTransactionDetailsResponseDataTypeAdditionalDocumentsTypeItem[] AdditionalDocuments { get; set; }

        [JsonProperty("separateAgreements")]
        public bool SeparateAgreements { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeMailType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeCreatedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeLastActionPerformedByType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("candidateId")]
        public string CandidateId { get; set; }

        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeExpiryAndRemindersType
    {
        [JsonProperty("expiresAtTimestamp")]
        public string ExpiresAtTimestamp { get; set; }

        [JsonProperty("expiryDays")]
        public int ExpiryDays { get; set; }

        [JsonProperty("remindFromReminderDays")]
        public int RemindFromReminderDays { get; set; }

        [JsonProperty("remindFromReminderTime")]
        public string RemindFromReminderTime { get; set; }

        [JsonProperty("reminderFrequency")]
        public int ReminderFrequency { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("signingMethodDTO")]
        public string[] SigningMethodDTO { get; set; }

        [JsonProperty("submittedBys")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemSubmittedBysTypeItem[] SubmittedBys { get; set; }

        [JsonProperty("candidates")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("fields")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("signatureBlock")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemSignatureBlockType SignatureBlock { get; set; }

        [JsonProperty("enableDelegate")]
        public bool EnableDelegate { get; set; }

        [JsonProperty("autoProcess")]
        public bool AutoProcess { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemSubmittedBysTypeItem
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("phoneNumber")]
        public JToken PhoneNumber { get; set; }

        [JsonProperty("candidateId")]
        public string CandidateId { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemCandidatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("actionDate")]
        public string ActionDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("authenticationInfo")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType AuthenticationInfo { get; set; }

        [JsonProperty("signingMethodDTO")]
        public string[] SigningMethodDTO { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("deliveryChannels")]
        public string[] DeliveryChannels { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType
    {
        [JsonProperty("authenticationModeValue")]
        public string AuthenticationModeValue { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("validation")]
        public string Validation { get; set; }

        [JsonProperty("nameStyle")]
        public string NameStyle { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("linkType")]
        public string LinkType { get; set; }

        [JsonProperty("radioId")]
        public int RadioId { get; set; }

        [JsonProperty("radioGroupId")]
        public string RadioGroupId { get; set; }

        [JsonProperty("checkboxId")]
        public int CheckboxId { get; set; }

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

        [JsonProperty("vertical")]
        public bool Vertical { get; set; }

        [JsonProperty("topBottom")]
        public bool TopBottom { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemSignatureBlockType
    {
        [JsonProperty("format")]
        public GetTransactionDetailsResponseDataTypeParticipantsTypeItemSignatureBlockTypeFormatTypeItem[] Format { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeParticipantsTypeItemSignatureBlockTypeFormatTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeCcUsersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("deletable")]
        public bool Deletable { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeCustomFieldsTypeItem
    {
        [JsonProperty("customFieldId")]
        public string CustomFieldId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }
    }

    public class GetTransactionDetailsResponseDataTypeAdditionalDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("candidateId")]
        public string CandidateId { get; set; }
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

    public class CreateTransactionBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("mail")]
        public BodyInputMailType Mail { get; set; }

        [JsonProperty("notificationSubscriptions")]
        public BodyInputNotificationSubscriptionsTypeItem[] NotificationSubscriptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("expiryAndReminders")]
        public BodyInputExpiryAndRemindersType ExpiryAndReminders { get; set; }

        [JsonProperty("signatureBlock")]
        public BodyInputSignatureBlockType SignatureBlock { get; set; }

        [JsonProperty("participants")]
        public CreateTransactionBodyInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("ccUsers")]
        public BodyInputCcUsersTypeItem[] CcUsers { get; set; }

        [JsonProperty("documents")]
        public BodyInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("customFields")]
        public BodyInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class BodyInputMailType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class BodyInputNotificationSubscriptionsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("transactionEvents")]
        public string[] TransactionEvents { get; set; }

        [JsonProperty("participantEvents")]
        public string[] ParticipantEvents { get; set; }
    }

    public class BodyInputExpiryAndRemindersType
    {
        [JsonProperty("expiresAtTimestamp")]
        public string ExpiresAtTimestamp { get; set; }

        [JsonProperty("remindFromTimestamp")]
        public string RemindFromTimestamp { get; set; }

        [JsonProperty("reminderFrequency")]
        public int? ReminderFrequency { get; set; }
    }

    public class BodyInputSignatureBlockType
    {
        [JsonProperty("default")]
        public bool? Default { get; set; }
    }

    public class CreateTransactionBodyInputParticipantsTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("candidates")]
        public CreateTransactionBodyInputParticipantsTypeItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("fields")]
        public CreateTransactionBodyInputParticipantsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    public class CreateTransactionBodyInputParticipantsTypeItemCandidatesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("authenticationInfo")]
        public BodyInputParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType AuthenticationInfo { get; set; }

        [JsonProperty("deliveryChannels")]
        public string[] DeliveryChannels { get; set; }
    }

    public class BodyInputParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType
    {
        [JsonProperty("authenticationMode")]
        public string AuthenticationMode { get; set; }

        [JsonProperty("authenticationModeValue")]
        public string AuthenticationModeValue { get; set; }
    }

    public class CreateTransactionBodyInputParticipantsTypeItemFieldsTypeItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("pages")]
        public string[] Pages { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("textareaLineCount")]
        public string TextareaLineCount { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("xposition")]
        public double? Xposition { get; set; }

        [JsonProperty("yposition")]
        public double? Yposition { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readOnly")]
        public bool? ReadOnly { get; set; }

        [JsonProperty("textarea")]
        public bool? Textarea { get; set; }

        [JsonProperty("topBottom")]
        public bool? TopBottom { get; set; }

        [JsonProperty("vertical")]
        public bool? Vertical { get; set; }

        [JsonProperty("radioGroupId")]
        public string RadioGroupId { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }
    }

    public class BodyInputCcUsersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class BodyInputDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("deletable")]
        public bool? Deletable { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }
    }

    public class BodyInputCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("details")]
        public BodyInputCustomFieldsTypeItemDetailsType Details { get; set; }
    }

    public class BodyInputCustomFieldsTypeItemDetailsType
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

    public class ListUsersBodyInput
    {
        [JsonProperty("pageNo", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; }

        [JsonProperty("perPageRecords", DefaultValueHandling = DefaultValueHandling.Include)]
        public int RecordsPerPage { get; set; }

        [JsonProperty("paginatedResponse", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool PaginatedResponse { get; set; } = true;
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

    public class CreateUserBodyInput
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

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

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("finalMailDisabled")]
        public bool? FinalMailDisabled { get; set; }

        [JsonProperty("reminderMailDisabled")]
        public bool? ReminderMailDisabled { get; set; }

        [JsonProperty("senderMailDisabled")]
        public bool? SenderMailDisabled { get; set; }

        [JsonProperty("integrationUser")]
        public bool? IntegrationUser { get; set; }
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

    public class CreateTransactionUsingTemplateBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("secondaryTemplateIds")]
        public string[] SecondaryTemplateIds { get; set; }

        [JsonProperty("mail")]
        public BodyInputMailType Mail { get; set; }

        [JsonProperty("notificationSubscriptions")]
        public BodyInputNotificationSubscriptionsTypeItem[] NotificationSubscriptions { get; set; }

        [JsonProperty("participants")]
        public CreateTransactionUsingTemplateBodyInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("ccUsers")]
        public BodyInputCcUsersTypeItem[] CcUsers { get; set; }

        [JsonProperty("customFields")]
        public BodyInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CreateTransactionUsingTemplateBodyInputParticipantsTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("autoProcess")]
        public bool? AutoProcess { get; set; }

        [JsonProperty("fields")]
        public CreateTransactionUsingTemplateBodyInputParticipantsTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("candidates")]
        public CreateTransactionUsingTemplateBodyInputParticipantsTypeItemCandidatesTypeItem[] Candidates { get; set; }
    }

    public class CreateTransactionUsingTemplateBodyInputParticipantsTypeItemFieldsTypeItem
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTransactionUsingTemplateBodyInputParticipantsTypeItemCandidatesTypeItem
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
        public BodyInputParticipantsTypeItemCandidatesTypeItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class BodyInputParticipantsTypeItemCandidatesTypeItemAttachmentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventTypeInputItem
    {
        SENT,
        PENDING,
        COMPLETED,
        DECLINED,
        CANCELLED,
        EXPIRED
    }

    public class TransactionStatusChangedBodyInput
    {
        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
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