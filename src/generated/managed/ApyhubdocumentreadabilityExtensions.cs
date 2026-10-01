//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubdocumentreadability
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubdocumentreadabilityActions([ConnectionName] string connectionId)
    {
    }

    public class ApyhubdocumentreadabilityTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubdocumentreadability;

    public partial class WorkflowManagedActions
    {
        public ApyhubdocumentreadabilityActions Apyhubdocumentreadability(string connectionId) => new ApyhubdocumentreadabilityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApyhubdocumentreadabilityTriggers Apyhubdocumentreadability(string connectionId) => new ApyhubdocumentreadabilityTriggers(connectionId);
    }
}