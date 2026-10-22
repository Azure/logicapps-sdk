//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItautomateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itautomate")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RunCommand(Expression<Func<int>> id, Expression<Func<object>> commandInput = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_commandInput = WorkflowExpression.Compile(commandInput, nameof(commandInput), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_commandInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
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
