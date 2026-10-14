//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smslink
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SmslinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smslink")]
        public IBodyWorkflowAction<SMSLinkSendSMSResponse> SMSLinkSendSMS(Expression<Func<string>> bodyto, Expression<Func<string>> bodymessage)
        {
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<SMSLinkSendSMSResponse>(() =>
            {
                var apiCallPath = "/sms/gateway/integration/powerautomate.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
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
