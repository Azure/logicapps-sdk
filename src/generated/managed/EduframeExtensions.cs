//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eduframe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EduframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account> PostAccounts([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyaddressAttributesaddress, [WorkflowExpression] Func<string> bodyaddressAttributespostalCode, [WorkflowExpression] Func<string> bodyaddressAttributescity, [WorkflowExpression] Func<string> bodyaddressAttributescountry, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyaddressAttributesid = null, [WorkflowExpression] Func<string> bodyaddressAttributesaddressee = null, [WorkflowExpression] Func<string> bodyaddressAttributesupdatedAt = null, [WorkflowExpression] Func<string> bodyaddressAttributescreatedAt = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                var addressAttributesObject = new JObject();
                var addressAttributesObjectpropCount = 0;
                if (bodyaddressAttributesid != null)
                {
                    addressAttributesObject["id"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesid);
                    addressAttributesObjectpropCount++;
                }

                if (bodyaddressAttributesaddressee != null)
                {
                    addressAttributesObject["addressee"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesaddressee);
                    addressAttributesObjectpropCount++;
                }

                addressAttributesObjectpropCount++;
                addressAttributesObject["address"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesaddress);
                addressAttributesObjectpropCount++;
                addressAttributesObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributespostalCode);
                addressAttributesObjectpropCount++;
                addressAttributesObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescity);
                addressAttributesObjectpropCount++;
                addressAttributesObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescountry);
                if (bodyaddressAttributesupdatedAt != null)
                {
                    addressAttributesObject["updated_at"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesupdatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (bodyaddressAttributescreatedAt != null)
                {
                    addressAttributesObject["created_at"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescreatedAt);
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
                return callPayload;
            }

            return new ApiConnectionAction<Account>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account[]> GetAccounts([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Account[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account> GetAccountsId([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Account>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication> PostAuthentication([WorkflowExpression] Func<int> bodyuserId, [WorkflowExpression] Func<bodyauthenticationProviderTypeInput> bodyauthenticationProviderType, [WorkflowExpression] Func<string> bodyuid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/authentications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["authentication_provider_type"] = SourceExpressionConverter.Convert(bodyauthenticationProviderType);
                bodypropCount++;
                body["uid"] = SourceExpressionConverter.ConvertToken(bodyuid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Authentication>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category> PostCategories([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<double> bodyposition = null, [WorkflowExpression] Func<double> bodyparentId = null, [WorkflowExpression] Func<string> bodyavatar = null, [WorkflowExpression] Func<bool> bodyisPublished = null, [WorkflowExpression] Func<double> bodycoursesCount = null, [WorkflowExpression] Func<double> bodychildrenCount = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodycreatedAt = null, [WorkflowExpression] Func<string> bodyavatarUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyavatar != null)
                {
                    body["avatar"] = SourceExpressionConverter.ConvertToken(bodyavatar);
                    bodypropCount++;
                }

                if (bodyisPublished != null)
                {
                    if (bodyisPublished != null)
                    {
                        body["is_published"] = SourceExpressionConverter.ConvertToken(bodyisPublished);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_published"] = true;
                    bodypropCount++;
                }

                if (bodycoursesCount != null)
                {
                    body["courses_count"] = SourceExpressionConverter.ConvertToken(bodycoursesCount);
                    bodypropCount++;
                }

                if (bodychildrenCount != null)
                {
                    body["children_count"] = SourceExpressionConverter.ConvertToken(bodychildrenCount);
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = SourceExpressionConverter.ConvertToken(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodycreatedAt != null)
                {
                    body["created_at"] = SourceExpressionConverter.ConvertToken(bodycreatedAt);
                    bodypropCount++;
                }

                if (bodyavatarUrl != null)
                {
                    body["avatar_url"] = SourceExpressionConverter.ConvertToken(bodyavatarUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Category>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category[]> GetCategories([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<sortInputItem[]> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<Category[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category> GetCategoriesId([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Category>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course> PostCourses([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodycategoryId, [WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<double> bodyposition = null, [WorkflowExpression] Func<string> bodysignupUrl = null, [WorkflowExpression] Func<string> bodyavatar = null, [WorkflowExpression] Func<double> bodycertificateTemplateId = null, [WorkflowExpression] Func<string> bodycost = null, [WorkflowExpression] Func<bodycostSchemeInput> bodycostScheme = null, [WorkflowExpression] Func<bool> bodyisPublished = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string> bodycreatedAt = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodysignupUrl != null)
                {
                    body["signup_url"] = SourceExpressionConverter.ConvertToken(bodysignupUrl);
                    bodypropCount++;
                }

                if (bodyavatar != null)
                {
                    body["avatar"] = SourceExpressionConverter.ConvertToken(bodyavatar);
                    bodypropCount++;
                }

                if (bodycertificateTemplateId != null)
                {
                    body["certificate_template_id"] = SourceExpressionConverter.ConvertToken(bodycertificateTemplateId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["category_id"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                if (bodycost != null)
                {
                    body["cost"] = SourceExpressionConverter.ConvertToken(bodycost);
                    bodypropCount++;
                }

                if (bodycostScheme != null)
                {
                    body["cost_scheme"] = SourceExpressionConverter.Convert(bodycostScheme);
                    bodypropCount++;
                }

                if (bodyisPublished != null)
                {
                    if (bodyisPublished != null)
                    {
                        body["is_published"] = SourceExpressionConverter.ConvertToken(bodyisPublished);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_published"] = true;
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = SourceExpressionConverter.ConvertToken(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodycreatedAt != null)
                {
                    body["created_at"] = SourceExpressionConverter.ConvertToken(bodycreatedAt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Course>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course[]> GetCourses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<sortInputItem[]> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/courses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<Course[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course> GetCoursesId([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/courses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Course>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User> PostUsers([WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyaddressAttributesaddress, [WorkflowExpression] Func<string> bodyaddressAttributespostalCode, [WorkflowExpression] Func<string> bodyaddressAttributescity, [WorkflowExpression] Func<string> bodyaddressAttributescountry, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<bool> bodywantsNewsletter = null, [WorkflowExpression] Func<bool> bodywithAuthentication = null, [WorkflowExpression] Func<bodylocaleInput> bodylocale = null, [WorkflowExpression] Func<double[]> bodylabelIds = null, [WorkflowExpression] Func<int> bodyaddressAttributesid = null, [WorkflowExpression] Func<string> bodyaddressAttributesaddressee = null, [WorkflowExpression] Func<string> bodyaddressAttributesupdatedAt = null, [WorkflowExpression] Func<string> bodyaddressAttributescreatedAt = null, [WorkflowExpression] Func<string> bodynotesUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodywantsNewsletter != null)
                {
                    if (bodywantsNewsletter != null)
                    {
                        body["wants_newsletter"] = SourceExpressionConverter.ConvertToken(bodywantsNewsletter);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["wants_newsletter"] = false;
                    bodypropCount++;
                }

                if (bodywithAuthentication != null)
                {
                    if (bodywithAuthentication != null)
                    {
                        body["with_authentication"] = SourceExpressionConverter.ConvertToken(bodywithAuthentication);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["with_authentication"] = true;
                    bodypropCount++;
                }

                if (bodylocale != null)
                {
                    body["locale"] = SourceExpressionConverter.Convert(bodylocale);
                    bodypropCount++;
                }

                if (bodylabelIds != null)
                {
                    body["label_ids"] = SourceExpressionConverter.ConvertToken(bodylabelIds);
                    bodypropCount++;
                }

                var addressAttributesObject = new JObject();
                var addressAttributesObjectpropCount = 0;
                if (bodyaddressAttributesid != null)
                {
                    addressAttributesObject["id"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesid);
                    addressAttributesObjectpropCount++;
                }

                if (bodyaddressAttributesaddressee != null)
                {
                    addressAttributesObject["addressee"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesaddressee);
                    addressAttributesObjectpropCount++;
                }

                addressAttributesObjectpropCount++;
                addressAttributesObject["address"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesaddress);
                addressAttributesObjectpropCount++;
                addressAttributesObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributespostalCode);
                addressAttributesObjectpropCount++;
                addressAttributesObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescity);
                addressAttributesObjectpropCount++;
                addressAttributesObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescountry);
                if (bodyaddressAttributesupdatedAt != null)
                {
                    addressAttributesObject["updated_at"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributesupdatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (bodyaddressAttributescreatedAt != null)
                {
                    addressAttributesObject["created_at"] = SourceExpressionConverter.ConvertToken(bodyaddressAttributescreatedAt);
                    addressAttributesObjectpropCount++;
                }

                if (addressAttributesObjectpropCount > 0)
                {
                    body["address_attributes"] = addressAttributesObject;
                    bodypropCount++;
                }

                if (bodynotesUser != null)
                {
                    body["notes_user"] = SourceExpressionConverter.ConvertToken(bodynotesUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<User>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User[]> GetUsers([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<sortInputItem[]> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<User[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User> GetUsersId([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<User>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication[]> GetAuthenticationsByUserId([WorkflowExpression] Func<int> userId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/authentications", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Authentication[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IWorkflowAction DeleteAuthenticationByUserId([WorkflowExpression] Func<int> userId, [WorkflowExpression] Func<int> authenticationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/authentications/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(authenticationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice> PostInvoices([WorkflowExpression] Func<double> bodyaccountId, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency, [WorkflowExpression] Func<InvoiceItem[]> bodyinvoiceItemsAttributes, [WorkflowExpression] Func<string> bodyaccountName = null, [WorkflowExpression] Func<string> bodyfeature = null, [WorkflowExpression] Func<string> bodyfootnote = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["account_id"] = SourceExpressionConverter.ConvertToken(bodyaccountId);
                if (bodyaccountName != null)
                {
                    body["account_name"] = SourceExpressionConverter.ConvertToken(bodyaccountName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["currency"] = SourceExpressionConverter.Convert(bodycurrency);
                bodypropCount++;
                body["invoice_items_attributes"] = SourceExpressionConverter.ConvertToken(bodyinvoiceItemsAttributes);
                if (bodyfeature != null)
                {
                    body["feature"] = SourceExpressionConverter.ConvertToken(bodyfeature);
                    bodypropCount++;
                }

                if (bodyfootnote != null)
                {
                    body["footnote"] = SourceExpressionConverter.ConvertToken(bodyfootnote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Invoice>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice[]> GetInvoices([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Invoice[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice> GetInvoicesId([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Invoice>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat[]> GetInvoiceVats([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice_vats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceVat[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat> PostInvoiceVats([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypercentage, [WorkflowExpression] Func<int> bodyid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice_vats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["percentage"] = SourceExpressionConverter.ConvertToken(bodypercentage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceVat>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<CatalogVariant[]> GetCatalogVariants([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/variants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<CatalogVariant[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Label[]> GetLabels([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<modelTypeInput> modelType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (modelType != null)
                    callPayload.Queries["model_type"] = SourceExpressionConverter.Convert(modelType);
                return callPayload;
            }

            return new ApiConnectionAction<Label[]>(BuildSourceInput);
        }
    }

    public class EduframeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Webhook> PostWebhooks([WorkflowExpression] Func<bodyeventsInputItem[]> bodyevents, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyactive = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyactive != null)
                {
                    if (bodyactive != null)
                    {
                        body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
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
                body["events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<Webhook>(BuildSourceInput, triggerName, recurrence);
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

    public enum CatalogVariantCurrencyType
    {
        EUR,
        ISK,
        USD,
        GBP
    }

    public enum CatalogVariantVariantableTypeType
    {
        PlannedCourse,
        [EnumMember(Value = "Program::Edition")]
        ProgramEdition
    }

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