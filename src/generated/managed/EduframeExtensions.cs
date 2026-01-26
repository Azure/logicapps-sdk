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
        public IBodyWorkflowAction<Account> PostAccounts(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddressAttributesaddress, Expression<Func<string>> bodyaddressAttributespostalCode, Expression<Func<string>> bodyaddressAttributescity, Expression<Func<string>> bodyaddressAttributescountry, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyaddressAttributesid = null, Expression<Func<string>> bodyaddressAttributesaddressee = null, Expression<Func<string>> bodyaddressAttributesupdatedAt = null, Expression<Func<string>> bodyaddressAttributescreatedAt = null)
        {
            var apiCallPath = "/accounts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            var address_attributesObject = new JObject();
            var address_attributesObjectpropCount = 0;
            if (bodyaddressAttributesid != null)
            {
                address_attributesObject["id"] = ExpressionConverter.ConvertO(bodyaddressAttributesid);
                address_attributesObjectpropCount++;
            }

            if (bodyaddressAttributesaddressee != null)
            {
                address_attributesObject["addressee"] = ExpressionConverter.ConvertO(bodyaddressAttributesaddressee);
                address_attributesObjectpropCount++;
            }

            address_attributesObjectpropCount++;
            address_attributesObject["address"] = ExpressionConverter.ConvertO(bodyaddressAttributesaddress);
            address_attributesObjectpropCount++;
            address_attributesObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddressAttributespostalCode);
            address_attributesObjectpropCount++;
            address_attributesObject["city"] = ExpressionConverter.ConvertO(bodyaddressAttributescity);
            address_attributesObjectpropCount++;
            address_attributesObject["country"] = ExpressionConverter.ConvertO(bodyaddressAttributescountry);
            if (bodyaddressAttributesupdatedAt != null)
            {
                address_attributesObject["updated_at"] = ExpressionConverter.ConvertO(bodyaddressAttributesupdatedAt);
                address_attributesObjectpropCount++;
            }

            if (bodyaddressAttributescreatedAt != null)
            {
                address_attributesObject["created_at"] = ExpressionConverter.ConvertO(bodyaddressAttributescreatedAt);
                address_attributesObjectpropCount++;
            }

            if (address_attributesObjectpropCount > 0)
            {
                body["address_attributes"] = address_attributesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Account>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account[]> GetAccounts(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<Account[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Account> GetAccountsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/accounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Account>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication> PostAuthentication(Expression<Func<int>> bodyuserId, Expression<Func<bodyauthenticationProviderTypeInput>> bodyauthenticationProviderType, Expression<Func<string>> bodyuid)
        {
            var apiCallPath = "/authentications";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
            bodypropCount++;
            body["authentication_provider_type"] = ExpressionConverter.ConvertO(bodyauthenticationProviderType);
            bodypropCount++;
            body["uid"] = ExpressionConverter.ConvertO(bodyuid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Authentication>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category> PostCategories(Expression<Func<string>> bodyname, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyposition = null, Expression<Func<double>> bodyparentId = null, Expression<Func<string>> bodyavatar = null, Expression<Func<bool>> bodyisPublished = null, Expression<Func<double>> bodycoursesCount = null, Expression<Func<double>> bodychildrenCount = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodyavatarUrl = null)
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parent_id"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodyavatar != null)
            {
                body["avatar"] = ExpressionConverter.ConvertO(bodyavatar);
                bodypropCount++;
            }

            if (bodyisPublished != null)
            {
                body["is_published"] = ExpressionConverter.ConvertO(bodyisPublished);
                bodypropCount++;
            }

            if (bodycoursesCount != null)
            {
                body["courses_count"] = ExpressionConverter.ConvertO(bodycoursesCount);
                bodypropCount++;
            }

            if (bodychildrenCount != null)
            {
                body["children_count"] = ExpressionConverter.ConvertO(bodychildrenCount);
                bodypropCount++;
            }

            if (bodyupdatedAt != null)
            {
                body["updated_at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                bodypropCount++;
            }

            if (bodycreatedAt != null)
            {
                body["created_at"] = ExpressionConverter.ConvertO(bodycreatedAt);
                bodypropCount++;
            }

            if (bodyavatarUrl != null)
            {
                body["avatar_url"] = ExpressionConverter.ConvertO(bodyavatarUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Category>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category[]> GetCategories(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<Category[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Category> GetCategoriesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Category>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course> PostCourses(Expression<Func<string>> bodyname, Expression<Func<double>> bodycategoryId, Expression<Func<string>> bodycode, Expression<Func<int>> bodyid = null, Expression<Func<double>> bodyposition = null, Expression<Func<string>> bodysignupUrl = null, Expression<Func<string>> bodyavatar = null, Expression<Func<double>> bodycertificateTemplateId = null, Expression<Func<string>> bodycost = null, Expression<Func<bodycostSchemeInput>> bodycostScheme = null, Expression<Func<bool>> bodyisPublished = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodycreatedAt = null)
        {
            var apiCallPath = "/courses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodysignupUrl != null)
            {
                body["signup_url"] = ExpressionConverter.ConvertO(bodysignupUrl);
                bodypropCount++;
            }

            if (bodyavatar != null)
            {
                body["avatar"] = ExpressionConverter.ConvertO(bodyavatar);
                bodypropCount++;
            }

            if (bodycertificateTemplateId != null)
            {
                body["certificate_template_id"] = ExpressionConverter.ConvertO(bodycertificateTemplateId);
                bodypropCount++;
            }

            bodypropCount++;
            body["category_id"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["code"] = ExpressionConverter.ConvertO(bodycode);
            if (bodycost != null)
            {
                body["cost"] = ExpressionConverter.ConvertO(bodycost);
                bodypropCount++;
            }

            if (bodycostScheme != null)
            {
                body["cost_scheme"] = ExpressionConverter.ConvertO(bodycostScheme);
                bodypropCount++;
            }

            if (bodyisPublished != null)
            {
                body["is_published"] = ExpressionConverter.ConvertO(bodyisPublished);
                bodypropCount++;
            }

            if (bodyupdatedAt != null)
            {
                body["updated_at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                bodypropCount++;
            }

            if (bodycreatedAt != null)
            {
                body["created_at"] = ExpressionConverter.ConvertO(bodycreatedAt);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Course>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course[]> GetCourses(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var apiCallPath = "/courses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<Course[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Course> GetCoursesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/courses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Course>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User> PostUsers(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyaddressAttributesaddress, Expression<Func<string>> bodyaddressAttributespostalCode, Expression<Func<string>> bodyaddressAttributescity, Expression<Func<string>> bodyaddressAttributescountry, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyphone = null, Expression<Func<bool>> bodywantsNewsletter = null, Expression<Func<bool>> bodywithAuthentication = null, Expression<Func<bodylocaleInput>> bodylocale = null, Expression<Func<double[]>> bodylabelIds = null, Expression<Func<int>> bodyaddressAttributesid = null, Expression<Func<string>> bodyaddressAttributesaddressee = null, Expression<Func<string>> bodyaddressAttributesupdatedAt = null, Expression<Func<string>> bodyaddressAttributescreatedAt = null, Expression<Func<string>> bodynotesUser = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
            if (bodymiddleName != null)
            {
                body["middle_name"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            bodypropCount++;
            body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyphone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodywantsNewsletter != null)
            {
                body["wants_newsletter"] = ExpressionConverter.ConvertO(bodywantsNewsletter);
                bodypropCount++;
            }

            if (bodywithAuthentication != null)
            {
                body["with_authentication"] = ExpressionConverter.ConvertO(bodywithAuthentication);
                bodypropCount++;
            }

            if (bodylocale != null)
            {
                body["locale"] = ExpressionConverter.ConvertO(bodylocale);
                bodypropCount++;
            }

            if (bodylabelIds != null)
            {
                body["label_ids"] = ExpressionConverter.ConvertO(bodylabelIds);
                bodypropCount++;
            }

            var address_attributesObject = new JObject();
            var address_attributesObjectpropCount = 0;
            if (bodyaddressAttributesid != null)
            {
                address_attributesObject["id"] = ExpressionConverter.ConvertO(bodyaddressAttributesid);
                address_attributesObjectpropCount++;
            }

            if (bodyaddressAttributesaddressee != null)
            {
                address_attributesObject["addressee"] = ExpressionConverter.ConvertO(bodyaddressAttributesaddressee);
                address_attributesObjectpropCount++;
            }

            address_attributesObjectpropCount++;
            address_attributesObject["address"] = ExpressionConverter.ConvertO(bodyaddressAttributesaddress);
            address_attributesObjectpropCount++;
            address_attributesObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddressAttributespostalCode);
            address_attributesObjectpropCount++;
            address_attributesObject["city"] = ExpressionConverter.ConvertO(bodyaddressAttributescity);
            address_attributesObjectpropCount++;
            address_attributesObject["country"] = ExpressionConverter.ConvertO(bodyaddressAttributescountry);
            if (bodyaddressAttributesupdatedAt != null)
            {
                address_attributesObject["updated_at"] = ExpressionConverter.ConvertO(bodyaddressAttributesupdatedAt);
                address_attributesObjectpropCount++;
            }

            if (bodyaddressAttributescreatedAt != null)
            {
                address_attributesObject["created_at"] = ExpressionConverter.ConvertO(bodyaddressAttributescreatedAt);
                address_attributesObjectpropCount++;
            }

            if (address_attributesObjectpropCount > 0)
            {
                body["address_attributes"] = address_attributesObject;
                bodypropCount++;
            }

            if (bodynotesUser != null)
            {
                body["notes_user"] = ExpressionConverter.ConvertO(bodynotesUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User[]> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortInputItem[]>> sort = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<User[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<User> GetUsersId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Authentication[]> GetAuthenticationsByUserId(Expression<Func<int>> userId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/users/{0}/authentications", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<Authentication[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IWorkflowAction DeleteAuthenticationByUserId(Expression<Func<int>> userId, Expression<Func<int>> authenticationId)
        {
            var apiCallPath = String.Format("/users/{0}/authentications/{1}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1), ExpressionConverter.ConvertWithUrlEncoding(authenticationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice> PostInvoices(Expression<Func<double>> bodyaccountId, Expression<Func<bodycurrencyInput>> bodycurrency, Expression<Func<InvoiceItem[]>> bodyinvoiceItemsAttributes, Expression<Func<string>> bodyaccountName = null, Expression<Func<string>> bodyfeature = null, Expression<Func<string>> bodyfootnote = null)
        {
            var apiCallPath = "/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["account_id"] = ExpressionConverter.ConvertO(bodyaccountId);
            if (bodyaccountName != null)
            {
                body["account_name"] = ExpressionConverter.ConvertO(bodyaccountName);
                bodypropCount++;
            }

            bodypropCount++;
            body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
            bodypropCount++;
            body["invoice_items_attributes"] = ExpressionConverter.ConvertO(bodyinvoiceItemsAttributes);
            if (bodyfeature != null)
            {
                body["feature"] = ExpressionConverter.ConvertO(bodyfeature);
                bodypropCount++;
            }

            if (bodyfootnote != null)
            {
                body["footnote"] = ExpressionConverter.ConvertO(bodyfootnote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Invoice>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice[]> GetInvoices(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<Invoice[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Invoice> GetInvoicesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Invoice>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat[]> GetInvoiceVats(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/invoice_vats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<InvoiceVat[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<InvoiceVat> PostInvoiceVats(Expression<Func<string>> bodyname, Expression<Func<string>> bodypercentage, Expression<Func<int>> bodyid = null)
        {
            var apiCallPath = "/invoice_vats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["percentage"] = ExpressionConverter.ConvertO(bodypercentage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InvoiceVat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<CatalogVariant[]> GetCatalogVariants(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/catalog/variants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<CatalogVariant[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eduframe")]
        public IBodyWorkflowAction<Label[]> GetLabels(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<modelTypeInput>> modelType = null)
        {
            var apiCallPath = "/labels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(25);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (modelType != null)
                callPayload.Queries["model_type"] = ExpressionConverter.Convert(modelType);
            return new ApiConnectionAction<Label[]>(callPayload);
        }
    }

    public class EduframeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Webhook> PostWebhooks(Expression<Func<bodyeventsInputItem[]>> bodyevents, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyactive = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            bodypropCount++;
            body["events"] = ExpressionConverter.ConvertO(bodyevents);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<Webhook>(callPayload, triggerName, recurrence);
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