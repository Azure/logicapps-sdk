//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Read(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var apiCallPath = "/read";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReadAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var apiCallPath = "/readall";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionsbatchSize != null)
            {
                options["BatchSize"] = ExpressionConverter.ConvertO(optionsbatchSize);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Receive(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var apiCallPath = "/receive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReceiveAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var apiCallPath = "/receiveall";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionsbatchSize != null)
            {
                options["BatchSize"] = ExpressionConverter.ConvertO(optionsbatchSize);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Delete(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var apiCallPath = "/delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> DeleteAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var apiCallPath = "/deleteall";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var options = new JObject();
            var optionspropCount = 0;
            if (optionsqueue != null)
            {
                options["Queue"] = ExpressionConverter.ConvertO(optionsqueue);
                optionspropCount++;
            }

            if (optionsmessageId != null)
            {
                options["MessageId"] = ExpressionConverter.ConvertO(optionsmessageId);
                optionspropCount++;
            }

            if (optionscorrelationId != null)
            {
                options["CorrelationId"] = ExpressionConverter.ConvertO(optionscorrelationId);
                optionspropCount++;
            }

            if (optionsgroupId != null)
            {
                options["GroupId"] = ExpressionConverter.ConvertO(optionsgroupId);
                optionspropCount++;
            }

            if (optionsmessageToken != null)
            {
                options["MessageToken"] = ExpressionConverter.ConvertO(optionsmessageToken);
                optionspropCount++;
            }

            if (optionsoffset != null)
            {
                options["Offset"] = ExpressionConverter.ConvertO(optionsoffset);
                optionspropCount++;
            }

            if (optionslogicalSequenceNumber != null)
            {
                options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(optionslogicalSequenceNumber);
                optionspropCount++;
            }

            if (optionsincludeInfo != null)
            {
                if (optionsincludeInfo != null)
                {
                    options["IncludeInfo"] = ExpressionConverter.ConvertO(optionsincludeInfo);
                    optionspropCount++;
                }

                optionspropCount++;
            }
            else
            {
                options["IncludeInfo"] = "false";
                optionspropCount++;
            }

            if (optionstimeout != null)
            {
                options["Timeout"] = ExpressionConverter.ConvertO(optionstimeout);
                optionspropCount++;
            }

            if (optionsbatchSize != null)
            {
                options["BatchSize"] = ExpressionConverter.ConvertO(optionsbatchSize);
                optionspropCount++;
            }

            if (optionspropCount > 0)
            {
                callPayload.Body = options;
            }

            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendResponse> Send(Expression<Func<string>> messagemessage, Expression<Func<string>> messagequeue = null, Expression<Func<messagemessageTypeInput>> messagemessageType = null, Expression<Func<string>> messagecorrelationId = null, Expression<Func<string>> messagemessageId = null, Expression<Func<string>> messagereplyToQueue = null, Expression<Func<string>> messagereplyToQueueManager = null, Expression<Func<double>> messagecodeCharSetId = null, Expression<Func<double>> messageoffset = null, Expression<Func<string>> messageformat = null)
        {
            var apiCallPath = "/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var message = new JObject();
            var messagepropCount = 0;
            if (messagequeue != null)
            {
                message["Queue"] = ExpressionConverter.ConvertO(messagequeue);
                messagepropCount++;
            }

            messagepropCount++;
            message["Message"] = ExpressionConverter.ConvertO(messagemessage);
            if (messagemessageType != null)
            {
                if (messagemessageType != null)
                {
                    message["MessageType"] = ExpressionConverter.ConvertO(messagemessageType);
                    messagepropCount++;
                }

                messagepropCount++;
            }
            else
            {
                message["MessageType"] = "Datagram";
                messagepropCount++;
            }

            if (messagecorrelationId != null)
            {
                message["CorrelationId"] = ExpressionConverter.ConvertO(messagecorrelationId);
                messagepropCount++;
            }

            if (messagemessageId != null)
            {
                message["MessageId"] = ExpressionConverter.ConvertO(messagemessageId);
                messagepropCount++;
            }

            if (messagereplyToQueue != null)
            {
                message["ReplyToQueue"] = ExpressionConverter.ConvertO(messagereplyToQueue);
                messagepropCount++;
            }

            if (messagereplyToQueueManager != null)
            {
                message["ReplyToQueueManager"] = ExpressionConverter.ConvertO(messagereplyToQueueManager);
                messagepropCount++;
            }

            if (messagecodeCharSetId != null)
            {
                message["CodeCharSetId"] = ExpressionConverter.ConvertO(messagecodeCharSetId);
                messagepropCount++;
            }

            if (messageoffset != null)
            {
                message["Offset"] = ExpressionConverter.ConvertO(messageoffset);
                messagepropCount++;
            }

            if (messageformat != null)
            {
                message["Format"] = ExpressionConverter.ConvertO(messageformat);
                messagepropCount++;
            }

            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction<SendResponse>(callPayload);
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

    public enum optionsincludeInfoInput
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

    public class SendResponse
    {
        public string ItemInternalId { get; set; }
        public string MessageData { get; set; }
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
    }

    public enum messagemessageTypeInput
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