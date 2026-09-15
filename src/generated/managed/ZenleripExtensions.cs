//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zenlerip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZenleripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserListResponse> UserList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> role = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(15);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            callPayload.Queries["order"] = Convert.ToString("desc");
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (role != null)
                callPayload.Queries["role"] = CSharpExpressionConverter.ConvertO(role);
            return new ApiConnectionAction<UserListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPostResponse> User(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodypassword, Expression<Func<int>> bodycommission, Expression<Func<string>> bodyroles, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
            bodypropCount++;
            body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
            bodypropCount++;
            body["commission"] = CSharpExpressionConverter.ConvertToken(bodycommission);
            bodypropCount++;
            body["roles"] = CSharpExpressionConverter.ConvertToken(bodyroles);
            if (bodyaddress != null)
            {
                body["address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zip_code"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodygdprConsentStatus != null)
            {
                body["gdpr_consent_status"] = CSharpExpressionConverter.ConvertToken(bodygdprConsentStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserGetResponse> UserGet(Expression<Func<string>> userId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete(Expression<Func<string>> userId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPutResponse> UserPut(Expression<Func<string>> userId, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodypassword, Expression<Func<int>> bodycommission, Expression<Func<string>> bodyroles, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
            bodypropCount++;
            body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
            bodypropCount++;
            body["commission"] = CSharpExpressionConverter.ConvertToken(bodycommission);
            bodypropCount++;
            body["roles"] = CSharpExpressionConverter.ConvertToken(bodyroles);
            if (bodyaddress != null)
            {
                body["address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zip_code"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodygdprConsentStatus != null)
            {
                body["gdpr_consent_status"] = CSharpExpressionConverter.ConvertToken(bodygdprConsentStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserEnrollResponse> UserEnroll(Expression<Func<string>> userId, Expression<Func<string>> bodycourseId, Expression<Func<string>> bodyplanId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}/enroll", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["course_id"] = CSharpExpressionConverter.ConvertToken(bodycourseId);
            if (bodyplanId != null)
            {
                body["plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserEnrollResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserUnenrollResponse> UserUnenroll(Expression<Func<string>> userId, Expression<Func<string>> bodycourseId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}/unenroll", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["course_id"] = CSharpExpressionConverter.ConvertToken(bodycourseId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserUnenrollResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseListResponse> CourseList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<string>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> type = null, Expression<Func<int>> status = null)
        {
            var apiCallPath = "/courses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.ConvertO(order);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.ConvertO(type);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            return new ApiConnectionAction<CourseListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseGetResponse> CourseGet(Expression<Func<string>> courseId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/courses/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CourseGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelListResponse> FunnelList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<string>> order = null, Expression<Func<string>> search = null, Expression<Func<int>> status = null)
        {
            var apiCallPath = "/funnels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.ConvertO(order);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            return new ApiConnectionAction<FunnelListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelEnrollmentResponse> FunnelEnrollment(Expression<Func<string>> funnelId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/funnels/enrollments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FunnelEnrollmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelSubscribeResponse> FunnelSubscribe(Expression<Func<string>> funnelId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodygdprConsentStatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/funnels/{0}/subscribe", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zip_code"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodygdprConsentStatus != null)
            {
                body["gdpr_consent_status"] = CSharpExpressionConverter.ConvertToken(bodygdprConsentStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FunnelSubscribeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelUnsubscribeResponse> FunnelUnsubscribe(Expression<Func<string>> funnelId, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/funnels/{0}/unsubscribe", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FunnelUnsubscribeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassListResponse> ClassList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/live-class/get-live-classes-list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            callPayload.Queries["order"] = Convert.ToString("desc");
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            return new ApiConnectionAction<ClassListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassRegisterResponse> ClassRegister(Expression<Func<string>> liveclassId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-class/{0}/register", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(liveclassId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassRegisterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassUnregisterResponse> ClassUnregister(Expression<Func<string>> liveclassId, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-class/{0}/unregister", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(liveclassId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassUnregisterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarListResponse> WebinarList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> orderby = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/live-webinar/get-live-webinars-list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            callPayload.Queries["order"] = Convert.ToString("desc");
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            return new ApiConnectionAction<WebinarListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarRegisterResponse> WebinarRegister(Expression<Func<string>> webinarId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyphone = null, Expression<Func<int>> bodyzipCode = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/register", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zip_code"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WebinarRegisterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarUnregisterResponse> WebinarUnregister(Expression<Func<string>> webinarId, Expression<Func<string>> bodyemail)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/unregister", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WebinarUnregisterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollBriefResponse> ReportEnrollBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> courseId = null)
        {
            var apiCallPath = "/reports/enrollments/brief";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (courseId != null)
                callPayload.Queries["course_id"] = CSharpExpressionConverter.ConvertO(courseId);
            return new ApiConnectionAction<ReportEnrollBriefResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollDetailResponse> ReportEnrollDetail(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> courseId = null)
        {
            var apiCallPath = "/reports/enrollments/detailed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (courseId != null)
                callPayload.Queries["course_id"] = CSharpExpressionConverter.ConvertO(courseId);
            return new ApiConnectionAction<ReportEnrollDetailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesBriefResponse> ReportSalesBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> groupby = null, Expression<Func<string>> courseIds = null)
        {
            var apiCallPath = "/reports/sales/brief";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (groupby != null)
                callPayload.Queries["groupby"] = CSharpExpressionConverter.ConvertO(groupby);
            if (courseIds != null)
                callPayload.Queries["course_ids"] = CSharpExpressionConverter.ConvertO(courseIds);
            return new ApiConnectionAction<ReportSalesBriefResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesDetailedResponse> ReportSalesDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<int>> paymentType = null)
        {
            var apiCallPath = "/reports/sales/detailed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (courseIds != null)
                callPayload.Queries["course_ids"] = CSharpExpressionConverter.ConvertO(courseIds);
            if (paymentType != null)
                callPayload.Queries["payment_type"] = CSharpExpressionConverter.ConvertO(paymentType);
            return new ApiConnectionAction<ReportSalesDetailedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressBriefResponse> ReportProgressBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null)
        {
            var apiCallPath = "/reports/course-progress/brief";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (courseIds != null)
                callPayload.Queries["course_ids[]"] = CSharpExpressionConverter.ConvertO(courseIds);
            return new ApiConnectionAction<ReportProgressBriefResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressDetailedResponse> ReportProgressDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> afV = null, Expression<Func<string>> couponIs = null, Expression<Func<string>> couponLike = null, Expression<Func<string>> nameIs = null, Expression<Func<string>> nameLike = null, Expression<Func<string>> emailIs = null, Expression<Func<string>> emailLike = null, Expression<Func<string>> affiliateIs = null, Expression<Func<int>> paymentType = null)
        {
            var apiCallPath = "/reports/course-progress/detailed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (courseIds != null)
                callPayload.Queries["course_ids[]"] = CSharpExpressionConverter.ConvertO(courseIds);
            if (afV != null)
                callPayload.Queries["af_v"] = CSharpExpressionConverter.ConvertO(afV);
            if (couponIs != null)
                callPayload.Queries["coupon_is[]"] = CSharpExpressionConverter.ConvertO(couponIs);
            if (couponLike != null)
                callPayload.Queries["coupon_like[]"] = CSharpExpressionConverter.ConvertO(couponLike);
            if (nameIs != null)
                callPayload.Queries["name_is[]"] = CSharpExpressionConverter.ConvertO(nameIs);
            if (nameLike != null)
                callPayload.Queries["name_like[]"] = CSharpExpressionConverter.ConvertO(nameLike);
            if (emailIs != null)
                callPayload.Queries["email_is[]"] = CSharpExpressionConverter.ConvertO(emailIs);
            if (emailLike != null)
                callPayload.Queries["email_like[]"] = CSharpExpressionConverter.ConvertO(emailLike);
            if (affiliateIs != null)
                callPayload.Queries["affiliate_is[]"] = CSharpExpressionConverter.ConvertO(affiliateIs);
            if (paymentType != null)
                callPayload.Queries["payment_type"] = CSharpExpressionConverter.ConvertO(paymentType);
            return new ApiConnectionAction<ReportProgressDetailedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateBriefResponse> ReportAffiliateBrief(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> affiliateIds = null)
        {
            var apiCallPath = "/reports/affiliates/brief";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (courseIds != null)
                callPayload.Queries["course_ids[]"] = CSharpExpressionConverter.ConvertO(courseIds);
            if (affiliateIds != null)
                callPayload.Queries["affiliate_ids[]"] = CSharpExpressionConverter.ConvertO(affiliateIds);
            return new ApiConnectionAction<ReportAffiliateBriefResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateDetailedResponse> ReportAffiliateDetailed(Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> courseIds = null, Expression<Func<string>> affiliateIds = null, Expression<Func<string>> afV = null, Expression<Func<string>> couponIs = null, Expression<Func<string>> couponLike = null, Expression<Func<string>> nameIs = null, Expression<Func<string>> nameLike = null, Expression<Func<string>> emailIs = null, Expression<Func<string>> emailLike = null, Expression<Func<string>> affiliateIs = null, Expression<Func<string>> paymentType = null)
        {
            var apiCallPath = "/reports/affiliates/detailed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (courseIds != null)
                callPayload.Queries["course_ids[]"] = CSharpExpressionConverter.ConvertO(courseIds);
            if (affiliateIds != null)
                callPayload.Queries["affiliate_ids[]"] = CSharpExpressionConverter.ConvertO(affiliateIds);
            if (afV != null)
                callPayload.Queries["af_v"] = CSharpExpressionConverter.ConvertO(afV);
            if (couponIs != null)
                callPayload.Queries["coupon_is[]"] = CSharpExpressionConverter.ConvertO(couponIs);
            if (couponLike != null)
                callPayload.Queries["coupon_like[]"] = CSharpExpressionConverter.ConvertO(couponLike);
            if (nameIs != null)
                callPayload.Queries["name_is[]"] = CSharpExpressionConverter.ConvertO(nameIs);
            if (nameLike != null)
                callPayload.Queries["name_like[]"] = CSharpExpressionConverter.ConvertO(nameLike);
            if (emailIs != null)
                callPayload.Queries["email_is[]"] = CSharpExpressionConverter.ConvertO(emailIs);
            if (emailLike != null)
                callPayload.Queries["email_like[]"] = CSharpExpressionConverter.ConvertO(emailLike);
            if (affiliateIs != null)
                callPayload.Queries["affiliate_is[]"] = CSharpExpressionConverter.ConvertO(affiliateIs);
            if (paymentType != null)
                callPayload.Queries["payment_type"] = CSharpExpressionConverter.ConvertO(paymentType);
            return new ApiConnectionAction<ReportAffiliateDetailedResponse>(callPayload);
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