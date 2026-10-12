//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VeteransaffairsipActions([ConnectionName] string connectionId)
    {
    }

    public class VeteransaffairsipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsip;

    public partial class WorkflowManagedActions
    {
        public VeteransaffairsipActions Veteransaffairsip(string connectionId) => new VeteransaffairsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VeteransaffairsipTriggers Veteransaffairsip(string connectionId) => new VeteransaffairsipTriggers(connectionId);
    }
}