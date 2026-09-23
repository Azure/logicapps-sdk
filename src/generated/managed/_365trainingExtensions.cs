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
        public IBodyWorkflowAction<CourseSummaryResponse> ListCourses([WorkflowExpression] Func<string> publishedFrom = null, [WorkflowExpression] Func<string> publishedTo = null, [WorkflowExpression] Func<double> priceFrom = null, [WorkflowExpression] Func<double> priceTo = null, [WorkflowExpression] Func<bool> isNew = null, [WorkflowExpression] Func<string> moreToken = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<InstructorSummaryResponse> ListInstructors([WorkflowExpression] Func<string> moreToken = null)
        {
            var apiCallPath = "/ListInstructors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (moreToken != null)
                callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
            return new ApiConnectionAction<InstructorSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<MyCoursesResponse> ListMyCourses([WorkflowExpression] Func<string> moreToken = null)
        {
            var apiCallPath = "/ListMyCourses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (moreToken != null)
                callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
            return new ApiConnectionAction<MyCoursesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<IdeaSummaryResponse> ListIdeas([WorkflowExpression] Func<string> moreToken = null)
        {
            var apiCallPath = "/ListIdeas";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (moreToken != null)
                callPayload.Queries["moreToken"] = ExpressionConverter.Convert(moreToken);
            return new ApiConnectionAction<IdeaSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<CourseDetail> GetCourse([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/GetCourse";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<CourseDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IWorkflowAction AddIdeaVote([WorkflowExpression] Func<string> ideaID)
        {
            var apiCallPath = "/AddIdeaVote";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["IdeaID"] = ExpressionConverter.Convert(ideaID);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<InstructorDetail> GetInstructor([WorkflowExpression] Func<string> id = null)
        {
            var apiCallPath = "/GetInstructor";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<InstructorDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "365training")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> query)
        {
            var apiCallPath = "/Search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }
    }

    public class _365trainingTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewCourseUserNotification(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NewIdeaNotification(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NewCoursePublishedNotification(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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