//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Spoonacularmealplaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpoonacularmealplaipActions([ConnectionName] string connectionId)
    {
    }

    public class SpoonacularmealplaipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Spoonacularmealplaip;

    public partial class WorkflowManagedActions
    {
        public SpoonacularmealplaipActions Spoonacularmealplaip(string connectionId) => new SpoonacularmealplaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpoonacularmealplaipTriggers Spoonacularmealplaip(string connectionId) => new SpoonacularmealplaipTriggers(connectionId);
    }
}