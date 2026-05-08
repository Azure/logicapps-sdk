//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MavimaiActions([ConnectionName] string connectionId)
    {
    }

    public class MavimaiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mavimai;

    public partial class WorkflowManagedActions
    {
        public MavimaiActions Mavimai(string connectionId) => new MavimaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MavimaiTriggers Mavimai(string connectionId) => new MavimaiTriggers(connectionId);
    }
}