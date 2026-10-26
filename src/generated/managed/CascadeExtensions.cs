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
        public IBodyWorkflowAction<CreateGoalResponse, ApiConnectionActionConfiguration> CreateGoal(Expression<Func<string>> instance, Expression<Func<int>> bodygoalroleId = null, Expression<Func<int>> bodygoalcreatorId = null, Expression<Func<bodygoalstatusInput>> bodygoalstatus = null, Expression<Func<bodygoalcompletionCriteriaInput>> bodygoalcompletionCriteria = null, Expression<Func<bodygoaltargetFlowInput>> bodygoaltargetFlow = null, Expression<Func<string>> bodygoalaction = null, Expression<Func<string>> bodygoaldetails = null, Expression<Func<double>> bodygoalinitial = null, Expression<Func<double>> bodygoalprogress = null, Expression<Func<double>> bodygoaltarget = null, Expression<Func<string>> bodygoalstartTime = null, Expression<Func<string>> bodygoalendTime = null, Expression<Func<bodygoalweightIdInput>> bodygoalweightId = null, Expression<Func<bodygoalisPrivateInput>> bodygoalisPrivate = null, Expression<Func<bodygoaltrackingTypeInput>> bodygoaltrackingType = null, Expression<Func<int>> bodygoalentityTemplateId = null, Expression<Func<int[]>> bodygoaldirectFocusAreaIds = null, Expression<Func<int[]>> bodygoalalignedFromIds = null, Expression<Func<int[]>> bodygoalalignedToIds = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodygoalroleId = WorkflowExpression.Compile(bodygoalroleId, nameof(bodygoalroleId), required: false);
            var __workflow_bodygoalcreatorId = WorkflowExpression.Compile(bodygoalcreatorId, nameof(bodygoalcreatorId), required: false);
            var __workflow_bodygoalstatus = WorkflowExpression.Compile(bodygoalstatus, nameof(bodygoalstatus), required: false);
            var __workflow_bodygoalcompletionCriteria = WorkflowExpression.Compile(bodygoalcompletionCriteria, nameof(bodygoalcompletionCriteria), required: false);
            var __workflow_bodygoaltargetFlow = WorkflowExpression.Compile(bodygoaltargetFlow, nameof(bodygoaltargetFlow), required: false);
            var __workflow_bodygoalaction = WorkflowExpression.Compile(bodygoalaction, nameof(bodygoalaction), required: false);
            var __workflow_bodygoaldetails = WorkflowExpression.Compile(bodygoaldetails, nameof(bodygoaldetails), required: false);
            var __workflow_bodygoalinitial = WorkflowExpression.Compile(bodygoalinitial, nameof(bodygoalinitial), required: false);
            var __workflow_bodygoalprogress = WorkflowExpression.Compile(bodygoalprogress, nameof(bodygoalprogress), required: false);
            var __workflow_bodygoaltarget = WorkflowExpression.Compile(bodygoaltarget, nameof(bodygoaltarget), required: false);
            var __workflow_bodygoalstartTime = WorkflowExpression.Compile(bodygoalstartTime, nameof(bodygoalstartTime), required: false);
            var __workflow_bodygoalendTime = WorkflowExpression.Compile(bodygoalendTime, nameof(bodygoalendTime), required: false);
            var __workflow_bodygoalweightId = WorkflowExpression.Compile(bodygoalweightId, nameof(bodygoalweightId), required: false);
            var __workflow_bodygoalisPrivate = WorkflowExpression.Compile(bodygoalisPrivate, nameof(bodygoalisPrivate), required: false);
            var __workflow_bodygoaltrackingType = WorkflowExpression.Compile(bodygoaltrackingType, nameof(bodygoaltrackingType), required: false);
            var __workflow_bodygoalentityTemplateId = WorkflowExpression.Compile(bodygoalentityTemplateId, nameof(bodygoalentityTemplateId), required: false);
            var __workflow_bodygoaldirectFocusAreaIds = WorkflowExpression.Compile(bodygoaldirectFocusAreaIds, nameof(bodygoaldirectFocusAreaIds), required: false);
            var __workflow_bodygoalalignedFromIds = WorkflowExpression.Compile(bodygoalalignedFromIds, nameof(bodygoalalignedFromIds), required: false);
            var __workflow_bodygoalalignedToIds = WorkflowExpression.Compile(bodygoalalignedToIds, nameof(bodygoalalignedToIds), required: false);
            return new DeferredBodyAction<CreateGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/goals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                var body = new JObject();
                var bodypropCount = 0;
                var goalObject = new JObject();
                var goalObjectpropCount = 0;
                if (__workflow_bodygoalroleId != null)
                {
                    goalObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalroleId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalcreatorId != null)
                {
                    goalObject["creator_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalcreatorId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalstatus != null)
                {
                    goalObject["status"] = ExpressionConverter.ConvertO(__workflow_bodygoalstatus);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalcompletionCriteria != null)
                {
                    goalObject["completion_criteria"] = ExpressionConverter.ConvertO(__workflow_bodygoalcompletionCriteria);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltargetFlow != null)
                {
                    goalObject["target_flow"] = ExpressionConverter.ConvertO(__workflow_bodygoaltargetFlow);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalaction != null)
                {
                    goalObject["action"] = ExpressionConverter.ConvertO(__workflow_bodygoalaction);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaldetails != null)
                {
                    goalObject["details"] = ExpressionConverter.ConvertO(__workflow_bodygoaldetails);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalinitial != null)
                {
                    goalObject["initial"] = ExpressionConverter.ConvertO(__workflow_bodygoalinitial);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalprogress != null)
                {
                    goalObject["progress"] = ExpressionConverter.ConvertO(__workflow_bodygoalprogress);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltarget != null)
                {
                    goalObject["target"] = ExpressionConverter.ConvertO(__workflow_bodygoaltarget);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalstartTime != null)
                {
                    goalObject["start_time"] = ExpressionConverter.ConvertO(__workflow_bodygoalstartTime);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalendTime != null)
                {
                    goalObject["end_time"] = ExpressionConverter.ConvertO(__workflow_bodygoalendTime);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalweightId != null)
                {
                    goalObject["weight_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalweightId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalisPrivate != null)
                {
                    goalObject["is_private"] = ExpressionConverter.ConvertO(__workflow_bodygoalisPrivate);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltrackingType != null)
                {
                    goalObject["tracking_type"] = ExpressionConverter.ConvertO(__workflow_bodygoaltrackingType);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalentityTemplateId != null)
                {
                    goalObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalentityTemplateId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaldirectFocusAreaIds != null)
                {
                    goalObject["direct_focus_area_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoaldirectFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalalignedFromIds != null)
                {
                    goalObject["aligned_from_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoalalignedFromIds);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalalignedToIds != null)
                {
                    goalObject["aligned_to_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoalalignedToIds);
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
        public IBodyWorkflowAction<UpdateGoalResponse, ApiConnectionActionConfiguration> UpdateGoal(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<int>> bodygoalroleId = null, Expression<Func<int>> bodygoalcreatorId = null, Expression<Func<bodygoalstatusInput>> bodygoalstatus = null, Expression<Func<bodygoalcompletionCriteriaInput>> bodygoalcompletionCriteria = null, Expression<Func<bodygoaltargetFlowInput>> bodygoaltargetFlow = null, Expression<Func<string>> bodygoalaction = null, Expression<Func<string>> bodygoaldetails = null, Expression<Func<double>> bodygoalinitial = null, Expression<Func<double>> bodygoalprogress = null, Expression<Func<double>> bodygoaltarget = null, Expression<Func<string>> bodygoalstartTime = null, Expression<Func<string>> bodygoalendTime = null, Expression<Func<bodygoalweightIdInput>> bodygoalweightId = null, Expression<Func<int>> bodygoalisPrivate = null, Expression<Func<bodygoaltrackingTypeInput>> bodygoaltrackingType = null, Expression<Func<int>> bodygoalentityTemplateId = null, Expression<Func<int[]>> bodygoaldirectFocusAreaIds = null, Expression<Func<int[]>> bodygoalinheritedFocusAreaIds = null, Expression<Func<int[]>> bodygoalalignedFromIds = null, Expression<Func<int[]>> bodygoalalignedToIds = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodygoalroleId = WorkflowExpression.Compile(bodygoalroleId, nameof(bodygoalroleId), required: false);
            var __workflow_bodygoalcreatorId = WorkflowExpression.Compile(bodygoalcreatorId, nameof(bodygoalcreatorId), required: false);
            var __workflow_bodygoalstatus = WorkflowExpression.Compile(bodygoalstatus, nameof(bodygoalstatus), required: false);
            var __workflow_bodygoalcompletionCriteria = WorkflowExpression.Compile(bodygoalcompletionCriteria, nameof(bodygoalcompletionCriteria), required: false);
            var __workflow_bodygoaltargetFlow = WorkflowExpression.Compile(bodygoaltargetFlow, nameof(bodygoaltargetFlow), required: false);
            var __workflow_bodygoalaction = WorkflowExpression.Compile(bodygoalaction, nameof(bodygoalaction), required: false);
            var __workflow_bodygoaldetails = WorkflowExpression.Compile(bodygoaldetails, nameof(bodygoaldetails), required: false);
            var __workflow_bodygoalinitial = WorkflowExpression.Compile(bodygoalinitial, nameof(bodygoalinitial), required: false);
            var __workflow_bodygoalprogress = WorkflowExpression.Compile(bodygoalprogress, nameof(bodygoalprogress), required: false);
            var __workflow_bodygoaltarget = WorkflowExpression.Compile(bodygoaltarget, nameof(bodygoaltarget), required: false);
            var __workflow_bodygoalstartTime = WorkflowExpression.Compile(bodygoalstartTime, nameof(bodygoalstartTime), required: false);
            var __workflow_bodygoalendTime = WorkflowExpression.Compile(bodygoalendTime, nameof(bodygoalendTime), required: false);
            var __workflow_bodygoalweightId = WorkflowExpression.Compile(bodygoalweightId, nameof(bodygoalweightId), required: false);
            var __workflow_bodygoalisPrivate = WorkflowExpression.Compile(bodygoalisPrivate, nameof(bodygoalisPrivate), required: false);
            var __workflow_bodygoaltrackingType = WorkflowExpression.Compile(bodygoaltrackingType, nameof(bodygoaltrackingType), required: false);
            var __workflow_bodygoalentityTemplateId = WorkflowExpression.Compile(bodygoalentityTemplateId, nameof(bodygoalentityTemplateId), required: false);
            var __workflow_bodygoaldirectFocusAreaIds = WorkflowExpression.Compile(bodygoaldirectFocusAreaIds, nameof(bodygoaldirectFocusAreaIds), required: false);
            var __workflow_bodygoalinheritedFocusAreaIds = WorkflowExpression.Compile(bodygoalinheritedFocusAreaIds, nameof(bodygoalinheritedFocusAreaIds), required: false);
            var __workflow_bodygoalalignedFromIds = WorkflowExpression.Compile(bodygoalalignedFromIds, nameof(bodygoalalignedFromIds), required: false);
            var __workflow_bodygoalalignedToIds = WorkflowExpression.Compile(bodygoalalignedToIds, nameof(bodygoalalignedToIds), required: false);
            return new DeferredBodyAction<UpdateGoalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/goals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                var body = new JObject();
                var bodypropCount = 0;
                var goalObject = new JObject();
                var goalObjectpropCount = 0;
                if (__workflow_bodygoalroleId != null)
                {
                    goalObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalroleId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalcreatorId != null)
                {
                    goalObject["creator_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalcreatorId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalstatus != null)
                {
                    goalObject["status"] = ExpressionConverter.ConvertO(__workflow_bodygoalstatus);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalcompletionCriteria != null)
                {
                    goalObject["completion_criteria"] = ExpressionConverter.ConvertO(__workflow_bodygoalcompletionCriteria);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltargetFlow != null)
                {
                    goalObject["target_flow"] = ExpressionConverter.ConvertO(__workflow_bodygoaltargetFlow);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalaction != null)
                {
                    goalObject["action"] = ExpressionConverter.ConvertO(__workflow_bodygoalaction);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaldetails != null)
                {
                    goalObject["details"] = ExpressionConverter.ConvertO(__workflow_bodygoaldetails);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalinitial != null)
                {
                    goalObject["initial"] = ExpressionConverter.ConvertO(__workflow_bodygoalinitial);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalprogress != null)
                {
                    goalObject["progress"] = ExpressionConverter.ConvertO(__workflow_bodygoalprogress);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltarget != null)
                {
                    goalObject["target"] = ExpressionConverter.ConvertO(__workflow_bodygoaltarget);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalstartTime != null)
                {
                    goalObject["start_time"] = ExpressionConverter.ConvertO(__workflow_bodygoalstartTime);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalendTime != null)
                {
                    goalObject["end_time"] = ExpressionConverter.ConvertO(__workflow_bodygoalendTime);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalweightId != null)
                {
                    goalObject["weight_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalweightId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalisPrivate != null)
                {
                    goalObject["is_private"] = ExpressionConverter.ConvertO(__workflow_bodygoalisPrivate);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaltrackingType != null)
                {
                    goalObject["tracking_type"] = ExpressionConverter.ConvertO(__workflow_bodygoaltrackingType);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalentityTemplateId != null)
                {
                    goalObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodygoalentityTemplateId);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoaldirectFocusAreaIds != null)
                {
                    goalObject["direct_focus_area_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoaldirectFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalinheritedFocusAreaIds != null)
                {
                    goalObject["inherited_focus_area_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoalinheritedFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalalignedFromIds != null)
                {
                    goalObject["aligned_from_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoalalignedFromIds);
                    goalObjectpropCount++;
                }

                if (__workflow_bodygoalalignedToIds != null)
                {
                    goalObject["aligned_to_ids"] = ExpressionConverter.ConvertO(__workflow_bodygoalalignedToIds);
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
        public IBodyWorkflowAction<CreateRiskResponse, ApiConnectionActionConfiguration> CreateRisk(Expression<Func<string>> instance, Expression<Func<string>> bodyissueissue = null, Expression<Func<bodyissueisCriticalInput>> bodyissueisCritical = null, Expression<Func<bodyissueisResolvedInput>> bodyissueisResolved = null, Expression<Func<int>> bodyissueroleId = null, Expression<Func<int>> bodyissuegoalId = null, Expression<Func<string>> bodyissuedueDate = null, Expression<Func<int>> bodyissueentityTemplateId = null, Expression<Func<int>> bodyissuecustomAttributescA1573011281053 = null, Expression<Func<int>> bodyissuecustomAttributescA1573011296755 = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyissueissue = WorkflowExpression.Compile(bodyissueissue, nameof(bodyissueissue), required: false);
            var __workflow_bodyissueisCritical = WorkflowExpression.Compile(bodyissueisCritical, nameof(bodyissueisCritical), required: false);
            var __workflow_bodyissueisResolved = WorkflowExpression.Compile(bodyissueisResolved, nameof(bodyissueisResolved), required: false);
            var __workflow_bodyissueroleId = WorkflowExpression.Compile(bodyissueroleId, nameof(bodyissueroleId), required: false);
            var __workflow_bodyissuegoalId = WorkflowExpression.Compile(bodyissuegoalId, nameof(bodyissuegoalId), required: false);
            var __workflow_bodyissuedueDate = WorkflowExpression.Compile(bodyissuedueDate, nameof(bodyissuedueDate), required: false);
            var __workflow_bodyissueentityTemplateId = WorkflowExpression.Compile(bodyissueentityTemplateId, nameof(bodyissueentityTemplateId), required: false);
            var __workflow_bodyissuecustomAttributescA1573011281053 = WorkflowExpression.Compile(bodyissuecustomAttributescA1573011281053, nameof(bodyissuecustomAttributescA1573011281053), required: false);
            var __workflow_bodyissuecustomAttributescA1573011296755 = WorkflowExpression.Compile(bodyissuecustomAttributescA1573011296755, nameof(bodyissuecustomAttributescA1573011296755), required: false);
            return new DeferredBodyAction<CreateRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                var body = new JObject();
                var bodypropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (__workflow_bodyissueissue != null)
                {
                    issueObject["issue"] = ExpressionConverter.ConvertO(__workflow_bodyissueissue);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueisCritical != null)
                {
                    issueObject["is_critical"] = ExpressionConverter.ConvertO(__workflow_bodyissueisCritical);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueisResolved != null)
                {
                    issueObject["is_resolved"] = ExpressionConverter.ConvertO(__workflow_bodyissueisResolved);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueroleId != null)
                {
                    issueObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodyissueroleId);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissuegoalId != null)
                {
                    issueObject["goal_id"] = ExpressionConverter.ConvertO(__workflow_bodyissuegoalId);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissuedueDate != null)
                {
                    issueObject["due_date"] = ExpressionConverter.ConvertO(__workflow_bodyissuedueDate);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueentityTemplateId != null)
                {
                    issueObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodyissueentityTemplateId);
                    issueObjectpropCount++;
                }

                var customAttributesObject = new JObject();
                var customAttributesObjectpropCount = 0;
                if (__workflow_bodyissuecustomAttributescA1573011281053 != null)
                {
                    customAttributesObject["CA1573011281053"] = ExpressionConverter.ConvertO(__workflow_bodyissuecustomAttributescA1573011281053);
                    customAttributesObjectpropCount++;
                }

                if (__workflow_bodyissuecustomAttributescA1573011296755 != null)
                {
                    customAttributesObject["CA1573011296755"] = ExpressionConverter.ConvertO(__workflow_bodyissuecustomAttributescA1573011296755);
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
        public IBodyWorkflowAction<UpdateRiskResponse, ApiConnectionActionConfiguration> UpdateRisk(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<string>> bodyissueissue = null, Expression<Func<bodyissueisCriticalInput>> bodyissueisCritical = null, Expression<Func<bodyissueisResolvedInput>> bodyissueisResolved = null, Expression<Func<int>> bodyissueroleId = null, Expression<Func<string>> bodyissuedueDate = null, Expression<Func<int>> bodyissueentityTemplateId = null, Expression<Func<int>> bodyissuecustomAttributescA1573011281053 = null, Expression<Func<int>> bodyissuecustomAttributescA1573011296755 = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyissueissue = WorkflowExpression.Compile(bodyissueissue, nameof(bodyissueissue), required: false);
            var __workflow_bodyissueisCritical = WorkflowExpression.Compile(bodyissueisCritical, nameof(bodyissueisCritical), required: false);
            var __workflow_bodyissueisResolved = WorkflowExpression.Compile(bodyissueisResolved, nameof(bodyissueisResolved), required: false);
            var __workflow_bodyissueroleId = WorkflowExpression.Compile(bodyissueroleId, nameof(bodyissueroleId), required: false);
            var __workflow_bodyissuedueDate = WorkflowExpression.Compile(bodyissuedueDate, nameof(bodyissuedueDate), required: false);
            var __workflow_bodyissueentityTemplateId = WorkflowExpression.Compile(bodyissueentityTemplateId, nameof(bodyissueentityTemplateId), required: false);
            var __workflow_bodyissuecustomAttributescA1573011281053 = WorkflowExpression.Compile(bodyissuecustomAttributescA1573011281053, nameof(bodyissuecustomAttributescA1573011281053), required: false);
            var __workflow_bodyissuecustomAttributescA1573011296755 = WorkflowExpression.Compile(bodyissuecustomAttributescA1573011296755, nameof(bodyissuecustomAttributescA1573011296755), required: false);
            return new DeferredBodyAction<UpdateRiskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/issues/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                var body = new JObject();
                var bodypropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (__workflow_bodyissueissue != null)
                {
                    issueObject["issue"] = ExpressionConverter.ConvertO(__workflow_bodyissueissue);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueisCritical != null)
                {
                    issueObject["is_critical"] = ExpressionConverter.ConvertO(__workflow_bodyissueisCritical);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueisResolved != null)
                {
                    issueObject["is_resolved"] = ExpressionConverter.ConvertO(__workflow_bodyissueisResolved);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueroleId != null)
                {
                    issueObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodyissueroleId);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissuedueDate != null)
                {
                    issueObject["due_date"] = ExpressionConverter.ConvertO(__workflow_bodyissuedueDate);
                    issueObjectpropCount++;
                }

                if (__workflow_bodyissueentityTemplateId != null)
                {
                    issueObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodyissueentityTemplateId);
                    issueObjectpropCount++;
                }

                var customAttributesObject = new JObject();
                var customAttributesObjectpropCount = 0;
                if (__workflow_bodyissuecustomAttributescA1573011281053 != null)
                {
                    customAttributesObject["CA1573011281053"] = ExpressionConverter.ConvertO(__workflow_bodyissuecustomAttributescA1573011281053);
                    customAttributesObjectpropCount++;
                }

                if (__workflow_bodyissuecustomAttributescA1573011296755 != null)
                {
                    customAttributesObject["CA1573011296755"] = ExpressionConverter.ConvertO(__workflow_bodyissuecustomAttributescA1573011296755);
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
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> instance, Expression<Func<string>> bodytasktask = null, Expression<Func<string>> bodytaskcomment = null, Expression<Func<bodytaskisCompleteInput>> bodytaskisComplete = null, Expression<Func<int>> bodytaskroleId = null, Expression<Func<int>> bodytaskgoalId = null, Expression<Func<string>> bodytaskstartDate = null, Expression<Func<string>> bodytaskdueDate = null, Expression<Func<bodytaskweightIdInput>> bodytaskweightId = null, Expression<Func<int>> bodytaskentityTemplateId = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodytasktask = WorkflowExpression.Compile(bodytasktask, nameof(bodytasktask), required: false);
            var __workflow_bodytaskcomment = WorkflowExpression.Compile(bodytaskcomment, nameof(bodytaskcomment), required: false);
            var __workflow_bodytaskisComplete = WorkflowExpression.Compile(bodytaskisComplete, nameof(bodytaskisComplete), required: false);
            var __workflow_bodytaskroleId = WorkflowExpression.Compile(bodytaskroleId, nameof(bodytaskroleId), required: false);
            var __workflow_bodytaskgoalId = WorkflowExpression.Compile(bodytaskgoalId, nameof(bodytaskgoalId), required: false);
            var __workflow_bodytaskstartDate = WorkflowExpression.Compile(bodytaskstartDate, nameof(bodytaskstartDate), required: false);
            var __workflow_bodytaskdueDate = WorkflowExpression.Compile(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            var __workflow_bodytaskweightId = WorkflowExpression.Compile(bodytaskweightId, nameof(bodytaskweightId), required: false);
            var __workflow_bodytaskentityTemplateId = WorkflowExpression.Compile(bodytaskentityTemplateId, nameof(bodytaskentityTemplateId), required: false);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (__workflow_bodytasktask != null)
                {
                    taskObject["task"] = ExpressionConverter.ConvertO(__workflow_bodytasktask);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskcomment != null)
                {
                    taskObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodytaskcomment);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskisComplete != null)
                {
                    taskObject["is_complete"] = ExpressionConverter.ConvertO(__workflow_bodytaskisComplete);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskroleId != null)
                {
                    taskObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskroleId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskgoalId != null)
                {
                    taskObject["goal_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskgoalId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskstartDate != null)
                {
                    taskObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodytaskstartDate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskdueDate != null)
                {
                    taskObject["due_date"] = ExpressionConverter.ConvertO(__workflow_bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskweightId != null)
                {
                    taskObject["weight_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskweightId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskentityTemplateId != null)
                {
                    taskObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskentityTemplateId);
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
        public IBodyWorkflowAction<UpdateTaskResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<string>> bodytasktask = null, Expression<Func<string>> bodytaskcomment = null, Expression<Func<bodytaskisCompleteInput>> bodytaskisComplete = null, Expression<Func<int>> bodytaskroleId = null, Expression<Func<int>> bodytaskgoalId = null, Expression<Func<string>> bodytaskstartDate = null, Expression<Func<string>> bodytaskdueDate = null, Expression<Func<bodytaskweightIdInput>> bodytaskweightId = null, Expression<Func<int>> bodytaskentityTemplateId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodytasktask = WorkflowExpression.Compile(bodytasktask, nameof(bodytasktask), required: false);
            var __workflow_bodytaskcomment = WorkflowExpression.Compile(bodytaskcomment, nameof(bodytaskcomment), required: false);
            var __workflow_bodytaskisComplete = WorkflowExpression.Compile(bodytaskisComplete, nameof(bodytaskisComplete), required: false);
            var __workflow_bodytaskroleId = WorkflowExpression.Compile(bodytaskroleId, nameof(bodytaskroleId), required: false);
            var __workflow_bodytaskgoalId = WorkflowExpression.Compile(bodytaskgoalId, nameof(bodytaskgoalId), required: false);
            var __workflow_bodytaskstartDate = WorkflowExpression.Compile(bodytaskstartDate, nameof(bodytaskstartDate), required: false);
            var __workflow_bodytaskdueDate = WorkflowExpression.Compile(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            var __workflow_bodytaskweightId = WorkflowExpression.Compile(bodytaskweightId, nameof(bodytaskweightId), required: false);
            var __workflow_bodytaskentityTemplateId = WorkflowExpression.Compile(bodytaskentityTemplateId, nameof(bodytaskentityTemplateId), required: false);
            return new DeferredBodyAction<UpdateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (__workflow_bodytasktask != null)
                {
                    taskObject["task"] = ExpressionConverter.ConvertO(__workflow_bodytasktask);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskcomment != null)
                {
                    taskObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodytaskcomment);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskisComplete != null)
                {
                    taskObject["is_complete"] = ExpressionConverter.ConvertO(__workflow_bodytaskisComplete);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskroleId != null)
                {
                    taskObject["role_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskroleId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskgoalId != null)
                {
                    taskObject["goal_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskgoalId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskstartDate != null)
                {
                    taskObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodytaskstartDate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskdueDate != null)
                {
                    taskObject["due_date"] = ExpressionConverter.ConvertO(__workflow_bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskweightId != null)
                {
                    taskObject["weight_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskweightId);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskentityTemplateId != null)
                {
                    taskObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskentityTemplateId);
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
        public IBodyWorkflowAction<CreateUpdateResponse, ApiConnectionActionConfiguration> CreateUpdate(Expression<Func<string>> instance, Expression<Func<string>> bodyupdatecomment = null, Expression<Func<int>> bodyupdategoalId = null, Expression<Func<int>> bodyupdateentityTemplateId = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyupdatecomment = WorkflowExpression.Compile(bodyupdatecomment, nameof(bodyupdatecomment), required: false);
            var __workflow_bodyupdategoalId = WorkflowExpression.Compile(bodyupdategoalId, nameof(bodyupdategoalId), required: false);
            var __workflow_bodyupdateentityTemplateId = WorkflowExpression.Compile(bodyupdateentityTemplateId, nameof(bodyupdateentityTemplateId), required: false);
            return new DeferredBodyAction<CreateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (__workflow_bodyupdatecomment != null)
                {
                    updateObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodyupdatecomment);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdategoalId != null)
                {
                    updateObject["goal_id"] = ExpressionConverter.ConvertO(__workflow_bodyupdategoalId);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdateentityTemplateId != null)
                {
                    updateObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodyupdateentityTemplateId);
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
        public IBodyWorkflowAction<UpdateUpdateResponse, ApiConnectionActionConfiguration> UpdateUpdate(Expression<Func<string>> id, Expression<Func<string>> instance, Expression<Func<string>> bodyupdatecomment = null, Expression<Func<string>> bodyupdatecreatedAt = null, Expression<Func<string>> bodyupdateupdatedAt = null, Expression<Func<int>> bodyupdategoalId = null, Expression<Func<int>> bodyupdatedeleted = null, Expression<Func<int>> bodyupdateentityTemplateId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyupdatecomment = WorkflowExpression.Compile(bodyupdatecomment, nameof(bodyupdatecomment), required: false);
            var __workflow_bodyupdatecreatedAt = WorkflowExpression.Compile(bodyupdatecreatedAt, nameof(bodyupdatecreatedAt), required: false);
            var __workflow_bodyupdateupdatedAt = WorkflowExpression.Compile(bodyupdateupdatedAt, nameof(bodyupdateupdatedAt), required: false);
            var __workflow_bodyupdategoalId = WorkflowExpression.Compile(bodyupdategoalId, nameof(bodyupdategoalId), required: false);
            var __workflow_bodyupdatedeleted = WorkflowExpression.Compile(bodyupdatedeleted, nameof(bodyupdatedeleted), required: false);
            var __workflow_bodyupdateentityTemplateId = WorkflowExpression.Compile(bodyupdateentityTemplateId, nameof(bodyupdateentityTemplateId), required: false);
            return new DeferredBodyAction<UpdateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = ExpressionConverter.Convert(__workflow_instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (__workflow_bodyupdatecomment != null)
                {
                    updateObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodyupdatecomment);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdatecreatedAt != null)
                {
                    updateObject["created_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatecreatedAt);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdateupdatedAt != null)
                {
                    updateObject["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdateupdatedAt);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdategoalId != null)
                {
                    updateObject["goal_id"] = ExpressionConverter.ConvertO(__workflow_bodyupdategoalId);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdatedeleted != null)
                {
                    updateObject["deleted"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedeleted);
                    updateObjectpropCount++;
                }

                if (__workflow_bodyupdateentityTemplateId != null)
                {
                    updateObject["entity_template_id"] = ExpressionConverter.ConvertO(__workflow_bodyupdateentityTemplateId);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygoalstatusInput
    {
        APPRO,
        DRAFT,
        ARCHI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygoalcompletionCriteriaInput
    {
        [EnumMember(Value = "TARGET-REACHED")]
        TARGETREACHED,
        [EnumMember(Value = "TARGET-DEADLINE-REACHED")]
        TARGETDEADLINEREACHED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygoaltargetFlowInput
    {
        OVER,
        UNDER,
        NONE
    }

    public enum bodygoalweightIdInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public enum bodygoalisPrivateInput
    {
        _0 = 0,
        _1 = 1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        _0 = 0,
        _1 = 1
    }

    public enum bodyissueisResolvedInput
    {
        _0 = 0,
        _1 = 1
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
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public enum bodytaskisCompleteInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum bodytaskweightIdInput
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