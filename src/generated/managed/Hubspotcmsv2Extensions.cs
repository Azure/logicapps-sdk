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
        public IWorkflowAction ScheduleaBlogPosttobePublished([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypublishDate)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction UpdatelanguagesofmultiLanguagegroup([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation1> Retrievesapreviousversionofablogpost([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/revisions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation1>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> RetrievethefulldraftversionoftheBlog([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> UpdateaBlogPostdraft([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodyblogAuthorId, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableGoogleAmpOutputOverride, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypostBody, [WorkflowExpression] Func<string> bodypostSummary, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyrssBody, [WorkflowExpression] Func<string> bodyrssSummary, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string[]> bodytagIds, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypostBody, nameof(bodypostBody), required: true);
            SourceExpression.Validate(bodypostSummary, nameof(bodypostSummary), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyrssBody, nameof(bodyrssBody), required: true);
            SourceExpression.Validate(bodyrssSummary, nameof(bodyrssSummary), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodytagIds, nameof(bodytagIds), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = SourceExpressionConverter.ConvertToken(bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["postBody"] = SourceExpressionConverter.ConvertToken(bodypostBody);
                bodypropCount++;
                body["postSummary"] = SourceExpressionConverter.ConvertToken(bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = SourceExpressionConverter.ConvertToken(bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = SourceExpressionConverter.ConvertToken(bodyrssSummary);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["tagIds"] = SourceExpressionConverter.ConvertToken(bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Restoreapreviousversionofablogposttothedraftversionoftheblogpost([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/revisions/{1}/restore-to-draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Createanewlanguagevariation([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> CloneaBlog([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycloneName)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodycloneName, nameof(bodycloneName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["cloneName"] = SourceExpressionConverter.ConvertToken(bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation9> GetallBlogPosts([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation9>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> CreateanewBlog([WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodyblogAuthorId, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableGoogleAmpOutputOverride, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypostBody, [WorkflowExpression] Func<string> bodypostSummary, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyrssBody, [WorkflowExpression] Func<string> bodyrssSummary, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string[]> bodytagIds, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypostBody, nameof(bodypostBody), required: true);
            SourceExpression.Validate(bodypostSummary, nameof(bodypostSummary), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyrssBody, nameof(bodyrssBody), required: true);
            SourceExpression.Validate(bodyrssSummary, nameof(bodyrssSummary), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodytagIds, nameof(bodytagIds), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = SourceExpressionConverter.ConvertToken(bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["postBody"] = SourceExpressionConverter.ConvertToken(bodypostBody);
                bodypropCount++;
                body["postSummary"] = SourceExpressionConverter.ConvertToken(bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = SourceExpressionConverter.ConvertToken(bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = SourceExpressionConverter.ConvertToken(bodyrssSummary);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["tagIds"] = SourceExpressionConverter.ConvertToken(bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> Restoreapreviousversionofablogpost([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/revisions/{1}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogPostfromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushBlogPostdrafteditslive([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/draft/push-live", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogPosts([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheBlogPostdrafttotheliveversion([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/draft/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogPosttoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation12> Retrievesallthepreviousversionsofablogpost([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}/revisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation12>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Setanewprimarylanguage([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/posts/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlog([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3> UpdateaBlog([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodyblogAuthorId, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableGoogleAmpOutputOverride, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypostBody, [WorkflowExpression] Func<string> bodypostSummary, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyrssBody, [WorkflowExpression] Func<string> bodyrssSummary, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string[]> bodytagIds, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodyblogAuthorId, nameof(bodyblogAuthorId), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableGoogleAmpOutputOverride, nameof(bodyenableGoogleAmpOutputOverride), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypostBody, nameof(bodypostBody), required: true);
            SourceExpression.Validate(bodypostSummary, nameof(bodypostSummary), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyrssBody, nameof(bodyrssBody), required: true);
            SourceExpression.Validate(bodyrssSummary, nameof(bodyrssSummary), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodytagIds, nameof(bodytagIds), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/posts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["blogAuthorId"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorId);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableGoogleAmpOutputOverride"] = SourceExpressionConverter.ConvertToken(bodyenableGoogleAmpOutputOverride);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["postBody"] = SourceExpressionConverter.ConvertToken(bodypostBody);
                bodypropCount++;
                body["postSummary"] = SourceExpressionConverter.ConvertToken(bodypostSummary);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["rssBody"] = SourceExpressionConverter.ConvertToken(bodyrssBody);
                bodypropCount++;
                body["rssSummary"] = SourceExpressionConverter.ConvertToken(bodyrssSummary);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["tagIds"] = SourceExpressionConverter.ConvertToken(bodytagIds);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> RetrieveaBlogAuthor([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/authors/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation15>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlogAuthor([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/authors/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> UpdateaBlogAuthor([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyavatar, [WorkflowExpression] Func<string> bodybio, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfacebook, [WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkedin, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodytwitter, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodywebsite, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyavatar, nameof(bodyavatar), required: true);
            SourceExpression.Validate(bodybio, nameof(bodybio), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfacebook, nameof(bodyfacebook), required: true);
            SourceExpression.Validate(bodyfullName, nameof(bodyfullName), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkedin, nameof(bodylinkedin), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodytwitter, nameof(bodytwitter), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/authors/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["avatar"] = SourceExpressionConverter.ConvertToken(bodyavatar);
                bodypropCount++;
                body["bio"] = SourceExpressionConverter.ConvertToken(bodybio);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["facebook"] = SourceExpressionConverter.ConvertToken(bodyfacebook);
                bodypropCount++;
                body["fullName"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["linkedin"] = SourceExpressionConverter.ConvertToken(bodylinkedin);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                bodypropCount++;
                body["twitter"] = SourceExpressionConverter.ConvertToken(bodytwitter);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation15>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogAuthorfromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogAuthors([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation20> GetallBlogAuthors([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation20>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> CreateanewBlogAuthor([WorkflowExpression] Func<string> bodyavatar, [WorkflowExpression] Func<string> bodybio, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfacebook, [WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkedin, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodytwitter, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodywebsite)
        {
            SourceExpression.Validate(bodyavatar, nameof(bodyavatar), required: true);
            SourceExpression.Validate(bodybio, nameof(bodybio), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfacebook, nameof(bodyfacebook), required: true);
            SourceExpression.Validate(bodyfullName, nameof(bodyfullName), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkedin, nameof(bodylinkedin), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodytwitter, nameof(bodytwitter), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["avatar"] = SourceExpressionConverter.ConvertToken(bodyavatar);
                bodypropCount++;
                body["bio"] = SourceExpressionConverter.ConvertToken(bodybio);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["facebook"] = SourceExpressionConverter.ConvertToken(bodyfacebook);
                bodypropCount++;
                body["fullName"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["linkedin"] = SourceExpressionConverter.ConvertToken(bodylinkedin);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                bodypropCount++;
                body["twitter"] = SourceExpressionConverter.ConvertToken(bodytwitter);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation15>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15> PostCreateanewlanguagevariation([WorkflowExpression] Func<string> bodyblogAuthoravatar, [WorkflowExpression] Func<string> bodyblogAuthorbio, [WorkflowExpression] Func<string> bodyblogAuthorcreated, [WorkflowExpression] Func<string> bodyblogAuthordeletedAt, [WorkflowExpression] Func<string> bodyblogAuthordisplayName, [WorkflowExpression] Func<string> bodyblogAuthoremail, [WorkflowExpression] Func<string> bodyblogAuthorfacebook, [WorkflowExpression] Func<string> bodyblogAuthorfullName, [WorkflowExpression] Func<string> bodyblogAuthorid, [WorkflowExpression] Func<string> bodyblogAuthorlanguage, [WorkflowExpression] Func<string> bodyblogAuthorlinkedin, [WorkflowExpression] Func<string> bodyblogAuthorname, [WorkflowExpression] Func<string> bodyblogAuthorslug, [WorkflowExpression] Func<string> bodyblogAuthortranslatedFromId, [WorkflowExpression] Func<string> bodyblogAuthortwitter, [WorkflowExpression] Func<string> bodyblogAuthorupdated, [WorkflowExpression] Func<string> bodyblogAuthorwebsite, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyblogAuthoravatar, nameof(bodyblogAuthoravatar), required: true);
            SourceExpression.Validate(bodyblogAuthorbio, nameof(bodyblogAuthorbio), required: true);
            SourceExpression.Validate(bodyblogAuthorcreated, nameof(bodyblogAuthorcreated), required: true);
            SourceExpression.Validate(bodyblogAuthordeletedAt, nameof(bodyblogAuthordeletedAt), required: true);
            SourceExpression.Validate(bodyblogAuthordisplayName, nameof(bodyblogAuthordisplayName), required: true);
            SourceExpression.Validate(bodyblogAuthoremail, nameof(bodyblogAuthoremail), required: true);
            SourceExpression.Validate(bodyblogAuthorfacebook, nameof(bodyblogAuthorfacebook), required: true);
            SourceExpression.Validate(bodyblogAuthorfullName, nameof(bodyblogAuthorfullName), required: true);
            SourceExpression.Validate(bodyblogAuthorid, nameof(bodyblogAuthorid), required: true);
            SourceExpression.Validate(bodyblogAuthorlanguage, nameof(bodyblogAuthorlanguage), required: true);
            SourceExpression.Validate(bodyblogAuthorlinkedin, nameof(bodyblogAuthorlinkedin), required: true);
            SourceExpression.Validate(bodyblogAuthorname, nameof(bodyblogAuthorname), required: true);
            SourceExpression.Validate(bodyblogAuthorslug, nameof(bodyblogAuthorslug), required: true);
            SourceExpression.Validate(bodyblogAuthortranslatedFromId, nameof(bodyblogAuthortranslatedFromId), required: true);
            SourceExpression.Validate(bodyblogAuthortwitter, nameof(bodyblogAuthortwitter), required: true);
            SourceExpression.Validate(bodyblogAuthorupdated, nameof(bodyblogAuthorupdated), required: true);
            SourceExpression.Validate(bodyblogAuthorwebsite, nameof(bodyblogAuthorwebsite), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var blogAuthorObject = new JObject();
                var blogAuthorObjectpropCount = 0;
                blogAuthorObjectpropCount++;
                blogAuthorObject["avatar"] = SourceExpressionConverter.ConvertToken(bodyblogAuthoravatar);
                blogAuthorObjectpropCount++;
                blogAuthorObject["bio"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorbio);
                blogAuthorObjectpropCount++;
                blogAuthorObject["created"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorcreated);
                blogAuthorObjectpropCount++;
                blogAuthorObject["deletedAt"] = SourceExpressionConverter.ConvertToken(bodyblogAuthordeletedAt);
                blogAuthorObjectpropCount++;
                blogAuthorObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyblogAuthordisplayName);
                blogAuthorObjectpropCount++;
                blogAuthorObject["email"] = SourceExpressionConverter.ConvertToken(bodyblogAuthoremail);
                blogAuthorObjectpropCount++;
                blogAuthorObject["facebook"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorfacebook);
                blogAuthorObjectpropCount++;
                blogAuthorObject["fullName"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorfullName);
                blogAuthorObjectpropCount++;
                blogAuthorObject["id"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorid);
                blogAuthorObjectpropCount++;
                blogAuthorObject["language"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorlanguage);
                blogAuthorObjectpropCount++;
                blogAuthorObject["linkedin"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorlinkedin);
                blogAuthorObjectpropCount++;
                blogAuthorObject["name"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorname);
                blogAuthorObjectpropCount++;
                blogAuthorObject["slug"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorslug);
                blogAuthorObjectpropCount++;
                blogAuthorObject["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodyblogAuthortranslatedFromId);
                blogAuthorObjectpropCount++;
                blogAuthorObject["twitter"] = SourceExpressionConverter.ConvertToken(bodyblogAuthortwitter);
                blogAuthorObjectpropCount++;
                blogAuthorObject["updated"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorupdated);
                blogAuthorObjectpropCount++;
                blogAuthorObject["website"] = SourceExpressionConverter.ConvertToken(bodyblogAuthorwebsite);
                if (blogAuthorObjectpropCount > 0)
                {
                    body["blogAuthor"] = blogAuthorObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation15>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogAuthortoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/authors/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup1([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation23> RetrievesallthepreviousversionsofaBlog([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blog-settings/settings/{0}/revisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation23>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation24> RetrievesapreviousversionofaBlog([WorkflowExpression] Func<string> blogId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blog-settings/settings/{0}/revisions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation24>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25> RetrieveaBlog([WorkflowExpression] Func<string> blogId)
        {
            SourceExpression.Validate(blogId, nameof(blogId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blog-settings/settings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(blogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation25>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25> PostCreateanewlanguagevariation1([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryLanguage, [WorkflowExpression] Func<string> bodyslug)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blog-settings/settings/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation25>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation27> GetallBlogs([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blog-settings/settings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation27>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage1([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blog-settings/settings/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachablogfromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blog-settings/settings/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachablogtoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blog-settings/settings/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup2([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachaBlogTagfromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofBlogTags([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage2([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation31> GetallBlogTags([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation31>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> CreateanewBlogTag([WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated)
        {
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation32>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachaBlogTagtoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> RetrieveaBlogTag([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation32>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaBlogTag([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> UpdateaBlogTag([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/blogs/tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation32>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32> PostCreateanewlanguagevariation2([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/blogs/tags/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation32>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string> Exportadrafttable([WorkflowExpression] Func<string> tableIdOrName)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft/export", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36> Returnalldrafttables([WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hubdb/tables/draft";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation36>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Resetadrafttable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<bool> includeForeignIds = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string> Exportapublishedversionofatable([WorkflowExpression] Func<string> tableIdOrName)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/export", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Cloneatable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string> bodycopyRows, [WorkflowExpression] Func<string> bodynewName, [WorkflowExpression] Func<string> bodynewLabel)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(bodycopyRows, nameof(bodycopyRows), required: true);
            SourceExpression.Validate(bodynewName, nameof(bodynewName), required: true);
            SourceExpression.Validate(bodynewLabel, nameof(bodynewLabel), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft/clone", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["copyRows"] = SourceExpressionConverter.ConvertToken(bodycopyRows);
                bodypropCount++;
                body["newName"] = SourceExpressionConverter.ConvertToken(bodynewName);
                bodypropCount++;
                body["newLabel"] = SourceExpressionConverter.ConvertToken(bodynewLabel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Getdetailsforapublishedtable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<bool> includeForeignIds = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Archiveatable([WorkflowExpression] Func<string> tableIdOrName)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36> Getallpublishedtables([WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation36>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Createanewtable([WorkflowExpression] Func<string> bodylabel, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyuseForPages, [WorkflowExpression] Func<bool> bodyallowPublicApiAccess, [WorkflowExpression] Func<bool> bodyallowChildTables, [WorkflowExpression] Func<bool> bodyenableChildTablePages, [WorkflowExpression] Func<Column5[]> bodycolumns)
        {
            SourceExpression.Validate(bodylabel, nameof(bodylabel), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyuseForPages, nameof(bodyuseForPages), required: true);
            SourceExpression.Validate(bodyallowPublicApiAccess, nameof(bodyallowPublicApiAccess), required: true);
            SourceExpression.Validate(bodyallowChildTables, nameof(bodyallowChildTables), required: true);
            SourceExpression.Validate(bodyenableChildTablePages, nameof(bodyenableChildTablePages), required: true);
            SourceExpression.Validate(bodycolumns, nameof(bodycolumns), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = SourceExpressionConverter.ConvertToken(bodylabel);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["useForPages"] = SourceExpressionConverter.ConvertToken(bodyuseForPages);
                bodypropCount++;
                body["allowPublicApiAccess"] = SourceExpressionConverter.ConvertToken(bodyallowPublicApiAccess);
                bodypropCount++;
                body["allowChildTables"] = SourceExpressionConverter.ConvertToken(bodyallowChildTables);
                bodypropCount++;
                body["enableChildTablePages"] = SourceExpressionConverter.ConvertToken(bodyenableChildTablePages);
                bodypropCount++;
                body["columns"] = SourceExpressionConverter.ConvertToken(bodycolumns);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Unpublishatable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<bool> includeForeignIds = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/unpublish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Getdetailsforadrafttable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<bool> includeForeignIds = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Updateanexistingtable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string> bodylabel, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyuseForPages, [WorkflowExpression] Func<bool> bodyallowPublicApiAccess, [WorkflowExpression] Func<bool> bodyallowChildTables, [WorkflowExpression] Func<bool> bodyenableChildTablePages, [WorkflowExpression] Func<Column5[]> bodycolumns, [WorkflowExpression] Func<bool> includeForeignIds = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(bodylabel, nameof(bodylabel), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyuseForPages, nameof(bodyuseForPages), required: true);
            SourceExpression.Validate(bodyallowPublicApiAccess, nameof(bodyallowPublicApiAccess), required: true);
            SourceExpression.Validate(bodyallowChildTables, nameof(bodyallowChildTables), required: true);
            SourceExpression.Validate(bodyenableChildTablePages, nameof(bodyenableChildTablePages), required: true);
            SourceExpression.Validate(bodycolumns, nameof(bodycolumns), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["label"] = SourceExpressionConverter.ConvertToken(bodylabel);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["useForPages"] = SourceExpressionConverter.ConvertToken(bodyuseForPages);
                bodypropCount++;
                body["allowPublicApiAccess"] = SourceExpressionConverter.ConvertToken(bodyallowPublicApiAccess);
                bodypropCount++;
                body["allowChildTables"] = SourceExpressionConverter.ConvertToken(bodyallowChildTables);
                bodypropCount++;
                body["enableChildTablePages"] = SourceExpressionConverter.ConvertToken(bodyenableChildTablePages);
                bodypropCount++;
                body["columns"] = SourceExpressionConverter.ConvertToken(bodycolumns);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37> Publishatablefromdraft([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<bool> includeForeignIds = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(includeForeignIds, nameof(includeForeignIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/draft/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = SourceExpressionConverter.ConvertO(includeForeignIds);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation37>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47> Getrowsfromdrafttable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> properties = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(properties, nameof(properties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation47>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Getatablerow([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Clonearow([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}/draft/clone", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Getarowfromthedrafttable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Permanentlydeletesarow([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Replacesanexistingrow([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodychildTableId, [WorkflowExpression] Func<string> bodydisplayIndex)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodychildTableId, nameof(bodychildTableId), required: true);
            SourceExpression.Validate(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
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
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["childTableId"] = SourceExpressionConverter.ConvertToken(bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = SourceExpressionConverter.ConvertToken(bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Updatesanexistingrow([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<int> rowId, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodychildTableId, [WorkflowExpression] Func<int> bodydisplayIndex)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(rowId, nameof(rowId), required: true);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodychildTableId, nameof(bodychildTableId), required: true);
            SourceExpression.Validate(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
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
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["childTableId"] = SourceExpressionConverter.ConvertToken(bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = SourceExpressionConverter.ConvertToken(bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47> Getrowsforatable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> properties = null)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(properties, nameof(properties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation47>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48> Addanewrowtoatable([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodychildTableId, [WorkflowExpression] Func<int> bodydisplayIndex)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodychildTableId, nameof(bodychildTableId), required: true);
            SourceExpression.Validate(bodydisplayIndex, nameof(bodydisplayIndex), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
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
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["childTableId"] = SourceExpressionConverter.ConvertToken(bodychildTableId);
                bodypropCount++;
                body["displayIndex"] = SourceExpressionConverter.ConvertToken(bodydisplayIndex);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation48>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction Permanentlydeletesrows([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/draft/batch/purge", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation55> Clonerowsinbatch([WorkflowExpression] Func<string> tableIdOrName, [WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(tableIdOrName, nameof(tableIdOrName), required: true);
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hubdb/tables/{0}/rows/draft/batch/clone", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableIdOrName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation55>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61> RetrievesapreviousversionofaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/revisions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation61>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ScheduleaSitePagetobePublished([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypublishDate)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachasitepagetoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachasitepagefromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64> RetrievesallthepreviousversionsofaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/revisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation64>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaSitePagetothedraftversionoftheSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore-to-draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction EndanactiveABtest([WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodywinnerId)
        {
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodywinnerId, nameof(bodywinnerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["winnerId"] = SourceExpressionConverter.ConvertToken(bodywinnerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrievethefulldraftversionoftheSitePage([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaSitePagedraft([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69> GetallSitePages([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation69>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewSitePage([WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewlanguagevariation3([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewABtestvariation([WorkflowExpression] Func<string> bodycontentId, [WorkflowExpression] Func<string> bodyvariationName)
        {
            SourceExpression.Validate(bodycontentId, nameof(bodycontentId), required: true);
            SourceExpression.Validate(bodyvariationName, nameof(bodyvariationName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contentId"] = SourceExpressionConverter.ConvertToken(bodycontentId);
                bodypropCount++;
                body["variationName"] = SourceExpressionConverter.ConvertToken(bodyvariationName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup3([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofSitePages([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CloneaSitePage([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycloneName)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodycloneName, nameof(bodycloneName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["cloneName"] = SourceExpressionConverter.ConvertToken(bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage3([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushSitePagedrafteditslive([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/draft/push-live", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction RerunapreviousABtest([WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyvariationId)
        {
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyvariationId, nameof(bodyvariationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/site-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["variationId"] = SourceExpressionConverter.ConvertToken(bodyvariationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheSitePagedrafttotheliveversion([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}/draft/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrieveaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaSitePage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/site-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64> RetrievesallthepreviousversionsofaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/revisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation64>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation78> RetrievesallthepreviousversionsofaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}/revisions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation78>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation79> GetallLandingPageFolders([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation79>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> CreateanewFolder([WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId, [WorkflowExpression] Func<string> bodyupdated)
        {
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation80>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrievethefulldraftversionoftheLandingPage([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaLandingPagedraft([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69> GetallLandingPages([WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdAfter = null, [WorkflowExpression] Func<string> createdBefore = null, [WorkflowExpression] Func<string> updatedAt = null, [WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> updatedBefore = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdAfter, nameof(createdAfter), required: false);
            SourceExpression.Validate(createdBefore, nameof(createdBefore), required: false);
            SourceExpression.Validate(updatedAt, nameof(updatedAt), required: false);
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(updatedBefore, nameof(updatedBefore), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdAfter != null)
                    callPayload.Queries["createdAfter"] = SourceExpressionConverter.ConvertO(createdAfter);
                if (createdBefore != null)
                    callPayload.Queries["createdBefore"] = SourceExpressionConverter.ConvertO(createdBefore);
                if (updatedAt != null)
                    callPayload.Queries["updatedAt"] = SourceExpressionConverter.ConvertO(updatedAt);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = SourceExpressionConverter.ConvertO(updatedBefore);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation69>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CreateanewLandingPage([WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage)
        {
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> CloneaLandingPage([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycloneName)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodycloneName, nameof(bodycloneName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["cloneName"] = SourceExpressionConverter.ConvertToken(bodycloneName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> RestoreapreviousversionofaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation80>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PutSetanewprimarylanguage4([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> RetrieveaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation80>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80> UpdateaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodydeletedAt, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodydeletedAt, nameof(bodydeletedAt), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["deletedAt"] = SourceExpressionConverter.ConvertToken(bodydeletedAt);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation80>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewABtestvariation([WorkflowExpression] Func<string> bodycontentId, [WorkflowExpression] Func<string> bodyvariationName)
        {
            SourceExpression.Validate(bodycontentId, nameof(bodycontentId), required: true);
            SourceExpression.Validate(bodyvariationName, nameof(bodyvariationName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contentId"] = SourceExpressionConverter.ConvertToken(bodycontentId);
                bodypropCount++;
                body["variationName"] = SourceExpressionConverter.ConvertToken(bodyvariationName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction AttachalandingpagetoamultiLanguagegroup([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryId, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61> RetrievesapreviousversionofaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/revisions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation61>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostEndanactiveABtest([WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodywinnerId)
        {
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodywinnerId, nameof(bodywinnerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["winnerId"] = SourceExpressionConverter.ConvertToken(bodywinnerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PushLandingPagedrafteditslive([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/draft/push-live", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DetachalandingpagefromamultiLanguagegroup([WorkflowExpression] Func<string> bodyid)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ScheduleaLandingPagetobePublished([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypublishDate)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostUpdatelanguagesofmultiLanguagegroup4([WorkflowExpression] Func<string> bodyprimaryId)
        {
            SourceExpression.Validate(bodyprimaryId, nameof(bodyprimaryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["primaryId"] = SourceExpressionConverter.ConvertToken(bodyprimaryId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction PostRerunapreviousABtest([WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyvariationId)
        {
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyvariationId, nameof(bodyvariationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["variationId"] = SourceExpressionConverter.ConvertToken(bodyvariationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofFolders([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/folders/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation97> RetrievesapreviousversionofaFolder([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation97>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction ResettheLandingPagedrafttotheliveversion([WorkflowExpression] Func<string> objectId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/draft/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RetrieveaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> property = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(property, nameof(property), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (property != null)
                    callPayload.Queries["property"] = SourceExpressionConverter.ConvertO(property);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> UpdateaLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> bodyabStatus, [WorkflowExpression] Func<string> bodyabTestId, [WorkflowExpression] Func<string> bodyarchivedAt, [WorkflowExpression] Func<bool> bodyarchivedInDashboard, [WorkflowExpression] Func<JToken[]> bodyattachedStylesheets, [WorkflowExpression] Func<string> bodyauthorName, [WorkflowExpression] Func<string> bodycampaign, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<string> bodycontentGroupId, [WorkflowExpression] Func<string> bodycontentTypeCategory, [WorkflowExpression] Func<string> bodycreated, [WorkflowExpression] Func<string> bodycreatedById, [WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bool> bodycurrentlyPublished, [WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodydynamicPageDataSourceId, [WorkflowExpression] Func<string> bodydynamicPageDataSourceType, [WorkflowExpression] Func<string> bodydynamicPageHubDbTableId, [WorkflowExpression] Func<bool> bodyenableDomainStylesheets, [WorkflowExpression] Func<bool> bodyenableLayoutStylesheets, [WorkflowExpression] Func<string> bodyfeaturedImage, [WorkflowExpression] Func<string> bodyfeaturedImageAltText, [WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyfooterHtml, [WorkflowExpression] Func<string> bodyheadHtml, [WorkflowExpression] Func<string> bodyhtmlTitle, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyincludeDefaultCustomCss, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodylinkRelCanonicalUrl, [WorkflowExpression] Func<string> bodymabExperimentId, [WorkflowExpression] Func<string> bodymetaDescription, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypageExpiryDate, [WorkflowExpression] Func<bool> bodypageExpiryEnabled, [WorkflowExpression] Func<string> bodypageExpiryRedirectId, [WorkflowExpression] Func<string> bodypageExpiryRedirectUrl, [WorkflowExpression] Func<bool> bodypageRedirected, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string[]> bodypublicAccessRules, [WorkflowExpression] Func<bool> bodypublicAccessRulesEnabled, [WorkflowExpression] Func<string> bodypublishDate, [WorkflowExpression] Func<string> bodypublishImmediately, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodystate, [WorkflowExpression] Func<string> bodysubCategory, [WorkflowExpression] Func<string> bodytemplatePath, [WorkflowExpression] Func<string> bodytranslatedFromId, [WorkflowExpression] Func<string> bodyupdated, [WorkflowExpression] Func<string> bodyupdatedById, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bool> bodyuseFeaturedImage, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(bodyabStatus, nameof(bodyabStatus), required: true);
            SourceExpression.Validate(bodyabTestId, nameof(bodyabTestId), required: true);
            SourceExpression.Validate(bodyarchivedAt, nameof(bodyarchivedAt), required: true);
            SourceExpression.Validate(bodyarchivedInDashboard, nameof(bodyarchivedInDashboard), required: true);
            SourceExpression.Validate(bodyattachedStylesheets, nameof(bodyattachedStylesheets), required: true);
            SourceExpression.Validate(bodyauthorName, nameof(bodyauthorName), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodycontentGroupId, nameof(bodycontentGroupId), required: true);
            SourceExpression.Validate(bodycontentTypeCategory, nameof(bodycontentTypeCategory), required: true);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: true);
            SourceExpression.Validate(bodycreatedById, nameof(bodycreatedById), required: true);
            SourceExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            SourceExpression.Validate(bodycurrentlyPublished, nameof(bodycurrentlyPublished), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceId, nameof(bodydynamicPageDataSourceId), required: true);
            SourceExpression.Validate(bodydynamicPageDataSourceType, nameof(bodydynamicPageDataSourceType), required: true);
            SourceExpression.Validate(bodydynamicPageHubDbTableId, nameof(bodydynamicPageHubDbTableId), required: true);
            SourceExpression.Validate(bodyenableDomainStylesheets, nameof(bodyenableDomainStylesheets), required: true);
            SourceExpression.Validate(bodyenableLayoutStylesheets, nameof(bodyenableLayoutStylesheets), required: true);
            SourceExpression.Validate(bodyfeaturedImage, nameof(bodyfeaturedImage), required: true);
            SourceExpression.Validate(bodyfeaturedImageAltText, nameof(bodyfeaturedImageAltText), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: true);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: true);
            SourceExpression.Validate(bodyhtmlTitle, nameof(bodyhtmlTitle), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyincludeDefaultCustomCss, nameof(bodyincludeDefaultCustomCss), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodylinkRelCanonicalUrl, nameof(bodylinkRelCanonicalUrl), required: true);
            SourceExpression.Validate(bodymabExperimentId, nameof(bodymabExperimentId), required: true);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypageExpiryDate, nameof(bodypageExpiryDate), required: true);
            SourceExpression.Validate(bodypageExpiryEnabled, nameof(bodypageExpiryEnabled), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectId, nameof(bodypageExpiryRedirectId), required: true);
            SourceExpression.Validate(bodypageExpiryRedirectUrl, nameof(bodypageExpiryRedirectUrl), required: true);
            SourceExpression.Validate(bodypageRedirected, nameof(bodypageRedirected), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypublicAccessRules, nameof(bodypublicAccessRules), required: true);
            SourceExpression.Validate(bodypublicAccessRulesEnabled, nameof(bodypublicAccessRulesEnabled), required: true);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: true);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: true);
            SourceExpression.Validate(bodysubCategory, nameof(bodysubCategory), required: true);
            SourceExpression.Validate(bodytemplatePath, nameof(bodytemplatePath), required: true);
            SourceExpression.Validate(bodytranslatedFromId, nameof(bodytranslatedFromId), required: true);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: true);
            SourceExpression.Validate(bodyupdatedById, nameof(bodyupdatedById), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyuseFeaturedImage, nameof(bodyuseFeaturedImage), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["abStatus"] = SourceExpressionConverter.ConvertToken(bodyabStatus);
                bodypropCount++;
                body["abTestId"] = SourceExpressionConverter.ConvertToken(bodyabTestId);
                bodypropCount++;
                body["archivedAt"] = SourceExpressionConverter.ConvertToken(bodyarchivedAt);
                bodypropCount++;
                body["archivedInDashboard"] = SourceExpressionConverter.ConvertToken(bodyarchivedInDashboard);
                bodypropCount++;
                body["attachedStylesheets"] = SourceExpressionConverter.ConvertToken(bodyattachedStylesheets);
                bodypropCount++;
                body["authorName"] = SourceExpressionConverter.ConvertToken(bodyauthorName);
                bodypropCount++;
                body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                bodypropCount++;
                body["contentGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentGroupId);
                bodypropCount++;
                body["contentTypeCategory"] = SourceExpressionConverter.ConvertToken(bodycontentTypeCategory);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                bodypropCount++;
                body["createdById"] = SourceExpressionConverter.ConvertToken(bodycreatedById);
                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                bodypropCount++;
                body["currentlyPublished"] = SourceExpressionConverter.ConvertToken(bodycurrentlyPublished);
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
                body["dynamicPageDataSourceId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceId);
                bodypropCount++;
                body["dynamicPageDataSourceType"] = SourceExpressionConverter.ConvertToken(bodydynamicPageDataSourceType);
                bodypropCount++;
                body["dynamicPageHubDbTableId"] = SourceExpressionConverter.ConvertToken(bodydynamicPageHubDbTableId);
                bodypropCount++;
                body["enableDomainStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableDomainStylesheets);
                bodypropCount++;
                body["enableLayoutStylesheets"] = SourceExpressionConverter.ConvertToken(bodyenableLayoutStylesheets);
                bodypropCount++;
                body["featuredImage"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImage);
                bodypropCount++;
                body["featuredImageAltText"] = SourceExpressionConverter.ConvertToken(bodyfeaturedImageAltText);
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["footerHtml"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
                body["headHtml"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
                body["htmlTitle"] = SourceExpressionConverter.ConvertToken(bodyhtmlTitle);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["includeDefaultCustomCss"] = SourceExpressionConverter.ConvertToken(bodyincludeDefaultCustomCss);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                var layoutSectionsObject = new JObject();
                var layoutSectionsObjectpropCount = 0;
                if (layoutSectionsObjectpropCount > 0)
                {
                    body["layoutSections"] = layoutSectionsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["linkRelCanonicalUrl"] = SourceExpressionConverter.ConvertToken(bodylinkRelCanonicalUrl);
                bodypropCount++;
                body["mabExperimentId"] = SourceExpressionConverter.ConvertToken(bodymabExperimentId);
                bodypropCount++;
                body["metaDescription"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pageExpiryDate"] = SourceExpressionConverter.ConvertToken(bodypageExpiryDate);
                bodypropCount++;
                body["pageExpiryEnabled"] = SourceExpressionConverter.ConvertToken(bodypageExpiryEnabled);
                bodypropCount++;
                body["pageExpiryRedirectId"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectId);
                bodypropCount++;
                body["pageExpiryRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodypageExpiryRedirectUrl);
                bodypropCount++;
                body["pageRedirected"] = SourceExpressionConverter.ConvertToken(bodypageRedirected);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["publicAccessRules"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRules);
                bodypropCount++;
                body["publicAccessRulesEnabled"] = SourceExpressionConverter.ConvertToken(bodypublicAccessRulesEnabled);
                bodypropCount++;
                body["publishDate"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
                body["publishImmediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
                body["subCategory"] = SourceExpressionConverter.ConvertToken(bodysubCategory);
                bodypropCount++;
                body["templatePath"] = SourceExpressionConverter.ConvertToken(bodytemplatePath);
                var themeSettingsValuesObject = new JObject();
                var themeSettingsValuesObjectpropCount = 0;
                if (themeSettingsValuesObjectpropCount > 0)
                {
                    body["themeSettingsValues"] = themeSettingsValuesObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["translatedFromId"] = SourceExpressionConverter.ConvertToken(bodytranslatedFromId);
                var translationsObject = new JObject();
                var translationsObjectpropCount = 0;
                if (translationsObjectpropCount > 0)
                {
                    body["translations"] = translationsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                bodypropCount++;
                body["updatedById"] = SourceExpressionConverter.ConvertToken(bodyupdatedById);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["useFeaturedImage"] = SourceExpressionConverter.ConvertToken(bodyuseFeaturedImage);
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
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> PostCreateanewlanguagevariation4([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyprimaryLanguage)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodyprimaryLanguage, nameof(bodyprimaryLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
                body["primaryLanguage"] = SourceExpressionConverter.ConvertToken(bodyprimaryLanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction DeleteabatchofLandingPages([WorkflowExpression] Func<string[]> bodyinputs)
        {
            SourceExpression.Validate(bodyinputs, nameof(bodyinputs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/landing-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputs"] = SourceExpressionConverter.ConvertToken(bodyinputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63> RestoreapreviousversionofaLandingPagetothedraftversionoftheLandingPage([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> revisionId)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(revisionId, nameof(revisionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore-to-draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(revisionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Successfuloperation63>(BuildSourceInput);
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