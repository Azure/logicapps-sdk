//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Khalibrelms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KhalibrelmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "khalibrelms")]
        public IBodyWorkflowAction<ReadCoursesResponse, ApiConnectionActionConfiguration> ReadCourses(Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null, Expression<Func<string>> keywords = null)
        {
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            return new DeferredBodyAction<ReadCoursesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/o/kh-gateway/lms/v1.1/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                return new ApiConnectionAction<ReadCoursesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "khalibrelms")]
        public IBodyWorkflowAction<ReadCourseDetailResponse, ApiConnectionActionConfiguration> ReadCourseDetail(Expression<Func<int>> courseId)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            return new DeferredBodyAction<ReadCourseDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/o/kh-gateway/lms/v1.1/course/{0}", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ReadCourseDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "khalibrelms")]
        public IBodyWorkflowAction<ProgressByCourseIdResponse, ApiConnectionActionConfiguration> ProgressByCourseId(Expression<Func<int>> courseId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<ProgressByCourseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/o/kh-gateway/lms/v1.1/progress/course/{0}", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<ProgressByCourseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "khalibrelms")]
        public IBodyWorkflowAction<ProgressByEmailResponse, ApiConnectionActionConfiguration> ProgressByEmail(Expression<Func<string>> learnerEmail, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_learnerEmail = WorkflowExpression.Compile(learnerEmail, nameof(learnerEmail), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<ProgressByEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/o/kh-gateway/lms/v1.1/progress/learner";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["learnerEmail"] = ExpressionConverter.Convert(__workflow_learnerEmail);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<ProgressByEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "khalibrelms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BookCourse(Expression<Func<int>> bodycommunityId, Expression<Func<int>> bodycourseId, Expression<Func<string>> bodylearnerEmail, Expression<Func<string>> bodylearnerFirstname = null, Expression<Func<string>> bodylearnerLastname = null)
        {
            var __workflow_bodycommunityId = WorkflowExpression.Compile(bodycommunityId, nameof(bodycommunityId), required: true);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: true);
            var __workflow_bodylearnerEmail = WorkflowExpression.Compile(bodylearnerEmail, nameof(bodylearnerEmail), required: true);
            var __workflow_bodylearnerFirstname = WorkflowExpression.Compile(bodylearnerFirstname, nameof(bodylearnerFirstname), required: false);
            var __workflow_bodylearnerLastname = WorkflowExpression.Compile(bodylearnerLastname, nameof(bodylearnerLastname), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/o/kh-gateway/lms/v1.1/course/booking";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["communityId"] = ExpressionConverter.ConvertO(__workflow_bodycommunityId);
                bodypropCount++;
                body["courseId"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                bodypropCount++;
                body["learnerEmail"] = ExpressionConverter.ConvertO(__workflow_bodylearnerEmail);
                if (__workflow_bodylearnerFirstname != null)
                {
                    body["learnerFirstname"] = ExpressionConverter.ConvertO(__workflow_bodylearnerFirstname);
                    bodypropCount++;
                }

                if (__workflow_bodylearnerLastname != null)
                {
                    body["learnerLastname"] = ExpressionConverter.ConvertO(__workflow_bodylearnerLastname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class KhalibrelmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReadCoursesResponse
    {
        [JsonProperty("actions")]
        public JToken Actions { get; set; }

        [JsonProperty("facets")]
        public string[] Facets { get; set; }

        [JsonProperty("items")]
        public ReadCoursesResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("lastPage")]
        public int LastPage { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class ReadCoursesResponseItemsTypeItem
    {
        [JsonProperty("additionalBookingNote")]
        public string AdditionalBookingNote { get; set; }

        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        [JsonProperty("bookingUrl")]
        public string BookingUrl { get; set; }

        [JsonProperty("classTitle")]
        public string ClassTitle { get; set; }

        [JsonProperty("communities")]
        public ReadCoursesResponseItemsTypeItemCommunitiesTypeItem[] Communities { get; set; }

        [JsonProperty("courseExpiryPeriod")]
        public int CourseExpiryPeriod { get; set; }

        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dayBeforeBook")]
        public int DayBeforeBook { get; set; }

        [JsonProperty("dayBeforeCancel")]
        public int DayBeforeCancel { get; set; }

        [JsonProperty("deliveryMethod")]
        public ReadCoursesResponseItemsTypeItemDeliveryMethodType DeliveryMethod { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expectedDuration")]
        public int ExpectedDuration { get; set; }

        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalActivity")]
        public int TotalActivity { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class ReadCoursesResponseItemsTypeItemCommunitiesTypeItem
    {
        [JsonProperty("bookingUrl")]
        public string BookingUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadCoursesResponseItemsTypeItemDeliveryMethodType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadCourseDetailResponse
    {
        [JsonProperty("additionalBookingNote")]
        public string AdditionalBookingNote { get; set; }

        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        [JsonProperty("bookingUrl")]
        public string BookingUrl { get; set; }

        [JsonProperty("classTitle")]
        public string ClassTitle { get; set; }

        [JsonProperty("communities")]
        public ReadCourseDetailResponseCommunitiesTypeItem[] Communities { get; set; }

        [JsonProperty("courseExpiryPeriod")]
        public int CourseExpiryPeriod { get; set; }

        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dayBeforeBook")]
        public int DayBeforeBook { get; set; }

        [JsonProperty("dayBeforeCancel")]
        public int DayBeforeCancel { get; set; }

        [JsonProperty("deliveryMethod")]
        public ReadCourseDetailResponseDeliveryMethodType DeliveryMethod { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("expectedDuration")]
        public int ExpectedDuration { get; set; }

        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalActivity")]
        public int TotalActivity { get; set; }
    }

    public class ReadCourseDetailResponseCommunitiesTypeItem
    {
        [JsonProperty("bookingUrl")]
        public string BookingUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReadCourseDetailResponseDeliveryMethodType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ProgressByCourseIdResponse
    {
        [JsonProperty("actions")]
        public JToken Actions { get; set; }

        [JsonProperty("facets")]
        public JToken[] Facets { get; set; }

        [JsonProperty("items")]
        public ProgressByCourseIdResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("lastPage")]
        public int LastPage { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class ProgressByCourseIdResponseItemsTypeItem
    {
        [JsonProperty("activityOverdue")]
        public bool ActivityOverdue { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("classTitle")]
        public string ClassTitle { get; set; }

        [JsonProperty("community")]
        public ProgressByCourseIdResponseItemsTypeItemCommunityType Community { get; set; }

        [JsonProperty("completedActivity")]
        public int CompletedActivity { get; set; }

        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("courseOverdue")]
        public bool CourseOverdue { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("recentUpdateDate")]
        public string RecentUpdateDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalActivity")]
        public int TotalActivity { get; set; }
    }

    public class ProgressByCourseIdResponseItemsTypeItemCommunityType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProgressByEmailResponse
    {
        [JsonProperty("actions")]
        public JToken Actions { get; set; }

        [JsonProperty("facets")]
        public JToken[] Facets { get; set; }

        [JsonProperty("items")]
        public ProgressByEmailResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("lastPage")]
        public int LastPage { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

    public class ProgressByEmailResponseItemsTypeItem
    {
        [JsonProperty("activityOverdue")]
        public bool ActivityOverdue { get; set; }

        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }

        [JsonProperty("classTitle")]
        public string ClassTitle { get; set; }

        [JsonProperty("community")]
        public ProgressByEmailResponseItemsTypeItemCommunityType Community { get; set; }

        [JsonProperty("completedActivity")]
        public int CompletedActivity { get; set; }

        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("courseOverdue")]
        public bool CourseOverdue { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("recentUpdateDate")]
        public string RecentUpdateDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalActivity")]
        public int TotalActivity { get; set; }
    }

    public class ProgressByEmailResponseItemsTypeItemCommunityType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Khalibrelms;

    public partial class WorkflowManagedActions
    {
        public KhalibrelmsActions Khalibrelms(string connectionId) => new KhalibrelmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KhalibrelmsTriggers Khalibrelms(string connectionId) => new KhalibrelmsTriggers(connectionId);
    }
}