//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signinghubwebhooks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigninghubwebhooksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghubwebhooks")]
        public IWorkflowAction UnsubscribeWebhook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId)
        {
            var apiCallPath = String.Format("/powerautomate/webhook/unsubscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class SigninghubwebhooksTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookSubscribeTrigger([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/powerautomate/webhook/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public enum bodyeventTypeInput
    {
        SHARED,
        SIGNED,
        REVIEWED,
        DECLINED,
        EDITED,
        [EnumMember(Value = "CARBON_COPIED")]
        CARBONCOPIED,
        RECALLED,
        REMINDED,
        COMPLETED,
        [EnumMember(Value = "EVIDENCE_REPORT_GENERATED")]
        EVIDENCEREPORTGENERATED,
        [EnumMember(Value = "DOCUMENT_DELETED")]
        DOCUMENTDELETED
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signinghubwebhooks;

    public partial class WorkflowManagedActions
    {
        public SigninghubwebhooksActions Signinghubwebhooks(string connectionId) => new SigninghubwebhooksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigninghubwebhooksTriggers Signinghubwebhooks(string connectionId) => new SigninghubwebhooksTriggers(connectionId);
    }
}