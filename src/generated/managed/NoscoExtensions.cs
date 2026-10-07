//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nosco
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NoscoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<IdeaboxesResponse> Ideaboxes()
        {
            var apiCallPath = "/integration/v1/ideaboxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdeaboxesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        [WorkflowExpressionFactory(nameof(__BuildGetIdea))]
        public IBodyWorkflowAction<GetIdeaResponse> GetIdea([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIdeaResponse> __BuildGetIdea(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetIdeaResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        [WorkflowExpressionFactory(nameof(__BuildIdeas))]
        public IBodyWorkflowAction<IdeasResponse> Ideas([WorkflowExpression] Func<string> publishedAfter = null, [WorkflowExpression] Func<string> lastStageChangeAfter = null, [WorkflowExpression] Func<string> ideaboxId = null, [WorkflowExpression] Func<string> stageId = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<string> afterCursor = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdeasResponse> __BuildIdeas(WorkflowExpression<string> publishedAfter = null, WorkflowExpression<string> lastStageChangeAfter = null, WorkflowExpression<string> ideaboxId = null, WorkflowExpression<string> stageId = null, WorkflowExpression<sortFieldInput> sortField = null, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<string> afterCursor = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(publishedAfter, nameof(publishedAfter), required: false);
            WorkflowExpression.Validate(lastStageChangeAfter, nameof(lastStageChangeAfter), required: false);
            WorkflowExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            WorkflowExpression.Validate(sortField, nameof(sortField), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(afterCursor, nameof(afterCursor), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<IdeasResponse>(() =>
            {
                var apiCallPath = "/integration/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (publishedAfter != null)
                    callPayload.Queries["publishedAfter"] = ExpressionConverter.Convert(publishedAfter);
                if (lastStageChangeAfter != null)
                    callPayload.Queries["lastStageChangeAfter"] = ExpressionConverter.Convert(lastStageChangeAfter);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                callPayload.Queries["sortField"] = Convert.ToString("PUBLISHED_AT");
                if (sortField != null)
                    callPayload.Queries["sortField"] = ExpressionConverter.Convert(sortField);
                callPayload.Queries["sortOrder"] = Convert.ToString("DESC");
                if (sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
                if (afterCursor != null)
                    callPayload.Queries["afterCursor"] = ExpressionConverter.Convert(afterCursor);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<IdeasResponse>(callPayload);
            });
        }
    }

    public class NoscoTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildIdeaReachedStageTrigger))]
        public IBodyWorkflowTrigger<IdeaReachedStageTriggerResponse> IdeaReachedStageTrigger([WorkflowExpression] Func<string> ideaboxId,[WorkflowExpression] Func<string> stageId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IdeaReachedStageTriggerResponse> __BuildIdeaReachedStageTrigger(WorkflowExpression<string> ideaboxId,WorkflowExpression<string> stageId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(ideaboxId, nameof(ideaboxId), required: true);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: true);
            return new DeferredBodyTrigger<IdeaReachedStageTriggerResponse>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-reached-stage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(ideaboxId);
                callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                return new ApiConnectionTrigger<IdeaReachedStageTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildIdeaStatusChangedTrigger))]
        public IBodyWorkflowTrigger<IdeaStatusChangedTriggerResponse> IdeaStatusChangedTrigger([WorkflowExpression] Func<string> ideaboxId = null,[WorkflowExpression] Func<string> stageId = null,[WorkflowExpression] Func<string> statusId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IdeaStatusChangedTriggerResponse> __BuildIdeaStatusChangedTrigger(WorkflowExpression<string> ideaboxId = null,WorkflowExpression<string> stageId = null,WorkflowExpression<string> statusId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            WorkflowExpression.Validate(statusId, nameof(statusId), required: false);
            return new DeferredBodyTrigger<IdeaStatusChangedTriggerResponse>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-status-changed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                if (statusId != null)
                    callPayload.Queries["statusId"] = ExpressionConverter.Convert(statusId);
                return new ApiConnectionTrigger<IdeaStatusChangedTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildIdeaPublishedTrigger))]
        public IBodyWorkflowTrigger<IdeaPublishedTriggerResponse> IdeaPublishedTrigger([WorkflowExpression] Func<string> ideaboxId = null,[WorkflowExpression] Func<string> stageId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IdeaPublishedTriggerResponse> __BuildIdeaPublishedTrigger(WorkflowExpression<string> ideaboxId = null,WorkflowExpression<string> stageId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            return new DeferredBodyTrigger<IdeaPublishedTriggerResponse>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-published";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                return new ApiConnectionTrigger<IdeaPublishedTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildIdeaEditedTrigger))]
        public IBodyWorkflowTrigger<IdeaEditedTriggerResponse> IdeaEditedTrigger([WorkflowExpression] Func<string> ideaboxId = null,[WorkflowExpression] Func<string> stageId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IdeaEditedTriggerResponse> __BuildIdeaEditedTrigger(WorkflowExpression<string> ideaboxId = null,WorkflowExpression<string> stageId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            return new DeferredBodyTrigger<IdeaEditedTriggerResponse>(() =>
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-edited";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = ExpressionConverter.Convert(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
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