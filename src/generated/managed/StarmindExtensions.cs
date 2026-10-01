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
        public IBodyWorkflowAction<FindExpertsV3Response> FindExperts([WorkflowExpression] Func<string> bodytextQuery, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/experts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["text_query"] = SourceExpressionConverter.ConvertToken(bodytextQuery);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindExpertsV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<FindQuestionsV3Response> FindQuestions([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<sortInput> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/questions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                return callPayload;
            }

            return new ApiConnectionAction<FindQuestionsV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<GraphQLUserResponse> GetUserById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphQLUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<Question> PostQuestionDraft([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<int> bodyknowledgeSpace = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/questions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                if (bodyknowledgeSpace != null)
                {
                    body["knowledge_space"] = SourceExpressionConverter.ConvertToken(bodyknowledgeSpace);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Question>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starmind")]
        public IBodyWorkflowAction<PublishQuestionDraftV3Response> PublishQuestionDraft([WorkflowExpression] Func<int> questionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/questions/{0}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(questionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PublishQuestionDraftV3Response>(BuildSourceInput);
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