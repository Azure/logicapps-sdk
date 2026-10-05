//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flic
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlicActions([ConnectionName] string connectionId)
    {
    }

    public class FlicTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildFlicButtonTrigger))]
        public IWorkflowTrigger FlicButtonTrigger([WorkflowExpression] Func<string> buttonUuid, [WorkflowExpression] Func<requestBodyOfWebhookeventsInput> requestBodyOfWebhookevents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFlicButtonTrigger(WorkflowValue<string> buttonUuid, WorkflowValue<requestBodyOfWebhookeventsInput> requestBodyOfWebhookevents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(buttonUuid, nameof(buttonUuid), required: true);
            WorkflowValue.Validate(requestBodyOfWebhookevents, nameof(requestBodyOfWebhookevents), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(buttonUuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookevents != null)
                {
                    if (requestBodyOfWebhookevents != null)
                    {
                        requestBodyOfWebhook["events"] = ExpressionConverter.ConvertO(requestBodyOfWebhookevents);
                        requestBodyOfWebhookpropCount++;
                    }

                    requestBodyOfWebhookpropCount++;
                }
                else
                {
                    requestBodyOfWebhook["events"] = "any";
                    requestBodyOfWebhookpropCount++;
                }

                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildFlicTaskTrigger))]
        public IWorkflowTrigger FlicTaskTrigger([WorkflowExpression] Func<string> taskUuid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFlicTaskTrigger(WorkflowValue<string> taskUuid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(taskUuid, nameof(taskUuid), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskUuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
