//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaimodelinference
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaimodelinferenceActions([ConnectionName] string connectionId)
    {
    }

    public class AzureaimodelinferenceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureaimodelinference;

    public partial class WorkflowManagedActions
    {
        public AzureaimodelinferenceActions Azureaimodelinference(string connectionId) => new AzureaimodelinferenceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureaimodelinferenceTriggers Azureaimodelinference(string connectionId) => new AzureaimodelinferenceTriggers(connectionId);
    }
}