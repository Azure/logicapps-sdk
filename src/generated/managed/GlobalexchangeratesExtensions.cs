//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Globalexchangerates
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GlobalexchangeratesActions([ConnectionName] string connectionId)
    {
    }

    public class GlobalexchangeratesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Globalexchangerates;

    public partial class WorkflowManagedActions
    {
        public GlobalexchangeratesActions Globalexchangerates(string connectionId) => new GlobalexchangeratesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GlobalexchangeratesTriggers Globalexchangerates(string connectionId) => new GlobalexchangeratesTriggers(connectionId);
    }
}