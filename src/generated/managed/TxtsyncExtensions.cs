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
        public IBodyWorkflowAction<SMS[]> SendSMS(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodymessage, Expression<Func<string>> bodyto)
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
            body["From"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodymessage);
            bodypropCount++;
            body["To"] = ExpressionConverter.ConvertO(bodyto);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "txtsync")]
        public IBodyWorkflowAction<SMS> SendBulkSMS(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodymessage, Expression<Func<string[]>> bodyto = null, Expression<Func<string[]>> bodytoTagName = null)
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
            body["From"] = ExpressionConverter.ConvertO(bodyfrom);
            if (bodyto != null)
            {
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
            }

            if (bodytoTagName != null)
            {
                body["ToTagName"] = ExpressionConverter.ConvertO(bodytoTagName);
                bodypropCount++;
            }

            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodymessage);
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
        public IBodyWorkflowAction<AddContactResponse> AddContact(Expression<Func<string>> bodymobileNumber, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<string>> bodytagNames = null)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            bodypropCount++;
            body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyexternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyaddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                bodypropCount++;
            }

            if (bodyaddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodypostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodycustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                bodypropCount++;
            }

            if (bodycustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                bodypropCount++;
            }

            if (bodycustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                bodypropCount++;
            }

            if (bodycustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                bodypropCount++;
            }

            if (bodycustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                bodypropCount++;
            }

            if (bodytagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymobileNumber = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<bool>> bodyallowSMS = null, Expression<Func<string>> bodytagNames = null)
        {
            var apiCallPath = String.Format("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodymobileNumber != null)
            {
                body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyexternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyaddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                bodypropCount++;
            }

            if (bodyaddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodypostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodycustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                bodypropCount++;
            }

            if (bodycustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                bodypropCount++;
            }

            if (bodycustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                bodypropCount++;
            }

            if (bodycustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                bodypropCount++;
            }

            if (bodycustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                bodypropCount++;
            }

            if (bodyallowSMS != null)
            {
                body["AllowSMS"] = ExpressionConverter.ConvertO(bodyallowSMS);
                bodypropCount++;
            }

            if (bodytagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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
        public IBodyWorkflowAction<string> UpdateContactByExternalReference(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymobileNumber = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycustom01 = null, Expression<Func<string>> bodycustom02 = null, Expression<Func<string>> bodycustom03 = null, Expression<Func<string>> bodycustom04 = null, Expression<Func<string>> bodycustom05 = null, Expression<Func<bool>> bodyallowSMS = null, Expression<Func<string>> bodytagNames = null)
        {
            var apiCallPath = String.Format("/contacts/external/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["x-api-key"] = Convert.ToString("<Secret cannot be exposed in connector artifacts>");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodymobileNumber != null)
            {
                body["MobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyexternalReference != null)
            {
                body["ExternalReference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyaddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                bodypropCount++;
            }

            if (bodyaddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodypostcode != null)
            {
                body["Postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodycustom01 != null)
            {
                body["Custom01"] = ExpressionConverter.ConvertO(bodycustom01);
                bodypropCount++;
            }

            if (bodycustom02 != null)
            {
                body["Custom02"] = ExpressionConverter.ConvertO(bodycustom02);
                bodypropCount++;
            }

            if (bodycustom03 != null)
            {
                body["Custom03"] = ExpressionConverter.ConvertO(bodycustom03);
                bodypropCount++;
            }

            if (bodycustom04 != null)
            {
                body["Custom04"] = ExpressionConverter.ConvertO(bodycustom04);
                bodypropCount++;
            }

            if (bodycustom05 != null)
            {
                body["Custom05"] = ExpressionConverter.ConvertO(bodycustom05);
                bodypropCount++;
            }

            if (bodyallowSMS != null)
            {
                body["AllowSMS"] = ExpressionConverter.ConvertO(bodyallowSMS);
                bodypropCount++;
            }

            if (bodytagNames != null)
            {
                body["TagNames"] = ExpressionConverter.ConvertO(bodytagNames);
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