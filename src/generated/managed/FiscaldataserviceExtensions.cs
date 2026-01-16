//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fiscaldataservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FiscaldataserviceActions([ConnectionName] string connectionId)
    {
    }

    public class FiscaldataserviceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fiscaldataservice;

    public partial class WorkflowManagedActions
    {
        public FiscaldataserviceActions Fiscaldataservice(string connectionId) => new FiscaldataserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FiscaldataserviceTriggers Fiscaldataservice(string connectionId) => new FiscaldataserviceTriggers(connectionId);
    }
}