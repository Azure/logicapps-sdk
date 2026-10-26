//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadAttachment(Expression<Func<string>> fileUrl)
        {
            var __workflow_fileUrl = WorkflowExpression.Compile(fileUrl, nameof(fileUrl), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileUrl"] = ExpressionConverter.Convert(__workflow_fileUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAttachment(Expression<Func<string>> fileUrl)
        {
            var __workflow_fileUrl = WorkflowExpression.Compile(fileUrl, nameof(fileUrl), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileUrl);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSubmission(Expression<Func<string>> formId, Expression<Func<string>> submissionId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_submissionId = WorkflowExpression.Compile(submissionId, nameof(submissionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forms/{0}/submissions/{1}", __workflow_formId.WithUrlEncoding(1), __workflow_submissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PlumsailformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FormIsSubmitted(Expression<Func<FormIsSubmittedInput>> subscriber, FlowRecurrence recurrence = null)
        {
            var __workflow_subscriber = WorkflowExpression.Compile(subscriber, nameof(subscriber), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/submissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscriber);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class FormIsSubmittedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("formId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Form { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailforms;

    public partial class WorkflowManagedActions
    {
        public PlumsailformsActions Plumsailforms(string connectionId) => new PlumsailformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlumsailformsTriggers Plumsailforms(string connectionId) => new PlumsailformsTriggers(connectionId);
    }
}