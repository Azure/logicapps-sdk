//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcmsv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcmsv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaBlogPosttobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatelanguagesofmultiLanguagegroup(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation1, ApiConnectionActionConfiguration> Retrievesapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheBlog(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> UpdateaBlogPostdraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodyblogAuthorId = WorkflowExpression.Compile(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableGoogleAmpOutputOverride = WorkflowExpression.Compile(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypostBody = WorkflowExpression.Compile(bodypostBody, nameof(bodypostBody), required: true);
            var __workflow_bodypostSummary = WorkflowExpression.Compile(bodypostSummary, nameof(bodypostSummary), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyrssBody = WorkflowExpression.Compile(bodyrssBody, nameof(bodyrssBody), required: true);
            var __workflow_bodyrssSummary = WorkflowExpression.Compile(bodyrssSummary, nameof(bodyrssSummary), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodytagIds = WorkflowExpression.Compile(bodytagIds, nameof(bodytagIds), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(__workflow_bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["postBody"] = ExpressionConverter.ConvertO(__workflow_bodypostBody);
                bodypropCount++;
                body["postSummary"] = ExpressionConverter.ConvertO(__workflow_bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = ExpressionConverter.ConvertO(__workflow_bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = ExpressionConverter.ConvertO(__workflow_bodyrssSummary);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["tagIds"] = ExpressionConverter.ConvertO(__workflow_bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Restoreapreviousversionofablogposttothedraftversionoftheblogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Createanewlanguagevariation(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> CloneaBlog(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodycloneName = WorkflowExpression.Compile(bodycloneName, nameof(bodycloneName), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["cloneName"] = ExpressionConverter.ConvertO(__workflow_bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation9, ApiConnectionActionConfiguration> GetallBlogPosts(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation9, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation9>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> CreateanewBlog(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodyblogAuthorId = WorkflowExpression.Compile(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableGoogleAmpOutputOverride = WorkflowExpression.Compile(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypostBody = WorkflowExpression.Compile(bodypostBody, nameof(bodypostBody), required: true);
            var __workflow_bodypostSummary = WorkflowExpression.Compile(bodypostSummary, nameof(bodypostSummary), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyrssBody = WorkflowExpression.Compile(bodyrssBody, nameof(bodyrssBody), required: true);
            var __workflow_bodyrssSummary = WorkflowExpression.Compile(bodyrssSummary, nameof(bodyrssSummary), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodytagIds = WorkflowExpression.Compile(bodytagIds, nameof(bodytagIds), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(__workflow_bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["postBody"] = ExpressionConverter.ConvertO(__workflow_bodypostBody);
                bodypropCount++;
                body["postSummary"] = ExpressionConverter.ConvertO(__workflow_bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = ExpressionConverter.ConvertO(__workflow_bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = ExpressionConverter.ConvertO(__workflow_bodyrssSummary);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["tagIds"] = ExpressionConverter.ConvertO(__workflow_bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Restoreapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogPostfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushBlogPostdrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogPosts(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheBlogPostdrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogPosttoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation12, ApiConnectionActionConfiguration> Retrievesallthepreviousversionsofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation12, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation12>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Setanewprimarylanguage(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlog(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> UpdateaBlog(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodyblogAuthorId = WorkflowExpression.Compile(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableGoogleAmpOutputOverride = WorkflowExpression.Compile(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypostBody = WorkflowExpression.Compile(bodypostBody, nameof(bodypostBody), required: true);
            var __workflow_bodypostSummary = WorkflowExpression.Compile(bodypostSummary, nameof(bodypostSummary), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyrssBody = WorkflowExpression.Compile(bodyrssBody, nameof(bodyrssBody), required: true);
            var __workflow_bodyrssSummary = WorkflowExpression.Compile(bodyrssSummary, nameof(bodyrssSummary), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodytagIds = WorkflowExpression.Compile(bodytagIds, nameof(bodytagIds), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(__workflow_bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["postBody"] = ExpressionConverter.ConvertO(__workflow_bodypostBody);
                bodypropCount++;
                body["postSummary"] = ExpressionConverter.ConvertO(__workflow_bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = ExpressionConverter.ConvertO(__workflow_bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = ExpressionConverter.ConvertO(__workflow_bodyrssSummary);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["tagIds"] = ExpressionConverter.ConvertO(__workflow_bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> RetrieveaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> UpdateaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<string>> bodyavatar, Expression<Func<string>> bodybio, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfacebook, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkedin, Expression<Func<string>> bodyname, Expression<Func<string>> bodyslug, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodytwitter, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodywebsite, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyavatar = WorkflowExpression.Compile(bodyavatar, nameof(bodyavatar), required: true);
            var __workflow_bodybio = WorkflowExpression.Compile(bodybio, nameof(bodybio), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfacebook = WorkflowExpression.Compile(bodyfacebook, nameof(bodyfacebook), required: true);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkedin = WorkflowExpression.Compile(bodylinkedin, nameof(bodylinkedin), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodytwitter = WorkflowExpression.Compile(bodytwitter, nameof(bodytwitter), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["avatar"] = ExpressionConverter.ConvertO(__workflow_bodyavatar);
                bodypropCount++;
                body["bio"] = ExpressionConverter.ConvertO(__workflow_bodybio);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyfacebook);
                bodypropCount++;
                body["fullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodylinkedin);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                bodypropCount++;
                body["twitter"] = ExpressionConverter.ConvertO(__workflow_bodytwitter);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogAuthorfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogAuthors(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation20, ApiConnectionActionConfiguration> GetallBlogAuthors(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation20, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation20>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> CreateanewBlogAuthor(Expression<Func<string>> bodyavatar, Expression<Func<string>> bodybio, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfacebook, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkedin, Expression<Func<string>> bodyname, Expression<Func<string>> bodyslug, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodytwitter, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodywebsite)
        {
            var __workflow_bodyavatar = WorkflowExpression.Compile(bodyavatar, nameof(bodyavatar), required: true);
            var __workflow_bodybio = WorkflowExpression.Compile(bodybio, nameof(bodybio), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfacebook = WorkflowExpression.Compile(bodyfacebook, nameof(bodyfacebook), required: true);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkedin = WorkflowExpression.Compile(bodylinkedin, nameof(bodylinkedin), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodytwitter = WorkflowExpression.Compile(bodytwitter, nameof(bodytwitter), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: true);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["avatar"] = ExpressionConverter.ConvertO(__workflow_bodyavatar);
                bodypropCount++;
                body["bio"] = ExpressionConverter.ConvertO(__workflow_bodybio);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyfacebook);
                bodypropCount++;
                body["fullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodylinkedin);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                bodypropCount++;
                body["twitter"] = ExpressionConverter.ConvertO(__workflow_bodytwitter);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation(Expression<Func<string>> bodyblogAuthoravatar, Expression<Func<string>> bodyblogAuthorbio, Expression<Func<string>> bodyblogAuthorcreated, Expression<Func<string>> bodyblogAuthordeletedAt, Expression<Func<string>> bodyblogAuthordisplayName, Expression<Func<string>> bodyblogAuthoremail, Expression<Func<string>> bodyblogAuthorfacebook, Expression<Func<string>> bodyblogAuthorfullName, Expression<Func<string>> bodyblogAuthorid, Expression<Func<string>> bodyblogAuthorlanguage, Expression<Func<string>> bodyblogAuthorlinkedin, Expression<Func<string>> bodyblogAuthorname, Expression<Func<string>> bodyblogAuthorslug, Expression<Func<string>> bodyblogAuthortranslatedFromId, Expression<Func<string>> bodyblogAuthortwitter, Expression<Func<string>> bodyblogAuthorupdated, Expression<Func<string>> bodyblogAuthorwebsite, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyblogAuthoravatar = WorkflowExpression.Compile(bodyblogAuthoravatar, nameof(bodyblogAuthoravatar), required: true);
            var __workflow_bodyblogAuthorbio = WorkflowExpression.Compile(bodyblogAuthorbio, nameof(bodyblogAuthorbio), required: true);
            var __workflow_bodyblogAuthorcreated = WorkflowExpression.Compile(bodyblogAuthorcreated, nameof(bodyblogAuthorcreated), required: true);
            var __workflow_bodyblogAuthordeletedAt = WorkflowExpression.Compile(bodyblogAuthordeletedAt, nameof(bodyblogAuthordeletedAt), required: true);
            var __workflow_bodyblogAuthordisplayName = WorkflowExpression.Compile(bodyblogAuthordisplayName, nameof(bodyblogAuthordisplayName), required: true);
            var __workflow_bodyblogAuthoremail = WorkflowExpression.Compile(bodyblogAuthoremail, nameof(bodyblogAuthoremail), required: true);
            var __workflow_bodyblogAuthorfacebook = WorkflowExpression.Compile(bodyblogAuthorfacebook, nameof(bodyblogAuthorfacebook), required: true);
            var __workflow_bodyblogAuthorfullName = WorkflowExpression.Compile(bodyblogAuthorfullName, nameof(bodyblogAuthorfullName), required: true);
            var __workflow_bodyblogAuthorid = WorkflowExpression.Compile(bodyblogAuthorid, nameof(bodyblogAuthorid), required: true);
            var __workflow_bodyblogAuthorlanguage = WorkflowExpression.Compile(bodyblogAuthorlanguage, nameof(bodyblogAuthorlanguage), required: true);
            var __workflow_bodyblogAuthorlinkedin = WorkflowExpression.Compile(bodyblogAuthorlinkedin, nameof(bodyblogAuthorlinkedin), required: true);
            var __workflow_bodyblogAuthorname = WorkflowExpression.Compile(bodyblogAuthorname, nameof(bodyblogAuthorname), required: true);
            var __workflow_bodyblogAuthorslug = WorkflowExpression.Compile(bodyblogAuthorslug, nameof(bodyblogAuthorslug), required: true);
            var __workflow_bodyblogAuthortranslatedFromId = WorkflowExpression.Compile(bodyblogAuthortranslatedFromId, nameof(bodyblogAuthortranslatedFromId), required: true);
            var __workflow_bodyblogAuthortwitter = WorkflowExpression.Compile(bodyblogAuthortwitter, nameof(bodyblogAuthortwitter), required: true);
            var __workflow_bodyblogAuthorupdated = WorkflowExpression.Compile(bodyblogAuthorupdated, nameof(bodyblogAuthorupdated), required: true);
            var __workflow_bodyblogAuthorwebsite = WorkflowExpression.Compile(bodyblogAuthorwebsite, nameof(bodyblogAuthorwebsite), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var blogAuthorObject = new JObject();
                var blogAuthorObjectpropCount = 0;
                blogAuthorObjectpropCount++;
                blogAuthorObject["avatar"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthoravatar);
                blogAuthorObjectpropCount++;
                blogAuthorObject["bio"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorbio);
                blogAuthorObjectpropCount++;
                blogAuthorObject["created"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorcreated);
                blogAuthorObjectpropCount++;
                blogAuthorObject["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthordeletedAt);
                blogAuthorObjectpropCount++;
                blogAuthorObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthordisplayName);
                blogAuthorObjectpropCount++;
                blogAuthorObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthoremail);
                blogAuthorObjectpropCount++;
                blogAuthorObject["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorfacebook);
                blogAuthorObjectpropCount++;
                blogAuthorObject["fullName"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorfullName);
                blogAuthorObjectpropCount++;
                blogAuthorObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorid);
                blogAuthorObjectpropCount++;
                blogAuthorObject["language"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorlanguage);
                blogAuthorObjectpropCount++;
                blogAuthorObject["linkedin"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorlinkedin);
                blogAuthorObjectpropCount++;
                blogAuthorObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorname);
                blogAuthorObjectpropCount++;
                blogAuthorObject["slug"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorslug);
                blogAuthorObjectpropCount++;
                blogAuthorObject["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthortranslatedFromId);
                blogAuthorObjectpropCount++;
                blogAuthorObject["twitter"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthortwitter);
                blogAuthorObjectpropCount++;
                blogAuthorObject["updated"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorupdated);
                blogAuthorObjectpropCount++;
                blogAuthorObject["website"] = ExpressionConverter.ConvertO(__workflow_bodyblogAuthorwebsite);
                if (blogAuthorObjectpropCount > 0)
                {
                    body["blogAuthor"] = blogAuthorObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogAuthortoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup1(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation23, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation23, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}/revisions", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation23>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation24, ApiConnectionActionConfiguration> RetrievesapreviousversionofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> revisionId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation24, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}/revisions/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation24>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25, ApiConnectionActionConfiguration> RetrieveaBlog(Expression<Func<string>> blogId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            return new DeferredBodyAction<Successfuloperation25, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation25>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation1(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage, Expression<Func<string>> bodyslug)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            return new DeferredBodyAction<Successfuloperation25, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation25>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation27, ApiConnectionActionConfiguration> GetallBlogs(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation27, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation27>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage1(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachablogfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachablogtoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup2(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogTagfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogTags(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage2(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation31, ApiConnectionActionConfiguration> GetallBlogTags(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation31, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation31>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> CreateanewBlogTag(Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyname, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated)
        {
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogTagtoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> RetrieveaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> UpdateaBlogTag(Expression<Func<string>> objectId, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyname, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Exportadrafttable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/export", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36, ApiConnectionActionConfiguration> Returnalldrafttables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation36, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables/draft";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation36>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Resetadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/reset", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Exportapublishedversionofatable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/export", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Cloneatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodycopyRows, Expression<Func<string>> bodynewName, Expression<Func<string>> bodynewLabel)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_bodycopyRows = WorkflowExpression.Compile(bodycopyRows, nameof(bodycopyRows), required: true);
            var __workflow_bodynewName = WorkflowExpression.Compile(bodynewName, nameof(bodynewName), required: true);
            var __workflow_bodynewLabel = WorkflowExpression.Compile(bodynewLabel, nameof(bodynewLabel), required: true);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/clone", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["copyRows"] = ExpressionConverter.ConvertO(__workflow_bodycopyRows);
                bodypropCount++;
                body["newName"] = ExpressionConverter.ConvertO(__workflow_bodynewName);
                bodypropCount++;
                body["newLabel"] = ExpressionConverter.ConvertO(__workflow_bodynewLabel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Getdetailsforapublishedtable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Archiveatable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36, ApiConnectionActionConfiguration> Getallpublishedtables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation36, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation36>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Createanewtable(Expression<Func<string>> bodylabel, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyuseForPages, Expression<Func<bool>> bodyallowPublicApiAccess, Expression<Func<bool>> bodyallowChildTables, Expression<Func<bool>> bodyenableChildTablePages, Expression<Func<Column5[]>> bodycolumns)
        {
            var __workflow_bodylabel = WorkflowExpression.Compile(bodylabel, nameof(bodylabel), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyuseForPages = WorkflowExpression.Compile(bodyuseForPages, nameof(bodyuseForPages), required: true);
            var __workflow_bodyallowPublicApiAccess = WorkflowExpression.Compile(bodyallowPublicApiAccess, nameof(bodyallowPublicApiAccess), required: true);
            var __workflow_bodyallowChildTables = WorkflowExpression.Compile(bodyallowChildTables, nameof(bodyallowChildTables), required: true);
            var __workflow_bodyenableChildTablePages = WorkflowExpression.Compile(bodyenableChildTablePages, nameof(bodyenableChildTablePages), required: true);
            var __workflow_bodycolumns = WorkflowExpression.Compile(bodycolumns, nameof(bodycolumns), required: true);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["useForPages"] = ExpressionConverter.ConvertO(__workflow_bodyuseForPages);
                bodypropCount++;
                body["allowPublicApiAccess"] = ExpressionConverter.ConvertO(__workflow_bodyallowPublicApiAccess);
                bodypropCount++;
                body["allowChildTables"] = ExpressionConverter.ConvertO(__workflow_bodyallowChildTables);
                bodypropCount++;
                body["enableChildTablePages"] = ExpressionConverter.ConvertO(__workflow_bodyenableChildTablePages);
                bodypropCount++;
                body["columns"] = ExpressionConverter.ConvertO(__workflow_bodycolumns);
                var dynamicMetaTagsObject = new JObject();
                var dynamicMetaTagsObjectpropCount = 0;
                if (dynamicMetaTagsObjectpropCount > 0)
                {
                    body["dynamicMetaTags"] = dynamicMetaTagsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Unpublishatable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/unpublish", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Getdetailsforadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Updateanexistingtable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodylabel, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyuseForPages, Expression<Func<bool>> bodyallowPublicApiAccess, Expression<Func<bool>> bodyallowChildTables, Expression<Func<bool>> bodyenableChildTablePages, Expression<Func<Column5[]>> bodycolumns, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_bodylabel = WorkflowExpression.Compile(bodylabel, nameof(bodylabel), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyuseForPages = WorkflowExpression.Compile(bodyuseForPages, nameof(bodyuseForPages), required: true);
            var __workflow_bodyallowPublicApiAccess = WorkflowExpression.Compile(bodyallowPublicApiAccess, nameof(bodyallowPublicApiAccess), required: true);
            var __workflow_bodyallowChildTables = WorkflowExpression.Compile(bodyallowChildTables, nameof(bodyallowChildTables), required: true);
            var __workflow_bodyenableChildTablePages = WorkflowExpression.Compile(bodyenableChildTablePages, nameof(bodyenableChildTablePages), required: true);
            var __workflow_bodycolumns = WorkflowExpression.Compile(bodycolumns, nameof(bodycolumns), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["useForPages"] = ExpressionConverter.ConvertO(__workflow_bodyuseForPages);
                bodypropCount++;
                body["allowPublicApiAccess"] = ExpressionConverter.ConvertO(__workflow_bodyallowPublicApiAccess);
                bodypropCount++;
                body["allowChildTables"] = ExpressionConverter.ConvertO(__workflow_bodyallowChildTables);
                bodypropCount++;
                body["enableChildTablePages"] = ExpressionConverter.ConvertO(__workflow_bodyenableChildTablePages);
                bodypropCount++;
                body["columns"] = ExpressionConverter.ConvertO(__workflow_bodycolumns);
                var dynamicMetaTagsObject = new JObject();
                var dynamicMetaTagsObjectpropCount = 0;
                if (dynamicMetaTagsObjectpropCount > 0)
                {
                    body["dynamicMetaTags"] = dynamicMetaTagsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Publishatablefromdraft(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/publish", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47, ApiConnectionActionConfiguration> Getrowsfromdrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredBodyAction<Successfuloperation47, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction<Successfuloperation47>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Getatablerow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Clonearow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft/clone", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Getarowfromthedrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Permanentlydeletesarow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Replacesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<string>> bodydisplayIndex)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodychildTableId = WorkflowExpression.Compile(bodychildTableId, nameof(bodychildTableId), required: true);
            var __workflow_bodydisplayIndex = WorkflowExpression.Compile(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var valuesObject = new JObject();
                var valuesObjectpropCount = 0;
                if (valuesObjectpropCount > 0)
                {
                    body["values"] = valuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["childTableId"] = ExpressionConverter.ConvertO(__workflow_bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = ExpressionConverter.ConvertO(__workflow_bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Updatesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<int>> bodydisplayIndex)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodychildTableId = WorkflowExpression.Compile(bodychildTableId, nameof(bodychildTableId), required: true);
            var __workflow_bodydisplayIndex = WorkflowExpression.Compile(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var valuesObject = new JObject();
                var valuesObjectpropCount = 0;
                if (valuesObjectpropCount > 0)
                {
                    body["values"] = valuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["childTableId"] = ExpressionConverter.ConvertO(__workflow_bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = ExpressionConverter.ConvertO(__workflow_bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47, ApiConnectionActionConfiguration> Getrowsforatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredBodyAction<Successfuloperation47, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction<Successfuloperation47>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Addanewrowtoatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<int>> bodydisplayIndex)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodychildTableId = WorkflowExpression.Compile(bodychildTableId, nameof(bodychildTableId), required: true);
            var __workflow_bodydisplayIndex = WorkflowExpression.Compile(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var valuesObject = new JObject();
                var valuesObjectpropCount = 0;
                if (valuesObjectpropCount > 0)
                {
                    body["values"] = valuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["childTableId"] = ExpressionConverter.ConvertO(__workflow_bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = ExpressionConverter.ConvertO(__workflow_bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Permanentlydeletesrows(Expression<Func<string>> tableIdOrName, Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft/batch/purge", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation55, ApiConnectionActionConfiguration> Clonerowsinbatch(Expression<Func<string>> tableIdOrName, Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredBodyAction<Successfuloperation55, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft/batch/clone", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation55>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61, ApiConnectionActionConfiguration> RetrievesapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation61, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation61>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaSitePagetobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachasitepagetoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachasitepagefromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation64, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation64>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaSitePagetothedraftversionoftheSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EndanactiveABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodywinnerId)
        {
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodywinnerId = WorkflowExpression.Compile(bodywinnerId, nameof(bodywinnerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["winnerId"] = ExpressionConverter.ConvertO(__workflow_bodywinnerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheSitePage(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaSitePagedraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69, ApiConnectionActionConfiguration> GetallSitePages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation69, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation69>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewSitePage(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation3(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewABtestvariation(Expression<Func<string>> bodycontentId, Expression<Func<string>> bodyvariationName)
        {
            var __workflow_bodycontentId = WorkflowExpression.Compile(bodycontentId, nameof(bodycontentId), required: true);
            var __workflow_bodyvariationName = WorkflowExpression.Compile(bodyvariationName, nameof(bodyvariationName), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contentId"] = ExpressionConverter.ConvertO(__workflow_bodycontentId);
                bodypropCount++;
                body["variationName"] = ExpressionConverter.ConvertO(__workflow_bodyvariationName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup3(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofSitePages(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CloneaSitePage(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodycloneName = WorkflowExpression.Compile(bodycloneName, nameof(bodycloneName), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["cloneName"] = ExpressionConverter.ConvertO(__workflow_bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage3(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushSitePagedrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RerunapreviousABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyvariationId)
        {
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyvariationId = WorkflowExpression.Compile(bodyvariationId, nameof(bodyvariationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["variationId"] = ExpressionConverter.ConvertO(__workflow_bodyvariationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheSitePagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrieveaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation64, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation64>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation78, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation78, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation78>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation79, ApiConnectionActionConfiguration> GetallLandingPageFolders(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation79, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation79>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> CreateanewFolder(Expression<Func<string>> bodycategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId, Expression<Func<string>> bodyupdated)
        {
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheLandingPage(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaLandingPagedraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69, ApiConnectionActionConfiguration> GetallLandingPages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation69, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation69>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewLandingPage(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CloneaLandingPage(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodycloneName = WorkflowExpression.Compile(bodycloneName, nameof(bodycloneName), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["cloneName"] = ExpressionConverter.ConvertO(__workflow_bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> RestoreapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage4(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> RetrieveaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> UpdateaFolder(Expression<Func<string>> objectId, Expression<Func<string>> bodycategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId, Expression<Func<string>> bodyupdated, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodydeletedAt = WorkflowExpression.Compile(bodydeletedAt, nameof(bodydeletedAt), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["deletedAt"] = ExpressionConverter.ConvertO(__workflow_bodydeletedAt);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewABtestvariation(Expression<Func<string>> bodycontentId, Expression<Func<string>> bodyvariationName)
        {
            var __workflow_bodycontentId = WorkflowExpression.Compile(bodycontentId, nameof(bodycontentId), required: true);
            var __workflow_bodyvariationName = WorkflowExpression.Compile(bodyvariationName, nameof(bodyvariationName), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contentId"] = ExpressionConverter.ConvertO(__workflow_bodycontentId);
                bodypropCount++;
                body["variationName"] = ExpressionConverter.ConvertO(__workflow_bodyvariationName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachalandingpagetoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61, ApiConnectionActionConfiguration> RetrievesapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation61, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation61>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEndanactiveABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodywinnerId)
        {
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodywinnerId = WorkflowExpression.Compile(bodywinnerId, nameof(bodywinnerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["winnerId"] = ExpressionConverter.ConvertO(__workflow_bodywinnerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushLandingPagedrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachalandingpagefromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaLandingPagetobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup4(Expression<Func<string>> bodyprimaryId)
        {
            var __workflow_bodyprimaryId = WorkflowExpression.Compile(bodyprimaryId, nameof(bodyprimaryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var languagesObject = new JObject();
                var languagesObjectpropCount = 0;
                if (languagesObjectpropCount > 0)
                {
                    body["languages"] = languagesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["primaryId"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostRerunapreviousABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyvariationId)
        {
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyvariationId = WorkflowExpression.Compile(bodyvariationId, nameof(bodyvariationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["variationId"] = ExpressionConverter.ConvertO(__workflow_bodyvariationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofFolders(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation97, ApiConnectionActionConfiguration> RetrievesapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation97, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation97>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheLandingPagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrieveaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_bodyabStatus = WorkflowExpression.Compile(bodyabStatus, nameof(bodyabStatus), required: true);
            var __workflow_bodyabTestId = WorkflowExpression.Compile(bodyabTestId, nameof(bodyabTestId), required: true);
            var __workflow_bodyarchivedAt = WorkflowExpression.Compile(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            var __workflow_bodyarchivedInDashboard = WorkflowExpression.Compile(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            var __workflow_bodyattachedStylesheets = WorkflowExpression.Compile(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            var __workflow_bodyauthorName = WorkflowExpression.Compile(bodyauthorName, nameof(bodyauthorName), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodycontentGroupId = WorkflowExpression.Compile(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            var __workflow_bodycontentTypeCategory = WorkflowExpression.Compile(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: true);
            var __workflow_bodycreatedById = WorkflowExpression.Compile(bodycreatedById, nameof(bodycreatedById), required: true);
            var __workflow_bodycurrentState = WorkflowExpression.Compile(bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodycurrentlyPublished = WorkflowExpression.Compile(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: true);
            var __workflow_bodydynamicPageDataSourceId = WorkflowExpression.Compile(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            var __workflow_bodydynamicPageDataSourceType = WorkflowExpression.Compile(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            var __workflow_bodydynamicPageHubDbTableId = WorkflowExpression.Compile(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            var __workflow_bodyenableDomainStylesheets = WorkflowExpression.Compile(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            var __workflow_bodyenableLayoutStylesheets = WorkflowExpression.Compile(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            var __workflow_bodyfeaturedImage = WorkflowExpression.Compile(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            var __workflow_bodyfeaturedImageAltText = WorkflowExpression.Compile(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: true);
            var __workflow_bodyhtmlTitle = WorkflowExpression.Compile(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyincludeDefaultCustomCss = WorkflowExpression.Compile(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodylinkRelCanonicalUrl = WorkflowExpression.Compile(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            var __workflow_bodymabExperimentId = WorkflowExpression.Compile(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypageExpiryDate = WorkflowExpression.Compile(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            var __workflow_bodypageExpiryEnabled = WorkflowExpression.Compile(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            var __workflow_bodypageExpiryRedirectId = WorkflowExpression.Compile(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            var __workflow_bodypageExpiryRedirectUrl = WorkflowExpression.Compile(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            var __workflow_bodypageRedirected = WorkflowExpression.Compile(bodypageRedirected, nameof(bodypageRedirected), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypublicAccessRules = WorkflowExpression.Compile(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            var __workflow_bodypublicAccessRulesEnabled = WorkflowExpression.Compile(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: true);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodysubCategory = WorkflowExpression.Compile(bodysubCategory, nameof(bodysubCategory), required: true);
            var __workflow_bodytemplatePath = WorkflowExpression.Compile(bodytemplatePath, nameof(bodytemplatePath), required: true);
            var __workflow_bodytranslatedFromId = WorkflowExpression.Compile(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: true);
            var __workflow_bodyupdatedById = WorkflowExpression.Compile(bodyupdatedById, nameof(bodyupdatedById), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyuseFeaturedImage = WorkflowExpression.Compile(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = ExpressionConverter.ConvertO(__workflow_bodyabStatus);
                bodypropCount++;
                body["abTestId"] = ExpressionConverter.ConvertO(__workflow_bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = ExpressionConverter.ConvertO(__workflow_bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = ExpressionConverter.ConvertO(__workflow_bodyauthorName);
                bodypropCount++;
                body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                bodypropCount++;
                body["createdById"] = ExpressionConverter.ConvertO(__workflow_bodycreatedById);
                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = ExpressionConverter.ConvertO(__workflow_bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(__workflow_bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(__workflow_bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlTitle);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(__workflow_bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = ExpressionConverter.ConvertO(__workflow_bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = ExpressionConverter.ConvertO(__workflow_bodypageRedirected);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(__workflow_bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["subCategory"] = ExpressionConverter.ConvertO(__workflow_bodysubCategory);
                bodypropCount++;
                body["templatePath"] = ExpressionConverter.ConvertO(__workflow_bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = ExpressionConverter.ConvertO(__workflow_bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                bodypropCount++;
                body["updatedById"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedById);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = ExpressionConverter.ConvertO(__workflow_bodyuseFeaturedImage);
                var widgetContainersObject = new JObject();
                var widgetContainersObjectpropCount = 0;
                if (widgetContainersObjectpropCount > 0)
                {
                    body["widgetContainers"] = widgetContainersObject;
                    bodypropCount++;
                }

                var widgetsObject = new JObject();
                var widgetsObjectpropCount = 0;
                if (widgetsObjectpropCount > 0)
                {
                    body["widgets"] = widgetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation4(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyprimaryLanguage = WorkflowExpression.Compile(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofLandingPages(Expression<Func<string[]>> bodyinputs)
        {
            var __workflow_bodyinputs = WorkflowExpression.Compile(bodyinputs, nameof(bodyinputs), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = ExpressionConverter.ConvertO(__workflow_bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaLandingPagetothedraftversionoftheLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }
    }

    public class Hubspotcmsv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class Successfuloperation1
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public ObjectEntity ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class ObjectEntity
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Successfuloperation3
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation9
    {
        [JsonProperty("results")]
        public Result6[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result6
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Paging
    {
        [JsonProperty("next")]
        public Next Next { get; set; }
    }

    public class Next
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Successfuloperation12
    {
        [JsonProperty("results")]
        public Result7[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result7
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object1 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object1
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Paging1
    {
        [JsonProperty("next")]
        public Next Next { get; set; }

        [JsonProperty("prev")]
        public Prev Prev { get; set; }
    }

    public class Prev
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Successfuloperation15
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class Successfuloperation20
    {
        [JsonProperty("results")]
        public Result8[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result8
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class Successfuloperation23
    {
        [JsonProperty("results")]
        public Result15[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result15
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object2 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object2
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation24
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object2 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Successfuloperation25
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation27
    {
        [JsonProperty("results")]
        public Result16[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result16
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation31
    {
        [JsonProperty("results")]
        public Result17[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result17
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation32
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation36
    {
        [JsonProperty("results")]
        public Result24[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result24
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("columns")]
        public Column[] Columns { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public UpdatedBy UpdatedBy { get; set; }

        [JsonProperty("useForPages")]
        public bool UseForPages { get; set; }

        [JsonProperty("allowChildTables")]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages")]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("isOrderedManually")]
        public bool IsOrderedManually { get; set; }

        [JsonProperty("dynamicMetaTags")]
        public JToken DynamicMetaTags { get; set; }

        [JsonProperty("allowPublicApiAccess")]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Column
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foreignIds")]
        public ForeignId[] ForeignIds { get; set; }

        [JsonProperty("foreignIdsByName")]
        public JToken ForeignIdsByName { get; set; }

        [JsonProperty("foreignIdsById")]
        public JToken ForeignIdsById { get; set; }

        [JsonProperty("optionCount")]
        public string OptionCount { get; set; }
    }

    public class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ForeignId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreatedBy
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class UpdatedBy
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class Successfuloperation37
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("columns")]
        public Column1[] Columns { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public UpdatedBy UpdatedBy { get; set; }

        [JsonProperty("useForPages")]
        public bool UseForPages { get; set; }

        [JsonProperty("allowChildTables")]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages")]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("isOrderedManually")]
        public bool IsOrderedManually { get; set; }

        [JsonProperty("dynamicMetaTags")]
        public JToken DynamicMetaTags { get; set; }

        [JsonProperty("allowPublicApiAccess")]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Column1
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foreignIds")]
        public ForeignId[] ForeignIds { get; set; }

        [JsonProperty("foreignIdsByName")]
        public JToken ForeignIdsByName { get; set; }

        [JsonProperty("foreignIdsById")]
        public JToken ForeignIdsById { get; set; }

        [JsonProperty("optionCount")]
        public string OptionCount { get; set; }
    }

    public class Column5
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }
    }

    public class Successfuloperation47
    {
        [JsonProperty("results")]
        public Result26[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result26
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class Successfuloperation48
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class Successfuloperation55
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("results")]
        public Result28[] Results { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class Result28
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class Successfuloperation61
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object4 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object4
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation63
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation64
    {
        [JsonProperty("results")]
        public Result41[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result41
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object5 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object5
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation69
    {
        [JsonProperty("results")]
        public Result44[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result44
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation78
    {
        [JsonProperty("results")]
        public Result48[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result48
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object7 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object7
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation79
    {
        [JsonProperty("results")]
        public Result49[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result49
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation80
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation97
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object7 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcmsv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotcmsv2Actions Hubspotcmsv2(string connectionId) => new Hubspotcmsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotcmsv2Triggers Hubspotcmsv2(string connectionId) => new Hubspotcmsv2Triggers(connectionId);
    }
}