//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mitto
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MittoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mitto")]
        public IBodyWorkflowAction<SmsResponse, ApiConnectionActionConfiguration> SmsRequest(Expression<Func<SmsRequestPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<SmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mitto")]
        public IBodyWorkflowAction<SmsBulkResponse, ApiConnectionActionConfiguration> SmsBulkRequest(Expression<Func<SmsBulkRequestPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<SmsBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/smsbulk.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SmsBulkResponse>(callPayload);
            });
        }
    }

    public class MittoTriggers([ConnectionName] string connectionId)
    {
    }

    public class SmsResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }

        [JsonProperty("responseText")]
        public string ResponseText { get; set; }

        [JsonProperty("test")]
        public bool WasTestSMS { get; set; }

        [JsonProperty("textLength")]
        public int TextLength { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("to")]
        public string Receiver { get; set; }
    }

    public class SmsRequestPostInput
    {
        [JsonProperty("flash")]
        public bool? IsFlashSMS { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sender { get; set; }

        [JsonProperty("pid")]
        public int? ProtocolIdentifier { get; set; }

        [JsonProperty("reference")]
        public string CustomerReference { get; set; }

        [JsonProperty("test")]
        public bool? IsTestSMS { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Receiver { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SmsRequestPostInputTextTypeType? TextType { get; set; } = SmsRequestPostInputTextTypeType.GSM;

        [JsonProperty("udh")]
        public string UserDataHeader { get; set; }

        [JsonProperty("validity")]
        public int? ValidityInMinutes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SmsRequestPostInputTextTypeType
    {
        GSM,
        Unicode,
        Binary
    }

    public class SmsBulkResponse
    {
        [JsonProperty("messages")]
        public SmsBulkResponseItem[] Messages { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }

        [JsonProperty("responseText")]
        public string ResponseText { get; set; }

        [JsonProperty("test")]
        public bool WasTestSMS { get; set; }
    }

    public class SmsBulkResponseItem
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("textLength")]
        public int TextLength { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("to")]
        public string Receiver { get; set; }
    }

    public class SmsBulkRequestPostInput
    {
        [JsonProperty("flash")]
        public bool? IsFlashSMS { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sender { get; set; }

        [JsonProperty("pid")]
        public int? ProtocolIdentifier { get; set; }

        [JsonProperty("reference")]
        public string CustomerReference { get; set; }

        [JsonProperty("test")]
        public bool? IsTestSMS { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Receivers { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SmsBulkRequestPostInputTextTypeType? TextType { get; set; } = SmsBulkRequestPostInputTextTypeType.GSM;

        [JsonProperty("udh")]
        public string UserDataHeader { get; set; }

        [JsonProperty("validity")]
        public int? ValidityInMinutes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SmsBulkRequestPostInputTextTypeType
    {
        GSM,
        Unicode,
        Binary
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mitto;

    public partial class WorkflowManagedActions
    {
        public MittoActions Mitto(string connectionId) => new MittoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MittoTriggers Mitto(string connectionId) => new MittoTriggers(connectionId);
    }
}