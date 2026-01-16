//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodiantrigr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodiantrigrActions([ConnectionName] string connectionId)
    {
    }

    public class EncodiantrigrTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodiantrigr;

    public partial class WorkflowManagedActions
    {
        public EncodiantrigrActions Encodiantrigr(string connectionId) => new EncodiantrigrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodiantrigrTriggers Encodiantrigr(string connectionId) => new EncodiantrigrTriggers(connectionId);
    }
}