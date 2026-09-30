//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuedatagateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huedatagate")]
        public IWorkflowAction Odata([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> roleId, [WorkflowExpression] Func<string> roleSecret)
        {
            var apiCallPath = "/api/v2/odata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            callPayload.Queries["host_url"] = ExpressionConverter.Convert(hostUrl);
            callPayload.Headers["role-id"] = ExpressionConverter.Convert(roleId);
            callPayload.Headers["role-secret"] = ExpressionConverter.Convert(roleSecret);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class HuedatagateTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huedatagate;

    public partial class WorkflowManagedActions
    {
        public HuedatagateActions Huedatagate(string connectionId) => new HuedatagateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuedatagateTriggers Huedatagate(string connectionId) => new HuedatagateTriggers(connectionId);
    }
}