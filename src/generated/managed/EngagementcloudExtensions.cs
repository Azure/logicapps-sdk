//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Engagementcloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EngagementcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateAddressBookResponse> CreateAddressBook(Expression<Func<regionInput>> region, Expression<Func<string>> bodyname, Expression<Func<bodyvisibilityInput>> bodyvisibility = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyvisibility = WorkflowExpression.Compile(bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<CreateAddressBookResponse>(() =>
            {
                var apiCallPath = "/v2/address-books";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyvisibility != null)
                {
                    if (__workflow_bodyvisibility != null)
                    {
                        body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["visibility"] = "Private";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAddressBookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> addressBook, Expression<Func<regionInput>> region, Expression<Func<string>> bodyemail, Expression<Func<bodydataFieldsInputItem[]>> bodydataFields = null, Expression<Func<bodyemailTypeInput>> bodyemailType = null, Expression<Func<bodyoptInTypeInput>> bodyoptInType = null)
        {
            var __workflow_addressBook = WorkflowExpression.Compile(addressBook, nameof(addressBook), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodydataFields = WorkflowExpression.Compile(bodydataFields, nameof(bodydataFields), required: false);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: false);
            var __workflow_bodyoptInType = WorkflowExpression.Compile(bodyoptInType, nameof(bodyoptInType), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_addressBook, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydataFields != null)
                {
                    body["dataFields"] = ExpressionConverter.ConvertO(__workflow_bodydataFields);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyemailType != null)
                {
                    if (__workflow_bodyemailType != null)
                    {
                        body["emailType"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["emailType"] = "Html";
                    bodypropCount++;
                }

                if (__workflow_bodyoptInType != null)
                {
                    if (__workflow_bodyoptInType != null)
                    {
                        body["optInType"] = ExpressionConverter.ConvertO(__workflow_bodyoptInType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["optInType"] = "Unknown";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<SendEmailCampaignResponse> SendEmailCampaign(Expression<Func<regionInput>> region, Expression<Func<int>> bodycampaignID, Expression<Func<int[]>> bodyaddressBookIDs = null, Expression<Func<int[]>> bodycontactIDs = null, Expression<Func<string>> bodysendDate = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodycampaignID = WorkflowExpression.Compile(bodycampaignID, nameof(bodycampaignID), required: true);
            var __workflow_bodyaddressBookIDs = WorkflowExpression.Compile(bodyaddressBookIDs, nameof(bodyaddressBookIDs), required: false);
            var __workflow_bodycontactIDs = WorkflowExpression.Compile(bodycontactIDs, nameof(bodycontactIDs), required: false);
            var __workflow_bodysendDate = WorkflowExpression.Compile(bodysendDate, nameof(bodysendDate), required: false);
            return new DeferredBodyAction<SendEmailCampaignResponse>(() =>
            {
                var apiCallPath = "/v2/campaigns/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressBookIDs != null)
                {
                    body["AddressBookIDs"] = ExpressionConverter.ConvertO(__workflow_bodyaddressBookIDs);
                    bodypropCount++;
                }

                bodypropCount++;
                body["CampaignID"] = ExpressionConverter.ConvertO(__workflow_bodycampaignID);
                if (__workflow_bodycontactIDs != null)
                {
                    body["ContactIDs"] = ExpressionConverter.ConvertO(__workflow_bodycontactIDs);
                    bodypropCount++;
                }

                if (__workflow_bodysendDate != null)
                {
                    body["SendDate"] = ExpressionConverter.ConvertO(__workflow_bodysendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendEmailCampaignResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendTransactionalEmailUsingTriggeredCampagin(Expression<Func<regionInput>> region, Expression<Func<int>> bodycampaignID, Expression<Func<string[]>> bodytoAddresses, Expression<Func<bodypersonalizationValuesInputItem[]>> bodypersonalizationValues = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodycampaignID = WorkflowExpression.Compile(bodycampaignID, nameof(bodycampaignID), required: true);
            var __workflow_bodytoAddresses = WorkflowExpression.Compile(bodytoAddresses, nameof(bodytoAddresses), required: true);
            var __workflow_bodypersonalizationValues = WorkflowExpression.Compile(bodypersonalizationValues, nameof(bodypersonalizationValues), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/email/triggered-campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CampaignID"] = ExpressionConverter.ConvertO(__workflow_bodycampaignID);
                if (__workflow_bodypersonalizationValues != null)
                {
                    body["PersonalizationValues"] = ExpressionConverter.ConvertO(__workflow_bodypersonalizationValues);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToAddresses"] = ExpressionConverter.ConvertO(__workflow_bodytoAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse> CreateProgramEnrolment(Expression<Func<regionInput>> region, Expression<Func<int>> bodyprogramID, Expression<Func<int[]>> bodyaddressBooks = null, Expression<Func<int[]>> bodycontacts = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodyprogramID = WorkflowExpression.Compile(bodyprogramID, nameof(bodyprogramID), required: true);
            var __workflow_bodyaddressBooks = WorkflowExpression.Compile(bodyaddressBooks, nameof(bodyaddressBooks), required: false);
            var __workflow_bodycontacts = WorkflowExpression.Compile(bodycontacts, nameof(bodycontacts), required: false);
            return new DeferredBodyAction<CreateProgramEnrolmentResponse>(() =>
            {
                var apiCallPath = "/v2/programs/enrolments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressBooks != null)
                {
                    body["AddressBooks"] = ExpressionConverter.ConvertO(__workflow_bodyaddressBooks);
                    bodypropCount++;
                }

                if (__workflow_bodycontacts != null)
                {
                    body["Contacts"] = ExpressionConverter.ConvertO(__workflow_bodycontacts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProgramID"] = ExpressionConverter.ConvertO(__workflow_bodyprogramID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProgramEnrolmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendSmsMessage(Expression<Func<string>> telephoneNumber, Expression<Func<regionInput>> region, Expression<Func<string>> bodymessage)
        {
            var __workflow_telephoneNumber = WorkflowExpression.Compile(telephoneNumber, nameof(telephoneNumber), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/sms-messages/send-to/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_telephoneNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction BulkContactsImport(Expression<Func<string>> addressBook, Expression<Func<object>> filedata)
        {
            var __workflow_addressBook = WorkflowExpression.Compile(addressBook, nameof(addressBook), required: true);
            var __workflow_filedata = WorkflowExpression.Compile(filedata, nameof(filedata), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts/import", ExpressionConverter.ConvertWithUrlEncoding(__workflow_addressBook, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportReport(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}/report", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum regionInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyemailTypeInput
    {
        PlainText,
        Html
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class bodypersonalizationValuesInputItem
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
