//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elasticforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElasticformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<AssignFormResponse, ApiConnectionActionConfiguration> AssignForm(Expression<Func<string>> formAssignBodyuser, Expression<Func<string>> formAssignBodyform, Expression<Func<object>> formAssignBodyfields = null)
        {
            var __workflow_formAssignBodyuser = WorkflowExpression.Compile(formAssignBodyuser, nameof(formAssignBodyuser), required: true);
            var __workflow_formAssignBodyform = WorkflowExpression.Compile(formAssignBodyform, nameof(formAssignBodyform), required: true);
            var __workflow_formAssignBodyfields = WorkflowExpression.Compile(formAssignBodyfields, nameof(formAssignBodyfields), required: false);
            return new DeferredBodyAction<AssignFormResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/external/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formAssignBody = new JObject();
                var formAssignBodypropCount = 0;
                formAssignBodypropCount++;
                formAssignBody["UserName"] = ExpressionConverter.ConvertO(__workflow_formAssignBodyuser);
                formAssignBodypropCount++;
                formAssignBody["FormUid"] = ExpressionConverter.ConvertO(__workflow_formAssignBodyform);
                if (__workflow_formAssignBodyfields != null)
                {
                    formAssignBody["FormData"] = ExpressionConverter.ConvertO(__workflow_formAssignBodyfields);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddData(Expression<Func<string>> formDataBodyform, Expression<Func<object>> formDataBodyfields = null)
        {
            var __workflow_formDataBodyform = WorkflowExpression.Compile(formDataBodyform, nameof(formDataBodyform), required: true);
            var __workflow_formDataBodyfields = WorkflowExpression.Compile(formDataBodyfields, nameof(formDataBodyfields), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/external/FormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formDataBody = new JObject();
                var formDataBodypropCount = 0;
                formDataBodypropCount++;
                formDataBody["FormUid"] = ExpressionConverter.ConvertO(__workflow_formDataBodyform);
                if (__workflow_formDataBodyfields != null)
                {
                    formDataBody["FormDataObject"] = ExpressionConverter.ConvertO(__workflow_formDataBodyfields);
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TrigNewResponse(Expression<Func<string>> requestBodyOfWebhookform, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookform = WorkflowExpression.Compile(requestBodyOfWebhookform, nameof(requestBodyOfWebhookform), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/external/WebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["TriggerUrl"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["FormUid"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookform);
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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