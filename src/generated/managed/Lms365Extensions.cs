//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lms365
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Lms365Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildApproveEnrollmentRequest))]
        public IWorkflowAction ApproveEnrollmentRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApproveEnrollmentRequest(WorkflowExpression<string> id, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})/Approve", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildEnrollUserToCourse))]
        public IBodyWorkflowAction<EnrollUserToCourseResponse> EnrollUserToCourse([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<string> bodyuserLoginName, [WorkflowExpression] Func<string> bodycourseSessionId = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnrollUserToCourseResponse> __BuildEnrollUserToCourse(WorkflowExpression<string> courseId, WorkflowExpression<string> bodyuserLoginName, WorkflowExpression<string> bodycourseSessionId = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(courseId, nameof(courseId), required: true);
            WorkflowExpression.Validate(bodyuserLoginName, nameof(bodyuserLoginName), required: true);
            WorkflowExpression.Validate(bodycourseSessionId, nameof(bodycourseSessionId), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<EnrollUserToCourseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Courses({0})/Enroll", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userLoginName"] = ExpressionConverter.ConvertO(bodyuserLoginName);
                if (bodycourseSessionId != null)
                {
                    body["courseSessionId"] = ExpressionConverter.ConvertO(bodycourseSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EnrollUserToCourseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildRejectEnrollmentRequest))]
        public IWorkflowAction RejectEnrollmentRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRejectEnrollmentRequest(WorkflowExpression<string> id, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})/Reject", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetCourseCategories))]
        public IBodyWorkflowAction<GetCourseCategoriesResponse> GetCourseCategories([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCourseCategoriesResponse> __BuildGetCourseCategories(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseCategoriesResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetCourseCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCourseCategory))]
        public IBodyWorkflowAction<CreateCourseCategoryResponse> CreateCourseCategory([WorkflowExpression] Func<string> bodycategoryName, [WorkflowExpression] Func<string> bodycourseCatalogId, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCourseCategoryResponse> __BuildCreateCourseCategory(WorkflowExpression<string> bodycategoryName, WorkflowExpression<string> bodycourseCatalogId, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(bodycategoryName, nameof(bodycategoryName), required: true);
            WorkflowExpression.Validate(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseCategoryResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(bodycategoryName);
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(bodycourseCatalogId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCourse))]
        public IBodyWorkflowAction<CreateCourseResponse> CreateCourse([WorkflowExpression] Func<string> bodycourseCatalogId, [WorkflowExpression] Func<bodycoursetypeInput> bodycoursetype, [WorkflowExpression] Func<string> bodytrainingTitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodyculture, [WorkflowExpression] Func<string> bodyuICulture, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bodycategoriesInputItem[]> bodycategories = null, [WorkflowExpression] Func<bodytagsInputItem[]> bodytags = null, [WorkflowExpression] Func<bodyenrollmentFlowInput> bodyenrollmentFlow = null, [WorkflowExpression] Func<string> bodysiteTemplate = null, [WorkflowExpression] Func<string[]> bodylearningModules = null, [WorkflowExpression] Func<string[]> bodyquizzes = null, [WorkflowExpression] Func<bool> bodyautoResolveUrlConflict = null, [WorkflowExpression] Func<string> bodycourseLayoutId = null, [WorkflowExpression] Func<bodycourseSessionEnrollmentTypeInput> bodycourseSessionEnrollmentType = null, [WorkflowExpression] Func<string[]> bodyteacherLogins = null, [WorkflowExpression] Func<string[]> bodytrainerLogins = null, [WorkflowExpression] Func<string> bodycertificateTemplateId = null, [WorkflowExpression] Func<string> bodycourseID = null, [WorkflowExpression] Func<string> bodyduration = null, [WorkflowExpression] Func<string> bodylongDescription = null, [WorkflowExpression] Func<bool> bodypublishingSettingsisEnabled = null, [WorkflowExpression] Func<string> bodypublishingSettingsstartDate = null, [WorkflowExpression] Func<string> bodypublishingSettingsendDate = null, [WorkflowExpression] Func<bool> bodyexpirySettingsisEnabled = null, [WorkflowExpression] Func<string> bodyexpirySettingsfixedDate = null, [WorkflowExpression] Func<string> bodyexpirySettingsdaysAfterCompletion = null, [WorkflowExpression] Func<bool> bodydueDateSettingsisEnabled = null, [WorkflowExpression] Func<string> bodydueDateSettingsfixedDate = null, [WorkflowExpression] Func<string> bodydueDateSettingsdaysAfterEnrollment = null, [WorkflowExpression] Func<bool> bodyshowInCatalog = null, [WorkflowExpression] Func<double> bodycontinuingEducationUnits = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<string> bodyfailedCourseId = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCourseResponse> __BuildCreateCourse(WorkflowExpression<string> bodycourseCatalogId, WorkflowExpression<bodycoursetypeInput> bodycoursetype, WorkflowExpression<string> bodytrainingTitle, WorkflowExpression<string> bodydescription, WorkflowExpression<string> bodyculture, WorkflowExpression<string> bodyuICulture, WorkflowExpression<string> bodyurl, WorkflowExpression<bodycategoriesInputItem[]> bodycategories = null, WorkflowExpression<bodytagsInputItem[]> bodytags = null, WorkflowExpression<bodyenrollmentFlowInput> bodyenrollmentFlow = null, WorkflowExpression<string> bodysiteTemplate = null, WorkflowExpression<string[]> bodylearningModules = null, WorkflowExpression<string[]> bodyquizzes = null, WorkflowExpression<bool> bodyautoResolveUrlConflict = null, WorkflowExpression<string> bodycourseLayoutId = null, WorkflowExpression<bodycourseSessionEnrollmentTypeInput> bodycourseSessionEnrollmentType = null, WorkflowExpression<string[]> bodyteacherLogins = null, WorkflowExpression<string[]> bodytrainerLogins = null, WorkflowExpression<string> bodycertificateTemplateId = null, WorkflowExpression<string> bodycourseID = null, WorkflowExpression<string> bodyduration = null, WorkflowExpression<string> bodylongDescription = null, WorkflowExpression<bool> bodypublishingSettingsisEnabled = null, WorkflowExpression<string> bodypublishingSettingsstartDate = null, WorkflowExpression<string> bodypublishingSettingsendDate = null, WorkflowExpression<bool> bodyexpirySettingsisEnabled = null, WorkflowExpression<string> bodyexpirySettingsfixedDate = null, WorkflowExpression<string> bodyexpirySettingsdaysAfterCompletion = null, WorkflowExpression<bool> bodydueDateSettingsisEnabled = null, WorkflowExpression<string> bodydueDateSettingsfixedDate = null, WorkflowExpression<string> bodydueDateSettingsdaysAfterEnrollment = null, WorkflowExpression<bool> bodyshowInCatalog = null, WorkflowExpression<double> bodycontinuingEducationUnits = null, WorkflowExpression<string> bodyimageUrl = null, WorkflowExpression<string> bodyfailedCourseId = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            WorkflowExpression.Validate(bodycoursetype, nameof(bodycoursetype), required: true);
            WorkflowExpression.Validate(bodytrainingTitle, nameof(bodytrainingTitle), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodyculture, nameof(bodyculture), required: true);
            WorkflowExpression.Validate(bodyuICulture, nameof(bodyuICulture), required: true);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodyenrollmentFlow, nameof(bodyenrollmentFlow), required: false);
            WorkflowExpression.Validate(bodysiteTemplate, nameof(bodysiteTemplate), required: false);
            WorkflowExpression.Validate(bodylearningModules, nameof(bodylearningModules), required: false);
            WorkflowExpression.Validate(bodyquizzes, nameof(bodyquizzes), required: false);
            WorkflowExpression.Validate(bodyautoResolveUrlConflict, nameof(bodyautoResolveUrlConflict), required: false);
            WorkflowExpression.Validate(bodycourseLayoutId, nameof(bodycourseLayoutId), required: false);
            WorkflowExpression.Validate(bodycourseSessionEnrollmentType, nameof(bodycourseSessionEnrollmentType), required: false);
            WorkflowExpression.Validate(bodyteacherLogins, nameof(bodyteacherLogins), required: false);
            WorkflowExpression.Validate(bodytrainerLogins, nameof(bodytrainerLogins), required: false);
            WorkflowExpression.Validate(bodycertificateTemplateId, nameof(bodycertificateTemplateId), required: false);
            WorkflowExpression.Validate(bodycourseID, nameof(bodycourseID), required: false);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            WorkflowExpression.Validate(bodylongDescription, nameof(bodylongDescription), required: false);
            WorkflowExpression.Validate(bodypublishingSettingsisEnabled, nameof(bodypublishingSettingsisEnabled), required: false);
            WorkflowExpression.Validate(bodypublishingSettingsstartDate, nameof(bodypublishingSettingsstartDate), required: false);
            WorkflowExpression.Validate(bodypublishingSettingsendDate, nameof(bodypublishingSettingsendDate), required: false);
            WorkflowExpression.Validate(bodyexpirySettingsisEnabled, nameof(bodyexpirySettingsisEnabled), required: false);
            WorkflowExpression.Validate(bodyexpirySettingsfixedDate, nameof(bodyexpirySettingsfixedDate), required: false);
            WorkflowExpression.Validate(bodyexpirySettingsdaysAfterCompletion, nameof(bodyexpirySettingsdaysAfterCompletion), required: false);
            WorkflowExpression.Validate(bodydueDateSettingsisEnabled, nameof(bodydueDateSettingsisEnabled), required: false);
            WorkflowExpression.Validate(bodydueDateSettingsfixedDate, nameof(bodydueDateSettingsfixedDate), required: false);
            WorkflowExpression.Validate(bodydueDateSettingsdaysAfterEnrollment, nameof(bodydueDateSettingsdaysAfterEnrollment), required: false);
            WorkflowExpression.Validate(bodyshowInCatalog, nameof(bodyshowInCatalog), required: false);
            WorkflowExpression.Validate(bodycontinuingEducationUnits, nameof(bodycontinuingEducationUnits), required: false);
            WorkflowExpression.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            WorkflowExpression.Validate(bodyfailedCourseId, nameof(bodyfailedCourseId), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(bodycourseCatalogId);
                bodypropCount++;
                body["CourseType"] = ExpressionConverter.ConvertO(bodycoursetype);
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytrainingTitle);
                bodypropCount++;
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
                body["Culture"] = ExpressionConverter.ConvertO(bodyculture);
                bodypropCount++;
                body["UICulture"] = ExpressionConverter.ConvertO(bodyuICulture);
                if (bodycategories != null)
                {
                    body["Categories"] = ExpressionConverter.ConvertO(bodycategories);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["Tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodyenrollmentFlow != null)
                {
                    body["EnrollmentFlow"] = ExpressionConverter.ConvertO(bodyenrollmentFlow);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodysiteTemplate != null)
                {
                    body["SiteTemplate"] = ExpressionConverter.ConvertO(bodysiteTemplate);
                    bodypropCount++;
                }

                if (bodylearningModules != null)
                {
                    body["LearningModules"] = ExpressionConverter.ConvertO(bodylearningModules);
                    bodypropCount++;
                }

                if (bodyquizzes != null)
                {
                    body["Quizzes"] = ExpressionConverter.ConvertO(bodyquizzes);
                    bodypropCount++;
                }

                if (bodyautoResolveUrlConflict != null)
                {
                    body["AutoResolveUrlConflict"] = ExpressionConverter.ConvertO(bodyautoResolveUrlConflict);
                    bodypropCount++;
                }

                if (bodycourseLayoutId != null)
                {
                    body["CourseLayoutId"] = ExpressionConverter.ConvertO(bodycourseLayoutId);
                    bodypropCount++;
                }

                if (bodycourseSessionEnrollmentType != null)
                {
                    body["CourseSessionEnrollmentType"] = ExpressionConverter.ConvertO(bodycourseSessionEnrollmentType);
                    bodypropCount++;
                }

                if (bodyteacherLogins != null)
                {
                    body["TeacherLogins"] = ExpressionConverter.ConvertO(bodyteacherLogins);
                    bodypropCount++;
                }

                if (bodytrainerLogins != null)
                {
                    body["TrainerLogins"] = ExpressionConverter.ConvertO(bodytrainerLogins);
                    bodypropCount++;
                }

                if (bodycertificateTemplateId != null)
                {
                    body["CertificateTemplateId"] = ExpressionConverter.ConvertO(bodycertificateTemplateId);
                    bodypropCount++;
                }

                if (bodycourseID != null)
                {
                    body["CourseID"] = ExpressionConverter.ConvertO(bodycourseID);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["Duration"] = ExpressionConverter.ConvertO(bodyduration);
                    bodypropCount++;
                }

                if (bodylongDescription != null)
                {
                    body["LongDescription"] = ExpressionConverter.ConvertO(bodylongDescription);
                    bodypropCount++;
                }

                var publishingSettingsObject = new JObject();
                var publishingSettingsObjectpropCount = 0;
                if (bodypublishingSettingsisEnabled != null)
                {
                    if (bodypublishingSettingsisEnabled != null)
                    {
                        publishingSettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(bodypublishingSettingsisEnabled);
                        publishingSettingsObjectpropCount++;
                    }

                    publishingSettingsObjectpropCount++;
                }
                else
                {
                    publishingSettingsObject["IsEnabled"] = true;
                    publishingSettingsObjectpropCount++;
                }

                if (bodypublishingSettingsstartDate != null)
                {
                    publishingSettingsObject["StartDate"] = ExpressionConverter.ConvertO(bodypublishingSettingsstartDate);
                    publishingSettingsObjectpropCount++;
                }

                if (bodypublishingSettingsendDate != null)
                {
                    publishingSettingsObject["EndDate"] = ExpressionConverter.ConvertO(bodypublishingSettingsendDate);
                    publishingSettingsObjectpropCount++;
                }

                if (publishingSettingsObjectpropCount > 0)
                {
                    body["PublishingSettings"] = publishingSettingsObject;
                    bodypropCount++;
                }

                var expirySettingsObject = new JObject();
                var expirySettingsObjectpropCount = 0;
                if (bodyexpirySettingsisEnabled != null)
                {
                    expirySettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(bodyexpirySettingsisEnabled);
                    expirySettingsObjectpropCount++;
                }

                if (bodyexpirySettingsfixedDate != null)
                {
                    expirySettingsObject["FixedDate"] = ExpressionConverter.ConvertO(bodyexpirySettingsfixedDate);
                    expirySettingsObjectpropCount++;
                }

                if (bodyexpirySettingsdaysAfterCompletion != null)
                {
                    expirySettingsObject["DaysAfterCompletion"] = ExpressionConverter.ConvertO(bodyexpirySettingsdaysAfterCompletion);
                    expirySettingsObjectpropCount++;
                }

                if (expirySettingsObjectpropCount > 0)
                {
                    body["ExpirySettings"] = expirySettingsObject;
                    bodypropCount++;
                }

                var dueDateSettingsObject = new JObject();
                var dueDateSettingsObjectpropCount = 0;
                if (bodydueDateSettingsisEnabled != null)
                {
                    dueDateSettingsObject["IsEnabled"] = ExpressionConverter.ConvertO(bodydueDateSettingsisEnabled);
                    dueDateSettingsObjectpropCount++;
                }

                if (bodydueDateSettingsfixedDate != null)
                {
                    dueDateSettingsObject["FixedDate"] = ExpressionConverter.ConvertO(bodydueDateSettingsfixedDate);
                    dueDateSettingsObjectpropCount++;
                }

                if (bodydueDateSettingsdaysAfterEnrollment != null)
                {
                    dueDateSettingsObject["DaysAfterEnrollment"] = ExpressionConverter.ConvertO(bodydueDateSettingsdaysAfterEnrollment);
                    dueDateSettingsObjectpropCount++;
                }

                if (dueDateSettingsObjectpropCount > 0)
                {
                    body["DueDateSettings"] = dueDateSettingsObject;
                    bodypropCount++;
                }

                if (bodyshowInCatalog != null)
                {
                    body["ShowInCatalog"] = ExpressionConverter.ConvertO(bodyshowInCatalog);
                    bodypropCount++;
                }

                if (bodycontinuingEducationUnits != null)
                {
                    body["CEU"] = ExpressionConverter.ConvertO(bodycontinuingEducationUnits);
                    bodypropCount++;
                }

                if (bodyimageUrl != null)
                {
                    body["ImageUrl"] = ExpressionConverter.ConvertO(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodyfailedCourseId != null)
                {
                    body["FailedCourseId"] = ExpressionConverter.ConvertO(bodyfailedCourseId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetCourseInfo))]
        public IBodyWorkflowAction<GetCourseInfoResponse> GetCourseInfo([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCourseInfoResponse> __BuildGetCourseInfo(WorkflowExpression<string> courseId, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(courseId, nameof(courseId), required: true);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCourseInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Courses({0})", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("DueDate,Publishing,CertificateExpiry,SharepointWeb($select=Url),Categories,Tags,CourseSessions,ProvisioningProgress,Trainers");
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                return new ApiConnectionAction<GetCourseInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteEnrollmentById))]
        public IWorkflowAction CompleteEnrollmentById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteEnrollmentById(WorkflowExpression<string> id, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})/Complete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildRetakeEnrollmentById))]
        public IWorkflowAction RetakeEnrollmentById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycourseSessionId = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRetakeEnrollmentById(WorkflowExpression<string> id, WorkflowExpression<string> bodycourseSessionId = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycourseSessionId, nameof(bodycourseSessionId), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})/Retake", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycourseSessionId != null)
                {
                    body["courseSessionId"] = ExpressionConverter.ConvertO(bodycourseSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetCourseTags))]
        public IBodyWorkflowAction<GetCourseTagsResponse> GetCourseTags([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCourseTagsResponse> __BuildGetCourseTags(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseTagsResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetCourseTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCourseTag))]
        public IBodyWorkflowAction<CreateCourseTagResponse> CreateCourseTag([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycourseCatalogId, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCourseTagResponse> __BuildCreateCourseTag(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycourseCatalogId, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycourseCatalogId, nameof(bodycourseCatalogId), required: true);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseTagResponse>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["CourseCatalogId"] = ExpressionConverter.ConvertO(bodycourseCatalogId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCourseTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetCourseProvisioningStatus))]
        public IBodyWorkflowAction<GetCourseProvisioningStatusResponse> GetCourseProvisioningStatus([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCourseProvisioningStatusResponse> __BuildGetCourseProvisioningStatus(WorkflowExpression<string> expand = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetCourseProvisioningStatusResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Courses/IncludeNotCreated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("ProvisioningProgress,SharepointWeb");
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["$select"] = Convert.ToString("Id");
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetCourseProvisioningStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetCoursesFromCatalog))]
        public IBodyWorkflowAction<GetCoursesFromCatalogResponse> GetCoursesFromCatalog([WorkflowExpression] Func<string> courseCatalogId, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCoursesFromCatalogResponse> __BuildGetCoursesFromCatalog(WorkflowExpression<string> courseCatalogId, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(courseCatalogId, nameof(courseCatalogId), required: true);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCoursesFromCatalogResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/CourseCatalogs({0})", ExpressionConverter.ConvertWithUrlEncoding(courseCatalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("Courses($expand=SharepointWeb)");
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                return new ApiConnectionAction<GetCoursesFromCatalogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnrollmentById))]
        public IBodyWorkflowAction<GetEnrollmentByIdResponse> GetEnrollmentById([WorkflowExpression] Func<string> enrollmentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEnrollmentByIdResponse> __BuildGetEnrollmentById(WorkflowExpression<string> enrollmentId)
        {
            WorkflowExpression.Validate(enrollmentId, nameof(enrollmentId), required: true);
            return new DeferredBodyAction<GetEnrollmentByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})", ExpressionConverter.ConvertWithUrlEncoding(enrollmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnrollmentByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCancelEnrollment))]
        public IWorkflowAction CancelEnrollment([WorkflowExpression] Func<string> enrollmentId, [WorkflowExpression] Func<string> bodycancellationMessage = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelEnrollment(WorkflowExpression<string> enrollmentId, WorkflowExpression<string> bodycancellationMessage = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(enrollmentId, nameof(enrollmentId), required: true);
            WorkflowExpression.Validate(bodycancellationMessage, nameof(bodycancellationMessage), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Enrollments({0})/Cancel", ExpressionConverter.ConvertWithUrlEncoding(enrollmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycancellationMessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodycancellationMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildGetUsers))]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUsersResponse> __BuildGetUsers(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetUsersResponse>(() =>
            {
                var apiCallPath = "/odata/v2/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = Convert.ToString("Email eq '{UserEmail}'");
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCourseSession))]
        public IWorkflowAction CreateCourseSession([WorkflowExpression] Func<string> courseId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<bodytimeZoneInput> bodytimeZone, [WorkflowExpression] Func<string> bodyenrollmentDeadline = null, [WorkflowExpression] Func<string> bodyroomemailAddress = null, [WorkflowExpression] Func<string> bodyroomtitle = null, [WorkflowExpression] Func<string> bodyroomlocation = null, [WorkflowExpression] Func<bodyroomsourceInput> bodyroomsource = null, [WorkflowExpression] Func<string> bodymeetingUrl = null, [WorkflowExpression] Func<string> bodymaxAttendees = null, [WorkflowExpression] Func<string> lMS365UserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCourseSession(WorkflowExpression<string> courseId, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyendDate, WorkflowExpression<bodytimeZoneInput> bodytimeZone, WorkflowExpression<string> bodyenrollmentDeadline = null, WorkflowExpression<string> bodyroomemailAddress = null, WorkflowExpression<string> bodyroomtitle = null, WorkflowExpression<string> bodyroomlocation = null, WorkflowExpression<bodyroomsourceInput> bodyroomsource = null, WorkflowExpression<string> bodymeetingUrl = null, WorkflowExpression<string> bodymaxAttendees = null, WorkflowExpression<string> lMS365UserId = null)
        {
            WorkflowExpression.Validate(courseId, nameof(courseId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: true);
            WorkflowExpression.Validate(bodyenrollmentDeadline, nameof(bodyenrollmentDeadline), required: false);
            WorkflowExpression.Validate(bodyroomemailAddress, nameof(bodyroomemailAddress), required: false);
            WorkflowExpression.Validate(bodyroomtitle, nameof(bodyroomtitle), required: false);
            WorkflowExpression.Validate(bodyroomlocation, nameof(bodyroomlocation), required: false);
            WorkflowExpression.Validate(bodyroomsource, nameof(bodyroomsource), required: false);
            WorkflowExpression.Validate(bodymeetingUrl, nameof(bodymeetingUrl), required: false);
            WorkflowExpression.Validate(bodymaxAttendees, nameof(bodymaxAttendees), required: false);
            WorkflowExpression.Validate(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/v2/Courses({0})/CourseSessions", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(lMS365UserId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["StartDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
                body["EndDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
                body["TimeZone"] = ExpressionConverter.ConvertO(bodytimeZone);
                if (bodyenrollmentDeadline != null)
                {
                    body["EnrollmentDeadline"] = ExpressionConverter.ConvertO(bodyenrollmentDeadline);
                    bodypropCount++;
                }

                var roomObject = new JObject();
                var roomObjectpropCount = 0;
                if (bodyroomemailAddress != null)
                {
                    roomObject["EmailAddress"] = ExpressionConverter.ConvertO(bodyroomemailAddress);
                    roomObjectpropCount++;
                }

                if (bodyroomtitle != null)
                {
                    roomObject["Title"] = ExpressionConverter.ConvertO(bodyroomtitle);
                    roomObjectpropCount++;
                }

                if (bodyroomlocation != null)
                {
                    roomObject["Location"] = ExpressionConverter.ConvertO(bodyroomlocation);
                    roomObjectpropCount++;
                }

                if (bodyroomsource != null)
                {
                    if (bodyroomsource != null)
                    {
                        roomObject["Source"] = ExpressionConverter.ConvertO(bodyroomsource);
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

                if (bodymeetingUrl != null)
                {
                    body["MeetingUrl"] = ExpressionConverter.ConvertO(bodymeetingUrl);
                    bodypropCount++;
                }

                if (bodymaxAttendees != null)
                {
                    body["MaxAttendees"] = ExpressionConverter.ConvertO(bodymaxAttendees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildFileUpload))]
        public IWorkflowAction FileUpload([WorkflowExpression] Func<string> fileUploadUrl, [WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileUpload(WorkflowExpression<string> fileUploadUrl, WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(fileUploadUrl, nameof(fileUploadUrl), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileUploadUrl, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IWorkflowAction HttpRequest([WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersuri, [WorkflowExpression] Func<string> parametersbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHttpRequest(WorkflowExpression<parametersmethodInput> parametersmethod, WorkflowExpression<string> parametersuri, WorkflowExpression<string> parametersbody = null)
        {
            WorkflowExpression.Validate(parametersmethod, nameof(parametersmethod), required: true);
            WorkflowExpression.Validate(parametersuri, nameof(parametersuri), required: true);
            WorkflowExpression.Validate(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = ExpressionConverter.ConvertO(parametersmethod);
                parameterspropCount++;
                parameters["uri"] = ExpressionConverter.ConvertO(parametersuri);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["body"] = ExpressionConverter.ConvertO(parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction(callPayload);
            });
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

    public enum bodyenrollmentFlowInput
    {
        AutomaticApproval,
        LineManagerApproval,
        LMSAdministratorsApproval,
        CustomApproval,
        ExternalWebhookApproval
    }

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

    public enum bodyroomsourceInput
    {
        Unknown,
        Exchange
    }

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