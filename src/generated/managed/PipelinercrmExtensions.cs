//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipelinercrm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipelinercrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsDeleteResponse> AccountsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<AccountsDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsGetResponse> AccountsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<AccountsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsUpdateResponse> AccountsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountTypeId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<bodyaccountClassInput>> bodyaccountClass = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyhomePage = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsCreateResponse> AccountsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyownerId, Expression<Func<string>> bodyaccountTypeId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<bodyaccountClassInput>> bodyaccountClass = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyhomePage = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Accounts", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsCreateResponse> ContactsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> bodylastName, Expression<Func<string>> bodyownerId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<bodygenderInput>> bodygender = null, Expression<Func<string>> bodycontactTypeId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<bodyaccountRelationsInputItem[]>> bodyaccountRelations = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Contacts", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsDeleteResponse> ContactsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<ContactsDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<ContactsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsUpdateResponse> ContactsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bodygenderInput>> bodygender = null, Expression<Func<string>> bodycontactTypeId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyemail1 = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsCreateResponse> LeadsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyownerId, Expression<Func<string>> bodyunitId, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyranking = null, Expression<Func<string>> bodyleadTypeId = null, Expression<Func<string>> bodystepId = null, Expression<Func<bodycontactRelationsInputItem[]>> bodycontactRelations = null, Expression<Func<bodyaccountRelationsInputItem[]>> bodyaccountRelations = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Leads", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsDeleteResponse> LeadsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<LeadsDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsGetResponse> LeadsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<LeadsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsUpdateResponse> LeadsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyranking = null, Expression<Func<string>> bodyleadTypeId = null, Expression<Func<string>> bodystepId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<string>> bodyownerId = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Leads/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksCreateResponse> TasksCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyunitId, Expression<Func<string>> bodyownerId, Expression<Func<string>> bodyactivityTypeId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bodyaccountRelationsInputItem2[]>> bodyaccountRelations = null, Expression<Func<bodycontactRelationsInputItem2[]>> bodycontactRelations = null, Expression<Func<bodyleadRelationsInputItem[]>> bodyleadRelations = null, Expression<Func<bodyopportunityRelationsInputItem[]>> bodyopportunityRelations = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Tasks", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksDeleteResponse> TasksDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<TasksDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksGetResponse> TasksGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<TasksGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksUpdateResponse> TasksUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyactivityTypeId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesDeleteResponse> OpportunitiesDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<OpportunitiesDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesGetResponse> OpportunitiesGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["service_url"] = ExpressionConverter.Convert(serviceUrl);
            return new ApiConnectionAction<OpportunitiesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesUpdateResponse> OpportunitiesUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyvaluebaseValue = null, Expression<Func<string>> bodyvaluecurrencyId = null, Expression<Func<double>> bodyvaluevalueForeign = null, Expression<Func<string>> bodyclosingDate = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyranking = null, Expression<Func<string>> bodyopptyTypeId = null, Expression<Func<string>> bodystepId = null, Expression<Func<string>> bodyunitId = null, Expression<Func<string>> bodyownerId = null)
        {
            var apiCallPath = String.Format("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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