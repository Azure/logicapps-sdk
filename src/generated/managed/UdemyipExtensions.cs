//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Udemyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UdemyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCoursesResponse> GetCourses(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> search = null, Expression<Func<string>> category = null, Expression<Func<string>> subcategory = null, Expression<Func<string>> price = null, Expression<Func<bool>> isAffiliateAgreed = null, Expression<Func<bool>> isDealsAgreed = null, Expression<Func<string>> language = null, Expression<Func<bool>> hasClosedCaption = null, Expression<Func<bool>> hasCodingExercises = null, Expression<Func<bool>> hasSimpleQuiz = null, Expression<Func<bool>> hasWorkspace = null, Expression<Func<string>> instructionalLevel = null, Expression<Func<string>> ordering = null, Expression<Func<double>> ratings = null, Expression<Func<string>> duration = null, Expression<Func<int>> subsCollId = null, Expression<Func<string>> subsFilterType = null)
        {
            var apiCallPath = "/courses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (subcategory != null)
                callPayload.Queries["subcategory"] = ExpressionConverter.Convert(subcategory);
            if (price != null)
                callPayload.Queries["price"] = ExpressionConverter.Convert(price);
            if (isAffiliateAgreed != null)
                callPayload.Queries["is_affiliate_agreed"] = ExpressionConverter.Convert(isAffiliateAgreed);
            if (isDealsAgreed != null)
                callPayload.Queries["is_deals_agreed"] = ExpressionConverter.Convert(isDealsAgreed);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            if (hasClosedCaption != null)
                callPayload.Queries["has_closed_caption"] = ExpressionConverter.Convert(hasClosedCaption);
            if (hasCodingExercises != null)
                callPayload.Queries["has_coding_exercises"] = ExpressionConverter.Convert(hasCodingExercises);
            if (hasSimpleQuiz != null)
                callPayload.Queries["has_simple_quiz"] = ExpressionConverter.Convert(hasSimpleQuiz);
            if (hasWorkspace != null)
                callPayload.Queries["has_workspace"] = ExpressionConverter.Convert(hasWorkspace);
            if (instructionalLevel != null)
                callPayload.Queries["instructional_level"] = ExpressionConverter.Convert(instructionalLevel);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (ratings != null)
                callPayload.Queries["ratings"] = ExpressionConverter.Convert(ratings);
            if (duration != null)
                callPayload.Queries["duration"] = ExpressionConverter.Convert(duration);
            if (subsCollId != null)
                callPayload.Queries["subs_coll_id"] = ExpressionConverter.Convert(subsCollId);
            if (subsFilterType != null)
                callPayload.Queries["subs_filter_type"] = ExpressionConverter.Convert(subsFilterType);
            return new ApiConnectionAction<GetCoursesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseDetailsResponse> GetCourseDetails(Expression<Func<int>> pk)
        {
            var apiCallPath = String.Format("/courses/{0}/", ExpressionConverter.ConvertWithUrlEncoding(pk, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCourseDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseReviewsResponse> GetCourseReviews(Expression<Func<int>> courseId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/courses/{0}/reviews/", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetCourseReviewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetPublicCurriculumItemsResponse> GetPublicCurriculumItems(Expression<Func<int>> courseId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/courses/{0}/public-curriculum-items", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetPublicCurriculumItemsResponse>(callPayload);
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