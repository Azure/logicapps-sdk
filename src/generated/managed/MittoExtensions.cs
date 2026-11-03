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
        public IBodyWorkflowAction<SmsResponse, ApiConnectionActionConfiguration> SmsRequest(Expression<Func<string>> requestsender, Expression<Func<string>> requesttext, Expression<Func<string>> requestreceiver, Expression<Func<bool>> requestisFlashSMS = null, Expression<Func<int>> requestprotocolIdentifier = null, Expression<Func<string>> requestcustomerReference = null, Expression<Func<bool>> requestisTestSMS = null, Expression<Func<requesttextTypeInput>> requesttextType = null, Expression<Func<string>> requestuserDataHeader = null, Expression<Func<int>> requestvalidityInMinutes = null)
        {
            var __workflow_requestsender = WorkflowExpression.Compile(requestsender, nameof(requestsender), required: true);
            var __workflow_requesttext = WorkflowExpression.Compile(requesttext, nameof(requesttext), required: true);
            var __workflow_requestreceiver = WorkflowExpression.Compile(requestreceiver, nameof(requestreceiver), required: true);
            var __workflow_requestisFlashSMS = WorkflowExpression.Compile(requestisFlashSMS, nameof(requestisFlashSMS), required: false);
            var __workflow_requestprotocolIdentifier = WorkflowExpression.Compile(requestprotocolIdentifier, nameof(requestprotocolIdentifier), required: false);
            var __workflow_requestcustomerReference = WorkflowExpression.Compile(requestcustomerReference, nameof(requestcustomerReference), required: false);
            var __workflow_requestisTestSMS = WorkflowExpression.Compile(requestisTestSMS, nameof(requestisTestSMS), required: false);
            var __workflow_requesttextType = WorkflowExpression.Compile(requesttextType, nameof(requesttextType), required: false);
            var __workflow_requestuserDataHeader = WorkflowExpression.Compile(requestuserDataHeader, nameof(requestuserDataHeader), required: false);
            var __workflow_requestvalidityInMinutes = WorkflowExpression.Compile(requestvalidityInMinutes, nameof(requestvalidityInMinutes), required: false);
            return new DeferredBodyAction<SmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestisFlashSMS != null)
                {
                    request["flash"] = ExpressionConverter.ConvertO(__workflow_requestisFlashSMS);
                    requestpropCount++;
                }

                requestpropCount++;
                request["from"] = ExpressionConverter.ConvertO(__workflow_requestsender);
                if (__workflow_requestprotocolIdentifier != null)
                {
                    request["pid"] = ExpressionConverter.ConvertO(__workflow_requestprotocolIdentifier);
                    requestpropCount++;
                }

                if (__workflow_requestcustomerReference != null)
                {
                    request["reference"] = ExpressionConverter.ConvertO(__workflow_requestcustomerReference);
                    requestpropCount++;
                }

                if (__workflow_requestisTestSMS != null)
                {
                    request["test"] = ExpressionConverter.ConvertO(__workflow_requestisTestSMS);
                    requestpropCount++;
                }

                requestpropCount++;
                request["text"] = ExpressionConverter.ConvertO(__workflow_requesttext);
                requestpropCount++;
                request["to"] = ExpressionConverter.ConvertO(__workflow_requestreceiver);
                if (__workflow_requesttextType != null)
                {
                    if (__workflow_requesttextType != null)
                    {
                        request["type"] = ExpressionConverter.ConvertO(__workflow_requesttextType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["type"] = "GSM";
                    requestpropCount++;
                }

                if (__workflow_requestuserDataHeader != null)
                {
                    request["udh"] = ExpressionConverter.ConvertO(__workflow_requestuserDataHeader);
                    requestpropCount++;
                }

                if (__workflow_requestvalidityInMinutes != null)
                {
                    request["validity"] = ExpressionConverter.ConvertO(__workflow_requestvalidityInMinutes);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mitto")]
        public IBodyWorkflowAction<SmsBulkResponse, ApiConnectionActionConfiguration> SmsBulkRequest(Expression<Func<string>> requestsender, Expression<Func<string>> requesttext, Expression<Func<string[]>> requestreceivers, Expression<Func<bool>> requestisFlashSMS = null, Expression<Func<int>> requestprotocolIdentifier = null, Expression<Func<string>> requestcustomerReference = null, Expression<Func<bool>> requestisTestSMS = null, Expression<Func<requesttextTypeInput>> requesttextType = null, Expression<Func<string>> requestuserDataHeader = null, Expression<Func<int>> requestvalidityInMinutes = null)
        {
            var __workflow_requestsender = WorkflowExpression.Compile(requestsender, nameof(requestsender), required: true);
            var __workflow_requesttext = WorkflowExpression.Compile(requesttext, nameof(requesttext), required: true);
            var __workflow_requestreceivers = WorkflowExpression.Compile(requestreceivers, nameof(requestreceivers), required: true);
            var __workflow_requestisFlashSMS = WorkflowExpression.Compile(requestisFlashSMS, nameof(requestisFlashSMS), required: false);
            var __workflow_requestprotocolIdentifier = WorkflowExpression.Compile(requestprotocolIdentifier, nameof(requestprotocolIdentifier), required: false);
            var __workflow_requestcustomerReference = WorkflowExpression.Compile(requestcustomerReference, nameof(requestcustomerReference), required: false);
            var __workflow_requestisTestSMS = WorkflowExpression.Compile(requestisTestSMS, nameof(requestisTestSMS), required: false);
            var __workflow_requesttextType = WorkflowExpression.Compile(requesttextType, nameof(requesttextType), required: false);
            var __workflow_requestuserDataHeader = WorkflowExpression.Compile(requestuserDataHeader, nameof(requestuserDataHeader), required: false);
            var __workflow_requestvalidityInMinutes = WorkflowExpression.Compile(requestvalidityInMinutes, nameof(requestvalidityInMinutes), required: false);
            return new DeferredBodyAction<SmsBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/smsbulk.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestisFlashSMS != null)
                {
                    request["flash"] = ExpressionConverter.ConvertO(__workflow_requestisFlashSMS);
                    requestpropCount++;
                }

                requestpropCount++;
                request["from"] = ExpressionConverter.ConvertO(__workflow_requestsender);
                if (__workflow_requestprotocolIdentifier != null)
                {
                    request["pid"] = ExpressionConverter.ConvertO(__workflow_requestprotocolIdentifier);
                    requestpropCount++;
                }

                if (__workflow_requestcustomerReference != null)
                {
                    request["reference"] = ExpressionConverter.ConvertO(__workflow_requestcustomerReference);
                    requestpropCount++;
                }

                if (__workflow_requestisTestSMS != null)
                {
                    request["test"] = ExpressionConverter.ConvertO(__workflow_requestisTestSMS);
                    requestpropCount++;
                }

                requestpropCount++;
                request["text"] = ExpressionConverter.ConvertO(__workflow_requesttext);
                requestpropCount++;
                request["to"] = ExpressionConverter.ConvertO(__workflow_requestreceivers);
                if (__workflow_requesttextType != null)
                {
                    if (__workflow_requesttextType != null)
                    {
                        request["type"] = ExpressionConverter.ConvertO(__workflow_requesttextType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["type"] = "GSM";
                    requestpropCount++;
                }

                if (__workflow_requestuserDataHeader != null)
                {
                    request["udh"] = ExpressionConverter.ConvertO(__workflow_requestuserDataHeader);
                    requestpropCount++;
                }

                if (__workflow_requestvalidityInMinutes != null)
                {
                    request["validity"] = ExpressionConverter.ConvertO(__workflow_requestvalidityInMinutes);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requesttextTypeInput
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