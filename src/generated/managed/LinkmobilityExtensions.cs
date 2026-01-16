//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkmobility
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinkmobilityActions([ConnectionName] string connectionId)
    {
    }

    public class LinkmobilityTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linkmobility;

    public partial class WorkflowManagedActions
    {
        public LinkmobilityActions Linkmobility(string connectionId) => new LinkmobilityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LinkmobilityTriggers Linkmobility(string connectionId) => new LinkmobilityTriggers(connectionId);
    }
}