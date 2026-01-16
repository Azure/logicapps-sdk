//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ppmexpress
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PpmexpressActions([ConnectionName] string connectionId)
    {
    }

    public class PpmexpressTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ppmexpress;

    public partial class WorkflowManagedActions
    {
        public PpmexpressActions Ppmexpress(string connectionId) => new PpmexpressActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PpmexpressTriggers Ppmexpress(string connectionId) => new PpmexpressTriggers(connectionId);
    }
}