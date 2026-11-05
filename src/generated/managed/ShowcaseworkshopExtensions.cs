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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseShareSendEmail(Expression<Func<string>> workshopUid, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/share_send_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("share_send_email");
                callPayload.Body = new RequestBodyOfWebhookInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseSharedPageView(Expression<Func<string>> workshopUid, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_view";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_view");
                callPayload.Body = new RequestBodyOfWebhookInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShowcaseSharedPageDownload(Expression<Func<string>> workshopUid, FlowRecurrence recurrence = null)
        {
            var __workflow_workshopUid = WorkflowExpression.Compile(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_download";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(__workflow_workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_download");
                callPayload.Body = new RequestBodyOfWebhookInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class RequestBodyOfWebhookInput
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