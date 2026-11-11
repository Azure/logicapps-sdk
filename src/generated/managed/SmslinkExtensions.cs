//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smslink
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmslinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smslink")]
        public IBodyWorkflowAction<SmsLinkSendSmsResponse, ApiConnectionActionConfiguration> SmsLinkSendSms(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SmsLinkSendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/gateway/integration/powerautomate.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SmsLinkSendSmsResponse>(callPayload);
            });
        }
    }

    public class SmslinkTriggers([ConnectionName] string connectionId)
    {
    }

    public class SmsLinkSendSmsResponse
    {
        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }

        [JsonProperty("response_message")]
        public string ResponseMessage { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string to, string message)
        {
            this.To = to;
            this.Message = message;
        }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smslink;

    public partial class WorkflowManagedActions
    {
        public SmslinkActions Smslink(string connectionId) => new SmslinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmslinkTriggers Smslink(string connectionId) => new SmslinkTriggers(connectionId);
    }
}