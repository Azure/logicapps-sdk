//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Paylocity
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PaylocityActions([ConnectionName] string connectionId)
    {
    }

    public class PaylocityTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildWebhookTrigger))]
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> requestBodyOfWebhookCompanyId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookTrigger(WorkflowValue<string> requestBodyOfWebhookCompanyId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(requestBodyOfWebhookCompanyId, nameof(requestBodyOfWebhookCompanyId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v2/webhooks/TimeOffRequestApprovalNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                if (requestBodyOfWebhookCompanyId != null)
                {
                    requestBodyOfWebhook["companyId"] = ExpressionConverter.ConvertO(requestBodyOfWebhookCompanyId);
                    requestBodyOfWebhookpropCount++;
                }

                requestBodyOfWebhook["callbackURL"] = "#{listCallbackUrl()}";
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Paylocity;

    public partial class WorkflowManagedActions
    {
        public PaylocityActions Paylocity(string connectionId) => new PaylocityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PaylocityTriggers Paylocity(string connectionId) => new PaylocityTriggers(connectionId);
    }
}
