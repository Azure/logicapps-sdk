//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SnowflakeipActions([ConnectionName] string connectionId)
    {
    }

    public class SnowflakeipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snowflakeip;

    public partial class WorkflowManagedActions
    {
        public SnowflakeipActions Snowflakeip(string connectionId) => new SnowflakeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SnowflakeipTriggers Snowflakeip(string connectionId) => new SnowflakeipTriggers(connectionId);
    }
}