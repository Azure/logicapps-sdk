//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Passageby1passwordma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Passageby1passwordmaActions([ConnectionName] string connectionId)
    {
    }

    public class Passageby1passwordmaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Passageby1passwordma;

    public partial class WorkflowManagedActions
    {
        public Passageby1passwordmaActions Passageby1passwordma(string connectionId) => new Passageby1passwordmaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Passageby1passwordmaTriggers Passageby1passwordma(string connectionId) => new Passageby1passwordmaTriggers(connectionId);
    }
}