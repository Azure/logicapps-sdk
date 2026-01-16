//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecdr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivecdrActions([ConnectionName] string connectionId)
    {
    }

    public class CloudmersivecdrTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivecdr;

    public partial class WorkflowManagedActions
    {
        public CloudmersivecdrActions Cloudmersivecdr(string connectionId) => new CloudmersivecdrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivecdrTriggers Cloudmersivecdr(string connectionId) => new CloudmersivecdrTriggers(connectionId);
    }
}