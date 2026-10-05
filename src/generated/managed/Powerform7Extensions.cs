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
        [WorkflowExpressionFactory(nameof(__BuildSubmitForm))]
        public IWorkflowAction SubmitForm([WorkflowExpression] Func<string> wPSITEURL, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<object> query = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubmitForm(WorkflowValue<string> wPSITEURL, WorkflowValue<string> formId, WorkflowValue<object> query = null)
        {
            WorkflowValue.Validate(wPSITEURL, nameof(wPSITEURL), required: true);
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            WorkflowValue.Validate(query, nameof(query), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/proxy/contact-form-7/v1/contact-forms/{0}/feedback", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
                callPayload.Body = ExpressionConverter.ConvertO(query);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerform7")]
        [WorkflowExpressionFactory(nameof(__BuildGetCF7Forms))]
        public IBodyWorkflowAction<GetCF7FormsResponseItem[]> GetCF7Forms([WorkflowExpression] Func<string> wPSITEURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCF7FormsResponseItem[]> __BuildGetCF7Forms(WorkflowValue<string> wPSITEURL)
        {
            WorkflowValue.Validate(wPSITEURL, nameof(wPSITEURL), required: true);
            return new DeferredBodyAction<GetCF7FormsResponseItem[]>(() =>
            {
                var apiCallPath = "/proxy/contact-form-7/v1/contact-forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
                return new ApiConnectionAction<GetCF7FormsResponseItem[]>(callPayload);
            });
        }
    }

    public class Powerform7Triggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateWebhook))]
        public IWorkflowTrigger CreateWebhook([WorkflowExpression] Func<string> wPSITEURL, [WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateWebhook(WorkflowValue<string> wPSITEURL, WorkflowValue<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(wPSITEURL, nameof(wPSITEURL), required: true);
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/proxy/power-form-7/v1/webhooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(wPSITEURL);
                var callbackUrl = new JObject();
                var callbackUrlpropCount = 0;
                callbackUrl["callback_url"] = "#{listCallbackUrl()}";
                callbackUrlpropCount++;
                if (callbackUrlpropCount > 0)
                {
                    callPayload.Body = callbackUrl;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
