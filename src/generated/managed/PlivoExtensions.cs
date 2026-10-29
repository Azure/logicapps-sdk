//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plivo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlivoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<MakeCallResponse, ApiConnectionActionConfiguration> MakeCall(Expression<Func<string>> callRequestBodyfrom, Expression<Func<string>> callRequestBodyto, Expression<Func<string>> callRequestBodyanswerURL, Expression<Func<string>> callRequestBodyanswerMethod = null)
        {
            var __workflow_callRequestBodyfrom = WorkflowExpression.Compile(callRequestBodyfrom, nameof(callRequestBodyfrom), required: true);
            var __workflow_callRequestBodyto = WorkflowExpression.Compile(callRequestBodyto, nameof(callRequestBodyto), required: true);
            var __workflow_callRequestBodyanswerURL = WorkflowExpression.Compile(callRequestBodyanswerURL, nameof(callRequestBodyanswerURL), required: true);
            var __workflow_callRequestBodyanswerMethod = WorkflowExpression.Compile(callRequestBodyanswerMethod, nameof(callRequestBodyanswerMethod), required: false);
            return new DeferredBodyAction<MakeCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Call/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var callRequestBody = new JObject();
                var callRequestBodypropCount = 0;
                callRequestBodypropCount++;
                callRequestBody["from"] = ExpressionConverter.ConvertO(__workflow_callRequestBodyfrom);
                callRequestBodypropCount++;
                callRequestBody["to"] = ExpressionConverter.ConvertO(__workflow_callRequestBodyto);
                callRequestBodypropCount++;
                callRequestBody["answer_url"] = ExpressionConverter.ConvertO(__workflow_callRequestBodyanswerURL);
                if (__workflow_callRequestBodyanswerMethod != null)
                {
                    callRequestBody["answer_method"] = ExpressionConverter.ConvertO(__workflow_callRequestBodyanswerMethod);
                    callRequestBodypropCount++;
                }

                if (callRequestBodypropCount > 0)
                {
                    callPayload.Body = callRequestBody;
                }

                return new ApiConnectionAction<MakeCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<ListMessagesResponse, ApiConnectionActionConfiguration> ListMessages()
        {
            return new DeferredBodyAction<ListMessagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Message/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListMessagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<string>> sMSRequestBodyfrom, Expression<Func<string>> sMSRequestBodyto, Expression<Func<string>> sMSRequestBodymessage)
        {
            var __workflow_sMSRequestBodyfrom = WorkflowExpression.Compile(sMSRequestBodyfrom, nameof(sMSRequestBodyfrom), required: true);
            var __workflow_sMSRequestBodyto = WorkflowExpression.Compile(sMSRequestBodyto, nameof(sMSRequestBodyto), required: true);
            var __workflow_sMSRequestBodymessage = WorkflowExpression.Compile(sMSRequestBodymessage, nameof(sMSRequestBodymessage), required: true);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Message/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sMSRequestBody = new JObject();
                var sMSRequestBodypropCount = 0;
                sMSRequestBodypropCount++;
                sMSRequestBody["src"] = ExpressionConverter.ConvertO(__workflow_sMSRequestBodyfrom);
                sMSRequestBodypropCount++;
                sMSRequestBody["dst"] = ExpressionConverter.ConvertO(__workflow_sMSRequestBodyto);
                sMSRequestBodypropCount++;
                sMSRequestBody["text"] = ExpressionConverter.ConvertO(__workflow_sMSRequestBodymessage);
                if (sMSRequestBodypropCount > 0)
                {
                    callPayload.Body = sMSRequestBody;
                }

                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<GetMessageResponse, ApiConnectionActionConfiguration> GetMessage(Expression<Func<string>> messageUuid)
        {
            var __workflow_messageUuid = WorkflowExpression.Compile(messageUuid, nameof(messageUuid), required: true);
            return new DeferredBodyAction<GetMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Message/{1}/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1), __workflow_messageUuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessageResponse>(callPayload);
            });
        }
    }

    public class PlivoTriggers([ConnectionName] string connectionId)
    {
    }

    public class MakeCallResponse
    {
        [JsonProperty("api_id")]
        public string APIId { get; set; }

        [JsonProperty("message")]
        public string Response { get; set; }

        [JsonProperty("request_uuid")]
        public string CallUUID { get; set; }
    }

    public class ListMessagesResponse
    {
        [JsonProperty("api_id")]
        public string APIId { get; set; }

        [JsonProperty("meta")]
        public ListMessagesResponseMetaInformationType MetaInformation { get; set; }

        [JsonProperty("objects")]
        public ListMessagesResponseMessageListTypeItem[] MessageList { get; set; }
    }

    public class ListMessagesResponseMetaInformationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class ListMessagesResponseMessageListTypeItem
    {
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("from_number")]
        public string From { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("message_state")]
        public string MessageDeliveryStatus { get; set; }

        [JsonProperty("message_time")]
        public string Timestamp { get; set; }

        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("message_uuid")]
        public string MessageUUID { get; set; }

        [JsonProperty("resource_uri")]
        public string MessageURI { get; set; }

        [JsonProperty("to_number")]
        public string To { get; set; }

        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        [JsonProperty("total_rate")]
        public string Rate { get; set; }

        [JsonProperty("units")]
        public int Units { get; set; }
    }

    public class SendSMSResponse
    {
        [JsonProperty("api_id")]
        public string APIId { get; set; }

        [JsonProperty("message")]
        public string Response { get; set; }

        [JsonProperty("message_uuid")]
        public string[] MessageUUID { get; set; }
    }

    public class GetMessageResponse
    {
        [JsonProperty("api_id")]
        public string APIId { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("from_number")]
        public string From { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("message_state")]
        public string MessageDeliveryStatus { get; set; }

        [JsonProperty("message_time")]
        public string Timestamp { get; set; }

        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("message_uuid")]
        public string MessageUUID { get; set; }

        [JsonProperty("resource_uri")]
        public string MessageURI { get; set; }

        [JsonProperty("to_number")]
        public string To { get; set; }

        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        [JsonProperty("total_rate")]
        public string Rate { get; set; }

        [JsonProperty("units")]
        public int Units { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plivo;

    public partial class WorkflowManagedActions
    {
        public PlivoActions Plivo(string connectionId) => new PlivoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlivoTriggers Plivo(string connectionId) => new PlivoTriggers(connectionId);
    }
}