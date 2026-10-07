//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentriviadbip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentriviadbipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        public IBodyWorkflowAction<GetCategoriesResponse> GetCategories()
        {
            var apiCallPath = "/api_category.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        [WorkflowExpressionFactory(nameof(__BuildGetQuestion))]
        public IBodyWorkflowAction<GetQuestionResponse> GetQuestion([WorkflowExpression] Func<int> amount, [WorkflowExpression] Func<int> category = null, [WorkflowExpression] Func<difficultyInput> difficulty = null, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetQuestionResponse> __BuildGetQuestion(WorkflowExpression<int> amount, WorkflowExpression<int> category = null, WorkflowExpression<difficultyInput> difficulty = null, WorkflowExpression<typeInput> type = null)
        {
            WorkflowExpression.Validate(amount, nameof(amount), required: true);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(difficulty, nameof(difficulty), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<GetQuestionResponse>(() =>
            {
                var apiCallPath = "/api.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["amount"] = ExpressionConverter.Convert(amount);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (difficulty != null)
                    callPayload.Queries["difficulty"] = ExpressionConverter.Convert(difficulty);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<GetQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        [WorkflowExpressionFactory(nameof(__BuildQuestionCountLookup))]
        public IBodyWorkflowAction<QuestionCountLookupResponse> QuestionCountLookup([WorkflowExpression] Func<int> category)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuestionCountLookupResponse> __BuildQuestionCountLookup(WorkflowExpression<int> category)
        {
            WorkflowExpression.Validate(category, nameof(category), required: true);
            return new DeferredBodyAction<QuestionCountLookupResponse>(() =>
            {
                var apiCallPath = "/api_count.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                return new ApiConnectionAction<QuestionCountLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentriviadbip")]
        public IBodyWorkflowAction<GlobalCountLookupResponse> GlobalCountLookup()
        {
            var apiCallPath = "/api_count_global.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GlobalCountLookupResponse>(callPayload);
        }
    }

    public class OpentriviadbipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCategoriesResponse
    {
        [JsonProperty("trivia_categories")]
        public GetCategoriesResponseTriviaCategoriesTypeItem[] TriviaCategories { get; set; }
    }

    public class GetCategoriesResponseTriviaCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetQuestionResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("results")]
        public GetQuestionResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetQuestionResponseResultsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("correct_answer")]
        public string CorrectAnswer { get; set; }

        [JsonProperty("incorrect_answers")]
        public string[] IncorrectAnswers { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum difficultyInput
    {
        [EnumMember(Value = "easy")]
        Easy,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "hard")]
        Hard
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "multiple")]
        Multiple
    }

    public class QuestionCountLookupResponse
    {
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("category_question_count")]
        public QuestionCountLookupResponseCategoryQuestionCountType CategoryQuestionCount { get; set; }
    }

    public class QuestionCountLookupResponseCategoryQuestionCountType
    {
        [JsonProperty("total_question_count")]
        public int TotalQuestionCount { get; set; }

        [JsonProperty("total_easy_question_count")]
        public int TotalEasyQuestionCount { get; set; }

        [JsonProperty("total_medium_question_count")]
        public int TotalMediumQuestionCount { get; set; }

        [JsonProperty("total_hard_question_count")]
        public int TotalHardQuestionCount { get; set; }
    }

    public class GlobalCountLookupResponse
    {
        [JsonProperty("overall")]
        public GlobalCountLookupResponseOverallType Overall { get; set; }

        [JsonProperty("categories")]
        public GlobalCountLookupResponseCategoriesType Categories { get; set; }
    }

    public class GlobalCountLookupResponseOverallType
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType
    {
        [JsonProperty("9")]
        public GlobalCountLookupResponseCategoriesType_9Type _9 { get; set; }

        [JsonProperty("10")]
        public GlobalCountLookupResponseCategoriesType_10Type _10 { get; set; }

        [JsonProperty("11")]
        public GlobalCountLookupResponseCategoriesType_11Type _11 { get; set; }

        [JsonProperty("12")]
        public GlobalCountLookupResponseCategoriesType_12Type _12 { get; set; }

        [JsonProperty("13")]
        public GlobalCountLookupResponseCategoriesType_13Type _13 { get; set; }

        [JsonProperty("14")]
        public GlobalCountLookupResponseCategoriesType_14Type _14 { get; set; }

        [JsonProperty("15")]
        public GlobalCountLookupResponseCategoriesType_15Type _15 { get; set; }

        [JsonProperty("16")]
        public GlobalCountLookupResponseCategoriesType_16Type _16 { get; set; }

        [JsonProperty("17")]
        public GlobalCountLookupResponseCategoriesType_17Type _17 { get; set; }

        [JsonProperty("18")]
        public GlobalCountLookupResponseCategoriesType_18Type _18 { get; set; }

        [JsonProperty("19")]
        public GlobalCountLookupResponseCategoriesType_19Type _19 { get; set; }

        [JsonProperty("20")]
        public GlobalCountLookupResponseCategoriesType_20Type _20 { get; set; }

        [JsonProperty("21")]
        public GlobalCountLookupResponseCategoriesType_21Type _21 { get; set; }

        [JsonProperty("22")]
        public GlobalCountLookupResponseCategoriesType_22Type _22 { get; set; }

        [JsonProperty("23")]
        public GlobalCountLookupResponseCategoriesType_23Type _23 { get; set; }

        [JsonProperty("24")]
        public GlobalCountLookupResponseCategoriesType_24Type _24 { get; set; }

        [JsonProperty("25")]
        public GlobalCountLookupResponseCategoriesType_25Type _25 { get; set; }

        [JsonProperty("26")]
        public GlobalCountLookupResponseCategoriesType_26Type _26 { get; set; }

        [JsonProperty("27")]
        public GlobalCountLookupResponseCategoriesType_27Type _27 { get; set; }

        [JsonProperty("28")]
        public GlobalCountLookupResponseCategoriesType_28Type _28 { get; set; }

        [JsonProperty("29")]
        public GlobalCountLookupResponseCategoriesType_29Type _29 { get; set; }

        [JsonProperty("30")]
        public GlobalCountLookupResponseCategoriesType_30Type _30 { get; set; }

        [JsonProperty("31")]
        public GlobalCountLookupResponseCategoriesType_31Type _31 { get; set; }

        [JsonProperty("32")]
        public GlobalCountLookupResponseCategoriesType_32Type _32 { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_9Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_10Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_11Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_12Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_13Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_14Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_15Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_16Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_17Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_18Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_19Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_20Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_21Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_22Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_23Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_24Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_25Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_26Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_27Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_28Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_29Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_30Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_31Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }

    public class GlobalCountLookupResponseCategoriesType_32Type
    {
        [JsonProperty("total_num_of_questions")]
        public int TotalNumOfQuestions { get; set; }

        [JsonProperty("total_num_of_pending_questions")]
        public int TotalNumOfPendingQuestions { get; set; }

        [JsonProperty("total_num_of_verified_questions")]
        public int TotalNumOfVerifiedQuestions { get; set; }

        [JsonProperty("total_num_of_rejected_questions")]
        public int TotalNumOfRejectedQuestions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opentriviadbip;

    public partial class WorkflowManagedActions
    {
        public OpentriviadbipActions Opentriviadbip(string connectionId) => new OpentriviadbipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpentriviadbipTriggers Opentriviadbip(string connectionId) => new OpentriviadbipTriggers(connectionId);
    }
}