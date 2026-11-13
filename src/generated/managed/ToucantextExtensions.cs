//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toucantext
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToucantextActions([ConnectionName] string connectionId)
    {
    }

    public class ToucantextTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Toucantext;

    public partial class WorkflowManagedActions
    {
        public ToucantextActions Toucantext(string connectionId) => new ToucantextActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ToucantextTriggers Toucantext(string connectionId) => new ToucantextTriggers(connectionId);
    }
}