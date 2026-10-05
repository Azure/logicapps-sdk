//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.K2workflow
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class K2workflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "k2workflow")]
        [WorkflowExpressionFactory(nameof(__BuildTasksPostReleaseAction))]
        public IBodyWorkflowAction<JToken> TasksPostReleaseAction([WorkflowExpression] Func<string> serialNumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildTasksPostReleaseAction(WorkflowValue<string> serialNumber)
        {
            WorkflowValue.Validate(serialNumber, nameof(serialNumber), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/tasks/{0}/actions/release", ExpressionConverter.ConvertWithUrlEncoding(serialNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class K2workflowTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.K2workflow;

    public partial class WorkflowManagedActions
    {
        public K2workflowActions K2workflow(string connectionId) => new K2workflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public K2workflowTriggers K2workflow(string connectionId) => new K2workflowTriggers(connectionId);
    }
}
