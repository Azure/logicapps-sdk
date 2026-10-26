//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lcpicordis
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LcpicordisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lcpicordis")]
        public IBodyWorkflowAction<EloketExport, ApiConnectionActionConfiguration> EloketExport(Expression<Func<int>> formid, Expression<Func<int>> entryid = null, Expression<Func<string>> lastsynch = null, Expression<Func<bool>> includeFiles = null, Expression<Func<bool>> includePDF = null, Expression<Func<bool>> includeHTML = null, Expression<Func<int>> page = null)
        {
            var __workflow_formid = WorkflowExpression.Compile(formid, nameof(formid), required: true);
            var __workflow_entryid = WorkflowExpression.Compile(entryid, nameof(entryid), required: false);
            var __workflow_lastsynch = WorkflowExpression.Compile(lastsynch, nameof(lastsynch), required: false);
            var __workflow_includeFiles = WorkflowExpression.Compile(includeFiles, nameof(includeFiles), required: false);
            var __workflow_includePDF = WorkflowExpression.Compile(includePDF, nameof(includePDF), required: false);
            var __workflow_includeHTML = WorkflowExpression.Compile(includeHTML, nameof(includeHTML), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<EloketExport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Export/eloketjson";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["formid"] = ExpressionConverter.Convert(__workflow_formid);
                if (__workflow_entryid != null)
                    callPayload.Queries["entryid"] = ExpressionConverter.Convert(__workflow_entryid);
                if (__workflow_lastsynch != null)
                    callPayload.Queries["lastsynch"] = ExpressionConverter.Convert(__workflow_lastsynch);
                if (__workflow_includeFiles != null)
                    callPayload.Queries["includeFiles"] = ExpressionConverter.Convert(__workflow_includeFiles);
                if (__workflow_includePDF != null)
                    callPayload.Queries["includePDF"] = ExpressionConverter.Convert(__workflow_includePDF);
                if (__workflow_includeHTML != null)
                    callPayload.Queries["includeHTML"] = ExpressionConverter.Convert(__workflow_includeHTML);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<EloketExport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lcpicordis")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> TriggerUnsubscribe(Expression<Func<int>> formid, Expression<Func<TriggerUnsubscribeInput>> body = null)
        {
            var __workflow_formid = WorkflowExpression.Compile(formid, nameof(formid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/export/eloket/{0}/unsubscribe", __workflow_formid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }
    }

    public class LcpicordisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<bool, ApiConnectionTriggerConfiguration> NewEntry(Expression<Func<int>> formid, Expression<Func<NewEntryInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formid = WorkflowExpression.Compile(formid, nameof(formid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<bool, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/export/eloket/{0}/hooks", __workflow_formid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<bool>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class EloketExport
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("formID")]
        public int FormId { get; set; }

        [JsonProperty("formTitle")]
        public string FormTitle { get; set; }

        [JsonProperty("responseStatus")]
        public string ResponseStatus { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("fields")]
        public EloketField[] Fields { get; set; }
    }

    public class EloketField
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldDescription")]
        public string FieldDescription { get; set; }
    }

    public class TriggerUnsubscribeInput
    {
        [JsonProperty("webhookurl")]
        public string Webhookurl { get; set; }
    }

    public class NewEntryInput
    {
        [JsonProperty("webhookURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lcpicordis;

    public partial class WorkflowManagedActions
    {
        public LcpicordisActions Lcpicordis(string connectionId) => new LcpicordisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LcpicordisTriggers Lcpicordis(string connectionId) => new LcpicordisTriggers(connectionId);
    }
}