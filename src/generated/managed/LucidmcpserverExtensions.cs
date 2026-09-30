//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lucidmcpserver
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LucidmcpserverActions([ConnectionName] string connectionId)
    {
    }

    public class LucidmcpserverTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lucidmcpserver;

    public partial class WorkflowManagedActions
    {
        public LucidmcpserverActions Lucidmcpserver(string connectionId) => new LucidmcpserverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LucidmcpserverTriggers Lucidmcpserver(string connectionId) => new LucidmcpserverTriggers(connectionId);
    }
}