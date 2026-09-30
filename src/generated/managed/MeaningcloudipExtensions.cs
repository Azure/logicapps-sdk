//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meaningcloudip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeaningcloudipActions([ConnectionName] string connectionId)
    {
    }

    public class MeaningcloudipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Meaningcloudip;

    public partial class WorkflowManagedActions
    {
        public MeaningcloudipActions Meaningcloudip(string connectionId) => new MeaningcloudipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeaningcloudipTriggers Meaningcloudip(string connectionId) => new MeaningcloudipTriggers(connectionId);
    }
}