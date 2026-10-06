//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smslink
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmslinkActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smslink")]
        [WorkflowExpressionFactory(nameof(__BuildSMSLinkSendSMS))]
        public IBodyWorkflowAction<SMSLinkSendSMSResponse> SMSLinkSendSMS([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodymessage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smslink")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMSLinkSendSMSResponse> __BuildSMSLinkSendSMS(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodymessage)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<SMSLinkSendSMSResponse>(() =>
            {
                var apiCallPath = "/sms/gateway/integration/powerautomate.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SMSLinkSendSMSResponse>(callPayload);
            });
        }
    }

    public class SmslinkTriggers([ConnectionName] string connectionId)
    {
    }

    public class SMSLinkSendSMSResponse
    {
        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }

        [JsonProperty("response_message")]
        public string ResponseMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smslink;

    public partial class WorkflowManagedActions
    {
        public SmslinkActions Smslink(string connectionId) => new SmslinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmslinkTriggers Smslink(string connectionId) => new SmslinkTriggers(connectionId);
    }
}