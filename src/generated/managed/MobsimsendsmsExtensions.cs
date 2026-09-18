//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobsimsendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobsimsendsms")]
        public IBodyWorkflowAction<string> SMS([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodygroupMsg = null, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodygroupMsg, nameof(bodygroupMsg), required: false);
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodygroupMsg != null)
                {
                    body["groupMsg"] = SourceExpressionConverter.ConvertToken(bodygroupMsg);
                    bodypropCount++;
                }

                if (bodymessages != null)
                {
                    body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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