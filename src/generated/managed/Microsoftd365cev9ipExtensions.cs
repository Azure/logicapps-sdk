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
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact(Expression<Func<string>> contactGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodybirthdate = null, Expression<Func<string>> bodycustomertypecode = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodyemailaddress2 = null, Expression<Func<string>> bodytelephone1 = null, Expression<Func<string>> bodytelephone2 = null, Expression<Func<string>> bodytelephone3 = null, Expression<Func<string>> bodymobilephone = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/contacts({0})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactGUID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["OData-MaxVersion"] = CSharpExpressionConverter.ConvertO(oDataMaxVersion);
            callPayload.Headers["OData-Version"] = CSharpExpressionConverter.ConvertO(oDataVersion);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodymiddlename != null)
            {
                body["middlename"] = CSharpExpressionConverter.ConvertToken(bodymiddlename);
                bodypropCount++;
            }

            if (bodybirthdate != null)
            {
                body["birthdate"] = CSharpExpressionConverter.ConvertToken(bodybirthdate);
                bodypropCount++;
            }

            if (bodycustomertypecode != null)
            {
                body["customertypecode"] = CSharpExpressionConverter.ConvertToken(bodycustomertypecode);
                bodypropCount++;
            }

            if (bodyemailaddress1 != null)
            {
                body["emailaddress1"] = CSharpExpressionConverter.ConvertToken(bodyemailaddress1);
                bodypropCount++;
            }

            if (bodyemailaddress2 != null)
            {
                body["emailaddress2"] = CSharpExpressionConverter.ConvertToken(bodyemailaddress2);
                bodypropCount++;
            }

            if (bodytelephone1 != null)
            {
                body["telephone1"] = CSharpExpressionConverter.ConvertToken(bodytelephone1);
                bodypropCount++;
            }

            if (bodytelephone2 != null)
            {
                body["telephone2"] = CSharpExpressionConverter.ConvertToken(bodytelephone2);
                bodypropCount++;
            }

            if (bodytelephone3 != null)
            {
                body["telephone3"] = CSharpExpressionConverter.ConvertToken(bodytelephone3);
                bodypropCount++;
            }

            if (bodymobilephone != null)
            {
                body["mobilephone"] = CSharpExpressionConverter.ConvertToken(bodymobilephone);
                bodypropCount++;
            }

            if (bodyaddress1Line1 != null)
            {
                body["address1_line1"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Line1);
                bodypropCount++;
            }

            if (bodyaddress1Line2 != null)
            {
                body["address1_line2"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Line2);
                bodypropCount++;
            }

            if (bodyaddress1City != null)
            {
                body["address1_city"] = CSharpExpressionConverter.ConvertToken(bodyaddress1City);
                bodypropCount++;
            }

            if (bodyaddress1Stateorprovince != null)
            {
                body["address1_stateorprovince"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Stateorprovince);
                bodypropCount++;
            }

            if (bodyaddress1Postalcode != null)
            {
                body["address1_postalcode"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Postalcode);
                bodypropCount++;
            }

            if (bodyaddress1County != null)
            {
                body["address1_county"] = CSharpExpressionConverter.ConvertToken(bodyaddress1County);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpsertContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount(Expression<Func<string>> accountGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/accounts({0})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountGUID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["OData-MaxVersion"] = CSharpExpressionConverter.ConvertO(oDataMaxVersion);
            callPayload.Headers["OData-Version"] = CSharpExpressionConverter.ConvertO(oDataVersion);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyaddress1Line1 != null)
            {
                body["address1_line1"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Line1);
                bodypropCount++;
            }

            if (bodyaddress1Line2 != null)
            {
                body["address1_line2"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Line2);
                bodypropCount++;
            }

            if (bodyaddress1City != null)
            {
                body["address1_city"] = CSharpExpressionConverter.ConvertToken(bodyaddress1City);
                bodypropCount++;
            }

            if (bodyaddress1Stateorprovince != null)
            {
                body["address1_stateorprovince"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Stateorprovince);
                bodypropCount++;
            }

            if (bodyaddress1Postalcode != null)
            {
                body["address1_postalcode"] = CSharpExpressionConverter.ConvertToken(bodyaddress1Postalcode);
                bodypropCount++;
            }

            if (bodyaddress1County != null)
            {
                body["address1_county"] = CSharpExpressionConverter.ConvertToken(bodyaddress1County);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpsertAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead(Expression<Func<string>> leadGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfullname = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodytelephone1 = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/leads({0})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(leadGUID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["OData-MaxVersion"] = CSharpExpressionConverter.ConvertO(oDataMaxVersion);
            callPayload.Headers["OData-Version"] = CSharpExpressionConverter.ConvertO(oDataVersion);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfullname != null)
            {
                body["fullname"] = CSharpExpressionConverter.ConvertToken(bodyfullname);
                bodypropCount++;
            }

            if (bodyemailaddress1 != null)
            {
                body["emailaddress1"] = CSharpExpressionConverter.ConvertToken(bodyemailaddress1);
                bodypropCount++;
            }

            if (bodytelephone1 != null)
            {
                body["telephone1"] = CSharpExpressionConverter.ConvertToken(bodytelephone1);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpsertLeadResponse>(callPayload);
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