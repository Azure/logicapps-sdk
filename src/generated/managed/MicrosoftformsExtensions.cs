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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFormResponseById(WorkflowExpression<string> formId, WorkflowExpression<int> responseId)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(responseId, nameof(responseId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFormDetailsByIdResult> __BuildGetFormDetailsById(WorkflowExpression<string> formId)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
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
        public IWorkflowTrigger CreateFormWebhook([WorkflowExpression] Func<string> formId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateFormWebhook(WorkflowExpression<string> formId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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