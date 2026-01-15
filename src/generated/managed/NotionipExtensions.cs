//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Notionip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NotionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveuserResponse> Retrieveuser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveuserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<ListOfAllUsersResponse> ListOfAllUsers(Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page_size"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<ListOfAllUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveablockResponse> Retrieveablock(Expression<Func<string>> blockId)
        {
            var apiCallPath = String.Format("/blocks/{0}", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
            return new ApiConnectionAction<RetrieveablockResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DeleteablockResponse> Deleteablock(Expression<Func<string>> blockId)
        {
            var apiCallPath = String.Format("/blocks/{0}", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<DeleteablockResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction Updateablock(Expression<Func<string>> blockId, Expression<Func<bodyparagraphrichTextInputItem[]>> bodyparagraphrichText = null, Expression<Func<string>> bodyparagraphcolor = null, Expression<Func<bodyheading1richTextInputItem[]>> bodyheading1richText = null, Expression<Func<string>> bodyheading1color = null, Expression<Func<bodyheading2richTextInputItem[]>> bodyheading2richText = null, Expression<Func<string>> bodyheading2color = null, Expression<Func<bodyheading3richTextInputItem[]>> bodyheading3richText = null, Expression<Func<string>> bodyheading3color = null, Expression<Func<bodybulletedListItemrichTextInputItem[]>> bodybulletedListItemrichText = null, Expression<Func<string>> bodybulletedListItemcolor = null, Expression<Func<bodynumberedListItemrichTextInputItem[]>> bodynumberedListItemrichText = null, Expression<Func<string>> bodynumberedListItemcolor = null, Expression<Func<bodytoDorichTextInputItem[]>> bodytoDorichText = null, Expression<Func<bool>> bodytoDochecked = null, Expression<Func<string>> bodytoDocolor = null)
        {
            var apiCallPath = String.Format("/blocks/{0}", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
            var body = new JObject();
            var bodypropCount = 0;
            var paragraphObject = new JObject();
            var paragraphObjectpropCount = 0;
            if (bodyparagraphrichText != null)
            {
                paragraphObject["rich_text"] = ExpressionConverter.ConvertO(bodyparagraphrichText);
                paragraphObjectpropCount++;
            }

            if (bodyparagraphcolor != null)
            {
                paragraphObject["color"] = ExpressionConverter.ConvertO(bodyparagraphcolor);
                paragraphObjectpropCount++;
            }

            if (paragraphObjectpropCount > 0)
            {
                body["paragraph"] = paragraphObject;
                bodypropCount++;
            }

            var heading_1Object = new JObject();
            var heading_1ObjectpropCount = 0;
            if (bodyheading1richText != null)
            {
                heading_1Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading1richText);
                heading_1ObjectpropCount++;
            }

            if (bodyheading1color != null)
            {
                heading_1Object["color"] = ExpressionConverter.ConvertO(bodyheading1color);
                heading_1ObjectpropCount++;
            }

            if (heading_1ObjectpropCount > 0)
            {
                body["heading_1"] = heading_1Object;
                bodypropCount++;
            }

            var heading_2Object = new JObject();
            var heading_2ObjectpropCount = 0;
            if (bodyheading2richText != null)
            {
                heading_2Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading2richText);
                heading_2ObjectpropCount++;
            }

            if (bodyheading2color != null)
            {
                heading_2Object["color"] = ExpressionConverter.ConvertO(bodyheading2color);
                heading_2ObjectpropCount++;
            }

            if (heading_2ObjectpropCount > 0)
            {
                body["heading_2"] = heading_2Object;
                bodypropCount++;
            }

            var heading_3Object = new JObject();
            var heading_3ObjectpropCount = 0;
            if (bodyheading3richText != null)
            {
                heading_3Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading3richText);
                heading_3ObjectpropCount++;
            }

            if (bodyheading3color != null)
            {
                heading_3Object["color"] = ExpressionConverter.ConvertO(bodyheading3color);
                heading_3ObjectpropCount++;
            }

            if (heading_3ObjectpropCount > 0)
            {
                body["heading_3"] = heading_3Object;
                bodypropCount++;
            }

            var bulleted_list_itemObject = new JObject();
            var bulleted_list_itemObjectpropCount = 0;
            if (bodybulletedListItemrichText != null)
            {
                bulleted_list_itemObject["rich_text"] = ExpressionConverter.ConvertO(bodybulletedListItemrichText);
                bulleted_list_itemObjectpropCount++;
            }

            if (bodybulletedListItemcolor != null)
            {
                bulleted_list_itemObject["color"] = ExpressionConverter.ConvertO(bodybulletedListItemcolor);
                bulleted_list_itemObjectpropCount++;
            }

            if (bulleted_list_itemObjectpropCount > 0)
            {
                body["bulleted_list_item"] = bulleted_list_itemObject;
                bodypropCount++;
            }

            var numbered_list_itemObject = new JObject();
            var numbered_list_itemObjectpropCount = 0;
            if (bodynumberedListItemrichText != null)
            {
                numbered_list_itemObject["rich_text"] = ExpressionConverter.ConvertO(bodynumberedListItemrichText);
                numbered_list_itemObjectpropCount++;
            }

            if (bodynumberedListItemcolor != null)
            {
                numbered_list_itemObject["color"] = ExpressionConverter.ConvertO(bodynumberedListItemcolor);
                numbered_list_itemObjectpropCount++;
            }

            if (numbered_list_itemObjectpropCount > 0)
            {
                body["numbered_list_item"] = numbered_list_itemObject;
                bodypropCount++;
            }

            var to_doObject = new JObject();
            var to_doObjectpropCount = 0;
            if (bodytoDorichText != null)
            {
                to_doObject["rich_text"] = ExpressionConverter.ConvertO(bodytoDorichText);
                to_doObjectpropCount++;
            }

            if (bodytoDochecked != null)
            {
                to_doObject["checked"] = ExpressionConverter.ConvertO(bodytoDochecked);
                to_doObjectpropCount++;
            }

            if (bodytoDocolor != null)
            {
                to_doObject["color"] = ExpressionConverter.ConvertO(bodytoDocolor);
                to_doObjectpropCount++;
            }

            if (to_doObjectpropCount > 0)
            {
                body["to_do"] = to_doObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveBlockChildrenResponse> RetrieveBlockChildren(Expression<Func<string>> blockId, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/blocks/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page_size"] = Convert.ToString(100);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveBlockChildrenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction Appendblockchildren(Expression<Func<string>> blockId, Expression<Func<bodychildrenInputItem[]>> bodychildren = null)
        {
            var apiCallPath = String.Format("/blocks/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodychildren != null)
            {
                body["children"] = ExpressionConverter.ConvertO(bodychildren);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse> RetrieveADatabase(Expression<Func<string>> databaseId)
        {
            var apiCallPath = String.Format("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<DatabaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> bodyquery, Expression<Func<string>> bodysortdirection = null, Expression<Func<string>> bodysorttimestamp = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            var sortObject = new JObject();
            var sortObjectpropCount = 0;
            if (bodysortdirection != null)
            {
                sortObject["direction"] = ExpressionConverter.ConvertO(bodysortdirection);
                sortObjectpropCount++;
            }

            if (bodysorttimestamp != null)
            {
                sortObject["timestamp"] = ExpressionConverter.ConvertO(bodysorttimestamp);
                sortObjectpropCount++;
            }

            if (sortObjectpropCount > 0)
            {
                body["sort"] = sortObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse> QueryADatabase(Expression<Func<string>> databaseId)
        {
            var apiCallPath = String.Format("/databases/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<DatabaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveYourTokensBotUserResponse> RetrieveYourTokensBotUser()
        {
            var apiCallPath = "/v1/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveYourTokensBotUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapagepropertyitemResponse> Retrieveapagepropertyitem(Expression<Func<string>> pageId, Expression<Func<string>> propertyId)
        {
            var apiCallPath = String.Format("/pages/{0}/properties/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(propertyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveapagepropertyitemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapageResponse> Retrieveapage(Expression<Func<string>> pageId)
        {
            var apiCallPath = String.Format("/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveapageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Retrievecomments(Expression<Func<string>> blockId)
        {
            var apiCallPath = "/comments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["block_id"] = ExpressionConverter.Convert(blockId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<CommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Createcomment(Expression<Func<string>> bodyparentpageId = null, Expression<Func<string>> bodydiscussionId = null, Expression<Func<bodyrichTextInputItem[]>> bodyrichText = null)
        {
            var apiCallPath = "/comments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            var body = new JObject();
            var bodypropCount = 0;
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyparentpageId != null)
            {
                parentObject["page_id"] = ExpressionConverter.ConvertO(bodyparentpageId);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                body["parent"] = parentObject;
                bodypropCount++;
            }

            if (bodydiscussionId != null)
            {
                body["discussion_id"] = ExpressionConverter.ConvertO(bodydiscussionId);
                bodypropCount++;
            }

            if (bodyrichText != null)
            {
                body["rich_text"] = ExpressionConverter.ConvertO(bodyrichText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommentResponse>(callPayload);
        }
    }

    public class NotionipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrieveuserResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
        public string Object { get; set; }

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
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RetrieveablockResponseLastEditedByType
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteablockResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteablockResponseLastEditedByType
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyparagraphrichTextInputItem
    {
        [JsonProperty("text")]
        public bodyparagraphrichTextInputItemTextType Text { get; set; }
    }

    public class bodyparagraphrichTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodyheading1richTextInputItem
    {
        [JsonProperty("text")]
        public bodyheading1richTextInputItemTextType Text { get; set; }
    }

    public class bodyheading1richTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodyheading2richTextInputItem
    {
        [JsonProperty("text")]
        public bodyheading2richTextInputItemTextType Text { get; set; }
    }

    public class bodyheading2richTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodyheading3richTextInputItem
    {
        [JsonProperty("text")]
        public bodyheading3richTextInputItemTextType Text { get; set; }
    }

    public class bodyheading3richTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodybulletedListItemrichTextInputItem
    {
        [JsonProperty("text")]
        public bodybulletedListItemrichTextInputItemTextType Text { get; set; }
    }

    public class bodybulletedListItemrichTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodynumberedListItemrichTextInputItem
    {
        [JsonProperty("text")]
        public bodynumberedListItemrichTextInputItemTextType Text { get; set; }
    }

    public class bodynumberedListItemrichTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodytoDorichTextInputItem
    {
        [JsonProperty("text")]
        public bodytoDorichTextInputItemTextType Text { get; set; }
    }

    public class bodytoDorichTextInputItemTextType
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
        public string Object { get; set; }

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

    public class bodychildrenInputItem
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("heading_1")]
        public bodychildrenInputItemHeading1Type Heading1 { get; set; }

        [JsonProperty("paragraph")]
        public bodychildrenInputItemParagraphType Paragraph { get; set; }
    }

    public class bodychildrenInputItemHeading1Type
    {
        [JsonProperty("rich_text")]
        public bodychildrenInputItemHeading1TypeRichTextTypeItem[] RichText { get; set; }
    }

    public class bodychildrenInputItemHeading1TypeRichTextTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public bodychildrenInputItemHeading1TypeRichTextTypeItemTextType Text { get; set; }
    }

    public class bodychildrenInputItemHeading1TypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class bodychildrenInputItemParagraphType
    {
        [JsonProperty("rich_text")]
        public bodychildrenInputItemParagraphTypeRichTextTypeItem[] RichText { get; set; }
    }

    public class bodychildrenInputItemParagraphTypeRichTextTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public bodychildrenInputItemParagraphTypeRichTextTypeItemTextType Text { get; set; }
    }

    public class bodychildrenInputItemParagraphTypeRichTextTypeItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("link")]
        public bodychildrenInputItemParagraphTypeRichTextTypeItemTextTypeLinkType Link { get; set; }
    }

    public class bodychildrenInputItemParagraphTypeRichTextTypeItemTextTypeLinkType
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
        public string Object { get; set; }

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
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DatabaseResponseResultsTypeItemLastEditedByType
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
        public string Object { get; set; }

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
        public string Object { get; set; }

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

    public class bodyrichTextInputItem
    {
        [JsonProperty("text")]
        public bodyrichTextInputItemTextType Text { get; set; }
    }

    public class bodyrichTextInputItemTextType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Notionip;

    public partial class WorkflowManagedActions
    {
        public NotionipActions Notionip(string connectionId) => new NotionipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NotionipTriggers Notionip(string connectionId) => new NotionipTriggers(connectionId);
    }
}