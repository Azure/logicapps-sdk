//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalytics
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureloganalyticsActions([ConnectionName] string connectionId)
    {
    }

    public class AzureloganalyticsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureloganalytics;

    public partial class WorkflowManagedActions
    {
        public AzureloganalyticsActions Azureloganalytics(string connectionId) => new AzureloganalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureloganalyticsTriggers Azureloganalytics(string connectionId) => new AzureloganalyticsTriggers(connectionId);
    }
}