//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NintexworkflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nintexworkflow")]
        public IWorkflowAction CreateWorkflowInstance([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<object> bodystartData = null)
        {
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            SourceExpression.Validate(bodystartData, nameof(bodystartData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflows/v1/designs/{0}/instances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystartData != null)
                {
                    body["startData"] = SourceExpressionConverter.ConvertToken(bodystartData);
                    bodypropCount++;
                }

                body["x-ntx-callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class NintexworkflowTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nintexworkflow;

    public partial class WorkflowManagedActions
    {
        public NintexworkflowActions Nintexworkflow(string connectionId) => new NintexworkflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NintexworkflowTriggers Nintexworkflow(string connectionId) => new NintexworkflowTriggers(connectionId);
    }
}