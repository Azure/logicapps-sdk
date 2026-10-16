//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pitneybowes
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PitneybowesActions([ConnectionName] string connectionId)
    {
    }

    public class PitneybowesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pitneybowes;

    public partial class WorkflowManagedActions
    {
        public PitneybowesActions Pitneybowes(string connectionId) => new PitneybowesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PitneybowesTriggers Pitneybowes(string connectionId) => new PitneybowesTriggers(connectionId);
    }
}