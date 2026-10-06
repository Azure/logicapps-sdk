//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentscorepackapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentscorepackapiActions([ConnectionName] string connectionId)
    {
    }

    public class DocumentscorepackapiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentscorepackapi;

    public partial class WorkflowManagedActions
    {
        public DocumentscorepackapiActions Documentscorepackapi(string connectionId) => new DocumentscorepackapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentscorepackapiTriggers Documentscorepackapi(string connectionId) => new DocumentscorepackapiTriggers(connectionId);
    }
}