//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SociabbleActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildSendAlertRequest))]
        public IWorkflowAction SendAlertRequest([WorkflowExpression] Func<string> bodyalertText, [WorkflowExpression] Func<string> bodyalertTitle, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<bool> bodyisMandatory = null, [WorkflowExpression] Func<bool> bodysendSMS = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendAlertRequest(WorkflowExpression<string> bodyalertText, WorkflowExpression<string> bodyalertTitle, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodyusername = null, WorkflowExpression<bool> bodyisMandatory = null, WorkflowExpression<bool> bodysendSMS = null)
        {
            WorkflowExpression.Validate(bodyalertText, nameof(bodyalertText), required: true);
            WorkflowExpression.Validate(bodyalertTitle, nameof(bodyalertTitle), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            WorkflowExpression.Validate(bodyisMandatory, nameof(bodyisMandatory), required: false);
            WorkflowExpression.Validate(bodysendSMS, nameof(bodysendSMS), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/alerts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["alertText"] = ExpressionConverter.ConvertO(bodyalertText);
                bodypropCount++;
                body["alertTitle"] = ExpressionConverter.ConvertO(bodyalertTitle);
                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(bodyusername);
                    bodypropCount++;
                }

                if (bodyisMandatory != null)
                {
                    body["isMandatory"] = ExpressionConverter.ConvertO(bodyisMandatory);
                    bodypropCount++;
                }

                if (bodysendSMS != null)
                {
                    body["sendSMS"] = ExpressionConverter.ConvertO(bodysendSMS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAudiencesResponseItem[]> GetAudiences()
        {
            var apiCallPath = "/companies/audiences";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAudiencesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetChannelsResponseItem[]> GetChannels()
        {
            var apiCallPath = "/channels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetChannelsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetCategoriesResponseItem[]> GetCategories()
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCategoriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCreateInternalNews))]
        public IBodyWorkflowAction<InternalContent> CreateInternalNews([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedInternalContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null, [WorkflowExpression] Func<bool> bodyareCommentsAuthorized = null, [WorkflowExpression] Func<bool> bodyshouldNotifyUsers = null, [WorkflowExpression] Func<bool> bodyisMustReadContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InternalContent> __BuildCreateInternalNews(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedInternalContentCreation[]> bodycontents, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null, WorkflowExpression<bool> bodyareCommentsAuthorized = null, WorkflowExpression<bool> bodyshouldNotifyUsers = null, WorkflowExpression<bool> bodyisMustReadContent = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            WorkflowExpression.Validate(bodyareCommentsAuthorized, nameof(bodyareCommentsAuthorized), required: false);
            WorkflowExpression.Validate(bodyshouldNotifyUsers, nameof(bodyshouldNotifyUsers), required: false);
            WorkflowExpression.Validate(bodyisMustReadContent, nameof(bodyisMustReadContent), required: false);
            return new DeferredBodyAction<InternalContent>(() =>
            {
                var apiCallPath = "/content/internalnews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = ExpressionConverter.ConvertO(bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = ExpressionConverter.ConvertO(bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = ExpressionConverter.ConvertO(bodyisMustReadContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InternalContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCreateExternalContent))]
        public IBodyWorkflowAction<ExternalContent> CreateExternalContent([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedExternalContentCreation[]> bodycontents, [WorkflowExpression] Func<string> bodycontentUrl, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null, [WorkflowExpression] Func<bool> bodyisShareable = null, [WorkflowExpression] Func<bool> bodyisOfficialContent = null, [WorkflowExpression] Func<bool> bodyareCommentsAuthorized = null, [WorkflowExpression] Func<bool> bodyshouldNotifyUsers = null, [WorkflowExpression] Func<bool> bodyisMustReadContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExternalContent> __BuildCreateExternalContent(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedExternalContentCreation[]> bodycontents, WorkflowExpression<string> bodycontentUrl, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null, WorkflowExpression<bool> bodyisShareable = null, WorkflowExpression<bool> bodyisOfficialContent = null, WorkflowExpression<bool> bodyareCommentsAuthorized = null, WorkflowExpression<bool> bodyshouldNotifyUsers = null, WorkflowExpression<bool> bodyisMustReadContent = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodycontentUrl, nameof(bodycontentUrl), required: true);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            WorkflowExpression.Validate(bodyisShareable, nameof(bodyisShareable), required: false);
            WorkflowExpression.Validate(bodyisOfficialContent, nameof(bodyisOfficialContent), required: false);
            WorkflowExpression.Validate(bodyareCommentsAuthorized, nameof(bodyareCommentsAuthorized), required: false);
            WorkflowExpression.Validate(bodyshouldNotifyUsers, nameof(bodyshouldNotifyUsers), required: false);
            WorkflowExpression.Validate(bodyisMustReadContent, nameof(bodyisMustReadContent), required: false);
            return new DeferredBodyAction<ExternalContent>(() =>
            {
                var apiCallPath = "/content/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                bodypropCount++;
                body["contentUrl"] = ExpressionConverter.ConvertO(bodycontentUrl);
                if (bodyisShareable != null)
                {
                    body["isShareable"] = ExpressionConverter.ConvertO(bodyisShareable);
                    bodypropCount++;
                }

                if (bodyisOfficialContent != null)
                {
                    body["isOfficialContent"] = ExpressionConverter.ConvertO(bodyisOfficialContent);
                    bodypropCount++;
                }

                if (bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = ExpressionConverter.ConvertO(bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = ExpressionConverter.ConvertO(bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = ExpressionConverter.ConvertO(bodyisMustReadContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExternalContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCtaSuggestContentCreation))]
        public IBodyWorkflowAction<CtaSuggestContent> CtaSuggestContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CtaSuggestContent> __BuildCtaSuggestContentCreation(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedBaseCtaContentCreation[]> bodycontents, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            return new DeferredBodyAction<CtaSuggestContent>(() =>
            {
                var apiCallPath = "/content/Cta/Suggest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "SuggestContent";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaSuggestContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCtaInvitationContentCreation))]
        public IBodyWorkflowAction<CtaInvitationContent> CtaInvitationContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CtaInvitationContent> __BuildCtaInvitationContentCreation(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedBaseCtaContentCreation[]> bodycontents, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            return new DeferredBodyAction<CtaInvitationContent>(() =>
            {
                var apiCallPath = "/content/Cta/Invitation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Invitation";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaInvitationContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCtaMobileContentCreation))]
        public IBodyWorkflowAction<CtaMobileContent> CtaMobileContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CtaMobileContent> __BuildCtaMobileContentCreation(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedBaseCtaContentCreation[]> bodycontents, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            return new DeferredBodyAction<CtaMobileContent>(() =>
            {
                var apiCallPath = "/content/Cta/Mobile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Mobile";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaMobileContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildCtaEventCreation))]
        public IBodyWorkflowAction<CtaEventContent> CtaEventCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedCtaEventContentCreation[]> bodycontents, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<int> bodyawardedBonus = null, [WorkflowExpression] Func<bool> bodyshouldDisplayTitle = null, [WorkflowExpression] Func<bool> bodyshouldDisplayButton = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CtaEventContent> __BuildCtaEventCreation(WorkflowExpression<string[]> bodychannelIds, WorkflowExpression<LocalizedCtaEventContentCreation[]> bodycontents, WorkflowExpression<string> bodyaudienceId = null, WorkflowExpression<string[]> bodycategoryIds = null, WorkflowExpression<string> bodylink = null, WorkflowExpression<int> bodyawardedBonus = null, WorkflowExpression<bool> bodyshouldDisplayTitle = null, WorkflowExpression<bool> bodyshouldDisplayButton = null, WorkflowExpression<string> bodypublicationStartDate = null, WorkflowExpression<string> bodypublicationEndDate = null, WorkflowExpression<bodymyNewsDisplayInput> bodymyNewsDisplay = null, WorkflowExpression<bool> bodyshouldPinTopOfMyNews = null, WorkflowExpression<string> bodypinOfMyNewsStartDate = null, WorkflowExpression<string> bodypinOfMyNewsEndDate = null, WorkflowExpression<bool> bodyshouldPinTopOfSelectedChannels = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsStartDate = null, WorkflowExpression<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            WorkflowExpression.Validate(bodychannelIds, nameof(bodychannelIds), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodyaudienceId, nameof(bodyaudienceId), required: false);
            WorkflowExpression.Validate(bodycategoryIds, nameof(bodycategoryIds), required: false);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: false);
            WorkflowExpression.Validate(bodyawardedBonus, nameof(bodyawardedBonus), required: false);
            WorkflowExpression.Validate(bodyshouldDisplayTitle, nameof(bodyshouldDisplayTitle), required: false);
            WorkflowExpression.Validate(bodyshouldDisplayButton, nameof(bodyshouldDisplayButton), required: false);
            WorkflowExpression.Validate(bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            WorkflowExpression.Validate(bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            WorkflowExpression.Validate(bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            WorkflowExpression.Validate(bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            WorkflowExpression.Validate(bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            WorkflowExpression.Validate(bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            return new DeferredBodyAction<CtaEventContent>(() =>
            {
                var apiCallPath = "/content/Cta/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                body["ctaDiscriminator"] = "Event";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(bodychannelIds);
                if (bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(bodylink);
                    bodypropCount++;
                }

                if (bodyawardedBonus != null)
                {
                    body["awardedBonus"] = ExpressionConverter.ConvertO(bodyawardedBonus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodyshouldDisplayTitle != null)
                {
                    body["shouldDisplayTitle"] = ExpressionConverter.ConvertO(bodyshouldDisplayTitle);
                    bodypropCount++;
                }

                if (bodyshouldDisplayButton != null)
                {
                    body["shouldDisplayButton"] = ExpressionConverter.ConvertO(bodyshouldDisplayButton);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaEventContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildAssignBadgeToUser))]
        public IWorkflowAction AssignBadgeToUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> bodybadgeId, [WorkflowExpression] Func<int> bodylevel)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssignBadgeToUser(WorkflowExpression<string> username, WorkflowExpression<string> bodybadgeId, WorkflowExpression<int> bodylevel)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(bodybadgeId, nameof(bodybadgeId), required: true);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/badges/", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["badgeId"] = ExpressionConverter.ConvertO(bodybadgeId);
                bodypropCount++;
                body["level"] = ExpressionConverter.ConvertO(bodylevel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildAssignCustomActionToUser))]
        public IWorkflowAction AssignCustomActionToUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents, [WorkflowExpression] Func<bool> bodyisEngaging = null, [WorkflowExpression] Func<bool> bodyisInternal = null, [WorkflowExpression] Func<int> bodypoints = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssignCustomActionToUser(WorkflowExpression<string> username, WorkflowExpression<bodycontentsInputItem[]> bodycontents, WorkflowExpression<bool> bodyisEngaging = null, WorkflowExpression<bool> bodyisInternal = null, WorkflowExpression<int> bodypoints = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: true);
            WorkflowExpression.Validate(bodyisEngaging, nameof(bodyisEngaging), required: false);
            WorkflowExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            WorkflowExpression.Validate(bodypoints, nameof(bodypoints), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/customactions/", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisEngaging != null)
                {
                    body["isEngaging"] = ExpressionConverter.ConvertO(bodyisEngaging);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypoints != null)
                {
                    body["points"] = ExpressionConverter.ConvertO(bodypoints);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAllBadgesResponseItem[]> GetAllBadges()
        {
            var apiCallPath = "/badges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllBadgesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildGetBadgeLevels))]
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[]> GetBadgeLevels([WorkflowExpression] Func<string> badgeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[]> __BuildGetBadgeLevels(WorkflowExpression<string> badgeId)
        {
            WorkflowExpression.Validate(badgeId, nameof(badgeId), required: true);
            return new DeferredBodyAction<GetBadgeLevelsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/badges/{0}/levels", ExpressionConverter.ConvertWithUrlEncoding(badgeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBadgeLevelsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaByStream))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStream([WorkflowExpression] Func<mediaVisibilityInput> mediaVisibility, [WorkflowExpression] Func<object> media)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaByStream(WorkflowExpression<mediaVisibilityInput> mediaVisibility, WorkflowExpression<object> media)
        {
            WorkflowExpression.Validate(mediaVisibility, nameof(mediaVisibility), required: true);
            WorkflowExpression.Validate(media, nameof(media), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByStream";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaByUrl))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrl([WorkflowExpression] Func<mediaVisibilityInput> mediaVisibility, [WorkflowExpression] Func<string> mediaUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaByUrl(WorkflowExpression<mediaVisibilityInput> mediaVisibility, WorkflowExpression<string> mediaUrl)
        {
            WorkflowExpression.Validate(mediaVisibility, nameof(mediaVisibility), required: true);
            WorkflowExpression.Validate(mediaUrl, nameof(mediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaByStreamByFolder))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStreamByFolder([WorkflowExpression] Func<mediaVisibilityInput> mediaVisibility, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<object> media)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaByStreamByFolder(WorkflowExpression<mediaVisibilityInput> mediaVisibility, WorkflowExpression<string> folderId, WorkflowExpression<object> media)
        {
            WorkflowExpression.Validate(mediaVisibility, nameof(mediaVisibility), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(media, nameof(media), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByStreamByFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaByUrlByFolder))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrlByFolder([WorkflowExpression] Func<mediaVisibilityInput> mediaVisibility, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> mediaUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaByUrlByFolder(WorkflowExpression<mediaVisibilityInput> mediaVisibility, WorkflowExpression<string> folderId, WorkflowExpression<string> mediaUrl)
        {
            WorkflowExpression.Validate(mediaVisibility, nameof(mediaVisibility), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(mediaUrl, nameof(mediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByUrlByFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [WorkflowExpressionFactory(nameof(__BuildGetMediaDriveFolders))]
        public IBodyWorkflowAction<GetFoldersResponse> GetMediaDriveFolders([WorkflowExpression] Func<string> culture = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFoldersResponse> __BuildGetMediaDriveFolders(WorkflowExpression<string> culture = null)
        {
            WorkflowExpression.Validate(culture, nameof(culture), required: false);
            return new DeferredBodyAction<GetFoldersResponse>(() =>
            {
                var apiCallPath = "/mediadrive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["culture"] = Convert.ToString("en");
                if (culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(culture);
                return new ApiConnectionAction<GetFoldersResponse>(callPayload);
            });
        }
    }

    public class SociabbleTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAudiencesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetChannelsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCategoriesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("shouldFillBackground")]
        public bool ShouldFillBackground { get; set; }
    }

    public class InternalContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedInternalContent[] Contents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContentTypeDiscriminator
    {
        None,
        InternalNews,
        Quiz,
        Survey,
        ContentForSharing,
        Cta,
        Live,
        SocialNetworkContent,
        AdminExternalContent,
        PersonalisedTile,
        Poll,
        UserContent,
        SupportMyCause
    }

    public class ContentChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class ContentCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("shouldFillBackground")]
        public bool ShouldFillBackground { get; set; }
    }

    public class LocalizedInternalContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaIds")]
        public string[] MediaIds { get; set; }

        [JsonProperty("medias")]
        public ContentImage[] Medias { get; set; }
    }

    public class ContentImage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class LocalizedInternalContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaIds")]
        public string[] MediaIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LanguageBehavior
    {
        [EnumMember(Value = "af")]
        Afrikaans,
        [EnumMember(Value = "ar")]
        Arabic,
        [EnumMember(Value = "bn")]
        Bengali,
        [EnumMember(Value = "bs")]
        Bosnian,
        [EnumMember(Value = "pt-BR")]
        BrazilianPortuguese,
        [EnumMember(Value = "bg")]
        Bulgarian,
        [EnumMember(Value = "ca")]
        Catalan,
        [EnumMember(Value = "zh-Hans")]
        ChineseSimplified,
        [EnumMember(Value = "zh-Hant")]
        ChineseTraditional,
        [EnumMember(Value = "hr")]
        Croatian,
        [EnumMember(Value = "cs")]
        Czech,
        [EnumMember(Value = "da")]
        Danish,
        [EnumMember(Value = "nl")]
        Dutch,
        [EnumMember(Value = "en")]
        English,
        [EnumMember(Value = "et")]
        Estonian,
        [EnumMember(Value = "fil")]
        Filipino,
        [EnumMember(Value = "fi")]
        Finnish,
        [EnumMember(Value = "fr")]
        French,
        [EnumMember(Value = "de")]
        German,
        [EnumMember(Value = "el")]
        Greek,
        [EnumMember(Value = "he")]
        Hebrew,
        [EnumMember(Value = "hi")]
        Hindi,
        [EnumMember(Value = "hu")]
        Hungarian,
        [EnumMember(Value = "is")]
        Icelandic,
        [EnumMember(Value = "id")]
        Indonesian,
        [EnumMember(Value = "it")]
        Italian,
        [EnumMember(Value = "ja")]
        Japanese,
        [EnumMember(Value = "sw")]
        Kiswahili,
        [EnumMember(Value = "ko")]
        Korean,
        [EnumMember(Value = "lv")]
        Latvian,
        [EnumMember(Value = "lt")]
        Lithuanian,
        [EnumMember(Value = "ms")]
        Malay,
        [EnumMember(Value = "mt")]
        Maltese,
        [EnumMember(Value = "nb")]
        Norwegian,
        [EnumMember(Value = "fa")]
        Persian,
        [EnumMember(Value = "pl")]
        Polish,
        [EnumMember(Value = "pt")]
        Portuguese,
        [EnumMember(Value = "ro")]
        Romanian,
        [EnumMember(Value = "ru")]
        Russian,
        [EnumMember(Value = "sr")]
        Serbian,
        [EnumMember(Value = "sk")]
        Slovak,
        [EnumMember(Value = "sl")]
        Slovenian,
        [EnumMember(Value = "es")]
        Spanish,
        [EnumMember(Value = "sv")]
        Swedish,
        [EnumMember(Value = "ta")]
        Tamil,
        [EnumMember(Value = "th")]
        Thai,
        [EnumMember(Value = "tr")]
        Turkish,
        [EnumMember(Value = "uk")]
        Ukrainian,
        [EnumMember(Value = "ur")]
        Urdu,
        [EnumMember(Value = "vi")]
        Vietnamese,
        [EnumMember(Value = "cy")]
        Welsh
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymyNewsDisplayInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "never")]
        Never
    }

    public class ExternalContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedExternalContent[] Contents { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("isShareable")]
        public bool IsShareable { get; set; }

        [JsonProperty("isOfficialContent")]
        public bool IsOfficialContent { get; set; }

        [JsonProperty("areCommentsAuthorized")]
        public bool AreCommentsAuthorized { get; set; }
    }

    public class LocalizedExternalContent
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("proposedCommentForSharing")]
        public string ProposedCommentForSharing { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }
    }

    public class LocalizedExternalContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("proposedCommentForSharing")]
        public string ProposedCommentForSharing { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }
    }

    public class CtaSuggestContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CtaContentTypeDiscriminator
    {
        None,
        SuggestContent,
        Mobile,
        Invitation,
        Event
    }

    public class LocalizedBaseCtaContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class LocalizedBaseCtaContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class CtaInvitationContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    public class CtaMobileContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    public class CtaEventContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("awardedBonus")]
        public int AwardedBonus { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("shouldDisplayButton")]
        public bool ShouldDisplayButton { get; set; }

        [JsonProperty("shouldDisplayTitle")]
        public bool ShouldDisplayTitle { get; set; }

        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("contents")]
        public LocalizedCtaEventContent[] Contents { get; set; }
    }

    public class LocalizedCtaEventContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("headerText")]
        public string HeaderText { get; set; }

        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }

        [JsonProperty("headerForegroundColor")]
        public string HeaderForegroundColor { get; set; }

        [JsonProperty("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("buttonForegroundColor")]
        public string ButtonForegroundColor { get; set; }

        [JsonProperty("buttonBackgroundColor")]
        public string ButtonBackgroundColor { get; set; }

        [JsonProperty("summaryForegroundColor")]
        public string SummaryForegroundColor { get; set; }
    }

    public class LocalizedCtaEventContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("headerText")]
        public string HeaderText { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("headerForegroundColor")]
        public string HeaderForegroundColor { get; set; }

        [JsonProperty("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("summaryForegroundColor")]
        public string SummaryForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("buttonForegroundColor")]
        public string ButtonForegroundColor { get; set; }

        [JsonProperty("buttonBackgroundColor")]
        public string ButtonBackgroundColor { get; set; }
    }

    public class bodycontentsInputItem
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notificationText")]
        public string NotificationText { get; set; }
    }

    public class GetAllBadgesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetBadgeLevelsResponseItem
    {
        [JsonProperty("badgeId")]
        public string BadgeId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UploadMediaResponse
    {
        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum mediaVisibilityInput
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetFoldersResponse
    {
        [JsonProperty("folders")]
        public MediaFolder[] Folders { get; set; }
    }

    public class MediaFolder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canUploadInto")]
        public bool CanUploadInto { get; set; }

        [JsonProperty("isGeneratedFolder")]
        public bool IsGeneratedFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble;

    public partial class WorkflowManagedActions
    {
        public SociabbleActions Sociabble(string connectionId) => new SociabbleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SociabbleTriggers Sociabble(string connectionId) => new SociabbleTriggers(connectionId);
    }
}