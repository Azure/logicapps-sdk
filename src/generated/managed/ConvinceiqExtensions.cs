//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Convinceiq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConvinceiqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<Membership, ApiConnectionActionConfiguration> GetMyMembership(Expression<Func<string>> xTenantId)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            return new DeferredBodyAction<Membership, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                return new ApiConnectionAction<Membership>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<SessionList, ApiConnectionActionConfiguration> ListSessions(Expression<Func<string>> xTenantId, Expression<Func<StatusInput>> status = null, Expression<Func<SourceTypeInput>> sourceType = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_sourceType = WorkflowExpression.Compile(sourceType, nameof(sourceType), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<SessionList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sessions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("all");
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["source_type"] = Convert.ToString("all");
                if (__workflow_sourceType != null)
                    callPayload.Queries["source_type"] = ExpressionConverter.Convert(__workflow_sourceType);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                return new ApiConnectionAction<SessionList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<SessionDetail, ApiConnectionActionConfiguration> GetSession(Expression<Func<string>> xTenantId, Expression<Func<string>> sessionId)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<SessionDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sessions/{0}", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                return new ApiConnectionAction<SessionDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<Leaderboard, ApiConnectionActionConfiguration> GetLeaderboard(Expression<Func<string>> xTenantId, Expression<Func<int>> limit = null)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Leaderboard, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/leaderboard";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(5);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                return new ApiConnectionAction<Leaderboard>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<MemberList, ApiConnectionActionConfiguration> FindMemberByEmail(Expression<Func<string>> xTenantId, Expression<Func<string>> email)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<MemberList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                return new ApiConnectionAction<MemberList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<InvitationResult, ApiConnectionActionConfiguration> InviteMember(Expression<Func<string>> xTenantId, Expression<Func<InviteMemberBodyInput>> body)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InvitationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvitationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convinceiq")]
        public IBodyWorkflowAction<AssignmentResult, ApiConnectionActionConfiguration> AssignTrainingPlan(Expression<Func<string>> xTenantId, Expression<Func<AssignTrainingPlanBodyInput>> body)
        {
            var __workflow_xTenantId = WorkflowExpression.Compile(xTenantId, nameof(xTenantId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AssignmentResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/training-plan-assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-tenant-id"] = ExpressionConverter.Convert(__workflow_xTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AssignmentResult>(callPayload);
            });
        }
    }

    public class ConvinceiqTriggers([ConnectionName] string connectionId)
    {
    }

    public class Membership
    {
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("member")]
        public Member Member { get; set; }

        [JsonProperty("features")]
        public string[] PlanFeatures { get; set; }
    }

    public class Member
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public MemberRoleType Role { get; set; }

        [JsonProperty("status")]
        public MemberStatusType Status { get; set; }

        [JsonProperty("manager_id")]
        public string ManagerMemberId { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("created_at")]
        public string JoinedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MemberRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "admin")]
        Admin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MemberStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    public class Team
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }

        [JsonProperty("name")]
        public string TeamName { get; set; }
    }

    public class SessionList
    {
        [JsonProperty("sessions")]
        public SessionSummary[] Sessions { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }
    }

    public class SessionSummary
    {
        [JsonProperty("id")]
        public string SessionId { get; set; }

        [JsonProperty("source_type")]
        public SessionSummarySourceType Source { get; set; }

        [JsonProperty("status")]
        public SessionSummaryStatusType Status { get; set; }

        [JsonProperty("owner")]
        public SessionOwner Owner { get; set; }

        [JsonProperty("buyer")]
        public Buyer Buyer { get; set; }

        [JsonProperty("call_direction")]
        public string CallDirection { get; set; }

        [JsonProperty("call_duration_minutes")]
        public int PlannedDurationMinutes { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("training_plan")]
        public TrainingPlanContext TrainingPlan { get; set; }

        [JsonProperty("created_at")]
        public string StartedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("recording_duration_ms")]
        public int RecordingDurationMs { get; set; }

        [JsonProperty("ended_reason")]
        public string EndedReason { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SessionSummarySourceType
    {
        [EnumMember(Value = "practice_session")]
        PracticeSession,
        [EnumMember(Value = "uploaded_recording")]
        UploadedRecording
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SessionSummaryStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "ended")]
        Ended
    }

    public class SessionOwner
    {
        [JsonProperty("member_id")]
        public string OwnerMemberId { get; set; }

        [JsonProperty("display_name")]
        public string OwnerName { get; set; }

        [JsonProperty("email")]
        public string OwnerEmail { get; set; }
    }

    public class Buyer
    {
        [JsonProperty("name")]
        public string BuyerName { get; set; }

        [JsonProperty("role_title")]
        public string BuyerRole { get; set; }

        [JsonProperty("company_name")]
        public string BuyerCompany { get; set; }

        [JsonProperty("company_type")]
        public string CompanyType { get; set; }

        [JsonProperty("contact_role")]
        public string ContactRole { get; set; }

        [JsonProperty("mood")]
        public string BuyerMood { get; set; }
    }

    public class TrainingPlanContext
    {
        [JsonProperty("assignment_id")]
        public string AssignmentId { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_title")]
        public string TrainingPlan { get; set; }

        [JsonProperty("step_title")]
        public string Step { get; set; }
    }

    public class Score
    {
        [JsonProperty("overall")]
        public double OverallScore { get; set; }

        [JsonProperty("discovery")]
        public double DiscoveryScore { get; set; }

        [JsonProperty("value_prop")]
        public double ValuePropositionScore { get; set; }

        [JsonProperty("objections")]
        public double ObjectionHandlingScore { get; set; }

        [JsonProperty("structure")]
        public double StructureScore { get; set; }

        [JsonProperty("next_step")]
        public double NextStepScore { get; set; }

        [JsonProperty("tone")]
        public double ToneScore { get; set; }

        [JsonProperty("strengths")]
        public string[] Strengths { get; set; }

        [JsonProperty("improvements")]
        public string[] Improvements { get; set; }

        [JsonProperty("next_practice_goals")]
        public string[] NextPracticeGoals { get; set; }

        [JsonProperty("scored_at")]
        public string ScoredAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "ended")]
        Ended
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourceTypeInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "practice_session")]
        PracticeSession,
        [EnumMember(Value = "uploaded_recording")]
        UploadedRecording
    }

    public class SessionDetail
    {
        [JsonProperty("id")]
        public string SessionId { get; set; }

        [JsonProperty("source_type")]
        public SessionDetailSourceType Source { get; set; }

        [JsonProperty("status")]
        public SessionDetailStatusType Status { get; set; }

        [JsonProperty("owner")]
        public SessionOwner Owner { get; set; }

        [JsonProperty("buyer")]
        public Buyer Buyer { get; set; }

        [JsonProperty("call_direction")]
        public string CallDirection { get; set; }

        [JsonProperty("call_duration_minutes")]
        public int PlannedDurationMinutes { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("training_plan")]
        public TrainingPlanContext TrainingPlan { get; set; }

        [JsonProperty("created_at")]
        public string StartedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("recording_duration_ms")]
        public int RecordingDurationMs { get; set; }

        [JsonProperty("ended_reason")]
        public string EndedReason { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("transcript")]
        public TranscriptTurn[] Transcript { get; set; }

        [JsonProperty("buyer_assessment")]
        public BuyerAssessment BuyerAssessment { get; set; }

        [JsonProperty("decision_criteria")]
        public DecisionCriterion[] DecisionCriteria { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SessionDetailSourceType
    {
        [EnumMember(Value = "practice_session")]
        PracticeSession,
        [EnumMember(Value = "uploaded_recording")]
        UploadedRecording
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SessionDetailStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "ended")]
        Ended
    }

    public class TranscriptTurn
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("speaker")]
        public TranscriptTurnSpeakerType Speaker { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TranscriptTurnSpeakerType
    {
        [EnumMember(Value = "seller")]
        Seller,
        [EnumMember(Value = "buyer")]
        Buyer
    }

    public class BuyerAssessment
    {
        [JsonProperty("stance")]
        public string BuyerStance { get; set; }

        [JsonProperty("concerns")]
        public string[] BuyerConcerns { get; set; }

        [JsonProperty("seller_strengths")]
        public string[] SellerStrengths { get; set; }

        [JsonProperty("summary")]
        public string AssessmentSummary { get; set; }
    }

    public class DecisionCriterion
    {
        [JsonProperty("label")]
        public string Criterion { get; set; }

        [JsonProperty("status")]
        public string CriterionStatus { get; set; }
    }

    public class Leaderboard
    {
        [JsonProperty("period_days")]
        public int PeriodDays { get; set; }

        [JsonProperty("top")]
        public LeaderboardEntry[] TopPerformers { get; set; }

        [JsonProperty("rising_stars")]
        public LeaderboardEntry[] RisingStars { get; set; }
    }

    public class LeaderboardEntry
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("average_score")]
        public double AverageScore { get; set; }

        [JsonProperty("latest_score")]
        public double LatestScore { get; set; }

        [JsonProperty("session_count")]
        public int SessionCount { get; set; }

        [JsonProperty("trend_delta")]
        public double Trend { get; set; }
    }

    public class MemberList
    {
        [JsonProperty("members")]
        public Member[] Members { get; set; }
    }

    public class InvitationResult
    {
        [JsonProperty("invitation")]
        public Invitation Invitation { get; set; }

        [JsonProperty("email_sent")]
        public bool EmailSent { get; set; }
    }

    public class Invitation
    {
        [JsonProperty("id")]
        public string InvitationId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public InvitationRoleType Role { get; set; }

        [JsonProperty("status")]
        public InvitationStatusType Status { get; set; }

        [JsonProperty("manager_id")]
        public string ManagerMemberId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvitationRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "manager")]
        Manager
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvitationStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "revoked")]
        Revoked
    }

    public class InviteMemberBodyInput
    {
        public InviteMemberBodyInput(string email)
        {
            this.Email = email;
        }

        [JsonProperty("invited_email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRoleType? Role { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Convinceiq.BodyInputRoleType.User;

        [JsonProperty("manager_membership_id")]
        public string ManagerMemberId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "manager")]
        Manager
    }

    public class AssignmentResult
    {
        [JsonProperty("created_count")]
        public int Created { get; set; }

        [JsonProperty("duplicate_count")]
        public int AlreadyAssigned { get; set; }

        [JsonProperty("ineligible_count")]
        public int NotEligible { get; set; }

        [JsonProperty("duplicate_member_ids")]
        public string[] AlreadyAssignedMemberIds { get; set; }

        [JsonProperty("ineligible_member_ids")]
        public string[] NotEligibleMemberIds { get; set; }

        [JsonProperty("assignments")]
        public Assignment[] Assignments { get; set; }
    }

    public class Assignment
    {
        [JsonProperty("id")]
        public string AssignmentId { get; set; }

        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_title")]
        public string TrainingPlan { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("created_at")]
        public string AssignedAt { get; set; }
    }

    public class AssignTrainingPlanBodyInput
    {
        public AssignTrainingPlanBodyInput(string trainingPlan)
        {
            this.TrainingPlan = trainingPlan;
        }

        [JsonProperty("template_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TrainingPlan { get; set; }

        [JsonProperty("assignee_membership_ids")]
        public string[] MemberIds { get; set; }

        [JsonProperty("target_type")]
        public BodyInputTargetType? Target { get; set; }

        [JsonProperty("target_membership_id")]
        public string TargetMemberId { get; set; }

        [JsonProperty("target_team_id")]
        public string TargetTeamId { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTargetType
    {
        [EnumMember(Value = "membership")]
        Membership,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "workspace")]
        Workspace
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Convinceiq;

    public partial class WorkflowManagedActions
    {
        public ConvinceiqActions Convinceiq(string connectionId) => new ConvinceiqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConvinceiqTriggers Convinceiq(string connectionId) => new ConvinceiqTriggers(connectionId);
    }
}