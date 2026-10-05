//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elasticforms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElasticformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        [WorkflowExpressionFactory(nameof(__BuildAssignForm))]
        public IBodyWorkflowAction<AssignFormResponse> AssignForm([WorkflowExpression] Func<string> formAssignBodyuser, [WorkflowExpression] Func<string> formAssignBodyform, [WorkflowExpression] Func<object> formAssignBodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssignFormResponse> __BuildAssignForm(WorkflowValue<string> formAssignBodyuser, WorkflowValue<string> formAssignBodyform, WorkflowValue<object> formAssignBodyfields = null)
        {
            WorkflowValue.Validate(formAssignBodyuser, nameof(formAssignBodyuser), required: true);
            WorkflowValue.Validate(formAssignBodyform, nameof(formAssignBodyform), required: true);
            WorkflowValue.Validate(formAssignBodyfields, nameof(formAssignBodyfields), required: false);
            return new DeferredBodyAction<AssignFormResponse>(() =>
            {
                var apiCallPath = "/api/external/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formAssignBody = new JObject();
                var formAssignBodypropCount = 0;
                formAssignBodypropCount++;
                formAssignBody["UserName"] = ExpressionConverter.ConvertO(formAssignBodyuser);
                formAssignBodypropCount++;
                formAssignBody["FormUid"] = ExpressionConverter.ConvertO(formAssignBodyform);
                if (formAssignBodyfields != null)
                {
                    formAssignBody["FormData"] = ExpressionConverter.ConvertO(formAssignBodyfields);
                    formAssignBodypropCount++;
                }

                if (formAssignBodypropCount > 0)
                {
                    callPayload.Body = formAssignBody;
                }

                return new ApiConnectionAction<AssignFormResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        [WorkflowExpressionFactory(nameof(__BuildAddData))]
        public IBodyWorkflowAction<string> AddData([WorkflowExpression] Func<string> formDataBodyform, [WorkflowExpression] Func<object> formDataBodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddData(WorkflowValue<string> formDataBodyform, WorkflowValue<object> formDataBodyfields = null)
        {
            WorkflowValue.Validate(formDataBodyform, nameof(formDataBodyform), required: true);
            WorkflowValue.Validate(formDataBodyfields, nameof(formDataBodyfields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/external/FormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formDataBody = new JObject();
                var formDataBodypropCount = 0;
                formDataBodypropCount++;
                formDataBody["FormUid"] = ExpressionConverter.ConvertO(formDataBodyform);
                if (formDataBodyfields != null)
                {
                    formDataBody["FormDataObject"] = ExpressionConverter.ConvertO(formDataBodyfields);
                    formDataBodypropCount++;
                }

                if (formDataBodypropCount > 0)
                {
                    callPayload.Body = formDataBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ElasticformsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildTrigNewResponse))]
        public IWorkflowTrigger TrigNewResponse([WorkflowExpression] Func<string> requestBodyOfWebhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTrigNewResponse(WorkflowValue<string> requestBodyOfWebhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(requestBodyOfWebhookform, nameof(requestBodyOfWebhookform), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/external/WebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["TriggerUrl"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["FormUid"] = ExpressionConverter.ConvertO(requestBodyOfWebhookform);
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class AssignFormResponse
    {
        public string AssignedFormUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Elasticforms;

    public partial class WorkflowManagedActions
    {
        public ElasticformsActions Elasticforms(string connectionId) => new ElasticformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElasticformsTriggers Elasticforms(string connectionId) => new ElasticformsTriggers(connectionId);
    }
}
