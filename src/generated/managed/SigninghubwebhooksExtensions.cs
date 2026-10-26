//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signinghubwebhooks
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigninghubwebhooksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghubwebhooks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnsubscribeWebhook(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/powerautomate/webhook/unsubscribe/{0}", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SigninghubwebhooksTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookSubscribeTrigger(Expression<Func<bodyeventTypeInput>> bodyeventType, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/webhook/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
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
        EVIdENCEREPORTGENERATED,
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