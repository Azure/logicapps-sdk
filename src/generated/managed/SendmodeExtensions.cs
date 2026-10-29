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
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<string>> messagemessagetext, Expression<Func<string[]>> messagerecipients, Expression<Func<string>> contentType = null, Expression<Func<string>> messagesenderid = null, Expression<Func<string>> messagecustomerid = null)
        {
            var __workflow_messagemessagetext = WorkflowExpression.Compile(messagemessagetext, nameof(messagemessagetext), required: true);
            var __workflow_messagerecipients = WorkflowExpression.Compile(messagerecipients, nameof(messagerecipients), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_messagesenderid = WorkflowExpression.Compile(messagesenderid, nameof(messagesenderid), required: false);
            var __workflow_messagecustomerid = WorkflowExpression.Compile(messagecustomerid, nameof(messagecustomerid), required: false);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var message = new JObject();
                var messagepropCount = 0;
                if (__workflow_messagesenderid != null)
                {
                    message["senderid"] = ExpressionConverter.ConvertO(__workflow_messagesenderid);
                    messagepropCount++;
                }

                messagepropCount++;
                message["messagetext"] = ExpressionConverter.ConvertO(__workflow_messagemessagetext);
                if (__workflow_messagecustomerid != null)
                {
                    message["customerid"] = ExpressionConverter.ConvertO(__workflow_messagecustomerid);
                    messagepropCount++;
                }

                messagepropCount++;
                message["recipients"] = ExpressionConverter.ConvertO(__workflow_messagerecipients);
                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<OptoutCustomerResponse, ApiConnectionActionConfiguration> OptoutCustomer(Expression<Func<string>> contentType, Expression<Func<string>> messagemobilenumber, Expression<Func<string>> messageoptoutresponse = null, Expression<Func<string>> messagereturnedresponse = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_messagemobilenumber = WorkflowExpression.Compile(messagemobilenumber, nameof(messagemobilenumber), required: true);
            var __workflow_messageoptoutresponse = WorkflowExpression.Compile(messageoptoutresponse, nameof(messageoptoutresponse), required: false);
            var __workflow_messagereturnedresponse = WorkflowExpression.Compile(messagereturnedresponse, nameof(messagereturnedresponse), required: false);
            return new DeferredBodyAction<OptoutCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/optout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var message = new JObject();
                var messagepropCount = 0;
                messagepropCount++;
                message["mobilenumber"] = ExpressionConverter.ConvertO(__workflow_messagemobilenumber);
                if (__workflow_messageoptoutresponse != null)
                {
                    message["optoutresponse"] = ExpressionConverter.ConvertO(__workflow_messageoptoutresponse);
                    messagepropCount++;
                }

                if (__workflow_messagereturnedresponse != null)
                {
                    message["returnedresponse"] = ExpressionConverter.ConvertO(__workflow_messagereturnedresponse);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

                return new ApiConnectionAction<OptoutCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<ImportCustomerResponse, ApiConnectionActionConfiguration> ImportCustomer(Expression<Func<string>> importdatagroup, Expression<Func<string>> importdatamobilenumber, Expression<Func<string>> contentType = null, Expression<Func<string>> importdatafirstname = null, Expression<Func<string>> importdatasurname = null, Expression<Func<string>> importdataaddress = null, Expression<Func<string>> importdatatown = null, Expression<Func<string>> importdatacounty = null, Expression<Func<string>> importdataemail = null, Expression<Func<string>> importdatacustom1 = null, Expression<Func<string>> importdatacustom2 = null, Expression<Func<string>> importdatabusinessname = null, Expression<Func<string>> importdatadateofbirth = null)
        {
            var __workflow_importdatagroup = WorkflowExpression.Compile(importdatagroup, nameof(importdatagroup), required: true);
            var __workflow_importdatamobilenumber = WorkflowExpression.Compile(importdatamobilenumber, nameof(importdatamobilenumber), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_importdatafirstname = WorkflowExpression.Compile(importdatafirstname, nameof(importdatafirstname), required: false);
            var __workflow_importdatasurname = WorkflowExpression.Compile(importdatasurname, nameof(importdatasurname), required: false);
            var __workflow_importdataaddress = WorkflowExpression.Compile(importdataaddress, nameof(importdataaddress), required: false);
            var __workflow_importdatatown = WorkflowExpression.Compile(importdatatown, nameof(importdatatown), required: false);
            var __workflow_importdatacounty = WorkflowExpression.Compile(importdatacounty, nameof(importdatacounty), required: false);
            var __workflow_importdataemail = WorkflowExpression.Compile(importdataemail, nameof(importdataemail), required: false);
            var __workflow_importdatacustom1 = WorkflowExpression.Compile(importdatacustom1, nameof(importdatacustom1), required: false);
            var __workflow_importdatacustom2 = WorkflowExpression.Compile(importdatacustom2, nameof(importdatacustom2), required: false);
            var __workflow_importdatabusinessname = WorkflowExpression.Compile(importdatabusinessname, nameof(importdatabusinessname), required: false);
            var __workflow_importdatadateofbirth = WorkflowExpression.Compile(importdatadateofbirth, nameof(importdatadateofbirth), required: false);
            return new DeferredBodyAction<ImportCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var importdata = new JObject();
                var importdatapropCount = 0;
                importdatapropCount++;
                importdata["group"] = ExpressionConverter.ConvertO(__workflow_importdatagroup);
                importdatapropCount++;
                importdata["mobilenumber"] = ExpressionConverter.ConvertO(__workflow_importdatamobilenumber);
                if (__workflow_importdatafirstname != null)
                {
                    importdata["firstname"] = ExpressionConverter.ConvertO(__workflow_importdatafirstname);
                    importdatapropCount++;
                }

                if (__workflow_importdatasurname != null)
                {
                    importdata["surname"] = ExpressionConverter.ConvertO(__workflow_importdatasurname);
                    importdatapropCount++;
                }

                if (__workflow_importdataaddress != null)
                {
                    importdata["address"] = ExpressionConverter.ConvertO(__workflow_importdataaddress);
                    importdatapropCount++;
                }

                if (__workflow_importdatatown != null)
                {
                    importdata["town"] = ExpressionConverter.ConvertO(__workflow_importdatatown);
                    importdatapropCount++;
                }

                if (__workflow_importdatacounty != null)
                {
                    importdata["county"] = ExpressionConverter.ConvertO(__workflow_importdatacounty);
                    importdatapropCount++;
                }

                if (__workflow_importdataemail != null)
                {
                    importdata["email"] = ExpressionConverter.ConvertO(__workflow_importdataemail);
                    importdatapropCount++;
                }

                if (__workflow_importdatacustom1 != null)
                {
                    importdata["custom1"] = ExpressionConverter.ConvertO(__workflow_importdatacustom1);
                    importdatapropCount++;
                }

                if (__workflow_importdatacustom2 != null)
                {
                    importdata["custom2"] = ExpressionConverter.ConvertO(__workflow_importdatacustom2);
                    importdatapropCount++;
                }

                if (__workflow_importdatabusinessname != null)
                {
                    importdata["businessname"] = ExpressionConverter.ConvertO(__workflow_importdatabusinessname);
                    importdatapropCount++;
                }

                if (__workflow_importdatadateofbirth != null)
                {
                    importdata["dateofbirth"] = ExpressionConverter.ConvertO(__workflow_importdatadateofbirth);
                    importdatapropCount++;
                }

                if (importdatapropCount > 0)
                {
                    callPayload.Body = importdata;
                }

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
