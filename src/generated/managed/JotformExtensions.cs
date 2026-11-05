//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jotform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JotformActions([ConnectionName] string connectionId)
    {
    }

    public class JotformTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> TriggerNewResponse(Expression<Func<RequestBodyOfWebhookInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RequestBodyOfWebhookInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("Form_ID")]
        public string FormId { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyOfWebhookInputOutputFormatTypeItem[] OutputFormat { get; set; } = new RequestBodyOfWebhookInputOutputFormatTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Jotform.RequestBodyOfWebhookInputOutputFormatTypeItem.HTML
        };
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestBodyOfWebhookInputOutputFormatTypeItem
    {
        HTML,
        Text
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jotform;

    public partial class WorkflowManagedActions
    {
        public JotformActions Jotform(string connectionId) => new JotformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JotformTriggers Jotform(string connectionId) => new JotformTriggers(connectionId);
    }
}