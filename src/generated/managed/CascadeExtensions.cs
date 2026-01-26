//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascade
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllGoalsResponse> GetAllGoals(Expression<Func<string>> instance)
        {
            var apiCallPath = "/goals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllGoalsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleGoalResponse> GetSingleGoal(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/goals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteGoalResponse> DeleteGoal(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/goals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateGoalResponse> UpdateGoal(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<int>> bodygoalroleId = null, Expression<Func<int>> bodygoalcreatorId = null, Expression<Func<bodygoalstatusInput>> bodygoalstatus = null, Expression<Func<bodygoalcompletionCriteriaInput>> bodygoalcompletionCriteria = null, Expression<Func<bodygoaltargetFlowInput>> bodygoaltargetFlow = null, Expression<Func<string>> bodygoalaction = null, Expression<Func<string>> bodygoaldetails = null, Expression<Func<double>> bodygoalinitial = null, Expression<Func<double>> bodygoalprogress = null, Expression<Func<double>> bodygoaltarget = null, Expression<Func<string>> bodygoalstartTime = null, Expression<Func<string>> bodygoalendTime = null, Expression<Func<bodygoalweightIdInput>> bodygoalweightId = null, Expression<Func<int>> bodygoalisPrivate = null, Expression<Func<bodygoaltrackingTypeInput>> bodygoaltrackingType = null, Expression<Func<int>> bodygoalentityTemplateId = null, Expression<Func<int[]>> bodygoaldirectFocusAreaIds = null, Expression<Func<int[]>> bodygoalinheritedFocusAreaIds = null, Expression<Func<int[]>> bodygoalalignedFromIds = null, Expression<Func<int[]>> bodygoalalignedToIds = null)
        {
            var apiCallPath = String.Format("/goals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            var body = new JObject();
            var bodypropCount = 0;
            var goalObject = new JObject();
            var goalObjectpropCount = 0;
            if (bodygoalroleId != null)
            {
                goalObject["role_id"] = ExpressionConverter.ConvertO(bodygoalroleId);
                goalObjectpropCount++;
            }

            if (bodygoalcreatorId != null)
            {
                goalObject["creator_id"] = ExpressionConverter.ConvertO(bodygoalcreatorId);
                goalObjectpropCount++;
            }

            if (bodygoalstatus != null)
            {
                goalObject["status"] = ExpressionConverter.ConvertO(bodygoalstatus);
                goalObjectpropCount++;
            }

            if (bodygoalcompletionCriteria != null)
            {
                goalObject["completion_criteria"] = ExpressionConverter.ConvertO(bodygoalcompletionCriteria);
                goalObjectpropCount++;
            }

            if (bodygoaltargetFlow != null)
            {
                goalObject["target_flow"] = ExpressionConverter.ConvertO(bodygoaltargetFlow);
                goalObjectpropCount++;
            }

            if (bodygoalaction != null)
            {
                goalObject["action"] = ExpressionConverter.ConvertO(bodygoalaction);
                goalObjectpropCount++;
            }

            if (bodygoaldetails != null)
            {
                goalObject["details"] = ExpressionConverter.ConvertO(bodygoaldetails);
                goalObjectpropCount++;
            }

            if (bodygoalinitial != null)
            {
                goalObject["initial"] = ExpressionConverter.ConvertO(bodygoalinitial);
                goalObjectpropCount++;
            }

            if (bodygoalprogress != null)
            {
                goalObject["progress"] = ExpressionConverter.ConvertO(bodygoalprogress);
                goalObjectpropCount++;
            }

            if (bodygoaltarget != null)
            {
                goalObject["target"] = ExpressionConverter.ConvertO(bodygoaltarget);
                goalObjectpropCount++;
            }

            if (bodygoalstartTime != null)
            {
                goalObject["start_time"] = ExpressionConverter.ConvertO(bodygoalstartTime);
                goalObjectpropCount++;
            }

            if (bodygoalendTime != null)
            {
                goalObject["end_time"] = ExpressionConverter.ConvertO(bodygoalendTime);
                goalObjectpropCount++;
            }

            if (bodygoalweightId != null)
            {
                goalObject["weight_id"] = ExpressionConverter.ConvertO(bodygoalweightId);
                goalObjectpropCount++;
            }

            if (bodygoalisPrivate != null)
            {
                goalObject["is_private"] = ExpressionConverter.ConvertO(bodygoalisPrivate);
                goalObjectpropCount++;
            }

            if (bodygoaltrackingType != null)
            {
                goalObject["tracking_type"] = ExpressionConverter.ConvertO(bodygoaltrackingType);
                goalObjectpropCount++;
            }

            if (bodygoalentityTemplateId != null)
            {
                goalObject["entity_template_id"] = ExpressionConverter.ConvertO(bodygoalentityTemplateId);
                goalObjectpropCount++;
            }

            if (bodygoaldirectFocusAreaIds != null)
            {
                goalObject["direct_focus_area_ids"] = ExpressionConverter.ConvertO(bodygoaldirectFocusAreaIds);
                goalObjectpropCount++;
            }

            if (bodygoalinheritedFocusAreaIds != null)
            {
                goalObject["inherited_focus_area_ids"] = ExpressionConverter.ConvertO(bodygoalinheritedFocusAreaIds);
                goalObjectpropCount++;
            }

            if (bodygoalalignedFromIds != null)
            {
                goalObject["aligned_from_ids"] = ExpressionConverter.ConvertO(bodygoalalignedFromIds);
                goalObjectpropCount++;
            }

            if (bodygoalalignedToIds != null)
            {
                goalObject["aligned_to_ids"] = ExpressionConverter.ConvertO(bodygoalalignedToIds);
                goalObjectpropCount++;
            }

            if (goalObjectpropCount > 0)
            {
                body["goal"] = goalObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllRisksResponse> GetAllRisks(Expression<Func<string>> instance)
        {
            var apiCallPath = "/issues";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllRisksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleRiskResponse> GetSingleRisk(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteRiskResponse> DeleteRisk(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateRiskResponse> UpdateRisk(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<string>> bodyissueissue = null, Expression<Func<bodyissueisCriticalInput>> bodyissueisCritical = null, Expression<Func<bodyissueisResolvedInput>> bodyissueisResolved = null, Expression<Func<int>> bodyissueroleId = null, Expression<Func<string>> bodyissuedueDate = null, Expression<Func<int>> bodyissueentityTemplateId = null, Expression<Func<int>> bodyissuecustomAttributesCA1573011281053 = null, Expression<Func<int>> bodyissuecustomAttributesCA1573011296755 = null)
        {
            var apiCallPath = String.Format("/issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            var body = new JObject();
            var bodypropCount = 0;
            var issueObject = new JObject();
            var issueObjectpropCount = 0;
            if (bodyissueissue != null)
            {
                issueObject["issue"] = ExpressionConverter.ConvertO(bodyissueissue);
                issueObjectpropCount++;
            }

            if (bodyissueisCritical != null)
            {
                issueObject["is_critical"] = ExpressionConverter.ConvertO(bodyissueisCritical);
                issueObjectpropCount++;
            }

            if (bodyissueisResolved != null)
            {
                issueObject["is_resolved"] = ExpressionConverter.ConvertO(bodyissueisResolved);
                issueObjectpropCount++;
            }

            if (bodyissueroleId != null)
            {
                issueObject["role_id"] = ExpressionConverter.ConvertO(bodyissueroleId);
                issueObjectpropCount++;
            }

            if (bodyissuedueDate != null)
            {
                issueObject["due_date"] = ExpressionConverter.ConvertO(bodyissuedueDate);
                issueObjectpropCount++;
            }

            if (bodyissueentityTemplateId != null)
            {
                issueObject["entity_template_id"] = ExpressionConverter.ConvertO(bodyissueentityTemplateId);
                issueObjectpropCount++;
            }

            var custom_attributesObject = new JObject();
            var custom_attributesObjectpropCount = 0;
            if (bodyissuecustomAttributesCA1573011281053 != null)
            {
                custom_attributesObject["CA1573011281053"] = ExpressionConverter.ConvertO(bodyissuecustomAttributesCA1573011281053);
                custom_attributesObjectpropCount++;
            }

            if (bodyissuecustomAttributesCA1573011296755 != null)
            {
                custom_attributesObject["CA1573011296755"] = ExpressionConverter.ConvertO(bodyissuecustomAttributesCA1573011296755);
                custom_attributesObjectpropCount++;
            }

            if (custom_attributesObjectpropCount > 0)
            {
                issueObject["custom_attributes"] = custom_attributesObject;
                issueObjectpropCount++;
            }

            if (issueObjectpropCount > 0)
            {
                body["issue"] = issueObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllTasksResponse> GetAllTasks(Expression<Func<string>> instance)
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleTaskResponse> GetSingleTask(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllUpdatesResponse> GetAllUpdates(Expression<Func<string>> instance)
        {
            var apiCallPath = "/updates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllUpdatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleUpdateResponse> GetSingleUpdate(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/updates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteUpdateResponse> DeleteUpdate(Expression<Func<string>> id, Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/updates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteUpdateResponse>(callPayload);
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

    public enum bodygoalstatusInput
    {
        APPRO,
        DRAFT,
        ARCHI
    }

    public enum bodygoalcompletionCriteriaInput
    {
        [EnumMember(Value = "TARGET-REACHED")]
        TARGETREACHED,
        [EnumMember(Value = "TARGET-DEADLINE-REACHED")]
        TARGETDEADLINEREACHED
    }

    public enum bodygoaltargetFlowInput
    {
        OVER,
        UNDER,
        NONE
    }

    public enum bodygoalweightIdInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    public enum bodygoaltrackingTypeInput
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

    public enum bodyissueisCriticalInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum bodyissueisResolvedInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
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