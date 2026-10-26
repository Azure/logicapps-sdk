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
        public IBodyWorkflowAction<UpsertContactResponse, ApiConnectionActionConfiguration> UpsertContact(Expression<Func<string>> contactGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<UpsertContactInput>> body)
        {
            var __workflow_contactGUID = WorkflowExpression.Compile(contactGUID, nameof(contactGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts({0})", __workflow_contactGUID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertAccountResponse, ApiConnectionActionConfiguration> UpsertAccount(Expression<Func<string>> accountGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<UpsertAccountInput>> body)
        {
            var __workflow_accountGUID = WorkflowExpression.Compile(accountGUID, nameof(accountGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts({0})", __workflow_accountGUID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftd365cev9ip")]
        public IBodyWorkflowAction<UpsertLeadResponse, ApiConnectionActionConfiguration> UpsertLead(Expression<Func<string>> leadGUID, Expression<Func<string>> oDataMaxVersion, Expression<Func<string>> oDataVersion, Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<UpsertLeadInput>> body)
        {
            var __workflow_leadGUID = WorkflowExpression.Compile(leadGUID, nameof(leadGUID), required: true);
            var __workflow_oDataMaxVersion = WorkflowExpression.Compile(oDataMaxVersion, nameof(oDataMaxVersion), required: true);
            var __workflow_oDataVersion = WorkflowExpression.Compile(oDataVersion, nameof(oDataVersion), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertLeadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/leads({0})", __workflow_leadGUID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OData-MaxVersion"] = ExpressionConverter.Convert(__workflow_oDataMaxVersion);
                callPayload.Headers["OData-Version"] = ExpressionConverter.Convert(__workflow_oDataVersion);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class UpsertContactInput
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("middlename")]
        public string Middlename { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("customertypecode")]
        public string Customertypecode { get; set; }

        [JsonProperty("emailaddress1")]
        public string Emailaddress1 { get; set; }

        [JsonProperty("emailaddress2")]
        public string Emailaddress2 { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty("telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty("telephone3")]
        public string Telephone3 { get; set; }

        [JsonProperty("mobilephone")]
        public string Mobilephone { get; set; }

        [JsonProperty("address1_line1")]
        public string Address1Line1 { get; set; }

        [JsonProperty("address1_line2")]
        public string Address1Line2 { get; set; }

        [JsonProperty("address1_city")]
        public string Address1City { get; set; }

        [JsonProperty("address1_stateorprovince")]
        public string Address1Stateorprovince { get; set; }

        [JsonProperty("address1_postalcode")]
        public string Address1Postalcode { get; set; }

        [JsonProperty("address1_county")]
        public string Address1County { get; set; }
    }

    public class UpsertAccountResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class UpsertAccountInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address1_line1")]
        public string Address1Line1 { get; set; }

        [JsonProperty("address1_line2")]
        public string Address1Line2 { get; set; }

        [JsonProperty("address1_city")]
        public string Address1City { get; set; }

        [JsonProperty("address1_stateorprovince")]
        public string Address1Stateorprovince { get; set; }

        [JsonProperty("address1_postalcode")]
        public string Address1Postalcode { get; set; }

        [JsonProperty("address1_county")]
        public string Address1County { get; set; }
    }

    public class UpsertLeadResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class UpsertLeadInput
    {
        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("emailaddress1")]
        public string Emailaddress1 { get; set; }

        [JsonProperty("telephone1")]
        public string Telephone1 { get; set; }
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