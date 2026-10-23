//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoripsumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loripsumip")]
        public IBodyWorkflowAction<string> GetText(Expression<Func<string>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/{0}", __workflow_parameters.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
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
