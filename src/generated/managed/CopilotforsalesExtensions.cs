//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copilotforsales
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopilotforsalesActions([ConnectionName] string connectionId)
    {
    }

    public class CopilotforsalesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Copilotforsales;

    public partial class WorkflowManagedActions
    {
        public CopilotforsalesActions Copilotforsales(string connectionId) => new CopilotforsalesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CopilotforsalesTriggers Copilotforsales(string connectionId) => new CopilotforsalesTriggers(connectionId);
    }
}