//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nosco
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NoscoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<IdeaboxesResponse> Ideaboxes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v1/ideaboxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IdeaboxesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<GetIdeaResponse> GetIdea([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v1/ideas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetIdeaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nosco")]
        public IBodyWorkflowAction<IdeasResponse> Ideas([WorkflowExpression] Func<string> publishedAfter = null, [WorkflowExpression] Func<string> lastStageChangeAfter = null, [WorkflowExpression] Func<string> ideaboxId = null, [WorkflowExpression] Func<string> stageId = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<string> afterCursor = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(publishedAfter, nameof(publishedAfter), required: false);
            SourceExpression.Validate(lastStageChangeAfter, nameof(lastStageChangeAfter), required: false);
            SourceExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            SourceExpression.Validate(sortField, nameof(sortField), required: false);
            SourceExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            SourceExpression.Validate(afterCursor, nameof(afterCursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (publishedAfter != null)
                    callPayload.Queries["publishedAfter"] = SourceExpressionConverter.ConvertO(publishedAfter);
                if (lastStageChangeAfter != null)
                    callPayload.Queries["lastStageChangeAfter"] = SourceExpressionConverter.ConvertO(lastStageChangeAfter);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = SourceExpressionConverter.ConvertO(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                callPayload.Queries["sortField"] = Convert.ToString("PUBLISHED_AT");
                if (sortField != null)
                    callPayload.Queries["sortField"] = SourceExpressionConverter.Convert(sortField);
                callPayload.Queries["sortOrder"] = Convert.ToString("DESC");
                if (sortOrder != null)
                    callPayload.Queries["sortOrder"] = SourceExpressionConverter.Convert(sortOrder);
                if (afterCursor != null)
                    callPayload.Queries["afterCursor"] = SourceExpressionConverter.ConvertO(afterCursor);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<IdeasResponse>(BuildSourceInput);
        }
    }

    public class NoscoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<IdeaReachedStageTriggerResponse> IdeaReachedStageTrigger([WorkflowExpression] Func<string> ideaboxId, [WorkflowExpression] Func<string> stageId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(ideaboxId, nameof(ideaboxId), required: true);
            SourceExpression.Validate(stageId, nameof(stageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-reached-stage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ideaboxId"] = SourceExpressionConverter.ConvertO(ideaboxId);
                callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IdeaReachedStageTriggerResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IdeaStatusChangedTriggerResponse> IdeaStatusChangedTrigger([WorkflowExpression] Func<string> ideaboxId = null, [WorkflowExpression] Func<string> stageId = null, [WorkflowExpression] Func<string> statusId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            SourceExpression.Validate(statusId, nameof(statusId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-status-changed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = SourceExpressionConverter.ConvertO(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                if (statusId != null)
                    callPayload.Queries["statusId"] = SourceExpressionConverter.ConvertO(statusId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IdeaStatusChangedTriggerResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IdeaPublishedTriggerResponse> IdeaPublishedTrigger([WorkflowExpression] Func<string> ideaboxId = null, [WorkflowExpression] Func<string> stageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-published";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = SourceExpressionConverter.ConvertO(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IdeaPublishedTriggerResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IdeaEditedTriggerResponse> IdeaEditedTrigger([WorkflowExpression] Func<string> ideaboxId = null, [WorkflowExpression] Func<string> stageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(ideaboxId, nameof(ideaboxId), required: false);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/integration/v1/power-automate/triggers/idea-edited";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ideaboxId != null)
                    callPayload.Queries["ideaboxId"] = SourceExpressionConverter.ConvertO(ideaboxId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IdeaEditedTriggerResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum sortFieldInput
    {
        [EnumMember(Value = "PUBLISHED_AT")]
        PUBLISHEDAT,
        [EnumMember(Value = "LAST_STAGE_CHANGE_AT")]
        LASTSTAGECHANGEAT
    }

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