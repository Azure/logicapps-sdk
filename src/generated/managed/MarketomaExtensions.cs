//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Marketoma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarketomaActions([ConnectionName] string connectionId)
    {
    }

    public class MarketomaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Marketoma;

    public partial class WorkflowManagedActions
    {
        public MarketomaActions Marketoma(string connectionId) => new MarketomaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarketomaTriggers Marketoma(string connectionId) => new MarketomaTriggers(connectionId);
    }
}