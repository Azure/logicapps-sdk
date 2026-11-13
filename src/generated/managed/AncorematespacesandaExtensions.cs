//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematespacesanda
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AncorematespacesandaActions([ConnectionName] string connectionId)
    {
    }

    public class AncorematespacesandaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematespacesanda;

    public partial class WorkflowManagedActions
    {
        public AncorematespacesandaActions Ancorematespacesanda(string connectionId) => new AncorematespacesandaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AncorematespacesandaTriggers Ancorematespacesanda(string connectionId) => new AncorematespacesandaTriggers(connectionId);
    }
}