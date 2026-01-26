//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Analysisservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnalysisserviceActions([ConnectionName] string connectionId)
    {
    }

    public class AnalysisserviceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Analysisservice;

    public partial class WorkflowManagedActions
    {
        public AnalysisserviceActions Analysisservice(string connectionId) => new AnalysisserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnalysisserviceTriggers Analysisservice(string connectionId) => new AnalysisserviceTriggers(connectionId);
    }
}