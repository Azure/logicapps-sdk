//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sherpadigital
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SherpadigitalActions([ConnectionName] string connectionId)
    {
    }

    public class SherpadigitalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sherpadigital;

    public partial class WorkflowManagedActions
    {
        public SherpadigitalActions Sherpadigital(string connectionId) => new SherpadigitalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SherpadigitalTriggers Sherpadigital(string connectionId) => new SherpadigitalTriggers(connectionId);
    }
}