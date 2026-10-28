//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravitysms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GravitysmsActions([ConnectionName] string connectionId)
    {
    }

    public class GravitysmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gravitysms;

    public partial class WorkflowManagedActions
    {
        public GravitysmsActions Gravitysms(string connectionId) => new GravitysmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GravitysmsTriggers Gravitysms(string connectionId) => new GravitysmsTriggers(connectionId);
    }
}