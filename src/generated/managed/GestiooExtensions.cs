//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gestioo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GestiooActions([ConnectionName] string connectionId)
    {
    }

    public class GestiooTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gestioo;

    public partial class WorkflowManagedActions
    {
        public GestiooActions Gestioo(string connectionId) => new GestiooActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GestiooTriggers Gestioo(string connectionId) => new GestiooTriggers(connectionId);
    }
}