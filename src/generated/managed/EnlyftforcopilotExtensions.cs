//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enlyftforcopilot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnlyftforcopilotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enlyftforcopilot")]
        public IBodyWorkflowAction<ExportContactFromEnlyftResponse> ExportContactFromEnlyft([WorkflowExpression] Func<string> personId = null, [WorkflowExpression] Func<string> userEmail = null)
        {
            SourceExpression.Validate(personId, nameof(personId), required: false);
            SourceExpression.Validate(userEmail, nameof(userEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/export-contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (personId != null)
                    callPayload.Queries["person_id"] = SourceExpressionConverter.ConvertO(personId);
                if (userEmail != null)
                    callPayload.Queries["userEmail"] = SourceExpressionConverter.ConvertO(userEmail);
                return callPayload;
            }

            return new ApiConnectionAction<ExportContactFromEnlyftResponse>(BuildSourceInput);
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