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
        public IWorkflowAction<ApiConnectionActionConfiguration> ApproveEnrollmentRequest(Expression<Func<string>> id, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Approve", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<EnrollUserToCourseResponse, ApiConnectionActionConfiguration> EnrollUserToCourse(Expression<Func<string>> courseId, Expression<Func<EnrollUserToCourseInput>> body, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<EnrollUserToCourseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})/Enroll", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EnrollUserToCourseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RejectEnrollmentRequest(Expression<Func<string>> id, Expression<Func<RejectEnrollmentRequestInput>> body = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Reject", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseCategoriesResponse, ApiConnectionActionConfiguration> GetCourseCategories(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetCourseCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseCategoryResponse, ApiConnectionActionConfiguration> CreateCourseCategory(Expression<Func<CreateCourseCategoryInput>> body, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/CourseCategories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCourseCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseResponse, ApiConnectionActionConfiguration> CreateCourse(Expression<Func<CreateCourseInput>> body, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/Courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCourseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseInfoResponse, ApiConnectionActionConfiguration> GetCourseInfo(Expression<Func<string>> courseId, Expression<Func<string>> expand = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCourseInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("DueDate,Publishing,CertificateExpiry,SharepointWeb($select=Url),Categories,Tags,CourseSessions,ProvisioningProgress,Trainers");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetCourseInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompleteEnrollmentById(Expression<Func<string>> id, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Complete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetakeEnrollmentById(Expression<Func<string>> id, Expression<Func<RetakeEnrollmentByIdInput>> body = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Retake", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseTagsResponse, ApiConnectionActionConfiguration> GetCourseTags(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetCourseTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetCourseTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<CreateCourseTagResponse, ApiConnectionActionConfiguration> CreateCourseTag(Expression<Func<CreateCourseTagInput>> body, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredBodyAction<CreateCourseTagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/CourseTags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCourseTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCourseProvisioningStatusResponse, ApiConnectionActionConfiguration> GetCourseProvisioningStatus(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetCourseProvisioningStatusResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetCoursesFromCatalogResponse, ApiConnectionActionConfiguration> GetCoursesFromCatalog(Expression<Func<string>> courseCatalogId, Expression<Func<string>> expand = null)
        {
            var __workflow_courseCatalogId = WorkflowExpression.Compile(courseCatalogId, nameof(courseCatalogId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetCoursesFromCatalogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/CourseCatalogs({0})", __workflow_courseCatalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("Courses($expand=SharepointWeb)");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetCoursesFromCatalogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetEnrollmentByIdResponse, ApiConnectionActionConfiguration> GetEnrollmentById(Expression<Func<string>> enrollmentId)
        {
            var __workflow_enrollmentId = WorkflowExpression.Compile(enrollmentId, nameof(enrollmentId), required: true);
            return new DeferredBodyAction<GetEnrollmentByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})", __workflow_enrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnrollmentByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CancelEnrollment(Expression<Func<string>> enrollmentId, Expression<Func<CancelEnrollmentInput>> body = null, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_enrollmentId = WorkflowExpression.Compile(enrollmentId, nameof(enrollmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Enrollments({0})/Cancel", __workflow_enrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IBodyWorkflowAction<GetUsersResponse, ApiConnectionActionConfiguration> GetUsers(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/v2/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = Convert.ToString("Email eq '{UserEmail}'");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateCourseSession(Expression<Func<string>> courseId, Expression<Func<CreateCourseSessionInput>> body, Expression<Func<string>> lMS365UserId = null)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_lMS365UserId = WorkflowExpression.Compile(lMS365UserId, nameof(lMS365UserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/v2/Courses({0})/CourseSessions", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lMS365UserId != null)
                    callPayload.Headers["LMS365-User-Id"] = ExpressionConverter.Convert(__workflow_lMS365UserId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lms365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HttpRequest(Expression<Func<HttpRequestV2Input>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Lms365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> EnrollmentApprovalRequest(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/EnrollmentApprovalRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new EnrollmentApprovalRequestInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseEnrollment(Expression<Func<CourseEnrollmentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseEnrollment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseUnenrollment(Expression<Func<CourseUnenrollmentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseUnenrollment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseStarted(Expression<Func<CourseStartedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseStarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseCompleted(Expression<Func<CourseCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CoursePublished(Expression<Func<CoursePublishedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CoursePublished";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseUnpublished(Expression<Func<CourseUnpublishedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseUnpublished";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UserCreated(Expression<Func<UserCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/UserCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UserDeleted(Expression<Func<UserDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/UserDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseCreated(Expression<Func<CourseCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CourseDeleted(Expression<Func<CourseDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe/CourseDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    public class EnrollUserToCourseInput
    {
        [JsonProperty("userLoginName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserLoginName { get; set; }

        [JsonProperty("courseSessionId")]
        public string CourseSessionId { get; set; }
    }

    public class RejectEnrollmentRequestInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class CreateCourseCategoryInput
    {
        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CourseCatalogId { get; set; }
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

        [JsonProperty("CourseID")]
        public string CourseId { get; set; }
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

    public class CreateCourseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CourseCatalogId { get; set; }

        [JsonProperty("CourseType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCourseInputCoursetypeType Coursetype { get; set; }

        [JsonProperty("Title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TrainingTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UICulture { get; set; }
        public CreateCourseInputCategoriesTypeItem[] Categories { get; set; }
        public CreateCourseInputTagsTypeItem[] Tags { get; set; }
        public CreateCourseInputEnrollmentFlowType? EnrollmentFlow { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
        public string SiteTemplate { get; set; }
        public string[] LearningModules { get; set; }
        public string[] Quizzes { get; set; }
        public bool? AutoResolveUrlConflict { get; set; }
        public string CourseLayoutId { get; set; }
        public CreateCourseInputCourseSessionEnrollmentTypeType? CourseSessionEnrollmentType { get; set; }
        public string[] TeacherLogins { get; set; }
        public string[] TrainerLogins { get; set; }
        public string CertificateTemplateId { get; set; }

        [JsonProperty("CourseID")]
        public string CourseId { get; set; }
        public string Duration { get; set; }
        public string LongDescription { get; set; }
        public CreateCourseInputPublishingSettingsType PublishingSettings { get; set; }
        public CreateCourseInputExpirySettingsType ExpirySettings { get; set; }
        public CreateCourseInputDueDateSettingsType DueDateSettings { get; set; }
        public bool? ShowInCatalog { get; set; }

        [JsonProperty("CEU")]
        public double? ContinuingEducationUnits { get; set; }
        public string ImageUrl { get; set; }
        public string FailedCourseId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCourseInputCoursetypeType
    {
        ELearning,
        ClassRoom,
        Webinar,
        TrainingPlan
    }

    public class CreateCourseInputCategoriesTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? IsNew { get; set; }
        public string ParentCategoryId { get; set; }
    }

    public class CreateCourseInputTagsTypeItem
    {
        public string Id { get; set; }

        [JsonProperty("TagName")]
        public string Name { get; set; }
        public bool? IsNew { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCourseInputEnrollmentFlowType
    {
        AutomaticApproval,
        LineManagerApproval,
        LMSAdministratorsApproval,
        CustomApproval,
        ExternalWebhookApproval
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCourseInputCourseSessionEnrollmentTypeType
    {
        EnrollToSingle,
        EnrollToAll,
        EnrollToMultiple
    }

    public class CreateCourseInputPublishingSettingsType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsEnabled { get; set; } = true;
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class CreateCourseInputExpirySettingsType
    {
        public bool? IsEnabled { get; set; }
        public string FixedDate { get; set; }
        public string DaysAfterCompletion { get; set; }
    }

    public class CreateCourseInputDueDateSettingsType
    {
        public bool? IsEnabled { get; set; }
        public string FixedDate { get; set; }
        public string DaysAfterEnrollment { get; set; }
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

        [JsonProperty("CourseID")]
        public string CourseId { get; set; }
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

    public class RetakeEnrollmentByIdInput
    {
        [JsonProperty("courseSessionId")]
        public string CourseSessionId { get; set; }
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

    public class CreateCourseTagInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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

        [JsonProperty("CourseID")]
        public string CourseId { get; set; }
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

    public class CancelEnrollmentInput
    {
        [JsonProperty("message")]
        public string CancellationMessage { get; set; }
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

    public class CreateCourseSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCourseSessionInputTimeZoneType TimeZone { get; set; }
        public string EnrollmentDeadline { get; set; }
        public CreateCourseSessionInputRoomType Room { get; set; }
        public string MeetingUrl { get; set; }
        public string MaxAttendees { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCourseSessionInputTimeZoneType
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

    public class CreateCourseSessionInputRoomType
    {
        public string EmailAddress { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCourseSessionInputRoomTypeSourceType? Source { get; set; } = CreateCourseSessionInputRoomTypeSourceType.Unknown;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCourseSessionInputRoomTypeSourceType
    {
        Unknown,
        Exchange
    }

    public class HttpRequestV2Input
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public HttpRequestV2InputMethodType Method { get; set; } = HttpRequestV2InputMethodType.GET;

        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Uri { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HttpRequestV2InputMethodType
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }

    public class EnrollmentApprovalRequestInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseEnrollmentInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseUnenrollmentInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseStartedInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseCompletedInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CoursePublishedInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseUnpublishedInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class UserCreatedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class UserDeletedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseCreatedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CourseDeletedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
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