//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartsheet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartsheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionSheet> ListSheets(Expression<Func<string>> optionalFolderId = null)
        {
            var __workflow_optionalFolderId = WorkflowExpression.Compile(optionalFolderId, nameof(optionalFolderId), required: false);
            return new DeferredBodyAction<SmartsheetCollectionSheet>(() =>
            {
                var apiCallPath = "/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(__workflow_optionalFolderId);
                return new ApiConnectionAction<SmartsheetCollectionSheet>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SheetWithRows> GetSheet(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            return new DeferredBodyAction<SheetWithRows>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                return new ApiConnectionAction<SheetWithRows>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionColumn> GetColumns(Expression<Func<string>> sheetId)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            return new DeferredBodyAction<SmartsheetCollectionColumn>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/columns", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmartsheetCollectionColumn>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IWorkflowAction GetColumnsSchema(Expression<Func<string>> sheetId)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/remove/sheets/{0}/columns", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<RowsList> GetSheetData(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            return new DeferredBodyAction<RowsList>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/rows", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                return new ApiConnectionAction<RowsList>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<InsertRowResponse> InsertRow(Expression<Func<string>> sheetId, Expression<Func<object>> row = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_row = WorkflowExpression.Compile(row, nameof(row), required: false);
            return new DeferredBodyAction<InsertRowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/rows", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_row);
                return new ApiConnectionAction<InsertRowResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionFolder> ListSubFolders(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SmartsheetCollectionFolder>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}/folders", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmartsheetCollectionFolder>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionGetDiscussionResponse> GetDiscussionsForSheet(Expression<Func<string>> sheetId)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            return new DeferredBodyAction<SmartsheetCollectionGetDiscussionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/discussions", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmartsheetCollectionGetDiscussionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToSheet(Expression<Func<string>> sheetId, Expression<Func<string>> discussiontitle = null, Expression<Func<string>> discussioncommenttext = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_discussiontitle = WorkflowExpression.Compile(discussiontitle, nameof(discussiontitle), required: false);
            var __workflow_discussioncommenttext = WorkflowExpression.Compile(discussioncommenttext, nameof(discussioncommenttext), required: false);
            return new DeferredBodyAction<DiscussionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/discussions", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var discussion = new JObject();
                var discussionpropCount = 0;
                if (__workflow_discussiontitle != null)
                {
                    discussion["title"] = ExpressionConverter.ConvertO(__workflow_discussiontitle);
                    discussionpropCount++;
                }

                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (__workflow_discussioncommenttext != null)
                {
                    commentObject["text"] = ExpressionConverter.ConvertO(__workflow_discussioncommenttext);
                    commentObjectpropCount++;
                }

                if (commentObjectpropCount > 0)
                {
                    discussion["comment"] = commentObject;
                    discussionpropCount++;
                }

                if (discussionpropCount > 0)
                {
                    callPayload.Body = discussion;
                }

                return new ApiConnectionAction<DiscussionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToRow(Expression<Func<string>> sheetId, Expression<Func<string>> rowId, Expression<Func<string>> discussiontitle = null, Expression<Func<string>> discussioncommenttext = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            var __workflow_discussiontitle = WorkflowExpression.Compile(discussiontitle, nameof(discussiontitle), required: false);
            var __workflow_discussioncommenttext = WorkflowExpression.Compile(discussioncommenttext, nameof(discussioncommenttext), required: false);
            return new DeferredBodyAction<DiscussionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/rows/{1}/discussions", __workflow_sheetId.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var discussion = new JObject();
                var discussionpropCount = 0;
                if (__workflow_discussiontitle != null)
                {
                    discussion["title"] = ExpressionConverter.ConvertO(__workflow_discussiontitle);
                    discussionpropCount++;
                }

                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (__workflow_discussioncommenttext != null)
                {
                    commentObject["text"] = ExpressionConverter.ConvertO(__workflow_discussioncommenttext);
                    commentObjectpropCount++;
                }

                if (commentObjectpropCount > 0)
                {
                    discussion["comment"] = commentObject;
                    discussionpropCount++;
                }

                if (discussionpropCount > 0)
                {
                    callPayload.Body = discussion;
                }

                return new ApiConnectionAction<DiscussionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<CreateCommentResponse> AddCommentToDiscussion(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId, Expression<Func<string>> commenttext = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_discussionId = WorkflowExpression.Compile(discussionId, nameof(discussionId), required: true);
            var __workflow_commenttext = WorkflowExpression.Compile(commenttext, nameof(commenttext), required: false);
            return new DeferredBodyAction<CreateCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/discussions/{1}/comments", __workflow_sheetId.WithUrlEncoding(1), __workflow_discussionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (__workflow_commenttext != null)
                {
                    comment["text"] = ExpressionConverter.ConvertO(__workflow_commenttext);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<CreateCommentResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionData> GetDiscussion(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_discussionId = WorkflowExpression.Compile(discussionId, nameof(discussionId), required: true);
            return new DeferredBodyAction<DiscussionData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sheets/{0}/discussions/{1}", __workflow_sheetId.WithUrlEncoding(1), __workflow_discussionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DiscussionData>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class SmartsheetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnNewSheet(Expression<Func<string>> optionalFolderId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_optionalFolderId = WorkflowExpression.Compile(optionalFolderId, nameof(optionalFolderId), required: false);
            return new DeferredBodyTrigger<SmartsheetCollectionSheet>(() =>
            {
                var apiCallPath = "/new_trigger/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(__workflow_optionalFolderId);
                return new ApiConnectionTrigger<SmartsheetCollectionSheet>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnUpdatedSheet(Expression<Func<string>> optionalFolderId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_optionalFolderId = WorkflowExpression.Compile(optionalFolderId, nameof(optionalFolderId), required: false);
            return new DeferredBodyTrigger<SmartsheetCollectionSheet>(() =>
            {
                var apiCallPath = "/updated_trigger/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(__workflow_optionalFolderId);
                return new ApiConnectionTrigger<SmartsheetCollectionSheet>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionDiscussionComment> OnNewComment(Expression<Func<string>> sheetId, FlowRecurrence recurrence = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            return new DeferredBodyTrigger<SmartsheetCollectionDiscussionComment>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/new_comment_trigger/sheets/{0}/discussions", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SmartsheetCollectionDiscussionComment>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheetWithRows> OnUpdatedSpecificSheet(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null, FlowRecurrence recurrence = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            return new DeferredBodyTrigger<SmartsheetCollectionSheetWithRows>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updated_trigger/sheets/{0}", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                return new ApiConnectionTrigger<SmartsheetCollectionSheetWithRows>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<RowResponse> OnRowCreated(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null, FlowRecurrence recurrence = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            return new DeferredBodyTrigger<RowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/row_created_trigger/sheets/{0}", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                return new ApiConnectionTrigger<RowResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<CommentResponse> OnCommentAdded(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId, FlowRecurrence recurrence = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            var __workflow_discussionId = WorkflowExpression.Compile(discussionId, nameof(discussionId), required: true);
            return new DeferredBodyTrigger<CommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/comment_added_trigger/sheets/{0}/discussions/{1}", __workflow_sheetId.WithUrlEncoding(1), __workflow_discussionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CommentResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionGetDiscussionResponse> OnDiscussionCreated(Expression<Func<string>> sheetId, FlowRecurrence recurrence = null)
        {
            var __workflow_sheetId = WorkflowExpression.Compile(sheetId, nameof(sheetId), required: true);
            return new DeferredBodyTrigger<SmartsheetCollectionGetDiscussionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/discussion_trigger/sheets/{0}/discussions", __workflow_sheetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SmartsheetCollectionGetDiscussionResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class SmartsheetCollectionSheet
    {
        [JsonProperty("data")]
        public Sheet[] Data { get; set; }
    }

    public class Sheet
    {
        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permalink")]
        public string Url { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }
    }

    public class SheetWithRows
    {
        [JsonProperty("rowHTML")]
        public string SheetHTML { get; set; }

        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permalink")]
        public string Url { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("columns")]
        public Column[] Columns { get; set; }

        [JsonProperty("rows")]
        public RowData[] Rows { get; set; }
    }

    public class Column
    {
        [JsonProperty("id")]
        public int ColumnId { get; set; }

        [JsonProperty("index")]
        public int ColumnIndex { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string DataType { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class RowData
    {
        [JsonProperty("id")]
        public int RowId { get; set; }

        [JsonProperty("sheetId")]
        public int SheetId { get; set; }

        [JsonProperty("permalink")]
        public string Url { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("rowNumber")]
        public int RowNumber { get; set; }

        [JsonProperty("cells")]
        public RowCell[] Cells { get; set; }

        [JsonProperty("rowHTML")]
        public string RowHTML { get; set; }
    }

    public class RowCell
    {
        [JsonProperty("columnId")]
        public int ColumnId { get; set; }

        [JsonProperty("value")]
        public JToken CellValue { get; set; }

        [JsonProperty("displayValue")]
        public string CellDisplayValue { get; set; }
    }

    public class SmartsheetCollectionColumn
    {
        [JsonProperty("data")]
        public Column[] Data { get; set; }
    }

    public class RowsList
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class InsertRowResponse
    {
        [JsonProperty("result")]
        public InsertRowResponseResult Result { get; set; }
    }

    public class InsertRowResponseResult
    {
        [JsonProperty("sheetId")]
        public int SheetId { get; set; }

        [JsonProperty("rowNumber")]
        public int RowNumber { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }
    }

    public class SmartsheetCollectionFolder
    {
        [JsonProperty("data")]
        public Folder[] Data { get; set; }
    }

    public class Folder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permalink")]
        public string Url { get; set; }
    }

    public class SmartsheetCollectionGetDiscussionResponse
    {
        [JsonProperty("data")]
        public GetDiscussionResponse[] Data { get; set; }
    }

    public class GetDiscussionResponse
    {
        [JsonProperty("id")]
        public int DiscussionId { get; set; }

        [JsonProperty("title")]
        public string DiscussionTitle { get; set; }

        [JsonProperty("createdBy")]
        public DiscussionUser CreatedBy { get; set; }

        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("parentType")]
        public string ParentType { get; set; }

        [JsonProperty("readOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("lastCommentedAt")]
        public string LastCommentedAt { get; set; }
    }

    public class DiscussionUser
    {
        [JsonProperty("name")]
        public string CreatedByName { get; set; }

        [JsonProperty("email")]
        public string CreatedByEmail { get; set; }
    }

    public class DiscussionResponse
    {
        [JsonProperty("result")]
        public DiscussionData Result { get; set; }
    }

    public class DiscussionData
    {
        [JsonProperty("id")]
        public int IdOfDiscussion { get; set; }

        [JsonProperty("title")]
        public string DiscussionTitle { get; set; }

        [JsonProperty("comments")]
        public DiscussionComment[] Comments { get; set; }

        [JsonProperty("createdBy")]
        public DiscussionUser CreatedBy { get; set; }
    }

    public class DiscussionComment
    {
        [JsonProperty("text")]
        public string CommentText { get; set; }

        [JsonProperty("id")]
        public int CommentId { get; set; }

        [JsonProperty("createdBy")]
        public DiscussionCommentUser CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }
    }

    public class DiscussionCommentUser
    {
        [JsonProperty("name")]
        public string CreatedByName { get; set; }

        [JsonProperty("email")]
        public string CreatedByEmail { get; set; }
    }

    public class CreateCommentResponse
    {
        [JsonProperty("result")]
        public DiscussionComment Result { get; set; }
    }

    public class SmartsheetCollectionDiscussionComment
    {
        [JsonProperty("data")]
        public DiscussionComment[] Data { get; set; }
    }

    public class SmartsheetCollectionSheetWithRows
    {
        [JsonProperty("data")]
        public SheetWithRows[] Data { get; set; }
    }

    public class RowResponse
    {
        [JsonProperty("rows")]
        public RowData[] Rows { get; set; }
    }

    public class CommentResponse
    {
        [JsonProperty("comments")]
        public DiscussionComment[] Comments { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smartsheet;

    public partial class WorkflowManagedActions
    {
        public SmartsheetActions Smartsheet(string connectionId) => new SmartsheetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmartsheetTriggers Smartsheet(string connectionId) => new SmartsheetTriggers(connectionId);
    }
}
