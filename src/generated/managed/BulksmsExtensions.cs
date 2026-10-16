//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BulksmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bulksms")]
        public IWorkflowAction SendSmsMessage(Expression<Func<bool>> autoUnicode, Expression<Func<string>> bodyto, Expression<Func<string>> bodybody, Expression<Func<int>> bodylongMessageMaxParts, Expression<Func<string>> bodyfrom = null)
        {
            var __workflow_autoUnicode = WorkflowExpression.Compile(autoUnicode, nameof(autoUnicode), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: true);
            var __workflow_bodylongMessageMaxParts = WorkflowExpression.Compile(bodylongMessageMaxParts, nameof(bodylongMessageMaxParts), required: true);
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["auto-unicode"] = ExpressionConverter.Convert(__workflow_autoUnicode);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                body["userSuppliedId"] = "BLKTM.GWPF.01.00.00";
                bodypropCount++;
                bodypropCount++;
                body["longMessageMaxParts"] = ExpressionConverter.ConvertO(__workflow_bodylongMessageMaxParts);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
