//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SociabbleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction SendAlertRequest(Expression<Func<string>> bodyalertText, Expression<Func<string>> bodyalertTitle, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodyusername = null, Expression<Func<bool>> bodyisMandatory = null, Expression<Func<bool>> bodysendSMS = null)
        {
            var __workflow_bodyalertText = bodyalertText == null ? null : WorkflowExpression.Compile(bodyalertText);
            WorkflowExpression.Validate(__workflow_bodyalertText, nameof(bodyalertText), required: true);
            var __workflow_bodyalertTitle = bodyalertTitle == null ? null : WorkflowExpression.Compile(bodyalertTitle);
            WorkflowExpression.Validate(__workflow_bodyalertTitle, nameof(bodyalertTitle), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyisMandatory = bodyisMandatory == null ? null : WorkflowExpression.Compile(bodyisMandatory);
            WorkflowExpression.Validate(__workflow_bodyisMandatory, nameof(bodyisMandatory), required: false);
            var __workflow_bodysendSMS = bodysendSMS == null ? null : WorkflowExpression.Compile(bodysendSMS);
            WorkflowExpression.Validate(__workflow_bodysendSMS, nameof(bodysendSMS), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/alerts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["alertText"] = ExpressionConverter.ConvertO(__workflow_bodyalertText);
                bodypropCount++;
                body["alertTitle"] = ExpressionConverter.ConvertO(__workflow_bodyalertTitle);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodyisMandatory != null)
                {
                    body["isMandatory"] = ExpressionConverter.ConvertO(__workflow_bodyisMandatory);
                    bodypropCount++;
                }

                if (__workflow_bodysendSMS != null)
                {
                    body["sendSMS"] = ExpressionConverter.ConvertO(__workflow_bodysendSMS);
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
        public IBodyWorkflowAction<InternalContent> CreateInternalNews(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedInternalContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null, Expression<Func<bool>> bodyareCommentsAuthorized = null, Expression<Func<bool>> bodyshouldNotifyUsers = null, Expression<Func<bool>> bodyisMustReadContent = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            var __workflow_bodyareCommentsAuthorized = bodyareCommentsAuthorized == null ? null : WorkflowExpression.Compile(bodyareCommentsAuthorized);
            WorkflowExpression.Validate(__workflow_bodyareCommentsAuthorized, nameof(bodyareCommentsAuthorized), required: false);
            var __workflow_bodyshouldNotifyUsers = bodyshouldNotifyUsers == null ? null : WorkflowExpression.Compile(bodyshouldNotifyUsers);
            WorkflowExpression.Validate(__workflow_bodyshouldNotifyUsers, nameof(bodyshouldNotifyUsers), required: false);
            var __workflow_bodyisMustReadContent = bodyisMustReadContent == null ? null : WorkflowExpression.Compile(bodyisMustReadContent);
            WorkflowExpression.Validate(__workflow_bodyisMustReadContent, nameof(bodyisMustReadContent), required: false);
            return new DeferredBodyAction<InternalContent>(() =>
            {
                var apiCallPath = "/content/internalnews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                if (__workflow_bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = ExpressionConverter.ConvertO(__workflow_bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = ExpressionConverter.ConvertO(__workflow_bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = ExpressionConverter.ConvertO(__workflow_bodyisMustReadContent);
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
        public IBodyWorkflowAction<ExternalContent> CreateExternalContent(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedExternalContentCreation[]>> bodycontents, Expression<Func<string>> bodycontentUrl, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null, Expression<Func<bool>> bodyisShareable = null, Expression<Func<bool>> bodyisOfficialContent = null, Expression<Func<bool>> bodyareCommentsAuthorized = null, Expression<Func<bool>> bodyshouldNotifyUsers = null, Expression<Func<bool>> bodyisMustReadContent = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodycontentUrl = bodycontentUrl == null ? null : WorkflowExpression.Compile(bodycontentUrl);
            WorkflowExpression.Validate(__workflow_bodycontentUrl, nameof(bodycontentUrl), required: true);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
            var __workflow_bodyisShareable = bodyisShareable == null ? null : WorkflowExpression.Compile(bodyisShareable);
            WorkflowExpression.Validate(__workflow_bodyisShareable, nameof(bodyisShareable), required: false);
            var __workflow_bodyisOfficialContent = bodyisOfficialContent == null ? null : WorkflowExpression.Compile(bodyisOfficialContent);
            WorkflowExpression.Validate(__workflow_bodyisOfficialContent, nameof(bodyisOfficialContent), required: false);
            var __workflow_bodyareCommentsAuthorized = bodyareCommentsAuthorized == null ? null : WorkflowExpression.Compile(bodyareCommentsAuthorized);
            WorkflowExpression.Validate(__workflow_bodyareCommentsAuthorized, nameof(bodyareCommentsAuthorized), required: false);
            var __workflow_bodyshouldNotifyUsers = bodyshouldNotifyUsers == null ? null : WorkflowExpression.Compile(bodyshouldNotifyUsers);
            WorkflowExpression.Validate(__workflow_bodyshouldNotifyUsers, nameof(bodyshouldNotifyUsers), required: false);
            var __workflow_bodyisMustReadContent = bodyisMustReadContent == null ? null : WorkflowExpression.Compile(bodyisMustReadContent);
            WorkflowExpression.Validate(__workflow_bodyisMustReadContent, nameof(bodyisMustReadContent), required: false);
            return new DeferredBodyAction<ExternalContent>(() =>
            {
                var apiCallPath = "/content/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                bodypropCount++;
                body["contentUrl"] = ExpressionConverter.ConvertO(__workflow_bodycontentUrl);
                if (__workflow_bodyisShareable != null)
                {
                    body["isShareable"] = ExpressionConverter.ConvertO(__workflow_bodyisShareable);
                    bodypropCount++;
                }

                if (__workflow_bodyisOfficialContent != null)
                {
                    body["isOfficialContent"] = ExpressionConverter.ConvertO(__workflow_bodyisOfficialContent);
                    bodypropCount++;
                }

                if (__workflow_bodyareCommentsAuthorized != null)
                {
                    body["areCommentsAuthorized"] = ExpressionConverter.ConvertO(__workflow_bodyareCommentsAuthorized);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldNotifyUsers != null)
                {
                    body["shouldNotifyUsers"] = ExpressionConverter.ConvertO(__workflow_bodyshouldNotifyUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyisMustReadContent != null)
                {
                    body["isMustReadContent"] = ExpressionConverter.ConvertO(__workflow_bodyisMustReadContent);
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
        public IBodyWorkflowAction<CtaSuggestContent> CtaSuggestContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
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
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "SuggestContent";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaSuggestContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaInvitationContent> CtaInvitationContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
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
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Invitation";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaInvitationContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaMobileContent> CtaMobileContentCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedBaseCtaContentCreation[]>> bodycontents, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
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
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
                    bodypropCount++;
                }

                body["ctaDiscriminator"] = "Mobile";
                bodypropCount++;
                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CtaMobileContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaEventContent> CtaEventCreation(Expression<Func<string[]>> bodychannelIds, Expression<Func<LocalizedCtaEventContentCreation[]>> bodycontents, Expression<Func<string>> bodyaudienceId = null, Expression<Func<string[]>> bodycategoryIds = null, Expression<Func<string>> bodylink = null, Expression<Func<int>> bodyawardedBonus = null, Expression<Func<bool>> bodyshouldDisplayTitle = null, Expression<Func<bool>> bodyshouldDisplayButton = null, Expression<Func<string>> bodypublicationStartDate = null, Expression<Func<string>> bodypublicationEndDate = null, Expression<Func<bodymyNewsDisplayInput>> bodymyNewsDisplay = null, Expression<Func<bool>> bodyshouldPinTopOfMyNews = null, Expression<Func<string>> bodypinOfMyNewsStartDate = null, Expression<Func<string>> bodypinOfMyNewsEndDate = null, Expression<Func<bool>> bodyshouldPinTopOfSelectedChannels = null, Expression<Func<string>> bodypinTopOfSelectedChannelsStartDate = null, Expression<Func<string>> bodypinTopOfSelectedChannelsEndDate = null)
        {
            var __workflow_bodychannelIds = bodychannelIds == null ? null : WorkflowExpression.Compile(bodychannelIds);
            WorkflowExpression.Validate(__workflow_bodychannelIds, nameof(bodychannelIds), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodyaudienceId = bodyaudienceId == null ? null : WorkflowExpression.Compile(bodyaudienceId);
            WorkflowExpression.Validate(__workflow_bodyaudienceId, nameof(bodyaudienceId), required: false);
            var __workflow_bodycategoryIds = bodycategoryIds == null ? null : WorkflowExpression.Compile(bodycategoryIds);
            WorkflowExpression.Validate(__workflow_bodycategoryIds, nameof(bodycategoryIds), required: false);
            var __workflow_bodylink = bodylink == null ? null : WorkflowExpression.Compile(bodylink);
            WorkflowExpression.Validate(__workflow_bodylink, nameof(bodylink), required: false);
            var __workflow_bodyawardedBonus = bodyawardedBonus == null ? null : WorkflowExpression.Compile(bodyawardedBonus);
            WorkflowExpression.Validate(__workflow_bodyawardedBonus, nameof(bodyawardedBonus), required: false);
            var __workflow_bodyshouldDisplayTitle = bodyshouldDisplayTitle == null ? null : WorkflowExpression.Compile(bodyshouldDisplayTitle);
            WorkflowExpression.Validate(__workflow_bodyshouldDisplayTitle, nameof(bodyshouldDisplayTitle), required: false);
            var __workflow_bodyshouldDisplayButton = bodyshouldDisplayButton == null ? null : WorkflowExpression.Compile(bodyshouldDisplayButton);
            WorkflowExpression.Validate(__workflow_bodyshouldDisplayButton, nameof(bodyshouldDisplayButton), required: false);
            var __workflow_bodypublicationStartDate = bodypublicationStartDate == null ? null : WorkflowExpression.Compile(bodypublicationStartDate);
            WorkflowExpression.Validate(__workflow_bodypublicationStartDate, nameof(bodypublicationStartDate), required: false);
            var __workflow_bodypublicationEndDate = bodypublicationEndDate == null ? null : WorkflowExpression.Compile(bodypublicationEndDate);
            WorkflowExpression.Validate(__workflow_bodypublicationEndDate, nameof(bodypublicationEndDate), required: false);
            var __workflow_bodymyNewsDisplay = bodymyNewsDisplay == null ? null : WorkflowExpression.Compile(bodymyNewsDisplay);
            WorkflowExpression.Validate(__workflow_bodymyNewsDisplay, nameof(bodymyNewsDisplay), required: false);
            var __workflow_bodyshouldPinTopOfMyNews = bodyshouldPinTopOfMyNews == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfMyNews);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfMyNews, nameof(bodyshouldPinTopOfMyNews), required: false);
            var __workflow_bodypinOfMyNewsStartDate = bodypinOfMyNewsStartDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsStartDate, nameof(bodypinOfMyNewsStartDate), required: false);
            var __workflow_bodypinOfMyNewsEndDate = bodypinOfMyNewsEndDate == null ? null : WorkflowExpression.Compile(bodypinOfMyNewsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinOfMyNewsEndDate, nameof(bodypinOfMyNewsEndDate), required: false);
            var __workflow_bodyshouldPinTopOfSelectedChannels = bodyshouldPinTopOfSelectedChannels == null ? null : WorkflowExpression.Compile(bodyshouldPinTopOfSelectedChannels);
            WorkflowExpression.Validate(__workflow_bodyshouldPinTopOfSelectedChannels, nameof(bodyshouldPinTopOfSelectedChannels), required: false);
            var __workflow_bodypinTopOfSelectedChannelsStartDate = bodypinTopOfSelectedChannelsStartDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsStartDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsStartDate, nameof(bodypinTopOfSelectedChannelsStartDate), required: false);
            var __workflow_bodypinTopOfSelectedChannelsEndDate = bodypinTopOfSelectedChannelsEndDate == null ? null : WorkflowExpression.Compile(bodypinTopOfSelectedChannelsEndDate);
            WorkflowExpression.Validate(__workflow_bodypinTopOfSelectedChannelsEndDate, nameof(bodypinTopOfSelectedChannelsEndDate), required: false);
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
                body["channelIds"] = ExpressionConverter.ConvertO(__workflow_bodychannelIds);
                if (__workflow_bodyaudienceId != null)
                {
                    body["audienceId"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceId);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryIds != null)
                {
                    body["categoryIds"] = ExpressionConverter.ConvertO(__workflow_bodycategoryIds);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodyawardedBonus != null)
                {
                    body["awardedBonus"] = ExpressionConverter.ConvertO(__workflow_bodyawardedBonus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                if (__workflow_bodyshouldDisplayTitle != null)
                {
                    body["shouldDisplayTitle"] = ExpressionConverter.ConvertO(__workflow_bodyshouldDisplayTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldDisplayButton != null)
                {
                    body["shouldDisplayButton"] = ExpressionConverter.ConvertO(__workflow_bodyshouldDisplayButton);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationStartDate != null)
                {
                    body["publicationStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublicationEndDate != null)
                {
                    body["publicationEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypublicationEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodymyNewsDisplay != null)
                {
                    body["myNewsDisplay"] = ExpressionConverter.ConvertO(__workflow_bodymyNewsDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfMyNews != null)
                {
                    body["shouldPinTopOfMyNews"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfMyNews);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsStartDate != null)
                {
                    body["pinOfMyNewsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinOfMyNewsEndDate != null)
                {
                    body["pinOfMyNewsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinOfMyNewsEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshouldPinTopOfSelectedChannels != null)
                {
                    body["shouldPinTopOfSelectedChannels"] = ExpressionConverter.ConvertO(__workflow_bodyshouldPinTopOfSelectedChannels);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsStartDate != null)
                {
                    body["pinTopOfSelectedChannelsStartDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodypinTopOfSelectedChannelsEndDate != null)
                {
                    body["pinTopOfSelectedChannelsEndDate"] = ExpressionConverter.ConvertO(__workflow_bodypinTopOfSelectedChannelsEndDate);
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
        public IWorkflowAction AssignBadgeToUser(Expression<Func<string>> username, Expression<Func<string>> bodybadgeId, Expression<Func<int>> bodylevel)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_bodybadgeId = bodybadgeId == null ? null : WorkflowExpression.Compile(bodybadgeId);
            WorkflowExpression.Validate(__workflow_bodybadgeId, nameof(bodybadgeId), required: true);
            var __workflow_bodylevel = bodylevel == null ? null : WorkflowExpression.Compile(bodylevel);
            WorkflowExpression.Validate(__workflow_bodylevel, nameof(bodylevel), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/badges/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["badgeId"] = ExpressionConverter.ConvertO(__workflow_bodybadgeId);
                bodypropCount++;
                body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction AssignCustomActionToUser(Expression<Func<string>> username, Expression<Func<bodycontentsInputItem[]>> bodycontents, Expression<Func<bool>> bodyisEngaging = null, Expression<Func<bool>> bodyisInternal = null, Expression<Func<int>> bodypoints = null)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_bodycontents = bodycontents == null ? null : WorkflowExpression.Compile(bodycontents);
            WorkflowExpression.Validate(__workflow_bodycontents, nameof(bodycontents), required: true);
            var __workflow_bodyisEngaging = bodyisEngaging == null ? null : WorkflowExpression.Compile(bodyisEngaging);
            WorkflowExpression.Validate(__workflow_bodyisEngaging, nameof(bodyisEngaging), required: false);
            var __workflow_bodyisInternal = bodyisInternal == null ? null : WorkflowExpression.Compile(bodyisInternal);
            WorkflowExpression.Validate(__workflow_bodyisInternal, nameof(bodyisInternal), required: false);
            var __workflow_bodypoints = bodypoints == null ? null : WorkflowExpression.Compile(bodypoints);
            WorkflowExpression.Validate(__workflow_bodypoints, nameof(bodypoints), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/customactions/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisEngaging != null)
                {
                    body["isEngaging"] = ExpressionConverter.ConvertO(__workflow_bodyisEngaging);
                    bodypropCount++;
                }

                if (__workflow_bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(__workflow_bodyisInternal);
                    bodypropCount++;
                }

                if (__workflow_bodypoints != null)
                {
                    body["points"] = ExpressionConverter.ConvertO(__workflow_bodypoints);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
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
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[]> GetBadgeLevels(Expression<Func<string>> badgeId)
        {
            var __workflow_badgeId = badgeId == null ? null : WorkflowExpression.Compile(badgeId);
            WorkflowExpression.Validate(__workflow_badgeId, nameof(badgeId), required: true);
            return new DeferredBodyAction<GetBadgeLevelsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/badges/{0}/levels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_badgeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBadgeLevelsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStream(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<object>> media)
        {
            var __workflow_mediaVisibility = mediaVisibility == null ? null : WorkflowExpression.Compile(mediaVisibility);
            WorkflowExpression.Validate(__workflow_mediaVisibility, nameof(mediaVisibility), required: true);
            var __workflow_media = media == null ? null : WorkflowExpression.Compile(media);
            WorkflowExpression.Validate(__workflow_media, nameof(media), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByStream";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrl(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> mediaUrl)
        {
            var __workflow_mediaVisibility = mediaVisibility == null ? null : WorkflowExpression.Compile(mediaVisibility);
            WorkflowExpression.Validate(__workflow_mediaVisibility, nameof(mediaVisibility), required: true);
            var __workflow_mediaUrl = mediaUrl == null ? null : WorkflowExpression.Compile(mediaUrl);
            WorkflowExpression.Validate(__workflow_mediaUrl, nameof(mediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByStreamByFolder(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> folderId, Expression<Func<object>> media)
        {
            var __workflow_mediaVisibility = mediaVisibility == null ? null : WorkflowExpression.Compile(mediaVisibility);
            WorkflowExpression.Validate(__workflow_mediaVisibility, nameof(mediaVisibility), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_media = media == null ? null : WorkflowExpression.Compile(media);
            WorkflowExpression.Validate(__workflow_media, nameof(media), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByStreamByFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaByUrlByFolder(Expression<Func<mediaVisibilityInput>> mediaVisibility, Expression<Func<string>> folderId, Expression<Func<string>> mediaUrl)
        {
            var __workflow_mediaVisibility = mediaVisibility == null ? null : WorkflowExpression.Compile(mediaVisibility);
            WorkflowExpression.Validate(__workflow_mediaVisibility, nameof(mediaVisibility), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_mediaUrl = mediaUrl == null ? null : WorkflowExpression.Compile(mediaUrl);
            WorkflowExpression.Validate(__workflow_mediaUrl, nameof(mediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/medias/ByUrlByFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetFoldersResponse> GetMediaDriveFolders(Expression<Func<string>> culture = null)
        {
            var __workflow_culture = culture == null ? null : WorkflowExpression.Compile(culture);
            WorkflowExpression.Validate(__workflow_culture, nameof(culture), required: false);
            return new DeferredBodyAction<GetFoldersResponse>(() =>
            {
                var apiCallPath = "/mediadrive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["culture"] = Convert.ToString("en");
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
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
