//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eduframe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EduframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account, ApiConnectionActionConfiguration> PostAccounts(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddressAttributesaddress, Expression<Func<string>> bodyaddressAttributespostalCode, Expression<Func<string>> bodyaddressAttributescity, Expression<Func<string>> bodyaddressAttributescountry, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyaddressAttributesid = null, Expression<Func<string>> bodyaddressAttributesaddressee = null, Expression<Func<string>> bodyaddressAttributesupdatedAt = null, Expression<Func<string>> bodyaddressAttributescreatedAt = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyaddressAttributesaddress = WorkflowExpression.Compile(bodyaddressAttributesaddress, nameof(bodyaddressAttributesaddress), required: true);
            var __workflow_bodyaddressAttributespostalCode = WorkflowExpression.Compile(bodyaddressAttributespostalCode, nameof(bodyaddressAttributespostalCode), required: true);
            var __workflow_bodyaddressAttributescity = WorkflowExpression.Compile(bodyaddressAttributescity, nameof(bodyaddressAttributescity), required: true);
            var __workflow_bodyaddressAttributescountry = WorkflowExpression.Compile(bodyaddressAttributescountry, nameof(bodyaddressAttributescountry), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyaddressAttributesid = WorkflowExpression.Compile(bodyaddressAttributesid, nameof(bodyaddressAttributesid), required: false);
            var __workflow_bodyaddressAttributesaddressee = WorkflowExpression.Compile(bodyaddressAttributesaddressee, nameof(bodyaddressAttributesaddressee), required: false);
            var __workflow_bodyaddressAttributesupdatedAt = WorkflowExpression.Compile(bodyaddressAttributesupdatedAt, nameof(bodyaddressAttributesupdatedAt), required: false);
            var __workflow_bodyaddressAttributescreatedAt = WorkflowExpression.Compile(bodyaddressAttributescreatedAt, nameof(bodyaddressAttributescreatedAt), required: false);
            return new DeferredBodyAction<Account, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                var addressAttributesObject = new JObject();
                var addressAttributesObjectpropCount = 0;
                if (__workflow_bodyaddressAttributesid != null)
                {
                    addressAttributesObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesid);
                    addressAttributesObjectpropCount++;
                }

                if (__workflow_bodyaddressAttributesaddressee != null)
                {
                    addressAttributesObject["addressee"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesaddressee);
                    addressAttributesObjectpropCount++;
                }

                addressAttributesObjectpropCount++;
                addressAttributesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesaddress);
                addressAttributesObjectpropCount++;
                addressAttributesObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributespostalCode);
                addressAttributesObjectpropCount++;
                addressAttributesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescity);
                addressAttributesObjectpropCount++;
                addressAttributesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescountry);
                if (__workflow_bodyaddressAttributesupdatedAt != null)
                {
                    addressAttributesObject["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesupdatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (__workflow_bodyaddressAttributescreatedAt != null)
                {
                    addressAttributesObject["created_at"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescreatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (addressAttributesObjectpropCount > 0)
                {
                    body["address_attributes"] = addressAttributesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Account>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account[], ApiConnectionActionConfiguration> GetAccounts(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Account[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Account[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account, ApiConnectionActionConfiguration> GetAccountsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Account, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Account>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication, ApiConnectionActionConfiguration> PostAuthentication(Expression<Func<int>> bodyuserId, Expression<Func<bodyauthenticationProviderTypeInput>> bodyauthenticationProviderType, Expression<Func<string>> bodyuid)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodyauthenticationProviderType = WorkflowExpression.Compile(bodyauthenticationProviderType, nameof(bodyauthenticationProviderType), required: true);
            var __workflow_bodyuid = WorkflowExpression.Compile(bodyuid, nameof(bodyuid), required: true);
            return new DeferredBodyAction<Authentication, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/authentications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["authentication_provider_type"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationProviderType);
                bodypropCount++;
                body["uid"] = ExpressionConverter.ConvertO(__workflow_bodyuid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Authentication>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category, ApiConnectionActionConfiguration> PostCategories(Expression<Func<string>> bodyname, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyposition = null, Expression<Func<double>> bodyparentId = null, Expression<Func<string>> bodyavatar = null, Expression<Func<bool>> bodyisPublished = null, Expression<Func<double>> bodycoursesCount = null, Expression<Func<double>> bodychildrenCount = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodyavatarUrl = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyavatar = WorkflowExpression.Compile(bodyavatar, nameof(bodyavatar), required: false);
            var __workflow_bodyisPublished = WorkflowExpression.Compile(bodyisPublished, nameof(bodyisPublished), required: false);
            var __workflow_bodycoursesCount = WorkflowExpression.Compile(bodycoursesCount, nameof(bodycoursesCount), required: false);
            var __workflow_bodychildrenCount = WorkflowExpression.Compile(bodychildrenCount, nameof(bodychildrenCount), required: false);
            var __workflow_bodyupdatedAt = WorkflowExpression.Compile(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            var __workflow_bodycreatedAt = WorkflowExpression.Compile(bodycreatedAt, nameof(bodycreatedAt), required: false);
            var __workflow_bodyavatarUrl = WorkflowExpression.Compile(bodyavatarUrl, nameof(bodyavatarUrl), required: false);
            return new DeferredBodyAction<Category, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyavatar != null)
                {
                    body["avatar"] = ExpressionConverter.ConvertO(__workflow_bodyavatar);
                    bodypropCount++;
                }

                if (__workflow_bodyisPublished != null)
                {
                    if (__workflow_bodyisPublished != null)
                    {
                        body["is_published"] = ExpressionConverter.ConvertO(__workflow_bodyisPublished);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_published"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodycoursesCount != null)
                {
                    body["courses_count"] = ExpressionConverter.ConvertO(__workflow_bodycoursesCount);
                    bodypropCount++;
                }

                if (__workflow_bodychildrenCount != null)
                {
                    body["children_count"] = ExpressionConverter.ConvertO(__workflow_bodychildrenCount);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(__workflow_bodycreatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarUrl != null)
                {
                    body["avatar_url"] = ExpressionConverter.ConvertO(__workflow_bodyavatarUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Category>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category[], ApiConnectionActionConfiguration> GetCategories(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<Category[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<Category[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category, ApiConnectionActionConfiguration> GetCategoriesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Category, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Category>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course, ApiConnectionActionConfiguration> PostCourses(Expression<Func<string>> bodyname, Expression<Func<double>> bodycategoryId, Expression<Func<string>> bodycode, Expression<Func<int>> bodyid = null, Expression<Func<double>> bodyposition = null, Expression<Func<string>> bodysignupUrl = null, Expression<Func<string>> bodyavatar = null, Expression<Func<double>> bodycertificateTemplateId = null, Expression<Func<string>> bodycost = null, Expression<Func<bodycostSchemeInput>> bodycostScheme = null, Expression<Func<bool>> bodyisPublished = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodycreatedAt = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodysignupUrl = WorkflowExpression.Compile(bodysignupUrl, nameof(bodysignupUrl), required: false);
            var __workflow_bodyavatar = WorkflowExpression.Compile(bodyavatar, nameof(bodyavatar), required: false);
            var __workflow_bodycertificateTemplateId = WorkflowExpression.Compile(bodycertificateTemplateId, nameof(bodycertificateTemplateId), required: false);
            var __workflow_bodycost = WorkflowExpression.Compile(bodycost, nameof(bodycost), required: false);
            var __workflow_bodycostScheme = WorkflowExpression.Compile(bodycostScheme, nameof(bodycostScheme), required: false);
            var __workflow_bodyisPublished = WorkflowExpression.Compile(bodyisPublished, nameof(bodyisPublished), required: false);
            var __workflow_bodyupdatedAt = WorkflowExpression.Compile(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            var __workflow_bodycreatedAt = WorkflowExpression.Compile(bodycreatedAt, nameof(bodycreatedAt), required: false);
            return new DeferredBodyAction<Course, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodysignupUrl != null)
                {
                    body["signup_url"] = ExpressionConverter.ConvertO(__workflow_bodysignupUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyavatar != null)
                {
                    body["avatar"] = ExpressionConverter.ConvertO(__workflow_bodyavatar);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateTemplateId != null)
                {
                    body["certificate_template_id"] = ExpressionConverter.ConvertO(__workflow_bodycertificateTemplateId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["category_id"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                if (__workflow_bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(__workflow_bodycost);
                    bodypropCount++;
                }

                if (__workflow_bodycostScheme != null)
                {
                    body["cost_scheme"] = ExpressionConverter.ConvertO(__workflow_bodycostScheme);
                    bodypropCount++;
                }

                if (__workflow_bodyisPublished != null)
                {
                    if (__workflow_bodyisPublished != null)
                    {
                        body["is_published"] = ExpressionConverter.ConvertO(__workflow_bodyisPublished);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_published"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedAt != null)
                {
                    body["created_at"] = ExpressionConverter.ConvertO(__workflow_bodycreatedAt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Course>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course[], ApiConnectionActionConfiguration> GetCourses(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<Course[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<Course[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course, ApiConnectionActionConfiguration> GetCoursesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Course, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/courses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Course>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> PostUsers(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyaddressAttributesaddress, Expression<Func<string>> bodyaddressAttributespostalCode, Expression<Func<string>> bodyaddressAttributescity, Expression<Func<string>> bodyaddressAttributescountry, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyphone = null, Expression<Func<bool>> bodywantsNewsletter = null, Expression<Func<bool>> bodywithAuthentication = null, Expression<Func<bodylocaleInput>> bodylocale = null, Expression<Func<double[]>> bodylabelIds = null, Expression<Func<int>> bodyaddressAttributesid = null, Expression<Func<string>> bodyaddressAttributesaddressee = null, Expression<Func<string>> bodyaddressAttributesupdatedAt = null, Expression<Func<string>> bodyaddressAttributescreatedAt = null, Expression<Func<string>> bodynotesUser = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyaddressAttributesaddress = WorkflowExpression.Compile(bodyaddressAttributesaddress, nameof(bodyaddressAttributesaddress), required: true);
            var __workflow_bodyaddressAttributespostalCode = WorkflowExpression.Compile(bodyaddressAttributespostalCode, nameof(bodyaddressAttributespostalCode), required: true);
            var __workflow_bodyaddressAttributescity = WorkflowExpression.Compile(bodyaddressAttributescity, nameof(bodyaddressAttributescity), required: true);
            var __workflow_bodyaddressAttributescountry = WorkflowExpression.Compile(bodyaddressAttributescountry, nameof(bodyaddressAttributescountry), required: true);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodywantsNewsletter = WorkflowExpression.Compile(bodywantsNewsletter, nameof(bodywantsNewsletter), required: false);
            var __workflow_bodywithAuthentication = WorkflowExpression.Compile(bodywithAuthentication, nameof(bodywithAuthentication), required: false);
            var __workflow_bodylocale = WorkflowExpression.Compile(bodylocale, nameof(bodylocale), required: false);
            var __workflow_bodylabelIds = WorkflowExpression.Compile(bodylabelIds, nameof(bodylabelIds), required: false);
            var __workflow_bodyaddressAttributesid = WorkflowExpression.Compile(bodyaddressAttributesid, nameof(bodyaddressAttributesid), required: false);
            var __workflow_bodyaddressAttributesaddressee = WorkflowExpression.Compile(bodyaddressAttributesaddressee, nameof(bodyaddressAttributesaddressee), required: false);
            var __workflow_bodyaddressAttributesupdatedAt = WorkflowExpression.Compile(bodyaddressAttributesupdatedAt, nameof(bodyaddressAttributesupdatedAt), required: false);
            var __workflow_bodyaddressAttributescreatedAt = WorkflowExpression.Compile(bodyaddressAttributescreatedAt, nameof(bodyaddressAttributescreatedAt), required: false);
            var __workflow_bodynotesUser = WorkflowExpression.Compile(bodynotesUser, nameof(bodynotesUser), required: false);
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                if (__workflow_bodymiddleName != null)
                {
                    body["middle_name"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodywantsNewsletter != null)
                {
                    if (__workflow_bodywantsNewsletter != null)
                    {
                        body["wants_newsletter"] = ExpressionConverter.ConvertO(__workflow_bodywantsNewsletter);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["wants_newsletter"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodywithAuthentication != null)
                {
                    if (__workflow_bodywithAuthentication != null)
                    {
                        body["with_authentication"] = ExpressionConverter.ConvertO(__workflow_bodywithAuthentication);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["with_authentication"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodylocale != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(__workflow_bodylocale);
                    bodypropCount++;
                }

                if (__workflow_bodylabelIds != null)
                {
                    body["label_ids"] = ExpressionConverter.ConvertO(__workflow_bodylabelIds);
                    bodypropCount++;
                }

                var addressAttributesObject = new JObject();
                var addressAttributesObjectpropCount = 0;
                if (__workflow_bodyaddressAttributesid != null)
                {
                    addressAttributesObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesid);
                    addressAttributesObjectpropCount++;
                }

                if (__workflow_bodyaddressAttributesaddressee != null)
                {
                    addressAttributesObject["addressee"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesaddressee);
                    addressAttributesObjectpropCount++;
                }

                addressAttributesObjectpropCount++;
                addressAttributesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesaddress);
                addressAttributesObjectpropCount++;
                addressAttributesObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributespostalCode);
                addressAttributesObjectpropCount++;
                addressAttributesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescity);
                addressAttributesObjectpropCount++;
                addressAttributesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescountry);
                if (__workflow_bodyaddressAttributesupdatedAt != null)
                {
                    addressAttributesObject["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributesupdatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (__workflow_bodyaddressAttributescreatedAt != null)
                {
                    addressAttributesObject["created_at"] = ExpressionConverter.ConvertO(__workflow_bodyaddressAttributescreatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (addressAttributesObjectpropCount > 0)
                {
                    body["address_attributes"] = addressAttributesObject;
                    bodypropCount++;
                }

                if (__workflow_bodynotesUser != null)
                {
                    body["notes_user"] = ExpressionConverter.ConvertO(__workflow_bodynotesUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User[], ApiConnectionActionConfiguration> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<User[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<User[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> GetUsersId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication[], ApiConnectionActionConfiguration> GetAuthenticationsByUserId(Expression<Func<int>> userId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Authentication[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/authentications", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Authentication[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAuthenticationByUserId(Expression<Func<int>> userId, Expression<Func<int>> authenticationId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_authenticationId = WorkflowExpression.Compile(authenticationId, nameof(authenticationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/authentications/{1}", __workflow_userId.WithUrlEncoding(1), __workflow_authenticationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> PostInvoices(Expression<Func<double>> bodyaccountId, Expression<Func<bodycurrencyInput>> bodycurrency, Expression<Func<InvoiceItem[]>> bodyinvoiceItemsAttributes, Expression<Func<string>> bodyaccountName = null, Expression<Func<string>> bodyfeature = null, Expression<Func<string>> bodyfootnote = null)
        {
            var __workflow_bodyaccountId = WorkflowExpression.Compile(bodyaccountId, nameof(bodyaccountId), required: true);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: true);
            var __workflow_bodyinvoiceItemsAttributes = WorkflowExpression.Compile(bodyinvoiceItemsAttributes, nameof(bodyinvoiceItemsAttributes), required: true);
            var __workflow_bodyaccountName = WorkflowExpression.Compile(bodyaccountName, nameof(bodyaccountName), required: false);
            var __workflow_bodyfeature = WorkflowExpression.Compile(bodyfeature, nameof(bodyfeature), required: false);
            var __workflow_bodyfootnote = WorkflowExpression.Compile(bodyfootnote, nameof(bodyfootnote), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["account_id"] = ExpressionConverter.ConvertO(__workflow_bodyaccountId);
                if (__workflow_bodyaccountName != null)
                {
                    body["account_name"] = ExpressionConverter.ConvertO(__workflow_bodyaccountName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                bodypropCount++;
                body["invoice_items_attributes"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceItemsAttributes);
                if (__workflow_bodyfeature != null)
                {
                    body["feature"] = ExpressionConverter.ConvertO(__workflow_bodyfeature);
                    bodypropCount++;
                }

                if (__workflow_bodyfootnote != null)
                {
                    body["footnote"] = ExpressionConverter.ConvertO(__workflow_bodyfootnote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice[], ApiConnectionActionConfiguration> GetInvoices(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Invoice[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Invoice[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> GetInvoicesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat[], ApiConnectionActionConfiguration> GetInvoiceVats(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<InvoiceVat[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice_vats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<InvoiceVat[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat, ApiConnectionActionConfiguration> PostInvoiceVats(Expression<Func<string>> bodyname, Expression<Func<string>> bodypercentage, Expression<Func<int>> bodyid = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypercentage = WorkflowExpression.Compile(bodypercentage, nameof(bodypercentage), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            return new DeferredBodyAction<InvoiceVat, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice_vats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["percentage"] = ExpressionConverter.ConvertO(__workflow_bodypercentage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InvoiceVat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<CatalogVariant[], ApiConnectionActionConfiguration> GetCatalogVariants(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<CatalogVariant[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/variants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<CatalogVariant[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Label[], ApiConnectionActionConfiguration> GetLabels(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<modelTypeInput>> modelType = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_modelType = WorkflowExpression.Compile(modelType, nameof(modelType), required: false);
            return new DeferredBodyAction<Label[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_modelType != null)
                    callPayload.Queries["model_type"] = ExpressionConverter.Convert(__workflow_modelType);
                return new ApiConnectionAction<Label[]>(callPayload);
            });
        }
    }

    public class EduframeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Webhook, ApiConnectionTriggerConfiguration> PostWebhooks(Expression<Func<bodyeventsInputItem[]>> bodyevents, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyactive = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyevents = WorkflowExpression.Compile(bodyevents, nameof(bodyevents), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyactive = WorkflowExpression.Compile(bodyactive, nameof(bodyactive), required: false);
            return new DeferredBodyTrigger<Webhook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyactive != null)
                {
                    if (__workflow_bodyactive != null)
                    {
                        body["active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["active"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<Webhook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("account_type")]
        public AccountAccountTypeType AccountType { get; set; }

        [JsonProperty("address")]
        public AddressInfo Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("signup_answers")]
        public CustomField[] SignupAnswers { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccountAccountTypeType
    {
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "personal")]
        Personal
    }

    public class AddressInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("addressee")]
        public string Addressee { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class CustomField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("signup_question_id")]
        public int SignupQuestionId { get; set; }
    }

    public class Authentication
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("authentication_provider_id")]
        public int AuthenticationProviderId { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("otp_enabled")]
        public JToken IfOTPIsEnabledForThisLogin { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthenticationProviderTypeInput
    {
        [EnumMember(Value = "azure_active_directory")]
        AzureActiveDirectory,
        [EnumMember(Value = "eduframe")]
        Eduframe,
        [EnumMember(Value = "openid_connect")]
        OpenidConnect,
        [EnumMember(Value = "surf_conext")]
        SurfConext
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public double Position { get; set; }

        [JsonProperty("parent_id")]
        public double ParentId { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("is_published")]
        public bool IsPublished { get; set; }

        [JsonProperty("courses_count")]
        public double CoursesCount { get; set; }

        [JsonProperty("children_count")]
        public double ChildrenCount { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInputItem
    {
        [EnumMember(Value = "first_name")]
        FirstName,
        [EnumMember(Value = "last_name")]
        LastName,
        [EnumMember(Value = "middle_name")]
        MiddleName
    }

    public class Course
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public double Position { get; set; }

        [JsonProperty("starting_price")]
        public string StartingPrice { get; set; }

        [JsonProperty("signup_url")]
        public string SignupUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("slug_history")]
        public string[] SlugHistory { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatar_thumb_url")]
        public string AvatarThumbUrl { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("certificate_template_id")]
        public double CertificateTemplateId { get; set; }

        [JsonProperty("category_id")]
        public double CategoryId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("cost_scheme")]
        public CourseCostSchemeType CostScheme { get; set; }

        [JsonProperty("is_published")]
        public bool IsPublished { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CourseCostSchemeType
    {
        [EnumMember(Value = "student")]
        Student,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "tbd")]
        Tbd,
        [EnumMember(Value = "free")]
        Free
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycostSchemeInput
    {
        [EnumMember(Value = "student")]
        Student,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "tbd")]
        Tbd,
        [EnumMember(Value = "free")]
        Free
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("employee_number")]
        public string EmployeeNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("wants_newsletter")]
        public bool WantsNewsletter { get; set; }

        [JsonProperty("with_authentication")]
        public bool WithAuthentication { get; set; }

        [JsonProperty("locale")]
        public UserLocaleType Locale { get; set; }

        [JsonProperty("address")]
        public AddressInfo Address { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("teacher_headline")]
        public string TeacherHeadline { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("teacher_description")]
        public string TeacherDescription { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("notes_user")]
        public string NotesUser { get; set; }

        [JsonProperty("teacher_enrollments_count")]
        public double TeacherEnrollmentsCount { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class Label
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("model_type")]
        public LabelModelTypeType ModelType { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LabelModelTypeType
    {
        Lead,
        Order,
        [EnumMember(Value = "Catalog::Product")]
        CatalogProduct,
        User,
        Account,
        Teacher
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserLocaleType
    {
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "en_GB")]
        EnGB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylocaleInput
    {
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "en_GB")]
        EnGB
    }

    public class Invoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("account_id")]
        public double AccountId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("number_int")]
        public double NumberInt { get; set; }

        [JsonProperty("status")]
        public InvoiceStatusType Status { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("opened_at")]
        public string OpenedAt { get; set; }

        [JsonProperty("invoice_set_id")]
        public double InvoiceSetId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("currency")]
        public InvoiceCurrencyType Currency { get; set; }

        [JsonProperty("total_incl")]
        public string TotalIncl { get; set; }

        [JsonProperty("total_excl")]
        public string TotalExcl { get; set; }

        [JsonProperty("total_open")]
        public string TotalOpen { get; set; }

        [JsonProperty("pdf_url")]
        public string PdfUrl { get; set; }

        [JsonProperty("xml_url")]
        public string XmlUrl { get; set; }

        [JsonProperty("feature")]
        public string Feature { get; set; }

        [JsonProperty("footnote")]
        public string Footnote { get; set; }

        [JsonProperty("invoice_items")]
        public InvoiceItem[] InvoiceItems { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceStatusType
    {
        [EnumMember(Value = "concept")]
        Concept,
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceCurrencyType
    {
        EUR,
        ISK,
        USD,
        GBP
    }

    public class InvoiceItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("units")]
        public double Units { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }

        [JsonProperty("invoice_vat_id")]
        public double InvoiceVatId { get; set; }

        [JsonProperty("catalog_variant_id")]
        public double CatalogVariantId { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurrencyInput
    {
        EUR,
        ISK,
        USD,
        GBP
    }

    public class InvoiceVat
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }
    }

    public class CatalogVariant
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("product_id")]
        public double ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost_scheme")]
        public CatalogVariantCostSchemeType CostScheme { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("currency")]
        public CatalogVariantCurrencyType Currency { get; set; }

        [JsonProperty("variantable_type")]
        public CatalogVariantVariantableTypeType VariantableType { get; set; }

        [JsonProperty("variantable_id")]
        public double VariantableId { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_published")]
        public bool IsPublished { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CatalogVariantCostSchemeType
    {
        [EnumMember(Value = "student")]
        Student,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "tbd")]
        Tbd,
        [EnumMember(Value = "free")]
        Free
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CatalogVariantCurrencyType
    {
        EUR,
        ISK,
        USD,
        GBP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CatalogVariantVariantableTypeType
    {
        PlannedCourse,
        [EnumMember(Value = "Program::Edition")]
        ProgramEdition
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modelTypeInput
    {
        Lead,
        Order,
        [EnumMember(Value = "Catalog::Product")]
        CatalogProduct,
        User,
        Account,
        Teacher
    }

    public class Webhook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public WebhookEventsTypeItem[] Events { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookEventsTypeItem
    {
        [EnumMember(Value = "account.created")]
        AccountCreated,
        [EnumMember(Value = "account.deleted")]
        AccountDeleted,
        [EnumMember(Value = "account.updated")]
        AccountUpdated,
        [EnumMember(Value = "category.created")]
        CategoryCreated,
        [EnumMember(Value = "category.deleted")]
        CategoryDeleted,
        [EnumMember(Value = "category.updated")]
        CategoryUpdated,
        [EnumMember(Value = "course.created")]
        CourseCreated,
        [EnumMember(Value = "course.deleted")]
        CourseDeleted,
        [EnumMember(Value = "course.updated")]
        CourseUpdated,
        [EnumMember(Value = "course_location.created")]
        CourseLocationCreated,
        [EnumMember(Value = "course_location.deleted")]
        CourseLocationDeleted,
        [EnumMember(Value = "course_location.updated")]
        CourseLocationUpdated,
        [EnumMember(Value = "course_variant.created")]
        CourseVariantCreated,
        [EnumMember(Value = "course_variant.deleted")]
        CourseVariantDeleted,
        [EnumMember(Value = "course_variant.updated")]
        CourseVariantUpdated,
        [EnumMember(Value = "educator.created")]
        EducatorCreated,
        [EnumMember(Value = "educator.deleted")]
        EducatorDeleted,
        [EnumMember(Value = "educator.updated")]
        EducatorUpdated,
        [EnumMember(Value = "enrollment.created")]
        EnrollmentCreated,
        [EnumMember(Value = "enrollment.deleted")]
        EnrollmentDeleted,
        [EnumMember(Value = "enrollment.updated")]
        EnrollmentUpdated,
        [EnumMember(Value = "invoice.created")]
        InvoiceCreated,
        [EnumMember(Value = "invoice.deleted")]
        InvoiceDeleted,
        [EnumMember(Value = "invoice.updated")]
        InvoiceUpdated,
        [EnumMember(Value = "invoice_vat.created")]
        InvoiceVatCreated,
        [EnumMember(Value = "invoice_vat.deleted")]
        InvoiceVatDeleted,
        [EnumMember(Value = "invoice_vat.updated")]
        InvoiceVatUpdated,
        [EnumMember(Value = "lead.created")]
        LeadCreated,
        [EnumMember(Value = "lead.deleted")]
        LeadDeleted,
        [EnumMember(Value = "lead.updated")]
        LeadUpdated,
        [EnumMember(Value = "meeting.created")]
        MeetingCreated,
        [EnumMember(Value = "meeting.deleted")]
        MeetingDeleted,
        [EnumMember(Value = "meeting.updated")]
        MeetingUpdated,
        [EnumMember(Value = "meeting.teacher_attendees_changed")]
        MeetingTeacherAttendeesChanged,
        [EnumMember(Value = "meeting_location.created")]
        MeetingLocationCreated,
        [EnumMember(Value = "meeting_location.deleted")]
        MeetingLocationDeleted,
        [EnumMember(Value = "meeting_location.updated")]
        MeetingLocationUpdated,
        [EnumMember(Value = "order.created")]
        OrderCreated,
        [EnumMember(Value = "order.deleted")]
        OrderDeleted,
        [EnumMember(Value = "order.updated")]
        OrderUpdated,
        [EnumMember(Value = "payment.created")]
        PaymentCreated,
        [EnumMember(Value = "payment.deleted")]
        PaymentDeleted,
        [EnumMember(Value = "payment.updated")]
        PaymentUpdated,
        [EnumMember(Value = "planned_course.created")]
        PlannedCourseCreated,
        [EnumMember(Value = "planned_course.deleted")]
        PlannedCourseDeleted,
        [EnumMember(Value = "planned_course.updated")]
        PlannedCourseUpdated,
        [EnumMember(Value = "planning_event.created")]
        PlanningEventCreated,
        [EnumMember(Value = "planning_event.deleted")]
        PlanningEventDeleted,
        [EnumMember(Value = "planning_event.updated")]
        PlanningEventUpdated,
        [EnumMember(Value = "planning_event.teacher_attendees_changed")]
        PlanningEventTeacherAttendeesChanged,
        [EnumMember(Value = "teacher_role.created")]
        TeacherRoleCreated,
        [EnumMember(Value = "teacher_role.deleted")]
        TeacherRoleDeleted,
        [EnumMember(Value = "teacher_role.updated")]
        TeacherRoleUpdated,
        [EnumMember(Value = "user.created")]
        UserCreated,
        [EnumMember(Value = "user.deleted")]
        UserDeleted,
        [EnumMember(Value = "user.updated")]
        UserUpdated
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventsInputItem
    {
        [EnumMember(Value = "account.created")]
        AccountCreated,
        [EnumMember(Value = "account.deleted")]
        AccountDeleted,
        [EnumMember(Value = "account.updated")]
        AccountUpdated,
        [EnumMember(Value = "category.created")]
        CategoryCreated,
        [EnumMember(Value = "category.deleted")]
        CategoryDeleted,
        [EnumMember(Value = "category.updated")]
        CategoryUpdated,
        [EnumMember(Value = "course.created")]
        CourseCreated,
        [EnumMember(Value = "course.deleted")]
        CourseDeleted,
        [EnumMember(Value = "course.updated")]
        CourseUpdated,
        [EnumMember(Value = "course_location.created")]
        CourseLocationCreated,
        [EnumMember(Value = "course_location.deleted")]
        CourseLocationDeleted,
        [EnumMember(Value = "course_location.updated")]
        CourseLocationUpdated,
        [EnumMember(Value = "course_variant.created")]
        CourseVariantCreated,
        [EnumMember(Value = "course_variant.deleted")]
        CourseVariantDeleted,
        [EnumMember(Value = "course_variant.updated")]
        CourseVariantUpdated,
        [EnumMember(Value = "educator.created")]
        EducatorCreated,
        [EnumMember(Value = "educator.deleted")]
        EducatorDeleted,
        [EnumMember(Value = "educator.updated")]
        EducatorUpdated,
        [EnumMember(Value = "enrollment.created")]
        EnrollmentCreated,
        [EnumMember(Value = "enrollment.deleted")]
        EnrollmentDeleted,
        [EnumMember(Value = "enrollment.updated")]
        EnrollmentUpdated,
        [EnumMember(Value = "invoice.created")]
        InvoiceCreated,
        [EnumMember(Value = "invoice.deleted")]
        InvoiceDeleted,
        [EnumMember(Value = "invoice.updated")]
        InvoiceUpdated,
        [EnumMember(Value = "invoice_vat.created")]
        InvoiceVatCreated,
        [EnumMember(Value = "invoice_vat.deleted")]
        InvoiceVatDeleted,
        [EnumMember(Value = "invoice_vat.updated")]
        InvoiceVatUpdated,
        [EnumMember(Value = "lead.created")]
        LeadCreated,
        [EnumMember(Value = "lead.deleted")]
        LeadDeleted,
        [EnumMember(Value = "lead.updated")]
        LeadUpdated,
        [EnumMember(Value = "meeting.created")]
        MeetingCreated,
        [EnumMember(Value = "meeting.deleted")]
        MeetingDeleted,
        [EnumMember(Value = "meeting.updated")]
        MeetingUpdated,
        [EnumMember(Value = "meeting.teacher_attendees_changed")]
        MeetingTeacherAttendeesChanged,
        [EnumMember(Value = "meeting_location.created")]
        MeetingLocationCreated,
        [EnumMember(Value = "meeting_location.deleted")]
        MeetingLocationDeleted,
        [EnumMember(Value = "meeting_location.updated")]
        MeetingLocationUpdated,
        [EnumMember(Value = "order.created")]
        OrderCreated,
        [EnumMember(Value = "order.deleted")]
        OrderDeleted,
        [EnumMember(Value = "order.updated")]
        OrderUpdated,
        [EnumMember(Value = "payment.created")]
        PaymentCreated,
        [EnumMember(Value = "payment.deleted")]
        PaymentDeleted,
        [EnumMember(Value = "payment.updated")]
        PaymentUpdated,
        [EnumMember(Value = "planned_course.created")]
        PlannedCourseCreated,
        [EnumMember(Value = "planned_course.deleted")]
        PlannedCourseDeleted,
        [EnumMember(Value = "planned_course.updated")]
        PlannedCourseUpdated,
        [EnumMember(Value = "planning_event.created")]
        PlanningEventCreated,
        [EnumMember(Value = "planning_event.deleted")]
        PlanningEventDeleted,
        [EnumMember(Value = "planning_event.updated")]
        PlanningEventUpdated,
        [EnumMember(Value = "planning_event.teacher_attendees_changed")]
        PlanningEventTeacherAttendeesChanged,
        [EnumMember(Value = "teacher_role.created")]
        TeacherRoleCreated,
        [EnumMember(Value = "teacher_role.deleted")]
        TeacherRoleDeleted,
        [EnumMember(Value = "teacher_role.updated")]
        TeacherRoleUpdated,
        [EnumMember(Value = "user.created")]
        UserCreated,
        [EnumMember(Value = "user.deleted")]
        UserDeleted,
        [EnumMember(Value = "user.updated")]
        UserUpdated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eduframe;

    public partial class WorkflowManagedActions
    {
        public EduframeActions Eduframe(string connectionId) => new EduframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EduframeTriggers Eduframe(string connectionId) => new EduframeTriggers(connectionId);
    }
}