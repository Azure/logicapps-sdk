//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendmode
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendmodeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMS))]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> messagemessagetext, [WorkflowExpression] Func<string[]> messagerecipients, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> messagesenderid = null, [WorkflowExpression] Func<string> messagecustomerid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSMSResponse> __BuildSendSMS(WorkflowExpression<string> messagemessagetext, WorkflowExpression<string[]> messagerecipients, WorkflowExpression<string> contentType = null, WorkflowExpression<string> messagesenderid = null, WorkflowExpression<string> messagecustomerid = null)
        {
            WorkflowExpression.Validate(messagemessagetext, nameof(messagemessagetext), required: true);
            WorkflowExpression.Validate(messagerecipients, nameof(messagerecipients), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(messagesenderid, nameof(messagesenderid), required: false);
            WorkflowExpression.Validate(messagecustomerid, nameof(messagecustomerid), required: false);
            return new DeferredBodyAction<SendSMSResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        [WorkflowExpressionFactory(nameof(__BuildOptoutCustomer))]
        public IBodyWorkflowAction<OptoutCustomerResponse> OptoutCustomer([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> messagemobilenumber, [WorkflowExpression] Func<string> messageoptoutresponse = null, [WorkflowExpression] Func<string> messagereturnedresponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OptoutCustomerResponse> __BuildOptoutCustomer(WorkflowExpression<string> contentType, WorkflowExpression<string> messagemobilenumber, WorkflowExpression<string> messageoptoutresponse = null, WorkflowExpression<string> messagereturnedresponse = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(messagemobilenumber, nameof(messagemobilenumber), required: true);
            WorkflowExpression.Validate(messageoptoutresponse, nameof(messageoptoutresponse), required: false);
            WorkflowExpression.Validate(messagereturnedresponse, nameof(messagereturnedresponse), required: false);
            return new DeferredBodyAction<OptoutCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        [WorkflowExpressionFactory(nameof(__BuildImportCustomer))]
        public IBodyWorkflowAction<ImportCustomerResponse> ImportCustomer([WorkflowExpression] Func<string> importdatagroup, [WorkflowExpression] Func<string> importdatamobilenumber, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> importdatafirstname = null, [WorkflowExpression] Func<string> importdatasurname = null, [WorkflowExpression] Func<string> importdataaddress = null, [WorkflowExpression] Func<string> importdatatown = null, [WorkflowExpression] Func<string> importdatacounty = null, [WorkflowExpression] Func<string> importdataemail = null, [WorkflowExpression] Func<string> importdatacustom1 = null, [WorkflowExpression] Func<string> importdatacustom2 = null, [WorkflowExpression] Func<string> importdatabusinessname = null, [WorkflowExpression] Func<string> importdatadateofbirth = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImportCustomerResponse> __BuildImportCustomer(WorkflowExpression<string> importdatagroup, WorkflowExpression<string> importdatamobilenumber, WorkflowExpression<string> contentType = null, WorkflowExpression<string> importdatafirstname = null, WorkflowExpression<string> importdatasurname = null, WorkflowExpression<string> importdataaddress = null, WorkflowExpression<string> importdatatown = null, WorkflowExpression<string> importdatacounty = null, WorkflowExpression<string> importdataemail = null, WorkflowExpression<string> importdatacustom1 = null, WorkflowExpression<string> importdatacustom2 = null, WorkflowExpression<string> importdatabusinessname = null, WorkflowExpression<string> importdatadateofbirth = null)
        {
            WorkflowExpression.Validate(importdatagroup, nameof(importdatagroup), required: true);
            WorkflowExpression.Validate(importdatamobilenumber, nameof(importdatamobilenumber), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(importdatafirstname, nameof(importdatafirstname), required: false);
            WorkflowExpression.Validate(importdatasurname, nameof(importdatasurname), required: false);
            WorkflowExpression.Validate(importdataaddress, nameof(importdataaddress), required: false);
            WorkflowExpression.Validate(importdatatown, nameof(importdatatown), required: false);
            WorkflowExpression.Validate(importdatacounty, nameof(importdatacounty), required: false);
            WorkflowExpression.Validate(importdataemail, nameof(importdataemail), required: false);
            WorkflowExpression.Validate(importdatacustom1, nameof(importdatacustom1), required: false);
            WorkflowExpression.Validate(importdatacustom2, nameof(importdatacustom2), required: false);
            WorkflowExpression.Validate(importdatabusinessname, nameof(importdatabusinessname), required: false);
            WorkflowExpression.Validate(importdatadateofbirth, nameof(importdatadateofbirth), required: false);
            return new DeferredBodyAction<ImportCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        [WorkflowExpressionFactory(nameof(__BuildCheckCredits))]
        public IBodyWorkflowAction<CheckCreditsResponse> CheckCredits([WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckCreditsResponse> __BuildCheckCredits(WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CheckCreditsResponse>(() =>
            {
                var apiCallPath = "/v2/credits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
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