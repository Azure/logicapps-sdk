//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TxtsyncActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS[]> SendSMS(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodymessage, Expression<Func<string>> bodyto)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            return new DeferredBodyAction<SMS[]>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["From"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SMS[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS> SendBulkSMS(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodymessage, Expression<Func<string[]>> bodyto = null, Expression<Func<string[]>> bodytoTagName = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodytoTagName = bodytoTagName == null ? null : WorkflowExpression.Compile(bodytoTagName);
            WorkflowExpression.Validate(__workflow_bodytoTagName, nameof(bodytoTagName), required: false);
            return new DeferredBodyAction<SMS>(() =>
            {
                var apiCallPath = "/sms/send/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["From"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                if (__workflow_bodyto != null)
                {
                    body["To"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodytoTagName != null)
                {
                    body["ToTagName"] = ExpressionConverter.ConvertO(__workflow_bodytoTagName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SMS>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SearchContactResponseItem[]> SearchContact(Expression<Func<string>> search)
        {
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: true);
            return new DeferredBodyAction<SearchContactResponseItem[]>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<SearchContactResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<AddContactResponse> AddContact(Expression<Func<string>> bodymobileNumber, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<string>> bodytagNames = null)
        {
            var __workflow_bodymobileNumber = bodymobileNumber == null ? null : WorkflowExpression.Compile(bodymobileNumber);
            WorkflowExpression.Validate(__workflow_bodymobileNumber, nameof(bodymobileNumber), required: true);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyexternalReference = bodyexternalReference == null ? null : WorkflowExpression.Compile(bodyexternalReference);
            WorkflowExpression.Validate(__workflow_bodyexternalReference, nameof(bodyexternalReference), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyaddressLine1 = bodyaddressLine1 == null ? null : WorkflowExpression.Compile(bodyaddressLine1);
            WorkflowExpression.Validate(__workflow_bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = bodyaddressLine2 == null ? null : WorkflowExpression.Compile(bodyaddressLine2);
            WorkflowExpression.Validate(__workflow_bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycounty = bodycounty == null ? null : WorkflowExpression.Compile(bodycounty);
            WorkflowExpression.Validate(__workflow_bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodypostcode = bodypostcode == null ? null : WorkflowExpression.Compile(bodypostcode);
            WorkflowExpression.Validate(__workflow_bodypostcode, nameof(bodypostcode), required: false);
            var __workflow_bodycountry = bodycountry == null ? null : WorkflowExpression.Compile(bodycountry);
            WorkflowExpression.Validate(__workflow_bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycustom01 = bodycustom01 == null ? null : WorkflowExpression.Compile(bodycustom01);
            WorkflowExpression.Validate(__workflow_bodycustom01, nameof(bodycustom01), required: false);
            var __workflow_bodycustom02 = bodycustom02 == null ? null : WorkflowExpression.Compile(bodycustom02);
            WorkflowExpression.Validate(__workflow_bodycustom02, nameof(bodycustom02), required: false);
            var __workflow_bodycustom03 = bodycustom03 == null ? null : WorkflowExpression.Compile(bodycustom03);
            WorkflowExpression.Validate(__workflow_bodycustom03, nameof(bodycustom03), required: false);
            var __workflow_bodycustom04 = bodycustom04 == null ? null : WorkflowExpression.Compile(bodycustom04);
            WorkflowExpression.Validate(__workflow_bodycustom04, nameof(bodycustom04), required: false);
            var __workflow_bodycustom05 = bodycustom05 == null ? null : WorkflowExpression.Compile(bodycustom05);
            WorkflowExpression.Validate(__workflow_bodycustom05, nameof(bodycustom05), required: false);
            var __workflow_bodytagNames = bodytagNames == null ? null : WorkflowExpression.Compile(bodytagNames);
            WorkflowExpression.Validate(__workflow_bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<AddContactResponse>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MobileNumber"] = ExpressionConverter.ConvertO(__workflow_bodymobileNumber);
                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReference);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostcode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(__workflow_bodycustom01);
                    bodypropCount++;
                }

                if (__workflow_bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(__workflow_bodycustom02);
                    bodypropCount++;
                }

                if (__workflow_bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(__workflow_bodycustom03);
                    bodypropCount++;
                }

                if (__workflow_bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(__workflow_bodycustom04);
                    bodypropCount++;
                }

                if (__workflow_bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(__workflow_bodycustom05);
                    bodypropCount++;
                }

                if (__workflow_bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(__workflow_bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContact(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymobileNumber = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<bool>> bodyallowSMS = null, Expression<Func<string>> bodytagNames = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymobileNumber = bodymobileNumber == null ? null : WorkflowExpression.Compile(bodymobileNumber);
            WorkflowExpression.Validate(__workflow_bodymobileNumber, nameof(bodymobileNumber), required: false);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyexternalReference = bodyexternalReference == null ? null : WorkflowExpression.Compile(bodyexternalReference);
            WorkflowExpression.Validate(__workflow_bodyexternalReference, nameof(bodyexternalReference), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyaddressLine1 = bodyaddressLine1 == null ? null : WorkflowExpression.Compile(bodyaddressLine1);
            WorkflowExpression.Validate(__workflow_bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = bodyaddressLine2 == null ? null : WorkflowExpression.Compile(bodyaddressLine2);
            WorkflowExpression.Validate(__workflow_bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycounty = bodycounty == null ? null : WorkflowExpression.Compile(bodycounty);
            WorkflowExpression.Validate(__workflow_bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodypostcode = bodypostcode == null ? null : WorkflowExpression.Compile(bodypostcode);
            WorkflowExpression.Validate(__workflow_bodypostcode, nameof(bodypostcode), required: false);
            var __workflow_bodycountry = bodycountry == null ? null : WorkflowExpression.Compile(bodycountry);
            WorkflowExpression.Validate(__workflow_bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycustom01 = bodycustom01 == null ? null : WorkflowExpression.Compile(bodycustom01);
            WorkflowExpression.Validate(__workflow_bodycustom01, nameof(bodycustom01), required: false);
            var __workflow_bodycustom02 = bodycustom02 == null ? null : WorkflowExpression.Compile(bodycustom02);
            WorkflowExpression.Validate(__workflow_bodycustom02, nameof(bodycustom02), required: false);
            var __workflow_bodycustom03 = bodycustom03 == null ? null : WorkflowExpression.Compile(bodycustom03);
            WorkflowExpression.Validate(__workflow_bodycustom03, nameof(bodycustom03), required: false);
            var __workflow_bodycustom04 = bodycustom04 == null ? null : WorkflowExpression.Compile(bodycustom04);
            WorkflowExpression.Validate(__workflow_bodycustom04, nameof(bodycustom04), required: false);
            var __workflow_bodycustom05 = bodycustom05 == null ? null : WorkflowExpression.Compile(bodycustom05);
            WorkflowExpression.Validate(__workflow_bodycustom05, nameof(bodycustom05), required: false);
            var __workflow_bodyallowSMS = bodyallowSMS == null ? null : WorkflowExpression.Compile(bodyallowSMS);
            WorkflowExpression.Validate(__workflow_bodyallowSMS, nameof(bodyallowSMS), required: false);
            var __workflow_bodytagNames = bodytagNames == null ? null : WorkflowExpression.Compile(bodytagNames);
            WorkflowExpression.Validate(__workflow_bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<UpdateContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodymobileNumber != null)
                {
                    body["MobileNumber"] = ExpressionConverter.ConvertO(__workflow_bodymobileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReference);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostcode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(__workflow_bodycustom01);
                    bodypropCount++;
                }

                if (__workflow_bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(__workflow_bodycustom02);
                    bodypropCount++;
                }

                if (__workflow_bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(__workflow_bodycustom03);
                    bodypropCount++;
                }

                if (__workflow_bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(__workflow_bodycustom04);
                    bodypropCount++;
                }

                if (__workflow_bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(__workflow_bodycustom05);
                    bodypropCount++;
                }

                if (__workflow_bodyallowSMS != null)
                {
                    body["AllowSMS"] = ExpressionConverter.ConvertO(__workflow_bodyallowSMS);
                    bodypropCount++;
                }

                if (__workflow_bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(__workflow_bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse> GetContactByExternalReference(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<GetContactByExternalReferenceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<GetContactByExternalReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContactByExternalReference(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> UpdateContactByExternalReference(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymobileNumber = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<bool>> bodyallowSMS = null, Expression<Func<string>> bodytagNames = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymobileNumber = bodymobileNumber == null ? null : WorkflowExpression.Compile(bodymobileNumber);
            WorkflowExpression.Validate(__workflow_bodymobileNumber, nameof(bodymobileNumber), required: false);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyexternalReference = bodyexternalReference == null ? null : WorkflowExpression.Compile(bodyexternalReference);
            WorkflowExpression.Validate(__workflow_bodyexternalReference, nameof(bodyexternalReference), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyaddressLine1 = bodyaddressLine1 == null ? null : WorkflowExpression.Compile(bodyaddressLine1);
            WorkflowExpression.Validate(__workflow_bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = bodyaddressLine2 == null ? null : WorkflowExpression.Compile(bodyaddressLine2);
            WorkflowExpression.Validate(__workflow_bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycounty = bodycounty == null ? null : WorkflowExpression.Compile(bodycounty);
            WorkflowExpression.Validate(__workflow_bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodypostcode = bodypostcode == null ? null : WorkflowExpression.Compile(bodypostcode);
            WorkflowExpression.Validate(__workflow_bodypostcode, nameof(bodypostcode), required: false);
            var __workflow_bodycountry = bodycountry == null ? null : WorkflowExpression.Compile(bodycountry);
            WorkflowExpression.Validate(__workflow_bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycustom01 = bodycustom01 == null ? null : WorkflowExpression.Compile(bodycustom01);
            WorkflowExpression.Validate(__workflow_bodycustom01, nameof(bodycustom01), required: false);
            var __workflow_bodycustom02 = bodycustom02 == null ? null : WorkflowExpression.Compile(bodycustom02);
            WorkflowExpression.Validate(__workflow_bodycustom02, nameof(bodycustom02), required: false);
            var __workflow_bodycustom03 = bodycustom03 == null ? null : WorkflowExpression.Compile(bodycustom03);
            WorkflowExpression.Validate(__workflow_bodycustom03, nameof(bodycustom03), required: false);
            var __workflow_bodycustom04 = bodycustom04 == null ? null : WorkflowExpression.Compile(bodycustom04);
            WorkflowExpression.Validate(__workflow_bodycustom04, nameof(bodycustom04), required: false);
            var __workflow_bodycustom05 = bodycustom05 == null ? null : WorkflowExpression.Compile(bodycustom05);
            WorkflowExpression.Validate(__workflow_bodycustom05, nameof(bodycustom05), required: false);
            var __workflow_bodyallowSMS = bodyallowSMS == null ? null : WorkflowExpression.Compile(bodyallowSMS);
            WorkflowExpression.Validate(__workflow_bodyallowSMS, nameof(bodyallowSMS), required: false);
            var __workflow_bodytagNames = bodytagNames == null ? null : WorkflowExpression.Compile(bodytagNames);
            WorkflowExpression.Validate(__workflow_bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodymobileNumber != null)
                {
                    body["MobileNumber"] = ExpressionConverter.ConvertO(__workflow_bodymobileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReference);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostcode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(__workflow_bodycustom01);
                    bodypropCount++;
                }

                if (__workflow_bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(__workflow_bodycustom02);
                    bodypropCount++;
                }

                if (__workflow_bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(__workflow_bodycustom03);
                    bodypropCount++;
                }

                if (__workflow_bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(__workflow_bodycustom04);
                    bodypropCount++;
                }

                if (__workflow_bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(__workflow_bodycustom05);
                    bodypropCount++;
                }

                if (__workflow_bodyallowSMS != null)
                {
                    body["AllowSMS"] = ExpressionConverter.ConvertO(__workflow_bodyallowSMS);
                    bodypropCount++;
                }

                if (__workflow_bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(__workflow_bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TxtsyncTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<InboundSMSResponse> InboundSMS(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/system/applications/webhooks/type/0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            body["URL"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<InboundSMSResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OutboundSMSResponse> OutboundSMS(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/system/applications/webhooks/type/5";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            body["URL"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<OutboundSMSResponse>(callPayload, recurrence: recurrence);
        }
    }

    public class SMS
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public int ContactID { get; set; }
        public int Direction { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }
        public int SMSID { get; set; }
        public double Segments { get; set; }
        public string DeliveredDate { get; set; }
        public double CampaignID { get; set; }
        public double ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public double UserID { get; set; }
        public string UserName { get; set; }
        public string ContactName { get; set; }
        public string ProfileURL { get; set; }
        public string LinkDetails { get; set; }
        public bool IsFlagged { get; set; }
        public string FlaggedDate { get; set; }
        public string FlaggedDescription { get; set; }
        public string CurrencyCode { get; set; }
        public double CostLocal { get; set; }
        public double CostGBP { get; set; }
        public double ErrorCode { get; set; }
        public double Status { get; set; }
    }

    public class SearchContactResponseItem
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }
        public int OverallRating { get; set; }
        public int TotalDistinctLinkClicks { get; set; }
        public int TotalLinksSent { get; set; }
        public int TotalInboundSMS { get; set; }
        public int TotalOutboundSMS { get; set; }
        public int TotalFailedSMS { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }
        public bool AllowSMS { get; set; }
    }

    public class AddContactResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ContactID { get; set; }
        public string FullName { get; set; }
    }

    public class UpdateContactResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ContactID { get; set; }
        public string FullName { get; set; }
    }

    public class GetContactByExternalReferenceResponse
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }
        public int OverallRating { get; set; }
        public int TotalDistinctLinkClicks { get; set; }
        public int TotalLinksSent { get; set; }
        public int TotalInboundSMS { get; set; }
        public int TotalOutboundSMS { get; set; }
        public int TotalFailedSMS { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }
        public bool AllowSMS { get; set; }
    }

    public class InboundSMSResponse
    {
        public InboundSMSResponseContentType Content { get; set; }
    }

    public class InboundSMSResponseContentType
    {
        public InboundSMSResponseContentTypeContactType Contact { get; set; }
        public InboundSMSResponseContentTypeSMSType SMS { get; set; }
    }

    public class InboundSMSResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class InboundSMSResponseContentTypeSMSType
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string DeliveredDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }
        public int SMSID { get; set; }
        public string ToNumber { get; set; }
    }

    public class OutboundSMSResponse
    {
        public OutboundSMSResponseContentType Content { get; set; }
    }

    public class OutboundSMSResponseContentType
    {
        public OutboundSMSResponseContentTypeContactType Contact { get; set; }
        public OutboundSMSResponseContentTypeSMSType SMS { get; set; }
    }

    public class OutboundSMSResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class OutboundSMSResponseContentTypeSMSType
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string CreatedDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }
        public int SMSID { get; set; }
        public string ToNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync;

    public partial class WorkflowManagedActions
    {
        public TxtsyncActions Txtsync(string connectionId) => new TxtsyncActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TxtsyncTriggers Txtsync(string connectionId) => new TxtsyncTriggers(connectionId);
    }
}
