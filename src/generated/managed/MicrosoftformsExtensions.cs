//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftforms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        [WorkflowExpressionFactory(nameof(__BuildGetFormResponseById))]
        public IBodyWorkflowAction<JToken> GetFormResponseById([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<int> responseId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFormResponseById(WorkflowValue<string> formId, WorkflowValue<int> responseId)
        {
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            WorkflowValue.Validate(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')/responses", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["response_id"] = ExpressionConverter.Convert(responseId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        [WorkflowExpressionFactory(nameof(__BuildGetFormDetailsById))]
        public IBodyWorkflowAction<GetFormDetailsByIdResult> GetFormDetailsById([WorkflowExpression] Func<string> formId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFormDetailsByIdResult> __BuildGetFormDetailsById(WorkflowValue<string> formId)
        {
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            return new DeferredBodyAction<GetFormDetailsByIdResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("title,modifiedDate,createdDate,status,createdBy");
                return new ApiConnectionAction<GetFormDetailsByIdResult>(callPayload);
            });
        }
    }

    public class MicrosoftformsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateFormWebhook))]
        public IWorkflowTrigger CreateFormWebhook([WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateFormWebhook(WorkflowValue<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/formapi/api/forms/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["eventType"] = "responseAdded";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["notificationUrl"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["source"] = "ms-connector";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
