//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobsimsendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobsimsendsms")]
        public IBodyWorkflowAction<string> SMS(Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodygroupMsg = null, Expression<Func<bodymessagesInputItem[]>> bodymessages = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodygroupMsg = WorkflowExpression.Compile(bodygroupMsg, nameof(bodygroupMsg), required: false);
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupMsg != null)
                {
                    body["groupMsg"] = ExpressionConverter.ConvertO(__workflow_bodygroupMsg);
                    bodypropCount++;
                }

                if (__workflow_bodymessages != null)
                {
                    body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
