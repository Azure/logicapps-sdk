//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Indinsurance
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndinsuranceActions([ConnectionName] string connectionId)
    {
    }

    public class IndinsuranceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Indinsurance;

    public partial class WorkflowManagedActions
    {
        public IndinsuranceActions Indinsurance(string connectionId) => new IndinsuranceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndinsuranceTriggers Indinsurance(string connectionId) => new IndinsuranceTriggers(connectionId);
    }
}