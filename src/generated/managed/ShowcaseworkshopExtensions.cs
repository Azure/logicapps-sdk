//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Showcaseworkshop
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShowcaseworkshopActions([ConnectionName] string connectionId)
    {
    }

    public class ShowcaseworkshopTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildShowcaseShareSendEmail))]
        public IWorkflowTrigger ShowcaseShareSendEmail([WorkflowExpression] Func<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildShowcaseShareSendEmail(WorkflowValue<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/share_send_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("share_send_email");
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["callback_url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildShowcaseSharedPageView))]
        public IWorkflowTrigger ShowcaseSharedPageView([WorkflowExpression] Func<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildShowcaseSharedPageView(WorkflowValue<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_view";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_view");
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["callback_url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildShowcaseSharedPageDownload))]
        public IWorkflowTrigger ShowcaseSharedPageDownload([WorkflowExpression] Func<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildShowcaseSharedPageDownload(WorkflowValue<string> workshopUid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workshopUid, nameof(workshopUid), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/main/integrations/ms_create_webhook/shared_page_download";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workshop_uid"] = ExpressionConverter.Convert(workshopUid);
                callPayload.Queries["event_name"] = Convert.ToString("shared_page_download");
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["callback_url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
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
