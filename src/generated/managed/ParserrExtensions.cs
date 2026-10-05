//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parserr
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParserrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parserr")]
        public IBodyWorkflowAction<ListInboxesResponseItem[]> ListInboxes()
        {
            var apiCallPath = "/api/microsoft/user/emaillist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListInboxesResponseItem[]>(callPayload);
        }
    }

    public class ParserrTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildWebhookEmailReceived))]
        public IWorkflowTrigger WebhookEmailReceived([WorkflowExpression] Func<string> bodyemail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookEmailReceived(WorkflowValue<string> bodyemail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/microsoft/subscription/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["TriggerUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
