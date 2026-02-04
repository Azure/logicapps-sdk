//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendansms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendansmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendansms")]
        public IWorkflowAction SendSms(Expression<Func<string>> xTopMessageKey, Expression<Func<string>> contentType = null, Expression<Func<string>> bodydatafrom = null, Expression<Func<string[]>> bodydatato = null, Expression<Func<string>> bodydatatext = null)
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