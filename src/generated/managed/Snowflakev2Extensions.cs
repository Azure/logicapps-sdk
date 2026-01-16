//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakev2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Snowflakev2Actions([ConnectionName] string connectionId)
    {
    }

    public class Snowflakev2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakev2;

    public partial class WorkflowManagedActions
    {
        public Snowflakev2Actions Snowflakev2(string connectionId) => new Snowflakev2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Snowflakev2Triggers Snowflakev2(string connectionId) => new Snowflakev2Triggers(connectionId);
    }
}