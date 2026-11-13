//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Politemail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolitemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ContactsGetContactsFromListResponse, ApiConnectionActionConfiguration> ContactsGetContactsFromList(Expression<Func<int>> id, Expression<Func<string>> expand = null, Expression<Func<string>> select = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ContactsGetContactsFromListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/Lists({0})/Contacts", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ContactsGetContactsFromListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ContactsNewContactResponse, ApiConnectionActionConfiguration> ContactsNewContact(Expression<Func<ContactsNewContactParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<ContactsNewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/Contacts/NewContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ContactsNewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ImagesNewImageResponse, ApiConnectionActionConfiguration> ImagesNewImage(Expression<Func<ImagesNewImageParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<ImagesNewImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/Images/NewImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ImagesNewImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ListsAddEmailsByIdResponse, ApiConnectionActionConfiguration> ListsAddEmailsById(Expression<Func<int>> id, Expression<Func<ListsAddEmailsByIdParametersInput>> parameters = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<ListsAddEmailsByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/Lists({0})/AddEmails", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parameters != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ListsAddEmailsByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ListsRemoveEmailsByIdResponse, ApiConnectionActionConfiguration> ListsRemoveEmailsById(Expression<Func<int>> id, Expression<Func<ListsAddEmailsByIdParametersInput>> parameters = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<ListsRemoveEmailsByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/odata/Lists({0})/RemoveEmails", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parameters != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ListsRemoveEmailsByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<ListsNewListResponse, ApiConnectionActionConfiguration> ListsNewList(Expression<Func<CampaignsNewCampaignParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<ListsNewListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/Lists/NewList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ListsNewListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<TemplatesNewTemplateResponse, ApiConnectionActionConfiguration> TemplatesNewTemplate(Expression<Func<TemplatesNewTemplateParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<TemplatesNewTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/Templates/NewTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<TemplatesNewTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<SentMessagesSendResponse, ApiConnectionActionConfiguration> SentMessagesSend(Expression<Func<SentMessagesSendParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<SentMessagesSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/SentMessages/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<SentMessagesSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<SmartAttachmentsNewAttachmentResponse, ApiConnectionActionConfiguration> SmartAttachmentsNewAttachment(Expression<Func<ImagesNewImageParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<SmartAttachmentsNewAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/SmartAttachments/NewAttachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<SmartAttachmentsNewAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "politemail")]
        public IBodyWorkflowAction<CampaignsNewCampaignResponse, ApiConnectionActionConfiguration> CampaignsNewCampaign(Expression<Func<CampaignsNewCampaignParametersInput>> parameters)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<CampaignsNewCampaignResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/odata/Campaigns/NewCampaign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<CampaignsNewCampaignResponse>(callPayload);
            });
        }
    }

    public class PolitemailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewContactResponse, ApiConnectionPollingTriggerConfiguration> OnNewContact()
        {
            return new DeferredBodyTrigger<OnNewContactResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/odata/Contacts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<OnNewContactResponse>(callPayload);
            });
        }
    }

    public class ContactsGetContactsFromListResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public Contact[] Value { get; set; }
    }

    public class Contact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("ownerID")]
        public int OwnerId { get; set; }

        [JsonProperty("categoryID")]
        public int CategoryId { get; set; }

        [JsonProperty("stageID")]
        public int StageId { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("webAddress")]
        public string WebAddress { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fileAs")]
        public string FileAs { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public string Custom17 { get; set; }

        [JsonProperty("custom18")]
        public string Custom18 { get; set; }

        [JsonProperty("custom19")]
        public string Custom19 { get; set; }

        [JsonProperty("custom20")]
        public string Custom20 { get; set; }

        [JsonProperty("businessID")]
        public int BusinessId { get; set; }

        [JsonProperty("regionID")]
        public int RegionId { get; set; }

        [JsonProperty("lastChangedDate")]
        public string LastChangedDate { get; set; }

        [JsonProperty("listID")]
        public int ListId { get; set; }
    }

    public class ContactsNewContactResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ContactsNewContactParametersInput
    {
        public ContactsNewContactParametersInput(string email)
        {
            this.Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("OwnerID")]
        public int? SelectOwner { get; set; }
        public bool? Shared { get; set; }

        [JsonProperty("BusinessID")]
        public int? SelectBusiness { get; set; }

        [JsonProperty("RegionID")]
        public int? SelectRegion { get; set; }
    }

    public class ImagesNewImageResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ImagesNewImageParametersInput
    {
        public ImagesNewImageParametersInput(string name, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent data)
        {
            this.Name = name;
            this.Data = data;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string ContentType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Data { get; set; }

        [JsonProperty("OwnerID")]
        public int? SelectOwner { get; set; }
        public bool? Shared { get; set; }
        public int? Privacy { get; set; }

        [JsonProperty("BusinessID")]
        public int? SelectBusiness { get; set; }

        [JsonProperty("RegionID")]
        public int? SelectRegion { get; set; }
    }

    public class ListsAddEmailsByIdResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class ListsAddEmailsByIdParametersInput
    {
        [JsonProperty("emails")]
        public string[] Emails { get; set; }
    }

    public class ListsRemoveEmailsByIdResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class ListsNewListResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class CampaignsNewCampaignParametersInput
    {
        public CampaignsNewCampaignParametersInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty("OwnerID")]
        public int? SelectOwner { get; set; }
        public bool? Shared { get; set; }

        [JsonProperty("BusinessID")]
        public int? SelectBusiness { get; set; }

        [JsonProperty("RegionID")]
        public int? SelectRegion { get; set; }
    }

    public class TemplatesNewTemplateResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class TemplatesNewTemplateParametersInput
    {
        public TemplatesNewTemplateParametersInput(string name, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.Name = name;
            this.File = @file;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        [JsonProperty("BodyBinary", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }
        public string Body { get; set; }

        [JsonProperty("OwnerID")]
        public int? SelectOwner { get; set; }
        public bool? Shared { get; set; }

        [JsonProperty("BusinessID")]
        public int? SelectBusiness { get; set; }

        [JsonProperty("RegionID")]
        public int? SelectRegion { get; set; }
    }

    public class SentMessagesSendResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class SentMessagesSendParametersInput
    {
        public SentMessagesSendParametersInput(string to, string subject, string body, string fromSendAs)
        {
            this.To = to;
            this.Subject = subject;
            this.Body = body;
            this.FromSendAs = fromSendAs;
        }

        [JsonProperty("Campaign")]
        public int? SelectCampaign { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("From", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromSendAs { get; set; }
        public string CC { get; set; }

        [JsonProperty("BCC")]
        public string Bcc { get; set; }
        public int? Importance { get; set; }
        public string Sensitivity { get; set; }

        [JsonProperty("IsHTML")]
        public bool? IsHtml { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParametersInputSendModeType? SendMode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Politemail.ParametersInputSendModeType._2;
        public string SendLater { get; set; }
    }

    public enum ParametersInputSendModeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class SmartAttachmentsNewAttachmentResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class CampaignsNewCampaignResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class OnNewContactResponse
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }

        [JsonProperty("value")]
        public Contact[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Politemail;

    public partial class WorkflowManagedActions
    {
        public PolitemailActions Politemail(string connectionId) => new PolitemailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PolitemailTriggers Politemail(string connectionId) => new PolitemailTriggers(connectionId);
    }
}