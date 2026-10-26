//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starmind
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StarmindActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<FindExpertsV3Response, ApiConnectionActionConfiguration> FindExperts(Expression<Func<FindExpertsV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindExpertsV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/experts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindExpertsV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<FindQuestionsV3Response, ApiConnectionActionConfiguration> FindQuestions(Expression<Func<string>> query = null, Expression<Func<int>> limit = null, Expression<Func<filterInput>> filter = null, Expression<Func<sortInput>> sort = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<FindQuestionsV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/questions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<FindQuestionsV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<GraphQLUserResponse, ApiConnectionActionConfiguration> GetUserById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GraphQLUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphQLUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<Question, ApiConnectionActionConfiguration> PostQuestionDraft(Expression<Func<PostQuestionDraftV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Question, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/questions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Question>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<PublishQuestionDraftV3Response, ApiConnectionActionConfiguration> PublishQuestionDraft(Expression<Func<int>> questionId)
        {
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<PublishQuestionDraftV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/questions/{0}/publish", __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PublishQuestionDraftV3Response>(callPayload);
            });
        }
    }

    public class StarmindTriggers([ConnectionName] string connectionId)
    {
    }

    public class FindExpertsV3Response
    {
        [JsonProperty("experts")]
        public FindExpertsV3ResponseExpertsTypeItem[] Experts { get; set; }

        [JsonProperty("label_matches")]
        public ConceptLabelMatch[] LabelMatches { get; set; }
    }

    public class FindExpertsV3ResponseExpertsTypeItem
    {
        [JsonProperty("concept_scores")]
        public ExpertConceptScoresItem[] ConceptScores { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("user")]
        public UserV3 User { get; set; }
    }

    public class ExpertConceptScoresItem
    {
        [JsonProperty("concept")]
        public ExpertConceptScoresItemConceptType Concept { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class ExpertConceptScoresItemConceptType
    {
        [JsonProperty("concept_id")]
        public string ConceptId { get; set; }

        [JsonProperty("encounter_count")]
        public int EncounterCount { get; set; }

        [JsonProperty("is_excluded_from_suggestion")]
        public bool IsExcludedFromSuggestion { get; set; }

        [JsonProperty("is_flat")]
        public bool IsFlat { get; set; }

        [JsonProperty("labels_for_languages")]
        public ExpertConceptScoresItemConceptTypeLabelsForLanguagesTypeItem[] LabelsForLanguages { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("ontology_id")]
        public string OntologyId { get; set; }

        [JsonProperty("parents")]
        public string[] Parents { get; set; }
    }

    public class ExpertConceptScoresItemConceptTypeLabelsForLanguagesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_type")]
        public ExpertConceptScoresItemConceptTypeLabelsForLanguagesTypeItemDescriptionTypeType DescriptionType { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("primary_label")]
        public string PrimaryLabel { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpertConceptScoresItemConceptTypeLabelsForLanguagesTypeItemDescriptionTypeType
    {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "starmind_ontology")]
        StarmindOntology
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Language
    {
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "xx")]
        Xx,
        [EnumMember(Value = "zh")]
        Zh
    }

    public class UserV3
    {
        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_seen")]
        public string FirstSeen { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_federated")]
        public bool IsFederated { get; set; }

        [JsonProperty("is_technical")]
        public bool IsTechnical { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class ConceptLabelMatch
    {
        [JsonProperty("concept_id")]
        public string ConceptId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_flat")]
        public bool IsFlat { get; set; }

        [JsonProperty("label_match")]
        public string LabelMatch { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("ontology_id")]
        public string OntologyId { get; set; }

        [JsonProperty("primary_label")]
        public string PrimaryLabel { get; set; }
    }

    public class FindExpertsV3Input
    {
        [JsonProperty("language")]
        public Language? Language { get; set; }

        [JsonProperty("text_query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextQuery { get; set; }
    }

    public class FindQuestionsV3Response
    {
        [JsonProperty("_links")]
        public FindQuestionsV3ResponseLinksType Links { get; set; }

        [JsonProperty("items")]
        public Question[] Items { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class FindQuestionsV3ResponseLinksType
    {
        [JsonProperty("self")]
        public FindQuestionsV3ResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("next")]
        public FindQuestionsV3ResponseLinksTypeNextType Next { get; set; }

        [JsonProperty("last")]
        public FindQuestionsV3ResponseLinksTypeLastType Last { get; set; }
    }

    public class FindQuestionsV3ResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class FindQuestionsV3ResponseLinksTypeNextType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class FindQuestionsV3ResponseLinksTypeLastType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Question
    {
        [JsonProperty("knowledge_space_id")]
        public int KnowledgeSpaceId { get; set; }

        [JsonProperty("upvote_count")]
        public int UpvoteCount { get; set; }

        [JsonProperty("view_count")]
        public int ViewCount { get; set; }

        [JsonProperty("published")]
        public string PublishedDate { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("last_activity")]
        public string LastActivityDate { get; set; }

        [JsonProperty("is_published")]
        public bool IsPublished { get; set; }

        [JsonProperty("created")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("solution_count")]
        public int SolutionCount { get; set; }

        [JsonProperty("content_updated")]
        public string ContentUpdatedDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("updated")]
        public string QuestionUpdatedDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterInput
    {
        [EnumMember(Value = "solved")]
        Solved,
        [EnumMember(Value = "unsolved")]
        Unsolved,
        [EnumMember(Value = "my-questions")]
        MyQuestions,
        [EnumMember(Value = "my-solutions")]
        MySolutions,
        [EnumMember(Value = "flagged")]
        Flagged,
        [EnumMember(Value = "following")]
        Following,
        [EnumMember(Value = "trending")]
        Trending,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "verified")]
        Verified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "last_activity.desc")]
        LastActivityDesc,
        [EnumMember(Value = "last_activity.asc")]
        LastActivityAsc,
        [EnumMember(Value = "solution_count.desc")]
        SolutionCountDesc,
        [EnumMember(Value = "solution_count.asc")]
        SolutionCountAsc,
        [EnumMember(Value = "date_published.desc")]
        DatePublishedDesc,
        [EnumMember(Value = "date_published.asc")]
        DatePublishedAsc,
        [EnumMember(Value = "view_count.desc")]
        ViewCountDesc,
        [EnumMember(Value = "view_count.asc")]
        ViewCountAsc,
        [EnumMember(Value = "id.desc")]
        IdDesc,
        [EnumMember(Value = "id.asc")]
        IdAsc,
        [EnumMember(Value = "interest.desc")]
        InterestDesc,
        [EnumMember(Value = "interest.asc")]
        InterestAsc,
        [EnumMember(Value = "activity_and_interest.desc")]
        ActivityAndInterestDesc,
        [EnumMember(Value = "activity_and_interest.asc")]
        ActivityAndInterestAsc
    }

    public class GraphQLUserResponse
    {
        [JsonProperty("data")]
        public GraphQLUserResponseDataType Data { get; set; }

        [JsonProperty("errors")]
        public GraphQLError[] Errors { get; set; }
    }

    public class GraphQLUserResponseDataType
    {
        [JsonProperty("user")]
        public UserV3 User { get; set; }
    }

    public class GraphQLError
    {
        [JsonProperty("extensions")]
        public GraphQLErrorExtensionsType Extensions { get; set; }

        [JsonProperty("locations")]
        public GraphQLErrorLocationsTypeItem[] Locations { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("path")]
        public string[] Path { get; set; }
    }

    public class GraphQLErrorExtensionsType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GraphQLErrorLocationsTypeItem
    {
        [JsonProperty("column")]
        public int Column { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }
    }

    public class PostQuestionDraftV3Input
    {
        [JsonProperty("category")]
        public int? Category { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public Language? Language { get; set; }

        [JsonProperty("knowledge_space")]
        public int? KnowledgeSpace { get; set; }
    }

    public class PublishQuestionDraftV3Response
    {
        [JsonProperty("number_of_experts")]
        public int NumberOfExperts { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Starmind;

    public partial class WorkflowManagedActions
    {
        public StarmindActions Starmind(string connectionId) => new StarmindActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StarmindTriggers Starmind(string connectionId) => new StarmindTriggers(connectionId);
    }
}