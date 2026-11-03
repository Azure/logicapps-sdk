//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Udemyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UdemyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCoursesResponse, ApiConnectionActionConfiguration> GetCourses(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> search = null, Expression<Func<string>> category = null, Expression<Func<string>> subcategory = null, Expression<Func<string>> price = null, Expression<Func<bool>> isAffiliateAgreed = null, Expression<Func<bool>> isDealsAgreed = null, Expression<Func<string>> language = null, Expression<Func<bool>> hasClosedCaption = null, Expression<Func<bool>> hasCodingExercises = null, Expression<Func<bool>> hasSimpleQuiz = null, Expression<Func<bool>> hasWorkspace = null, Expression<Func<string>> instructionalLevel = null, Expression<Func<string>> ordering = null, Expression<Func<double>> ratings = null, Expression<Func<string>> duration = null, Expression<Func<int>> subsCollId = null, Expression<Func<string>> subsFilterType = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_subcategory = WorkflowExpression.Compile(subcategory, nameof(subcategory), required: false);
            var __workflow_price = WorkflowExpression.Compile(price, nameof(price), required: false);
            var __workflow_isAffiliateAgreed = WorkflowExpression.Compile(isAffiliateAgreed, nameof(isAffiliateAgreed), required: false);
            var __workflow_isDealsAgreed = WorkflowExpression.Compile(isDealsAgreed, nameof(isDealsAgreed), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_hasClosedCaption = WorkflowExpression.Compile(hasClosedCaption, nameof(hasClosedCaption), required: false);
            var __workflow_hasCodingExercises = WorkflowExpression.Compile(hasCodingExercises, nameof(hasCodingExercises), required: false);
            var __workflow_hasSimpleQuiz = WorkflowExpression.Compile(hasSimpleQuiz, nameof(hasSimpleQuiz), required: false);
            var __workflow_hasWorkspace = WorkflowExpression.Compile(hasWorkspace, nameof(hasWorkspace), required: false);
            var __workflow_instructionalLevel = WorkflowExpression.Compile(instructionalLevel, nameof(instructionalLevel), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_ratings = WorkflowExpression.Compile(ratings, nameof(ratings), required: false);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: false);
            var __workflow_subsCollId = WorkflowExpression.Compile(subsCollId, nameof(subsCollId), required: false);
            var __workflow_subsFilterType = WorkflowExpression.Compile(subsFilterType, nameof(subsFilterType), required: false);
            return new DeferredBodyAction<GetCoursesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_subcategory != null)
                    callPayload.Queries["subcategory"] = ExpressionConverter.Convert(__workflow_subcategory);
                if (__workflow_price != null)
                    callPayload.Queries["price"] = ExpressionConverter.Convert(__workflow_price);
                if (__workflow_isAffiliateAgreed != null)
                    callPayload.Queries["is_affiliate_agreed"] = ExpressionConverter.Convert(__workflow_isAffiliateAgreed);
                if (__workflow_isDealsAgreed != null)
                    callPayload.Queries["is_deals_agreed"] = ExpressionConverter.Convert(__workflow_isDealsAgreed);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_hasClosedCaption != null)
                    callPayload.Queries["has_closed_caption"] = ExpressionConverter.Convert(__workflow_hasClosedCaption);
                if (__workflow_hasCodingExercises != null)
                    callPayload.Queries["has_coding_exercises"] = ExpressionConverter.Convert(__workflow_hasCodingExercises);
                if (__workflow_hasSimpleQuiz != null)
                    callPayload.Queries["has_simple_quiz"] = ExpressionConverter.Convert(__workflow_hasSimpleQuiz);
                if (__workflow_hasWorkspace != null)
                    callPayload.Queries["has_workspace"] = ExpressionConverter.Convert(__workflow_hasWorkspace);
                if (__workflow_instructionalLevel != null)
                    callPayload.Queries["instructional_level"] = ExpressionConverter.Convert(__workflow_instructionalLevel);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_ratings != null)
                    callPayload.Queries["ratings"] = ExpressionConverter.Convert(__workflow_ratings);
                if (__workflow_duration != null)
                    callPayload.Queries["duration"] = ExpressionConverter.Convert(__workflow_duration);
                if (__workflow_subsCollId != null)
                    callPayload.Queries["subs_coll_id"] = ExpressionConverter.Convert(__workflow_subsCollId);
                if (__workflow_subsFilterType != null)
                    callPayload.Queries["subs_filter_type"] = ExpressionConverter.Convert(__workflow_subsFilterType);
                return new ApiConnectionAction<GetCoursesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseDetailsResponse, ApiConnectionActionConfiguration> GetCourseDetails(Expression<Func<int>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<GetCourseDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}/", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCourseDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseReviewsResponse, ApiConnectionActionConfiguration> GetCourseReviews(Expression<Func<int>> courseId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetCourseReviewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}/reviews/", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetCourseReviewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetPublicCurriculumItemsResponse, ApiConnectionActionConfiguration> GetPublicCurriculumItems(Expression<Func<int>> courseId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetPublicCurriculumItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}/public-curriculum-items", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetPublicCurriculumItemsResponse>(callPayload);
            });
        }
    }

    public class UdemyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCoursesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public GetCoursesResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("aggregations")]
        public GetCoursesResponseAggregationsTypeItem[] Aggregations { get; set; }

        [JsonProperty("search_tracking_id")]
        public string SearchTrackingId { get; set; }
    }

    public class GetCoursesResponseResultsTypeItem
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_detail")]
        public string PriceDetail { get; set; }

        [JsonProperty("price_serve_tracking_id")]
        public string PriceServeTrackingId { get; set; }

        [JsonProperty("visible_instructors")]
        public GetCoursesResponseResultsTypeItemVisibleInstructorsTypeItem[] VisibleInstructors { get; set; }

        [JsonProperty("image_125_H")]
        public string Image125H { get; set; }

        [JsonProperty("image_240x135")]
        public string Image240x135 { get; set; }

        [JsonProperty("is_practice_test_course")]
        public bool IsPracticeTestCourse { get; set; }

        [JsonProperty("image_480x270")]
        public string Image480x270 { get; set; }

        [JsonProperty("published_title")]
        public string PublishedTitle { get; set; }

        [JsonProperty("tracking_id")]
        public string TrackingId { get; set; }

        [JsonProperty("predictive_score")]
        public string PredictiveScore { get; set; }

        [JsonProperty("relevancy_score")]
        public string RelevancyScore { get; set; }

        [JsonProperty("input_features")]
        public string InputFeatures { get; set; }

        [JsonProperty("lecture_search_result")]
        public string LectureSearchResult { get; set; }

        [JsonProperty("curriculum_lectures")]
        public JToken[] CurriculumLectures { get; set; }

        [JsonProperty("order_in_results")]
        public string OrderInResults { get; set; }

        [JsonProperty("curriculum_items")]
        public JToken[] CurriculumItems { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("instructor_name")]
        public string InstructorName { get; set; }
    }

    public class GetCoursesResponseResultsTypeItemVisibleInstructorsTypeItem
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("image_50x50")]
        public string Image50x50 { get; set; }

        [JsonProperty("image_100x100")]
        public string Image100x100 { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCoursesResponseAggregationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("options")]
        public GetCoursesResponseAggregationsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetCoursesResponseAggregationsTypeItemOptionsTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCourseDetailsResponse
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_detail")]
        public string PriceDetail { get; set; }

        [JsonProperty("price_serve_tracking_id")]
        public string PriceServeTrackingId { get; set; }

        [JsonProperty("visible_instructors")]
        public GetCourseDetailsResponseVisibleInstructorsTypeItem[] VisibleInstructors { get; set; }

        [JsonProperty("image_125_H")]
        public string Image125H { get; set; }

        [JsonProperty("image_240x135")]
        public string Image240x135 { get; set; }

        [JsonProperty("is_practice_test_course")]
        public bool IsPracticeTestCourse { get; set; }

        [JsonProperty("image_480x270")]
        public string Image480x270 { get; set; }

        [JsonProperty("published_title")]
        public string PublishedTitle { get; set; }

        [JsonProperty("tracking_id")]
        public string TrackingId { get; set; }
    }

    public class GetCourseDetailsResponseVisibleInstructorsTypeItem
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("image_50x50")]
        public string Image50x50 { get; set; }

        [JsonProperty("image_100x100")]
        public string Image100x100 { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCourseReviewsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public GetCourseReviewsResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetCourseReviewsResponseResultsTypeItem
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("user_modified")]
        public string UserModified { get; set; }

        [JsonProperty("user")]
        public GetCourseReviewsResponseResultsTypeItemUserType User { get; set; }
    }

    public class GetCourseReviewsResponseResultsTypeItemUserType
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public class GetPublicCurriculumItemsResponse
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_detail")]
        public string PriceDetail { get; set; }

        [JsonProperty("price_serve_tracking_id")]
        public string PriceServeTrackingId { get; set; }

        [JsonProperty("visible_instructors")]
        public GetPublicCurriculumItemsResponseVisibleInstructorsTypeItem[] VisibleInstructors { get; set; }

        [JsonProperty("image_125_H")]
        public string Image125H { get; set; }

        [JsonProperty("image_240x135")]
        public string Image240x135 { get; set; }

        [JsonProperty("is_practice_test_course")]
        public bool IsPracticeTestCourse { get; set; }

        [JsonProperty("image_480x270")]
        public string Image480x270 { get; set; }

        [JsonProperty("published_title")]
        public string PublishedTitle { get; set; }

        [JsonProperty("tracking_id")]
        public string TrackingId { get; set; }
    }

    public class GetPublicCurriculumItemsResponseVisibleInstructorsTypeItem
    {
        [JsonProperty("_class")]
        public string Class { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("image_50x50")]
        public string Image50x50 { get; set; }

        [JsonProperty("image_100x100")]
        public string Image100x100 { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Udemyip;

    public partial class WorkflowManagedActions
    {
        public UdemyipActions Udemyip(string connectionId) => new UdemyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UdemyipTriggers Udemyip(string connectionId) => new UdemyipTriggers(connectionId);
    }
}