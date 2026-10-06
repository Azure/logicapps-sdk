//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._365training
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _365trainingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<UserProfile> GetUserProfile()
        {
            var apiCallPath = "/UserProfile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildListCourses))]
        public IBodyWorkflowAction<CourseSummaryResponse> ListCourses([WorkflowExpression] Func<string> publishedFrom = null, [WorkflowExpression] Func<string> publishedTo = null, [WorkflowExpression] Func<double> priceFrom = null, [WorkflowExpression] Func<double> priceTo = null, [WorkflowExpression] Func<bool> isNew = null, [WorkflowExpression] Func<string> moreToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CourseSummaryResponse> __BuildListCourses(WorkflowExpression<string> publishedFrom = null, WorkflowExpression<string> publishedTo = null, WorkflowExpression<double> priceFrom = null, WorkflowExpression<double> priceTo = null, WorkflowExpression<bool> isNew = null, WorkflowExpression<string> moreToken = null)
        {
            WorkflowExpression.Validate(publishedFrom, nameof(publishedFrom), required: false);
            WorkflowExpression.Validate(publishedTo, nameof(publishedTo), required: false);
            WorkflowExpression.Validate(priceFrom, nameof(priceFrom), required: false);
            WorkflowExpression.Validate(priceTo, nameof(priceTo), required: false);
            WorkflowExpression.Validate(isNew, nameof(isNew), required: false);
            WorkflowExpression.Validate(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<CourseSummaryResponse>(() =>
            {
                var apiCallPath = "/ListCourses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (publishedFrom != null)
                    callPayload.Queries["PublishedFrom"] = ExpressionConverter.Convert(publishedFrom);
                if (publishedTo != null)
                    callPayload.Queries["PublishedTo"] = ExpressionConverter.Convert(publishedTo);
                if (priceFrom != null)
                    callPayload.Queries["PriceFrom"] = ExpressionConverter.Convert(priceFrom);
                if (priceTo != null)
                    callPayload.Queries["PriceTo"] = ExpressionConverter.Convert(priceTo);
                if (isNew != null)
                    callPayload.Queries["IsNew"] = ExpressionConverter.Convert(isNew);
                if (moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
                return new ApiConnectionAction<CourseSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildListInstructors))]
        public IBodyWorkflowAction<InstructorSummaryResponse> ListInstructors([WorkflowExpression] Func<string> moreToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InstructorSummaryResponse> __BuildListInstructors(WorkflowExpression<string> moreToken = null)
        {
            WorkflowExpression.Validate(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<InstructorSummaryResponse>(() =>
            {
                var apiCallPath = "/ListInstructors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
                return new ApiConnectionAction<InstructorSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildListMyCourses))]
        public IBodyWorkflowAction<MyCoursesResponse> ListMyCourses([WorkflowExpression] Func<string> moreToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MyCoursesResponse> __BuildListMyCourses(WorkflowExpression<string> moreToken = null)
        {
            WorkflowExpression.Validate(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<MyCoursesResponse>(() =>
            {
                var apiCallPath = "/ListMyCourses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
                return new ApiConnectionAction<MyCoursesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildListIdeas))]
        public IBodyWorkflowAction<IdeaSummaryResponse> ListIdeas([WorkflowExpression] Func<string> moreToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdeaSummaryResponse> __BuildListIdeas(WorkflowExpression<string> moreToken = null)
        {
            WorkflowExpression.Validate(moreToken, nameof(moreToken), required: false);
            return new DeferredBodyAction<IdeaSummaryResponse>(() =>
            {
                var apiCallPath = "/ListIdeas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (moreToken != null)
                    callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
                return new ApiConnectionAction<IdeaSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildGetCourse))]
        public IBodyWorkflowAction<CourseDetail> GetCourse([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CourseDetail> __BuildGetCourse(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CourseDetail>(() =>
            {
                var apiCallPath = "/GetCourse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<CourseDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildAddIdeaVote))]
        public IWorkflowAction AddIdeaVote([WorkflowExpression] Func<string> ideaID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddIdeaVote(WorkflowExpression<string> ideaID)
        {
            WorkflowExpression.Validate(ideaID, nameof(ideaID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/AddIdeaVote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IdeaID"] = ExpressionConverter.Convert(ideaID);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildGetInstructor))]
        public IBodyWorkflowAction<InstructorDetail> GetInstructor([WorkflowExpression] Func<string> id = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InstructorDetail> __BuildGetInstructor(WorkflowExpression<string> id = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            return new DeferredBodyAction<InstructorDetail>(() =>
            {
                var apiCallPath = "/GetInstructor";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<InstructorDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> query)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowExpression<string> query)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }
    }

    public class _365trainingTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewCourseUserNotification(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/NewCourseUserNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targeturl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger NewIdeaNotification(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/NewIdeaNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targeturl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger NewCoursePublishedNotification(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/NewCoursePublishedNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targeturl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }
    }

    public class UserProfile
    {
        [JsonProperty("userID")]
        public string UserID { get; set; }

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
        public string CourseID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string CourseID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string IdeaID { get; set; }

        [JsonProperty("ideaSetID")]
        public string IdeaSetID { get; set; }

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
        public string CourseID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string ModuleID { get; set; }

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
        public string UnitID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string LinkedInID { get; set; }

        [JsonProperty("gitHubID")]
        public string GitHubID { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("instructorID")]
        public string InstructorID { get; set; }

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
        public string CourseID { get; set; }

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
        public string InstructorID { get; set; }

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
        public string CourseID { get; set; }

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
        public string InstructorID { get; set; }

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