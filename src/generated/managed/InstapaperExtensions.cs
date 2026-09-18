//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instapaper
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstapaperActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksLiked([WorkflowExpression] Func<string> readFilterreadFilter = null)
        {
            SourceExpression.Validate(readFilterreadFilter, nameof(readFilterreadFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/list/starred";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var readFilter = new JObject();
                var readFilterpropCount = 0;
                if (readFilterreadFilter != null)
                {
                    readFilter["readFilter"] = SourceExpressionConverter.ConvertToken(readFilterreadFilter);
                    readFilterpropCount++;
                }

                if (readFilterpropCount > 0)
                {
                    callPayload.Body = readFilter;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BookmarksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksArchived([WorkflowExpression] Func<filterslikedFilterDefaultAllInput> filterslikedFilterDefaultAll = null, [WorkflowExpression] Func<filtersreadFilterDefaultAllInput> filtersreadFilterDefaultAll = null)
        {
            SourceExpression.Validate(filterslikedFilterDefaultAll, nameof(filterslikedFilterDefaultAll), required: false);
            SourceExpression.Validate(filtersreadFilterDefaultAll, nameof(filtersreadFilterDefaultAll), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/list/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filters = new JObject();
                var filterspropCount = 0;
                if (filterslikedFilterDefaultAll != null)
                {
                    filters["likedFilter"] = SourceExpressionConverter.Convert(filterslikedFilterDefaultAll);
                    filterspropCount++;
                }

                if (filtersreadFilterDefaultAll != null)
                {
                    filters["readFilter"] = SourceExpressionConverter.Convert(filtersreadFilterDefaultAll);
                    filterspropCount++;
                }

                if (filterspropCount > 0)
                {
                    callPayload.Body = filters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BookmarksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarksResponse> ListBookmarksInFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<likedFilterInput> likedFilter = null, [WorkflowExpression] Func<readFilterInput> readFilter = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(likedFilter, nameof(likedFilter), required: false);
            SourceExpression.Validate(readFilter, nameof(readFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                if (likedFilter != null)
                    callPayload.Queries["likedFilter"] = SourceExpressionConverter.Convert(likedFilter);
                if (readFilter != null)
                    callPayload.Queries["readFilter"] = SourceExpressionConverter.Convert(readFilter);
                return callPayload;
            }

            return new ApiConnectionAction<BookmarksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FoldersResponse> ListFolders()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/folders/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FoldersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlighstResponse> ListHighlights([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.1/bookmarks/{0}/highlights", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HighlighstResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> UnlikeBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/unstar";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<BookmarkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> LikeBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/star";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<BookmarkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> ArchiveBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<BookmarkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<BookmarkResponse> UnarchiveBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/unarchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<BookmarkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> DeleteBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> MarkReadBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/read";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<JToken> MarkUnreadBookmark([WorkflowExpression] Func<string> bookmarkId)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/bookmarks/update_read_progress/unread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bookmark_id"] = SourceExpressionConverter.ConvertO(bookmarkId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<HighlightResponse> AddHighlight([WorkflowExpression] Func<string> bookmarkId, [WorkflowExpression] Func<string> text)
        {
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            SourceExpression.Validate(text, nameof(text), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.1/bookmarks/{0}/highlight", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                return callPayload;
            }

            return new ApiConnectionAction<HighlightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instapaper")]
        public IBodyWorkflowAction<FolderResponse> CreateFolder([WorkflowExpression] Func<string> title)
        {
            SourceExpression.Validate(title, nameof(title), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/folders/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                return callPayload;
            }

            return new ApiConnectionAction<FolderResponse>(BuildSourceInput);
        }
    }

    public class InstapaperTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkAdded([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<BookmarksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int[]> OnBookmarkRemoved([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_removed_folder_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<int[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkArchived(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_archive_trigger/1/bookmarks/list/archive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<BookmarksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkLiked(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_starred_trigger/1/bookmarks/list/starred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<BookmarksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FoldersResponse> OnFolderCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/folder_trigger/1/folders/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<FoldersResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkProgressUpdated([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_progress_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<BookmarksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BookmarksResponse> OnBookmarkProgressRead([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookmark_progressread_trigger/1/bookmarks/list/folder_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<BookmarksResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<HighlighstResponse> OnHighlightAdded([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bookmarkId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(bookmarkId, nameof(bookmarkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlight_added_trigger/1.1/bookmarks/{0}/highlights", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookmarkId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folder_id"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionTrigger<HighlighstResponse>(BuildSourceInput, triggerName, recurrence);
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