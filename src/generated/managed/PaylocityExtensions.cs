//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Paylocity
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PaylocityActions([ConnectionName] string connectionId)
    {
    }

    public class PaylocityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> requestBodyOfWebhookCompanyId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(requestBodyOfWebhookCompanyId, nameof(requestBodyOfWebhookCompanyId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/webhooks/TimeOffRequestApprovalNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                if (requestBodyOfWebhookCompanyId != null)
                {
                    requestBodyOfWebhook["companyId"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookCompanyId);
                    requestBodyOfWebhookpropCount++;
                }

                requestBodyOfWebhook["callbackURL"] = "@listCallbackUrl()";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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