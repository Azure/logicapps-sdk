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
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksLiked(Expression<Func<ListBookmarksLikedReadFilterInput>> readFilter = null)
        {
            var __workflow_readFilter = WorkflowExpression.Compile(readFilter, nameof(readFilter), required: false);
            return new DeferredBodyAction<BookmarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/list/starred";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_readFilter != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_readFilter);
                return new ApiConnectionAction<BookmarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksArchived(Expression<Func<FiltersInput>> filters = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            return new DeferredBodyAction<BookmarksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/bookmarks/list/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_filters);
                return new ApiConnectionAction<BookmarksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse, ApiConnectionActionConfiguration> ListBookmarksInFolder(Expression<Func<string>> folderId, Expression<Func<LikedFilterInput>> likedFilter = null, Expression<Func<ListBookmarksInFolderReadFilterInput>> readFilter = null)
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
            return new DeferredBodyAction<FoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/folders/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FoldersResponse>(callPayload);
            });
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
        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration> OnBookmarkAdded(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<BookmarksResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<int[], ApiConnectionPollingTriggerConfiguration> OnBookmarkRemoved(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<int[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_removed_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<int[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration> OnBookmarkArchived()
        {
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_archive_trigger/1/bookmarks/list/archive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<BookmarksResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration> OnBookmarkLiked()
        {
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_starred_trigger/1/bookmarks/list/starred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<BookmarksResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<FoldersResponse, ApiConnectionPollingTriggerConfiguration> OnFolderCreated()
        {
            return new DeferredBodyTrigger<FoldersResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/folder_trigger/1/folders/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<FoldersResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration> OnBookmarkProgressUpdated(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_progress_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<BookmarksResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration> OnBookmarkProgressRead(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/bookmark_progressread_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<BookmarksResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<HighlighstResponse, ApiConnectionPollingTriggerConfiguration> OnHighlightAdded(Expression<Func<string>> folderId, Expression<Func<string>> bookmarkId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bookmarkId = WorkflowExpression.Compile(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyTrigger<HighlighstResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/highlight_added_trigger/1.1/bookmarks/{0}/highlights", __workflow_bookmarkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<HighlighstResponse>(callPayload);
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

    public class ListBookmarksLikedReadFilterInput
    {
        [JsonProperty("readFilter")]
        public string ReadFilter { get; set; }
    }

    public class FiltersInput
    {
        [JsonProperty("likedFilter")]
        public FiltersInputLikedFilterDefaultAllType? LikedFilterDefaultAll { get; set; }

        [JsonProperty("readFilter")]
        public FiltersInputReadFilterDefaultAllType? ReadFilterDefaultAll { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FiltersInputLikedFilterDefaultAllType
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FiltersInputReadFilterDefaultAllType
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
    public enum LikedFilterInput
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListBookmarksInFolderReadFilterInput
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