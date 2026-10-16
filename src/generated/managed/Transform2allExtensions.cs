//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Transform2all
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Transform2allActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "transform2all")]
        public IWorkflowAction Transform(Expression<Func<string>> bodybase64Content, Expression<Func<string>> bodyconfigId)
        {
            var __workflow_bodybase64Content = WorkflowExpression.Compile(bodybase64Content, nameof(bodybase64Content), required: true);
            var __workflow_bodyconfigId = WorkflowExpression.Compile(bodyconfigId, nameof(bodyconfigId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/1.0/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["base64Content"] = ExpressionConverter.ConvertO(__workflow_bodybase64Content);
                bodypropCount++;
                body["configId"] = ExpressionConverter.ConvertO(__workflow_bodyconfigId);
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
