//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nosco
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NoscoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<IdeaboxesResponse, ApiConnectionActionConfiguration> Ideaboxes()
        {
            var apiCallPath = "/integration/v1/ideaboxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdeaboxesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<GetIdeaResponse, ApiConnectionActionConfiguration> GetIdea(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetIdeaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v1/ideas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<IdeasResponse, ApiConnectionActionConfiguration> Ideas(Expression<Func<string>> publishedAfter = null, Expression<Func<string>> lastStageChangeAfter = null, Expression<Func<string>> ideaboxId = null, Expression<Func<string>> stageId = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<string>> afterCursor = null, Expression<Func<int>> limit = null)
        {
            var __workflow_publishedAfter = WorkflowExpression.Compile(publishedAfter, nameof(publishedAfter), required: false);
            var __workflow_lastStageChangeAfter = WorkflowExpression.Compile(lastStageChangeAfter, nameof(lastStageChangeAfter), required: false);
            var __workflow_ideaboxId = WorkflowExpression.Compile(ideaboxId, nameof(ideaboxId), required: false);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_afterCursor = WorkflowExpression.Compile(afterCursor, nameof(afterCursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<IdeasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_publishedAfter != null)
                    callPayload.Queries["publishedAfter"] = ExpressionConverter.Convert(__workflow_publishedAfter);
                if (__workflow_lastStageChangeAfter != null)
                    callPayload.Queries["lastStageChangeAfter"] = ExpressionConverter.Convert(__workflow_lastStageChangeAfter);
                if (__workflow_ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(__workflow_ideaboxId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                callPayload.Queries["sortField"] = Convert.ToString("PUBLISHED_AT");
                if (__workflow_sortField != null)
                    callPayload.Queries["sortField"] = ExpressionConverter.Convert(__workflow_sortField);
                callPayload.Queries["sortOrder"] = Convert.ToString("DESC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_afterCursor != null)
                    callPayload.Queries["afterCursor"] = ExpressionConverter.Convert(__workflow_afterCursor);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<IdeasResponse>(callPayload);
            });
        }
    }

    public class NoscoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<IdeaReachedStageTriggerResponse, ApiConnectionTriggerConfiguration> IdeaReachedStageTrigger(Expression<Func<string>> ideaboxId, Expression<Func<string>> stageId, FlowRecurrence recurrence = null)
        {
            var __workflow_ideaboxId = WorkflowExpression.Compile(ideaboxId, nameof(ideaboxId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: true);
            return new DeferredBodyTrigger<IdeaReachedStageTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-reached-stage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(__workflow_ideaboxId);
                callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionTrigger<IdeaReachedStageTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IdeaStatusChangedTriggerResponse, ApiConnectionTriggerConfiguration> IdeaStatusChangedTrigger(Expression<Func<string>> ideaboxId = null, Expression<Func<string>> stageId = null, Expression<Func<string>> statusId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_ideaboxId = WorkflowExpression.Compile(ideaboxId, nameof(ideaboxId), required: false);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            var __workflow_statusId = WorkflowExpression.Compile(statusId, nameof(statusId), required: false);
            return new DeferredBodyTrigger<IdeaStatusChangedTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-status-changed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(__workflow_ideaboxId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                if (__workflow_statusId != null)
                    callPayload.Queries["statusId"] = ExpressionConverter.Convert(__workflow_statusId);
                return new ApiConnectionTrigger<IdeaStatusChangedTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IdeaPublishedTriggerResponse, ApiConnectionTriggerConfiguration> IdeaPublishedTrigger(Expression<Func<string>> ideaboxId = null, Expression<Func<string>> stageId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_ideaboxId = WorkflowExpression.Compile(ideaboxId, nameof(ideaboxId), required: false);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredBodyTrigger<IdeaPublishedTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-published";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(__workflow_ideaboxId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionTrigger<IdeaPublishedTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IdeaEditedTriggerResponse, ApiConnectionTriggerConfiguration> IdeaEditedTrigger(Expression<Func<string>> ideaboxId = null, Expression<Func<string>> stageId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_ideaboxId = WorkflowExpression.Compile(ideaboxId, nameof(ideaboxId), required: false);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredBodyTrigger<IdeaEditedTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-edited";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(__workflow_ideaboxId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionTrigger<IdeaEditedTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class IdeaboxesResponse
    {
        [JsonProperty("nodes")]
        public IdeaboxesResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeaboxesResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeaboxesResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaboxesResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }

    public class GetIdeaResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public GetIdeaResponseAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public GetIdeaResponseIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public GetIdeaResponseStageType Stage { get; set; }

        [JsonProperty("status")]
        public GetIdeaResponseStatusType Status { get; set; }
    }

    public class GetIdeaResponseAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetIdeaResponseIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetIdeaResponseStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetIdeaResponseStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeasResponse
    {
        [JsonProperty("nodes")]
        public IdeasResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeasResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeasResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public IdeasResponseNodesTypeItemAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public IdeasResponseNodesTypeItemIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public IdeasResponseNodesTypeItemStageType Stage { get; set; }

        [JsonProperty("status")]
        public IdeasResponseNodesTypeItemStatusType Status { get; set; }
    }

    public class IdeasResponseNodesTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdeasResponseNodesTypeItemIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeasResponseNodesTypeItemStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeasResponseNodesTypeItemStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeasResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortFieldInput
    {
        [EnumMember(Value = "PUBLISHED_AT")]
        PUBLISHEDAT,
        [EnumMember(Value = "LAST_STAGE_CHANGE_AT")]
        LASTSTAGECHANGEAT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOrderInput
    {
        ASC,
        DESC
    }

    public class IdeaReachedStageTriggerResponse
    {
        [JsonProperty("nodes")]
        public IdeaReachedStageTriggerResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeaReachedStageTriggerResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeaReachedStageTriggerResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public IdeaReachedStageTriggerResponseNodesTypeItemAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public IdeaReachedStageTriggerResponseNodesTypeItemIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public IdeaReachedStageTriggerResponseNodesTypeItemStageType Stage { get; set; }

        [JsonProperty("status")]
        public IdeaReachedStageTriggerResponseNodesTypeItemStatusType Status { get; set; }
    }

    public class IdeaReachedStageTriggerResponseNodesTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdeaReachedStageTriggerResponseNodesTypeItemIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaReachedStageTriggerResponseNodesTypeItemStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaReachedStageTriggerResponseNodesTypeItemStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaReachedStageTriggerResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }

    public class IdeaStatusChangedTriggerResponse
    {
        [JsonProperty("nodes")]
        public IdeaStatusChangedTriggerResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeaStatusChangedTriggerResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeaStatusChangedTriggerResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public IdeaStatusChangedTriggerResponseNodesTypeItemAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public IdeaStatusChangedTriggerResponseNodesTypeItemIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public IdeaStatusChangedTriggerResponseNodesTypeItemStageType Stage { get; set; }

        [JsonProperty("status")]
        public IdeaStatusChangedTriggerResponseNodesTypeItemStatusType Status { get; set; }
    }

    public class IdeaStatusChangedTriggerResponseNodesTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdeaStatusChangedTriggerResponseNodesTypeItemIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaStatusChangedTriggerResponseNodesTypeItemStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaStatusChangedTriggerResponseNodesTypeItemStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaStatusChangedTriggerResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }

    public class IdeaPublishedTriggerResponse
    {
        [JsonProperty("nodes")]
        public IdeaPublishedTriggerResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeaPublishedTriggerResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeaPublishedTriggerResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public IdeaPublishedTriggerResponseNodesTypeItemAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public IdeaPublishedTriggerResponseNodesTypeItemIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public IdeaPublishedTriggerResponseNodesTypeItemStageType Stage { get; set; }

        [JsonProperty("status")]
        public IdeaPublishedTriggerResponseNodesTypeItemStatusType Status { get; set; }
    }

    public class IdeaPublishedTriggerResponseNodesTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdeaPublishedTriggerResponseNodesTypeItemIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaPublishedTriggerResponseNodesTypeItemStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaPublishedTriggerResponseNodesTypeItemStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaPublishedTriggerResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }

    public class IdeaEditedTriggerResponse
    {
        [JsonProperty("nodes")]
        public IdeaEditedTriggerResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public IdeaEditedTriggerResponsePageInfoType PageInfo { get; set; }
    }

    public class IdeaEditedTriggerResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public IdeaEditedTriggerResponseNodesTypeItemAuthorType Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("editedAt")]
        public string EditedAt { get; set; }

        [JsonProperty("lastStageChange")]
        public string LastStageChange { get; set; }

        [JsonProperty("lastStatusChange")]
        public string LastStatusChange { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ideabox")]
        public IdeaEditedTriggerResponseNodesTypeItemIdeaboxType Ideabox { get; set; }

        [JsonProperty("stage")]
        public IdeaEditedTriggerResponseNodesTypeItemStageType Stage { get; set; }

        [JsonProperty("status")]
        public IdeaEditedTriggerResponseNodesTypeItemStatusType Status { get; set; }
    }

    public class IdeaEditedTriggerResponseNodesTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IdeaEditedTriggerResponseNodesTypeItemIdeaboxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaEditedTriggerResponseNodesTypeItemStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaEditedTriggerResponseNodesTypeItemStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class IdeaEditedTriggerResponsePageInfoType
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nosco;

    public partial class WorkflowManagedActions
    {
        public NoscoActions Nosco(string connectionId) => new NoscoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NoscoTriggers Nosco(string connectionId) => new NoscoTriggers(connectionId);
    }
}
