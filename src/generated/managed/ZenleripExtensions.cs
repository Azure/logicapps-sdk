//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zenlerip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZenleripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserListResponse> UserList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> role = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: false);
            return new DeferredBodyAction<UserListResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(15);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_role != null)
                    callPayload.Queries["role"] = ExpressionConverter.Convert(__workflow_role);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPostResponse> User(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodypassword, Expression<Func<int>> bodycommission, Expression<Func<string>> bodyroles, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodycommission = WorkflowExpression.Compile(bodycommission, nameof(bodycommission), required: true);
            var __workflow_bodyroles = WorkflowExpression.Compile(bodyroles, nameof(bodyroles), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodygdprConsentStatus = WorkflowExpression.Compile(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<UserPostResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["commission"] = ExpressionConverter.ConvertO(__workflow_bodycommission);
                bodypropCount++;
                body["roles"] = ExpressionConverter.ConvertO(__workflow_bodyroles);
                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(__workflow_bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserGetResponse> UserGet(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPutResponse> UserPut(Expression<Func<string>> userId, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodypassword, Expression<Func<int>> bodycommission, Expression<Func<string>> bodyroles, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodycommission = WorkflowExpression.Compile(bodycommission, nameof(bodycommission), required: true);
            var __workflow_bodyroles = WorkflowExpression.Compile(bodyroles, nameof(bodyroles), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodygdprConsentStatus = WorkflowExpression.Compile(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<UserPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["commission"] = ExpressionConverter.ConvertO(__workflow_bodycommission);
                bodypropCount++;
                body["roles"] = ExpressionConverter.ConvertO(__workflow_bodyroles);
                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(__workflow_bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserPutResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserEnrollResponse> UserEnroll(Expression<Func<string>> userId, Expression<Func<string>> bodycourseId, Expression<Func<string>> bodyplanId = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: false);
            return new DeferredBodyAction<UserEnrollResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/enroll", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                if (__workflow_bodyplanId != null)
                {
                    body["plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserEnrollResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserUnenrollResponse> UserUnenroll(Expression<Func<string>> userId, Expression<Func<string>> bodycourseId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: true);
            return new DeferredBodyAction<UserUnenrollResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/unenroll", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserUnenrollResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseListResponse> CourseList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<string>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> type = null, Expression<Func<int>> status = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<CourseListResponse>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<CourseListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseGetResponse> CourseGet(Expression<Func<string>> courseId)
        {
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: true);
            return new DeferredBodyAction<CourseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}", __workflow_courseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CourseGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelListResponse> FunnelList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<string>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> status = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<FunnelListResponse>(() =>
            {
                var apiCallPath = "/funnels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<FunnelListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelEnrollmentResponse> FunnelEnrollment(Expression<Func<string>> funnelId)
        {
            var __workflow_funnelId = WorkflowExpression.Compile(funnelId, nameof(funnelId), required: true);
            return new DeferredBodyAction<FunnelEnrollmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/funnels/enrollments/{0}", __workflow_funnelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FunnelEnrollmentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelSubscribeResponse> FunnelSubscribe(Expression<Func<string>> funnelId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var __workflow_funnelId = WorkflowExpression.Compile(funnelId, nameof(funnelId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodygdprConsentStatus = WorkflowExpression.Compile(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            return new DeferredBodyAction<FunnelSubscribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/funnels/{0}/subscribe", __workflow_funnelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = ExpressionConverter.ConvertO(__workflow_bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FunnelSubscribeResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelUnsubscribeResponse> FunnelUnsubscribe(Expression<Func<string>> funnelId, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_funnelId = WorkflowExpression.Compile(funnelId, nameof(funnelId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<FunnelUnsubscribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/funnels/{0}/unsubscribe", __workflow_funnelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FunnelUnsubscribeResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassListResponse> ClassList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<ClassListResponse>(() =>
            {
                var apiCallPath = "/live-class/get-live-classes-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<ClassListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassRegisterResponse> ClassRegister(Expression<Func<string>> liveclassId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_liveclassId = WorkflowExpression.Compile(liveclassId, nameof(liveclassId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ClassRegisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-class/{0}/register", __workflow_liveclassId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassRegisterResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassUnregisterResponse> ClassUnregister(Expression<Func<string>> liveclassId, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_liveclassId = WorkflowExpression.Compile(liveclassId, nameof(liveclassId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<ClassUnregisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-class/{0}/unregister", __workflow_liveclassId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassUnregisterResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarListResponse> WebinarList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<WebinarListResponse>(() =>
            {
                var apiCallPath = "/live-webinar/get-live-webinars-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<WebinarListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarRegisterResponse> WebinarRegister(Expression<Func<string>> webinarId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null)
        {
            var __workflow_webinarId = WorkflowExpression.Compile(webinarId, nameof(webinarId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            return new DeferredBodyAction<WebinarRegisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-webinar/{0}/register", __workflow_webinarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WebinarRegisterResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarUnregisterResponse> WebinarUnregister(Expression<Func<string>> webinarId, Expression<Func<string>> bodyemail)
        {
            var __workflow_webinarId = WorkflowExpression.Compile(webinarId, nameof(webinarId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<WebinarUnregisterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-webinar/{0}/unregister", __workflow_webinarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WebinarUnregisterResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollBriefResponse> ReportEnrollBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> courseId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: false);
            return new DeferredBodyAction<ReportEnrollBriefResponse>(() =>
            {
                var apiCallPath = "/reports/enrollments/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_courseId != null)
                    callPayload.Queries["course_id"] = ExpressionConverter.Convert(__workflow_courseId);
                return new ApiConnectionAction<ReportEnrollBriefResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollDetailResponse> ReportEnrollDetail(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> courseId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_courseId = WorkflowExpression.Compile(courseId, nameof(courseId), required: false);
            return new DeferredBodyAction<ReportEnrollDetailResponse>(() =>
            {
                var apiCallPath = "/reports/enrollments/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_courseId != null)
                    callPayload.Queries["course_id"] = ExpressionConverter.Convert(__workflow_courseId);
                return new ApiConnectionAction<ReportEnrollDetailResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesBriefResponse> ReportSalesBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> groupby = null, Expression<Func<string>> courseIds = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_groupby = WorkflowExpression.Compile(groupby, nameof(groupby), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            return new DeferredBodyAction<ReportSalesBriefResponse>(() =>
            {
                var apiCallPath = "/reports/sales/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_groupby != null)
                    callPayload.Queries["groupby"] = ExpressionConverter.Convert(__workflow_groupby);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids"] = ExpressionConverter.Convert(__workflow_courseIds);
                return new ApiConnectionAction<ReportSalesBriefResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesDetailedResponse> ReportSalesDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<int>> paymentType = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            var __workflow_paymentType = WorkflowExpression.Compile(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportSalesDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/sales/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids"] = ExpressionConverter.Convert(__workflow_courseIds);
                if (__workflow_paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(__workflow_paymentType);
                return new ApiConnectionAction<ReportSalesDetailedResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressBriefResponse> ReportProgressBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            return new DeferredBodyAction<ReportProgressBriefResponse>(() =>
            {
                var apiCallPath = "/reports/course-progress/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(__workflow_courseIds);
                return new ApiConnectionAction<ReportProgressBriefResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressDetailedResponse> ReportProgressDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> afV = null, Expression<Func<string>> couponIs = null, Expression<Func<string>> couponLike = null, Expression<Func<string>> nameIs = null, Expression<Func<string>> nameLike = null, Expression<Func<string>> emailIs = null, Expression<Func<string>> emailLike = null, Expression<Func<string>> affiliateIs = null, Expression<Func<int>> paymentType = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            var __workflow_afV = WorkflowExpression.Compile(afV, nameof(afV), required: false);
            var __workflow_couponIs = WorkflowExpression.Compile(couponIs, nameof(couponIs), required: false);
            var __workflow_couponLike = WorkflowExpression.Compile(couponLike, nameof(couponLike), required: false);
            var __workflow_nameIs = WorkflowExpression.Compile(nameIs, nameof(nameIs), required: false);
            var __workflow_nameLike = WorkflowExpression.Compile(nameLike, nameof(nameLike), required: false);
            var __workflow_emailIs = WorkflowExpression.Compile(emailIs, nameof(emailIs), required: false);
            var __workflow_emailLike = WorkflowExpression.Compile(emailLike, nameof(emailLike), required: false);
            var __workflow_affiliateIs = WorkflowExpression.Compile(affiliateIs, nameof(affiliateIs), required: false);
            var __workflow_paymentType = WorkflowExpression.Compile(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportProgressDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/course-progress/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(__workflow_courseIds);
                if (__workflow_afV != null)
                    callPayload.Queries["af_v"] = ExpressionConverter.Convert(__workflow_afV);
                if (__workflow_couponIs != null)
                    callPayload.Queries["coupon_is[]"] = ExpressionConverter.Convert(__workflow_couponIs);
                if (__workflow_couponLike != null)
                    callPayload.Queries["coupon_like[]"] = ExpressionConverter.Convert(__workflow_couponLike);
                if (__workflow_nameIs != null)
                    callPayload.Queries["name_is[]"] = ExpressionConverter.Convert(__workflow_nameIs);
                if (__workflow_nameLike != null)
                    callPayload.Queries["name_like[]"] = ExpressionConverter.Convert(__workflow_nameLike);
                if (__workflow_emailIs != null)
                    callPayload.Queries["email_is[]"] = ExpressionConverter.Convert(__workflow_emailIs);
                if (__workflow_emailLike != null)
                    callPayload.Queries["email_like[]"] = ExpressionConverter.Convert(__workflow_emailLike);
                if (__workflow_affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = ExpressionConverter.Convert(__workflow_affiliateIs);
                if (__workflow_paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(__workflow_paymentType);
                return new ApiConnectionAction<ReportProgressDetailedResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateBriefResponse> ReportAffiliateBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> affiliateIds = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            var __workflow_affiliateIds = WorkflowExpression.Compile(affiliateIds, nameof(affiliateIds), required: false);
            return new DeferredBodyAction<ReportAffiliateBriefResponse>(() =>
            {
                var apiCallPath = "/reports/affiliates/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(__workflow_courseIds);
                if (__workflow_affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = ExpressionConverter.Convert(__workflow_affiliateIds);
                return new ApiConnectionAction<ReportAffiliateBriefResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateDetailedResponse> ReportAffiliateDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> affiliateIds = null, Expression<Func<string>> afV = null, Expression<Func<string>> couponIs = null, Expression<Func<string>> couponLike = null, Expression<Func<string>> nameIs = null, Expression<Func<string>> nameLike = null, Expression<Func<string>> emailIs = null, Expression<Func<string>> emailLike = null, Expression<Func<string>> affiliateIs = null, Expression<Func<string>> paymentType = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_courseIds = WorkflowExpression.Compile(courseIds, nameof(courseIds), required: false);
            var __workflow_affiliateIds = WorkflowExpression.Compile(affiliateIds, nameof(affiliateIds), required: false);
            var __workflow_afV = WorkflowExpression.Compile(afV, nameof(afV), required: false);
            var __workflow_couponIs = WorkflowExpression.Compile(couponIs, nameof(couponIs), required: false);
            var __workflow_couponLike = WorkflowExpression.Compile(couponLike, nameof(couponLike), required: false);
            var __workflow_nameIs = WorkflowExpression.Compile(nameIs, nameof(nameIs), required: false);
            var __workflow_nameLike = WorkflowExpression.Compile(nameLike, nameof(nameLike), required: false);
            var __workflow_emailIs = WorkflowExpression.Compile(emailIs, nameof(emailIs), required: false);
            var __workflow_emailLike = WorkflowExpression.Compile(emailLike, nameof(emailLike), required: false);
            var __workflow_affiliateIs = WorkflowExpression.Compile(affiliateIs, nameof(affiliateIs), required: false);
            var __workflow_paymentType = WorkflowExpression.Compile(paymentType, nameof(paymentType), required: false);
            return new DeferredBodyAction<ReportAffiliateDetailedResponse>(() =>
            {
                var apiCallPath = "/reports/affiliates/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_courseIds != null)
                    callPayload.Queries["course_ids[]"] = ExpressionConverter.Convert(__workflow_courseIds);
                if (__workflow_affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = ExpressionConverter.Convert(__workflow_affiliateIds);
                if (__workflow_afV != null)
                    callPayload.Queries["af_v"] = ExpressionConverter.Convert(__workflow_afV);
                if (__workflow_couponIs != null)
                    callPayload.Queries["coupon_is[]"] = ExpressionConverter.Convert(__workflow_couponIs);
                if (__workflow_couponLike != null)
                    callPayload.Queries["coupon_like[]"] = ExpressionConverter.Convert(__workflow_couponLike);
                if (__workflow_nameIs != null)
                    callPayload.Queries["name_is[]"] = ExpressionConverter.Convert(__workflow_nameIs);
                if (__workflow_nameLike != null)
                    callPayload.Queries["name_like[]"] = ExpressionConverter.Convert(__workflow_nameLike);
                if (__workflow_emailIs != null)
                    callPayload.Queries["email_is[]"] = ExpressionConverter.Convert(__workflow_emailIs);
                if (__workflow_emailLike != null)
                    callPayload.Queries["email_like[]"] = ExpressionConverter.Convert(__workflow_emailLike);
                if (__workflow_affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = ExpressionConverter.Convert(__workflow_affiliateIs);
                if (__workflow_paymentType != null)
                    callPayload.Queries["payment_type"] = ExpressionConverter.Convert(__workflow_paymentType);
                return new ApiConnectionAction<ReportAffiliateDetailedResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
