//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Secretserver
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecretserverActions([ConnectionName] string connectionId)
    {
    }

    public class SecretserverTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Secretserver;

    public partial class WorkflowManagedActions
    {
        public SecretserverActions Secretserver(string connectionId) => new SecretserverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecretserverTriggers Secretserver(string connectionId) => new SecretserverTriggers(connectionId);
    }
}