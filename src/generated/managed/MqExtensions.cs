//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildRead))]
        public IBodyWorkflowAction<Item> Read([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildRead(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildReadAll))]
        public IBodyWorkflowAction<ItemsList> ReadAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildReadAll(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null, WorkflowExpression<double> optionsbatchSize = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            WorkflowExpression.Validate(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildReceive))]
        public IBodyWorkflowAction<Item> Receive([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildReceive(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildReceiveAll))]
        public IBodyWorkflowAction<ItemsList> ReceiveAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildReceiveAll(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null, WorkflowExpression<double> optionsbatchSize = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            WorkflowExpression.Validate(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildDelete))]
        public IBodyWorkflowAction<Item> Delete([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildDelete(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            return new DeferredBodyAction<Item>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAll))]
        public IBodyWorkflowAction<ItemsList> DeleteAll([WorkflowExpression] Func<string> optionsqueue = null, [WorkflowExpression] Func<string> optionsmessageId = null, [WorkflowExpression] Func<string> optionscorrelationId = null, [WorkflowExpression] Func<string> optionsgroupId = null, [WorkflowExpression] Func<string> optionsmessageToken = null, [WorkflowExpression] Func<double> optionsoffset = null, [WorkflowExpression] Func<double> optionslogicalSequenceNumber = null, [WorkflowExpression] Func<optionsincludeInfoInput> optionsincludeInfo = null, [WorkflowExpression] Func<string> optionstimeout = null, [WorkflowExpression] Func<double> optionsbatchSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildDeleteAll(WorkflowExpression<string> optionsqueue = null, WorkflowExpression<string> optionsmessageId = null, WorkflowExpression<string> optionscorrelationId = null, WorkflowExpression<string> optionsgroupId = null, WorkflowExpression<string> optionsmessageToken = null, WorkflowExpression<double> optionsoffset = null, WorkflowExpression<double> optionslogicalSequenceNumber = null, WorkflowExpression<optionsincludeInfoInput> optionsincludeInfo = null, WorkflowExpression<string> optionstimeout = null, WorkflowExpression<double> optionsbatchSize = null)
        {
            WorkflowExpression.Validate(optionsqueue, nameof(optionsqueue), required: false);
            WorkflowExpression.Validate(optionsmessageId, nameof(optionsmessageId), required: false);
            WorkflowExpression.Validate(optionscorrelationId, nameof(optionscorrelationId), required: false);
            WorkflowExpression.Validate(optionsgroupId, nameof(optionsgroupId), required: false);
            WorkflowExpression.Validate(optionsmessageToken, nameof(optionsmessageToken), required: false);
            WorkflowExpression.Validate(optionsoffset, nameof(optionsoffset), required: false);
            WorkflowExpression.Validate(optionslogicalSequenceNumber, nameof(optionslogicalSequenceNumber), required: false);
            WorkflowExpression.Validate(optionsincludeInfo, nameof(optionsincludeInfo), required: false);
            WorkflowExpression.Validate(optionstimeout, nameof(optionstimeout), required: false);
            WorkflowExpression.Validate(optionsbatchSize, nameof(optionsbatchSize), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [WorkflowExpressionFactory(nameof(__BuildSend))]
        public IBodyWorkflowAction<SendResponse> Send([WorkflowExpression] Func<string> messagemessage, [WorkflowExpression] Func<string> messagequeue = null, [WorkflowExpression] Func<messagemessageTypeInput> messagemessageType = null, [WorkflowExpression] Func<string> messagecorrelationId = null, [WorkflowExpression] Func<string> messagemessageId = null, [WorkflowExpression] Func<string> messagereplyToQueue = null, [WorkflowExpression] Func<string> messagereplyToQueueManager = null, [WorkflowExpression] Func<double> messagecodeCharSetId = null, [WorkflowExpression] Func<double> messageoffset = null, [WorkflowExpression] Func<string> messageformat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendResponse> __BuildSend(WorkflowExpression<string> messagemessage, WorkflowExpression<string> messagequeue = null, WorkflowExpression<messagemessageTypeInput> messagemessageType = null, WorkflowExpression<string> messagecorrelationId = null, WorkflowExpression<string> messagemessageId = null, WorkflowExpression<string> messagereplyToQueue = null, WorkflowExpression<string> messagereplyToQueueManager = null, WorkflowExpression<double> messagecodeCharSetId = null, WorkflowExpression<double> messageoffset = null, WorkflowExpression<string> messageformat = null)
        {
            WorkflowExpression.Validate(messagemessage, nameof(messagemessage), required: true);
            WorkflowExpression.Validate(messagequeue, nameof(messagequeue), required: false);
            WorkflowExpression.Validate(messagemessageType, nameof(messagemessageType), required: false);
            WorkflowExpression.Validate(messagecorrelationId, nameof(messagecorrelationId), required: false);
            WorkflowExpression.Validate(messagemessageId, nameof(messagemessageId), required: false);
            WorkflowExpression.Validate(messagereplyToQueue, nameof(messagereplyToQueue), required: false);
            WorkflowExpression.Validate(messagereplyToQueueManager, nameof(messagereplyToQueueManager), required: false);
            WorkflowExpression.Validate(messagecodeCharSetId, nameof(messagecodeCharSetId), required: false);
            WorkflowExpression.Validate(messageoffset, nameof(messageoffset), required: false);
            WorkflowExpression.Validate(messageformat, nameof(messageformat), required: false);
            return new DeferredBodyAction<SendResponse>(() =>
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