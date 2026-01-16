//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exasol
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExasolActions([ConnectionName] string connectionId)
    {
    }

    public class ExasolTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Exasol;

    public partial class WorkflowManagedActions
    {
        public ExasolActions Exasol(string connectionId) => new ExasolActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExasolTriggers Exasol(string connectionId) => new ExasolTriggers(connectionId);
    }
}