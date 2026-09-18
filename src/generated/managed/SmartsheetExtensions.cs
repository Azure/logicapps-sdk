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
        public IBodyWorkflowAction<SmartsheetCollectionSheet> ListSheets([WorkflowExpression] Func<string> optionalFolderId = null)
        {
            SourceExpression.Validate(optionalFolderId, nameof(optionalFolderId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = SourceExpressionConverter.ConvertO(optionalFolderId);
                return callPayload;
            }

            return new ApiConnectionAction<SmartsheetCollectionSheet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SheetWithRows> GetSheet([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> columns = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(columns, nameof(columns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (columns != null)
                    callPayload.Queries["columns"] = SourceExpressionConverter.ConvertO(columns);
                return callPayload;
            }

            return new ApiConnectionAction<SheetWithRows>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionColumn> GetColumns([WorkflowExpression] Func<string> sheetId)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/columns", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmartsheetCollectionColumn>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IWorkflowAction GetColumnsSchema([WorkflowExpression] Func<string> sheetId)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/remove/sheets/{0}/columns", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<RowsList> GetSheetData([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> columns = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(columns, nameof(columns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (columns != null)
                    callPayload.Queries["columns"] = SourceExpressionConverter.ConvertO(columns);
                return callPayload;
            }

            return new ApiConnectionAction<RowsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<InsertRowResponse> InsertRow([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<object> row = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(row, nameof(row), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(row);
                return callPayload;
            }

            return new ApiConnectionAction<InsertRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionFolder> ListSubFolders([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/folders/{0}/folders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmartsheetCollectionFolder>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<SmartsheetCollectionGetDiscussionResponse> GetDiscussionsForSheet([WorkflowExpression] Func<string> sheetId)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/discussions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmartsheetCollectionGetDiscussionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToSheet([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> discussiontitle = null, [WorkflowExpression] Func<string> discussioncommenttext = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(discussiontitle, nameof(discussiontitle), required: false);
            SourceExpression.Validate(discussioncommenttext, nameof(discussioncommenttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/discussions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var discussion = new JObject();
                var discussionpropCount = 0;
                if (discussiontitle != null)
                {
                    discussion["title"] = SourceExpressionConverter.ConvertToken(discussiontitle);
                    discussionpropCount++;
                }

                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (discussioncommenttext != null)
                {
                    commentObject["text"] = SourceExpressionConverter.ConvertToken(discussioncommenttext);
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
                return callPayload;
            }

            return new ApiConnectionAction<DiscussionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionResponse> AddDiscussionToRow([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> rowId, [WorkflowExpression] Func<string> discussiontitle = null, [WorkflowExpression] Func<string> discussioncommenttext = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            SourceExpression.Validate(discussiontitle, nameof(discussiontitle), required: false);
            SourceExpression.Validate(discussioncommenttext, nameof(discussioncommenttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/rows/{1}/discussions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var discussion = new JObject();
                var discussionpropCount = 0;
                if (discussiontitle != null)
                {
                    discussion["title"] = SourceExpressionConverter.ConvertToken(discussiontitle);
                    discussionpropCount++;
                }

                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (discussioncommenttext != null)
                {
                    commentObject["text"] = SourceExpressionConverter.ConvertToken(discussioncommenttext);
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
                return callPayload;
            }

            return new ApiConnectionAction<DiscussionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<CreateCommentResponse> AddCommentToDiscussion([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> discussionId, [WorkflowExpression] Func<string> commenttext = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(discussionId, nameof(discussionId), required: true);
            SourceExpression.Validate(commenttext, nameof(commenttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/discussions/{1}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(discussionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (commenttext != null)
                {
                    comment["text"] = SourceExpressionConverter.ConvertToken(commenttext);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartsheet")]
        public IBodyWorkflowAction<DiscussionData> GetDiscussion([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> discussionId)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(discussionId, nameof(discussionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sheets/{0}/discussions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(discussionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DiscussionData>(BuildSourceInput);
        }
    }

    public class SmartsheetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnNewSheet([WorkflowExpression] Func<string> optionalFolderId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(optionalFolderId, nameof(optionalFolderId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/new_trigger/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = SourceExpressionConverter.ConvertO(optionalFolderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SmartsheetCollectionSheet>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheet> OnUpdatedSheet([WorkflowExpression] Func<string> optionalFolderId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(optionalFolderId, nameof(optionalFolderId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updated_trigger/sheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (optionalFolderId != null)
                    callPayload.Queries["optionalFolderId"] = SourceExpressionConverter.ConvertO(optionalFolderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SmartsheetCollectionSheet>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionDiscussionComment> OnNewComment([WorkflowExpression] Func<string> sheetId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/new_comment_trigger/sheets/{0}/discussions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SmartsheetCollectionDiscussionComment>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionSheetWithRows> OnUpdatedSpecificSheet([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> columns = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(columns, nameof(columns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updated_trigger/sheets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (columns != null)
                    callPayload.Queries["columns"] = SourceExpressionConverter.ConvertO(columns);
                return callPayload;
            }

            return new ApiConnectionTrigger<SmartsheetCollectionSheetWithRows>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RowResponse> OnRowCreated([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> columns = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(columns, nameof(columns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/row_created_trigger/sheets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (columns != null)
                    callPayload.Queries["columns"] = SourceExpressionConverter.ConvertO(columns);
                return callPayload;
            }

            return new ApiConnectionTrigger<RowResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CommentResponse> OnCommentAdded([WorkflowExpression] Func<string> sheetId, [WorkflowExpression] Func<string> discussionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            SourceExpression.Validate(discussionId, nameof(discussionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/comment_added_trigger/sheets/{0}/discussions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(discussionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<CommentResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SmartsheetCollectionGetDiscussionResponse> OnDiscussionCreated([WorkflowExpression] Func<string> sheetId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(sheetId, nameof(sheetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/discussion_trigger/sheets/{0}/discussions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sheetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<SmartsheetCollectionGetDiscussionResponse>(BuildSourceInput, triggerName, recurrence);
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