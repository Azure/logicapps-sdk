//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nitrosign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitrosignActions([ConnectionName] string connectionId)
    {
    }

    public class NitrosignTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nitrosign;

    public partial class WorkflowManagedActions
    {
        public NitrosignActions Nitrosign(string connectionId) => new NitrosignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NitrosignTriggers Nitrosign(string connectionId) => new NitrosignTriggers(connectionId);
    }
}