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
        public IBodyWorkflowAction<CreateAddressBookResponse> CreateAddressBook([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/address-books";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyvisibility != null)
                {
                    if (bodyvisibility != null)
                    {
                        body["visibility"] = SourceExpressionConverter.Convert(bodyvisibility);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateAddressBookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> addressBook, [WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodydataFieldsInputItem[]> bodydataFields = null, [WorkflowExpression] Func<bodyemailTypeInput> bodyemailType = null, [WorkflowExpression] Func<bodyoptInTypeInput> bodyoptInType = null)
        {
            SourceExpression.Validate(addressBook, nameof(addressBook), required: true);
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodydataFields, nameof(bodydataFields), required: false);
            SourceExpression.Validate(bodyemailType, nameof(bodyemailType), required: false);
            SourceExpression.Validate(bodyoptInType, nameof(bodyoptInType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(addressBook, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydataFields != null)
                {
                    body["dataFields"] = SourceExpressionConverter.ConvertToken(bodydataFields);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyemailType != null)
                {
                    if (bodyemailType != null)
                    {
                        body["emailType"] = SourceExpressionConverter.Convert(bodyemailType);
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
                        body["optInType"] = SourceExpressionConverter.Convert(bodyoptInType);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<SendEmailCampaignResponse> SendEmailCampaign([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodycampaignID, [WorkflowExpression] Func<int[]> bodyaddressBookIDs = null, [WorkflowExpression] Func<int[]> bodycontactIDs = null, [WorkflowExpression] Func<string> bodysendDate = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: true);
            SourceExpression.Validate(bodyaddressBookIDs, nameof(bodyaddressBookIDs), required: false);
            SourceExpression.Validate(bodycontactIDs, nameof(bodycontactIDs), required: false);
            SourceExpression.Validate(bodysendDate, nameof(bodysendDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/campaigns/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressBookIDs != null)
                {
                    body["AddressBookIDs"] = SourceExpressionConverter.ConvertToken(bodyaddressBookIDs);
                    bodypropCount++;
                }

                bodypropCount++;
                body["CampaignID"] = SourceExpressionConverter.ConvertToken(bodycampaignID);
                if (bodycontactIDs != null)
                {
                    body["ContactIDs"] = SourceExpressionConverter.ConvertToken(bodycontactIDs);
                    bodypropCount++;
                }

                if (bodysendDate != null)
                {
                    body["SendDate"] = SourceExpressionConverter.ConvertToken(bodysendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendEmailCampaignResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendTransactionalEmailUsingTriggeredCampagin([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodycampaignID, [WorkflowExpression] Func<string[]> bodytoAddresses, [WorkflowExpression] Func<bodypersonalizationValuesInputItem[]> bodypersonalizationValues = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodycampaignID, nameof(bodycampaignID), required: true);
            SourceExpression.Validate(bodytoAddresses, nameof(bodytoAddresses), required: true);
            SourceExpression.Validate(bodypersonalizationValues, nameof(bodypersonalizationValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/email/triggered-campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CampaignID"] = SourceExpressionConverter.ConvertToken(bodycampaignID);
                if (bodypersonalizationValues != null)
                {
                    body["PersonalizationValues"] = SourceExpressionConverter.ConvertToken(bodypersonalizationValues);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToAddresses"] = SourceExpressionConverter.ConvertToken(bodytoAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse> CreateProgramEnrolment([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<int> bodyprogramID, [WorkflowExpression] Func<int[]> bodyaddressBooks = null, [WorkflowExpression] Func<int[]> bodycontacts = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodyprogramID, nameof(bodyprogramID), required: true);
            SourceExpression.Validate(bodyaddressBooks, nameof(bodyaddressBooks), required: false);
            SourceExpression.Validate(bodycontacts, nameof(bodycontacts), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/programs/enrolments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressBooks != null)
                {
                    body["AddressBooks"] = SourceExpressionConverter.ConvertToken(bodyaddressBooks);
                    bodypropCount++;
                }

                if (bodycontacts != null)
                {
                    body["Contacts"] = SourceExpressionConverter.ConvertToken(bodycontacts);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProgramID"] = SourceExpressionConverter.ConvertToken(bodyprogramID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProgramEnrolmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction SendSmsMessage([WorkflowExpression] Func<string> telephoneNumber, [WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> bodymessage)
        {
            SourceExpression.Validate(telephoneNumber, nameof(telephoneNumber), required: true);
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/sms-messages/send-to/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(telephoneNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction BulkContactsImport([WorkflowExpression] Func<string> addressBook, [WorkflowExpression] Func<object> filedata)
        {
            SourceExpression.Validate(addressBook, nameof(addressBook), required: true);
            SourceExpression.Validate(filedata, nameof(filedata), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/address-books/{0}/contacts/import", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(addressBook, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportStatus([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction GetContactsImportReport([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contacts/import/{0}/report", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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