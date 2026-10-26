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
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<CreateTransactionInput>> body)
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
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers(Expression<Func<ListUsersInput>> body)
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
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body = null)
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
        public IBodyWorkflowAction<CreateTransactionUsingTemplateResponse, ApiConnectionActionConfiguration> CreateTransactionUsingTemplate(Expression<Func<CreateTransactionUsingTemplateInput>> body = null)
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TransactionStatusChanged(Expression<Func<eventTypeInputItem[]>> eventType, Expression<Func<TransactionStatusChangedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(__workflow_eventType);
                callPayload.Headers["Integration-Platform"] = Convert.ToString("MS_Power_Automate");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateTransactionInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("mail")]
        public CreateTransactionInputMailType Mail { get; set; }

        [JsonProperty("notificationSubscriptions")]
        public CreateTransactionInputNotificationSubscriptionsTypeItem[] NotificationSubscriptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("expiryAndReminders")]
        public CreateTransactionInputExpiryAndRemindersType ExpiryAndReminders { get; set; }

        [JsonProperty("signatureBlock")]
        public CreateTransactionInputSignatureBlockType SignatureBlock { get; set; }

        [JsonProperty("participants")]
        public CreateTransactionInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("ccUsers")]
        public CreateTransactionInputCcUsersTypeItem[] CcUsers { get; set; }

        [JsonProperty("documents")]
        public CreateTransactionInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("customFields")]
        public CreateTransactionInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CreateTransactionInputMailType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateTransactionInputNotificationSubscriptionsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("transactionEvents")]
        public string[] TransactionEvents { get; set; }

        [JsonProperty("participantEvents")]
        public string[] ParticipantEvents { get; set; }
    }

    public class CreateTransactionInputExpiryAndRemindersType
    {
        [JsonProperty("expiresAtTimestamp")]
        public string ExpiresAtTimestamp { get; set; }

        [JsonProperty("remindFromTimestamp")]
        public string RemindFromTimestamp { get; set; }

        [JsonProperty("reminderFrequency")]
        public int? ReminderFrequency { get; set; }
    }

    public class CreateTransactionInputSignatureBlockType
    {
        [JsonProperty("default")]
        public bool? Default { get; set; }
    }

    public class CreateTransactionInputParticipantsTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("candidates")]
        public CreateTransactionInputParticipantsTypeItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("fields")]
        public CreateTransactionInputParticipantsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    public class CreateTransactionInputParticipantsTypeItemCandidatesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("authenticationInfo")]
        public CreateTransactionInputParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType AuthenticationInfo { get; set; }

        [JsonProperty("deliveryChannels")]
        public string[] DeliveryChannels { get; set; }
    }

    public class CreateTransactionInputParticipantsTypeItemCandidatesTypeItemAuthenticationInfoType
    {
        [JsonProperty("authenticationMode")]
        public string AuthenticationMode { get; set; }

        [JsonProperty("authenticationModeValue")]
        public string AuthenticationModeValue { get; set; }
    }

    public class CreateTransactionInputParticipantsTypeItemFieldsTypeItem
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

    public class CreateTransactionInputCcUsersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CreateTransactionInputDocumentsTypeItem
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

    public class CreateTransactionInputCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("details")]
        public CreateTransactionInputCustomFieldsTypeItemDetailsType Details { get; set; }
    }

    public class CreateTransactionInputCustomFieldsTypeItemDetailsType
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

    public class ListUsersInput
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

    public class CreateUserInput
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

    public class CreateTransactionUsingTemplateInput
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
        public CreateTransactionUsingTemplateInputMailType Mail { get; set; }

        [JsonProperty("notificationSubscriptions")]
        public CreateTransactionUsingTemplateInputNotificationSubscriptionsTypeItem[] NotificationSubscriptions { get; set; }

        [JsonProperty("participants")]
        public CreateTransactionUsingTemplateInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("ccUsers")]
        public CreateTransactionUsingTemplateInputCcUsersTypeItem[] CcUsers { get; set; }

        [JsonProperty("customFields")]
        public CreateTransactionUsingTemplateInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CreateTransactionUsingTemplateInputMailType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateTransactionUsingTemplateInputNotificationSubscriptionsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("transactionEvents")]
        public string[] TransactionEvents { get; set; }

        [JsonProperty("participantEvents")]
        public string[] ParticipantEvents { get; set; }
    }

    public class CreateTransactionUsingTemplateInputParticipantsTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("autoProcess")]
        public bool? AutoProcess { get; set; }

        [JsonProperty("fields")]
        public CreateTransactionUsingTemplateInputParticipantsTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("candidates")]
        public CreateTransactionUsingTemplateInputParticipantsTypeItemCandidatesTypeItem[] Candidates { get; set; }
    }

    public class CreateTransactionUsingTemplateInputParticipantsTypeItemFieldsTypeItem
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTransactionUsingTemplateInputParticipantsTypeItemCandidatesTypeItem
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
        public CreateTransactionUsingTemplateInputParticipantsTypeItemCandidatesTypeItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class CreateTransactionUsingTemplateInputParticipantsTypeItemCandidatesTypeItemAttachmentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }
    }

    public class CreateTransactionUsingTemplateInputCcUsersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CreateTransactionUsingTemplateInputCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("details")]
        public CreateTransactionUsingTemplateInputCustomFieldsTypeItemDetailsType Details { get; set; }
    }

    public class CreateTransactionUsingTemplateInputCustomFieldsTypeItemDetailsType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
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

    public class TransactionStatusChangedInput
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