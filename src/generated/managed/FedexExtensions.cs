//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fedex
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FedexActions([ConnectionName] string connectionId)
    {
    }

    public class FedexTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fedex;

    public partial class WorkflowManagedActions
    {
        public FedexActions Fedex(string connectionId) => new FedexActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FedexTriggers Fedex(string connectionId) => new FedexTriggers(connectionId);
    }
}