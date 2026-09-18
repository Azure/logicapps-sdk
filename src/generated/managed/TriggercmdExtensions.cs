//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TriggercmdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "triggercmd")]
        public IBodyWorkflowAction<string> RunCommand([WorkflowExpression] Func<string> bodycomputer, [WorkflowExpression] Func<string> bodytrigger, [WorkflowExpression] Func<string> bodyParams = null)
        {
            SourceExpression.Validate(bodycomputer, nameof(bodycomputer), required: true);
            SourceExpression.Validate(bodytrigger, nameof(bodytrigger), required: true);
            SourceExpression.Validate(bodyParams, nameof(bodyParams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/oauth/flow/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["computer"] = SourceExpressionConverter.ConvertToken(bodycomputer);
                bodypropCount++;
                body["trigger"] = SourceExpressionConverter.ConvertToken(bodytrigger);
                if (bodyParams != null)
                {
                    body["params"] = SourceExpressionConverter.ConvertToken(bodyParams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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