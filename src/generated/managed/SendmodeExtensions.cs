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
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> messagemessagetext, [WorkflowExpression] Func<string[]> messagerecipients, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> messagesenderid = null, [WorkflowExpression] Func<string> messagecustomerid = null)
        {
            SourceExpression.Validate(messagemessagetext, nameof(messagemessagetext), required: true);
            SourceExpression.Validate(messagerecipients, nameof(messagerecipients), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(messagesenderid, nameof(messagesenderid), required: false);
            SourceExpression.Validate(messagecustomerid, nameof(messagecustomerid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var message = new JObject();
                var messagepropCount = 0;
                if (messagesenderid != null)
                {
                    message["senderid"] = SourceExpressionConverter.ConvertToken(messagesenderid);
                    messagepropCount++;
                }

                messagepropCount++;
                message["messagetext"] = SourceExpressionConverter.ConvertToken(messagemessagetext);
                if (messagecustomerid != null)
                {
                    message["customerid"] = SourceExpressionConverter.ConvertToken(messagecustomerid);
                    messagepropCount++;
                }

                messagepropCount++;
                message["recipients"] = SourceExpressionConverter.ConvertToken(messagerecipients);
                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<OptoutCustomerResponse> OptoutCustomer([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> messagemobilenumber, [WorkflowExpression] Func<string> messageoptoutresponse = null, [WorkflowExpression] Func<string> messagereturnedresponse = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(messagemobilenumber, nameof(messagemobilenumber), required: true);
            SourceExpression.Validate(messageoptoutresponse, nameof(messageoptoutresponse), required: false);
            SourceExpression.Validate(messagereturnedresponse, nameof(messagereturnedresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/optout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var message = new JObject();
                var messagepropCount = 0;
                messagepropCount++;
                message["mobilenumber"] = SourceExpressionConverter.ConvertToken(messagemobilenumber);
                if (messageoptoutresponse != null)
                {
                    message["optoutresponse"] = SourceExpressionConverter.ConvertToken(messageoptoutresponse);
                    messagepropCount++;
                }

                if (messagereturnedresponse != null)
                {
                    message["returnedresponse"] = SourceExpressionConverter.ConvertToken(messagereturnedresponse);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OptoutCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<ImportCustomerResponse> ImportCustomer([WorkflowExpression] Func<string> importdatagroup, [WorkflowExpression] Func<string> importdatamobilenumber, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> importdatafirstname = null, [WorkflowExpression] Func<string> importdatasurname = null, [WorkflowExpression] Func<string> importdataaddress = null, [WorkflowExpression] Func<string> importdatatown = null, [WorkflowExpression] Func<string> importdatacounty = null, [WorkflowExpression] Func<string> importdataemail = null, [WorkflowExpression] Func<string> importdatacustom1 = null, [WorkflowExpression] Func<string> importdatacustom2 = null, [WorkflowExpression] Func<string> importdatabusinessname = null, [WorkflowExpression] Func<string> importdatadateofbirth = null)
        {
            SourceExpression.Validate(importdatagroup, nameof(importdatagroup), required: true);
            SourceExpression.Validate(importdatamobilenumber, nameof(importdatamobilenumber), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(importdatafirstname, nameof(importdatafirstname), required: false);
            SourceExpression.Validate(importdatasurname, nameof(importdatasurname), required: false);
            SourceExpression.Validate(importdataaddress, nameof(importdataaddress), required: false);
            SourceExpression.Validate(importdatatown, nameof(importdatatown), required: false);
            SourceExpression.Validate(importdatacounty, nameof(importdatacounty), required: false);
            SourceExpression.Validate(importdataemail, nameof(importdataemail), required: false);
            SourceExpression.Validate(importdatacustom1, nameof(importdatacustom1), required: false);
            SourceExpression.Validate(importdatacustom2, nameof(importdatacustom2), required: false);
            SourceExpression.Validate(importdatabusinessname, nameof(importdatabusinessname), required: false);
            SourceExpression.Validate(importdatadateofbirth, nameof(importdatadateofbirth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var importdata = new JObject();
                var importdatapropCount = 0;
                importdatapropCount++;
                importdata["group"] = SourceExpressionConverter.ConvertToken(importdatagroup);
                importdatapropCount++;
                importdata["mobilenumber"] = SourceExpressionConverter.ConvertToken(importdatamobilenumber);
                if (importdatafirstname != null)
                {
                    importdata["firstname"] = SourceExpressionConverter.ConvertToken(importdatafirstname);
                    importdatapropCount++;
                }

                if (importdatasurname != null)
                {
                    importdata["surname"] = SourceExpressionConverter.ConvertToken(importdatasurname);
                    importdatapropCount++;
                }

                if (importdataaddress != null)
                {
                    importdata["address"] = SourceExpressionConverter.ConvertToken(importdataaddress);
                    importdatapropCount++;
                }

                if (importdatatown != null)
                {
                    importdata["town"] = SourceExpressionConverter.ConvertToken(importdatatown);
                    importdatapropCount++;
                }

                if (importdatacounty != null)
                {
                    importdata["county"] = SourceExpressionConverter.ConvertToken(importdatacounty);
                    importdatapropCount++;
                }

                if (importdataemail != null)
                {
                    importdata["email"] = SourceExpressionConverter.ConvertToken(importdataemail);
                    importdatapropCount++;
                }

                if (importdatacustom1 != null)
                {
                    importdata["custom1"] = SourceExpressionConverter.ConvertToken(importdatacustom1);
                    importdatapropCount++;
                }

                if (importdatacustom2 != null)
                {
                    importdata["custom2"] = SourceExpressionConverter.ConvertToken(importdatacustom2);
                    importdatapropCount++;
                }

                if (importdatabusinessname != null)
                {
                    importdata["businessname"] = SourceExpressionConverter.ConvertToken(importdatabusinessname);
                    importdatapropCount++;
                }

                if (importdatadateofbirth != null)
                {
                    importdata["dateofbirth"] = SourceExpressionConverter.ConvertToken(importdatadateofbirth);
                    importdatapropCount++;
                }

                if (importdatapropCount > 0)
                {
                    callPayload.Body = importdata;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendmode")]
        public IBodyWorkflowAction<CheckCreditsResponse> CheckCredits([WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/credits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<CheckCreditsResponse>(BuildSourceInput);
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