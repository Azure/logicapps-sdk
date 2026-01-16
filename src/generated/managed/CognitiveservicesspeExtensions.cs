//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesspe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicesspeActions([ConnectionName] string connectionId)
    {
    }

    public class CognitiveservicesspeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesspe;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicesspeActions Cognitiveservicesspe(string connectionId) => new CognitiveservicesspeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicesspeTriggers Cognitiveservicesspe(string connectionId) => new CognitiveservicesspeTriggers(connectionId);
    }
}