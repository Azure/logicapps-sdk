//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobecommerce
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobecommerceActions([ConnectionName] string connectionId)
    {
    }

    public class AdobecommerceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobecommerce;

    public partial class WorkflowManagedActions
    {
        public AdobecommerceActions Adobecommerce(string connectionId) => new AdobecommerceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobecommerceTriggers Adobecommerce(string connectionId) => new AdobecommerceTriggers(connectionId);
    }
}