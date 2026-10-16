//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendansms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SendansmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendansms")]
        public IWorkflowAction SendSms(Expression<Func<string>> xTopMessageKey, Expression<Func<string>> contentType = null, Expression<Func<string>> bodydatafrom = null, Expression<Func<string[]>> bodydatato = null, Expression<Func<string>> bodydatatext = null)
        {
            var __workflow_xTopMessageKey = WorkflowExpression.Compile(xTopMessageKey, nameof(xTopMessageKey), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodydatafrom = WorkflowExpression.Compile(bodydatafrom, nameof(bodydatafrom), required: false);
            var __workflow_bodydatato = WorkflowExpression.Compile(bodydatato, nameof(bodydatato), required: false);
            var __workflow_bodydatatext = WorkflowExpression.Compile(bodydatatext, nameof(bodydatatext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-TopMessage-Key"] = ExpressionConverter.Convert(__workflow_xTopMessageKey);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatafrom != null)
                {
                    dataObject["from"] = ExpressionConverter.ConvertO(__workflow_bodydatafrom);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatato != null)
                {
                    dataObject["to"] = ExpressionConverter.ConvertO(__workflow_bodydatato);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatatext != null)
                {
                    dataObject["text"] = ExpressionConverter.ConvertO(__workflow_bodydatatext);
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
