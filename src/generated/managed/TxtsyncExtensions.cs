//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Txtsync
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TxtsyncActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS[]> SendSMS(Expression<Func<string>> bodyFrom, Expression<Func<string>> bodyMessage, Expression<Func<string>> bodyTo)
        {
            var apiCallPath = "/sms/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            callPayload.Headers["x-zapier"] = Convert.ToString("true");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["From"] = ExpressionConverter.ConvertO(bodyFrom);
            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
            bodypropCount++;
            body["To"] = ExpressionConverter.ConvertO(bodyTo);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS> SendBulkSMS(Expression<Func<string>> bodyFrom, Expression<Func<string>> bodyMessage, Expression<Func<string[]>> bodyTo = null, Expression<Func<string[]>> bodyToTagName = null)
        {
            var apiCallPath = "/sms/send/bulk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            callPayload.Headers["Content-Type:"] = Convert.ToString("application/json");
            callPayload.Headers["x-zapier"] = Convert.ToString("true");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["From"] = ExpressionConverter.ConvertO(bodyFrom);
            if (bodyTo != null)
            {
                body["To"] = ExpressionConverter.ConvertO(bodyTo);
                bodypropCount++;
            }

            if (bodyToTagName != null)
            {
                body["ToTagName"] = ExpressionConverter.ConvertO(bodyToTagName);
                bodypropCount++;
            }

            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SearchContactResponseItem[]> SearchContact(Expression<Func<string>> search)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            return new ApiConnectionAction<SearchContactResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<AddContactResponse> AddContact(Expression<Func<string>> bodyMobileNumber, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyExternalReference = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyAddressLine1 = null, Expression<Func<string>> bodyAddressLine2 = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyCounty = null, Expression<Func<string>> bodyPostcode = null, Expression<Func<string>> bodyCountry = null, Expression<Func<string>> bodyCustom01 = null, Expression<Func<string>> bodyCustom02 = null, Expression<Func<string>> bodyCustom03 = null, Expression<Func<string>> bodyCustom04 = null, Expression<Func<string>> bodyCustom05 = null, Expression<Func<string>> bodyTagNames = null)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            bodypropCount++;
            body["MobileNumber"] = ExpressionConverter.ConvertO(bodyMobileNumber);
            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyExternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyExternalReference);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyAddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyAddressLine1);
                bodypropCount++;
            }

            if (bodyAddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyAddressLine2);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyCounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodyCounty);
                bodypropCount++;
            }

            if (bodyPostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodyPostcode);
                bodypropCount++;
            }

            if (bodyCountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodyCountry);
                bodypropCount++;
            }

            if (bodyCustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodyCustom01);
                bodypropCount++;
            }

            if (bodyCustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodyCustom02);
                bodypropCount++;
            }

            if (bodyCustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodyCustom03);
                bodypropCount++;
            }

            if (bodyCustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodyCustom04);
                bodypropCount++;
            }

            if (bodyCustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodyCustom05);
                bodypropCount++;
            }

            if (bodyTagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodyTagNames);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContact(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact(Expression<Func<string>> id, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyMobileNumber = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyExternalReference = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyAddressLine1 = null, Expression<Func<string>> bodyAddressLine2 = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyCounty = null, Expression<Func<string>> bodyPostcode = null, Expression<Func<string>> bodyCountry = null, Expression<Func<string>> bodyCustom01 = null, Expression<Func<string>> bodyCustom02 = null, Expression<Func<string>> bodyCustom03 = null, Expression<Func<string>> bodyCustom04 = null, Expression<Func<string>> bodyCustom05 = null, Expression<Func<bool>> bodyAllowSMS = null, Expression<Func<string>> bodyTagNames = null)
        {
            var apiCallPath = String.Format("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodyMobileNumber != null)
            {
                body["MobileNumber"] = ExpressionConverter.ConvertO(bodyMobileNumber);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyExternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyExternalReference);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyAddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyAddressLine1);
                bodypropCount++;
            }

            if (bodyAddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyAddressLine2);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyCounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodyCounty);
                bodypropCount++;
            }

            if (bodyPostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodyPostcode);
                bodypropCount++;
            }

            if (bodyCountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodyCountry);
                bodypropCount++;
            }

            if (bodyCustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodyCustom01);
                bodypropCount++;
            }

            if (bodyCustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodyCustom02);
                bodypropCount++;
            }

            if (bodyCustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodyCustom03);
                bodypropCount++;
            }

            if (bodyCustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodyCustom04);
                bodypropCount++;
            }

            if (bodyCustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodyCustom05);
                bodypropCount++;
            }

            if (bodyAllowSMS != null)
            {
                body["AllowSMS"] = ExpressionConverter.ConvertO(bodyAllowSMS);
                bodypropCount++;
            }

            if (bodyTagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodyTagNames);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<GetContactByExternalReferenceResponse> GetContactByExternalReference(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            return new ApiConnectionAction<GetContactByExternalReferenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> DeleteContactByExternalReference(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<string> UpdateContactByExternalReference(Expression<Func<string>> id, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyMobileNumber = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyExternalReference = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyAddressLine1 = null, Expression<Func<string>> bodyAddressLine2 = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyCounty = null, Expression<Func<string>> bodyPostcode = null, Expression<Func<string>> bodyCountry = null, Expression<Func<string>> bodyCustom01 = null, Expression<Func<string>> bodyCustom02 = null, Expression<Func<string>> bodyCustom03 = null, Expression<Func<string>> bodyCustom04 = null, Expression<Func<string>> bodyCustom05 = null, Expression<Func<bool>> bodyAllowSMS = null, Expression<Func<string>> bodyTagNames = null)
        {
            var apiCallPath = String.Format("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodyMobileNumber != null)
            {
                body["MobileNumber"] = ExpressionConverter.ConvertO(bodyMobileNumber);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyExternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyExternalReference);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyAddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyAddressLine1);
                bodypropCount++;
            }

            if (bodyAddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyAddressLine2);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyCounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodyCounty);
                bodypropCount++;
            }

            if (bodyPostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodyPostcode);
                bodypropCount++;
            }

            if (bodyCountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodyCountry);
                bodypropCount++;
            }

            if (bodyCustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodyCustom01);
                bodypropCount++;
            }

            if (bodyCustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodyCustom02);
                bodypropCount++;
            }

            if (bodyCustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodyCustom03);
                bodypropCount++;
            }

            if (bodyCustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodyCustom04);
                bodypropCount++;
            }

            if (bodyCustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodyCustom05);
                bodypropCount++;
            }

            if (bodyAllowSMS != null)
            {
                body["AllowSMS"] = ExpressionConverter.ConvertO(bodyAllowSMS);
                bodypropCount++;
            }

            if (bodyTagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodyTagNames);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class TxtsyncTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<InboundSMSResponse> InboundSMS(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/system/applications/webhooks/type/0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            body["URL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<InboundSMSResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OutboundSMSResponse> OutboundSMS(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/system/applications/webhooks/type/5";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            body["URL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<OutboundSMSResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class SMS
    {
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public int ContactID { get; set; }
        public int Direction { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }
        public int SMSID { get; set; }
        public double Segments { get; set; }
        public string DeliveredDate { get; set; }
        public double CampaignID { get; set; }
        public double ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public double UserID { get; set; }
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

    public class SearchContactResponseItem
    {
        public int ContactID { get; set; }
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
        public int ContactID { get; set; }
        public string FullName { get; set; }
    }

    public class UpdateContactResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ContactID { get; set; }
        public string FullName { get; set; }
    }

    public class GetContactByExternalReferenceResponse
    {
        public int ContactID { get; set; }
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
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string DeliveredDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }
        public int SMSID { get; set; }
        public string ToNumber { get; set; }
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
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string CreatedDate { get; set; }
        public string FromNumber { get; set; }
        public string Message { get; set; }
        public int SMSID { get; set; }
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