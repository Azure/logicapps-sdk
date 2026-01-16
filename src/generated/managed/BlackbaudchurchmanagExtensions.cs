//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudchurchmanag
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudchurchmanagActions([ConnectionName] string connectionId)
    {
    }

    public class BlackbaudchurchmanagTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudchurchmanag;

    public partial class WorkflowManagedActions
    {
        public BlackbaudchurchmanagActions Blackbaudchurchmanag(string connectionId) => new BlackbaudchurchmanagActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudchurchmanagTriggers Blackbaudchurchmanag(string connectionId) => new BlackbaudchurchmanagTriggers(connectionId);
    }
}