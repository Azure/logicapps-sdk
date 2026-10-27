//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ideanote
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IdeanoteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<Mission[], ApiConnectionActionConfiguration> ListMissions(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Mission[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/missions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Mission[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<GetMissionSchemaResponse, ApiConnectionActionConfiguration> GetMissionSchema()
        {
            return new DeferredBodyAction<GetMissionSchemaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/swagger/missions/{0}/schema", WorkflowExpression.Literal("default").WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMissionSchemaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<Model, ApiConnectionActionConfiguration> CreateIdea(Expression<Func<string>> missionId, Expression<Func<object>> body)
        {
            var __workflow_missionId = WorkflowExpression.Compile(missionId, nameof(missionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Model, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ideas/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["missionId"] = ExpressionConverter.Convert(__workflow_missionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Model>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<Idea[], ApiConnectionActionConfiguration> ListIdeas(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Idea[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Idea[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<Idea[], ApiConnectionActionConfiguration> ListIdeasForMission(Expression<Func<string>> missionId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_missionId = WorkflowExpression.Compile(missionId, nameof(missionId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Idea[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/missions/{0}/ideas", __workflow_missionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Idea[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<Comment[], ApiConnectionActionConfiguration> ListCommentsForIdea(Expression<Func<string>> ideaId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Comment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ideas/{0}/comments", __workflow_ideaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Comment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> userId, Expression<Func<UpdateUserInput>> body)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ideanote")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> sendInvitation = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sendInvitation = WorkflowExpression.Compile(sendInvitation, nameof(sendInvitation), required: false);
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flat"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["send_invitation"] = Convert.ToString(true);
                if (__workflow_sendInvitation != null)
                    callPayload.Queries["send_invitation"] = ExpressionConverter.Convert(__workflow_sendInvitation);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<User>(callPayload);
            });
        }
    }

    public class IdeanoteTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> FinishRating(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/finish_rating";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new FinishRatingInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> NewIdea(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new_idea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new NewIdeaInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> NewUser(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new_user";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new NewUserInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> NewComment(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new_comment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new NewCommentInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> NewLike(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/new_like";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new NewLikeInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> UpdatedIdeaStatus(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/updated_idea_status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new UpdatedIdeaStatusInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Model, ApiConnectionTriggerConfiguration> UpdatedIdeaPhase(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<Model, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/updated_idea_phase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new UpdatedIdeaPhaseInput().ToJToken();
                return new ApiConnectionTrigger<Model>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Mission
    {
        [JsonProperty("id")]
        public string IdeaCollectionId { get; set; }

        [JsonProperty("friendly_id")]
        public int IdeaCollectionFriendlyId { get; set; }

        [JsonProperty("title")]
        public string IdeaCollectionTitle { get; set; }

        [JsonProperty("question")]
        public string IdeaCollectionQuestion { get; set; }

        [JsonProperty("details")]
        public string IdeaCollectionDetails { get; set; }

        [JsonProperty("status")]
        public string IdeaCollectionStatus { get; set; }

        [JsonProperty("stats_viewed")]
        public double IdeaCollectionStatsViewed { get; set; }

        [JsonProperty("stats_ideas_total")]
        public double IdeaCollectionStatsIdeasTotal { get; set; }

        [JsonProperty("stats_ideas_days7")]
        public double IdeaCollectionStatsIdeasDays7 { get; set; }

        [JsonProperty("url_path")]
        public string IdeaCollectionURLPath { get; set; }

        [JsonProperty("url")]
        public string IdeaCollectionURL { get; set; }

        [JsonProperty("goal_id")]
        public string IdeaCollectionGoalId { get; set; }

        [JsonProperty("goal_title")]
        public string IdeaCollectionGoalTitle { get; set; }

        [JsonProperty("goal_text")]
        public string IdeaCollectionGoalText { get; set; }

        [JsonProperty("goal_stats_missions")]
        public double IdeaCollectionGoalStatsIdeaCollections { get; set; }

        [JsonProperty("created_at")]
        public string IdeaCollectionCreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string IdeaCollectionUpdatedAt { get; set; }

        [JsonProperty("archived")]
        public bool IdeaCollectionArchived { get; set; }

        [JsonProperty("owner_id")]
        public string IdeaCollectionOwnerId { get; set; }

        [JsonProperty("owner_email")]
        public string IdeaCollectionOwnerEmail { get; set; }

        [JsonProperty("owner_alias")]
        public string IdeaCollectionOwnerAlias { get; set; }

        [JsonProperty("owner_first_name")]
        public string IdeaCollectionOwnerFirstName { get; set; }

        [JsonProperty("owner_last_name")]
        public string IdeaCollectionOwnerLastName { get; set; }

        [JsonProperty("owner_name")]
        public string IdeaCollectionOwnerName { get; set; }

        [JsonProperty("owner_rank")]
        public int IdeaCollectionOwnerRank { get; set; }

        [JsonProperty("owner_department")]
        public string IdeaCollectionOwnerDepartment { get; set; }

        [JsonProperty("owner_country")]
        public string IdeaCollectionOwnerCountry { get; set; }

        [JsonProperty("owner_url_path")]
        public string IdeaCollectionOwnerURLPath { get; set; }

        [JsonProperty("owner_url")]
        public string IdeaCollectionOwnerURL { get; set; }

        [JsonProperty("workspace_id")]
        public string IdeaCollectionWorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string IdeaCollectionWorkspaceName { get; set; }

        [JsonProperty("workspace_subdomain")]
        public string IdeaCollectionWorkspaceSubdomain { get; set; }

        [JsonProperty("workspace_url_path")]
        public string IdeaCollectionWorkspaceURLPath { get; set; }

        [JsonProperty("workspace_url")]
        public string IdeaCollectionWorkspaceURL { get; set; }

        [JsonProperty("section_title")]
        public string IdeaCollectionSectionTitle { get; set; }

        [JsonProperty("section_id")]
        public string IdeaCollectionSectionId { get; set; }
    }

    public class GetMissionSchemaResponse
    {
        [JsonProperty("schema")]
        public JToken IdeaCollectionsSchema { get; set; }
    }

    public class Model
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Idea
    {
        [JsonProperty("anonymity")]
        public string IdeaAnonymity { get; set; }

        [JsonProperty("archived")]
        public bool IdeaArchived { get; set; }

        [JsonProperty("content_html")]
        public string IdeaContentHTML { get; set; }

        [JsonProperty("content_json")]
        public string IdeaContentJSON { get; set; }

        [JsonProperty("content_language")]
        public string IdeaContentLanguage { get; set; }

        [JsonProperty("content_markdown")]
        public string IdeaContentMarkdown { get; set; }

        [JsonProperty("created_at")]
        public string IdeaCreatedAt { get; set; }

        [JsonProperty("form_archived")]
        public bool IdeaFormArchived { get; set; }

        [JsonProperty("form_id")]
        public string IdeaFormId { get; set; }

        [JsonProperty("form_title")]
        public string IdeaFormTitle { get; set; }

        [JsonProperty("friendly_id")]
        public int IdeaFriendlyId { get; set; }

        [JsonProperty("id")]
        public string IdeaId { get; set; }

        [JsonProperty("idea_collection_archived")]
        public bool IdeaCollectionArchived { get; set; }

        [JsonProperty("idea_collection_details")]
        public string IdeaCollectionDetails { get; set; }

        [JsonProperty("idea_collection_friendly_id")]
        public int IdeaCollectionFriendlyId { get; set; }

        [JsonProperty("idea_collection_goal_id")]
        public string IdeaCollectionGoalId { get; set; }

        [JsonProperty("idea_collection_goal_text")]
        public string IdeaCollectionGoalText { get; set; }

        [JsonProperty("idea_collection_goal_title")]
        public string IdeaCollectionGoalTitle { get; set; }

        [JsonProperty("idea_collection_id")]
        public string IdeaCollectionId { get; set; }

        [JsonProperty("idea_collection_question")]
        public string IdeaCollectionQuestion { get; set; }

        [JsonProperty("idea_collection_stats_ideas_days7")]
        public double IdeaCollectionStatsIdeasDays7 { get; set; }

        [JsonProperty("idea_collection_stats_ideas_total")]
        public double IdeaCollectionStatsIdeasTotal { get; set; }

        [JsonProperty("idea_collection_stats_viewed")]
        public double IdeaCollectionStatsViewedCount { get; set; }

        [JsonProperty("idea_collection_status")]
        public string IdeaCollectionStatus { get; set; }

        [JsonProperty("idea_collection_title")]
        public string IdeaCollectionTitle { get; set; }

        [JsonProperty("idea_collection_url_path")]
        public string IdeaCollectionURLPath { get; set; }

        [JsonProperty("idea_collection_url")]
        public string IdeaCollectionURL { get; set; }

        [JsonProperty("idea_collection_workspace_url_path")]
        public string IdeaCollectionWorkspaceURLPath { get; set; }

        [JsonProperty("idea_collection_workspace_url")]
        public string IdeaCollectionWorkspaceURL { get; set; }

        [JsonProperty("keywords")]
        public string IdeaKeywords { get; set; }

        [JsonProperty("owner_alias")]
        public string IdeaOwnerAlias { get; set; }

        [JsonProperty("owner_country")]
        public string IdeaOwnerCountry { get; set; }

        [JsonProperty("owner_department")]
        public string IdeaOwnerDepartment { get; set; }

        [JsonProperty("owner_email")]
        public string IdeaOwnerEmail { get; set; }

        [JsonProperty("owner_first_name")]
        public string IdeaOwnerFirstName { get; set; }

        [JsonProperty("owner_id")]
        public string IdeaOwnerId { get; set; }

        [JsonProperty("owner_last_name")]
        public string IdeaOwnerLastName { get; set; }

        [JsonProperty("owner_name")]
        public string IdeaOwnerName { get; set; }

        [JsonProperty("owner_rank")]
        public int IdeaOwnerRank { get; set; }

        [JsonProperty("owner_url_path")]
        public string IdeaOwnerURLPath { get; set; }

        [JsonProperty("owner_url")]
        public string IdeaOwnerURL { get; set; }

        [JsonProperty("phase_id")]
        public string IdeaPhaseId { get; set; }

        [JsonProperty("phase_kind")]
        public string IdeaPhaseKind { get; set; }

        [JsonProperty("phase_name")]
        public string IdeaPhaseName { get; set; }

        [JsonProperty("stats_comments")]
        public double IdeaStatsCommentCount { get; set; }

        [JsonProperty("stats_likes")]
        public double IdeaStatsLikeCount { get; set; }

        [JsonProperty("stats_total_avg_rating")]
        public double IdeaStatsTotalAverageRating { get; set; }

        [JsonProperty("status_id")]
        public string IdeaStatusId { get; set; }

        [JsonProperty("status_kind")]
        public string IdeaStatusKind { get; set; }

        [JsonProperty("status_text")]
        public string IdeaStatusText { get; set; }

        [JsonProperty("status_title")]
        public string IdeaStatusTitle { get; set; }

        [JsonProperty("updated_at")]
        public string IdeaUpdatedAt { get; set; }

        [JsonProperty("url_path")]
        public string IdeaURLPath { get; set; }

        [JsonProperty("url")]
        public string IdeaURL { get; set; }

        [JsonProperty("workspace_id")]
        public string IdeaWorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string IdeaWorkspaceName { get; set; }

        [JsonProperty("workspace_subdomain")]
        public string IdeaWorkspaceSubdomain { get; set; }

        [JsonProperty("workspace_url_path")]
        public string IdeaWorkspaceURLPath { get; set; }

        [JsonProperty("workspace_url")]
        public string IdeaWorkspaceURL { get; set; }

        [JsonProperty("idea_collection_section_title")]
        public string IdeaCollectionSectionTitle { get; set; }

        [JsonProperty("idea_collection_section_id")]
        public string IdeaCollectionSectionId { get; set; }

        [JsonProperty("mission_id")]
        public string IdeaMissionId { get; set; }

        [JsonProperty("mission_friendly_id")]
        public int IdeaMissionFriendlyId { get; set; }

        [JsonProperty("mission_title")]
        public string IdeaMissionTitle { get; set; }

        [JsonProperty("mission_question")]
        public string IdeaMissionQuestion { get; set; }

        [JsonProperty("mission_url")]
        public string IdeaMissionURL { get; set; }

        [JsonProperty("mission_url_path")]
        public string IdeaMissionURLPath { get; set; }
    }

    public class Comment
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("text")]
        public string CommentText { get; set; }

        [JsonProperty("url_path")]
        public string CommentURL { get; set; }

        [JsonProperty("anonymity")]
        public string CommentAnonymity { get; set; }

        [JsonProperty("sender_id")]
        public string CommentSenderId { get; set; }

        [JsonProperty("sender_email")]
        public string CommentSenderEmail { get; set; }

        [JsonProperty("sender_alias")]
        public string CommentSenderAlias { get; set; }

        [JsonProperty("sender_first_name")]
        public string CommentSenderLastName { get; set; }

        [JsonProperty("sender_last_name")]
        public string CommentSenderFirstName { get; set; }

        [JsonProperty("sender_name")]
        public string CommentSenderName { get; set; }

        [JsonProperty("sender_department")]
        public string CommentSenderDepartment { get; set; }

        [JsonProperty("sender_country")]
        public string CommentSenderCountry { get; set; }

        [JsonProperty("sender_url")]
        public string CommentSenderURL { get; set; }

        [JsonProperty("sender_url_path")]
        public string CommentSenderURLPath { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string UserEmail { get; set; }

        [JsonProperty("alias")]
        public string UserAlias { get; set; }

        [JsonProperty("first_name")]
        public string UserLastName { get; set; }

        [JsonProperty("last_name")]
        public string UserFirstName { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("department")]
        public string UserDepartment { get; set; }

        [JsonProperty("country")]
        public string UserCountry { get; set; }

        [JsonProperty("url")]
        public string UserURL { get; set; }

        [JsonProperty("url_path")]
        public string UserURLPath { get; set; }
    }

    public class UpdateUserInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class CreateUserInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class FinishRatingInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "finish_rating";
    }

    public class NewIdeaInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "new_idea";
    }

    public class NewUserInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "new_user";
    }

    public class NewCommentInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "new_comment";
    }

    public class NewLikeInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "new_like";
    }

    public class UpdatedIdeaStatusInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "updated_idea_status";
    }

    public class UpdatedIdeaPhaseInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "updated_idea_phase";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ideanote;

    public partial class WorkflowManagedActions
    {
        public IdeanoteActions Ideanote(string connectionId) => new IdeanoteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IdeanoteTriggers Ideanote(string connectionId) => new IdeanoteTriggers(connectionId);
    }
}