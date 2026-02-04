//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabsintelligence
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReversinglabsintelligenceActions([ConnectionName] string connectionId)
    {
    }

    public class ReversinglabsintelligenceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabsintelligence;

    public partial class WorkflowManagedActions
    {
        public ReversinglabsintelligenceActions Reversinglabsintelligence(string connectionId) => new ReversinglabsintelligenceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReversinglabsintelligenceTriggers Reversinglabsintelligence(string connectionId) => new ReversinglabsintelligenceTriggers(connectionId);
    }
}