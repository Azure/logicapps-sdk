//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instagram
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstagramActions([ConnectionName] string connectionId)
    {
    }

    public class InstagramTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Instagram;

    public partial class WorkflowManagedActions
    {
        public InstagramActions Instagram(string connectionId) => new InstagramActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstagramTriggers Instagram(string connectionId) => new InstagramTriggers(connectionId);
    }
}