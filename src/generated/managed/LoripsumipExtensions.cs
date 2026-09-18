//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoripsumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loripsumip")]
        public IBodyWorkflowAction<string> GetText([WorkflowExpression] Func<string> parameters)
        {
            SourceExpression.Validate(parameters, nameof(parameters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parameters, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class LoripsumipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip;

    public partial class WorkflowManagedActions
    {
        public LoripsumipActions Loripsumip(string connectionId) => new LoripsumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LoripsumipTriggers Loripsumip(string connectionId) => new LoripsumipTriggers(connectionId);
    }
}