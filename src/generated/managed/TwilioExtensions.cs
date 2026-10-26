//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Twilio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TwilioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<Message, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageInput>> sendMessageRequest)
        {
            var __workflow_sendMessageRequest = WorkflowExpression.Compile(sendMessageRequest, nameof(sendMessageRequest), required: true);
            return new DeferredBodyAction<Message, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendMessageRequest);
                return new ApiConnectionAction<Message>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<Message, ApiConnectionActionConfiguration> GetMessage(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<Message, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Messages/{0}.json", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Message>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "twilio")]
        public IBodyWorkflowAction<MessageListV2, ApiConnectionActionConfiguration> ListMessages(Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> dateSent = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_dateSent = WorkflowExpression.Compile(dateSent, nameof(dateSent), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Messages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_to != null)
                    callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_from != null)
                    callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_dateSent != null)
                    callPayload.Queries["DateSent"] = ExpressionConverter.Convert(__workflow_dateSent);
                callPayload.Queries["PageSize"] = Convert.ToString(50);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["Page"] = Convert.ToString(0);
                return new ApiConnectionAction<MessageListV2>(callPayload);
            });
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

    public class SendMessageInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("media_url")]
        public string[] MediaUrl { get; set; }
        public string StatusCallback { get; set; }

        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; set; }

        [JsonProperty("application_sid")]
        public string ApplicationSid { get; set; }

        [JsonProperty("max_price")]
        public string MaxPrice { get; set; }

        [JsonProperty("validity_period")]
        public string ValidityPeriod { get; set; }
    }

    public class MessageListV2
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public Message[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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