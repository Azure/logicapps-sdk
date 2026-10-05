//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tegolysign
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TegolysignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tegolysign")]
        [WorkflowExpressionFactory(nameof(__BuildImportPDF))]
        public IWorkflowAction ImportPDF([WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportPDF(WorkflowValue<object> file)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/webhook/create-draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TegolysignTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCompletelySigned))]
        public IWorkflowTrigger CompletelySigned([WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCompletelySigned(WorkflowValue<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/end-trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                body["delivery_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tegolysign;

    public partial class WorkflowManagedActions
    {
        public TegolysignActions Tegolysign(string connectionId) => new TegolysignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TegolysignTriggers Tegolysign(string connectionId) => new TegolysignTriggers(connectionId);
    }
}
