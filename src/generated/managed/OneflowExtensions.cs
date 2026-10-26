//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oneflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OneflowActions([ConnectionName] string connectionId)
    {
    }

    public class OneflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookRegister(Expression<Func<WebhookRegisterInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookRegisterInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookRegisterInputUpdateTypeTypeItem[] UpdateType { get; set; }

        [JsonProperty("template_group_id")]
        public int? TemplateGroupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookRegisterInputUpdateTypeTypeItem
    {
        [EnumMember(Value = "contract:publish")]
        ContractPublish,
        [EnumMember(Value = "contract:sign")]
        ContractSign,
        [EnumMember(Value = "contract:delete")]
        ContractDelete,
        [EnumMember(Value = "contract:decline")]
        ContractDecline,
        [EnumMember(Value = "participant:first_visit")]
        ParticipantFirstVisit,
        [EnumMember(Value = "participant:sign")]
        ParticipantSign,
        [EnumMember(Value = "participant:create")]
        ParticipantCreate,
        [EnumMember(Value = "participant:decline")]
        ParticipantDecline,
        [EnumMember(Value = "participant:delete")]
        ParticipantDelete,
        [EnumMember(Value = "data_field:update")]
        DataFieldUpdate,
        [EnumMember(Value = "contract:signing_period_expire")]
        ContractSigningPeriodExpire,
        [EnumMember(Value = "contract:signing_period_revive")]
        ContractSigningPeriodRevive,
        [EnumMember(Value = "contract:signature_reset")]
        ContractSignatureReset
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oneflow;

    public partial class WorkflowManagedActions
    {
        public OneflowActions Oneflow(string connectionId) => new OneflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OneflowTriggers Oneflow(string connectionId) => new OneflowTriggers(connectionId);
    }
}