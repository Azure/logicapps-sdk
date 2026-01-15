//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Uspatenttrademarkoff
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UspatenttrademarkoffActions([ConnectionName] string connectionId)
    {
    }

    public class UspatenttrademarkoffTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Uspatenttrademarkoff;

    public partial class WorkflowManagedActions
    {
        public UspatenttrademarkoffActions Uspatenttrademarkoff(string connectionId) => new UspatenttrademarkoffActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UspatenttrademarkoffTriggers Uspatenttrademarkoff(string connectionId) => new UspatenttrademarkoffTriggers(connectionId);
    }
}