//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workableip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkableipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<CandidatesResponse> Candidates()
        {
            var apiCallPath = "/spi/v3/candidates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CandidatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildCandidatesId))]
        public IBodyWorkflowAction<CandidatesIdResponse> CandidatesId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CandidatesIdResponse> __BuildCandidatesId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CandidatesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/spi/v3/candidates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CandidatesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<AccountsResponse> Accounts()
        {
            var apiCallPath = "/spi/v3/accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<JobsResponse> Jobs()
        {
            var apiCallPath = "/spi/v3/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JobsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildJobShortCode))]
        public IBodyWorkflowAction<JobShortCodeResponse> JobShortCode([WorkflowExpression] Func<string> shortcode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobShortCodeResponse> __BuildJobShortCode(WorkflowExpression<string> shortcode)
        {
            WorkflowExpression.Validate(shortcode, nameof(shortcode), required: true);
            return new DeferredBodyAction<JobShortCodeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/spi/v3/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(shortcode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobShortCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<MembersResponse> Members()
        {
            var apiCallPath = "/spi/v3/members";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<StagesResponse> Stages()
        {
            var apiCallPath = "/spi/v3/stages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildJobActivities))]
        public IBodyWorkflowAction<JobActivitiesResponse> JobActivities([WorkflowExpression] Func<string> shortcode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobActivitiesResponse> __BuildJobActivities(WorkflowExpression<string> shortcode)
        {
            WorkflowExpression.Validate(shortcode, nameof(shortcode), required: true);
            return new DeferredBodyAction<JobActivitiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/spi/v3/jobs/{0}/activities", ExpressionConverter.ConvertWithUrlEncoding(shortcode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobActivitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<EventsResponse> Events()
        {
            var apiCallPath = "/spi/v3/events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildEventsId))]
        public IBodyWorkflowAction<EventsIdResponse> EventsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventsIdResponse> __BuildEventsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<EventsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/spi/v3/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<SubscriptionsResponse> Subscriptions()
        {
            var apiCallPath = "/spi/v3/subscriptions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SubscriptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildPostSubscription))]
        public IBodyWorkflowAction<PostSubscriptionResponse> PostSubscription([WorkflowExpression] Func<string> bodytarget = null, [WorkflowExpression] Func<string> bodyEvent = null, [WorkflowExpression] Func<string> bodyargsaccountId = null, [WorkflowExpression] Func<string> bodyargsstageSlug = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostSubscriptionResponse> __BuildPostSubscription(WorkflowExpression<string> bodytarget = null, WorkflowExpression<string> bodyEvent = null, WorkflowExpression<string> bodyargsaccountId = null, WorkflowExpression<string> bodyargsstageSlug = null)
        {
            WorkflowExpression.Validate(bodytarget, nameof(bodytarget), required: false);
            WorkflowExpression.Validate(bodyEvent, nameof(bodyEvent), required: false);
            WorkflowExpression.Validate(bodyargsaccountId, nameof(bodyargsaccountId), required: false);
            WorkflowExpression.Validate(bodyargsstageSlug, nameof(bodyargsstageSlug), required: false);
            return new DeferredBodyAction<PostSubscriptionResponse>(() =>
            {
                var apiCallPath = "/spi/v3/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(bodytarget);
                    bodypropCount++;
                }

                if (bodyEvent != null)
                {
                    body["event"] = ExpressionConverter.ConvertO(bodyEvent);
                    bodypropCount++;
                }

                var argsObject = new JObject();
                var argsObjectpropCount = 0;
                if (bodyargsaccountId != null)
                {
                    if (bodyargsaccountId != null)
                    {
                        argsObject["account_id"] = ExpressionConverter.ConvertO(bodyargsaccountId);
                        argsObjectpropCount++;
                    }

                    argsObjectpropCount++;
                }
                else
                {
                    argsObject["account_id"] = "aker-carbon-capture";
                    argsObjectpropCount++;
                }

                if (bodyargsstageSlug != null)
                {
                    argsObject["stage_slug"] = ExpressionConverter.ConvertO(bodyargsstageSlug);
                    argsObjectpropCount++;
                }

                if (argsObjectpropCount > 0)
                {
                    body["args"] = argsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostSubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        public IBodyWorkflowAction<CustomAttributesResponse> CustomAttributes()
        {
            var apiCallPath = "/spi/v3/custom_attributes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomAttributesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [WorkflowExpressionFactory(nameof(__BuildOffer))]
        public IBodyWorkflowAction<OfferResponse> Offer([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workableip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfferResponse> __BuildOffer(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<OfferResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/spi/v3/candidates/{0}/offer", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfferResponse>(callPayload);
            });
        }
    }

    public class WorkableipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CandidatesResponse
    {
        [JsonProperty("candidates")]
        public CandidatesResponseCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("paging")]
        public CandidatesResponsePagingType Paging { get; set; }
    }

    public class CandidatesResponseCandidatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Headline { get; set; }

        [JsonProperty("account")]
        public CandidatesResponseCandidatesTypeItemAccountType Account { get; set; }

        [JsonProperty("job")]
        public CandidatesResponseCandidatesTypeItemJobType Job { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("disqualified")]
        public bool Disqualified { get; set; }

        [JsonProperty("disqualification_reason")]
        public string DisqualificationReason { get; set; }

        [JsonProperty("hired_at")]
        public string HiredAt { get; set; }

        [JsonProperty("sourced")]
        public bool Sourced { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
        public string Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CandidatesResponseCandidatesTypeItemAccountType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CandidatesResponseCandidatesTypeItemJobType
    {
        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CandidatesResponsePagingType
    {
        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class CandidatesIdResponse
    {
        [JsonProperty("candidate")]
        public CandidatesIdResponseCandidateType Candidate { get; set; }
    }

    public class CandidatesIdResponseCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Headline { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("account")]
        public CandidatesIdResponseCandidateTypeAccountType Account { get; set; }

        [JsonProperty("job")]
        public CandidatesIdResponseCandidateTypeJobType Job { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("disqualified")]
        public bool Disqualified { get; set; }

        [JsonProperty("disqualified_at")]
        public string DisqualifiedAt { get; set; }

        [JsonProperty("disqualification_reason")]
        public string DisqualificationReason { get; set; }

        [JsonProperty("hired_at")]
        public string HiredAt { get; set; }

        [JsonProperty("sourced")]
        public bool Sourced { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
        public string Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("outbound_mailbox")]
        public string OutboundMailbox { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("uploader_id")]
        public string UploaderId { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("cover_letter")]
        public string CoverLetter { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("education_entries")]
        public CandidatesIdResponseCandidateTypeEducationEntriesTypeItem[] EducationEntries { get; set; }

        [JsonProperty("experience_entries")]
        public CandidatesIdResponseCandidateTypeExperienceEntriesTypeItem[] ExperienceEntries { get; set; }

        [JsonProperty("skills")]
        public JToken[] Skills { get; set; }

        [JsonProperty("answers")]
        public JToken[] Answers { get; set; }

        [JsonProperty("resume_url")]
        public string ResumeUrl { get; set; }

        [JsonProperty("social_profiles")]
        public CandidatesIdResponseCandidateTypeSocialProfilesTypeItem[] SocialProfiles { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("location")]
        public CandidatesIdResponseCandidateTypeLocationType Location { get; set; }

        [JsonProperty("originating_candidate_id")]
        public string OriginatingCandidateId { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeAccountType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeJobType
    {
        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeEducationEntriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("field_of_study")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeExperienceEntriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeSocialProfilesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CandidatesIdResponseCandidateTypeLocationType
    {
        [JsonProperty("location_str")]
        public string LocationStr { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }

    public class AccountsResponse
    {
        [JsonProperty("accounts")]
        public AccountsResponseAccountsTypeItem[] Accounts { get; set; }
    }

    public class AccountsResponseAccountsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }

    public class JobsResponse
    {
        [JsonProperty("jobs")]
        public JobsResponseJobsTypeItem[] Jobs { get; set; }

        [JsonProperty("paging")]
        public JobsResponsePagingType Paging { get; set; }
    }

    public class JobsResponseJobsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("full_title")]
        public string FullTitle { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("sample")]
        public bool Sample { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("department_hierarchy")]
        public JobsResponseJobsTypeItemDepartmentHierarchyTypeItem[] DepartmentHierarchy { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("application_url")]
        public string ApplicationUrl { get; set; }

        [JsonProperty("shortlink")]
        public string Shortlink { get; set; }

        [JsonProperty("location")]
        public JobsResponseJobsTypeItemLocationType Location { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }
    }

    public class JobsResponseJobsTypeItemDepartmentHierarchyTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class JobsResponseJobsTypeItemLocationType
    {
        [JsonProperty("location_str")]
        public string LocationStr { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("telecommuting")]
        public bool Telecommuting { get; set; }
    }

    public class JobsResponsePagingType
    {
        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class JobShortCodeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("full_title")]
        public string FullTitle { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("application_url")]
        public string ApplicationUrl { get; set; }

        [JsonProperty("shortlink")]
        public string Shortlink { get; set; }

        [JsonProperty("location")]
        public JobShortCodeResponseLocationType Location { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("Full description")]
        public string FullDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requirements")]
        public string Requirements { get; set; }

        [JsonProperty("benefits")]
        public string Benefits { get; set; }

        [JsonProperty("employment_type")]
        public string EmploymentType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("function")]
        public string Function { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("education")]
        public string Education { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }
    }

    public class JobShortCodeResponseLocationType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("telecommuting")]
        public bool Telecommuting { get; set; }
    }

    public class MembersResponse
    {
        [JsonProperty("members")]
        public MembersResponseMembersTypeItem[] Members { get; set; }

        [JsonProperty("paging")]
        public MembersResponsePagingType Paging { get; set; }
    }

    public class MembersResponseMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string Headline { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class MembersResponsePagingType
    {
        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class StagesResponse
    {
        [JsonProperty("stages")]
        public StagesResponseStagesTypeItem[] Stages { get; set; }
    }

    public class StagesResponseStagesTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class JobActivitiesResponse
    {
        [JsonProperty("activities")]
        public JobActivitiesResponseActivitiesTypeItem[] Activities { get; set; }
    }

    public class JobActivitiesResponseActivitiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("member")]
        public JobActivitiesResponseActivitiesTypeItemMemberType Member { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class JobActivitiesResponseActivitiesTypeItemMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsResponse
    {
        [JsonProperty("events")]
        public EventsResponseEventsTypeItem[] Events { get; set; }
    }

    public class EventsResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("starts_at")]
        public string StartsAt { get; set; }

        [JsonProperty("ends_at")]
        public string EndsAt { get; set; }

        [JsonProperty("job")]
        public EventsResponseEventsTypeItemJobType Job { get; set; }

        [JsonProperty("members")]
        public EventsResponseEventsTypeItemMembersTypeItem[] Members { get; set; }

        [JsonProperty("candidate")]
        public EventsResponseEventsTypeItemCandidateType Candidate { get; set; }
    }

    public class EventsResponseEventsTypeItemJobType
    {
        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class EventsResponseEventsTypeItemMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class EventsResponseEventsTypeItemCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventsIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("starts_at")]
        public string StartsAt { get; set; }

        [JsonProperty("ends_at")]
        public string EndsAt { get; set; }

        [JsonProperty("job")]
        public EventsIdResponseJobType Job { get; set; }

        [JsonProperty("members")]
        public EventsIdResponseMembersTypeItem[] Members { get; set; }

        [JsonProperty("candidate")]
        public EventsIdResponseCandidateType Candidate { get; set; }
    }

    public class EventsIdResponseJobType
    {
        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class EventsIdResponseMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class EventsIdResponseCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionsResponse
    {
        [JsonProperty("subscriptions")]
        public SubscriptionsResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class SubscriptionsResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("stage_slug")]
        public string StageSlug { get; set; }

        [JsonProperty("job_shortcode")]
        public string JobShortcode { get; set; }
    }

    public class PostSubscriptionResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CustomAttributesResponse
    {
        [JsonProperty("custom_attributes")]
        public JToken[] CustomAttributes { get; set; }
    }

    public class OfferResponse
    {
        [JsonProperty("candidate")]
        public OfferResponseCandidateType Candidate { get; set; }

        [JsonProperty("Created On")]
        public string CreatedOn { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("document_variables")]
        public OfferResponseDocumentVariablesTypeItem[] DocumentVariables { get; set; }

        [JsonProperty("documents")]
        public OfferResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class OfferResponseCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfferResponseDocumentVariablesTypeItem
    {
        [JsonProperty("document_variable")]
        public OfferResponseDocumentVariablesTypeItemDocumentVariableType DocumentVariable { get; set; }

        [JsonProperty("value")]
        public OfferResponseDocumentVariablesTypeItemValueType Value { get; set; }
    }

    public class OfferResponseDocumentVariablesTypeItemDocumentVariableType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class OfferResponseDocumentVariablesTypeItemValueType
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class OfferResponseDocumentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workableip;

    public partial class WorkflowManagedActions
    {
        public WorkableipActions Workableip(string connectionId) => new WorkableipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkableipTriggers Workableip(string connectionId) => new WorkableipTriggers(connectionId);
    }
}