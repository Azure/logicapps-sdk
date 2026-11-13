//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TxtsyncActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<Sms[], ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sms[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sms[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<Sms, ApiConnectionActionConfiguration> SendBulkSms(Expression<Func<SendBulkSmsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sms, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sms>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SearchContactResponseItem[], ApiConnectionActionConfiguration> SearchContact(Expression<Func<string>> search)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: true);
            return new DeferredBodyAction<SearchContactResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<SearchContactResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<AddContactResponse, ApiConnectionActionConfiguration> AddContact(Expression<Func<AddContactBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<UpdateContactResponse, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> id, Expression<Func<UpdateContactBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse, ApiConnectionActionConfiguration> GetContactByExternalReference(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetContactByExternalReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/external/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<GetContactByExternalReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteContactByExternalReference(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/external/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateContactByExternalReference(Expression<Func<string>> id, Expression<Func<UpdateContactBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/external/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TxtsyncTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<InboundSmsResponse, ApiConnectionPollingTriggerConfiguration> InboundSms()
        {
            return new DeferredBodyTrigger<InboundSmsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/system/applications/webhooks/type/0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = new InboundSmsBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<InboundSmsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<OutboundSmsResponse, ApiConnectionPollingTriggerConfiguration> OutboundSms()
        {
            return new DeferredBodyTrigger<OutboundSmsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/system/applications/webhooks/type/5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = new InboundSmsBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<OutboundSmsResponse>(callPayload);
            });
        }
    }

    public class Sms
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public int Direction { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("SMSID")]
        public int Smsid { get; set; }
        public double Segments { get; set; }
        public string DeliveredDate { get; set; }

        [JsonProperty("CampaignID")]
        public double CampaignId { get; set; }

        [JsonProperty("ApplicationID")]
        public double ApplicationId { get; set; }
        public string ApplicationName { get; set; }

        [JsonProperty("UserID")]
        public double UserId { get; set; }
        public string UserName { get; set; }
        public string ContactName { get; set; }

        [JsonProperty("ProfileURL")]
        public string ProfileUrl { get; set; }
        public string LinkDetails { get; set; }
        public bool IsFlagged { get; set; }
        public string FlaggedDate { get; set; }
        public string FlaggedDescription { get; set; }
        public string CurrencyCode { get; set; }
        public double CostLocal { get; set; }

        [JsonProperty("CostGBP")]
        public double CostGbp { get; set; }
        public double ErrorCode { get; set; }
        public double Status { get; set; }
    }

    public class SendSmsBodyInput
    {
        public SendSmsBodyInput(string from, string message, string to)
        {
            this.From = from;
            this.Message = message;
            this.To = to;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
    }

    public class SendBulkSmsBodyInput
    {
        public SendBulkSmsBodyInput(string from, string message)
        {
            this.From = from;
            this.Message = message;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }
        public string[] To { get; set; }
        public string[] ToTagName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    public class SearchContactResponseItem
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }
        public int OverallRating { get; set; }
        public int TotalDistinctLinkClicks { get; set; }
        public int TotalLinksSent { get; set; }

        [JsonProperty("TotalInboundSMS")]
        public int TotalInboundSms { get; set; }

        [JsonProperty("TotalOutboundSMS")]
        public int TotalOutboundSms { get; set; }

        [JsonProperty("TotalFailedSMS")]
        public int TotalFailedSms { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }

        [JsonProperty("AllowSMS")]
        public bool AllowSms { get; set; }
    }

    public class AddContactResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string FullName { get; set; }
    }

    public class AddContactBodyInput
    {
        public AddContactBodyInput(string mobileNumber)
        {
            this.MobileNumber = mobileNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MobileNumber { get; set; }
        public string CompanyName { get; set; }
        public string ExternalReference { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }
        public string TagNames { get; set; }
    }

    public class UpdateContactResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string FullName { get; set; }
    }

    public class UpdateContactBodyInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string CompanyName { get; set; }
        public string ExternalReference { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }

        [JsonProperty("AllowSMS")]
        public bool? AllowSms { get; set; }
        public string TagNames { get; set; }
    }

    public class GetContactByExternalReferenceResponse
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public string Custom01 { get; set; }
        public string Custom02 { get; set; }
        public string Custom03 { get; set; }
        public string Custom04 { get; set; }
        public string Custom05 { get; set; }
        public int OverallRating { get; set; }
        public int TotalDistinctLinkClicks { get; set; }
        public int TotalLinksSent { get; set; }

        [JsonProperty("TotalInboundSMS")]
        public int TotalInboundSms { get; set; }

        [JsonProperty("TotalOutboundSMS")]
        public int TotalOutboundSms { get; set; }

        [JsonProperty("TotalFailedSMS")]
        public int TotalFailedSms { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }

        [JsonProperty("AllowSMS")]
        public bool AllowSms { get; set; }
    }

    public class InboundSmsResponse
    {
        public InboundSmsResponseContentType Content { get; set; }
    }

    public class InboundSmsResponseContentType
    {
        public InboundSmsResponseContentTypeContactType Contact { get; set; }

        [JsonProperty("SMS")]
        public InboundSmsResponseContentTypeSmsType Sms { get; set; }
    }

    public class InboundSmsResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class InboundSmsResponseContentTypeSmsType
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string DeliveredDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }

        [JsonProperty("SMSID")]
        public int Smsid { get; set; }
        public string ToNumber { get; set; }
    }

    public class InboundSmsBodyInput
    {
        [JsonProperty("URL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class OutboundSmsResponse
    {
        public OutboundSmsResponseContentType Content { get; set; }
    }

    public class OutboundSmsResponseContentType
    {
        public OutboundSmsResponseContentTypeContactType Contact { get; set; }

        [JsonProperty("SMS")]
        public OutboundSmsResponseContentTypeSmsType Sms { get; set; }
    }

    public class OutboundSmsResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class OutboundSmsResponseContentTypeSmsType
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string CreatedDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }

        [JsonProperty("SMSID")]
        public int Smsid { get; set; }
        public string ToNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync;

    public partial class WorkflowManagedActions
    {
        public TxtsyncActions Txtsync(string connectionId) => new TxtsyncActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TxtsyncTriggers Txtsync(string connectionId) => new TxtsyncTriggers(connectionId);
    }
}