//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Paylocity
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PaylocityActions([ConnectionName] string connectionId)
    {
    }

    public class PaylocityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger(Expression<Func<string>> requestBodyOfWebhookCompanyId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookCompanyId = WorkflowExpression.Compile(requestBodyOfWebhookCompanyId, nameof(requestBodyOfWebhookCompanyId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v2/webhooks/TimeOffRequestApprovalNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                if (__workflow_requestBodyOfWebhookCompanyId != null)
                {
                    requestBodyOfWebhook["companyId"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookCompanyId);
                    requestBodyOfWebhookpropCount++;
                }

                requestBodyOfWebhook["callbackURL"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
