//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signl4
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Signl4Actions([ConnectionName] string connectionId)
    {
    }

    public class Signl4Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signl4;

    public partial class WorkflowManagedActions
    {
        public Signl4Actions Signl4(string connectionId) => new Signl4Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Signl4Triggers Signl4(string connectionId) => new Signl4Triggers(connectionId);
    }
}