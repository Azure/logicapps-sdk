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
            var __workflow_autoUnicode = autoUnicode == null ? null : WorkflowExpression.Compile(autoUnicode);
            WorkflowExpression.Validate(__workflow_autoUnicode, nameof(autoUnicode), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: true);
            var __workflow_bodylongMessageMaxParts = bodylongMessageMaxParts == null ? null : WorkflowExpression.Compile(bodylongMessageMaxParts);
            WorkflowExpression.Validate(__workflow_bodylongMessageMaxParts, nameof(bodylongMessageMaxParts), required: true);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
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
