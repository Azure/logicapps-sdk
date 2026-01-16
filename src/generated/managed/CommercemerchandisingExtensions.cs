//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commercemerchandising
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommercemerchandisingActions([ConnectionName] string connectionId)
    {
    }

    public class CommercemerchandisingTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Commercemerchandising;

    public partial class WorkflowManagedActions
    {
        public CommercemerchandisingActions Commercemerchandising(string connectionId) => new CommercemerchandisingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CommercemerchandisingTriggers Commercemerchandising(string connectionId) => new CommercemerchandisingTriggers(connectionId);
    }
}