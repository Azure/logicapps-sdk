//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftlearncataip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftlearncataipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftlearncataip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLearningContent))]
        public IBodyWorkflowAction<GetLearningContentResponse> GetLearningContent([WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> uid = null, [WorkflowExpression] Func<string> lastModified = null, [WorkflowExpression] Func<string> popularity = null, [WorkflowExpression] Func<string> level = null, [WorkflowExpression] Func<string> role = null, [WorkflowExpression] Func<string> product = null, [WorkflowExpression] Func<string> subject = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLearningContentResponse> __BuildGetLearningContent(WorkflowValue<string> locale = null, WorkflowValue<string> type = null, WorkflowValue<string> uid = null, WorkflowValue<string> lastModified = null, WorkflowValue<string> popularity = null, WorkflowValue<string> level = null, WorkflowValue<string> role = null, WorkflowValue<string> product = null, WorkflowValue<string> subject = null)
        {
            WorkflowValue.Validate(locale, nameof(locale), required: false);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(uid, nameof(uid), required: false);
            WorkflowValue.Validate(lastModified, nameof(lastModified), required: false);
            WorkflowValue.Validate(popularity, nameof(popularity), required: false);
            WorkflowValue.Validate(level, nameof(level), required: false);
            WorkflowValue.Validate(role, nameof(role), required: false);
            WorkflowValue.Validate(product, nameof(product), required: false);
            WorkflowValue.Validate(subject, nameof(subject), required: false);
            return new DeferredBodyAction<GetLearningContentResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (uid != null)
                    callPayload.Queries["uid"] = ExpressionConverter.Convert(uid);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
                if (popularity != null)
                    callPayload.Queries["popularity"] = ExpressionConverter.Convert(popularity);
                if (level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(level);
                if (role != null)
                    callPayload.Queries["role"] = ExpressionConverter.Convert(role);
                if (product != null)
                    callPayload.Queries["product"] = ExpressionConverter.Convert(product);
                if (subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
                return new ApiConnectionAction<GetLearningContentResponse>(callPayload);
            });
        }
    }

    public class MicrosoftlearncataipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLearningContentResponse
    {
        [JsonProperty("modules")]
        public GetLearningContentResponseModulesTypeItem[] Modules { get; set; }

        [JsonProperty("units")]
        public GetLearningContentResponseUnitsTypeItem[] Units { get; set; }

        [JsonProperty("learningPaths")]
        public GetLearningContentResponseLearningPathsTypeItem[] LearningPaths { get; set; }

        [JsonProperty("appliedSkills")]
        public GetLearningContentResponseAppliedSkillsTypeItem[] AppliedSkills { get; set; }

        [JsonProperty("mergedCertifications")]
        public GetLearningContentResponseMergedCertificationsTypeItem[] MergedCertifications { get; set; }

        [JsonProperty("certifications")]
        public GetLearningContentResponseCertificationsTypeItem[] Certifications { get; set; }

        [JsonProperty("exams")]
        public GetLearningContentResponseExamsTypeItem[] Exams { get; set; }

        [JsonProperty("courses")]
        public GetLearningContentResponseCoursesTypeItem[] Courses { get; set; }

        [JsonProperty("levels")]
        public GetLearningContentResponseLevelsTypeItem[] Levels { get; set; }

        [JsonProperty("products")]
        public GetLearningContentResponseProductsTypeItem[] Products { get; set; }

        [JsonProperty("roles")]
        public GetLearningContentResponseRolesTypeItem[] Roles { get; set; }

        [JsonProperty("subjects")]
        public GetLearningContentResponseSubjectsTypeItem[] Subjects { get; set; }
    }

    public class GetLearningContentResponseModulesTypeItem
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration_in_minutes")]
        public int DurationInMinutes { get; set; }

        [JsonProperty("rating")]
        public GetLearningContentResponseModulesTypeItemRatingType Rating { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("social_image_url")]
        public string SocialImageUrl { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("firstUnitUrl")]
        public string FirstUnitUrl { get; set; }

        [JsonProperty("units")]
        public string[] Units { get; set; }

        [JsonProperty("number_of_children")]
        public int NumberOfChildren { get; set; }
    }

    public class GetLearningContentResponseModulesTypeItemRatingType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("average")]
        public double Average { get; set; }
    }

    public class GetLearningContentResponseUnitsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration_in_minutes")]
        public int DurationInMinutes { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
    }

    public class GetLearningContentResponseLearningPathsTypeItem
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration_in_minutes")]
        public int DurationInMinutes { get; set; }

        [JsonProperty("rating")]
        public GetLearningContentResponseLearningPathsTypeItemRatingType Rating { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("social_image_url")]
        public string SocialImageUrl { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("firstModuleUrl")]
        public string FirstModuleUrl { get; set; }

        [JsonProperty("modules")]
        public string[] Modules { get; set; }

        [JsonProperty("number_of_children")]
        public int NumberOfChildren { get; set; }
    }

    public class GetLearningContentResponseLearningPathsTypeItemRatingType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetLearningContentResponseAppliedSkillsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("study_guide")]
        public GetLearningContentResponseAppliedSkillsTypeItemStudyGuideTypeItem[] StudyGuide { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
    }

    public class GetLearningContentResponseAppliedSkillsTypeItemStudyGuideTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLearningContentResponseMergedCertificationsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("certification_type")]
        public string CertificationType { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("renewal_frequency_in_days")]
        public int RenewalFrequencyInDays { get; set; }

        [JsonProperty("prerequisites")]
        public string[] Prerequisites { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("recommendation_list")]
        public string[] RecommendationList { get; set; }

        [JsonProperty("study_guide")]
        public GetLearningContentResponseMergedCertificationsTypeItemStudyGuideTypeItem[] StudyGuide { get; set; }

        [JsonProperty("exam_duration_in_minutes")]
        public int ExamDurationInMinutes { get; set; }

        [JsonProperty("locales")]
        public string[] Locales { get; set; }

        [JsonProperty("providers")]
        public GetLearningContentResponseMergedCertificationsTypeItemProvidersTypeItem[] Providers { get; set; }

        [JsonProperty("career_paths")]
        public string[] CareerPaths { get; set; }
    }

    public class GetLearningContentResponseMergedCertificationsTypeItemStudyGuideTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLearningContentResponseMergedCertificationsTypeItemProvidersTypeItem
    {
        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("examUrl")]
        public string ExamUrl { get; set; }
    }

    public class GetLearningContentResponseCertificationsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("certification_type")]
        public string CertificationType { get; set; }

        [JsonProperty("exams")]
        public string[] Exams { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("study_guide")]
        public GetLearningContentResponseCertificationsTypeItemStudyGuideTypeItem[] StudyGuide { get; set; }
    }

    public class GetLearningContentResponseCertificationsTypeItemStudyGuideTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLearningContentResponseExamsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("pdf_download_url")]
        public string PdfDownloadUrl { get; set; }

        [JsonProperty("practice_assessment_url")]
        public string PracticeAssessmentUrl { get; set; }

        [JsonProperty("practice_test_url")]
        public string PracticeTestUrl { get; set; }

        [JsonProperty("locales")]
        public JToken[] Locales { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("courses")]
        public string[] Courses { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("providers")]
        public GetLearningContentResponseExamsTypeItemProvidersTypeItem[] Providers { get; set; }

        [JsonProperty("study_guide")]
        public GetLearningContentResponseExamsTypeItemStudyGuideTypeItem[] StudyGuide { get; set; }
    }

    public class GetLearningContentResponseExamsTypeItemProvidersTypeItem
    {
        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("examUrl")]
        public string ExamUrl { get; set; }
    }

    public class GetLearningContentResponseExamsTypeItemStudyGuideTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLearningContentResponseCoursesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("course_number")]
        public string CourseNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("duration_in_hours")]
        public int DurationInHours { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("locales")]
        public string[] Locales { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("exam")]
        public string Exam { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("study_guide")]
        public GetLearningContentResponseCoursesTypeItemStudyGuideTypeItem[] StudyGuide { get; set; }

        [JsonProperty("recommendation_list")]
        public string[] RecommendationList { get; set; }
    }

    public class GetLearningContentResponseCoursesTypeItemStudyGuideTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLearningContentResponseLevelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLearningContentResponseProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("children")]
        public GetLearningContentResponseProductsTypeItemChildrenTypeItem[] Children { get; set; }
    }

    public class GetLearningContentResponseProductsTypeItemChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLearningContentResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLearningContentResponseSubjectsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("children")]
        public GetLearningContentResponseSubjectsTypeItemChildrenTypeItem[] Children { get; set; }
    }

    public class GetLearningContentResponseSubjectsTypeItemChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftlearncataip;

    public partial class WorkflowManagedActions
    {
        public MicrosoftlearncataipActions Microsoftlearncataip(string connectionId) => new MicrosoftlearncataipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftlearncataipTriggers Microsoftlearncataip(string connectionId) => new MicrosoftlearncataipTriggers(connectionId);
    }
}
