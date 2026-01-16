//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirlink
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirlinkActions([ConnectionName] string connectionId)
    {
    }

    public class FhirlinkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fhirlink;

    public partial class WorkflowManagedActions
    {
        public FhirlinkActions Fhirlink(string connectionId) => new FhirlinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FhirlinkTriggers Fhirlink(string connectionId) => new FhirlinkTriggers(connectionId);
    }
}