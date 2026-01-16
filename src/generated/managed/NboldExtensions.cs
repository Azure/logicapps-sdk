//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nbold
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NboldActions([ConnectionName] string connectionId)
    {
    }

    public class NboldTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nbold;

    public partial class WorkflowManagedActions
    {
        public NboldActions Nbold(string connectionId) => new NboldActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NboldTriggers Nbold(string connectionId) => new NboldTriggers(connectionId);
    }
}