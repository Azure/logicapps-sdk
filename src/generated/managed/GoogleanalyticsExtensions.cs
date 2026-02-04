//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googleanalytics
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoogleanalyticsActions([ConnectionName] string connectionId)
    {
    }

    public class GoogleanalyticsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googleanalytics;

    public partial class WorkflowManagedActions
    {
        public GoogleanalyticsActions Googleanalytics(string connectionId) => new GoogleanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoogleanalyticsTriggers Googleanalytics(string connectionId) => new GoogleanalyticsTriggers(connectionId);
    }
}