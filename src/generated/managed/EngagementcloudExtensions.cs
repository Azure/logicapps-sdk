//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Engagementcloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EngagementcloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAddressBook))]
        public IBodyWorkflowAction<CreateAddressBookResponse> CreateAddressBook([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAddressBookResponse> __BuildCreateAddressBook(WorkflowExpression<regionInput> region, WorkflowExpression<string> bodyname, WorkflowExpression<bodyvisibilityInput> bodyvisibility = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<CreateAddressBookResponse>(() =>
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
                    if (bodyvisibility != null)
                    {
                        body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> addressBook, [WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodydataFieldsInputItem[]> bodydataFields = null, [WorkflowExpression] Func<bodyemailTypeInput> bodyemailType = null, [WorkflowExpression] Func<bodyoptInTypeInput> bodyoptInType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowExpression<string> addressBook, WorkflowExpression<regionInput> region, WorkflowExpression<string> bodyemail, WorkflowExpression<bodydataFieldsInputItem[]> bodydataFields = null, WorkflowExpression<bodyemailTypeInput> bodyemailType = null, WorkflowExpression<bodyoptInTypeInput> bodyoptInType = null)
        {
            WorkflowExpression.Validate(addressBook, nameof(addressBook), required: true);
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodydataFields, nameof(bodydataFields), required: false);
            WorkflowExpression.Validate(bodyemailType, nameof(bodyemailType), required: false);
            WorkflowExpression.Validate(bodyoptInType, nameof(bodyoptInType), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
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
                    if (bodyemailType != null)
                    {
                        body["emailType"] = ExpressionConverter.ConvertO(bodyemailType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["emailType"] = "Html";
                    bodypropCount++;
                }

                if (bodyoptInType != null)
                {
                    if (bodyoptInType != null)
                    {
                        body["optInType"] = ExpressionConverter.ConvertO(bodyoptInType);
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
        [WorkflowExpressionFactory(nameof(__BuildSendEmailCampaign))]
        public IBodyWorkflowAction<SendEmailCampaignResponse> SendEmailCampaign([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodycampaignID, [WorkflowExpression] Func<int[]> bodyaddressBookIDs = null, [WorkflowExpression] Func<int[]> bodycontactIDs = null, [WorkflowExpression] Func<string> bodysendDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendEmailCampaignResponse> __BuildSendEmailCampaign(WorkflowExpression<regionInput> region, WorkflowExpression<int> bodycampaignID, WorkflowExpression<int[]> bodyaddressBookIDs = null, WorkflowExpression<int[]> bodycontactIDs = null, WorkflowExpression<string> bodysendDate = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: true);
            WorkflowExpression.Validate(bodyaddressBookIDs, nameof(bodyaddressBookIDs), required: false);
            WorkflowExpression.Validate(bodycontactIDs, nameof(bodycontactIDs), required: false);
            WorkflowExpression.Validate(bodysendDate, nameof(bodysendDate), required: false);
            return new DeferredBodyAction<SendEmailCampaignResponse>(() =>
            {
                var apiCallPath = "/v2/campaigns/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressBookIDs != null)
                {
                    body["AddressBookIDs"] = ExpressionConverter.ConvertO(bodyaddressBookIDs);
                    bodypropCount++;
                }

                bodypropCount++;
                body["CampaignID"] = ExpressionConverter.ConvertO(bodycampaignID);
                if (bodycontactIDs != null)
                {
                    body["ContactIDs"] = ExpressionConverter.ConvertO(bodycontactIDs);
                    bodypropCount++;
                }

                if (bodysendDate != null)
                {
                    body["SendDate"] = ExpressionConverter.ConvertO(bodysendDate);
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
        [WorkflowExpressionFactory(nameof(__BuildSendTransactionalEmailUsingTriggeredCampagin))]
        public IWorkflowAction SendTransactionalEmailUsingTriggeredCampagin([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodycampaignID, [WorkflowExpression] Func<string[]> bodytoAddresses, [WorkflowExpression] Func<bodypersonalizationValuesInputItem[]> bodypersonalizationValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendTransactionalEmailUsingTriggeredCampagin(WorkflowExpression<regionInput> region, WorkflowExpression<int> bodycampaignID, WorkflowExpression<string[]> bodytoAddresses, WorkflowExpression<bodypersonalizationValuesInputItem[]> bodypersonalizationValues = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: true);
            WorkflowExpression.Validate(bodytoAddresses, nameof(bodytoAddresses), required: true);
            WorkflowExpression.Validate(bodypersonalizationValues, nameof(bodypersonalizationValues), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/email/triggered-campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CampaignID"] = ExpressionConverter.ConvertO(bodycampaignID);
                if (bodypersonalizationValues != null)
                {
                    body["PersonalizationValues"] = ExpressionConverter.ConvertO(bodypersonalizationValues);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToAddresses"] = ExpressionConverter.ConvertO(bodytoAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProgramEnrolment))]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse> CreateProgramEnrolment([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodyprogramID, [WorkflowExpression] Func<int[]> bodyaddressBooks = null, [WorkflowExpression] Func<int[]> bodycontacts = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse> __BuildCreateProgramEnrolment(WorkflowExpression<regionInput> region, WorkflowExpression<int> bodyprogramID, WorkflowExpression<int[]> bodyaddressBooks = null, WorkflowExpression<int[]> bodycontacts = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodyprogramID, nameof(bodyprogramID), required: true);
            WorkflowExpression.Validate(bodyaddressBooks, nameof(bodyaddressBooks), required: false);
            WorkflowExpression.Validate(bodycontacts, nameof(bodycontacts), required: false);
            return new DeferredBodyAction<CreateProgramEnrolmentResponse>(() =>
            {
                var apiCallPath = "/v2/programs/enrolments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressBooks != null)
                {
                    body["AddressBooks"] = ExpressionConverter.ConvertO(bodyaddressBooks);
                    bodypropCount++;
                }

                if (bodycontacts != null)
                {
                    body["Contacts"] = ExpressionConverter.ConvertO(bodycontacts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProgramID"] = ExpressionConverter.ConvertO(bodyprogramID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProgramEnrolmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildSendSmsMessage))]
        public IWorkflowAction SendSmsMessage([WorkflowExpression] Func<string> telephoneNumber, [WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodymessage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSmsMessage(WorkflowExpression<string> telephoneNumber, WorkflowExpression<regionInput> region, WorkflowExpression<string> bodymessage)
        {
            WorkflowExpression.Validate(telephoneNumber, nameof(telephoneNumber), required: true);
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/sms-messages/send-to/{0}", ExpressionConverter.ConvertWithUrlEncoding(telephoneNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildBulkContactsImport))]
        public IWorkflowAction BulkContactsImport([WorkflowExpression] Func<string> addressBook, [WorkflowExpression] Func<object> filedata)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBulkContactsImport(WorkflowExpression<string> addressBook, WorkflowExpression<object> filedata)
        {
            WorkflowExpression.Validate(addressBook, nameof(addressBook), required: true);
            WorkflowExpression.Validate(filedata, nameof(filedata), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts/import", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetContactsImportStatus))]
        public IWorkflowAction GetContactsImportStatus([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContactsImportStatus(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetContactsImportReport))]
        public IWorkflowAction GetContactsImportReport([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContactsImportReport(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}/report", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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