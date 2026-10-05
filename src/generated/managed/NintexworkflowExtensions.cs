//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NintexworkflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nintexworkflow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkflowInstance))]
        public IWorkflowAction CreateWorkflowInstance([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<object> bodystartData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateWorkflowInstance(WorkflowValue<string> workflowId, WorkflowValue<object> bodystartData = null)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(bodystartData, nameof(bodystartData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflows/v1/designs/{0}/instances", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystartData != null)
                {
                    body["startData"] = ExpressionConverter.ConvertO(bodystartData);
                    bodypropCount++;
                }

                body["x-ntx-callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class NintexworkflowTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow;

    public partial class WorkflowManagedActions
    {
        public NintexworkflowActions Nintexworkflow(string connectionId) => new NintexworkflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NintexworkflowTriggers Nintexworkflow(string connectionId) => new NintexworkflowTriggers(connectionId);
    }
}
