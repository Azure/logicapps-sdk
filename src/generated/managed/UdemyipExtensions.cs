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
        public IBodyWorkflowAction<GetCoursesResponse> GetCourses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> subcategory = null, [WorkflowExpression] Func<string> price = null, [WorkflowExpression] Func<bool> isAffiliateAgreed = null, [WorkflowExpression] Func<bool> isDealsAgreed = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> hasClosedCaption = null, [WorkflowExpression] Func<bool> hasCodingExercises = null, [WorkflowExpression] Func<bool> hasSimpleQuiz = null, [WorkflowExpression] Func<bool> hasWorkspace = null, [WorkflowExpression] Func<string> instructionalLevel = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<double> ratings = null, [WorkflowExpression] Func<string> duration = null, [WorkflowExpression] Func<int> subsCollId = null, [WorkflowExpression] Func<string> subsFilterType = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(subcategory, nameof(subcategory), required: false);
            SourceExpression.Validate(price, nameof(price), required: false);
            SourceExpression.Validate(isAffiliateAgreed, nameof(isAffiliateAgreed), required: false);
            SourceExpression.Validate(isDealsAgreed, nameof(isDealsAgreed), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(hasClosedCaption, nameof(hasClosedCaption), required: false);
            SourceExpression.Validate(hasCodingExercises, nameof(hasCodingExercises), required: false);
            SourceExpression.Validate(hasSimpleQuiz, nameof(hasSimpleQuiz), required: false);
            SourceExpression.Validate(hasWorkspace, nameof(hasWorkspace), required: false);
            SourceExpression.Validate(instructionalLevel, nameof(instructionalLevel), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(ratings, nameof(ratings), required: false);
            SourceExpression.Validate(duration, nameof(duration), required: false);
            SourceExpression.Validate(subsCollId, nameof(subsCollId), required: false);
            SourceExpression.Validate(subsFilterType, nameof(subsFilterType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (subcategory != null)
                    callPayload.Queries["subcategory"] = SourceExpressionConverter.ConvertO(subcategory);
                if (price != null)
                    callPayload.Queries["price"] = SourceExpressionConverter.ConvertO(price);
                if (isAffiliateAgreed != null)
                    callPayload.Queries["is_affiliate_agreed"] = SourceExpressionConverter.ConvertO(isAffiliateAgreed);
                if (isDealsAgreed != null)
                    callPayload.Queries["is_deals_agreed"] = SourceExpressionConverter.ConvertO(isDealsAgreed);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (hasClosedCaption != null)
                    callPayload.Queries["has_closed_caption"] = SourceExpressionConverter.ConvertO(hasClosedCaption);
                if (hasCodingExercises != null)
                    callPayload.Queries["has_coding_exercises"] = SourceExpressionConverter.ConvertO(hasCodingExercises);
                if (hasSimpleQuiz != null)
                    callPayload.Queries["has_simple_quiz"] = SourceExpressionConverter.ConvertO(hasSimpleQuiz);
                if (hasWorkspace != null)
                    callPayload.Queries["has_workspace"] = SourceExpressionConverter.ConvertO(hasWorkspace);
                if (instructionalLevel != null)
                    callPayload.Queries["instructional_level"] = SourceExpressionConverter.ConvertO(instructionalLevel);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (ratings != null)
                    callPayload.Queries["ratings"] = SourceExpressionConverter.ConvertO(ratings);
                if (duration != null)
                    callPayload.Queries["duration"] = SourceExpressionConverter.ConvertO(duration);
                if (subsCollId != null)
                    callPayload.Queries["subs_coll_id"] = SourceExpressionConverter.ConvertO(subsCollId);
                if (subsFilterType != null)
                    callPayload.Queries["subs_filter_type"] = SourceExpressionConverter.ConvertO(subsFilterType);
                return callPayload;
            }

            return new ApiConnectionAction<GetCoursesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseDetailsResponse> GetCourseDetails([WorkflowExpression] Func<int> pk)
        {
            SourceExpression.Validate(pk, nameof(pk), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/courses/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pk, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCourseDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetCourseReviewsResponse> GetCourseReviews([WorkflowExpression] Func<int> courseId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/courses/{0}/reviews/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetCourseReviewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "udemyip")]
        public IBodyWorkflowAction<GetPublicCurriculumItemsResponse> GetPublicCurriculumItems([WorkflowExpression] Func<int> courseId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/courses/{0}/public-curriculum-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetPublicCurriculumItemsResponse>(BuildSourceInput);
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