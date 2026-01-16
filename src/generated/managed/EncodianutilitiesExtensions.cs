//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianutilities
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianutilitiesActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianutilitiesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianutilities;

    public partial class WorkflowManagedActions
    {
        public EncodianutilitiesActions Encodianutilities(string connectionId) => new EncodianutilitiesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianutilitiesTriggers Encodianutilities(string connectionId) => new EncodianutilitiesTriggers(connectionId);
    }
}