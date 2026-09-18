//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Notionip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NotionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveuserResponse> Retrieveuser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userId)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveuserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<ListOfAllUsersResponse> ListOfAllUsers([WorkflowExpression] Func<int> pageSize = null)
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
        public IBodyWorkflowAction<RetrieveablockResponse> Retrieveablock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> blockId)
        {
            var apiCallPath = String.Format("/blocks/{0}", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
            return new ApiConnectionAction<RetrieveablockResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DeleteablockResponse> Deleteablock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> blockId)
        {
            var apiCallPath = String.Format("/blocks/{0}", ExpressionConverter.ConvertWithUrlEncoding(blockId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<DeleteablockResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction Updateablock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> blockId, [WorkflowExpression] Func<bodyparagraphrichTextInputItem[]> bodyparagraphrichText = null, [WorkflowExpression] Func<string> bodyparagraphcolor = null, [WorkflowExpression] Func<bodyheading1richTextInputItem[]> bodyheading1richText = null, [WorkflowExpression] Func<string> bodyheading1color = null, [WorkflowExpression] Func<bodyheading2richTextInputItem[]> bodyheading2richText = null, [WorkflowExpression] Func<string> bodyheading2color = null, [WorkflowExpression] Func<bodyheading3richTextInputItem[]> bodyheading3richText = null, [WorkflowExpression] Func<string> bodyheading3color = null, [WorkflowExpression] Func<bodybulletedListItemrichTextInputItem[]> bodybulletedListItemrichText = null, [WorkflowExpression] Func<string> bodybulletedListItemcolor = null, [WorkflowExpression] Func<bodynumberedListItemrichTextInputItem[]> bodynumberedListItemrichText = null, [WorkflowExpression] Func<string> bodynumberedListItemcolor = null, [WorkflowExpression] Func<bodytoDorichTextInputItem[]> bodytoDorichText = null, [WorkflowExpression] Func<bool> bodytoDochecked = null, [WorkflowExpression] Func<string> bodytoDocolor = null)
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

            var heading1Object = new JObject();
            var heading1ObjectpropCount = 0;
            if (bodyheading1richText != null)
            {
                heading1Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading1richText);
                heading1ObjectpropCount++;
            }

            if (bodyheading1color != null)
            {
                heading1Object["color"] = ExpressionConverter.ConvertO(bodyheading1color);
                heading1ObjectpropCount++;
            }

            if (heading1ObjectpropCount > 0)
            {
                body["heading_1"] = heading1Object;
                bodypropCount++;
            }

            var heading2Object = new JObject();
            var heading2ObjectpropCount = 0;
            if (bodyheading2richText != null)
            {
                heading2Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading2richText);
                heading2ObjectpropCount++;
            }

            if (bodyheading2color != null)
            {
                heading2Object["color"] = ExpressionConverter.ConvertO(bodyheading2color);
                heading2ObjectpropCount++;
            }

            if (heading2ObjectpropCount > 0)
            {
                body["heading_2"] = heading2Object;
                bodypropCount++;
            }

            var heading3Object = new JObject();
            var heading3ObjectpropCount = 0;
            if (bodyheading3richText != null)
            {
                heading3Object["rich_text"] = ExpressionConverter.ConvertO(bodyheading3richText);
                heading3ObjectpropCount++;
            }

            if (bodyheading3color != null)
            {
                heading3Object["color"] = ExpressionConverter.ConvertO(bodyheading3color);
                heading3ObjectpropCount++;
            }

            if (heading3ObjectpropCount > 0)
            {
                body["heading_3"] = heading3Object;
                bodypropCount++;
            }

            var bulletedListItemObject = new JObject();
            var bulletedListItemObjectpropCount = 0;
            if (bodybulletedListItemrichText != null)
            {
                bulletedListItemObject["rich_text"] = ExpressionConverter.ConvertO(bodybulletedListItemrichText);
                bulletedListItemObjectpropCount++;
            }

            if (bodybulletedListItemcolor != null)
            {
                bulletedListItemObject["color"] = ExpressionConverter.ConvertO(bodybulletedListItemcolor);
                bulletedListItemObjectpropCount++;
            }

            if (bulletedListItemObjectpropCount > 0)
            {
                body["bulleted_list_item"] = bulletedListItemObject;
                bodypropCount++;
            }

            var numberedListItemObject = new JObject();
            var numberedListItemObjectpropCount = 0;
            if (bodynumberedListItemrichText != null)
            {
                numberedListItemObject["rich_text"] = ExpressionConverter.ConvertO(bodynumberedListItemrichText);
                numberedListItemObjectpropCount++;
            }

            if (bodynumberedListItemcolor != null)
            {
                numberedListItemObject["color"] = ExpressionConverter.ConvertO(bodynumberedListItemcolor);
                numberedListItemObjectpropCount++;
            }

            if (numberedListItemObjectpropCount > 0)
            {
                body["numbered_list_item"] = numberedListItemObject;
                bodypropCount++;
            }

            var toDoObject = new JObject();
            var toDoObjectpropCount = 0;
            if (bodytoDorichText != null)
            {
                toDoObject["rich_text"] = ExpressionConverter.ConvertO(bodytoDorichText);
                toDoObjectpropCount++;
            }

            if (bodytoDochecked != null)
            {
                toDoObject["checked"] = ExpressionConverter.ConvertO(bodytoDochecked);
                toDoObjectpropCount++;
            }

            if (bodytoDocolor != null)
            {
                toDoObject["color"] = ExpressionConverter.ConvertO(bodytoDocolor);
                toDoObjectpropCount++;
            }

            if (toDoObjectpropCount > 0)
            {
                body["to_do"] = toDoObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveBlockChildrenResponse> RetrieveBlockChildren([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> blockId, [WorkflowExpression] Func<int> pageSize = null)
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
        public IWorkflowAction Appendblockchildren([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> blockId, [WorkflowExpression] Func<bodychildrenInputItem[]> bodychildren = null)
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
        public IBodyWorkflowAction<DatabaseResponse> RetrieveADatabase([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> databaseId)
        {
            var apiCallPath = String.Format("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<DatabaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodysortdirection = null, [WorkflowExpression] Func<string> bodysorttimestamp = null)
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
        public IBodyWorkflowAction<DatabaseResponse> QueryADatabase([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> databaseId)
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
        public IBodyWorkflowAction<RetrieveapagepropertyitemResponse> Retrieveapagepropertyitem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pageId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> propertyId)
        {
            var apiCallPath = String.Format("/pages/{0}/properties/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(propertyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveapagepropertyitemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapageResponse> Retrieveapage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pageId)
        {
            var apiCallPath = String.Format("/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<RetrieveapageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CreateaPageResponse> CreateaPage([WorkflowExpression] Func<string> bodyparentdatabaseId = null, [WorkflowExpression] Func<string> bodyiconemoji = null, [WorkflowExpression] Func<string> bodycoverexternalurl = null)
        {
            var apiCallPath = "/pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            var body = new JObject();
            var bodypropCount = 0;
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyparentdatabaseId != null)
            {
                parentObject["database_id"] = ExpressionConverter.ConvertO(bodyparentdatabaseId);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                body["parent"] = parentObject;
                bodypropCount++;
            }

            var iconObject = new JObject();
            var iconObjectpropCount = 0;
            if (bodyiconemoji != null)
            {
                iconObject["emoji"] = ExpressionConverter.ConvertO(bodyiconemoji);
                iconObjectpropCount++;
            }

            if (iconObjectpropCount > 0)
            {
                body["icon"] = iconObject;
                bodypropCount++;
            }

            var coverObject = new JObject();
            var coverObjectpropCount = 0;
            var externalObject = new JObject();
            var externalObjectpropCount = 0;
            if (bodycoverexternalurl != null)
            {
                externalObject["url"] = ExpressionConverter.ConvertO(bodycoverexternalurl);
                externalObjectpropCount++;
            }

            if (externalObjectpropCount > 0)
            {
                coverObject["external"] = externalObject;
                coverObjectpropCount++;
            }

            if (coverObjectpropCount > 0)
            {
                body["cover"] = coverObject;
                bodypropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                body["properties"] = propertiesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateaPageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Retrievecomments([WorkflowExpression] Func<string> blockId)
        {
            var apiCallPath = "/comments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["block_id"] = ExpressionConverter.Convert(blockId);
            callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
            return new ApiConnectionAction<CommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Createcomment([WorkflowExpression] Func<string> bodyparentpageId = null, [WorkflowExpression] Func<string> bodydiscussionId = null, [WorkflowExpression] Func<bodyrichTextInputItem[]> bodyrichText = null)
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

    public class bodychildrenInputItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

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