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
        public IBodyWorkflowAction<CommentQueryResponse> GetComments(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string[]>> creatorIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/nodes/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (creatorIds != null)
                callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(creatorIds);
            if (cursor != null)
                callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<CommentQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> CreateComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> bodyannotationPayload = null, Expression<Func<string>> bodyannotationType = null, Expression<Func<string>> bodycommentContent = null, Expression<Func<bool>> bodyisResolved = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/nodes/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyannotationPayload != null)
            {
                body["annotationPayload"] = ExpressionConverter.ConvertO(bodyannotationPayload);
                bodypropCount++;
            }

            if (bodyannotationType != null)
            {
                body["annotationType"] = ExpressionConverter.ConvertO(bodyannotationType);
                bodypropCount++;
            }

            if (bodycommentContent != null)
            {
                body["commentContent"] = ExpressionConverter.ConvertO(bodycommentContent);
                bodypropCount++;
            }

            if (bodyisResolved != null)
            {
                body["isResolved"] = ExpressionConverter.ConvertO(bodyisResolved);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Comment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> GetComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Comment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction DeleteComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment> UpdateComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId, Expression<Func<string>> bodyannotationPayload = null, Expression<Func<string>> bodyannotationType = null, Expression<Func<string>> bodycommentContent = null, Expression<Func<bool>> bodyisResolved = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyannotationPayload != null)
            {
                body["annotationPayload"] = ExpressionConverter.ConvertO(bodyannotationPayload);
                bodypropCount++;
            }

            if (bodyannotationType != null)
            {
                body["annotationType"] = ExpressionConverter.ConvertO(bodyannotationType);
                bodypropCount++;
            }

            if (bodycommentContent != null)
            {
                body["commentContent"] = ExpressionConverter.ConvertO(bodycommentContent);
                bodypropCount++;
            }

            if (bodyisResolved != null)
            {
                body["isResolved"] = ExpressionConverter.ConvertO(bodyisResolved);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Comment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProjectQueryResponse> GetProjects(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string[]>> managerIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<bool>> includeAssociations = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (plannedEndDateFrom != null)
                callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(plannedEndDateFrom);
            if (plannedEndDateTo != null)
                callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(plannedEndDateTo);
            if (plannedStartDateFrom != null)
                callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(plannedStartDateFrom);
            if (plannedStartDateTo != null)
                callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(plannedStartDateTo);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (managerIds != null)
                callPayload.Queries["managerIds"] = ExpressionConverter.Convert(managerIds);
            if (creatorIds != null)
                callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(creatorIds);
            if (associatedNodeIds != null)
                callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(associatedNodeIds);
            if (cursor != null)
                callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (customProperties != null)
                callPayload.Queries["customProperties"] = ExpressionConverter.Convert(customProperties);
            if (followerIds != null)
                callPayload.Queries["followerIds"] = ExpressionConverter.Convert(followerIds);
            callPayload.Queries["includeAssociations"] = Convert.ToString(false);
            if (includeAssociations != null)
                callPayload.Queries["includeAssociations"] = ExpressionConverter.Convert(includeAssociations);
            return new ApiConnectionAction<PlannerProjectQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteProjects(Expression<Func<string>> spaceId, Expression<Func<string[]>> ids, Expression<Func<bool>> deleteTasks = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            callPayload.Queries["deleteTasks"] = Convert.ToString(false);
            if (deleteTasks != null)
                callPayload.Queries["deleteTasks"] = ExpressionConverter.Convert(deleteTasks);
            return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> CreateProject(Expression<Func<string>> spaceId, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymanagerID = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodymanagerID != null)
            {
                body["managerId"] = ExpressionConverter.ConvertO(bodymanagerID);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> GetProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<int>> associatedNodesDepth = null, Expression<Func<bool>> includeWorks = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (associatedNodesDepth != null)
                callPayload.Queries["associatedNodesDepth"] = ExpressionConverter.Convert(associatedNodesDepth);
            if (includeWorks != null)
                callPayload.Queries["includeWorks"] = ExpressionConverter.Convert(includeWorks);
            return new ApiConnectionAction<PlannerProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<bool>> deleteTasks = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["deleteTasks"] = Convert.ToString(false);
            if (deleteTasks != null)
                callPayload.Queries["deleteTasks"] = ExpressionConverter.Convert(deleteTasks);
            return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject> UpdateProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<CustomPropertyValues[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisActive = null, Expression<Func<string>> bodymanagerID = null, Expression<Func<string>> bodymaxRank = null, Expression<Func<string>> bodyminRank = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyisActive != null)
            {
                body["isActive"] = ExpressionConverter.ConvertO(bodyisActive);
                bodypropCount++;
            }

            if (bodymanagerID != null)
            {
                body["managerId"] = ExpressionConverter.ConvertO(bodymanagerID);
                bodypropCount++;
            }

            if (bodymaxRank != null)
            {
                body["maxRank"] = ExpressionConverter.ConvertO(bodymaxRank);
                bodypropCount++;
            }

            if (bodyminRank != null)
            {
                body["minRank"] = ExpressionConverter.ConvertO(bodyminRank);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequestQueryResponse> GetRequests(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> updatedAtFrom = null, Expression<Func<string>> updatedAtTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string[]>> assigneeIds = null, Expression<Func<prioritiesInputItem[]>> priorities = null, Expression<Func<string>> keywords = null, Expression<Func<string[]>> assignerIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<int[]>> stepIds = null, Expression<Func<string>> statusSchemaId = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> hasProject = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string[]>> contentRefs = null, Expression<Func<bool>> includeRequestFormCustomProperties = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (plannedEndDateFrom != null)
                callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(plannedEndDateFrom);
            if (plannedEndDateTo != null)
                callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(plannedEndDateTo);
            if (plannedStartDateFrom != null)
                callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(plannedStartDateFrom);
            if (plannedStartDateTo != null)
                callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(plannedStartDateTo);
            if (createdAtFrom != null)
                callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(createdAtFrom);
            if (createdAtTo != null)
                callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(createdAtTo);
            if (updatedAtFrom != null)
                callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(updatedAtFrom);
            if (updatedAtTo != null)
                callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(updatedAtTo);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (assigneeIds != null)
                callPayload.Queries["assigneeIds"] = ExpressionConverter.Convert(assigneeIds);
            if (priorities != null)
                callPayload.Queries["priorities"] = ExpressionConverter.Convert(priorities);
            if (keywords != null)
                callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
            if (assignerIds != null)
                callPayload.Queries["assignerIds"] = ExpressionConverter.Convert(assignerIds);
            if (creatorIds != null)
                callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(creatorIds);
            if (stepIds != null)
                callPayload.Queries["stepIds"] = ExpressionConverter.Convert(stepIds);
            if (statusSchemaId != null)
                callPayload.Queries["statusSchemaId"] = ExpressionConverter.Convert(statusSchemaId);
            if (cursor != null)
                callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (hasProject != null)
                callPayload.Queries["hasProject"] = ExpressionConverter.Convert(hasProject);
            if (customProperties != null)
                callPayload.Queries["customProperties"] = ExpressionConverter.Convert(customProperties);
            if (followerIds != null)
                callPayload.Queries["followerIds"] = ExpressionConverter.Convert(followerIds);
            if (associatedNodeIds != null)
                callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(associatedNodeIds);
            if (contentRefs != null)
                callPayload.Queries["contentRefs"] = ExpressionConverter.Convert(contentRefs);
            callPayload.Queries["includeRequestFormCustomProperties"] = Convert.ToString(false);
            if (includeRequestFormCustomProperties != null)
                callPayload.Queries["includeRequestFormCustomProperties"] = ExpressionConverter.Convert(includeRequestFormCustomProperties);
            return new ApiConnectionAction<PlannerRequestQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteRequests(Expression<Func<string>> spaceId, Expression<Func<string>> contentType = null, Expression<Func<string[]>> bodyrequestIDs = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequestIDs != null)
            {
                body["ids"] = ExpressionConverter.ConvertO(bodyrequestIDs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> CreateRequest(Expression<Func<string>> spaceId, Expression<Func<string>> bodyassigneeID = null, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<ContentRef[]>> bodycontentReferences = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<object>> bodyformReference = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectID = null, Expression<Func<string>> bodystatusSchemaID = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassigneeID != null)
            {
                body["assigneeId"] = ExpressionConverter.ConvertO(bodyassigneeID);
                bodypropCount++;
            }

            if (bodyassociations != null)
            {
                body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                bodypropCount++;
            }

            if (bodycontentReferences != null)
            {
                body["contentRefs"] = ExpressionConverter.ConvertO(bodycontentReferences);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodyformReference != null)
            {
                body["formRef"] = ExpressionConverter.ConvertO(bodyformReference);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodystatusSchemaID != null)
            {
                body["statusSchemaId"] = ExpressionConverter.ConvertO(bodystatusSchemaID);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> GetRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PlannerRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction DeleteRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest> UpdateRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId, Expression<Func<string>> bodyassigneeID = null, Expression<Func<ContentRef[]>> bodycontentReferenceObjects = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<object>> bodyformReference = null, Expression<Func<string>> bodynote = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectID = null, Expression<Func<int>> bodystepID = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassigneeID != null)
            {
                body["assigneeId"] = ExpressionConverter.ConvertO(bodyassigneeID);
                bodypropCount++;
            }

            if (bodycontentReferenceObjects != null)
            {
                body["contentRefs"] = ExpressionConverter.ConvertO(bodycontentReferenceObjects);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodyformReference != null)
            {
                body["formRef"] = ExpressionConverter.ConvertO(bodyformReference);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodystepID != null)
            {
                body["stepId"] = ExpressionConverter.ConvertO(bodystepID);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchemaQueryResponse> GetStatusSchemas(Expression<Func<string>> spaceId, Expression<Func<bool>> isDefault = null, Expression<Func<typeInput>> type = null, Expression<Func<string[]>> ids = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/statusschema", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isDefault != null)
                callPayload.Queries["isDefault"] = ExpressionConverter.Convert(isDefault);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (creatorIds != null)
                callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(creatorIds);
            if (cursor != null)
                callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<StatusSchemaQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchema> GetStatusSchema(Expression<Func<string>> spaceId, Expression<Func<string>> statusSchemaId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/statusschema/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(statusSchemaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTaskQueryResponse> GetTasks(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> updatedAtFrom = null, Expression<Func<string>> updatedAtTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string>> description = null, Expression<Func<string[]>> assigneeIds = null, Expression<Func<prioritiesInputItem[]>> priorities = null, Expression<Func<string>> keywords = null, Expression<Func<string[]>> assignerIds = null, Expression<Func<int[]>> stepIds = null, Expression<Func<string>> statusSchemaId = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<bool>> recursive = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> hasProject = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<bool>> includeAssociations = null, Expression<Func<string>> parentId = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (plannedEndDateFrom != null)
                callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(plannedEndDateFrom);
            if (plannedEndDateTo != null)
                callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(plannedEndDateTo);
            if (plannedStartDateFrom != null)
                callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(plannedStartDateFrom);
            if (plannedStartDateTo != null)
                callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(plannedStartDateTo);
            if (createdAtFrom != null)
                callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(createdAtFrom);
            if (createdAtTo != null)
                callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(createdAtTo);
            if (updatedAtFrom != null)
                callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(updatedAtFrom);
            if (updatedAtTo != null)
                callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(updatedAtTo);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (description != null)
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            if (assigneeIds != null)
                callPayload.Queries["assigneeIds"] = ExpressionConverter.Convert(assigneeIds);
            if (priorities != null)
                callPayload.Queries["priorities"] = ExpressionConverter.Convert(priorities);
            if (keywords != null)
                callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
            if (assignerIds != null)
                callPayload.Queries["assignerIds"] = ExpressionConverter.Convert(assignerIds);
            if (stepIds != null)
                callPayload.Queries["stepIds"] = ExpressionConverter.Convert(stepIds);
            if (statusSchemaId != null)
                callPayload.Queries["statusSchemaId"] = ExpressionConverter.Convert(statusSchemaId);
            if (cursor != null)
                callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (recursive != null)
                callPayload.Queries["recursive"] = ExpressionConverter.Convert(recursive);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (hasProject != null)
                callPayload.Queries["hasProject"] = ExpressionConverter.Convert(hasProject);
            if (customProperties != null)
                callPayload.Queries["customProperties"] = ExpressionConverter.Convert(customProperties);
            if (followerIds != null)
                callPayload.Queries["followerIds"] = ExpressionConverter.Convert(followerIds);
            if (associatedNodeIds != null)
                callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(associatedNodeIds);
            if (creatorIds != null)
                callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(creatorIds);
            if (includeAssociations != null)
                callPayload.Queries["includeAssociations"] = ExpressionConverter.Convert(includeAssociations);
            if (parentId != null)
                callPayload.Queries["parentId"] = ExpressionConverter.Convert(parentId);
            return new ApiConnectionAction<PlannerTaskQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> CreateTask(Expression<Func<string>> spaceId, Expression<Func<string>> bodyassigneeID = null, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentID = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectID = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassigneeID != null)
            {
                body["assigneeId"] = ExpressionConverter.ConvertO(bodyassigneeID);
                bodypropCount++;
            }

            if (bodyassociations != null)
            {
                body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyparentID != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> GetTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PlannerTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse> DeleteTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask> UpdateTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId, Expression<Func<string>> bodyassigneeID = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentID = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectID = null, Expression<Func<int>> bodystepID = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/planner/v2/spaces/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassigneeID != null)
            {
                body["assigneeId"] = ExpressionConverter.ConvertO(bodyassigneeID);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["customProperties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyparentID != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                bodypropCount++;
            }

            if (bodyplannedDuration != null)
            {
                body["plannedDuration"] = ExpressionConverter.ConvertO(bodyplannedDuration);
                bodypropCount++;
            }

            if (bodyplannedEndDate != null)
            {
                body["plannedEndDate"] = ExpressionConverter.ConvertO(bodyplannedEndDate);
                bodypropCount++;
            }

            if (bodyplannedStartDate != null)
            {
                body["plannedStartDate"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodystepID != null)
            {
                body["stepId"] = ExpressionConverter.ConvertO(bodystepID);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlannerTask>(callPayload);
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