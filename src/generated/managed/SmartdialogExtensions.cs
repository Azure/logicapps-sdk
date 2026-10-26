//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartdialogActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<SendMessageInput>> requestBody)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendReplyMessageResponse, ApiConnectionActionConfiguration> SendReplyMessage(Expression<Func<string>> parentMessageId, Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<SendReplyMessageInput>> requestBody)
        {
            var __workflow_parentMessageId = WorkflowExpression.Compile(parentMessageId, nameof(parentMessageId), required: true);
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<SendReplyMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/reply/{0}", __workflow_parentMessageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<SendReplyMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse, ApiConnectionActionConfiguration> SendDiscussionReplyMessage(Expression<Func<string>> customerId, Expression<Func<SendDiscussionReplyMessageInput>> requestBody)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<SendDiscussionReplyMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/discussion/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["CustomerId"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<SendDiscussionReplyMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateWhatsappTemplate(Expression<Func<string>> customerId, Expression<Func<string>> identityNumber, Expression<Func<CreateWhatsappTemplateInput>> requestBody)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_identityNumber = WorkflowExpression.Compile(identityNumber, nameof(identityNumber), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/whatsapp/templates/{0}/{1}", __workflow_customerId.WithUrlEncoding(1), __workflow_identityNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse, ApiConnectionActionConfiguration> SendWhatsappTemplateMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<SendWhatsappTemplateMessageInput>> requestBody)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<SendWhatsappTemplateMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/templates/whatsapp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<SendWhatsappTemplateMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<GetGroupContactResponse, ApiConnectionActionConfiguration> GetGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<string>> region = null)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_groupService = WorkflowExpression.Compile(groupService, nameof(groupService), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            return new DeferredBodyAction<GetGroupContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groupcontact/{0}/{1}/{2}", __workflow_customer.WithUrlEncoding(1), __workflow_groupService.WithUrlEncoding(1), __workflow_phone.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_region != null)
                    callPayload.Queries["Region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<GetGroupContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> DeleteGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_groupService = WorkflowExpression.Compile(groupService, nameof(groupService), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groupcontact/{0}/{1}/{2}", __workflow_customer.WithUrlEncoding(1), __workflow_groupService.WithUrlEncoding(1), __workflow_phone.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> UpdateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<UpdateGroupContactInput>> requestBody)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_groupService = WorkflowExpression.Compile(groupService, nameof(groupService), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groupcontact/{0}/{1}/{2}", __workflow_customer.WithUrlEncoding(1), __workflow_groupService.WithUrlEncoding(1), __workflow_phone.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> DeleteAllGroupContacts(Expression<Func<string>> customer, Expression<Func<string>> groupService)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_groupService = WorkflowExpression.Compile(groupService, nameof(groupService), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groupcontact/{0}/{1}", __workflow_customer.WithUrlEncoding(1), __workflow_groupService.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<CreateGroupContactInput>> requestBody)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_groupService = WorkflowExpression.Compile(groupService, nameof(groupService), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groupcontact/{0}/{1}", __workflow_customer.WithUrlEncoding(1), __workflow_groupService.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class SmartdialogTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMessageResponse, ApiConnectionTriggerConfiguration> NewMessage(Expression<Func<string>> customer, Expression<Func<string>> service, Expression<Func<NewMessageInput>> createWebhookRequestBody, FlowRecurrence recurrence = null)
        {
            var __workflow_customer = WorkflowExpression.Compile(customer, nameof(customer), required: true);
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_createWebhookRequestBody = WorkflowExpression.Compile(createWebhookRequestBody, nameof(createWebhookRequestBody), required: true);
            return new DeferredBodyTrigger<NewMessageResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/service/{0}/pipelines/actions", __workflow_service.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer"] = ExpressionConverter.Convert(__workflow_customer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createWebhookRequestBody);
                return new ApiConnectionTrigger<NewMessageResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class SendMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sender { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageInputProtocolType Protocol { get; set; } = SendMessageInputProtocolType.SMS;
        public string SendDateTime { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageInputRecipientsTypeItem[] Recipients { get; set; }
        public string AttachmentUri { get; set; }
        public string CustomerData { get; set; }
        public bool? AdMessage { get; set; }
        public string DlrUrl { get; set; }
        public string RequestId { get; set; }
        public SendMessageInputUnicodeCharacterHandlingPolicyType? UnicodeCharacterHandlingPolicy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageInputProtocolType
    {
        SMS
    }

    public class SendMessageInputRecipientsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
        public JToken Personalization { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageInputUnicodeCharacterHandlingPolicyType
    {
        None,
        Strict,
        Replace
    }

    public class SendReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class SendReplyMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sender { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendReplyMessageInputProtocolType Protocol { get; set; } = SendReplyMessageInputProtocolType.SMS;
        public string SendDateTime { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendReplyMessageInputRecipientsTypeItem[] Recipients { get; set; }
        public string AttachmentUri { get; set; }
        public string CustomerData { get; set; }
        public bool? AdMessage { get; set; }
        public string DlrUrl { get; set; }
        public string RequestId { get; set; }
        public SendReplyMessageInputUnicodeCharacterHandlingPolicyType? UnicodeCharacterHandlingPolicy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendReplyMessageInputProtocolType
    {
        SMS
    }

    public class SendReplyMessageInputRecipientsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
        public JToken Personalization { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendReplyMessageInputUnicodeCharacterHandlingPolicyType
    {
        None,
        Strict,
        Replace
    }

    public class SendDiscussionReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendDiscussionReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
        public string ThreadId { get; set; }
    }

    public class SendDiscussionReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class SendDiscussionReplyMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
        public string CustomerData { get; set; }
    }

    public class CreateWhatsappTemplateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RawContent { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }
        public CreateWhatsappTemplateInputButtonsTypeItem[] Buttons { get; set; }
        public string AttachmentUrl { get; set; }
    }

    public class CreateWhatsappTemplateInputButtonsTypeItem
    {
        public CreateWhatsappTemplateInputButtonsTypeItemTypeType? Type { get; set; }
        public string Label { get; set; }
        public string Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWhatsappTemplateInputButtonsTypeItemTypeType
    {
        Call,
        QuickReply,
        Url
    }

    public class SendWhatsappTemplateMessageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("messagePartCount")]
        public int MessagePartCount { get; set; }

        [JsonProperty("recipients")]
        public SendWhatsappTemplateMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendWhatsappTemplateMessageResponseRecipientsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SendWhatsappTemplateMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsappTemplateMessageInputRecipientsTypeItem[] Recipients { get; set; }
        public string[] BodyParameters { get; set; }
        public string[] HeaderParameters { get; set; }
        public SendWhatsappTemplateMessageInputButtonsTypeItem[] Buttons { get; set; }
        public string SendDateTime { get; set; }
        public string AttachmentUri { get; set; }
        public bool? UseSmsFallback { get; set; }
        public string DlrUrl { get; set; }
        public string CustomerData { get; set; }
        public string RequestId { get; set; }
    }

    public class SendWhatsappTemplateMessageInputRecipientsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class SendWhatsappTemplateMessageInputButtonsTypeItem
    {
        public SendWhatsappTemplateMessageInputButtonsTypeItemTypeType? Type { get; set; }
        public string Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendWhatsappTemplateMessageInputButtonsTypeItemTypeType
    {
        Call,
        QuickReply,
        Url
    }

    public class GetGroupContactResponse
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public GetGroupContactResponseGenderType Gender { get; set; }

        [JsonProperty("birthYear")]
        public int BirthYear { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("failedMessages")]
        public int FailedMessages { get; set; }

        [JsonProperty("customContactProperties")]
        public GetGroupContactResponseCustomContactPropertiesTypeItem[] CustomContactProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetGroupContactResponseGenderType
    {
        Male,
        Female,
        Other
    }

    public class GetGroupContactResponseCustomContactPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateGroupContactInput
    {
        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Active { get; set; } = true;

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public UpdateGroupContactInputGenderType? Gender { get; set; }

        [JsonProperty("birthYear")]
        public int? BirthYear { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("customContactProperties")]
        public UpdateGroupContactInputCustomContactPropertiesTypeItem[] CustomContactProperties { get; set; }

        [JsonProperty("phoneNumberRegions")]
        public string[] PhoneNumberRegions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGroupContactInputGenderType
    {
        Male,
        Female,
        Other
    }

    public class UpdateGroupContactInputCustomContactPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateGroupContactInput
    {
        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Active { get; set; } = true;

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public CreateGroupContactInputGenderType? Gender { get; set; }

        [JsonProperty("birthYear")]
        public int? BirthYear { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("customContactProperties")]
        public CreateGroupContactInputCustomContactPropertiesTypeItem[] CustomContactProperties { get; set; }

        [JsonProperty("phoneNumberRegions")]
        public string[] PhoneNumberRegions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGroupContactInputGenderType
    {
        Male,
        Female,
        Other
    }

    public class CreateGroupContactInputCustomContactPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class NewMessageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class NewMessageInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "PowerAutomate (Auto Created Webhook)";

        [JsonProperty("actionType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ActionType { get; set; } = "HttpRequest";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "PowerAutomate auto-created webhook. Please don´t modify. Will be removed by PowerAutomate , when the Flow/Logic App is disabled or removed";

        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewMessageInputOptionsType Options { get; set; }
    }

    public class NewMessageInputOptionsType
    {
        [JsonProperty("endpointUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EndpointUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("httpVerb", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HttpVerb { get; set; } = "POST";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog;

    public partial class WorkflowManagedActions
    {
        public SmartdialogActions Smartdialog(string connectionId) => new SmartdialogActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmartdialogTriggers Smartdialog(string connectionId) => new SmartdialogTriggers(connectionId);
    }
}