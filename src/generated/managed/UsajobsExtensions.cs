//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usajobs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class UsajobsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<SearchJobsResponse> SearchJobs(Expression<Func<string>> keyword = null, Expression<Func<string>> positionTitle = null, Expression<Func<int>> remunerationMinimumAmount = null, Expression<Func<int>> remunerationMaximumAmount = null, Expression<Func<string>> payGradeHigh = null, Expression<Func<string>> payGradeLow = null, Expression<Func<string>> jobCategoryCode = null, Expression<Func<bool>> remoteIndicator = null, Expression<Func<string>> locationName = null, Expression<Func<int>> radius = null, Expression<Func<bool>> relocationIndicator = null, Expression<Func<string>> travelPercentage = null, Expression<Func<string>> organization = null, Expression<Func<string>> positionOfferingTypeCode = null, Expression<Func<string>> positionScheduleTypeCode = null, Expression<Func<string>> securityClearanceRequired = null, Expression<Func<positionSensitivityInput>> positionSensitivity = null, Expression<Func<bool>> supervisoryStatus = null, Expression<Func<int>> datePosted = null, Expression<Func<string>> jobGradeCode = null, Expression<Func<string>> whoMayApply = null, Expression<Func<string>> salaryBucket = null, Expression<Func<string>> gradeBucket = null, Expression<Func<string>> hiringPath = null, Expression<Func<string>> missionCriticalTags = null, Expression<Func<string>> postingChannel = null, Expression<Func<fieldsInput>> fields = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null, Expression<Func<int>> page = null, Expression<Func<int>> resultsPerPage = null)
        {
            var __workflow_keyword = keyword == null ? null : WorkflowExpression.Compile(keyword);
            WorkflowExpression.Validate(__workflow_keyword, nameof(keyword), required: false);
            var __workflow_positionTitle = positionTitle == null ? null : WorkflowExpression.Compile(positionTitle);
            WorkflowExpression.Validate(__workflow_positionTitle, nameof(positionTitle), required: false);
            var __workflow_remunerationMinimumAmount = remunerationMinimumAmount == null ? null : WorkflowExpression.Compile(remunerationMinimumAmount);
            WorkflowExpression.Validate(__workflow_remunerationMinimumAmount, nameof(remunerationMinimumAmount), required: false);
            var __workflow_remunerationMaximumAmount = remunerationMaximumAmount == null ? null : WorkflowExpression.Compile(remunerationMaximumAmount);
            WorkflowExpression.Validate(__workflow_remunerationMaximumAmount, nameof(remunerationMaximumAmount), required: false);
            var __workflow_payGradeHigh = payGradeHigh == null ? null : WorkflowExpression.Compile(payGradeHigh);
            WorkflowExpression.Validate(__workflow_payGradeHigh, nameof(payGradeHigh), required: false);
            var __workflow_payGradeLow = payGradeLow == null ? null : WorkflowExpression.Compile(payGradeLow);
            WorkflowExpression.Validate(__workflow_payGradeLow, nameof(payGradeLow), required: false);
            var __workflow_jobCategoryCode = jobCategoryCode == null ? null : WorkflowExpression.Compile(jobCategoryCode);
            WorkflowExpression.Validate(__workflow_jobCategoryCode, nameof(jobCategoryCode), required: false);
            var __workflow_remoteIndicator = remoteIndicator == null ? null : WorkflowExpression.Compile(remoteIndicator);
            WorkflowExpression.Validate(__workflow_remoteIndicator, nameof(remoteIndicator), required: false);
            var __workflow_locationName = locationName == null ? null : WorkflowExpression.Compile(locationName);
            WorkflowExpression.Validate(__workflow_locationName, nameof(locationName), required: false);
            var __workflow_radius = radius == null ? null : WorkflowExpression.Compile(radius);
            WorkflowExpression.Validate(__workflow_radius, nameof(radius), required: false);
            var __workflow_relocationIndicator = relocationIndicator == null ? null : WorkflowExpression.Compile(relocationIndicator);
            WorkflowExpression.Validate(__workflow_relocationIndicator, nameof(relocationIndicator), required: false);
            var __workflow_travelPercentage = travelPercentage == null ? null : WorkflowExpression.Compile(travelPercentage);
            WorkflowExpression.Validate(__workflow_travelPercentage, nameof(travelPercentage), required: false);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_positionOfferingTypeCode = positionOfferingTypeCode == null ? null : WorkflowExpression.Compile(positionOfferingTypeCode);
            WorkflowExpression.Validate(__workflow_positionOfferingTypeCode, nameof(positionOfferingTypeCode), required: false);
            var __workflow_positionScheduleTypeCode = positionScheduleTypeCode == null ? null : WorkflowExpression.Compile(positionScheduleTypeCode);
            WorkflowExpression.Validate(__workflow_positionScheduleTypeCode, nameof(positionScheduleTypeCode), required: false);
            var __workflow_securityClearanceRequired = securityClearanceRequired == null ? null : WorkflowExpression.Compile(securityClearanceRequired);
            WorkflowExpression.Validate(__workflow_securityClearanceRequired, nameof(securityClearanceRequired), required: false);
            var __workflow_positionSensitivity = positionSensitivity == null ? null : WorkflowExpression.Compile(positionSensitivity);
            WorkflowExpression.Validate(__workflow_positionSensitivity, nameof(positionSensitivity), required: false);
            var __workflow_supervisoryStatus = supervisoryStatus == null ? null : WorkflowExpression.Compile(supervisoryStatus);
            WorkflowExpression.Validate(__workflow_supervisoryStatus, nameof(supervisoryStatus), required: false);
            var __workflow_datePosted = datePosted == null ? null : WorkflowExpression.Compile(datePosted);
            WorkflowExpression.Validate(__workflow_datePosted, nameof(datePosted), required: false);
            var __workflow_jobGradeCode = jobGradeCode == null ? null : WorkflowExpression.Compile(jobGradeCode);
            WorkflowExpression.Validate(__workflow_jobGradeCode, nameof(jobGradeCode), required: false);
            var __workflow_whoMayApply = whoMayApply == null ? null : WorkflowExpression.Compile(whoMayApply);
            WorkflowExpression.Validate(__workflow_whoMayApply, nameof(whoMayApply), required: false);
            var __workflow_salaryBucket = salaryBucket == null ? null : WorkflowExpression.Compile(salaryBucket);
            WorkflowExpression.Validate(__workflow_salaryBucket, nameof(salaryBucket), required: false);
            var __workflow_gradeBucket = gradeBucket == null ? null : WorkflowExpression.Compile(gradeBucket);
            WorkflowExpression.Validate(__workflow_gradeBucket, nameof(gradeBucket), required: false);
            var __workflow_hiringPath = hiringPath == null ? null : WorkflowExpression.Compile(hiringPath);
            WorkflowExpression.Validate(__workflow_hiringPath, nameof(hiringPath), required: false);
            var __workflow_missionCriticalTags = missionCriticalTags == null ? null : WorkflowExpression.Compile(missionCriticalTags);
            WorkflowExpression.Validate(__workflow_missionCriticalTags, nameof(missionCriticalTags), required: false);
            var __workflow_postingChannel = postingChannel == null ? null : WorkflowExpression.Compile(postingChannel);
            WorkflowExpression.Validate(__workflow_postingChannel, nameof(postingChannel), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sortField = sortField == null ? null : WorkflowExpression.Compile(sortField);
            WorkflowExpression.Validate(__workflow_sortField, nameof(sortField), required: false);
            var __workflow_sortDirection = sortDirection == null ? null : WorkflowExpression.Compile(sortDirection);
            WorkflowExpression.Validate(__workflow_sortDirection, nameof(sortDirection), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_resultsPerPage = resultsPerPage == null ? null : WorkflowExpression.Compile(resultsPerPage);
            WorkflowExpression.Validate(__workflow_resultsPerPage, nameof(resultsPerPage), required: false);
            return new DeferredBodyAction<SearchJobsResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyword != null)
                    callPayload.Queries["Keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                if (__workflow_positionTitle != null)
                    callPayload.Queries["PositionTitle"] = ExpressionConverter.Convert(__workflow_positionTitle);
                if (__workflow_remunerationMinimumAmount != null)
                    callPayload.Queries["RemunerationMinimumAmount"] = ExpressionConverter.Convert(__workflow_remunerationMinimumAmount);
                if (__workflow_remunerationMaximumAmount != null)
                    callPayload.Queries["RemunerationMaximumAmount"] = ExpressionConverter.Convert(__workflow_remunerationMaximumAmount);
                if (__workflow_payGradeHigh != null)
                    callPayload.Queries["PayGradeHigh"] = ExpressionConverter.Convert(__workflow_payGradeHigh);
                if (__workflow_payGradeLow != null)
                    callPayload.Queries["PayGradeLow"] = ExpressionConverter.Convert(__workflow_payGradeLow);
                if (__workflow_jobCategoryCode != null)
                    callPayload.Queries["JobCategoryCode"] = ExpressionConverter.Convert(__workflow_jobCategoryCode);
                if (__workflow_remoteIndicator != null)
                    callPayload.Queries["RemoteIndicator"] = ExpressionConverter.Convert(__workflow_remoteIndicator);
                if (__workflow_locationName != null)
                    callPayload.Queries["LocationName"] = ExpressionConverter.Convert(__workflow_locationName);
                if (__workflow_radius != null)
                    callPayload.Queries["Radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_relocationIndicator != null)
                    callPayload.Queries["RelocationIndicator"] = ExpressionConverter.Convert(__workflow_relocationIndicator);
                if (__workflow_travelPercentage != null)
                    callPayload.Queries["TravelPercentage"] = ExpressionConverter.Convert(__workflow_travelPercentage);
                if (__workflow_organization != null)
                    callPayload.Queries["Organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_positionOfferingTypeCode != null)
                    callPayload.Queries["PositionOfferingTypeCode"] = ExpressionConverter.Convert(__workflow_positionOfferingTypeCode);
                if (__workflow_positionScheduleTypeCode != null)
                    callPayload.Queries["PositionScheduleTypeCode"] = ExpressionConverter.Convert(__workflow_positionScheduleTypeCode);
                if (__workflow_securityClearanceRequired != null)
                    callPayload.Queries["SecurityClearanceRequired"] = ExpressionConverter.Convert(__workflow_securityClearanceRequired);
                if (__workflow_positionSensitivity != null)
                    callPayload.Queries["PositionSensitivity"] = ExpressionConverter.Convert(__workflow_positionSensitivity);
                if (__workflow_supervisoryStatus != null)
                    callPayload.Queries["SupervisoryStatus"] = ExpressionConverter.Convert(__workflow_supervisoryStatus);
                if (__workflow_datePosted != null)
                    callPayload.Queries["DatePosted"] = ExpressionConverter.Convert(__workflow_datePosted);
                if (__workflow_jobGradeCode != null)
                    callPayload.Queries["JobGradeCode"] = ExpressionConverter.Convert(__workflow_jobGradeCode);
                if (__workflow_whoMayApply != null)
                    callPayload.Queries["WhoMayApply"] = ExpressionConverter.Convert(__workflow_whoMayApply);
                if (__workflow_salaryBucket != null)
                    callPayload.Queries["SalaryBucket"] = ExpressionConverter.Convert(__workflow_salaryBucket);
                if (__workflow_gradeBucket != null)
                    callPayload.Queries["GradeBucket"] = ExpressionConverter.Convert(__workflow_gradeBucket);
                if (__workflow_hiringPath != null)
                    callPayload.Queries["HiringPath"] = ExpressionConverter.Convert(__workflow_hiringPath);
                if (__workflow_missionCriticalTags != null)
                    callPayload.Queries["MissionCriticalTags"] = ExpressionConverter.Convert(__workflow_missionCriticalTags);
                if (__workflow_postingChannel != null)
                    callPayload.Queries["PostingChannel"] = ExpressionConverter.Convert(__workflow_postingChannel);
                if (__workflow_fields != null)
                    callPayload.Queries["Fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sortField != null)
                    callPayload.Queries["SortField"] = ExpressionConverter.Convert(__workflow_sortField);
                if (__workflow_sortDirection != null)
                    callPayload.Queries["SortDirection"] = ExpressionConverter.Convert(__workflow_sortDirection);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_resultsPerPage != null)
                    callPayload.Queries["ResultsPerPage"] = ExpressionConverter.Convert(__workflow_resultsPerPage);
                return new ApiConnectionAction<SearchJobsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicHonorsResponse> ListAcademicHonors(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAcademicHonorsResponse>(() =>
            {
                var apiCallPath = "/codelist/academichonors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListAcademicHonorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicLevelsResponse> ListAcademicLevels(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAcademicLevelsResponse>(() =>
            {
                var apiCallPath = "/codelist/academiclevels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListAcademicLevelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListActionCodesResponse> ListActionCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListActionCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/actioncodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListActionCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAgencySubelementsResponse> ListAgencySubelements(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAgencySubelementsResponse>(() =>
            {
                var apiCallPath = "/codelist/agencysubelements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListAgencySubelementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAnnouncementClosingTypesResponse> ListAnnouncementClosingTypes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListAnnouncementClosingTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/announcementclosingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListAnnouncementClosingTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicantSuppliersResponse> ListApplicantSuppliers(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListApplicantSuppliersResponse>(() =>
            {
                var apiCallPath = "/codelist/applicantsuppliers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListApplicantSuppliersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicationStatusesResponse> ListApplicationStatuses(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListApplicationStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/applicationstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListApplicationStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCountriesResponse>(() =>
            {
                var apiCallPath = "/codelist/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListCountriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountrySubdivisionsResponse> ListCountrySubdivisions(Expression<Func<string>> country = null, Expression<Func<string>> lastmodified = null)
        {
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCountrySubdivisionsResponse>(() =>
            {
                var apiCallPath = "/codelist/countrysubdivisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListCountrySubdivisionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkGroupingsResponse> ListCyberWorkGroupings(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCyberWorkGroupingsResponse>(() =>
            {
                var apiCallPath = "/codelist/cyberworkgroupings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListCyberWorkGroupingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkRolesResponse> ListCyberWorkRoles(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListCyberWorkRolesResponse>(() =>
            {
                var apiCallPath = "/codelist/cyberworkroles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListCyberWorkRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDegreeTypeCodesResponse> ListDegreeTypeCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDegreeTypeCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/degreetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListDegreeTypeCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDisabilitiesResponse> ListDisabilities(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDisabilitiesResponse>(() =>
            {
                var apiCallPath = "/codelist/disabilities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListDisabilitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentationsResponse> ListDocumentations(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDocumentationsResponse>(() =>
            {
                var apiCallPath = "/codelist/documentations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListDocumentationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentFormatsResponse> ListDocumentFormats(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListDocumentFormatsResponse>(() =>
            {
                var apiCallPath = "/codelist/documentformats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListDocumentFormatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListEthnicitiesResponse> ListEthnicities(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListEthnicitiesResponse>(() =>
            {
                var apiCallPath = "/codelist/ethnicities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListEthnicitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListFederalEmploymentStatusesResponse> ListFederalEmploymentStatuses(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListFederalEmploymentStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/federalemploymentstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListFederalEmploymentStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGeolocCodesResponse> ListGeolocCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListGeolocCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/geoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListGeolocCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGsaGeolocCodesResponse> ListGsaGeolocCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListGsaGeolocCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/gsageoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListGsaGeolocCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListHiringPathsResponse> ListHiringPaths(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListHiringPathsResponse>(() =>
            {
                var apiCallPath = "/codelist/hiringpaths";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListHiringPathsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListKeyStandardRequirementsResponse> ListKeyStandardRequirements(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListKeyStandardRequirementsResponse>(() =>
            {
                var apiCallPath = "/codelist/keystandardrequirements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListKeyStandardRequirementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageCodesResponse> ListLanguageCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLanguageCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/languagecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListLanguageCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageProficienciesResponse> ListLanguageProficiencies(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLanguageProficienciesResponse>(() =>
            {
                var apiCallPath = "/codelist/languageproficiencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListLanguageProficienciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLocationExpansionsResponse> ListLocationExpansions(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListLocationExpansionsResponse>(() =>
            {
                var apiCallPath = "/codelist/locationexpansions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListLocationExpansionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMilitaryStatusCodesResponse> ListMilitaryStatusCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListMilitaryStatusCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/militarystatuscodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListMilitaryStatusCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMissionCriticalCodesResponse> ListMissionCriticalCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListMissionCriticalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/missioncriticalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListMissionCriticalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListOccupationalSeriesResponse> ListOccupationalSeries(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListOccupationalSeriesResponse>(() =>
            {
                var apiCallPath = "/codelist/occupationalseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListOccupationalSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPayPlansResponse> ListPayPlans(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPayPlansResponse>(() =>
            {
                var apiCallPath = "/codelist/payplans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListPayPlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOfferingTypesResponse> ListPositionOfferingTypes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionOfferingTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionofferingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListPositionOfferingTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOpeningStatusesResponse> ListPositionOpeningStatuses(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionOpeningStatusesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionopeningstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListPositionOpeningStatusesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionScheduleTypesResponse> ListPositionScheduleTypes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPositionScheduleTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/positionscheduletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListPositionScheduleTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPostalCodesResponse> ListPostalCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListPostalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/postalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListPostalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRaceCodesResponse> ListRaceCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRaceCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/racecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListRaceCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRefereeTypeCodesResponse> ListRefereeTypeCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRefereeTypeCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/refereetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListRefereeTypeCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRemunerationRateIntervalCodesResponse> ListRemunerationRateIntervalCodes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRemunerationRateIntervalCodesResponse>(() =>
            {
                var apiCallPath = "/codelist/remunerationrateintervalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListRemunerationRateIntervalCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRequiredStandardDocumentsResponse> ListRequiredStandardDocuments(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListRequiredStandardDocumentsResponse>(() =>
            {
                var apiCallPath = "/codelist/requiredstandarddocuments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListRequiredStandardDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSecurityClearancesResponse> ListSecurityClearances(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListSecurityClearancesResponse>(() =>
            {
                var apiCallPath = "/codelist/securityclearances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListSecurityClearancesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListServiceTypesResponse> ListServiceTypes(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListServiceTypesResponse>(() =>
            {
                var apiCallPath = "/codelist/servicetypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListServiceTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSpecialHiringsResponse> ListSpecialHirings(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListSpecialHiringsResponse>(() =>
            {
                var apiCallPath = "/codelist/specialhirings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListSpecialHiringsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListTravelPercentagesResponse> ListTravelPercentages(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListTravelPercentagesResponse>(() =>
            {
                var apiCallPath = "/codelist/travelpercentages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
                return new ApiConnectionAction<ListTravelPercentagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListWhoMayApplyResponse> ListWhoMayApply(Expression<Func<string>> lastmodified = null)
        {
            var __workflow_lastmodified = lastmodified == null ? null : WorkflowExpression.Compile(lastmodified);
            WorkflowExpression.Validate(__workflow_lastmodified, nameof(lastmodified), required: false);
            return new DeferredBodyAction<ListWhoMayApplyResponse>(() =>
            {
                var apiCallPath = "/codelist/whomayapply";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lastmodified != null)
                    callPayload.Queries["lastmodified"] = ExpressionConverter.Convert(__workflow_lastmodified);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsInput
    {
        Min,
        Full
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
