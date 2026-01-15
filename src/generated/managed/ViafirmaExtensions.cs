//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Viafirma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViafirmaActions([ConnectionName] string connectionId)
    {
    }

    public class ViafirmaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Viafirma;

    public partial class WorkflowManagedActions
    {
        public ViafirmaActions Viafirma(string connectionId) => new ViafirmaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ViafirmaTriggers Viafirma(string connectionId) => new ViafirmaTriggers(connectionId);
    }
}