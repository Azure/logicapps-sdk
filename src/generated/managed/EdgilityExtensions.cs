//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edgility
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdgilityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<GetAccountResponse, ApiConnectionActionConfiguration> GetAccount()
        {
            return new DeferredBodyAction<GetAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageInput>> message)
        {
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/integrations/power-automate/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }
    }

    public class EdgilityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> InboundMessage(Expression<Func<InboundMessageInput>> config, FlowRecurrence recurrence = null)
        {
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/integrations/power-automate/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_config);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetAccountResponse
    {
        [JsonProperty("data")]
        public AccountInformation Data { get; set; }
    }

    public class AccountInformation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("credits")]
        public double Credits { get; set; }

        [JsonProperty("settings")]
        public JToken Settings { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("success_count")]
        public int SuccessCount { get; set; }

        [JsonProperty("failed_count")]
        public int FailedCount { get; set; }
    }

    public class SendMessageInput
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class InboundMessageInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal InboundMessageInputEventType Event { get; set; } = InboundMessageInputEventType.MessageReceived;

        [JsonProperty("dedicated_number")]
        public string DedicatedNumber { get; set; }

        [JsonProperty("destination_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DestinationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InboundMessageInputEventType
    {
        [EnumMember(Value = "message_received")]
        MessageReceived
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Edgility;

    public partial class WorkflowManagedActions
    {
        public EdgilityActions Edgility(string connectionId) => new EdgilityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EdgilityTriggers Edgility(string connectionId) => new EdgilityTriggers(connectionId);
    }
}