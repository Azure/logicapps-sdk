//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Harnesspdfx
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HarnesspdfxActions([ConnectionName] string connectionId)
    {
    }

    public class HarnesspdfxTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Harnesspdfx;

    public partial class WorkflowManagedActions
    {
        public HarnesspdfxActions Harnesspdfx(string connectionId) => new HarnesspdfxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HarnesspdfxTriggers Harnesspdfx(string connectionId) => new HarnesspdfxTriggers(connectionId);
    }
}