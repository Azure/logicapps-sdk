//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aexum
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AexumActions([ConnectionName] string connectionId)
    {
    }

    public class AexumTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aexum;

    public partial class WorkflowManagedActions
    {
        public AexumActions Aexum(string connectionId) => new AexumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AexumTriggers Aexum(string connectionId) => new AexumTriggers(connectionId);
    }
}