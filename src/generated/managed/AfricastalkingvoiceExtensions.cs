//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingvoice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingvoiceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingvoice")]
        public IBodyWorkflowAction<CallResponse, ApiConnectionActionConfiguration> Call(Expression<Func<CallInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CallResponse>(callPayload);
            });
        }
    }

    public class AfricastalkingvoiceTriggers([ConnectionName] string connectionId)
    {
    }

    public class CallResponse
    {
        [JsonProperty("entries")]
        public CallResponseEntriesTypeItem[] Entries { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class CallResponseEntriesTypeItem
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class CallInput
    {
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty("actions", DefaultValueHandling = DefaultValueHandling.Include)]
        public CallInputActionsTypeItem[] Actions { get; set; }
    }

    public class CallInputActionsTypeItem
    {
        [JsonProperty("actionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CallInputActionsTypeItemActionTypeType ActionType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("voice")]
        public CallInputActionsTypeItemVoiceType? Voice { get; set; }

        [JsonProperty("playBeep")]
        public bool? PlayBeep { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallInputActionsTypeItemActionTypeType
    {
        Play,
        Say
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallInputActionsTypeItemVoiceType
    {
        [EnumMember(Value = "man")]
        Man,
        [EnumMember(Value = "woman")]
        Woman
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingvoice;

    public partial class WorkflowManagedActions
    {
        public AfricastalkingvoiceActions Africastalkingvoice(string connectionId) => new AfricastalkingvoiceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AfricastalkingvoiceTriggers Africastalkingvoice(string connectionId) => new AfricastalkingvoiceTriggers(connectionId);
    }
}