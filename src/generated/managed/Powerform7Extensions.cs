//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerform7
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Powerform7Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerform7")]
        public IWorkflowAction SubmitForm(Expression<Func<string>> wPSITEURL, Expression<Func<string>> formId, Expression<Func<object>> query = null)
        {
            var __workflow_wPSITEURL = WorkflowExpression.Compile(wPSITEURL, nameof(wPSITEURL), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/proxy/contact-form-7/v1/contact-forms/{0}/feedback", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(__workflow_wPSITEURL);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerform7")]
        public IBodyWorkflowAction<GetCF7FormsResponseItem[]> GetCF7Forms(Expression<Func<string>> wPSITEURL)
        {
            var __workflow_wPSITEURL = WorkflowExpression.Compile(wPSITEURL, nameof(wPSITEURL), required: true);
            return new DeferredBodyAction<GetCF7FormsResponseItem[]>(() =>
            {
                var apiCallPath = "/proxy/contact-form-7/v1/contact-forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(__workflow_wPSITEURL);
                return new ApiConnectionAction<GetCF7FormsResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class Powerform7Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateWebhook(Expression<Func<string>> wPSITEURL, Expression<Func<string>> formId, FlowRecurrence recurrence = null)
        {
            var __workflow_wPSITEURL = WorkflowExpression.Compile(wPSITEURL, nameof(wPSITEURL), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/proxy/power-form-7/v1/webhooks/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(__workflow_wPSITEURL);
                var callbackUrl = new JObject();
                var callbackUrlpropCount = 0;
                callbackUrl["callback_url"] = "#{listCallbackUrl()}";
                callbackUrlpropCount++;
                if (callbackUrlpropCount > 0)
                {
                    callPayload.Body = callbackUrl;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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
