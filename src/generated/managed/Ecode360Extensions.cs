//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecode360
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ecode360Actions([ConnectionName] string connectionId)
    {
    }

    public class Ecode360Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ecode360;

    public partial class WorkflowManagedActions
    {
        public Ecode360Actions Ecode360(string connectionId) => new Ecode360Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ecode360Triggers Ecode360(string connectionId) => new Ecode360Triggers(connectionId);
    }
}