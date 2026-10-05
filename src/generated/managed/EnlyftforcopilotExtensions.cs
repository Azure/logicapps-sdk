//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enlyftforcopilot
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnlyftforcopilotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enlyftforcopilot")]
        [WorkflowExpressionFactory(nameof(__BuildExportContactFromEnlyft))]
        public IBodyWorkflowAction<ExportContactFromEnlyftResponse> ExportContactFromEnlyft([WorkflowExpression] Func<string> personId = null, [WorkflowExpression] Func<string> userEmail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportContactFromEnlyftResponse> __BuildExportContactFromEnlyft(WorkflowValue<string> personId = null, WorkflowValue<string> userEmail = null)
        {
            WorkflowValue.Validate(personId, nameof(personId), required: false);
            WorkflowValue.Validate(userEmail, nameof(userEmail), required: false);
            return new DeferredBodyAction<ExportContactFromEnlyftResponse>(() =>
            {
                var apiCallPath = "/export-contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (personId != null)
                    callPayload.Queries["person_id"] = ExpressionConverter.Convert(personId);
                if (userEmail != null)
                    callPayload.Queries["userEmail"] = ExpressionConverter.Convert(userEmail);
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
