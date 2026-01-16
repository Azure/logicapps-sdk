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
        public IWorkflowTrigger WebhookTrigger(Expression<Func<string>> requestBodyOfWebhookCompanyId = null, string triggerName = null)
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

            requestBodyOfWebhook["callbackURL"] = "@listcallbackurl()";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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