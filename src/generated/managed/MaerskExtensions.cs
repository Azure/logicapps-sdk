//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maersk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaerskActions([ConnectionName] string connectionId)
    {
    }

    public class MaerskTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maersk;

    public partial class WorkflowManagedActions
    {
        public MaerskActions Maersk(string connectionId) => new MaerskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaerskTriggers Maersk(string connectionId) => new MaerskTriggers(connectionId);
    }
}