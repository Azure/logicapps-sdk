//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdftools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdftoolsActions([ConnectionName] string connectionId)
    {
    }

    public class PdftoolsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdftools;

    public partial class WorkflowManagedActions
    {
        public PdftoolsActions Pdftools(string connectionId) => new PdftoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdftoolsTriggers Pdftools(string connectionId) => new PdftoolsTriggers(connectionId);
    }
}