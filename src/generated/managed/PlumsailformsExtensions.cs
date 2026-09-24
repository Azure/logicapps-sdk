//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IBodyWorkflowAction<string> DownloadAttachment([WorkflowExpression] Func<string> fileUrl)
        {
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> fileUrl = null)
        {
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/attachments";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fileUrl);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailforms")]
        public IWorkflowAction DeleteSubmission([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> submissionId)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(submissionId, nameof(submissionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forms/{0}/submissions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(submissionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class PlumsailformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormIsSubmitted([WorkflowExpression] Func<string> subscriberform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(subscriberform, nameof(subscriberform), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/submissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscriber = new JObject();
                var subscriberpropCount = 0;
                subscriber["callbackUrl"] = "#{listCallbackUrl()}";
                subscriberpropCount++;
                subscriberpropCount++;
                subscriber["formId"] = SourceExpressionConverter.ConvertToken(subscriberform);
                if (subscriberpropCount > 0)
                {
                    callPayload.Body = subscriber;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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