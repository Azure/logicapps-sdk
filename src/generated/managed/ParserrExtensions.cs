//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parserr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParserrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parserr")]
        public IBodyWorkflowAction<ListInboxesResponseItem[], ApiConnectionActionConfiguration> ListInboxes()
        {
            return new DeferredBodyAction<ListInboxesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/microsoft/user/emaillist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListInboxesResponseItem[]>(callPayload);
            });
        }
    }

    public class ParserrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookEmailReceived(Expression<Func<WebhookEmailReceivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/microsoft/subscription/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ListInboxesResponseItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateAdded")]
        public string DateTimeCreated { get; set; }

        [JsonProperty("id")]
        public int InboxId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookEmailReceivedInput
    {
        [JsonProperty("TriggerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Parserr;

    public partial class WorkflowManagedActions
    {
        public ParserrActions Parserr(string connectionId) => new ParserrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ParserrTriggers Parserr(string connectionId) => new ParserrTriggers(connectionId);
    }
}