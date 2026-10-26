//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sinch
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SinchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<SendSmsResponse, ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/int-power-automate/send-message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<GetSenderIdResponse, ApiConnectionActionConfiguration> GetSenderId()
        {
            return new DeferredBodyAction<GetSenderIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/int-power-automate/v1/int-crm/integrations/account/sender-id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSenderIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<SendMmsResponse, ApiConnectionActionConfiguration> SendMms(Expression<Func<SendMmsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/int-power-automate/send-mms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<Message, ApiConnectionActionConfiguration> GetMessageStatus(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<Message, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Message>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendRCS(Expression<Func<object>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/int-power-automate/send-message-v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SinchTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MessageArrived(Expression<Func<MessageArrivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GetDeliveryReceipt(Expression<Func<GetDeliveryReceiptInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/deliveryreports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendSmsResponse
    {
        [JsonProperty("messages")]
        public SendSmsResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class SendSmsResponseMessagesTypeItem
    {
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("delivery_report")]
        public bool DeliveryReport { get; set; }

        [JsonProperty("destination_number")]
        public string DestinationNumber { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("message_expiry_timestamp")]
        public string MessageExpiryTimestamp { get; set; }

        [JsonProperty("message_flags")]
        public JToken[] MessageFlags { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("metadata")]
        public SendSmsResponseMessagesTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("scheduled")]
        public string Scheduled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("media")]
        public string[] Media { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class SendSmsResponseMessagesTypeItemMetadataType
    {
        public string Source { get; set; }
    }

    public class SendSmsInput
    {
        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("delivery_report", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeliveryReport { get; set; } = true;

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("metadata")]
        public SendSmsInputMetadataTypeItem[] Metadata { get; set; }
    }

    public class SendSmsInputMetadataTypeItem
    {
        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("metadata_value")]
        public string MetadataValue { get; set; }
    }

    public class GetSenderIdResponse
    {
        [JsonProperty("pagination")]
        public GetSenderIdResponsePaginationType Pagination { get; set; }

        [JsonProperty("default_sender")]
        public GetSenderIdResponseDefaultSenderType DefaultSender { get; set; }

        [JsonProperty("senders")]
        public GetSenderIdResponseSendersTypeItem[] Senders { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("vendor_id")]
        public string VendorId { get; set; }
    }

    public class GetSenderIdResponsePaginationType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }
    }

    public class GetSenderIdResponseDefaultSenderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("mms_capable")]
        public bool MmsCapable { get; set; }
    }

    public class GetSenderIdResponseSendersTypeItem
    {
        [JsonProperty("display_type")]
        public string DisplayType { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("mms_capable")]
        public bool MmsCapable { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("number_id")]
        public string NumberId { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number_status")]
        public string NumberStatus { get; set; }
    }

    public class SendMmsResponse
    {
        [JsonProperty("messages")]
        public SendMmsResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class SendMmsResponseMessagesTypeItem
    {
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("delivery_report")]
        public bool DeliveryReport { get; set; }

        [JsonProperty("destination_number")]
        public string DestinationNumber { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("message_expiry_timestamp")]
        public string MessageExpiryTimestamp { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("metadata")]
        public SendMmsResponseMessagesTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("scheduled")]
        public string Scheduled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("media")]
        public string[] Media { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class SendMmsResponseMessagesTypeItemMetadataType
    {
        public string Source { get; set; }
    }

    public class SendMmsInput
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("metadata")]
        public SendMmsInputMetadataTypeItem[] Metadata { get; set; }
    }

    public class SendMmsInputMetadataTypeItem
    {
        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("metadata_value")]
        public string MetadataValue { get; set; }
    }

    public class Message
    {
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("delivery_report")]
        public bool DeliveryReport { get; set; }

        [JsonProperty("destination_number")]
        public string DestinationNumber { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("message_expiry_timestamp")]
        public string MessageExpiryTimestamp { get; set; }

        [JsonProperty("message_flags")]
        public JToken[] MessageFlags { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("metadata")]
        public MessageMetadataType Metadata { get; set; }

        [JsonProperty("scheduled")]
        public string Scheduled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("media")]
        public string[] Media { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class MessageMetadataType
    {
        public string Source { get; set; }
    }

    public class MessageArrivedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Method { get; set; } = "POST";

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Encoding { get; set; } = "JSON";

        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageArrivedInputHeadersType Headers { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Template { get; set; } = "{#if($version == 2)\"contact_message\":$jsonUtils.toJson($contact_message),#end#if($moContent)\"content\":\"$esc.json($moContent)\",#end#if($messageId)\"message_id\": \"$messageId\",#end\"type\":\"$type\",#if($moId)\"reply_id\":\"$moId\",#end#if($statusCode)\"status_code\":\"$statusCode\",#end#if($status)\"status\":\"$status\",#end#if($submittedTimestamp)\"submitted_date\":\"$submittedTimestamp\",#end#if($receivedTimestamp)\"date_received\":\"$receivedTimestamp\",#end\"source_address\":\"$sourceAddress\",#if($destinationAddress)\"destination_address\":\"$destinationAddress\",#end\"attachments\": [#foreach ($entry in $attachments){\"attachment_type\":\"$entry.contentType\",\"attachment_content\":\"$entry.base64\",\"attachment_name\":\"$entry.originalName\"}#if($foreach.hasNext),#end#end],\"metadata\":[#foreach ($entry in $metadata.entrySet()){\"metadata_key\":\"$entry.key\",\"metadata_value\":\"$esc.json($entry.value)\"}#if($foreach.hasNext),#end#end]}";
    }

    public class MessageArrivedInputHeadersType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Platform { get; set; } = "PowerAutomate";
    }

    public class GetDeliveryReceiptInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Method { get; set; } = "POST";

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Encoding { get; set; } = "JSON";

        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDeliveryReceiptInputHeadersType Headers { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Template { get; set; } = "{\"delivery_report_id\":\"$drId\",#if($statusCode)\"status_code\":\"$statusCode\",#end#if($status)\"status\":\"$status\",#end#if($destinationAddress)\"destination_address\":\"$destinationAddress\",#end#if($submittedTimestamp)\"submitted_date\":\"$submittedTimestamp\",#end#if($receivedTimestamp)\"date_received\":\"$receivedTimestamp\",#end\"type\":\"$type\",\"message_id\":\"$messageId\",\"source_address\":\"$sourceAddress\",\"content\":\"$esc.json($mtContent)\",\"attachments\":[#foreach ($entry in $attachments){\"attachment_type\":\"$entry.contentType\",\"attachment_content\":\"$entry.base64\",\"attachment_name\":\"$entry.originalName\"}#if( $foreach.hasNext ),#end#end],\"metadata\":[#foreach ($entry in $metadata.entrySet()){\"metadata_key\":\"$entry.key\",\"metadata_value\":\"$esc.json($entry.value)\"}#if( $foreach.hasNext ),#end#end]}";
    }

    public class GetDeliveryReceiptInputHeadersType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Platform { get; set; } = "PowerAutomate";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sinch;

    public partial class WorkflowManagedActions
    {
        public SinchActions Sinch(string connectionId) => new SinchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SinchTriggers Sinch(string connectionId) => new SinchTriggers(connectionId);
    }
}