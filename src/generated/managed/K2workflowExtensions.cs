//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.K2workflow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class K2workflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "k2workflow")]
        public IBodyWorkflowAction<JToken> TasksPostReleaseAction([WorkflowExpression] Func<string> serialNumber)
        {
            SourceExpression.Validate(serialNumber, nameof(serialNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/tasks/{0}/actions/release", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(serialNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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