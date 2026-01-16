//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gravityformsprofessi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GravityformsprofessiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> GetFieldChoices(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/resources/forms/{0}/fields/{1}/choices", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> UpdateFieldChoices(Expression<Func<string>> formId, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/resources/forms/{0}/fields/{1}/choices", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<GetEntriesResponse> GetEntries(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/resources/entries/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<GetEntriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> CreateEntry(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/resources/entries";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction DeleteEntry(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> UpdateEntry(Expression<Func<string>> formId, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> GetFieldEntry(Expression<Func<string>> formId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/resources/field_entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> ValidateEntry(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/resources/validations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken[]> GetEntryNotes(Expression<Func<string>> entryId)
        {
            var apiCallPath = String.Format("/resources/entries/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(entryId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> CreateEntryNote(Expression<Func<string>> entryId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/resources/entries/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(entryId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction DeleteEntryAttachment(Expression<Func<string>> entryId, Expression<Func<string>> attachmentUrl)
        {
            var apiCallPath = String.Format("/resources/entries/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(entryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["attachment_url"] = ExpressionConverter.Convert(attachmentUrl);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IWorkflowAction DeleteAllEntryAttachments(Expression<Func<string>> entryId)
        {
            var apiCallPath = String.Format("/resources/entries/{0}/attachments/all", ExpressionConverter.ConvertWithUrlEncoding(entryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gravityformsprofessi")]
        public IBodyWorkflowAction<JToken> DownloadEntryAttachment(Expression<Func<string>> entryId, Expression<Func<string>> attachmentUrl)
        {
            var apiCallPath = String.Format("/resources/entries/{0}/attachments/download", ExpressionConverter.ConvertWithUrlEncoding(entryId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["attachment_url"] = ExpressionConverter.Convert(attachmentUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class GravityformsprofessiTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetEntriesResponse
    {
        [JsonProperty("entries")]
        public JToken[] Entries { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
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