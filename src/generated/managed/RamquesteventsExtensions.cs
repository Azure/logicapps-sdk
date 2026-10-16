//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestevents
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RamquesteventsActions([ConnectionName] string connectionId)
    {
    }

    public class RamquesteventsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CCEEventTrigger(Expression<Func<bodyactionInput>> bodyaction = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/register/cce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webHook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyaction != null)
                {
                    body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger HorizonEventTrigger(Expression<Func<string>> bodyaction = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/register/horizon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webHook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyaction != null)
                {
                    body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
