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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSms(WorkflowValue<string> xTopMessageKey, WorkflowValue<string> contentType = null, WorkflowValue<string> bodydatafrom = null, WorkflowValue<string[]> bodydatato = null, WorkflowValue<string> bodydatatext = null)
        {
            WorkflowValue.Validate(xTopMessageKey, nameof(xTopMessageKey), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(bodydatafrom, nameof(bodydatafrom), required: false);
            WorkflowValue.Validate(bodydatato, nameof(bodydatato), required: false);
            WorkflowValue.Validate(bodydatatext, nameof(bodydatatext), required: false);
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
