//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThebotplatformActions([ConnectionName] string connectionId)
    {
    }

    public class ThebotplatformTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform;

    public partial class WorkflowManagedActions
    {
        public ThebotplatformActions Thebotplatform(string connectionId) => new ThebotplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThebotplatformTriggers Thebotplatform(string connectionId) => new ThebotplatformTriggers(connectionId);
    }
}