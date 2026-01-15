//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Billspls
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BillsplsActions([ConnectionName] string connectionId)
    {
    }

    public class BillsplsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Billspls;

    public partial class WorkflowManagedActions
    {
        public BillsplsActions Billspls(string connectionId) => new BillsplsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BillsplsTriggers Billspls(string connectionId) => new BillsplsTriggers(connectionId);
    }
}