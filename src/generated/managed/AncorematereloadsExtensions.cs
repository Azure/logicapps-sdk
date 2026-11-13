//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematereloads
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AncorematereloadsActions([ConnectionName] string connectionId)
    {
    }

    public class AncorematereloadsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematereloads;

    public partial class WorkflowManagedActions
    {
        public AncorematereloadsActions Ancorematereloads(string connectionId) => new AncorematereloadsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AncorematereloadsTriggers Ancorematereloads(string connectionId) => new AncorematereloadsTriggers(connectionId);
    }
}