//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emailveritasurlcheck
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmailveritasurlcheckActions([ConnectionName] string connectionId)
    {
    }

    public class EmailveritasurlcheckTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emailveritasurlcheck;

    public partial class WorkflowManagedActions
    {
        public EmailveritasurlcheckActions Emailveritasurlcheck(string connectionId) => new EmailveritasurlcheckActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmailveritasurlcheckTriggers Emailveritasurlcheck(string connectionId) => new EmailveritasurlcheckTriggers(connectionId);
    }
}