//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parserr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParserrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parserr")]
        public IBodyWorkflowAction<ListInboxesResponseItem[]> ListInboxes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/microsoft/user/emaillist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListInboxesResponseItem[]>(BuildSourceInput);
        }
    }

    public class ParserrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookEmailReceived([WorkflowExpression] Func<string> bodyemail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/microsoft/subscription/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["TriggerUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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