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
        public IBodyWorkflowAction<string> DownloadAttachment(Expression<Func<string>> fileUrl)
        {
            var __workflow_fileUrl = WorkflowExpression.Compile(fileUrl, nameof(fileUrl), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileUrl"] = ExpressionConverter.Convert(__workflow_fileUrl);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> fileUrl = null)
        {
            var __workflow_fileUrl = WorkflowExpression.Compile(fileUrl, nameof(fileUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileUrl);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteSubmission(Expression<Func<string>> formId, Expression<Func<string>> submissionId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_submissionId = WorkflowExpression.Compile(submissionId, nameof(submissionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forms/{0}/submissions/{1}", __workflow_formId.WithUrlEncoding(1), __workflow_submissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class PlumsailformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormIsSubmitted(Expression<Func<string>> subscriberform, FlowRecurrence recurrence = null)
        {
            var __workflow_subscriberform = WorkflowExpression.Compile(subscriberform, nameof(subscriberform), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/submissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscriber = new JObject();
                var subscriberpropCount = 0;
                subscriber["callbackUrl"] = "#{listCallbackUrl()}";
                subscriberpropCount++;
                subscriberpropCount++;
                subscriber["formId"] = ExpressionConverter.ConvertO(__workflow_subscriberform);
                if (subscriberpropCount > 0)
                {
                    callPayload.Body = subscriber;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
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
