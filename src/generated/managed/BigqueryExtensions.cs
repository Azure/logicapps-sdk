//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bigquery
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BigqueryActions([ConnectionName] string connectionId)
    {
    }

    public class BigqueryTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bigquery;

    public partial class WorkflowManagedActions
    {
        public BigqueryActions Bigquery(string connectionId) => new BigqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BigqueryTriggers Bigquery(string connectionId) => new BigqueryTriggers(connectionId);
    }
}