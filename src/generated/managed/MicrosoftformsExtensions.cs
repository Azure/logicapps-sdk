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
        public IBodyWorkflowAction<JToken> GetFormResponseById(Expression<Func<string>> formId, Expression<Func<int>> responseId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')/responses", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["response_id"] = CSharpExpressionConverter.ConvertO(responseId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public IBodyWorkflowAction<GetFormDetailsByIdResult> GetFormDetailsById(Expression<Func<string>> formId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/formapi/api/forms('{0}')", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$select"] = Convert.ToString("title,modifiedDate,createdDate,status,createdBy");
            return new ApiConnectionAction<GetFormDetailsByIdResult>(callPayload);
        }
    }

    public class MicrosoftformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateFormWebhook(Expression<Func<string>> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/formapi/api/forms/{0}/webhooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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