//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Businessassist
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BusinessassistActions([ConnectionName] string connectionId)
    {
    }

    public class BusinessassistTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Businessassist;

    public partial class WorkflowManagedActions
    {
        public BusinessassistActions Businessassist(string connectionId) => new BusinessassistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BusinessassistTriggers Businessassist(string connectionId) => new BusinessassistTriggers(connectionId);
    }
}