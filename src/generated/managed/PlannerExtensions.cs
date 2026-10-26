//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planner
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2, ApiConnectionActionConfiguration> UnassignUsers(Expression<Func<string>> id, Expression<Func<UnassignUsersInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/unassignusers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2, ApiConnectionActionConfiguration> AssignUsers(Expression<Func<string>> id, Expression<Func<AssignUsersInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/assignusers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListMyPlansResponse, ApiConnectionActionConfiguration> ListGroupPlans(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListMyPlansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/planner/plans", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListMyPlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<CreateBucketResponse, ApiConnectionActionConfiguration> CreateBucket(Expression<Func<CreateBucketV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateBucketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/v1.0/planner/buckets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateBucketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV3, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskV4Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTaskResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/beta/planner/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTaskResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse, ApiConnectionActionConfiguration> GetTaskDetails(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/details", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListBucketsResponse, ApiConnectionActionConfiguration> ListBuckets(Expression<Func<string>> groupId, Expression<Func<string>> id)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ListBucketsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/plans/{0}/buckets", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionAction<ListBucketsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2, ApiConnectionActionConfiguration> ListMyTasks()
        {
            return new DeferredBodyAction<ListTasksResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/planner/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2, ApiConnectionActionConfiguration> ListTasks(Expression<Func<string>> groupId, Expression<Func<string>> id)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ListTasksResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<UpdateTaskV3Input>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse, ApiConnectionActionConfiguration> UpdateTaskDetails(Expression<Func<string>> id, Expression<Func<UpdateTaskDetailsV2Input>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTaskDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/details", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            });
        }
    }

    public class PlannerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration> OnCompleteTask(Expression<Func<string>> groupId, Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/oncompletetask_trigger/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration> OnNewTask(Expression<Func<string>> groupId, Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/onnewtask_trigger/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration> OnTaskAssignedToMe(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/planner/ontaskassignedtome_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetTaskResponseV2
    {
        [JsonProperty("createdBy")]
        public GetTaskResponseV2CreatedByType CreatedBy { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("percentComplete")]
        public int PercentComplete { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("hasDescription")]
        public bool HasDescription { get; set; }

        [JsonProperty("completedDateTime")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("referenceCount")]
        public int ReferenceCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }

        [JsonProperty("_assignments")]
        public GetTaskResponseV2AssignmentsTypeItem[] Assignments { get; set; }
    }

    public class GetTaskResponseV2CreatedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV2CreatedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV2CreatedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AppliedCategories
    {
        [JsonProperty("category1")]
        public bool Pink { get; set; }

        [JsonProperty("category2")]
        public bool Red { get; set; }

        [JsonProperty("category3")]
        public bool Yellow { get; set; }

        [JsonProperty("category4")]
        public bool Green { get; set; }

        [JsonProperty("category5")]
        public bool Blue { get; set; }

        [JsonProperty("category6")]
        public bool Purple { get; set; }

        [JsonProperty("category7")]
        public bool Bronze { get; set; }

        [JsonProperty("category8")]
        public bool Lime { get; set; }

        [JsonProperty("category9")]
        public bool Aqua { get; set; }

        [JsonProperty("category10")]
        public bool Gray { get; set; }

        [JsonProperty("category11")]
        public bool Silver { get; set; }

        [JsonProperty("category12")]
        public bool Brown { get; set; }

        [JsonProperty("category13")]
        public bool Cranberry { get; set; }

        [JsonProperty("category14")]
        public bool Orange { get; set; }

        [JsonProperty("category15")]
        public bool Peach { get; set; }

        [JsonProperty("category16")]
        public bool Marigold { get; set; }

        [JsonProperty("category17")]
        public bool LightGreen { get; set; }

        [JsonProperty("category18")]
        public bool DarkGreen { get; set; }

        [JsonProperty("category19")]
        public bool Teal { get; set; }

        [JsonProperty("category20")]
        public bool LightBlue { get; set; }

        [JsonProperty("category21")]
        public bool DarkBlue { get; set; }

        [JsonProperty("category22")]
        public bool Lavender { get; set; }

        [JsonProperty("category23")]
        public bool Plum { get; set; }

        [JsonProperty("category24")]
        public bool LightGray { get; set; }

        [JsonProperty("category25")]
        public bool DarkGray { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItem
    {
        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("value")]
        public GetTaskResponseV2AssignmentsTypeItemValueType Value { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueType
    {
        [JsonProperty("assignedBy")]
        public GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByType AssignedBy { get; set; }

        [JsonProperty("assignedDateTime")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByTypeUserType
    {
        [JsonProperty("id")]
        public string AssignedByUserId { get; set; }
    }

    public class UnassignUsersInput
    {
        [JsonProperty("assignments", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RemoveAssignedUsers { get; set; }
    }

    public class AssignUsersInput
    {
        [JsonProperty("assignments", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssignedUserIds { get; set; }
    }

    public class ListMyPlansResponse
    {
        [JsonProperty("value")]
        public ListMyPlansResponseValueTypeItem[] Value { get; set; }
    }

    public class ListMyPlansResponseValueTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateBucketResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateBucketV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("planId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }
    }

    public class GetTaskResponseV3
    {
        [JsonProperty("createdBy")]
        public GetTaskResponseV3CreatedByType CreatedBy { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("percentComplete")]
        public int PercentComplete { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("hasDescription")]
        public bool HasDescription { get; set; }

        [JsonProperty("completedDateTime")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("referenceCount")]
        public int ReferenceCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("_assignments")]
        public GetTaskResponseV3AssignmentsTypeItem[] Assignments { get; set; }
    }

    public class GetTaskResponseV3CreatedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV3CreatedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV3CreatedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItem
    {
        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("value")]
        public GetTaskResponseV3AssignmentsTypeItemValueType Value { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueType
    {
        [JsonProperty("assignedBy")]
        public GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByType AssignedBy { get; set; }

        [JsonProperty("assignedDateTime")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByTypeUserType
    {
        [JsonProperty("id")]
        public string AssignedByUserId { get; set; }
    }

    public class CreateTaskV4Input
    {
        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("planId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("assignments")]
        public string AssignedUserIds { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }
    }

    public class GetTaskDetailsResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("references")]
        public GetTaskDetailsResponseReferencesTypeItem[] References { get; set; }

        [JsonProperty("checklist")]
        public GetTaskDetailsResponseChecklistTypeItem[] Checklist { get; set; }
    }

    public class GetTaskDetailsResponseReferencesTypeItem
    {
        [JsonProperty("resourceLink")]
        public string ResourceLink { get; set; }

        [JsonProperty("value")]
        public GetTaskDetailsResponseReferencesTypeItemValueType Value { get; set; }
    }

    public class GetTaskDetailsResponseReferencesTypeItemValueType
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public JToken TypeOfTheReference { get; set; }
    }

    public class GetTaskDetailsResponseChecklistTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public GetTaskDetailsResponseChecklistTypeItemValueType Value { get; set; }
    }

    public class GetTaskDetailsResponseChecklistTypeItemValueType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isChecked")]
        public bool IsChecked { get; set; }
    }

    public class ListBucketsResponse
    {
        [JsonProperty("value")]
        public ListBucketsResponseValueTypeItem[] Value { get; set; }
    }

    public class ListBucketsResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListTasksResponseV2
    {
        [JsonProperty("value")]
        public GetTaskResponseV2[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class UpdateTaskV3Input
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("percentComplete")]
        public int? PercentComplete { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }
    }

    public class UpdateTaskDetailsV2Input
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("references")]
        public UpdateTaskDetailsV2InputReferencesTypeItem[] References { get; set; }

        [JsonProperty("checklist")]
        public UpdateTaskDetailsV2InputChecklistTypeItem[] Checklist { get; set; }
    }

    public class UpdateTaskDetailsV2InputReferencesTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("resourceLink", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceLink { get; set; }

        [JsonProperty("type")]
        public JToken TypeOfTheReference { get; set; }
    }

    public class UpdateTaskDetailsV2InputChecklistTypeItem
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("isChecked", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsChecked { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Planner;

    public partial class WorkflowManagedActions
    {
        public PlannerActions Planner(string connectionId) => new PlannerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlannerTriggers Planner(string connectionId) => new PlannerTriggers(connectionId);
    }
}