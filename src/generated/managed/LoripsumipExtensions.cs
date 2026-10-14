//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LoripsumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loripsumip")]
        public IBodyWorkflowAction<string> GetText(Expression<Func<string>> parameters)
        {
            var __workflow_parameters = parameters == null ? null : WorkflowExpression.Compile(parameters);
            WorkflowExpression.Validate(__workflow_parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_parameters, 1));
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
