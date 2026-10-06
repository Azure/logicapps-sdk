//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynatrace
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynatraceActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetProblems))]
        public IBodyWorkflowAction<GetProblemsResponse> GetProblems([WorkflowExpression] Func<string> from = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProblemsResponse> __BuildGetProblems(WorkflowExpression<string> from = null)
        {
            WorkflowExpression.Validate(from, nameof(from), required: false);
            return new DeferredBodyAction<GetProblemsResponse>(() =>
            {
                var apiCallPath = "/api/v2/problems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["from"] = Convert.ToString("now-2h");
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                callPayload.Headers["accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<GetProblemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetProblemById))]
        public IBodyWorkflowAction<GetProblemByIdResponse> GetProblemById([WorkflowExpression] Func<string> problemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProblemByIdResponse> __BuildGetProblemById(WorkflowExpression<string> problemId)
        {
            WorkflowExpression.Validate(problemId, nameof(problemId), required: true);
            return new DeferredBodyAction<GetProblemByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/problems/{0}", ExpressionConverter.ConvertWithUrlEncoding(problemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<GetProblemByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetProblemComments))]
        public IWorkflowAction GetProblemComments([WorkflowExpression] Func<string> problemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetProblemComments(WorkflowExpression<string> problemId)
        {
            WorkflowExpression.Validate(problemId, nameof(problemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/problems/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(problemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildPostProblemComment))]
        public IWorkflowAction PostProblemComment([WorkflowExpression] Func<string> problemId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodycontext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostProblemComment(WorkflowExpression<string> problemId, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> bodycontext = null)
        {
            WorkflowExpression.Validate(problemId, nameof(problemId), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodycontext, nameof(bodycontext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/problems/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(problemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json;charset=utf-8");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                if (bodycontext != null)
                {
                    body["context"] = ExpressionConverter.ConvertO(bodycontext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetProblemCommentByProblemIdAndCommentId))]
        public IBodyWorkflowAction<GetProblemCommentByProblemIdAndCommentIdResponse> GetProblemCommentByProblemIdAndCommentId([WorkflowExpression] Func<string> problemId, [WorkflowExpression] Func<string> commentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProblemCommentByProblemIdAndCommentIdResponse> __BuildGetProblemCommentByProblemIdAndCommentId(WorkflowExpression<string> problemId, WorkflowExpression<string> commentId)
        {
            WorkflowExpression.Validate(problemId, nameof(problemId), required: true);
            WorkflowExpression.Validate(commentId, nameof(commentId), required: true);
            return new DeferredBodyAction<GetProblemCommentByProblemIdAndCommentIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/problems/{0}/comments/{1}", ExpressionConverter.ConvertWithUrlEncoding(problemId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["accept"] = Convert.ToString("application/json; charset=utf-8");
                return new ApiConnectionAction<GetProblemCommentByProblemIdAndCommentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetEvents))]
        public IBodyWorkflowAction<GetEventsResponse> GetEvents([WorkflowExpression] Func<string> from = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEventsResponse> __BuildGetEvents(WorkflowExpression<string> from = null)
        {
            WorkflowExpression.Validate(from, nameof(from), required: false);
            return new DeferredBodyAction<GetEventsResponse>(() =>
            {
                var apiCallPath = "/api/v2/events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["from"] = Convert.ToString("now-2h");
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                return new ApiConnectionAction<GetEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntities))]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities([WorkflowExpression] Func<string> entitySelector, [WorkflowExpression] Func<string> from = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntitiesResponse> __BuildGetEntities(WorkflowExpression<string> entitySelector, WorkflowExpression<string> from = null)
        {
            WorkflowExpression.Validate(entitySelector, nameof(entitySelector), required: true);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            return new DeferredBodyAction<GetEntitiesResponse>(() =>
            {
                var apiCallPath = "/api/v2/entities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entitySelector"] = ExpressionConverter.Convert(entitySelector);
                callPayload.Queries["from"] = Convert.ToString("now-3d");
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                return new ApiConnectionAction<GetEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntityById))]
        public IBodyWorkflowAction<GetEntityByIdResponse> GetEntityById([WorkflowExpression] Func<string> entityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntityByIdResponse> __BuildGetEntityById(WorkflowExpression<string> entityId)
        {
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<GetEntityByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/entities/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEntityByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildPostEventIngest))]
        public IWorkflowAction PostEventIngest([WorkflowExpression] Func<string> bodyeventType, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodytimeout = null, [WorkflowExpression] Func<string> bodyentitySelector = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEventIngest(WorkflowExpression<string> bodyeventType, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<int> bodytimeout = null, WorkflowExpression<string> bodyentitySelector = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodytimeout, nameof(bodytimeout), required: false);
            WorkflowExpression.Validate(bodyentitySelector, nameof(bodyentitySelector), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v2/events/ingest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json;charset=utf-8");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodystartTime != null)
                {
                    body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodytimeout != null)
                {
                    body["timeout"] = ExpressionConverter.ConvertO(bodytimeout);
                    bodypropCount++;
                }

                if (bodyentitySelector != null)
                {
                    body["entitySelector"] = ExpressionConverter.ConvertO(bodyentitySelector);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecurityProblems))]
        public IBodyWorkflowAction<GetSecurityProblemsResponse> GetSecurityProblems([WorkflowExpression] Func<string> securityProblemSelector = null, [WorkflowExpression] Func<string> from = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecurityProblemsResponse> __BuildGetSecurityProblems(WorkflowExpression<string> securityProblemSelector = null, WorkflowExpression<string> from = null)
        {
            WorkflowExpression.Validate(securityProblemSelector, nameof(securityProblemSelector), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            return new DeferredBodyAction<GetSecurityProblemsResponse>(() =>
            {
                var apiCallPath = "/api/v2/securityProblems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["securityProblemSelector"] = Convert.ToString("status(\"open\")");
                if (securityProblemSelector != null)
                    callPayload.Queries["securityProblemSelector"] = ExpressionConverter.Convert(securityProblemSelector);
                callPayload.Queries["from"] = Convert.ToString("now-30d");
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                return new ApiConnectionAction<GetSecurityProblemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecurityProblemsById))]
        public IBodyWorkflowAction<GetSecurityProblemsByIdResponse> GetSecurityProblemsById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynatrace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecurityProblemsByIdResponse> __BuildGetSecurityProblemsById(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<GetSecurityProblemsByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/securityProblems/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<GetSecurityProblemsByIdResponse>(callPayload);
            });
        }
    }

    public class DynatraceTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetProblemsResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("problems")]
        public GetProblemsResponseProblemsTypeItem[] Problems { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItem
    {
        [JsonProperty("affectedEntities")]
        public GetProblemsResponseProblemsTypeItemAffectedEntitiesTypeItem[] AffectedEntities { get; set; }

        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("impactedEntities")]
        public GetProblemsResponseProblemsTypeItemImpactedEntitiesTypeItem[] ImpactedEntities { get; set; }

        [JsonProperty("linkedProblemInfo")]
        public GetProblemsResponseProblemsTypeItemLinkedProblemInfoType LinkedProblemInfo { get; set; }

        [JsonProperty("problemFilters")]
        public GetProblemsResponseProblemsTypeItemProblemFiltersTypeItem[] ProblemFilters { get; set; }

        [JsonProperty("evidenceDetails")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsType EvidenceDetails { get; set; }

        [JsonProperty("recentComments")]
        public GetProblemsResponseProblemsTypeItemRecentCommentsType RecentComments { get; set; }

        [JsonProperty("impactAnalysis")]
        public GetProblemsResponseProblemsTypeItemImpactAnalysisType ImpactAnalysis { get; set; }

        [JsonProperty("rootCauseEntity")]
        public GetProblemsResponseProblemsTypeItemRootCauseEntityType RootCauseEntity { get; set; }

        [JsonProperty("managementZones")]
        public GetProblemsResponseProblemsTypeItemManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("severityLevel")]
        public string SeverityLevel { get; set; }

        [JsonProperty("entityTags")]
        public GetProblemsResponseProblemsTypeItemEntityTagsTypeItem[] EntityTags { get; set; }

        [JsonProperty("problemId")]
        public string ProblemId { get; set; }

        [JsonProperty("impactLevel")]
        public string ImpactLevel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemAffectedEntitiesTypeItem
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemAffectedEntitiesTypeItemEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemAffectedEntitiesTypeItemEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactedEntitiesTypeItem
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemImpactedEntitiesTypeItemEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactedEntitiesTypeItemEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemLinkedProblemInfoType
    {
        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("problemId")]
        public string ProblemId { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemProblemFiltersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("details")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItem[] Details { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItem
    {
        [JsonProperty("evidenceType")]
        public string EvidenceType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("entity")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemEntityType Entity { get; set; }

        [JsonProperty("groupingEntity")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemGroupingEntityType GroupingEntity { get; set; }

        [JsonProperty("rootCauseRelevant")]
        public bool RootCauseRelevant { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemGroupingEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemGroupingEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEvidenceDetailsTypeDetailsTypeItemGroupingEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemRecentCommentsType
    {
        [JsonProperty("comments")]
        public GetProblemsResponseProblemsTypeItemRecentCommentsTypeCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemRecentCommentsTypeCommentsTypeItem
    {
        [JsonProperty("createdAtTimestamp")]
        public int CreatedAtTimestamp { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactAnalysisType
    {
        [JsonProperty("impacts")]
        public GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItem[] Impacts { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItem
    {
        [JsonProperty("impactType")]
        public string ImpactType { get; set; }

        [JsonProperty("impactedEntity")]
        public GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItemImpactedEntityType ImpactedEntity { get; set; }

        [JsonProperty("estimatedAffectedUsers")]
        public int EstimatedAffectedUsers { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItemImpactedEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItemImpactedEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemImpactAnalysisTypeImpactsTypeItemImpactedEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemRootCauseEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemsResponseProblemsTypeItemRootCauseEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemRootCauseEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemManagementZonesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetProblemsResponseProblemsTypeItemEntityTagsTypeItem
    {
        [JsonProperty("stringRepresentation")]
        public string StringRepresentation { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class GetProblemByIdResponse
    {
        [JsonProperty("evidenceDetails")]
        public GetProblemByIdResponseEvidenceDetailsType EvidenceDetails { get; set; }

        [JsonProperty("recentComments")]
        public GetProblemByIdResponseRecentCommentsType RecentComments { get; set; }

        [JsonProperty("linkedProblemInfo")]
        public GetProblemByIdResponseLinkedProblemInfoType LinkedProblemInfo { get; set; }

        [JsonProperty("rootCauseEntity")]
        public GetProblemByIdResponseRootCauseEntityType RootCauseEntity { get; set; }

        [JsonProperty("impactedEntities")]
        public GetProblemByIdResponseImpactedEntitiesTypeItem[] ImpactedEntities { get; set; }

        [JsonProperty("impactAnalysis")]
        public GetProblemByIdResponseImpactAnalysisType ImpactAnalysis { get; set; }

        [JsonProperty("problemFilters")]
        public GetProblemByIdResponseProblemFiltersTypeItem[] ProblemFilters { get; set; }

        [JsonProperty("impactLevel")]
        public string ImpactLevel { get; set; }

        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("affectedEntities")]
        public GetProblemByIdResponseAffectedEntitiesTypeItem[] AffectedEntities { get; set; }

        [JsonProperty("managementZones")]
        public GetProblemByIdResponseManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("severityLevel")]
        public string SeverityLevel { get; set; }

        [JsonProperty("entityTags")]
        public GetProblemByIdResponseEntityTagsTypeItem[] EntityTags { get; set; }

        [JsonProperty("problemId")]
        public string ProblemId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsType
    {
        [JsonProperty("details")]
        public GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItem[] Details { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItem
    {
        [JsonProperty("evidenceType")]
        public string EvidenceType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("entity")]
        public GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemEntityType Entity { get; set; }

        [JsonProperty("groupingEntity")]
        public GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemGroupingEntityType GroupingEntity { get; set; }

        [JsonProperty("rootCauseRelevant")]
        public bool RootCauseRelevant { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemGroupingEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemGroupingEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseEvidenceDetailsTypeDetailsTypeItemGroupingEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseRecentCommentsType
    {
        [JsonProperty("comments")]
        public GetProblemByIdResponseRecentCommentsTypeCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class GetProblemByIdResponseRecentCommentsTypeCommentsTypeItem
    {
        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("createdAtTimestamp")]
        public int CreatedAtTimestamp { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetProblemByIdResponseLinkedProblemInfoType
    {
        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("problemId")]
        public string ProblemId { get; set; }
    }

    public class GetProblemByIdResponseRootCauseEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseRootCauseEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseRootCauseEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseImpactedEntitiesTypeItem
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseImpactedEntitiesTypeItemEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseImpactedEntitiesTypeItemEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseImpactAnalysisType
    {
        [JsonProperty("impacts")]
        public GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItem[] Impacts { get; set; }
    }

    public class GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItem
    {
        [JsonProperty("impactType")]
        public string ImpactType { get; set; }

        [JsonProperty("impactedEntity")]
        public GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItemImpactedEntityType ImpactedEntity { get; set; }

        [JsonProperty("estimatedAffectedUsers")]
        public int EstimatedAffectedUsers { get; set; }
    }

    public class GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItemImpactedEntityType
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItemImpactedEntityTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseImpactAnalysisTypeImpactsTypeItemImpactedEntityTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseProblemFiltersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetProblemByIdResponseAffectedEntitiesTypeItem
    {
        [JsonProperty("entityId")]
        public GetProblemByIdResponseAffectedEntitiesTypeItemEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProblemByIdResponseAffectedEntitiesTypeItemEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProblemByIdResponseManagementZonesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetProblemByIdResponseEntityTagsTypeItem
    {
        [JsonProperty("stringRepresentation")]
        public string StringRepresentation { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class GetProblemCommentByProblemIdAndCommentIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAtTimestamp")]
        public int CreatedAtTimestamp { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }
    }

    public class GetEventsResponse
    {
        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }

        [JsonProperty("events")]
        public GetEventsResponseEventsTypeItem[] Events { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
    }

    public class GetEventsResponseEventsTypeItem
    {
        [JsonProperty("underMaintenance")]
        public bool UnderMaintenance { get; set; }

        [JsonProperty("suppressAlert")]
        public bool SuppressAlert { get; set; }

        [JsonProperty("suppressProblem")]
        public bool SuppressProblem { get; set; }

        [JsonProperty("frequentEvent")]
        public bool FrequentEvent { get; set; }

        [JsonProperty("properties")]
        public GetEventsResponseEventsTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("managementZones")]
        public GetEventsResponseEventsTypeItemManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("entityTags")]
        public GetEventsResponseEventsTypeItemEntityTagsTypeItem[] EntityTags { get; set; }

        [JsonProperty("entityId")]
        public GetEventsResponseEventsTypeItemEntityIdType EntityId { get; set; }
    }

    public class GetEventsResponseEventsTypeItemPropertiesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class GetEventsResponseEventsTypeItemManagementZonesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetEventsResponseEventsTypeItemEntityTagsTypeItem
    {
        [JsonProperty("stringRepresentation")]
        public string StringRepresentation { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public class GetEventsResponseEventsTypeItemEntityIdType
    {
        [JsonProperty("entityId")]
        public GetEventsResponseEventsTypeItemEntityIdTypeEntityIdType EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetEventsResponseEventsTypeItemEntityIdTypeEntityIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetEntitiesResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("entities")]
        public GetEntitiesResponseEntitiesTypeItem[] Entities { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItem
    {
        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("icon")]
        public GetEntitiesResponseEntitiesTypeItemIconType Icon { get; set; }

        [JsonProperty("firstSeenTms")]
        public int FirstSeenTms { get; set; }

        [JsonProperty("lastSeenTms")]
        public int LastSeenTms { get; set; }

        [JsonProperty("properties")]
        public GetEntitiesResponseEntitiesTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("tags")]
        public GetEntitiesResponseEntitiesTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("managementZones")]
        public GetEntitiesResponseEntitiesTypeItemManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("fromRelationships")]
        public GetEntitiesResponseEntitiesTypeItemFromRelationshipsType FromRelationships { get; set; }

        [JsonProperty("toRelationships")]
        public GetEntitiesResponseEntitiesTypeItemToRelationshipsType ToRelationships { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemIconType
    {
        [JsonProperty("primaryIconType")]
        public string PrimaryIconType { get; set; }

        [JsonProperty("secondaryIconType")]
        public string SecondaryIconType { get; set; }

        [JsonProperty("customIconPath")]
        public string CustomIconPath { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemPropertiesType
    {
        [JsonProperty("bitness")]
        public int Bitness { get; set; }

        [JsonProperty("monitoringMode")]
        public string MonitoringMode { get; set; }

        [JsonProperty("osType")]
        public string OsType { get; set; }

        [JsonProperty("osArchitecture")]
        public string OsArchitecture { get; set; }

        [JsonProperty("networkZoneId")]
        public string NetworkZoneId { get; set; }

        [JsonProperty("cpuCores")]
        public int CpuCores { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemTagsTypeItem
    {
        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("stringRepresentation")]
        public string StringRepresentation { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemManagementZonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemFromRelationshipsType
    {
        [JsonProperty("isInstanceOf")]
        public GetEntitiesResponseEntitiesTypeItemFromRelationshipsTypeIsInstanceOfTypeItem[] IsInstanceOf { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemFromRelationshipsTypeIsInstanceOfTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemToRelationshipsType
    {
        [JsonProperty("isDiskOf")]
        public GetEntitiesResponseEntitiesTypeItemToRelationshipsTypeIsDiskOfTypeItem[] IsDiskOf { get; set; }
    }

    public class GetEntitiesResponseEntitiesTypeItemToRelationshipsTypeIsDiskOfTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetEntityByIdResponse
    {
        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("icon")]
        public GetEntityByIdResponseIconType Icon { get; set; }

        [JsonProperty("firstSeenTms")]
        public int FirstSeenTms { get; set; }

        [JsonProperty("lastSeenTms")]
        public int LastSeenTms { get; set; }

        [JsonProperty("properties")]
        public GetEntityByIdResponsePropertiesType Properties { get; set; }

        [JsonProperty("tags")]
        public GetEntityByIdResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("managementZones")]
        public GetEntityByIdResponseManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("fromRelationships")]
        public GetEntityByIdResponseFromRelationshipsType FromRelationships { get; set; }

        [JsonProperty("toRelationships")]
        public GetEntityByIdResponseToRelationshipsType ToRelationships { get; set; }
    }

    public class GetEntityByIdResponseIconType
    {
        [JsonProperty("primaryIconType")]
        public string PrimaryIconType { get; set; }

        [JsonProperty("secondaryIconType")]
        public string SecondaryIconType { get; set; }

        [JsonProperty("customIconPath")]
        public string CustomIconPath { get; set; }
    }

    public class GetEntityByIdResponsePropertiesType
    {
        [JsonProperty("bitness")]
        public string Bitness { get; set; }

        [JsonProperty("monitoringMode")]
        public string MonitoringMode { get; set; }

        [JsonProperty("osType")]
        public string OsType { get; set; }

        [JsonProperty("osArchitecture")]
        public string OsArchitecture { get; set; }

        [JsonProperty("networkZoneId")]
        public string NetworkZoneId { get; set; }

        [JsonProperty("cpuCores")]
        public int CpuCores { get; set; }

        [JsonProperty("ipAddress")]
        public string[] IpAddress { get; set; }
    }

    public class GetEntityByIdResponseTagsTypeItem
    {
        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("stringRepresentation")]
        public string StringRepresentation { get; set; }
    }

    public class GetEntityByIdResponseManagementZonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetEntityByIdResponseFromRelationshipsType
    {
        [JsonProperty("isInstanceOf")]
        public GetEntityByIdResponseFromRelationshipsTypeIsInstanceOfTypeItem[] IsInstanceOf { get; set; }
    }

    public class GetEntityByIdResponseFromRelationshipsTypeIsInstanceOfTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetEntityByIdResponseToRelationshipsType
    {
        [JsonProperty("isDiskOf")]
        public GetEntityByIdResponseToRelationshipsTypeIsDiskOfTypeItem[] IsDiskOf { get; set; }
    }

    public class GetEntityByIdResponseToRelationshipsTypeIsDiskOfTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSecurityProblemsResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("nextPageKey")]
        public string NextPageKey { get; set; }

        [JsonProperty("securityProblems")]
        public GetSecurityProblemsResponseSecurityProblemsTypeItem[] SecurityProblems { get; set; }
    }

    public class GetSecurityProblemsResponseSecurityProblemsTypeItem
    {
        [JsonProperty("securityProblemId")]
        public string SecurityProblemId { get; set; }

        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("externalVulnerabilityId")]
        public string ExternalVulnerabilityId { get; set; }

        [JsonProperty("vulnerabilityType")]
        public string VulnerabilityType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("packageName")]
        public string PackageName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("firstSeenTimestamp")]
        public int FirstSeenTimestamp { get; set; }

        [JsonProperty("lastUpdatedTimestamp")]
        public int LastUpdatedTimestamp { get; set; }

        [JsonProperty("riskAssessment")]
        public GetSecurityProblemsResponseSecurityProblemsTypeItemRiskAssessmentType RiskAssessment { get; set; }

        [JsonProperty("managementZones")]
        public GetSecurityProblemsResponseSecurityProblemsTypeItemManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("cveIds")]
        public string[] CveIds { get; set; }
    }

    public class GetSecurityProblemsResponseSecurityProblemsTypeItemRiskAssessmentType
    {
        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskScore")]
        public int RiskScore { get; set; }

        [JsonProperty("riskVector")]
        public string RiskVector { get; set; }

        [JsonProperty("baseRiskLevel")]
        public string BaseRiskLevel { get; set; }

        [JsonProperty("baseRiskScore")]
        public int BaseRiskScore { get; set; }

        [JsonProperty("baseRiskVector")]
        public string BaseRiskVector { get; set; }

        [JsonProperty("exposure")]
        public string Exposure { get; set; }

        [JsonProperty("dataAssets")]
        public string DataAssets { get; set; }

        [JsonProperty("publicExploit")]
        public string PublicExploit { get; set; }

        [JsonProperty("vulnerableFunctionUsage")]
        public string VulnerableFunctionUsage { get; set; }
    }

    public class GetSecurityProblemsResponseSecurityProblemsTypeItemManagementZonesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetSecurityProblemsByIdResponse
    {
        [JsonProperty("securityProblemId")]
        public string SecurityProblemId { get; set; }

        [JsonProperty("displayId")]
        public string DisplayId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("externalVulnerabilityId")]
        public string ExternalVulnerabilityId { get; set; }

        [JsonProperty("vulnerabilityType")]
        public string VulnerabilityType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("packageName")]
        public string PackageName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("firstSeenTimestamp")]
        public int FirstSeenTimestamp { get; set; }

        [JsonProperty("lastUpdatedTimestamp")]
        public int LastUpdatedTimestamp { get; set; }

        [JsonProperty("riskAssessment")]
        public GetSecurityProblemsByIdResponseRiskAssessmentType RiskAssessment { get; set; }

        [JsonProperty("managementZones")]
        public GetSecurityProblemsByIdResponseManagementZonesTypeItem[] ManagementZones { get; set; }

        [JsonProperty("cveIds")]
        public string[] CveIds { get; set; }

        [JsonProperty("events")]
        public GetSecurityProblemsByIdResponseEventsTypeItem[] Events { get; set; }

        [JsonProperty("vulnerableComponents")]
        public GetSecurityProblemsByIdResponseVulnerableComponentsTypeItem[] VulnerableComponents { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }

        [JsonProperty("exposedEntities")]
        public string[] ExposedEntities { get; set; }

        [JsonProperty("reachableDataAssets")]
        public string[] ReachableDataAssets { get; set; }

        [JsonProperty("relatedEntities")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesType RelatedEntities { get; set; }

        [JsonProperty("relatedContainerImages")]
        public GetSecurityProblemsByIdResponseRelatedContainerImagesType RelatedContainerImages { get; set; }

        [JsonProperty("muteStateChangeInProgress")]
        public bool MuteStateChangeInProgress { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRiskAssessmentType
    {
        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskScore")]
        public double RiskScore { get; set; }

        [JsonProperty("riskVector")]
        public string RiskVector { get; set; }

        [JsonProperty("baseRiskLevel")]
        public string BaseRiskLevel { get; set; }

        [JsonProperty("baseRiskScore")]
        public double BaseRiskScore { get; set; }

        [JsonProperty("baseRiskVector")]
        public string BaseRiskVector { get; set; }

        [JsonProperty("exposure")]
        public string Exposure { get; set; }

        [JsonProperty("dataAssets")]
        public string DataAssets { get; set; }

        [JsonProperty("publicExploit")]
        public string PublicExploit { get; set; }

        [JsonProperty("vulnerableFunctionUsage")]
        public string VulnerableFunctionUsage { get; set; }
    }

    public class GetSecurityProblemsByIdResponseManagementZonesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetSecurityProblemsByIdResponseEventsTypeItem
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("riskAssessmentSnapshot")]
        public GetSecurityProblemsByIdResponseEventsTypeItemRiskAssessmentSnapshotType RiskAssessmentSnapshot { get; set; }

        [JsonProperty("muteState")]
        public GetSecurityProblemsByIdResponseEventsTypeItemMuteStateType MuteState { get; set; }
    }

    public class GetSecurityProblemsByIdResponseEventsTypeItemRiskAssessmentSnapshotType
    {
        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("numberOfReachableDataAssets")]
        public int NumberOfReachableDataAssets { get; set; }

        [JsonProperty("publicExploit")]
        public string PublicExploit { get; set; }

        [JsonProperty("exposure")]
        public string Exposure { get; set; }

        [JsonProperty("vulnerableFunctionUsage")]
        public string VulnerableFunctionUsage { get; set; }
    }

    public class GetSecurityProblemsByIdResponseEventsTypeItemMuteStateType
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class GetSecurityProblemsByIdResponseVulnerableComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesType
    {
        [JsonProperty("applications")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesTypeApplicationsTypeItem[] Applications { get; set; }

        [JsonProperty("services")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("hosts")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesTypeHostsTypeItem[] Hosts { get; set; }

        [JsonProperty("databases")]
        public string[] Databases { get; set; }

        [JsonProperty("kubernetesWorkloads")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesTypeKubernetesWorkloadsTypeItem[] KubernetesWorkloads { get; set; }

        [JsonProperty("kubernetesClusters")]
        public GetSecurityProblemsByIdResponseRelatedEntitiesTypeKubernetesClustersTypeItem[] KubernetesClusters { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesTypeApplicationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }

        [JsonProperty("exposure")]
        public string Exposure { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesTypeHostsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesTypeKubernetesWorkloadsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedEntitiesTypeKubernetesClustersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedContainerImagesType
    {
        [JsonProperty("containerImages")]
        public GetSecurityProblemsByIdResponseRelatedContainerImagesTypeContainerImagesTypeItem[] ContainerImages { get; set; }
    }

    public class GetSecurityProblemsByIdResponseRelatedContainerImagesTypeContainerImagesTypeItem
    {
        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("numberOfAffectedEntities")]
        public int NumberOfAffectedEntities { get; set; }

        [JsonProperty("affectedEntities")]
        public string[] AffectedEntities { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynatrace;

    public partial class WorkflowManagedActions
    {
        public DynatraceActions Dynatrace(string connectionId) => new DynatraceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynatraceTriggers Dynatrace(string connectionId) => new DynatraceTriggers(connectionId);
    }
}