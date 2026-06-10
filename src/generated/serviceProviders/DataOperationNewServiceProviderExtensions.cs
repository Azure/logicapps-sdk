//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DataOperationNew
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataOperationNewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "dataOperationNew")]
        public IOutputWorkflowAction<JToken> ComposeNew()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/dataOperationNew", operationId: "composeNew", connectionName: connectionId)
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class DataOperationNewTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.DataOperationNew;

    public partial class WorkflowServiceProviderActions
    {
        public DataOperationNewActions DataOperationNew(string connectionId) => new DataOperationNewActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public DataOperationNewTriggers DataOperationNew(string connectionId) => new DataOperationNewTriggers(connectionId);
    }
}