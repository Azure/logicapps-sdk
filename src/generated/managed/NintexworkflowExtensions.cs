//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NintexworkflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nintexworkflow")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateWorkflowInstance(Expression<Func<string>> workflowId, Expression<Func<CreateWorkflowInstanceInput>> body)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflows/v1/designs/{0}/instances", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class NintexworkflowTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateWorkflowInstanceInput
    {
        [JsonProperty("startData")]
        public JToken StartData { get; set; }

        [JsonProperty("x-ntx-callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string XNtxCallbackUrl { get; set; } = "#{listCallbackUrl()}";
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