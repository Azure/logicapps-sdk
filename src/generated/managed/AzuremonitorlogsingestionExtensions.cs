//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogsingestion
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremonitorlogsingestionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogsingestion")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendData(Expression<Func<string>> dcrImmutableId, Expression<Func<string>> streamName, Expression<Func<JToken[]>> body)
        {
            var __workflow_dcrImmutableId = WorkflowExpression.Compile(dcrImmutableId, nameof(dcrImmutableId), required: true);
            var __workflow_streamName = WorkflowExpression.Compile(streamName, nameof(streamName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dataCollectionRules/{0}/streams/{1}", __workflow_dcrImmutableId.WithUrlEncoding(1), __workflow_streamName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzuremonitorlogsingestionTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogsingestion;

    public partial class WorkflowManagedActions
    {
        public AzuremonitorlogsingestionActions Azuremonitorlogsingestion(string connectionId) => new AzuremonitorlogsingestionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremonitorlogsingestionTriggers Azuremonitorlogsingestion(string connectionId) => new AzuremonitorlogsingestionTriggers(connectionId);
    }
}