//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftd365cev9ip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Microsoftd365cev9ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        [WorkflowExpressionFactory(nameof(__BuildUpsertContact))]
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact([WorkflowExpression] Func<string> contactGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodybirthdate = null, [WorkflowExpression] Func<string> bodycustomertypecode = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodyemailaddress2 = null, [WorkflowExpression] Func<string> bodytelephone1 = null, [WorkflowExpression] Func<string> bodytelephone2 = null, [WorkflowExpression] Func<string> bodytelephone3 = null, [WorkflowExpression] Func<string> bodymobilephone = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpsertContactResponse> __BuildUpsertContact(WorkflowValue<string> contactGUID, WorkflowValue<string> oDataMaxVersion, WorkflowValue<string> oDataVersion, WorkflowValue<string> accept, WorkflowValue<string> contentType, WorkflowValue<string> bodyfirstname = null, WorkflowValue<string> bodylastname = null, WorkflowValue<string> bodymiddlename = null, WorkflowValue<string> bodybirthdate = null, WorkflowValue<string> bodycustomertypecode = null, WorkflowValue<string> bodyemailaddress1 = null, WorkflowValue<string> bodyemailaddress2 = null, WorkflowValue<string> bodytelephone1 = null, WorkflowValue<string> bodytelephone2 = null, WorkflowValue<string> bodytelephone3 = null, WorkflowValue<string> bodymobilephone = null, WorkflowValue<string> bodyaddress1Line1 = null, WorkflowValue<string> bodyaddress1Line2 = null, WorkflowValue<string> bodyaddress1City = null, WorkflowValue<string> bodyaddress1Stateorprovince = null, WorkflowValue<string> bodyaddress1Postalcode = null, WorkflowValue<string> bodyaddress1County = null)
        {
            WorkflowValue.Validate(contactGUID, nameof(contactGUID), required: true);
            WorkflowValue.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            WorkflowValue.Validate(oDataVersion, nameof(oDataVersion), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowValue.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowValue.Validate(bodymiddlename, nameof(bodymiddlename), required: false);
            WorkflowValue.Validate(bodybirthdate, nameof(bodybirthdate), required: false);
            WorkflowValue.Validate(bodycustomertypecode, nameof(bodycustomertypecode), required: false);
            WorkflowValue.Validate(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            WorkflowValue.Validate(bodyemailaddress2, nameof(bodyemailaddress2), required: false);
            WorkflowValue.Validate(bodytelephone1, nameof(bodytelephone1), required: false);
            WorkflowValue.Validate(bodytelephone2, nameof(bodytelephone2), required: false);
            WorkflowValue.Validate(bodytelephone3, nameof(bodytelephone3), required: false);
            WorkflowValue.Validate(bodymobilephone, nameof(bodymobilephone), required: false);
            WorkflowValue.Validate(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            WorkflowValue.Validate(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            WorkflowValue.Validate(bodyaddress1City, nameof(bodyaddress1City), required: false);
            WorkflowValue.Validate(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            WorkflowValue.Validate(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            WorkflowValue.Validate(bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts({0})", ExpressionConverter.ConvertWithUrlEncoding(contactGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(bodymiddlename);
                    bodypropCount++;
                }

                if (bodybirthdate != null)
                {
                    body["birthdate"] = ExpressionConverter.ConvertO(bodybirthdate);
                    bodypropCount++;
                }

                if (bodycustomertypecode != null)
                {
                    body["customertypecode"] = ExpressionConverter.ConvertO(bodycustomertypecode);
                    bodypropCount++;
                }

                if (bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = ExpressionConverter.ConvertO(bodyemailaddress1);
                    bodypropCount++;
                }

                if (bodyemailaddress2 != null)
                {
                    body["emailaddress2"] = ExpressionConverter.ConvertO(bodyemailaddress2);
                    bodypropCount++;
                }

                if (bodytelephone1 != null)
                {
                    body["telephone1"] = ExpressionConverter.ConvertO(bodytelephone1);
                    bodypropCount++;
                }

                if (bodytelephone2 != null)
                {
                    body["telephone2"] = ExpressionConverter.ConvertO(bodytelephone2);
                    bodypropCount++;
                }

                if (bodytelephone3 != null)
                {
                    body["telephone3"] = ExpressionConverter.ConvertO(bodytelephone3);
                    bodypropCount++;
                }

                if (bodymobilephone != null)
                {
                    body["mobilephone"] = ExpressionConverter.ConvertO(bodymobilephone);
                    bodypropCount++;
                }

                if (bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = ExpressionConverter.ConvertO(bodyaddress1Line1);
                    bodypropCount++;
                }

                if (bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = ExpressionConverter.ConvertO(bodyaddress1Line2);
                    bodypropCount++;
                }

                if (bodyaddress1City != null)
                {
                    body["address1_city"] = ExpressionConverter.ConvertO(bodyaddress1City);
                    bodypropCount++;
                }

                if (bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = ExpressionConverter.ConvertO(bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = ExpressionConverter.ConvertO(bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (bodyaddress1County != null)
                {
                    body["address1_county"] = ExpressionConverter.ConvertO(bodyaddress1County);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpsertContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        [WorkflowExpressionFactory(nameof(__BuildUpsertAccount))]
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount([WorkflowExpression] Func<string> accountGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpsertAccountResponse> __BuildUpsertAccount(WorkflowValue<string> accountGUID, WorkflowValue<string> oDataMaxVersion, WorkflowValue<string> oDataVersion, WorkflowValue<string> accept, WorkflowValue<string> contentType, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyaddress1Line1 = null, WorkflowValue<string> bodyaddress1Line2 = null, WorkflowValue<string> bodyaddress1City = null, WorkflowValue<string> bodyaddress1Stateorprovince = null, WorkflowValue<string> bodyaddress1Postalcode = null, WorkflowValue<string> bodyaddress1County = null)
        {
            WorkflowValue.Validate(accountGUID, nameof(accountGUID), required: true);
            WorkflowValue.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            WorkflowValue.Validate(oDataVersion, nameof(oDataVersion), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            WorkflowValue.Validate(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            WorkflowValue.Validate(bodyaddress1City, nameof(bodyaddress1City), required: false);
            WorkflowValue.Validate(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            WorkflowValue.Validate(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            WorkflowValue.Validate(bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertAccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/accounts({0})", ExpressionConverter.ConvertWithUrlEncoding(accountGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = ExpressionConverter.ConvertO(bodyaddress1Line1);
                    bodypropCount++;
                }

                if (bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = ExpressionConverter.ConvertO(bodyaddress1Line2);
                    bodypropCount++;
                }

                if (bodyaddress1City != null)
                {
                    body["address1_city"] = ExpressionConverter.ConvertO(bodyaddress1City);
                    bodypropCount++;
                }

                if (bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = ExpressionConverter.ConvertO(bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = ExpressionConverter.ConvertO(bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (bodyaddress1County != null)
                {
                    body["address1_county"] = ExpressionConverter.ConvertO(bodyaddress1County);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpsertAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        [WorkflowExpressionFactory(nameof(__BuildUpsertLead))]
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead([WorkflowExpression] Func<string> leadGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfullname = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodytelephone1 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpsertLeadResponse> __BuildUpsertLead(WorkflowValue<string> leadGUID, WorkflowValue<string> oDataMaxVersion, WorkflowValue<string> oDataVersion, WorkflowValue<string> accept, WorkflowValue<string> contentType, WorkflowValue<string> bodyfullname = null, WorkflowValue<string> bodyemailaddress1 = null, WorkflowValue<string> bodytelephone1 = null)
        {
            WorkflowValue.Validate(leadGUID, nameof(leadGUID), required: true);
            WorkflowValue.Validate(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            WorkflowValue.Validate(oDataVersion, nameof(oDataVersion), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(bodyfullname, nameof(bodyfullname), required: false);
            WorkflowValue.Validate(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            WorkflowValue.Validate(bodytelephone1, nameof(bodytelephone1), required: false);
            return new DeferredBodyAction<UpsertLeadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leads({0})", ExpressionConverter.ConvertWithUrlEncoding(leadGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfullname != null)
                {
                    body["fullname"] = ExpressionConverter.ConvertO(bodyfullname);
                    bodypropCount++;
                }

                if (bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = ExpressionConverter.ConvertO(bodyemailaddress1);
                    bodypropCount++;
                }

                if (bodytelephone1 != null)
                {
                    body["telephone1"] = ExpressionConverter.ConvertO(bodytelephone1);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpsertLeadResponse>(callPayload);
            });
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
