//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connect2all
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Connect2allActions([ConnectionName] string connectionId)
    {
    }

    public class Connect2allTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connect2all;

    public partial class WorkflowManagedActions
    {
        public Connect2allActions Connect2all(string connectionId) => new Connect2allActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Connect2allTriggers Connect2all(string connectionId) => new Connect2allTriggers(connectionId);
    }
}