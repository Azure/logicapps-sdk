//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Read(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = "/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReadAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            var __workflow_optionsbatchSize = WorkflowExpression.Compile(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/readall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (__workflow_optionsbatchSize != null)
                {
                    options["BatchSize"] = ExpressionConverter.ConvertO(__workflow_optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Receive(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = "/receive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> ReceiveAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            var __workflow_optionsbatchSize = WorkflowExpression.Compile(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/receiveall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (__workflow_optionsbatchSize != null)
                {
                    options["BatchSize"] = ExpressionConverter.ConvertO(__workflow_optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<Item> Delete(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = "/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<ItemsList> DeleteAll(Expression<Func<string>> optionsqueue = null, Expression<Func<string>> optionsmessageId = null, Expression<Func<string>> optionscorrelationId = null, Expression<Func<string>> optionsgroupId = null, Expression<Func<string>> optionsmessageToken = null, Expression<Func<double>> optionsoffset = null, Expression<Func<double>> optionslogicalSequenceNumber = null, Expression<Func<optionsincludeInfoInput>> optionsincludeInfo = null, Expression<Func<string>> optionstimeout = null, Expression<Func<double>> optionsbatchSize = null)
        {
            var __workflow_optionsqueue = WorkflowExpression.Compile(optionsqueue, nameof(optionsqueue), required: false);
            var __workflow_optionsmessageId = WorkflowExpression.Compile(optionsmessageId, nameof(optionsmessageId), required: false);
            var __workflow_optionscorrelationId = WorkflowExpression.Compile(optionscorrelationId, nameof(optionscorrelationId), required: false);
            var __workflow_optionsgroupId = WorkflowExpression.Compile(optionsgroupId, nameof(optionsgroupId), required: false);
            var __workflow_optionsmessageToken = WorkflowExpression.Compile(optionsmessageToken, nameof(optionsmessageToken), required: false);
            var __workflow_optionsoffset = WorkflowExpression.Compile(optionsoffset, nameof(optionsoffset), required: false);
            var __workflow_optionslogicalSequenceNumber = WorkflowExpression.Compile(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            var __workflow_optionsincludeInfo = WorkflowExpression.Compile(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            var __workflow_optionstimeout = WorkflowExpression.Compile(optionstimeout, nameof(optionstimeout), required: false);
            var __workflow_optionsbatchSize = WorkflowExpression.Compile(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = "/deleteall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var options = new JObject();
                var optionspropCount = 0;
                if (__workflow_optionsqueue != null)
                {
                    options["Queue"] = ExpressionConverter.ConvertO(__workflow_optionsqueue);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageId != null)
                {
                    options["MessageId"] = ExpressionConverter.ConvertO(__workflow_optionsmessageId);
                    optionspropCount++;
                }

                if (__workflow_optionscorrelationId != null)
                {
                    options["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_optionscorrelationId);
                    optionspropCount++;
                }

                if (__workflow_optionsgroupId != null)
                {
                    options["GroupId"] = ExpressionConverter.ConvertO(__workflow_optionsgroupId);
                    optionspropCount++;
                }

                if (__workflow_optionsmessageToken != null)
                {
                    options["MessageToken"] = ExpressionConverter.ConvertO(__workflow_optionsmessageToken);
                    optionspropCount++;
                }

                if (__workflow_optionsoffset != null)
                {
                    options["Offset"] = ExpressionConverter.ConvertO(__workflow_optionsoffset);
                    optionspropCount++;
                }

                if (__workflow_optionslogicalSequenceNumber != null)
                {
                    options["LogicalSequenceNumber"] = ExpressionConverter.ConvertO(__workflow_optionslogicalSequenceNumber);
                    optionspropCount++;
                }

                if (__workflow_optionsincludeInfo != null)
                {
                    if (__workflow_optionsincludeInfo != null)
                    {
                        options["IncludeInfo"] = ExpressionConverter.ConvertO(__workflow_optionsincludeInfo);
                        optionspropCount++;
                    }

                    optionspropCount++;
                }
                else
                {
                    options["IncludeInfo"] = "false";
                    optionspropCount++;
                }

                if (__workflow_optionstimeout != null)
                {
                    options["Timeout"] = ExpressionConverter.ConvertO(__workflow_optionstimeout);
                    optionspropCount++;
                }

                if (__workflow_optionsbatchSize != null)
                {
                    options["BatchSize"] = ExpressionConverter.ConvertO(__workflow_optionsbatchSize);
                    optionspropCount++;
                }

                if (optionspropCount > 0)
                {
                    callPayload.Body = options;
                }

                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        public IBodyWorkflowAction<SendResponse> Send(Expression<Func<string>> messagemessage, Expression<Func<string>> messagequeue = null, Expression<Func<messagemessageTypeInput>> messagemessageType = null, Expression<Func<string>> messagecorrelationId = null, Expression<Func<string>> messagemessageId = null, Expression<Func<string>> messagereplyToQueue = null, Expression<Func<string>> messagereplyToQueueManager = null, Expression<Func<double>> messagecodeCharSetId = null, Expression<Func<double>> messageoffset = null, Expression<Func<string>> messageformat = null)
        {
            var __workflow_messagemessage = WorkflowExpression.Compile(messagemessage, nameof(messagemessage), required: true);
            var __workflow_messagequeue = WorkflowExpression.Compile(messagequeue, nameof(messagequeue), required: false);
            var __workflow_messagemessageType = WorkflowExpression.Compile(messagemessageType, nameof(messagemessageType), required: false);
            var __workflow_messagecorrelationId = WorkflowExpression.Compile(messagecorrelationId, nameof(messagecorrelationId), required: false);
            var __workflow_messagemessageId = WorkflowExpression.Compile(messagemessageId, nameof(messagemessageId), required: false);
            var __workflow_messagereplyToQueue = WorkflowExpression.Compile(messagereplyToQueue, nameof(messagereplyToQueue), required: false);
            var __workflow_messagereplyToQueueManager = WorkflowExpression.Compile(messagereplyToQueueManager, nameof(messagereplyToQueueManager), required: false);
            var __workflow_messagecodeCharSetId = WorkflowExpression.Compile(messagecodeCharSetId, nameof(messagecodeCharSetId), required: false);
            var __workflow_messageoffset = WorkflowExpression.Compile(messageoffset, nameof(messageoffset), required: false);
            var __workflow_messageformat = WorkflowExpression.Compile(messageformat, nameof(messageformat), required: false);
            return new DeferredBodyAction<SendResponse>(() =>
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                if (__workflow_messagequeue != null)
                {
                    message["Queue"] = ExpressionConverter.ConvertO(__workflow_messagequeue);
                    messagepropCount++;
                }

                messagepropCount++;
                message["Message"] = ExpressionConverter.ConvertO(__workflow_messagemessage);
                if (__workflow_messagemessageType != null)
                {
                    if (__workflow_messagemessageType != null)
                    {
                        message["MessageType"] = ExpressionConverter.ConvertO(__workflow_messagemessageType);
                        messagepropCount++;
                    }

                    messagepropCount++;
                }
                else
                {
                    message["MessageType"] = "Datagram";
                    messagepropCount++;
                }

                if (__workflow_messagecorrelationId != null)
                {
                    message["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_messagecorrelationId);
                    messagepropCount++;
                }

                if (__workflow_messagemessageId != null)
                {
                    message["MessageId"] = ExpressionConverter.ConvertO(__workflow_messagemessageId);
                    messagepropCount++;
                }

                if (__workflow_messagereplyToQueue != null)
                {
                    message["ReplyToQueue"] = ExpressionConverter.ConvertO(__workflow_messagereplyToQueue);
                    messagepropCount++;
                }

                if (__workflow_messagereplyToQueueManager != null)
                {
                    message["ReplyToQueueManager"] = ExpressionConverter.ConvertO(__workflow_messagereplyToQueueManager);
                    messagepropCount++;
                }

                if (__workflow_messagecodeCharSetId != null)
                {
                    message["CodeCharSetId"] = ExpressionConverter.ConvertO(__workflow_messagecodeCharSetId);
                    messagepropCount++;
                }

                if (__workflow_messageoffset != null)
                {
                    message["Offset"] = ExpressionConverter.ConvertO(__workflow_messageoffset);
                    messagepropCount++;
                }

                if (__workflow_messageformat != null)
                {
                    message["Format"] = ExpressionConverter.ConvertO(__workflow_messageformat);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
