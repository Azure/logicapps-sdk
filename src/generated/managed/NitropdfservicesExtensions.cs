//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nitropdfservices
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitropdfservicesActions([ConnectionName] string connectionId)
    {
    }

    public class NitropdfservicesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nitropdfservices;

    public partial class WorkflowManagedActions
    {
        public NitropdfservicesActions Nitropdfservices(string connectionId) => new NitropdfservicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NitropdfservicesTriggers Nitropdfservices(string connectionId) => new NitropdfservicesTriggers(connectionId);
    }
}