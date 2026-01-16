//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assemblyai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AssemblyaiActions([ConnectionName] string connectionId)
    {
    }

    public class AssemblyaiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Assemblyai;

    public partial class WorkflowManagedActions
    {
        public AssemblyaiActions Assemblyai(string connectionId) => new AssemblyaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AssemblyaiTriggers Assemblyai(string connectionId) => new AssemblyaiTriggers(connectionId);
    }
}