//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Delete(Expression<Func<DeleteOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteOptionsInput().ToJToken();
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> DeleteAll(Expression<Func<DeleteAllOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/deleteall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteAllOptionsInput().ToJToken();
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Read(Expression<Func<DeleteOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteOptionsInput().ToJToken();
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> ReadAll(Expression<Func<DeleteAllOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/readall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteAllOptionsInput().ToJToken();
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Receive(Expression<Func<DeleteOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/receive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteOptionsInput().ToJToken();
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> ReceiveAll(Expression<Func<DeleteAllOptionsInput>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/receiveall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                else
                    callPayload.Body = new DeleteAllOptionsInput().ToJToken();
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendResponse, ApiConnectionActionConfiguration> Send(Expression<Func<MessageInput>> message)
        {
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<SendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<SendResponse>(callPayload);
            });
        }
    }

    public class MqTriggers([ConnectionName] string connectionId)
    {
    }

    public class Item
    {
        public string ItemInternalId { get; set; }
        public string MessageData { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string PutDateTime { get; set; }
        public string UserIdentifier { get; set; }
        public string PutApplicationName { get; set; }
        public string PutApplicationType { get; set; }
        public string Format { get; set; }
        public string AccountingToken { get; set; }
        public int Ccsid { get; set; }
        public string GroupId { get; set; }
        public int LogicalSequenceNumber { get; set; }
        public string MessageType { get; set; }
        public int Offset { get; set; }
        public int OriginalLength { get; set; }
        public string Persistence { get; set; }
        public int Priority { get; set; }
        public string ReplyToQueue { get; set; }
        public string ReplyToQueueManager { get; set; }
    }

    public class DeleteOptionsInput
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OptionsInputIncludeInfoType? IncludeInfo { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Mq.OptionsInputIncludeInfoType.False;
        public string Timeout { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OptionsInputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class DeleteAllOptionsInput
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OptionsInputIncludeInfoType? IncludeInfo { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Mq.OptionsInputIncludeInfoType.False;
        public string Timeout { get; set; }
        public double? BatchSize { get; set; }
    }

    public class SendResponse
    {
        public string ItemInternalId { get; set; }
        public string MessageData { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
    }

    public class MessageInput
    {
        public MessageInput(string message)
        {
            this.Message = message;
        }

        public string Queue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageInputMessageTypeType? MessageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Mq.MessageInputMessageTypeType.Datagram;
        public string CorrelationId { get; set; }
        public string MessageId { get; set; }
        public string ReplyToQueue { get; set; }
        public string ReplyToQueueManager { get; set; }
        public double? CodeCharSetId { get; set; }
        public double? Offset { get; set; }
        public string Format { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageInputMessageTypeType
    {
        Datagram,
        Reply,
        Request
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mq;

    public partial class WorkflowManagedActions
    {
        public MqActions Mq(string connectionId) => new MqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MqTriggers Mq(string connectionId) => new MqTriggers(connectionId);
    }
}