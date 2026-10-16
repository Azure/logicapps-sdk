//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tribalsits
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TribalsitsActions([ConnectionName] string connectionId)
    {
    }

    public class TribalsitsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tribalsits;

    public partial class WorkflowManagedActions
    {
        public TribalsitsActions Tribalsits(string connectionId) => new TribalsitsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TribalsitsTriggers Tribalsits(string connectionId) => new TribalsitsTriggers(connectionId);
    }
}