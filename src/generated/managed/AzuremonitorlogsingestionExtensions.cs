//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremonitorlogsingestion
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremonitorlogsingestionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremonitorlogsingestion")]
        public IWorkflowAction SendData([WorkflowExpression] Func<string> dcrImmutableId, [WorkflowExpression] Func<string> streamName, [WorkflowExpression] Func<JToken[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dataCollectionRules/{0}/streams/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dcrImmutableId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(streamName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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