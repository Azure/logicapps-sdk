//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TxtsyncActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMS))]
        public IBodyWorkflowAction<SMS[]> SendSMS([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodyto)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMS[]> __BuildSendSMS(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodyto)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
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
                body["From"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SMS[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildSendBulkSMS))]
        public IBodyWorkflowAction<SMS> SendBulkSMS([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string[]> bodyto = null, [WorkflowExpression] Func<string[]> bodytoTagName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMS> __BuildSendBulkSMS(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodymessage, WorkflowExpression<string[]> bodyto = null, WorkflowExpression<string[]> bodytoTagName = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodytoTagName, nameof(bodytoTagName), required: false);
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
                body["From"] = ExpressionConverter.ConvertO(bodyfrom);
                if (bodyto != null)
                {
                    body["To"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                if (bodytoTagName != null)
                {
                    body["ToTagName"] = ExpressionConverter.ConvertO(bodytoTagName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SMS>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildSearchContact))]
        public IBodyWorkflowAction<SearchContactResponseItem[]> SearchContact([WorkflowExpression] Func<string> search)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchContactResponseItem[]> __BuildSearchContact(WorkflowExpression<string> search)
        {
            WorkflowExpression.Validate(search, nameof(search), required: true);
            return new DeferredBodyAction<SearchContactResponseItem[]>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<SearchContactResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildAddContact))]
        public IBodyWorkflowAction<AddContactResponse> AddContact([WorkflowExpression] Func<string> bodymobileNumber, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddContactResponse> __BuildAddContact(WorkflowExpression<string> bodymobileNumber, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodycompanyName = null, WorkflowExpression<string> bodyexternalReference = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyaddressLine1 = null, WorkflowExpression<string> bodyaddressLine2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodypostcode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodycustom01 = null, WorkflowExpression<string> bodycustom02 = null, WorkflowExpression<string> bodycustom03 = null, WorkflowExpression<string> bodycustom04 = null, WorkflowExpression<string> bodycustom05 = null, WorkflowExpression<string> bodytagNames = null)
        {
            WorkflowExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            WorkflowExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            WorkflowExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            WorkflowExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            WorkflowExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            WorkflowExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            WorkflowExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<AddContactResponse>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                if (bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteContact))]
        public IBodyWorkflowAction<string> DeleteContact([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteContact(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateContact))]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymobileNumber = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<bool> bodyallowSMS = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateContactResponse> __BuildUpdateContact(WorkflowExpression<string> id, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodymobileNumber = null, WorkflowExpression<string> bodycompanyName = null, WorkflowExpression<string> bodyexternalReference = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyaddressLine1 = null, WorkflowExpression<string> bodyaddressLine2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodypostcode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodycustom01 = null, WorkflowExpression<string> bodycustom02 = null, WorkflowExpression<string> bodycustom03 = null, WorkflowExpression<string> bodycustom04 = null, WorkflowExpression<string> bodycustom05 = null, WorkflowExpression<bool> bodyallowSMS = null, WorkflowExpression<string> bodytagNames = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            WorkflowExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            WorkflowExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            WorkflowExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            WorkflowExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            WorkflowExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            WorkflowExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            WorkflowExpression.Validate(bodyallowSMS, nameof(bodyallowSMS), required: false);
            WorkflowExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<UpdateContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                    bodypropCount++;
                }

                if (bodyallowSMS != null)
                {
                    body["AllowSMS"] = ExpressionConverter.ConvertO(bodyallowSMS);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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
        [WorkflowExpressionFactory(nameof(__BuildGetContactByExternalReference))]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse> GetContactByExternalReference([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse> __BuildGetContactByExternalReference(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetContactByExternalReferenceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<GetContactByExternalReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteContactByExternalReference))]
        public IBodyWorkflowAction<string> DeleteContactByExternalReference([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteContactByExternalReference(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateContactByExternalReference))]
        public IBodyWorkflowAction<string> UpdateContactByExternalReference([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymobileNumber = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<bool> bodyallowSMS = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUpdateContactByExternalReference(WorkflowExpression<string> id, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodymobileNumber = null, WorkflowExpression<string> bodycompanyName = null, WorkflowExpression<string> bodyexternalReference = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyaddressLine1 = null, WorkflowExpression<string> bodyaddressLine2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodypostcode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodycustom01 = null, WorkflowExpression<string> bodycustom02 = null, WorkflowExpression<string> bodycustom03 = null, WorkflowExpression<string> bodycustom04 = null, WorkflowExpression<string> bodycustom05 = null, WorkflowExpression<bool> bodyallowSMS = null, WorkflowExpression<string> bodytagNames = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            WorkflowExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            WorkflowExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            WorkflowExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            WorkflowExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            WorkflowExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            WorkflowExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            WorkflowExpression.Validate(bodyallowSMS, nameof(bodyallowSMS), required: false);
            WorkflowExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                    bodypropCount++;
                }

                if (bodyallowSMS != null)
                {
                    body["AllowSMS"] = ExpressionConverter.ConvertO(bodyallowSMS);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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