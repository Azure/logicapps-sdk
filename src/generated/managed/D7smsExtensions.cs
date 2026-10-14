//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.D7sms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class D7smsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7sms")]
        public IBodyWorkflowAction<BalanceResponse> Balance()
        {
            var apiCallPath = "/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7sms")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null)
        {
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            return new DeferredBodyAction<SendSMSResponse>(() =>
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
        }
    }

    public class D7smsTriggers([ConnectionName] string connectionId)
    {
    }

    public class BalanceResponse
    {
        [JsonProperty("data")]
        public BalanceResponseDataType Data { get; set; }
    }

    public class BalanceResponseDataType
    {
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("sms_count")]
        public string SmsCount { get; set; }
    }

    public class SendSMSResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.D7sms;

    public partial class WorkflowManagedActions
    {
        public D7smsActions D7sms(string connectionId) => new D7smsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public D7smsTriggers D7sms(string connectionId) => new D7smsTriggers(connectionId);
    }
}
