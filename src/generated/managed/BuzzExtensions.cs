//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Buzz
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BuzzActions([ConnectionName] string connectionId)
    {
    }

    public class BuzzTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Buzz;

    public partial class WorkflowManagedActions
    {
        public BuzzActions Buzz(string connectionId) => new BuzzActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BuzzTriggers Buzz(string connectionId) => new BuzzTriggers(connectionId);
    }
}