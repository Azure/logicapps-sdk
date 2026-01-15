//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Apptigentcloudtools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentcloudtoolsActions([ConnectionName] string connectionId)
    {
    }

    public class ApptigentcloudtoolsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Apptigentcloudtools;

    public partial class WorkflowManagedActions
    {
        public ApptigentcloudtoolsActions Apptigentcloudtools(string connectionId) => new ApptigentcloudtoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApptigentcloudtoolsTriggers Apptigentcloudtools(string connectionId) => new ApptigentcloudtoolsTriggers(connectionId);
    }
}