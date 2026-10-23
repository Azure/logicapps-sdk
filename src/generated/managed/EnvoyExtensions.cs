//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Envoy
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnvoyActions([ConnectionName] string connectionId)
    {
    }

    public class EnvoyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> InviteCreated(Expression<Func<string>> bodytoken = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytoken = WorkflowExpression.Compile(bodytoken, nameof(bodytoken), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register-invite-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytoken != null)
                {
                    body["token"] = ExpressionConverter.ConvertO(__workflow_bodytoken);
                    bodypropCount++;
                }

                body["callback-url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
