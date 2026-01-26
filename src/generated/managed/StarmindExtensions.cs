//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starmind
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StarmindActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<FindQuestionsV3Response> FindQuestionsV3(Expression<Func<string>> query = null, Expression<Func<int>> limit = null, Expression<Func<filterInput>> filter = null, Expression<Func<sortInput>> sort = null)
        {
            var apiCallPath = "/api/v3/questions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<FindQuestionsV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<Question> PostQuestionDraftV3(Expression<Func<string>> bodytitle, Expression<Func<int>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<int>> bodyknowledgeSpace = null)
        {
            var apiCallPath = "/api/v3/questions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyknowledgeSpace != null)
            {
                body["knowledge_space"] = ExpressionConverter.ConvertO(bodyknowledgeSpace);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Question>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<PublishQuestionDraftV3Response> PublishQuestionDraftV3(Expression<Func<int>> questionId)
        {
            var apiCallPath = String.Format("/api/v3/questions/{0}/publish", ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublishQuestionDraftV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<FindExpertsV3Response> FindExpertsV3(Expression<Func<string>> bodytextQuery, Expression<Func<bodylanguageInput>> bodylanguage = null)
        {
            var apiCallPath = "/api/v3/experts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            bodypropCount++;
            body["text_query"] = ExpressionConverter.ConvertO(bodytextQuery);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindExpertsV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<GraphQLUserResponse> GetUserByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v3/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphQLUserResponse>(callPayload);
        }
    }

    public class StarmindTriggers([ConnectionName] string connectionId)
    {
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

    public enum bodylanguageInput
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

    public class PublishQuestionDraftV3Response
    {
        [JsonProperty("number_of_experts")]
        public int NumberOfExperts { get; set; }
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

    public enum ExpertConceptScoresItemConceptTypeLabelsForLanguagesTypeItemDescriptionTypeType
    {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "starmind_ontology")]
        StarmindOntology
    }

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