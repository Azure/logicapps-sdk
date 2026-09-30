//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sproofsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SproofsignActions([ConnectionName] string connectionId)
    {
    }

    public class SproofsignTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sproofsign;

    public partial class WorkflowManagedActions
    {
        public SproofsignActions Sproofsign(string connectionId) => new SproofsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SproofsignTriggers Sproofsign(string connectionId) => new SproofsignTriggers(connectionId);
    }
}