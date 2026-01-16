//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connect2allonpremises
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Connect2allonpremisesActions([ConnectionName] string connectionId)
    {
    }

    public class Connect2allonpremisesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Connect2allonpremises;

    public partial class WorkflowManagedActions
    {
        public Connect2allonpremisesActions Connect2allonpremises(string connectionId) => new Connect2allonpremisesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Connect2allonpremisesTriggers Connect2allonpremises(string connectionId) => new Connect2allonpremisesTriggers(connectionId);
    }
}