//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobeanalytics
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobeanalyticsActions([ConnectionName] string connectionId)
    {
    }

    public class AdobeanalyticsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobeanalytics;

    public partial class WorkflowManagedActions
    {
        public AdobeanalyticsActions Adobeanalytics(string connectionId) => new AdobeanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobeanalyticsTriggers Adobeanalytics(string connectionId) => new AdobeanalyticsTriggers(connectionId);
    }
}