//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NintexworkflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nintexworkflow")]
        public IWorkflowAction CreateWorkflowInstance(Expression<Func<string>> workflowId, Expression<Func<object>> bodystartData = null)
        {
            var __workflow_workflowId = workflowId == null ? null : WorkflowExpression.Compile(workflowId);
            WorkflowExpression.Validate(__workflow_workflowId, nameof(workflowId), required: true);
            var __workflow_bodystartData = bodystartData == null ? null : WorkflowExpression.Compile(bodystartData);
            WorkflowExpression.Validate(__workflow_bodystartData, nameof(bodystartData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflows/v1/designs/{0}/instances", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystartData != null)
                {
                    body["startData"] = ExpressionConverter.ConvertO(__workflow_bodystartData);
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
