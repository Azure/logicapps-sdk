//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailjetip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailjetipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<SendEmailv31Response, ApiConnectionActionConfiguration> SendEmailv31(Expression<Func<SendEmailv31Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEmailv31Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.1/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEmailv31Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<SendEmailv3Response, ApiConnectionActionConfiguration> SendEmailv3(Expression<Func<SendEmailv3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEmailv3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEmailv3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesResponse, ApiConnectionActionConfiguration> GetMessages(Expression<Func<int>> contact = null, Expression<Func<int>> customId = null, Expression<Func<int>> destination = null, Expression<Func<string>> fromTS = null, Expression<Func<int>> limit = null, Expression<Func<fromTypeInput>> fromType = null)
        {
            var __workflow_contact = WorkflowExpression.Compile(contact, nameof(contact), required: false);
            var __workflow_customId = WorkflowExpression.Compile(customId, nameof(customId), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_fromTS = WorkflowExpression.Compile(fromTS, nameof(fromTS), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_fromType = WorkflowExpression.Compile(fromType, nameof(fromType), required: false);
            return new DeferredBodyAction<GetMessagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/message";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contact != null)
                    callPayload.Queries["Contact"] = ExpressionConverter.Convert(__workflow_contact);
                if (__workflow_customId != null)
                    callPayload.Queries["CustomID"] = ExpressionConverter.Convert(__workflow_customId);
                if (__workflow_destination != null)
                    callPayload.Queries["Destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_fromTS != null)
                    callPayload.Queries["FromTS"] = ExpressionConverter.Convert(__workflow_fromTS);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_fromType != null)
                    callPayload.Queries["FromType"] = ExpressionConverter.Convert(__workflow_fromType);
                return new ApiConnectionAction<GetMessagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesInformationResponse, ApiConnectionActionConfiguration> GetMessagesInformation(Expression<Func<int>> campaignId = null, Expression<Func<int>> contactsList = null, Expression<Func<int>> customCampaign = null, Expression<Func<string>> from = null, Expression<Func<string>> fromDomain = null, Expression<Func<int>> fromId = null, Expression<Func<string>> fromTS = null)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: false);
            var __workflow_contactsList = WorkflowExpression.Compile(contactsList, nameof(contactsList), required: false);
            var __workflow_customCampaign = WorkflowExpression.Compile(customCampaign, nameof(customCampaign), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_fromDomain = WorkflowExpression.Compile(fromDomain, nameof(fromDomain), required: false);
            var __workflow_fromId = WorkflowExpression.Compile(fromId, nameof(fromId), required: false);
            var __workflow_fromTS = WorkflowExpression.Compile(fromTS, nameof(fromTS), required: false);
            return new DeferredBodyAction<GetMessagesInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/messageinformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_campaignId != null)
                    callPayload.Queries["CampaignID"] = ExpressionConverter.Convert(__workflow_campaignId);
                if (__workflow_contactsList != null)
                    callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(__workflow_contactsList);
                if (__workflow_customCampaign != null)
                    callPayload.Queries["CustomCampaign"] = ExpressionConverter.Convert(__workflow_customCampaign);
                if (__workflow_from != null)
                    callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_fromDomain != null)
                    callPayload.Queries["FromDomain"] = ExpressionConverter.Convert(__workflow_fromDomain);
                if (__workflow_fromId != null)
                    callPayload.Queries["FromID"] = ExpressionConverter.Convert(__workflow_fromId);
                if (__workflow_fromTS != null)
                    callPayload.Queries["FromTS"] = ExpressionConverter.Convert(__workflow_fromTS);
                return new ApiConnectionAction<GetMessagesInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsResponse, ApiConnectionActionConfiguration> GetContacts(Expression<Func<int>> campaign = null, Expression<Func<int>> contactsList = null, Expression<Func<bool>> isExcludedFromCampaigns = null, Expression<Func<int>> limit = null)
        {
            var __workflow_campaign = WorkflowExpression.Compile(campaign, nameof(campaign), required: false);
            var __workflow_contactsList = WorkflowExpression.Compile(contactsList, nameof(contactsList), required: false);
            var __workflow_isExcludedFromCampaigns = WorkflowExpression.Compile(isExcludedFromCampaigns, nameof(isExcludedFromCampaigns), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_campaign != null)
                    callPayload.Queries["Campaign"] = ExpressionConverter.Convert(__workflow_campaign);
                if (__workflow_contactsList != null)
                    callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(__workflow_contactsList);
                if (__workflow_isExcludedFromCampaigns != null)
                    callPayload.Queries["IsExcludedFromCampaigns"] = ExpressionConverter.Convert(__workflow_isExcludedFromCampaigns);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactByIdResponse, ApiConnectionActionConfiguration> GetContactById(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<GetContactByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactResponse, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> contactId, Expression<Func<UpdateContactInput>> body)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListsResponse, ApiConnectionActionConfiguration> GetContactLists(Expression<Func<string>> address = null, Expression<Func<int>> excludeId = null, Expression<Func<bool>> isDeleted = null, Expression<Func<string>> name = null, Expression<Func<int>> limit = null, Expression<Func<int>> offSet = null, Expression<Func<bool>> countOnly = null, Expression<Func<string>> sort = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_excludeId = WorkflowExpression.Compile(excludeId, nameof(excludeId), required: false);
            var __workflow_isDeleted = WorkflowExpression.Compile(isDeleted, nameof(isDeleted), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offSet = WorkflowExpression.Compile(offSet, nameof(offSet), required: false);
            var __workflow_countOnly = WorkflowExpression.Compile(countOnly, nameof(countOnly), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetContactListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contactslist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_address != null)
                    callPayload.Queries["Address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_excludeId != null)
                    callPayload.Queries["ExcludeID"] = ExpressionConverter.Convert(__workflow_excludeId);
                if (__workflow_isDeleted != null)
                    callPayload.Queries["IsDeleted"] = ExpressionConverter.Convert(__workflow_isDeleted);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offSet != null)
                    callPayload.Queries["OffSet"] = ExpressionConverter.Convert(__workflow_offSet);
                if (__workflow_countOnly != null)
                    callPayload.Queries["countOnly"] = ExpressionConverter.Convert(__workflow_countOnly);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetContactListsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactListResponse, ApiConnectionActionConfiguration> CreateContactList(Expression<Func<CreateContactListInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contactslist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListByIdResponse, ApiConnectionActionConfiguration> GetContactListById(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<GetContactListByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contactslist/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactListByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteContactList(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contactslist/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactListResponse, ApiConnectionActionConfiguration> UpdateContactList(Expression<Func<string>> listId, Expression<Func<UpdateContactListInput>> body)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateContactListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contactslist/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateContactListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignsDraftResponse, ApiConnectionActionConfiguration> GetCampaignsDraft()
        {
            return new DeferredBodyAction<GetCampaignsDraftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/campaigndraft";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCampaignsDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateCampaignDraftResponse, ApiConnectionActionConfiguration> CreateCampaignDraft(Expression<Func<CreateCampaignDraftInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCampaignDraftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/campaigndraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCampaignDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignDraftByIdResponse, ApiConnectionActionConfiguration> GetCampaignDraftById(Expression<Func<int>> draftId)
        {
            var __workflow_draftId = WorkflowExpression.Compile(draftId, nameof(draftId), required: true);
            return new DeferredBodyAction<GetCampaignDraftByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/campaigndraft/{0}", __workflow_draftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCampaignDraftByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateCampaignDraftResponse, ApiConnectionActionConfiguration> UpdateCampaignDraft(Expression<Func<int>> draftId, Expression<Func<UpdateCampaignDraftInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_draftId = WorkflowExpression.Compile(draftId, nameof(draftId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<UpdateCampaignDraftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/campaigndraft/{0}", __workflow_draftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateCampaignDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignOverviewResponse, ApiConnectionActionConfiguration> GetCampaignOverview()
        {
            return new DeferredBodyAction<GetCampaignOverviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/campaignoverview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCampaignOverviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsStatisticsResponse, ApiConnectionActionConfiguration> GetContactsStatistics()
        {
            return new DeferredBodyAction<GetContactsStatisticsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contactstatistics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactsStatisticsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsDataResponse, ApiConnectionActionConfiguration> GetContactsData(Expression<Func<int>> campaign = null, Expression<Func<string>> contactEmail = null, Expression<Func<int>> contactsList = null, Expression<Func<string>> fields = null, Expression<Func<string>> lastActivityAt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offSet = null, Expression<Func<bool>> countOnly = null, Expression<Func<string>> sort = null)
        {
            var __workflow_campaign = WorkflowExpression.Compile(campaign, nameof(campaign), required: false);
            var __workflow_contactEmail = WorkflowExpression.Compile(contactEmail, nameof(contactEmail), required: false);
            var __workflow_contactsList = WorkflowExpression.Compile(contactsList, nameof(contactsList), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_lastActivityAt = WorkflowExpression.Compile(lastActivityAt, nameof(lastActivityAt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offSet = WorkflowExpression.Compile(offSet, nameof(offSet), required: false);
            var __workflow_countOnly = WorkflowExpression.Compile(countOnly, nameof(countOnly), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetContactsDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/REST/contactdata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_campaign != null)
                    callPayload.Queries["Campaign"] = ExpressionConverter.Convert(__workflow_campaign);
                if (__workflow_contactEmail != null)
                    callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(__workflow_contactEmail);
                if (__workflow_contactsList != null)
                    callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(__workflow_contactsList);
                if (__workflow_fields != null)
                    callPayload.Queries["Fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_lastActivityAt != null)
                    callPayload.Queries["LastActivityAt"] = ExpressionConverter.Convert(__workflow_lastActivityAt);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offSet != null)
                    callPayload.Queries["OffSet"] = ExpressionConverter.Convert(__workflow_offSet);
                if (__workflow_countOnly != null)
                    callPayload.Queries["countOnly"] = ExpressionConverter.Convert(__workflow_countOnly);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetContactsDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactDataByIdResponse, ApiConnectionActionConfiguration> GetContactDataById(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<GetContactDataByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/REST/contactdata/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactDataByIdResponse>(callPayload);
            });
        }
    }

    public class MailjetipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendEmailv31Response
    {
        public SendEmailv31ResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItem
    {
        public string Status { get; set; }
        public SendEmailv31ResponseMessagesTypeItemErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("CustomID")]
        public string CustomId { get; set; }
        public SendEmailv31ResponseMessagesTypeItemToTypeItem[] To { get; set; }
        public SendEmailv31ResponseMessagesTypeItemCcTypeItem[] Cc { get; set; }
        public SendEmailv31ResponseMessagesTypeItemBccTypeItem[] Bcc { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemErrorsTypeItem
    {
        public string ErrorIdentifier { get; set; }
        public string ErrorCode { get; set; }
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorRelatedTo { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemToTypeItem
    {
        public string Email { get; set; }
        public string MessageUUID { get; set; }

        [JsonProperty("MessageID")]
        public int MessageId { get; set; }
        public string MessageHref { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemCcTypeItem
    {
        public string Email { get; set; }
        public string MessageUUID { get; set; }

        [JsonProperty("MessageID")]
        public int MessageId { get; set; }
        public string MessageHref { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemBccTypeItem
    {
        public string Email { get; set; }
        public string MessageUUID { get; set; }

        [JsonProperty("MessageID")]
        public int MessageId { get; set; }
        public string MessageHref { get; set; }
    }

    public class SendEmailv31Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailv31InputMessagesTypeItem[] Messages { get; set; }
        public bool? SandboxMode { get; set; }
        public bool? AdvanceErrorHandling { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailv31InputMessagesTypeItemFromType From { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailv31InputMessagesTypeItemToTypeItem[] To { get; set; }
        public SendEmailv31InputMessagesTypeItemSenderType Sender { get; set; }
        public SendEmailv31InputMessagesTypeItemReplyToType ReplyTo { get; set; }
        public SendEmailv31InputMessagesTypeItemCcTypeItem[] Cc { get; set; }
        public SendEmailv31InputMessagesTypeItemBccTypeItem[] Bcc { get; set; }
        public string Subject { get; set; }
        public string TextPart { get; set; }
        public string HTMLPart { get; set; }

        [JsonProperty("TemplateID")]
        public int? TemplateId { get; set; }
        public Attachmentv31[] Attachments { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemFromType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemToTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemSenderType
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemReplyToType
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemCcTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class SendEmailv31InputMessagesTypeItemBccTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class Attachmentv31
    {
        public string Filename { get; set; }

        [JsonProperty("Content-type")]
        public string ContentType { get; set; }

        [JsonProperty("Base64Content")]
        public string Content { get; set; }
    }

    public class SendEmailv3Response
    {
        public SendEmailv3ResponseSentTypeItem[] Sent { get; set; }
    }

    public class SendEmailv3ResponseSentTypeItem
    {
        public string Email { get; set; }

        [JsonProperty("MessageID")]
        public int MessageId { get; set; }
        public string MessageUUID { get; set; }
    }

    public class SendEmailv3Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailv3InputMessagesTypeItem[] Messages { get; set; }
    }

    public class SendEmailv3InputMessagesTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public bool? Sender { get; set; }
        public SendEmailv3InputMessagesTypeItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }

        [JsonProperty("Text-part")]
        public string TextPart { get; set; }

        [JsonProperty("Html-part")]
        public string HtmlPart { get; set; }
        public Attachment[] Attachments { get; set; }

        [JsonProperty("Inline_attachments")]
        public SendEmailv3InputMessagesTypeItemInlineAttachmentsTypeItem[] InlineAttachments { get; set; }
    }

    public class SendEmailv3InputMessagesTypeItemRecipientsTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class Attachment
    {
        public string Filename { get; set; }

        [JsonProperty("Content-type")]
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class SendEmailv3InputMessagesTypeItemInlineAttachmentsTypeItem
    {
        public string Filename { get; set; }

        [JsonProperty("Content-type")]
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class GetMessagesResponse
    {
        public int Count { get; set; }
        public MessageResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class MessageResponse
    {
        public string ArrivedAt { get; set; }
        public int AttachmentCount { get; set; }
        public int AttemptCount { get; set; }

        [JsonProperty("CampaignID")]
        public int CampaignId { get; set; }
        public string ContactAlt { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public double Delay { get; set; }

        [JsonProperty("DestinationID")]
        public int DestinationId { get; set; }
        public int FilterTime { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public bool IsClickTracked { get; set; }
        public bool IsHTMLPartIncluded { get; set; }
        public bool IsOpenTracked { get; set; }
        public bool IsTextPartIncluded { get; set; }
        public bool IsUnsubTracked { get; set; }
        public int MessageSize { get; set; }

        [JsonProperty("SenderID")]
        public int SenderId { get; set; }
        public double SpamassassinScore { get; set; }
        public string SpamassRules { get; set; }

        [JsonProperty("StateID")]
        public int StateId { get; set; }
        public bool StatePermanent { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string UUID { get; set; }
    }

    public enum fromTypeInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class GetMessagesInformationResponse
    {
        public int Count { get; set; }
        public MessageInformationResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class MessageInformationResponse
    {
        [JsonProperty("CampaignID")]
        public int CampaignId { get; set; }
        public int ClickTrackedCount { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string CreatedAt { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public int MessageSize { get; set; }
        public int OpenTrackedCount { get; set; }
        public int QueuedCount { get; set; }
        public string SendEndAt { get; set; }
        public int SentCount { get; set; }
        public JToken SpamAssassinRules { get; set; }
        public double SpamAssassinScore { get; set; }
    }

    public class GetContactsResponse
    {
        public int Count { get; set; }
        public ContactResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class ContactResponse
    {
        public bool IsExcludedFromCampaigns { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public int DeliveredCount { get; set; }
        public string Email { get; set; }
        public string ExclusionFromCampaignsUpdatedAt { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public bool IsOptInPending { get; set; }
        public bool IsSpamComplaining { get; set; }
        public string LastActivityAt { get; set; }
        public string LastUpdateAt { get; set; }
    }

    public class CreateContactResponse
    {
        public int Count { get; set; }
        public ContactResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class CreateContactInput
    {
        public string IsExcludedFromCampaigns { get; set; }
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class GetContactByIdResponse
    {
        public int Count { get; set; }
        public ContactResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateContactResponse
    {
        public int Count { get; set; }
        public ContactResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateContactInput
    {
        public bool? IsExcludedFromCampaigns { get; set; }
        public string Name { get; set; }
    }

    public class GetContactListsResponse
    {
        public int Count { get; set; }
        public ContactsListResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class ContactsListResponse
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CreatedAt { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public int SubscriberCount { get; set; }
    }

    public class CreateContactListResponse
    {
        public int Count { get; set; }
        public ContactsListResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class CreateContactListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class GetContactListByIdResponse
    {
        public int Count { get; set; }
        public ContactsListResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateContactListResponse
    {
        public int Count { get; set; }
        public ContactsListResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateContactListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public class GetCampaignsDraftResponse
    {
        public int Count { get; set; }
        public CampaignDraftResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class CampaignDraftResponse
    {
        public int AXFraction { get; set; }
        public string AXFractionName { get; set; }
        public string AXTesting { get; set; }
        public int Current { get; set; }
        public string EditMode { get; set; }
        public bool IsStarred { get; set; }
        public bool IsTextPartIncluded { get; set; }
        public string ReplyEmail { get; set; }
        public string SenderName { get; set; }

        [JsonProperty("TemplateID")]
        public int TemplateId { get; set; }
        public string Title { get; set; }

        [JsonProperty("CampaignID")]
        public int CampaignId { get; set; }

        [JsonProperty("ContactsListID")]
        public int ContactsListId { get; set; }
        public string CreatedAt { get; set; }
        public string DeliveredAt { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Locale { get; set; }
        public string ModifiedAt { get; set; }
        public string Preset { get; set; }

        [JsonProperty("SegmentationID")]
        public int SegmentationId { get; set; }
        public string Sender { get; set; }
        public string SenderEmail { get; set; }
        public int Status { get; set; }
        public string Subject { get; set; }
        public string Url { get; set; }
        public bool Used { get; set; }
    }

    public class CreateCampaignDraftResponse
    {
        public int Count { get; set; }
        public CampaignDraftResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class CreateCampaignDraftInput
    {
        public int? Current { get; set; }
        public CreateCampaignDraftInputEditModeType? EditMode { get; set; }
        public bool? IsStarred { get; set; }
        public bool? IsTextPartIncluded { get; set; }
        public string ReplyEmail { get; set; }
        public string SenderName { get; set; }

        [JsonProperty("TemplateID")]
        public int? TemplateId { get; set; }
        public string Title { get; set; }

        [JsonProperty("ContactsListID")]
        public string ContactsListId { get; set; }
        public string ContactsListAlt { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locale { get; set; }

        [JsonProperty("SegmentationID")]
        public int? SegmentationId { get; set; }
        public string SegmentationAlt { get; set; }
        public string Sender { get; set; }
        public string SenderEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCampaignDraftInputEditModeType
    {
        [EnumMember(Value = "tool2")]
        Tool2,
        [EnumMember(Value = "html2")]
        Html2,
        [EnumMember(Value = "mjml")]
        Mjml
    }

    public class GetCampaignDraftByIdResponse
    {
        public int Count { get; set; }
        public CampaignDraftResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateCampaignDraftResponse
    {
        public int Count { get; set; }
        public CampaignDraftResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class UpdateCampaignDraftInput
    {
        public int? Current { get; set; }
        public UpdateCampaignDraftInputEditModeType? EditMode { get; set; }
        public bool? IsStarred { get; set; }
        public bool? IsTextPartIncluded { get; set; }
        public string ReplyEmail { get; set; }
        public string SenderName { get; set; }

        [JsonProperty("TemplateID")]
        public int? TemplateId { get; set; }
        public string Title { get; set; }

        [JsonProperty("ContactsListID")]
        public string ContactsListId { get; set; }
        public string ContactsListAlt { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locale { get; set; }

        [JsonProperty("SegmentationID")]
        public int? SegmentationId { get; set; }
        public string SegmentationAlt { get; set; }
        public string Sender { get; set; }
        public string SenderEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCampaignDraftInputEditModeType
    {
        [EnumMember(Value = "tool2")]
        Tool2,
        [EnumMember(Value = "html2")]
        Html2,
        [EnumMember(Value = "mjml")]
        Mjml
    }

    public class GetCampaignOverviewResponse
    {
        public int Count { get; set; }
        public GetCampaignOverviewResponseDataTypeItem[] Data { get; set; }
        public int Total { get; set; }
    }

    public class GetCampaignOverviewResponseDataTypeItem
    {
        public int ClickedCount { get; set; }
        public int DeliveredCount { get; set; }
        public string EditMode { get; set; }
        public string EditType { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("IDType")]
        public string IdType { get; set; }
        public int OpenedCount { get; set; }
        public int ProcessedCount { get; set; }
        public int SendTimeStart { get; set; }
        public bool Starred { get; set; }
        public int Status { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
    }

    public class GetContactsStatisticsResponse
    {
        public int Count { get; set; }
        public GetContactsStatisticsResponseDataTypeItem[] Data { get; set; }
        public int Total { get; set; }
    }

    public class GetContactsStatisticsResponseDataTypeItem
    {
        public int BlockedCount { get; set; }
        public int BouncedCount { get; set; }
        public int ClickedCount { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public int DeferredCount { get; set; }
        public int DeliveredCount { get; set; }
        public int HardbouncedCount { get; set; }
        public string LastActivityAt { get; set; }
        public int MarketingContacts { get; set; }
        public int OpenedCount { get; set; }
        public int ProcessedCount { get; set; }
        public int QueuedCount { get; set; }
        public int SoftbouncedCount { get; set; }
        public int SpamComplaintCount { get; set; }
        public int UnsubscribedCount { get; set; }
        public int UserMarketingContacts { get; set; }
        public int WorkFlowExitedCount { get; set; }
    }

    public class GetContactsDataResponse
    {
        public int Count { get; set; }
        public ContactDataResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class ContactDataResponse
    {
        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public JToken[] Data { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string MethodCollection { get; set; }
    }

    public class GetContactDataByIdResponse
    {
        public int Count { get; set; }
        public ContactDataResponse[] Data { get; set; }
        public int Total { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailjetip;

    public partial class WorkflowManagedActions
    {
        public MailjetipActions Mailjetip(string connectionId) => new MailjetipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailjetipTriggers Mailjetip(string connectionId) => new MailjetipTriggers(connectionId);
    }
}