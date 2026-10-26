//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thesmsworksip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThesmsworksipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ScheduleMessage(Expression<Func<ScheduleMessageInput>> smsMessage)
        {
            var __workflow_smsMessage = WorkflowExpression.Compile(smsMessage, nameof(smsMessage), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/message/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_smsMessage);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetMessages(Expression<Func<object>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetInboxMessages(Expression<Func<object>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/inbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetFailedMessages(Expression<Func<object>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/failed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetScheduledMessages()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/schedule";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CancelScheduledJob(Expression<Func<string>> messageid)
        {
            var __workflow_messageid = WorkflowExpression.Compile(messageid, nameof(messageid), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/schedule/{0}", __workflow_messageid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendBatch(Expression<Func<object>> smsMessage)
        {
            var __workflow_smsMessage = WorkflowExpression.Compile(smsMessage, nameof(smsMessage), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/batch/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_smsMessage);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendAny(Expression<Func<object>> messages)
        {
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/batch/any";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messages);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ScheduleBatch(Expression<Func<object>> smsMessage)
        {
            var __workflow_smsMessage = WorkflowExpression.Compile(smsMessage, nameof(smsMessage), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/batch/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_smsMessage);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CancelScheduledBatchJob(Expression<Func<string>> batchid)
        {
            var __workflow_batchid = WorkflowExpression.Compile(batchid, nameof(batchid), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/batches/schedule/{0}", __workflow_batchid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Credits()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/credits/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Test()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/utils/test";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ThesmsworksipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ScheduleMessageInput
    {
        [JsonProperty("sender", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sender { get; set; }

        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Destination { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("deliveryreporturl")]
        public string Deliveryreporturl { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("ttl")]
        public double? Ttl { get; set; }

        [JsonProperty("responseemail")]
        public string[] Responseemail { get; set; }

        [JsonProperty("metadata")]
        public ScheduleMessageInputMetadataType Metadata { get; set; }

        [JsonProperty("validity")]
        public double? Validity { get; set; }
    }

    public class ScheduleMessageInputMetadataType
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thesmsworksip;

    public partial class WorkflowManagedActions
    {
        public ThesmsworksipActions Thesmsworksip(string connectionId) => new ThesmsworksipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThesmsworksipTriggers Thesmsworksip(string connectionId) => new ThesmsworksipTriggers(connectionId);
    }
}