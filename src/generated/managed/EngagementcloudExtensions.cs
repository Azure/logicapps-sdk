//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Engagementcloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EngagementcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateAddressBookResponse, ApiConnectionActionConfiguration> CreateAddressBook(Expression<Func<regionInput>> region, Expression<Func<CreateAddressBookInput>> body)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAddressBookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/address-books";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAddressBookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> addressBook, Expression<Func<regionInput>> region, Expression<Func<CreateContactInput>> body)
        {
            var __workflow_addressBook = WorkflowExpression.Compile(addressBook, nameof(addressBook), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/address-books/{0}/contacts", __workflow_addressBook.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<SendEmailCampaignResponse, ApiConnectionActionConfiguration> SendEmailCampaign(Expression<Func<regionInput>> region, Expression<Func<SendEmailCampaignInput>> body)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEmailCampaignResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/campaigns/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEmailCampaignResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendTransactionalEmailUsingTriggeredCampagin(Expression<Func<regionInput>> region, Expression<Func<SendTransactionalEmailUsingTriggeredCampaginInput>> body)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/email/triggered-campaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IBodyWorkflowAction<CreateProgramEnrolmentResponse, ApiConnectionActionConfiguration> CreateProgramEnrolment(Expression<Func<regionInput>> region, Expression<Func<CreateProgramEnrolmentInput>> body)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProgramEnrolmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/programs/enrolments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProgramEnrolmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendSmsMessage(Expression<Func<string>> telephoneNumber, Expression<Func<regionInput>> region, Expression<Func<SendSmsMessageInput>> body)
        {
            var __workflow_telephoneNumber = WorkflowExpression.Compile(telephoneNumber, nameof(telephoneNumber), required: true);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/sms-messages/send-to/{0}", __workflow_telephoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContactsImportStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contacts/import/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "engagementcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContactsImportReport(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contacts/import/{0}/report", __workflow_id.WithUrlEncoding(1)));
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
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class CreateAddressBookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("visibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAddressBookInputVisibilityType? Visibility { get; set; } = CreateAddressBookInputVisibilityType.Private;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAddressBookInputVisibilityType
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

    public class CreateContactInput
    {
        [JsonProperty("dataFields")]
        public CreateContactInputDataFieldsTypeItem[] DataFields { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("emailType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputEmailTypeType? EmailType { get; set; } = CreateContactInputEmailTypeType.Html;

        [JsonProperty("optInType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputOptInTypeType? OptInType { get; set; } = CreateContactInputOptInTypeType.Unknown;
    }

    public class CreateContactInputDataFieldsTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputEmailTypeType
    {
        PlainText,
        Html
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputOptInTypeType
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

    public class SendEmailCampaignInput
    {
        public int[] AddressBookIDs { get; set; }

        [JsonProperty("CampaignID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CampaignId { get; set; }
        public int[] ContactIDs { get; set; }
        public string SendDate { get; set; }
    }

    public class SendTransactionalEmailUsingTriggeredCampaginInput
    {
        [JsonProperty("CampaignID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CampaignId { get; set; }
        public SendTransactionalEmailUsingTriggeredCampaginInputPersonalizationValuesTypeItem[] PersonalizationValues { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ToAddresses { get; set; }
    }

    public class SendTransactionalEmailUsingTriggeredCampaginInputPersonalizationValuesTypeItem
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

    public class CreateProgramEnrolmentInput
    {
        public int[] AddressBooks { get; set; }
        public int[] Contacts { get; set; }

        [JsonProperty("ProgramID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProgramId { get; set; }
    }

    public class SendSmsMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
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