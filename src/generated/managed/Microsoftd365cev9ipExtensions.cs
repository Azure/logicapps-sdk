//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftd365cev9ip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Microsoftd365cev9ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact([WorkflowExpression] Func<string> contactGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodybirthdate = null, [WorkflowExpression] Func<string> bodycustomertypecode = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodyemailaddress2 = null, [WorkflowExpression] Func<string> bodytelephone1 = null, [WorkflowExpression] Func<string> bodytelephone2 = null, [WorkflowExpression] Func<string> bodytelephone3 = null, [WorkflowExpression] Func<string> bodymobilephone = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            SourceExpression.Validate(contactGUID, nameof(contactGUID), required: true);
            SourceExpression.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            SourceExpression.Validate(oDataVersion, nameof(oDataVersion), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            SourceExpression.Validate(bodybirthdate, nameof(bodybirthdate), required: false);
            SourceExpression.Validate(bodycustomertypecode, nameof(bodycustomertypecode), required: false);
            SourceExpression.Validate(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            SourceExpression.Validate(bodyemailaddress2, nameof(bodyemailaddress2), required: false);
            SourceExpression.Validate(bodytelephone1, nameof(bodytelephone1), required: false);
            SourceExpression.Validate(bodytelephone2, nameof(bodytelephone2), required: false);
            SourceExpression.Validate(bodytelephone3, nameof(bodytelephone3), required: false);
            SourceExpression.Validate(bodymobilephone, nameof(bodymobilephone), required: false);
            SourceExpression.Validate(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            SourceExpression.Validate(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            SourceExpression.Validate(bodyaddress1City, nameof(bodyaddress1City), required: false);
            SourceExpression.Validate(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            SourceExpression.Validate(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            SourceExpression.Validate(bodyaddress1County, nameof(bodyaddress1County), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts({0})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = SourceExpressionConverter.ConvertO(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = SourceExpressionConverter.ConvertO(oDataVersion);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = SourceExpressionConverter.ConvertToken(bodymiddlename);
                    bodypropCount++;
                }

                if (bodybirthdate != null)
                {
                    body["birthdate"] = SourceExpressionConverter.ConvertToken(bodybirthdate);
                    bodypropCount++;
                }

                if (bodycustomertypecode != null)
                {
                    body["customertypecode"] = SourceExpressionConverter.ConvertToken(bodycustomertypecode);
                    bodypropCount++;
                }

                if (bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = SourceExpressionConverter.ConvertToken(bodyemailaddress1);
                    bodypropCount++;
                }

                if (bodyemailaddress2 != null)
                {
                    body["emailaddress2"] = SourceExpressionConverter.ConvertToken(bodyemailaddress2);
                    bodypropCount++;
                }

                if (bodytelephone1 != null)
                {
                    body["telephone1"] = SourceExpressionConverter.ConvertToken(bodytelephone1);
                    bodypropCount++;
                }

                if (bodytelephone2 != null)
                {
                    body["telephone2"] = SourceExpressionConverter.ConvertToken(bodytelephone2);
                    bodypropCount++;
                }

                if (bodytelephone3 != null)
                {
                    body["telephone3"] = SourceExpressionConverter.ConvertToken(bodytelephone3);
                    bodypropCount++;
                }

                if (bodymobilephone != null)
                {
                    body["mobilephone"] = SourceExpressionConverter.ConvertToken(bodymobilephone);
                    bodypropCount++;
                }

                if (bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = SourceExpressionConverter.ConvertToken(bodyaddress1Line1);
                    bodypropCount++;
                }

                if (bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = SourceExpressionConverter.ConvertToken(bodyaddress1Line2);
                    bodypropCount++;
                }

                if (bodyaddress1City != null)
                {
                    body["address1_city"] = SourceExpressionConverter.ConvertToken(bodyaddress1City);
                    bodypropCount++;
                }

                if (bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = SourceExpressionConverter.ConvertToken(bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = SourceExpressionConverter.ConvertToken(bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (bodyaddress1County != null)
                {
                    body["address1_county"] = SourceExpressionConverter.ConvertToken(bodyaddress1County);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpsertContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount([WorkflowExpression] Func<string> accountGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            SourceExpression.Validate(accountGUID, nameof(accountGUID), required: true);
            SourceExpression.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            SourceExpression.Validate(oDataVersion, nameof(oDataVersion), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            SourceExpression.Validate(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            SourceExpression.Validate(bodyaddress1City, nameof(bodyaddress1City), required: false);
            SourceExpression.Validate(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            SourceExpression.Validate(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            SourceExpression.Validate(bodyaddress1County, nameof(bodyaddress1County), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts({0})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = SourceExpressionConverter.ConvertO(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = SourceExpressionConverter.ConvertO(oDataVersion);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = SourceExpressionConverter.ConvertToken(bodyaddress1Line1);
                    bodypropCount++;
                }

                if (bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = SourceExpressionConverter.ConvertToken(bodyaddress1Line2);
                    bodypropCount++;
                }

                if (bodyaddress1City != null)
                {
                    body["address1_city"] = SourceExpressionConverter.ConvertToken(bodyaddress1City);
                    bodypropCount++;
                }

                if (bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = SourceExpressionConverter.ConvertToken(bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = SourceExpressionConverter.ConvertToken(bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (bodyaddress1County != null)
                {
                    body["address1_county"] = SourceExpressionConverter.ConvertToken(bodyaddress1County);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpsertAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead([WorkflowExpression] Func<string> leadGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfullname = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodytelephone1 = null)
        {
            SourceExpression.Validate(leadGUID, nameof(leadGUID), required: true);
            SourceExpression.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            SourceExpression.Validate(oDataVersion, nameof(oDataVersion), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodyfullname, nameof(bodyfullname), required: false);
            SourceExpression.Validate(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            SourceExpression.Validate(bodytelephone1, nameof(bodytelephone1), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/leads({0})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(leadGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = SourceExpressionConverter.ConvertO(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = SourceExpressionConverter.ConvertO(oDataVersion);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfullname != null)
                {
                    body["fullname"] = SourceExpressionConverter.ConvertToken(bodyfullname);
                    bodypropCount++;
                }

                if (bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = SourceExpressionConverter.ConvertToken(bodyemailaddress1);
                    bodypropCount++;
                }

                if (bodytelephone1 != null)
                {
                    body["telephone1"] = SourceExpressionConverter.ConvertToken(bodytelephone1);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpsertLeadResponse>(BuildSourceInput);
        }
    }

    public class Microsoftd365cev9ipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UpsertContactResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class StatusDetails
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }
    }

    public class Messages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpsertAccountResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class UpsertLeadResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftd365cev9ip;

    public partial class WorkflowManagedActions
    {
        public Microsoftd365cev9ipActions Microsoftd365cev9ip(string connectionId) => new Microsoftd365cev9ipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Microsoftd365cev9ipTriggers Microsoftd365cev9ip(string connectionId) => new Microsoftd365cev9ipTriggers(connectionId);
    }
}