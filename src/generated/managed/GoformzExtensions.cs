//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goformz
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoformzActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportForm(Expression<Func<string>> formId, Expression<Func<ExportFormInput>> body = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/formz/{0}/exports", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateForm(Expression<Func<bool>> runCalculations = null, Expression<Func<CreateFormInput>> body = null)
        {
            var __workflow_runCalculations = WorkflowExpression.Compile(runCalculations, nameof(runCalculations), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/formz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runCalculations"] = Convert.ToString(false);
                if (__workflow_runCalculations != null)
                    callPayload.Queries["runCalculations"] = ExpressionConverter.Convert(__workflow_runCalculations);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<FormDto, ApiConnectionActionConfiguration> GetForm(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FormDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/formz/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FormDto>(callPayload);
            });
        }
    }

    public class GoformzTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FormCompleted(Expression<Func<FormCompletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ExportFormInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }
    }

    public class CreateFormInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overrideDefaultFormName")]
        public bool? OverrideDefaultFormName { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("assignment")]
        public AssignmentDto Assignment { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class AssignmentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormDto
    {
        [JsonProperty("formId")]
        public string FormId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overrideDefaultFormName")]
        public bool OverrideDefaultFormName { get; set; }

        [JsonProperty("status")]
        public FormStatusDto Status { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("assignment")]
        public AssignmentDto Assignment { get; set; }

        [JsonProperty("location")]
        public LocationDto Location { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateUrl")]
        public string TemplateUrl { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class FormStatusDto
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("changeDate")]
        public string ChangeDate { get; set; }
    }

    public class LocationDto
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }
    }

    public class FormCompletedInput
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("entityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityId { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Goformz;

    public partial class WorkflowManagedActions
    {
        public GoformzActions Goformz(string connectionId) => new GoformzActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoformzTriggers Goformz(string connectionId) => new GoformzTriggers(connectionId);
    }
}