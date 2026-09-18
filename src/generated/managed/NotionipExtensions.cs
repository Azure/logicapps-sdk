//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Notionip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NotionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveuserResponse> Retrieveuser([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveuserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<ListOfAllUsersResponse> ListOfAllUsers([WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<ListOfAllUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveablockResponse> Retrieveablock([WorkflowExpression] Func<string> blockId)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blocks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blockId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-02-22");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveablockResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DeleteablockResponse> Deleteablock([WorkflowExpression] Func<string> blockId)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blocks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blockId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<DeleteablockResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction Updateablock([WorkflowExpression] Func<string> blockId, [WorkflowExpression] Func<bodyparagraphrichTextInputItem[]> bodyparagraphrichText = null, [WorkflowExpression] Func<string> bodyparagraphcolor = null, [WorkflowExpression] Func<bodyheading1richTextInputItem[]> bodyheading1richText = null, [WorkflowExpression] Func<string> bodyheading1color = null, [WorkflowExpression] Func<bodyheading2richTextInputItem[]> bodyheading2richText = null, [WorkflowExpression] Func<string> bodyheading2color = null, [WorkflowExpression] Func<bodyheading3richTextInputItem[]> bodyheading3richText = null, [WorkflowExpression] Func<string> bodyheading3color = null, [WorkflowExpression] Func<bodybulletedListItemrichTextInputItem[]> bodybulletedListItemrichText = null, [WorkflowExpression] Func<string> bodybulletedListItemcolor = null, [WorkflowExpression] Func<bodynumberedListItemrichTextInputItem[]> bodynumberedListItemrichText = null, [WorkflowExpression] Func<string> bodynumberedListItemcolor = null, [WorkflowExpression] Func<bodytoDorichTextInputItem[]> bodytoDorichText = null, [WorkflowExpression] Func<bool> bodytoDochecked = null, [WorkflowExpression] Func<string> bodytoDocolor = null)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            SourceExpression.Validate(bodyparagraphrichText, nameof(bodyparagraphrichText), required: false);
            SourceExpression.Validate(bodyparagraphcolor, nameof(bodyparagraphcolor), required: false);
            SourceExpression.Validate(bodyheading1richText, nameof(bodyheading1richText), required: false);
            SourceExpression.Validate(bodyheading1color, nameof(bodyheading1color), required: false);
            SourceExpression.Validate(bodyheading2richText, nameof(bodyheading2richText), required: false);
            SourceExpression.Validate(bodyheading2color, nameof(bodyheading2color), required: false);
            SourceExpression.Validate(bodyheading3richText, nameof(bodyheading3richText), required: false);
            SourceExpression.Validate(bodyheading3color, nameof(bodyheading3color), required: false);
            SourceExpression.Validate(bodybulletedListItemrichText, nameof(bodybulletedListItemrichText), required: false);
            SourceExpression.Validate(bodybulletedListItemcolor, nameof(bodybulletedListItemcolor), required: false);
            SourceExpression.Validate(bodynumberedListItemrichText, nameof(bodynumberedListItemrichText), required: false);
            SourceExpression.Validate(bodynumberedListItemcolor, nameof(bodynumberedListItemcolor), required: false);
            SourceExpression.Validate(bodytoDorichText, nameof(bodytoDorichText), required: false);
            SourceExpression.Validate(bodytoDochecked, nameof(bodytoDochecked), required: false);
            SourceExpression.Validate(bodytoDocolor, nameof(bodytoDocolor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blocks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blockId, 1));
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
                    paragraphObject["rich_text"] = SourceExpressionConverter.ConvertToken(bodyparagraphrichText);
                    paragraphObjectpropCount++;
                }

                if (bodyparagraphcolor != null)
                {
                    paragraphObject["color"] = SourceExpressionConverter.ConvertToken(bodyparagraphcolor);
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
                    heading1Object["rich_text"] = SourceExpressionConverter.ConvertToken(bodyheading1richText);
                    heading1ObjectpropCount++;
                }

                if (bodyheading1color != null)
                {
                    heading1Object["color"] = SourceExpressionConverter.ConvertToken(bodyheading1color);
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
                    heading2Object["rich_text"] = SourceExpressionConverter.ConvertToken(bodyheading2richText);
                    heading2ObjectpropCount++;
                }

                if (bodyheading2color != null)
                {
                    heading2Object["color"] = SourceExpressionConverter.ConvertToken(bodyheading2color);
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
                    heading3Object["rich_text"] = SourceExpressionConverter.ConvertToken(bodyheading3richText);
                    heading3ObjectpropCount++;
                }

                if (bodyheading3color != null)
                {
                    heading3Object["color"] = SourceExpressionConverter.ConvertToken(bodyheading3color);
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
                    bulletedListItemObject["rich_text"] = SourceExpressionConverter.ConvertToken(bodybulletedListItemrichText);
                    bulletedListItemObjectpropCount++;
                }

                if (bodybulletedListItemcolor != null)
                {
                    bulletedListItemObject["color"] = SourceExpressionConverter.ConvertToken(bodybulletedListItemcolor);
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
                    numberedListItemObject["rich_text"] = SourceExpressionConverter.ConvertToken(bodynumberedListItemrichText);
                    numberedListItemObjectpropCount++;
                }

                if (bodynumberedListItemcolor != null)
                {
                    numberedListItemObject["color"] = SourceExpressionConverter.ConvertToken(bodynumberedListItemcolor);
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
                    toDoObject["rich_text"] = SourceExpressionConverter.ConvertToken(bodytoDorichText);
                    toDoObjectpropCount++;
                }

                if (bodytoDochecked != null)
                {
                    toDoObject["checked"] = SourceExpressionConverter.ConvertToken(bodytoDochecked);
                    toDoObjectpropCount++;
                }

                if (bodytoDocolor != null)
                {
                    toDoObject["color"] = SourceExpressionConverter.ConvertToken(bodytoDocolor);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveBlockChildrenResponse> RetrieveBlockChildren([WorkflowExpression] Func<string> blockId, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blocks/{0}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blockId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveBlockChildrenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IWorkflowAction Appendblockchildren([WorkflowExpression] Func<string> blockId, [WorkflowExpression] Func<bodychildrenInputItem[]> bodychildren = null)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            SourceExpression.Validate(bodychildren, nameof(bodychildren), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blocks/{0}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blockId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychildren != null)
                {
                    body["children"] = SourceExpressionConverter.ConvertToken(bodychildren);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse> RetrieveADatabase([WorkflowExpression] Func<string> databaseId)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/databases/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<DatabaseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodysortdirection = null, [WorkflowExpression] Func<string> bodysorttimestamp = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodysortdirection, nameof(bodysortdirection), required: false);
            SourceExpression.Validate(bodysorttimestamp, nameof(bodysorttimestamp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (bodysortdirection != null)
                {
                    sortObject["direction"] = SourceExpressionConverter.ConvertToken(bodysortdirection);
                    sortObjectpropCount++;
                }

                if (bodysorttimestamp != null)
                {
                    sortObject["timestamp"] = SourceExpressionConverter.ConvertToken(bodysorttimestamp);
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
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<DatabaseResponse> QueryADatabase([WorkflowExpression] Func<string> databaseId)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/databases/{0}/query", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<DatabaseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveYourTokensBotUserResponse> RetrieveYourTokensBotUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveYourTokensBotUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapagepropertyitemResponse> Retrieveapagepropertyitem([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> propertyId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(propertyId, nameof(propertyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/{0}/properties/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(propertyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveapagepropertyitemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<RetrieveapageResponse> Retrieveapage([WorkflowExpression] Func<string> pageId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveapageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CreateaPageResponse> CreateaPage([WorkflowExpression] Func<string> bodyparentdatabaseId = null, [WorkflowExpression] Func<string> bodyiconemoji = null, [WorkflowExpression] Func<string> bodycoverexternalurl = null)
        {
            SourceExpression.Validate(bodyparentdatabaseId, nameof(bodyparentdatabaseId), required: false);
            SourceExpression.Validate(bodyiconemoji, nameof(bodyiconemoji), required: false);
            SourceExpression.Validate(bodycoverexternalurl, nameof(bodycoverexternalurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    parentObject["database_id"] = SourceExpressionConverter.ConvertToken(bodyparentdatabaseId);
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
                    iconObject["emoji"] = SourceExpressionConverter.ConvertToken(bodyiconemoji);
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
                    externalObject["url"] = SourceExpressionConverter.ConvertToken(bodycoverexternalurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateaPageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Retrievecomments([WorkflowExpression] Func<string> blockId)
        {
            SourceExpression.Validate(blockId, nameof(blockId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["block_id"] = SourceExpressionConverter.ConvertO(blockId);
                callPayload.Headers["Notion-Version"] = Convert.ToString("2022-06-28");
                return callPayload;
            }

            return new ApiConnectionAction<CommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "notionip")]
        public IBodyWorkflowAction<CommentResponse> Createcomment([WorkflowExpression] Func<string> bodyparentpageId = null, [WorkflowExpression] Func<string> bodydiscussionId = null, [WorkflowExpression] Func<bodyrichTextInputItem[]> bodyrichText = null)
        {
            SourceExpression.Validate(bodyparentpageId, nameof(bodyparentpageId), required: false);
            SourceExpression.Validate(bodydiscussionId, nameof(bodydiscussionId), required: false);
            SourceExpression.Validate(bodyrichText, nameof(bodyrichText), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    parentObject["page_id"] = SourceExpressionConverter.ConvertToken(bodyparentpageId);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    body["parent"] = parentObject;
                    bodypropCount++;
                }

                if (bodydiscussionId != null)
                {
                    body["discussion_id"] = SourceExpressionConverter.ConvertToken(bodydiscussionId);
                    bodypropCount++;
                }

                if (bodyrichText != null)
                {
                    body["rich_text"] = SourceExpressionConverter.ConvertToken(bodyrichText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommentResponse>(BuildSourceInput);
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