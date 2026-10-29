//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingairtime
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingairtimeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingairtime")]
        public IBodyWorkflowAction<SendAirtimeResponse, ApiConnectionActionConfiguration> SendAirtime(Expression<Func<SendAirtimeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendAirtimeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version1/airtime/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendAirtimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingairtime")]
        public IBodyWorkflowAction<FindTransactionStatusResponse, ApiConnectionActionConfiguration> FindTransactionStatus(Expression<Func<string>> username, Expression<Func<string>> transactionId)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<FindTransactionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/transaction/find";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["transactionId"] = ExpressionConverter.Convert(__workflow_transactionId);
                return new ApiConnectionAction<FindTransactionStatusResponse>(callPayload);
            });
        }
    }

    public class AfricastalkingairtimeTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AirtimeStatusNotification(Expression<Func<string>> username, FlowRecurrence recurrence = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/powerapps/{0}/airtime/status/callback", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new AirtimeStatusNotificationInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendAirtimeResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("numSent")]
        public int NumSent { get; set; }

        [JsonProperty("responses")]
        public SendAirtimeResponseResponsesTypeItem[] Responses { get; set; }

        [JsonProperty("totalAmount")]
        public string TotalAmount { get; set; }

        [JsonProperty("totalDiscount")]
        public string TotalDiscount { get; set; }
    }

    public class SendAirtimeResponseResponsesTypeItem
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SendAirtimeInput
    {
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendAirtimeInputRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendAirtimeInputRecipientsTypeItem
    {
        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Amount { get; set; }
    }

    public class FindTransactionStatusResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AirtimeStatusNotificationInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingairtime;

    public partial class WorkflowManagedActions
    {
        public AfricastalkingairtimeActions Africastalkingairtime(string connectionId) => new AfricastalkingairtimeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AfricastalkingairtimeTriggers Africastalkingairtime(string connectionId) => new AfricastalkingairtimeTriggers(connectionId);
    }
}