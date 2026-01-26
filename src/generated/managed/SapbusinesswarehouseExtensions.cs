//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sapbusinesswarehouse
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapbusinesswarehouseActions([ConnectionName] string connectionId)
    {
    }

    public class SapbusinesswarehouseTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sapbusinesswarehouse;

    public partial class WorkflowManagedActions
    {
        public SapbusinesswarehouseActions Sapbusinesswarehouse(string connectionId) => new SapbusinesswarehouseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SapbusinesswarehouseTriggers Sapbusinesswarehouse(string connectionId) => new SapbusinesswarehouseTriggers(connectionId);
    }
}