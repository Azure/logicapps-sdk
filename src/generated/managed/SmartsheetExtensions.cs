//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartsheet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartsheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionSheet> ListSheets(Expression<Func<string>> optionalFolderId = null)
        {
            var apiCallPath = "/sheets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (optionalFolderId != null)
                callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(optionalFolderId);
            return new ApiConnectionAction<SmartsheetCollectionSheet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SheetWithRows> GetSheet(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null)
        {
            var apiCallPath = String.Format("/sheets/{0}", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (columns != null)
                callPayload.Queries["columns"] = ExpressionConverter.Convert(columns);
            return new ApiConnectionAction<SheetWithRows>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionColumn> GetColumns(Expression<Func<string>> sheetId)
        {
            var apiCallPath = String.Format("/sheets/{0}/columns", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SmartsheetCollectionColumn>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IWorkflowAction GetColumnsSchema(Expression<Func<string>> sheetId)
        {
            var apiCallPath = String.Format("/remove/sheets/{0}/columns", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<RowsList> GetSheetData(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null)
        {
            var apiCallPath = String.Format("/sheets/{0}/rows", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (columns != null)
                callPayload.Queries["columns"] = ExpressionConverter.Convert(columns);
            return new ApiConnectionAction<RowsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<InsertRowResponse> InsertRow(Expression<Func<string>> sheetId, Expression<Func<object>> row = null)
        {
            var apiCallPath = String.Format("/sheets/{0}/rows", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(row);
            return new ApiConnectionAction<InsertRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionFolder> ListSubFolders(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/folders/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SmartsheetCollectionFolder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionGetDiscussionResponse> GetDiscussionsForSheet(Expression<Func<string>> sheetId)
        {
            var apiCallPath = String.Format("/sheets/{0}/discussions", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SmartsheetCollectionGetDiscussionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToSheet(Expression<Func<string>> sheetId, Expression<Func<string>> discussiontitle = null, Expression<Func<string>> discussioncommenttext = null)
        {
            var apiCallPath = String.Format("/sheets/{0}/discussions", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var discussion = new JObject();
            var discussionpropCount = 0;
            if (discussiontitle != null)
            {
                discussion["title"] = ExpressionConverter.ConvertO(discussiontitle);
                discussionpropCount++;
            }

            var commentObject = new JObject();
            var commentObjectpropCount = 0;
            if (discussioncommenttext != null)
            {
                commentObject["text"] = ExpressionConverter.ConvertO(discussioncommenttext);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToRow(Expression<Func<string>> sheetId, Expression<Func<string>> rowId, Expression<Func<string>> discussiontitle = null, Expression<Func<string>> discussioncommenttext = null)
        {
            var apiCallPath = String.Format("/sheets/{0}/rows/{1}/discussions", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var discussion = new JObject();
            var discussionpropCount = 0;
            if (discussiontitle != null)
            {
                discussion["title"] = ExpressionConverter.ConvertO(discussiontitle);
                discussionpropCount++;
            }

            var commentObject = new JObject();
            var commentObjectpropCount = 0;
            if (discussioncommenttext != null)
            {
                commentObject["text"] = ExpressionConverter.ConvertO(discussioncommenttext);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<CreateCommentResponse> AddCommentToDiscussion(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId, Expression<Func<string>> commenttext = null)
        {
            var apiCallPath = String.Format("/sheets/{0}/discussions/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1), ExpressionConverter.ConvertWithUrlEncoding(discussionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var comment = new JObject();
            var commentpropCount = 0;
            if (commenttext != null)
            {
                comment["text"] = ExpressionConverter.ConvertO(commenttext);
                commentpropCount++;
            }

            if (commentpropCount > 0)
            {
                callPayload.Body = comment;
            }

            return new ApiConnectionAction<CreateCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionData> GetDiscussion(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId)
        {
            var apiCallPath = String.Format("/sheets/{0}/discussions/{1}", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1), ExpressionConverter.ConvertWithUrlEncoding(discussionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DiscussionData>(callPayload);
        }
    }

    public class SmartsheetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnNewSheet(Expression<Func<string>> optionalFolderId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_trigger/sheets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (optionalFolderId != null)
                callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(optionalFolderId);
            return new ApiConnectionTrigger<SmartsheetCollectionSheet>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnUpdatedSheet(Expression<Func<string>> optionalFolderId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/updated_trigger/sheets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (optionalFolderId != null)
                callPayload.Queries["optionalFolderId"] = ExpressionConverter.Convert(optionalFolderId);
            return new ApiConnectionTrigger<SmartsheetCollectionSheet>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionDiscussionComment> OnNewComment(Expression<Func<string>> sheetId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/new_comment_trigger/sheets/{0}/discussions", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SmartsheetCollectionDiscussionComment>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheetWithRows> OnUpdatedSpecificSheet(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/updated_trigger/sheets/{0}", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (columns != null)
                callPayload.Queries["columns"] = ExpressionConverter.Convert(columns);
            return new ApiConnectionTrigger<SmartsheetCollectionSheetWithRows>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RowResponse> OnRowCreated(Expression<Func<string>> sheetId, Expression<Func<string>> columns = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/row_created_trigger/sheets/{0}", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (columns != null)
                callPayload.Queries["columns"] = ExpressionConverter.Convert(columns);
            return new ApiConnectionTrigger<RowResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CommentResponse> OnCommentAdded(Expression<Func<string>> sheetId, Expression<Func<string>> discussionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/comment_added_trigger/sheets/{0}/discussions/{1}", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1), ExpressionConverter.ConvertWithUrlEncoding(discussionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CommentResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionGetDiscussionResponse> OnDiscussionCreated(Expression<Func<string>> sheetId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/discussion_trigger/sheets/{0}/discussions", ExpressionConverter.ConvertWithUrlEncoding(sheetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SmartsheetCollectionGetDiscussionResponse>(callPayload, triggerName, recurrence);
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