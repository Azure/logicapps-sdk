//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lms365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Lms365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction ApproveEnrollmentRequest(Expression<Func<string>> id, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Approve", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<EnrollUserToCourseResponse> EnrollUserToCourse(Expression<Func<string>> courseId, Expression<Func<string>> bodyuserLoginName, Expression<Func<string>> bodycourseSessionId = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_bodyuserLoginName = WorkflowExpression.Compile(bodyuserLoginName, nameof(bodyuserLoginName), required: true);
            var __workflow_bodycourseSessionId = WorkflowExpression.Compile(bodycourseSessionId, nameof(bodycourseSessionId), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<EnrollUserToCourseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})/Enroll", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userLoginName"] = ExpressionConverter.ConvertO(__workflow_bodyuserLoginName);
                if (__workflow_bodycourseSessionId != null)
                {
                    body["courseSessionId"] = ExpressionConverter.ConvertO(__workflow_bodycourseSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EnrollUserToCourseResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction RejectEnrollmentRequest(Expression<Func<string>> id, Expression<Func<string>> bodymessage = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Reject", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseCategoriesResponse> GetCourseCategories(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseCategoriesResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetCourseCategoriesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseCategoryResponse> CreateCourseCategory(Expression<Func<string>> bodycategoryName, Expression<Func<string>> bodycourseCatalogId, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_bodycategoryName = WorkflowExpression.Compile(bodycategoryName, nameof(bodycategoryName), required: true);
            var __workflow_bodycourseCatalogId = WorkflowExpression.Compile(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseCategoryResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(__workflow_bodycategoryName);
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(__workflow_bodycourseCatalogId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseCategoryResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseResponse> CreateCourse(Expression<Func<string>> bodycourseCatalogId, Expression<Func<bodycoursetypeInput>> bodycoursetype, Expression<Func<string>> bodytrainingTitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodyculture, Expression<Func<string>> bodyuICulture, Expression<Func<string>> bodyurl, Expression<Func<bodycategoriesInputItem[]>> bodycategories = null, Expression<Func<bodytagsInputItem[]>> bodytags = null, Expression<Func<bodyenrollmentFlowInput>> bodyenrollmentFlow = null, Expression<Func<string>> bodysiteTemplate = null, Expression<Func<string[]>> bodylearningModules = null, Expression<Func<string[]>> bodyquizzes = null, Expression<Func<bool>> bodyautoResolveUrlConflict = null, Expression<Func<string>> bodycourseLayoutId = null, Expression<Func<bodycourseSessionEnrollmentTypeInput>> bodycourseSessionEnrollmentType = null, Expression<Func<string[]>> bodyteacherLogins = null, Expression<Func<string[]>> bodytrainerLogins = null, Expression<Func<string>> bodycertificateTemplateId = null, Expression<Func<string>> bodycourseID = null, Expression<Func<string>> bodyduration = null, Expression<Func<string>> bodylongDescription = null, Expression<Func<bool>> bodypublishingSettingsisEnabled = null, Expression<Func<string>> bodypublishingSettingsstartDate = null, Expression<Func<string>> bodypublishingSettingsendDate = null, Expression<Func<bool>> bodyexpirySettingsisEnabled = null, Expression<Func<string>> bodyexpirySettingsfixedDate = null, Expression<Func<string>> bodyexpirySettingsdaysAfterCompletion = null, Expression<Func<bool>> bodydueDateSettingsisEnabled = null, Expression<Func<string>> bodydueDateSettingsfixedDate = null, Expression<Func<string>> bodydueDateSettingsdaysAfterEnrollment = null, Expression<Func<bool>> bodyshowInCatalog = null, Expression<Func<double>> bodycontinuingEducationUnits = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodyfailedCourseId = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_bodycourseCatalogId = WorkflowExpression.Compile(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            var __workflow_bodycoursetype = WorkflowExpression.Compile(bodycoursetype, nameof(bodycoursetype), required: true);
            var __workflow_bodytrainingTitle = WorkflowExpression.Compile(bodytrainingTitle, nameof(bodytrainingTitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyculture = WorkflowExpression.Compile(bodyculture, nameof(bodyculture), required: true);
            var __workflow_bodyuICulture = WorkflowExpression.Compile(bodyuICulture, nameof(bodyuICulture), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodycategories = WorkflowExpression.Compile(bodycategories, nameof(bodycategories), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodyenrollmentFlow = WorkflowExpression.Compile(bodyenrollmentFlow, nameof(bodyenrollmentFlow), required: false);
            var __workflow_bodysiteTemplate = WorkflowExpression.Compile(bodysiteTemplate, nameof(bodysiteTemplate), required: false);
            var __workflow_bodylearningModules = WorkflowExpression.Compile(bodylearningModules, nameof(bodylearningModules), required: false);
            var __workflow_bodyquizzes = WorkflowExpression.Compile(bodyquizzes, nameof(bodyquizzes), required: false);
            var __workflow_bodyautoResolveUrlConflict = WorkflowExpression.Compile(bodyautoResolveUrlConflict, nameof(bodyautoResolveUrlConflict), required: false);
            var __workflow_bodycourseLayoutId = WorkflowExpression.Compile(bodycourseLayoutId, nameof(bodycourseLayoutId), required: false);
            var __workflow_bodycourseSessionEnrollmentType = WorkflowExpression.Compile(bodycourseSessionEnrollmentType, nameof(bodycourseSessionEnrollmentType), required: false);
            var __workflow_bodyteacherLogins = WorkflowExpression.Compile(bodyteacherLogins, nameof(bodyteacherLogins), required: false);
            var __workflow_bodytrainerLogins = WorkflowExpression.Compile(bodytrainerLogins, nameof(bodytrainerLogins), required: false);
            var __workflow_bodycertificateTemplateId = WorkflowExpression.Compile(bodycertificateTemplateId, nameof(bodycertificateTemplateId), required: false);
            var __workflow_bodycourseID = WorkflowExpression.Compile(bodycourseID, nameof(bodycourseID), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodylongDescription = WorkflowExpression.Compile(bodylongDescription, nameof(bodylongDescription), required: false);
            var __workflow_bodypublishingSettingsisEnabled = WorkflowExpression.Compile(bodypublishingSettingsisEnabled, nameof(bodypublishingSettingsisEnabled), required: false);
            var __workflow_bodypublishingSettingsstartDate = WorkflowExpression.Compile(bodypublishingSettingsstartDate, nameof(bodypublishingSettingsstartDate), required: false);
            var __workflow_bodypublishingSettingsendDate = WorkflowExpression.Compile(bodypublishingSettingsendDate, nameof(bodypublishingSettingsendDate), required: false);
            var __workflow_bodyexpirySettingsisEnabled = WorkflowExpression.Compile(bodyexpirySettingsisEnabled, nameof(bodyexpirySettingsisEnabled), required: false);
            var __workflow_bodyexpirySettingsfixedDate = WorkflowExpression.Compile(bodyexpirySettingsfixedDate, nameof(bodyexpirySettingsfixedDate), required: false);
            var __workflow_bodyexpirySettingsdaysAfterCompletion = WorkflowExpression.Compile(bodyexpirySettingsdaysAfterCompletion, nameof(bodyexpirySettingsdaysAfterCompletion), required: false);
            var __workflow_bodydueDateSettingsisEnabled = WorkflowExpression.Compile(bodydueDateSettingsisEnabled, nameof(bodydueDateSettingsisEnabled), required: false);
            var __workflow_bodydueDateSettingsfixedDate = WorkflowExpression.Compile(bodydueDateSettingsfixedDate, nameof(bodydueDateSettingsfixedDate), required: false);
            var __workflow_bodydueDateSettingsdaysAfterEnrollment = WorkflowExpression.Compile(bodydueDateSettingsdaysAfterEnrollment, nameof(bodydueDateSettingsdaysAfterEnrollment), required: false);
            var __workflow_bodyshowInCatalog = WorkflowExpression.Compile(bodyshowInCatalog, nameof(bodyshowInCatalog), required: false);
            var __workflow_bodycontinuingEducationUnits = WorkflowExpression.Compile(bodycontinuingEducationUnits, nameof(bodycontinuingEducationUnits), required: false);
            var __workflow_bodyimageUrl = WorkflowExpression.Compile(bodyimageUrl, nameof(bodyimageUrl), required: false);
            var __workflow_bodyfailedCourseId = WorkflowExpression.Compile(bodyfailedCourseId, nameof(bodyfailedCourseId), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(__workflow_bodycourseCatalogId);
                bodypropCount++;
                body["CourseType"] = ExpressionConverter.ConvertO(__workflow_bodycoursetype);
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytrainingTitle);
                bodypropCount++;
                body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["Culture"] = ExpressionConverter.ConvertO(__workflow_bodyculture);
                bodypropCount++;
                body["UICulture"] = ExpressionConverter.ConvertO(__workflow_bodyuICulture);
                if (__workflow_bodycategories != null)
                {
                    body["Categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["Tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentFlow != null)
                {
                    body["EnrollmentFlow"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentFlow);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodysiteTemplate != null)
                {
                    body["SiteTemplate"] = ExpressionConverter.ConvertO(__workflow_bodysiteTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylearningModules != null)
                {
                    body["LearningModules"] = ExpressionConverter.ConvertO(__workflow_bodylearningModules);
                    bodypropCount++;
                }

                if (__workflow_bodyquizzes != null)
                {
                    body["Quizzes"] = ExpressionConverter.ConvertO(__workflow_bodyquizzes);
                    bodypropCount++;
                }

                if (__workflow_bodyautoResolveUrlConflict != null)
                {
                    body["AutoResolveUrlConflict"] = ExpressionConverter.ConvertO(__workflow_bodyautoResolveUrlConflict);
                    bodypropCount++;
                }

                if (__workflow_bodycourseLayoutId != null)
                {
                    body["CourseLayoutId"] = ExpressionConverter.ConvertO(__workflow_bodycourseLayoutId);
                    bodypropCount++;
                }

                if (__workflow_bodycourseSessionEnrollmentType != null)
                {
                    body["CourseSessionEnrollmentType"] = ExpressionConverter.ConvertO(__workflow_bodycourseSessionEnrollmentType);
                    bodypropCount++;
                }

                if (__workflow_bodyteacherLogins != null)
                {
                    body["TeacherLogins"] = ExpressionConverter.ConvertO(__workflow_bodyteacherLogins);
                    bodypropCount++;
                }

                if (__workflow_bodytrainerLogins != null)
                {
                    body["TrainerLogins"] = ExpressionConverter.ConvertO(__workflow_bodytrainerLogins);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateTemplateId != null)
                {
                    body["CertificateTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodycertificateTemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodycourseID != null)
                {
                    body["CourseID"] = ExpressionConverter.ConvertO(__workflow_bodycourseID);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["Duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodylongDescription != null)
                {
                    body["LongDescription"] = ExpressionConverter.ConvertO(__workflow_bodylongDescription);
                    bodypropCount++;
                }

                var publishingSettingsObject = new JObject();
                var publishingSettingsObjectpropCount = 0;
                if (__workflow_bodypublishingSettingsisEnabled != null)
                {
                    if (__workflow_bodypublishingSettingsisEnabled != null)
                    {
                        publishingSettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublishingSettingsisEnabled);
                        publishingSettingsObjectpropCount++;
                    }

                    publishingSettingsObjectpropCount++;
                }
                else
                {
                    publishingSettingsObject["IsEnabled"] = true;
                    publishingSettingsObjectpropCount++;
                }

                if (__workflow_bodypublishingSettingsstartDate != null)
                {
                    publishingSettingsObject["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishingSettingsstartDate);
                    publishingSettingsObjectpropCount++;
                }

                if (__workflow_bodypublishingSettingsendDate != null)
                {
                    publishingSettingsObject["EndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishingSettingsendDate);
                    publishingSettingsObjectpropCount++;
                }

                if (publishingSettingsObjectpropCount > 0)
                {
                    body["PublishingSettings"] = publishingSettingsObject;
                    bodypropCount++;
                }

                var expirySettingsObject = new JObject();
                var expirySettingsObjectpropCount = 0;
                if (__workflow_bodyexpirySettingsisEnabled != null)
                {
                    expirySettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyexpirySettingsisEnabled);
                    expirySettingsObjectpropCount++;
                }

                if (__workflow_bodyexpirySettingsfixedDate != null)
                {
                    expirySettingsObject["FixedDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpirySettingsfixedDate);
                    expirySettingsObjectpropCount++;
                }

                if (__workflow_bodyexpirySettingsdaysAfterCompletion != null)
                {
                    expirySettingsObject["DaysAfterCompletion"] = ExpressionConverter.ConvertO(__workflow_bodyexpirySettingsdaysAfterCompletion);
                    expirySettingsObjectpropCount++;
                }

                if (expirySettingsObjectpropCount > 0)
                {
                    body["ExpirySettings"] = expirySettingsObject;
                    bodypropCount++;
                }

                var dueDateSettingsObject = new JObject();
                var dueDateSettingsObjectpropCount = 0;
                if (__workflow_bodydueDateSettingsisEnabled != null)
                {
                    dueDateSettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(__workflow_bodydueDateSettingsisEnabled);
                    dueDateSettingsObjectpropCount++;
                }

                if (__workflow_bodydueDateSettingsfixedDate != null)
                {
                    dueDateSettingsObject["FixedDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDateSettingsfixedDate);
                    dueDateSettingsObjectpropCount++;
                }

                if (__workflow_bodydueDateSettingsdaysAfterEnrollment != null)
                {
                    dueDateSettingsObject["DaysAfterEnrollment"] = ExpressionConverter.ConvertO(__workflow_bodydueDateSettingsdaysAfterEnrollment);
                    dueDateSettingsObjectpropCount++;
                }

                if (dueDateSettingsObjectpropCount > 0)
                {
                    body["DueDateSettings"] = dueDateSettingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyshowInCatalog != null)
                {
                    body["ShowInCatalog"] = ExpressionConverter.ConvertO(__workflow_bodyshowInCatalog);
                    bodypropCount++;
                }

                if (__workflow_bodycontinuingEducationUnits != null)
                {
                    body["CEU"] = ExpressionConverter.ConvertO(__workflow_bodycontinuingEducationUnits);
                    bodypropCount++;
                }

                if (__workflow_bodyimageUrl != null)
                {
                    body["ImageUrl"] = ExpressionConverter.ConvertO(__workflow_bodyimageUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfailedCourseId != null)
                {
                    body["FailedCourseId"] = ExpressionConverter.ConvertO(__workflow_bodyfailedCourseId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseInfoResponse> GetCourseInfo(Expression<Func<string>> courseId, Expression<Func<string>> expand = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCourseInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("DueDate,Publishing,CertificateExpiry,SharepointWeb($select=Url),Categories,Tags,CourseSessions,ProvisioningProgress,Trainers");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetCourseInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction CompleteEnrollmentById(Expression<Func<string>> id, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Complete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction RetakeEnrollmentById(Expression<Func<string>> id, Expression<Func<string>> bodycourseSessionId = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycourseSessionId = WorkflowExpression.Compile(bodycourseSessionId, nameof(bodycourseSessionId), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Retake", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycourseSessionId != null)
                {
                    body["courseSessionId"] = ExpressionConverter.ConvertO(__workflow_bodycourseSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseTagsResponse> GetCourseTags(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseTagsResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetCourseTagsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseTagResponse> CreateCourseTag(Expression<Func<string>> bodyname, Expression<Func<string>> bodycourseCatalogId, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycourseCatalogId = WorkflowExpression.Compile(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseTagResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(__workflow_bodycourseCatalogId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseTagResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseProvisioningStatusResponse> GetCourseProvisioningStatus(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetCourseProvisioningStatusResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Courses/IncludeNotCreated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("ProvisioningProgress,SharepointWeb");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$select"] = Convert.ToString("Id");
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GetCourseProvisioningStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCoursesFromCatalogResponse> GetCoursesFromCatalog(Expression<Func<string>> courseCatalogId, Expression<Func<string>> expand = null)
        {
            var __workflow_courseCatalogId = WorkflowExpression.Compile(courseCatalogId, nameof(courseCatalogId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCoursesFromCatalogResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/CourseCatalogs({0})", __workflow_courseCatalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("Courses($expand=SharepointWeb)");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetCoursesFromCatalogResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetEnrollmentByIdResponse> GetEnrollmentById(Expression<Func<string>> enrollmentId)
        {
            var __workflow_enrollmentId = WorkflowExpression.Compile(enrollmentId, nameof(enrollmentId), required: true);
            return new DeferredBodyAction<GetEnrollmentByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})", __workflow_enrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnrollmentByIdResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction CancelEnrollment(Expression<Func<string>> enrollmentId, Expression<Func<string>> bodycancellationMessage = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_enrollmentId = WorkflowExpression.Compile(enrollmentId, nameof(enrollmentId), required: true);
            var __workflow_bodycancellationMessage = WorkflowExpression.Compile(bodycancellationMessage, nameof(bodycancellationMessage), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Cancel", __workflow_enrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycancellationMessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodycancellationMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetUsersResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = Convert.ToString("Email eq '{UserEmail}'");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction CreateCourseSession(Expression<Func<string>> courseId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<bodytimeZoneInput>> bodytimeZone, Expression<Func<string>> bodyenrollmentDeadline = null, Expression<Func<string>> bodyroomemailAddress = null, Expression<Func<string>> bodyroomtitle = null, Expression<Func<string>> bodyroomlocation = null, Expression<Func<bodyroomsourceInput>> bodyroomsource = null, Expression<Func<string>> bodymeetingUrl = null, Expression<Func<string>> bodymaxAttendees = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: true);
            var __workflow_bodyenrollmentDeadline = WorkflowExpression.Compile(bodyenrollmentDeadline, nameof(bodyenrollmentDeadline), required: false);
            var __workflow_bodyroomemailAddress = WorkflowExpression.Compile(bodyroomemailAddress, nameof(bodyroomemailAddress), required: false);
            var __workflow_bodyroomtitle = WorkflowExpression.Compile(bodyroomtitle, nameof(bodyroomtitle), required: false);
            var __workflow_bodyroomlocation = WorkflowExpression.Compile(bodyroomlocation, nameof(bodyroomlocation), required: false);
            var __workflow_bodyroomsource = WorkflowExpression.Compile(bodyroomsource, nameof(bodyroomsource), required: false);
            var __workflow_bodymeetingUrl = WorkflowExpression.Compile(bodymeetingUrl, nameof(bodymeetingUrl), required: false);
            var __workflow_bodymaxAttendees = WorkflowExpression.Compile(bodymaxAttendees, nameof(bodymaxAttendees), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})/CourseSessions", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                bodypropCount++;
                body["EndDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                bodypropCount++;
                body["TimeZone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                if (__workflow_bodyenrollmentDeadline != null)
                {
                    body["EnrollmentDeadline"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentDeadline);
                    bodypropCount++;
                }

                var roomObject = new JObject();
                var roomObjectpropCount = 0;
                if (__workflow_bodyroomemailAddress != null)
                {
                    roomObject["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyroomemailAddress);
                    roomObjectpropCount++;
                }

                if (__workflow_bodyroomtitle != null)
                {
                    roomObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyroomtitle);
                    roomObjectpropCount++;
                }

                if (__workflow_bodyroomlocation != null)
                {
                    roomObject["Location"] = ExpressionConverter.ConvertO(__workflow_bodyroomlocation);
                    roomObjectpropCount++;
                }

                if (__workflow_bodyroomsource != null)
                {
                    if (__workflow_bodyroomsource != null)
                    {
                        roomObject["Source"] = ExpressionConverter.ConvertO(__workflow_bodyroomsource);
                        roomObjectpropCount++;
                    }

                    roomObjectpropCount++;
                }
                else
                {
                    roomObject["Source"] = "Unknown";
                    roomObjectpropCount++;
                }

                if (roomObjectpropCount > 0)
                {
                    body["Room"] = roomObject;
                    bodypropCount++;
                }

                if (__workflow_bodymeetingUrl != null)
                {
                    body["MeetingUrl"] = ExpressionConverter.ConvertO(__workflow_bodymeetingUrl);
                    bodypropCount++;
                }

                if (__workflow_bodymaxAttendees != null)
                {
                    body["MaxAttendees"] = ExpressionConverter.ConvertO(__workflow_bodymaxAttendees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction FileUpload(Expression<Func<string>> fileUploadUrl, Expression<Func<object>> file)
        {
            var __workflow_fileUploadUrl = WorkflowExpression.Compile(fileUploadUrl, nameof(fileUploadUrl), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_fileUploadUrl.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction HttpRequest(Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersuri, Expression<Func<string>> parametersbody = null)
        {
            var __workflow_parametersmethod = WorkflowExpression.Compile(parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parametersuri = WorkflowExpression.Compile(parametersuri, nameof(parametersuri), required: true);
            var __workflow_parametersbody = WorkflowExpression.Compile(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = ExpressionConverter.ConvertO(__workflow_parametersmethod);
                parameterspropCount++;
                parameters["uri"] = ExpressionConverter.ConvertO(__workflow_parametersuri);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (__workflow_parametersbody != null)
                {
                    parameters["body"] = ExpressionConverter.ConvertO(__workflow_parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class Lms365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger EnrollmentApprovalRequest(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/EnrollmentApprovalRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseEnrollment(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseEnrollment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseUnenrollment(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseUnenrollment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseStarted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseStarted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseCompleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CoursePublished(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CoursePublished";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseUnpublished(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseUnpublished";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UserCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/UserCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UserDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/UserDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CourseDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscribe/CourseDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }
    }

    public class EnrollUserToCourseResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string UserId { get; set; }
        public string UserLoginName { get; set; }
        public string[] Roles { get; set; }
        public string RegistrationDate { get; set; }
        public string StartDate { get; set; }
        public string CompletionDate { get; set; }
        public string RegistrationStatus { get; set; }
        public string CoursePassingStatus { get; set; }
        public string CertificateId { get; set; }

        [JsonProperty("DecimalCEU")]
        public double ContinuingEducationUnits { get; set; }
        public string DueDate { get; set; }
        public string EndDate { get; set; }
        public bool IsPartOfTrainingPlan { get; set; }
        public bool CanUnenroll { get; set; }
        public string CancellationReason { get; set; }

        [JsonProperty("courseSessionId")]
        public string CourseSessionId { get; set; }
    }

    public class GetCourseCategoriesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetCourseCategoriesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetCourseCategoriesResponseValueTypeItem
    {
        [JsonProperty("Id")]
        public string CategoryUniqueId { get; set; }

        [JsonProperty("Name")]
        public string CategoryName { get; set; }
        public string CourseCatalogId { get; set; }
        public string ParentCategoryId { get; set; }
    }

    public class CreateCourseCategoryResponse
    {
        [JsonProperty("Id")]
        public string CatagoryUniqueId { get; set; }

        [JsonProperty("Name")]
        public string CategoryName { get; set; }
        public string CourseCatalogId { get; set; }
        public string ParentCategoryId { get; set; }
    }

    public class CreateCourseResponse
    {
        [JsonProperty("Id")]
        public string CourseUniqueId { get; set; }
        public string CourseCatalogId { get; set; }

        [JsonProperty("Title")]
        public string TrainingTitle { get; set; }

        [JsonProperty("Description")]
        public string CourseDescription { get; set; }

        [JsonProperty("LongDescription")]
        public string CourseLongDescription { get; set; }

        [JsonProperty("DecimalCEU")]
        public double ContinuingEducationUnits { get; set; }
        public bool ShowInCatalog { get; set; }
        public bool IsRequired { get; set; }
        public bool IsPublished { get; set; }
        public bool IsEnded { get; set; }
        public string CourseID { get; set; }
        public string Duration { get; set; }

        [JsonProperty("CourseType")]
        public string Coursetype { get; set; }
        public string ImageUrl { get; set; }
        public string CertificateTemplateId { get; set; }
        public string EnrollmentFlow { get; set; }
        public bool IsDeleted { get; set; }
        public string CourseSessionEnrollmentType { get; set; }
        public string CreatedAt { get; set; }
        public string CourseLayoutId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycoursetypeInput
    {
        ELearning,
        ClassRoom,
        Webinar,
        TrainingPlan
    }

    public class bodycategoriesInputItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsNew { get; set; }
        public string ParentCategoryId { get; set; }
    }

    public class bodytagsInputItem
    {
        public string Id { get; set; }

        [JsonProperty("TagName")]
        public string Name { get; set; }
        public bool IsNew { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenrollmentFlowInput
    {
        AutomaticApproval,
        LineManagerApproval,
        LMSAdministratorsApproval,
        CustomApproval,
        ExternalWebhookApproval
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycourseSessionEnrollmentTypeInput
    {
        EnrollToSingle,
        EnrollToAll,
        EnrollToMultiple
    }

    public class GetCourseInfoResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public string Id { get; set; }
        public string CourseCatalogId { get; set; }

        [JsonProperty("Title")]
        public string TrainingTitle { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }

        [JsonProperty("DecimalCEU")]
        public double ContinuingEducationUnits { get; set; }
        public bool ShowInCatalog { get; set; }
        public bool IsRequired { get; set; }
        public bool IsPublished { get; set; }
        public bool IsEnded { get; set; }
        public string CourseID { get; set; }
        public string Duration { get; set; }
        public string CourseType { get; set; }
        public string ImageUrl { get; set; }
        public string CertificateTemplateId { get; set; }
        public string EnrollmentFlow { get; set; }
        public bool IsDeleted { get; set; }
        public string CourseSessionEnrollmentType { get; set; }
        public string CreatedAt { get; set; }
        public string CourseLayoutId { get; set; }

        [JsonProperty("DueDate@odata.context")]
        public string DueDateOdataContext { get; set; }
        public GetCourseInfoResponseDueDateType DueDate { get; set; }

        [JsonProperty("Publishing@odata.context")]
        public string PublishingOdataContext { get; set; }
        public GetCourseInfoResponsePublishingType Publishing { get; set; }

        [JsonProperty("CertificateExpiry@odata.context")]
        public string CertificateExpiryOdataContext { get; set; }
        public GetCourseInfoResponseCertificateExpiryType CertificateExpiry { get; set; }
        public GetCourseInfoResponseSharepointWebType SharepointWeb { get; set; }
        public GetCourseInfoResponseCategoriesTypeItem[] Categories { get; set; }
        public GetCourseInfoResponseTagsTypeItem[] Tags { get; set; }
        public JToken[] CourseSessions { get; set; }
        public GetCourseInfoResponseLearningModulesTypeItem[] LearningModules { get; set; }

        [JsonProperty("ProvisioningProgress@odata.context")]
        public string ProvisioningProgressOdataContext { get; set; }
        public string ProvisioningProgress { get; set; }
        public GetCourseInfoResponseTrainersTypeItem[] Trainers { get; set; }
        public GetCourseInfoResponseAdminsTypeItem[] Admins { get; set; }
        public GetCourseInfoResponseQuizzesTypeItem[] Quizzes { get; set; }
    }

    public class GetCourseInfoResponseDueDateType
    {
        public string CourseId { get; set; }
        public bool IsEnabled { get; set; }
        public string FixedDate { get; set; }
        public int DaysAfterEnrollment { get; set; }
    }

    public class GetCourseInfoResponsePublishingType
    {
        public string Id { get; set; }
        public bool IsEnabled { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class GetCourseInfoResponseCertificateExpiryType
    {
        public string CourseId { get; set; }
        public bool IsEnabled { get; set; }
        public string FixedDate { get; set; }
        public int DaysAfterCompletion { get; set; }
    }

    public class GetCourseInfoResponseSharepointWebType
    {
        public string Url { get; set; }
    }

    public class GetCourseInfoResponseCategoriesTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseCatalogId { get; set; }
        public string ParentCategoryId { get; set; }
    }

    public class GetCourseInfoResponseTagsTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseCatalogId { get; set; }
    }

    public class GetCourseInfoResponseLearningModulesTypeItem
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
        public int Order { get; set; }
        public bool HasPrerequisite { get; set; }
        public GetCourseInfoResponseLearningModulesTypeItemConfigurationType Configuration { get; set; }
    }

    public class GetCourseInfoResponseLearningModulesTypeItemConfigurationType
    {
        public string LearningModuleId { get; set; }
        public GetCourseInfoResponseLearningModulesTypeItemConfigurationTypeItemsTypeItem[] Items { get; set; }
    }

    public class GetCourseInfoResponseLearningModulesTypeItemConfigurationTypeItemsTypeItem
    {
        public string Content { get; set; }
        public int EmbedType { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public int ItemType { get; set; }
        public string ConfirmationMessage { get; set; }
        public string CheckMarkMessage { get; set; }
        public int Type { get; set; }
    }

    public class GetCourseInfoResponseTrainersTypeItem
    {
        public string Id { get; set; }
        public string Department { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("Title")]
        public string TrainersDisplayName { get; set; }
        public string Email { get; set; }
        public string ManagerId { get; set; }
        public string ManagerLoginName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Office { get; set; }
        public string JobTitle { get; set; }
        public bool IsExternal { get; set; }
    }

    public class GetCourseInfoResponseAdminsTypeItem
    {
        public string Id { get; set; }
        public string Department { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("Title")]
        public string AdminsDisplayName { get; set; }
        public string Email { get; set; }
        public string ManagerId { get; set; }
        public string ManagerLoginName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Office { get; set; }
        public string JobTitle { get; set; }
        public bool IsExternal { get; set; }
    }

    public class GetCourseInfoResponseQuizzesTypeItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MaxAttemptsLimit { get; set; }
        public int PassingPercentage { get; set; }
        public bool IsPublished { get; set; }
        public string PublishingStartDate { get; set; }
        public string PublishingEndDate { get; set; }
        public bool Randomize { get; set; }
        public bool ShowScore { get; set; }
        public bool AllowReview { get; set; }
        public bool ShowCorrectAnswers { get; set; }
        public string TimeLimit { get; set; }
        public bool ShowTimer { get; set; }
        public string ModifiedAt { get; set; }
    }

    public class GetCourseTagsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetCourseTagsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetCourseTagsResponseValueTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseCatalogId { get; set; }
    }

    public class CreateCourseTagResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CourseCatalogId { get; set; }
    }

    public class GetCourseProvisioningStatusResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetCourseProvisioningStatusResponseValueTypeItem[] Value { get; set; }
    }

    public class GetCourseProvisioningStatusResponseValueTypeItem
    {
        public string Id { get; set; }

        [JsonProperty("ProvisioningProgress@odata.context")]
        public string ProvisioningProgressOdataContext { get; set; }
        public string ProvisioningProgress { get; set; }
        public GetCourseProvisioningStatusResponseValueTypeItemSharepointWebType SharepointWeb { get; set; }
    }

    public class GetCourseProvisioningStatusResponseValueTypeItemSharepointWebType
    {
        public string SiteId { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class GetCoursesFromCatalogResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public string Id { get; set; }

        [JsonProperty("Title")]
        public string CourseCatalogTitle { get; set; }
        public GetCoursesFromCatalogResponseCoursesTypeItem[] Courses { get; set; }
    }

    public class GetCoursesFromCatalogResponseCoursesTypeItem
    {
        public string Id { get; set; }
        public string CourseCatalogId { get; set; }

        [JsonProperty("Title")]
        public string TrainingTitle { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }

        [JsonProperty("DecimalCEU")]
        public double ContinuingEducationUnits { get; set; }
        public bool ShowInCatalog { get; set; }
        public bool IsRequired { get; set; }
        public bool IsPublished { get; set; }
        public bool IsEnded { get; set; }
        public string CourseID { get; set; }
        public string Duration { get; set; }
        public string CourseType { get; set; }
        public string ImageUrl { get; set; }
        public string CertificateTemplateId { get; set; }
        public string EnrollmentFlow { get; set; }
        public bool IsDeleted { get; set; }
        public string CourseSessionEnrollmentType { get; set; }
        public string CreatedAt { get; set; }
        public string CourseLayoutId { get; set; }
        public GetCoursesFromCatalogResponseCoursesTypeItemSharepointWebType SharepointWeb { get; set; }
    }

    public class GetCoursesFromCatalogResponseCoursesTypeItemSharepointWebType
    {
        public string SiteId { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class GetEnrollmentByIdResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string UserId { get; set; }
        public string UserLoginName { get; set; }
        public string[] Roles { get; set; }
        public string RegistrationDate { get; set; }
        public string StartDate { get; set; }
        public string CompletionDate { get; set; }
        public string RegistrationStatus { get; set; }
        public string CoursePassingStatus { get; set; }
        public string CertificateId { get; set; }

        [JsonProperty("DecimalCEU")]
        public double ContinuingEducationUnits { get; set; }
        public string DueDate { get; set; }
        public string EndDate { get; set; }
        public bool IsPartOfTrainingPlan { get; set; }
        public bool CanUnenroll { get; set; }
        public string CancellationReason { get; set; }

        [JsonProperty("courseSessionId")]
        public string CourseSessionId { get; set; }
    }

    public class GetUsersResponse
    {
        [JsonProperty("value")]
        public GetUsersResponseValueTypeItem[] Value { get; set; }
    }

    public class GetUsersResponseValueTypeItem
    {
        public string Id { get; set; }
        public string Department { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("Title")]
        public string UserDisplayName { get; set; }
        public string Email { get; set; }
        public string ManagerId { get; set; }
        public string ManagerLoginName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DirectoryObjectId { get; set; }
        public string Office { get; set; }
        public string JobTitle { get; set; }
        public bool IsExternal { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytimeZoneInput
    {
        [EnumMember(Value = "Afghanistan Standard Time")]
        AfghanistanStandardTime,
        [EnumMember(Value = "Alaskan Standard Time")]
        AlaskanStandardTime,
        [EnumMember(Value = "Aleutian Standard Time")]
        AleutianStandardTime,
        [EnumMember(Value = "Altai Standard Time")]
        AltaiStandardTime,
        [EnumMember(Value = "Arab Standard Time")]
        ArabStandardTime,
        [EnumMember(Value = "Arabian Standard Time")]
        ArabianStandardTime,
        [EnumMember(Value = "Arabic Standard Time")]
        ArabicStandardTime,
        [EnumMember(Value = "Argentina Standard Time")]
        ArgentinaStandardTime,
        [EnumMember(Value = "Astrakhan Standard Time")]
        AstrakhanStandardTime,
        [EnumMember(Value = "Atlantic Standard Time")]
        AtlanticStandardTime,
        [EnumMember(Value = "AUS Central Standard Time")]
        AUSCentralStandardTime,
        [EnumMember(Value = "Aus Central W. Standard Time")]
        AusCentralWStandardTime,
        [EnumMember(Value = "AUS Eastern Standard Time")]
        AUSEasternStandardTime,
        [EnumMember(Value = "Azerbaijan Standard Time")]
        AzerbaijanStandardTime,
        [EnumMember(Value = "Azores Standard Time")]
        AzoresStandardTime,
        [EnumMember(Value = "Bahia Standard Time")]
        BahiaStandardTime,
        [EnumMember(Value = "Bangladesh Standard Time")]
        BangladeshStandardTime,
        [EnumMember(Value = "Belarus Standard Time")]
        BelarusStandardTime,
        [EnumMember(Value = "Bougainville Standard Time")]
        BougainvilleStandardTime,
        [EnumMember(Value = "Canada Central Standard Time")]
        CanadaCentralStandardTime,
        [EnumMember(Value = "Cape Verde Standard Time")]
        CapeVerdeStandardTime,
        [EnumMember(Value = "Caucasus Standard Time")]
        CaucasusStandardTime,
        [EnumMember(Value = "Cen. Australia Standard Time")]
        CenAustraliaStandardTime,
        [EnumMember(Value = "Central America Standard Time")]
        CentralAmericaStandardTime,
        [EnumMember(Value = "Central Asia Standard Time")]
        CentralAsiaStandardTime,
        [EnumMember(Value = "Central Brazilian Standard Time")]
        CentralBrazilianStandardTime,
        [EnumMember(Value = "Central Europe Standard Time")]
        CentralEuropeStandardTime,
        [EnumMember(Value = "Central European Standard Time")]
        CentralEuropeanStandardTime,
        [EnumMember(Value = "Central Pacific Standard Time")]
        CentralPacificStandardTime,
        [EnumMember(Value = "Central Standard Time")]
        CentralStandardTime,
        [EnumMember(Value = "Central Standard Time (Mexico)")]
        CentralStandardTimeMexico,
        [EnumMember(Value = "Chatham Islands Standard Time")]
        ChathamIslandsStandardTime,
        [EnumMember(Value = "China Standard Time")]
        ChinaStandardTime,
        [EnumMember(Value = "Cuba Standard Time")]
        CubaStandardTime,
        [EnumMember(Value = "Dateline Standard Time")]
        DatelineStandardTime,
        [EnumMember(Value = "E. Africa Standard Time")]
        EAfricaStandardTime,
        [EnumMember(Value = "E. Australia Standard Time")]
        EAustraliaStandardTime,
        [EnumMember(Value = "E. Europe Standard Time")]
        EEuropeStandardTime,
        [EnumMember(Value = "E. South America Standard Time")]
        ESouthAmericaStandardTime,
        [EnumMember(Value = "Easter Island Standard Time")]
        EasterIslandStandardTime,
        [EnumMember(Value = "Eastern Standard Time")]
        EasternStandardTime,
        [EnumMember(Value = "Eastern Standard Time (Mexico)")]
        EasternStandardTimeMexico,
        [EnumMember(Value = "Egypt Standard Time")]
        EgyptStandardTime,
        [EnumMember(Value = "Ekaterinburg Standard Time")]
        EkaterinburgStandardTime,
        [EnumMember(Value = "Fiji Standard Time")]
        FijiStandardTime,
        [EnumMember(Value = "FLE Standard Time")]
        FLEStandardTime,
        [EnumMember(Value = "Georgian Standard Time")]
        GeorgianStandardTime,
        [EnumMember(Value = "GMT Standard Time")]
        GMTStandardTime,
        [EnumMember(Value = "Greenland Standard Time")]
        GreenlandStandardTime,
        [EnumMember(Value = "Greenwich Standard Time")]
        GreenwichStandardTime,
        [EnumMember(Value = "GTB Standard Time")]
        GTBStandardTime,
        [EnumMember(Value = "Haiti Standard Time")]
        HaitiStandardTime,
        [EnumMember(Value = "Hawaiian Standard Time")]
        HawaiianStandardTime,
        [EnumMember(Value = "India Standard Time")]
        IndiaStandardTime,
        [EnumMember(Value = "Iran Standard Time")]
        IranStandardTime,
        [EnumMember(Value = "Israel Standard Time")]
        IsraelStandardTime,
        [EnumMember(Value = "Jordan Standard Time")]
        JordanStandardTime,
        [EnumMember(Value = "Kaliningrad Standard Time")]
        KaliningradStandardTime,
        [EnumMember(Value = "Kamchatka Standard Time")]
        KamchatkaStandardTime,
        [EnumMember(Value = "Korea Standard Time")]
        KoreaStandardTime,
        [EnumMember(Value = "Libya Standard Time")]
        LibyaStandardTime,
        [EnumMember(Value = "Line Islands Standard Time")]
        LineIslandsStandardTime,
        [EnumMember(Value = "Lord Howe Standard Time")]
        LordHoweStandardTime,
        [EnumMember(Value = "Magadan Standard Time")]
        MagadanStandardTime,
        [EnumMember(Value = "Magallanes Standard Time")]
        MagallanesStandardTime,
        [EnumMember(Value = "Marquesas Standard Time")]
        MarquesasStandardTime,
        [EnumMember(Value = "Mauritius Standard Time")]
        MauritiusStandardTime,
        [EnumMember(Value = "Mid-Atlantic Standard Time")]
        MidAtlanticStandardTime,
        [EnumMember(Value = "Middle East Standard Time")]
        MiddleEastStandardTime,
        [EnumMember(Value = "Montevideo Standard Time")]
        MontevideoStandardTime,
        [EnumMember(Value = "Morocco Standard Time")]
        MoroccoStandardTime,
        [EnumMember(Value = "Mountain Standard Time")]
        MountainStandardTime,
        [EnumMember(Value = "Mountain Standard Time (Mexico)")]
        MountainStandardTimeMexico,
        [EnumMember(Value = "Myanmar Standard Time")]
        MyanmarStandardTime,
        [EnumMember(Value = "N. Central Asia Standard Time")]
        NCentralAsiaStandardTime,
        [EnumMember(Value = "Namibia Standard Time")]
        NamibiaStandardTime,
        [EnumMember(Value = "Nepal Standard Time")]
        NepalStandardTime,
        [EnumMember(Value = "New Zealand Standard Time")]
        NewZealandStandardTime,
        [EnumMember(Value = "Newfoundland Standard Time")]
        NewfoundlandStandardTime,
        [EnumMember(Value = "Norfolk Standard Time")]
        NorfolkStandardTime,
        [EnumMember(Value = "North Asia East Standard Time")]
        NorthAsiaEastStandardTime,
        [EnumMember(Value = "North Asia Standard Time")]
        NorthAsiaStandardTime,
        [EnumMember(Value = "North Korea Standard Time")]
        NorthKoreaStandardTime,
        [EnumMember(Value = "Omsk Standard Time")]
        OmskStandardTime,
        [EnumMember(Value = "Pacific SA Standard Time")]
        PacificSAStandardTime,
        [EnumMember(Value = "Pacific Standard Time")]
        PacificStandardTime,
        [EnumMember(Value = "Pacific Standard Time (Mexico)")]
        PacificStandardTimeMexico,
        [EnumMember(Value = "Pakistan Standard Time")]
        PakistanStandardTime,
        [EnumMember(Value = "Paraguay Standard Time")]
        ParaguayStandardTime,
        [EnumMember(Value = "Romance Standard Time")]
        RomanceStandardTime,
        [EnumMember(Value = "Russia Time Zone 10")]
        RussiaTimeZone10,
        [EnumMember(Value = "Russia Time Zone 11")]
        RussiaTimeZone11,
        [EnumMember(Value = "Russia Time Zone 3")]
        RussiaTimeZone3,
        [EnumMember(Value = "Russian Standard Time")]
        RussianStandardTime,
        [EnumMember(Value = "SA Eastern Standard Time")]
        SAEasternStandardTime,
        [EnumMember(Value = "SA Pacific Standard Time")]
        SAPacificStandardTime,
        [EnumMember(Value = "SA Western Standard Time")]
        SAWesternStandardTime,
        [EnumMember(Value = "Saint Pierre Standard Time")]
        SaintPierreStandardTime,
        [EnumMember(Value = "Sakhalin Standard Time")]
        SakhalinStandardTime,
        [EnumMember(Value = "Samoa Standard Time")]
        SamoaStandardTime,
        [EnumMember(Value = "Sao Tome Standard Time")]
        SaoTomeStandardTime,
        [EnumMember(Value = "Saratov Standard Time")]
        SaratovStandardTime,
        [EnumMember(Value = "SE Asia Standard Time")]
        SEAsiaStandardTime,
        [EnumMember(Value = "Singapore Standard Time")]
        SingaporeStandardTime,
        [EnumMember(Value = "South Africa Standard Time")]
        SouthAfricaStandardTime,
        [EnumMember(Value = "Sri Lanka Standard Time")]
        SriLankaStandardTime,
        [EnumMember(Value = "Sudan Standard Time")]
        SudanStandardTime,
        [EnumMember(Value = "Syria Standard Time")]
        SyriaStandardTime,
        [EnumMember(Value = "Taipei Standard Time")]
        TaipeiStandardTime,
        [EnumMember(Value = "Tasmania Standard Time")]
        TasmaniaStandardTime,
        [EnumMember(Value = "Tocantins Standard Time")]
        TocantinsStandardTime,
        [EnumMember(Value = "Tokyo Standard Time")]
        TokyoStandardTime,
        [EnumMember(Value = "Tomsk Standard Time")]
        TomskStandardTime,
        [EnumMember(Value = "Tonga Standard Time")]
        TongaStandardTime,
        [EnumMember(Value = "Transbaikal Standard Time")]
        TransbaikalStandardTime,
        [EnumMember(Value = "Turkey Standard Time")]
        TurkeyStandardTime,
        [EnumMember(Value = "Turks And Caicos Standard Time")]
        TurksAndCaicosStandardTime,
        [EnumMember(Value = "Ulaanbaatar Standard Time")]
        UlaanbaatarStandardTime,
        [EnumMember(Value = "US Eastern Standard Time")]
        USEasternStandardTime,
        [EnumMember(Value = "US Mountain Standard Time")]
        USMountainStandardTime,
        UTC,
        [EnumMember(Value = "UTC+12")]
        UTC12,
        [EnumMember(Value = "UTC+13")]
        UTC13,
        [EnumMember(Value = "UTC-02")]
        UTC02,
        [EnumMember(Value = "UTC-08")]
        UTC08,
        [EnumMember(Value = "UTC-09")]
        UTC09,
        [EnumMember(Value = "UTC-11")]
        UTC11,
        [EnumMember(Value = "Venezuela Standard Time")]
        VenezuelaStandardTime,
        [EnumMember(Value = "Vladivostok Standard Time")]
        VladivostokStandardTime,
        [EnumMember(Value = "W. Australia Standard Time")]
        WAustraliaStandardTime,
        [EnumMember(Value = "W. Central Africa Standard Time")]
        WCentralAfricaStandardTime,
        [EnumMember(Value = "W. Europe Standard Time")]
        WEuropeStandardTime,
        [EnumMember(Value = "W. Mongolia Standard Time")]
        WMongoliaStandardTime,
        [EnumMember(Value = "West Asia Standard Time")]
        WestAsiaStandardTime,
        [EnumMember(Value = "West Bank Standard Time")]
        WestBankStandardTime,
        [EnumMember(Value = "West Pacific Standard Time")]
        WestPacificStandardTime,
        [EnumMember(Value = "Yakutsk Standard Time")]
        YakutskStandardTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyroomsourceInput
    {
        Unknown,
        Exchange
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum parametersmethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lms365;

    public partial class WorkflowManagedActions
    {
        public Lms365Actions Lms365(string connectionId) => new Lms365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Lms365Triggers Lms365(string connectionId) => new Lms365Triggers(connectionId);
    }
}
