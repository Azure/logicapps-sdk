//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Crmservicebus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CrmservicebusActions([ConnectionName] string connectionId)
    {
    }

    public class CrmservicebusTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Crmservicebus;

    public partial class WorkflowManagedActions
    {
        public CrmservicebusActions Crmservicebus(string connectionId) => new CrmservicebusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CrmservicebusTriggers Crmservicebus(string connectionId) => new CrmservicebusTriggers(connectionId);
    }
}