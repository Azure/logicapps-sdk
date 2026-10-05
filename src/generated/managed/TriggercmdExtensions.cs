//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TriggercmdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "triggercmd")]
        [WorkflowExpressionFactory(nameof(__BuildRunCommand))]
        public IBodyWorkflowAction<string> RunCommand([WorkflowExpression] Func<string> bodycomputer, [WorkflowExpression] Func<string> bodytrigger, [WorkflowExpression] Func<string> bodyParams = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRunCommand(WorkflowValue<string> bodycomputer, WorkflowValue<string> bodytrigger, WorkflowValue<string> bodyParams = null)
        {
            WorkflowValue.Validate(bodycomputer, nameof(bodycomputer), required: true);
            WorkflowValue.Validate(bodytrigger, nameof(bodytrigger), required: true);
            WorkflowValue.Validate(bodyParams, nameof(bodyParams), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/oauth/flow/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["computer"] = ExpressionConverter.ConvertO(bodycomputer);
                bodypropCount++;
                body["trigger"] = ExpressionConverter.ConvertO(bodytrigger);
                if (bodyParams != null)
                {
                    body["params"] = ExpressionConverter.ConvertO(bodyParams);
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
