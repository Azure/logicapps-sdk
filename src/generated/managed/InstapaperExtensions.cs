//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instapaper
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstapaperActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildListBookmarksLiked))]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksLiked([WorkflowExpression] Func<string> readFilterreadFilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarksResponse> __BuildListBookmarksLiked(WorkflowValue<string> readFilterreadFilter = null)
        {
            WorkflowValue.Validate(readFilterreadFilter, nameof(readFilterreadFilter), required: false);
            return new DeferredBodyAction<BookmarksResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildListBookmarksArchived))]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksArchived([WorkflowExpression] Func<filterslikedFilterDefaultAllInput> filterslikedFilterDefaultAll = null, [WorkflowExpression] Func<filtersreadFilterDefaultAllInput> filtersreadFilterDefaultAll = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarksResponse> __BuildListBookmarksArchived(WorkflowValue<filterslikedFilterDefaultAllInput> filterslikedFilterDefaultAll = null, WorkflowValue<filtersreadFilterDefaultAllInput> filtersreadFilterDefaultAll = null)
        {
            WorkflowValue.Validate(filterslikedFilterDefaultAll, nameof(filterslikedFilterDefaultAll), required: false);
            WorkflowValue.Validate(filtersreadFilterDefaultAll, nameof(filtersreadFilterDefaultAll), required: false);
            return new DeferredBodyAction<BookmarksResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildListBookmarksInFolder))]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksInFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<likedFilterInput> likedFilter = null, [WorkflowExpression] Func<readFilterInput> readFilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarksResponse> __BuildListBookmarksInFolder(WorkflowValue<string> folderId, WorkflowValue<likedFilterInput> likedFilter = null, WorkflowValue<readFilterInput> readFilter = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(likedFilter, nameof(likedFilter), required: false);
            WorkflowValue.Validate(readFilter, nameof(readFilter), required: false);
            return new DeferredBodyAction<BookmarksResponse>(() =>
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildListHighlights))]
        public IBodyWorkflowAction<HighlighstResponse> ListHighlights([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlighstResponse> __BuildListHighlights(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<HighlighstResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/1.1/bookmarks/{0}/highlights", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HighlighstResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildUnlikeBookmark))]
        public IBodyWorkflowAction<BookmarkResponse> UnlikeBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarkResponse> __BuildUnlikeBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse>(() =>
            {
                var apiCallPath = "/1/bookmarks/unstar";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildLikeBookmark))]
        public IBodyWorkflowAction<BookmarkResponse> LikeBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarkResponse> __BuildLikeBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse>(() =>
            {
                var apiCallPath = "/1/bookmarks/star";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveBookmark))]
        public IBodyWorkflowAction<BookmarkResponse> ArchiveBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarkResponse> __BuildArchiveBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse>(() =>
            {
                var apiCallPath = "/1/bookmarks/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildUnarchiveBookmark))]
        public IBodyWorkflowAction<BookmarkResponse> UnarchiveBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookmarkResponse> __BuildUnarchiveBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<BookmarkResponse>(() =>
            {
                var apiCallPath = "/1/bookmarks/unarchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<BookmarkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBookmark))]
        public IBodyWorkflowAction<JToken> DeleteBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/1/bookmarks/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildMarkReadBookmark))]
        public IBodyWorkflowAction<JToken> MarkReadBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMarkReadBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildMarkUnreadBookmark))]
        public IBodyWorkflowAction<JToken> MarkUnreadBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMarkUnreadBookmark(WorkflowValue<string> bookmarkId)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/unread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = ExpressionConverter.Convert(bookmarkId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildAddHighlight))]
        public IBodyWorkflowAction<HighlightResponse> AddHighlight([WorkflowExpression] Func<string> bookmarkId, [WorkflowExpression] Func<string> text)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightResponse> __BuildAddHighlight(WorkflowValue<string> bookmarkId, WorkflowValue<string> text)
        {
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            WorkflowValue.Validate(text, nameof(text), required: true);
            return new DeferredBodyAction<HighlightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/1.1/bookmarks/{0}/highlight", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                return new ApiConnectionAction<HighlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<FolderResponse> CreateFolder([WorkflowExpression] Func<string> title)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderResponse> __BuildCreateFolder(WorkflowValue<string> title)
        {
            WorkflowValue.Validate(title, nameof(title), required: true);
            return new DeferredBodyAction<FolderResponse>(() =>
            {
                var apiCallPath = "/1/folders/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                return new ApiConnectionAction<FolderResponse>(callPayload);
            });
        }
    }

    public class InstapaperTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnBookmarkAdded))]
        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkAdded([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BookmarksResponse> __BuildOnBookmarkAdded(WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse>(() =>
            {
                var apiCallPath = "/bookmark_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnBookmarkRemoved))]
        public IBodyWorkflowTrigger<int[]> OnBookmarkRemoved([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<int[]> __BuildOnBookmarkRemoved(WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<int[]>(() =>
            {
                var apiCallPath = "/bookmark_removed_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionTrigger<int[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkArchived(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/bookmark_archive_trigger/1/bookmarks/list/archive";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkLiked(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/bookmark_starred_trigger/1/bookmarks/list/starred";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<BookmarksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FoldersResponse> OnFolderCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/folder_trigger/1/folders/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<FoldersResponse>(callPayload, triggerName, recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnBookmarkProgressUpdated))]
        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkProgressUpdated([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BookmarksResponse> __BuildOnBookmarkProgressUpdated(WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse>(() =>
            {
                var apiCallPath = "/bookmark_progress_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnBookmarkProgressRead))]
        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkProgressRead([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BookmarksResponse> __BuildOnBookmarkProgressRead(WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<BookmarksResponse>(() =>
            {
                var apiCallPath = "/bookmark_progressread_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionTrigger<BookmarksResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnHighlightAdded))]
        public IBodyWorkflowTrigger<HighlighstResponse> OnHighlightAdded([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bookmarkId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HighlighstResponse> __BuildOnHighlightAdded(WorkflowValue<string> folderId, WorkflowValue<string> bookmarkId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(bookmarkId, nameof(bookmarkId), required: true);
            return new DeferredBodyTrigger<HighlighstResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlight_added_trigger/1.1/bookmarks/{0}/highlights", ExpressionConverter.ConvertWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionTrigger<HighlighstResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
