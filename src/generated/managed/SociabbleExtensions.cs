//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SociabbleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction SendAlertRequest(Expression<Func<string>> bodyalertText, Expression<Func<string>> bodyalertTitle, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodyusername = null, Expression<Func<bool>> bodyisMandatory = null, Expression<Func<bool>> bodysendSMS = null)
        {
            var apiCallPath = "/alerts/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["alertText"] = CSharpExpressionConverter.ConvertToken(bodyalertText);
            bodypropCount++;
            body["alertTitle"] = CSharpExpressionConverter.ConvertToken(bodyalertTitle);
            if (bodystartDate != null)
            {
                body["startDate"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
            }

            if (bodyisMandatory != null)
            {
                body["isMandatory"] = CSharpExpressionConverter.ConvertToken(bodyisMandatory);
                bodypropCount++;
            }

            if (bodysendSMS != null)
            {
                body["sendSMS"] = CSharpExpressionConverter.ConvertToken(bodysendSMS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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
        public IBodyWorkflowAction<InternalContent> CreateInternalNews(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedInternalContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null, Expression<Func<bool>> bodyareCommentsAuthorized = null, Expression<Func<bool>> bodyshouldNotifyUsers = null, Expression<Func<bool>> bodyisMustReadContent = null)
        {
            var apiCallPath = "/content/internalnews";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodyareCommentsAuthorized != null)
            {
                body["areCommentsAuthorized"] = CSharpExpressionConverter.ConvertToken(bodyareCommentsAuthorized);
                bodypropCount++;
            }

            if (bodyshouldNotifyUsers != null)
            {
                body["shouldNotifyUsers"] = CSharpExpressionConverter.ConvertToken(bodyshouldNotifyUsers);
                bodypropCount++;
            }

            if (bodyisMustReadContent != null)
            {
                body["isMustReadContent"] = CSharpExpressionConverter.ConvertToken(bodyisMustReadContent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InternalContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<ExternalContent> CreateExternalContent(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedExternalContentCreation[]>> bodycontents, Expression<Func<string>> bodycontentUrl, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null, Expression<Func<bool>> bodyisShareable = null, Expression<Func<bool>> bodyisOfficialContent = null, Expression<Func<bool>> bodyareCommentsAuthorized = null, Expression<Func<bool>> bodyshouldNotifyUsers = null, Expression<Func<bool>> bodyisMustReadContent = null)
        {
            var apiCallPath = "/content/external";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            bodypropCount++;
            body["contentUrl"] = CSharpExpressionConverter.ConvertToken(bodycontentUrl);
            if (bodyisShareable != null)
            {
                body["isShareable"] = CSharpExpressionConverter.ConvertToken(bodyisShareable);
                bodypropCount++;
            }

            if (bodyisOfficialContent != null)
            {
                body["isOfficialContent"] = CSharpExpressionConverter.ConvertToken(bodyisOfficialContent);
                bodypropCount++;
            }

            if (bodyareCommentsAuthorized != null)
            {
                body["areCommentsAuthorized"] = CSharpExpressionConverter.ConvertToken(bodyareCommentsAuthorized);
                bodypropCount++;
            }

            if (bodyshouldNotifyUsers != null)
            {
                body["shouldNotifyUsers"] = CSharpExpressionConverter.ConvertToken(bodyshouldNotifyUsers);
                bodypropCount++;
            }

            if (bodyisMustReadContent != null)
            {
                body["isMustReadContent"] = CSharpExpressionConverter.ConvertToken(bodyisMustReadContent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExternalContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaSuggestContent> CtaSuggestContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var apiCallPath = "/content/Cta/Suggest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["discriminator"] = "Cta";
            bodypropCount++;
            bodypropCount++;
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            body["ctaDiscriminator"] = "SuggestContent";
            bodypropCount++;
            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CtaSuggestContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaInvitationContent> CtaInvitationContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var apiCallPath = "/content/Cta/Invitation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["discriminator"] = "Cta";
            bodypropCount++;
            bodypropCount++;
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            body["ctaDiscriminator"] = "Invitation";
            bodypropCount++;
            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CtaInvitationContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaMobileContent> CtaMobileContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var apiCallPath = "/content/Cta/Mobile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["discriminator"] = "Cta";
            bodypropCount++;
            bodypropCount++;
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            body["ctaDiscriminator"] = "Mobile";
            bodypropCount++;
            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CtaMobileContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaEventContent> CtaEventCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedCtaEventContentCreation[]>> bodycontents, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodylink = null, Expression<Func<int>> bodyawardedBonus = null, Expression<Func<bool>> bodyshouldDisplayTitle = null, Expression<Func<bool>> bodyshouldDisplayButton = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
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
            body["channelIds"] = CSharpExpressionConverter.ConvertToken(bodychannelIds);
            if (bodyaudienceId != null)
            {
                body["audienceId"] = CSharpExpressionConverter.ConvertToken(bodyaudienceId);
                bodypropCount++;
            }

            if (bodycategoryIds != null)
            {
                body["categoryIds"] = CSharpExpressionConverter.ConvertToken(bodycategoryIds);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["link"] = CSharpExpressionConverter.ConvertToken(bodylink);
                bodypropCount++;
            }

            if (bodyawardedBonus != null)
            {
                body["awardedBonus"] = CSharpExpressionConverter.ConvertToken(bodyawardedBonus);
                bodypropCount++;
            }

            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodyshouldDisplayTitle != null)
            {
                body["shouldDisplayTitle"] = CSharpExpressionConverter.ConvertToken(bodyshouldDisplayTitle);
                bodypropCount++;
            }

            if (bodyshouldDisplayButton != null)
            {
                body["shouldDisplayButton"] = CSharpExpressionConverter.ConvertToken(bodyshouldDisplayButton);
                bodypropCount++;
            }

            if (bodypublicationStartDate != null)
            {
                body["publicationStartDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationStartDate);
                bodypropCount++;
            }

            if (bodypublicationEndDate != null)
            {
                body["publicationEndDate"] = CSharpExpressionConverter.ConvertToken(bodypublicationEndDate);
                bodypropCount++;
            }

            if (bodymyNewsDisplay != null)
            {
                body["myNewsDisplay"] = CSharpExpressionConverter.Convert(bodymyNewsDisplay);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfMyNews != null)
            {
                body["shouldPinTopOfMyNews"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                bodypropCount++;
            }

            if (bodypinOfMyNewsStartDate != null)
            {
                body["pinOfMyNewsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                bodypropCount++;
            }

            if (bodypinOfMyNewsEndDate != null)
            {
                body["pinOfMyNewsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                bodypropCount++;
            }

            if (bodyshouldPinTopOfSelectedChannels != null)
            {
                body["shouldPinTopOfSelectedChannels"] = CSharpExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsStartDate != null)
            {
                body["pinTopOfSelectedChannelsStartDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                bodypropCount++;
            }

            if (bodypinTopOfSelectedChannelsEndDate != null)
            {
                body["pinTopOfSelectedChannelsEndDate"] = CSharpExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CtaEventContent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction AssignBadgeToUser(Expression<Func<string>> username, Expression<Func<string>> bodybadgeId, Expression<Func<int>> bodylevel)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}/badges/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["badgeId"] = CSharpExpressionConverter.ConvertToken(bodybadgeId);
            bodypropCount++;
            body["level"] = CSharpExpressionConverter.ConvertToken(bodylevel);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction AssignCustomActionToUser(Expression<Func<string>> username, Expression<Func<bodycontentsInputItem[]>> bodycontents, Expression<Func<bool>> bodyisEngaging = null, Expression<Func<bool>> bodyisInternal = null, Expression<Func<int>> bodypoints = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/users/{0}/customactions/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyisEngaging != null)
            {
                body["isEngaging"] = CSharpExpressionConverter.ConvertToken(bodyisEngaging);
                bodypropCount++;
            }

            if (bodyisInternal != null)
            {
                body["isInternal"] = CSharpExpressionConverter.ConvertToken(bodyisInternal);
                bodypropCount++;
            }

            if (bodypoints != null)
            {
                body["points"] = CSharpExpressionConverter.ConvertToken(bodypoints);
                bodypropCount++;
            }

            bodypropCount++;
            body["contents"] = CSharpExpressionConverter.ConvertToken(bodycontents);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[]> GetBadgeLevels(Expression<Func<string>> badgeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/badges/{0}/levels", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(badgeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBadgeLevelsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStream(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<object>> media)
        {
            var apiCallPath = "/medias/ByStream";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrl(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> mediaUrl)
        {
            var apiCallPath = "/medias/ByUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStreamByFolder(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> folderId, Expression<Func<object>> media)
        {
            var apiCallPath = "/medias/ByStreamByFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrlByFolder(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> folderId, Expression<Func<string>> mediaUrl)
        {
            var apiCallPath = "/medias/ByUrlByFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetFoldersResponse> GetMediaDriveFolders(Expression<Func<string>> culture = null)
        {
            var apiCallPath = "/mediadrive";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["culture"] = Convert.ToString("en");
            if (culture != null)
                callPayload.Queries["culture"] = CSharpExpressionConverter.ConvertO(culture);
            return new ApiConnectionAction<GetFoldersResponse>(callPayload);
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