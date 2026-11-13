//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentscorepackfor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentscorepackforActions([ConnectionName] string connectionId)
    {
    }

    public class DocumentscorepackforTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentscorepackfor;

    public partial class WorkflowManagedActions
    {
        public DocumentscorepackforActions Documentscorepackfor(string connectionId) => new DocumentscorepackforActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentscorepackforTriggers Documentscorepackfor(string connectionId) => new DocumentscorepackforTriggers(connectionId);
    }
}