//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Instapaper
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstapaperActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksLiked(Expression<Func<string>> readFilterreadFilter = null)
        {
            var apiCallPath = "/1/bookmarks/list/starred";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var readFilter = new JObject();
            var readFilterpropCount = 0;
            if (readFilterreadFilter != null)
            {
                readFilter["readFilter"] = ExpressionConverter.ConvertO(readFilterreadFilter);
                readFilterpropCount++;
            }

            if (readFilterpropCount > 0)
            {
                callPayload.Body = readFilter;
            }

            return new ApiConnectionAction<BookmarksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksArchived(Expression<Func<filterslikedFilterDefaultAllInput>> filterslikedFilterDefaultAll = null, Expression<Func<filtersreadFilterDefaultAllInput>> filtersreadFilterDefaultAll = null)
        {
            var apiCallPath = "/1/bookmarks/list/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filters = new JObject();
            var filterspropCount = 0;
            if (filterslikedFilterDefaultAll != null)
            {
                filters["likedFilter"] = ExpressionConverter.ConvertO(filterslikedFilterDefaultAll);
                filterspropCount++;
            }

            if (filtersreadFilterDefaultAll != null)
            {
                filters["readFilter"] = ExpressionConverter.ConvertO(filtersreadFilterDefaultAll);
                filterspropCount++;
            }

            if (filterspropCount > 0)
            {
                callPayload.Body = filters;
            }

            return new ApiConnectionAction<BookmarksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksInFolder(Expression<Func<string>> folderId, Expression<Func<likedFilterInput>> likedFilter = null, Expression<Func<readFilterInput>> readFilter = null)
        {
            var apiCallPath = "/1/bookmarks/list/folder_id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            if (likedFilter != null)
                callPayload.Queries["likedFilter"] = ExpressionConverter.Convert(likedFilter);
            if (readFilter != null)
                callPayload.Queries["readFilter"] = ExpressionConverter.Convert(readFilter);
            return new ApiConnectionAction<BookmarksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FoldersResponse> ListFolders()
        {
            var apiCallPath = "/1/folders/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlighstResponse> ListHighlights(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = String.Format("/1.1/bookmarks/{0}/highlights", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HighlighstResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> UnlikeBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/unstar";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<BookmarkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> LikeBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/star";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<BookmarkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> ArchiveBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<BookmarkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> UnarchiveBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/unarchive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<BookmarkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> DeleteBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> MarkReadBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/update_read_progress/read";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> MarkUnreadBookmark(Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = "/1/bookmarks/update_read_progress/unread";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlightResponse> AddHighlight(Expression<Func<string>> bookmarkId, Expression<Func<string>> text)
        {
            var apiCallPath = String.Format("/1.1/bookmarks/{0}/highlight", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            return new ApiConnectionAction<HighlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FolderResponse> CreateFolder(Expression<Func<string>> title)
        {
            var apiCallPath = "/1/folders/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            return new ApiConnectionAction<FolderResponse>(callPayload);
        }
    }

    public class InstapaperTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<BookmarksResponse> OnBookmarkAdded(Expression<Func<string>> folderId)
        {
            var apiCallPath = "/bookmark_folder_trigger/1/bookmarks/list/folder_id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<int[]> OnBookmarkRemoved(Expression<Func<string>> folderId)
        {
            var apiCallPath = "/bookmark_removed_folder_trigger/1/bookmarks/list/folder_id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionTrigger<int[]>(callPayload);
        }

        public IOutputWorkflowTrigger<BookmarksResponse> OnBookmarkArchived()
        {
            var apiCallPath = "/bookmark_archive_trigger/1/bookmarks/list/archive";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<BookmarksResponse> OnBookmarkLiked()
        {
            var apiCallPath = "/bookmark_starred_trigger/1/bookmarks/list/starred";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<FoldersResponse> OnFolderCreated()
        {
            var apiCallPath = "/folder_trigger/1/folders/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<FoldersResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<BookmarksResponse> OnBookmarkProgressUpdated(Expression<Func<string>> folderId)
        {
            var apiCallPath = "/bookmark_progress_trigger/1/bookmarks/list/folder_id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<BookmarksResponse> OnBookmarkProgressRead(Expression<Func<string>> folderId)
        {
            var apiCallPath = "/bookmark_progressread_trigger/1/bookmarks/list/folder_id";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<HighlighstResponse> OnHighlightAdded(Expression<Func<string>> folderId, Expression<Func<string>> bookmarkId)
        {
            var apiCallPath = String.Format("/highlight_added_trigger/1.1/bookmarks/{0}/highlights", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionTrigger<HighlighstResponse>(callPayload);
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

    public enum filterslikedFilterDefaultAllInput
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

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

    public enum likedFilterInput
    {
        Liked,
        [EnumMember(Value = "Not liked")]
        NotLiked
    }

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
    using Microsoft.Azure.Workflows.Sdk.Instapaper;

    public partial class WorkflowManagedActions
    {
        public InstapaperActions Instapaper(string connectionId) => new InstapaperActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstapaperTriggers Instapaper(string connectionId) => new InstapaperTriggers(connectionId);
    }
}