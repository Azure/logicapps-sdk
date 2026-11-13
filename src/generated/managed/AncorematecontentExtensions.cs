//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematecontent
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AncorematecontentActions([ConnectionName] string connectionId)
    {
    }

    public class AncorematecontentTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ancorematecontent;

    public partial class WorkflowManagedActions
    {
        public AncorematecontentActions Ancorematecontent(string connectionId) => new AncorematecontentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AncorematecontentTriggers Ancorematecontent(string connectionId) => new AncorematecontentTriggers(connectionId);
    }
}