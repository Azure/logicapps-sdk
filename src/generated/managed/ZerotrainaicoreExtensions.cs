//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zerotrainaicore
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZerotrainaicoreActions([ConnectionName] string connectionId)
    {
    }

    public class ZerotrainaicoreTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zerotrainaicore;

    public partial class WorkflowManagedActions
    {
        public ZerotrainaicoreActions Zerotrainaicore(string connectionId) => new ZerotrainaicoreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZerotrainaicoreTriggers Zerotrainaicore(string connectionId) => new ZerotrainaicoreTriggers(connectionId);
    }
}