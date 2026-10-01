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
        public IBodyWorkflowAction<Item> Delete([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> DeleteAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/deleteall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionsbatchSize != null)
                {
                    options["BatchSize"] = SourceExpressionConverter.ConvertToken(optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Read([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReadAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/readall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionsbatchSize != null)
                {
                    options["BatchSize"] = SourceExpressionConverter.ConvertToken(optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Receive([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/receive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReceiveAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/receiveall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (optionsqueue != null)
                {
                    options["Queue"] = SourceExpressionConverter.ConvertToken(optionsqueue);
                    optionspropCount++;
                }

                if (optionsmessageId != null)
                {
                    options["MessageId"] = SourceExpressionConverter.ConvertToken(optionsmessageId);
                    optionspropCount++;
                }

                if (optionscorrelationId != null)
                {
                    options["CorrelationId"] = SourceExpressionConverter.ConvertToken(optionscorrelationId);
                    optionspropCount++;
                }

                if (optionsgroupId != null)
                {
                    options["GroupId"] = SourceExpressionConverter.ConvertToken(optionsgroupId);
                    optionspropCount++;
                }

                if (optionsmessageToken != null)
                {
                    options["MessageToken"] = SourceExpressionConverter.ConvertToken(optionsmessageToken);
                    optionspropCount++;
                }

                if (optionsoffset != null)
                {
                    options["Offset"] = SourceExpressionConverter.ConvertToken(optionsoffset);
                    optionspropCount++;
                }

                if (optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = SourceExpressionConverter.ConvertToken(optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (optionsincludeInfo != null)
                {
                    if (optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = SourceExpressionConverter.Convert(optionsincludeInfo);
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
                    options["Timeout"] = SourceExpressionConverter.ConvertToken(optionstimeout);
                    optionspropCount++;
                }

                if (optionsbatchSize != null)
                {
                    options["BatchSize"] = SourceExpressionConverter.ConvertToken(optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendV2Response> Send([WorkflowExpression] Func<string> messagemessage, [WorkflowExpression] Func<string> messagequeue = null, [WorkflowExpression] Func<messagemessageTypeInput> messagemessageType = null, [WorkflowExpression] Func<string> messagecorrelationId = null, [WorkflowExpression] Func<string> messagemessageId = null, [WorkflowExpression] Func<string> messagereplyToQueue = null, [WorkflowExpression] Func<string> messagereplyToQueueManager = null, [WorkflowExpression] Func<double> messagecodeCharSetId = null, [WorkflowExpression] Func<double> messageoffset = null, [WorkflowExpression] Func<string> messageformat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                if (messagequeue != null)
                {
                    message["Queue"] = SourceExpressionConverter.ConvertToken(messagequeue);
                    messagepropCount++;
                }

                messagepropCount++;
                message["Message"] = SourceExpressionConverter.ConvertToken(messagemessage);
                if (messagemessageType != null)
                {
                    if (messagemessageType != null)
                    {
                        message["MessageType"] = SourceExpressionConverter.Convert(messagemessageType);
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
                    message["CorrelationId"] = SourceExpressionConverter.ConvertToken(messagecorrelationId);
                    messagepropCount++;
                }

                if (messagemessageId != null)
                {
                    message["MessageId"] = SourceExpressionConverter.ConvertToken(messagemessageId);
                    messagepropCount++;
                }

                if (messagereplyToQueue != null)
                {
                    message["ReplyToQueue"] = SourceExpressionConverter.ConvertToken(messagereplyToQueue);
                    messagepropCount++;
                }

                if (messagereplyToQueueManager != null)
                {
                    message["ReplyToQueueManager"] = SourceExpressionConverter.ConvertToken(messagereplyToQueueManager);
                    messagepropCount++;
                }

                if (messagecodeCharSetId != null)
                {
                    message["CodeCharSetId"] = SourceExpressionConverter.ConvertToken(messagecodeCharSetId);
                    messagepropCount++;
                }

                if (messageoffset != null)
                {
                    message["Offset"] = SourceExpressionConverter.ConvertToken(messageoffset);
                    messagepropCount++;
                }

                if (messageformat != null)
                {
                    message["Format"] = SourceExpressionConverter.ConvertToken(messageformat);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendV2Response>(BuildSourceInput);
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

    public class SendV2Response
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