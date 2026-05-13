//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alertrelay
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlertrelayActions([ConnectionName] string connectionId)
    {
    }

    public class AlertrelayTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alertrelay;

    public partial class WorkflowManagedActions
    {
        public AlertrelayActions Alertrelay(string connectionId) => new AlertrelayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlertrelayTriggers Alertrelay(string connectionId) => new AlertrelayTriggers(connectionId);
    }
}