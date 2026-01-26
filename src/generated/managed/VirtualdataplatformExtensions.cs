//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Virtualdataplatform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VirtualdataplatformActions([ConnectionName] string connectionId)
    {
    }

    public class VirtualdataplatformTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Virtualdataplatform;

    public partial class WorkflowManagedActions
    {
        public VirtualdataplatformActions Virtualdataplatform(string connectionId) => new VirtualdataplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VirtualdataplatformTriggers Virtualdataplatform(string connectionId) => new VirtualdataplatformTriggers(connectionId);
    }
}