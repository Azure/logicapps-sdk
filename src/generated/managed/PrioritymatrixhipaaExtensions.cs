//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prioritymatrixhipaa
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PrioritymatrixhipaaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrixhipaa")]
        public IBodyWorkflowAction<AddCommentToItemResponse, ApiConnectionActionConfiguration> AddCommentToItem(Expression<Func<int>> project, Expression<Func<AddCommentToItemInput>> body)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddCommentToItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/comment/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddCommentToItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrixhipaa")]
        public IBodyWorkflowAction<GetProjectsResponse, ApiConnectionActionConfiguration> GetProjects(Expression<Func<int>> limit, Expression<Func<int>> state, Expression<Func<string>> skipTag = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            var __workflow_skipTag = WorkflowExpression.Compile(skipTag, nameof(skipTag), required: false);
            return new DeferredBodyAction<GetProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/project/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                callPayload.Queries["skip_tag"] = Convert.ToString("archived");
                if (__workflow_skipTag != null)
                    callPayload.Queries["skip_tag"] = ExpressionConverter.Convert(__workflow_skipTag);
                return new ApiConnectionAction<GetProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrixhipaa")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/project/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrixhipaa")]
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<int>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "prioritymatrixhipaa")]
        public IBodyWorkflowAction<UpdateProjectResponse, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<int>> projectId, Expression<Func<UpdateProjectInput>> body = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            });
        }
    }

    public class PrioritymatrixhipaaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemCompletedHookResponse, ApiConnectionTriggerConfiguration> ItemCompletedHook(Expression<Func<ItemCompletedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemCompletedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.completed/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemCompletedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemCreatedHookResponse, ApiConnectionTriggerConfiguration> ItemCreatedHook(Expression<Func<ItemCreatedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemCreatedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.created/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemCreatedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemDelegatedHookResponse, ApiConnectionTriggerConfiguration> ItemDelegatedHook(Expression<Func<ItemDelegatedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemDelegatedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.delegated/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemDelegatedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemDeletedHookResponse, ApiConnectionTriggerConfiguration> ItemDeletedHook(Expression<Func<ItemDeletedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemDeletedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.deleted/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemDeletedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemDueHookResponse, ApiConnectionTriggerConfiguration> ItemDueHook(Expression<Func<ItemDueHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemDueHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.due/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemDueHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemStartHookResponse, ApiConnectionTriggerConfiguration> ItemStartHook(Expression<Func<ItemStartHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ItemStartHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/hook/item.start/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ItemStartHookResponse>(callPayload, recurrence: recurrence);
            });
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

    public class AddCommentToItemInput
    {
        [JsonProperty("item", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Item { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
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
        public string BoxFolderId { get; set; }

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
        public string BoxFolderId { get; set; }

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

    public class CreateProjectInput
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("account_uri")]
        public string AccountUri { get; set; }

        [JsonProperty("boxFolderID")]
        public string BoxFolderId { get; set; }

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
        public string BoxFolderId { get; set; }

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

    public class UpdateProjectInput
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("textFirstQuadrant")]
        public string TextFirstQuadrant { get; set; }

        [JsonProperty("textFourthQuadrant")]
        public string TextFourthQuadrant { get; set; }

        [JsonProperty("textSecondQuadrant")]
        public string TextSecondQuadrant { get; set; }

        [JsonProperty("textThirdQuadrant")]
        public string TextThirdQuadrant { get; set; }
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

    public class ItemCompletedHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
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

    public class ItemCreatedHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
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

    public class ItemDelegatedHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
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

    public class ItemDeletedHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
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

    public class ItemDueHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
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

    public class ItemStartHookInput
    {
        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prioritymatrixhipaa;

    public partial class WorkflowManagedActions
    {
        public PrioritymatrixhipaaActions Prioritymatrixhipaa(string connectionId) => new PrioritymatrixhipaaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PrioritymatrixhipaaTriggers Prioritymatrixhipaa(string connectionId) => new PrioritymatrixhipaaTriggers(connectionId);
    }
}