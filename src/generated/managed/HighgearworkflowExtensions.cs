//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highgearworkflow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HighgearworkflowActions([ConnectionName] string connectionId)
    {
    }

    public class HighgearworkflowTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Highgearworkflow;

    public partial class WorkflowManagedActions
    {
        public HighgearworkflowActions Highgearworkflow(string connectionId) => new HighgearworkflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HighgearworkflowTriggers Highgearworkflow(string connectionId) => new HighgearworkflowTriggers(connectionId);
    }
}