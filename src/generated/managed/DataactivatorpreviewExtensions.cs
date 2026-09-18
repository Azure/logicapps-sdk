//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataactivatorpreview
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataactivatorpreviewActions([ConnectionName] string connectionId)
    {
    }

    public class DataactivatorpreviewTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreatePowerAutomateWorkflow([WorkflowExpression] Func<string> connectionString, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(connectionString, nameof(connectionString), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/powerAutomateFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Connection-String"] = SourceExpressionConverter.ConvertO(connectionString);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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