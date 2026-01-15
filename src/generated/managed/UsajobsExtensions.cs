//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Usajobs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsajobsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<SearchJobsResponse> SearchJobs(Expression<Func<string>> keyword = null, Expression<Func<string>> positionTitle = null, Expression<Func<int>> remunerationMinimumAmount = null, Expression<Func<int>> remunerationMaximumAmount = null, Expression<Func<string>> payGradeHigh = null, Expression<Func<string>> payGradeLow = null, Expression<Func<string>> jobCategoryCode = null, Expression<Func<bool>> remoteIndicator = null, Expression<Func<string>> locationName = null, Expression<Func<int>> radius = null, Expression<Func<bool>> relocationIndicator = null, Expression<Func<string>> travelPercentage = null, Expression<Func<string>> organization = null, Expression<Func<string>> positionOfferingTypeCode = null, Expression<Func<string>> positionScheduleTypeCode = null, Expression<Func<string>> securityClearanceRequired = null, Expression<Func<positionSensitivityInput>> positionSensitivity = null, Expression<Func<bool>> supervisoryStatus = null, Expression<Func<int>> datePosted = null, Expression<Func<string>> jobGradeCode = null, Expression<Func<string>> whoMayApply = null, Expression<Func<string>> salaryBucket = null, Expression<Func<string>> gradeBucket = null, Expression<Func<string>> hiringPath = null, Expression<Func<string>> missionCriticalTags = null, Expression<Func<string>> postingChannel = null, Expression<Func<fieldsInput>> fields = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null, Expression<Func<int>> page = null, Expression<Func<int>> resultsPerPage = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyword != null)
                callPayload.Queries["Keyword"] = ExpressionConverter.Convert(keyword);
            if (positionTitle != null)
                callPayload.Queries["PositionTitle"] = ExpressionConverter.Convert(positionTitle);
            if (remunerationMinimumAmount != null)
                callPayload.Queries["RemunerationMinimumAmount"] = ExpressionConverter.Convert(remunerationMinimumAmount);
            if (remunerationMaximumAmount != null)
                callPayload.Queries["RemunerationMaximumAmount"] = ExpressionConverter.Convert(remunerationMaximumAmount);
            if (payGradeHigh != null)
                callPayload.Queries["PayGradeHigh"] = ExpressionConverter.Convert(payGradeHigh);
            if (payGradeLow != null)
                callPayload.Queries["PayGradeLow"] = ExpressionConverter.Convert(payGradeLow);
            if (jobCategoryCode != null)
                callPayload.Queries["JobCategoryCode"] = ExpressionConverter.Convert(jobCategoryCode);
            if (remoteIndicator != null)
                callPayload.Queries["RemoteIndicator"] = ExpressionConverter.Convert(remoteIndicator);
            if (locationName != null)
                callPayload.Queries["LocationName"] = ExpressionConverter.Convert(locationName);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            if (relocationIndicator != null)
                callPayload.Queries["RelocationIndicator"] = ExpressionConverter.Convert(relocationIndicator);
            if (travelPercentage != null)
                callPayload.Queries["TravelPercentage"] = ExpressionConverter.Convert(travelPercentage);
            if (organization != null)
                callPayload.Queries["Organization"] = ExpressionConverter.Convert(organization);
            if (positionOfferingTypeCode != null)
                callPayload.Queries["PositionOfferingTypeCode"] = ExpressionConverter.Convert(positionOfferingTypeCode);
            if (positionScheduleTypeCode != null)
                callPayload.Queries["PositionScheduleTypeCode"] = ExpressionConverter.Convert(positionScheduleTypeCode);
            if (securityClearanceRequired != null)
                callPayload.Queries["SecurityClearanceRequired"] = ExpressionConverter.Convert(securityClearanceRequired);
            if (positionSensitivity != null)
                callPayload.Queries["PositionSensitivity"] = ExpressionConverter.Convert(positionSensitivity);
            if (supervisoryStatus != null)
                callPayload.Queries["SupervisoryStatus"] = ExpressionConverter.Convert(supervisoryStatus);
            if (datePosted != null)
                callPayload.Queries["DatePosted"] = ExpressionConverter.Convert(datePosted);
            if (jobGradeCode != null)
                callPayload.Queries["JobGradeCode"] = ExpressionConverter.Convert(jobGradeCode);
            if (whoMayApply != null)
                callPayload.Queries["WhoMayApply"] = ExpressionConverter.Convert(whoMayApply);
            if (salaryBucket != null)
                callPayload.Queries["SalaryBucket"] = ExpressionConverter.Convert(salaryBucket);
            if (gradeBucket != null)
                callPayload.Queries["GradeBucket"] = ExpressionConverter.Convert(gradeBucket);
            if (hiringPath != null)
                callPayload.Queries["HiringPath"] = ExpressionConverter.Convert(hiringPath);
            if (missionCriticalTags != null)
                callPayload.Queries["MissionCriticalTags"] = ExpressionConverter.Convert(missionCriticalTags);
            if (postingChannel != null)
                callPayload.Queries["PostingChannel"] = ExpressionConverter.Convert(postingChannel);
            if (fields != null)
                callPayload.Queries["Fields"] = ExpressionConverter.Convert(fields);
            if (sortField != null)
                callPayload.Queries["SortField"] = ExpressionConverter.Convert(sortField);
            if (sortDirection != null)
                callPayload.Queries["SortDirection"] = ExpressionConverter.Convert(sortDirection);
            if (page != null)
                callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
            if (resultsPerPage != null)
                callPayload.Queries["ResultsPerPage"] = ExpressionConverter.Convert(resultsPerPage);
            return new ApiConnectionAction<SearchJobsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicHonorsResponse> ListAcademicHonors(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/academichonors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListAcademicHonorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicLevelsResponse> ListAcademicLevels(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/academiclevels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListAcademicLevelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListActionCodesResponse> ListActionCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/actioncodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListActionCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAgencySubelementsResponse> ListAgencySubelements(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/agencysubelements";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListAgencySubelementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAnnouncementClosingTypesResponse> ListAnnouncementClosingTypes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/announcementclosingtypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListAnnouncementClosingTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicantSuppliersResponse> ListApplicantSuppliers(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/applicantsuppliers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListApplicantSuppliersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicationStatusesResponse> ListApplicationStatuses(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/applicationstatuses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListApplicationStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListCountriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountrySubdivisionsResponse> ListCountrySubdivisions(Expression<Func<string>> country = null, Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/countrysubdivisions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListCountrySubdivisionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkGroupingsResponse> ListCyberWorkGroupings(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/cyberworkgroupings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListCyberWorkGroupingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkRolesResponse> ListCyberWorkRoles(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/cyberworkroles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListCyberWorkRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDegreeTypeCodesResponse> ListDegreeTypeCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/degreetypecodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListDegreeTypeCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDisabilitiesResponse> ListDisabilities(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/disabilities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListDisabilitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentationsResponse> ListDocumentations(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/documentations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListDocumentationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentFormatsResponse> ListDocumentFormats(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/documentformats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListDocumentFormatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListEthnicitiesResponse> ListEthnicities(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/ethnicities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListEthnicitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListFederalEmploymentStatusesResponse> ListFederalEmploymentStatuses(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/federalemploymentstatuses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListFederalEmploymentStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGeolocCodesResponse> ListGeolocCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/geoloccodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListGeolocCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGsaGeolocCodesResponse> ListGsaGeolocCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/gsageoloccodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListGsaGeolocCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListHiringPathsResponse> ListHiringPaths(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/hiringpaths";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListHiringPathsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListKeyStandardRequirementsResponse> ListKeyStandardRequirements(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/keystandardrequirements";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListKeyStandardRequirementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageCodesResponse> ListLanguageCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/languagecodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListLanguageCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageProficienciesResponse> ListLanguageProficiencies(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/languageproficiencies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListLanguageProficienciesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLocationExpansionsResponse> ListLocationExpansions(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/locationexpansions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListLocationExpansionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMilitaryStatusCodesResponse> ListMilitaryStatusCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/militarystatuscodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListMilitaryStatusCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMissionCriticalCodesResponse> ListMissionCriticalCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/missioncriticalcodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListMissionCriticalCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListOccupationalSeriesResponse> ListOccupationalSeries(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/occupationalseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListOccupationalSeriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPayPlansResponse> ListPayPlans(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/payplans";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListPayPlansResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOfferingTypesResponse> ListPositionOfferingTypes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/positionofferingtypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListPositionOfferingTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOpeningStatusesResponse> ListPositionOpeningStatuses(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/positionopeningstatuses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListPositionOpeningStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionScheduleTypesResponse> ListPositionScheduleTypes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/positionscheduletypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListPositionScheduleTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPostalCodesResponse> ListPostalCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/postalcodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListPostalCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRaceCodesResponse> ListRaceCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/racecodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListRaceCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRefereeTypeCodesResponse> ListRefereeTypeCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/refereetypecodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListRefereeTypeCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRemunerationRateIntervalCodesResponse> ListRemunerationRateIntervalCodes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/remunerationrateintervalcodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListRemunerationRateIntervalCodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRequiredStandardDocumentsResponse> ListRequiredStandardDocuments(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/requiredstandarddocuments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListRequiredStandardDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSecurityClearancesResponse> ListSecurityClearances(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/securityclearances";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListSecurityClearancesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListServiceTypesResponse> ListServiceTypes(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/servicetypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListServiceTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSpecialHiringsResponse> ListSpecialHirings(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/specialhirings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListSpecialHiringsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListTravelPercentagesResponse> ListTravelPercentages(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/travelpercentages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListTravelPercentagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListWhoMayApplyResponse> ListWhoMayApply(Expression<Func<string>> lastmodified = null)
        {
            var apiCallPath = "/codelist/whomayapply";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lastmodified != null)
                callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
            return new ApiConnectionAction<ListWhoMayApplyResponse>(callPayload);
        }
    }

    public class UsajobsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchJobsResponse
    {
        public string LanguageCode { get; set; }
        public JToken SearchParameters { get; set; }
        public SearchJobsResponseSearchResultType SearchResult { get; set; }
    }

    public class SearchJobsResponseSearchResultType
    {
        public int SearchResultCount { get; set; }
        public int SearchResultCountAll { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItem[] SearchResultItems { get; set; }
        public SearchJobsResponseSearchResultTypeUserAreaType UserArea { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItem
    {
        public string MatchedObjectId { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorType MatchedObjectDescriptor { get; set; }
        public double RelevanceRank { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorType
    {
        public string PositionID { get; set; }
        public string PositionTitle { get; set; }
        public string PositionURI { get; set; }
        public string[] ApplyURI { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionLocationTypeItem[] PositionLocation { get; set; }
        public string OrganizationName { get; set; }
        public string DepartmentName { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeJobCategoryTypeItem[] JobCategory { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeJobGradeTypeItem[] JobGrade { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionScheduleTypeItem[] PositionSchedule { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionOfferingTypeTypeItem[] PositionOfferingType { get; set; }
        public string QualificationSummary { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionRemunerationTypeItem[] PositionRemuneration { get; set; }
        public string PositionStartDate { get; set; }
        public string PositionEndDate { get; set; }
        public string PublicationStartDate { get; set; }
        public string ApplicationCloseDate { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionFormattedDescriptionTypeItem[] PositionFormattedDescription { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaType UserArea { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionLocationTypeItem
    {
        public string LocationName { get; set; }
        public string CountryCode { get; set; }
        public string CountrySubDivisionCode { get; set; }
        public string CityName { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeJobCategoryTypeItem
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeJobGradeTypeItem
    {
        public string Code { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionScheduleTypeItem
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionOfferingTypeTypeItem
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionRemunerationTypeItem
    {
        public string MinimumRange { get; set; }
        public string MaximumRange { get; set; }
        public string RateIntervalCode { get; set; }
        public string Description { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypePositionFormattedDescriptionTypeItem
    {
        public string Content { get; set; }
        public string Label { get; set; }
        public string LabelDescription { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaType
    {
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaTypeDetailsType Details { get; set; }
        public bool IsRadialSearch { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaTypeDetailsType
    {
        public string[] MajorDuties { get; set; }
        public string Education { get; set; }
        public string Requirements { get; set; }
        public string Evaluations { get; set; }
        public string HowToApply { get; set; }
        public string WhatToExpectNext { get; set; }
        public string RequiredDocuments { get; set; }
        public string Benefits { get; set; }
        public string BenefitsUrl { get; set; }
        public string OtherInformation { get; set; }
        public string[] KeyRequirements { get; set; }
        public string JobSummary { get; set; }
        public SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaTypeDetailsTypeWhoMayApplyType WhoMayApply { get; set; }
        public string LowGrade { get; set; }
        public string HighGrade { get; set; }
        public string SubAgencyName { get; set; }
        public string OrganizationCodes { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeSearchResultItemsTypeItemMatchedObjectDescriptorTypeUserAreaTypeDetailsTypeWhoMayApplyType
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class SearchJobsResponseSearchResultTypeUserAreaType
    {
        public string NumberOfPages { get; set; }
        public bool IsRadialSearch { get; set; }
    }

    public enum positionSensitivityInput
    {
        [EnumMember(Value = "1")]
        _1NonSensitiveNSLowRisk,
        [EnumMember(Value = "2")]
        _2NoncriticalSensitiveNCSModerateRisk,
        [EnumMember(Value = "3")]
        _3CriticalSensitiveCSHighRisk,
        [EnumMember(Value = "4")]
        _4SpecialSensitiveSSHighRisk,
        [EnumMember(Value = "5")]
        _5ModerateRiskMR,
        [EnumMember(Value = "6")]
        _6HighRiskHR,
        [EnumMember(Value = "7")]
        _7NCSHighRisk
    }

    public enum fieldsInput
    {
        Min,
        Full
    }

    public enum sortFieldInput
    {
        [EnumMember(Value = "opendate")]
        Opendate,
        [EnumMember(Value = "closedate")]
        Closedate,
        [EnumMember(Value = "organizationname")]
        Organizationname,
        [EnumMember(Value = "jobtitle")]
        Jobtitle,
        [EnumMember(Value = "positiontitle")]
        Positiontitle,
        [EnumMember(Value = "openingdate")]
        Openingdate,
        [EnumMember(Value = "closingdate")]
        Closingdate,
        [EnumMember(Value = "honame")]
        Honame,
        [EnumMember(Value = "salarymin")]
        Salarymin,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "department")]
        Department,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "agency")]
        Agency,
        [EnumMember(Value = "salary")]
        Salary
    }

    public enum sortDirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ListAcademicHonorsResponse
    {
        public ListAcademicHonorsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListAcademicHonorsResponseCodeListTypeItem
    {
        public ListAcademicHonorsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListAcademicHonorsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListAcademicLevelsResponse
    {
        public ListAcademicLevelsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListAcademicLevelsResponseCodeListTypeItem
    {
        public ListAcademicLevelsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListAcademicLevelsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListActionCodesResponse
    {
        public ListActionCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListActionCodesResponseCodeListTypeItem
    {
        public ListActionCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListActionCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListAgencySubelementsResponse
    {
        public ListAgencySubelementsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListAgencySubelementsResponseCodeListTypeItem
    {
        public ListAgencySubelementsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListAgencySubelementsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListAnnouncementClosingTypesResponse
    {
        public ListAnnouncementClosingTypesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListAnnouncementClosingTypesResponseCodeListTypeItem
    {
        public ListAnnouncementClosingTypesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListAnnouncementClosingTypesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListApplicantSuppliersResponse
    {
        public ListApplicantSuppliersResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListApplicantSuppliersResponseCodeListTypeItem
    {
        public ListApplicantSuppliersResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListApplicantSuppliersResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListApplicationStatusesResponse
    {
        public ListApplicationStatusesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListApplicationStatusesResponseCodeListTypeItem
    {
        public ListApplicationStatusesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListApplicationStatusesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListCountriesResponse
    {
        public ListCountriesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListCountriesResponseCodeListTypeItem
    {
        public ListCountriesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListCountriesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListCountrySubdivisionsResponse
    {
        public ListCountrySubdivisionsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListCountrySubdivisionsResponseCodeListTypeItem
    {
        public ListCountrySubdivisionsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListCountrySubdivisionsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string ParentCode { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListCyberWorkGroupingsResponse
    {
        public ListCyberWorkGroupingsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListCyberWorkGroupingsResponseCodeListTypeItem
    {
        public ListCyberWorkGroupingsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListCyberWorkGroupingsResponseCodeListTypeItemValidValueTypeItem
    {
        public int Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public bool IsDisabled { get; set; }
    }

    public class ListCyberWorkRolesResponse
    {
        public ListCyberWorkRolesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListCyberWorkRolesResponseCodeListTypeItem
    {
        public ListCyberWorkRolesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListCyberWorkRolesResponseCodeListTypeItemValidValueTypeItem
    {
        public int Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public bool IsDisabled { get; set; }
    }

    public class ListDegreeTypeCodesResponse
    {
        public ListDegreeTypeCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListDegreeTypeCodesResponseCodeListTypeItem
    {
        public ListDegreeTypeCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListDegreeTypeCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListDisabilitiesResponse
    {
        public ListDisabilitiesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListDisabilitiesResponseCodeListTypeItem
    {
        public ListDisabilitiesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListDisabilitiesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListDocumentationsResponse
    {
        public ListDocumentationsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListDocumentationsResponseCodeListTypeItem
    {
        public ListDocumentationsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListDocumentationsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListDocumentFormatsResponse
    {
        public ListDocumentFormatsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListDocumentFormatsResponseCodeListTypeItem
    {
        public ListDocumentFormatsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListDocumentFormatsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListEthnicitiesResponse
    {
        public ListEthnicitiesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListEthnicitiesResponseCodeListTypeItem
    {
        public ListEthnicitiesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListEthnicitiesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListFederalEmploymentStatusesResponse
    {
        public ListFederalEmploymentStatusesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListFederalEmploymentStatusesResponseCodeListTypeItem
    {
        public ListFederalEmploymentStatusesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListFederalEmploymentStatusesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListGeolocCodesResponse
    {
        public ListGeolocCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListGeolocCodesResponseCodeListTypeItem
    {
        public ListGeolocCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListGeolocCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string City { get; set; }
        public string USCounty { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListGsaGeolocCodesResponse
    {
        public ListGsaGeolocCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListGsaGeolocCodesResponseCodeListTypeItem
    {
        public ListGsaGeolocCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListGsaGeolocCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string City { get; set; }
        public string USCounty { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListHiringPathsResponse
    {
        public ListHiringPathsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListHiringPathsResponseCodeListTypeItem
    {
        public ListHiringPathsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListHiringPathsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListKeyStandardRequirementsResponse
    {
        public ListKeyStandardRequirementsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListKeyStandardRequirementsResponseCodeListTypeItem
    {
        public ListKeyStandardRequirementsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListKeyStandardRequirementsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListLanguageCodesResponse
    {
        public ListLanguageCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListLanguageCodesResponseCodeListTypeItem
    {
        public ListLanguageCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListLanguageCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListLanguageProficienciesResponse
    {
        public ListLanguageProficienciesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListLanguageProficienciesResponseCodeListTypeItem
    {
        public ListLanguageProficienciesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListLanguageProficienciesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListLocationExpansionsResponse
    {
        public ListLocationExpansionsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListLocationExpansionsResponseCodeListTypeItem
    {
        public ListLocationExpansionsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListLocationExpansionsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string City { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
        public ListLocationExpansionsResponseCodeListTypeItemValidValueTypeItemExpansionTypeItem[] Expansion { get; set; }
    }

    public class ListLocationExpansionsResponseCodeListTypeItemValidValueTypeItemExpansionTypeItem
    {
        public string GeoLocCode { get; set; }
        public string City { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListMilitaryStatusCodesResponse
    {
        public ListMilitaryStatusCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListMilitaryStatusCodesResponseCodeListTypeItem
    {
        public ListMilitaryStatusCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListMilitaryStatusCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListMissionCriticalCodesResponse
    {
        public ListMissionCriticalCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListMissionCriticalCodesResponseCodeListTypeItem
    {
        public ListMissionCriticalCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListMissionCriticalCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListOccupationalSeriesResponse
    {
        public ListOccupationalSeriesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListOccupationalSeriesResponseCodeListTypeItem
    {
        public ListOccupationalSeriesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListOccupationalSeriesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListPayPlansResponse
    {
        public ListPayPlansResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListPayPlansResponseCodeListTypeItem
    {
        public ListPayPlansResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListPayPlansResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListPositionOfferingTypesResponse
    {
        public ListPositionOfferingTypesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListPositionOfferingTypesResponseCodeListTypeItem
    {
        public ListPositionOfferingTypesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListPositionOfferingTypesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListPositionOpeningStatusesResponse
    {
        public ListPositionOpeningStatusesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListPositionOpeningStatusesResponseCodeListTypeItem
    {
        public ListPositionOpeningStatusesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListPositionOpeningStatusesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListPositionScheduleTypesResponse
    {
        public ListPositionScheduleTypesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListPositionScheduleTypesResponseCodeListTypeItem
    {
        public ListPositionScheduleTypesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListPositionScheduleTypesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListPostalCodesResponse
    {
        public ListPostalCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListPostalCodesResponseCodeListTypeItem
    {
        public ListPostalCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListPostalCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public int RefLocID { get; set; }
        public string City { get; set; }
        public string USCounty { get; set; }
        public string CountrySubdivision { get; set; }
        public string Country { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListRaceCodesResponse
    {
        public ListRaceCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListRaceCodesResponseCodeListTypeItem
    {
        public ListRaceCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListRaceCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListRefereeTypeCodesResponse
    {
        public ListRefereeTypeCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListRefereeTypeCodesResponseCodeListTypeItem
    {
        public ListRefereeTypeCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListRefereeTypeCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListRemunerationRateIntervalCodesResponse
    {
        public ListRemunerationRateIntervalCodesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListRemunerationRateIntervalCodesResponseCodeListTypeItem
    {
        public ListRemunerationRateIntervalCodesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListRemunerationRateIntervalCodesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListRequiredStandardDocumentsResponse
    {
        public ListRequiredStandardDocumentsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListRequiredStandardDocumentsResponseCodeListTypeItem
    {
        public ListRequiredStandardDocumentsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListRequiredStandardDocumentsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListSecurityClearancesResponse
    {
        public ListSecurityClearancesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListSecurityClearancesResponseCodeListTypeItem
    {
        public ListSecurityClearancesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListSecurityClearancesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListServiceTypesResponse
    {
        public ListServiceTypesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListServiceTypesResponseCodeListTypeItem
    {
        public ListServiceTypesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListServiceTypesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListSpecialHiringsResponse
    {
        public ListSpecialHiringsResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListSpecialHiringsResponseCodeListTypeItem
    {
        public ListSpecialHiringsResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListSpecialHiringsResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListTravelPercentagesResponse
    {
        public ListTravelPercentagesResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListTravelPercentagesResponseCodeListTypeItem
    {
        public ListTravelPercentagesResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListTravelPercentagesResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }

    public class ListWhoMayApplyResponse
    {
        public ListWhoMayApplyResponseCodeListTypeItem[] CodeList { get; set; }
        public string DateGenerated { get; set; }
    }

    public class ListWhoMayApplyResponseCodeListTypeItem
    {
        public ListWhoMayApplyResponseCodeListTypeItemValidValueTypeItem[] ValidValue { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListWhoMayApplyResponseCodeListTypeItemValidValueTypeItem
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string LastModified { get; set; }
        public string IsDisabled { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Usajobs;

    public partial class WorkflowManagedActions
    {
        public UsajobsActions Usajobs(string connectionId) => new UsajobsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UsajobsTriggers Usajobs(string connectionId) => new UsajobsTriggers(connectionId);
    }
}