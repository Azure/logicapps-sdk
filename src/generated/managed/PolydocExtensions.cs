//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Polydoc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolydocActions([ConnectionName] string connectionId)
    {
    }

    public class PolydocTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Polydoc;

    public partial class WorkflowManagedActions
    {
        public PolydocActions Polydoc(string connectionId) => new PolydocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PolydocTriggers Polydoc(string connectionId) => new PolydocTriggers(connectionId);
    }
}