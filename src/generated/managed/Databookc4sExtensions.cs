//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Databookc4s
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Databookc4sActions([ConnectionName] string connectionId)
    {
    }

    public class Databookc4sTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Databookc4s;

    public partial class WorkflowManagedActions
    {
        public Databookc4sActions Databookc4s(string connectionId) => new Databookc4sActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Databookc4sTriggers Databookc4s(string connectionId) => new Databookc4sTriggers(connectionId);
    }
}