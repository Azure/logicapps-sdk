//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematecatalog
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AncorematecatalogActions([ConnectionName] string connectionId)
    {
    }

    public class AncorematecatalogTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematecatalog;

    public partial class WorkflowManagedActions
    {
        public AncorematecatalogActions Ancorematecatalog(string connectionId) => new AncorematecatalogActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AncorematecatalogTriggers Ancorematecatalog(string connectionId) => new AncorematecatalogTriggers(connectionId);
    }
}