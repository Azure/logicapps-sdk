//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakepa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SnowflakepaActions([ConnectionName] string connectionId)
    {
    }

    public class SnowflakepaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakepa;

    public partial class WorkflowManagedActions
    {
        public SnowflakepaActions Snowflakepa(string connectionId) => new SnowflakepaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SnowflakepaTriggers Snowflakepa(string connectionId) => new SnowflakepaTriggers(connectionId);
    }
}