//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docurain
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocurainActions([ConnectionName] string connectionId)
    {
    }

    public class DocurainTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docurain;

    public partial class WorkflowManagedActions
    {
        public DocurainActions Docurain(string connectionId) => new DocurainActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocurainTriggers Docurain(string connectionId) => new DocurainTriggers(connectionId);
    }
}