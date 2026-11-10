//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Notionip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NotionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveuserResponse, ApiConnectionActionConfiguration> Retrieveuser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<RetrieveuserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<RetrieveuserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<ListOfAllUsersResponse, ApiConnectionActionConfiguration> ListOfAllUsers(Expression<Func<int>> pageSize = null)
        {
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<ListOfAllUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<ListOfAllUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveablockResponse, ApiConnectionActionConfiguration> Retrieveablock(Expression<Func<string>> blockId)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            return new DeferredBodyAction<RetrieveablockResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blocks/{0}", __workflow_blockId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
                return new ApiConnectionAction<RetrieveablockResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DeleteablockResponse, ApiConnectionActionConfiguration> Deleteablock(Expression<Func<string>> blockId)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            return new DeferredBodyAction<DeleteablockResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blocks/{0}", __workflow_blockId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<DeleteablockResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Updateablock(Expression<Func<string>> blockId, Expression<Func<UpdateablockBodyInput>> body = null)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blocks/{0}", __workflow_blockId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveBlockChildrenResponse, ApiConnectionActionConfiguration> RetrieveBlockChildren(Expression<Func<string>> blockId, Expression<Func<int>> pageSize = null)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<RetrieveBlockChildrenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blocks/{0}/children", __workflow_blockId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<RetrieveBlockChildrenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Appendblockchildren(Expression<Func<string>> blockId, Expression<Func<AppendblockchildrenBodyInput>> body)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blocks/{0}/children", __workflow_blockId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse, ApiConnectionActionConfiguration> RetrieveADatabase(Expression<Func<string>> databaseId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            return new DeferredBodyAction<DatabaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/databases/{0}", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<DatabaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<SearchResponse, ApiConnectionActionConfiguration> Search(Expression<Func<SearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse, ApiConnectionActionConfiguration> QueryADatabase(Expression<Func<string>> databaseId)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            return new DeferredBodyAction<DatabaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/databases/{0}/query", __workflow_databaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DatabaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveYourTokensBotUserResponse, ApiConnectionActionConfiguration> RetrieveYourTokensBotUser()
        {
            return new DeferredBodyAction<RetrieveYourTokensBotUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<RetrieveYourTokensBotUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapagepropertyitemResponse, ApiConnectionActionConfiguration> Retrieveapagepropertyitem(Expression<Func<string>> pageId, Expression<Func<string>> propertyId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: true);
            return new DeferredBodyAction<RetrieveapagepropertyitemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/{0}/properties/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_propertyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<RetrieveapagepropertyitemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapageResponse, ApiConnectionActionConfiguration> Retrieveapage(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<RetrieveapageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<RetrieveapageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CreateaPageResponse, ApiConnectionActionConfiguration> CreateaPage(Expression<Func<CreateaPageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateaPageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateaPageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse, ApiConnectionActionConfiguration> Retrievecomments(Expression<Func<string>> blockId)
        {
            var __workflow_blockId = WorkflowExpression.Compile(blockId, nameof(blockId), required: true);
            return new DeferredBodyAction<CommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["block_id"] = ExpressionConverter.Convert(__workflow_blockId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return new ApiConnectionAction<CommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse, ApiConnectionActionConfiguration> Createcomment(Expression<Func<CreatecommentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommentResponse>(callPayload);
            });
        }
    }

    public class NotionipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrieveuserResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ListOfAllUsersResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
        public JToken Bot { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class RetrieveablockResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public RetrieveablockResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public RetrieveablockResponseLastEditedByType LastEditedBy { get; set; }

        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RetrieveablockResponseCreatedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RetrieveablockResponseLastEditedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteablockResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public DeleteablockResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public DeleteablockResponseLastEditedByType LastEditedBy { get; set; }

        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DeleteablockResponseCreatedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteablockResponseLastEditedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateablockBodyInput
    {
        [JsonProperty("paragraph")]
        public BodyInputParagraphType Paragraph { get; set; }

        [JsonProperty("heading_1")]
        public BodyInputHeading1Type Heading1 { get; set; }

        [JsonProperty("heading_2")]
        public BodyInputHeading2Type Heading2 { get; set; }

        [JsonProperty("heading_3")]
        public BodyInputHeading3Type Heading3 { get; set; }

        [JsonProperty("bulleted_list_item")]
        public BodyInputBulletedListItemType BulletedListItem { get; set; }

        [JsonProperty("numbered_list_item")]
        public BodyInputNumberedListItemType NumberedListItem { get; set; }

        [JsonProperty("to_do")]
        public BodyInputToDoType ToDo { get; set; }
    }

    public class BodyInputParagraphType
    {
        [JsonProperty("rich_text")]
        public BodyInputParagraphTypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputParagraphTypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputParagraphTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputParagraphTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputHeading1Type
    {
        [JsonProperty("rich_text")]
        public BodyInputHeading1TypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputHeading1TypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputHeading1TypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputHeading1TypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputHeading2Type
    {
        [JsonProperty("rich_text")]
        public BodyInputHeading2TypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputHeading2TypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputHeading2TypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputHeading2TypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputHeading3Type
    {
        [JsonProperty("rich_text")]
        public BodyInputHeading3TypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputHeading3TypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputHeading3TypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputHeading3TypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputBulletedListItemType
    {
        [JsonProperty("rich_text")]
        public BodyInputBulletedListItemTypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputBulletedListItemTypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputBulletedListItemTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputBulletedListItemTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputNumberedListItemType
    {
        [JsonProperty("rich_text")]
        public BodyInputNumberedListItemTypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputNumberedListItemTypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputNumberedListItemTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputNumberedListItemTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputToDoType
    {
        [JsonProperty("rich_text")]
        public BodyInputToDoTypeRichTextTypeItem[] RichText { get; set; }

        [JsonProperty("checked")]
        public bool? Checked { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class BodyInputToDoTypeRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputToDoTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputToDoTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class RetrieveBlockChildrenResponse
    {
        [JsonProperty("items")]
        public RetrieveBlockChildrenResponseItemsType Items { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class RetrieveBlockChildrenResponseItemsType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AppendblockchildrenBodyInput
    {
        [JsonProperty("children")]
        public BodyInputChildrenTypeItem[] Children { get; set; }
    }

    public class BodyInputChildrenTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("heading_1")]
        public BodyInputChildrenTypeItemHeading1Type Heading1 { get; set; }

        [JsonProperty("paragraph")]
        public BodyInputChildrenTypeItemParagraphType Paragraph { get; set; }
    }

    public class BodyInputChildrenTypeItemHeading1Type
    {
        [JsonProperty("rich_text")]
        public BodyInputChildrenTypeItemHeading1TypeRichTextTypeItem[] RichText { get; set; }
    }

    public class BodyInputChildrenTypeItemHeading1TypeRichTextTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public BodyInputChildrenTypeItemHeading1TypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputChildrenTypeItemHeading1TypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class BodyInputChildrenTypeItemParagraphType
    {
        [JsonProperty("rich_text")]
        public BodyInputChildrenTypeItemParagraphTypeRichTextTypeItem[] RichText { get; set; }
    }

    public class BodyInputChildrenTypeItemParagraphTypeRichTextTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public BodyInputChildrenTypeItemParagraphTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputChildrenTypeItemParagraphTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("link")]
        public BodyInputChildrenTypeItemParagraphTypeRichTextTypeItemTextTypeLinkType Link { get; set; }
    }

    public class BodyInputChildrenTypeItemParagraphTypeRichTextTypeItemTextTypeLinkType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DatabaseResponse
    {
        [JsonProperty("results")]
        public DatabaseResponseResultsTypeItem[] Results { get; set; }
    }

    public class DatabaseResponseResultsTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public DatabaseResponseResultsTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public DatabaseResponseResultsTypeItemLastEditedByType LastEditedBy { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DatabaseResponseResultsTypeItemCreatedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DatabaseResponseResultsTypeItemLastEditedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }
        public JToken Tags { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class SearchBodyInput
    {
        public SearchBodyInput(string query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("sort")]
        public BodyInputSortType Sort { get; set; }
    }

    public class BodyInputSortType
    {
        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RetrieveYourTokensBotUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bot")]
        public RetrieveYourTokensBotUserResponseBotType Bot { get; set; }
    }

    public class RetrieveYourTokensBotUserResponseBotType
    {
        [JsonProperty("owner")]
        public RetrieveYourTokensBotUserResponseBotTypeOwnerType Owner { get; set; }
    }

    public class RetrieveYourTokensBotUserResponseBotTypeOwnerType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RetrieveapagepropertyitemResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class RetrieveapageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public RetrieveapageResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public RetrieveapageResponseLastEditedByType LastEditedBy { get; set; }

        [JsonProperty("cover")]
        public RetrieveapageResponseCoverType Cover { get; set; }

        [JsonProperty("icon")]
        public RetrieveapageResponseIconType Icon { get; set; }

        [JsonProperty("parent")]
        public RetrieveapageResponseParentType Parent { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class RetrieveapageResponseCreatedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RetrieveapageResponseLastEditedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RetrieveapageResponseCoverType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class RetrieveapageResponseIconType
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }

    public class RetrieveapageResponseParentType
    {
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }
    }

    public class CreateaPageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public CreateaPageResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("last_edited_by")]
        public CreateaPageResponseLastEditedByType LastEditedBy { get; set; }

        [JsonProperty("cover")]
        public CreateaPageResponseCoverType Cover { get; set; }

        [JsonProperty("icon")]
        public CreateaPageResponseIconType Icon { get; set; }

        [JsonProperty("parent")]
        public CreateaPageResponseParentType Parent { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateaPageResponseCreatedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateaPageResponseLastEditedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateaPageResponseCoverType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateaPageResponseIconType
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }

    public class CreateaPageResponseParentType
    {
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }
    }

    public class CreateaPageBodyInput
    {
        public CreateaPageBodyInput(CreateaPageBodyInputParentType parent)
        {
            this.Parent = parent;
        }

        [JsonProperty("parent", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateaPageBodyInputParentType Parent { get; set; }

        [JsonProperty("icon")]
        public BodyInputIconType Icon { get; set; }

        [JsonProperty("cover")]
        public BodyInputCoverType Cover { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class CreateaPageBodyInputParentType
    {
        public CreateaPageBodyInputParentType(string databaseId)
        {
            this.DatabaseId = databaseId;
        }

        [JsonProperty("database_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DatabaseId { get; set; }
    }

    public class BodyInputIconType
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }

    public class BodyInputCoverType
    {
        [JsonProperty("external")]
        public BodyInputCoverTypeExternalType External { get; set; }
    }

    public class BodyInputCoverTypeExternalType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public CommentResponseParentType Parent { get; set; }

        [JsonProperty("discussion_id")]
        public string DiscussionId { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("created_by")]
        public CommentResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("rich_text")]
        public CommentResponseRichTextTypeItem[] RichText { get; set; }
    }

    public class CommentResponseParentType
    {
        [JsonProperty("page_id")]
        public string PageId { get; set; }
    }

    public class CommentResponseCreatedByType
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CommentResponseRichTextTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public CommentResponseRichTextTypeItemTextType Text { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class CommentResponseRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreatecommentBodyInput
    {
        [JsonProperty("parent")]
        public CreatecommentBodyInputParentType Parent { get; set; }

        [JsonProperty("discussion_id")]
        public string DiscussionId { get; set; }

        [JsonProperty("rich_text")]
        public BodyInputRichTextTypeItem[] RichText { get; set; }
    }

    public class CreatecommentBodyInputParentType
    {
        [JsonProperty("page_id")]
        public string PageId { get; set; }
    }

    public class BodyInputRichTextTypeItem
    {
        [JsonProperty("text")]
        public BodyInputRichTextTypeItemTextType Text { get; set; }
    }

    public class BodyInputRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Notionip;

    public partial class WorkflowManagedActions
    {
        public NotionipActions Notionip(string connectionId) => new NotionipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NotionipTriggers Notionip(string connectionId) => new NotionipTriggers(connectionId);
    }
}