//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Moduleq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ModuleqActions([ConnectionName] string connectionId)
    {
    }

    public class ModuleqTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Moduleq;

    public partial class WorkflowManagedActions
    {
        public ModuleqActions Moduleq(string connectionId) => new ModuleqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ModuleqTriggers Moduleq(string connectionId) => new ModuleqTriggers(connectionId);
    }
}