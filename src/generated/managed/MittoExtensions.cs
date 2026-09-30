//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mitto
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MittoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mitto")]
        public IBodyWorkflowAction<SmsResponse> SmsRequest([WorkflowExpression] Func<string> requestsender, [WorkflowExpression] Func<string> requesttext, [WorkflowExpression] Func<string> requestreceiver, [WorkflowExpression] Func<bool> requestisFlashSMS = null, [WorkflowExpression] Func<int> requestprotocolIdentifier = null, [WorkflowExpression] Func<string> requestcustomerReference = null, [WorkflowExpression] Func<bool> requestisTestSMS = null, [WorkflowExpression] Func<requesttextTypeInput> requesttextType = null, [WorkflowExpression] Func<string> requestuserDataHeader = null, [WorkflowExpression] Func<int> requestvalidityInMinutes = null)
        {
            var apiCallPath = "/sms.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestisFlashSMS != null)
            {
                request["flash"] = ExpressionConverter.ConvertO(requestisFlashSMS);
                requestpropCount++;
            }

            requestpropCount++;
            request["from"] = ExpressionConverter.ConvertO(requestsender);
            if (requestprotocolIdentifier != null)
            {
                request["pid"] = ExpressionConverter.ConvertO(requestprotocolIdentifier);
                requestpropCount++;
            }

            if (requestcustomerReference != null)
            {
                request["reference"] = ExpressionConverter.ConvertO(requestcustomerReference);
                requestpropCount++;
            }

            if (requestisTestSMS != null)
            {
                request["test"] = ExpressionConverter.ConvertO(requestisTestSMS);
                requestpropCount++;
            }

            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            requestpropCount++;
            request["to"] = ExpressionConverter.ConvertO(requestreceiver);
            if (requesttextType != null)
            {
                if (requesttextType != null)
                {
                    request["type"] = ExpressionConverter.ConvertO(requesttextType);
                    requestpropCount++;
                }

                requestpropCount++;
            }
            else
            {
                request["type"] = "GSM";
                requestpropCount++;
            }

            if (requestuserDataHeader != null)
            {
                request["udh"] = ExpressionConverter.ConvertO(requestuserDataHeader);
                requestpropCount++;
            }

            if (requestvalidityInMinutes != null)
            {
                request["validity"] = ExpressionConverter.ConvertO(requestvalidityInMinutes);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SmsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mitto")]
        public IBodyWorkflowAction<SmsBulkResponse> SmsBulkRequest([WorkflowExpression] Func<string> requestsender, [WorkflowExpression] Func<string> requesttext, [WorkflowExpression] Func<string[]> requestreceivers, [WorkflowExpression] Func<bool> requestisFlashSMS = null, [WorkflowExpression] Func<int> requestprotocolIdentifier = null, [WorkflowExpression] Func<string> requestcustomerReference = null, [WorkflowExpression] Func<bool> requestisTestSMS = null, [WorkflowExpression] Func<requesttextTypeInput> requesttextType = null, [WorkflowExpression] Func<string> requestuserDataHeader = null, [WorkflowExpression] Func<int> requestvalidityInMinutes = null)
        {
            var apiCallPath = "/smsbulk.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestisFlashSMS != null)
            {
                request["flash"] = ExpressionConverter.ConvertO(requestisFlashSMS);
                requestpropCount++;
            }

            requestpropCount++;
            request["from"] = ExpressionConverter.ConvertO(requestsender);
            if (requestprotocolIdentifier != null)
            {
                request["pid"] = ExpressionConverter.ConvertO(requestprotocolIdentifier);
                requestpropCount++;
            }

            if (requestcustomerReference != null)
            {
                request["reference"] = ExpressionConverter.ConvertO(requestcustomerReference);
                requestpropCount++;
            }

            if (requestisTestSMS != null)
            {
                request["test"] = ExpressionConverter.ConvertO(requestisTestSMS);
                requestpropCount++;
            }

            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            requestpropCount++;
            request["to"] = ExpressionConverter.ConvertO(requestreceivers);
            if (requesttextType != null)
            {
                if (requesttextType != null)
                {
                    request["type"] = ExpressionConverter.ConvertO(requesttextType);
                    requestpropCount++;
                }

                requestpropCount++;
            }
            else
            {
                request["type"] = "GSM";
                requestpropCount++;
            }

            if (requestuserDataHeader != null)
            {
                request["udh"] = ExpressionConverter.ConvertO(requestuserDataHeader);
                requestpropCount++;
            }

            if (requestvalidityInMinutes != null)
            {
                request["validity"] = ExpressionConverter.ConvertO(requestvalidityInMinutes);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SmsBulkResponse>(callPayload);
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