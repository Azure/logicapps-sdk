//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailjetip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailjetipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<SendEmailv3Response> SendEmailv3(Expression<Func<bodyMessagesInputItem[]>> bodyMessages)
        {
            var apiCallPath = "/v3/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Messages"] = ExpressionConverter.ConvertO(bodyMessages);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendEmailv3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages(Expression<Func<int>> contact = null, Expression<Func<int>> customID = null, Expression<Func<int>> destination = null, Expression<Func<string>> fromTS = null, Expression<Func<int>> limit = null, Expression<Func<fromTypeInput>> fromType = null)
        {
            var apiCallPath = "/v3/REST/message";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contact != null)
                callPayload.Queries["Contact"] = ExpressionConverter.Convert(contact);
            if (customID != null)
                callPayload.Queries["CustomID"] = ExpressionConverter.Convert(customID);
            if (destination != null)
                callPayload.Queries["Destination"] = ExpressionConverter.Convert(destination);
            if (fromTS != null)
                callPayload.Queries["FromTS"] = ExpressionConverter.Convert(fromTS);
            callPayload.Queries["Limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["Limit"] = ExpressionConverter.Convert(limit);
            if (fromType != null)
                callPayload.Queries["FromType"] = ExpressionConverter.Convert(fromType);
            return new ApiConnectionAction<GetMessagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesInformationResponse> GetMessagesInformation(Expression<Func<int>> campaignID = null, Expression<Func<int>> contactsList = null, Expression<Func<int>> customCampaign = null, Expression<Func<string>> from = null, Expression<Func<string>> fromDomain = null, Expression<Func<int>> fromID = null, Expression<Func<string>> fromTS = null)
        {
            var apiCallPath = "/v3/REST/messageinformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (campaignID != null)
                callPayload.Queries["CampaignID"] = ExpressionConverter.Convert(campaignID);
            if (contactsList != null)
                callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(contactsList);
            if (customCampaign != null)
                callPayload.Queries["CustomCampaign"] = ExpressionConverter.Convert(customCampaign);
            if (from != null)
                callPayload.Queries["From"] = ExpressionConverter.Convert(from);
            if (fromDomain != null)
                callPayload.Queries["FromDomain"] = ExpressionConverter.Convert(fromDomain);
            if (fromID != null)
                callPayload.Queries["FromID"] = ExpressionConverter.Convert(fromID);
            if (fromTS != null)
                callPayload.Queries["FromTS"] = ExpressionConverter.Convert(fromTS);
            return new ApiConnectionAction<GetMessagesInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts(Expression<Func<int>> campaign = null, Expression<Func<int>> contactsList = null, Expression<Func<bool>> isExcludedFromCampaigns = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/v3/REST/contact";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (campaign != null)
                callPayload.Queries["Campaign"] = ExpressionConverter.Convert(campaign);
            if (contactsList != null)
                callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(contactsList);
            if (isExcludedFromCampaigns != null)
                callPayload.Queries["IsExcludedFromCampaigns"] = ExpressionConverter.Convert(isExcludedFromCampaigns);
            callPayload.Queries["Limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["Limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<GetContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodyEmail, Expression<Func<string>> bodyIsExcludedFromCampaigns = null, Expression<Func<string>> bodyName = null)
        {
            var apiCallPath = "/v3/REST/contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyIsExcludedFromCampaigns != null)
            {
                body["IsExcludedFromCampaigns"] = ExpressionConverter.ConvertO(bodyIsExcludedFromCampaigns);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactByIDResponse> GetContactByID(Expression<Func<string>> contactID)
        {
            var apiCallPath = String.Format("/v3/REST/contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact(Expression<Func<string>> contactID, Expression<Func<bool>> bodyIsExcludedFromCampaigns = null, Expression<Func<string>> bodyName = null)
        {
            var apiCallPath = String.Format("/v3/REST/contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyIsExcludedFromCampaigns != null)
            {
                body["IsExcludedFromCampaigns"] = ExpressionConverter.ConvertO(bodyIsExcludedFromCampaigns);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListsResponse> GetContactLists(Expression<Func<string>> address = null, Expression<Func<int>> excludeID = null, Expression<Func<bool>> isDeleted = null, Expression<Func<string>> name = null, Expression<Func<int>> limit = null, Expression<Func<int>> offSet = null, Expression<Func<bool>> countOnly = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/v3/REST/contactslist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (address != null)
                callPayload.Queries["Address"] = ExpressionConverter.Convert(address);
            if (excludeID != null)
                callPayload.Queries["ExcludeID"] = ExpressionConverter.Convert(excludeID);
            if (isDeleted != null)
                callPayload.Queries["IsDeleted"] = ExpressionConverter.Convert(isDeleted);
            if (name != null)
                callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["Limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["Limit"] = ExpressionConverter.Convert(limit);
            if (offSet != null)
                callPayload.Queries["OffSet"] = ExpressionConverter.Convert(offSet);
            if (countOnly != null)
                callPayload.Queries["countOnly"] = ExpressionConverter.Convert(countOnly);
            if (sort != null)
                callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetContactListsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactListResponse> CreateContactList(Expression<Func<string>> bodyName, Expression<Func<bool>> bodyIsDeleted = null)
        {
            var apiCallPath = "/v3/REST/contactslist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyName);
            if (bodyIsDeleted != null)
            {
                body["IsDeleted"] = ExpressionConverter.ConvertO(bodyIsDeleted);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateContactListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListByIDResponse> GetContactListByID(Expression<Func<string>> listID)
        {
            var apiCallPath = String.Format("/v3/REST/contactslist/{0}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactListByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IWorkflowAction DeleteContactList(Expression<Func<string>> listID)
        {
            var apiCallPath = String.Format("/v3/REST/contactslist/{0}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactListResponse> UpdateContactList(Expression<Func<string>> listID, Expression<Func<string>> bodyName, Expression<Func<bool>> bodyIsDeleted = null)
        {
            var apiCallPath = String.Format("/v3/REST/contactslist/{0}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyName);
            if (bodyIsDeleted != null)
            {
                body["IsDeleted"] = ExpressionConverter.ConvertO(bodyIsDeleted);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateContactListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignsDraftResponse> GetCampaignsDraft()
        {
            var apiCallPath = "/v3/REST/campaigndraft";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCampaignsDraftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateCampaignDraftResponse> CreateCampaignDraft(Expression<Func<string>> bodyLocale, Expression<Func<string>> bodySubject, Expression<Func<int>> bodyCurrent = null, Expression<Func<bodyEditModeInput>> bodyEditMode = null, Expression<Func<bool>> bodyIsStarred = null, Expression<Func<bool>> bodyIsTextPartIncluded = null, Expression<Func<string>> bodyReplyEmail = null, Expression<Func<string>> bodySenderName = null, Expression<Func<int>> bodyTemplateID = null, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyContactsListID = null, Expression<Func<string>> bodyContactsListAlt = null, Expression<Func<int>> bodySegmentationID = null, Expression<Func<string>> bodySegmentationAlt = null, Expression<Func<string>> bodySender = null, Expression<Func<string>> bodySenderEmail = null)
        {
            var apiCallPath = "/v3/REST/campaigndraft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCurrent != null)
            {
                body["Current"] = ExpressionConverter.ConvertO(bodyCurrent);
                bodypropCount++;
            }

            if (bodyEditMode != null)
            {
                body["EditMode"] = ExpressionConverter.ConvertO(bodyEditMode);
                bodypropCount++;
            }

            if (bodyIsStarred != null)
            {
                body["IsStarred"] = ExpressionConverter.ConvertO(bodyIsStarred);
                bodypropCount++;
            }

            if (bodyIsTextPartIncluded != null)
            {
                body["IsTextPartIncluded"] = ExpressionConverter.ConvertO(bodyIsTextPartIncluded);
                bodypropCount++;
            }

            if (bodyReplyEmail != null)
            {
                body["ReplyEmail"] = ExpressionConverter.ConvertO(bodyReplyEmail);
                bodypropCount++;
            }

            if (bodySenderName != null)
            {
                body["SenderName"] = ExpressionConverter.ConvertO(bodySenderName);
                bodypropCount++;
            }

            if (bodyTemplateID != null)
            {
                body["TemplateID"] = ExpressionConverter.ConvertO(bodyTemplateID);
                bodypropCount++;
            }

            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyContactsListID != null)
            {
                body["ContactsListID"] = ExpressionConverter.ConvertO(bodyContactsListID);
                bodypropCount++;
            }

            if (bodyContactsListAlt != null)
            {
                body["ContactsListAlt"] = ExpressionConverter.ConvertO(bodyContactsListAlt);
                bodypropCount++;
            }

            bodypropCount++;
            body["Locale"] = ExpressionConverter.ConvertO(bodyLocale);
            if (bodySegmentationID != null)
            {
                body["SegmentationID"] = ExpressionConverter.ConvertO(bodySegmentationID);
                bodypropCount++;
            }

            if (bodySegmentationAlt != null)
            {
                body["SegmentationAlt"] = ExpressionConverter.ConvertO(bodySegmentationAlt);
                bodypropCount++;
            }

            if (bodySender != null)
            {
                body["Sender"] = ExpressionConverter.ConvertO(bodySender);
                bodypropCount++;
            }

            if (bodySenderEmail != null)
            {
                body["SenderEmail"] = ExpressionConverter.ConvertO(bodySenderEmail);
                bodypropCount++;
            }

            bodypropCount++;
            body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCampaignDraftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignDraftByIDResponse> GetCampaignDraftByID(Expression<Func<int>> draftID)
        {
            var apiCallPath = String.Format("/v3/REST/campaigndraft/{0}", ExpressionConverter.ConvertWithUrlEncoding(draftID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCampaignDraftByIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateCampaignDraftResponse> UpdateCampaignDraft(Expression<Func<int>> draftID, Expression<Func<string>> bodyLocale, Expression<Func<string>> bodySubject, Expression<Func<string>> contentType = null, Expression<Func<int>> bodyCurrent = null, Expression<Func<bodyEditModeInput>> bodyEditMode = null, Expression<Func<bool>> bodyIsStarred = null, Expression<Func<bool>> bodyIsTextPartIncluded = null, Expression<Func<string>> bodyReplyEmail = null, Expression<Func<string>> bodySenderName = null, Expression<Func<int>> bodyTemplateID = null, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyContactsListID = null, Expression<Func<string>> bodyContactsListAlt = null, Expression<Func<int>> bodySegmentationID = null, Expression<Func<string>> bodySegmentationAlt = null, Expression<Func<string>> bodySender = null, Expression<Func<string>> bodySenderEmail = null)
        {
            var apiCallPath = String.Format("/v3/REST/campaigndraft/{0}", ExpressionConverter.ConvertWithUrlEncoding(draftID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCurrent != null)
            {
                body["Current"] = ExpressionConverter.ConvertO(bodyCurrent);
                bodypropCount++;
            }

            if (bodyEditMode != null)
            {
                body["EditMode"] = ExpressionConverter.ConvertO(bodyEditMode);
                bodypropCount++;
            }

            if (bodyIsStarred != null)
            {
                body["IsStarred"] = ExpressionConverter.ConvertO(bodyIsStarred);
                bodypropCount++;
            }

            if (bodyIsTextPartIncluded != null)
            {
                body["IsTextPartIncluded"] = ExpressionConverter.ConvertO(bodyIsTextPartIncluded);
                bodypropCount++;
            }

            if (bodyReplyEmail != null)
            {
                body["ReplyEmail"] = ExpressionConverter.ConvertO(bodyReplyEmail);
                bodypropCount++;
            }

            if (bodySenderName != null)
            {
                body["SenderName"] = ExpressionConverter.ConvertO(bodySenderName);
                bodypropCount++;
            }

            if (bodyTemplateID != null)
            {
                body["TemplateID"] = ExpressionConverter.ConvertO(bodyTemplateID);
                bodypropCount++;
            }

            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyContactsListID != null)
            {
                body["ContactsListID"] = ExpressionConverter.ConvertO(bodyContactsListID);
                bodypropCount++;
            }

            if (bodyContactsListAlt != null)
            {
                body["ContactsListAlt"] = ExpressionConverter.ConvertO(bodyContactsListAlt);
                bodypropCount++;
            }

            bodypropCount++;
            body["Locale"] = ExpressionConverter.ConvertO(bodyLocale);
            if (bodySegmentationID != null)
            {
                body["SegmentationID"] = ExpressionConverter.ConvertO(bodySegmentationID);
                bodypropCount++;
            }

            if (bodySegmentationAlt != null)
            {
                body["SegmentationAlt"] = ExpressionConverter.ConvertO(bodySegmentationAlt);
                bodypropCount++;
            }

            if (bodySender != null)
            {
                body["Sender"] = ExpressionConverter.ConvertO(bodySender);
                bodypropCount++;
            }

            if (bodySenderEmail != null)
            {
                body["SenderEmail"] = ExpressionConverter.ConvertO(bodySenderEmail);
                bodypropCount++;
            }

            bodypropCount++;
            body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateCampaignDraftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignOverviewResponse> GetCampaignOverview()
        {
            var apiCallPath = "/v3/REST/campaignoverview";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCampaignOverviewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsStatisticsResponse> GetContactsStatistics()
        {
            var apiCallPath = "/v3/REST/contactstatistics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactsStatisticsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsDataResponse> GetContactsData(Expression<Func<int>> campaign = null, Expression<Func<string>> contactEmail = null, Expression<Func<int>> contactsList = null, Expression<Func<string>> fields = null, Expression<Func<string>> lastActivityAt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offSet = null, Expression<Func<bool>> countOnly = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/v3/REST/contactdata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (campaign != null)
                callPayload.Queries["Campaign"] = ExpressionConverter.Convert(campaign);
            if (contactEmail != null)
                callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(contactEmail);
            if (contactsList != null)
                callPayload.Queries["ContactsList"] = ExpressionConverter.Convert(contactsList);
            if (fields != null)
                callPayload.Queries["Fields"] = ExpressionConverter.Convert(fields);
            if (lastActivityAt != null)
                callPayload.Queries["LastActivityAt"] = ExpressionConverter.Convert(lastActivityAt);
            callPayload.Queries["Limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["Limit"] = ExpressionConverter.Convert(limit);
            if (offSet != null)
                callPayload.Queries["OffSet"] = ExpressionConverter.Convert(offSet);
            if (countOnly != null)
                callPayload.Queries["countOnly"] = ExpressionConverter.Convert(countOnly);
            if (sort != null)
                callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetContactsDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactDataByIDResponse> GetContactDataByID(Expression<Func<int>> contactID)
        {
            var apiCallPath = String.Format("/v3/REST/contactdata/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactDataByIDResponse>(callPayload);
        }
    }

    public class MailjetipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendEmailv3Response
    {
        public SendEmailv3ResponseSentTypeItem[] Sent { get; set; }
    }

    public class SendEmailv3ResponseSentTypeItem
    {
        public string Email { get; set; }
        public int MessageID { get; set; }
        public string MessageUUID { get; set; }
    }

    public class bodyMessagesInputItem
    {
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public bool Sender { get; set; }
        public bodyMessagesInputItemRecipientsTypeItem[] Recipients { get; set; }
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
        public bodyMessagesInputItemInlineAttachmentsTypeItem[] InlineAttachments { get; set; }
    }

    public class bodyMessagesInputItemRecipientsTypeItem
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

    public class bodyMessagesInputItemInlineAttachmentsTypeItem
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
        public int CampaignID { get; set; }
        public string ContactAlt { get; set; }
        public int ContactID { get; set; }
        public double Delay { get; set; }
        public int DestinationID { get; set; }
        public int FilterTime { get; set; }
        public int ID { get; set; }
        public bool IsClickTracked { get; set; }
        public bool IsHTMLPartIncluded { get; set; }
        public bool IsOpenTracked { get; set; }
        public bool IsTextPartIncluded { get; set; }
        public bool IsUnsubTracked { get; set; }
        public int MessageSize { get; set; }
        public int SenderID { get; set; }
        public double SpamassassinScore { get; set; }
        public string SpamassRules { get; set; }
        public int StateID { get; set; }
        public bool StatePermanent { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string UUID { get; set; }
    }

    public enum fromTypeInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class GetMessagesInformationResponse
    {
        public int Count { get; set; }
        public MessageInformationResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class MessageInformationResponse
    {
        public int CampaignID { get; set; }
        public int ClickTrackedCount { get; set; }
        public int ContactID { get; set; }
        public string CreatedAt { get; set; }
        public int ID { get; set; }
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
        public int ID { get; set; }
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

    public class GetContactByIDResponse
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
        public int ID { get; set; }
        public int SubscriberCount { get; set; }
    }

    public class CreateContactListResponse
    {
        public int Count { get; set; }
        public ContactsListResponse[] Data { get; set; }
        public int Total { get; set; }
    }

    public class GetContactListByIDResponse
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
        public int TemplateID { get; set; }
        public string Title { get; set; }
        public int CampaignID { get; set; }
        public int ContactsListID { get; set; }
        public string CreatedAt { get; set; }
        public string DeliveredAt { get; set; }
        public int ID { get; set; }
        public string Locale { get; set; }
        public string ModifiedAt { get; set; }
        public string Preset { get; set; }
        public int SegmentationID { get; set; }
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

    public enum bodyEditModeInput
    {
        [EnumMember(Value = "tool2")]
        Tool2,
        [EnumMember(Value = "html2")]
        Html2,
        [EnumMember(Value = "mjml")]
        Mjml
    }

    public class GetCampaignDraftByIDResponse
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
        public int ID { get; set; }
        public string IDType { get; set; }
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
        public int ContactID { get; set; }
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
        public int ContactID { get; set; }
        public JToken[] Data { get; set; }
        public int ID { get; set; }
        public string MethodCollection { get; set; }
    }

    public class GetContactDataByIDResponse
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