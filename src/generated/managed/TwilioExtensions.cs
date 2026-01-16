//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Twilio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TwilioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<Message> SendMessage(Expression<Func<string>> sendMessageRequestfrom, Expression<Func<string>> sendMessageRequestto, Expression<Func<string>> sendMessageRequestbody, Expression<Func<string[]>> sendMessageRequestmediaUrl = null, Expression<Func<string>> sendMessageRequestStatusCallback = null, Expression<Func<string>> sendMessageRequestmessagingServiceSid = null, Expression<Func<string>> sendMessageRequestapplicationSid = null, Expression<Func<string>> sendMessageRequestmaxPrice = null, Expression<Func<string>> sendMessageRequestvalidityPeriod = null)
        {
            var apiCallPath = "/Messages.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendMessageRequest = new JObject();
            var sendMessageRequestpropCount = 0;
            sendMessageRequestpropCount++;
            sendMessageRequest["from"] = ExpressionConverter.ConvertO(sendMessageRequestfrom);
            sendMessageRequestpropCount++;
            sendMessageRequest["to"] = ExpressionConverter.ConvertO(sendMessageRequestto);
            sendMessageRequestpropCount++;
            sendMessageRequest["body"] = ExpressionConverter.ConvertO(sendMessageRequestbody);
            if (sendMessageRequestmediaUrl != null)
            {
                sendMessageRequest["media_url"] = ExpressionConverter.ConvertO(sendMessageRequestmediaUrl);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestStatusCallback != null)
            {
                sendMessageRequest["StatusCallback"] = ExpressionConverter.ConvertO(sendMessageRequestStatusCallback);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestmessagingServiceSid != null)
            {
                sendMessageRequest["messaging_service_sid"] = ExpressionConverter.ConvertO(sendMessageRequestmessagingServiceSid);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestapplicationSid != null)
            {
                sendMessageRequest["application_sid"] = ExpressionConverter.ConvertO(sendMessageRequestapplicationSid);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestmaxPrice != null)
            {
                sendMessageRequest["max_price"] = ExpressionConverter.ConvertO(sendMessageRequestmaxPrice);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestvalidityPeriod != null)
            {
                sendMessageRequest["validity_period"] = ExpressionConverter.ConvertO(sendMessageRequestvalidityPeriod);
                sendMessageRequestpropCount++;
            }

            if (sendMessageRequestpropCount > 0)
            {
                callPayload.Body = sendMessageRequest;
            }

            return new ApiConnectionAction<Message>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<MessageListV2> ListMessagesV2(Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> dateSent = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/v2/Messages.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (to != null)
                callPayload.Queries["To"] = ExpressionConverter.Convert(to);
            if (from != null)
                callPayload.Queries["From"] = ExpressionConverter.Convert(from);
            if (dateSent != null)
                callPayload.Queries["DateSent"] = ExpressionConverter.Convert(dateSent);
            callPayload.Queries["PageSize"] = Convert.ToString(50);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
            callPayload.Queries["Page"] = Convert.ToString(0);
            return new ApiConnectionAction<MessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<Message> GetMessage(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Messages/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Message>(callPayload);
        }
    }

    public class TwilioTriggers([ConnectionName] string connectionId)
    {
    }

    public class Message
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("num_segments")]
        public string NumSegments { get; set; }

        [JsonProperty("num_media")]
        public string NumMedia { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("date_updated")]
        public string DateUpdated { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_unit")]
        public string PriceUnit { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("subresource_uris")]
        public JToken SubresourceUris { get; set; }

        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; set; }
    }

    public class MessageListV2
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public Message[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Twilio;

    public partial class WorkflowManagedActions
    {
        public TwilioActions Twilio(string connectionId) => new TwilioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TwilioTriggers Twilio(string connectionId) => new TwilioTriggers(connectionId);
    }
}