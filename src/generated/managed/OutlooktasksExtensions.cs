//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Outlooktasks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutlooktasksActions([ConnectionName] string connectionId)
    {
    }

    public class OutlooktasksTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Outlooktasks;

    public partial class WorkflowManagedActions
    {
        public OutlooktasksActions Outlooktasks(string connectionId) => new OutlooktasksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OutlooktasksTriggers Outlooktasks(string connectionId) => new OutlooktasksTriggers(connectionId);
    }
}