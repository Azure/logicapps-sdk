//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calendly
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalendlyActions([ConnectionName] string connectionId)
    {
    }

    public class CalendlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> WebhookCreateInvitee(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook1/api/v1/hooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCancelInvitee(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook2/api/v1/hooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calendly;

    public partial class WorkflowManagedActions
    {
        public CalendlyActions Calendly(string connectionId) => new CalendlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CalendlyTriggers Calendly(string connectionId) => new CalendlyTriggers(connectionId);
    }
}