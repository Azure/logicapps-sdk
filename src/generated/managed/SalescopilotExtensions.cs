//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Salescopilot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SalescopilotActions([ConnectionName] string connectionId)
    {
    }

    public class SalescopilotTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Salescopilot;

    public partial class WorkflowManagedActions
    {
        public SalescopilotActions Salescopilot(string connectionId) => new SalescopilotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SalescopilotTriggers Salescopilot(string connectionId) => new SalescopilotTriggers(connectionId);
    }
}