//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highspotmcptestjan20
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Highspotmcptestjan20Actions([ConnectionName] string connectionId)
    {
    }

    public class Highspotmcptestjan20Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Highspotmcptestjan20;

    public partial class WorkflowManagedActions
    {
        public Highspotmcptestjan20Actions Highspotmcptestjan20(string connectionId) => new Highspotmcptestjan20Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Highspotmcptestjan20Triggers Highspotmcptestjan20(string connectionId) => new Highspotmcptestjan20Triggers(connectionId);
    }
}