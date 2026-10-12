//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Okdokumentip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OkdokumentipActions([ConnectionName] string connectionId)
    {
    }

    public class OkdokumentipTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWaitForSignature))]
        public IWorkflowTrigger WaitForSignature([WorkflowExpression] Func<string> signatureRequestId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWaitForSignature(WorkflowExpression<string> signatureRequestId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(signatureRequestId, nameof(signatureRequestId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signatureRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(signatureRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["sendInfoURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Okdokumentip;

    public partial class WorkflowManagedActions
    {
        public OkdokumentipActions Okdokumentip(string connectionId) => new OkdokumentipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OkdokumentipTriggers Okdokumentip(string connectionId) => new OkdokumentipTriggers(connectionId);
    }
}