//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstoreconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppstoreconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appstoreconnect")]
        public IBodyWorkflowAction<AppsAndAppMetadataListAppsResponse, ApiConnectionActionConfiguration> AppsAndAppMetadataListApps(Expression<Func<string>> serviceToken, Expression<Func<fieldsAppsInput>> fieldsApps = null, Expression<Func<fieldsBetaLicenseAgreementsInput>> fieldsBetaLicenseAgreements = null, Expression<Func<fieldsPreReleaseVersionsInput>> fieldsPreReleaseVersions = null, Expression<Func<fieldsBetaAppReviewDetailsInput>> fieldsBetaAppReviewDetails = null, Expression<Func<fieldsBetaAppLocalizationsInput>> fieldsBetaAppLocalizations = null, Expression<Func<fieldsBuildsInput>> fieldsBuilds = null, Expression<Func<fieldsBetaGroupsInput>> fieldsBetaGroups = null, Expression<Func<fieldsEndUserLicenseAgreementsInput>> fieldsEndUserLicenseAgreements = null, Expression<Func<fieldsAppStoreVersionsInput>> fieldsAppStoreVersions = null, Expression<Func<fieldsAppInfosInput>> fieldsAppInfos = null, Expression<Func<fieldsPerfPowerMetricsInput>> fieldsPerfPowerMetrics = null, Expression<Func<fieldsInAppPurchasesInput>> fieldsInAppPurchases = null, Expression<Func<fieldsCiProductsInput>> fieldsCiProducts = null, Expression<Func<fieldsAppClipsInput>> fieldsAppClips = null, Expression<Func<fieldsReviewSubmissionsInput>> fieldsReviewSubmissions = null, Expression<Func<fieldsAppCustomProductPagesInput>> fieldsAppCustomProductPages = null, Expression<Func<fieldsAppEventsInput>> fieldsAppEvents = null, Expression<Func<fieldsAppPricePointsInput>> fieldsAppPricePoints = null, Expression<Func<fieldsCustomerReviewsInput>> fieldsCustomerReviews = null, Expression<Func<fieldsSubscriptionGracePeriodsInput>> fieldsSubscriptionGracePeriods = null, Expression<Func<fieldsPromotedPurchasesInput>> fieldsPromotedPurchases = null, Expression<Func<fieldsSubscriptionGroupsInput>> fieldsSubscriptionGroups = null, Expression<Func<fieldsAppPriceSchedulesInput>> fieldsAppPriceSchedules = null, Expression<Func<fieldsAppStoreVersionExperimentsInput>> fieldsAppStoreVersionExperiments = null, Expression<Func<fieldsAppEncryptionDeclarationsInput>> fieldsAppEncryptionDeclarations = null, Expression<Func<fieldsGameCenterDetailsInput>> fieldsGameCenterDetails = null, Expression<Func<includeInput>> include = null, Expression<Func<string>> filterBundleId = null, Expression<Func<string>> filterId = null, Expression<Func<string>> filterName = null, Expression<Func<string>> filterSku = null, Expression<Func<string>> filterAppStoreVersions = null, Expression<Func<filterAppStoreVersionsPlatformInput>> filterAppStoreVersionsPlatform = null, Expression<Func<filterAppStoreVersionsAppStoreStateInput>> filterAppStoreVersionsAppStoreState = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limitPreReleaseVersions = null, Expression<Func<int>> limitBuilds = null, Expression<Func<int>> limitBetaGroups = null, Expression<Func<int>> limitBetaAppLocalizations = null, Expression<Func<int>> limitAvailableTerritories = null, Expression<Func<int>> limitAppStoreVersions = null, Expression<Func<int>> limitAppInfos = null, Expression<Func<int>> limitAppClips = null, Expression<Func<int>> limitAppCustomProductPages = null, Expression<Func<int>> limitAppEvents = null, Expression<Func<int>> limitReviewSubmissions = null, Expression<Func<int>> limitInAppPurchasesV2 = null, Expression<Func<int>> limitPromotedPurchases = null, Expression<Func<int>> limitSubscriptionGroups = null, Expression<Func<int>> limitAppStoreVersionExperimentsV2 = null, Expression<Func<int>> limitAppEncryptionDeclarations = null)
        {
            var __workflow_serviceToken = WorkflowExpression.Compile(serviceToken, nameof(serviceToken), required: true);
            var __workflow_fieldsApps = WorkflowExpression.Compile(fieldsApps, nameof(fieldsApps), required: false);
            var __workflow_fieldsBetaLicenseAgreements = WorkflowExpression.Compile(fieldsBetaLicenseAgreements, nameof(fieldsBetaLicenseAgreements), required: false);
            var __workflow_fieldsPreReleaseVersions = WorkflowExpression.Compile(fieldsPreReleaseVersions, nameof(fieldsPreReleaseVersions), required: false);
            var __workflow_fieldsBetaAppReviewDetails = WorkflowExpression.Compile(fieldsBetaAppReviewDetails, nameof(fieldsBetaAppReviewDetails), required: false);
            var __workflow_fieldsBetaAppLocalizations = WorkflowExpression.Compile(fieldsBetaAppLocalizations, nameof(fieldsBetaAppLocalizations), required: false);
            var __workflow_fieldsBuilds = WorkflowExpression.Compile(fieldsBuilds, nameof(fieldsBuilds), required: false);
            var __workflow_fieldsBetaGroups = WorkflowExpression.Compile(fieldsBetaGroups, nameof(fieldsBetaGroups), required: false);
            var __workflow_fieldsEndUserLicenseAgreements = WorkflowExpression.Compile(fieldsEndUserLicenseAgreements, nameof(fieldsEndUserLicenseAgreements), required: false);
            var __workflow_fieldsAppStoreVersions = WorkflowExpression.Compile(fieldsAppStoreVersions, nameof(fieldsAppStoreVersions), required: false);
            var __workflow_fieldsAppInfos = WorkflowExpression.Compile(fieldsAppInfos, nameof(fieldsAppInfos), required: false);
            var __workflow_fieldsPerfPowerMetrics = WorkflowExpression.Compile(fieldsPerfPowerMetrics, nameof(fieldsPerfPowerMetrics), required: false);
            var __workflow_fieldsInAppPurchases = WorkflowExpression.Compile(fieldsInAppPurchases, nameof(fieldsInAppPurchases), required: false);
            var __workflow_fieldsCiProducts = WorkflowExpression.Compile(fieldsCiProducts, nameof(fieldsCiProducts), required: false);
            var __workflow_fieldsAppClips = WorkflowExpression.Compile(fieldsAppClips, nameof(fieldsAppClips), required: false);
            var __workflow_fieldsReviewSubmissions = WorkflowExpression.Compile(fieldsReviewSubmissions, nameof(fieldsReviewSubmissions), required: false);
            var __workflow_fieldsAppCustomProductPages = WorkflowExpression.Compile(fieldsAppCustomProductPages, nameof(fieldsAppCustomProductPages), required: false);
            var __workflow_fieldsAppEvents = WorkflowExpression.Compile(fieldsAppEvents, nameof(fieldsAppEvents), required: false);
            var __workflow_fieldsAppPricePoints = WorkflowExpression.Compile(fieldsAppPricePoints, nameof(fieldsAppPricePoints), required: false);
            var __workflow_fieldsCustomerReviews = WorkflowExpression.Compile(fieldsCustomerReviews, nameof(fieldsCustomerReviews), required: false);
            var __workflow_fieldsSubscriptionGracePeriods = WorkflowExpression.Compile(fieldsSubscriptionGracePeriods, nameof(fieldsSubscriptionGracePeriods), required: false);
            var __workflow_fieldsPromotedPurchases = WorkflowExpression.Compile(fieldsPromotedPurchases, nameof(fieldsPromotedPurchases), required: false);
            var __workflow_fieldsSubscriptionGroups = WorkflowExpression.Compile(fieldsSubscriptionGroups, nameof(fieldsSubscriptionGroups), required: false);
            var __workflow_fieldsAppPriceSchedules = WorkflowExpression.Compile(fieldsAppPriceSchedules, nameof(fieldsAppPriceSchedules), required: false);
            var __workflow_fieldsAppStoreVersionExperiments = WorkflowExpression.Compile(fieldsAppStoreVersionExperiments, nameof(fieldsAppStoreVersionExperiments), required: false);
            var __workflow_fieldsAppEncryptionDeclarations = WorkflowExpression.Compile(fieldsAppEncryptionDeclarations, nameof(fieldsAppEncryptionDeclarations), required: false);
            var __workflow_fieldsGameCenterDetails = WorkflowExpression.Compile(fieldsGameCenterDetails, nameof(fieldsGameCenterDetails), required: false);
            var __workflow_include = WorkflowExpression.Compile(include, nameof(include), required: false);
            var __workflow_filterBundleId = WorkflowExpression.Compile(filterBundleId, nameof(filterBundleId), required: false);
            var __workflow_filterId = WorkflowExpression.Compile(filterId, nameof(filterId), required: false);
            var __workflow_filterName = WorkflowExpression.Compile(filterName, nameof(filterName), required: false);
            var __workflow_filterSku = WorkflowExpression.Compile(filterSku, nameof(filterSku), required: false);
            var __workflow_filterAppStoreVersions = WorkflowExpression.Compile(filterAppStoreVersions, nameof(filterAppStoreVersions), required: false);
            var __workflow_filterAppStoreVersionsPlatform = WorkflowExpression.Compile(filterAppStoreVersionsPlatform, nameof(filterAppStoreVersionsPlatform), required: false);
            var __workflow_filterAppStoreVersionsAppStoreState = WorkflowExpression.Compile(filterAppStoreVersionsAppStoreState, nameof(filterAppStoreVersionsAppStoreState), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_limitPreReleaseVersions = WorkflowExpression.Compile(limitPreReleaseVersions, nameof(limitPreReleaseVersions), required: false);
            var __workflow_limitBuilds = WorkflowExpression.Compile(limitBuilds, nameof(limitBuilds), required: false);
            var __workflow_limitBetaGroups = WorkflowExpression.Compile(limitBetaGroups, nameof(limitBetaGroups), required: false);
            var __workflow_limitBetaAppLocalizations = WorkflowExpression.Compile(limitBetaAppLocalizations, nameof(limitBetaAppLocalizations), required: false);
            var __workflow_limitAvailableTerritories = WorkflowExpression.Compile(limitAvailableTerritories, nameof(limitAvailableTerritories), required: false);
            var __workflow_limitAppStoreVersions = WorkflowExpression.Compile(limitAppStoreVersions, nameof(limitAppStoreVersions), required: false);
            var __workflow_limitAppInfos = WorkflowExpression.Compile(limitAppInfos, nameof(limitAppInfos), required: false);
            var __workflow_limitAppClips = WorkflowExpression.Compile(limitAppClips, nameof(limitAppClips), required: false);
            var __workflow_limitAppCustomProductPages = WorkflowExpression.Compile(limitAppCustomProductPages, nameof(limitAppCustomProductPages), required: false);
            var __workflow_limitAppEvents = WorkflowExpression.Compile(limitAppEvents, nameof(limitAppEvents), required: false);
            var __workflow_limitReviewSubmissions = WorkflowExpression.Compile(limitReviewSubmissions, nameof(limitReviewSubmissions), required: false);
            var __workflow_limitInAppPurchasesV2 = WorkflowExpression.Compile(limitInAppPurchasesV2, nameof(limitInAppPurchasesV2), required: false);
            var __workflow_limitPromotedPurchases = WorkflowExpression.Compile(limitPromotedPurchases, nameof(limitPromotedPurchases), required: false);
            var __workflow_limitSubscriptionGroups = WorkflowExpression.Compile(limitSubscriptionGroups, nameof(limitSubscriptionGroups), required: false);
            var __workflow_limitAppStoreVersionExperimentsV2 = WorkflowExpression.Compile(limitAppStoreVersionExperimentsV2, nameof(limitAppStoreVersionExperimentsV2), required: false);
            var __workflow_limitAppEncryptionDeclarations = WorkflowExpression.Compile(limitAppEncryptionDeclarations, nameof(limitAppEncryptionDeclarations), required: false);
            return new DeferredBodyAction<AppsAndAppMetadataListAppsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/apps";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fieldsApps != null)
                    callPayload.Queries["fields[apps]"] = ExpressionConverter.Convert(__workflow_fieldsApps);
                if (__workflow_fieldsBetaLicenseAgreements != null)
                    callPayload.Queries["fields[betaLicenseAgreements]"] = ExpressionConverter.Convert(__workflow_fieldsBetaLicenseAgreements);
                if (__workflow_fieldsPreReleaseVersions != null)
                    callPayload.Queries["fields[preReleaseVersions]"] = ExpressionConverter.Convert(__workflow_fieldsPreReleaseVersions);
                if (__workflow_fieldsBetaAppReviewDetails != null)
                    callPayload.Queries["fields[betaAppReviewDetails]"] = ExpressionConverter.Convert(__workflow_fieldsBetaAppReviewDetails);
                if (__workflow_fieldsBetaAppLocalizations != null)
                    callPayload.Queries["fields[betaAppLocalizations]"] = ExpressionConverter.Convert(__workflow_fieldsBetaAppLocalizations);
                if (__workflow_fieldsBuilds != null)
                    callPayload.Queries["fields[builds]"] = ExpressionConverter.Convert(__workflow_fieldsBuilds);
                if (__workflow_fieldsBetaGroups != null)
                    callPayload.Queries["fields[betaGroups]"] = ExpressionConverter.Convert(__workflow_fieldsBetaGroups);
                if (__workflow_fieldsEndUserLicenseAgreements != null)
                    callPayload.Queries["fields[endUserLicenseAgreements]"] = ExpressionConverter.Convert(__workflow_fieldsEndUserLicenseAgreements);
                if (__workflow_fieldsAppStoreVersions != null)
                    callPayload.Queries["fields[appStoreVersions]"] = ExpressionConverter.Convert(__workflow_fieldsAppStoreVersions);
                if (__workflow_fieldsAppInfos != null)
                    callPayload.Queries["fields[appInfos]"] = ExpressionConverter.Convert(__workflow_fieldsAppInfos);
                if (__workflow_fieldsPerfPowerMetrics != null)
                    callPayload.Queries["fields[perfPowerMetrics]"] = ExpressionConverter.Convert(__workflow_fieldsPerfPowerMetrics);
                if (__workflow_fieldsInAppPurchases != null)
                    callPayload.Queries["fields[inAppPurchases]"] = ExpressionConverter.Convert(__workflow_fieldsInAppPurchases);
                if (__workflow_fieldsCiProducts != null)
                    callPayload.Queries["fields[ciProducts]"] = ExpressionConverter.Convert(__workflow_fieldsCiProducts);
                if (__workflow_fieldsAppClips != null)
                    callPayload.Queries["fields[appClips]"] = ExpressionConverter.Convert(__workflow_fieldsAppClips);
                if (__workflow_fieldsReviewSubmissions != null)
                    callPayload.Queries["fields[reviewSubmissions]"] = ExpressionConverter.Convert(__workflow_fieldsReviewSubmissions);
                if (__workflow_fieldsAppCustomProductPages != null)
                    callPayload.Queries["fields[appCustomProductPages]"] = ExpressionConverter.Convert(__workflow_fieldsAppCustomProductPages);
                if (__workflow_fieldsAppEvents != null)
                    callPayload.Queries["fields[appEvents]"] = ExpressionConverter.Convert(__workflow_fieldsAppEvents);
                if (__workflow_fieldsAppPricePoints != null)
                    callPayload.Queries["fields[appPricePoints]"] = ExpressionConverter.Convert(__workflow_fieldsAppPricePoints);
                if (__workflow_fieldsCustomerReviews != null)
                    callPayload.Queries["fields[customerReviews]"] = ExpressionConverter.Convert(__workflow_fieldsCustomerReviews);
                if (__workflow_fieldsSubscriptionGracePeriods != null)
                    callPayload.Queries["fields[subscriptionGracePeriods]"] = ExpressionConverter.Convert(__workflow_fieldsSubscriptionGracePeriods);
                if (__workflow_fieldsPromotedPurchases != null)
                    callPayload.Queries["fields[promotedPurchases]"] = ExpressionConverter.Convert(__workflow_fieldsPromotedPurchases);
                if (__workflow_fieldsSubscriptionGroups != null)
                    callPayload.Queries["fields[subscriptionGroups]"] = ExpressionConverter.Convert(__workflow_fieldsSubscriptionGroups);
                if (__workflow_fieldsAppPriceSchedules != null)
                    callPayload.Queries["fields[appPriceSchedules]"] = ExpressionConverter.Convert(__workflow_fieldsAppPriceSchedules);
                if (__workflow_fieldsAppStoreVersionExperiments != null)
                    callPayload.Queries["fields[appStoreVersionExperiments]"] = ExpressionConverter.Convert(__workflow_fieldsAppStoreVersionExperiments);
                if (__workflow_fieldsAppEncryptionDeclarations != null)
                    callPayload.Queries["fields[appEncryptionDeclarations]"] = ExpressionConverter.Convert(__workflow_fieldsAppEncryptionDeclarations);
                if (__workflow_fieldsGameCenterDetails != null)
                    callPayload.Queries["fields[gameCenterDetails]"] = ExpressionConverter.Convert(__workflow_fieldsGameCenterDetails);
                if (__workflow_include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
                if (__workflow_filterBundleId != null)
                    callPayload.Queries["filter[bundleId]"] = ExpressionConverter.Convert(__workflow_filterBundleId);
                if (__workflow_filterId != null)
                    callPayload.Queries["filter[id]"] = ExpressionConverter.Convert(__workflow_filterId);
                if (__workflow_filterName != null)
                    callPayload.Queries["filter[name]"] = ExpressionConverter.Convert(__workflow_filterName);
                if (__workflow_filterSku != null)
                    callPayload.Queries["filter[sku]"] = ExpressionConverter.Convert(__workflow_filterSku);
                if (__workflow_filterAppStoreVersions != null)
                    callPayload.Queries["filter[appStoreVersions]"] = ExpressionConverter.Convert(__workflow_filterAppStoreVersions);
                if (__workflow_filterAppStoreVersionsPlatform != null)
                    callPayload.Queries["filter[appStoreVersions.platform]"] = ExpressionConverter.Convert(__workflow_filterAppStoreVersionsPlatform);
                if (__workflow_filterAppStoreVersionsAppStoreState != null)
                    callPayload.Queries["filter[appStoreVersions.appStoreState]"] = ExpressionConverter.Convert(__workflow_filterAppStoreVersionsAppStoreState);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_limitPreReleaseVersions != null)
                    callPayload.Queries["limit[preReleaseVersions]"] = ExpressionConverter.Convert(__workflow_limitPreReleaseVersions);
                if (__workflow_limitBuilds != null)
                    callPayload.Queries["limit[builds]"] = ExpressionConverter.Convert(__workflow_limitBuilds);
                if (__workflow_limitBetaGroups != null)
                    callPayload.Queries["limit[betaGroups]"] = ExpressionConverter.Convert(__workflow_limitBetaGroups);
                if (__workflow_limitBetaAppLocalizations != null)
                    callPayload.Queries["limit[betaAppLocalizations]"] = ExpressionConverter.Convert(__workflow_limitBetaAppLocalizations);
                if (__workflow_limitAvailableTerritories != null)
                    callPayload.Queries["limit[availableTerritories]"] = ExpressionConverter.Convert(__workflow_limitAvailableTerritories);
                if (__workflow_limitAppStoreVersions != null)
                    callPayload.Queries["limit[appStoreVersions]"] = ExpressionConverter.Convert(__workflow_limitAppStoreVersions);
                if (__workflow_limitAppInfos != null)
                    callPayload.Queries["limit[appInfos]"] = ExpressionConverter.Convert(__workflow_limitAppInfos);
                if (__workflow_limitAppClips != null)
                    callPayload.Queries["limit[appClips]"] = ExpressionConverter.Convert(__workflow_limitAppClips);
                if (__workflow_limitAppCustomProductPages != null)
                    callPayload.Queries["limit[appCustomProductPages]"] = ExpressionConverter.Convert(__workflow_limitAppCustomProductPages);
                if (__workflow_limitAppEvents != null)
                    callPayload.Queries["limit[appEvents]"] = ExpressionConverter.Convert(__workflow_limitAppEvents);
                if (__workflow_limitReviewSubmissions != null)
                    callPayload.Queries["limit[reviewSubmissions]"] = ExpressionConverter.Convert(__workflow_limitReviewSubmissions);
                if (__workflow_limitInAppPurchasesV2 != null)
                    callPayload.Queries["limit[inAppPurchasesV2]"] = ExpressionConverter.Convert(__workflow_limitInAppPurchasesV2);
                if (__workflow_limitPromotedPurchases != null)
                    callPayload.Queries["limit[promotedPurchases]"] = ExpressionConverter.Convert(__workflow_limitPromotedPurchases);
                if (__workflow_limitSubscriptionGroups != null)
                    callPayload.Queries["limit[subscriptionGroups]"] = ExpressionConverter.Convert(__workflow_limitSubscriptionGroups);
                if (__workflow_limitAppStoreVersionExperimentsV2 != null)
                    callPayload.Queries["limit[appStoreVersionExperimentsV2]"] = ExpressionConverter.Convert(__workflow_limitAppStoreVersionExperimentsV2);
                if (__workflow_limitAppEncryptionDeclarations != null)
                    callPayload.Queries["limit[appEncryptionDeclarations]"] = ExpressionConverter.Convert(__workflow_limitAppEncryptionDeclarations);
                callPayload.Headers["Service-Token"] = ExpressionConverter.Convert(__workflow_serviceToken);
                return new ApiConnectionAction<AppsAndAppMetadataListAppsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appstoreconnect")]
        public IBodyWorkflowAction<AppsAndAppMetadataReadAppInformationResponse, ApiConnectionActionConfiguration> AppsAndAppMetadataReadAppInformation(Expression<Func<string>> id, Expression<Func<string>> serviceToken, Expression<Func<fieldsAppsInput>> fieldsApps = null, Expression<Func<fieldsBetaLicenseAgreementsInput>> fieldsBetaLicenseAgreements = null, Expression<Func<fieldsPreReleaseVersionsInput>> fieldsPreReleaseVersions = null, Expression<Func<fieldsBetaAppReviewDetailsInput>> fieldsBetaAppReviewDetails = null, Expression<Func<fieldsBetaAppLocalizationsInput>> fieldsBetaAppLocalizations = null, Expression<Func<fieldsBuildsInput>> fieldsBuilds = null, Expression<Func<fieldsBetaGroupsInput>> fieldsBetaGroups = null, Expression<Func<fieldsEndUserLicenseAgreementsInput>> fieldsEndUserLicenseAgreements = null, Expression<Func<fieldsAppStoreVersionsInput>> fieldsAppStoreVersions = null, Expression<Func<fieldsAppInfosInput>> fieldsAppInfos = null, Expression<Func<fieldsPerfPowerMetricsInput>> fieldsPerfPowerMetrics = null, Expression<Func<fieldsInAppPurchasesInput>> fieldsInAppPurchases = null, Expression<Func<fieldsCiProductsInput>> fieldsCiProducts = null, Expression<Func<fieldsAppClipsInput>> fieldsAppClips = null, Expression<Func<fieldsReviewSubmissionsInput>> fieldsReviewSubmissions = null, Expression<Func<fieldsAppCustomProductPagesInput>> fieldsAppCustomProductPages = null, Expression<Func<fieldsAppEventsInput>> fieldsAppEvents = null, Expression<Func<fieldsAppPricePointsInput>> fieldsAppPricePoints = null, Expression<Func<fieldsCustomerReviewsInput>> fieldsCustomerReviews = null, Expression<Func<fieldsSubscriptionGracePeriodsInput>> fieldsSubscriptionGracePeriods = null, Expression<Func<fieldsPromotedPurchasesInput>> fieldsPromotedPurchases = null, Expression<Func<fieldsSubscriptionGroupsInput>> fieldsSubscriptionGroups = null, Expression<Func<fieldsAppPriceSchedulesInput>> fieldsAppPriceSchedules = null, Expression<Func<fieldsAppStoreVersionExperimentsInput>> fieldsAppStoreVersionExperiments = null, Expression<Func<fieldsAppEncryptionDeclarationsInput>> fieldsAppEncryptionDeclarations = null, Expression<Func<fieldsGameCenterDetailsInput>> fieldsGameCenterDetails = null, Expression<Func<includeInput>> include = null, Expression<Func<int>> limitPreReleaseVersions = null, Expression<Func<int>> limitBuilds = null, Expression<Func<int>> limitBetaGroups = null, Expression<Func<int>> limitBetaAppLocalizations = null, Expression<Func<int>> limitAvailableTerritories = null, Expression<Func<int>> limitAppStoreVersions = null, Expression<Func<int>> limitAppInfos = null, Expression<Func<int>> limitAppClips = null, Expression<Func<int>> limitAppCustomProductPages = null, Expression<Func<int>> limitAppEvents = null, Expression<Func<int>> limitReviewSubmissions = null, Expression<Func<int>> limitInAppPurchasesV2 = null, Expression<Func<int>> limitPromotedPurchases = null, Expression<Func<int>> limitSubscriptionGroups = null, Expression<Func<int>> limitAppStoreVersionExperimentsV2 = null, Expression<Func<int>> limitAppEncryptionDeclarations = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_serviceToken = WorkflowExpression.Compile(serviceToken, nameof(serviceToken), required: true);
            var __workflow_fieldsApps = WorkflowExpression.Compile(fieldsApps, nameof(fieldsApps), required: false);
            var __workflow_fieldsBetaLicenseAgreements = WorkflowExpression.Compile(fieldsBetaLicenseAgreements, nameof(fieldsBetaLicenseAgreements), required: false);
            var __workflow_fieldsPreReleaseVersions = WorkflowExpression.Compile(fieldsPreReleaseVersions, nameof(fieldsPreReleaseVersions), required: false);
            var __workflow_fieldsBetaAppReviewDetails = WorkflowExpression.Compile(fieldsBetaAppReviewDetails, nameof(fieldsBetaAppReviewDetails), required: false);
            var __workflow_fieldsBetaAppLocalizations = WorkflowExpression.Compile(fieldsBetaAppLocalizations, nameof(fieldsBetaAppLocalizations), required: false);
            var __workflow_fieldsBuilds = WorkflowExpression.Compile(fieldsBuilds, nameof(fieldsBuilds), required: false);
            var __workflow_fieldsBetaGroups = WorkflowExpression.Compile(fieldsBetaGroups, nameof(fieldsBetaGroups), required: false);
            var __workflow_fieldsEndUserLicenseAgreements = WorkflowExpression.Compile(fieldsEndUserLicenseAgreements, nameof(fieldsEndUserLicenseAgreements), required: false);
            var __workflow_fieldsAppStoreVersions = WorkflowExpression.Compile(fieldsAppStoreVersions, nameof(fieldsAppStoreVersions), required: false);
            var __workflow_fieldsAppInfos = WorkflowExpression.Compile(fieldsAppInfos, nameof(fieldsAppInfos), required: false);
            var __workflow_fieldsPerfPowerMetrics = WorkflowExpression.Compile(fieldsPerfPowerMetrics, nameof(fieldsPerfPowerMetrics), required: false);
            var __workflow_fieldsInAppPurchases = WorkflowExpression.Compile(fieldsInAppPurchases, nameof(fieldsInAppPurchases), required: false);
            var __workflow_fieldsCiProducts = WorkflowExpression.Compile(fieldsCiProducts, nameof(fieldsCiProducts), required: false);
            var __workflow_fieldsAppClips = WorkflowExpression.Compile(fieldsAppClips, nameof(fieldsAppClips), required: false);
            var __workflow_fieldsReviewSubmissions = WorkflowExpression.Compile(fieldsReviewSubmissions, nameof(fieldsReviewSubmissions), required: false);
            var __workflow_fieldsAppCustomProductPages = WorkflowExpression.Compile(fieldsAppCustomProductPages, nameof(fieldsAppCustomProductPages), required: false);
            var __workflow_fieldsAppEvents = WorkflowExpression.Compile(fieldsAppEvents, nameof(fieldsAppEvents), required: false);
            var __workflow_fieldsAppPricePoints = WorkflowExpression.Compile(fieldsAppPricePoints, nameof(fieldsAppPricePoints), required: false);
            var __workflow_fieldsCustomerReviews = WorkflowExpression.Compile(fieldsCustomerReviews, nameof(fieldsCustomerReviews), required: false);
            var __workflow_fieldsSubscriptionGracePeriods = WorkflowExpression.Compile(fieldsSubscriptionGracePeriods, nameof(fieldsSubscriptionGracePeriods), required: false);
            var __workflow_fieldsPromotedPurchases = WorkflowExpression.Compile(fieldsPromotedPurchases, nameof(fieldsPromotedPurchases), required: false);
            var __workflow_fieldsSubscriptionGroups = WorkflowExpression.Compile(fieldsSubscriptionGroups, nameof(fieldsSubscriptionGroups), required: false);
            var __workflow_fieldsAppPriceSchedules = WorkflowExpression.Compile(fieldsAppPriceSchedules, nameof(fieldsAppPriceSchedules), required: false);
            var __workflow_fieldsAppStoreVersionExperiments = WorkflowExpression.Compile(fieldsAppStoreVersionExperiments, nameof(fieldsAppStoreVersionExperiments), required: false);
            var __workflow_fieldsAppEncryptionDeclarations = WorkflowExpression.Compile(fieldsAppEncryptionDeclarations, nameof(fieldsAppEncryptionDeclarations), required: false);
            var __workflow_fieldsGameCenterDetails = WorkflowExpression.Compile(fieldsGameCenterDetails, nameof(fieldsGameCenterDetails), required: false);
            var __workflow_include = WorkflowExpression.Compile(include, nameof(include), required: false);
            var __workflow_limitPreReleaseVersions = WorkflowExpression.Compile(limitPreReleaseVersions, nameof(limitPreReleaseVersions), required: false);
            var __workflow_limitBuilds = WorkflowExpression.Compile(limitBuilds, nameof(limitBuilds), required: false);
            var __workflow_limitBetaGroups = WorkflowExpression.Compile(limitBetaGroups, nameof(limitBetaGroups), required: false);
            var __workflow_limitBetaAppLocalizations = WorkflowExpression.Compile(limitBetaAppLocalizations, nameof(limitBetaAppLocalizations), required: false);
            var __workflow_limitAvailableTerritories = WorkflowExpression.Compile(limitAvailableTerritories, nameof(limitAvailableTerritories), required: false);
            var __workflow_limitAppStoreVersions = WorkflowExpression.Compile(limitAppStoreVersions, nameof(limitAppStoreVersions), required: false);
            var __workflow_limitAppInfos = WorkflowExpression.Compile(limitAppInfos, nameof(limitAppInfos), required: false);
            var __workflow_limitAppClips = WorkflowExpression.Compile(limitAppClips, nameof(limitAppClips), required: false);
            var __workflow_limitAppCustomProductPages = WorkflowExpression.Compile(limitAppCustomProductPages, nameof(limitAppCustomProductPages), required: false);
            var __workflow_limitAppEvents = WorkflowExpression.Compile(limitAppEvents, nameof(limitAppEvents), required: false);
            var __workflow_limitReviewSubmissions = WorkflowExpression.Compile(limitReviewSubmissions, nameof(limitReviewSubmissions), required: false);
            var __workflow_limitInAppPurchasesV2 = WorkflowExpression.Compile(limitInAppPurchasesV2, nameof(limitInAppPurchasesV2), required: false);
            var __workflow_limitPromotedPurchases = WorkflowExpression.Compile(limitPromotedPurchases, nameof(limitPromotedPurchases), required: false);
            var __workflow_limitSubscriptionGroups = WorkflowExpression.Compile(limitSubscriptionGroups, nameof(limitSubscriptionGroups), required: false);
            var __workflow_limitAppStoreVersionExperimentsV2 = WorkflowExpression.Compile(limitAppStoreVersionExperimentsV2, nameof(limitAppStoreVersionExperimentsV2), required: false);
            var __workflow_limitAppEncryptionDeclarations = WorkflowExpression.Compile(limitAppEncryptionDeclarations, nameof(limitAppEncryptionDeclarations), required: false);
            return new DeferredBodyAction<AppsAndAppMetadataReadAppInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/apps/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fieldsApps != null)
                    callPayload.Queries["fields[apps]"] = ExpressionConverter.Convert(__workflow_fieldsApps);
                if (__workflow_fieldsBetaLicenseAgreements != null)
                    callPayload.Queries["fields[betaLicenseAgreements]"] = ExpressionConverter.Convert(__workflow_fieldsBetaLicenseAgreements);
                if (__workflow_fieldsPreReleaseVersions != null)
                    callPayload.Queries["fields[preReleaseVersions]"] = ExpressionConverter.Convert(__workflow_fieldsPreReleaseVersions);
                if (__workflow_fieldsBetaAppReviewDetails != null)
                    callPayload.Queries["fields[betaAppReviewDetails]"] = ExpressionConverter.Convert(__workflow_fieldsBetaAppReviewDetails);
                if (__workflow_fieldsBetaAppLocalizations != null)
                    callPayload.Queries["fields[betaAppLocalizations]"] = ExpressionConverter.Convert(__workflow_fieldsBetaAppLocalizations);
                if (__workflow_fieldsBuilds != null)
                    callPayload.Queries["fields[builds]"] = ExpressionConverter.Convert(__workflow_fieldsBuilds);
                if (__workflow_fieldsBetaGroups != null)
                    callPayload.Queries["fields[betaGroups]"] = ExpressionConverter.Convert(__workflow_fieldsBetaGroups);
                if (__workflow_fieldsEndUserLicenseAgreements != null)
                    callPayload.Queries["fields[endUserLicenseAgreements]"] = ExpressionConverter.Convert(__workflow_fieldsEndUserLicenseAgreements);
                if (__workflow_fieldsAppStoreVersions != null)
                    callPayload.Queries["fields[appStoreVersions]"] = ExpressionConverter.Convert(__workflow_fieldsAppStoreVersions);
                if (__workflow_fieldsAppInfos != null)
                    callPayload.Queries["fields[appInfos]"] = ExpressionConverter.Convert(__workflow_fieldsAppInfos);
                if (__workflow_fieldsPerfPowerMetrics != null)
                    callPayload.Queries["fields[perfPowerMetrics]"] = ExpressionConverter.Convert(__workflow_fieldsPerfPowerMetrics);
                if (__workflow_fieldsInAppPurchases != null)
                    callPayload.Queries["fields[inAppPurchases]"] = ExpressionConverter.Convert(__workflow_fieldsInAppPurchases);
                if (__workflow_fieldsCiProducts != null)
                    callPayload.Queries["fields[ciProducts]"] = ExpressionConverter.Convert(__workflow_fieldsCiProducts);
                if (__workflow_fieldsAppClips != null)
                    callPayload.Queries["fields[appClips]"] = ExpressionConverter.Convert(__workflow_fieldsAppClips);
                if (__workflow_fieldsReviewSubmissions != null)
                    callPayload.Queries["fields[reviewSubmissions]"] = ExpressionConverter.Convert(__workflow_fieldsReviewSubmissions);
                if (__workflow_fieldsAppCustomProductPages != null)
                    callPayload.Queries["fields[appCustomProductPages]"] = ExpressionConverter.Convert(__workflow_fieldsAppCustomProductPages);
                if (__workflow_fieldsAppEvents != null)
                    callPayload.Queries["fields[appEvents]"] = ExpressionConverter.Convert(__workflow_fieldsAppEvents);
                if (__workflow_fieldsAppPricePoints != null)
                    callPayload.Queries["fields[appPricePoints]"] = ExpressionConverter.Convert(__workflow_fieldsAppPricePoints);
                if (__workflow_fieldsCustomerReviews != null)
                    callPayload.Queries["fields[customerReviews]"] = ExpressionConverter.Convert(__workflow_fieldsCustomerReviews);
                if (__workflow_fieldsSubscriptionGracePeriods != null)
                    callPayload.Queries["fields[subscriptionGracePeriods]"] = ExpressionConverter.Convert(__workflow_fieldsSubscriptionGracePeriods);
                if (__workflow_fieldsPromotedPurchases != null)
                    callPayload.Queries["fields[promotedPurchases]"] = ExpressionConverter.Convert(__workflow_fieldsPromotedPurchases);
                if (__workflow_fieldsSubscriptionGroups != null)
                    callPayload.Queries["fields[subscriptionGroups]"] = ExpressionConverter.Convert(__workflow_fieldsSubscriptionGroups);
                if (__workflow_fieldsAppPriceSchedules != null)
                    callPayload.Queries["fields[appPriceSchedules]"] = ExpressionConverter.Convert(__workflow_fieldsAppPriceSchedules);
                if (__workflow_fieldsAppStoreVersionExperiments != null)
                    callPayload.Queries["fields[appStoreVersionExperiments]"] = ExpressionConverter.Convert(__workflow_fieldsAppStoreVersionExperiments);
                if (__workflow_fieldsAppEncryptionDeclarations != null)
                    callPayload.Queries["fields[appEncryptionDeclarations]"] = ExpressionConverter.Convert(__workflow_fieldsAppEncryptionDeclarations);
                if (__workflow_fieldsGameCenterDetails != null)
                    callPayload.Queries["fields[gameCenterDetails]"] = ExpressionConverter.Convert(__workflow_fieldsGameCenterDetails);
                if (__workflow_include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
                if (__workflow_limitPreReleaseVersions != null)
                    callPayload.Queries["limit[preReleaseVersions]"] = ExpressionConverter.Convert(__workflow_limitPreReleaseVersions);
                if (__workflow_limitBuilds != null)
                    callPayload.Queries["limit[builds]"] = ExpressionConverter.Convert(__workflow_limitBuilds);
                if (__workflow_limitBetaGroups != null)
                    callPayload.Queries["limit[betaGroups]"] = ExpressionConverter.Convert(__workflow_limitBetaGroups);
                if (__workflow_limitBetaAppLocalizations != null)
                    callPayload.Queries["limit[betaAppLocalizations]"] = ExpressionConverter.Convert(__workflow_limitBetaAppLocalizations);
                if (__workflow_limitAvailableTerritories != null)
                    callPayload.Queries["limit[availableTerritories]"] = ExpressionConverter.Convert(__workflow_limitAvailableTerritories);
                if (__workflow_limitAppStoreVersions != null)
                    callPayload.Queries["limit[appStoreVersions]"] = ExpressionConverter.Convert(__workflow_limitAppStoreVersions);
                if (__workflow_limitAppInfos != null)
                    callPayload.Queries["limit[appInfos]"] = ExpressionConverter.Convert(__workflow_limitAppInfos);
                if (__workflow_limitAppClips != null)
                    callPayload.Queries["limit[appClips]"] = ExpressionConverter.Convert(__workflow_limitAppClips);
                if (__workflow_limitAppCustomProductPages != null)
                    callPayload.Queries["limit[appCustomProductPages]"] = ExpressionConverter.Convert(__workflow_limitAppCustomProductPages);
                if (__workflow_limitAppEvents != null)
                    callPayload.Queries["limit[appEvents]"] = ExpressionConverter.Convert(__workflow_limitAppEvents);
                if (__workflow_limitReviewSubmissions != null)
                    callPayload.Queries["limit[reviewSubmissions]"] = ExpressionConverter.Convert(__workflow_limitReviewSubmissions);
                if (__workflow_limitInAppPurchasesV2 != null)
                    callPayload.Queries["limit[inAppPurchasesV2]"] = ExpressionConverter.Convert(__workflow_limitInAppPurchasesV2);
                if (__workflow_limitPromotedPurchases != null)
                    callPayload.Queries["limit[promotedPurchases]"] = ExpressionConverter.Convert(__workflow_limitPromotedPurchases);
                if (__workflow_limitSubscriptionGroups != null)
                    callPayload.Queries["limit[subscriptionGroups]"] = ExpressionConverter.Convert(__workflow_limitSubscriptionGroups);
                if (__workflow_limitAppStoreVersionExperimentsV2 != null)
                    callPayload.Queries["limit[appStoreVersionExperimentsV2]"] = ExpressionConverter.Convert(__workflow_limitAppStoreVersionExperimentsV2);
                if (__workflow_limitAppEncryptionDeclarations != null)
                    callPayload.Queries["limit[appEncryptionDeclarations]"] = ExpressionConverter.Convert(__workflow_limitAppEncryptionDeclarations);
                callPayload.Headers["Service-Token"] = ExpressionConverter.Convert(__workflow_serviceToken);
                return new ApiConnectionAction<AppsAndAppMetadataReadAppInformationResponse>(callPayload);
            });
        }
    }

    public class AppstoreconnectTriggers([ConnectionName] string connectionId)
    {
    }

    public class AppsAndAppMetadataListAppsResponse
    {
        [JsonProperty("data")]
        public AppsAndAppMetadataListAppsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public AppsAndAppMetadataListAppsResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public AppsAndAppMetadataListAppsResponseMetaType Meta { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bundleId")]
        public string BundleId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("primaryLocale")]
        public string PrimaryLocale { get; set; }

        [JsonProperty("isOrEverWasMadeForKids")]
        public bool IsOrEverWasMadeForKids { get; set; }

        [JsonProperty("subscriptionStatusUrl")]
        public string SubscriptionStatusUrl { get; set; }

        [JsonProperty("subscriptionStatusUrlVersion")]
        public string SubscriptionStatusUrlVersion { get; set; }

        [JsonProperty("subscriptionStatusUrlForSandbox")]
        public string SubscriptionStatusUrlForSandbox { get; set; }

        [JsonProperty("subscriptionStatusUrlVersionForSandbox")]
        public string SubscriptionStatusUrlVersionForSandbox { get; set; }

        [JsonProperty("availableInNewTerritories")]
        public bool AvailableInNewTerritories { get; set; }

        [JsonProperty("contentRightsDeclaration")]
        public string ContentRightsDeclaration { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("ciProduct")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeCiProductType CiProduct { get; set; }

        [JsonProperty("betaTesters")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaTestersType BetaTesters { get; set; }

        [JsonProperty("betaGroups")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaGroupsType BetaGroups { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeCiProductType
    {
        [JsonProperty("links")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeCiProductTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeCiProductTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaTestersType
    {
        [JsonProperty("links")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaTestersTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaTestersTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaGroupsType
    {
        [JsonProperty("links")]
        public AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaGroupsTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseDataTypeItemRelationshipsTypeBetaGroupsTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseMetaType
    {
        [JsonProperty("paging")]
        public AppsAndAppMetadataListAppsResponseMetaTypePagingType Paging { get; set; }
    }

    public class AppsAndAppMetadataListAppsResponseMetaTypePagingType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppsInput
    {
        [EnumMember(Value = "appAvailability")]
        AppAvailability,
        [EnumMember(Value = "appClips")]
        AppClips,
        [EnumMember(Value = "appCustomProductPages")]
        AppCustomProductPages,
        [EnumMember(Value = "appEncryptionDeclarations")]
        AppEncryptionDeclarations,
        [EnumMember(Value = "appEvents")]
        AppEvents,
        [EnumMember(Value = "appInfos")]
        AppInfos,
        [EnumMember(Value = "appPricePoints")]
        AppPricePoints,
        [EnumMember(Value = "appPriceSchedule")]
        AppPriceSchedule,
        [EnumMember(Value = "appStoreVersionExperimentsV2")]
        AppStoreVersionExperimentsV2,
        [EnumMember(Value = "appStoreVersions")]
        AppStoreVersions,
        [EnumMember(Value = "availableInNewTerritories")]
        AvailableInNewTerritories,
        [EnumMember(Value = "availableTerritories")]
        AvailableTerritories,
        [EnumMember(Value = "betaAppLocalizations")]
        BetaAppLocalizations,
        [EnumMember(Value = "betaAppReviewDetail")]
        BetaAppReviewDetail,
        [EnumMember(Value = "betaGroups")]
        BetaGroups,
        [EnumMember(Value = "betaLicenseAgreement")]
        BetaLicenseAgreement,
        [EnumMember(Value = "betaTesters")]
        BetaTesters,
        [EnumMember(Value = "builds")]
        Builds,
        [EnumMember(Value = "bundleId")]
        BundleId,
        [EnumMember(Value = "ciProduct")]
        CiProduct,
        [EnumMember(Value = "contentRightsDeclaration")]
        ContentRightsDeclaration,
        [EnumMember(Value = "customerReviews")]
        CustomerReviews,
        [EnumMember(Value = "endUserLicenseAgreement")]
        EndUserLicenseAgreement,
        [EnumMember(Value = "gameCenterDetail")]
        GameCenterDetail,
        [EnumMember(Value = "gameCenterEnabledVersions")]
        GameCenterEnabledVersions,
        [EnumMember(Value = "inAppPurchases")]
        InAppPurchases,
        [EnumMember(Value = "inAppPurchasesV2")]
        InAppPurchasesV2,
        [EnumMember(Value = "isOrEverWasMadeForKids")]
        IsOrEverWasMadeForKids,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "perfPowerMetrics")]
        PerfPowerMetrics,
        [EnumMember(Value = "preOrder")]
        PreOrder,
        [EnumMember(Value = "preReleaseVersions")]
        PreReleaseVersions,
        [EnumMember(Value = "pricePoints")]
        PricePoints,
        [EnumMember(Value = "prices")]
        Prices,
        [EnumMember(Value = "primaryLocale")]
        PrimaryLocale,
        [EnumMember(Value = "promotedPurchases")]
        PromotedPurchases,
        [EnumMember(Value = "reviewSubmissions")]
        ReviewSubmissions,
        [EnumMember(Value = "sku")]
        Sku,
        [EnumMember(Value = "subscriptionGracePeriod")]
        SubscriptionGracePeriod,
        [EnumMember(Value = "subscriptionGroups")]
        SubscriptionGroups,
        [EnumMember(Value = "subscriptionStatusUrl")]
        SubscriptionStatusUrl,
        [EnumMember(Value = "subscriptionStatusUrlForSandbox")]
        SubscriptionStatusUrlForSandbox,
        [EnumMember(Value = "subscriptionStatusUrlVersion")]
        SubscriptionStatusUrlVersion,
        [EnumMember(Value = "subscriptionStatusUrlVersionForSandbox")]
        SubscriptionStatusUrlVersionForSandbox
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsBetaLicenseAgreementsInput
    {
        [EnumMember(Value = "agreementText")]
        AgreementText,
        [EnumMember(Value = "app")]
        App
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsPreReleaseVersionsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "builds")]
        Builds,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "version")]
        Version
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsBetaAppReviewDetailsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "contactEmail")]
        ContactEmail,
        [EnumMember(Value = "contactFirstName")]
        ContactFirstName,
        [EnumMember(Value = "contactLastName")]
        ContactLastName,
        [EnumMember(Value = "contactPhone")]
        ContactPhone,
        [EnumMember(Value = "demoAccountName")]
        DemoAccountName,
        [EnumMember(Value = "demoAccountPassword")]
        DemoAccountPassword,
        [EnumMember(Value = "demoAccountRequired")]
        DemoAccountRequired,
        [EnumMember(Value = "notes")]
        Notes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsBetaAppLocalizationsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "feedbackEmail")]
        FeedbackEmail,
        [EnumMember(Value = "locale")]
        Locale,
        [EnumMember(Value = "marketingUrl")]
        MarketingUrl,
        [EnumMember(Value = "privacyPolicyUrl")]
        PrivacyPolicyUrl,
        [EnumMember(Value = "tvOsPrivacyPolicy")]
        TvOsPrivacyPolicy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsBuildsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appEncryptionDeclaration")]
        AppEncryptionDeclaration,
        [EnumMember(Value = "appStoreVersion")]
        AppStoreVersion,
        [EnumMember(Value = "betaAppReviewSubmission")]
        BetaAppReviewSubmission,
        [EnumMember(Value = "betaBuildLocalizations")]
        BetaBuildLocalizations,
        [EnumMember(Value = "betaGroups")]
        BetaGroups,
        [EnumMember(Value = "buildAudienceType")]
        BuildAudienceType,
        [EnumMember(Value = "buildBetaDetail")]
        BuildBetaDetail,
        [EnumMember(Value = "buildBundles")]
        BuildBundles,
        [EnumMember(Value = "computedMinMacOsVersion")]
        ComputedMinMacOsVersion,
        [EnumMember(Value = "diagnosticSignatures")]
        DiagnosticSignatures,
        [EnumMember(Value = "expirationDate")]
        ExpirationDate,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "iconAssetToken")]
        IconAssetToken,
        [EnumMember(Value = "icons")]
        Icons,
        [EnumMember(Value = "individualTesters")]
        IndividualTesters,
        [EnumMember(Value = "lsMinimumSystemVersion")]
        LsMinimumSystemVersion,
        [EnumMember(Value = "minOsVersion")]
        MinOsVersion,
        [EnumMember(Value = "perfPowerMetrics")]
        PerfPowerMetrics,
        [EnumMember(Value = "preReleaseVersion")]
        PreReleaseVersion,
        [EnumMember(Value = "processingState")]
        ProcessingState,
        [EnumMember(Value = "uploadedDate")]
        UploadedDate,
        [EnumMember(Value = "usesNonExemptEncryption")]
        UsesNonExemptEncryption,
        [EnumMember(Value = "version")]
        Version
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsBetaGroupsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "betaTesters")]
        BetaTesters,
        [EnumMember(Value = "builds")]
        Builds,
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        [EnumMember(Value = "feedbackEnabled")]
        FeedbackEnabled,
        [EnumMember(Value = "hasAccessToAllBuilds")]
        HasAccessToAllBuilds,
        [EnumMember(Value = "iosBuildsAvailableForAppleSiliconMac")]
        IosBuildsAvailableForAppleSiliconMac,
        [EnumMember(Value = "isInternalGroup")]
        IsInternalGroup,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "publicLink")]
        PublicLink,
        [EnumMember(Value = "publicLinkEnabled")]
        PublicLinkEnabled,
        [EnumMember(Value = "publicLinkId")]
        PublicLinkId,
        [EnumMember(Value = "publicLinkLimit")]
        PublicLinkLimit,
        [EnumMember(Value = "publicLinkLimitEnabled")]
        PublicLinkLimitEnabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsEndUserLicenseAgreementsInput
    {
        [EnumMember(Value = "agreementText")]
        AgreementText,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "territories")]
        Territories
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppStoreVersionsInput
    {
        [EnumMember(Value = "ageRatingDeclaration")]
        AgeRatingDeclaration,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appClipDefaultExperience")]
        AppClipDefaultExperience,
        [EnumMember(Value = "appStoreReviewDetail")]
        AppStoreReviewDetail,
        [EnumMember(Value = "appStoreState")]
        AppStoreState,
        [EnumMember(Value = "appStoreVersionExperiments")]
        AppStoreVersionExperiments,
        [EnumMember(Value = "appStoreVersionExperimentsV2")]
        AppStoreVersionExperimentsV2,
        [EnumMember(Value = "appStoreVersionLocalizations")]
        AppStoreVersionLocalizations,
        [EnumMember(Value = "appStoreVersionPhasedRelease")]
        AppStoreVersionPhasedRelease,
        [EnumMember(Value = "appStoreVersionSubmission")]
        AppStoreVersionSubmission,
        [EnumMember(Value = "build")]
        Build,
        [EnumMember(Value = "copyright")]
        Copyright,
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        [EnumMember(Value = "customerReviews")]
        CustomerReviews,
        [EnumMember(Value = "downloadable")]
        Downloadable,
        [EnumMember(Value = "earliestReleaseDate")]
        EarliestReleaseDate,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "releaseType")]
        ReleaseType,
        [EnumMember(Value = "routingAppCoverage")]
        RoutingAppCoverage,
        [EnumMember(Value = "versionString")]
        VersionString
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppInfosInput
    {
        [EnumMember(Value = "ageRatingDeclaration")]
        AgeRatingDeclaration,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appInfoLocalizations")]
        AppInfoLocalizations,
        [EnumMember(Value = "appStoreAgeRating")]
        AppStoreAgeRating,
        [EnumMember(Value = "appStoreState")]
        AppStoreState,
        [EnumMember(Value = "brazilAgeRating")]
        BrazilAgeRating,
        [EnumMember(Value = "brazilAgeRatingV2")]
        BrazilAgeRatingV2,
        [EnumMember(Value = "kidsAgeBand")]
        KidsAgeBand,
        [EnumMember(Value = "primaryCategory")]
        PrimaryCategory,
        [EnumMember(Value = "primarySubcategoryOne")]
        PrimarySubcategoryOne,
        [EnumMember(Value = "primarySubcategoryTwo")]
        PrimarySubcategoryTwo,
        [EnumMember(Value = "secondaryCategory")]
        SecondaryCategory,
        [EnumMember(Value = "secondarySubcategoryOne")]
        SecondarySubcategoryOne,
        [EnumMember(Value = "secondarySubcategoryTwo")]
        SecondarySubcategoryTwo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsPerfPowerMetricsInput
    {
        [EnumMember(Value = "deviceType")]
        DeviceType,
        [EnumMember(Value = "metricType")]
        MetricType,
        [EnumMember(Value = "platform")]
        Platform
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsInAppPurchasesInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appStoreReviewScreenshot")]
        AppStoreReviewScreenshot,
        [EnumMember(Value = "apps")]
        Apps,
        [EnumMember(Value = "content")]
        Content,
        [EnumMember(Value = "contentHosting")]
        ContentHosting,
        [EnumMember(Value = "familySharable")]
        FamilySharable,
        [EnumMember(Value = "iapPriceSchedule")]
        IapPriceSchedule,
        [EnumMember(Value = "inAppPurchaseAvailability")]
        InAppPurchaseAvailability,
        [EnumMember(Value = "inAppPurchaseLocalizations")]
        InAppPurchaseLocalizations,
        [EnumMember(Value = "inAppPurchaseType")]
        InAppPurchaseType,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "pricePoints")]
        PricePoints,
        [EnumMember(Value = "productId")]
        ProductId,
        [EnumMember(Value = "promotedPurchase")]
        PromotedPurchase,
        [EnumMember(Value = "referenceName")]
        ReferenceName,
        [EnumMember(Value = "reviewNote")]
        ReviewNote,
        [EnumMember(Value = "state")]
        State
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsCiProductsInput
    {
        [EnumMember(Value = "additionalRepositories")]
        AdditionalRepositories,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "buildRuns")]
        BuildRuns,
        [EnumMember(Value = "bundleId")]
        BundleId,
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "primaryRepositories")]
        PrimaryRepositories,
        [EnumMember(Value = "productType")]
        ProductType,
        [EnumMember(Value = "workflows")]
        Workflows
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppClipsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appClipAdvancedExperiences")]
        AppClipAdvancedExperiences,
        [EnumMember(Value = "appClipDefaultExperiences")]
        AppClipDefaultExperiences,
        [EnumMember(Value = "bundleId")]
        BundleId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsReviewSubmissionsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appStoreVersionForReview")]
        AppStoreVersionForReview,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "items")]
        Items,
        [EnumMember(Value = "lastUpdatedByActor")]
        LastUpdatedByActor,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "submittedByActor")]
        SubmittedByActor,
        [EnumMember(Value = "submittedDate")]
        SubmittedDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppCustomProductPagesInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appCustomProductPageVersions")]
        AppCustomProductPageVersions,
        [EnumMember(Value = "appStoreVersionTemplate")]
        AppStoreVersionTemplate,
        [EnumMember(Value = "customProductPageTemplate")]
        CustomProductPageTemplate,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "visible")]
        Visible
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppEventsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "archivedTerritorySchedules")]
        ArchivedTerritorySchedules,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "deepLink")]
        DeepLink,
        [EnumMember(Value = "eventState")]
        EventState,
        [EnumMember(Value = "localizations")]
        Localizations,
        [EnumMember(Value = "primaryLocale")]
        PrimaryLocale,
        [EnumMember(Value = "priority")]
        Priority,
        [EnumMember(Value = "purchaseRequirement")]
        PurchaseRequirement,
        [EnumMember(Value = "purpose")]
        Purpose,
        [EnumMember(Value = "referenceName")]
        ReferenceName,
        [EnumMember(Value = "territorySchedules")]
        TerritorySchedules
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppPricePointsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "customerPrice")]
        CustomerPrice,
        [EnumMember(Value = "equalizations")]
        Equalizations,
        [EnumMember(Value = "priceTier")]
        PriceTier,
        [EnumMember(Value = "proceeds")]
        Proceeds,
        [EnumMember(Value = "territory")]
        Territory
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsCustomerReviewsInput
    {
        [EnumMember(Value = "body")]
        Body,
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "response")]
        Response,
        [EnumMember(Value = "reviewerNickname")]
        ReviewerNickname,
        [EnumMember(Value = "territory")]
        Territory,
        [EnumMember(Value = "title")]
        Title
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsSubscriptionGracePeriodsInput
    {
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "optIn")]
        OptIn,
        [EnumMember(Value = "renewalType")]
        RenewalType,
        [EnumMember(Value = "sandboxOptIn")]
        SandboxOptIn
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsPromotedPurchasesInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "inAppPurchaseV2")]
        InAppPurchaseV2,
        [EnumMember(Value = "promotionImages")]
        PromotionImages,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "subscription")]
        Subscription,
        [EnumMember(Value = "visibleForAllUsers")]
        VisibleForAllUsers
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsSubscriptionGroupsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "referenceName")]
        ReferenceName,
        [EnumMember(Value = "subscriptionGroupLocalizations")]
        SubscriptionGroupLocalizations,
        [EnumMember(Value = "subscriptions")]
        Subscriptions
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppPriceSchedulesInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "automaticPrices")]
        AutomaticPrices,
        [EnumMember(Value = "baseTerritory")]
        BaseTerritory,
        [EnumMember(Value = "manualPrices")]
        ManualPrices
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppStoreVersionExperimentsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appStoreVersionExperimentTreatments")]
        AppStoreVersionExperimentTreatments,
        [EnumMember(Value = "controlVersions")]
        ControlVersions,
        [EnumMember(Value = "endDate")]
        EndDate,
        [EnumMember(Value = "latestControlVersion")]
        LatestControlVersion,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "reviewRequired")]
        ReviewRequired,
        [EnumMember(Value = "startDate")]
        StartDate,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "trafficProportion")]
        TrafficProportion
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsAppEncryptionDeclarationsInput
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "appDescription")]
        AppDescription,
        [EnumMember(Value = "appEncryptionDeclarationDocument")]
        AppEncryptionDeclarationDocument,
        [EnumMember(Value = "appEncryptionDeclarationState")]
        AppEncryptionDeclarationState,
        [EnumMember(Value = "availableOnFrenchStore")]
        AvailableOnFrenchStore,
        [EnumMember(Value = "builds")]
        Builds,
        [EnumMember(Value = "codeValue")]
        CodeValue,
        [EnumMember(Value = "containsProprietaryCryptography")]
        ContainsProprietaryCryptography,
        [EnumMember(Value = "containsThirdPartyCryptography")]
        ContainsThirdPartyCryptography,
        [EnumMember(Value = "createdDate")]
        CreatedDate,
        [EnumMember(Value = "documentName")]
        DocumentName,
        [EnumMember(Value = "documentType")]
        DocumentType,
        [EnumMember(Value = "documentUrl")]
        DocumentUrl,
        [EnumMember(Value = "exempt")]
        Exempt,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "uploadedDate")]
        UploadedDate,
        [EnumMember(Value = "usesEncryption")]
        UsesEncryption
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsGameCenterDetailsInput
    {
        [EnumMember(Value = "achievementReleases")]
        AchievementReleases,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "arcadeEnabled")]
        ArcadeEnabled,
        [EnumMember(Value = "challengeEnabled")]
        ChallengeEnabled,
        [EnumMember(Value = "defaultGroupLeaderboard")]
        DefaultGroupLeaderboard,
        [EnumMember(Value = "defaultLeaderboard")]
        DefaultLeaderboard,
        [EnumMember(Value = "gameCenterAchievements")]
        GameCenterAchievements,
        [EnumMember(Value = "gameCenterAppVersions")]
        GameCenterAppVersions,
        [EnumMember(Value = "gameCenterGroup")]
        GameCenterGroup,
        [EnumMember(Value = "gameCenterLeaderboardSets")]
        GameCenterLeaderboardSets,
        [EnumMember(Value = "gameCenterLeaderboards")]
        GameCenterLeaderboards,
        [EnumMember(Value = "leaderboardReleases")]
        LeaderboardReleases,
        [EnumMember(Value = "leaderboardSetReleases")]
        LeaderboardSetReleases
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum includeInput
    {
        [EnumMember(Value = "appClips")]
        AppClips,
        [EnumMember(Value = "appCustomProductPages")]
        AppCustomProductPages,
        [EnumMember(Value = "appEncryptionDeclarations")]
        AppEncryptionDeclarations,
        [EnumMember(Value = "appEvents")]
        AppEvents,
        [EnumMember(Value = "appInfos")]
        AppInfos,
        [EnumMember(Value = "appStoreVersionExperimentsV2")]
        AppStoreVersionExperimentsV2,
        [EnumMember(Value = "appStoreVersions")]
        AppStoreVersions,
        [EnumMember(Value = "availableTerritories")]
        AvailableTerritories,
        [EnumMember(Value = "betaAppLocalizations")]
        BetaAppLocalizations,
        [EnumMember(Value = "betaAppReviewDetail")]
        BetaAppReviewDetail,
        [EnumMember(Value = "betaGroups")]
        BetaGroups,
        [EnumMember(Value = "betaLicenseAgreement")]
        BetaLicenseAgreement,
        [EnumMember(Value = "builds")]
        Builds,
        [EnumMember(Value = "ciProduct")]
        CiProduct,
        [EnumMember(Value = "endUserLicenseAgreement")]
        EndUserLicenseAgreement,
        [EnumMember(Value = "gameCenterDetail")]
        GameCenterDetail,
        [EnumMember(Value = "gameCenterEnabledVersions")]
        GameCenterEnabledVersions,
        [EnumMember(Value = "inAppPurchases")]
        InAppPurchases,
        [EnumMember(Value = "inAppPurchasesV2")]
        InAppPurchasesV2,
        [EnumMember(Value = "preOrder")]
        PreOrder,
        [EnumMember(Value = "preReleaseVersions")]
        PreReleaseVersions,
        [EnumMember(Value = "prices")]
        Prices,
        [EnumMember(Value = "promotedPurchases")]
        PromotedPurchases,
        [EnumMember(Value = "reviewSubmissions")]
        ReviewSubmissions,
        [EnumMember(Value = "subscriptionGracePeriod")]
        SubscriptionGracePeriod,
        [EnumMember(Value = "subscriptionGroups")]
        SubscriptionGroups
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterAppStoreVersionsPlatformInput
    {
        IOS,
        [EnumMember(Value = "MAC_OS")]
        MACOS,
        [EnumMember(Value = "TV_OS")]
        TVOS,
        [EnumMember(Value = "VISION_OS")]
        VISIONOS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterAppStoreVersionsAppStoreStateInput
    {
        ACCEPTED,
        [EnumMember(Value = "DEVELOPER_REMOVED_FROM_SALE")]
        DEVELOPERREMOVEDFROMSALE,
        [EnumMember(Value = "DEVELOPER_REJECTED")]
        DEVELOPERREJECTED,
        [EnumMember(Value = "IN_REVIEW")]
        INREVIEW,
        [EnumMember(Value = "INVALID_BINARY")]
        INVALIdBINARY,
        [EnumMember(Value = "METADATA_REJECTED")]
        METADATAREJECTED,
        [EnumMember(Value = "PENDING_APPLE_RELEASE")]
        PENDINGAPPLERELEASE,
        [EnumMember(Value = "PENDING_CONTRACT")]
        PENDINGCONTRACT,
        [EnumMember(Value = "PENDING_DEVELOPER_RELEASE")]
        PENDINGDEVELOPERRELEASE,
        [EnumMember(Value = "PREPARE_FOR_SUBMISSION")]
        PREPAREFORSUBMISSION,
        [EnumMember(Value = "PREORDER_READY_FOR_SALE")]
        PREORDERREADYFORSALE,
        [EnumMember(Value = "PROCESSING_FOR_APP_STORE")]
        PROCESSINGFORAPPSTORE,
        [EnumMember(Value = "READY_FOR_REVIEW")]
        READYFORREVIEW,
        [EnumMember(Value = "READY_FOR_SALE")]
        READYFORSALE,
        REJECTED,
        [EnumMember(Value = "REMOVED_FROM_SALE")]
        REMOVEDFROMSALE,
        [EnumMember(Value = "WAITING_FOR_EXPORT_COMPLIANCE")]
        WAITINGFOREXPORTCOMPLIANCE,
        [EnumMember(Value = "WAITING_FOR_REVIEW")]
        WAITINGFORREVIEW,
        [EnumMember(Value = "REPLACED_WITH_NEW_VERSION")]
        REPLACEDWITHNEWVERSION
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "bundleId")]
        BundleId2,
        [EnumMember(Value = "-bundleId")]
        BundleId,
        [EnumMember(Value = "name")]
        Name2,
        [EnumMember(Value = "-name")]
        Name,
        [EnumMember(Value = "sku")]
        Sku2,
        [EnumMember(Value = "-sku")]
        Sku
    }

    public class AppsAndAppMetadataReadAppInformationResponse
    {
        [JsonProperty("data")]
        public AppsAndAppMetadataReadAppInformationResponseDataType Data { get; set; }

        [JsonProperty("links")]
        public AppsAndAppMetadataReadAppInformationResponseLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsType Relationships { get; set; }

        [JsonProperty("links")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bundleId")]
        public string BundleId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("primaryLocale")]
        public string PrimaryLocale { get; set; }

        [JsonProperty("isOrEverWasMadeForKids")]
        public bool IsOrEverWasMadeForKids { get; set; }

        [JsonProperty("subscriptionStatusUrl")]
        public string SubscriptionStatusUrl { get; set; }

        [JsonProperty("subscriptionStatusUrlVersion")]
        public string SubscriptionStatusUrlVersion { get; set; }

        [JsonProperty("subscriptionStatusUrlForSandbox")]
        public string SubscriptionStatusUrlForSandbox { get; set; }

        [JsonProperty("subscriptionStatusUrlVersionForSandbox")]
        public string SubscriptionStatusUrlVersionForSandbox { get; set; }

        [JsonProperty("availableInNewTerritories")]
        public bool AvailableInNewTerritories { get; set; }

        [JsonProperty("contentRightsDeclaration")]
        public string ContentRightsDeclaration { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsType
    {
        [JsonProperty("ciProduct")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCiProductType CiProduct { get; set; }

        [JsonProperty("customerReviews")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCustomerReviewsType CustomerReviews { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCiProductType
    {
        [JsonProperty("links")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCiProductTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCiProductTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCustomerReviewsType
    {
        [JsonProperty("links")]
        public AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCustomerReviewsTypeLinksType Links { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeRelationshipsTypeCustomerReviewsTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseDataTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class AppsAndAppMetadataReadAppInformationResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appstoreconnect;

    public partial class WorkflowManagedActions
    {
        public AppstoreconnectActions Appstoreconnect(string connectionId) => new AppstoreconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppstoreconnectTriggers Appstoreconnect(string connectionId) => new AppstoreconnectTriggers(connectionId);
    }
}