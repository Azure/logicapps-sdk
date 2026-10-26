//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enlyftforcopilot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnlyftforcopilotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enlyftforcopilot")]
        public IBodyWorkflowAction<ExportContactFromEnlyftResponse, ApiConnectionActionConfiguration> ExportContactFromEnlyft(Expression<Func<string>> personId = null, Expression<Func<string>> userEmail = null)
        {
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: false);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: false);
            return new DeferredBodyAction<ExportContactFromEnlyftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/export-contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_personId != null)
                    callPayload.Queries["person_id"] = ExpressionConverter.Convert(__workflow_personId);
                if (__workflow_userEmail != null)
                    callPayload.Queries["userEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                return new ApiConnectionAction<ExportContactFromEnlyftResponse>(callPayload);
            });
        }
    }

    public class EnlyftforcopilotTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExportContactFromEnlyftResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ExportContactFromEnlyftResponseDataType Data { get; set; }
    }

    public class ExportContactFromEnlyftResponseDataType
    {
        [JsonProperty("adaptive_card")]
        public JToken AdaptiveCard { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Enlyftforcopilot;

    public partial class WorkflowManagedActions
    {
        public EnlyftforcopilotActions Enlyftforcopilot(string connectionId) => new EnlyftforcopilotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnlyftforcopilotTriggers Enlyftforcopilot(string connectionId) => new EnlyftforcopilotTriggers(connectionId);
    }
}