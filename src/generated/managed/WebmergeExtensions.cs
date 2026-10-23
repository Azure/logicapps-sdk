//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webmerge
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebmergeActions([ConnectionName] string connectionId)
    {
    }

    public class WebmergeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webmerge;

    public partial class WorkflowManagedActions
    {
        public WebmergeActions Webmerge(string connectionId) => new WebmergeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebmergeTriggers Webmerge(string connectionId) => new WebmergeTriggers(connectionId);
    }
}