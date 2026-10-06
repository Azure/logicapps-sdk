//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItautomateActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itautomate")]
        [WorkflowExpressionFactory(nameof(__BuildRunCommand))]
        public IBodyWorkflowAction<JToken> RunCommand([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> commandInput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itautomate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildRunCommand(WorkflowExpression<int> id, WorkflowExpression<object> commandInput = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(commandInput, nameof(commandInput), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Body = ExpressionConverter.ConvertO(commandInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ItautomateTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate;

    public partial class WorkflowManagedActions
    {
        public ItautomateActions Itautomate(string connectionId) => new ItautomateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ItautomateTriggers Itautomate(string connectionId) => new ItautomateTriggers(connectionId);
    }
}