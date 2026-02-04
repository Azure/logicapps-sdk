//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Templafy
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TemplafyActions([ConnectionName] string connectionId)
    {
    }

    public class TemplafyTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Templafy;

    public partial class WorkflowManagedActions
    {
        public TemplafyActions Templafy(string connectionId) => new TemplafyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TemplafyTriggers Templafy(string connectionId) => new TemplafyTriggers(connectionId);
    }
}