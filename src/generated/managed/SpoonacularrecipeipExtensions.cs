//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Spoonacularrecipeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpoonacularrecipeipActions([ConnectionName] string connectionId)
    {
    }

    public class SpoonacularrecipeipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Spoonacularrecipeip;

    public partial class WorkflowManagedActions
    {
        public SpoonacularrecipeipActions Spoonacularrecipeip(string connectionId) => new SpoonacularrecipeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpoonacularrecipeipTriggers Spoonacularrecipeip(string connectionId) => new SpoonacularrecipeipTriggers(connectionId);
    }
}