//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egoi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgoiActions([ConnectionName] string connectionId)
    {
    }

    public class EgoiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Egoi;

    public partial class WorkflowManagedActions
    {
        public EgoiActions Egoi(string connectionId) => new EgoiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EgoiTriggers Egoi(string connectionId) => new EgoiTriggers(connectionId);
    }
}