//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuedatagateActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huedatagate")]
        [WorkflowExpressionFactory(nameof(__BuildOdata))]
        public IWorkflowAction Odata([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> roleId, [WorkflowExpression] Func<string> roleSecret)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huedatagate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOdata(WorkflowExpression<string> query, WorkflowExpression<string> hostUrl, WorkflowExpression<string> roleId, WorkflowExpression<string> roleSecret)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: true);
            WorkflowExpression.Validate(roleId, nameof(roleId), required: true);
            WorkflowExpression.Validate(roleSecret, nameof(roleSecret), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v2/odata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["host_url"] = ExpressionConverter.Convert(hostUrl);
                callPayload.Headers["role-id"] = ExpressionConverter.Convert(roleId);
                callPayload.Headers["role-secret"] = ExpressionConverter.Convert(roleSecret);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HuedatagateTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate;

    public partial class WorkflowManagedActions
    {
        public HuedatagateActions Huedatagate(string connectionId) => new HuedatagateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuedatagateTriggers Huedatagate(string connectionId) => new HuedatagateTriggers(connectionId);
    }
}