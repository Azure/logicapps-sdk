//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendansms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendansmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendansms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSms))]
        public IWorkflowAction SendSms([WorkflowExpression] Func<string> xTopMessageKey, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodydatafrom = null, [WorkflowExpression] Func<string[]> bodydatato = null, [WorkflowExpression] Func<string> bodydatatext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendansms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSms(WorkflowExpression<string> xTopMessageKey, WorkflowExpression<string> contentType = null, WorkflowExpression<string> bodydatafrom = null, WorkflowExpression<string[]> bodydatato = null, WorkflowExpression<string> bodydatatext = null)
        {
            WorkflowExpression.Validate(xTopMessageKey, nameof(xTopMessageKey), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(bodydatafrom, nameof(bodydatafrom), required: false);
            WorkflowExpression.Validate(bodydatato, nameof(bodydatato), required: false);
            WorkflowExpression.Validate(bodydatatext, nameof(bodydatatext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-TopMessage-Key"] = ExpressionConverter.Convert(xTopMessageKey);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatafrom != null)
                {
                    dataObject["from"] = ExpressionConverter.ConvertO(bodydatafrom);
                    dataObjectpropCount++;
                }

                if (bodydatato != null)
                {
                    dataObject["to"] = ExpressionConverter.ConvertO(bodydatato);
                    dataObjectpropCount++;
                }

                if (bodydatatext != null)
                {
                    dataObject["text"] = ExpressionConverter.ConvertO(bodydatatext);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SendansmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sendansms;

    public partial class WorkflowManagedActions
    {
        public SendansmsActions Sendansms(string connectionId) => new SendansmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendansmsTriggers Sendansms(string connectionId) => new SendansmsTriggers(connectionId);
    }
}