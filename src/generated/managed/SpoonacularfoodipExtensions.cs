//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Spoonacularfoodip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpoonacularfoodipActions([ConnectionName] string connectionId)
    {
    }

    public class SpoonacularfoodipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Spoonacularfoodip;

    public partial class WorkflowManagedActions
    {
        public SpoonacularfoodipActions Spoonacularfoodip(string connectionId) => new SpoonacularfoodipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpoonacularfoodipTriggers Spoonacularfoodip(string connectionId) => new SpoonacularfoodipTriggers(connectionId);
    }
}