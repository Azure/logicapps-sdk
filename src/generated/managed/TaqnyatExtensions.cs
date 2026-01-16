//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taqnyat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaqnyatActions([ConnectionName] string connectionId)
    {
    }

    public class TaqnyatTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Taqnyat;

    public partial class WorkflowManagedActions
    {
        public TaqnyatActions Taqnyat(string connectionId) => new TaqnyatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TaqnyatTriggers Taqnyat(string connectionId) => new TaqnyatTriggers(connectionId);
    }
}