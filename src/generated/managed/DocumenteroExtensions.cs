//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentero
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumenteroActions([ConnectionName] string connectionId)
    {
    }

    public class DocumenteroTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentero;

    public partial class WorkflowManagedActions
    {
        public DocumenteroActions Documentero(string connectionId) => new DocumenteroActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumenteroTriggers Documentero(string connectionId) => new DocumenteroTriggers(connectionId);
    }
}