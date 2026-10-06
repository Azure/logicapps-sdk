//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Featheryforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FeatheryformsActions([ConnectionName] string connectionId)
    {
    }

    public class FeatheryformsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildFormCompletion))]
        public IBodyWorkflowTrigger<FormCompletionResponse> FormCompletion([WorkflowExpression] Func<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<FormCompletionResponse> __BuildFormCompletion(WorkflowExpression<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formKey, nameof(formKey), required: true);
            return new DeferredBodyTrigger<FormCompletionResponse>(() =>
            {
                var apiCallPath = "/trigger/power-automate/poll/form_completion/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_key"] = ExpressionConverter.Convert(formKey);
                return new ApiConnectionTrigger<FormCompletionResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildDataReceived))]
        public IBodyWorkflowTrigger<DataReceivedResponse> DataReceived([WorkflowExpression] Func<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<DataReceivedResponse> __BuildDataReceived(WorkflowExpression<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formKey, nameof(formKey), required: true);
            return new DeferredBodyTrigger<DataReceivedResponse>(() =>
            {
                var apiCallPath = "/trigger/power-automate/poll/data_received/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_key"] = ExpressionConverter.Convert(formKey);
                return new ApiConnectionTrigger<DataReceivedResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildNewFile))]
        public IBodyWorkflowTrigger<NewFileResponse> NewFile([WorkflowExpression] Func<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewFileResponse> __BuildNewFile(WorkflowExpression<string> formKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formKey, nameof(formKey), required: true);
            return new DeferredBodyTrigger<NewFileResponse>(() =>
            {
                var apiCallPath = "/trigger/power-automate/poll/file/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_key"] = ExpressionConverter.Convert(formKey);
                return new ApiConnectionTrigger<NewFileResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class FormCompletionResponse
    {
        [JsonProperty("results")]
        public FormCompletionResponseResultsTypeItem[] Results { get; set; }
    }

    public class FormCompletionResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Submission Completed At")]
        public string SubmissionCompletedAt { get; set; }

        [JsonProperty("Submission Updated At")]
        public string SubmissionUpdatedAt { get; set; }
    }

    public class DataReceivedResponse
    {
        [JsonProperty("requested_at")]
        public string RequestedAt { get; set; }

        [JsonProperty("results")]
        public JToken[] Results { get; set; }
    }

    public class NewFileResponse
    {
        [JsonProperty("requested_at")]
        public string RequestedAt { get; set; }

        [JsonProperty("results")]
        public JToken[] Results { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Featheryforms;

    public partial class WorkflowManagedActions
    {
        public FeatheryformsActions Featheryforms(string connectionId) => new FeatheryformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FeatheryformsTriggers Featheryforms(string connectionId) => new FeatheryformsTriggers(connectionId);
    }
}