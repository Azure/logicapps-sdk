//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobeacrobatknowledg
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobeacrobatknowledgActions([ConnectionName] string connectionId)
    {
    }

    public class AdobeacrobatknowledgTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobeacrobatknowledg;

    public partial class WorkflowManagedActions
    {
        public AdobeacrobatknowledgActions Adobeacrobatknowledg(string connectionId) => new AdobeacrobatknowledgActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobeacrobatknowledgTriggers Adobeacrobatknowledg(string connectionId) => new AdobeacrobatknowledgTriggers(connectionId);
    }
}