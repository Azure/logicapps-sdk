//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plivo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlivoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<MakeCallResponse> MakeCall(Expression<Func<string>> callRequestBodyfrom, Expression<Func<string>> callRequestBodyto, Expression<Func<string>> callRequestBodyanswerURL, Expression<Func<string>> callRequestBodyanswerMethod = null)
        {
            var apiCallPath = String.Format("/v1/Account/{0}/Call/", ExpressionConverter.ConvertWithUrlEncoding(authId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var callRequestBody = new JObject();
            var callRequestBodypropCount = 0;
            callRequestBodypropCount++;
            callRequestBody["from"] = ExpressionConverter.ConvertO(callRequestBodyfrom);
            callRequestBodypropCount++;
            callRequestBody["to"] = ExpressionConverter.ConvertO(callRequestBodyto);
            callRequestBodypropCount++;
            callRequestBody["answer_url"] = ExpressionConverter.ConvertO(callRequestBodyanswerURL);
            if (callRequestBodyanswerMethod != null)
            {
                callRequestBody["answer_method"] = ExpressionConverter.ConvertO(callRequestBodyanswerMethod);
                callRequestBodypropCount++;
            }

            if (callRequestBodypropCount > 0)
            {
                callPayload.Body = callRequestBody;
            }

            return new ApiConnectionAction<MakeCallResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<ListMessagesResponse> ListMessages()
        {
            var apiCallPath = String.Format("/v1/Account/{0}/Message/", ExpressionConverter.ConvertWithUrlEncoding(authId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListMessagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> sMSRequestBodyfrom, Expression<Func<string>> sMSRequestBodyto, Expression<Func<string>> sMSRequestBodymessage)
        {
            var apiCallPath = String.Format("/v1/Account/{0}/Message/", ExpressionConverter.ConvertWithUrlEncoding(authId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sMSRequestBody = new JObject();
            var sMSRequestBodypropCount = 0;
            sMSRequestBodypropCount++;
            sMSRequestBody["src"] = ExpressionConverter.ConvertO(sMSRequestBodyfrom);
            sMSRequestBodypropCount++;
            sMSRequestBody["dst"] = ExpressionConverter.ConvertO(sMSRequestBodyto);
            sMSRequestBodypropCount++;
            sMSRequestBody["text"] = ExpressionConverter.ConvertO(sMSRequestBodymessage);
            if (sMSRequestBodypropCount > 0)
            {
                callPayload.Body = sMSRequestBody;
            }

            return new ApiConnectionAction<SendSMSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<GetMessageResponse> GetMessage(Expression<Func<string>> messageUuid)
        {
            var apiCallPath = String.Format("/v1/Account/{0}/Message/{1}/", ExpressionConverter.ConvertWithUrlEncoding(authId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageUuid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMessageResponse>(callPayload);
        }
    }

    public class PlivoTriggers([ConnectionName] string connectionId)
    {
    }

    public class MakeCallResponse
    {
        [JsonProperty("api_id")]
        public string APIID { get; set; }

        [JsonProperty("message")]
        public string Response { get; set; }

        [JsonProperty("request_uuid")]
        public string CallUUID { get; set; }
    }

    public class ListMessagesResponse
    {
        [JsonProperty("api_id")]
        public string APIID { get; set; }

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
        public string APIID { get; set; }

        [JsonProperty("message")]
        public string Response { get; set; }

        [JsonProperty("message_uuid")]
        public string[] MessageUUID { get; set; }
    }

    public class GetMessageResponse
    {
        [JsonProperty("api_id")]
        public string APIID { get; set; }

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