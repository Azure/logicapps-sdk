//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TriggercmdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "triggercmd")]
        public IBodyWorkflowAction<string> RunCommand(Expression<Func<string>> bodycomputer, Expression<Func<string>> bodytrigger, Expression<Func<string>> bodyParams = null)
        {
            var __workflow_bodycomputer = WorkflowExpression.Compile(bodycomputer, nameof(bodycomputer), required: true);
            var __workflow_bodytrigger = WorkflowExpression.Compile(bodytrigger, nameof(bodytrigger), required: true);
            var __workflow_bodyParams = WorkflowExpression.Compile(bodyParams, nameof(bodyParams), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/oauth/flow/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["computer"] = ExpressionConverter.ConvertO(__workflow_bodycomputer);
                bodypropCount++;
                body["trigger"] = ExpressionConverter.ConvertO(__workflow_bodytrigger);
                if (__workflow_bodyParams != null)
                {
                    body["params"] = ExpressionConverter.ConvertO(__workflow_bodyParams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TriggercmdTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd;

    public partial class WorkflowManagedActions
    {
        public TriggercmdActions Triggercmd(string connectionId) => new TriggercmdActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TriggercmdTriggers Triggercmd(string connectionId) => new TriggercmdTriggers(connectionId);
    }
}
