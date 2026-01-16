//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nextcom
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NextcomActions([ConnectionName] string connectionId)
    {
    }

    public class NextcomTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nextcom;

    public partial class WorkflowManagedActions
    {
        public NextcomActions Nextcom(string connectionId) => new NextcomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NextcomTriggers Nextcom(string connectionId) => new NextcomTriggers(connectionId);
    }
}