//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tribalmaytas
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TribalmaytasActions([ConnectionName] string connectionId)
    {
    }

    public class TribalmaytasTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tribalmaytas;

    public partial class WorkflowManagedActions
    {
        public TribalmaytasActions Tribalmaytas(string connectionId) => new TribalmaytasActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TribalmaytasTriggers Tribalmaytas(string connectionId) => new TribalmaytasTriggers(connectionId);
    }
}