//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365video
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365videoActions([ConnectionName] string connectionId)
    {
    }

    public class Office365videoTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365video;

    public partial class WorkflowManagedActions
    {
        public Office365videoActions Office365video(string connectionId) => new Office365videoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365videoTriggers Office365video(string connectionId) => new Office365videoTriggers(connectionId);
    }
}