//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BulksmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bulksms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSmsMessage))]
        public IWorkflowAction SendSmsMessage([WorkflowExpression] Func<bool> autoUnicode, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<int> bodylongMessageMaxParts, [WorkflowExpression] Func<string> bodyfrom = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSmsMessage(WorkflowExpression<bool> autoUnicode, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<int> bodylongMessageMaxParts, WorkflowExpression<string> bodyfrom = null)
        {
            WorkflowExpression.Validate(autoUnicode, nameof(autoUnicode), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodylongMessageMaxParts, nameof(bodylongMessageMaxParts), required: true);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            return new DeferredWorkflowAction(() =>
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