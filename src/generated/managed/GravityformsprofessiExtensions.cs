//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsprofessi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GravityformsprofessiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFieldChoices(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/forms/{0}/fields/{1}/choices", __workflow_formId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateFieldChoices(Expression<Func<string>> formId, Expression<Func<string>> id, Expression<Func<object>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/forms/{0}/fields/{1}/choices", __workflow_formId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<GetEntriesResponse, ApiConnectionActionConfiguration> GetEntries(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetEntriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/entries/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetEntriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<string>> formId, Expression<Func<object>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/entries";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEntry(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEntry(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<string>> formId, Expression<Func<string>> id, Expression<Func<object>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFieldEntry(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/field_entries/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ValidateEntry(Expression<Func<string>> formId, Expression<Func<object>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/validations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetEntryNotes(Expression<Func<string>> entryId)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}/notes", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateEntryNote(Expression<Func<string>> entryId, Expression<Func<object>> body)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}/notes", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEntryAttachment(Expression<Func<string>> entryId, Expression<Func<string>> attachmentUrl)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            var __workflow_attachmentUrl = WorkflowExpression.Compile(attachmentUrl, nameof(attachmentUrl), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}/attachments", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attachment_url"] = ExpressionConverter.Convert(__workflow_attachmentUrl);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAllEntryAttachments(Expression<Func<string>> entryId)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}/attachments/all", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DownloadEntryAttachment(Expression<Func<string>> entryId, Expression<Func<string>> attachmentUrl)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            var __workflow_attachmentUrl = WorkflowExpression.Compile(attachmentUrl, nameof(attachmentUrl), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/entries/{0}/attachments/download", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attachment_url"] = ExpressionConverter.Convert(__workflow_attachmentUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class GravityformsprofessiTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnEntryUpdate(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/entry_update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnFormSubmission(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/form_submission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnEntryUpdateStatus(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/entry_update_status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnEntryDelete(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/entry_delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnPaymentAction(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/payment_action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnNoteAdded(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/note_added";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerOnEntryEntryApprovalUpdate(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/resources/feeds/t/entry_approval_update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class GetEntriesResponse
    {
        [JsonProperty("entries")]
        public JToken[] Entries { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("form_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FormId { get; set; }

        [JsonProperty("meta", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputMetaType Meta { get; set; } = new BodyInputMetaType();
    }

    public class BodyInputMetaType
    {
        [JsonProperty("powerAutomateUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PowerAutomateUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsprofessi;

    public partial class WorkflowManagedActions
    {
        public GravityformsprofessiActions Gravityformsprofessi(string connectionId) => new GravityformsprofessiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GravityformsprofessiTriggers Gravityformsprofessi(string connectionId) => new GravityformsprofessiTriggers(connectionId);
    }
}