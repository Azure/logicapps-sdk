//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mondaycomip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondaycomipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mondaycomip")]
        [WorkflowExpressionFactory(nameof(__BuildCallGraphQL))]
        public IBodyWorkflowAction<JToken> CallGraphQL([WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCallGraphQL(WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class MondaycomipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mondaycomip;

    public partial class WorkflowManagedActions
    {
        public MondaycomipActions Mondaycomip(string connectionId) => new MondaycomipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MondaycomipTriggers Mondaycomip(string connectionId) => new MondaycomipTriggers(connectionId);
    }
}