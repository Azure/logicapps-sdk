//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mcphivetintegration
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class McphivetintegrationActions([ConnectionName] string connectionId)
    {
    }

    public class McphivetintegrationTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mcphivetintegration;

    public partial class WorkflowManagedActions
    {
        public McphivetintegrationActions Mcphivetintegration(string connectionId) => new McphivetintegrationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public McphivetintegrationTriggers Mcphivetintegration(string connectionId) => new McphivetintegrationTriggers(connectionId);
    }
}