//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instapaper
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstapaperActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksLiked(Expression<Func<string>> readFilterreadFilter = null)
        {
            var __workflow_readFilterreadFilter = WorkflowExpression.Compile(readFilterreadFilter, nameof(readFilterreadFilter), required: false);
            return new DeferredBodyAction<BookmarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/list/starred";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var readFilter = new JObject();
                var readFilterpropCount = 0;
                if (__workflow_readFilterreadFilter != null)
                {
                    readFilter["readFilter"] = ExpressionConverter.ConvertO(__workflow_readFilterreadFilter);
                    readFilterpropCount++;
                }

                if (readFilterpropCount > 0)
                {
                    callPayload.Body = readFilter;
                }

                return new ApiConnectionAction<BookmarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksArchived(Expression<Func<filterslikedFilterDefaultAllInput>> filterslikedFilterDefaultAll = null, Expression<Func<filtersreadFilterDefaultAllInput>> filtersreadFilterDefaultAll = null)
        {
            var __workflow_filterslikedFilterDefaultAll = WorkflowExpression.Compile(filterslikedFilterDefaultAll, nameof(filterslikedFilterDefaultAll), required: false);
            var __workflow_filtersreadFilterDefaultAll = WorkflowExpression.Compile(filtersreadFilterDefaultAll, nameof(filtersreadFilterDefaultAll), required: false);
            return new DeferredBodyAction<BookmarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/list/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filters = new JObject();
                var filterspropCount = 0;
                if (__workflow_filterslikedFilterDefaultAll != null)
                {
                    filters["likedFilter"] = ExpressionConverter.ConvertO(__workflow_filterslikedFilterDefaultAll);
                    filterspropCount++;
                }

                if (__workflow_filtersreadFilterDefaultAll != null)
                {
                    filters["readFilter"] = ExpressionConverter.ConvertO(__workflow_filtersreadFilterDefaultAll);
                    filterspropCount++;
                }

                if (filterspropCount > 0)
                {
                    callPayload.Body = filters;
                }

                return new ApiConnectionAction<BookmarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksInFolder(Expression<Func<string>> folderId, Expression<Func<likedFilterInput>> likedFilter = null, Expression<Func<readFilterInput>> readFilter = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_likedFilter = WorkflowExpression.Compile(likedFilter, nameof(likedFilter), required: false);
            var __workflow_readFilter = WorkflowExpression.Compile(readFilter, nameof(readFilter), required: false);
            return new DeferredBodyAction<BookmarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                if (__workflow_likedFilter != null)
                    callPayload.Queries["likedFilter"] = ExpressionConverter.Convert(__workflow_likedFilter);
                if (__workflow_readFilter != null)
                    callPayload.Queries["readFilter"] = ExpressionConverter.Convert(__workflow_readFilter);
                return new ApiConnectionAction<BookmarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FoldersResponse, ApiConnectionActionConfiguration> ListFolders()
        {
            var apiCallPath = "/1/folders/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlighstResponse, ApiConnectionActionConfiguration> ListHighlights(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<HighlighstResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/1.1/bookmarks/{0}/highlights", __workflow_bookmarkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HighlighstResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse, ApiConnectionActionConfiguration> UnlikeBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/unstar";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse, ApiConnectionActionConfiguration> LikeBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/star";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse, ApiConnectionActionConfiguration> ArchiveBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse, ApiConnectionActionConfiguration> UnarchiveBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/unarchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MarkReadBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MarkUnreadBookmark(Expression<Func<string>> bookmarkId)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/unread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(__workflow_bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlightResponse, ApiConnectionActionConfiguration> AddHighlight(Expression<Func<string>> bookmarkId, Expression<Func<string>> text)
        {
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: true);
            return new DeferredBodyAction<HighlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/1.1/bookmarks/{0}/highlight", __workflow_bookmarkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                return new ApiConnectionAction<HighlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FolderResponse, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<string>> title)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            return new DeferredBodyAction<FolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/folders/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                return new ApiConnectionAction<FolderResponse>(callPayload);
            });
        }
    }

    public class InstapaperTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration> OnBookmarkAdded(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<int[], ApiConnectionTriggerConfiguration> OnBookmarkRemoved(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<int[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_removed_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionTrigger<int[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration> OnBookmarkArchived(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/bookmark_archive_trigger/1/bookmarks/list/archive";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration> OnBookmarkLiked(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/bookmark_starred_trigger/1/bookmarks/list/starred";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<FoldersResponse, ApiConnectionTriggerConfiguration> OnFolderCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/folder_trigger/1/folders/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<FoldersResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration> OnBookmarkProgressUpdated(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_progress_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration> OnBookmarkProgressRead(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_progressread_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<HighlighstResponse, ApiConnectionTriggerConfiguration> OnHighlightAdded(Expression<Func<string>> folderId, Expression<Func<string>> bookmarkId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyTrigger<HighlighstResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/highlight_added_trigger/1.1/bookmarks/{0}/highlights", __workflow_bookmarkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionTrigger<HighlighstResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BookmarksResponse
    {
        public Bookmark[] Bookmarks { get; set; }
    }

    public class Bookmark
    {
        [JsonProperty("bookmark_id")]
        public int BookmarkId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("starred")]
        public bool Liked { get; set; }

        [JsonProperty("time")]
        public string CreationTime { get; set; }

        [JsonProperty("progress")]
        public double ReadProgress { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterslikedFilterDefaultAllInput
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filtersreadFilterDefaultAllInput
    {
        Unread,
        [EnumMember(Value = "Unread or partially read")]
        UnreadOrPartiallyRead,
        [EnumMember(Value = "Partially read")]
        PartiallyRead,
        [EnumMember(Value = "Partially read or read")]
        PartiallyReadOrRead,
        Read
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum likedFilterInput
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum readFilterInput
    {
        Unread,
        [EnumMember(Value = "Unread or partially read")]
        UnreadOrPartiallyRead,
        [EnumMember(Value = "Partially read")]
        PartiallyRead,
        [EnumMember(Value = "Partially read or read")]
        PartiallyReadOrRead,
        Read
    }

    public class FoldersResponse
    {
        public Folder[] Folders { get; set; }
    }

    public class Folder
    {
        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }

        [JsonProperty("sync_to_mobile")]
        public bool SyncToMobile { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class HighlighstResponse
    {
        public Highlight[] Highlights { get; set; }
    }

    public class Highlight
    {
        [JsonProperty("highlight_id")]
        public int HighlightId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("time")]
        public string CreationTime { get; set; }
    }

    public class BookmarkResponse
    {
        public Bookmark Bookmark { get; set; }
    }

    public class HighlightResponse
    {
        public Highlight Highlight { get; set; }
    }

    public class FolderResponse
    {
        public Folder Folders { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Instapaper;

    public partial class WorkflowManagedActions
    {
        public InstapaperActions Instapaper(string connectionId) => new InstapaperActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstapaperTriggers Instapaper(string connectionId) => new InstapaperTriggers(connectionId);
    }
}
