//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Showcaseworkshop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShowcaseworkshopActions([ConnectionName] string connectionId)
    {
    }

    public class ShowcaseworkshopTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseShareSendEmail(Expression<Func<string>> workshopUid, Expression<Func<ShowcaseShareSendEmailInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/share_send_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("share_send_email");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseSharedPageView(Expression<Func<string>> workshopUid, Expression<Func<ShowcaseSharedPageViewInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_view";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_view");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseSharedPageDownload(Expression<Func<string>> workshopUid, Expression<Func<ShowcaseSharedPageDownloadInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_download";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_download");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ShowcaseShareSendEmailInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ShowcaseSharedPageViewInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ShowcaseSharedPageDownloadInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Showcaseworkshop;

    public partial class WorkflowManagedActions
    {
        public ShowcaseworkshopActions Showcaseworkshop(string connectionId) => new ShowcaseworkshopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShowcaseworkshopTriggers Showcaseworkshop(string connectionId) => new ShowcaseworkshopTriggers(connectionId);
    }
}