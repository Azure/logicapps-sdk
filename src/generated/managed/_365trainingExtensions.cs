//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._365training
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _365trainingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<UserProfile, ApiConnectionActionConfiguration> GetUserProfile()
        {
            return new DeferredBodyAction<UserProfile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UserProfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<CourseSummaryResponse, ApiConnectionActionConfiguration> ListCourses(Expression<Func<string>> publishedFrom = null, Expression<Func<string>> publishedTo = null, Expression<Func<double>> priceFrom = null, Expression<Func<double>> priceTo = null, Expression<Func<bool>> isNew = null, Expression<Func<string>> moreToken = null)
        {
            var __workflow_publishedFrom = WorkflowExpression.Compile(publishedFrom, nameof(publishedFrom), required: false);
            var __workflow_publishedTo = WorkflowExpression.Compile(publishedTo, nameof(publishedTo), required: false);
            var __workflow_priceFrom = WorkflowExpression.Compile(priceFrom, nameof(priceFrom), required: false);
            var __workflow_priceTo = WorkflowExpression.Compile(priceTo, nameof(priceTo), required: false);
            var __workflow_isNew = WorkflowExpression.Compile(isNew, nameof(isNew), required: false);
            var __workflow_moreToken = WorkflowExpression.Compile(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<CourseSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ListCourses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_publishedFrom != null)
                    callPayload.Queries["PublishedFrom"] = ExpressionConverter.Convert(__workflow_publishedFrom);
                if (__workflow_publishedTo != null)
                    callPayload.Queries["PublishedTo"] = ExpressionConverter.Convert(__workflow_publishedTo);
                if (__workflow_priceFrom != null)
                    callPayload.Queries["PriceFrom"] = ExpressionConverter.Convert(__workflow_priceFrom);
                if (__workflow_priceTo != null)
                    callPayload.Queries["PriceTo"] = ExpressionConverter.Convert(__workflow_priceTo);
                if (__workflow_isNew != null)
                    callPayload.Queries["IsNew"] = ExpressionConverter.Convert(__workflow_isNew);
                if (__workflow_moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(__workflow_moreToken);
                return new ApiConnectionAction<CourseSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<InstructorSummaryResponse, ApiConnectionActionConfiguration> ListInstructors(Expression<Func<string>> moreToken = null)
        {
            var __workflow_moreToken = WorkflowExpression.Compile(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<InstructorSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ListInstructors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(__workflow_moreToken);
                return new ApiConnectionAction<InstructorSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<MyCoursesResponse, ApiConnectionActionConfiguration> ListMyCourses(Expression<Func<string>> moreToken = null)
        {
            var __workflow_moreToken = WorkflowExpression.Compile(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<MyCoursesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ListMyCourses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(__workflow_moreToken);
                return new ApiConnectionAction<MyCoursesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<IdeaSummaryResponse, ApiConnectionActionConfiguration> ListIdeas(Expression<Func<string>> moreToken = null)
        {
            var __workflow_moreToken = WorkflowExpression.Compile(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<IdeaSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ListIdeas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(__workflow_moreToken);
                return new ApiConnectionAction<IdeaSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<CourseDetail, ApiConnectionActionConfiguration> GetCourse(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CourseDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCourse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<CourseDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddIdeaVote(Expression<Func<string>> ideaId)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddIdeaVote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IdeaID"] = ExpressionConverter.Convert(__workflow_ideaId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<InstructorDetail, ApiConnectionActionConfiguration> GetInstructor(Expression<Func<string>> id = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<InstructorDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetInstructor";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<InstructorDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<SearchResponse, ApiConnectionActionConfiguration> Search(Expression<Func<string>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<SearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }
    }

    public class _365trainingTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewCourseUserNotification(Expression<Func<NewCourseUserNotificationInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/NewCourseUserNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewIdeaNotification(Expression<Func<NewIdeaNotificationInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/NewIdeaNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewCoursePublishedNotification(Expression<Func<NewCoursePublishedNotificationInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/NewCoursePublishedNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UserProfile
    {
        [JsonProperty("userID")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class CourseSummaryResponse
    {
        [JsonProperty("courses")]
        public CourseSummaryResponseCoursesTypeItem[] Courses { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("moreToken")]
        public string MoreToken { get; set; }
    }

    public class CourseSummaryResponseCoursesTypeItem
    {
        [JsonProperty("courseID")]
        public string CourseId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("onelineDescription")]
        public string OnelineDescription { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("instructorName")]
        public string InstructorName { get; set; }

        [JsonProperty("courseUrl")]
        public string CourseUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("skillLevel")]
        public string SkillLevel { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("eventStart")]
        public string EventStart { get; set; }

        [JsonProperty("eventEnd")]
        public string EventEnd { get; set; }
    }

    public class InstructorSummaryResponse
    {
        [JsonProperty("instructors")]
        public InstructorSummaryResponseInstructorsTypeItem[] Instructors { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("moreToken")]
        public string MoreToken { get; set; }
    }

    public class InstructorSummaryResponseInstructorsTypeItem
    {
        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("onelineBIO")]
        public string OnelineBIO { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class MyCoursesResponse
    {
        [JsonProperty("courses")]
        public MyCoursesResponseCoursesTypeItem[] Courses { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("moreToken")]
        public string MoreToken { get; set; }
    }

    public class MyCoursesResponseCoursesTypeItem
    {
        [JsonProperty("lastAccessed")]
        public string LastAccessed { get; set; }

        [JsonProperty("lastViewedName")]
        public string LastViewedName { get; set; }

        [JsonProperty("lastViewedId")]
        public string LastViewedId { get; set; }

        [JsonProperty("timeRemaining")]
        public int TimeRemaining { get; set; }

        [JsonProperty("percentCompleted")]
        public int PercentCompleted { get; set; }

        [JsonProperty("courseNotification")]
        public bool CourseNotification { get; set; }

        [JsonProperty("daysSinceLastAccess")]
        public int DaysSinceLastAccess { get; set; }

        [JsonProperty("courseID")]
        public string CourseId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("onelineDescription")]
        public string OnelineDescription { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("instructorName")]
        public string InstructorName { get; set; }

        [JsonProperty("courseUrl")]
        public string CourseUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("skillLevel")]
        public string SkillLevel { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("eventStart")]
        public string EventStart { get; set; }

        [JsonProperty("eventEnd")]
        public string EventEnd { get; set; }
    }

    public class IdeaSummaryResponse
    {
        [JsonProperty("ideas")]
        public IdeaSummaryResponseIdeasTypeItem[] Ideas { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("moreToken")]
        public string MoreToken { get; set; }
    }

    public class IdeaSummaryResponseIdeasTypeItem
    {
        [JsonProperty("ideaID")]
        public string IdeaId { get; set; }

        [JsonProperty("ideaSetID")]
        public string IdeaSetId { get; set; }

        [JsonProperty("idea")]
        public string Idea { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("released")]
        public bool Released { get; set; }
    }

    public class CourseDetail
    {
        [JsonProperty("instructors")]
        public JToken[] Instructors { get; set; }

        [JsonProperty("modules")]
        public CourseDetailModulesTypeItem[] Modules { get; set; }

        [JsonProperty("courseID")]
        public string CourseId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("onelineDescription")]
        public string OnelineDescription { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("instructorName")]
        public string InstructorName { get; set; }

        [JsonProperty("courseUrl")]
        public string CourseUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("skillLevel")]
        public string SkillLevel { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("eventStart")]
        public string EventStart { get; set; }

        [JsonProperty("eventEnd")]
        public string EventEnd { get; set; }
    }

    public class CourseDetailModulesTypeItem
    {
        [JsonProperty("moduleID")]
        public string ModuleId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("units")]
        public CourseDetailModulesTypeItemUnitsTypeItem[] Units { get; set; }
    }

    public class CourseDetailModulesTypeItemUnitsTypeItem
    {
        [JsonProperty("unitID")]
        public string UnitId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("unitType")]
        public string UnitType { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("objectives")]
        public string Objectives { get; set; }

        [JsonProperty("guests")]
        public CourseDetailModulesTypeItemUnitsTypeItemGuestsTypeItem[] Guests { get; set; }
    }

    public class CourseDetailModulesTypeItemUnitsTypeItemGuestsTypeItem
    {
        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("onelineBIO")]
        public string OnelineBIO { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class InstructorDetail
    {
        [JsonProperty("courses")]
        public InstructorDetailCoursesTypeItem[] Courses { get; set; }

        [JsonProperty("instructorUrl")]
        public string InstructorUrl { get; set; }

        [JsonProperty("blogURL")]
        public string BlogURL { get; set; }

        [JsonProperty("twitterHandle")]
        public string TwitterHandle { get; set; }

        [JsonProperty("linkedInID")]
        public string LinkedInId { get; set; }

        [JsonProperty("gitHubID")]
        public string GitHubId { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("onelineBIO")]
        public string OnelineBIO { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class InstructorDetailCoursesTypeItem
    {
        [JsonProperty("courseID")]
        public string CourseId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("onelineDescription")]
        public string OnelineDescription { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("instructorName")]
        public string InstructorName { get; set; }

        [JsonProperty("courseUrl")]
        public string CourseUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("skillLevel")]
        public string SkillLevel { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("eventStart")]
        public string EventStart { get; set; }

        [JsonProperty("eventEnd")]
        public string EventEnd { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("courses")]
        public SearchResponseCoursesTypeItem[] Courses { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("moreToken")]
        public string MoreToken { get; set; }

        [JsonProperty("webSearchResult")]
        public SearchResponseWebSearchResultTypeItem[] WebSearchResult { get; set; }
    }

    public class SearchResponseCoursesTypeItem
    {
        [JsonProperty("courseID")]
        public string CourseId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("onelineDescription")]
        public string OnelineDescription { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorId { get; set; }

        [JsonProperty("instructorName")]
        public string InstructorName { get; set; }

        [JsonProperty("courseUrl")]
        public string CourseUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("skillLevel")]
        public string SkillLevel { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("eventStart")]
        public string EventStart { get; set; }

        [JsonProperty("eventEnd")]
        public string EventEnd { get; set; }
    }

    public class SearchResponseWebSearchResultTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("displayURL")]
        public string DisplayURL { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }
    }

    public class NewCourseUserNotificationInput
    {
        [JsonProperty("targeturl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Targeturl { get; set; } = "#{listCallbackUrl()}";
    }

    public class NewIdeaNotificationInput
    {
        [JsonProperty("targeturl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Targeturl { get; set; } = "#{listCallbackUrl()}";
    }

    public class NewCoursePublishedNotificationInput
    {
        [JsonProperty("targeturl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Targeturl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._365training;

    public partial class WorkflowManagedActions
    {
        public _365trainingActions _365training(string connectionId) => new _365trainingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _365trainingTriggers _365training(string connectionId) => new _365trainingTriggers(connectionId);
    }
}