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
        public IBodyWorkflowAction<SendEmailv31Response> SendEmailv31([WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<bool> bodysandboxMode = null, [WorkflowExpression] Func<bool> bodyadvanceErrorHandling = null)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodysandboxMode, nameof(bodysandboxMode), required: false);
            SourceExpression.Validate(bodyadvanceErrorHandling, nameof(bodyadvanceErrorHandling), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.1/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodysandboxMode != null)
                {
                    body["SandboxMode"] = SourceExpressionConverter.ConvertToken(bodysandboxMode);
                    bodypropCount++;
                }

                if (bodyadvanceErrorHandling != null)
                {
                    body["AdvanceErrorHandling"] = SourceExpressionConverter.ConvertToken(bodyadvanceErrorHandling);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendEmailv31Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<SendEmailv3Response> SendEmailv3([WorkflowExpression] Func<bodymessagesInputItem2[]> bodymessages)
        {
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendEmailv3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages([WorkflowExpression] Func<int> contact = null, [WorkflowExpression] Func<int> customId = null, [WorkflowExpression] Func<int> destination = null, [WorkflowExpression] Func<string> fromTS = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<fromTypeInput> fromType = null)
        {
            SourceExpression.Validate(contact, nameof(contact), required: false);
            SourceExpression.Validate(customId, nameof(customId), required: false);
            SourceExpression.Validate(destination, nameof(destination), required: false);
            SourceExpression.Validate(fromTS, nameof(fromTS), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(fromType, nameof(fromType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/message";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contact != null)
                    callPayload.Queries["Contact"] = SourceExpressionConverter.ConvertO(contact);
                if (customId != null)
                    callPayload.Queries["CustomID"] = SourceExpressionConverter.ConvertO(customId);
                if (destination != null)
                    callPayload.Queries["Destination"] = SourceExpressionConverter.ConvertO(destination);
                if (fromTS != null)
                    callPayload.Queries["FromTS"] = SourceExpressionConverter.ConvertO(fromTS);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["Limit"] = SourceExpressionConverter.ConvertO(limit);
                if (fromType != null)
                    callPayload.Queries["FromType"] = SourceExpressionConverter.Convert(fromType);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetMessagesInformationResponse> GetMessagesInformation([WorkflowExpression] Func<int> campaignId = null, [WorkflowExpression] Func<int> contactsList = null, [WorkflowExpression] Func<int> customCampaign = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> fromDomain = null, [WorkflowExpression] Func<int> fromId = null, [WorkflowExpression] Func<string> fromTS = null)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: false);
            SourceExpression.Validate(contactsList, nameof(contactsList), required: false);
            SourceExpression.Validate(customCampaign, nameof(customCampaign), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(fromDomain, nameof(fromDomain), required: false);
            SourceExpression.Validate(fromId, nameof(fromId), required: false);
            SourceExpression.Validate(fromTS, nameof(fromTS), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/messageinformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (campaignId != null)
                    callPayload.Queries["CampaignID"] = SourceExpressionConverter.ConvertO(campaignId);
                if (contactsList != null)
                    callPayload.Queries["ContactsList"] = SourceExpressionConverter.ConvertO(contactsList);
                if (customCampaign != null)
                    callPayload.Queries["CustomCampaign"] = SourceExpressionConverter.ConvertO(customCampaign);
                if (from != null)
                    callPayload.Queries["From"] = SourceExpressionConverter.ConvertO(from);
                if (fromDomain != null)
                    callPayload.Queries["FromDomain"] = SourceExpressionConverter.ConvertO(fromDomain);
                if (fromId != null)
                    callPayload.Queries["FromID"] = SourceExpressionConverter.ConvertO(fromId);
                if (fromTS != null)
                    callPayload.Queries["FromTS"] = SourceExpressionConverter.ConvertO(fromTS);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<int> campaign = null, [WorkflowExpression] Func<int> contactsList = null, [WorkflowExpression] Func<bool> isExcludedFromCampaigns = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(campaign, nameof(campaign), required: false);
            SourceExpression.Validate(contactsList, nameof(contactsList), required: false);
            SourceExpression.Validate(isExcludedFromCampaigns, nameof(isExcludedFromCampaigns), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (campaign != null)
                    callPayload.Queries["Campaign"] = SourceExpressionConverter.ConvertO(campaign);
                if (contactsList != null)
                    callPayload.Queries["ContactsList"] = SourceExpressionConverter.ConvertO(contactsList);
                if (isExcludedFromCampaigns != null)
                    callPayload.Queries["IsExcludedFromCampaigns"] = SourceExpressionConverter.ConvertO(isExcludedFromCampaigns);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["Limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyisExcludedFromCampaigns = null, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyisExcludedFromCampaigns, nameof(bodyisExcludedFromCampaigns), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisExcludedFromCampaigns != null)
                {
                    body["IsExcludedFromCampaigns"] = SourceExpressionConverter.ConvertToken(bodyisExcludedFromCampaigns);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactByIdResponse> GetContactById([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<bool> bodyisExcludedFromCampaigns = null, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodyisExcludedFromCampaigns, nameof(bodyisExcludedFromCampaigns), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisExcludedFromCampaigns != null)
                {
                    body["IsExcludedFromCampaigns"] = SourceExpressionConverter.ConvertToken(bodyisExcludedFromCampaigns);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListsResponse> GetContactLists([WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<int> excludeId = null, [WorkflowExpression] Func<bool> isDeleted = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offSet = null, [WorkflowExpression] Func<bool> countOnly = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(excludeId, nameof(excludeId), required: false);
            SourceExpression.Validate(isDeleted, nameof(isDeleted), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offSet, nameof(offSet), required: false);
            SourceExpression.Validate(countOnly, nameof(countOnly), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contactslist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (address != null)
                    callPayload.Queries["Address"] = SourceExpressionConverter.ConvertO(address);
                if (excludeId != null)
                    callPayload.Queries["ExcludeID"] = SourceExpressionConverter.ConvertO(excludeId);
                if (isDeleted != null)
                    callPayload.Queries["IsDeleted"] = SourceExpressionConverter.ConvertO(isDeleted);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["Limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offSet != null)
                    callPayload.Queries["OffSet"] = SourceExpressionConverter.ConvertO(offSet);
                if (countOnly != null)
                    callPayload.Queries["countOnly"] = SourceExpressionConverter.ConvertO(countOnly);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactListsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateContactListResponse> CreateContactList([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyisDeleted = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyisDeleted, nameof(bodyisDeleted), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contactslist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyisDeleted != null)
                {
                    body["IsDeleted"] = SourceExpressionConverter.ConvertToken(bodyisDeleted);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactListByIdResponse> GetContactListById([WorkflowExpression] Func<string> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contactslist/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactListByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IWorkflowAction DeleteContactList([WorkflowExpression] Func<string> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contactslist/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateContactListResponse> UpdateContactList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyisDeleted = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyisDeleted, nameof(bodyisDeleted), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contactslist/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyisDeleted != null)
                {
                    body["IsDeleted"] = SourceExpressionConverter.ConvertToken(bodyisDeleted);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateContactListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignsDraftResponse> GetCampaignsDraft()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/campaigndraft";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCampaignsDraftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<CreateCampaignDraftResponse> CreateCampaignDraft([WorkflowExpression] Func<string> bodylocale, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<int> bodycurrent = null, [WorkflowExpression] Func<bodyeditModeInput> bodyeditMode = null, [WorkflowExpression] Func<bool> bodyisStarred = null, [WorkflowExpression] Func<bool> bodyisTextPartIncluded = null, [WorkflowExpression] Func<string> bodyreplyEmail = null, [WorkflowExpression] Func<string> bodysenderName = null, [WorkflowExpression] Func<int> bodytemplateId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontactsListId = null, [WorkflowExpression] Func<string> bodycontactsListAlt = null, [WorkflowExpression] Func<int> bodysegmentationId = null, [WorkflowExpression] Func<string> bodysegmentationAlt = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<string> bodysenderEmail = null)
        {
            SourceExpression.Validate(bodylocale, nameof(bodylocale), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodycurrent, nameof(bodycurrent), required: false);
            SourceExpression.Validate(bodyeditMode, nameof(bodyeditMode), required: false);
            SourceExpression.Validate(bodyisStarred, nameof(bodyisStarred), required: false);
            SourceExpression.Validate(bodyisTextPartIncluded, nameof(bodyisTextPartIncluded), required: false);
            SourceExpression.Validate(bodyreplyEmail, nameof(bodyreplyEmail), required: false);
            SourceExpression.Validate(bodysenderName, nameof(bodysenderName), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycontactsListId, nameof(bodycontactsListId), required: false);
            SourceExpression.Validate(bodycontactsListAlt, nameof(bodycontactsListAlt), required: false);
            SourceExpression.Validate(bodysegmentationId, nameof(bodysegmentationId), required: false);
            SourceExpression.Validate(bodysegmentationAlt, nameof(bodysegmentationAlt), required: false);
            SourceExpression.Validate(bodysender, nameof(bodysender), required: false);
            SourceExpression.Validate(bodysenderEmail, nameof(bodysenderEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/campaigndraft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycurrent != null)
                {
                    body["Current"] = SourceExpressionConverter.ConvertToken(bodycurrent);
                    bodypropCount++;
                }

                if (bodyeditMode != null)
                {
                    body["EditMode"] = SourceExpressionConverter.Convert(bodyeditMode);
                    bodypropCount++;
                }

                if (bodyisStarred != null)
                {
                    body["IsStarred"] = SourceExpressionConverter.ConvertToken(bodyisStarred);
                    bodypropCount++;
                }

                if (bodyisTextPartIncluded != null)
                {
                    body["IsTextPartIncluded"] = SourceExpressionConverter.ConvertToken(bodyisTextPartIncluded);
                    bodypropCount++;
                }

                if (bodyreplyEmail != null)
                {
                    body["ReplyEmail"] = SourceExpressionConverter.ConvertToken(bodyreplyEmail);
                    bodypropCount++;
                }

                if (bodysenderName != null)
                {
                    body["SenderName"] = SourceExpressionConverter.ConvertToken(bodysenderName);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["TemplateID"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontactsListId != null)
                {
                    body["ContactsListID"] = SourceExpressionConverter.ConvertToken(bodycontactsListId);
                    bodypropCount++;
                }

                if (bodycontactsListAlt != null)
                {
                    body["ContactsListAlt"] = SourceExpressionConverter.ConvertToken(bodycontactsListAlt);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Locale"] = SourceExpressionConverter.ConvertToken(bodylocale);
                if (bodysegmentationId != null)
                {
                    body["SegmentationID"] = SourceExpressionConverter.ConvertToken(bodysegmentationId);
                    bodypropCount++;
                }

                if (bodysegmentationAlt != null)
                {
                    body["SegmentationAlt"] = SourceExpressionConverter.ConvertToken(bodysegmentationAlt);
                    bodypropCount++;
                }

                if (bodysender != null)
                {
                    body["Sender"] = SourceExpressionConverter.ConvertToken(bodysender);
                    bodypropCount++;
                }

                if (bodysenderEmail != null)
                {
                    body["SenderEmail"] = SourceExpressionConverter.ConvertToken(bodysenderEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCampaignDraftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignDraftByIdResponse> GetCampaignDraftById([WorkflowExpression] Func<int> draftId)
        {
            SourceExpression.Validate(draftId, nameof(draftId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/campaigndraft/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(draftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCampaignDraftByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<UpdateCampaignDraftResponse> UpdateCampaignDraft([WorkflowExpression] Func<int> draftId, [WorkflowExpression] Func<string> bodylocale, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<int> bodycurrent = null, [WorkflowExpression] Func<bodyeditModeInput> bodyeditMode = null, [WorkflowExpression] Func<bool> bodyisStarred = null, [WorkflowExpression] Func<bool> bodyisTextPartIncluded = null, [WorkflowExpression] Func<string> bodyreplyEmail = null, [WorkflowExpression] Func<string> bodysenderName = null, [WorkflowExpression] Func<int> bodytemplateId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontactsListId = null, [WorkflowExpression] Func<string> bodycontactsListAlt = null, [WorkflowExpression] Func<int> bodysegmentationId = null, [WorkflowExpression] Func<string> bodysegmentationAlt = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<string> bodysenderEmail = null)
        {
            SourceExpression.Validate(draftId, nameof(draftId), required: true);
            SourceExpression.Validate(bodylocale, nameof(bodylocale), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodycurrent, nameof(bodycurrent), required: false);
            SourceExpression.Validate(bodyeditMode, nameof(bodyeditMode), required: false);
            SourceExpression.Validate(bodyisStarred, nameof(bodyisStarred), required: false);
            SourceExpression.Validate(bodyisTextPartIncluded, nameof(bodyisTextPartIncluded), required: false);
            SourceExpression.Validate(bodyreplyEmail, nameof(bodyreplyEmail), required: false);
            SourceExpression.Validate(bodysenderName, nameof(bodysenderName), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycontactsListId, nameof(bodycontactsListId), required: false);
            SourceExpression.Validate(bodycontactsListAlt, nameof(bodycontactsListAlt), required: false);
            SourceExpression.Validate(bodysegmentationId, nameof(bodysegmentationId), required: false);
            SourceExpression.Validate(bodysegmentationAlt, nameof(bodysegmentationAlt), required: false);
            SourceExpression.Validate(bodysender, nameof(bodysender), required: false);
            SourceExpression.Validate(bodysenderEmail, nameof(bodysenderEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/campaigndraft/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(draftId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycurrent != null)
                {
                    body["Current"] = SourceExpressionConverter.ConvertToken(bodycurrent);
                    bodypropCount++;
                }

                if (bodyeditMode != null)
                {
                    body["EditMode"] = SourceExpressionConverter.Convert(bodyeditMode);
                    bodypropCount++;
                }

                if (bodyisStarred != null)
                {
                    body["IsStarred"] = SourceExpressionConverter.ConvertToken(bodyisStarred);
                    bodypropCount++;
                }

                if (bodyisTextPartIncluded != null)
                {
                    body["IsTextPartIncluded"] = SourceExpressionConverter.ConvertToken(bodyisTextPartIncluded);
                    bodypropCount++;
                }

                if (bodyreplyEmail != null)
                {
                    body["ReplyEmail"] = SourceExpressionConverter.ConvertToken(bodyreplyEmail);
                    bodypropCount++;
                }

                if (bodysenderName != null)
                {
                    body["SenderName"] = SourceExpressionConverter.ConvertToken(bodysenderName);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["TemplateID"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontactsListId != null)
                {
                    body["ContactsListID"] = SourceExpressionConverter.ConvertToken(bodycontactsListId);
                    bodypropCount++;
                }

                if (bodycontactsListAlt != null)
                {
                    body["ContactsListAlt"] = SourceExpressionConverter.ConvertToken(bodycontactsListAlt);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Locale"] = SourceExpressionConverter.ConvertToken(bodylocale);
                if (bodysegmentationId != null)
                {
                    body["SegmentationID"] = SourceExpressionConverter.ConvertToken(bodysegmentationId);
                    bodypropCount++;
                }

                if (bodysegmentationAlt != null)
                {
                    body["SegmentationAlt"] = SourceExpressionConverter.ConvertToken(bodysegmentationAlt);
                    bodypropCount++;
                }

                if (bodysender != null)
                {
                    body["Sender"] = SourceExpressionConverter.ConvertToken(bodysender);
                    bodypropCount++;
                }

                if (bodysenderEmail != null)
                {
                    body["SenderEmail"] = SourceExpressionConverter.ConvertToken(bodysenderEmail);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateCampaignDraftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetCampaignOverviewResponse> GetCampaignOverview()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/campaignoverview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCampaignOverviewResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsStatisticsResponse> GetContactsStatistics()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contactstatistics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsStatisticsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactsDataResponse> GetContactsData([WorkflowExpression] Func<int> campaign = null, [WorkflowExpression] Func<string> contactEmail = null, [WorkflowExpression] Func<int> contactsList = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> lastActivityAt = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offSet = null, [WorkflowExpression] Func<bool> countOnly = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(campaign, nameof(campaign), required: false);
            SourceExpression.Validate(contactEmail, nameof(contactEmail), required: false);
            SourceExpression.Validate(contactsList, nameof(contactsList), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(lastActivityAt, nameof(lastActivityAt), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offSet, nameof(offSet), required: false);
            SourceExpression.Validate(countOnly, nameof(countOnly), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/REST/contactdata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (campaign != null)
                    callPayload.Queries["Campaign"] = SourceExpressionConverter.ConvertO(campaign);
                if (contactEmail != null)
                    callPayload.Queries["ContactEmail"] = SourceExpressionConverter.ConvertO(contactEmail);
                if (contactsList != null)
                    callPayload.Queries["ContactsList"] = SourceExpressionConverter.ConvertO(contactsList);
                if (fields != null)
                    callPayload.Queries["Fields"] = SourceExpressionConverter.ConvertO(fields);
                if (lastActivityAt != null)
                    callPayload.Queries["LastActivityAt"] = SourceExpressionConverter.ConvertO(lastActivityAt);
                callPayload.Queries["Limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["Limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offSet != null)
                    callPayload.Queries["OffSet"] = SourceExpressionConverter.ConvertO(offSet);
                if (countOnly != null)
                    callPayload.Queries["countOnly"] = SourceExpressionConverter.ConvertO(countOnly);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailjetip")]
        public IBodyWorkflowAction<GetContactDataByIdResponse> GetContactDataById([WorkflowExpression] Func<int> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/REST/contactdata/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactDataByIdResponse>(BuildSourceInput);
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
        public string CustomID { get; set; }
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
        public int MessageID { get; set; }
        public string MessageHref { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemCcTypeItem
    {
        public string Email { get; set; }
        public string MessageUUID { get; set; }
        public int MessageID { get; set; }
        public string MessageHref { get; set; }
    }

    public class SendEmailv31ResponseMessagesTypeItemBccTypeItem
    {
        public string Email { get; set; }
        public string MessageUUID { get; set; }
        public int MessageID { get; set; }
        public string MessageHref { get; set; }
    }

    public class bodymessagesInputItem
    {
        public bodymessagesInputItemFromType From { get; set; }
        public bodymessagesInputItemToTypeItem[] To { get; set; }
        public bodymessagesInputItemSenderType Sender { get; set; }
        public bodymessagesInputItemReplyToType ReplyTo { get; set; }
        public bodymessagesInputItemCcTypeItem[] Cc { get; set; }
        public bodymessagesInputItemBccTypeItem[] Bcc { get; set; }
        public string Subject { get; set; }
        public string TextPart { get; set; }
        public string HTMLPart { get; set; }
        public int TemplateID { get; set; }
        public Attachmentv31[] Attachments { get; set; }
    }

    public class bodymessagesInputItemFromType
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class bodymessagesInputItemToTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class bodymessagesInputItemSenderType
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class bodymessagesInputItemReplyToType
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class bodymessagesInputItemCcTypeItem
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class bodymessagesInputItemBccTypeItem
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
        public int MessageID { get; set; }
        public string MessageUUID { get; set; }
    }

    public class bodymessagesInputItem2
    {
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public bool Sender { get; set; }
        public bodymessagesInputItemRecipientsTypeItem[] Recipients { get; set; }
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
        public bodymessagesInputItemInlineAttachmentsTypeItem[] InlineAttachments { get; set; }
    }

    public class bodymessagesInputItemRecipientsTypeItem
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

    public class bodymessagesInputItemInlineAttachmentsTypeItem
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

    public enum bodyeditModeInput
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