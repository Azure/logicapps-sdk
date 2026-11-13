//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingsms")]
        public IBodyWorkflowAction<SendSmsResponse, ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version1/messaging/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingsms")]
        public IBodyWorkflowAction<FetchInboxResponse, ApiConnectionActionConfiguration> FetchInbox(Expression<Func<string>> userName, Expression<Func<int>> lastReceivedId = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_lastReceivedId = WorkflowExpression.Compile(lastReceivedId, nameof(lastReceivedId), required: false);
            return new DeferredBodyAction<FetchInboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version1/messaging";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_lastReceivedId != null)
                    callPayload.Queries["lastReceivedId"] = ExpressionConverter.Convert(__workflow_lastReceivedId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                return new ApiConnectionAction<FetchInboxResponse>(callPayload);
            });
        }
    }

    public class AfricastalkingsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DlrNotification(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/powerapps/{0}/sms/dlr/callback", __workflow_userName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new BulkSmsOptOutNotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> InboxNotification(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/powerapps/{0}/sms/inbox/callback", __workflow_userName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new BulkSmsOptOutNotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> BulkSmsOptOutNotification(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/powerapps/{0}/sms/optout/callback", __workflow_userName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new BulkSmsOptOutNotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class SendSmsResponse
    {
        [JsonProperty("SMSMessageData")]
        public SendSmsResponseSmsMessageDataType SmsMessageData { get; set; }
    }

    public class SendSmsResponseSmsMessageDataType
    {
        public string Message { get; set; }
        public SendSmsResponseSmsMessageDataTypeRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendSmsResponseSmsMessageDataTypeRecipientsTypeItem
    {
        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("messageParts")]
        public int MessageParts { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }

    public class SendSmsBodyInput
    {
        public SendSmsBodyInput(string userName, string message, string[] phoneNumbers)
        {
            this.UserName = userName;
            this.Message = message;
            this.PhoneNumbers = phoneNumbers;
        }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("phoneNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PhoneNumbers { get; set; }

        [JsonProperty("enqueue")]
        public bool? Enqueue { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }
    }

    public class FetchInboxResponse
    {
        [JsonProperty("SMSMessageData")]
        public FetchInboxResponseSmsMessageDataType SmsMessageData { get; set; }
    }

    public class FetchInboxResponseSmsMessageDataType
    {
        public JToken[] Messages { get; set; }
    }

    public class BulkSmsOptOutNotificationBodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingsms;

    public partial class WorkflowManagedActions
    {
        public AfricastalkingsmsActions Africastalkingsms(string connectionId) => new AfricastalkingsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AfricastalkingsmsTriggers Africastalkingsms(string connectionId) => new AfricastalkingsmsTriggers(connectionId);
    }
}