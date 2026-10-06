//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Narvar
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NarvarActions([ConnectionName] string connectionId)
    {
    }

    public class NarvarTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Narvar;

    public partial class WorkflowManagedActions
    {
        public NarvarActions Narvar(string connectionId) => new NarvarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NarvarTriggers Narvar(string connectionId) => new NarvarTriggers(connectionId);
    }
}