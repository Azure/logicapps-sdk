//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appstoreconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppstoreconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appstoreconnect")]
        public IBodyWorkflowAction<AppsAndAppMetadataListAppsResponse> AppsAndAppMetadataListApps(Expression<Func<string>> serviceToken, Expression<Func<fieldsAppsInput>> fieldsApps = null, Expression<Func<fieldsBetaLicenseAgreementsInput>> fieldsBetaLicenseAgreements = null, Expression<Func<fieldsPreReleaseVersionsInput>> fieldsPreReleaseVersions = null, Expression<Func<fieldsBetaAppReviewDetailsInput>> fieldsBetaAppReviewDetails = null, Expression<Func<fieldsBetaAppLocalizationsInput>> fieldsBetaAppLocalizations = null, Expression<Func<fieldsBuildsInput>> fieldsBuilds = null, Expression<Func<fieldsBetaGroupsInput>> fieldsBetaGroups = null, Expression<Func<fieldsEndUserLicenseAgreementsInput>> fieldsEndUserLicenseAgreements = null, Expression<Func<fieldsAppStoreVersionsInput>> fieldsAppStoreVersions = null, Expression<Func<fieldsAppInfosInput>> fieldsAppInfos = null, Expression<Func<fieldsPerfPowerMetricsInput>> fieldsPerfPowerMetrics = null, Expression<Func<fieldsInAppPurchasesInput>> fieldsInAppPurchases = null, Expression<Func<fieldsCiProductsInput>> fieldsCiProducts = null, Expression<Func<fieldsAppClipsInput>> fieldsAppClips = null, Expression<Func<fieldsReviewSubmissionsInput>> fieldsReviewSubmissions = null, Expression<Func<fieldsAppCustomProductPagesInput>> fieldsAppCustomProductPages = null, Expression<Func<fieldsAppEventsInput>> fieldsAppEvents = null, Expression<Func<fieldsAppPricePointsInput>> fieldsAppPricePoints = null, Expression<Func<fieldsCustomerReviewsInput>> fieldsCustomerReviews = null, Expression<Func<fieldsSubscriptionGracePeriodsInput>> fieldsSubscriptionGracePeriods = null, Expression<Func<fieldsPromotedPurchasesInput>> fieldsPromotedPurchases = null, Expression<Func<fieldsSubscriptionGroupsInput>> fieldsSubscriptionGroups = null, Expression<Func<fieldsAppPriceSchedulesInput>> fieldsAppPriceSchedules = null, Expression<Func<fieldsAppStoreVersionExperimentsInput>> fieldsAppStoreVersionExperiments = null, Expression<Func<fieldsAppEncryptionDeclarationsInput>> fieldsAppEncryptionDeclarations = null, Expression<Func<fieldsGameCenterDetailsInput>> fieldsGameCenterDetails = null, Expression<Func<includeInput>> include = null, Expression<Func<string>> filterBundleId = null, Expression<Func<string>> filterId = null, Expression<Func<string>> filterName = null, Expression<Func<string>> filterSku = null, Expression<Func<string>> filterAppStoreVersions = null, Expression<Func<filterAppStoreVersionsPlatformInput>> filterAppStoreVersionsPlatform = null, Expression<Func<filterAppStoreVersionsAppStoreStateInput>> filterAppStoreVersionsAppStoreState = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limitPreReleaseVersions = null, Expression<Func<int>> limitBuilds = null, Expression<Func<int>> limitBetaGroups = null, Expression<Func<int>> limitBetaAppLocalizations = null, Expression<Func<int>> limitAvailableTerritories = null, Expression<Func<int>> limitAppStoreVersions = null, Expression<Func<int>> limitAppInfos = null, Expression<Func<int>> limitAppClips = null, Expression<Func<int>> limitAppCustomProductPages = null, Expression<Func<int>> limitAppEvents = null, Expression<Func<int>> limitReviewSubmissions = null, Expression<Func<int>> limitInAppPurchasesV2 = null, Expression<Func<int>> limitPromotedPurchases = null, Expression<Func<int>> limitSubscriptionGroups = null, Expression<Func<int>> limitAppStoreVersionExperimentsV2 = null, Expression<Func<int>> limitAppEncryptionDeclarations = null)
        {
            var apiCallPath = "/v1/apps";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fieldsApps != null)
                callPayload.Queries["fields[apps]"] = ExpressionConverter.Convert(fieldsApps);
            if (fieldsBetaLicenseAgreements != null)
                callPayload.Queries["fields[betaLicenseAgreements]"] = ExpressionConverter.Convert(fieldsBetaLicenseAgreements);
            if (fieldsPreReleaseVersions != null)
                callPayload.Queries["fields[preReleaseVersions]"] = ExpressionConverter.Convert(fieldsPreReleaseVersions);
            if (fieldsBetaAppReviewDetails != null)
                callPayload.Queries["fields[betaAppReviewDetails]"] = ExpressionConverter.Convert(fieldsBetaAppReviewDetails);
            if (fieldsBetaAppLocalizations != null)
                callPayload.Queries["fields[betaAppLocalizations]"] = ExpressionConverter.Convert(fieldsBetaAppLocalizations);
            if (fieldsBuilds != null)
                callPayload.Queries["fields[builds]"] = ExpressionConverter.Convert(fieldsBuilds);
            if (fieldsBetaGroups != null)
                callPayload.Queries["fields[betaGroups]"] = ExpressionConverter.Convert(fieldsBetaGroups);
            if (fieldsEndUserLicenseAgreements != null)
                callPayload.Queries["fields[endUserLicenseAgreements]"] = ExpressionConverter.Convert(fieldsEndUserLicenseAgreements);
            if (fieldsAppStoreVersions != null)
                callPayload.Queries["fields[appStoreVersions]"] = ExpressionConverter.Convert(fieldsAppStoreVersions);
            if (fieldsAppInfos != null)
                callPayload.Queries["fields[appInfos]"] = ExpressionConverter.Convert(fieldsAppInfos);
            if (fieldsPerfPowerMetrics != null)
                callPayload.Queries["fields[perfPowerMetrics]"] = ExpressionConverter.Convert(fieldsPerfPowerMetrics);
            if (fieldsInAppPurchases != null)
                callPayload.Queries["fields[inAppPurchases]"] = ExpressionConverter.Convert(fieldsInAppPurchases);
            if (fieldsCiProducts != null)
                callPayload.Queries["fields[ciProducts]"] = ExpressionConverter.Convert(fieldsCiProducts);
            if (fieldsAppClips != null)
                callPayload.Queries["fields[appClips]"] = ExpressionConverter.Convert(fieldsAppClips);
            if (fieldsReviewSubmissions != null)
                callPayload.Queries["fields[reviewSubmissions]"] = ExpressionConverter.Convert(fieldsReviewSubmissions);
            if (fieldsAppCustomProductPages != null)
                callPayload.Queries["fields[appCustomProductPages]"] = ExpressionConverter.Convert(fieldsAppCustomProductPages);
            if (fieldsAppEvents != null)
                callPayload.Queries["fields[appEvents]"] = ExpressionConverter.Convert(fieldsAppEvents);
            if (fieldsAppPricePoints != null)
                callPayload.Queries["fields[appPricePoints]"] = ExpressionConverter.Convert(fieldsAppPricePoints);
            if (fieldsCustomerReviews != null)
                callPayload.Queries["fields[customerReviews]"] = ExpressionConverter.Convert(fieldsCustomerReviews);
            if (fieldsSubscriptionGracePeriods != null)
                callPayload.Queries["fields[subscriptionGracePeriods]"] = ExpressionConverter.Convert(fieldsSubscriptionGracePeriods);
            if (fieldsPromotedPurchases != null)
                callPayload.Queries["fields[promotedPurchases]"] = ExpressionConverter.Convert(fieldsPromotedPurchases);
            if (fieldsSubscriptionGroups != null)
                callPayload.Queries["fields[subscriptionGroups]"] = ExpressionConverter.Convert(fieldsSubscriptionGroups);
            if (fieldsAppPriceSchedules != null)
                callPayload.Queries["fields[appPriceSchedules]"] = ExpressionConverter.Convert(fieldsAppPriceSchedules);
            if (fieldsAppStoreVersionExperiments != null)
                callPayload.Queries["fields[appStoreVersionExperiments]"] = ExpressionConverter.Convert(fieldsAppStoreVersionExperiments);
            if (fieldsAppEncryptionDeclarations != null)
                callPayload.Queries["fields[appEncryptionDeclarations]"] = ExpressionConverter.Convert(fieldsAppEncryptionDeclarations);
            if (fieldsGameCenterDetails != null)
                callPayload.Queries["fields[gameCenterDetails]"] = ExpressionConverter.Convert(fieldsGameCenterDetails);
            if (include != null)
                callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            if (filterBundleId != null)
                callPayload.Queries["filter[bundleId]"] = ExpressionConverter.Convert(filterBundleId);
            if (filterId != null)
                callPayload.Queries["filter[id]"] = ExpressionConverter.Convert(filterId);
            if (filterName != null)
                callPayload.Queries["filter[name]"] = ExpressionConverter.Convert(filterName);
            if (filterSku != null)
                callPayload.Queries["filter[sku]"] = ExpressionConverter.Convert(filterSku);
            if (filterAppStoreVersions != null)
                callPayload.Queries["filter[appStoreVersions]"] = ExpressionConverter.Convert(filterAppStoreVersions);
            if (filterAppStoreVersionsPlatform != null)
                callPayload.Queries["filter[appStoreVersions.platform]"] = ExpressionConverter.Convert(filterAppStoreVersionsPlatform);
            if (filterAppStoreVersionsAppStoreState != null)
                callPayload.Queries["filter[appStoreVersions.appStoreState]"] = ExpressionConverter.Convert(filterAppStoreVersionsAppStoreState);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (limitPreReleaseVersions != null)
                callPayload.Queries["limit[preReleaseVersions]"] = ExpressionConverter.Convert(limitPreReleaseVersions);
            if (limitBuilds != null)
                callPayload.Queries["limit[builds]"] = ExpressionConverter.Convert(limitBuilds);
            if (limitBetaGroups != null)
                callPayload.Queries["limit[betaGroups]"] = ExpressionConverter.Convert(limitBetaGroups);
            if (limitBetaAppLocalizations != null)
                callPayload.Queries["limit[betaAppLocalizations]"] = ExpressionConverter.Convert(limitBetaAppLocalizations);
            if (limitAvailableTerritories != null)
                callPayload.Queries["limit[availableTerritories]"] = ExpressionConverter.Convert(limitAvailableTerritories);
            if (limitAppStoreVersions != null)
                callPayload.Queries["limit[appStoreVersions]"] = ExpressionConverter.Convert(limitAppStoreVersions);
            if (limitAppInfos != null)
                callPayload.Queries["limit[appInfos]"] = ExpressionConverter.Convert(limitAppInfos);
            if (limitAppClips != null)
                callPayload.Queries["limit[appClips]"] = ExpressionConverter.Convert(limitAppClips);
            if (limitAppCustomProductPages != null)
                callPayload.Queries["limit[appCustomProductPages]"] = ExpressionConverter.Convert(limitAppCustomProductPages);
            if (limitAppEvents != null)
                callPayload.Queries["limit[appEvents]"] = ExpressionConverter.Convert(limitAppEvents);
            if (limitReviewSubmissions != null)
                callPayload.Queries["limit[reviewSubmissions]"] = ExpressionConverter.Convert(limitReviewSubmissions);
            if (limitInAppPurchasesV2 != null)
                callPayload.Queries["limit[inAppPurchasesV2]"] = ExpressionConverter.Convert(limitInAppPurchasesV2);
            if (limitPromotedPurchases != null)
                callPayload.Queries["limit[promotedPurchases]"] = ExpressionConverter.Convert(limitPromotedPurchases);
            if (limitSubscriptionGroups != null)
                callPayload.Queries["limit[subscriptionGroups]"] = ExpressionConverter.Convert(limitSubscriptionGroups);
            if (limitAppStoreVersionExperimentsV2 != null)
                callPayload.Queries["limit[appStoreVersionExperimentsV2]"] = ExpressionConverter.Convert(limitAppStoreVersionExperimentsV2);
            if (limitAppEncryptionDeclarations != null)
                callPayload.Queries["limit[appEncryptionDeclarations]"] = ExpressionConverter.Convert(limitAppEncryptionDeclarations);
            callPayload.Headers["Service-Token"] = ExpressionConverter.Convert(serviceToken);
            return new ApiConnectionAction<AppsAndAppMetadataListAppsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appstoreconnect")]
        public IBodyWorkflowAction<AppsAndAppMetadataReadAppInformationResponse> AppsAndAppMetadataReadAppInformation(Expression<Func<string>> id, Expression<Func<string>> serviceToken, Expression<Func<fieldsAppsInput>> fieldsApps = null, Expression<Func<fieldsBetaLicenseAgreementsInput>> fieldsBetaLicenseAgreements = null, Expression<Func<fieldsPreReleaseVersionsInput>> fieldsPreReleaseVersions = null, Expression<Func<fieldsBetaAppReviewDetailsInput>> fieldsBetaAppReviewDetails = null, Expression<Func<fieldsBetaAppLocalizationsInput>> fieldsBetaAppLocalizations = null, Expression<Func<fieldsBuildsInput>> fieldsBuilds = null, Expression<Func<fieldsBetaGroupsInput>> fieldsBetaGroups = null, Expression<Func<fieldsEndUserLicenseAgreementsInput>> fieldsEndUserLicenseAgreements = null, Expression<Func<fieldsAppStoreVersionsInput>> fieldsAppStoreVersions = null, Expression<Func<fieldsAppInfosInput>> fieldsAppInfos = null, Expression<Func<fieldsPerfPowerMetricsInput>> fieldsPerfPowerMetrics = null, Expression<Func<fieldsInAppPurchasesInput>> fieldsInAppPurchases = null, Expression<Func<fieldsCiProductsInput>> fieldsCiProducts = null, Expression<Func<fieldsAppClipsInput>> fieldsAppClips = null, Expression<Func<fieldsReviewSubmissionsInput>> fieldsReviewSubmissions = null, Expression<Func<fieldsAppCustomProductPagesInput>> fieldsAppCustomProductPages = null, Expression<Func<fieldsAppEventsInput>> fieldsAppEvents = null, Expression<Func<fieldsAppPricePointsInput>> fieldsAppPricePoints = null, Expression<Func<fieldsCustomerReviewsInput>> fieldsCustomerReviews = null, Expression<Func<fieldsSubscriptionGracePeriodsInput>> fieldsSubscriptionGracePeriods = null, Expression<Func<fieldsPromotedPurchasesInput>> fieldsPromotedPurchases = null, Expression<Func<fieldsSubscriptionGroupsInput>> fieldsSubscriptionGroups = null, Expression<Func<fieldsAppPriceSchedulesInput>> fieldsAppPriceSchedules = null, Expression<Func<fieldsAppStoreVersionExperimentsInput>> fieldsAppStoreVersionExperiments = null, Expression<Func<fieldsAppEncryptionDeclarationsInput>> fieldsAppEncryptionDeclarations = null, Expression<Func<fieldsGameCenterDetailsInput>> fieldsGameCenterDetails = null, Expression<Func<includeInput>> include = null, Expression<Func<int>> limitPreReleaseVersions = null, Expression<Func<int>> limitBuilds = null, Expression<Func<int>> limitBetaGroups = null, Expression<Func<int>> limitBetaAppLocalizations = null, Expression<Func<int>> limitAvailableTerritories = null, Expression<Func<int>> limitAppStoreVersions = null, Expression<Func<int>> limitAppInfos = null, Expression<Func<int>> limitAppClips = null, Expression<Func<int>> limitAppCustomProductPages = null, Expression<Func<int>> limitAppEvents = null, Expression<Func<int>> limitReviewSubmissions = null, Expression<Func<int>> limitInAppPurchasesV2 = null, Expression<Func<int>> limitPromotedPurchases = null, Expression<Func<int>> limitSubscriptionGroups = null, Expression<Func<int>> limitAppStoreVersionExperimentsV2 = null, Expression<Func<int>> limitAppEncryptionDeclarations = null)
        {
            var apiCallPath = String.Format("/v1/apps/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fieldsApps != null)
                callPayload.Queries["fields[apps]"] = ExpressionConverter.Convert(fieldsApps);
            if (fieldsBetaLicenseAgreements != null)
                callPayload.Queries["fields[betaLicenseAgreements]"] = ExpressionConverter.Convert(fieldsBetaLicenseAgreements);
            if (fieldsPreReleaseVersions != null)
                callPayload.Queries["fields[preReleaseVersions]"] = ExpressionConverter.Convert(fieldsPreReleaseVersions);
            if (fieldsBetaAppReviewDetails != null)
                callPayload.Queries["fields[betaAppReviewDetails]"] = ExpressionConverter.Convert(fieldsBetaAppReviewDetails);
            if (fieldsBetaAppLocalizations != null)
                callPayload.Queries["fields[betaAppLocalizations]"] = ExpressionConverter.Convert(fieldsBetaAppLocalizations);
            if (fieldsBuilds != null)
                callPayload.Queries["fields[builds]"] = ExpressionConverter.Convert(fieldsBuilds);
            if (fieldsBetaGroups != null)
                callPayload.Queries["fields[betaGroups]"] = ExpressionConverter.Convert(fieldsBetaGroups);
            if (fieldsEndUserLicenseAgreements != null)
                callPayload.Queries["fields[endUserLicenseAgreements]"] = ExpressionConverter.Convert(fieldsEndUserLicenseAgreements);
            if (fieldsAppStoreVersions != null)
                callPayload.Queries["fields[appStoreVersions]"] = ExpressionConverter.Convert(fieldsAppStoreVersions);
            if (fieldsAppInfos != null)
                callPayload.Queries["fields[appInfos]"] = ExpressionConverter.Convert(fieldsAppInfos);
            if (fieldsPerfPowerMetrics != null)
                callPayload.Queries["fields[perfPowerMetrics]"] = ExpressionConverter.Convert(fieldsPerfPowerMetrics);
            if (fieldsInAppPurchases != null)
                callPayload.Queries["fields[inAppPurchases]"] = ExpressionConverter.Convert(fieldsInAppPurchases);
            if (fieldsCiProducts != null)
                callPayload.Queries["fields[ciProducts]"] = ExpressionConverter.Convert(fieldsCiProducts);
            if (fieldsAppClips != null)
                callPayload.Queries["fields[appClips]"] = ExpressionConverter.Convert(fieldsAppClips);
            if (fieldsReviewSubmissions != null)
                callPayload.Queries["fields[reviewSubmissions]"] = ExpressionConverter.Convert(fieldsReviewSubmissions);
            if (fieldsAppCustomProductPages != null)
                callPayload.Queries["fields[appCustomProductPages]"] = ExpressionConverter.Convert(fieldsAppCustomProductPages);
            if (fieldsAppEvents != null)
                callPayload.Queries["fields[appEvents]"] = ExpressionConverter.Convert(fieldsAppEvents);
            if (fieldsAppPricePoints != null)
                callPayload.Queries["fields[appPricePoints]"] = ExpressionConverter.Convert(fieldsAppPricePoints);
            if (fieldsCustomerReviews != null)
                callPayload.Queries["fields[customerReviews]"] = ExpressionConverter.Convert(fieldsCustomerReviews);
            if (fieldsSubscriptionGracePeriods != null)
                callPayload.Queries["fields[subscriptionGracePeriods]"] = ExpressionConverter.Convert(fieldsSubscriptionGracePeriods);
            if (fieldsPromotedPurchases != null)
                callPayload.Queries["fields[promotedPurchases]"] = ExpressionConverter.Convert(fieldsPromotedPurchases);
            if (fieldsSubscriptionGroups != null)
                callPayload.Queries["fields[subscriptionGroups]"] = ExpressionConverter.Convert(fieldsSubscriptionGroups);
            if (fieldsAppPriceSchedules != null)
                callPayload.Queries["fields[appPriceSchedules]"] = ExpressionConverter.Convert(fieldsAppPriceSchedules);
            if (fieldsAppStoreVersionExperiments != null)
                callPayload.Queries["fields[appStoreVersionExperiments]"] = ExpressionConverter.Convert(fieldsAppStoreVersionExperiments);
            if (fieldsAppEncryptionDeclarations != null)
                callPayload.Queries["fields[appEncryptionDeclarations]"] = ExpressionConverter.Convert(fieldsAppEncryptionDeclarations);
            if (fieldsGameCenterDetails != null)
                callPayload.Queries["fields[gameCenterDetails]"] = ExpressionConverter.Convert(fieldsGameCenterDetails);
            if (include != null)
                callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            if (limitPreReleaseVersions != null)
                callPayload.Queries["limit[preReleaseVersions]"] = ExpressionConverter.Convert(limitPreReleaseVersions);
            if (limitBuilds != null)
                callPayload.Queries["limit[builds]"] = ExpressionConverter.Convert(limitBuilds);
            if (limitBetaGroups != null)
                callPayload.Queries["limit[betaGroups]"] = ExpressionConverter.Convert(limitBetaGroups);
            if (limitBetaAppLocalizations != null)
                callPayload.Queries["limit[betaAppLocalizations]"] = ExpressionConverter.Convert(limitBetaAppLocalizations);
            if (limitAvailableTerritories != null)
                callPayload.Queries["limit[availableTerritories]"] = ExpressionConverter.Convert(limitAvailableTerritories);
            if (limitAppStoreVersions != null)
                callPayload.Queries["limit[appStoreVersions]"] = ExpressionConverter.Convert(limitAppStoreVersions);
            if (limitAppInfos != null)
                callPayload.Queries["limit[appInfos]"] = ExpressionConverter.Convert(limitAppInfos);
            if (limitAppClips != null)
                callPayload.Queries["limit[appClips]"] = ExpressionConverter.Convert(limitAppClips);
            if (limitAppCustomProductPages != null)
                callPayload.Queries["limit[appCustomProductPages]"] = ExpressionConverter.Convert(limitAppCustomProductPages);
            if (limitAppEvents != null)
                callPayload.Queries["limit[appEvents]"] = ExpressionConverter.Convert(limitAppEvents);
            if (limitReviewSubmissions != null)
                callPayload.Queries["limit[reviewSubmissions]"] = ExpressionConverter.Convert(limitReviewSubmissions);
            if (limitInAppPurchasesV2 != null)
                callPayload.Queries["limit[inAppPurchasesV2]"] = ExpressionConverter.Convert(limitInAppPurchasesV2);
            if (limitPromotedPurchases != null)
                callPayload.Queries["limit[promotedPurchases]"] = ExpressionConverter.Convert(limitPromotedPurchases);
            if (limitSubscriptionGroups != null)
                callPayload.Queries["limit[subscriptionGroups]"] = ExpressionConverter.Convert(limitSubscriptionGroups);
            if (limitAppStoreVersionExperimentsV2 != null)
                callPayload.Queries["limit[appStoreVersionExperimentsV2]"] = ExpressionConverter.Convert(limitAppStoreVersionExperimentsV2);
            if (limitAppEncryptionDeclarations != null)
                callPayload.Queries["limit[appEncryptionDeclarations]"] = ExpressionConverter.Convert(limitAppEncryptionDeclarations);
            callPayload.Headers["Service-Token"] = ExpressionConverter.Convert(serviceToken);
            return new ApiConnectionAction<AppsAndAppMetadataReadAppInformationResponse>(callPayload);
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

    public enum fieldsBetaLicenseAgreementsInput
    {
        [EnumMember(Value = "agreementText")]
        AgreementText,
        [EnumMember(Value = "app")]
        App
    }

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

    public enum fieldsEndUserLicenseAgreementsInput
    {
        [EnumMember(Value = "agreementText")]
        AgreementText,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "territories")]
        Territories
    }

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

    public enum fieldsPerfPowerMetricsInput
    {
        [EnumMember(Value = "deviceType")]
        DeviceType,
        [EnumMember(Value = "metricType")]
        MetricType,
        [EnumMember(Value = "platform")]
        Platform
    }

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
        INVALIDBINARY,
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

    public enum sortInput
    {
        [EnumMember(Value = "bundleId")]
        BundleId,
        [EnumMember(Value = "-bundleId")]
        BundleId,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "-name")]
        Name,
        [EnumMember(Value = "sku")]
        Sku,
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