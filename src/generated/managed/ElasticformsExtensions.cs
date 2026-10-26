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
        public IBodyWorkflowAction<AssignFormResponse, ApiConnectionActionConfiguration> AssignForm(Expression<Func<AssignFormInput>> formAssignBody)
        {
            var __workflow_formAssignBody = WorkflowExpression.Compile(formAssignBody, nameof(formAssignBody), required: true);
            return new DeferredBodyAction<AssignFormResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/external/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_formAssignBody);
                return new ApiConnectionAction<AssignFormResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddData(Expression<Func<AddDataInput>> formDataBody)
        {
            var __workflow_formDataBody = WorkflowExpression.Compile(formDataBody, nameof(formDataBody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/external/FormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_formDataBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ElasticformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TrigNewResponse(Expression<Func<TrigNewResponseInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/external/WebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AssignFormResponse
    {
        public string AssignedFormUrl { get; set; }
    }

    public class AssignFormInput
    {
        [JsonProperty("UserName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("FormUid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Form { get; set; }

        [JsonProperty("FormData")]
        public JToken Fields { get; set; }
    }

    public class AddDataInput
    {
        [JsonProperty("FormUid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Form { get; set; }

        [JsonProperty("FormDataObject")]
        public JToken Fields { get; set; }
    }

    public class TrigNewResponseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggerUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("FormUid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Form { get; set; }
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