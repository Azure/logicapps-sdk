//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snowflake
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SnowflakeActions([ConnectionName] string connectionId)
    {
    }

    public class SnowflakeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snowflake;

    public partial class WorkflowManagedActions
    {
        public SnowflakeActions Snowflake(string connectionId) => new SnowflakeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SnowflakeTriggers Snowflake(string connectionId) => new SnowflakeTriggers(connectionId);
    }
}