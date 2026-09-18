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
        public IBodyWorkflowAction<UserListResponse> UserList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> role = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(role, nameof(role), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(15);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (role != null)
                    callPayload.Queries["role"] = SourceExpressionConverter.ConvertO(role);
                return callPayload;
            }

            return new ApiConnectionAction<UserListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<int> bodycommission, [WorkflowExpression] Func<string> bodyroles, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodycommission, nameof(bodycommission), required: true);
            SourceExpression.Validate(bodyroles, nameof(bodyroles), required: true);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["commission"] = SourceExpressionConverter.ConvertToken(bodycommission);
                bodypropCount++;
                body["roles"] = SourceExpressionConverter.ConvertToken(bodyroles);
                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = SourceExpressionConverter.ConvertToken(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserGetResponse> UserGet([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserPutResponse> UserPut([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<int> bodycommission, [WorkflowExpression] Func<string> bodyroles, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodycommission, nameof(bodycommission), required: true);
            SourceExpression.Validate(bodyroles, nameof(bodyroles), required: true);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["commission"] = SourceExpressionConverter.ConvertToken(bodycommission);
                bodypropCount++;
                body["roles"] = SourceExpressionConverter.ConvertToken(bodyroles);
                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = SourceExpressionConverter.ConvertToken(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserEnrollResponse> UserEnroll([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodycourseId, [WorkflowExpression] Func<string> bodyplanId = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodycourseId, nameof(bodycourseId), required: true);
            SourceExpression.Validate(bodyplanId, nameof(bodyplanId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/enroll", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = SourceExpressionConverter.ConvertToken(bodycourseId);
                if (bodyplanId != null)
                {
                    body["plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserEnrollResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<UserUnenrollResponse> UserUnenroll([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodycourseId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodycourseId, nameof(bodycourseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/unenroll", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["course_id"] = SourceExpressionConverter.ConvertToken(bodycourseId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserUnenrollResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseListResponse> CourseList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> type = null, [WorkflowExpression] Func<int> status = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<CourseListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<CourseGetResponse> CourseGet([WorkflowExpression] Func<string> courseId)
        {
            SourceExpression.Validate(courseId, nameof(courseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/courses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CourseGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelListResponse> FunnelList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> status = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/funnels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<FunnelListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelEnrollmentResponse> FunnelEnrollment([WorkflowExpression] Func<string> funnelId)
        {
            SourceExpression.Validate(funnelId, nameof(funnelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funnels/enrollments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FunnelEnrollmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelSubscribeResponse> FunnelSubscribe([WorkflowExpression] Func<string> funnelId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodygdprConsentStatus = null)
        {
            SourceExpression.Validate(funnelId, nameof(funnelId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodygdprConsentStatus, nameof(bodygdprConsentStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funnels/{0}/subscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodygdprConsentStatus != null)
                {
                    body["gdpr_consent_status"] = SourceExpressionConverter.ConvertToken(bodygdprConsentStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FunnelSubscribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<FunnelUnsubscribeResponse> FunnelUnsubscribe([WorkflowExpression] Func<string> funnelId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            SourceExpression.Validate(funnelId, nameof(funnelId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/funnels/{0}/unsubscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(funnelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FunnelUnsubscribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassListResponse> ClassList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/live-class/get-live-classes-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<ClassListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassRegisterResponse> ClassRegister([WorkflowExpression] Func<string> liveclassId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(liveclassId, nameof(liveclassId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/live-class/{0}/register", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(liveclassId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClassRegisterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ClassUnregisterResponse> ClassUnregister([WorkflowExpression] Func<string> liveclassId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            SourceExpression.Validate(liveclassId, nameof(liveclassId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/live-class/{0}/unregister", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(liveclassId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClassUnregisterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarListResponse> WebinarList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/live-webinar/get-live-webinars-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<WebinarListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarRegisterResponse> WebinarRegister([WorkflowExpression] Func<string> webinarId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<int> bodyzipCode = null)
        {
            SourceExpression.Validate(webinarId, nameof(webinarId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/register", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebinarRegisterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<WebinarUnregisterResponse> WebinarUnregister([WorkflowExpression] Func<string> webinarId, [WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(webinarId, nameof(webinarId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/live-webinar/{0}/unregister", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebinarUnregisterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollBriefResponse> ReportEnrollBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> courseId = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(courseId, nameof(courseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/enrollments/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (courseId != null)
                    callPayload.Queries["course_id"] = SourceExpressionConverter.ConvertO(courseId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportEnrollBriefResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportEnrollDetailResponse> ReportEnrollDetail([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> courseId = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(courseId, nameof(courseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/enrollments/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (courseId != null)
                    callPayload.Queries["course_id"] = SourceExpressionConverter.ConvertO(courseId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportEnrollDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesBriefResponse> ReportSalesBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> groupby = null, [WorkflowExpression] Func<string> courseIds = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(groupby, nameof(groupby), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/sales/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (groupby != null)
                    callPayload.Queries["groupby"] = SourceExpressionConverter.ConvertO(groupby);
                if (courseIds != null)
                    callPayload.Queries["course_ids"] = SourceExpressionConverter.ConvertO(courseIds);
                return callPayload;
            }

            return new ApiConnectionAction<ReportSalesBriefResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportSalesDetailedResponse> ReportSalesDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<int> paymentType = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            SourceExpression.Validate(paymentType, nameof(paymentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/sales/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids"] = SourceExpressionConverter.ConvertO(courseIds);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = SourceExpressionConverter.ConvertO(paymentType);
                return callPayload;
            }

            return new ApiConnectionAction<ReportSalesDetailedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressBriefResponse> ReportProgressBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/course-progress/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = SourceExpressionConverter.ConvertO(courseIds);
                return callPayload;
            }

            return new ApiConnectionAction<ReportProgressBriefResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportProgressDetailedResponse> ReportProgressDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> afV = null, [WorkflowExpression] Func<string> couponIs = null, [WorkflowExpression] Func<string> couponLike = null, [WorkflowExpression] Func<string> nameIs = null, [WorkflowExpression] Func<string> nameLike = null, [WorkflowExpression] Func<string> emailIs = null, [WorkflowExpression] Func<string> emailLike = null, [WorkflowExpression] Func<string> affiliateIs = null, [WorkflowExpression] Func<int> paymentType = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            SourceExpression.Validate(afV, nameof(afV), required: false);
            SourceExpression.Validate(couponIs, nameof(couponIs), required: false);
            SourceExpression.Validate(couponLike, nameof(couponLike), required: false);
            SourceExpression.Validate(nameIs, nameof(nameIs), required: false);
            SourceExpression.Validate(nameLike, nameof(nameLike), required: false);
            SourceExpression.Validate(emailIs, nameof(emailIs), required: false);
            SourceExpression.Validate(emailLike, nameof(emailLike), required: false);
            SourceExpression.Validate(affiliateIs, nameof(affiliateIs), required: false);
            SourceExpression.Validate(paymentType, nameof(paymentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/course-progress/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = SourceExpressionConverter.ConvertO(courseIds);
                if (afV != null)
                    callPayload.Queries["af_v"] = SourceExpressionConverter.ConvertO(afV);
                if (couponIs != null)
                    callPayload.Queries["coupon_is[]"] = SourceExpressionConverter.ConvertO(couponIs);
                if (couponLike != null)
                    callPayload.Queries["coupon_like[]"] = SourceExpressionConverter.ConvertO(couponLike);
                if (nameIs != null)
                    callPayload.Queries["name_is[]"] = SourceExpressionConverter.ConvertO(nameIs);
                if (nameLike != null)
                    callPayload.Queries["name_like[]"] = SourceExpressionConverter.ConvertO(nameLike);
                if (emailIs != null)
                    callPayload.Queries["email_is[]"] = SourceExpressionConverter.ConvertO(emailIs);
                if (emailLike != null)
                    callPayload.Queries["email_like[]"] = SourceExpressionConverter.ConvertO(emailLike);
                if (affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = SourceExpressionConverter.ConvertO(affiliateIs);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = SourceExpressionConverter.ConvertO(paymentType);
                return callPayload;
            }

            return new ApiConnectionAction<ReportProgressDetailedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateBriefResponse> ReportAffiliateBrief([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> affiliateIds = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            SourceExpression.Validate(affiliateIds, nameof(affiliateIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/affiliates/brief";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = SourceExpressionConverter.ConvertO(courseIds);
                if (affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = SourceExpressionConverter.ConvertO(affiliateIds);
                return callPayload;
            }

            return new ApiConnectionAction<ReportAffiliateBriefResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlerip")]
        public IBodyWorkflowAction<ReportAffiliateDetailedResponse> ReportAffiliateDetailed([WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> courseIds = null, [WorkflowExpression] Func<string> affiliateIds = null, [WorkflowExpression] Func<string> afV = null, [WorkflowExpression] Func<string> couponIs = null, [WorkflowExpression] Func<string> couponLike = null, [WorkflowExpression] Func<string> nameIs = null, [WorkflowExpression] Func<string> nameLike = null, [WorkflowExpression] Func<string> emailIs = null, [WorkflowExpression] Func<string> emailLike = null, [WorkflowExpression] Func<string> affiliateIs = null, [WorkflowExpression] Func<string> paymentType = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(courseIds, nameof(courseIds), required: false);
            SourceExpression.Validate(affiliateIds, nameof(affiliateIds), required: false);
            SourceExpression.Validate(afV, nameof(afV), required: false);
            SourceExpression.Validate(couponIs, nameof(couponIs), required: false);
            SourceExpression.Validate(couponLike, nameof(couponLike), required: false);
            SourceExpression.Validate(nameIs, nameof(nameIs), required: false);
            SourceExpression.Validate(nameLike, nameof(nameLike), required: false);
            SourceExpression.Validate(emailIs, nameof(emailIs), required: false);
            SourceExpression.Validate(emailLike, nameof(emailLike), required: false);
            SourceExpression.Validate(affiliateIs, nameof(affiliateIs), required: false);
            SourceExpression.Validate(paymentType, nameof(paymentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/affiliates/detailed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (courseIds != null)
                    callPayload.Queries["course_ids[]"] = SourceExpressionConverter.ConvertO(courseIds);
                if (affiliateIds != null)
                    callPayload.Queries["affiliate_ids[]"] = SourceExpressionConverter.ConvertO(affiliateIds);
                if (afV != null)
                    callPayload.Queries["af_v"] = SourceExpressionConverter.ConvertO(afV);
                if (couponIs != null)
                    callPayload.Queries["coupon_is[]"] = SourceExpressionConverter.ConvertO(couponIs);
                if (couponLike != null)
                    callPayload.Queries["coupon_like[]"] = SourceExpressionConverter.ConvertO(couponLike);
                if (nameIs != null)
                    callPayload.Queries["name_is[]"] = SourceExpressionConverter.ConvertO(nameIs);
                if (nameLike != null)
                    callPayload.Queries["name_like[]"] = SourceExpressionConverter.ConvertO(nameLike);
                if (emailIs != null)
                    callPayload.Queries["email_is[]"] = SourceExpressionConverter.ConvertO(emailIs);
                if (emailLike != null)
                    callPayload.Queries["email_like[]"] = SourceExpressionConverter.ConvertO(emailLike);
                if (affiliateIs != null)
                    callPayload.Queries["affiliate_is[]"] = SourceExpressionConverter.ConvertO(affiliateIs);
                if (paymentType != null)
                    callPayload.Queries["payment_type"] = SourceExpressionConverter.ConvertO(paymentType);
                return callPayload;
            }

            return new ApiConnectionAction<ReportAffiliateDetailedResponse>(BuildSourceInput);
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