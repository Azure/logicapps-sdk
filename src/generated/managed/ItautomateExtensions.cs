//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItautomateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itautomate")]
        public IBodyWorkflowAction<JToken> RunCommand([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> commandInput = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Body = SourceExpressionConverter.ConvertToken(commandInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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