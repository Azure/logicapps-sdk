//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftd365cev9ip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Microsoftd365cev9ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertContactResponse> UpsertContact(Expression<Func<string>> contactGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodymiddlename = null, Expression<Func<string>> bodybirthdate = null, Expression<Func<string>> bodycustomertypecode = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodyemailaddress2 = null, Expression<Func<string>> bodytelephone1 = null, Expression<Func<string>> bodytelephone2 = null, Expression<Func<string>> bodytelephone3 = null, Expression<Func<string>> bodymobilephone = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var __workflow_contactGUID = WorkflowExpression.Compile(contactGUID, nameof(contactGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodymiddlename = WorkflowExpression.Compile(bodymiddlename, nameof(bodymiddlename), required: false);
            var __workflow_bodybirthdate = WorkflowExpression.Compile(bodybirthdate, nameof(bodybirthdate), required: false);
            var __workflow_bodycustomertypecode = WorkflowExpression.Compile(bodycustomertypecode, nameof(bodycustomertypecode), required: false);
            var __workflow_bodyemailaddress1 = WorkflowExpression.Compile(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            var __workflow_bodyemailaddress2 = WorkflowExpression.Compile(bodyemailaddress2, nameof(bodyemailaddress2), required: false);
            var __workflow_bodytelephone1 = WorkflowExpression.Compile(bodytelephone1, nameof(bodytelephone1), required: false);
            var __workflow_bodytelephone2 = WorkflowExpression.Compile(bodytelephone2, nameof(bodytelephone2), required: false);
            var __workflow_bodytelephone3 = WorkflowExpression.Compile(bodytelephone3, nameof(bodytelephone3), required: false);
            var __workflow_bodymobilephone = WorkflowExpression.Compile(bodymobilephone, nameof(bodymobilephone), required: false);
            var __workflow_bodyaddress1Line1 = WorkflowExpression.Compile(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            var __workflow_bodyaddress1Line2 = WorkflowExpression.Compile(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            var __workflow_bodyaddress1City = WorkflowExpression.Compile(bodyaddress1City, nameof(bodyaddress1City), required: false);
            var __workflow_bodyaddress1Stateorprovince = WorkflowExpression.Compile(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            var __workflow_bodyaddress1Postalcode = WorkflowExpression.Compile(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            var __workflow_bodyaddress1County = WorkflowExpression.Compile(bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts({0})", __workflow_contactGUID.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertAccountResponse> UpsertAccount(Expression<Func<string>> accountGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyaddress1Line1 = null, Expression<Func<string>> bodyaddress1Line2 = null, Expression<Func<string>> bodyaddress1City = null, Expression<Func<string>> bodyaddress1Stateorprovince = null, Expression<Func<string>> bodyaddress1Postalcode = null, Expression<Func<string>> bodyaddress1County = null)
        {
            var __workflow_accountGUID = WorkflowExpression.Compile(accountGUID, nameof(accountGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyaddress1Line1 = WorkflowExpression.Compile(bodyaddress1Line1, nameof(bodyaddress1Line1), required: false);
            var __workflow_bodyaddress1Line2 = WorkflowExpression.Compile(bodyaddress1Line2, nameof(bodyaddress1Line2), required: false);
            var __workflow_bodyaddress1City = WorkflowExpression.Compile(bodyaddress1City, nameof(bodyaddress1City), required: false);
            var __workflow_bodyaddress1Stateorprovince = WorkflowExpression.Compile(bodyaddress1Stateorprovince, nameof(bodyaddress1Stateorprovince), required: false);
            var __workflow_bodyaddress1Postalcode = WorkflowExpression.Compile(bodyaddress1Postalcode, nameof(bodyaddress1Postalcode), required: false);
            var __workflow_bodyaddress1County = WorkflowExpression.Compile(bodyaddress1County, nameof(bodyaddress1County), required: false);
            return new DeferredBodyAction<UpsertAccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts({0})", __workflow_accountGUID.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertLeadResponse> UpsertLead(Expression<Func<string>> leadGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyfullname = null, Expression<Func<string>> bodyemailaddress1 = null, Expression<Func<string>> bodytelephone1 = null)
        {
            var __workflow_leadGUID = WorkflowExpression.Compile(leadGUID, nameof(leadGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyfullname = WorkflowExpression.Compile(bodyfullname, nameof(bodyfullname), required: false);
            var __workflow_bodyemailaddress1 = WorkflowExpression.Compile(bodyemailaddress1, nameof(bodyemailaddress1), required: false);
            var __workflow_bodytelephone1 = WorkflowExpression.Compile(bodytelephone1, nameof(bodytelephone1), required: false);
            return new DeferredBodyAction<UpsertLeadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/leads({0})", __workflow_leadGUID.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
