//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oneflow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OneflowActions([ConnectionName] string connectionId)
    {
    }

    public class OneflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookRegister(Expression<Func<bodyupdateTypeInputItem[]>> bodyupdateType, Expression<Func<int>> bodytemplateGroupId = null, string triggerName = null)
        {
            var apiCallPath = "/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["filters"] = ExpressionConverter.ConvertO(bodyupdateType);
            if (bodytemplateGroupId != null)
            {
                body["template_group_id"] = ExpressionConverter.ConvertO(bodytemplateGroupId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public enum bodyupdateTypeInputItem
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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