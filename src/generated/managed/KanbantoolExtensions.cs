//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kanbantool
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KanbantoolActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetBoardResponse[]> GetBoards()
        {
            var apiCallPath = "/api/v1/boards.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBoardResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetBoardResponse> GetBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<GetBoardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}.json", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBoardResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetTaskResponse[]> GetTasks(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<GetTaskResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks.json", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> boardId, Expression<Func<string>> taskname, Expression<Func<string>> taskdescription = null, Expression<Func<string>> taskswimlaneId = null, Expression<Func<string>> taskworkflowStageId = null, Expression<Func<string>> taskcardTypeId = null, Expression<Func<string>> taskassignedUserId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskname = WorkflowExpression.Compile(taskname, nameof(taskname), required: true);
            var __workflow_taskdescription = WorkflowExpression.Compile(taskdescription, nameof(taskdescription), required: false);
            var __workflow_taskswimlaneId = WorkflowExpression.Compile(taskswimlaneId, nameof(taskswimlaneId), required: false);
            var __workflow_taskworkflowStageId = WorkflowExpression.Compile(taskworkflowStageId, nameof(taskworkflowStageId), required: false);
            var __workflow_taskcardTypeId = WorkflowExpression.Compile(taskcardTypeId, nameof(taskcardTypeId), required: false);
            var __workflow_taskassignedUserId = WorkflowExpression.Compile(taskassignedUserId, nameof(taskassignedUserId), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks.json", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                taskpropCount++;
                task["name"] = ExpressionConverter.ConvertO(__workflow_taskname);
                if (__workflow_taskdescription != null)
                {
                    task["description"] = ExpressionConverter.ConvertO(__workflow_taskdescription);
                    taskpropCount++;
                }

                if (__workflow_taskswimlaneId != null)
                {
                    task["swimlane_id"] = ExpressionConverter.ConvertO(__workflow_taskswimlaneId);
                    taskpropCount++;
                }

                if (__workflow_taskworkflowStageId != null)
                {
                    task["workflow_stage_id"] = ExpressionConverter.ConvertO(__workflow_taskworkflowStageId);
                    taskpropCount++;
                }

                if (__workflow_taskcardTypeId != null)
                {
                    task["card_type_id"] = ExpressionConverter.ConvertO(__workflow_taskcardTypeId);
                    taskpropCount++;
                }

                if (__workflow_taskassignedUserId != null)
                {
                    task["assigned_user_id"] = ExpressionConverter.ConvertO(__workflow_taskassignedUserId);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetTaskResponse2> GetTask(Expression<Func<string>> boardId, Expression<Func<string>> taskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponse2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask(Expression<Func<string>> boardId, Expression<Func<string>> taskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<DeleteTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<string>> taskname = null, Expression<Func<string>> taskdescription = null, Expression<Func<string>> taskcardTypeId = null, Expression<Func<string>> taskassignedUserId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_taskname = WorkflowExpression.Compile(taskname, nameof(taskname), required: false);
            var __workflow_taskdescription = WorkflowExpression.Compile(taskdescription, nameof(taskdescription), required: false);
            var __workflow_taskcardTypeId = WorkflowExpression.Compile(taskcardTypeId, nameof(taskcardTypeId), required: false);
            var __workflow_taskassignedUserId = WorkflowExpression.Compile(taskassignedUserId, nameof(taskassignedUserId), required: false);
            return new DeferredBodyAction<UpdateTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (__workflow_taskname != null)
                {
                    task["name"] = ExpressionConverter.ConvertO(__workflow_taskname);
                    taskpropCount++;
                }

                if (__workflow_taskdescription != null)
                {
                    task["description"] = ExpressionConverter.ConvertO(__workflow_taskdescription);
                    taskpropCount++;
                }

                if (__workflow_taskcardTypeId != null)
                {
                    task["card_type_id"] = ExpressionConverter.ConvertO(__workflow_taskcardTypeId);
                    taskpropCount++;
                }

                if (__workflow_taskassignedUserId != null)
                {
                    task["assigned_user_id"] = ExpressionConverter.ConvertO(__workflow_taskassignedUserId);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<MoveTaskResponse> MoveTask(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<taskdirectionInput>> taskdirection = null, Expression<Func<string>> taskswimlaneId = null, Expression<Func<string>> taskworkflowStageId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_taskdirection = WorkflowExpression.Compile(taskdirection, nameof(taskdirection), required: false);
            var __workflow_taskswimlaneId = WorkflowExpression.Compile(taskswimlaneId, nameof(taskswimlaneId), required: false);
            var __workflow_taskworkflowStageId = WorkflowExpression.Compile(taskworkflowStageId, nameof(taskworkflowStageId), required: false);
            return new DeferredBodyAction<MoveTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/move.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (__workflow_taskdirection != null)
                {
                    task["direction"] = ExpressionConverter.ConvertO(__workflow_taskdirection);
                    taskpropCount++;
                }

                if (__workflow_taskswimlaneId != null)
                {
                    task["swimlane_id"] = ExpressionConverter.ConvertO(__workflow_taskswimlaneId);
                    taskpropCount++;
                }

                if (__workflow_taskworkflowStageId != null)
                {
                    task["workflow_stage_id"] = ExpressionConverter.ConvertO(__workflow_taskworkflowStageId);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<MoveTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<ArchiveTaskResponse> ArchiveTask(Expression<Func<string>> boardId, Expression<Func<string>> taskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<ArchiveTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/archive.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ArchiveTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetActivitiesResponseItem[]> BoardActivities(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<GetActivitiesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/changelog.json", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetActivitiesResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetCommentResponse[]> GetComments(Expression<Func<string>> boardId, Expression<Func<string>> taskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetCommentResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/comments.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCommentResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetCommentResponse> CreateComment(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<string>> commentcontent)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_commentcontent = WorkflowExpression.Compile(commentcontent, nameof(commentcontent), required: true);
            return new DeferredBodyAction<GetCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/comments.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["content"] = ExpressionConverter.ConvertO(__workflow_commentcontent);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<GetCommentResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetSubtaskResponse[]> GetSubtasks(Expression<Func<string>> boardId, Expression<Func<string>> taskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetSubtaskResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/subtasks.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubtaskResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetSubtaskResponse> CreateSubtask(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<string>> subtaskname, Expression<Func<string>> subtaskassignedUserId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_subtaskname = WorkflowExpression.Compile(subtaskname, nameof(subtaskname), required: true);
            var __workflow_subtaskassignedUserId = WorkflowExpression.Compile(subtaskassignedUserId, nameof(subtaskassignedUserId), required: false);
            return new DeferredBodyAction<GetSubtaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/subtasks.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subtask = new JObject();
                var subtaskpropCount = 0;
                subtaskpropCount++;
                subtask["name"] = ExpressionConverter.ConvertO(__workflow_subtaskname);
                if (__workflow_subtaskassignedUserId != null)
                {
                    subtask["assigned_user_id"] = ExpressionConverter.ConvertO(__workflow_subtaskassignedUserId);
                    subtaskpropCount++;
                }

                if (subtaskpropCount > 0)
                {
                    callPayload.Body = subtask;
                }

                return new ApiConnectionAction<GetSubtaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetSubtaskResponse> DeleteSubtask(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<string>> subtaskId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_subtaskId = WorkflowExpression.Compile(subtaskId, nameof(subtaskId), required: true);
            return new DeferredBodyAction<GetSubtaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/subtasks/{2}.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1), __workflow_subtaskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubtaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbantool")]
        public IBodyWorkflowAction<GetSubtaskResponse> UpdateSubtask(Expression<Func<string>> boardId, Expression<Func<string>> taskId, Expression<Func<string>> subtaskId, Expression<Func<string>> subtaskname = null, Expression<Func<bool>> subtaskisCompleted = null, Expression<Func<string>> subtaskassignedUserId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_subtaskId = WorkflowExpression.Compile(subtaskId, nameof(subtaskId), required: true);
            var __workflow_subtaskname = WorkflowExpression.Compile(subtaskname, nameof(subtaskname), required: false);
            var __workflow_subtaskisCompleted = WorkflowExpression.Compile(subtaskisCompleted, nameof(subtaskisCompleted), required: false);
            var __workflow_subtaskassignedUserId = WorkflowExpression.Compile(subtaskassignedUserId, nameof(subtaskassignedUserId), required: false);
            return new DeferredBodyAction<GetSubtaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/boards/{0}/tasks/{1}/subtasks/{2}.json", __workflow_boardId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1), __workflow_subtaskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subtask = new JObject();
                var subtaskpropCount = 0;
                if (__workflow_subtaskname != null)
                {
                    subtask["name"] = ExpressionConverter.ConvertO(__workflow_subtaskname);
                    subtaskpropCount++;
                }

                if (__workflow_subtaskisCompleted != null)
                {
                    subtask["is_completed"] = ExpressionConverter.ConvertO(__workflow_subtaskisCompleted);
                    subtaskpropCount++;
                }

                if (__workflow_subtaskassignedUserId != null)
                {
                    subtask["assigned_user_id"] = ExpressionConverter.ConvertO(__workflow_subtaskassignedUserId);
                    subtaskpropCount++;
                }

                if (subtaskpropCount > 0)
                {
                    callPayload.Body = subtask;
                }

                return new ApiConnectionAction<GetSubtaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class KanbantoolTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetBoardResponse
    {
        [JsonProperty("board")]
        public GetBoardResponseBoardType Board { get; set; }
    }

    public class GetBoardResponseBoardType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("settings_updated_at")]
        public string SettingsUpdatedAt { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("last_activity_on")]
        public string LastActivityOn { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("external_id_sequence")]
        public int ExternalIdSequence { get; set; }

        [JsonProperty("board_template_id")]
        public string BoardTemplateId { get; set; }

        [JsonProperty("cumulative_flow_updated_at")]
        public string CumulativeFlowUpdatedAt { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("workflow_stages")]
        public GetBoardResponseBoardTypeWorkflowStagesTypeItem[] WorkflowStages { get; set; }

        [JsonProperty("swimlanes")]
        public GetBoardResponseBoardTypeSwimlanesTypeItem[] Swimlanes { get; set; }

        [JsonProperty("card_types")]
        public GetBoardResponseBoardTypeCardTypesTypeItem[] CardTypes { get; set; }
    }

    public class GetBoardResponseBoardTypeWorkflowStagesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class GetBoardResponseBoardTypeSwimlanesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetBoardResponseBoardTypeCardTypesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetTaskResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("workflow_stage_id")]
        public int WorkflowStageId { get; set; }

        [JsonProperty("swimlane_id")]
        public int SwimlaneId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("recurring_schedule")]
        public string RecurringSchedule { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("board_version")]
        public int BoardVersion { get; set; }

        [JsonProperty("archived_at")]
        public string ArchivedAt { get; set; }

        [JsonProperty("assigned_user_id")]
        public int AssignedUserId { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("size_estimate")]
        public string SizeEstimate { get; set; }

        [JsonProperty("card_type_id")]
        public int CardTypeId { get; set; }

        [JsonProperty("subtasks_count")]
        public int SubtasksCount { get; set; }

        [JsonProperty("subtasks_completed_count")]
        public int SubtasksCompletedCount { get; set; }

        [JsonProperty("attachments_count")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("custom_field_1")]
        public string CustomField1 { get; set; }

        [JsonProperty("custom_field_2")]
        public string CustomField2 { get; set; }

        [JsonProperty("custom_field_3")]
        public string CustomField3 { get; set; }

        [JsonProperty("custom_field_4")]
        public string CustomField4 { get; set; }

        [JsonProperty("custom_field_5")]
        public string CustomField5 { get; set; }

        [JsonProperty("custom_field_6")]
        public string CustomField6 { get; set; }

        [JsonProperty("custom_field_7")]
        public string CustomField7 { get; set; }

        [JsonProperty("custom_field_8")]
        public string CustomField8 { get; set; }

        [JsonProperty("custom_field_9")]
        public string CustomField9 { get; set; }

        [JsonProperty("custom_field_10")]
        public string CustomField10 { get; set; }

        [JsonProperty("custom_field_11")]
        public string CustomField11 { get; set; }

        [JsonProperty("custom_field_12")]
        public string CustomField12 { get; set; }

        [JsonProperty("custom_field_13")]
        public string CustomField13 { get; set; }

        [JsonProperty("custom_field_14")]
        public string CustomField14 { get; set; }

        [JsonProperty("custom_field_15")]
        public string CustomField15 { get; set; }

        [JsonProperty("external_link")]
        public string ExternalLink { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("postponed_until")]
        public string PostponedUntil { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("subtask_search_tags")]
        public string SubtaskSearchTags { get; set; }

        [JsonProperty("block_reason")]
        public string BlockReason { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("time_estimate")]
        public int TimeEstimate { get; set; }

        [JsonProperty("timers_total")]
        public string TimersTotal { get; set; }

        [JsonProperty("timers_total_updated_at")]
        public string TimersTotalUpdatedAt { get; set; }

        [JsonProperty("timers_active_count")]
        public int TimersActiveCount { get; set; }

        [JsonProperty("timers_listed_count")]
        public int TimersListedCount { get; set; }

        [JsonProperty("timers_postponed_count")]
        public int TimersPostponedCount { get; set; }

        [JsonProperty("linked_tasks")]
        public string LinkedTasks { get; set; }

        [JsonProperty("linked_tasks_status")]
        public string LinkedTasksStatus { get; set; }

        [JsonProperty("linked_from")]
        public string LinkedFrom { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    public class GetTaskResponse2
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    public class DeleteTaskResponse
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    public class UpdateTaskResponse
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    public class MoveTaskResponse
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum taskdirectionInput
    {
        [EnumMember(Value = "up")]
        Up,
        [EnumMember(Value = "down")]
        Down,
        [EnumMember(Value = "prev_stage")]
        PrevStage,
        [EnumMember(Value = "next_stage")]
        NextStage,
        [EnumMember(Value = "prev_swimlane")]
        PrevSwimlane,
        [EnumMember(Value = "next_swimlane")]
        NextSwimlane
    }

    public class ArchiveTaskResponse
    {
        [JsonProperty("task")]
        public GetTaskResponse TaskObject { get; set; }
    }

    public class GetActivitiesResponseItem
    {
        [JsonProperty("changelog")]
        public GetActivitiesResponseItemChangelogType Changelog { get; set; }
    }

    public class GetActivitiesResponseItemChangelogType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }

        [JsonProperty("changed_object_id")]
        public int ChangedObjectId { get; set; }

        [JsonProperty("changed_object_type")]
        public string ChangedObjectType { get; set; }

        [JsonProperty("changed_object_version")]
        public int ChangedObjectVersion { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("workflow_stage_id")]
        public int WorkflowStageId { get; set; }

        [JsonProperty("swimlane_id")]
        public int SwimlaneId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("data")]
        public GetActivitiesResponseItemChangelogTypeDataType Data { get; set; }
    }

    public class GetActivitiesResponseItemChangelogTypeDataType
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_initials")]
        public string UserInitials { get; set; }

        [JsonProperty("workflow_stage_id")]
        public int WorkflowStageId { get; set; }

        [JsonProperty("workflow_stage_name")]
        public string WorkflowStageName { get; set; }

        [JsonProperty("swimlane_id")]
        public int SwimlaneId { get; set; }

        [JsonProperty("swimlane_name")]
        public string SwimlaneName { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        [JsonProperty("task_external_id")]
        public string TaskExternalId { get; set; }

        [JsonProperty("dependent_task_id")]
        public int DependentTaskId { get; set; }

        [JsonProperty("dependent_task_name")]
        public string DependentTaskName { get; set; }

        [JsonProperty("from_workflow_stage_id")]
        public int FromWorkflowStageId { get; set; }

        [JsonProperty("from_workflow_stage_name")]
        public string FromWorkflowStageName { get; set; }

        [JsonProperty("from_swimlane_id")]
        public int FromSwimlaneId { get; set; }

        [JsonProperty("from_swimlane_name")]
        public string FromSwimlaneName { get; set; }

        [JsonProperty("to_workflow_stage_id")]
        public int ToWorkflowStageId { get; set; }

        [JsonProperty("to_workflow_stage_name")]
        public string ToWorkflowStageName { get; set; }

        [JsonProperty("to_swimlane_id")]
        public int ToSwimlaneId { get; set; }

        [JsonProperty("to_swimlane_name")]
        public string ToSwimlaneName { get; set; }

        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        [JsonProperty("comment_content")]
        public string CommentContent { get; set; }

        [JsonProperty("subtask_id")]
        public int SubtaskId { get; set; }

        [JsonProperty("subtask_name")]
        public string SubtaskName { get; set; }

        [JsonProperty("changes")]
        public string[] Changes { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetCommentResponse
    {
        [JsonProperty("comment")]
        public GetCommentResponseCommentType Comment { get; set; }
    }

    public class GetCommentResponseCommentType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("commentable_version")]
        public int CommentableVersion { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("recipients")]
        public string Recipients { get; set; }

        [JsonProperty("attachments")]
        public GetCommentResponseCommentTypeAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class GetCommentResponseCommentTypeAttachmentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetSubtaskResponse
    {
        [JsonProperty("subtask")]
        public GetSubtaskResponseSubtaskType Subtask { get; set; }
    }

    public class GetSubtaskResponseSubtaskType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task_version")]
        public int TaskVersion { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("assigned_user_id")]
        public int AssignedUserId { get; set; }

        [JsonProperty("is_completed")]
        public bool IsCompleted { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kanbantool;

    public partial class WorkflowManagedActions
    {
        public KanbantoolActions Kanbantool(string connectionId) => new KanbantoolActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KanbantoolTriggers Kanbantool(string connectionId) => new KanbantoolTriggers(connectionId);
    }
}
