//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flic
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlicActions([ConnectionName] string connectionId)
    {
    }

    public class FlicTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FlicButtonTrigger(Expression<Func<string>> buttonUuid, Expression<Func<requestBodyOfWebhookeventsInput>> requestBodyOfWebhookevents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(buttonUuid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookevents != null)
            {
                requestBodyOfWebhook["events"] = ExpressionConverter.ConvertO(requestBodyOfWebhookevents);
                requestBodyOfWebhookpropCount++;
            }

            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FlicTaskTrigger(Expression<Func<string>> taskUuid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskUuid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public enum requestBodyOfWebhookeventsInput
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "double click")]
        DoubleClick,
        [EnumMember(Value = "hold")]
        Hold,
        [EnumMember(Value = "any")]
        Any
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flic;

    public partial class WorkflowManagedActions
    {
        public FlicActions Flic(string connectionId) => new FlicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlicTriggers Flic(string connectionId) => new FlicTriggers(connectionId);
    }
}