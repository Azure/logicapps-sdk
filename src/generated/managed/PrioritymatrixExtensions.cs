//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prioritymatrix
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PrioritymatrixActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrix")]
        public IBodyWorkflowAction<AddCommentToItemResponse> AddCommentToItem([WorkflowExpression] Func<int> project, [WorkflowExpression] Func<string> bodyitem, [WorkflowExpression] Func<string> bodytext)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(bodyitem, nameof(bodyitem), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/comment/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Project"] = SourceExpressionConverter.ConvertO(project);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["item"] = SourceExpressionConverter.ConvertToken(bodyitem);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddCommentToItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrix")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> state, [WorkflowExpression] Func<string> skipTag = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: true);
            SourceExpression.Validate(state, nameof(state), required: true);
            SourceExpression.Validate(skipTag, nameof(skipTag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/project/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                callPayload.Queries["skip_tag"] = Convert.ToString("archived");
                if (skipTag != null)
                    callPayload.Queries["skip_tag"] = SourceExpressionConverter.ConvertO(skipTag);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrix")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodytextFirstQuadrant = null, [WorkflowExpression] Func<string> bodytextFourthQuadrant = null, [WorkflowExpression] Func<string> bodytextSecondQuadrant = null, [WorkflowExpression] Func<string> bodytextThirdQuadrant = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodytextFirstQuadrant, nameof(bodytextFirstQuadrant), required: false);
            SourceExpression.Validate(bodytextFourthQuadrant, nameof(bodytextFourthQuadrant), required: false);
            SourceExpression.Validate(bodytextSecondQuadrant, nameof(bodytextSecondQuadrant), required: false);
            SourceExpression.Validate(bodytextThirdQuadrant, nameof(bodytextThirdQuadrant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/project/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodytextFirstQuadrant != null)
                {
                    body["textFirstQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextFirstQuadrant);
                    bodypropCount++;
                }

                if (bodytextFourthQuadrant != null)
                {
                    body["textFourthQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextFourthQuadrant);
                    bodypropCount++;
                }

                if (bodytextSecondQuadrant != null)
                {
                    body["textSecondQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextSecondQuadrant);
                    bodypropCount++;
                }

                if (bodytextThirdQuadrant != null)
                {
                    body["textThirdQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextThirdQuadrant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrix")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<int> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/project/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrix")]
        public IBodyWorkflowAction<UpdateProjectResponse> UpdateProject([WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodytextFirstQuadrant = null, [WorkflowExpression] Func<string> bodytextFourthQuadrant = null, [WorkflowExpression] Func<string> bodytextSecondQuadrant = null, [WorkflowExpression] Func<string> bodytextThirdQuadrant = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodytextFirstQuadrant, nameof(bodytextFirstQuadrant), required: false);
            SourceExpression.Validate(bodytextFourthQuadrant, nameof(bodytextFourthQuadrant), required: false);
            SourceExpression.Validate(bodytextSecondQuadrant, nameof(bodytextSecondQuadrant), required: false);
            SourceExpression.Validate(bodytextThirdQuadrant, nameof(bodytextThirdQuadrant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/project/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodytextFirstQuadrant != null)
                {
                    body["textFirstQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextFirstQuadrant);
                    bodypropCount++;
                }

                if (bodytextFourthQuadrant != null)
                {
                    body["textFourthQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextFourthQuadrant);
                    bodypropCount++;
                }

                if (bodytextSecondQuadrant != null)
                {
                    body["textSecondQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextSecondQuadrant);
                    bodypropCount++;
                }

                if (bodytextThirdQuadrant != null)
                {
                    body["textThirdQuadrant"] = SourceExpressionConverter.ConvertToken(bodytextThirdQuadrant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateProjectResponse>(BuildSourceInput);
        }
    }

    public class PrioritymatrixTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemCompletedHookResponse> ItemCompletedHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.completed/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemCompletedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemCreatedHookResponse> ItemCreatedHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.created/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemCreatedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemDelegatedHookResponse> ItemDelegatedHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.delegated/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemDelegatedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemDeletedHookResponse> ItemDeletedHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.deleted/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemDeletedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemDueHookResponse> ItemDueHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.due/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemDueHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemStartHookResponse> ItemStartHook([WorkflowExpression] Func<string> bodyproject = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/hook/item.start/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyproject != null)
                {
                    body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                    bodypropCount++;
                }

                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemStartHookResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class AddCommentToItemResponse
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }

        [JsonProperty("author_fullname")]
        public string AuthorFullname { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("interest_level")]
        public int InterestLevel { get; set; }

        [JsonProperty("is_attention")]
        public bool IsAttention { get; set; }

        [JsonProperty("is_automatic")]
        public bool IsAutomatic { get; set; }

        [JsonProperty("is_command")]
        public bool IsCommand { get; set; }

        [JsonProperty("is_email")]
        public bool IsEmail { get; set; }

        [JsonProperty("is_read")]
        public bool IsRead { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("item_completed")]
        public bool ItemCompleted { get; set; }

        [JsonProperty("item_deleted")]
        public bool ItemDeleted { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("json")]
        public string Json { get; set; }

        [JsonProperty("num_comments")]
        public int NumComments { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("project_state")]
        public int ProjectState { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("source_email")]
        public string SourceEmail { get; set; }

        [JsonProperty("target_email")]
        public string TargetEmail { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }

    public class GetProjectsResponse
    {
        [JsonProperty("meta")]
        public GetProjectsResponseMetaType Meta { get; set; }

        [JsonProperty("objects")]
        public GetProjectsResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class GetProjectsResponseMetaType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("requested_time")]
        public int RequestedTime { get; set; }

        [JsonProperty("server_time")]
        public double ServerTime { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetProjectsResponseObjectsTypeItem
    {
        [JsonProperty("account_uri")]
        public string AccountUri { get; set; }

        [JsonProperty("boxFolderID")]
        public string BoxFolderID { get; set; }

        [JsonProperty("colorFirstQuadrant")]
        public string ColorFirstQuadrant { get; set; }

        [JsonProperty("colorFourthQuadrant")]
        public string ColorFourthQuadrant { get; set; }

        [JsonProperty("colorSecondQuadrant")]
        public string ColorSecondQuadrant { get; set; }

        [JsonProperty("colorThirdQuadrant")]
        public string ColorThirdQuadrant { get; set; }

        [JsonProperty("completed_effort")]
        public int CompletedEffort { get; set; }

        [JsonProperty("creationDateObject")]
        public string CreationDateObject { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("editedByDevice")]
        public string EditedByDevice { get; set; }

        [JsonProperty("edited_by_username")]
        public string EditedByUsername { get; set; }

        [JsonProperty("endDateObject")]
        public string EndDateObject { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("idd")]
        public int Idd { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("is_team_project")]
        public bool IsTeamProject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("owner")]
        public string[] Owner { get; set; }

        [JsonProperty("owners_count")]
        public int OwnersCount { get; set; }

        [JsonProperty("requested_time")]
        public double RequestedTime { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("startDateObject")]
        public string StartDateObject { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("tags")]
        public GetProjectsResponseObjectsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("templateCreationDate")]
        public int TemplateCreationDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("total_effort")]
        public int TotalEffort { get; set; }

        [JsonProperty("user_group_id")]
        public string UserGroupId { get; set; }

        [JsonProperty("version_id")]
        public int VersionId { get; set; }
    }

    public class GetProjectsResponseObjectsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class CreateProjectResponse
    {
        [JsonProperty("meta")]
        public CreateProjectResponseMetaType Meta { get; set; }

        [JsonProperty("objects")]
        public CreateProjectResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class CreateProjectResponseMetaType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("requested_time")]
        public int RequestedTime { get; set; }

        [JsonProperty("server_time")]
        public double ServerTime { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class CreateProjectResponseObjectsTypeItem
    {
        [JsonProperty("account_uri")]
        public string AccountUri { get; set; }

        [JsonProperty("boxFolderID")]
        public string BoxFolderID { get; set; }

        [JsonProperty("colorFirstQuadrant")]
        public string ColorFirstQuadrant { get; set; }

        [JsonProperty("colorFourthQuadrant")]
        public string ColorFourthQuadrant { get; set; }

        [JsonProperty("colorSecondQuadrant")]
        public string ColorSecondQuadrant { get; set; }

        [JsonProperty("colorThirdQuadrant")]
        public string ColorThirdQuadrant { get; set; }

        [JsonProperty("completed_effort")]
        public int CompletedEffort { get; set; }

        [JsonProperty("creationDateObject")]
        public string CreationDateObject { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("editedByDevice")]
        public string EditedByDevice { get; set; }

        [JsonProperty("edited_by_username")]
        public string EditedByUsername { get; set; }

        [JsonProperty("endDateObject")]
        public string EndDateObject { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("idd")]
        public int Idd { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("is_team_project")]
        public bool IsTeamProject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("owner")]
        public string[] Owner { get; set; }

        [JsonProperty("owners_count")]
        public int OwnersCount { get; set; }

        [JsonProperty("requested_time")]
        public double RequestedTime { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("startDateObject")]
        public string StartDateObject { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("tags")]
        public CreateProjectResponseObjectsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("templateCreationDate")]
        public int TemplateCreationDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("total_effort")]
        public int TotalEffort { get; set; }

        [JsonProperty("user_group_id")]
        public string UserGroupId { get; set; }

        [JsonProperty("version_id")]
        public int VersionId { get; set; }
    }

    public class CreateProjectResponseObjectsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("account_uri")]
        public string AccountUri { get; set; }

        [JsonProperty("boxFolderID")]
        public string BoxFolderID { get; set; }

        [JsonProperty("colorFirstQuadrant")]
        public string ColorFirstQuadrant { get; set; }

        [JsonProperty("colorFourthQuadrant")]
        public string ColorFourthQuadrant { get; set; }

        [JsonProperty("colorSecondQuadrant")]
        public string ColorSecondQuadrant { get; set; }

        [JsonProperty("colorThirdQuadrant")]
        public string ColorThirdQuadrant { get; set; }

        [JsonProperty("completed_effort")]
        public int CompletedEffort { get; set; }

        [JsonProperty("creationDateObject")]
        public string CreationDateObject { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("editedByDevice")]
        public string EditedByDevice { get; set; }

        [JsonProperty("edited_by_username")]
        public string EditedByUsername { get; set; }

        [JsonProperty("endDateObject")]
        public string EndDateObject { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("idd")]
        public int Idd { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("is_team_project")]
        public bool IsTeamProject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("owner")]
        public string[] Owner { get; set; }

        [JsonProperty("owners_count")]
        public int OwnersCount { get; set; }

        [JsonProperty("requested_time")]
        public double RequestedTime { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("startDateObject")]
        public string StartDateObject { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("tags")]
        public GetProjectResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("templateCreationDate")]
        public string TemplateCreationDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("total_effort")]
        public int TotalEffort { get; set; }

        [JsonProperty("user_group_id")]
        public string UserGroupId { get; set; }

        [JsonProperty("version_id")]
        public int VersionId { get; set; }
    }

    public class GetProjectResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class UpdateProjectResponse
    {
        [JsonProperty("meta")]
        public UpdateProjectResponseMetaType Meta { get; set; }

        [JsonProperty("objects")]
        public UpdateProjectResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class UpdateProjectResponseMetaType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("requested_time")]
        public int RequestedTime { get; set; }

        [JsonProperty("server_time")]
        public double ServerTime { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class UpdateProjectResponseObjectsTypeItem
    {
        [JsonProperty("account_uri")]
        public string AccountUri { get; set; }

        [JsonProperty("boxFolderID")]
        public string BoxFolderID { get; set; }

        [JsonProperty("colorFirstQuadrant")]
        public string ColorFirstQuadrant { get; set; }

        [JsonProperty("colorFourthQuadrant")]
        public string ColorFourthQuadrant { get; set; }

        [JsonProperty("colorSecondQuadrant")]
        public string ColorSecondQuadrant { get; set; }

        [JsonProperty("colorThirdQuadrant")]
        public string ColorThirdQuadrant { get; set; }

        [JsonProperty("completed_effort")]
        public int CompletedEffort { get; set; }

        [JsonProperty("creationDateObject")]
        public string CreationDateObject { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_username")]
        public string CreatorUsername { get; set; }

        [JsonProperty("editedByDevice")]
        public string EditedByDevice { get; set; }

        [JsonProperty("edited_by_username")]
        public string EditedByUsername { get; set; }

        [JsonProperty("endDateObject")]
        public string EndDateObject { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("idd")]
        public int Idd { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("is_team_project")]
        public bool IsTeamProject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("owner")]
        public string[] Owner { get; set; }

        [JsonProperty("owners_count")]
        public int OwnersCount { get; set; }

        [JsonProperty("requested_time")]
        public double RequestedTime { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("startDateObject")]
        public string StartDateObject { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("tags")]
        public UpdateProjectResponseObjectsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("templateCreationDate")]
        public int TemplateCreationDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("total_effort")]
        public int TotalEffort { get; set; }

        [JsonProperty("user_group_id")]
        public string UserGroupId { get; set; }

        [JsonProperty("version_id")]
        public int VersionId { get; set; }
    }

    public class UpdateProjectResponseObjectsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class ItemCompletedHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ItemCreatedHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ItemDelegatedHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ItemDeletedHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ItemDueHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class ItemStartHookResponse
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prioritymatrix;

    public partial class WorkflowManagedActions
    {
        public PrioritymatrixActions Prioritymatrix(string connectionId) => new PrioritymatrixActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PrioritymatrixTriggers Prioritymatrix(string connectionId) => new PrioritymatrixTriggers(connectionId);
    }
}