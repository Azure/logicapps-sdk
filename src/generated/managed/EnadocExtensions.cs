//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnadocActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enadoc")]
        [WorkflowExpressionFactory(nameof(__BuildSendToMyWorkspace))]
        public IBodyWorkflowAction<SuccessResponse> SendToMyWorkspace([WorkflowExpression] Func<string> document, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enadoc")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessResponse> __BuildSendToMyWorkspace(WorkflowExpression<string> document, WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(document, nameof(document), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<SuccessResponse>(() =>
            {
                var apiCallPath = "/api/v3/workspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SuccessResponse>(callPayload);
            });
        }
    }

    public class EnadocTriggers([ConnectionName] string connectionId)
    {
    }

    public class SuccessResponse
    {
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc;

    public partial class WorkflowManagedActions
    {
        public EnadocActions Enadoc(string connectionId) => new EnadocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnadocTriggers Enadoc(string connectionId) => new EnadocTriggers(connectionId);
    }
}