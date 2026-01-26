//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcmsv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcmsv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ScheduleaBlogPosttobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var apiCallPath = "/blogs/posts/schedule";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction UpdatelanguagesofmultiLanguagegroup(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation1> Retrievesapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/revisions/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> RetrievethefulldraftversionoftheBlogPost(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> UpdateaBlogPostdraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["blogAuthorId"] = ExpressionConverter.ConvertO(bodyblogAuthorId);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(bodyenableGoogleAmpOutputOverride);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["postBody"] = ExpressionConverter.ConvertO(bodypostBody);
            bodypropCount++;
            body["postSummary"] = ExpressionConverter.ConvertO(bodypostSummary);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["rssBody"] = ExpressionConverter.ConvertO(bodyrssBody);
            bodypropCount++;
            body["rssSummary"] = ExpressionConverter.ConvertO(bodyrssSummary);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["tagIds"] = ExpressionConverter.ConvertO(bodytagIds);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Restoreapreviousversionofablogposttothedraftversionoftheblogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/revisions/{1}/restore-to-draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Createanewlanguagevariation(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage)
        {
            var apiCallPath = "/blogs/posts/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> CloneaBlogPost(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var apiCallPath = "/blogs/posts/clone";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["cloneName"] = ExpressionConverter.ConvertO(bodycloneName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation9> GetallBlogPosts(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/blogs/posts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation9>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> CreateanewBlogPost(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = "/blogs/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["blogAuthorId"] = ExpressionConverter.ConvertO(bodyblogAuthorId);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(bodyenableGoogleAmpOutputOverride);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["postBody"] = ExpressionConverter.ConvertO(bodypostBody);
            bodypropCount++;
            body["postSummary"] = ExpressionConverter.ConvertO(bodypostSummary);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["rssBody"] = ExpressionConverter.ConvertO(bodyrssBody);
            bodypropCount++;
            body["rssSummary"] = ExpressionConverter.ConvertO(bodyrssSummary);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["tagIds"] = ExpressionConverter.ConvertO(bodytagIds);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Restoreapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/revisions/{1}/restore", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogPostfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/posts/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushBlogPostdrafteditslive(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/draft/push-live", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogPosts(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/blogs/posts/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheBlogPostdrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/draft/reset", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogPosttoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blogs/posts/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation12> Retrievesallthepreviousversionsofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}/revisions", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<Successfuloperation12>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Setanewprimarylanguage(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/posts/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> RetrieveaBlogPost(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlogPost(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> UpdateaBlogPost(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodyblogAuthorId, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableGoogleAmpOutputOverride, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypostBody, Expression<Func<string>> bodypostSummary, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyrssBody, Expression<Func<string>> bodyrssSummary, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string[]>> bodytagIds, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["blogAuthorId"] = ExpressionConverter.ConvertO(bodyblogAuthorId);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableGoogleAmpOutputOverride"] = ExpressionConverter.ConvertO(bodyenableGoogleAmpOutputOverride);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["postBody"] = ExpressionConverter.ConvertO(bodypostBody);
            bodypropCount++;
            body["postSummary"] = ExpressionConverter.ConvertO(bodypostSummary);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["rssBody"] = ExpressionConverter.ConvertO(bodyrssBody);
            bodypropCount++;
            body["rssSummary"] = ExpressionConverter.ConvertO(bodyrssSummary);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["tagIds"] = ExpressionConverter.ConvertO(bodytagIds);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> RetrieveaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/blogs/authors/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation15>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/authors/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> UpdateaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<string>> bodyavatar, Expression<Func<string>> bodybio, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfacebook, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkedin, Expression<Func<string>> bodyname, Expression<Func<string>> bodyslug, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodytwitter, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodywebsite, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/authors/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["avatar"] = ExpressionConverter.ConvertO(bodyavatar);
            bodypropCount++;
            body["bio"] = ExpressionConverter.ConvertO(bodybio);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["facebook"] = ExpressionConverter.ConvertO(bodyfacebook);
            bodypropCount++;
            body["fullName"] = ExpressionConverter.ConvertO(bodyfullName);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["linkedin"] = ExpressionConverter.ConvertO(bodylinkedin);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            bodypropCount++;
            body["twitter"] = ExpressionConverter.ConvertO(bodytwitter);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["website"] = ExpressionConverter.ConvertO(bodywebsite);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation15>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogAuthorfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/authors/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/authors/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogAuthors(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/blogs/authors/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation20> GetallBlogAuthors(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/blogs/authors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation20>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> CreateanewBlogAuthor(Expression<Func<string>> bodyavatar, Expression<Func<string>> bodybio, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfacebook, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkedin, Expression<Func<string>> bodyname, Expression<Func<string>> bodyslug, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodytwitter, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodywebsite)
        {
            var apiCallPath = "/blogs/authors";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["avatar"] = ExpressionConverter.ConvertO(bodyavatar);
            bodypropCount++;
            body["bio"] = ExpressionConverter.ConvertO(bodybio);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["facebook"] = ExpressionConverter.ConvertO(bodyfacebook);
            bodypropCount++;
            body["fullName"] = ExpressionConverter.ConvertO(bodyfullName);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["linkedin"] = ExpressionConverter.ConvertO(bodylinkedin);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            bodypropCount++;
            body["twitter"] = ExpressionConverter.ConvertO(bodytwitter);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["website"] = ExpressionConverter.ConvertO(bodywebsite);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation15>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> PostCreateanewlanguagevariation(Expression<Func<string>> bodyblogAuthoravatar, Expression<Func<string>> bodyblogAuthorbio, Expression<Func<string>> bodyblogAuthorcreated, Expression<Func<string>> bodyblogAuthordeletedAt, Expression<Func<string>> bodyblogAuthordisplayName, Expression<Func<string>> bodyblogAuthoremail, Expression<Func<string>> bodyblogAuthorfacebook, Expression<Func<string>> bodyblogAuthorfullName, Expression<Func<string>> bodyblogAuthorid, Expression<Func<string>> bodyblogAuthorlanguage, Expression<Func<string>> bodyblogAuthorlinkedin, Expression<Func<string>> bodyblogAuthorname, Expression<Func<string>> bodyblogAuthorslug, Expression<Func<string>> bodyblogAuthortranslatedFromId, Expression<Func<string>> bodyblogAuthortwitter, Expression<Func<string>> bodyblogAuthorupdated, Expression<Func<string>> bodyblogAuthorwebsite, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blogs/authors/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var blogAuthorObject = new JObject();
            var blogAuthorObjectpropCount = 0;
            blogAuthorObjectpropCount++;
            blogAuthorObject["avatar"] = ExpressionConverter.ConvertO(bodyblogAuthoravatar);
            blogAuthorObjectpropCount++;
            blogAuthorObject["bio"] = ExpressionConverter.ConvertO(bodyblogAuthorbio);
            blogAuthorObjectpropCount++;
            blogAuthorObject["created"] = ExpressionConverter.ConvertO(bodyblogAuthorcreated);
            blogAuthorObjectpropCount++;
            blogAuthorObject["deletedAt"] = ExpressionConverter.ConvertO(bodyblogAuthordeletedAt);
            blogAuthorObjectpropCount++;
            blogAuthorObject["displayName"] = ExpressionConverter.ConvertO(bodyblogAuthordisplayName);
            blogAuthorObjectpropCount++;
            blogAuthorObject["email"] = ExpressionConverter.ConvertO(bodyblogAuthoremail);
            blogAuthorObjectpropCount++;
            blogAuthorObject["facebook"] = ExpressionConverter.ConvertO(bodyblogAuthorfacebook);
            blogAuthorObjectpropCount++;
            blogAuthorObject["fullName"] = ExpressionConverter.ConvertO(bodyblogAuthorfullName);
            blogAuthorObjectpropCount++;
            blogAuthorObject["id"] = ExpressionConverter.ConvertO(bodyblogAuthorid);
            blogAuthorObjectpropCount++;
            blogAuthorObject["language"] = ExpressionConverter.ConvertO(bodyblogAuthorlanguage);
            blogAuthorObjectpropCount++;
            blogAuthorObject["linkedin"] = ExpressionConverter.ConvertO(bodyblogAuthorlinkedin);
            blogAuthorObjectpropCount++;
            blogAuthorObject["name"] = ExpressionConverter.ConvertO(bodyblogAuthorname);
            blogAuthorObjectpropCount++;
            blogAuthorObject["slug"] = ExpressionConverter.ConvertO(bodyblogAuthorslug);
            blogAuthorObjectpropCount++;
            blogAuthorObject["translatedFromId"] = ExpressionConverter.ConvertO(bodyblogAuthortranslatedFromId);
            blogAuthorObjectpropCount++;
            blogAuthorObject["twitter"] = ExpressionConverter.ConvertO(bodyblogAuthortwitter);
            blogAuthorObjectpropCount++;
            blogAuthorObject["updated"] = ExpressionConverter.ConvertO(bodyblogAuthorupdated);
            blogAuthorObjectpropCount++;
            blogAuthorObject["website"] = ExpressionConverter.ConvertO(bodyblogAuthorwebsite);
            if (blogAuthorObjectpropCount > 0)
            {
                body["blogAuthor"] = blogAuthorObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation15>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogAuthortoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blogs/authors/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup1(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation23> RetrievesallthepreviousversionsofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/blog-settings/settings/{0}/revisions", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<Successfuloperation23>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation24> RetrievesapreviousversionofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/blog-settings/settings/{0}/revisions/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation24>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25> RetrieveaBlog(Expression<Func<string>> blogId)
        {
            var apiCallPath = String.Format("/blog-settings/settings/{0}", ExpressionConverter.ConvertWithUrlEncoding(blogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation25>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25> PostCreateanewlanguagevariation1(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage, Expression<Func<string>> bodyslug)
        {
            var apiCallPath = "/blog-settings/settings/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation25>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation27> GetallBlogs(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/blog-settings/settings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction<Successfuloperation27>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage1(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blog-settings/settings/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachablogfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blog-settings/settings/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachablogtoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blog-settings/settings/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup2(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogTagfromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/tags/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogTags(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/blogs/tags/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage2(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/blogs/tags/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation31> GetallBlogTags(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/blogs/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation31>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> CreateanewBlogTag(Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyname, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated)
        {
            var apiCallPath = "/blogs/tags";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation32>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogTagtoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blogs/tags/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> RetrieveaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/blogs/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation32>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> UpdateaBlogTag(Expression<Func<string>> objectId, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyname, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/blogs/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation32>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> PostCreateanewlanguagevariation2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/blogs/tags/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation32>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string> Exportadrafttable(Expression<Func<string>> tableIdOrName)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft/export", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("CSV");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36> Returnalldrafttables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/hubdb/tables/draft";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction<Successfuloperation36>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Resetadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft/reset", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string> Exportapublishedversionofatable(Expression<Func<string>> tableIdOrName)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/export", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("CSV");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Cloneatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodycopyRows, Expression<Func<string>> bodynewName, Expression<Func<string>> bodynewLabel)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft/clone", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["copyRows"] = ExpressionConverter.ConvertO(bodycopyRows);
            bodypropCount++;
            body["newName"] = ExpressionConverter.ConvertO(bodynewName);
            bodypropCount++;
            body["newLabel"] = ExpressionConverter.ConvertO(bodynewLabel);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation39> Importdataintodrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> config, Expression<Func<string>> file)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft/import", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation39>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Getdetailsforapublishedtable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Archiveatable(Expression<Func<string>> tableIdOrName)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36> Getallpublishedtables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/hubdb/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction<Successfuloperation36>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Createanewtable(Expression<Func<string>> bodylabel, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyuseForPages, Expression<Func<bool>> bodyallowPublicApiAccess, Expression<Func<bool>> bodyallowChildTables, Expression<Func<bool>> bodyenableChildTablePages, Expression<Func<Column5[]>> bodycolumns)
        {
            var apiCallPath = "/hubdb/tables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["useForPages"] = ExpressionConverter.ConvertO(bodyuseForPages);
            bodypropCount++;
            body["allowPublicApiAccess"] = ExpressionConverter.ConvertO(bodyallowPublicApiAccess);
            bodypropCount++;
            body["allowChildTables"] = ExpressionConverter.ConvertO(bodyallowChildTables);
            bodypropCount++;
            body["enableChildTablePages"] = ExpressionConverter.ConvertO(bodyenableChildTablePages);
            bodypropCount++;
            body["columns"] = ExpressionConverter.ConvertO(bodycolumns);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Unpublishatable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/unpublish", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Getdetailsforadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Updateanexistingtable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodylabel, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyuseForPages, Expression<Func<bool>> bodyallowPublicApiAccess, Expression<Func<bool>> bodyallowChildTables, Expression<Func<bool>> bodyenableChildTablePages, Expression<Func<Column5[]>> bodycolumns, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["label"] = ExpressionConverter.ConvertO(bodylabel);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["useForPages"] = ExpressionConverter.ConvertO(bodyuseForPages);
            bodypropCount++;
            body["allowPublicApiAccess"] = ExpressionConverter.ConvertO(bodyallowPublicApiAccess);
            bodypropCount++;
            body["allowChildTables"] = ExpressionConverter.ConvertO(bodyallowChildTables);
            bodypropCount++;
            body["enableChildTablePages"] = ExpressionConverter.ConvertO(bodyenableChildTablePages);
            bodypropCount++;
            body["columns"] = ExpressionConverter.ConvertO(bodycolumns);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Publishatablefromdraft(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/draft/publish", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeForeignIds != null)
                callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(includeForeignIds);
            return new ApiConnectionAction<Successfuloperation37>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47> Getrowsfromdrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            return new ApiConnectionAction<Successfuloperation47>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Getatablerow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Clonearow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}/draft/clone", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Getarowfromthedrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Permanentlydeletesarow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Replacesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<string>> bodydisplayIndex)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
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
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["childTableId"] = ExpressionConverter.ConvertO(bodychildTableId);
            bodypropCount++;
            body["displayIndex"] = ExpressionConverter.ConvertO(bodydisplayIndex);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Updatesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<int>> bodydisplayIndex)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/{1}/draft", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowId, 1));
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
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["childTableId"] = ExpressionConverter.ConvertO(bodychildTableId);
            bodypropCount++;
            body["displayIndex"] = ExpressionConverter.ConvertO(bodydisplayIndex);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47> Getrowsforatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            return new ApiConnectionAction<Successfuloperation47>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Addanewrowtoatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> bodypath, Expression<Func<string>> bodyname, Expression<Func<string>> bodychildTableId, Expression<Func<int>> bodydisplayIndex)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
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
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["childTableId"] = ExpressionConverter.ConvertO(bodychildTableId);
            bodypropCount++;
            body["displayIndex"] = ExpressionConverter.ConvertO(bodydisplayIndex);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation48>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Permanentlydeletesrows(Expression<Func<string>> tableIdOrName, Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/draft/batch/purge", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation55> Clonerowsinbatch(Expression<Func<string>> tableIdOrName, Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = String.Format("/hubdb/tables/{0}/rows/draft/batch/clone", ExpressionConverter.ConvertWithUrlEncoding(tableIdOrName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation55>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61> RetrievesapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/revisions/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation61>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/revisions/{1}/restore", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ScheduleaSitePagetobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var apiCallPath = "/pages/site-pages/schedule";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachasitepagetoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/pages/site-pages/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachasitepagefromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/pages/site-pages/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64> RetrievesallthepreviousversionsofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/revisions", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<Successfuloperation64>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaSitePagetothedraftversionoftheSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/revisions/{1}/restore-to-draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction EndanactiveABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodywinnerId)
        {
            var apiCallPath = "/pages/site-pages/ab-test/end";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["winnerId"] = ExpressionConverter.ConvertO(bodywinnerId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrievethefulldraftversionoftheSitePage(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaSitePagedraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69> GetallSitePages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/pages/site-pages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation69>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewSitePage(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = "/pages/site-pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewlanguagevariation3(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/pages/site-pages/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewABtestvariation(Expression<Func<string>> bodycontentId, Expression<Func<string>> bodyvariationName)
        {
            var apiCallPath = "/pages/site-pages/ab-test/create-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contentId"] = ExpressionConverter.ConvertO(bodycontentId);
            bodypropCount++;
            body["variationName"] = ExpressionConverter.ConvertO(bodyvariationName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup3(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofSitePages(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/pages/site-pages/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CloneaSitePage(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var apiCallPath = "/pages/site-pages/clone";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["cloneName"] = ExpressionConverter.ConvertO(bodycloneName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage3(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/pages/site-pages/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushSitePagedrafteditslive(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/draft/push-live", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction RerunapreviousABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyvariationId)
        {
            var apiCallPath = "/pages/site-pages/ab-test/rerun";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["variationId"] = ExpressionConverter.ConvertO(bodyvariationId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheSitePagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}/draft/reset", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrieveaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/site-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64> RetrievesallthepreviousversionsofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/revisions", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<Successfuloperation64>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation78> RetrievesallthepreviousversionsofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}/revisions", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<Successfuloperation78>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation79> GetallLandingPageFolders(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/pages/landing-pages/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation79>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> CreateanewFolder(Expression<Func<string>> bodycategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId, Expression<Func<string>> bodyupdated)
        {
            var apiCallPath = "/pages/landing-pages/folders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation80>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrievethefulldraftversionoftheLandingPage(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaLandingPagedraft(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69> GetallLandingPages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = "/pages/landing-pages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAfter != null)
                callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(createdAfter);
            if (createdBefore != null)
                callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(createdBefore);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAfter != null)
                callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
            if (updatedBefore != null)
                callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(updatedBefore);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation69>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewLandingPage(Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage)
        {
            var apiCallPath = "/pages/landing-pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CloneaLandingPage(Expression<Func<string>> bodyid, Expression<Func<string>> bodycloneName)
        {
            var apiCallPath = "/pages/landing-pages/clone";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["cloneName"] = ExpressionConverter.ConvertO(bodycloneName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> RestoreapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}/revisions/{1}/restore", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation80>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage4(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/pages/landing-pages/multi-language/set-new-lang-primary";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/revisions/{1}/restore", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> RetrieveaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation80>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> UpdateaFolder(Expression<Func<string>> objectId, Expression<Func<string>> bodycategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodydeletedAt, Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId, Expression<Func<string>> bodyupdated, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["deletedAt"] = ExpressionConverter.ConvertO(bodydeletedAt);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation80>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewABtestvariation(Expression<Func<string>> bodycontentId, Expression<Func<string>> bodyvariationName)
        {
            var apiCallPath = "/pages/landing-pages/ab-test/create-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contentId"] = ExpressionConverter.ConvertO(bodycontentId);
            bodypropCount++;
            body["variationName"] = ExpressionConverter.ConvertO(bodyvariationName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachalandingpagetoamultiLanguagegroup(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryId, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/pages/landing-pages/multi-language/attach-to-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61> RetrievesapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/revisions/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation61>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostEndanactiveABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodywinnerId)
        {
            var apiCallPath = "/pages/landing-pages/ab-test/end";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["winnerId"] = ExpressionConverter.ConvertO(bodywinnerId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushLandingPagedrafteditslive(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/draft/push-live", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachalandingpagefromamultiLanguagegroup(Expression<Func<string>> bodyid)
        {
            var apiCallPath = "/pages/landing-pages/multi-language/detach-from-lang-group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ScheduleaLandingPagetobePublished(Expression<Func<string>> bodyid, Expression<Func<string>> bodypublishDate)
        {
            var apiCallPath = "/pages/landing-pages/schedule";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup4(Expression<Func<string>> bodyprimaryId)
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
            body["primaryId"] = ExpressionConverter.ConvertO(bodyprimaryId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostRerunapreviousABtest(Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyvariationId)
        {
            var apiCallPath = "/pages/landing-pages/ab-test/rerun";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["variationId"] = ExpressionConverter.ConvertO(bodyvariationId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofFolders(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/pages/landing-pages/folders/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation97> RetrievesapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/folders/{0}/revisions/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation97>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheLandingPagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/draft/reset", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrieveaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (property != null)
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> bodyabStatus, Expression<Func<string>> bodyabTestId, Expression<Func<string>> bodyarchivedAt, Expression<Func<bool>> bodyarchivedInDashboard, Expression<Func<JToken[]>> bodyattachedStylesheets, Expression<Func<string>> bodyauthorName, Expression<Func<string>> bodycampaign, Expression<Func<string>> bodycategoryId, Expression<Func<string>> bodycontentGroupId, Expression<Func<string>> bodycontentTypeCategory, Expression<Func<string>> bodycreated, Expression<Func<string>> bodycreatedById, Expression<Func<string>> bodycurrentState, Expression<Func<bool>> bodycurrentlyPublished, Expression<Func<string>> bodydomain, Expression<Func<string>> bodydynamicPageDataSourceId, Expression<Func<string>> bodydynamicPageDataSourceType, Expression<Func<string>> bodydynamicPageHubDbTableId, Expression<Func<bool>> bodyenableDomainStylesheets, Expression<Func<bool>> bodyenableLayoutStylesheets, Expression<Func<string>> bodyfeaturedImage, Expression<Func<string>> bodyfeaturedImageAltText, Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyfooterHtml, Expression<Func<string>> bodyheadHtml, Expression<Func<string>> bodyhtmlTitle, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyincludeDefaultCustomCss, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodylinkRelCanonicalUrl, Expression<Func<string>> bodymabExperimentId, Expression<Func<string>> bodymetaDescription, Expression<Func<string>> bodyname, Expression<Func<string>> bodypageExpiryDate, Expression<Func<bool>> bodypageExpiryEnabled, Expression<Func<string>> bodypageExpiryRedirectId, Expression<Func<string>> bodypageExpiryRedirectUrl, Expression<Func<bool>> bodypageRedirected, Expression<Func<string>> bodypassword, Expression<Func<string[]>> bodypublicAccessRules, Expression<Func<bool>> bodypublicAccessRulesEnabled, Expression<Func<string>> bodypublishDate, Expression<Func<string>> bodypublishImmediately, Expression<Func<string>> bodyslug, Expression<Func<string>> bodystate, Expression<Func<string>> bodysubCategory, Expression<Func<string>> bodytemplatePath, Expression<Func<string>> bodytranslatedFromId, Expression<Func<string>> bodyupdated, Expression<Func<string>> bodyupdatedById, Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyuseFeaturedImage, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["abStatus"] = ExpressionConverter.ConvertO(bodyabStatus);
            bodypropCount++;
            body["abTestId"] = ExpressionConverter.ConvertO(bodyabTestId);
            bodypropCount++;
            body["archivedAt"] = ExpressionConverter.ConvertO(bodyarchivedAt);
            bodypropCount++;
            body["archivedInDashboard"] = ExpressionConverter.ConvertO(bodyarchivedInDashboard);
            bodypropCount++;
            body["attachedStylesheets"] = ExpressionConverter.ConvertO(bodyattachedStylesheets);
            bodypropCount++;
            body["authorName"] = ExpressionConverter.ConvertO(bodyauthorName);
            bodypropCount++;
            body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["contentGroupId"] = ExpressionConverter.ConvertO(bodycontentGroupId);
            bodypropCount++;
            body["contentTypeCategory"] = ExpressionConverter.ConvertO(bodycontentTypeCategory);
            bodypropCount++;
            body["created"] = ExpressionConverter.ConvertO(bodycreated);
            bodypropCount++;
            body["createdById"] = ExpressionConverter.ConvertO(bodycreatedById);
            bodypropCount++;
            body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
            bodypropCount++;
            body["currentlyPublished"] = ExpressionConverter.ConvertO(bodycurrentlyPublished);
            bodypropCount++;
            body["domain"] = ExpressionConverter.ConvertO(bodydomain);
            bodypropCount++;
            body["dynamicPageDataSourceId"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceId);
            bodypropCount++;
            body["dynamicPageDataSourceType"] = ExpressionConverter.ConvertO(bodydynamicPageDataSourceType);
            bodypropCount++;
            body["dynamicPageHubDbTableId"] = ExpressionConverter.ConvertO(bodydynamicPageHubDbTableId);
            bodypropCount++;
            body["enableDomainStylesheets"] = ExpressionConverter.ConvertO(bodyenableDomainStylesheets);
            bodypropCount++;
            body["enableLayoutStylesheets"] = ExpressionConverter.ConvertO(bodyenableLayoutStylesheets);
            bodypropCount++;
            body["featuredImage"] = ExpressionConverter.ConvertO(bodyfeaturedImage);
            bodypropCount++;
            body["featuredImageAltText"] = ExpressionConverter.ConvertO(bodyfeaturedImageAltText);
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["footerHtml"] = ExpressionConverter.ConvertO(bodyfooterHtml);
            bodypropCount++;
            body["headHtml"] = ExpressionConverter.ConvertO(bodyheadHtml);
            bodypropCount++;
            body["htmlTitle"] = ExpressionConverter.ConvertO(bodyhtmlTitle);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["includeDefaultCustomCss"] = ExpressionConverter.ConvertO(bodyincludeDefaultCustomCss);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            var layoutSectionsObject = new JObject();
            var layoutSectionsObjectpropCount = 0;
            if (layoutSectionsObjectpropCount > 0)
            {
                body["layoutSections"] = layoutSectionsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["linkRelCanonicalUrl"] = ExpressionConverter.ConvertO(bodylinkRelCanonicalUrl);
            bodypropCount++;
            body["mabExperimentId"] = ExpressionConverter.ConvertO(bodymabExperimentId);
            bodypropCount++;
            body["metaDescription"] = ExpressionConverter.ConvertO(bodymetaDescription);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["pageExpiryDate"] = ExpressionConverter.ConvertO(bodypageExpiryDate);
            bodypropCount++;
            body["pageExpiryEnabled"] = ExpressionConverter.ConvertO(bodypageExpiryEnabled);
            bodypropCount++;
            body["pageExpiryRedirectId"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectId);
            bodypropCount++;
            body["pageExpiryRedirectUrl"] = ExpressionConverter.ConvertO(bodypageExpiryRedirectUrl);
            bodypropCount++;
            body["pageRedirected"] = ExpressionConverter.ConvertO(bodypageRedirected);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["publicAccessRules"] = ExpressionConverter.ConvertO(bodypublicAccessRules);
            bodypropCount++;
            body["publicAccessRulesEnabled"] = ExpressionConverter.ConvertO(bodypublicAccessRulesEnabled);
            bodypropCount++;
            body["publishDate"] = ExpressionConverter.ConvertO(bodypublishDate);
            bodypropCount++;
            body["publishImmediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
            bodypropCount++;
            body["slug"] = ExpressionConverter.ConvertO(bodyslug);
            bodypropCount++;
            body["state"] = ExpressionConverter.ConvertO(bodystate);
            bodypropCount++;
            body["subCategory"] = ExpressionConverter.ConvertO(bodysubCategory);
            bodypropCount++;
            body["templatePath"] = ExpressionConverter.ConvertO(bodytemplatePath);
            var themeSettingsValuesObject = new JObject();
            var themeSettingsValuesObjectpropCount = 0;
            if (themeSettingsValuesObjectpropCount > 0)
            {
                body["themeSettingsValues"] = themeSettingsValuesObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["translatedFromId"] = ExpressionConverter.ConvertO(bodytranslatedFromId);
            var translationsObject = new JObject();
            var translationsObjectpropCount = 0;
            if (translationsObjectpropCount > 0)
            {
                body["translations"] = translationsObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
            bodypropCount++;
            body["updatedById"] = ExpressionConverter.ConvertO(bodyupdatedById);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["useFeaturedImage"] = ExpressionConverter.ConvertO(bodyuseFeaturedImage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewlanguagevariation4(Expression<Func<string>> bodyid, Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyprimaryLanguage)
        {
            var apiCallPath = "/pages/landing-pages/multi-language/create-language-variation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodylanguage);
            bodypropCount++;
            body["primaryLanguage"] = ExpressionConverter.ConvertO(bodyprimaryLanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Successfuloperation63>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofLandingPages(Expression<Func<string[]>> bodyinputs)
        {
            var apiCallPath = "/pages/landing-pages/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaLandingPagetothedraftversionoftheLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var apiCallPath = String.Format("/pages/landing-pages/{0}/revisions/{1}/restore-to-draft", ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(revisionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Successfuloperation63>(callPayload);
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
        public Object Object { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object
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
        public Object1 Object { get; set; }

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
        public Object2 Object { get; set; }

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
        public Object2 Object { get; set; }

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

    public class Successfuloperation39
    {
        [JsonProperty("duplicateRows")]
        public int DuplicateRows { get; set; }

        [JsonProperty("errors")]
        public Error150[] Errors { get; set; }

        [JsonProperty("rowLimitExceeded")]
        public int RowLimitExceeded { get; set; }

        [JsonProperty("rowsImported")]
        public int RowsImported { get; set; }
    }

    public class Error150
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("errors")]
        public Error151[] Errors { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class Error151
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
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
        public Object4 Object { get; set; }

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
        public Object5 Object { get; set; }

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
        public Object7 Object { get; set; }

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
        public Object7 Object { get; set; }

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