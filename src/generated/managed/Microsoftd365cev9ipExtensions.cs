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
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> contactGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodymiddlename = null, [WorkflowExpression] Func<string> bodybirthdate = null, [WorkflowExpression] Func<string> bodycustomertypecode = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodyemailaddress2 = null, [WorkflowExpression] Func<string> bodytelephone1 = null, [WorkflowExpression] Func<string> bodytelephone2 = null, [WorkflowExpression] Func<string> bodytelephone3 = null, [WorkflowExpression] Func<string> bodymobilephone = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            var apiCallPath = String.Format("/contacts({0})", ExpressionConverter.ConvertWithUrlEncoding(contactGUID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> accountGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyaddress1Line1 = null, [WorkflowExpression] Func<string> bodyaddress1Line2 = null, [WorkflowExpression] Func<string> bodyaddress1City = null, [WorkflowExpression] Func<string> bodyaddress1Stateorprovince = null, [WorkflowExpression] Func<string> bodyaddress1Postalcode = null, [WorkflowExpression] Func<string> bodyaddress1County = null)
        {
            var apiCallPath = String.Format("/accounts({0})", ExpressionConverter.ConvertWithUrlEncoding(accountGUID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> leadGUID, [WorkflowExpression] Func<string> oDataMaxVersion, [WorkflowExpression] Func<string> oDataVersion, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyfullname = null, [WorkflowExpression] Func<string> bodyemailaddress1 = null, [WorkflowExpression] Func<string> bodytelephone1 = null)
        {
            var apiCallPath = String.Format("/leads({0})", ExpressionConverter.ConvertWithUrlEncoding(leadGUID, 1));
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