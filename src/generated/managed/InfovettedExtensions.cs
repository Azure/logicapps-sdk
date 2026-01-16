//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infovetted
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfovettedActions([ConnectionName] string connectionId)
    {
    }

    public class InfovettedTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infovetted;

    public partial class WorkflowManagedActions
    {
        public InfovettedActions Infovetted(string connectionId) => new InfovettedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfovettedTriggers Infovetted(string connectionId) => new InfovettedTriggers(connectionId);
    }
}