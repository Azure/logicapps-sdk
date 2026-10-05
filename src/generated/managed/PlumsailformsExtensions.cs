//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailforms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadAttachment))]
        public IBodyWorkflowAction<string> DownloadAttachment([WorkflowExpression] Func<string> fileUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadAttachment(WorkflowValue<string> fileUrl)
        {
            WorkflowValue.Validate(fileUrl, nameof(fileUrl), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAttachment))]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> fileUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAttachment(WorkflowValue<string> fileUrl = null)
        {
            WorkflowValue.Validate(fileUrl, nameof(fileUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(fileUrl);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSubmission))]
        public IWorkflowAction DeleteSubmission([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> submissionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSubmission(WorkflowValue<string> formId, WorkflowValue<string> submissionId)
        {
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            WorkflowValue.Validate(submissionId, nameof(submissionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/forms/{0}/submissions/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(submissionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PlumsailformsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildFormIsSubmitted))]
        public IWorkflowTrigger FormIsSubmitted([WorkflowExpression] Func<string> subscriberform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFormIsSubmitted(WorkflowValue<string> subscriberform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(subscriberform, nameof(subscriberform), required: true);
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
                subscriber["formId"] = ExpressionConverter.ConvertO(subscriberform);
                if (subscriberpropCount > 0)
                {
                    callPayload.Body = subscriber;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
