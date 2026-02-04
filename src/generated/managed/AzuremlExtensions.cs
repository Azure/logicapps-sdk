//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureml
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremlActions([ConnectionName] string connectionId)
    {
    }

    public class AzuremlTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureml;

    public partial class WorkflowManagedActions
    {
        public AzuremlActions Azureml(string connectionId) => new AzuremlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremlTriggers Azureml(string connectionId) => new AzuremlTriggers(connectionId);
    }
}