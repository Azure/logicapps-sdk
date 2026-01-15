//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Nitrosignenterprisev
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitrosignenterprisevActions([ConnectionName] string connectionId)
    {
    }

    public class NitrosignenterprisevTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Nitrosignenterprisev;

    public partial class WorkflowManagedActions
    {
        public NitrosignenterprisevActions Nitrosignenterprisev(string connectionId) => new NitrosignenterprisevActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NitrosignenterprisevTriggers Nitrosignenterprisev(string connectionId) => new NitrosignenterprisevTriggers(connectionId);
    }
}