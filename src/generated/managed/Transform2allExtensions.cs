//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Transform2all
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Transform2allActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "transform2all")]
        [WorkflowExpressionFactory(nameof(__BuildTransform))]
        public IWorkflowAction Transform([WorkflowExpression] Func<string> bodybase64Content, [WorkflowExpression] Func<string> bodyconfigId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "transform2all")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTransform(WorkflowExpression<string> bodybase64Content, WorkflowExpression<string> bodyconfigId)
        {
            WorkflowExpression.Validate(bodybase64Content, nameof(bodybase64Content), required: true);
            WorkflowExpression.Validate(bodyconfigId, nameof(bodyconfigId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/1.0/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["base64Content"] = ExpressionConverter.ConvertO(bodybase64Content);
                bodypropCount++;
                body["configId"] = ExpressionConverter.ConvertO(bodyconfigId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Transform2allTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Transform2all;

    public partial class WorkflowManagedActions
    {
        public Transform2allActions Transform2all(string connectionId) => new Transform2allActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Transform2allTriggers Transform2all(string connectionId) => new Transform2allTriggers(connectionId);
    }
}