//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Civicplustransform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CivicplustransformActions([ConnectionName] string connectionId)
    {
    }

    public class CivicplustransformTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Civicplustransform;

    public partial class WorkflowManagedActions
    {
        public CivicplustransformActions Civicplustransform(string connectionId) => new CivicplustransformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CivicplustransformTriggers Civicplustransform(string connectionId) => new CivicplustransformTriggers(connectionId);
    }
}