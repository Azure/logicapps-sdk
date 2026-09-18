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
        public IBodyWorkflowAction<string> DownloadAttachment([WorkflowExpression] Func<string> fileUrl)
        {
            var apiCallPath = "/api/attachments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> fileUrl = null)
        {
            var apiCallPath = "/api/attachments";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(fileUrl);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteSubmission([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> formId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> submissionId)
        {
            var apiCallPath = String.Format("/api/forms/{0}/submissions/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(submissionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class PlumsailformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormIsSubmitted([WorkflowExpression] Func<string> subscriberform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/submissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subscriber = new JObject();
            var subscriberpropCount = 0;
            subscriber["callbackUrl"] = "@listCallbackUrl()";
            subscriberpropCount++;
            subscriberpropCount++;
            subscriber["formId"] = ExpressionConverter.ConvertO(subscriberform);
            if (subscriberpropCount > 0)
            {
                callPayload.Body = subscriber;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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