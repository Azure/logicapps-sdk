//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Latinsharedocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LatinsharedocumentsActions([ConnectionName] string connectionId)
    {
    }

    public class LatinsharedocumentsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Latinsharedocuments;

    public partial class WorkflowManagedActions
    {
        public LatinsharedocumentsActions Latinsharedocuments(string connectionId) => new LatinsharedocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LatinsharedocumentsTriggers Latinsharedocuments(string connectionId) => new LatinsharedocumentsTriggers(connectionId);
    }
}