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
        public IBodyWorkflowAction<MakeCallResponse> MakeCall([WorkflowExpression] Func<string> callRequestBodyfrom, [WorkflowExpression] Func<string> callRequestBodyto, [WorkflowExpression] Func<string> callRequestBodyanswerURL, [WorkflowExpression] Func<string> callRequestBodyanswerMethod = null)
        {
            SourceExpression.Validate(callRequestBodyfrom, nameof(callRequestBodyfrom), required: true);
            SourceExpression.Validate(callRequestBodyto, nameof(callRequestBodyto), required: true);
            SourceExpression.Validate(callRequestBodyanswerURL, nameof(callRequestBodyanswerURL), required: true);
            SourceExpression.Validate(callRequestBodyanswerMethod, nameof(callRequestBodyanswerMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Account/{0}/Call/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "auth_id_value"), 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var callRequestBody = new JObject();
                var callRequestBodypropCount = 0;
                callRequestBodypropCount++;
                callRequestBody["from"] = SourceExpressionConverter.ConvertToken(callRequestBodyfrom);
                callRequestBodypropCount++;
                callRequestBody["to"] = SourceExpressionConverter.ConvertToken(callRequestBodyto);
                callRequestBodypropCount++;
                callRequestBody["answer_url"] = SourceExpressionConverter.ConvertToken(callRequestBodyanswerURL);
                if (callRequestBodyanswerMethod != null)
                {
                    callRequestBody["answer_method"] = SourceExpressionConverter.ConvertToken(callRequestBodyanswerMethod);
                    callRequestBodypropCount++;
                }

                if (callRequestBodypropCount > 0)
                {
                    callPayload.Body = callRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MakeCallResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<ListMessagesResponse> ListMessages()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Account/{0}/Message/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "auth_id_value"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListMessagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> sMSRequestBodyfrom, [WorkflowExpression] Func<string> sMSRequestBodyto, [WorkflowExpression] Func<string> sMSRequestBodymessage)
        {
            SourceExpression.Validate(sMSRequestBodyfrom, nameof(sMSRequestBodyfrom), required: true);
            SourceExpression.Validate(sMSRequestBodyto, nameof(sMSRequestBodyto), required: true);
            SourceExpression.Validate(sMSRequestBodymessage, nameof(sMSRequestBodymessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Account/{0}/Message/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "auth_id_value"), 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sMSRequestBody = new JObject();
                var sMSRequestBodypropCount = 0;
                sMSRequestBodypropCount++;
                sMSRequestBody["src"] = SourceExpressionConverter.ConvertToken(sMSRequestBodyfrom);
                sMSRequestBodypropCount++;
                sMSRequestBody["dst"] = SourceExpressionConverter.ConvertToken(sMSRequestBodyto);
                sMSRequestBodypropCount++;
                sMSRequestBody["text"] = SourceExpressionConverter.ConvertToken(sMSRequestBodymessage);
                if (sMSRequestBodypropCount > 0)
                {
                    callPayload.Body = sMSRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plivo")]
        public IBodyWorkflowAction<GetMessageResponse> GetMessage([WorkflowExpression] Func<string> messageUuid)
        {
            SourceExpression.Validate(messageUuid, nameof(messageUuid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Account/{0}/Message/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "auth_id_value"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageUuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessageResponse>(BuildSourceInput);
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