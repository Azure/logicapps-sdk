//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Flowformav2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Flowformav2Actions([ConnectionName] string connectionId)
    {
    }

    public class Flowformav2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Flowformav2;

    public partial class WorkflowManagedActions
    {
        public Flowformav2Actions Flowformav2(string connectionId) => new Flowformav2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Flowformav2Triggers Flowformav2(string connectionId) => new Flowformav2Triggers(connectionId);
    }
}