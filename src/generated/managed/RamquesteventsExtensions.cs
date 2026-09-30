//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestevents
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RamquesteventsActions([ConnectionName] string connectionId)
    {
    }

    public class RamquesteventsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CCEEventTrigger([WorkflowExpression] Func<bodyactionInput> bodyaction = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/register/cce";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webHook"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodyaction != null)
            {
                body["action"] = ExpressionConverter.ConvertO(bodyaction);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger HorizonEventTrigger([WorkflowExpression] Func<string> bodyaction = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/register/horizon";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webHook"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodyaction != null)
            {
                body["action"] = ExpressionConverter.ConvertO(bodyaction);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public enum bodyactionInput
    {
        TaskEvent,
        DocumentEvent,
        File,
        Commitment,
        CheckWriting
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestevents;

    public partial class WorkflowManagedActions
    {
        public RamquesteventsActions Ramquestevents(string connectionId) => new RamquesteventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RamquesteventsTriggers Ramquestevents(string connectionId) => new RamquesteventsTriggers(connectionId);
    }
}