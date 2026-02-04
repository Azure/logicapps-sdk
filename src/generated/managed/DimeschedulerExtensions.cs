//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dimescheduler
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DimeschedulerActions([ConnectionName] string connectionId)
    {
    }

    public class DimeschedulerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dimescheduler;

    public partial class WorkflowManagedActions
    {
        public DimeschedulerActions Dimescheduler(string connectionId) => new DimeschedulerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DimeschedulerTriggers Dimescheduler(string connectionId) => new DimeschedulerTriggers(connectionId);
    }
}