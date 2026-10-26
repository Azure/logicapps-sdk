//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatabricksgenie
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatabricksgenieActions([ConnectionName] string connectionId)
    {
    }

    public class AzuredatabricksgenieTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatabricksgenie;

    public partial class WorkflowManagedActions
    {
        public AzuredatabricksgenieActions Azuredatabricksgenie(string connectionId) => new AzuredatabricksgenieActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredatabricksgenieTriggers Azuredatabricksgenie(string connectionId) => new AzuredatabricksgenieTriggers(connectionId);
    }
}