//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescoreports
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescoreportsActions([ConnectionName] string connectionId)
    {
    }

    public class RescoreportsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rescoreports;

    public partial class WorkflowManagedActions
    {
        public RescoreportsActions Rescoreports(string connectionId) => new RescoreportsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RescoreportsTriggers Rescoreports(string connectionId) => new RescoreportsTriggers(connectionId);
    }
}