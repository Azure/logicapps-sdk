//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Moosendip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MoosendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListActiveResponse> ListActive(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortMethod = null)
        {
            var apiCallPath = String.Format("/lists/{0}/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(page, 1), ExpressionConverter.ConvertWithUrlEncoding(pageSize, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sortBy != null)
                callPayload.Queries["SortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortMethod != null)
                callPayload.Queries["SortMethod"] = ExpressionConverter.Convert(sortMethod);
            return new ApiConnectionAction<ListActiveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDetailsResponse> ListDetails(Expression<Func<string>> mailingListId, Expression<Func<bool>> withStatistics = null)
        {
            var apiCallPath = String.Format("/lists/{0}/details.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (withStatistics != null)
                callPayload.Queries["WithStatistics"] = ExpressionConverter.Convert(withStatistics);
            return new ApiConnectionAction<ListDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListCreateResponse> ListCreate(Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyConfirmationPage = null, Expression<Func<string>> bodyRedirectAfterUnsubscribePage = null)
        {
            var apiCallPath = "/lists/create.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyConfirmationPage != null)
            {
                body["ConfirmationPage"] = ExpressionConverter.ConvertO(bodyConfirmationPage);
                bodypropCount++;
            }

            if (bodyRedirectAfterUnsubscribePage != null)
            {
                body["RedirectAfterUnsubscribePage"] = ExpressionConverter.ConvertO(bodyRedirectAfterUnsubscribePage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListUpdateResponse> ListUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyConfirmationPage = null, Expression<Func<string>> bodyRedirectAfterUnsubscribePage = null)
        {
            var apiCallPath = String.Format("/lists/{0}/update.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyConfirmationPage != null)
            {
                body["ConfirmationPage"] = ExpressionConverter.ConvertO(bodyConfirmationPage);
                bodypropCount++;
            }

            if (bodyRedirectAfterUnsubscribePage != null)
            {
                body["RedirectAfterUnsubscribePage"] = ExpressionConverter.ConvertO(bodyRedirectAfterUnsubscribePage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDeleteResponse> ListDelete(Expression<Func<string>> mailingListId)
        {
            var apiCallPath = String.Format("/lists/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldCreateResponse> FieldCreate(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyCustomFieldType = null, Expression<Func<string>> bodyOptions = null)
        {
            var apiCallPath = String.Format("/lists/{0}/customfields/create.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyCustomFieldType != null)
            {
                body["CustomFieldType"] = ExpressionConverter.ConvertO(bodyCustomFieldType);
                bodypropCount++;
            }

            if (bodyOptions != null)
            {
                body["Options"] = ExpressionConverter.ConvertO(bodyOptions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FieldCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldUpdateResponse> FieldUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> customFieldId, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyCustomFieldType = null, Expression<Func<string>> bodyOptions = null)
        {
            var apiCallPath = String.Format("/lists/{0}/customfields/{1}/update.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1), ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyCustomFieldType != null)
            {
                body["CustomFieldType"] = ExpressionConverter.ConvertO(bodyCustomFieldType);
                bodypropCount++;
            }

            if (bodyOptions != null)
            {
                body["Options"] = ExpressionConverter.ConvertO(bodyOptions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FieldUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldDeleteResponse> FieldDelete(Expression<Func<string>> mailingListId, Expression<Func<string>> customFieldId)
        {
            var apiCallPath = String.Format("/lists/{0}/customfields/{1}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1), ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FieldDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberListResponse> SubscriberList(Expression<Func<string>> mailingListId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/lists/{0}/subscribers/Subscribed.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<SubscriberListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetEmailResponse> SubscriberGetEmail(Expression<Func<string>> mailingListId, Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/subscribers/{0}/view.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            return new ApiConnectionAction<SubscriberGetEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetIDResponse> SubscriberGetID(Expression<Func<string>> mailingListId, Expression<Func<string>> subscriberId)
        {
            var apiCallPath = String.Format("/subscribers/{0}/find/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SubscriberGetIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddResponse> SubscriberAdd(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyEmail = null, Expression<Func<bool>> bodyHasExternalDoubleOptIn = null, Expression<Func<string[]>> bodyCustomFields = null)
        {
            var apiCallPath = String.Format("/subscribers/{0}/subscribe.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyHasExternalDoubleOptIn != null)
            {
                body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(bodyHasExternalDoubleOptIn);
                bodypropCount++;
            }

            if (bodyCustomFields != null)
            {
                body["CustomFields"] = ExpressionConverter.ConvertO(bodyCustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SubscriberAddResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddBulkResponse> SubscriberAddBulk(Expression<Func<string>> mailingListId, Expression<Func<bool>> bodyHasExternalDoubleOptIn = null, Expression<Func<bodySubscribersInputItem[]>> bodySubscribers = null)
        {
            var apiCallPath = String.Format("/subscribers/{0}/subscribe_many.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyHasExternalDoubleOptIn != null)
            {
                body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(bodyHasExternalDoubleOptIn);
                bodypropCount++;
            }

            if (bodySubscribers != null)
            {
                body["Subscribers"] = ExpressionConverter.ConvertO(bodySubscribers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SubscriberAddBulkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse> SubscriberUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> subscriberId, Expression<Func<string>> bodyName = null, Expression<Func<bool>> bodyHasExternalDoubleOptIn = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string[]>> bodyCustomFields = null)
        {
            var apiCallPath = String.Format("/subscribers/{0}/update/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyHasExternalDoubleOptIn != null)
            {
                body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(bodyHasExternalDoubleOptIn);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyCustomFields != null)
            {
                body["CustomFields"] = ExpressionConverter.ConvertO(bodyCustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SubscriberUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeAccountResponse> UnsubscribeAccount(Expression<Func<string>> bodyEmail)
        {
            var apiCallPath = "/subscribers/unsubscribe.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnsubscribeAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeListResponse> UnsubscribeList(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyEmail)
        {
            var apiCallPath = String.Format("/subscribers/{0}/unsubscribe.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnsubscribeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveResponse> UnsubscribeRemove(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyEmail)
        {
            var apiCallPath = String.Format("/subscribers/{0}/remove.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnsubscribeRemoveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveBulkResponse> UnsubscribeRemoveBulk(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyEmails)
        {
            var apiCallPath = String.Format("/subscribers/{0}/remove_many.json", ExpressionConverter.ConvertWithUrlEncoding(mailingListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Emails"] = ExpressionConverter.ConvertO(bodyEmails);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnsubscribeRemoveBulkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetResponse> CampaignGet(Expression<Func<string>> page, Expression<Func<string>> pageSize, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortMethod = null)
        {
            var apiCallPath = String.Format("/campaigns/{0}/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(page, 1), ExpressionConverter.ConvertWithUrlEncoding(pageSize, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sortBy != null)
                callPayload.Queries["SortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortMethod != null)
                callPayload.Queries["SortMethod"] = ExpressionConverter.Convert(sortMethod);
            return new ApiConnectionAction<CampaignGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetDetailsResponse> CampaignGetDetails(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/view.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignGetDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetResponse> SenderGet()
        {
            var apiCallPath = "/senders/find_all.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SenderGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetEmailResponse> SenderGetEmail(Expression<Func<string>> email)
        {
            var apiCallPath = "/senders/find_one.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            return new ApiConnectionAction<SenderGetEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCloneResponse> CampaignClone(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/clone.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignCloneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCreateResponse> CampaignCreate(Expression<Func<string>> bodyName = null, Expression<Func<string>> bodySubject = null, Expression<Func<string>> bodySenderEmail = null, Expression<Func<string>> bodyReplyToEmail = null, Expression<Func<string>> bodyConfirmationToEmail = null, Expression<Func<string>> bodyWebLocation = null, Expression<Func<bodyMailingListsInputItem[]>> bodyMailingLists = null, Expression<Func<string>> bodyIsAB = null, Expression<Func<string>> bodyABCampaignType = null, Expression<Func<string>> bodyWebLocationB = null, Expression<Func<string>> bodyHoursToTest = null, Expression<Func<string>> bodyListPercentage = null, Expression<Func<string>> bodyABWinnerSelectionType = null)
        {
            var apiCallPath = "/campaigns/create.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodySubject != null)
            {
                body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
                bodypropCount++;
            }

            if (bodySenderEmail != null)
            {
                body["SenderEmail"] = ExpressionConverter.ConvertO(bodySenderEmail);
                bodypropCount++;
            }

            if (bodyReplyToEmail != null)
            {
                body["ReplyToEmail"] = ExpressionConverter.ConvertO(bodyReplyToEmail);
                bodypropCount++;
            }

            if (bodyConfirmationToEmail != null)
            {
                body["ConfirmationToEmail"] = ExpressionConverter.ConvertO(bodyConfirmationToEmail);
                bodypropCount++;
            }

            if (bodyWebLocation != null)
            {
                body["WebLocation"] = ExpressionConverter.ConvertO(bodyWebLocation);
                bodypropCount++;
            }

            if (bodyMailingLists != null)
            {
                body["MailingLists"] = ExpressionConverter.ConvertO(bodyMailingLists);
                bodypropCount++;
            }

            if (bodyIsAB != null)
            {
                body["IsAB"] = ExpressionConverter.ConvertO(bodyIsAB);
                bodypropCount++;
            }

            if (bodyABCampaignType != null)
            {
                body["ABCampaignType"] = ExpressionConverter.ConvertO(bodyABCampaignType);
                bodypropCount++;
            }

            if (bodyWebLocationB != null)
            {
                body["WebLocationB"] = ExpressionConverter.ConvertO(bodyWebLocationB);
                bodypropCount++;
            }

            if (bodyHoursToTest != null)
            {
                body["HoursToTest"] = ExpressionConverter.ConvertO(bodyHoursToTest);
                bodypropCount++;
            }

            if (bodyListPercentage != null)
            {
                body["ListPercentage"] = ExpressionConverter.ConvertO(bodyListPercentage);
                bodypropCount++;
            }

            if (bodyABWinnerSelectionType != null)
            {
                body["ABWinnerSelectionType"] = ExpressionConverter.ConvertO(bodyABWinnerSelectionType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CampaignCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUpdateResponse> CampaignUpdate(Expression<Func<string>> campaignId, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodySubject = null, Expression<Func<string>> bodySenderEmail = null, Expression<Func<string>> bodyReplyToEmail = null, Expression<Func<string>> bodyConfirmationToEmail = null, Expression<Func<string>> bodyWebLocation = null, Expression<Func<bodyMailingListsInputItem[]>> bodyMailingLists = null, Expression<Func<string>> bodyIsAB = null, Expression<Func<string>> bodyABCampaignType = null, Expression<Func<string>> bodyWebLocationB = null, Expression<Func<string>> bodyHoursToTest = null, Expression<Func<string>> bodyListPercentage = null, Expression<Func<string>> bodyABWinnerSelectionType = null)
        {
            var apiCallPath = String.Format("/campaigns/{0}/update.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodySubject != null)
            {
                body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
                bodypropCount++;
            }

            if (bodySenderEmail != null)
            {
                body["SenderEmail"] = ExpressionConverter.ConvertO(bodySenderEmail);
                bodypropCount++;
            }

            if (bodyReplyToEmail != null)
            {
                body["ReplyToEmail"] = ExpressionConverter.ConvertO(bodyReplyToEmail);
                bodypropCount++;
            }

            if (bodyConfirmationToEmail != null)
            {
                body["ConfirmationToEmail"] = ExpressionConverter.ConvertO(bodyConfirmationToEmail);
                bodypropCount++;
            }

            if (bodyWebLocation != null)
            {
                body["WebLocation"] = ExpressionConverter.ConvertO(bodyWebLocation);
                bodypropCount++;
            }

            if (bodyMailingLists != null)
            {
                body["MailingLists"] = ExpressionConverter.ConvertO(bodyMailingLists);
                bodypropCount++;
            }

            if (bodyIsAB != null)
            {
                body["IsAB"] = ExpressionConverter.ConvertO(bodyIsAB);
                bodypropCount++;
            }

            if (bodyABCampaignType != null)
            {
                body["ABCampaignType"] = ExpressionConverter.ConvertO(bodyABCampaignType);
                bodypropCount++;
            }

            if (bodyWebLocationB != null)
            {
                body["WebLocationB"] = ExpressionConverter.ConvertO(bodyWebLocationB);
                bodypropCount++;
            }

            if (bodyHoursToTest != null)
            {
                body["HoursToTest"] = ExpressionConverter.ConvertO(bodyHoursToTest);
                bodypropCount++;
            }

            if (bodyListPercentage != null)
            {
                body["ListPercentage"] = ExpressionConverter.ConvertO(bodyListPercentage);
                bodypropCount++;
            }

            if (bodyABWinnerSelectionType != null)
            {
                body["ABWinnerSelectionType"] = ExpressionConverter.ConvertO(bodyABWinnerSelectionType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CampaignUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignDeleteResponse> CampaignDelete(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignTestResponse> CampaignTest(Expression<Func<string>> campaignId, Expression<Func<string[]>> bodyTestEmails)
        {
            var apiCallPath = String.Format("/campaigns/{0}/send_test.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["TestEmails"] = ExpressionConverter.ConvertO(bodyTestEmails);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CampaignTestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSendResponse> CampaignSend(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/send.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignSendResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignStatsResponse> CampaignStats(Expression<Func<string>> campaignId, Expression<Func<typeInput>> type, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var apiCallPath = String.Format("/campaigns/{0}/stats/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1), ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
            if (from != null)
                callPayload.Queries["From"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["To"] = ExpressionConverter.Convert(to);
            return new ApiConnectionAction<CampaignStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSummaryResponse> CampaignSummary(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/view_summary.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLocationResponse> CampaignActivityLocation(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/stats/countries.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignActivityLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLinkResponse> CampaignActivityLink(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/stats/links.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignActivityLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignScheduleResponse> CampaignSchedule(Expression<Func<string>> campaignId, Expression<Func<string>> bodyDateTime, Expression<Func<string>> bodyTimezone = null)
        {
            var apiCallPath = String.Format("/campaigns/{0}/schedule.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["DateTime"] = ExpressionConverter.ConvertO(bodyDateTime);
            if (bodyTimezone != null)
            {
                body["Timezone"] = ExpressionConverter.ConvertO(bodyTimezone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CampaignScheduleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUnscheduleResponse> CampaignUnschedule(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/unschedule.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignUnscheduleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignABSummaryResponse> CampaignABSummary(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/view_ab_summary.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignABSummaryResponse>(callPayload);
        }
    }

    public class MoosendipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListActiveResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public ListActiveResponseContextType Context { get; set; }
    }

    public class ListActiveResponseContextType
    {
        public ListActiveResponseContextTypePagingType Paging { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
    }

    public class ListActiveResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItemCustomFieldsDefinitionTypeItem[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItemImportOperationType ImportOperation { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItemCustomFieldsDefinitionTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItemImportOperationType
    {
        public int ID { get; set; }
        public string DataHash { get; set; }
        public string Mappings { get; set; }
        public string EmailNotify { get; set; }
        public string CreatedOn { get; set; }
        public string StartedOn { get; set; }
        public string CompletedOn { get; set; }
        public int TotalInserted { get; set; }
        public int TotalUpdated { get; set; }
        public int TotalUnsubscribed { get; set; }
        public int TotalInvalid { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalMembers { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class ListDetailsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public ListDetailsResponseContextType Context { get; set; }
    }

    public class ListDetailsResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public ListDetailsResponseContextTypeCustomFieldsDefinitionTypeItem[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public ListDetailsResponseContextTypeImportOperationType ImportOperation { get; set; }
    }

    public class ListDetailsResponseContextTypeCustomFieldsDefinitionTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListDetailsResponseContextTypeImportOperationType
    {
        public int ID { get; set; }
        public string DataHash { get; set; }
        public string Mappings { get; set; }
        public string EmailNotify { get; set; }
        public string CreatedOn { get; set; }
        public string StartedOn { get; set; }
        public string CompletedOn { get; set; }
        public int TotalInserted { get; set; }
        public int TotalUpdated { get; set; }
        public int TotalUnsubscribed { get; set; }
        public int TotalInvalid { get; set; }
        public int TotalIgnored { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalMembers { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public bool SkipNewMembers { get; set; }
    }

    public class ListCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class ListUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class ListDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class SubscriberListResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberListResponseContextType Context { get; set; }
    }

    public class SubscriberListResponseContextType
    {
        public SubscriberListResponseContextTypePagingType Paging { get; set; }
        public SubscriberListResponseContextTypeSubscribersTypeItem[] Subscribers { get; set; }
    }

    public class SubscriberListResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class SubscriberListResponseContextTypeSubscribersTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberGetEmailResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberGetEmailResponseContextType Context { get; set; }
    }

    public class SubscriberGetEmailResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberGetIDResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberGetIDResponseContextType Context { get; set; }
    }

    public class SubscriberGetIDResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public JToken[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberAddResponseContextType Context { get; set; }
    }

    public class SubscriberAddResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberAddBulkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberAddBulkResponseContextTypeItem[] Context { get; set; }
    }

    public class SubscriberAddBulkResponseContextTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class bodySubscribersInputItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string[] CustomFields { get; set; }
    }

    public class SubscriberUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberUpdateResponseContextType Context { get; set; }
    }

    public class SubscriberUpdateResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberUpdateResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberUpdateResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UnsubscribeAccountResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeListResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeRemoveResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeRemoveBulkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public UnsubscribeRemoveBulkResponseContextType Context { get; set; }
    }

    public class UnsubscribeRemoveBulkResponseContextType
    {
        public int EmailsIgnored { get; set; }
        public int EmailsProcessed { get; set; }
    }

    public class CampaignGetResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignGetResponseContextType Context { get; set; }
    }

    public class CampaignGetResponseContextType
    {
        public CampaignGetResponseContextTypePagingType Paging { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItem[] Campaigns { get; set; }
    }

    public class CampaignGetResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string SiteName { get; set; }
        public string ConfirmationTo { get; set; }
        public string CreatedOn { get; set; }
        public string ABHoursToTest { get; set; }
        public string ABCampaignType { get; set; }
        public string ABWinner { get; set; }
        public string ABWinnerSelectionType { get; set; }
        public int Status { get; set; }
        public string DeliveredOn { get; set; }
        public string ScheduledFor { get; set; }
        public string ScheduledForTimezone { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItem[] MailingLists { get; set; }
        public int TotalSent { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int RecipientsCount { get; set; }
        public bool IsTransactional { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalUnsubscribes { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItemMailingListType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }

    public class CampaignGetDetailsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignGetDetailsResponseContextType Context { get; set; }
    }

    public class CampaignGetDetailsResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string WebLocation { get; set; }
        public string HTMLContent { get; set; }
        public string PlainContent { get; set; }
        public CampaignGetDetailsResponseContextTypeSenderType Sender { get; set; }
        public string DeliveredOn { get; set; }
        public CampaignGetDetailsResponseContextTypeReplyToEmailType ReplyToEmail { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string ScheduledFor { get; set; }
        public string Timezone { get; set; }
        public int FormatType { get; set; }
        public string ABCampaignData { get; set; }
        public CampaignGetDetailsResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string ConfirmationTo { get; set; }
        public int Status { get; set; }
        public bool IsTransactional { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeSenderType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeReplyToEmailType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeMailingListsTypeItem
    {
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
    }

    public class SenderGetResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SenderGetResponseContextTypeItem[] Context { get; set; }
    }

    public class SenderGetResponseContextTypeItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class SenderGetEmailResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SenderGetEmailResponseContextType Context { get; set; }
    }

    public class SenderGetEmailResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignCloneResponseContextType Context { get; set; }
    }

    public class CampaignCloneResponseContextType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string WebLocation { get; set; }
        public string HTMLContent { get; set; }
        public string PlainContent { get; set; }
        public CampaignCloneResponseContextTypeSenderType Sender { get; set; }
        public string DeliveredOn { get; set; }
        public CampaignCloneResponseContextTypeReplyToEmailType ReplyToEmail { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string ScheduledFor { get; set; }
        public string Timezone { get; set; }
        public int FormatType { get; set; }
        public CampaignCloneResponseContextTypeABCampaignDataType ABCampaignData { get; set; }
        public CampaignCloneResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string ConfirmationTo { get; set; }
        public int Status { get; set; }
        public bool IsTransactional { get; set; }
    }

    public class CampaignCloneResponseContextTypeSenderType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponseContextTypeReplyToEmailType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponseContextTypeABCampaignDataType
    {
        public int ID { get; set; }
        public string SubjectB { get; set; }
        public string PlainContentB { get; set; }
        public string HTMLContentB { get; set; }
        public string WebLocationB { get; set; }
        public string SenderB { get; set; }
        public int HoursToTest { get; set; }
        public int ListPercentage { get; set; }
        public int ABCampaignType { get; set; }
        public int ABWinnerSelectionType { get; set; }
        public string DeliveredOnA { get; set; }
        public string DeliveredOnB { get; set; }
    }

    public class CampaignCloneResponseContextTypeMailingListsTypeItem
    {
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
    }

    public class CampaignCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class bodyMailingListsInputItem
    {
        public string MailingListID { get; set; }
        public string SegmentID { get; set; }
    }

    public class CampaignUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignTestResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignSendResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignStatsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignStatsResponseContextType Context { get; set; }
    }

    public class CampaignStatsResponseContextType
    {
        public CampaignStatsResponseContextTypePagingType Paging { get; set; }
        public CampaignStatsResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignStatsResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignStatsResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    public enum typeInput
    {
        Sent,
        Opened,
        LinkClicked,
        Forward,
        Unsubscribed,
        Bounced,
        Complained
    }

    public class CampaignSummaryResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignSummaryResponseContextType Context { get; set; }
    }

    public class CampaignSummaryResponseContextType
    {
        public string CampaignID { get; set; }
        public string ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignSummaryResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignSummaryResponseContextTypeMailingListsTypeItem
    {
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
    }

    public class CampaignActivityLocationResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignActivityLocationResponseContextType Context { get; set; }
    }

    public class CampaignActivityLocationResponseContextType
    {
        public CampaignActivityLocationResponseContextTypePagingType Paging { get; set; }
        public CampaignActivityLocationResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignActivityLocationResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignActivityLocationResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    public class CampaignActivityLinkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignActivityLinkResponseContextType Context { get; set; }
    }

    public class CampaignActivityLinkResponseContextType
    {
        public CampaignActivityLinkResponseContextTypePagingType Paging { get; set; }
        public CampaignActivityLinkResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignActivityLinkResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignActivityLinkResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    public class CampaignScheduleResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignUnscheduleResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignABSummaryResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignABSummaryResponseContextType Context { get; set; }
    }

    public class CampaignABSummaryResponseContextType
    {
        public string CampaignID { get; set; }
        public CampaignABSummaryResponseContextTypeAType A { get; set; }
        public CampaignABSummaryResponseContextTypeBType B { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeAType
    {
        public string CampaignID { get; set; }
        public int ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignABSummaryResponseContextTypeATypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeATypeMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignABSummaryResponseContextTypeATypeMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeATypeMailingListsTypeItemMailingListType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBType
    {
        public string CampaignID { get; set; }
        public int ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItemMailingListType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Moosendip;

    public partial class WorkflowManagedActions
    {
        public MoosendipActions Moosendip(string connectionId) => new MoosendipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MoosendipTriggers Moosendip(string connectionId) => new MoosendipTriggers(connectionId);
    }
}