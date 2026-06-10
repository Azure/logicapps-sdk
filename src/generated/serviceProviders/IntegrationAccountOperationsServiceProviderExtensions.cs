//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.IntegrationAccountOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntegrationAccountOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "integrationAccountOperations")]
        public IBodyWorkflowAction<JToken> IntegrationAccountArtifactLookup(Expression<Func<IntegrationAccountArtifactLookupArtifactTypeType>> artifactType, Expression<Func<string>> artifactName)
        {
            var parameters = new JObject();
            parameters["artifactType"] = ExpressionConverter.ConvertO(artifactType);
            parameters["artifactName"] = ExpressionConverter.ConvertO(artifactName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/integrationAccountOperations", operationId: "integrationAccountArtifactLookup", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class IntegrationAccountOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum IntegrationAccountArtifactLookupArtifactTypeType
    {
        Schema,
        Map,
        Partner,
        Agreement,
        RosettaNetProcessConfiguration
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.IntegrationAccountOperations;

    public partial class WorkflowServiceProviderActions
    {
        public IntegrationAccountOperationsActions IntegrationAccountOperations(string connectionId) => new IntegrationAccountOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public IntegrationAccountOperationsTriggers IntegrationAccountOperations(string connectionId) => new IntegrationAccountOperationsTriggers(connectionId);
    }
}