//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usajobs
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsajobsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildSearchJobs))]
        public IBodyWorkflowAction<SearchJobsResponse> SearchJobs([WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> positionTitle = null, [WorkflowExpression] Func<int> remunerationMinimumAmount = null, [WorkflowExpression] Func<int> remunerationMaximumAmount = null, [WorkflowExpression] Func<string> payGradeHigh = null, [WorkflowExpression] Func<string> payGradeLow = null, [WorkflowExpression] Func<string> jobCategoryCode = null, [WorkflowExpression] Func<bool> remoteIndicator = null, [WorkflowExpression] Func<string> locationName = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<bool> relocationIndicator = null, [WorkflowExpression] Func<string> travelPercentage = null, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<string> positionOfferingTypeCode = null, [WorkflowExpression] Func<string> positionScheduleTypeCode = null, [WorkflowExpression] Func<string> securityClearanceRequired = null, [WorkflowExpression] Func<positionSensitivityInput> positionSensitivity = null, [WorkflowExpression] Func<bool> supervisoryStatus = null, [WorkflowExpression] Func<int> datePosted = null, [WorkflowExpression] Func<string> jobGradeCode = null, [WorkflowExpression] Func<string> whoMayApply = null, [WorkflowExpression] Func<string> salaryBucket = null, [WorkflowExpression] Func<string> gradeBucket = null, [WorkflowExpression] Func<string> hiringPath = null, [WorkflowExpression] Func<string> missionCriticalTags = null, [WorkflowExpression] Func<string> postingChannel = null, [WorkflowExpression] Func<fieldsInput> fields = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> resultsPerPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchJobsResponse> __BuildSearchJobs(WorkflowValue<string> keyword = null, WorkflowValue<string> positionTitle = null, WorkflowValue<int> remunerationMinimumAmount = null, WorkflowValue<int> remunerationMaximumAmount = null, WorkflowValue<string> payGradeHigh = null, WorkflowValue<string> payGradeLow = null, WorkflowValue<string> jobCategoryCode = null, WorkflowValue<bool> remoteIndicator = null, WorkflowValue<string> locationName = null, WorkflowValue<int> radius = null, WorkflowValue<bool> relocationIndicator = null, WorkflowValue<string> travelPercentage = null, WorkflowValue<string> organization = null, WorkflowValue<string> positionOfferingTypeCode = null, WorkflowValue<string> positionScheduleTypeCode = null, WorkflowValue<string> securityClearanceRequired = null, WorkflowValue<positionSensitivityInput> positionSensitivity = null, WorkflowValue<bool> supervisoryStatus = null, WorkflowValue<int> datePosted = null, WorkflowValue<string> jobGradeCode = null, WorkflowValue<string> whoMayApply = null, WorkflowValue<string> salaryBucket = null, WorkflowValue<string> gradeBucket = null, WorkflowValue<string> hiringPath = null, WorkflowValue<string> missionCriticalTags = null, WorkflowValue<string> postingChannel = null, WorkflowValue<fieldsInput> fields = null, WorkflowValue<sortFieldInput> sortField = null, WorkflowValue<sortDirectionInput> sortDirection = null, WorkflowValue<int> page = null, WorkflowValue<int> resultsPerPage = null)
        {
            WorkflowValue.Validate(keyword, nameof(keyword), required: false);
            WorkflowValue.Validate(positionTitle, nameof(positionTitle), required: false);
            WorkflowValue.Validate(remunerationMinimumAmount, nameof(remunerationMinimumAmount), required: false);
            WorkflowValue.Validate(remunerationMaximumAmount, nameof(remunerationMaximumAmount), required: false);
            WorkflowValue.Validate(payGradeHigh, nameof(payGradeHigh), required: false);
            WorkflowValue.Validate(payGradeLow, nameof(payGradeLow), required: false);
            WorkflowValue.Validate(jobCategoryCode, nameof(jobCategoryCode), required: false);
            WorkflowValue.Validate(remoteIndicator, nameof(remoteIndicator), required: false);
            WorkflowValue.Validate(locationName, nameof(locationName), required: false);
            WorkflowValue.Validate(radius, nameof(radius), required: false);
            WorkflowValue.Validate(relocationIndicator, nameof(relocationIndicator), required: false);
            WorkflowValue.Validate(travelPercentage, nameof(travelPercentage), required: false);
            WorkflowValue.Validate(organization, nameof(organization), required: false);
            WorkflowValue.Validate(positionOfferingTypeCode, nameof(positionOfferingTypeCode), required: false);
            WorkflowValue.Validate(positionScheduleTypeCode, nameof(positionScheduleTypeCode), required: false);
            WorkflowValue.Validate(securityClearanceRequired, nameof(securityClearanceRequired), required: false);
            WorkflowValue.Validate(positionSensitivity, nameof(positionSensitivity), required: false);
            WorkflowValue.Validate(supervisoryStatus, nameof(supervisoryStatus), required: false);
            WorkflowValue.Validate(datePosted, nameof(datePosted), required: false);
            WorkflowValue.Validate(jobGradeCode, nameof(jobGradeCode), required: false);
            WorkflowValue.Validate(whoMayApply, nameof(whoMayApply), required: false);
            WorkflowValue.Validate(salaryBucket, nameof(salaryBucket), required: false);
            WorkflowValue.Validate(gradeBucket, nameof(gradeBucket), required: false);
            WorkflowValue.Validate(hiringPath, nameof(hiringPath), required: false);
            WorkflowValue.Validate(missionCriticalTags, nameof(missionCriticalTags), required: false);
            WorkflowValue.Validate(postingChannel, nameof(postingChannel), required: false);
            WorkflowValue.Validate(fields, nameof(fields), required: false);
            WorkflowValue.Validate(sortField, nameof(sortField), required: false);
            WorkflowValue.Validate(sortDirection, nameof(sortDirection), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            return new DeferredBodyAction<SearchJobsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListAcademicHonors))]
        public IBodyWorkflowAction<ListAcademicHonorsResponse> ListAcademicHonors([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAcademicHonorsResponse> __BuildListAcademicHonors(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAcademicHonorsResponse>(() =>
            {
                var apiCallPath = "/codelist/academichonors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListAcademicHonorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListAcademicLevels))]
        public IBodyWorkflowAction<ListAcademicLevelsResponse> ListAcademicLevels([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAcademicLevelsResponse> __BuildListAcademicLevels(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAcademicLevelsResponse>(() =>
            {
                var apiCallPath = "/codelist/academiclevels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListAcademicLevelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListActionCodes))]
        public IBodyWorkflowAction<ListActionCodesResponse> ListActionCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListActionCodesResponse> __BuildListActionCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListActionCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/actioncodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListActionCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListAgencySubelements))]
        public IBodyWorkflowAction<ListAgencySubelementsResponse> ListAgencySubelements([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAgencySubelementsResponse> __BuildListAgencySubelements(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAgencySubelementsResponse>(() =>
            {
                var apiCallPath = "/codelist/agencysubelements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListAgencySubelementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListAnnouncementClosingTypes))]
        public IBodyWorkflowAction<ListAnnouncementClosingTypesResponse> ListAnnouncementClosingTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAnnouncementClosingTypesResponse> __BuildListAnnouncementClosingTypes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAnnouncementClosingTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/announcementclosingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListAnnouncementClosingTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListApplicantSuppliers))]
        public IBodyWorkflowAction<ListApplicantSuppliersResponse> ListApplicantSuppliers([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListApplicantSuppliersResponse> __BuildListApplicantSuppliers(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListApplicantSuppliersResponse>(() =>
            {
                var apiCallPath = "/codelist/applicantsuppliers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListApplicantSuppliersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListApplicationStatuses))]
        public IBodyWorkflowAction<ListApplicationStatusesResponse> ListApplicationStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListApplicationStatusesResponse> __BuildListApplicationStatuses(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListApplicationStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/applicationstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListApplicationStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListCountries))]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCountriesResponse> __BuildListCountries(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCountriesResponse>(() =>
            {
                var apiCallPath = "/codelist/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListCountriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListCountrySubdivisions))]
        public IBodyWorkflowAction<ListCountrySubdivisionsResponse> ListCountrySubdivisions([WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCountrySubdivisionsResponse> __BuildListCountrySubdivisions(WorkflowValue<string> country = null, WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCountrySubdivisionsResponse>(() =>
            {
                var apiCallPath = "/codelist/countrysubdivisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListCountrySubdivisionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListCyberWorkGroupings))]
        public IBodyWorkflowAction<ListCyberWorkGroupingsResponse> ListCyberWorkGroupings([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCyberWorkGroupingsResponse> __BuildListCyberWorkGroupings(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCyberWorkGroupingsResponse>(() =>
            {
                var apiCallPath = "/codelist/cyberworkgroupings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListCyberWorkGroupingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListCyberWorkRoles))]
        public IBodyWorkflowAction<ListCyberWorkRolesResponse> ListCyberWorkRoles([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCyberWorkRolesResponse> __BuildListCyberWorkRoles(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCyberWorkRolesResponse>(() =>
            {
                var apiCallPath = "/codelist/cyberworkroles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListCyberWorkRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListDegreeTypeCodes))]
        public IBodyWorkflowAction<ListDegreeTypeCodesResponse> ListDegreeTypeCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDegreeTypeCodesResponse> __BuildListDegreeTypeCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDegreeTypeCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/degreetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListDegreeTypeCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListDisabilities))]
        public IBodyWorkflowAction<ListDisabilitiesResponse> ListDisabilities([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDisabilitiesResponse> __BuildListDisabilities(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDisabilitiesResponse>(() =>
            {
                var apiCallPath = "/codelist/disabilities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListDisabilitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListDocumentations))]
        public IBodyWorkflowAction<ListDocumentationsResponse> ListDocumentations([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDocumentationsResponse> __BuildListDocumentations(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDocumentationsResponse>(() =>
            {
                var apiCallPath = "/codelist/documentations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListDocumentationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListDocumentFormats))]
        public IBodyWorkflowAction<ListDocumentFormatsResponse> ListDocumentFormats([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDocumentFormatsResponse> __BuildListDocumentFormats(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDocumentFormatsResponse>(() =>
            {
                var apiCallPath = "/codelist/documentformats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListDocumentFormatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListEthnicities))]
        public IBodyWorkflowAction<ListEthnicitiesResponse> ListEthnicities([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListEthnicitiesResponse> __BuildListEthnicities(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListEthnicitiesResponse>(() =>
            {
                var apiCallPath = "/codelist/ethnicities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListEthnicitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListFederalEmploymentStatuses))]
        public IBodyWorkflowAction<ListFederalEmploymentStatusesResponse> ListFederalEmploymentStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFederalEmploymentStatusesResponse> __BuildListFederalEmploymentStatuses(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListFederalEmploymentStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/federalemploymentstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListFederalEmploymentStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListGeolocCodes))]
        public IBodyWorkflowAction<ListGeolocCodesResponse> ListGeolocCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGeolocCodesResponse> __BuildListGeolocCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListGeolocCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/geoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListGeolocCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListGsaGeolocCodes))]
        public IBodyWorkflowAction<ListGsaGeolocCodesResponse> ListGsaGeolocCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGsaGeolocCodesResponse> __BuildListGsaGeolocCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListGsaGeolocCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/gsageoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListGsaGeolocCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListHiringPaths))]
        public IBodyWorkflowAction<ListHiringPathsResponse> ListHiringPaths([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListHiringPathsResponse> __BuildListHiringPaths(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListHiringPathsResponse>(() =>
            {
                var apiCallPath = "/codelist/hiringpaths";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListHiringPathsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListKeyStandardRequirements))]
        public IBodyWorkflowAction<ListKeyStandardRequirementsResponse> ListKeyStandardRequirements([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListKeyStandardRequirementsResponse> __BuildListKeyStandardRequirements(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListKeyStandardRequirementsResponse>(() =>
            {
                var apiCallPath = "/codelist/keystandardrequirements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListKeyStandardRequirementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListLanguageCodes))]
        public IBodyWorkflowAction<ListLanguageCodesResponse> ListLanguageCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListLanguageCodesResponse> __BuildListLanguageCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLanguageCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/languagecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListLanguageCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListLanguageProficiencies))]
        public IBodyWorkflowAction<ListLanguageProficienciesResponse> ListLanguageProficiencies([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListLanguageProficienciesResponse> __BuildListLanguageProficiencies(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLanguageProficienciesResponse>(() =>
            {
                var apiCallPath = "/codelist/languageproficiencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListLanguageProficienciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListLocationExpansions))]
        public IBodyWorkflowAction<ListLocationExpansionsResponse> ListLocationExpansions([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListLocationExpansionsResponse> __BuildListLocationExpansions(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLocationExpansionsResponse>(() =>
            {
                var apiCallPath = "/codelist/locationexpansions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListLocationExpansionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListMilitaryStatusCodes))]
        public IBodyWorkflowAction<ListMilitaryStatusCodesResponse> ListMilitaryStatusCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMilitaryStatusCodesResponse> __BuildListMilitaryStatusCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListMilitaryStatusCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/militarystatuscodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListMilitaryStatusCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListMissionCriticalCodes))]
        public IBodyWorkflowAction<ListMissionCriticalCodesResponse> ListMissionCriticalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMissionCriticalCodesResponse> __BuildListMissionCriticalCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListMissionCriticalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/missioncriticalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListMissionCriticalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListOccupationalSeries))]
        public IBodyWorkflowAction<ListOccupationalSeriesResponse> ListOccupationalSeries([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOccupationalSeriesResponse> __BuildListOccupationalSeries(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListOccupationalSeriesResponse>(() =>
            {
                var apiCallPath = "/codelist/occupationalseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListOccupationalSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListPayPlans))]
        public IBodyWorkflowAction<ListPayPlansResponse> ListPayPlans([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPayPlansResponse> __BuildListPayPlans(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPayPlansResponse>(() =>
            {
                var apiCallPath = "/codelist/payplans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListPayPlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListPositionOfferingTypes))]
        public IBodyWorkflowAction<ListPositionOfferingTypesResponse> ListPositionOfferingTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPositionOfferingTypesResponse> __BuildListPositionOfferingTypes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionOfferingTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionofferingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListPositionOfferingTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListPositionOpeningStatuses))]
        public IBodyWorkflowAction<ListPositionOpeningStatusesResponse> ListPositionOpeningStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPositionOpeningStatusesResponse> __BuildListPositionOpeningStatuses(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionOpeningStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionopeningstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListPositionOpeningStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListPositionScheduleTypes))]
        public IBodyWorkflowAction<ListPositionScheduleTypesResponse> ListPositionScheduleTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPositionScheduleTypesResponse> __BuildListPositionScheduleTypes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionScheduleTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionscheduletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListPositionScheduleTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListPostalCodes))]
        public IBodyWorkflowAction<ListPostalCodesResponse> ListPostalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPostalCodesResponse> __BuildListPostalCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPostalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/postalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListPostalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListRaceCodes))]
        public IBodyWorkflowAction<ListRaceCodesResponse> ListRaceCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRaceCodesResponse> __BuildListRaceCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRaceCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/racecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListRaceCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListRefereeTypeCodes))]
        public IBodyWorkflowAction<ListRefereeTypeCodesResponse> ListRefereeTypeCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRefereeTypeCodesResponse> __BuildListRefereeTypeCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRefereeTypeCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/refereetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListRefereeTypeCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListRemunerationRateIntervalCodes))]
        public IBodyWorkflowAction<ListRemunerationRateIntervalCodesResponse> ListRemunerationRateIntervalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRemunerationRateIntervalCodesResponse> __BuildListRemunerationRateIntervalCodes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRemunerationRateIntervalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/remunerationrateintervalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListRemunerationRateIntervalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListRequiredStandardDocuments))]
        public IBodyWorkflowAction<ListRequiredStandardDocumentsResponse> ListRequiredStandardDocuments([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRequiredStandardDocumentsResponse> __BuildListRequiredStandardDocuments(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRequiredStandardDocumentsResponse>(() =>
            {
                var apiCallPath = "/codelist/requiredstandarddocuments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListRequiredStandardDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListSecurityClearances))]
        public IBodyWorkflowAction<ListSecurityClearancesResponse> ListSecurityClearances([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSecurityClearancesResponse> __BuildListSecurityClearances(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListSecurityClearancesResponse>(() =>
            {
                var apiCallPath = "/codelist/securityclearances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListSecurityClearancesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListServiceTypes))]
        public IBodyWorkflowAction<ListServiceTypesResponse> ListServiceTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListServiceTypesResponse> __BuildListServiceTypes(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListServiceTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/servicetypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListServiceTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListSpecialHirings))]
        public IBodyWorkflowAction<ListSpecialHiringsResponse> ListSpecialHirings([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSpecialHiringsResponse> __BuildListSpecialHirings(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListSpecialHiringsResponse>(() =>
            {
                var apiCallPath = "/codelist/specialhirings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListSpecialHiringsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListTravelPercentages))]
        public IBodyWorkflowAction<ListTravelPercentagesResponse> ListTravelPercentages([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTravelPercentagesResponse> __BuildListTravelPercentages(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListTravelPercentagesResponse>(() =>
            {
                var apiCallPath = "/codelist/travelpercentages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListTravelPercentagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        [WorkflowExpressionFactory(nameof(__BuildListWhoMayApply))]
        public IBodyWorkflowAction<ListWhoMayApplyResponse> ListWhoMayApply([WorkflowExpression] Func<string> lastmodified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListWhoMayApplyResponse> __BuildListWhoMayApply(WorkflowValue<string> lastmodified = null)
        {
            WorkflowValue.Validate(lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListWhoMayApplyResponse>(() =>
            {
                var apiCallPath = "/codelist/whomayapply";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(lastmodified);
                return new ApiConnectionAction<ListWhoMayApplyResponse>(callPayload);
            });
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Usajobs;

    public partial class WorkflowManagedActions
    {
        public UsajobsActions Usajobs(string connectionId) => new UsajobsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UsajobsTriggers Usajobs(string connectionId) => new UsajobsTriggers(connectionId);
    }
}
