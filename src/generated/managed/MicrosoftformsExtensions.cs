//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public IBodyWorkflowAction<JToken> GetFormResponseById([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<int> responseId)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')/responses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["response_id"] = SourceExpressionConverter.ConvertO(responseId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public IBodyWorkflowAction<GetFormDetailsByIdResult> GetFormDetailsById([WorkflowExpression] Func<string> formId)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("title,modifiedDate,createdDate,status,createdBy");
                return callPayload;
            }

            return new ApiConnectionAction<GetFormDetailsByIdResult>(BuildSourceInput);
        }
    }

    public class MicrosoftformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateFormWebhook([WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/formapi/api/forms/{0}/webhooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["eventType"] = "responseAdded";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["notificationUrl"] = "@listCallbackUrl()";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["source"] = "ms-connector";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GetFormDetailsByIdResult
    {
        [JsonProperty("title")]
        public string FormTitle { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftforms;

    public partial class WorkflowManagedActions
    {
        public MicrosoftformsActions Microsoftforms(string connectionId) => new MicrosoftformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftformsTriggers Microsoftforms(string connectionId) => new MicrosoftformsTriggers(connectionId);
    }
}