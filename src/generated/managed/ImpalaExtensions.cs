//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Impala
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImpalaActions([ConnectionName] string connectionId)
    {
    }

    public class ImpalaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Impala;

    public partial class WorkflowManagedActions
    {
        public ImpalaActions Impala(string connectionId) => new ImpalaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImpalaTriggers Impala(string connectionId) => new ImpalaTriggers(connectionId);
    }
}