//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicplanner
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicplannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<CommentQueryResponse, ApiConnectionActionConfiguration> GetComments(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string[]>> creatorIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_creatorIds = WorkflowExpression.Compile(creatorIds, nameof(creatorIds), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CommentQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments", __workflow_spaceId.WithUrlEncoding(1), __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_creatorIds != null)
                    callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(__workflow_creatorIds);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CommentQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> CreateComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> bodyannotationPayload = null, Expression<Func<string>> bodyannotationType = null, Expression<Func<string>> bodycommentContent = null, Expression<Func<bool>> bodyisResolved = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_bodyannotationPayload = WorkflowExpression.Compile(bodyannotationPayload, nameof(bodyannotationPayload), required: false);
            var __workflow_bodyannotationType = WorkflowExpression.Compile(bodyannotationType, nameof(bodyannotationType), required: false);
            var __workflow_bodycommentContent = WorkflowExpression.Compile(bodycommentContent, nameof(bodycommentContent), required: false);
            var __workflow_bodyisResolved = WorkflowExpression.Compile(bodyisResolved, nameof(bodyisResolved), required: false);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments", __workflow_spaceId.WithUrlEncoding(1), __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyannotationPayload != null)
                {
                    body["annotationPayload"] = ExpressionConverter.ConvertO(__workflow_bodyannotationPayload);
                    bodypropCount++;
                }

                if (__workflow_bodyannotationType != null)
                {
                    body["annotationType"] = ExpressionConverter.ConvertO(__workflow_bodyannotationType);
                    bodypropCount++;
                }

                if (__workflow_bodycommentContent != null)
                {
                    body["commentContent"] = ExpressionConverter.ConvertO(__workflow_bodycommentContent);
                    bodypropCount++;
                }

                if (__workflow_bodyisResolved != null)
                {
                    body["isResolved"] = ExpressionConverter.ConvertO(__workflow_bodyisResolved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> GetComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", __workflow_spaceId.WithUrlEncoding(1), __workflow_nodeId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", __workflow_spaceId.WithUrlEncoding(1), __workflow_nodeId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> UpdateComment(Expression<Func<string>> spaceId, Expression<Func<string>> nodeId, Expression<Func<string>> commentId, Expression<Func<string>> bodyannotationPayload = null, Expression<Func<string>> bodyannotationType = null, Expression<Func<string>> bodycommentContent = null, Expression<Func<bool>> bodyisResolved = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_bodyannotationPayload = WorkflowExpression.Compile(bodyannotationPayload, nameof(bodyannotationPayload), required: false);
            var __workflow_bodyannotationType = WorkflowExpression.Compile(bodyannotationType, nameof(bodyannotationType), required: false);
            var __workflow_bodycommentContent = WorkflowExpression.Compile(bodycommentContent, nameof(bodycommentContent), required: false);
            var __workflow_bodyisResolved = WorkflowExpression.Compile(bodyisResolved, nameof(bodyisResolved), required: false);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/nodes/{1}/comments/{2}", __workflow_spaceId.WithUrlEncoding(1), __workflow_nodeId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyannotationPayload != null)
                {
                    body["annotationPayload"] = ExpressionConverter.ConvertO(__workflow_bodyannotationPayload);
                    bodypropCount++;
                }

                if (__workflow_bodyannotationType != null)
                {
                    body["annotationType"] = ExpressionConverter.ConvertO(__workflow_bodyannotationType);
                    bodypropCount++;
                }

                if (__workflow_bodycommentContent != null)
                {
                    body["commentContent"] = ExpressionConverter.ConvertO(__workflow_bodycommentContent);
                    bodypropCount++;
                }

                if (__workflow_bodyisResolved != null)
                {
                    body["isResolved"] = ExpressionConverter.ConvertO(__workflow_bodyisResolved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProjectQueryResponse, ApiConnectionActionConfiguration> GetProjects(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string[]>> managerIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<bool>> includeAssociations = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_plannedEndDateFrom = WorkflowExpression.Compile(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            var __workflow_plannedEndDateTo = WorkflowExpression.Compile(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            var __workflow_plannedStartDateFrom = WorkflowExpression.Compile(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            var __workflow_plannedStartDateTo = WorkflowExpression.Compile(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_managerIds = WorkflowExpression.Compile(managerIds, nameof(managerIds), required: false);
            var __workflow_creatorIds = WorkflowExpression.Compile(creatorIds, nameof(creatorIds), required: false);
            var __workflow_associatedNodeIds = WorkflowExpression.Compile(associatedNodeIds, nameof(associatedNodeIds), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_customProperties = WorkflowExpression.Compile(customProperties, nameof(customProperties), required: false);
            var __workflow_followerIds = WorkflowExpression.Compile(followerIds, nameof(followerIds), required: false);
            var __workflow_includeAssociations = WorkflowExpression.Compile(includeAssociations, nameof(includeAssociations), required: false);
            return new DeferredBodyAction<PlannerProjectQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(__workflow_plannedEndDateFrom);
                if (__workflow_plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(__workflow_plannedEndDateTo);
                if (__workflow_plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(__workflow_plannedStartDateFrom);
                if (__workflow_plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(__workflow_plannedStartDateTo);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_managerIds != null)
                    callPayload.Queries["managerIds"] = ExpressionConverter.Convert(__workflow_managerIds);
                if (__workflow_creatorIds != null)
                    callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(__workflow_creatorIds);
                if (__workflow_associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(__workflow_associatedNodeIds);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_customProperties != null)
                    callPayload.Queries["customProperties"] = ExpressionConverter.Convert(__workflow_customProperties);
                if (__workflow_followerIds != null)
                    callPayload.Queries["followerIds"] = ExpressionConverter.Convert(__workflow_followerIds);
                callPayload.Queries["includeAssociations"] = Convert.ToString(false);
                if (__workflow_includeAssociations != null)
                    callPayload.Queries["includeAssociations"] = ExpressionConverter.Convert(__workflow_includeAssociations);
                return new ApiConnectionAction<PlannerProjectQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse, ApiConnectionActionConfiguration> DeleteProjects(Expression<Func<string>> spaceId, Expression<Func<string[]>> ids, Expression<Func<bool>> deleteTasks = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            var __workflow_deleteTasks = WorkflowExpression.Compile(deleteTasks, nameof(deleteTasks), required: false);
            return new DeferredBodyAction<AsyncOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                callPayload.Queries["deleteTasks"] = Convert.ToString(false);
                if (__workflow_deleteTasks != null)
                    callPayload.Queries["deleteTasks"] = ExpressionConverter.Convert(__workflow_deleteTasks);
                return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> spaceId, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_bodyassociations = WorkflowExpression.Compile(bodyassociations, nameof(bodyassociations), required: false);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(__workflow_bodyassociations);
                    bodypropCount++;
                }

                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<int>> associatedNodesDepth = null, Expression<Func<bool>> includeWorks = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_associatedNodesDepth = WorkflowExpression.Compile(associatedNodesDepth, nameof(associatedNodesDepth), required: false);
            var __workflow_includeWorks = WorkflowExpression.Compile(includeWorks, nameof(includeWorks), required: false);
            return new DeferredBodyAction<PlannerProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_associatedNodesDepth != null)
                    callPayload.Queries["associatedNodesDepth"] = ExpressionConverter.Convert(__workflow_associatedNodesDepth);
                if (__workflow_includeWorks != null)
                    callPayload.Queries["includeWorks"] = ExpressionConverter.Convert(__workflow_includeWorks);
                return new ApiConnectionAction<PlannerProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse, ApiConnectionActionConfiguration> DeleteProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<bool>> deleteTasks = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_deleteTasks = WorkflowExpression.Compile(deleteTasks, nameof(deleteTasks), required: false);
            return new DeferredBodyAction<AsyncOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["deleteTasks"] = Convert.ToString(false);
                if (__workflow_deleteTasks != null)
                    callPayload.Queries["deleteTasks"] = ExpressionConverter.Convert(__workflow_deleteTasks);
                return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerProject, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> spaceId, Expression<Func<string>> projectId, Expression<Func<CustomPropertyValues[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisActive = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<string>> bodymaxRank = null, Expression<Func<string>> bodyminRank = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyisActive = WorkflowExpression.Compile(bodyisActive, nameof(bodyisActive), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodymaxRank = WorkflowExpression.Compile(bodymaxRank, nameof(bodymaxRank), required: false);
            var __workflow_bodyminRank = WorkflowExpression.Compile(bodyminRank, nameof(bodyminRank), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/projects/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyisActive != null)
                {
                    body["isActive"] = ExpressionConverter.ConvertO(__workflow_bodyisActive);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodymaxRank != null)
                {
                    body["maxRank"] = ExpressionConverter.ConvertO(__workflow_bodymaxRank);
                    bodypropCount++;
                }

                if (__workflow_bodyminRank != null)
                {
                    body["minRank"] = ExpressionConverter.ConvertO(__workflow_bodyminRank);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequestQueryResponse, ApiConnectionActionConfiguration> GetRequests(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> updatedAtFrom = null, Expression<Func<string>> updatedAtTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string[]>> assigneeIds = null, Expression<Func<prioritiesInputItem[]>> priorities = null, Expression<Func<string>> keywords = null, Expression<Func<string[]>> assignerIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<int[]>> stepIds = null, Expression<Func<string>> statusSchemaId = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> hasProject = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string[]>> contentRefs = null, Expression<Func<bool>> includeRequestFormCustomProperties = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_plannedEndDateFrom = WorkflowExpression.Compile(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            var __workflow_plannedEndDateTo = WorkflowExpression.Compile(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            var __workflow_plannedStartDateFrom = WorkflowExpression.Compile(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            var __workflow_plannedStartDateTo = WorkflowExpression.Compile(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            var __workflow_createdAtFrom = WorkflowExpression.Compile(createdAtFrom, nameof(createdAtFrom), required: false);
            var __workflow_createdAtTo = WorkflowExpression.Compile(createdAtTo, nameof(createdAtTo), required: false);
            var __workflow_updatedAtFrom = WorkflowExpression.Compile(updatedAtFrom, nameof(updatedAtFrom), required: false);
            var __workflow_updatedAtTo = WorkflowExpression.Compile(updatedAtTo, nameof(updatedAtTo), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_assigneeIds = WorkflowExpression.Compile(assigneeIds, nameof(assigneeIds), required: false);
            var __workflow_priorities = WorkflowExpression.Compile(priorities, nameof(priorities), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            var __workflow_assignerIds = WorkflowExpression.Compile(assignerIds, nameof(assignerIds), required: false);
            var __workflow_creatorIds = WorkflowExpression.Compile(creatorIds, nameof(creatorIds), required: false);
            var __workflow_stepIds = WorkflowExpression.Compile(stepIds, nameof(stepIds), required: false);
            var __workflow_statusSchemaId = WorkflowExpression.Compile(statusSchemaId, nameof(statusSchemaId), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_hasProject = WorkflowExpression.Compile(hasProject, nameof(hasProject), required: false);
            var __workflow_customProperties = WorkflowExpression.Compile(customProperties, nameof(customProperties), required: false);
            var __workflow_followerIds = WorkflowExpression.Compile(followerIds, nameof(followerIds), required: false);
            var __workflow_associatedNodeIds = WorkflowExpression.Compile(associatedNodeIds, nameof(associatedNodeIds), required: false);
            var __workflow_contentRefs = WorkflowExpression.Compile(contentRefs, nameof(contentRefs), required: false);
            var __workflow_includeRequestFormCustomProperties = WorkflowExpression.Compile(includeRequestFormCustomProperties, nameof(includeRequestFormCustomProperties), required: false);
            return new DeferredBodyAction<PlannerRequestQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(__workflow_plannedEndDateFrom);
                if (__workflow_plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(__workflow_plannedEndDateTo);
                if (__workflow_plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(__workflow_plannedStartDateFrom);
                if (__workflow_plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(__workflow_plannedStartDateTo);
                if (__workflow_createdAtFrom != null)
                    callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(__workflow_createdAtFrom);
                if (__workflow_createdAtTo != null)
                    callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(__workflow_createdAtTo);
                if (__workflow_updatedAtFrom != null)
                    callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(__workflow_updatedAtFrom);
                if (__workflow_updatedAtTo != null)
                    callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(__workflow_updatedAtTo);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_assigneeIds != null)
                    callPayload.Queries["assigneeIds"] = ExpressionConverter.Convert(__workflow_assigneeIds);
                if (__workflow_priorities != null)
                    callPayload.Queries["priorities"] = ExpressionConverter.Convert(__workflow_priorities);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_assignerIds != null)
                    callPayload.Queries["assignerIds"] = ExpressionConverter.Convert(__workflow_assignerIds);
                if (__workflow_creatorIds != null)
                    callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(__workflow_creatorIds);
                if (__workflow_stepIds != null)
                    callPayload.Queries["stepIds"] = ExpressionConverter.Convert(__workflow_stepIds);
                if (__workflow_statusSchemaId != null)
                    callPayload.Queries["statusSchemaId"] = ExpressionConverter.Convert(__workflow_statusSchemaId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_hasProject != null)
                    callPayload.Queries["hasProject"] = ExpressionConverter.Convert(__workflow_hasProject);
                if (__workflow_customProperties != null)
                    callPayload.Queries["customProperties"] = ExpressionConverter.Convert(__workflow_customProperties);
                if (__workflow_followerIds != null)
                    callPayload.Queries["followerIds"] = ExpressionConverter.Convert(__workflow_followerIds);
                if (__workflow_associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(__workflow_associatedNodeIds);
                if (__workflow_contentRefs != null)
                    callPayload.Queries["contentRefs"] = ExpressionConverter.Convert(__workflow_contentRefs);
                callPayload.Queries["includeRequestFormCustomProperties"] = Convert.ToString(false);
                if (__workflow_includeRequestFormCustomProperties != null)
                    callPayload.Queries["includeRequestFormCustomProperties"] = ExpressionConverter.Convert(__workflow_includeRequestFormCustomProperties);
                return new ApiConnectionAction<PlannerRequestQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse, ApiConnectionActionConfiguration> DeleteRequests(Expression<Func<string>> spaceId, Expression<Func<string>> contentType = null, Expression<Func<string[]>> bodyrequestIDs = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodyrequestIDs = WorkflowExpression.Compile(bodyrequestIDs, nameof(bodyrequestIDs), required: false);
            return new DeferredBodyAction<AsyncOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequestIDs != null)
                {
                    body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyrequestIDs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest, ApiConnectionActionConfiguration> CreateRequest(Expression<Func<string>> spaceId, Expression<Func<string>> bodyassigneeId = null, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<ContentRef[]>> bodycontentReferences = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<object>> bodyformReference = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodystatusSchemaId = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_bodyassigneeId = WorkflowExpression.Compile(bodyassigneeId, nameof(bodyassigneeId), required: false);
            var __workflow_bodyassociations = WorkflowExpression.Compile(bodyassociations, nameof(bodyassociations), required: false);
            var __workflow_bodycontentReferences = WorkflowExpression.Compile(bodycontentReferences, nameof(bodycontentReferences), required: false);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodyformReference = WorkflowExpression.Compile(bodyformReference, nameof(bodyformReference), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodystatusSchemaId = WorkflowExpression.Compile(bodystatusSchemaId, nameof(bodystatusSchemaId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassigneeId != null)
                {
                    body["assigneeId"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeId);
                    bodypropCount++;
                }

                if (__workflow_bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(__workflow_bodyassociations);
                    bodypropCount++;
                }

                if (__workflow_bodycontentReferences != null)
                {
                    body["contentRefs"] = ExpressionConverter.ConvertO(__workflow_bodycontentReferences);
                    bodypropCount++;
                }

                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodyformReference != null)
                {
                    body["formRef"] = ExpressionConverter.ConvertO(__workflow_bodyformReference);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodystatusSchemaId != null)
                {
                    body["statusSchemaId"] = ExpressionConverter.ConvertO(__workflow_bodystatusSchemaId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest, ApiConnectionActionConfiguration> GetRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<PlannerRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PlannerRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerRequest, ApiConnectionActionConfiguration> UpdateRequest(Expression<Func<string>> spaceId, Expression<Func<string>> requestId, Expression<Func<string>> bodyassigneeId = null, Expression<Func<ContentRef[]>> bodycontentReferenceObjects = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<object>> bodyformReference = null, Expression<Func<string>> bodynote = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodystepId = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_bodyassigneeId = WorkflowExpression.Compile(bodyassigneeId, nameof(bodyassigneeId), required: false);
            var __workflow_bodycontentReferenceObjects = WorkflowExpression.Compile(bodycontentReferenceObjects, nameof(bodycontentReferenceObjects), required: false);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodyformReference = WorkflowExpression.Compile(bodyformReference, nameof(bodyformReference), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodystepId = WorkflowExpression.Compile(bodystepId, nameof(bodystepId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/requests/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassigneeId != null)
                {
                    body["assigneeId"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeId);
                    bodypropCount++;
                }

                if (__workflow_bodycontentReferenceObjects != null)
                {
                    body["contentRefs"] = ExpressionConverter.ConvertO(__workflow_bodycontentReferenceObjects);
                    bodypropCount++;
                }

                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodyformReference != null)
                {
                    body["formRef"] = ExpressionConverter.ConvertO(__workflow_bodyformReference);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodystepId != null)
                {
                    body["stepId"] = ExpressionConverter.ConvertO(__workflow_bodystepId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchemaQueryResponse, ApiConnectionActionConfiguration> GetStatusSchemas(Expression<Func<string>> spaceId, Expression<Func<bool>> isDefault = null, Expression<Func<typeInput>> type = null, Expression<Func<string[]>> ids = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_isDefault = WorkflowExpression.Compile(isDefault, nameof(isDefault), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_creatorIds = WorkflowExpression.Compile(creatorIds, nameof(creatorIds), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<StatusSchemaQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/statusschema", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_isDefault != null)
                    callPayload.Queries["isDefault"] = ExpressionConverter.Convert(__workflow_isDefault);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_creatorIds != null)
                    callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(__workflow_creatorIds);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<StatusSchemaQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<StatusSchema, ApiConnectionActionConfiguration> GetStatusSchema(Expression<Func<string>> spaceId, Expression<Func<string>> statusSchemaId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_statusSchemaId = WorkflowExpression.Compile(statusSchemaId, nameof(statusSchemaId), required: true);
            return new DeferredBodyAction<StatusSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/statusschema/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_statusSchemaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTaskQueryResponse, ApiConnectionActionConfiguration> GetTasks(Expression<Func<string>> spaceId, Expression<Func<string>> plannedEndDateFrom = null, Expression<Func<string>> plannedEndDateTo = null, Expression<Func<string>> plannedStartDateFrom = null, Expression<Func<string>> plannedStartDateTo = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> updatedAtFrom = null, Expression<Func<string>> updatedAtTo = null, Expression<Func<string[]>> ids = null, Expression<Func<string>> title = null, Expression<Func<string>> description = null, Expression<Func<string[]>> assigneeIds = null, Expression<Func<prioritiesInputItem[]>> priorities = null, Expression<Func<string>> keywords = null, Expression<Func<string[]>> assignerIds = null, Expression<Func<int[]>> stepIds = null, Expression<Func<string>> statusSchemaId = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<bool>> recursive = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> hasProject = null, Expression<Func<string>> customProperties = null, Expression<Func<string[]>> followerIds = null, Expression<Func<string[]>> associatedNodeIds = null, Expression<Func<string[]>> creatorIds = null, Expression<Func<bool>> includeAssociations = null, Expression<Func<string>> parentId = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_plannedEndDateFrom = WorkflowExpression.Compile(plannedEndDateFrom, nameof(plannedEndDateFrom), required: false);
            var __workflow_plannedEndDateTo = WorkflowExpression.Compile(plannedEndDateTo, nameof(plannedEndDateTo), required: false);
            var __workflow_plannedStartDateFrom = WorkflowExpression.Compile(plannedStartDateFrom, nameof(plannedStartDateFrom), required: false);
            var __workflow_plannedStartDateTo = WorkflowExpression.Compile(plannedStartDateTo, nameof(plannedStartDateTo), required: false);
            var __workflow_createdAtFrom = WorkflowExpression.Compile(createdAtFrom, nameof(createdAtFrom), required: false);
            var __workflow_createdAtTo = WorkflowExpression.Compile(createdAtTo, nameof(createdAtTo), required: false);
            var __workflow_updatedAtFrom = WorkflowExpression.Compile(updatedAtFrom, nameof(updatedAtFrom), required: false);
            var __workflow_updatedAtTo = WorkflowExpression.Compile(updatedAtTo, nameof(updatedAtTo), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_assigneeIds = WorkflowExpression.Compile(assigneeIds, nameof(assigneeIds), required: false);
            var __workflow_priorities = WorkflowExpression.Compile(priorities, nameof(priorities), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            var __workflow_assignerIds = WorkflowExpression.Compile(assignerIds, nameof(assignerIds), required: false);
            var __workflow_stepIds = WorkflowExpression.Compile(stepIds, nameof(stepIds), required: false);
            var __workflow_statusSchemaId = WorkflowExpression.Compile(statusSchemaId, nameof(statusSchemaId), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_recursive = WorkflowExpression.Compile(recursive, nameof(recursive), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_hasProject = WorkflowExpression.Compile(hasProject, nameof(hasProject), required: false);
            var __workflow_customProperties = WorkflowExpression.Compile(customProperties, nameof(customProperties), required: false);
            var __workflow_followerIds = WorkflowExpression.Compile(followerIds, nameof(followerIds), required: false);
            var __workflow_associatedNodeIds = WorkflowExpression.Compile(associatedNodeIds, nameof(associatedNodeIds), required: false);
            var __workflow_creatorIds = WorkflowExpression.Compile(creatorIds, nameof(creatorIds), required: false);
            var __workflow_includeAssociations = WorkflowExpression.Compile(includeAssociations, nameof(includeAssociations), required: false);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: false);
            return new DeferredBodyAction<PlannerTaskQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/tasks", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_plannedEndDateFrom != null)
                    callPayload.Queries["plannedEndDateFrom"] = ExpressionConverter.Convert(__workflow_plannedEndDateFrom);
                if (__workflow_plannedEndDateTo != null)
                    callPayload.Queries["plannedEndDateTo"] = ExpressionConverter.Convert(__workflow_plannedEndDateTo);
                if (__workflow_plannedStartDateFrom != null)
                    callPayload.Queries["plannedStartDateFrom"] = ExpressionConverter.Convert(__workflow_plannedStartDateFrom);
                if (__workflow_plannedStartDateTo != null)
                    callPayload.Queries["plannedStartDateTo"] = ExpressionConverter.Convert(__workflow_plannedStartDateTo);
                if (__workflow_createdAtFrom != null)
                    callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(__workflow_createdAtFrom);
                if (__workflow_createdAtTo != null)
                    callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(__workflow_createdAtTo);
                if (__workflow_updatedAtFrom != null)
                    callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(__workflow_updatedAtFrom);
                if (__workflow_updatedAtTo != null)
                    callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(__workflow_updatedAtTo);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_assigneeIds != null)
                    callPayload.Queries["assigneeIds"] = ExpressionConverter.Convert(__workflow_assigneeIds);
                if (__workflow_priorities != null)
                    callPayload.Queries["priorities"] = ExpressionConverter.Convert(__workflow_priorities);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_assignerIds != null)
                    callPayload.Queries["assignerIds"] = ExpressionConverter.Convert(__workflow_assignerIds);
                if (__workflow_stepIds != null)
                    callPayload.Queries["stepIds"] = ExpressionConverter.Convert(__workflow_stepIds);
                if (__workflow_statusSchemaId != null)
                    callPayload.Queries["statusSchemaId"] = ExpressionConverter.Convert(__workflow_statusSchemaId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_recursive != null)
                    callPayload.Queries["recursive"] = ExpressionConverter.Convert(__workflow_recursive);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_hasProject != null)
                    callPayload.Queries["hasProject"] = ExpressionConverter.Convert(__workflow_hasProject);
                if (__workflow_customProperties != null)
                    callPayload.Queries["customProperties"] = ExpressionConverter.Convert(__workflow_customProperties);
                if (__workflow_followerIds != null)
                    callPayload.Queries["followerIds"] = ExpressionConverter.Convert(__workflow_followerIds);
                if (__workflow_associatedNodeIds != null)
                    callPayload.Queries["associatedNodeIds"] = ExpressionConverter.Convert(__workflow_associatedNodeIds);
                if (__workflow_creatorIds != null)
                    callPayload.Queries["creatorIds"] = ExpressionConverter.Convert(__workflow_creatorIds);
                if (__workflow_includeAssociations != null)
                    callPayload.Queries["includeAssociations"] = ExpressionConverter.Convert(__workflow_includeAssociations);
                if (__workflow_parentId != null)
                    callPayload.Queries["parentId"] = ExpressionConverter.Convert(__workflow_parentId);
                return new ApiConnectionAction<PlannerTaskQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> spaceId, Expression<Func<string>> bodyassigneeId = null, Expression<Func<AssociationReq[]>> bodyassociations = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentId = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_bodyassigneeId = WorkflowExpression.Compile(bodyassigneeId, nameof(bodyassigneeId), required: false);
            var __workflow_bodyassociations = WorkflowExpression.Compile(bodyassociations, nameof(bodyassociations), required: false);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/tasks", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassigneeId != null)
                {
                    body["assigneeId"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeId);
                    bodypropCount++;
                }

                if (__workflow_bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(__workflow_bodyassociations);
                    bodypropCount++;
                }

                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<PlannerTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PlannerTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<AsyncOperationResponse, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<AsyncOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicplanner")]
        public IBodyWorkflowAction<PlannerTask, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> spaceId, Expression<Func<string>> taskId, Expression<Func<string>> bodyassigneeId = null, Expression<Func<CustomPropertyValuesInput[]>> bodycustomProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentId = null, Expression<Func<int>> bodyplannedDuration = null, Expression<Func<string>> bodyplannedEndDate = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodystepId = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_bodyassigneeId = WorkflowExpression.Compile(bodyassigneeId, nameof(bodyassigneeId), required: false);
            var __workflow_bodycustomProperties = WorkflowExpression.Compile(bodycustomProperties, nameof(bodycustomProperties), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyplannedDuration = WorkflowExpression.Compile(bodyplannedDuration, nameof(bodyplannedDuration), required: false);
            var __workflow_bodyplannedEndDate = WorkflowExpression.Compile(bodyplannedEndDate, nameof(bodyplannedEndDate), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodystepId = WorkflowExpression.Compile(bodystepId, nameof(bodystepId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PlannerTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planner/v2/spaces/{0}/tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassigneeId != null)
                {
                    body["assigneeId"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomProperties != null)
                {
                    body["customProperties"] = ExpressionConverter.ConvertO(__workflow_bodycustomProperties);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedDuration != null)
                {
                    body["plannedDuration"] = ExpressionConverter.ConvertO(__workflow_bodyplannedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedEndDate != null)
                {
                    body["plannedEndDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodystepId != null)
                {
                    body["stepId"] = ExpressionConverter.ConvertO(__workflow_bodystepId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlannerTask>(callPayload);
            });
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
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("nodeType")]
        public CommentNodeTypeType NodeType { get; set; }

        [JsonProperty("pageIndex")]
        public string PageIndex { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("replyCount")]
        public int ReplyCount { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CreatorId { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

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
        public string SpaceId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

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
        public string NodeId { get; set; }

        [JsonProperty("nodeType")]
        public ProjectAssociatedNodesNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string NodeId { get; set; }

        [JsonProperty("nodeType")]
        public AssociationNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceGuid")]
        public string SpaceGUID { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CustomPropertyId { get; set; }

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
        public string ValueId { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class Follower
    {
        [JsonProperty("id")]
        public string UserUserGroupId { get; set; }

        [JsonProperty("type")]
        public FollowerTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string AssigneId { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerId { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("copyFrom")]
        public string CopyFrom { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("maxRank")]
        public string MaxRank { get; set; }

        [JsonProperty("minRank")]
        public string MinRank { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("priority")]
        public PlannerTaskPriorityType Priority { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaId { get; set; }

        [JsonProperty("stepId")]
        public int StepId { get; set; }

        [JsonProperty("subTaskIds")]
        public string[] SubTaskIDs { get; set; }

        [JsonProperty("subTasks")]
        public PlannerSubTask[] SubTasks { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public PlannerTaskTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string AssigneeId { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerId { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("copyFrom")]
        public string CopyFrom { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("maxRank")]
        public string MaxRank { get; set; }

        [JsonProperty("minRank")]
        public string MinRank { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("plannedDuration")]
        public int PlannedDuration { get; set; }

        [JsonProperty("plannedEndDate")]
        public string PlannedEndDate { get; set; }

        [JsonProperty("plannedStartDate")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("priority")]
        public PlannerSubTaskPriorityType Priority { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaId { get; set; }

        [JsonProperty("stepId")]
        public int StepId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public PlannerSubTaskTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdateAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlannerSubTaskTypeType
    {
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "task")]
        TaskObject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string NodeId { get; set; }

        [JsonProperty("nodeType")]
        public AssociationReqNodeTypeType NodeType { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CustomPropertyId { get; set; }

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
        public string AssigneeId { get; set; }

        [JsonProperty("assignerId")]
        public string AssignerId { get; set; }

        [JsonProperty("associations")]
        public Association[] Associations { get; set; }

        [JsonProperty("contentRefs")]
        public ContentRef[] ContentReferenceObjects { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("customProperties")]
        public CustomPropertyValues[] CustomProperties { get; set; }

        [JsonProperty("followers")]
        public Follower[] Followers { get; set; }

        [JsonProperty("formRef")]
        public JToken FormRef { get; set; }

        [JsonProperty("id")]
        public string RequestId { get; set; }

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
        public string ProjectId { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("requestFormCustomPropertyOption")]
        public RequestFormCustomProperties RequestFormCustomPropertyOption { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("statusSchemaId")]
        public string StatusSchemaId { get; set; }

        [JsonProperty("stepId")]
        public int StepId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ContentRef
    {
        [JsonProperty("contentId")]
        public string ContentId { get; set; }

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
        public string ProfileId { get; set; }

        [JsonProperty("profileVersionId")]
        public string ProfileVersionId { get; set; }

        [JsonProperty("source")]
        public ContentRefSourceType Source { get; set; }

        [JsonProperty("teamSiteId")]
        public string TeamSiteId { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailId { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContentRefSourceType
    {
        Library,
        DocCenter,
        NewsCenter,
        Workspace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CreatedById { get; set; }

        [JsonProperty("hasDomainOfValues")]
        public bool HasDomainOfValues { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("id")]
        public string CustomPropertyId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomPropertyOperationSettingType
    {
        Editable,
        ReadOnly,
        Hidden
    }

    public class PossibleValuesItem
    {
        [JsonProperty("id")]
        public string ValueId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomPropertyValueTypeType
    {
        Boolean,
        Integer,
        Double,
        DateTime,
        String,
        Dictionary
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string StatusSchemaId { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("steps")]
        public string[] Steps { get; set; }

        [JsonProperty("transitions")]
        public int[][] Transitions { get; set; }

        [JsonProperty("type")]
        public StatusSchemaTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusSchemaTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "request")]
        Request
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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