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
        public IBodyWorkflowAction<GetAllGoalsResponse> GetAllGoals([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllGoalsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateGoalResponse> CreateGoal([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> bodygoalroleId = null, [WorkflowExpression] Func<int> bodygoalcreatorId = null, [WorkflowExpression] Func<bodygoalstatusInput> bodygoalstatus = null, [WorkflowExpression] Func<bodygoalcompletionCriteriaInput> bodygoalcompletionCriteria = null, [WorkflowExpression] Func<bodygoaltargetFlowInput> bodygoaltargetFlow = null, [WorkflowExpression] Func<string> bodygoalaction = null, [WorkflowExpression] Func<string> bodygoaldetails = null, [WorkflowExpression] Func<double> bodygoalinitial = null, [WorkflowExpression] Func<double> bodygoalprogress = null, [WorkflowExpression] Func<double> bodygoaltarget = null, [WorkflowExpression] Func<string> bodygoalstartTime = null, [WorkflowExpression] Func<string> bodygoalendTime = null, [WorkflowExpression] Func<bodygoalweightIdInput> bodygoalweightId = null, [WorkflowExpression] Func<bodygoalisPrivateInput> bodygoalisPrivate = null, [WorkflowExpression] Func<bodygoaltrackingTypeInput> bodygoaltrackingType = null, [WorkflowExpression] Func<int> bodygoalentityTemplateId = null, [WorkflowExpression] Func<int[]> bodygoaldirectFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedFromIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedToIds = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodygoalroleId, nameof(bodygoalroleId), required: false);
            SourceExpression.Validate(bodygoalcreatorId, nameof(bodygoalcreatorId), required: false);
            SourceExpression.Validate(bodygoalstatus, nameof(bodygoalstatus), required: false);
            SourceExpression.Validate(bodygoalcompletionCriteria, nameof(bodygoalcompletionCriteria), required: false);
            SourceExpression.Validate(bodygoaltargetFlow, nameof(bodygoaltargetFlow), required: false);
            SourceExpression.Validate(bodygoalaction, nameof(bodygoalaction), required: false);
            SourceExpression.Validate(bodygoaldetails, nameof(bodygoaldetails), required: false);
            SourceExpression.Validate(bodygoalinitial, nameof(bodygoalinitial), required: false);
            SourceExpression.Validate(bodygoalprogress, nameof(bodygoalprogress), required: false);
            SourceExpression.Validate(bodygoaltarget, nameof(bodygoaltarget), required: false);
            SourceExpression.Validate(bodygoalstartTime, nameof(bodygoalstartTime), required: false);
            SourceExpression.Validate(bodygoalendTime, nameof(bodygoalendTime), required: false);
            SourceExpression.Validate(bodygoalweightId, nameof(bodygoalweightId), required: false);
            SourceExpression.Validate(bodygoalisPrivate, nameof(bodygoalisPrivate), required: false);
            SourceExpression.Validate(bodygoaltrackingType, nameof(bodygoaltrackingType), required: false);
            SourceExpression.Validate(bodygoalentityTemplateId, nameof(bodygoalentityTemplateId), required: false);
            SourceExpression.Validate(bodygoaldirectFocusAreaIds, nameof(bodygoaldirectFocusAreaIds), required: false);
            SourceExpression.Validate(bodygoalalignedFromIds, nameof(bodygoalalignedFromIds), required: false);
            SourceExpression.Validate(bodygoalalignedToIds, nameof(bodygoalalignedToIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                var body = new JObject();
                var bodypropCount = 0;
                var goalObject = new JObject();
                var goalObjectpropCount = 0;
                if (bodygoalroleId != null)
                {
                    goalObject["role_id"] = SourceExpressionConverter.ConvertToken(bodygoalroleId);
                    goalObjectpropCount++;
                }

                if (bodygoalcreatorId != null)
                {
                    goalObject["creator_id"] = SourceExpressionConverter.ConvertToken(bodygoalcreatorId);
                    goalObjectpropCount++;
                }

                if (bodygoalstatus != null)
                {
                    goalObject["status"] = SourceExpressionConverter.Convert(bodygoalstatus);
                    goalObjectpropCount++;
                }

                if (bodygoalcompletionCriteria != null)
                {
                    goalObject["completion_criteria"] = SourceExpressionConverter.Convert(bodygoalcompletionCriteria);
                    goalObjectpropCount++;
                }

                if (bodygoaltargetFlow != null)
                {
                    goalObject["target_flow"] = SourceExpressionConverter.Convert(bodygoaltargetFlow);
                    goalObjectpropCount++;
                }

                if (bodygoalaction != null)
                {
                    goalObject["action"] = SourceExpressionConverter.ConvertToken(bodygoalaction);
                    goalObjectpropCount++;
                }

                if (bodygoaldetails != null)
                {
                    goalObject["details"] = SourceExpressionConverter.ConvertToken(bodygoaldetails);
                    goalObjectpropCount++;
                }

                if (bodygoalinitial != null)
                {
                    goalObject["initial"] = SourceExpressionConverter.ConvertToken(bodygoalinitial);
                    goalObjectpropCount++;
                }

                if (bodygoalprogress != null)
                {
                    goalObject["progress"] = SourceExpressionConverter.ConvertToken(bodygoalprogress);
                    goalObjectpropCount++;
                }

                if (bodygoaltarget != null)
                {
                    goalObject["target"] = SourceExpressionConverter.ConvertToken(bodygoaltarget);
                    goalObjectpropCount++;
                }

                if (bodygoalstartTime != null)
                {
                    goalObject["start_time"] = SourceExpressionConverter.ConvertToken(bodygoalstartTime);
                    goalObjectpropCount++;
                }

                if (bodygoalendTime != null)
                {
                    goalObject["end_time"] = SourceExpressionConverter.ConvertToken(bodygoalendTime);
                    goalObjectpropCount++;
                }

                if (bodygoalweightId != null)
                {
                    goalObject["weight_id"] = SourceExpressionConverter.Convert(bodygoalweightId);
                    goalObjectpropCount++;
                }

                if (bodygoalisPrivate != null)
                {
                    goalObject["is_private"] = SourceExpressionConverter.Convert(bodygoalisPrivate);
                    goalObjectpropCount++;
                }

                if (bodygoaltrackingType != null)
                {
                    goalObject["tracking_type"] = SourceExpressionConverter.Convert(bodygoaltrackingType);
                    goalObjectpropCount++;
                }

                if (bodygoalentityTemplateId != null)
                {
                    goalObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodygoalentityTemplateId);
                    goalObjectpropCount++;
                }

                if (bodygoaldirectFocusAreaIds != null)
                {
                    goalObject["direct_focus_area_ids"] = SourceExpressionConverter.ConvertToken(bodygoaldirectFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (bodygoalalignedFromIds != null)
                {
                    goalObject["aligned_from_ids"] = SourceExpressionConverter.ConvertToken(bodygoalalignedFromIds);
                    goalObjectpropCount++;
                }

                if (bodygoalalignedToIds != null)
                {
                    goalObject["aligned_to_ids"] = SourceExpressionConverter.ConvertToken(bodygoalalignedToIds);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleGoalResponse> GetSingleGoal([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/goals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteGoalResponse> DeleteGoal([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/goals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateGoalResponse> UpdateGoal([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> bodygoalroleId = null, [WorkflowExpression] Func<int> bodygoalcreatorId = null, [WorkflowExpression] Func<bodygoalstatusInput> bodygoalstatus = null, [WorkflowExpression] Func<bodygoalcompletionCriteriaInput> bodygoalcompletionCriteria = null, [WorkflowExpression] Func<bodygoaltargetFlowInput> bodygoaltargetFlow = null, [WorkflowExpression] Func<string> bodygoalaction = null, [WorkflowExpression] Func<string> bodygoaldetails = null, [WorkflowExpression] Func<double> bodygoalinitial = null, [WorkflowExpression] Func<double> bodygoalprogress = null, [WorkflowExpression] Func<double> bodygoaltarget = null, [WorkflowExpression] Func<string> bodygoalstartTime = null, [WorkflowExpression] Func<string> bodygoalendTime = null, [WorkflowExpression] Func<bodygoalweightIdInput> bodygoalweightId = null, [WorkflowExpression] Func<int> bodygoalisPrivate = null, [WorkflowExpression] Func<bodygoaltrackingTypeInput> bodygoaltrackingType = null, [WorkflowExpression] Func<int> bodygoalentityTemplateId = null, [WorkflowExpression] Func<int[]> bodygoaldirectFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalinheritedFocusAreaIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedFromIds = null, [WorkflowExpression] Func<int[]> bodygoalalignedToIds = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodygoalroleId, nameof(bodygoalroleId), required: false);
            SourceExpression.Validate(bodygoalcreatorId, nameof(bodygoalcreatorId), required: false);
            SourceExpression.Validate(bodygoalstatus, nameof(bodygoalstatus), required: false);
            SourceExpression.Validate(bodygoalcompletionCriteria, nameof(bodygoalcompletionCriteria), required: false);
            SourceExpression.Validate(bodygoaltargetFlow, nameof(bodygoaltargetFlow), required: false);
            SourceExpression.Validate(bodygoalaction, nameof(bodygoalaction), required: false);
            SourceExpression.Validate(bodygoaldetails, nameof(bodygoaldetails), required: false);
            SourceExpression.Validate(bodygoalinitial, nameof(bodygoalinitial), required: false);
            SourceExpression.Validate(bodygoalprogress, nameof(bodygoalprogress), required: false);
            SourceExpression.Validate(bodygoaltarget, nameof(bodygoaltarget), required: false);
            SourceExpression.Validate(bodygoalstartTime, nameof(bodygoalstartTime), required: false);
            SourceExpression.Validate(bodygoalendTime, nameof(bodygoalendTime), required: false);
            SourceExpression.Validate(bodygoalweightId, nameof(bodygoalweightId), required: false);
            SourceExpression.Validate(bodygoalisPrivate, nameof(bodygoalisPrivate), required: false);
            SourceExpression.Validate(bodygoaltrackingType, nameof(bodygoaltrackingType), required: false);
            SourceExpression.Validate(bodygoalentityTemplateId, nameof(bodygoalentityTemplateId), required: false);
            SourceExpression.Validate(bodygoaldirectFocusAreaIds, nameof(bodygoaldirectFocusAreaIds), required: false);
            SourceExpression.Validate(bodygoalinheritedFocusAreaIds, nameof(bodygoalinheritedFocusAreaIds), required: false);
            SourceExpression.Validate(bodygoalalignedFromIds, nameof(bodygoalalignedFromIds), required: false);
            SourceExpression.Validate(bodygoalalignedToIds, nameof(bodygoalalignedToIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/goals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                var body = new JObject();
                var bodypropCount = 0;
                var goalObject = new JObject();
                var goalObjectpropCount = 0;
                if (bodygoalroleId != null)
                {
                    goalObject["role_id"] = SourceExpressionConverter.ConvertToken(bodygoalroleId);
                    goalObjectpropCount++;
                }

                if (bodygoalcreatorId != null)
                {
                    goalObject["creator_id"] = SourceExpressionConverter.ConvertToken(bodygoalcreatorId);
                    goalObjectpropCount++;
                }

                if (bodygoalstatus != null)
                {
                    goalObject["status"] = SourceExpressionConverter.Convert(bodygoalstatus);
                    goalObjectpropCount++;
                }

                if (bodygoalcompletionCriteria != null)
                {
                    goalObject["completion_criteria"] = SourceExpressionConverter.Convert(bodygoalcompletionCriteria);
                    goalObjectpropCount++;
                }

                if (bodygoaltargetFlow != null)
                {
                    goalObject["target_flow"] = SourceExpressionConverter.Convert(bodygoaltargetFlow);
                    goalObjectpropCount++;
                }

                if (bodygoalaction != null)
                {
                    goalObject["action"] = SourceExpressionConverter.ConvertToken(bodygoalaction);
                    goalObjectpropCount++;
                }

                if (bodygoaldetails != null)
                {
                    goalObject["details"] = SourceExpressionConverter.ConvertToken(bodygoaldetails);
                    goalObjectpropCount++;
                }

                if (bodygoalinitial != null)
                {
                    goalObject["initial"] = SourceExpressionConverter.ConvertToken(bodygoalinitial);
                    goalObjectpropCount++;
                }

                if (bodygoalprogress != null)
                {
                    goalObject["progress"] = SourceExpressionConverter.ConvertToken(bodygoalprogress);
                    goalObjectpropCount++;
                }

                if (bodygoaltarget != null)
                {
                    goalObject["target"] = SourceExpressionConverter.ConvertToken(bodygoaltarget);
                    goalObjectpropCount++;
                }

                if (bodygoalstartTime != null)
                {
                    goalObject["start_time"] = SourceExpressionConverter.ConvertToken(bodygoalstartTime);
                    goalObjectpropCount++;
                }

                if (bodygoalendTime != null)
                {
                    goalObject["end_time"] = SourceExpressionConverter.ConvertToken(bodygoalendTime);
                    goalObjectpropCount++;
                }

                if (bodygoalweightId != null)
                {
                    goalObject["weight_id"] = SourceExpressionConverter.Convert(bodygoalweightId);
                    goalObjectpropCount++;
                }

                if (bodygoalisPrivate != null)
                {
                    goalObject["is_private"] = SourceExpressionConverter.ConvertToken(bodygoalisPrivate);
                    goalObjectpropCount++;
                }

                if (bodygoaltrackingType != null)
                {
                    goalObject["tracking_type"] = SourceExpressionConverter.Convert(bodygoaltrackingType);
                    goalObjectpropCount++;
                }

                if (bodygoalentityTemplateId != null)
                {
                    goalObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodygoalentityTemplateId);
                    goalObjectpropCount++;
                }

                if (bodygoaldirectFocusAreaIds != null)
                {
                    goalObject["direct_focus_area_ids"] = SourceExpressionConverter.ConvertToken(bodygoaldirectFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (bodygoalinheritedFocusAreaIds != null)
                {
                    goalObject["inherited_focus_area_ids"] = SourceExpressionConverter.ConvertToken(bodygoalinheritedFocusAreaIds);
                    goalObjectpropCount++;
                }

                if (bodygoalalignedFromIds != null)
                {
                    goalObject["aligned_from_ids"] = SourceExpressionConverter.ConvertToken(bodygoalalignedFromIds);
                    goalObjectpropCount++;
                }

                if (bodygoalalignedToIds != null)
                {
                    goalObject["aligned_to_ids"] = SourceExpressionConverter.ConvertToken(bodygoalalignedToIds);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateGoalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllRisksResponse> GetAllRisks([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllRisksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateRiskResponse> CreateRisk([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyissueissue = null, [WorkflowExpression] Func<bodyissueisCriticalInput> bodyissueisCritical = null, [WorkflowExpression] Func<bodyissueisResolvedInput> bodyissueisResolved = null, [WorkflowExpression] Func<int> bodyissueroleId = null, [WorkflowExpression] Func<int> bodyissuegoalId = null, [WorkflowExpression] Func<string> bodyissuedueDate = null, [WorkflowExpression] Func<int> bodyissueentityTemplateId = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011281053 = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011296755 = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodyissueissue, nameof(bodyissueissue), required: false);
            SourceExpression.Validate(bodyissueisCritical, nameof(bodyissueisCritical), required: false);
            SourceExpression.Validate(bodyissueisResolved, nameof(bodyissueisResolved), required: false);
            SourceExpression.Validate(bodyissueroleId, nameof(bodyissueroleId), required: false);
            SourceExpression.Validate(bodyissuegoalId, nameof(bodyissuegoalId), required: false);
            SourceExpression.Validate(bodyissuedueDate, nameof(bodyissuedueDate), required: false);
            SourceExpression.Validate(bodyissueentityTemplateId, nameof(bodyissueentityTemplateId), required: false);
            SourceExpression.Validate(bodyissuecustomAttributescA1573011281053, nameof(bodyissuecustomAttributescA1573011281053), required: false);
            SourceExpression.Validate(bodyissuecustomAttributescA1573011296755, nameof(bodyissuecustomAttributescA1573011296755), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                var body = new JObject();
                var bodypropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (bodyissueissue != null)
                {
                    issueObject["issue"] = SourceExpressionConverter.ConvertToken(bodyissueissue);
                    issueObjectpropCount++;
                }

                if (bodyissueisCritical != null)
                {
                    issueObject["is_critical"] = SourceExpressionConverter.Convert(bodyissueisCritical);
                    issueObjectpropCount++;
                }

                if (bodyissueisResolved != null)
                {
                    issueObject["is_resolved"] = SourceExpressionConverter.Convert(bodyissueisResolved);
                    issueObjectpropCount++;
                }

                if (bodyissueroleId != null)
                {
                    issueObject["role_id"] = SourceExpressionConverter.ConvertToken(bodyissueroleId);
                    issueObjectpropCount++;
                }

                if (bodyissuegoalId != null)
                {
                    issueObject["goal_id"] = SourceExpressionConverter.ConvertToken(bodyissuegoalId);
                    issueObjectpropCount++;
                }

                if (bodyissuedueDate != null)
                {
                    issueObject["due_date"] = SourceExpressionConverter.ConvertToken(bodyissuedueDate);
                    issueObjectpropCount++;
                }

                if (bodyissueentityTemplateId != null)
                {
                    issueObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodyissueentityTemplateId);
                    issueObjectpropCount++;
                }

                var customAttributesObject = new JObject();
                var customAttributesObjectpropCount = 0;
                if (bodyissuecustomAttributescA1573011281053 != null)
                {
                    customAttributesObject["CA1573011281053"] = SourceExpressionConverter.ConvertToken(bodyissuecustomAttributescA1573011281053);
                    customAttributesObjectpropCount++;
                }

                if (bodyissuecustomAttributescA1573011296755 != null)
                {
                    customAttributesObject["CA1573011296755"] = SourceExpressionConverter.ConvertToken(bodyissuecustomAttributescA1573011296755);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateRiskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleRiskResponse> GetSingleRisk([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/issues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleRiskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteRiskResponse> DeleteRisk([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/issues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteRiskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateRiskResponse> UpdateRisk([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyissueissue = null, [WorkflowExpression] Func<bodyissueisCriticalInput> bodyissueisCritical = null, [WorkflowExpression] Func<bodyissueisResolvedInput> bodyissueisResolved = null, [WorkflowExpression] Func<int> bodyissueroleId = null, [WorkflowExpression] Func<string> bodyissuedueDate = null, [WorkflowExpression] Func<int> bodyissueentityTemplateId = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011281053 = null, [WorkflowExpression] Func<int> bodyissuecustomAttributescA1573011296755 = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodyissueissue, nameof(bodyissueissue), required: false);
            SourceExpression.Validate(bodyissueisCritical, nameof(bodyissueisCritical), required: false);
            SourceExpression.Validate(bodyissueisResolved, nameof(bodyissueisResolved), required: false);
            SourceExpression.Validate(bodyissueroleId, nameof(bodyissueroleId), required: false);
            SourceExpression.Validate(bodyissuedueDate, nameof(bodyissuedueDate), required: false);
            SourceExpression.Validate(bodyissueentityTemplateId, nameof(bodyissueentityTemplateId), required: false);
            SourceExpression.Validate(bodyissuecustomAttributescA1573011281053, nameof(bodyissuecustomAttributescA1573011281053), required: false);
            SourceExpression.Validate(bodyissuecustomAttributescA1573011296755, nameof(bodyissuecustomAttributescA1573011296755), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/issues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                var body = new JObject();
                var bodypropCount = 0;
                var issueObject = new JObject();
                var issueObjectpropCount = 0;
                if (bodyissueissue != null)
                {
                    issueObject["issue"] = SourceExpressionConverter.ConvertToken(bodyissueissue);
                    issueObjectpropCount++;
                }

                if (bodyissueisCritical != null)
                {
                    issueObject["is_critical"] = SourceExpressionConverter.Convert(bodyissueisCritical);
                    issueObjectpropCount++;
                }

                if (bodyissueisResolved != null)
                {
                    issueObject["is_resolved"] = SourceExpressionConverter.Convert(bodyissueisResolved);
                    issueObjectpropCount++;
                }

                if (bodyissueroleId != null)
                {
                    issueObject["role_id"] = SourceExpressionConverter.ConvertToken(bodyissueroleId);
                    issueObjectpropCount++;
                }

                if (bodyissuedueDate != null)
                {
                    issueObject["due_date"] = SourceExpressionConverter.ConvertToken(bodyissuedueDate);
                    issueObjectpropCount++;
                }

                if (bodyissueentityTemplateId != null)
                {
                    issueObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodyissueentityTemplateId);
                    issueObjectpropCount++;
                }

                var customAttributesObject = new JObject();
                var customAttributesObjectpropCount = 0;
                if (bodyissuecustomAttributescA1573011281053 != null)
                {
                    customAttributesObject["CA1573011281053"] = SourceExpressionConverter.ConvertToken(bodyissuecustomAttributescA1573011281053);
                    customAttributesObjectpropCount++;
                }

                if (bodyissuecustomAttributescA1573011296755 != null)
                {
                    customAttributesObject["CA1573011296755"] = SourceExpressionConverter.ConvertToken(bodyissuecustomAttributescA1573011296755);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateRiskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllTasksResponse> GetAllTasks([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodytasktask = null, [WorkflowExpression] Func<string> bodytaskcomment = null, [WorkflowExpression] Func<bodytaskisCompleteInput> bodytaskisComplete = null, [WorkflowExpression] Func<int> bodytaskroleId = null, [WorkflowExpression] Func<int> bodytaskgoalId = null, [WorkflowExpression] Func<string> bodytaskstartDate = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<bodytaskweightIdInput> bodytaskweightId = null, [WorkflowExpression] Func<int> bodytaskentityTemplateId = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodytasktask, nameof(bodytasktask), required: false);
            SourceExpression.Validate(bodytaskcomment, nameof(bodytaskcomment), required: false);
            SourceExpression.Validate(bodytaskisComplete, nameof(bodytaskisComplete), required: false);
            SourceExpression.Validate(bodytaskroleId, nameof(bodytaskroleId), required: false);
            SourceExpression.Validate(bodytaskgoalId, nameof(bodytaskgoalId), required: false);
            SourceExpression.Validate(bodytaskstartDate, nameof(bodytaskstartDate), required: false);
            SourceExpression.Validate(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            SourceExpression.Validate(bodytaskweightId, nameof(bodytaskweightId), required: false);
            SourceExpression.Validate(bodytaskentityTemplateId, nameof(bodytaskentityTemplateId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (bodytasktask != null)
                {
                    taskObject["task"] = SourceExpressionConverter.ConvertToken(bodytasktask);
                    taskObjectpropCount++;
                }

                if (bodytaskcomment != null)
                {
                    taskObject["comment"] = SourceExpressionConverter.ConvertToken(bodytaskcomment);
                    taskObjectpropCount++;
                }

                if (bodytaskisComplete != null)
                {
                    taskObject["is_complete"] = SourceExpressionConverter.Convert(bodytaskisComplete);
                    taskObjectpropCount++;
                }

                if (bodytaskroleId != null)
                {
                    taskObject["role_id"] = SourceExpressionConverter.ConvertToken(bodytaskroleId);
                    taskObjectpropCount++;
                }

                if (bodytaskgoalId != null)
                {
                    taskObject["goal_id"] = SourceExpressionConverter.ConvertToken(bodytaskgoalId);
                    taskObjectpropCount++;
                }

                if (bodytaskstartDate != null)
                {
                    taskObject["start_date"] = SourceExpressionConverter.ConvertToken(bodytaskstartDate);
                    taskObjectpropCount++;
                }

                if (bodytaskdueDate != null)
                {
                    taskObject["due_date"] = SourceExpressionConverter.ConvertToken(bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (bodytaskweightId != null)
                {
                    taskObject["weight_id"] = SourceExpressionConverter.Convert(bodytaskweightId);
                    taskObjectpropCount++;
                }

                if (bodytaskentityTemplateId != null)
                {
                    taskObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodytaskentityTemplateId);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleTaskResponse> GetSingleTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateTaskResponse> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodytasktask = null, [WorkflowExpression] Func<string> bodytaskcomment = null, [WorkflowExpression] Func<bodytaskisCompleteInput> bodytaskisComplete = null, [WorkflowExpression] Func<int> bodytaskroleId = null, [WorkflowExpression] Func<int> bodytaskgoalId = null, [WorkflowExpression] Func<string> bodytaskstartDate = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<bodytaskweightIdInput> bodytaskweightId = null, [WorkflowExpression] Func<int> bodytaskentityTemplateId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodytasktask, nameof(bodytasktask), required: false);
            SourceExpression.Validate(bodytaskcomment, nameof(bodytaskcomment), required: false);
            SourceExpression.Validate(bodytaskisComplete, nameof(bodytaskisComplete), required: false);
            SourceExpression.Validate(bodytaskroleId, nameof(bodytaskroleId), required: false);
            SourceExpression.Validate(bodytaskgoalId, nameof(bodytaskgoalId), required: false);
            SourceExpression.Validate(bodytaskstartDate, nameof(bodytaskstartDate), required: false);
            SourceExpression.Validate(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            SourceExpression.Validate(bodytaskweightId, nameof(bodytaskweightId), required: false);
            SourceExpression.Validate(bodytaskentityTemplateId, nameof(bodytaskentityTemplateId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (bodytasktask != null)
                {
                    taskObject["task"] = SourceExpressionConverter.ConvertToken(bodytasktask);
                    taskObjectpropCount++;
                }

                if (bodytaskcomment != null)
                {
                    taskObject["comment"] = SourceExpressionConverter.ConvertToken(bodytaskcomment);
                    taskObjectpropCount++;
                }

                if (bodytaskisComplete != null)
                {
                    taskObject["is_complete"] = SourceExpressionConverter.Convert(bodytaskisComplete);
                    taskObjectpropCount++;
                }

                if (bodytaskroleId != null)
                {
                    taskObject["role_id"] = SourceExpressionConverter.ConvertToken(bodytaskroleId);
                    taskObjectpropCount++;
                }

                if (bodytaskgoalId != null)
                {
                    taskObject["goal_id"] = SourceExpressionConverter.ConvertToken(bodytaskgoalId);
                    taskObjectpropCount++;
                }

                if (bodytaskstartDate != null)
                {
                    taskObject["start_date"] = SourceExpressionConverter.ConvertToken(bodytaskstartDate);
                    taskObjectpropCount++;
                }

                if (bodytaskdueDate != null)
                {
                    taskObject["due_date"] = SourceExpressionConverter.ConvertToken(bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (bodytaskweightId != null)
                {
                    taskObject["weight_id"] = SourceExpressionConverter.Convert(bodytaskweightId);
                    taskObjectpropCount++;
                }

                if (bodytaskentityTemplateId != null)
                {
                    taskObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodytaskentityTemplateId);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetAllUpdatesResponse> GetAllUpdates([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllUpdatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyupdatecomment = null, [WorkflowExpression] Func<int> bodyupdategoalId = null, [WorkflowExpression] Func<int> bodyupdateentityTemplateId = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodyupdatecomment, nameof(bodyupdatecomment), required: false);
            SourceExpression.Validate(bodyupdategoalId, nameof(bodyupdategoalId), required: false);
            SourceExpression.Validate(bodyupdateentityTemplateId, nameof(bodyupdateentityTemplateId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (bodyupdatecomment != null)
                {
                    updateObject["comment"] = SourceExpressionConverter.ConvertToken(bodyupdatecomment);
                    updateObjectpropCount++;
                }

                if (bodyupdategoalId != null)
                {
                    updateObject["goal_id"] = SourceExpressionConverter.ConvertToken(bodyupdategoalId);
                    updateObjectpropCount++;
                }

                if (bodyupdateentityTemplateId != null)
                {
                    updateObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodyupdateentityTemplateId);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<GetSingleUpdateResponse> GetSingleUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<DeleteUpdateResponse> DeleteUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascade")]
        public IBodyWorkflowAction<UpdateUpdateResponse> UpdateUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyupdatecomment = null, [WorkflowExpression] Func<string> bodyupdatecreatedAt = null, [WorkflowExpression] Func<string> bodyupdateupdatedAt = null, [WorkflowExpression] Func<int> bodyupdategoalId = null, [WorkflowExpression] Func<int> bodyupdatedeleted = null, [WorkflowExpression] Func<int> bodyupdateentityTemplateId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(bodyupdatecomment, nameof(bodyupdatecomment), required: false);
            SourceExpression.Validate(bodyupdatecreatedAt, nameof(bodyupdatecreatedAt), required: false);
            SourceExpression.Validate(bodyupdateupdatedAt, nameof(bodyupdateupdatedAt), required: false);
            SourceExpression.Validate(bodyupdategoalId, nameof(bodyupdategoalId), required: false);
            SourceExpression.Validate(bodyupdatedeleted, nameof(bodyupdatedeleted), required: false);
            SourceExpression.Validate(bodyupdateentityTemplateId, nameof(bodyupdateentityTemplateId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Instance"] = SourceExpressionConverter.ConvertO(instance);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (bodyupdatecomment != null)
                {
                    updateObject["comment"] = SourceExpressionConverter.ConvertToken(bodyupdatecomment);
                    updateObjectpropCount++;
                }

                if (bodyupdatecreatedAt != null)
                {
                    updateObject["created_at"] = SourceExpressionConverter.ConvertToken(bodyupdatecreatedAt);
                    updateObjectpropCount++;
                }

                if (bodyupdateupdatedAt != null)
                {
                    updateObject["updated_at"] = SourceExpressionConverter.ConvertToken(bodyupdateupdatedAt);
                    updateObjectpropCount++;
                }

                if (bodyupdategoalId != null)
                {
                    updateObject["goal_id"] = SourceExpressionConverter.ConvertToken(bodyupdategoalId);
                    updateObjectpropCount++;
                }

                if (bodyupdatedeleted != null)
                {
                    updateObject["deleted"] = SourceExpressionConverter.ConvertToken(bodyupdatedeleted);
                    updateObjectpropCount++;
                }

                if (bodyupdateentityTemplateId != null)
                {
                    updateObject["entity_template_id"] = SourceExpressionConverter.ConvertToken(bodyupdateentityTemplateId);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateUpdateResponse>(BuildSourceInput);
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