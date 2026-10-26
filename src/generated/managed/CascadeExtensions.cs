//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascade
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllGoalsResponse, ApiConnectionActionConfiguration> GetAllGoals(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetAllGoalsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/goals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetAllGoalsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateGoalResponse, ApiConnectionActionConfiguration> CreateGoal(Expression<Func<string>> instance, Expression<Func<CreateGoalInput>> body)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/goals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleGoalResponse, ApiConnectionActionConfiguration> GetSingleGoal(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetSingleGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/goals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetSingleGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteGoalResponse, ApiConnectionActionConfiguration> DeleteGoal(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<DeleteGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/goals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<DeleteGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateGoalResponse, ApiConnectionActionConfiguration> UpdateGoal(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<UpdateGoalInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/goals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateGoalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllRisksResponse, ApiConnectionActionConfiguration> GetAllRisks(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetAllRisksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetAllRisksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateRiskResponse, ApiConnectionActionConfiguration> CreateRisk(Expression<Func<string>> instance, Expression<Func<CreateRiskInput>> body)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRiskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleRiskResponse, ApiConnectionActionConfiguration> GetSingleRisk(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetSingleRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetSingleRiskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteRiskResponse, ApiConnectionActionConfiguration> DeleteRisk(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<DeleteRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<DeleteRiskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateRiskResponse, ApiConnectionActionConfiguration> UpdateRisk(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<UpdateRiskInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateRiskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllTasksResponse, ApiConnectionActionConfiguration> GetAllTasks(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetAllTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetAllTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> instance, Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleTaskResponse, ApiConnectionActionConfiguration> GetSingleTask(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetSingleTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetSingleTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteTaskResponse, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<DeleteTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateTaskResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<UpdateTaskInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllUpdatesResponse, ApiConnectionActionConfiguration> GetAllUpdates(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetAllUpdatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetAllUpdatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateUpdateResponse, ApiConnectionActionConfiguration> CreateUpdate(Expression<Func<string>> instance, Expression<Func<CreateUpdateInput>> body)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleUpdateResponse, ApiConnectionActionConfiguration> GetSingleUpdate(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetSingleUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<GetSingleUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteUpdateResponse, ApiConnectionActionConfiguration> DeleteUpdate(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<DeleteUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                return new ApiConnectionAction<DeleteUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateUpdateResponse, ApiConnectionActionConfiguration> UpdateUpdate(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<UpdateUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateUpdateResponse>(callPayload);
            });
        }
    }

    public class CascadeTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllGoalsResponse
    {
        [JsonProperty("goal")]
        public GetAllGoalsResponseGoalType Goal { get; set; }
    }

    public class GetAllGoalsResponseGoalType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("completion_criteria")]
        public string CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public string TargetFlow { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double Initial { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("target")]
        public double Target { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public string TrackingType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("inherited_focus_area_ids")]
        public int[] InheritedFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ancestor_ids")]
        public int[] AncestorIds { get; set; }

        [JsonProperty("descendant_ids")]
        public int[] DescendantIds { get; set; }

        [JsonProperty("issue_ids")]
        public int[] IssueIds { get; set; }

        [JsonProperty("task_ids")]
        public int[] TaskIds { get; set; }
    }

    public class CreateGoalResponse
    {
        [JsonProperty("goal")]
        public CreateGoalResponseGoalType Goal { get; set; }
    }

    public class CreateGoalResponseGoalType
    {
        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("completion_criteria")]
        public string CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public string TargetFlow { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double Initial { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("target")]
        public double Target { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public string TrackingType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("inherited_focus_area_ids")]
        public int[] InheritedFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ancestor_ids")]
        public int[] AncestorIds { get; set; }

        [JsonProperty("descendant_ids")]
        public int[] DescendantIds { get; set; }

        [JsonProperty("issue_ids")]
        public int[] IssueIds { get; set; }

        [JsonProperty("task_ids")]
        public int[] TaskIds { get; set; }
    }

    public class CreateGoalInput
    {
        [JsonProperty("goal", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGoalInputGoalType Goal { get; set; }
    }

    public class CreateGoalInputGoalType
    {
        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int? CreatorId { get; set; }

        [JsonProperty("status")]
        public CreateGoalInputGoalTypeStatusType? Status { get; set; }

        [JsonProperty("completion_criteria")]
        public CreateGoalInputGoalTypeCompletionCriteriaType? CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public CreateGoalInputGoalTypeTargetFlowType? TargetFlow { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; }

        [JsonProperty("details", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double? Initial { get; set; }

        [JsonProperty("progress")]
        public double? Progress { get; set; }

        [JsonProperty("target")]
        public double? Target { get; set; }

        [JsonProperty("start_time", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("end_time", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("weight_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGoalInputGoalTypeWeightIdType WeightId { get; set; }

        [JsonProperty("is_private")]
        public CreateGoalInputGoalTypeIsPrivateType? IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public CreateGoalInputGoalTypeTrackingTypeType? TrackingType { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGoalInputGoalTypeStatusType
    {
        APPRO,
        DRAFT,
        ARCHI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGoalInputGoalTypeCompletionCriteriaType
    {
        [EnumMember(Value = "TARGET-REACHED")]
        TARGETREACHED,
        [EnumMember(Value = "TARGET-DEADLINE-REACHED")]
        TARGETDEADLINEREACHED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGoalInputGoalTypeTargetFlowType
    {
        OVER,
        UNDER,
        NONE
    }

    public enum CreateGoalInputGoalTypeWeightIdType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public enum CreateGoalInputGoalTypeIsPrivateType
    {
        _0 = 0,
        _1 = 1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGoalInputGoalTypeTrackingTypeType
    {
        MANUAL,
        [EnumMember(Value = "SUBGOAL-SUM")]
        SUBGOALSUM,
        [EnumMember(Value = "SUBGOAL-MEAN")]
        SUBGOALMEAN,
        [EnumMember(Value = "WEIGHTED-MEAN")]
        WEIGHTEDMEAN,
        TASKS
    }

    public class GetSingleGoalResponse
    {
        [JsonProperty("goal")]
        public GetSingleGoalResponseGoalType Goal { get; set; }
    }

    public class GetSingleGoalResponseGoalType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("completion_criteria")]
        public string CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public string TargetFlow { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double Initial { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("target")]
        public double Target { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public string TrackingType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("inherited_focus_area_ids")]
        public int[] InheritedFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ancestor_ids")]
        public int[] AncestorIds { get; set; }

        [JsonProperty("descendant_ids")]
        public int[] DescendantIds { get; set; }

        [JsonProperty("issue_ids")]
        public int[] IssueIds { get; set; }

        [JsonProperty("task_ids")]
        public int[] TaskIds { get; set; }
    }

    public class DeleteGoalResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateGoalResponse
    {
        [JsonProperty("goal")]
        public UpdateGoalResponseGoalType Goal { get; set; }
    }

    public class UpdateGoalResponseGoalType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("completion_criteria")]
        public string CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public string TargetFlow { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double Initial { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("target")]
        public double Target { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public string TrackingType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("inherited_focus_area_ids")]
        public int[] InheritedFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ancestor_ids")]
        public int[] AncestorIds { get; set; }

        [JsonProperty("descendant_ids")]
        public int[] DescendantIds { get; set; }

        [JsonProperty("issue_ids")]
        public int[] IssueIds { get; set; }

        [JsonProperty("task_ids")]
        public int[] TaskIds { get; set; }
    }

    public class UpdateGoalInput
    {
        [JsonProperty("goal")]
        public UpdateGoalInputGoalType Goal { get; set; }
    }

    public class UpdateGoalInputGoalType
    {
        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("creator_id")]
        public int? CreatorId { get; set; }

        [JsonProperty("status")]
        public UpdateGoalInputGoalTypeStatusType? Status { get; set; }

        [JsonProperty("completion_criteria")]
        public UpdateGoalInputGoalTypeCompletionCriteriaType? CompletionCriteria { get; set; }

        [JsonProperty("target_flow")]
        public UpdateGoalInputGoalTypeTargetFlowType? TargetFlow { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("initial")]
        public double? Initial { get; set; }

        [JsonProperty("progress")]
        public double? Progress { get; set; }

        [JsonProperty("target")]
        public double? Target { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("weight_id")]
        public UpdateGoalInputGoalTypeWeightIdType? WeightId { get; set; }

        [JsonProperty("is_private")]
        public int? IsPrivate { get; set; }

        [JsonProperty("tracking_type")]
        public UpdateGoalInputGoalTypeTrackingTypeType? TrackingType { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }

        [JsonProperty("direct_focus_area_ids")]
        public int[] DirectFocusAreaIds { get; set; }

        [JsonProperty("inherited_focus_area_ids")]
        public int[] InheritedFocusAreaIds { get; set; }

        [JsonProperty("aligned_from_ids")]
        public int[] AlignedFromIds { get; set; }

        [JsonProperty("aligned_to_ids")]
        public int[] AlignedToIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalInputGoalTypeStatusType
    {
        APPRO,
        DRAFT,
        ARCHI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalInputGoalTypeCompletionCriteriaType
    {
        [EnumMember(Value = "TARGET-REACHED")]
        TARGETREACHED,
        [EnumMember(Value = "TARGET-DEADLINE-REACHED")]
        TARGETDEADLINEREACHED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalInputGoalTypeTargetFlowType
    {
        OVER,
        UNDER,
        NONE
    }

    public enum UpdateGoalInputGoalTypeWeightIdType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateGoalInputGoalTypeTrackingTypeType
    {
        MANUAL,
        [EnumMember(Value = "SUBGOAL-SUM")]
        SUBGOALSUM,
        [EnumMember(Value = "SUBGOAL-MEAN")]
        SUBGOALMEAN,
        [EnumMember(Value = "WEIGHTED-MEAN")]
        WEIGHTEDMEAN,
        TASKS
    }

    public class GetAllRisksResponse
    {
        [JsonProperty("issue")]
        public GetAllRisksResponseIssueType Issue { get; set; }
    }

    public class GetAllRisksResponseIssueType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("is_critical")]
        public int IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public int IsResolved { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public GetAllRisksResponseIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public class GetAllRisksResponseIssueTypeCustomAttributesType
    {
        public int CA1573011281053 { get; set; }
        public int CA1573011296755 { get; set; }
    }

    public class CreateRiskResponse
    {
        [JsonProperty("issue")]
        public CreateRiskResponseIssueType Issue { get; set; }
    }

    public class CreateRiskResponseIssueType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("is_critical")]
        public int IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public int IsResolved { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public CreateRiskResponseIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public class CreateRiskResponseIssueTypeCustomAttributesType
    {
        public int CA1573011281053 { get; set; }
        public int CA1573011296755 { get; set; }
    }

    public class CreateRiskInput
    {
        [JsonProperty("issue", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRiskInputIssueType Issue { get; set; }
    }

    public class CreateRiskInputIssueType
    {
        [JsonProperty("issue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Issue { get; set; }

        [JsonProperty("is_critical")]
        public CreateRiskInputIssueTypeIsCriticalType? IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public CreateRiskInputIssueTypeIsResolvedType? IsResolved { get; set; }

        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("goal_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GoalId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public CreateRiskInputIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public enum CreateRiskInputIssueTypeIsCriticalType
    {
        _0 = 0,
        _1 = 1
    }

    public enum CreateRiskInputIssueTypeIsResolvedType
    {
        _0 = 0,
        _1 = 1
    }

    public class CreateRiskInputIssueTypeCustomAttributesType
    {
        public int? CA1573011281053 { get; set; }
        public int? CA1573011296755 { get; set; }
    }

    public class GetSingleRiskResponse
    {
        [JsonProperty("issue")]
        public GetSingleRiskResponseIssueType Issue { get; set; }
    }

    public class GetSingleRiskResponseIssueType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("is_critical")]
        public int IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public int IsResolved { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public GetSingleRiskResponseIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public class GetSingleRiskResponseIssueTypeCustomAttributesType
    {
        public int CA1573011281053 { get; set; }
        public int CA1573011296755 { get; set; }
    }

    public class DeleteRiskResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateRiskResponse
    {
        [JsonProperty("issue")]
        public UpdateRiskResponseIssueType Issue { get; set; }
    }

    public class UpdateRiskResponseIssueType
    {
        [JsonProperty("issue")]
        public int Issue { get; set; }

        [JsonProperty("is_critical")]
        public int IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public int IsResolved { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public UpdateRiskResponseIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public class UpdateRiskResponseIssueTypeCustomAttributesType
    {
        public int CA1573011281053 { get; set; }
        public int CA1573011296755 { get; set; }
    }

    public class UpdateRiskInput
    {
        [JsonProperty("issue")]
        public UpdateRiskInputIssueType Issue { get; set; }
    }

    public class UpdateRiskInputIssueType
    {
        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("is_critical")]
        public UpdateRiskInputIssueTypeIsCriticalType? IsCritical { get; set; }

        [JsonProperty("is_resolved")]
        public UpdateRiskInputIssueTypeIsResolvedType? IsResolved { get; set; }

        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }

        [JsonProperty("custom_attributes")]
        public UpdateRiskInputIssueTypeCustomAttributesType CustomAttributes { get; set; }
    }

    public enum UpdateRiskInputIssueTypeIsCriticalType
    {
        _0 = 0,
        _1 = 1
    }

    public enum UpdateRiskInputIssueTypeIsResolvedType
    {
        _0 = 0,
        _1 = 1
    }

    public class UpdateRiskInputIssueTypeCustomAttributesType
    {
        public int? CA1573011281053 { get; set; }
        public int? CA1573011296755 { get; set; }
    }

    public class GetAllTasksResponse
    {
        [JsonProperty("tasks")]
        public GetAllTasksResponseTasksTypeItem[] Tasks { get; set; }
    }

    public class GetAllTasksResponseTasksTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("is_complete")]
        public int IsComplete { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("completed_user_id")]
        public int CompletedUserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("tasks")]
        public CreateTaskResponseTasksType Tasks { get; set; }
    }

    public class CreateTaskResponseTasksType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("is_complete")]
        public int IsComplete { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("completed_user_id")]
        public string CompletedUserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public CreateTaskResponseTasksTypeWeightIdType WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public enum CreateTaskResponseTasksTypeWeightIdType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class CreateTaskInput
    {
        [JsonProperty("task", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskInputTaskObjectType TaskObject { get; set; }
    }

    public class CreateTaskInputTaskObjectType
    {
        [JsonProperty("task", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("is_complete")]
        public CreateTaskInputTaskObjectTypeIsCompleteType? IsComplete { get; set; }

        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("goal_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public CreateTaskInputTaskObjectTypeWeightIdType? WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }
    }

    public enum CreateTaskInputTaskObjectTypeIsCompleteType
    {
        _0 = 0,
        _1 = 1
    }

    public enum CreateTaskInputTaskObjectTypeWeightIdType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class GetSingleTaskResponse
    {
        [JsonProperty("task")]
        public GetSingleTaskResponseTaskObjectType TaskObject { get; set; }
    }

    public class GetSingleTaskResponseTaskObjectType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_complete")]
        public int IsComplete { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("completed_user_id")]
        public int CompletedUserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class DeleteTaskResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateTaskResponse
    {
        [JsonProperty("task")]
        public UpdateTaskResponseTaskObjectType TaskObject { get; set; }
    }

    public class UpdateTaskResponseTaskObjectType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_complete")]
        public int IsComplete { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("completed_user_id")]
        public int CompletedUserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public int WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class UpdateTaskInput
    {
        [JsonProperty("task", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateTaskInputTaskObjectType TaskObject { get; set; }
    }

    public class UpdateTaskInputTaskObjectType
    {
        [JsonProperty("task")]
        public string TaskObject { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("is_complete")]
        public UpdateTaskInputTaskObjectTypeIsCompleteType? IsComplete { get; set; }

        [JsonProperty("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("goal_id")]
        public int? GoalId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("weight_id")]
        public UpdateTaskInputTaskObjectTypeWeightIdType? WeightId { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }
    }

    public enum UpdateTaskInputTaskObjectTypeIsCompleteType
    {
        _0 = 0,
        _1 = 1
    }

    public enum UpdateTaskInputTaskObjectTypeWeightIdType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class GetAllUpdatesResponse
    {
        [JsonProperty("update")]
        public GetAllUpdatesResponseUpdateType Update { get; set; }
    }

    public class GetAllUpdatesResponseUpdateType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class CreateUpdateResponse
    {
        [JsonProperty("update")]
        public CreateUpdateResponseUpdateType Update { get; set; }
    }

    public class CreateUpdateResponseUpdateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class CreateUpdateInput
    {
        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUpdateInputUpdateType Update { get; set; }
    }

    public class CreateUpdateInputUpdateType
    {
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty("goal_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GoalId { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }
    }

    public class GetSingleUpdateResponse
    {
        [JsonProperty("update")]
        public GetSingleUpdateResponseUpdateType Update { get; set; }
    }

    public class GetSingleUpdateResponseUpdateType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class DeleteUpdateResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateUpdateResponse
    {
        [JsonProperty("update")]
        public UpdateUpdateResponseUpdateType Update { get; set; }
    }

    public class UpdateUpdateResponseUpdateType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("goal_id")]
        public int GoalId { get; set; }

        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        [JsonProperty("entity_template_id")]
        public int EntityTemplateId { get; set; }
    }

    public class UpdateUpdateInput
    {
        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateUpdateInputUpdateType Update { get; set; }
    }

    public class UpdateUpdateInputUpdateType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("goal_id")]
        public int? GoalId { get; set; }

        [JsonProperty("deleted")]
        public int? Deleted { get; set; }

        [JsonProperty("entity_template_id")]
        public int? EntityTemplateId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cascade;

    public partial class WorkflowManagedActions
    {
        public CascadeActions Cascade(string connectionId) => new CascadeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CascadeTriggers Cascade(string connectionId) => new CascadeTriggers(connectionId);
    }
}