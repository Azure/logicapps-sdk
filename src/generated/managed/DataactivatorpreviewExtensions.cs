//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataactivatorpreview
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataactivatorpreviewActions([ConnectionName] string connectionId)
    {
    }

    public class DataactivatorpreviewTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreatePowerAutomateWorkflow(Expression<Func<string>> connectionString, Expression<Func<CreatePowerAutomateWorkflowInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_connectionString = WorkflowExpression.Compile(connectionString, nameof(connectionString), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/powerAutomateFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Connection-String"] = ExpressionConverter.Convert(__workflow_connectionString);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreatePowerAutomateWorkflowInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
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