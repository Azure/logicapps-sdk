//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alisqi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlisqiActions([ConnectionName] string connectionId)
    {
    }

    public class AlisqiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alisqi;

    public partial class WorkflowManagedActions
    {
        public AlisqiActions Alisqi(string connectionId) => new AlisqiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlisqiTriggers Alisqi(string connectionId) => new AlisqiTriggers(connectionId);
    }
}