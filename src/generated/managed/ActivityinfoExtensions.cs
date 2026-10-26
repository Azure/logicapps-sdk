//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Activityinfo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActivityinfoActions([ConnectionName] string connectionId)
    {
    }

    public class ActivityinfoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> AddRecordTrigger(Expression<Func<string>> formId, Expression<Func<AddRecordTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/add", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> EditRecordTrigger(Expression<Func<string>> formId, Expression<Func<EditRecordTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/edit", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> DeleteRecordTrigger(Expression<Func<string>> formId, Expression<Func<DeleteRecordTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/powerautomate/v1/forms/{0}/automation/delete", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddRecordTriggerInput
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; } = "Power Automate Webhook";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddRecordTriggerInputActionType Action { get; set; }
    }

    public class AddRecordTriggerInputActionType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "WEBHOOK";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class EditRecordTriggerInput
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; } = "Power Automate Webhook";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public EditRecordTriggerInputActionType Action { get; set; }
    }

    public class EditRecordTriggerInputActionType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "WEBHOOK";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class DeleteRecordTriggerInput
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; } = "Power Automate Webhook";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteRecordTriggerInputActionType Action { get; set; }
    }

    public class DeleteRecordTriggerInputActionType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "WEBHOOK";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Activityinfo;

    public partial class WorkflowManagedActions
    {
        public ActivityinfoActions Activityinfo(string connectionId) => new ActivityinfoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ActivityinfoTriggers Activityinfo(string connectionId) => new ActivityinfoTriggers(connectionId);
    }
}