//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Avalaraavatax
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AvalaraavataxActions([ConnectionName] string connectionId)
    {
    }

    public class AvalaraavataxTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Avalaraavatax;

    public partial class WorkflowManagedActions
    {
        public AvalaraavataxActions Avalaraavatax(string connectionId) => new AvalaraavataxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AvalaraavataxTriggers Avalaraavatax(string connectionId) => new AvalaraavataxTriggers(connectionId);
    }
}