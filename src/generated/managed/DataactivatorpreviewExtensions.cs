//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataactivatorpreview
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataactivatorpreviewActions([ConnectionName] string connectionId)
    {
    }

    public class DataactivatorpreviewTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreatePowerAutomateWorkflow))]
        public IWorkflowTrigger CreatePowerAutomateWorkflow([WorkflowExpression] Func<string> connectionString, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreatePowerAutomateWorkflow(WorkflowValue<string> connectionString, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(connectionString, nameof(connectionString), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/powerAutomateFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Connection-String"] = ExpressionConverter.Convert(connectionString);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dataactivatorpreview;

    public partial class WorkflowManagedActions
    {
        public DataactivatorpreviewActions Dataactivatorpreview(string connectionId) => new DataactivatorpreviewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DataactivatorpreviewTriggers Dataactivatorpreview(string connectionId) => new DataactivatorpreviewTriggers(connectionId);
    }
}
