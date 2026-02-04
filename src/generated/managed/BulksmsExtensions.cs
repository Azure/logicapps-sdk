//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BulksmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bulksms")]
        public IWorkflowAction SendSmsMessage(Expression<Func<bool>> autoUnicode, Expression<Func<string>> bodyto, Expression<Func<string>> bodybody, Expression<Func<int>> bodylongMessageMaxParts, Expression<Func<string>> bodyfrom = null)
        {
            var apiCallPath = "/v1/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["auto-unicode"] = ExpressionConverter.Convert(autoUnicode);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodybody);
            body["userSuppliedId"] = "BLKTM.GWPF.01.00.00";
            bodypropCount++;
            bodypropCount++;
            body["longMessageMaxParts"] = ExpressionConverter.ConvertO(bodylongMessageMaxParts);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BulksmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms;

    public partial class WorkflowManagedActions
    {
        public BulksmsActions Bulksms(string connectionId) => new BulksmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BulksmsTriggers Bulksms(string connectionId) => new BulksmsTriggers(connectionId);
    }
}