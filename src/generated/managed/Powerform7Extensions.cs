//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerform7
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Powerform7Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerform7")]
        public IWorkflowAction SubmitForm([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> wPSITEURL, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<object> query = null)
        {
            var apiCallPath = String.Format("/proxy/contact-form-7/v1/contact-forms/{0}/feedback", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerform7")]
        public IBodyWorkflowAction<GetCF7FormsResponseItem[]> GetCF7Forms([WorkflowExpression] Func<string> wPSITEURL)
        {
            var apiCallPath = "/proxy/contact-form-7/v1/contact-forms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
            return new ApiConnectionAction<GetCF7FormsResponseItem[]>(callPayload);
        }
    }

    public class Powerform7Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateWebhook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> wPSITEURL, [WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/proxy/power-form-7/v1/webhooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
            var callbackUrl = new JObject();
            var callbackUrlpropCount = 0;
            callbackUrl["callback_url"] = "@listCallbackUrl()";
            callbackUrlpropCount++;
            if (callbackUrlpropCount > 0)
            {
                callPayload.Body = callbackUrl;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class GetCF7FormsResponseItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string FormName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powerform7;

    public partial class WorkflowManagedActions
    {
        public Powerform7Actions Powerform7(string connectionId) => new Powerform7Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Powerform7Triggers Powerform7(string connectionId) => new Powerform7Triggers(connectionId);
    }
}