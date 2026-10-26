//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendmode
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendmodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<SendSMSInput>> message, Expression<Func<string>> contentType = null)
        {
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<OptoutCustomerResponse, ApiConnectionActionConfiguration> OptoutCustomer(Expression<Func<string>> contentType, Expression<Func<OptoutCustomerInput>> message)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<OptoutCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/optout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<OptoutCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<ImportCustomerResponse, ApiConnectionActionConfiguration> ImportCustomer(Expression<Func<ImportCustomerInput>> importdata, Expression<Func<string>> contentType = null)
        {
            var __workflow_importdata = WorkflowExpression.Compile(importdata, nameof(importdata), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<ImportCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_importdata);
                return new ApiConnectionAction<ImportCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<CheckCreditsResponse, ApiConnectionActionConfiguration> CheckCredits(Expression<Func<string>> contentType = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CheckCreditsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/credits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<CheckCreditsResponse>(callPayload);
            });
        }
    }

    public class SendmodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSMSResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("message")]
        public SendSMSResponseMessageType Message { get; set; }
    }

    public class SendSMSResponseMessageType
    {
        [JsonProperty("senderid")]
        public string Senderid { get; set; }

        [JsonProperty("messagetext")]
        public string Messagetext { get; set; }

        [JsonProperty("customerid")]
        public string Customerid { get; set; }

        [JsonProperty("scheduledate")]
        public string Scheduledate { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class SendSMSInput
    {
        [JsonProperty("senderid")]
        public string Senderid { get; set; }

        [JsonProperty("messagetext", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Messagetext { get; set; }

        [JsonProperty("customerid")]
        public string Customerid { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Recipients { get; set; }
    }

    public class OptoutCustomerResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("mobilenumber")]
        public string Mobilenumber { get; set; }

        [JsonProperty("optoutreason")]
        public string Optoutreason { get; set; }
    }

    public class OptoutCustomerInput
    {
        [JsonProperty("mobilenumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mobilenumber { get; set; }

        [JsonProperty("optoutresponse")]
        public string Optoutresponse { get; set; }

        [JsonProperty("returnedresponse")]
        public string Returnedresponse { get; set; }
    }

    public class ImportCustomerResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("importdata")]
        public ImportCustomerResponseImportdataType Importdata { get; set; }
    }

    public class ImportCustomerResponseImportdataType
    {
        [JsonProperty("mobilenumber")]
        public string Mobilenumber { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("businessname")]
        public string Businessname { get; set; }

        [JsonProperty("dateofbirth")]
        public string Dateofbirth { get; set; }
    }

    public class ImportCustomerInput
    {
        [JsonProperty("group", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Group { get; set; }

        [JsonProperty("mobilenumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mobilenumber { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("businessname")]
        public string Businessname { get; set; }

        [JsonProperty("dateofbirth")]
        public string Dateofbirth { get; set; }
    }

    public class CheckCreditsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sendmode;

    public partial class WorkflowManagedActions
    {
        public SendmodeActions Sendmode(string connectionId) => new SendmodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendmodeTriggers Sendmode(string connectionId) => new SendmodeTriggers(connectionId);
    }
}