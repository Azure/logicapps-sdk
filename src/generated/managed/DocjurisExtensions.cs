//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docjuris
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocjurisActions([ConnectionName] string connectionId)
    {
    }

    public class DocjurisTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docjuris;

    public partial class WorkflowManagedActions
    {
        public DocjurisActions Docjuris(string connectionId) => new DocjurisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocjurisTriggers Docjuris(string connectionId) => new DocjurisTriggers(connectionId);
    }
}