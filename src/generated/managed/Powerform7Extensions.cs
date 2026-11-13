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
        public IBodyWorkflowAction<GetCF7FormsResponseItem[], ApiConnectionActionConfiguration> GetCF7Forms(Expression<Func<string>> wpSiteurl)
        {
            var __workflow_wpSiteurl = WorkflowExpression.Compile(wpSiteurl, nameof(wpSiteurl), required: true);
            return new DeferredBodyAction<GetCF7FormsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/proxy/contact-form-7/v1/contact-forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(__workflow_wpSiteurl);
                return new ApiConnectionAction<GetCF7FormsResponseItem[]>(callPayload);
            });
        }
    }

    public class Powerform7Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateWebhook(Expression<Func<string>> wpSiteurl, Expression<Func<string>> formId)
        {
            var __workflow_wpSiteurl = WorkflowExpression.Compile(wpSiteurl, nameof(wpSiteurl), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/proxy/power-form-7/v1/webhooks/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WP_SITEURL"] = ExpressionConverter.Convert(__workflow_wpSiteurl);
                callPayload.Body = new CallbackUrlInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
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

    public class CallbackUrlInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
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