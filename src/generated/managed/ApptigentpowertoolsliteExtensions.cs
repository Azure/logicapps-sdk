//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Apptigentpowertoolslite
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApptigentpowertoolsliteActions([ConnectionName] string connectionId)
    {
    }

    public class ApptigentpowertoolsliteTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Apptigentpowertoolslite;

    public partial class WorkflowManagedActions
    {
        public ApptigentpowertoolsliteActions Apptigentpowertoolslite(string connectionId) => new ApptigentpowertoolsliteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApptigentpowertoolsliteTriggers Apptigentpowertoolslite(string connectionId) => new ApptigentpowertoolsliteTriggers(connectionId);
    }
}