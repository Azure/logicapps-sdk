//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.A365adminmcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class A365adminmcpActions([ConnectionName] string connectionId)
    {
    }

    public class A365adminmcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.A365adminmcp;

    public partial class WorkflowManagedActions
    {
        public A365adminmcpActions A365adminmcp(string connectionId) => new A365adminmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public A365adminmcpTriggers A365adminmcp(string connectionId) => new A365adminmcpTriggers(connectionId);
    }
}