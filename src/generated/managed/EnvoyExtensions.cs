//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Envoy
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnvoyActions([ConnectionName] string connectionId)
    {
    }

    public class EnvoyTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildInviteCreated))]
        public IWorkflowTrigger InviteCreated([WorkflowExpression] Func<string> bodytoken = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInviteCreated(WorkflowValue<string> bodytoken = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytoken, nameof(bodytoken), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/register-invite-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytoken != null)
                {
                    body["token"] = ExpressionConverter.ConvertO(bodytoken);
                    bodypropCount++;
                }

                body["callback-url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Envoy;

    public partial class WorkflowManagedActions
    {
        public EnvoyActions Envoy(string connectionId) => new EnvoyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnvoyTriggers Envoy(string connectionId) => new EnvoyTriggers(connectionId);
    }
}
