//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Passlet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PassletActions([ConnectionName] string connectionId)
    {
    }

    public class PassletTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Passlet;

    public partial class WorkflowManagedActions
    {
        public PassletActions Passlet(string connectionId) => new PassletActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PassletTriggers Passlet(string connectionId) => new PassletTriggers(connectionId);
    }
}