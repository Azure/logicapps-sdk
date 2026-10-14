//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftd365cev9ip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Microsoftd365cev9ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact(Expression<Func<string>> contactGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodybirthdate = null, Expression<Func<string>> bodycustomertypecode = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodyemailaddress2 = null, Expression<Func<string>> bodytelephone1 = null, Expression<Func<string>> bodytelephone2 = null, Expression<Func<string>> bodytelephone3 = null, Expression<Func<string>> bodymobilephone = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var __workflow_contactGUID = contactGUID == null ? null : WorkflowExpression.Compile(contactGUID);
            WorkflowExpression.Validate(__workflow_contactGUID, nameof(contactGUID), required: true);
            var __workflow_oDataMaxVersion = oDataMaxVersion == null ? null : WorkflowExpression.Compile(oDataMaxVersion);
            WorkflowExpression.Validate(__workflow_oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = oDataVersion == null ? null : WorkflowExpression.Compile(oDataVersion);
            WorkflowExpression.Validate(__workflow_oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_bodyfirstname = bodyfirstname == null ? null : WorkflowExpression.Compile(bodyfirstname);
            WorkflowExpression.Validate(__workflow_bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodylastname = bodylastname == null ? null : WorkflowExpression.Compile(bodylastname);
            WorkflowExpression.Validate(__workflow_bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodymiddlename = bodymiddlename == null ? null : WorkflowExpression.Compile(bodymiddlename);
            WorkflowExpression.Validate(__workflow_bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodybirthdate = bodybirthdate == null ? null : WorkflowExpression.Compile(bodybirthdate);
            WorkflowExpression.Validate(__workflow_bodybirthdate, nameof(bodybirthdate), required: false);
            var __workflow_bodycustomertypecode = bodycustomertypecode == null ? null : WorkflowExpression.Compile(bodycustomertypecode);
            WorkflowExpression.Validate(__workflow_bodycustomertypecode, nameof(bodycustomertypecode), required: false);
            var __workflow_bodyemailaddress1 = bodyemailaddress1 == null ? null : WorkflowExpression.Compile(bodyemailaddress1);
            WorkflowExpression.Validate(__workflow_bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            var __workflow_bodyemailaddress2 = bodyemailaddress2 == null ? null : WorkflowExpression.Compile(bodyemailaddress2);
            WorkflowExpression.Validate(__workflow_bodyemailaddress2, nameof(bodyemailaddress2), required: false);
            var __workflow_bodytelephone1 = bodytelephone1 == null ? null : WorkflowExpression.Compile(bodytelephone1);
            WorkflowExpression.Validate(__workflow_bodytelephone1, nameof(bodytelephone1), required: false);
            var __workflow_bodytelephone2 = bodytelephone2 == null ? null : WorkflowExpression.Compile(bodytelephone2);
            WorkflowExpression.Validate(__workflow_bodytelephone2, nameof(bodytelephone2), required: false);
            var __workflow_bodytelephone3 = bodytelephone3 == null ? null : WorkflowExpression.Compile(bodytelephone3);
            WorkflowExpression.Validate(__workflow_bodytelephone3, nameof(bodytelephone3), required: false);
            var __workflow_bodymobilephone = bodymobilephone == null ? null : WorkflowExpression.Compile(bodymobilephone);
            WorkflowExpression.Validate(__workflow_bodymobilephone, nameof(bodymobilephone), required: false);
            var __workflow_bodyaddress1Line1 = bodyaddress1Line1 == null ? null : WorkflowExpression.Compile(bodyaddress1Line1);
            WorkflowExpression.Validate(__workflow_bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            var __workflow_bodyaddress1Line2 = bodyaddress1Line2 == null ? null : WorkflowExpression.Compile(bodyaddress1Line2);
            WorkflowExpression.Validate(__workflow_bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            var __workflow_bodyaddress1City = bodyaddress1City == null ? null : WorkflowExpression.Compile(bodyaddress1City);
            WorkflowExpression.Validate(__workflow_bodyaddress1City, nameof(bodyaddress1City), required: false);
            var __workflow_bodyaddress1Stateorprovince = bodyaddress1Stateorprovince == null ? null : WorkflowExpression.Compile(bodyaddress1Stateorprovince);
            WorkflowExpression.Validate(__workflow_bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            var __workflow_bodyaddress1Postalcode = bodyaddress1Postalcode == null ? null : WorkflowExpression.Compile(bodyaddress1Postalcode);
            WorkflowExpression.Validate(__workflow_bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            var __workflow_bodyaddress1County = bodyaddress1County == null ? null : WorkflowExpression.Compile(bodyaddress1County);
            WorkflowExpression.Validate(__workflow_bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts({0})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodymiddlename != null)
                {
                    body["middlename"] = ExpressionConverter.ConvertO(__workflow_bodymiddlename);
                    bodypropCount++;
                }

                if (__workflow_bodybirthdate != null)
                {
                    body["birthdate"] = ExpressionConverter.ConvertO(__workflow_bodybirthdate);
                    bodypropCount++;
                }

                if (__workflow_bodycustomertypecode != null)
                {
                    body["customertypecode"] = ExpressionConverter.ConvertO(__workflow_bodycustomertypecode);
                    bodypropCount++;
                }

                if (__workflow_bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyemailaddress2 != null)
                {
                    body["emailaddress2"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress2);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone1 != null)
                {
                    body["telephone1"] = ExpressionConverter.ConvertO(__workflow_bodytelephone1);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone2 != null)
                {
                    body["telephone2"] = ExpressionConverter.ConvertO(__workflow_bodytelephone2);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone3 != null)
                {
                    body["telephone3"] = ExpressionConverter.ConvertO(__workflow_bodytelephone3);
                    bodypropCount++;
                }

                if (__workflow_bodymobilephone != null)
                {
                    body["mobilephone"] = ExpressionConverter.ConvertO(__workflow_bodymobilephone);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Line1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Line2);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1City != null)
                {
                    body["address1_city"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1City);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1County != null)
                {
                    body["address1_county"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1County);
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
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount(Expression<Func<string>> accountGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var __workflow_accountGUID = accountGUID == null ? null : WorkflowExpression.Compile(accountGUID);
            WorkflowExpression.Validate(__workflow_accountGUID, nameof(accountGUID), required: true);
            var __workflow_oDataMaxVersion = oDataMaxVersion == null ? null : WorkflowExpression.Compile(oDataMaxVersion);
            WorkflowExpression.Validate(__workflow_oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = oDataVersion == null ? null : WorkflowExpression.Compile(oDataVersion);
            WorkflowExpression.Validate(__workflow_oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyaddress1Line1 = bodyaddress1Line1 == null ? null : WorkflowExpression.Compile(bodyaddress1Line1);
            WorkflowExpression.Validate(__workflow_bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            var __workflow_bodyaddress1Line2 = bodyaddress1Line2 == null ? null : WorkflowExpression.Compile(bodyaddress1Line2);
            WorkflowExpression.Validate(__workflow_bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            var __workflow_bodyaddress1City = bodyaddress1City == null ? null : WorkflowExpression.Compile(bodyaddress1City);
            WorkflowExpression.Validate(__workflow_bodyaddress1City, nameof(bodyaddress1City), required: false);
            var __workflow_bodyaddress1Stateorprovince = bodyaddress1Stateorprovince == null ? null : WorkflowExpression.Compile(bodyaddress1Stateorprovince);
            WorkflowExpression.Validate(__workflow_bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            var __workflow_bodyaddress1Postalcode = bodyaddress1Postalcode == null ? null : WorkflowExpression.Compile(bodyaddress1Postalcode);
            WorkflowExpression.Validate(__workflow_bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            var __workflow_bodyaddress1County = bodyaddress1County == null ? null : WorkflowExpression.Compile(bodyaddress1County);
            WorkflowExpression.Validate(__workflow_bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertAccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/accounts({0})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Line1 != null)
                {
                    body["address1_line1"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Line1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Line2 != null)
                {
                    body["address1_line2"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Line2);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1City != null)
                {
                    body["address1_city"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1City);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Stateorprovince != null)
                {
                    body["address1_stateorprovince"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Stateorprovince);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1Postalcode != null)
                {
                    body["address1_postalcode"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1Postalcode);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1County != null)
                {
                    body["address1_county"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1County);
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
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead(Expression<Func<string>> leadGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfullname = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodytelephone1 = null)
        {
            var __workflow_leadGUID = leadGUID == null ? null : WorkflowExpression.Compile(leadGUID);
            WorkflowExpression.Validate(__workflow_leadGUID, nameof(leadGUID), required: true);
            var __workflow_oDataMaxVersion = oDataMaxVersion == null ? null : WorkflowExpression.Compile(oDataMaxVersion);
            WorkflowExpression.Validate(__workflow_oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = oDataVersion == null ? null : WorkflowExpression.Compile(oDataVersion);
            WorkflowExpression.Validate(__workflow_oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_bodyfullname = bodyfullname == null ? null : WorkflowExpression.Compile(bodyfullname);
            WorkflowExpression.Validate(__workflow_bodyfullname, nameof(bodyfullname), required: false);
            var __workflow_bodyemailaddress1 = bodyemailaddress1 == null ? null : WorkflowExpression.Compile(bodyemailaddress1);
            WorkflowExpression.Validate(__workflow_bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            var __workflow_bodytelephone1 = bodytelephone1 == null ? null : WorkflowExpression.Compile(bodytelephone1);
            WorkflowExpression.Validate(__workflow_bodytelephone1, nameof(bodytelephone1), required: false);
            return new DeferredBodyAction<UpsertLeadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leads({0})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_leadGUID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfullname != null)
                {
                    body["fullname"] = ExpressionConverter.ConvertO(__workflow_bodyfullname);
                    bodypropCount++;
                }

                if (__workflow_bodyemailaddress1 != null)
                {
                    body["emailaddress1"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress1);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone1 != null)
                {
                    body["telephone1"] = ExpressionConverter.ConvertO(__workflow_bodytelephone1);
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
