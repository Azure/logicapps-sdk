//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Formstackforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FormstackformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "formstackforms")]
        public IBodyWorkflowAction<GetAvailableFormsResponse, ApiConnectionActionConfiguration> GetAvailableForms()
        {
            return new DeferredBodyAction<GetAvailableFormsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/form/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAvailableFormsResponse>(callPayload);
            });
        }
    }

    public class FormstackformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FormstackFormSubmittedResponse, ApiConnectionTriggerConfiguration> FormstackFormSubmitted(Expression<Func<int>> formId, Expression<Func<FormstackFormSubmittedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<FormstackFormSubmittedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/form/{0}/webhook/", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<FormstackFormSubmittedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetAvailableFormsResponse
    {
        [JsonProperty("forms")]
        public GetAvailableFormsResponseFormsTypeItem[] Forms { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetAvailableFormsResponseFormsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FormstackFormSubmittedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FormstackFormSubmittedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("content_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "json";

        [JsonProperty("file_transfer_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FileTransferType { get; set; } = "base64encode";

        [JsonProperty("standardize_field_values", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool StandardizeFieldValues { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Formstackforms;

    public partial class WorkflowManagedActions
    {
        public FormstackformsActions Formstackforms(string connectionId) => new FormstackformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FormstackformsTriggers Formstackforms(string connectionId) => new FormstackformsTriggers(connectionId);
    }
}