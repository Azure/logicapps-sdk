//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Si3270
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Si3270Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "si3270")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteMethod))]
        public IBodyWorkflowAction<JToken> ExecuteMethod([WorkflowExpression] Func<string> hidxName, [WorkflowExpression] Func<string> methodName, [WorkflowExpression] Func<object> parameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteMethod(WorkflowExpression<string> hidxName, WorkflowExpression<string> methodName, WorkflowExpression<object> parameters = null)
        {
            WorkflowExpression.Validate(hidxName, nameof(hidxName), required: true);
            WorkflowExpression.Validate(methodName, nameof(methodName), required: true);
            WorkflowExpression.Validate(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hidx/{0}/methods/{1}/call", ExpressionConverter.ConvertWithUrlEncoding(hidxName, 1), ExpressionConverter.ConvertWithUrlEncoding(methodName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class Si3270Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Si3270;

    public partial class WorkflowManagedActions
    {
        public Si3270Actions Si3270(string connectionId) => new Si3270Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Si3270Triggers Si3270(string connectionId) => new Si3270Triggers(connectionId);
    }
}