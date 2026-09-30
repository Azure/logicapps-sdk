//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apify
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApifyActions([ConnectionName] string connectionId)
    {
    }

    public class ApifyTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apify;

    public partial class WorkflowManagedActions
    {
        public ApifyActions Apify(string connectionId) => new ApifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApifyTriggers Apify(string connectionId) => new ApifyTriggers(connectionId);
    }
}