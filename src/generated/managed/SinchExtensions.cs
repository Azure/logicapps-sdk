//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sinch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SinchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodysourceNumber = null, [WorkflowExpression] Func<bool> bodydeliveryReport = null, [WorkflowExpression] Func<string> bodycallbackUrl = null, [WorkflowExpression] Func<bodymetadataInputItem[]> bodymetadata = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodysourceNumber, nameof(bodysourceNumber), required: false);
            SourceExpression.Validate(bodydeliveryReport, nameof(bodydeliveryReport), required: false);
            SourceExpression.Validate(bodycallbackUrl, nameof(bodycallbackUrl), required: false);
            SourceExpression.Validate(bodymetadata, nameof(bodymetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/int-power-automate/send-message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysourceNumber != null)
                {
                    body["source_number"] = SourceExpressionConverter.ConvertToken(bodysourceNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodydeliveryReport != null)
                {
                    if (bodydeliveryReport != null)
                    {
                        body["delivery_report"] = SourceExpressionConverter.ConvertToken(bodydeliveryReport);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["delivery_report"] = true;
                    bodypropCount++;
                }

                if (bodycallbackUrl != null)
                {
                    body["callback_url"] = SourceExpressionConverter.ConvertToken(bodycallbackUrl);
                    bodypropCount++;
                }

                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSmsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<GetSenderIdResponse> GetSenderId()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/int-power-automate/v1/int-crm/integrations/account/sender-id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSenderIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<SendMmsResponse> SendMms([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodymedia = null, [WorkflowExpression] Func<string> bodysourceNumber = null, [WorkflowExpression] Func<bodymetadataInputItem[]> bodymetadata = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodymedia, nameof(bodymedia), required: false);
            SourceExpression.Validate(bodysourceNumber, nameof(bodysourceNumber), required: false);
            SourceExpression.Validate(bodymetadata, nameof(bodymetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/int-power-automate/send-mms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodymedia != null)
                {
                    body["media"] = SourceExpressionConverter.ConvertToken(bodymedia);
                    bodypropCount++;
                }

                if (bodysourceNumber != null)
                {
                    body["source_number"] = SourceExpressionConverter.ConvertToken(bodysourceNumber);
                    bodypropCount++;
                }

                if (bodymetadata != null)
                {
                    body["metadata"] = SourceExpressionConverter.ConvertToken(bodymetadata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMmsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IBodyWorkflowAction<Message> GetMessageStatus([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Message>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sinch")]
        public IWorkflowAction SendRCS([WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/int-power-automate/send-message-v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class SinchTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger MessageArrived(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["method"] = "POST";
                bodypropCount++;
                body["encoding"] = "JSON";
                bodypropCount++;
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                headersObject["Platform"] = "PowerAutomate";
                headersObjectpropCount++;
                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                body["template"] = "{#if($version == 2)\"contact_message\":$jsonUtils.toJson($contact_message),#end#if($moContent)\"content\":\"$esc.json($moContent)\",#end#if($messageId)\"message_id\": \"$messageId\",#end\"type\":\"$type\",#if($moId)\"reply_id\":\"$moId\",#end#if($statusCode)\"status_code\":\"$statusCode\",#end#if($status)\"status\":\"$status\",#end#if($submittedTimestamp)\"submitted_date\":\"$submittedTimestamp\",#end#if($receivedTimestamp)\"date_received\":\"$receivedTimestamp\",#end\"source_address\":\"$sourceAddress\",#if($destinationAddress)\"destination_address\":\"$destinationAddress\",#end\"attachments\": [#foreach ($entry in $attachments){\"attachment_type\":\"$entry.contentType\",\"attachment_content\":\"$entry.base64\",\"attachment_name\":\"$entry.originalName\"}#if($foreach.hasNext),#end#end],\"metadata\":[#foreach ($entry in $metadata.entrySet()){\"metadata_key\":\"$entry.key\",\"metadata_value\":\"$esc.json($entry.value)\"}#if($foreach.hasNext),#end#end]}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GetDeliveryReceipt(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/deliveryreports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["method"] = "POST";
                bodypropCount++;
                body["encoding"] = "JSON";
                bodypropCount++;
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                headersObject["Platform"] = "PowerAutomate";
                headersObjectpropCount++;
                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                body["template"] = "{\"delivery_report_id\":\"$drId\",#if($statusCode)\"status_code\":\"$statusCode\",#end#if($status)\"status\":\"$status\",#end#if($destinationAddress)\"destination_address\":\"$destinationAddress\",#end#if($submittedTimestamp)\"submitted_date\":\"$submittedTimestamp\",#end#if($receivedTimestamp)\"date_received\":\"$receivedTimestamp\",#end\"type\":\"$type\",\"message_id\":\"$messageId\",\"source_address\":\"$sourceAddress\",\"content\":\"$esc.json($mtContent)\",\"attachments\":[#foreach ($entry in $attachments){\"attachment_type\":\"$entry.contentType\",\"attachment_content\":\"$entry.base64\",\"attachment_name\":\"$entry.originalName\"}#if( $foreach.hasNext ),#end#end],\"metadata\":[#foreach ($entry in $metadata.entrySet()){\"metadata_key\":\"$entry.key\",\"metadata_value\":\"$esc.json($entry.value)\"}#if( $foreach.hasNext ),#end#end]}";
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

    public class bodymetadataInputItem
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