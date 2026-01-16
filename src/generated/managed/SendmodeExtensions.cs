//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendmode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendmodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> messagemessagetext, Expression<Func<string[]>> messagerecipients, Expression<Func<string>> contentType = null, Expression<Func<string>> messagesenderid = null, Expression<Func<string>> messagecustomerid = null)
        {
            var apiCallPath = "/v2/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var message = new JObject();
            var messagepropCount = 0;
            if (messagesenderid != null)
            {
                message["senderid"] = ExpressionConverter.ConvertO(messagesenderid);
                messagepropCount++;
            }

            messagepropCount++;
            message["messagetext"] = ExpressionConverter.ConvertO(messagemessagetext);
            if (messagecustomerid != null)
            {
                message["customerid"] = ExpressionConverter.ConvertO(messagecustomerid);
                messagepropCount++;
            }

            messagepropCount++;
            message["recipients"] = ExpressionConverter.ConvertO(messagerecipients);
            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction<SendSMSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<OptoutCustomerResponse> OptoutCustomer(Expression<Func<string>> contentType, Expression<Func<string>> messagemobilenumber, Expression<Func<string>> messageoptoutresponse = null, Expression<Func<string>> messagereturnedresponse = null)
        {
            var apiCallPath = "/v2/optout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var message = new JObject();
            var messagepropCount = 0;
            messagepropCount++;
            message["mobilenumber"] = ExpressionConverter.ConvertO(messagemobilenumber);
            if (messageoptoutresponse != null)
            {
                message["optoutresponse"] = ExpressionConverter.ConvertO(messageoptoutresponse);
                messagepropCount++;
            }

            if (messagereturnedresponse != null)
            {
                message["returnedresponse"] = ExpressionConverter.ConvertO(messagereturnedresponse);
                messagepropCount++;
            }

            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction<OptoutCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<ImportCustomerResponse> ImportCustomer(Expression<Func<string>> importdatagroup, Expression<Func<string>> importdatamobilenumber, Expression<Func<string>> contentType = null, Expression<Func<string>> importdatafirstname = null, Expression<Func<string>> importdatasurname = null, Expression<Func<string>> importdataaddress = null, Expression<Func<string>> importdatatown = null, Expression<Func<string>> importdatacounty = null, Expression<Func<string>> importdataemail = null, Expression<Func<string>> importdatacustom1 = null, Expression<Func<string>> importdatacustom2 = null, Expression<Func<string>> importdatabusinessname = null, Expression<Func<string>> importdatadateofbirth = null)
        {
            var apiCallPath = "/v2/import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var importdata = new JObject();
            var importdatapropCount = 0;
            importdatapropCount++;
            importdata["group"] = ExpressionConverter.ConvertO(importdatagroup);
            importdatapropCount++;
            importdata["mobilenumber"] = ExpressionConverter.ConvertO(importdatamobilenumber);
            if (importdatafirstname != null)
            {
                importdata["firstname"] = ExpressionConverter.ConvertO(importdatafirstname);
                importdatapropCount++;
            }

            if (importdatasurname != null)
            {
                importdata["surname"] = ExpressionConverter.ConvertO(importdatasurname);
                importdatapropCount++;
            }

            if (importdataaddress != null)
            {
                importdata["address"] = ExpressionConverter.ConvertO(importdataaddress);
                importdatapropCount++;
            }

            if (importdatatown != null)
            {
                importdata["town"] = ExpressionConverter.ConvertO(importdatatown);
                importdatapropCount++;
            }

            if (importdatacounty != null)
            {
                importdata["county"] = ExpressionConverter.ConvertO(importdatacounty);
                importdatapropCount++;
            }

            if (importdataemail != null)
            {
                importdata["email"] = ExpressionConverter.ConvertO(importdataemail);
                importdatapropCount++;
            }

            if (importdatacustom1 != null)
            {
                importdata["custom1"] = ExpressionConverter.ConvertO(importdatacustom1);
                importdatapropCount++;
            }

            if (importdatacustom2 != null)
            {
                importdata["custom2"] = ExpressionConverter.ConvertO(importdatacustom2);
                importdatapropCount++;
            }

            if (importdatabusinessname != null)
            {
                importdata["businessname"] = ExpressionConverter.ConvertO(importdatabusinessname);
                importdatapropCount++;
            }

            if (importdatadateofbirth != null)
            {
                importdata["dateofbirth"] = ExpressionConverter.ConvertO(importdatadateofbirth);
                importdatapropCount++;
            }

            if (importdatapropCount > 0)
            {
                callPayload.Body = importdata;
            }

            return new ApiConnectionAction<ImportCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<CheckCreditsResponse> CheckCredits(Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/v2/credits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<CheckCreditsResponse>(callPayload);
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