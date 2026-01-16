//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deepl
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeeplActions([ConnectionName] string connectionId)
    {
    }

    public class DeeplTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deepl;

    public partial class WorkflowManagedActions
    {
        public DeeplActions Deepl(string connectionId) => new DeeplActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeeplTriggers Deepl(string connectionId) => new DeeplTriggers(connectionId);
    }
}