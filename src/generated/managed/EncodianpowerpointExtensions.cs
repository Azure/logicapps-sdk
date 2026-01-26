//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianpowerpoint
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianpowerpointActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianpowerpointTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianpowerpoint;

    public partial class WorkflowManagedActions
    {
        public EncodianpowerpointActions Encodianpowerpoint(string connectionId) => new EncodianpowerpointActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianpowerpointTriggers Encodianpowerpoint(string connectionId) => new EncodianpowerpointTriggers(connectionId);
    }
}