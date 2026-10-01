//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Minipdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MinipdfActions([ConnectionName] string connectionId)
    {
    }

    public class MinipdfTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Minipdf;

    public partial class WorkflowManagedActions
    {
        public MinipdfActions Minipdf(string connectionId) => new MinipdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MinipdfTriggers Minipdf(string connectionId) => new MinipdfTriggers(connectionId);
    }
}