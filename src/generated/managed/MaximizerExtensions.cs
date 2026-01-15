//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Maximizer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaximizerActions([ConnectionName] string connectionId)
    {
    }

    public class MaximizerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Maximizer;

    public partial class WorkflowManagedActions
    {
        public MaximizerActions Maximizer(string connectionId) => new MaximizerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaximizerTriggers Maximizer(string connectionId) => new MaximizerTriggers(connectionId);
    }
}