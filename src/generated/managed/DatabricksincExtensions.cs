//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Databricksinc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatabricksincActions([ConnectionName] string connectionId)
    {
    }

    public class DatabricksincTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Databricksinc;

    public partial class WorkflowManagedActions
    {
        public DatabricksincActions Databricksinc(string connectionId) => new DatabricksincActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatabricksincTriggers Databricksinc(string connectionId) => new DatabricksincTriggers(connectionId);
    }
}