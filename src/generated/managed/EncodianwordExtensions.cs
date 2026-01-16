//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianword
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianwordActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianwordTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianword;

    public partial class WorkflowManagedActions
    {
        public EncodianwordActions Encodianword(string connectionId) => new EncodianwordActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianwordTriggers Encodianword(string connectionId) => new EncodianwordTriggers(connectionId);
    }
}