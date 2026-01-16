//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Affirmationsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AffirmationsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "affirmationsip")]
        public IBodyWorkflowAction<AffirmationResponse> Affirmation()
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AffirmationResponse>(callPayload);
        }
    }

    public class AffirmationsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AffirmationResponse
    {
        [JsonProperty("affirmation")]
        public string Affirmation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Affirmationsip;

    public partial class WorkflowManagedActions
    {
        public AffirmationsipActions Affirmationsip(string connectionId) => new AffirmationsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AffirmationsipTriggers Affirmationsip(string connectionId) => new AffirmationsipTriggers(connectionId);
    }
}