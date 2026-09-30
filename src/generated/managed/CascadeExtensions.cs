//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascade
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllGoalsResponse> GetAllGoals([WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = "/goals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllGoalsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> bodygoalroleId = null, [WorkflowExpression] Func<int> bodygoalcreatorId = null, [WorkflowExpression] Func<bodygoalstatusInput> bodygoalstatus = null, [WorkflowExpression] Func<bodygoalcompletionCriteriaInput> bodygoalcompletionCriteria = null, [WorkflowExpression] Func<bodygoaltargetFlowInput> bodygoaltargetFlow = null, [WorkflowExpression] Func<string> bodygoalaction = null, [WorkflowExpression] Func<string> bodygoaldetails = null, [WorkflowExpression] Func<double> bodygoalinitial = null, [WorkflowExpression] Func<double> bodygoalprogress = null, [WorkflowExpression] Func<double> bodygoaltarget = null, [WorkflowExpression] Func<string> bodygoalstartTime = null, [WorkflowExpression] Func<string> bodygoalendTime = null, [WorkflowExpression] Func<bodygoalweightIdInput> bodygoalweightId = null, [WorkflowExpression] Func<bodygoalisPrivateInput> bodygoalisPrivate = null, [WorkflowExpression] Func<bodygoaltrackingTypeInput> bodygoaltrackingType = null, [WorkflowExpression] Func<int> bodygoalentityTemplateId = null, [WorkflowExpression] Func<int[]> bodygoaldirectFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedFromIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedToIds = null)
        {
            var apiCallPath = "/goals";
            var apiCallHttpMethod = "post";
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

            return new ApiConnectionAction<CreateGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleGoalResponse> GetSingleGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/goals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteGoalResponse> DeleteGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/goals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteGoalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateGoalResponse> UpdateGoal([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> bodygoalroleId = null, [WorkflowExpression] Func<int> bodygoalcreatorId = null, [WorkflowExpression] Func<bodygoalstatusInput> bodygoalstatus = null, [WorkflowExpression] Func<bodygoalcompletionCriteriaInput> bodygoalcompletionCriteria = null, [WorkflowExpression] Func<bodygoaltargetFlowInput> bodygoaltargetFlow = null, [WorkflowExpression] Func<string> bodygoalaction = null, [WorkflowExpression] Func<string> bodygoaldetails = null, [WorkflowExpression] Func<double> bodygoalinitial = null, [WorkflowExpression] Func<double> bodygoalprogress = null, [WorkflowExpression] Func<double> bodygoaltarget = null, [WorkflowExpression] Func<string> bodygoalstartTime = null, [WorkflowExpression] Func<string> bodygoalendTime = null, [WorkflowExpression] Func<bodygoalweightIdInput> bodygoalweightId = null, [WorkflowExpression] Func<int> bodygoalisPrivate = null, [WorkflowExpression] Func<bodygoaltrackingTypeInput> bodygoaltrackingType = null, [WorkflowExpression] Func<int> bodygoalentityTemplateId = null, [WorkflowExpression] Func<int[]> bodygoaldirectFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalinheritedFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedFromIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedToIds = null)
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
        public IBodyWorkflowAction<GetAllRisksResponse> GetAllRisks([WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = "/issues";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllRisksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateRiskResponse> CreateRisk([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyissueissue = null, [WorkflowExpression] Func<bodyissueisCriticalInput> bodyissueisCritical = null, [WorkflowExpression] Func<bodyissueisResolvedInput> bodyissueisResolved = null, [WorkflowExpression] Func<int> bodyissueroleId = null, [WorkflowExpression] Func<int> bodyissuegoalId = null, [WorkflowExpression] Func<string> bodyissuedueDate = null, [WorkflowExpression] Func<int> bodyissueentityTemplateId = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011281053 = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011296755 = null)
        {
            var apiCallPath = "/issues";
            var apiCallHttpMethod = "post";
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

            if (bodyissuegoalId != null)
            {
                issueObject["goal_id"] = ExpressionConverter.ConvertO(bodyissuegoalId);
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

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (bodyissuecustomAttributescA1573011281053 != null)
            {
                customAttributesObject["CA1573011281053"] = ExpressionConverter.ConvertO(bodyissuecustomAttributescA1573011281053);
                customAttributesObjectpropCount++;
            }

            if (bodyissuecustomAttributescA1573011296755 != null)
            {
                customAttributesObject["CA1573011296755"] = ExpressionConverter.ConvertO(bodyissuecustomAttributescA1573011296755);
                customAttributesObjectpropCount++;
            }

            if (customAttributesObjectpropCount > 0)
            {
                issueObject["custom_attributes"] = customAttributesObject;
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

            return new ApiConnectionAction<CreateRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleRiskResponse> GetSingleRisk([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteRiskResponse> DeleteRisk([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteRiskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateRiskResponse> UpdateRisk([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyissueissue = null, [WorkflowExpression] Func<bodyissueisCriticalInput> bodyissueisCritical = null, [WorkflowExpression] Func<bodyissueisResolvedInput> bodyissueisResolved = null, [WorkflowExpression] Func<int> bodyissueroleId = null, [WorkflowExpression] Func<string> bodyissuedueDate = null, [WorkflowExpression] Func<int> bodyissueentityTemplateId = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011281053 = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011296755 = null)
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

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (bodyissuecustomAttributescA1573011281053 != null)
            {
                customAttributesObject["CA1573011281053"] = ExpressionConverter.ConvertO(bodyissuecustomAttributescA1573011281053);
                customAttributesObjectpropCount++;
            }

            if (bodyissuecustomAttributescA1573011296755 != null)
            {
                customAttributesObject["CA1573011296755"] = ExpressionConverter.ConvertO(bodyissuecustomAttributescA1573011296755);
                customAttributesObjectpropCount++;
            }

            if (customAttributesObjectpropCount > 0)
            {
                issueObject["custom_attributes"] = customAttributesObject;
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
        public IBodyWorkflowAction<GetAllTasksResponse> GetAllTasks([WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodytasktask = null, [WorkflowExpression] Func<string> bodytaskcomment = null, [WorkflowExpression] Func<bodytaskisCompleteInput> bodytaskisComplete = null, [WorkflowExpression] Func<int> bodytaskroleId = null, [WorkflowExpression] Func<int> bodytaskgoalId = null, [WorkflowExpression] Func<string> bodytaskstartDate = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<bodytaskweightIdInput> bodytaskweightId = null, [WorkflowExpression] Func<int> bodytaskentityTemplateId = null)
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            var body = new JObject();
            var bodypropCount = 0;
            var taskObject = new JObject();
            var taskObjectpropCount = 0;
            if (bodytasktask != null)
            {
                taskObject["task"] = ExpressionConverter.ConvertO(bodytasktask);
                taskObjectpropCount++;
            }

            if (bodytaskcomment != null)
            {
                taskObject["comment"] = ExpressionConverter.ConvertO(bodytaskcomment);
                taskObjectpropCount++;
            }

            if (bodytaskisComplete != null)
            {
                taskObject["is_complete"] = ExpressionConverter.ConvertO(bodytaskisComplete);
                taskObjectpropCount++;
            }

            if (bodytaskroleId != null)
            {
                taskObject["role_id"] = ExpressionConverter.ConvertO(bodytaskroleId);
                taskObjectpropCount++;
            }

            if (bodytaskgoalId != null)
            {
                taskObject["goal_id"] = ExpressionConverter.ConvertO(bodytaskgoalId);
                taskObjectpropCount++;
            }

            if (bodytaskstartDate != null)
            {
                taskObject["start_date"] = ExpressionConverter.ConvertO(bodytaskstartDate);
                taskObjectpropCount++;
            }

            if (bodytaskdueDate != null)
            {
                taskObject["due_date"] = ExpressionConverter.ConvertO(bodytaskdueDate);
                taskObjectpropCount++;
            }

            if (bodytaskweightId != null)
            {
                taskObject["weight_id"] = ExpressionConverter.ConvertO(bodytaskweightId);
                taskObjectpropCount++;
            }

            if (bodytaskentityTemplateId != null)
            {
                taskObject["entity_template_id"] = ExpressionConverter.ConvertO(bodytaskentityTemplateId);
                taskObjectpropCount++;
            }

            if (taskObjectpropCount > 0)
            {
                body["task"] = taskObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleTaskResponse> GetSingleTask([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodytasktask = null, [WorkflowExpression] Func<string> bodytaskcomment = null, [WorkflowExpression] Func<bodytaskisCompleteInput> bodytaskisComplete = null, [WorkflowExpression] Func<int> bodytaskroleId = null, [WorkflowExpression] Func<int> bodytaskgoalId = null, [WorkflowExpression] Func<string> bodytaskstartDate = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<bodytaskweightIdInput> bodytaskweightId = null, [WorkflowExpression] Func<int> bodytaskentityTemplateId = null)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var taskObject = new JObject();
            var taskObjectpropCount = 0;
            if (bodytasktask != null)
            {
                taskObject["task"] = ExpressionConverter.ConvertO(bodytasktask);
                taskObjectpropCount++;
            }

            if (bodytaskcomment != null)
            {
                taskObject["comment"] = ExpressionConverter.ConvertO(bodytaskcomment);
                taskObjectpropCount++;
            }

            if (bodytaskisComplete != null)
            {
                taskObject["is_complete"] = ExpressionConverter.ConvertO(bodytaskisComplete);
                taskObjectpropCount++;
            }

            if (bodytaskroleId != null)
            {
                taskObject["role_id"] = ExpressionConverter.ConvertO(bodytaskroleId);
                taskObjectpropCount++;
            }

            if (bodytaskgoalId != null)
            {
                taskObject["goal_id"] = ExpressionConverter.ConvertO(bodytaskgoalId);
                taskObjectpropCount++;
            }

            if (bodytaskstartDate != null)
            {
                taskObject["start_date"] = ExpressionConverter.ConvertO(bodytaskstartDate);
                taskObjectpropCount++;
            }

            if (bodytaskdueDate != null)
            {
                taskObject["due_date"] = ExpressionConverter.ConvertO(bodytaskdueDate);
                taskObjectpropCount++;
            }

            if (bodytaskweightId != null)
            {
                taskObject["weight_id"] = ExpressionConverter.ConvertO(bodytaskweightId);
                taskObjectpropCount++;
            }

            if (bodytaskentityTemplateId != null)
            {
                taskObject["entity_template_id"] = ExpressionConverter.ConvertO(bodytaskentityTemplateId);
                taskObjectpropCount++;
            }

            if (taskObjectpropCount > 0)
            {
                body["task"] = taskObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllUpdatesResponse> GetAllUpdates([WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = "/updates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetAllUpdatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyupdatecomment = null, [WorkflowExpression] Func<int> bodyupdategoalId = null, [WorkflowExpression] Func<int> bodyupdateentityTemplateId = null)
        {
            var apiCallPath = "/updates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var updateObject = new JObject();
            var updateObjectpropCount = 0;
            if (bodyupdatecomment != null)
            {
                updateObject["comment"] = ExpressionConverter.ConvertO(bodyupdatecomment);
                updateObjectpropCount++;
            }

            if (bodyupdategoalId != null)
            {
                updateObject["goal_id"] = ExpressionConverter.ConvertO(bodyupdategoalId);
                updateObjectpropCount++;
            }

            if (bodyupdateentityTemplateId != null)
            {
                updateObject["entity_template_id"] = ExpressionConverter.ConvertO(bodyupdateentityTemplateId);
                updateObjectpropCount++;
            }

            if (updateObjectpropCount > 0)
            {
                body["update"] = updateObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleUpdateResponse> GetSingleUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/updates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<GetSingleUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteUpdateResponse> DeleteUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            var apiCallPath = String.Format("/updates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            return new ApiConnectionAction<DeleteUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateUpdateResponse> UpdateUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyupdatecomment = null, [WorkflowExpression] Func<string> bodyupdatecreatedAt = null, [WorkflowExpression] Func<string> bodyupdateupdatedAt = null, [WorkflowExpression] Func<int> bodyupdategoalId = null, [WorkflowExpression] Func<int> bodyupdatedeleted = null, [WorkflowExpression] Func<int> bodyupdateentityTemplateId = null)
        {
            var apiCallPath = String.Format("/updates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Instance"] = ExpressionConverter.Convert(instance);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var updateObject = new JObject();
            var updateObjectpropCount = 0;
            if (bodyupdatecomment != null)
            {
                updateObject["comment"] = ExpressionConverter.ConvertO(bodyupdatecomment);
                updateObjectpropCount++;
            }

            if (bodyupdatecreatedAt != null)
            {
                updateObject["created_at"] = ExpressionConverter.ConvertO(bodyupdatecreatedAt);
                updateObjectpropCount++;
            }

            if (bodyupdateupdatedAt != null)
            {
                updateObject["updated_at"] = ExpressionConverter.ConvertO(bodyupdateupdatedAt);
                updateObjectpropCount++;
            }

            if (bodyupdategoalId != null)
            {
                updateObject["goal_id"] = ExpressionConverter.ConvertO(bodyupdategoalId);
                updateObjectpropCount++;
            }

            if (bodyupdatedeleted != null)
            {
                updateObject["deleted"] = ExpressionConverter.ConvertO(bodyupdatedeleted);
                updateObjectpropCount++;
            }

            if (bodyupdateentityTemplateId != null)
            {
                updateObject["entity_template_id"] = ExpressionConverter.ConvertO(bodyupdateentityTemplateId);
                updateObjectpropCount++;
            }

            if (updateObjectpropCount > 0)
            {
                body["update"] = updateObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateUpdateResponse>(callPayload);
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

    public enum bodygoalisPrivateInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
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
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    public enum bodytaskisCompleteInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum bodytaskweightIdInput
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