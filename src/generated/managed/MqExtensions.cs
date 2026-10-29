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
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Delete(Expression<Func<DeleteV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> DeleteAll(Expression<Func<DeleteAllV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/deleteall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Read(Expression<Func<ReadV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> ReadAll(Expression<Func<ReadAllV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/readall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> Receive(Expression<Func<ReceiveV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/receive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> ReceiveAll(Expression<Func<ReceiveAllV2Input>> options = null)
        {
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/receiveall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_options != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_options);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendV2Response, ApiConnectionActionConfiguration> Send(Expression<Func<SendV2Input>> message)
        {
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<SendV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<SendV2Response>(callPayload);
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

    public class DeleteV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteV2InputIncludeInfoType? IncludeInfo { get; set; } = DeleteV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteV2InputIncludeInfoType
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

    public class DeleteAllV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteAllV2InputIncludeInfoType? IncludeInfo { get; set; } = DeleteAllV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
        public double? BatchSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteAllV2InputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ReadV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadV2InputIncludeInfoType? IncludeInfo { get; set; } = ReadV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadV2InputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ReadAllV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadAllV2InputIncludeInfoType? IncludeInfo { get; set; } = ReadAllV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
        public double? BatchSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadAllV2InputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ReceiveV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ReceiveV2InputIncludeInfoType? IncludeInfo { get; set; } = ReceiveV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReceiveV2InputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ReceiveAllV2Input
    {
        public string Queue { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public string GroupId { get; set; }
        public string MessageToken { get; set; }
        public double? Offset { get; set; }
        public double? LogicalSequenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ReceiveAllV2InputIncludeInfoType? IncludeInfo { get; set; } = ReceiveAllV2InputIncludeInfoType.False;
        public string Timeout { get; set; }
        public double? BatchSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReceiveAllV2InputIncludeInfoType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class SendV2Response
    {
        public string ItemInternalId { get; set; }
        public string MessageData { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
    }

    public class SendV2Input
    {
        public string Queue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendV2InputMessageTypeType? MessageType { get; set; } = SendV2InputMessageTypeType.Datagram;
        public string CorrelationId { get; set; }
        public string MessageId { get; set; }
        public string ReplyToQueue { get; set; }
        public string ReplyToQueueManager { get; set; }
        public double? CodeCharSetId { get; set; }
        public double? Offset { get; set; }
        public string Format { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendV2InputMessageTypeType
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