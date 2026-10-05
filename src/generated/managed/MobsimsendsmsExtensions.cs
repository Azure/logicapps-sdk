//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobsimsendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobsimsendsms")]
        [WorkflowExpressionFactory(nameof(__BuildSMS))]
        public IBodyWorkflowAction<string> SMS([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodygroupMsg = null, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSMS(WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodygroupMsg = null, WorkflowValue<bodymessagesInputItem[]> bodymessages = null)
        {
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodygroupMsg, nameof(bodygroupMsg), required: false);
            WorkflowValue.Validate(bodymessages, nameof(bodymessages), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodygroupMsg != null)
                {
                    body["groupMsg"] = ExpressionConverter.ConvertO(bodygroupMsg);
                    bodypropCount++;
                }

                if (bodymessages != null)
                {
                    body["messages"] = ExpressionConverter.ConvertO(bodymessages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MobsimsendsmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodymessagesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("key1")]
        public string Key1 { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms;

    public partial class WorkflowManagedActions
    {
        public MobsimsendsmsActions Mobsimsendsms(string connectionId) => new MobsimsendsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobsimsendsmsTriggers Mobsimsendsms(string connectionId) => new MobsimsendsmsTriggers(connectionId);
    }
}
