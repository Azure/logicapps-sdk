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
        public IBodyWorkflowAction<SMS[], ApiConnectionActionConfiguration> SendSMS(Expression<Func<SendSMSInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SMS[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SMS[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS, ApiConnectionActionConfiguration> SendBulkSMS(Expression<Func<SendBulkSMSInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SMS, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/send/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
                callPayload.Headers["x-zapier"] = Convert.ToString("true");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SMS>(callPayload);
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
        public IBodyWorkflowAction<AddContactResponse, ApiConnectionActionConfiguration> AddContact(Expression<Func<AddContactInput>> body)
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
        public IBodyWorkflowAction<UpdateContactResponse, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> id, Expression<Func<UpdateContactInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateContactByExternalReference(Expression<Func<string>> id, Expression<Func<UpdateContactByExternalReferenceInput>> body)
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
        public IBodyWorkflowTrigger<InboundSMSResponse, ApiConnectionTriggerConfiguration> InboundSMS(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<InboundSMSResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/system/applications/webhooks/type/0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = new InboundSMSInput().ToJToken();
                return new ApiConnectionTrigger<InboundSMSResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OutboundSMSResponse, ApiConnectionTriggerConfiguration> OutboundSMS(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OutboundSMSResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/system/applications/webhooks/type/5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
                callPayload.Body = new OutboundSMSInput().ToJToken();
                return new ApiConnectionTrigger<OutboundSMSResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SMS
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public int Direction { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("SMSID")]
        public int SMSId { get; set; }
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
        public string ProfileURL { get; set; }
        public string LinkDetails { get; set; }
        public bool IsFlagged { get; set; }
        public string FlaggedDate { get; set; }
        public string FlaggedDescription { get; set; }
        public string CurrencyCode { get; set; }
        public double CostLocal { get; set; }
        public double CostGBP { get; set; }
        public double ErrorCode { get; set; }
        public double Status { get; set; }
    }

    public class SendSMSInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
    }

    public class SendBulkSMSInput
    {
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
        public int TotalInboundSMS { get; set; }
        public int TotalOutboundSMS { get; set; }
        public int TotalFailedSMS { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }
        public bool AllowSMS { get; set; }
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

    public class AddContactInput
    {
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

    public class UpdateContactInput
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
        public bool? AllowSMS { get; set; }
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
        public int TotalInboundSMS { get; set; }
        public int TotalOutboundSMS { get; set; }
        public int TotalFailedSMS { get; set; }
        public string ExternalReference { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string LastCommunicationDate { get; set; }
        public bool AllowSMS { get; set; }
    }

    public class UpdateContactByExternalReferenceInput
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
        public bool? AllowSMS { get; set; }
        public string TagNames { get; set; }
    }

    public class InboundSMSResponse
    {
        public InboundSMSResponseContentType Content { get; set; }
    }

    public class InboundSMSResponseContentType
    {
        public InboundSMSResponseContentTypeContactType Contact { get; set; }
        public InboundSMSResponseContentTypeSMSType SMS { get; set; }
    }

    public class InboundSMSResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class InboundSMSResponseContentTypeSMSType
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string DeliveredDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }

        [JsonProperty("SMSID")]
        public int SMSId { get; set; }
        public string ToNumber { get; set; }
    }

    public class InboundSMSInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";
    }

    public class OutboundSMSResponse
    {
        public OutboundSMSResponseContentType Content { get; set; }
    }

    public class OutboundSMSResponseContentType
    {
        public OutboundSMSResponseContentTypeContactType Contact { get; set; }
        public OutboundSMSResponseContentTypeSMSType SMS { get; set; }
    }

    public class OutboundSMSResponseContentTypeContactType
    {
        public string ExternalReference { get; set; }
    }

    public class OutboundSMSResponseContentTypeSMSType
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string CreatedDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }

        [JsonProperty("SMSID")]
        public int SMSId { get; set; }
        public string ToNumber { get; set; }
    }

    public class OutboundSMSInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";
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