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
        [WorkflowExpressionFactory(nameof(__BuildUnsubscribeWebhook))]
        public IWorkflowAction UnsubscribeWebhook([WorkflowExpression] Func<string> subscriptionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnsubscribeWebhook(WorkflowExpression<string> subscriptionId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/powerautomate/webhook/unsubscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SigninghubwebhooksTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhookSubscribeTrigger))]
        public IWorkflowTrigger WebhookSubscribeTrigger([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookSubscribeTrigger(WorkflowExpression<bodyeventTypeInput> bodyeventType,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            return new DeferredWorkflowTrigger(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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