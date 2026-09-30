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
        public IBodyWorkflowAction<AccountsDeleteResponse> AccountsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<AccountsDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsGetResponse> AccountsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<AccountsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsUpdateResponse> AccountsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodyaccountClassInput> bodyaccountClass = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyhomePage = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaccountTypeId, nameof(bodyaccountTypeId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyaccountClass, nameof(bodyaccountClass), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyhomePage, nameof(bodyhomePage), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountTypeId != null)
                {
                    body["account_type_id"] = SourceExpressionConverter.ConvertToken(bodyaccountTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyaccountClass != null)
                {
                    body["account_class"] = SourceExpressionConverter.Convert(bodyaccountClass);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyhomePage != null)
                {
                    body["home_page"] = SourceExpressionConverter.ConvertToken(bodyhomePage);
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

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["state_province"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AccountsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsCreateResponse> AccountsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyaccountTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodyaccountClassInput> bodyaccountClass = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyhomePage = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            SourceExpression.Validate(bodyaccountTypeId, nameof(bodyaccountTypeId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyaccountClass, nameof(bodyaccountClass), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyhomePage, nameof(bodyhomePage), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                if (bodyaccountTypeId != null)
                {
                    body["account_type_id"] = SourceExpressionConverter.ConvertToken(bodyaccountTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyaccountClass != null)
                {
                    body["account_class"] = SourceExpressionConverter.Convert(bodyaccountClass);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyhomePage != null)
                {
                    body["home_page"] = SourceExpressionConverter.ConvertToken(bodyhomePage);
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

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["state_province"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AccountsCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsCreateResponse> ContactsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<bodygenderInput> bodygender = null, [WorkflowExpression] Func<string> bodycontactTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodycontactTypeId, nameof(bodycontactTypeId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.Convert(bodygender);
                    bodypropCount++;
                }

                if (bodycontactTypeId != null)
                {
                    body["contact_type_id"] = SourceExpressionConverter.ConvertToken(bodycontactTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
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

                if (bodystateProvince != null)
                {
                    body["state_province"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
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

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = SourceExpressionConverter.ConvertToken(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactsCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsDeleteResponse> ContactsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<ContactsDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<ContactsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsUpdateResponse> ContactsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bodygenderInput> bodygender = null, [WorkflowExpression] Func<string> bodycontactTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyemail1 = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodycontactTypeId, nameof(bodycontactTypeId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyemail1, nameof(bodyemail1), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystateProvince, nameof(bodystateProvince), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.Convert(bodygender);
                    bodypropCount++;
                }

                if (bodycontactTypeId != null)
                {
                    body["contact_type_id"] = SourceExpressionConverter.ConvertToken(bodycontactTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyemail1 != null)
                {
                    body["email1"] = SourceExpressionConverter.ConvertToken(bodyemail1);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
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

                if (bodystateProvince != null)
                {
                    body["state_province"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
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

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsCreateResponse> LeadsCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyunitId, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyleadTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<bodycontactRelationsInputItem[]> bodycontactRelations = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            SourceExpression.Validate(bodyleadTypeId, nameof(bodyleadTypeId), required: false);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            SourceExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            SourceExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = SourceExpressionConverter.ConvertToken(bodyranking);
                    bodypropCount++;
                }

                if (bodyleadTypeId != null)
                {
                    body["lead_type_id"] = SourceExpressionConverter.ConvertToken(bodyleadTypeId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                if (bodystepId != null)
                {
                    body["step_id"] = SourceExpressionConverter.ConvertToken(bodystepId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = SourceExpressionConverter.ConvertToken(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = SourceExpressionConverter.ConvertToken(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LeadsCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsDeleteResponse> LeadsDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<LeadsDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsGetResponse> LeadsGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<LeadsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsUpdateResponse> LeadsUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyleadTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            SourceExpression.Validate(bodyleadTypeId, nameof(bodyleadTypeId), required: false);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = SourceExpressionConverter.ConvertToken(bodyranking);
                    bodypropCount++;
                }

                if (bodyleadTypeId != null)
                {
                    body["lead_type_id"] = SourceExpressionConverter.ConvertToken(bodyleadTypeId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["step_id"] = SourceExpressionConverter.ConvertToken(bodystepId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LeadsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksCreateResponse> TasksCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodyunitId, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<string> bodyactivityTypeId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bodyaccountRelationsInputItem2[]> bodyaccountRelations = null, [WorkflowExpression] Func<bodycontactRelationsInputItem2[]> bodycontactRelations = null, [WorkflowExpression] Func<bodyleadRelationsInputItem[]> bodyleadRelations = null, [WorkflowExpression] Func<bodyopportunityRelationsInputItem[]> bodyopportunityRelations = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            SourceExpression.Validate(bodyactivityTypeId, nameof(bodyactivityTypeId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: false);
            SourceExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            SourceExpression.Validate(bodyleadRelations, nameof(bodyleadRelations), required: false);
            SourceExpression.Validate(bodyopportunityRelations, nameof(bodyopportunityRelations), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodyactivityTypeId != null)
                {
                    body["activity_type_id"] = SourceExpressionConverter.ConvertToken(bodyactivityTypeId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                bodypropCount++;
                body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountRelations != null)
                {
                    body["account_relations"] = SourceExpressionConverter.ConvertToken(bodyaccountRelations);
                    bodypropCount++;
                }

                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = SourceExpressionConverter.ConvertToken(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodyleadRelations != null)
                {
                    body["lead_relations"] = SourceExpressionConverter.ConvertToken(bodyleadRelations);
                    bodypropCount++;
                }

                if (bodyopportunityRelations != null)
                {
                    body["opportunity_relations"] = SourceExpressionConverter.ConvertToken(bodyopportunityRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TasksCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksDeleteResponse> TasksDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<TasksDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksGetResponse> TasksGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<TasksGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksUpdateResponse> TasksUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyactivityTypeId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyactivityTypeId, nameof(bodyactivityTypeId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodyactivityTypeId != null)
                {
                    body["activity_type_id"] = SourceExpressionConverter.ConvertToken(bodyactivityTypeId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TasksUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesCreateResponse> OpportunitiesCreate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyclosingDate, [WorkflowExpression] Func<string> bodyopptyTypeId, [WorkflowExpression] Func<string> bodystepId, [WorkflowExpression] Func<string> bodyownerId, [WorkflowExpression] Func<bodyaccountRelationsInputItem[]> bodyaccountRelations, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<double> bodyvaluebaseValue = null, [WorkflowExpression] Func<string> bodyvaluecurrencyId = null, [WorkflowExpression] Func<double> bodyvaluevalueForeign = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<bodycontactRelationsInputItem[]> bodycontactRelations = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyclosingDate, nameof(bodyclosingDate), required: true);
            SourceExpression.Validate(bodyopptyTypeId, nameof(bodyopptyTypeId), required: true);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: true);
            SourceExpression.Validate(bodyaccountRelations, nameof(bodyaccountRelations), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodyvaluebaseValue, nameof(bodyvaluebaseValue), required: false);
            SourceExpression.Validate(bodyvaluecurrencyId, nameof(bodyvaluecurrencyId), required: false);
            SourceExpression.Validate(bodyvaluevalueForeign, nameof(bodyvaluevalueForeign), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodycontactRelations, nameof(bodycontactRelations), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyvaluebaseValue != null)
                {
                    valueObject["base_value"] = SourceExpressionConverter.ConvertToken(bodyvaluebaseValue);
                    valueObjectpropCount++;
                }

                if (bodyvaluecurrencyId != null)
                {
                    valueObject["currency_id"] = SourceExpressionConverter.ConvertToken(bodyvaluecurrencyId);
                    valueObjectpropCount++;
                }

                if (bodyvaluevalueForeign != null)
                {
                    valueObject["value_foreign"] = SourceExpressionConverter.ConvertToken(bodyvaluevalueForeign);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    body["value"] = valueObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["closing_date"] = SourceExpressionConverter.ConvertToken(bodyclosingDate);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = SourceExpressionConverter.ConvertToken(bodyranking);
                    bodypropCount++;
                }

                bodypropCount++;
                body["oppty_type_id"] = SourceExpressionConverter.ConvertToken(bodyopptyTypeId);
                bodypropCount++;
                body["step_id"] = SourceExpressionConverter.ConvertToken(bodystepId);
                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
                body["account_relations"] = SourceExpressionConverter.ConvertToken(bodyaccountRelations);
                if (bodycontactRelations != null)
                {
                    body["contact_relations"] = SourceExpressionConverter.ConvertToken(bodycontactRelations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunitiesCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesDeleteResponse> OpportunitiesDelete([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunitiesDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesGetResponse> OpportunitiesGet([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunitiesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesUpdateResponse> OpportunitiesUpdate([WorkflowExpression] Func<string> serviceUrl, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyvaluebaseValue = null, [WorkflowExpression] Func<string> bodyvaluecurrencyId = null, [WorkflowExpression] Func<double> bodyvaluevalueForeign = null, [WorkflowExpression] Func<string> bodyclosingDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyranking = null, [WorkflowExpression] Func<string> bodyopptyTypeId = null, [WorkflowExpression] Func<string> bodystepId = null, [WorkflowExpression] Func<string> bodyunitId = null, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            SourceExpression.Validate(serviceUrl, nameof(serviceUrl), required: true);
            SourceExpression.Validate(spaceId, nameof(spaceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyvaluebaseValue, nameof(bodyvaluebaseValue), required: false);
            SourceExpression.Validate(bodyvaluecurrencyId, nameof(bodyvaluecurrencyId), required: false);
            SourceExpression.Validate(bodyvaluevalueForeign, nameof(bodyvaluevalueForeign), required: false);
            SourceExpression.Validate(bodyclosingDate, nameof(bodyclosingDate), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyranking, nameof(bodyranking), required: false);
            SourceExpression.Validate(bodyopptyTypeId, nameof(bodyopptyTypeId), required: false);
            SourceExpression.Validate(bodystepId, nameof(bodystepId), required: false);
            SourceExpression.Validate(bodyunitId, nameof(bodyunitId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = SourceExpressionConverter.ConvertO(serviceUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyvaluebaseValue != null)
                {
                    valueObject["base_value"] = SourceExpressionConverter.ConvertToken(bodyvaluebaseValue);
                    valueObjectpropCount++;
                }

                if (bodyvaluecurrencyId != null)
                {
                    valueObject["currency_id"] = SourceExpressionConverter.ConvertToken(bodyvaluecurrencyId);
                    valueObjectpropCount++;
                }

                if (bodyvaluevalueForeign != null)
                {
                    valueObject["value_foreign"] = SourceExpressionConverter.ConvertToken(bodyvaluevalueForeign);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    body["value"] = valueObject;
                    bodypropCount++;
                }

                if (bodyclosingDate != null)
                {
                    body["closing_date"] = SourceExpressionConverter.ConvertToken(bodyclosingDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyranking != null)
                {
                    body["ranking"] = SourceExpressionConverter.ConvertToken(bodyranking);
                    bodypropCount++;
                }

                if (bodyopptyTypeId != null)
                {
                    body["oppty_type_id"] = SourceExpressionConverter.ConvertToken(bodyopptyTypeId);
                    bodypropCount++;
                }

                if (bodystepId != null)
                {
                    body["step_id"] = SourceExpressionConverter.ConvertToken(bodystepId);
                    bodypropCount++;
                }

                if (bodyunitId != null)
                {
                    body["unit_id"] = SourceExpressionConverter.ConvertToken(bodyunitId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunitiesUpdateResponse>(BuildSourceInput);
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
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
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
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum bodystatusInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
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