//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sentinelmcp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SentinelmcpActions([ConnectionName] string connectionId)
    {
    }

    public class SentinelmcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sentinelmcp;

    public partial class WorkflowManagedActions
    {
        public SentinelmcpActions Sentinelmcp(string connectionId) => new SentinelmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SentinelmcpTriggers Sentinelmcp(string connectionId) => new SentinelmcpTriggers(connectionId);
    }
}