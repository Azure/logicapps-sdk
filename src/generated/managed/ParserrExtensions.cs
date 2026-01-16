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
            var apiCallPath = "/api/microsoft/user/emaillist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListInboxesResponseItem[]>(callPayload);
        }
    }

    public class ParserrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookEmailReceived(Expression<Func<string>> bodyemail)
        {
            var apiCallPath = "/api/microsoft/subscription/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["TriggerUrl"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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