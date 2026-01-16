//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Crossbeam
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CrossbeamActions([ConnectionName] string connectionId)
    {
    }

    public class CrossbeamTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Crossbeam;

    public partial class WorkflowManagedActions
    {
        public CrossbeamActions Crossbeam(string connectionId) => new CrossbeamActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CrossbeamTriggers Crossbeam(string connectionId) => new CrossbeamTriggers(connectionId);
    }
}