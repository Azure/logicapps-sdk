//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazonredshift
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmazonredshiftActions([ConnectionName] string connectionId)
    {
    }

    public class AmazonredshiftTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Amazonredshift;

    public partial class WorkflowManagedActions
    {
        public AmazonredshiftActions Amazonredshift(string connectionId) => new AmazonredshiftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AmazonredshiftTriggers Amazonredshift(string connectionId) => new AmazonredshiftTriggers(connectionId);
    }
}