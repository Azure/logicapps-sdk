//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lansweeperappforsent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LansweeperappforsentActions([ConnectionName] string connectionId)
    {
    }

    public class LansweeperappforsentTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lansweeperappforsent;

    public partial class WorkflowManagedActions
    {
        public LansweeperappforsentActions Lansweeperappforsent(string connectionId) => new LansweeperappforsentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LansweeperappforsentTriggers Lansweeperappforsent(string connectionId) => new LansweeperappforsentTriggers(connectionId);
    }
}