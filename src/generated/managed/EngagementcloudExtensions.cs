//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Engagementcloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EngagementcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateAddressBookResponse> CreateAddressBook(Expression<Func<regionInput>> region, Expression<Func<string>> bodyname, Expression<Func<bodyvisibilityInput>> bodyvisibility = null)
        {
            var apiCallPath = "/v2/address-books";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyvisibility != null)
            {
                body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAddressBookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> addressBook, Expression<Func<regionInput>> region, Expression<Func<string>> bodyemail, Expression<Func<bodydataFieldsInputItem[]>> bodydataFields = null, Expression<Func<bodyemailTypeInput>> bodyemailType = null, Expression<Func<bodyoptInTypeInput>> bodyoptInType = null)
        {
            var apiCallPath = String.Format("/v2/address-books/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydataFields != null)
            {
                body["dataFields"] = ExpressionConverter.ConvertO(bodydataFields);
                bodypropCount++;
            }

            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyemailType != null)
            {
                body["emailType"] = ExpressionConverter.ConvertO(bodyemailType);
                bodypropCount++;
            }

            if (bodyoptInType != null)
            {
                body["optInType"] = ExpressionConverter.ConvertO(bodyoptInType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<SendEmailCampaignResponse> SendEmailCampaign(Expression<Func<regionInput>> region, Expression<Func<int>> bodyCampaignID, Expression<Func<int[]>> bodyAddressBookIDs = null, Expression<Func<int[]>> bodyContactIDs = null, Expression<Func<string>> bodySendDate = null)
        {
            var apiCallPath = "/v2/campaigns/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddressBookIDs != null)
            {
                body["AddressBookIDs"] = ExpressionConverter.ConvertO(bodyAddressBookIDs);
                bodypropCount++;
            }

            bodypropCount++;
            body["CampaignID"] = ExpressionConverter.ConvertO(bodyCampaignID);
            if (bodyContactIDs != null)
            {
                body["ContactIDs"] = ExpressionConverter.ConvertO(bodyContactIDs);
                bodypropCount++;
            }

            if (bodySendDate != null)
            {
                body["SendDate"] = ExpressionConverter.ConvertO(bodySendDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendEmailCampaignResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendTransactionalEmailUsingTriggeredCampagin(Expression<Func<regionInput>> region, Expression<Func<int>> bodyCampaignID, Expression<Func<string[]>> bodyToAddresses, Expression<Func<bodyPersonalizationValuesInputItem[]>> bodyPersonalizationValues = null)
        {
            var apiCallPath = "/v2/email/triggered-campaign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["CampaignID"] = ExpressionConverter.ConvertO(bodyCampaignID);
            if (bodyPersonalizationValues != null)
            {
                body["PersonalizationValues"] = ExpressionConverter.ConvertO(bodyPersonalizationValues);
                bodypropCount++;
            }

            bodypropCount++;
            body["ToAddresses"] = ExpressionConverter.ConvertO(bodyToAddresses);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse> CreateProgramEnrolment(Expression<Func<regionInput>> region, Expression<Func<int>> bodyProgramID, Expression<Func<int[]>> bodyAddressBooks = null, Expression<Func<int[]>> bodyContacts = null)
        {
            var apiCallPath = "/v2/programs/enrolments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddressBooks != null)
            {
                body["AddressBooks"] = ExpressionConverter.ConvertO(bodyAddressBooks);
                bodypropCount++;
            }

            if (bodyContacts != null)
            {
                body["Contacts"] = ExpressionConverter.ConvertO(bodyContacts);
                bodypropCount++;
            }

            bodypropCount++;
            body["ProgramID"] = ExpressionConverter.ConvertO(bodyProgramID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateProgramEnrolmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendSmsMessage(Expression<Func<string>> telephoneNumber, Expression<Func<regionInput>> region, Expression<Func<string>> bodyMessage)
        {
            var apiCallPath = String.Format("/v2/sms-messages/send-to/{0}", ExpressionConverter.ConvertWithUrlEncoding(telephoneNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction BulkContactsImport(Expression<Func<string>> addressBook, Expression<Func<object>> filedata)
        {
            var apiCallPath = String.Format("/v2/address-books/{0}/contacts/import", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportStatus(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/contacts/import/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportReport(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/contacts/import/{0}/report", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class EngagementcloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateAddressBookResponse
    {
        [JsonProperty("contacts")]
        public int Contacts { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public enum regionInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public enum bodyvisibilityInput
    {
        Private,
        Public
    }

    public class CreateContactResponse
    {
        [JsonProperty("dataFields")]
        public CreateContactResponseDataFieldsTypeItem[] DataFields { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailType")]
        public string EmailType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("optInType")]
        public string OptInType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateContactResponseDataFieldsTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodydataFieldsInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyemailTypeInput
    {
        PlainText,
        Html
    }

    public enum bodyoptInTypeInput
    {
        Unknown,
        Single,
        Double,
        VerifiedDouble
    }

    public class SendEmailCampaignResponse
    {
        [JsonProperty("addressBookIds")]
        public int[] AddressBookIds { get; set; }

        [JsonProperty("campaignId")]
        public int CampaignId { get; set; }

        [JsonProperty("contactIds")]
        public int[] ContactIds { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sendDate")]
        public string SendDate { get; set; }

        [JsonProperty("splitTestOptions")]
        public SendEmailCampaignResponseSplitTestOptionsType SplitTestOptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SendEmailCampaignResponseSplitTestOptionsType
    {
        public string TestMetric { get; set; }
        public int TestPercentage { get; set; }
        public int TestPeriodHours { get; set; }
    }

    public class bodyPersonalizationValuesInputItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CreateProgramEnrolmentResponse
    {
        [JsonProperty("addressBooks")]
        public int[] AddressBooks { get; set; }

        [JsonProperty("contacts")]
        public int[] Contacts { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Engagementcloud;

    public partial class WorkflowManagedActions
    {
        public EngagementcloudActions Engagementcloud(string connectionId) => new EngagementcloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EngagementcloudTriggers Engagementcloud(string connectionId) => new EngagementcloudTriggers(connectionId);
    }
}