//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dnb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DnbActions([ConnectionName] string connectionId)
    {
    }

    public class DnbTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dnb;

    public partial class WorkflowManagedActions
    {
        public DnbActions Dnb(string connectionId) => new DnbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DnbTriggers Dnb(string connectionId) => new DnbTriggers(connectionId);
    }
}