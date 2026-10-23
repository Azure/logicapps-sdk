//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketingv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotmarketingv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Hubspotmarketingv2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketingv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotmarketingv2Actions Hubspotmarketingv2(string connectionId) => new Hubspotmarketingv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotmarketingv2Triggers Hubspotmarketingv2(string connectionId) => new Hubspotmarketingv2Triggers(connectionId);
    }
}