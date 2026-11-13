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
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhookSubscribeTrigger(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/webhook/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputEventTypeType eventType)
        {
            this.EventType = eventType;
        }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventTypeType EventType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventTypeType
    {
        [EnumMember(Value = "SHARED")]
        Shared,
        [EnumMember(Value = "SIGNED")]
        Signed,
        [EnumMember(Value = "REVIEWED")]
        Reviewed,
        [EnumMember(Value = "DECLINED")]
        Declined,
        [EnumMember(Value = "EDITED")]
        Edited,
        [EnumMember(Value = "CARBON_COPIED")]
        CarbonCopied,
        [EnumMember(Value = "RECALLED")]
        Recalled,
        [EnumMember(Value = "REMINDED")]
        Reminded,
        [EnumMember(Value = "COMPLETED")]
        Completed,
        [EnumMember(Value = "EVIDENCE_REPORT_GENERATED")]
        EvidenceReportGenerated,
        [EnumMember(Value = "DOCUMENT_DELETED")]
        DocumentDeleted
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