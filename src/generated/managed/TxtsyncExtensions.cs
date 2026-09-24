//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TxtsyncActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS[]> SendSMS([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodyto)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["From"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SMS[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS> SendBulkSMS([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string[]> bodyto = null, [WorkflowExpression] Func<string[]> bodytoTagName = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodytoTagName, nameof(bodytoTagName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                body["From"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                if (bodyto != null)
                {
                    body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodytoTagName != null)
                {
                    body["ToTagName"] = SourceExpressionConverter.ConvertToken(bodytoTagName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SMS>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SearchContactResponseItem[]> SearchContact([WorkflowExpression] Func<string> search)
        {
            SourceExpression.Validate(search, nameof(search), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return callPayload;
            }

            return new ApiConnectionAction<SearchContactResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<AddContactResponse> AddContact([WorkflowExpression] Func<string> bodymobileNumber, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            SourceExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            SourceExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            SourceExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            SourceExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            SourceExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            SourceExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            SourceExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MobileNumber"] = SourceExpressionConverter.ConvertToken(bodymobileNumber);
                if (bodycompanyName != null)
                {
                    body["CompanyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = SourceExpressionConverter.ConvertToken(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = SourceExpressionConverter.ConvertToken(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = SourceExpressionConverter.ConvertToken(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = SourceExpressionConverter.ConvertToken(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = SourceExpressionConverter.ConvertToken(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = SourceExpressionConverter.ConvertToken(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = SourceExpressionConverter.ConvertToken(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = SourceExpressionConverter.ConvertToken(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = SourceExpressionConverter.ConvertToken(bodycustom05);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = SourceExpressionConverter.ConvertToken(bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContact([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymobileNumber = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<bool> bodyallowSMS = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            SourceExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            SourceExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            SourceExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            SourceExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            SourceExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            SourceExpression.Validate(bodyallowSMS, nameof(bodyallowSMS), required: false);
            SourceExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["MobileNumber"] = SourceExpressionConverter.ConvertToken(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["CompanyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = SourceExpressionConverter.ConvertToken(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = SourceExpressionConverter.ConvertToken(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = SourceExpressionConverter.ConvertToken(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = SourceExpressionConverter.ConvertToken(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = SourceExpressionConverter.ConvertToken(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = SourceExpressionConverter.ConvertToken(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = SourceExpressionConverter.ConvertToken(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = SourceExpressionConverter.ConvertToken(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = SourceExpressionConverter.ConvertToken(bodycustom05);
                    bodypropCount++;
                }

                if (bodyallowSMS != null)
                {
                    body["AllowSMS"] = SourceExpressionConverter.ConvertToken(bodyallowSMS);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = SourceExpressionConverter.ConvertToken(bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse> GetContactByExternalReference([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return callPayload;
            }

            return new ApiConnectionAction<GetContactByExternalReferenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContactByExternalReference([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> UpdateContactByExternalReference([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymobileNumber = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycustom01 = null, [WorkflowExpression] Func<string> bodycustom02 = null, [WorkflowExpression] Func<string> bodycustom03 = null, [WorkflowExpression] Func<string> bodycustom04 = null, [WorkflowExpression] Func<string> bodycustom05 = null, [WorkflowExpression] Func<bool> bodyallowSMS = null, [WorkflowExpression] Func<string> bodytagNames = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            SourceExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodycustom01, nameof(bodycustom01), required: false);
            SourceExpression.Validate(bodycustom02, nameof(bodycustom02), required: false);
            SourceExpression.Validate(bodycustom03, nameof(bodycustom03), required: false);
            SourceExpression.Validate(bodycustom04, nameof(bodycustom04), required: false);
            SourceExpression.Validate(bodycustom05, nameof(bodycustom05), required: false);
            SourceExpression.Validate(bodyallowSMS, nameof(bodyallowSMS), required: false);
            SourceExpression.Validate(bodytagNames, nameof(bodytagNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/external/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["MobileNumber"] = SourceExpressionConverter.ConvertToken(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["CompanyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["ExternalReference"] = SourceExpressionConverter.ConvertToken(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = SourceExpressionConverter.ConvertToken(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = SourceExpressionConverter.ConvertToken(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["Postcode"] = SourceExpressionConverter.ConvertToken(bodypostcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodycustom01 != null)
                {
                    body["Custom01"] = SourceExpressionConverter.ConvertToken(bodycustom01);
                    bodypropCount++;
                }

                if (bodycustom02 != null)
                {
                    body["Custom02"] = SourceExpressionConverter.ConvertToken(bodycustom02);
                    bodypropCount++;
                }

                if (bodycustom03 != null)
                {
                    body["Custom03"] = SourceExpressionConverter.ConvertToken(bodycustom03);
                    bodypropCount++;
                }

                if (bodycustom04 != null)
                {
                    body["Custom04"] = SourceExpressionConverter.ConvertToken(bodycustom04);
                    bodypropCount++;
                }

                if (bodycustom05 != null)
                {
                    body["Custom05"] = SourceExpressionConverter.ConvertToken(bodycustom05);
                    bodypropCount++;
                }

                if (bodyallowSMS != null)
                {
                    body["AllowSMS"] = SourceExpressionConverter.ConvertToken(bodyallowSMS);
                    bodypropCount++;
                }

                if (bodytagNames != null)
                {
                    body["TagNames"] = SourceExpressionConverter.ConvertToken(bodytagNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class TxtsyncTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<InboundSMSResponse> InboundSMS(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<InboundSMSResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OutboundSMSResponse> OutboundSMS(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<OutboundSMSResponse>(BuildSourceInput, triggerName, recurrence);
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