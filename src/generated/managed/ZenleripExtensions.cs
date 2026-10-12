//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zenlerip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZenleripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserList))]
        public IBodyWorkflowAction<UserListResponse> UserList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> role = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserListResponse> __BuildUserList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> orderby = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<string> search = null, WorkflowExpression<int> role = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(role, nameof(role), required: false);
            return new DeferredBodyAction<UserListResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(15);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (role != null)
                    callPayload.Queries["role"] = ExpressionConverter.Convert(role);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUser))]
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<int> bodycommission, [WorkflowExpression] Func<string> bodyroles, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserPostResponse> __BuildUser(WorkflowExpression<string> bodyfirstName, WorkflowExpression<string> bodylastName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodypassword, WorkflowExpression<int> bodycommission, WorkflowExpression<string> bodyroles, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<int> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<int> bodygdprConsentStatus = null)
        {
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodycommission, nameof(bodycommission), required: true);
            WorkflowExpression.Validate(bodyroles, nameof(bodyroles), required: true);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<UserPostResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["commission"] = ExpressionConverter.ConvertO(bodycommission);
                bodypropCount++;
                body["roles"] = ExpressionConverter.ConvertO(bodyroles);
                if (bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserGet))]
        public IBodyWorkflowAction<UserGetResponse> UserGet([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserGetResponse> __BuildUserGet(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserDelete))]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDeleteResponse> __BuildUserDelete(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserPut))]
        public IBodyWorkflowAction<UserPutResponse> UserPut([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<int> bodycommission, [WorkflowExpression] Func<string> bodyroles, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserPutResponse> __BuildUserPut(WorkflowExpression<string> userId, WorkflowExpression<string> bodyfirstName, WorkflowExpression<string> bodylastName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodypassword, WorkflowExpression<int> bodycommission, WorkflowExpression<string> bodyroles, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<int> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<int> bodygdprConsentStatus = null)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodycommission, nameof(bodycommission), required: true);
            WorkflowExpression.Validate(bodyroles, nameof(bodyroles), required: true);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<UserPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["commission"] = ExpressionConverter.ConvertO(bodycommission);
                bodypropCount++;
                body["roles"] = ExpressionConverter.ConvertO(bodyroles);
                if (bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserEnroll))]
        public IBodyWorkflowAction<UserEnrollResponse> UserEnroll([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodycourseId, [WorkflowExpression] Func<string> bodyplanId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserEnrollResponse> __BuildUserEnroll(WorkflowExpression<string> userId, WorkflowExpression<string> bodycourseId, WorkflowExpression<string> bodyplanId = null)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            WorkflowExpression.Validate(bodycourseId, nameof(bodycourseId), required: true);
            WorkflowExpression.Validate(bodyplanId, nameof(bodyplanId), required: false);
            return new DeferredBodyAction<UserEnrollResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/enroll", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = ExpressionConverter.ConvertO(bodycourseId);
                if (bodyplanId != null)
                {
                    body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserEnrollResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildUserUnenroll))]
        public IBodyWorkflowAction<UserUnenrollResponse> UserUnenroll([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodycourseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserUnenrollResponse> __BuildUserUnenroll(WorkflowExpression<string> userId, WorkflowExpression<string> bodycourseId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            WorkflowExpression.Validate(bodycourseId, nameof(bodycourseId), required: true);
            return new DeferredBodyAction<UserUnenrollResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/unenroll", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = ExpressionConverter.ConvertO(bodycourseId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserUnenrollResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildCourseList))]
        public IBodyWorkflowAction<CourseListResponse> CourseList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> type = null, [WorkflowExpression] Func<int> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CourseListResponse> __BuildCourseList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> order = null, WorkflowExpression<string> search = null, WorkflowExpression<int> type = null, WorkflowExpression<int> status = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<CourseListResponse>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<CourseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildCourseGet))]
        public IBodyWorkflowAction<CourseGetResponse> CourseGet([WorkflowExpression] Func<string> courseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CourseGetResponse> __BuildCourseGet(WorkflowExpression<string> courseId)
        {
            WorkflowExpression.Validate(courseId, nameof(courseId), required: true);
            return new DeferredBodyAction<CourseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/courses/{0}", ExpressionConverter.ConvertWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildFunnelList))]
        public IBodyWorkflowAction<FunnelListResponse> FunnelList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FunnelListResponse> __BuildFunnelList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> order = null, WorkflowExpression<string> search = null, WorkflowExpression<int> status = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<FunnelListResponse>(() =>
            {
                var apiCallPath = "/funnels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<FunnelListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildFunnelEnrollment))]
        public IBodyWorkflowAction<FunnelEnrollmentResponse> FunnelEnrollment([WorkflowExpression] Func<string> funnelId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FunnelEnrollmentResponse> __BuildFunnelEnrollment(WorkflowExpression<string> funnelId)
        {
            WorkflowExpression.Validate(funnelId, nameof(funnelId), required: true);
            return new DeferredBodyAction<FunnelEnrollmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/funnels/enrollments/{0}", ExpressionConverter.ConvertWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FunnelEnrollmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildFunnelSubscribe))]
        public IBodyWorkflowAction<FunnelSubscribeResponse> FunnelSubscribe([WorkflowExpression] Func<string> funnelId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FunnelSubscribeResponse> __BuildFunnelSubscribe(WorkflowExpression<string> funnelId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<int> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<int> bodygdprConsentStatus = null)
        {
            WorkflowExpression.Validate(funnelId, nameof(funnelId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<FunnelSubscribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/funnels/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FunnelSubscribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildFunnelUnsubscribe))]
        public IBodyWorkflowAction<FunnelUnsubscribeResponse> FunnelUnsubscribe([WorkflowExpression] Func<string> funnelId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FunnelUnsubscribeResponse> __BuildFunnelUnsubscribe(WorkflowExpression<string> funnelId, WorkflowExpression<string> bodyemail = null)
        {
            WorkflowExpression.Validate(funnelId, nameof(funnelId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<FunnelUnsubscribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/funnels/{0}/unsubscribe", ExpressionConverter.ConvertWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FunnelUnsubscribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildClassList))]
        public IBodyWorkflowAction<ClassListResponse> ClassList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassListResponse> __BuildClassList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> orderby = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<string> search = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<ClassListResponse>(() =>
            {
                var apiCallPath = "/live-class/get-live-classes-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                return new ApiConnectionAction<ClassListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildClassRegister))]
        public IBodyWorkflowAction<ClassRegisterResponse> ClassRegister([WorkflowExpression] Func<string> liveclassId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassRegisterResponse> __BuildClassRegister(WorkflowExpression<string> liveclassId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodylastName = null)
        {
            WorkflowExpression.Validate(liveclassId, nameof(liveclassId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ClassRegisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/live-class/{0}/register", ExpressionConverter.ConvertWithUrlEncoding(liveclassId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassRegisterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildClassUnregister))]
        public IBodyWorkflowAction<ClassUnregisterResponse> ClassUnregister([WorkflowExpression] Func<string> liveclassId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassUnregisterResponse> __BuildClassUnregister(WorkflowExpression<string> liveclassId, WorkflowExpression<string> bodyemail = null)
        {
            WorkflowExpression.Validate(liveclassId, nameof(liveclassId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<ClassUnregisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/live-class/{0}/unregister", ExpressionConverter.ConvertWithUrlEncoding(liveclassId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassUnregisterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildWebinarList))]
        public IBodyWorkflowAction<WebinarListResponse> WebinarList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebinarListResponse> __BuildWebinarList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> orderby = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<string> search = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<WebinarListResponse>(() =>
            {
                var apiCallPath = "/live-webinar/get-live-webinars-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                return new ApiConnectionAction<WebinarListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildWebinarRegister))]
        public IBodyWorkflowAction<WebinarRegisterResponse> WebinarRegister([WorkflowExpression] Func<string> webinarId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebinarRegisterResponse> __BuildWebinarRegister(WorkflowExpression<string> webinarId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<int> bodyzipCode = null)
        {
            WorkflowExpression.Validate(webinarId, nameof(webinarId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            return new DeferredBodyAction<WebinarRegisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/register", ExpressionConverter.ConvertWithUrlEncoding(webinarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WebinarRegisterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildWebinarUnregister))]
        public IBodyWorkflowAction<WebinarUnregisterResponse> WebinarUnregister([WorkflowExpression] Func<string> webinarId, [WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebinarUnregisterResponse> __BuildWebinarUnregister(WorkflowExpression<string> webinarId, WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(webinarId, nameof(webinarId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<WebinarUnregisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/unregister", ExpressionConverter.ConvertWithUrlEncoding(webinarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WebinarUnregisterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportEnrollBrief))]
        public IBodyWorkflowAction<ReportEnrollBriefResponse> ReportEnrollBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> courseId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportEnrollBriefResponse> __BuildReportEnrollBrief(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> courseId = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(courseId, nameof(courseId), required: false);
            return new DeferredBodyAction<ReportEnrollBriefResponse>(() =>
            {
                var apiCallPath = "/reports/enrollments/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (courseId != null)
                    callPayload.Queries["course_id"] = ExpressionConverter.Convert(courseId);
                return new ApiConnectionAction<ReportEnrollBriefResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportEnrollDetail))]
        public IBodyWorkflowAction<ReportEnrollDetailResponse> ReportEnrollDetail([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> courseId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportEnrollDetailResponse> __BuildReportEnrollDetail(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> courseId = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(courseId, nameof(courseId), required: false);
            return new DeferredBodyAction<ReportEnrollDetailResponse>(() =>
            {
                var apiCallPath = "/reports/enrollments/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (courseId != null)
                    callPayload.Queries["course_id"] = ExpressionConverter.Convert(courseId);
                return new ApiConnectionAction<ReportEnrollDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportSalesBrief))]
        public IBodyWorkflowAction<ReportSalesBriefResponse> ReportSalesBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> groupby = null, [WorkflowExpression] Func<string> courseIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportSalesBriefResponse> __BuildReportSalesBrief(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> groupby = null, WorkflowExpression<string> courseIds = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(groupby, nameof(groupby), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            return new DeferredBodyAction<ReportSalesBriefResponse>(() =>
            {
                var apiCallPath = "/reports/sales/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (groupby != null)
                    callPayload.Queries["groupby"] = ExpressionConverter.Convert(groupby);
                if (courseIds != null)
                    callPayload.Queries["course_ids"] = ExpressionConverter.Convert(courseIds);
                return new ApiConnectionAction<ReportSalesBriefResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportSalesDetailed))]
        public IBodyWorkflowAction<ReportSalesDetailedResponse> ReportSalesDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<int> paymentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportSalesDetailedResponse> __BuildReportSalesDetailed(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> courseIds = null, WorkflowExpression<int> paymentType = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            WorkflowExpression.Validate(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportSalesDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/sales/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids"] = ExpressionConverter.Convert(courseIds);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(paymentType);
                return new ApiConnectionAction<ReportSalesDetailedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportProgressBrief))]
        public IBodyWorkflowAction<ReportProgressBriefResponse> ReportProgressBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportProgressBriefResponse> __BuildReportProgressBrief(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> courseIds = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            return new DeferredBodyAction<ReportProgressBriefResponse>(() =>
            {
                var apiCallPath = "/reports/course-progress/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(courseIds);
                return new ApiConnectionAction<ReportProgressBriefResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportProgressDetailed))]
        public IBodyWorkflowAction<ReportProgressDetailedResponse> ReportProgressDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> afV = null, [WorkflowExpression] Func<string> couponIs = null, [WorkflowExpression] Func<string> couponLike = null, [WorkflowExpression] Func<string> nameIs = null, [WorkflowExpression] Func<string> nameLike = null, [WorkflowExpression] Func<string> emailIs = null, [WorkflowExpression] Func<string> emailLike = null, [WorkflowExpression] Func<string> affiliateIs = null, [WorkflowExpression] Func<int> paymentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportProgressDetailedResponse> __BuildReportProgressDetailed(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> courseIds = null, WorkflowExpression<string> afV = null, WorkflowExpression<string> couponIs = null, WorkflowExpression<string> couponLike = null, WorkflowExpression<string> nameIs = null, WorkflowExpression<string> nameLike = null, WorkflowExpression<string> emailIs = null, WorkflowExpression<string> emailLike = null, WorkflowExpression<string> affiliateIs = null, WorkflowExpression<int> paymentType = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            WorkflowExpression.Validate(afV, nameof(afV), required: false);
            WorkflowExpression.Validate(couponIs, nameof(couponIs), required: false);
            WorkflowExpression.Validate(couponLike, nameof(couponLike), required: false);
            WorkflowExpression.Validate(nameIs, nameof(nameIs), required: false);
            WorkflowExpression.Validate(nameLike, nameof(nameLike), required: false);
            WorkflowExpression.Validate(emailIs, nameof(emailIs), required: false);
            WorkflowExpression.Validate(emailLike, nameof(emailLike), required: false);
            WorkflowExpression.Validate(affiliateIs, nameof(affiliateIs), required: false);
            WorkflowExpression.Validate(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportProgressDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/course-progress/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(courseIds);
                if (afV != null)
                    callPayload.Queries["af_v"] = ExpressionConverter.Convert(afV);
                if (couponIs != null)
                    callPayload.Queries["coupon_is[]"] = ExpressionConverter.Convert(couponIs);
                if (couponLike != null)
                    callPayload.Queries["coupon_like[]"] = ExpressionConverter.Convert(couponLike);
                if (nameIs != null)
                    callPayload.Queries["name_is[]"] = ExpressionConverter.Convert(nameIs);
                if (nameLike != null)
                    callPayload.Queries["name_like[]"] = ExpressionConverter.Convert(nameLike);
                if (emailIs != null)
                    callPayload.Queries["email_is[]"] = ExpressionConverter.Convert(emailIs);
                if (emailLike != null)
                    callPayload.Queries["email_like[]"] = ExpressionConverter.Convert(emailLike);
                if (affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = ExpressionConverter.Convert(affiliateIs);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(paymentType);
                return new ApiConnectionAction<ReportProgressDetailedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportAffiliateBrief))]
        public IBodyWorkflowAction<ReportAffiliateBriefResponse> ReportAffiliateBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> affiliateIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportAffiliateBriefResponse> __BuildReportAffiliateBrief(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> courseIds = null, WorkflowExpression<string> affiliateIds = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            WorkflowExpression.Validate(affiliateIds, nameof(affiliateIds), required: false);
            return new DeferredBodyAction<ReportAffiliateBriefResponse>(() =>
            {
                var apiCallPath = "/reports/affiliates/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(courseIds);
                if (affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = ExpressionConverter.Convert(affiliateIds);
                return new ApiConnectionAction<ReportAffiliateBriefResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        [WorkflowExpressionFactory(nameof(__BuildReportAffiliateDetailed))]
        public IBodyWorkflowAction<ReportAffiliateDetailedResponse> ReportAffiliateDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> affiliateIds = null, [WorkflowExpression] Func<string> afV = null, [WorkflowExpression] Func<string> couponIs = null, [WorkflowExpression] Func<string> couponLike = null, [WorkflowExpression] Func<string> nameIs = null, [WorkflowExpression] Func<string> nameLike = null, [WorkflowExpression] Func<string> emailIs = null, [WorkflowExpression] Func<string> emailLike = null, [WorkflowExpression] Func<string> affiliateIs = null, [WorkflowExpression] Func<string> paymentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReportAffiliateDetailedResponse> __BuildReportAffiliateDetailed(WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> courseIds = null, WorkflowExpression<string> affiliateIds = null, WorkflowExpression<string> afV = null, WorkflowExpression<string> couponIs = null, WorkflowExpression<string> couponLike = null, WorkflowExpression<string> nameIs = null, WorkflowExpression<string> nameLike = null, WorkflowExpression<string> emailIs = null, WorkflowExpression<string> emailLike = null, WorkflowExpression<string> affiliateIs = null, WorkflowExpression<string> paymentType = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(courseIds, nameof(courseIds), required: false);
            WorkflowExpression.Validate(affiliateIds, nameof(affiliateIds), required: false);
            WorkflowExpression.Validate(afV, nameof(afV), required: false);
            WorkflowExpression.Validate(couponIs, nameof(couponIs), required: false);
            WorkflowExpression.Validate(couponLike, nameof(couponLike), required: false);
            WorkflowExpression.Validate(nameIs, nameof(nameIs), required: false);
            WorkflowExpression.Validate(nameLike, nameof(nameLike), required: false);
            WorkflowExpression.Validate(emailIs, nameof(emailIs), required: false);
            WorkflowExpression.Validate(emailLike, nameof(emailLike), required: false);
            WorkflowExpression.Validate(affiliateIs, nameof(affiliateIs), required: false);
            WorkflowExpression.Validate(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportAffiliateDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/affiliates/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(courseIds);
                if (affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = ExpressionConverter.Convert(affiliateIds);
                if (afV != null)
                    callPayload.Queries["af_v"] = ExpressionConverter.Convert(afV);
                if (couponIs != null)
                    callPayload.Queries["coupon_is[]"] = ExpressionConverter.Convert(couponIs);
                if (couponLike != null)
                    callPayload.Queries["coupon_like[]"] = ExpressionConverter.Convert(couponLike);
                if (nameIs != null)
                    callPayload.Queries["name_is[]"] = ExpressionConverter.Convert(nameIs);
                if (nameLike != null)
                    callPayload.Queries["name_like[]"] = ExpressionConverter.Convert(nameLike);
                if (emailIs != null)
                    callPayload.Queries["email_is[]"] = ExpressionConverter.Convert(emailIs);
                if (emailLike != null)
                    callPayload.Queries["email_like[]"] = ExpressionConverter.Convert(emailLike);
                if (affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = ExpressionConverter.Convert(affiliateIs);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(paymentType);
                return new ApiConnectionAction<ReportAffiliateDetailedResponse>(callPayload);
            });
        }
    }

    public class ZenleripTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserListResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserListResponseDataType Data { get; set; }
    }

    public class UserListResponseDataType
    {
        [JsonProperty("items")]
        public UserListResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public UserListResponseDataTypePaginationType Pagination { get; set; }
    }

    public class UserListResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("roles")]
        public int[] Roles { get; set; }
    }

    public class UserListResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    public class UserPostResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserPostResponseDataType Data { get; set; }
    }

    public class UserPostResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class UserGetResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserGetResponseDataType Data { get; set; }
    }

    public class UserGetResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("roles")]
        public int[] Roles { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class UserDeleteResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UserPutResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserPutResponseDataType Data { get; set; }
    }

    public class UserPutResponseDataType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UserEnrollResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UserUnenrollResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserUnenrollResponseDataType Data { get; set; }
    }

    public class UserUnenrollResponseDataType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CourseListResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CourseListResponseDataType Data { get; set; }
    }

    public class CourseListResponseDataType
    {
        [JsonProperty("items")]
        public CourseListResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public CourseListResponseDataTypePaginationType Pagination { get; set; }
    }

    public class CourseListResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CourseListResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class CourseGetResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CourseGetResponseDataType Data { get; set; }
    }

    public class CourseGetResponseDataType
    {
        [JsonProperty("items")]
        public CourseGetResponseDataTypeItemsType Items { get; set; }
    }

    public class CourseGetResponseDataTypeItemsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("course_type")]
        public int CourseType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("school_id")]
        public int SchoolId { get; set; }

        [JsonProperty("public")]
        public int Public { get; set; }

        [JsonProperty("featured")]
        public int Featured { get; set; }

        [JsonProperty("hidden")]
        public int Hidden { get; set; }

        [JsonProperty("private")]
        public int Private { get; set; }
    }

    public class FunnelListResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public FunnelListResponseDataType Data { get; set; }
    }

    public class FunnelListResponseDataType
    {
        [JsonProperty("items")]
        public FunnelListResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public FunnelListResponseDataTypePaginationType Pagination { get; set; }
    }

    public class FunnelListResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total_leads")]
        public int TotalLeads { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class FunnelListResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class FunnelEnrollmentResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public FunnelEnrollmentResponseDataType Data { get; set; }
    }

    public class FunnelEnrollmentResponseDataType
    {
        [JsonProperty("items")]
        public FunnelEnrollmentResponseDataTypeItemsTypeItem[] Items { get; set; }
    }

    public class FunnelEnrollmentResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("enrolled_on")]
        public string EnrolledOn { get; set; }
    }

    public class FunnelSubscribeResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public FunnelSubscribeResponseDataType Data { get; set; }
    }

    public class FunnelSubscribeResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("funnel")]
        public string Funnel { get; set; }
    }

    public class FunnelUnsubscribeResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class ClassListResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ClassListResponseDataType Data { get; set; }
    }

    public class ClassListResponseDataType
    {
        [JsonProperty("items")]
        public ClassListResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ClassListResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ClassListResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("schedule_date")]
        public string ScheduleDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("register_url")]
        public string RegisterUrl { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recent_recurring_schedule")]
        public string RecentRecurringSchedule { get; set; }
    }

    public class ClassListResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ClassRegisterResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ClassRegisterResponseDataType Data { get; set; }
    }

    public class ClassRegisterResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("live class")]
        public string LiveClass { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ClassUnregisterResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class WebinarListResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WebinarListResponseDataType Data { get; set; }
    }

    public class WebinarListResponseDataType
    {
        [JsonProperty("items")]
        public WebinarListResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public WebinarListResponseDataTypePaginationType Pagination { get; set; }
    }

    public class WebinarListResponseDataTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("schedule_date")]
        public string ScheduleDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("register_url")]
        public string RegisterUrl { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recent_recurring_schedule")]
        public string RecentRecurringSchedule { get; set; }
    }

    public class WebinarListResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class WebinarRegisterResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public WebinarRegisterResponseDataType Data { get; set; }
    }

    public class WebinarRegisterResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("live webinar")]
        public string LiveWebinar { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class WebinarUnregisterResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class ReportEnrollBriefResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportEnrollBriefResponseDataType Data { get; set; }
    }

    public class ReportEnrollBriefResponseDataType
    {
        [JsonProperty("items")]
        public ReportEnrollBriefResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ReportEnrollBriefResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportEnrollBriefResponseDataTypeItemsTypeItem
    {
        [JsonProperty("course_id")]
        public int CourseId { get; set; }

        [JsonProperty("course_name")]
        public string CourseName { get; set; }

        [JsonProperty("no_of_enrollments")]
        public int NoOfEnrollments { get; set; }
    }

    public class ReportEnrollBriefResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportEnrollDetailResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportEnrollDetailResponseDataType Data { get; set; }
    }

    public class ReportEnrollDetailResponseDataType
    {
        [JsonProperty("items")]
        public ReportEnrollDetailResponseDataTypeItemsTypeItem[] Items { get; set; }
    }

    public class ReportEnrollDetailResponseDataTypeItemsTypeItem
    {
        [JsonProperty("course_id")]
        public int CourseId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("course_name")]
        public string CourseName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("enrollment_date")]
        public string EnrollmentDate { get; set; }
    }

    public class ReportSalesBriefResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportSalesBriefResponseDataType Data { get; set; }
    }

    public class ReportSalesBriefResponseDataType
    {
        [JsonProperty("items")]
        public ReportSalesBriefResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ReportSalesBriefResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportSalesBriefResponseDataTypeItemsTypeItem
    {
        [JsonProperty("total_sales")]
        public int TotalSales { get; set; }

        [JsonProperty("course_id")]
        public int CourseId { get; set; }

        [JsonProperty("earnings_total")]
        public string EarningsTotal { get; set; }

        [JsonProperty("sales_total")]
        public string SalesTotal { get; set; }

        [JsonProperty("aff_fee")]
        public string AffFee { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class ReportSalesBriefResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportSalesDetailedResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportSalesDetailedResponseDataType Data { get; set; }
    }

    public class ReportSalesDetailedResponseDataType
    {
        [JsonProperty("items")]
        public ReportSalesDetailedResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ReportSalesDetailedResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportSalesDetailedResponseDataTypeItemsTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("sales_price")]
        public string SalesPrice { get; set; }

        [JsonProperty("earn_price")]
        public string EarnPrice { get; set; }

        [JsonProperty("student_name")]
        public string StudentName { get; set; }

        [JsonProperty("student_email")]
        public string StudentEmail { get; set; }

        [JsonProperty("course")]
        public string Course { get; set; }

        [JsonProperty("course_id")]
        public int CourseId { get; set; }

        [JsonProperty("coupon_code")]
        public string CouponCode { get; set; }

        [JsonProperty("payment_gateway")]
        public string PaymentGateway { get; set; }
    }

    public class ReportSalesDetailedResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportProgressBriefResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportProgressBriefResponseDataType Data { get; set; }
    }

    public class ReportProgressBriefResponseDataType
    {
        [JsonProperty("items")]
        public ReportProgressBriefResponseDataTypeItemsType Items { get; set; }

        [JsonProperty("pagination")]
        public ReportProgressBriefResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportProgressBriefResponseDataTypeItemsType
    {
        [JsonProperty("course_number")]
        public ReportProgressBriefResponseDataTypeItemsTypeCourseNumberType CourseNumber { get; set; }
    }

    public class ReportProgressBriefResponseDataTypeItemsTypeCourseNumberType
    {
        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("last_date")]
        public string LastDate { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("total_students")]
        public int TotalStudents { get; set; }

        [JsonProperty("not_started")]
        public int NotStarted { get; set; }

        [JsonProperty("in_progress")]
        public int InProgress { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("pass_rate")]
        public int PassRate { get; set; }
    }

    public class ReportProgressBriefResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public string ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public string PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportProgressDetailedResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportProgressDetailedResponseDataType Data { get; set; }
    }

    public class ReportProgressDetailedResponseDataType
    {
        [JsonProperty("items")]
        public ReportProgressDetailedResponseDataTypeItemsType Items { get; set; }

        [JsonProperty("pagination")]
        public ReportProgressDetailedResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportProgressDetailedResponseDataTypeItemsType
    {
        [JsonProperty("course_number")]
        public ReportProgressDetailedResponseDataTypeItemsTypeCourseNumberType CourseNumber { get; set; }
    }

    public class ReportProgressDetailedResponseDataTypeItemsTypeCourseNumberType
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("courseId")]
        public string CourseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("enrollment_date")]
        public string EnrollmentDate { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("last_attended")]
        public string LastAttended { get; set; }

        [JsonProperty("completion_percentage")]
        public int CompletionPercentage { get; set; }
    }

    public class ReportProgressDetailedResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public string ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public string PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportAffiliateBriefResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportAffiliateBriefResponseDataType Data { get; set; }
    }

    public class ReportAffiliateBriefResponseDataType
    {
        [JsonProperty("items")]
        public ReportAffiliateBriefResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ReportAffiliateBriefResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportAffiliateBriefResponseDataTypeItemsTypeItem
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("aff_id")]
        public string AffId { get; set; }

        [JsonProperty("aff_name")]
        public string AffName { get; set; }

        [JsonProperty("aff_email")]
        public string AffEmail { get; set; }

        [JsonProperty("total_sales_count")]
        public int TotalSalesCount { get; set; }

        [JsonProperty("total_commission")]
        public string TotalCommission { get; set; }

        [JsonProperty("pending_commission")]
        public string PendingCommission { get; set; }

        [JsonProperty("paid_commission")]
        public string PaidCommission { get; set; }
    }

    public class ReportAffiliateBriefResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public string ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public string PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class ReportAffiliateDetailedResponse
    {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ReportAffiliateDetailedResponseDataType Data { get; set; }
    }

    public class ReportAffiliateDetailedResponseDataType
    {
        [JsonProperty("items")]
        public ReportAffiliateDetailedResponseDataTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("pagination")]
        public ReportAffiliateDetailedResponseDataTypePaginationType Pagination { get; set; }
    }

    public class ReportAffiliateDetailedResponseDataTypeItemsTypeItem
    {
        [JsonProperty("course")]
        public string Course { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("sales_price")]
        public string SalesPrice { get; set; }

        [JsonProperty("coupon_discount")]
        public string CouponDiscount { get; set; }

        [JsonProperty("commission")]
        public string Commission { get; set; }

        [JsonProperty("payout_status")]
        public string PayoutStatus { get; set; }
    }

    public class ReportAffiliateDetailedResponseDataTypePaginationType
    {
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zenlerip;

    public partial class WorkflowManagedActions
    {
        public ZenleripActions Zenlerip(string connectionId) => new ZenleripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZenleripTriggers Zenlerip(string connectionId) => new ZenleripTriggers(connectionId);
    }
}