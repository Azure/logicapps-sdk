//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipelinercrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipelinercrmActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountsDelete))]
        public IBodyWorkflowAction<AccountsDeleteResponse> AccountsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountsDeleteResponse> __BuildAccountsDelete(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<AccountsDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<AccountsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountsGet))]
        public IBodyWorkflowAction<AccountsGetResponse> AccountsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountsGetResponse> __BuildAccountsGet(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<AccountsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<AccountsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountsUpdate))]
        public IBodyWorkflowAction<AccountsUpdateResponse> AccountsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodyaccountClassInput> bodyaccountClass = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyhomePage = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountsUpdateResponse> __BuildAccountsUpdate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyaccountTypeId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<bodyaccountClassInput> bodyaccountClass = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyhomePage = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodystateProvince = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaccountTypeId, nameof(bodyaccountTypeId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyaccountClass, nameof(bodyaccountClass), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyhomePage, nameof(bodyhomePage), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<AccountsUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountTypeId != null)
                {
                    body["account_type_id"] = ExpressionConverter.ConvertO(bodyaccountTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyaccountClass != null)
                {
                    body["account_class"] = ExpressionConverter.ConvertO(bodyaccountClass);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyhomePage != null)
                {
                    body["home_page"] = ExpressionConverter.ConvertO(bodyhomePage);
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

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["state_province"] = ExpressionConverter.ConvertO(bodystateProvince);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AccountsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountsCreate))]
        public IBodyWorkflowAction<AccountsCreateResponse> AccountsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyaccountTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodyaccountClassInput> bodyaccountClass = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyhomePage = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountsCreateResponse> __BuildAccountsCreate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyownerId, WorkflowExpression<string> bodyaccountTypeId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<bodyaccountClassInput> bodyaccountClass = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyhomePage = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodystateProvince = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            WorkflowExpression.Validate(bodyaccountTypeId, nameof(bodyaccountTypeId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyaccountClass, nameof(bodyaccountClass), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyhomePage, nameof(bodyhomePage), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<AccountsCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                if (bodyaccountTypeId != null)
                {
                    body["account_type_id"] = ExpressionConverter.ConvertO(bodyaccountTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyaccountClass != null)
                {
                    body["account_class"] = ExpressionConverter.ConvertO(bodyaccountClass);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                    bodypropCount++;
                }

                if (bodyhomePage != null)
                {
                    body["home_page"] = ExpressionConverter.ConvertO(bodyhomePage);
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

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["state_province"] = ExpressionConverter.ConvertO(bodystateProvince);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AccountsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsCreate))]
        public IBodyWorkflowAction<ContactsCreateResponse> ContactsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<bodygenderInput> bodygender = null, [WorkflowExpression] Func<string> bodycontactTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsCreateResponse> __BuildContactsCreate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> bodylastName, WorkflowExpression<string> bodyownerId, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<bodygenderInput> bodygender = null, WorkflowExpression<string> bodycontactTypeId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystateProvince = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<bodyaccountRelationsInputItem[]> bodyaccountRelations = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodygender, nameof(bodygender), required: false);
            WorkflowExpression.Validate(bodycontactTypeId, nameof(bodycontactTypeId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ContactsCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = ExpressionConverter.ConvertO(bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                if (bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(bodygender);
                    bodypropCount++;
                }

                if (bodycontactTypeId != null)
                {
                    body["contact_type_id"] = ExpressionConverter.ConvertO(bodycontactTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
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

                if (bodystateProvince != null)
                {
                    body["state_province"] = ExpressionConverter.ConvertO(bodystateProvince);
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

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = ExpressionConverter.ConvertO(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsDelete))]
        public IBodyWorkflowAction<ContactsDeleteResponse> ContactsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsDeleteResponse> __BuildContactsDelete(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactsDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<ContactsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsGet))]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsGetResponse> __BuildContactsGet(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<ContactsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsUpdate))]
        public IBodyWorkflowAction<ContactsUpdateResponse> ContactsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bodygenderInput> bodygender = null, [WorkflowExpression] Func<string> bodycontactTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactsUpdateResponse> __BuildContactsUpdate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<bodygenderInput> bodygender = null, WorkflowExpression<string> bodycontactTypeId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyemail1 = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystateProvince = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodygender, nameof(bodygender), required: false);
            WorkflowExpression.Validate(bodycontactTypeId, nameof(bodycontactTypeId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ContactsUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = ExpressionConverter.ConvertO(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(bodygender);
                    bodypropCount++;
                }

                if (bodycontactTypeId != null)
                {
                    body["contact_type_id"] = ExpressionConverter.ConvertO(bodycontactTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = ExpressionConverter.ConvertO(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = ExpressionConverter.ConvertO(bodyphone1);
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

                if (bodystateProvince != null)
                {
                    body["state_province"] = ExpressionConverter.ConvertO(bodystateProvince);
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

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadsCreate))]
        public IBodyWorkflowAction<LeadsCreateResponse> LeadsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyunitId, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyleadTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<bodycontactRelationsInputItem[]> bodycontactRelations = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadsCreateResponse> __BuildLeadsCreate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyownerId, WorkflowExpression<string> bodyunitId, WorkflowExpression<string> bodycreated = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodyranking = null, WorkflowExpression<string> bodyleadTypeId = null, WorkflowExpression<string> bodystepId = null, WorkflowExpression<bodycontactRelationsInputItem[]> bodycontactRelations = null, WorkflowExpression<bodyaccountRelationsInputItem[]> bodyaccountRelations = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: true);
            WorkflowExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            WorkflowExpression.Validate(bodyleadTypeId, nameof(bodyleadTypeId), required: false);
            WorkflowExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            WorkflowExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            WorkflowExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            return new DeferredBodyAction<LeadsCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(bodycreated);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = ExpressionConverter.ConvertO(bodyranking);
                    bodypropCount++;
                }

                if (bodyleadTypeId != null)
                {
                    body["lead_type_id"] = ExpressionConverter.ConvertO(bodyleadTypeId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                if (bodystepId != null)
                {
                    body["step_id"] = ExpressionConverter.ConvertO(bodystepId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = ExpressionConverter.ConvertO(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = ExpressionConverter.ConvertO(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LeadsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadsDelete))]
        public IBodyWorkflowAction<LeadsDeleteResponse> LeadsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadsDeleteResponse> __BuildLeadsDelete(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadsDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<LeadsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadsGet))]
        public IBodyWorkflowAction<LeadsGetResponse> LeadsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadsGetResponse> __BuildLeadsGet(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<LeadsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadsUpdate))]
        public IBodyWorkflowAction<LeadsUpdateResponse> LeadsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyleadTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadsUpdateResponse> __BuildLeadsUpdate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id, WorkflowExpression<string> bodycreated = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodyranking = null, WorkflowExpression<string> bodyleadTypeId = null, WorkflowExpression<string> bodystepId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<string> bodyownerId = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            WorkflowExpression.Validate(bodyleadTypeId, nameof(bodyleadTypeId), required: false);
            WorkflowExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredBodyAction<LeadsUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(bodycreated);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = ExpressionConverter.ConvertO(bodyranking);
                    bodypropCount++;
                }

                if (bodyleadTypeId != null)
                {
                    body["lead_type_id"] = ExpressionConverter.ConvertO(bodyleadTypeId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["step_id"] = ExpressionConverter.ConvertO(bodystepId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LeadsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildTasksCreate))]
        public IBodyWorkflowAction<TasksCreateResponse> TasksCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodyunitId, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyactivityTypeId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem2[]> bodyaccountRelations = null, [WorkflowExpression] Func<bodycontactRelationsInputItem2[]> bodycontactRelations = null, [WorkflowExpression] Func<bodyleadRelationsInputItem[]> bodyleadRelations = null, [WorkflowExpression] Func<bodyopportunityRelationsInputItem[]> bodyopportunityRelations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksCreateResponse> __BuildTasksCreate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> bodysubject, WorkflowExpression<string> bodyunitId, WorkflowExpression<string> bodyownerId, WorkflowExpression<string> bodyactivityTypeId = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<bodyaccountRelationsInputItem2[]> bodyaccountRelations = null, WorkflowExpression<bodycontactRelationsInputItem2[]> bodycontactRelations = null, WorkflowExpression<bodyleadRelationsInputItem[]> bodyleadRelations = null, WorkflowExpression<bodyopportunityRelationsInputItem[]> bodyopportunityRelations = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            WorkflowExpression.Validate(bodyactivityTypeId, nameof(bodyactivityTypeId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            WorkflowExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            WorkflowExpression.Validate(bodyleadRelations, nameof(bodyleadRelations), required: false);
            WorkflowExpression.Validate(bodyopportunityRelations, nameof(bodyopportunityRelations), required: false);
            return new DeferredBodyAction<TasksCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                if (bodyactivityTypeId != null)
                {
                    body["activity_type_id"] = ExpressionConverter.ConvertO(bodyactivityTypeId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                bodypropCount++;
                body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = ExpressionConverter.ConvertO(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = ExpressionConverter.ConvertO(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodyleadRelations != null)
                {
                    body["lead_relations"] = ExpressionConverter.ConvertO(bodyleadRelations);
                    bodypropCount++;
                }

                if (bodyopportunityRelations != null)
                {
                    body["opportunity_relations"] = ExpressionConverter.ConvertO(bodyopportunityRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TasksCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildTasksDelete))]
        public IBodyWorkflowAction<TasksDeleteResponse> TasksDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksDeleteResponse> __BuildTasksDelete(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TasksDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<TasksDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildTasksGet))]
        public IBodyWorkflowAction<TasksGetResponse> TasksGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksGetResponse> __BuildTasksGet(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TasksGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<TasksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildTasksUpdate))]
        public IBodyWorkflowAction<TasksUpdateResponse> TasksUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyactivityTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksUpdateResponse> __BuildTasksUpdate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodyactivityTypeId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<bodystatusInput> bodystatus = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodyactivityTypeId, nameof(bodyactivityTypeId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<TasksUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodyactivityTypeId != null)
                {
                    body["activity_type_id"] = ExpressionConverter.ConvertO(bodyactivityTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TasksUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunitiesCreate))]
        public IBodyWorkflowAction<OpportunitiesCreateResponse> OpportunitiesCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyclosingDate, [WorkflowExpression] Func<string> bodyopptyTypeId, [WorkflowExpression] Func<string> bodystepId, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<double> bodyvaluebaseValue = null, [WorkflowExpression] Func<string> bodyvaluecurrencyId = null, [WorkflowExpression] Func<double> bodyvaluevalueForeign = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodycontactRelationsInputItem[]> bodycontactRelations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunitiesCreateResponse> __BuildOpportunitiesCreate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyclosingDate, WorkflowExpression<string> bodyopptyTypeId, WorkflowExpression<string> bodystepId, WorkflowExpression<string> bodyownerId, WorkflowExpression<bodyaccountRelationsInputItem[]> bodyaccountRelations, WorkflowExpression<string> bodycreated = null, WorkflowExpression<double> bodyvaluebaseValue = null, WorkflowExpression<string> bodyvaluecurrencyId = null, WorkflowExpression<double> bodyvaluevalueForeign = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodyranking = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<bodycontactRelationsInputItem[]> bodycontactRelations = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyclosingDate, nameof(bodyclosingDate), required: true);
            WorkflowExpression.Validate(bodyopptyTypeId, nameof(bodyopptyTypeId), required: true);
            WorkflowExpression.Validate(bodystepId, nameof(bodystepId), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            WorkflowExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: true);
            WorkflowExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            WorkflowExpression.Validate(bodyvaluebaseValue, nameof(bodyvaluebaseValue), required: false);
            WorkflowExpression.Validate(bodyvaluecurrencyId, nameof(bodyvaluecurrencyId), required: false);
            WorkflowExpression.Validate(bodyvaluevalueForeign, nameof(bodyvaluevalueForeign), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            return new DeferredBodyAction<OpportunitiesCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(bodycreated);
                    bodypropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyvaluebaseValue != null)
                {
                    valueObject["base_value"] = ExpressionConverter.ConvertO(bodyvaluebaseValue);
                    valueObjectpropCount++;
                }

                if (bodyvaluecurrencyId != null)
                {
                    valueObject["currency_id"] = ExpressionConverter.ConvertO(bodyvaluecurrencyId);
                    valueObjectpropCount++;
                }

                if (bodyvaluevalueForeign != null)
                {
                    valueObject["value_foreign"] = ExpressionConverter.ConvertO(bodyvaluevalueForeign);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    body["value"] = valueObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["closing_date"] = ExpressionConverter.ConvertO(bodyclosingDate);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = ExpressionConverter.ConvertO(bodyranking);
                    bodypropCount++;
                }

                bodypropCount++;
                body["oppty_type_id"] = ExpressionConverter.ConvertO(bodyopptyTypeId);
                bodypropCount++;
                body["step_id"] = ExpressionConverter.ConvertO(bodystepId);
                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                bodypropCount++;
                body["account_relations"] = ExpressionConverter.ConvertO(bodyaccountRelations);
                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = ExpressionConverter.ConvertO(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunitiesCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunitiesDelete))]
        public IBodyWorkflowAction<OpportunitiesDeleteResponse> OpportunitiesDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunitiesDeleteResponse> __BuildOpportunitiesDelete(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<OpportunitiesDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<OpportunitiesDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunitiesGet))]
        public IBodyWorkflowAction<OpportunitiesGetResponse> OpportunitiesGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunitiesGetResponse> __BuildOpportunitiesGet(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<OpportunitiesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                return new ApiConnectionAction<OpportunitiesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunitiesUpdate))]
        public IBodyWorkflowAction<OpportunitiesUpdateResponse> OpportunitiesUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyvaluebaseValue = null, [WorkflowExpression] Func<string> bodyvaluecurrencyId = null, [WorkflowExpression] Func<double> bodyvaluevalueForeign = null, [WorkflowExpression] Func<string> bodyclosingDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyopptyTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunitiesUpdateResponse> __BuildOpportunitiesUpdate(WorkflowExpression<string> serviceUrl, WorkflowExpression<string> spaceId, WorkflowExpression<string> id, WorkflowExpression<string> bodycreated = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<double> bodyvaluebaseValue = null, WorkflowExpression<string> bodyvaluecurrencyId = null, WorkflowExpression<double> bodyvaluevalueForeign = null, WorkflowExpression<string> bodyclosingDate = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodyranking = null, WorkflowExpression<string> bodyopptyTypeId = null, WorkflowExpression<string> bodystepId = null, WorkflowExpression<string> bodyunitId = null, WorkflowExpression<string> bodyownerId = null)
        {
            WorkflowExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            WorkflowExpression.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyvaluebaseValue, nameof(bodyvaluebaseValue), required: false);
            WorkflowExpression.Validate(bodyvaluecurrencyId, nameof(bodyvaluecurrencyId), required: false);
            WorkflowExpression.Validate(bodyvaluevalueForeign, nameof(bodyvaluevalueForeign), required: false);
            WorkflowExpression.Validate(bodyclosingDate, nameof(bodyclosingDate), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            WorkflowExpression.Validate(bodyopptyTypeId, nameof(bodyopptyTypeId), required: false);
            WorkflowExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            WorkflowExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredBodyAction<OpportunitiesUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(bodycreated);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyvaluebaseValue != null)
                {
                    valueObject["base_value"] = ExpressionConverter.ConvertO(bodyvaluebaseValue);
                    valueObjectpropCount++;
                }

                if (bodyvaluecurrencyId != null)
                {
                    valueObject["currency_id"] = ExpressionConverter.ConvertO(bodyvaluecurrencyId);
                    valueObjectpropCount++;
                }

                if (bodyvaluevalueForeign != null)
                {
                    valueObject["value_foreign"] = ExpressionConverter.ConvertO(bodyvaluevalueForeign);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    body["value"] = valueObject;
                    bodypropCount++;
                }

                if (bodyclosingDate != null)
                {
                    body["closing_date"] = ExpressionConverter.ConvertO(bodyclosingDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = ExpressionConverter.ConvertO(bodyranking);
                    bodypropCount++;
                }

                if (bodyopptyTypeId != null)
                {
                    body["oppty_type_id"] = ExpressionConverter.ConvertO(bodyopptyTypeId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["step_id"] = ExpressionConverter.ConvertO(bodystepId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = ExpressionConverter.ConvertO(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunitiesUpdateResponse>(callPayload);
            });
        }
    }

    public class PipelinercrmTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class AccountsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsGetResponseDataType Data { get; set; }
    }

    public class AccountsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class AccountsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsUpdateResponseDataType Data { get; set; }
    }

    public class AccountsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public enum bodyaccountClassInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public class AccountsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsCreateResponseDataType Data { get; set; }
    }

    public class AccountsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class ContactsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsCreateResponseDataType Data { get; set; }
    }

    public class ContactsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public enum bodygenderInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class bodyaccountRelationsInputItem
    {
        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class ContactsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class ContactsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsGetResponseDataType Data { get; set; }
    }

    public class ContactsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class ContactsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsUpdateResponseDataType Data { get; set; }
    }

    public class ContactsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class LeadsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsCreateResponseDataType Data { get; set; }
    }

    public class LeadsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class bodycontactRelationsInputItem
    {
        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class LeadsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class LeadsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsGetResponseDataType Data { get; set; }
    }

    public class LeadsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class LeadsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsUpdateResponseDataType Data { get; set; }
    }

    public class LeadsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class TasksCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksCreateResponseDataType Data { get; set; }
    }

    public class TasksCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public enum bodypriorityInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public class bodyaccountRelationsInputItem2
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class bodycontactRelationsInputItem2
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class bodyleadRelationsInputItem
    {
        [JsonProperty("lead_oppty_id")]
        public string LeadOpptyId { get; set; }
    }

    public class bodyopportunityRelationsInputItem
    {
        [JsonProperty("lead_oppty_id")]
        public string LeadOpptyId { get; set; }
    }

    public class TasksDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class TasksGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksGetResponseDataType Data { get; set; }
    }

    public class TasksGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class TasksUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksUpdateResponseDataType Data { get; set; }
    }

    public class TasksUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesCreateResponseDataType Data { get; set; }
    }

    public class OpportunitiesCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesCreateResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesCreateResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }

    public class OpportunitiesDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class OpportunitiesGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesGetResponseDataType Data { get; set; }
    }

    public class OpportunitiesGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesGetResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesGetResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }

    public class OpportunitiesUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesUpdateResponseDataType Data { get; set; }
    }

    public class OpportunitiesUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesUpdateResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesUpdateResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pipelinercrm;

    public partial class WorkflowManagedActions
    {
        public PipelinercrmActions Pipelinercrm(string connectionId) => new PipelinercrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PipelinercrmTriggers Pipelinercrm(string connectionId) => new PipelinercrmTriggers(connectionId);
    }
}