//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adls
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdlsActions([ConnectionName] string connectionId)
    {
    }

    public class AdlsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adls;

    public partial class WorkflowManagedActions
    {
        public AdlsActions Adls(string connectionId) => new AdlsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdlsTriggers Adls(string connectionId) => new AdlsTriggers(connectionId);
    }
}