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
        public IBodyWorkflowAction<MakeCallResponse, ApiConnectionActionConfiguration> MakeCall(Expression<Func<MakeCallInput>> callRequestBody)
        {
            var __workflow_callRequestBody = WorkflowExpression.Compile(callRequestBody, nameof(callRequestBody), required: true);
            return new DeferredBodyAction<MakeCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Call/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_callRequestBody);
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
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<SendSMSInput>> sMSRequestBody)
        {
            var __workflow_sMSRequestBody = WorkflowExpression.Compile(sMSRequestBody, nameof(sMSRequestBody), required: true);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Account/{0}/Message/", WorkflowExpression.Literal("auth_id_value").WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sMSRequestBody);
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

    public class MakeCallInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("answer_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AnswerURL { get; set; }

        [JsonProperty("answer_method")]
        public string AnswerMethod { get; set; }
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

    public class SendSMSInput
    {
        [JsonProperty("src", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("dst", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
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