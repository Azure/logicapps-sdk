//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicplanner
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicplannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<CommentQueryResponse> GetComments([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string[]> creatorIds = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string[]> sort = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(nodeId, nameof(nodeId), required: true);
            SourceExpression.Validate(creatorIds, nameof(creatorIds), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (creatorIds != null)
                    callPayload.Queries["creatorIds"] = SourceExpressionConverter.ConvertO(creatorIds);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CommentQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> CreateComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> bodyannotationPayload = null, [WorkflowExpression] Func<string> bodyannotationType = null, [WorkflowExpression] Func<string> bodycommentContent = null, [WorkflowExpression] Func<bool> bodyisResolved = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(nodeId, nameof(nodeId), required: true);
            SourceExpression.Validate(bodyannotationPayload, nameof(bodyannotationPayload), required: false);
            SourceExpression.Validate(bodyannotationType, nameof(bodyannotationType), required: false);
            SourceExpression.Validate(bodycommentContent, nameof(bodycommentContent), required: false);
            SourceExpression.Validate(bodyisResolved, nameof(bodyisResolved), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyannotationPayload != null)
                {
                    body["annotationPayload"] = SourceExpressionConverter.ConvertToken(bodyannotationPayload);
                    bodypropCount++;
                }

                if (bodyannotationType != null)
                {
                    body["annotationType"] = SourceExpressionConverter.ConvertToken(bodyannotationType);
                    bodypropCount++;
                }

                if (bodycommentContent != null)
                {
                    body["commentContent"] = SourceExpressionConverter.ConvertToken(bodycommentContent);
                    bodypropCount++;
                }

                if (bodyisResolved != null)
                {
                    body["isResolved"] = SourceExpressionConverter.ConvertToken(bodyisResolved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Comment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> GetComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> commentId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(nodeId, nameof(nodeId), required: true);
            SourceExpression.Validate(commentId, nameof(commentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nodeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Comment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction DeleteComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> commentId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(nodeId, nameof(nodeId), required: true);
            SourceExpression.Validate(commentId, nameof(commentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nodeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> UpdateComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> commentId, [WorkflowExpression] Func<string> bodyannotationPayload = null, [WorkflowExpression] Func<string> bodyannotationType = null, [WorkflowExpression] Func<string> bodycommentContent = null, [WorkflowExpression] Func<bool> bodyisResolved = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(nodeId, nameof(nodeId), required: true);
            SourceExpression.Validate(commentId, nameof(commentId), required: true);
            SourceExpression.Validate(bodyannotationPayload, nameof(bodyannotationPayload), required: false);
            SourceExpression.Validate(bodyannotationType, nameof(bodyannotationType), required: false);
            SourceExpression.Validate(bodycommentContent, nameof(bodycommentContent), required: false);
            SourceExpression.Validate(bodyisResolved, nameof(bodyisResolved), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nodeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyannotationPayload != null)
                {
                    body["annotationPayload"] = SourceExpressionConverter.ConvertToken(bodyannotationPayload);
                    bodypropCount++;
                }

                if (bodyannotationType != null)
                {
                    body["annotationType"] = SourceExpressionConverter.ConvertToken(bodyannotationType);
                    bodypropCount++;
                }

                if (bodycommentContent != null)
                {
                    body["commentContent"] = SourceExpressionConverter.ConvertToken(bodycommentContent);
                    bodypropCount++;
                }

                if (bodyisResolved != null)
                {
                    body["isResolved"] = SourceExpressionConverter.ConvertToken(bodyisResolved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Comment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProjectQueryResponse> GetProjects([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> plannedEndDateFrom = null, [WorkflowExpression] Func<string> plannedEndDateTo = null, [WorkflowExpression] Func<string> plannedStartDateFrom = null, [WorkflowExpression] Func<string> plannedStartDateTo = null, [WorkflowExpression] Func<string[]> ids = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string[]> managerIds = null, [WorkflowExpression] Func<string[]> creatorIds = null, [WorkflowExpression] Func<string[]> associatedNodeIds = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string[]> sort = null, [WorkflowExpression] Func<string> customProperties = null, [WorkflowExpression] Func<string[]> followerIds = null, [WorkflowExpression] Func<bool> includeAssociations = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            SourceExpression.Validate(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            SourceExpression.Validate(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            SourceExpression.Validate(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(managerIds, nameof(managerIds), required: false);
            SourceExpression.Validate(creatorIds, nameof(creatorIds), required: false);
            SourceExpression.Validate(associatedNodeIds, nameof(associatedNodeIds), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(customProperties, nameof(customProperties), required: false);
            SourceExpression.Validate(followerIds, nameof(followerIds), required: false);
            SourceExpression.Validate(includeAssociations, nameof(includeAssociations), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = SourceExpressionConverter.ConvertO(plannedEndDateFrom);
                if (plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = SourceExpressionConverter.ConvertO(plannedEndDateTo);
                if (plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = SourceExpressionConverter.ConvertO(plannedStartDateFrom);
                if (plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = SourceExpressionConverter.ConvertO(plannedStartDateTo);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (managerIds != null)
                    callPayload.Queries["managerIds"] = SourceExpressionConverter.ConvertO(managerIds);
                if (creatorIds != null)
                    callPayload.Queries["creatorIds"] = SourceExpressionConverter.ConvertO(creatorIds);
                if (associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = SourceExpressionConverter.ConvertO(associatedNodeIds);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (customProperties != null)
                    callPayload.Queries["customProperties"] = SourceExpressionConverter.ConvertO(customProperties);
                if (followerIds != null)
                    callPayload.Queries["followerIds"] = SourceExpressionConverter.ConvertO(followerIds);
                callPayload.Queries["includeAssociations"] = Convert.ToString(false);
                if (includeAssociations != null)
                    callPayload.Queries["includeAssociations"] = SourceExpressionConverter.ConvertO(includeAssociations);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerProjectQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteProjects([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string[]> ids, [WorkflowExpression] Func<bool> deleteTasks = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(ids, nameof(ids), required: true);
            SourceExpression.Validate(deleteTasks, nameof(deleteTasks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                callPayload.Queries["deleteTasks"] = Convert.ToString(false);
                if (deleteTasks != null)
                    callPayload.Queries["deleteTasks"] = SourceExpressionConverter.ConvertO(deleteTasks);
                return callPayload;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> CreateProject([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<AssociationReq[]> bodyassociations = null, [WorkflowExpression] Func<CustomPropertyValuesInput[]> bodycustomProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = SourceExpressionConverter.ConvertToken(bodyassociations);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> GetProject([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<int> associatedNodesDepth = null, [WorkflowExpression] Func<bool> includeWorks = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(associatedNodesDepth, nameof(associatedNodesDepth), required: false);
            SourceExpression.Validate(includeWorks, nameof(includeWorks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (associatedNodesDepth != null)
                    callPayload.Queries["associatedNodesDepth"] = SourceExpressionConverter.ConvertO(associatedNodesDepth);
                if (includeWorks != null)
                    callPayload.Queries["includeWorks"] = SourceExpressionConverter.ConvertO(includeWorks);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteProject([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<bool> deleteTasks = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(deleteTasks, nameof(deleteTasks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["deleteTasks"] = Convert.ToString(false);
                if (deleteTasks != null)
                    callPayload.Queries["deleteTasks"] = SourceExpressionConverter.ConvertO(deleteTasks);
                return callPayload;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> UpdateProject([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<CustomPropertyValues[]> bodycustomProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyisActive = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<string> bodymaxRank = null, [WorkflowExpression] Func<string> bodyminRank = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyisActive, nameof(bodyisActive), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodymaxRank, nameof(bodymaxRank), required: false);
            SourceExpression.Validate(bodyminRank, nameof(bodyminRank), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/projects/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyisActive != null)
                {
                    body["isActive"] = SourceExpressionConverter.ConvertToken(bodyisActive);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodymaxRank != null)
                {
                    body["maxRank"] = SourceExpressionConverter.ConvertToken(bodymaxRank);
                    bodypropCount++;
                }

                if (bodyminRank != null)
                {
                    body["minRank"] = SourceExpressionConverter.ConvertToken(bodyminRank);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequestQueryResponse> GetRequests([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> plannedEndDateFrom = null, [WorkflowExpression] Func<string> plannedEndDateTo = null, [WorkflowExpression] Func<string> plannedStartDateFrom = null, [WorkflowExpression] Func<string> plannedStartDateTo = null, [WorkflowExpression] Func<string> createdAtFrom = null, [WorkflowExpression] Func<string> createdAtTo = null, [WorkflowExpression] Func<string> updatedAtFrom = null, [WorkflowExpression] Func<string> updatedAtTo = null, [WorkflowExpression] Func<string[]> ids = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string[]> assigneeIds = null, [WorkflowExpression] Func<prioritiesInputItem[]> priorities = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string[]> assignerIds = null, [WorkflowExpression] Func<string[]> creatorIds = null, [WorkflowExpression] Func<int[]> stepIds = null, [WorkflowExpression] Func<string> statusSchemaId = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string[]> sort = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<bool> hasProject = null, [WorkflowExpression] Func<string> customProperties = null, [WorkflowExpression] Func<string[]> followerIds = null, [WorkflowExpression] Func<string[]> associatedNodeIds = null, [WorkflowExpression] Func<string[]> contentRefs = null, [WorkflowExpression] Func<bool> includeRequestFormCustomProperties = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            SourceExpression.Validate(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            SourceExpression.Validate(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            SourceExpression.Validate(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            SourceExpression.Validate(createdAtFrom, nameof(createdAtFrom), required: false);
            SourceExpression.Validate(createdAtTo, nameof(createdAtTo), required: false);
            SourceExpression.Validate(updatedAtFrom, nameof(updatedAtFrom), required: false);
            SourceExpression.Validate(updatedAtTo, nameof(updatedAtTo), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(assigneeIds, nameof(assigneeIds), required: false);
            SourceExpression.Validate(priorities, nameof(priorities), required: false);
            SourceExpression.Validate(keywords, nameof(keywords), required: false);
            SourceExpression.Validate(assignerIds, nameof(assignerIds), required: false);
            SourceExpression.Validate(creatorIds, nameof(creatorIds), required: false);
            SourceExpression.Validate(stepIds, nameof(stepIds), required: false);
            SourceExpression.Validate(statusSchemaId, nameof(statusSchemaId), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(projectId, nameof(projectId), required: false);
            SourceExpression.Validate(hasProject, nameof(hasProject), required: false);
            SourceExpression.Validate(customProperties, nameof(customProperties), required: false);
            SourceExpression.Validate(followerIds, nameof(followerIds), required: false);
            SourceExpression.Validate(associatedNodeIds, nameof(associatedNodeIds), required: false);
            SourceExpression.Validate(contentRefs, nameof(contentRefs), required: false);
            SourceExpression.Validate(includeRequestFormCustomProperties, nameof(includeRequestFormCustomProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = SourceExpressionConverter.ConvertO(plannedEndDateFrom);
                if (plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = SourceExpressionConverter.ConvertO(plannedEndDateTo);
                if (plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = SourceExpressionConverter.ConvertO(plannedStartDateFrom);
                if (plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = SourceExpressionConverter.ConvertO(plannedStartDateTo);
                if (createdAtFrom != null)
                    callPayload.Queries["createdAtFrom"] = SourceExpressionConverter.ConvertO(createdAtFrom);
                if (createdAtTo != null)
                    callPayload.Queries["createdAtTo"] = SourceExpressionConverter.ConvertO(createdAtTo);
                if (updatedAtFrom != null)
                    callPayload.Queries["updatedAtFrom"] = SourceExpressionConverter.ConvertO(updatedAtFrom);
                if (updatedAtTo != null)
                    callPayload.Queries["updatedAtTo"] = SourceExpressionConverter.ConvertO(updatedAtTo);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (assigneeIds != null)
                    callPayload.Queries["assigneeIds"] = SourceExpressionConverter.ConvertO(assigneeIds);
                if (priorities != null)
                    callPayload.Queries["priorities"] = SourceExpressionConverter.ConvertO(priorities);
                if (keywords != null)
                    callPayload.Queries["keywords"] = SourceExpressionConverter.ConvertO(keywords);
                if (assignerIds != null)
                    callPayload.Queries["assignerIds"] = SourceExpressionConverter.ConvertO(assignerIds);
                if (creatorIds != null)
                    callPayload.Queries["creatorIds"] = SourceExpressionConverter.ConvertO(creatorIds);
                if (stepIds != null)
                    callPayload.Queries["stepIds"] = SourceExpressionConverter.ConvertO(stepIds);
                if (statusSchemaId != null)
                    callPayload.Queries["statusSchemaId"] = SourceExpressionConverter.ConvertO(statusSchemaId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (hasProject != null)
                    callPayload.Queries["hasProject"] = SourceExpressionConverter.ConvertO(hasProject);
                if (customProperties != null)
                    callPayload.Queries["customProperties"] = SourceExpressionConverter.ConvertO(customProperties);
                if (followerIds != null)
                    callPayload.Queries["followerIds"] = SourceExpressionConverter.ConvertO(followerIds);
                if (associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = SourceExpressionConverter.ConvertO(associatedNodeIds);
                if (contentRefs != null)
                    callPayload.Queries["contentRefs"] = SourceExpressionConverter.ConvertO(contentRefs);
                callPayload.Queries["includeRequestFormCustomProperties"] = Convert.ToString(false);
                if (includeRequestFormCustomProperties != null)
                    callPayload.Queries["includeRequestFormCustomProperties"] = SourceExpressionConverter.ConvertO(includeRequestFormCustomProperties);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerRequestQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteRequests([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string[]> bodyrequestIDs = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodyrequestIDs, nameof(bodyrequestIDs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequestIDs != null)
                {
                    body["ids"] = SourceExpressionConverter.ConvertToken(bodyrequestIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> CreateRequest([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyassigneeId = null, [WorkflowExpression] Func<AssociationReq[]> bodyassociations = null, [WorkflowExpression] Func<ContentRef[]> bodycontentReferences = null, [WorkflowExpression] Func<CustomPropertyValuesInput[]> bodycustomProperties = null, [WorkflowExpression] Func<object> bodyformReference = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodystatusSchemaId = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyassigneeId, nameof(bodyassigneeId), required: false);
            SourceExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            SourceExpression.Validate(bodycontentReferences, nameof(bodycontentReferences), required: false);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodyformReference, nameof(bodyformReference), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodystatusSchemaId, nameof(bodystatusSchemaId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassigneeId != null)
                {
                    body["assigneeId"] = SourceExpressionConverter.ConvertToken(bodyassigneeId);
                    bodypropCount++;
                }

                if (bodyassociations != null)
                {
                    body["associations"] = SourceExpressionConverter.ConvertToken(bodyassociations);
                    bodypropCount++;
                }

                if (bodycontentReferences != null)
                {
                    body["contentRefs"] = SourceExpressionConverter.ConvertToken(bodycontentReferences);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodyformReference != null)
                {
                    body["formRef"] = SourceExpressionConverter.ConvertToken(bodyformReference);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodystatusSchemaId != null)
                {
                    body["statusSchemaId"] = SourceExpressionConverter.ConvertToken(bodystatusSchemaId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerRequest>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> GetRequest([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerRequest>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction DeleteRequest([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> UpdateRequest([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> bodyassigneeId = null, [WorkflowExpression] Func<ContentRef[]> bodycontentReferenceObjects = null, [WorkflowExpression] Func<CustomPropertyValuesInput[]> bodycustomProperties = null, [WorkflowExpression] Func<object> bodyformReference = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodystepId = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            SourceExpression.Validate(bodyassigneeId, nameof(bodyassigneeId), required: false);
            SourceExpression.Validate(bodycontentReferenceObjects, nameof(bodycontentReferenceObjects), required: false);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodyformReference, nameof(bodyformReference), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassigneeId != null)
                {
                    body["assigneeId"] = SourceExpressionConverter.ConvertToken(bodyassigneeId);
                    bodypropCount++;
                }

                if (bodycontentReferenceObjects != null)
                {
                    body["contentRefs"] = SourceExpressionConverter.ConvertToken(bodycontentReferenceObjects);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodyformReference != null)
                {
                    body["formRef"] = SourceExpressionConverter.ConvertToken(bodyformReference);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["stepId"] = SourceExpressionConverter.ConvertToken(bodystepId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerRequest>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchemaQueryResponse> GetStatusSchemas([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<bool> isDefault = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string[]> ids = null, [WorkflowExpression] Func<string[]> creatorIds = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(isDefault, nameof(isDefault), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(creatorIds, nameof(creatorIds), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/statusschema", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isDefault != null)
                    callPayload.Queries["isDefault"] = SourceExpressionConverter.ConvertO(isDefault);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (creatorIds != null)
                    callPayload.Queries["creatorIds"] = SourceExpressionConverter.ConvertO(creatorIds);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<StatusSchemaQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchema> GetStatusSchema([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> statusSchemaId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(statusSchemaId, nameof(statusSchemaId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/statusschema/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(statusSchemaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTaskQueryResponse> GetTasks([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> plannedEndDateFrom = null, [WorkflowExpression] Func<string> plannedEndDateTo = null, [WorkflowExpression] Func<string> plannedStartDateFrom = null, [WorkflowExpression] Func<string> plannedStartDateTo = null, [WorkflowExpression] Func<string> createdAtFrom = null, [WorkflowExpression] Func<string> createdAtTo = null, [WorkflowExpression] Func<string> updatedAtFrom = null, [WorkflowExpression] Func<string> updatedAtTo = null, [WorkflowExpression] Func<string[]> ids = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string[]> assigneeIds = null, [WorkflowExpression] Func<prioritiesInputItem[]> priorities = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string[]> assignerIds = null, [WorkflowExpression] Func<int[]> stepIds = null, [WorkflowExpression] Func<string> statusSchemaId = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string[]> sort = null, [WorkflowExpression] Func<bool> recursive = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<bool> hasProject = null, [WorkflowExpression] Func<string> customProperties = null, [WorkflowExpression] Func<string[]> followerIds = null, [WorkflowExpression] Func<string[]> associatedNodeIds = null, [WorkflowExpression] Func<string[]> creatorIds = null, [WorkflowExpression] Func<bool> includeAssociations = null, [WorkflowExpression] Func<string> parentId = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            SourceExpression.Validate(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            SourceExpression.Validate(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            SourceExpression.Validate(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            SourceExpression.Validate(createdAtFrom, nameof(createdAtFrom), required: false);
            SourceExpression.Validate(createdAtTo, nameof(createdAtTo), required: false);
            SourceExpression.Validate(updatedAtFrom, nameof(updatedAtFrom), required: false);
            SourceExpression.Validate(updatedAtTo, nameof(updatedAtTo), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(description, nameof(description), required: false);
            SourceExpression.Validate(assigneeIds, nameof(assigneeIds), required: false);
            SourceExpression.Validate(priorities, nameof(priorities), required: false);
            SourceExpression.Validate(keywords, nameof(keywords), required: false);
            SourceExpression.Validate(assignerIds, nameof(assignerIds), required: false);
            SourceExpression.Validate(stepIds, nameof(stepIds), required: false);
            SourceExpression.Validate(statusSchemaId, nameof(statusSchemaId), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(recursive, nameof(recursive), required: false);
            SourceExpression.Validate(projectId, nameof(projectId), required: false);
            SourceExpression.Validate(hasProject, nameof(hasProject), required: false);
            SourceExpression.Validate(customProperties, nameof(customProperties), required: false);
            SourceExpression.Validate(followerIds, nameof(followerIds), required: false);
            SourceExpression.Validate(associatedNodeIds, nameof(associatedNodeIds), required: false);
            SourceExpression.Validate(creatorIds, nameof(creatorIds), required: false);
            SourceExpression.Validate(includeAssociations, nameof(includeAssociations), required: false);
            SourceExpression.Validate(parentId, nameof(parentId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = SourceExpressionConverter.ConvertO(plannedEndDateFrom);
                if (plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = SourceExpressionConverter.ConvertO(plannedEndDateTo);
                if (plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = SourceExpressionConverter.ConvertO(plannedStartDateFrom);
                if (plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = SourceExpressionConverter.ConvertO(plannedStartDateTo);
                if (createdAtFrom != null)
                    callPayload.Queries["createdAtFrom"] = SourceExpressionConverter.ConvertO(createdAtFrom);
                if (createdAtTo != null)
                    callPayload.Queries["createdAtTo"] = SourceExpressionConverter.ConvertO(createdAtTo);
                if (updatedAtFrom != null)
                    callPayload.Queries["updatedAtFrom"] = SourceExpressionConverter.ConvertO(updatedAtFrom);
                if (updatedAtTo != null)
                    callPayload.Queries["updatedAtTo"] = SourceExpressionConverter.ConvertO(updatedAtTo);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (assigneeIds != null)
                    callPayload.Queries["assigneeIds"] = SourceExpressionConverter.ConvertO(assigneeIds);
                if (priorities != null)
                    callPayload.Queries["priorities"] = SourceExpressionConverter.ConvertO(priorities);
                if (keywords != null)
                    callPayload.Queries["keywords"] = SourceExpressionConverter.ConvertO(keywords);
                if (assignerIds != null)
                    callPayload.Queries["assignerIds"] = SourceExpressionConverter.ConvertO(assignerIds);
                if (stepIds != null)
                    callPayload.Queries["stepIds"] = SourceExpressionConverter.ConvertO(stepIds);
                if (statusSchemaId != null)
                    callPayload.Queries["statusSchemaId"] = SourceExpressionConverter.ConvertO(statusSchemaId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (recursive != null)
                    callPayload.Queries["recursive"] = SourceExpressionConverter.ConvertO(recursive);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (hasProject != null)
                    callPayload.Queries["hasProject"] = SourceExpressionConverter.ConvertO(hasProject);
                if (customProperties != null)
                    callPayload.Queries["customProperties"] = SourceExpressionConverter.ConvertO(customProperties);
                if (followerIds != null)
                    callPayload.Queries["followerIds"] = SourceExpressionConverter.ConvertO(followerIds);
                if (associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = SourceExpressionConverter.ConvertO(associatedNodeIds);
                if (creatorIds != null)
                    callPayload.Queries["creatorIds"] = SourceExpressionConverter.ConvertO(creatorIds);
                if (includeAssociations != null)
                    callPayload.Queries["includeAssociations"] = SourceExpressionConverter.ConvertO(includeAssociations);
                if (parentId != null)
                    callPayload.Queries["parentId"] = SourceExpressionConverter.ConvertO(parentId);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerTaskQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> CreateTask([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyassigneeId = null, [WorkflowExpression] Func<AssociationReq[]> bodyassociations = null, [WorkflowExpression] Func<CustomPropertyValuesInput[]> bodycustomProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyassigneeId, nameof(bodyassigneeId), required: false);
            SourceExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassigneeId != null)
                {
                    body["assigneeId"] = SourceExpressionConverter.ConvertToken(bodyassigneeId);
                    bodypropCount++;
                }

                if (bodyassociations != null)
                {
                    body["associations"] = SourceExpressionConverter.ConvertToken(bodyassociations);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> GetTask([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlannerTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteTask([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> UpdateTask([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodyassigneeId = null, [WorkflowExpression] Func<CustomPropertyValuesInput[]> bodycustomProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<int> bodyplannedDuration = null, [WorkflowExpression] Func<string> bodyplannedEndDate = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodystepId = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            SourceExpression.Validate(bodyassigneeId, nameof(bodyassigneeId), required: false);
            SourceExpression.Validate(bodycustomProperties, nameof(bodycustomProperties), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            SourceExpression.Validate(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassigneeId != null)
                {
                    body["assigneeId"] = SourceExpressionConverter.ConvertToken(bodyassigneeId);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["customProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyplannedDuration != null)
                {
                    body["plannedDuration"] = SourceExpressionConverter.ConvertToken(bodyplannedDuration);
                    bodypropCount++;
                }

                if (bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = SourceExpressionConverter.ConvertToken(bodyplannedEndDate);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["stepId"] = SourceExpressionConverter.ConvertToken(bodystepId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlannerTask>(BuildSourceInput);
        }
    }

    public class SeismicplannerTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommentQueryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("items")]
        public Comment[] Items { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class Comment
    {
        [JsonProperty("annotationPayload")]
        public string AnnotationPayload { get; set; }

        [JsonProperty("annotationType")]
        public string AnnotationType { get; set; }

        [JsonProperty("commentContent")]
        public string CommentContent { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("id")]
        public string CommentID { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("nodeId")]
        public string NodeID { get; set; }

        [JsonProperty("nodeType")]
        public CommentNodeTypeType NodeType { get; set; }

        [JsonProperty("pageIndex")]
        public string PageIndex { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("replyCount")]
        public int ReplyCount { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum CommentNodeTypeType
    {
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request
    }

    public class Meta
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("query")]
        public MetaQueryInfo[] Query { get; set; }
    }

    public class MetaQueryInfo
    {
        [JsonProperty("sort")]
        public string[] Sort { get; set; }
    }

    public class PlannerProjectQueryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("items")]
        public PlannerProject[] ProjectObjects { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class PlannerProject
    {
        [JsonProperty("actualDuration")]
        public int ActualDuration { get; set; }

        [JsonProperty("actualEndDate")]
        public string ActualEndDate { get; set; }

        [JsonProperty("actualStartDate")]
        public string ActualStartDate { get; set; }

        [JsonProperty("associatedNodes")]
        public ProjectAssociatedNodes[] AssociatedNodes { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("copyFrom")]
        public string CopyFrom { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string ProjectID { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("managerId")]
        public string ManagerID { get; set; }

        [JsonProperty("maxRank")]
        public string MaxRank { get; set; }

        [JsonProperty("minRank")]
        public string MinRank { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("templateId")]
        public string TemplateID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("works")]
        public PlannerTask[] Works { get; set; }
    }

    public class ProjectAssociatedNodes
    {
        [JsonProperty("nodeId")]
        public string NodeID { get; set; }

        [JsonProperty("nodeType")]
        public ProjectAssociatedNodesNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }
    }

    public enum ProjectAssociatedNodesNodeTypeType
    {
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "content")]
        Content
    }

    public class Association
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nodeGuid")]
        public string NodeGUID { get; set; }

        [JsonProperty("nodeId")]
        public string NodeID { get; set; }

        [JsonProperty("nodeType")]
        public AssociationNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceGuid")]
        public string SpaceGUID { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }
    }

    public enum AssociationNodeTypeType
    {
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "content")]
        Content
    }

    public class CustomPropertyValues
    {
        [JsonProperty("id")]
        public string CustomPropertyID { get; set; }

        [JsonProperty("localizations")]
        public JToken Localizations { get; set; }

        [JsonProperty("multipleValue")]
        public bool MultipleValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public CustomPropertyValuesValues[] Values { get; set; }
    }

    public class CustomPropertyValuesValues
    {
        [JsonProperty("id")]
        public string ValueID { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class Follower
    {
        [JsonProperty("id")]
        public string UserUserGroupID { get; set; }

        [JsonProperty("type")]
        public FollowerTypeType Type { get; set; }
    }

    public enum FollowerTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

    public class PlannerTask
    {
        [JsonProperty("actualDuration")]
        public int ActualDuration { get; set; }

        [JsonProperty("actualEndDate")]
        public string ActualEndDate { get; set; }

        [JsonProperty("actualStartDate")]
        public string ActualStartDate { get; set; }

        [JsonProperty("assigneeId")]
        public string AssigneID { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerID { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("copyFrom")]
        public string CopyFrom { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string TaskID { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("maxRank")]
        public string MaxRank { get; set; }

        [JsonProperty("minRank")]
        public string MinRank { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("priority")]
        public PlannerTaskPriorityType Priority { get; set; }

        [JsonProperty("projectId")]
        public string ProjectID { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaID { get; set; }

        [JsonProperty("stepId")]
        public int StepID { get; set; }

        [JsonProperty("subTaskIds")]
        public string[] SubTaskIDs { get; set; }

        [JsonProperty("subTasks")]
        public PlannerSubTask[] SubTasks { get; set; }

        [JsonProperty("templateId")]
        public string TemplateID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public PlannerTaskTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum PlannerTaskPriorityType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class PlannerSubTask
    {
        [JsonProperty("actualDuration")]
        public int ActualDuration { get; set; }

        [JsonProperty("actualEndDate")]
        public string ActualEndDate { get; set; }

        [JsonProperty("actualStartDate")]
        public string ActualStartDate { get; set; }

        [JsonProperty("assigneeId")]
        public string AssigneeID { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerID { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("copyFrom")]
        public string CopyFrom { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string TaskID { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("maxRank")]
        public string MaxRank { get; set; }

        [JsonProperty("minRank")]
        public string MinRank { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("priority")]
        public PlannerSubTaskPriorityType Priority { get; set; }

        [JsonProperty("projectId")]
        public string ProjectID { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaID { get; set; }

        [JsonProperty("stepId")]
        public int StepID { get; set; }

        [JsonProperty("templateId")]
        public string TemplateID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public PlannerSubTaskTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdateAt { get; set; }
    }

    public enum PlannerSubTaskPriorityType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public enum PlannerSubTaskTypeType
    {
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "task")]
        TaskObject
    }

    public enum PlannerTaskTypeType
    {
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "task")]
        TaskObject
    }

    public class AsyncOperationResponse
    {
        [JsonProperty("asyncOperationIds")]
        public string[] AsyncOperationIDs { get; set; }
    }

    public class AssociationReq
    {
        [JsonProperty("nodeId")]
        public string NodeID { get; set; }

        [JsonProperty("nodeType")]
        public AssociationReqNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }
    }

    public enum AssociationReqNodeTypeType
    {
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "content")]
        Content
    }

    public class CustomPropertyValuesInput
    {
        [JsonProperty("id")]
        public string CustomPropertyID { get; set; }

        [JsonProperty("values")]
        public CustomPropertyValuesValues[] Values { get; set; }
    }

    public class PlannerRequestQueryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("items")]
        public PlannerRequest[] RequestObjects { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class PlannerRequest
    {
        [JsonProperty("assigneeId")]
        public string AssigneeID { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerID { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("contentRefs")]
        public ContentRef[] ContentReferenceObjects { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("formRef")]
        public JToken FormRef { get; set; }

        [JsonProperty("id")]
        public string RequestID { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlanntedStartDate { get; set; }

        [JsonProperty("priority")]
        public PlannerRequestPriorityType Priority { get; set; }

        [JsonProperty("projectId")]
        public string ProjectID { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("requestFormCustomPropertyOption")]
        public RequestFormCustomProperties RequestFormCustomPropertyOption { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaID { get; set; }

        [JsonProperty("stepId")]
        public int StepID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ContentRef
    {
        [JsonProperty("contentId")]
        public string ContentID { get; set; }

        [JsonProperty("docCenterFullPath")]
        public string DocCenterFullPath { get; set; }

        [JsonProperty("majorVersion")]
        public int MajorVersion { get; set; }

        [JsonProperty("minorVersion")]
        public int MinorVersion { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("orderNo")]
        public int OrderNumber { get; set; }

        [JsonProperty("profileId")]
        public string ProfileID { get; set; }

        [JsonProperty("profileVersionId")]
        public string ProfileVersionID { get; set; }

        [JsonProperty("source")]
        public ContentRefSourceType Source { get; set; }

        [JsonProperty("teamSiteId")]
        public string TeamSiteID { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailID { get; set; }

        [JsonProperty("versionId")]
        public string VersionID { get; set; }
    }

    public enum ContentRefSourceType
    {
        Library,
        DocCenter,
        NewsCenter,
        Workspace
    }

    public enum PlannerRequestPriorityType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class RequestFormCustomProperties
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("customProperties")]
        public CustomProperty[] CustomProperties { get; set; }
    }

    public class CustomProperty
    {
        [JsonProperty("allowMultipleValues")]
        public bool AllowMultipleValues { get; set; }

        [JsonProperty("createdById")]
        public string CreatedByID { get; set; }

        [JsonProperty("hasDomainOfValues")]
        public bool HasDomainOfValues { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("id")]
        public string CustomPropertyID { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedByID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operationSetting")]
        public CustomPropertyOperationSettingType OperationSetting { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("possibleValues")]
        public PossibleValuesItem[] PossibleValues { get; set; }

        [JsonProperty("scopeSettings")]
        public ScopeSettingsItemDefinition[] ScopeSettings { get; set; }

        [JsonProperty("scopes")]
        public CustomPropertyScopesTypeItem[] Scopes { get; set; }

        [JsonProperty("valueSchemaName")]
        public CustomPropertyValueSchemaNameType ValueSchemaName { get; set; }

        [JsonProperty("valueSchemaProperty")]
        public ValueSchemaPropertyDefinition ValueSchemaProperty { get; set; }

        [JsonProperty("valueType")]
        public CustomPropertyValueTypeType ValueType { get; set; }
    }

    public enum CustomPropertyOperationSettingType
    {
        Editable,
        ReadOnly,
        Hidden
    }

    public class PossibleValuesItem
    {
        [JsonProperty("id")]
        public string ValueID { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class ScopeSettingsItemDefinition
    {
        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("scope")]
        public ScopeSettingsItemDefinitionScopeType Scope { get; set; }
    }

    public enum ScopeSettingsItemDefinitionScopeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "content")]
        Content,
        [EnumMember(Value = "request")]
        Request
    }

    public enum CustomPropertyScopesTypeItem
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "content")]
        Content,
        [EnumMember(Value = "request")]
        Request
    }

    public enum CustomPropertyValueSchemaNameType
    {
        [EnumMember(Value = "dateRange")]
        DateRange,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "tag")]
        Tag
    }

    public class ValueSchemaPropertyDefinition
    {
        [JsonProperty("max")]
        public string MaximumNumber { get; set; }

        [JsonProperty("min")]
        public string MinimumNumber { get; set; }
    }

    public enum CustomPropertyValueTypeType
    {
        Boolean,
        Integer,
        Double,
        DateTime,
        String,
        Dictionary
    }

    public enum prioritiesInputItem
    {
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "noPriority")]
        NoPriority
    }

    public enum bodypriorityInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class StatusSchemaQueryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("items")]
        public StatusSchema[] StatusSchemaObjects { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class StatusSchema
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorID { get; set; }

        [JsonProperty("id")]
        public string StatusSchemaID { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceID { get; set; }

        [JsonProperty("steps")]
        public string[] Steps { get; set; }

        [JsonProperty("transitions")]
        public int[][] Transitions { get; set; }

        [JsonProperty("type")]
        public StatusSchemaTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum StatusSchemaTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request
    }

    public enum typeInput
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request
    }

    public class PlannerTaskQueryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("items")]
        public PlannerTask[] TaskObjects { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicplanner;

    public partial class WorkflowManagedActions
    {
        public SeismicplannerActions Seismicplanner(string connectionId) => new SeismicplannerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicplannerTriggers Seismicplanner(string connectionId) => new SeismicplannerTriggers(connectionId);
    }
}