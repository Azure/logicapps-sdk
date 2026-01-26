//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smarterdrafter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmarterdrafterActions([ConnectionName] string connectionId)
    {
    }

    public class SmarterdrafterTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smarterdrafter;

    public partial class WorkflowManagedActions
    {
        public SmarterdrafterActions Smarterdrafter(string connectionId) => new SmarterdrafterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmarterdrafterTriggers Smarterdrafter(string connectionId) => new SmarterdrafterTriggers(connectionId);
    }
}