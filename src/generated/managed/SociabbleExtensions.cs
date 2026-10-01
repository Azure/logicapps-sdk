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
        public IWorkflowAction SendAlertRequest([WorkflowExpression] Func<string> bodyalertText, [WorkflowExpression] Func<string> bodyalertTitle, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<bool> bodyisMandatory = null, [WorkflowExpression] Func<bool> bodysendSMS = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alerts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["alertText"] = SourceExpressionConverter.ConvertToken(bodyalertText);
                bodypropCount++;
                body["alertTitle"] = SourceExpressionConverter.ConvertToken(bodyalertTitle);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyisMandatory != null)
                {
                    body["isMandatory"] = SourceExpressionConverter.ConvertToken(bodyisMandatory);
                    bodypropCount++;
                }

                if (bodysendSMS != null)
                {
                    body["sendSMS"] = SourceExpressionConverter.ConvertToken(bodysendSMS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAudiencesResponseItem[]> GetAudiences()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/companies/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAudiencesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetChannelsResponseItem[]> GetChannels()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetChannelsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetCategoriesResponseItem[]> GetCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCategoriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<InternalContent> CreateInternalNews([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedInternalContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null, [WorkflowExpression] Func<bool> bodyareCommentsAuthorized = null, [WorkflowExpression] Func<bool> bodyshouldNotifyUsers = null, [WorkflowExpression] Func<bool> bodyisMustReadContent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/internalnews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = SourceExpressionConverter.ConvertToken(bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = SourceExpressionConverter.ConvertToken(bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = SourceExpressionConverter.ConvertToken(bodyisMustReadContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InternalContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<ExternalContent> CreateExternalContent([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedExternalContentCreation[]> bodycontents, [WorkflowExpression] Func<string> bodycontentUrl, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null, [WorkflowExpression] Func<bool> bodyisShareable = null, [WorkflowExpression] Func<bool> bodyisOfficialContent = null, [WorkflowExpression] Func<bool> bodyareCommentsAuthorized = null, [WorkflowExpression] Func<bool> bodyshouldNotifyUsers = null, [WorkflowExpression] Func<bool> bodyisMustReadContent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                bodypropCount++;
                body["contentUrl"] = SourceExpressionConverter.ConvertToken(bodycontentUrl);
                if (bodyisShareable != null)
                {
                    body["isShareable"] = SourceExpressionConverter.ConvertToken(bodyisShareable);
                    bodypropCount++;
                }

                if (bodyisOfficialContent != null)
                {
                    body["isOfficialContent"] = SourceExpressionConverter.ConvertToken(bodyisOfficialContent);
                    bodypropCount++;
                }

                if (bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = SourceExpressionConverter.ConvertToken(bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = SourceExpressionConverter.ConvertToken(bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = SourceExpressionConverter.ConvertToken(bodyisMustReadContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExternalContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaSuggestContent> CtaSuggestContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/Cta/Suggest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "SuggestContent";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CtaSuggestContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaInvitationContent> CtaInvitationContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/Cta/Invitation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Invitation";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CtaInvitationContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaMobileContent> CtaMobileContentCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedBaseCtaContentCreation[]> bodycontents, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/Cta/Mobile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["discriminator"] = "Cta";
                bodypropCount++;
                bodypropCount++;
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Mobile";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CtaMobileContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaEventContent> CtaEventCreation([WorkflowExpression] Func<string[]> bodychannelIds, [WorkflowExpression] Func<LocalizedCtaEventContentCreation[]> bodycontents, [WorkflowExpression] Func<string> bodyaudienceId = null, [WorkflowExpression] Func<string[]> bodycategoryIds = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<int> bodyawardedBonus = null, [WorkflowExpression] Func<bool> bodyshouldDisplayTitle = null, [WorkflowExpression] Func<bool> bodyshouldDisplayButton = null, [WorkflowExpression] Func<string> bodypublicationStartDate = null, [WorkflowExpression] Func<string> bodypublicationEndDate = null, [WorkflowExpression] Func<bodymyNewsDisplayInput> bodymyNewsDisplay = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfMyNews = null, [WorkflowExpression] Func<string> bodypinOfMyNewsStartDate = null, [WorkflowExpression] Func<string> bodypinOfMyNewsEndDate = null, [WorkflowExpression] Func<bool> bodyshouldPinTopOfSelectedChannels = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsStartDate = null, [WorkflowExpression] Func<string> bodypinTopOfSelectedChannelsEndDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                body["channelIds"] = SourceExpressionConverter.ConvertToken(bodychannelIds);
                if (bodyaudienceId != null)
                {
                    body["audienceId"] = SourceExpressionConverter.ConvertToken(bodyaudienceId);
                    bodypropCount++;
                }

                if (bodycategoryIds != null)
                {
                    body["categoryIds"] = SourceExpressionConverter.ConvertToken(bodycategoryIds);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodyawardedBonus != null)
                {
                    body["awardedBonus"] = SourceExpressionConverter.ConvertToken(bodyawardedBonus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodyshouldDisplayTitle != null)
                {
                    body["shouldDisplayTitle"] = SourceExpressionConverter.ConvertToken(bodyshouldDisplayTitle);
                    bodypropCount++;
                }

                if (bodyshouldDisplayButton != null)
                {
                    body["shouldDisplayButton"] = SourceExpressionConverter.ConvertToken(bodyshouldDisplayButton);
                    bodypropCount++;
                }

                if (bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = SourceExpressionConverter.ConvertToken(bodypublicationStartDate);
                    bodypropCount++;
                }

                if (bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = SourceExpressionConverter.ConvertToken(bodypublicationEndDate);
                    bodypropCount++;
                }

                if (bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = SourceExpressionConverter.Convert(bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = SourceExpressionConverter.ConvertToken(bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = SourceExpressionConverter.ConvertToken(bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CtaEventContent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction AssignBadgeToUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> bodybadgeId, [WorkflowExpression] Func<int> bodylevel)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/badges/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["badgeId"] = SourceExpressionConverter.ConvertToken(bodybadgeId);
                bodypropCount++;
                body["level"] = SourceExpressionConverter.ConvertToken(bodylevel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction AssignCustomActionToUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents, [WorkflowExpression] Func<bool> bodyisEngaging = null, [WorkflowExpression] Func<bool> bodyisInternal = null, [WorkflowExpression] Func<int> bodypoints = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/customactions/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisEngaging != null)
                {
                    body["isEngaging"] = SourceExpressionConverter.ConvertToken(bodyisEngaging);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = SourceExpressionConverter.ConvertToken(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypoints != null)
                {
                    body["points"] = SourceExpressionConverter.ConvertToken(bodypoints);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAllBadgesResponseItem[]> GetAllBadges()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/badges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllBadgesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[]> GetBadgeLevels([WorkflowExpression] Func<string> badgeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/badges/{0}/levels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(badgeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBadgeLevelsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetFoldersResponse> GetMediaDriveFolders([WorkflowExpression] Func<string> culture = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mediadrive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["culture"] = Convert.ToString("en");
                if (culture != null)
                    callPayload.Queries["culture"] = SourceExpressionConverter.ConvertO(culture);
                return callPayload;
            }

            return new ApiConnectionAction<GetFoldersResponse>(BuildSourceInput);
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