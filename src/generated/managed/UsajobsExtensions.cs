//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usajobs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsajobsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<SearchJobsResponse> SearchJobs([WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> positionTitle = null, [WorkflowExpression] Func<int> remunerationMinimumAmount = null, [WorkflowExpression] Func<int> remunerationMaximumAmount = null, [WorkflowExpression] Func<string> payGradeHigh = null, [WorkflowExpression] Func<string> payGradeLow = null, [WorkflowExpression] Func<string> jobCategoryCode = null, [WorkflowExpression] Func<bool> remoteIndicator = null, [WorkflowExpression] Func<string> locationName = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<bool> relocationIndicator = null, [WorkflowExpression] Func<string> travelPercentage = null, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<string> positionOfferingTypeCode = null, [WorkflowExpression] Func<string> positionScheduleTypeCode = null, [WorkflowExpression] Func<string> securityClearanceRequired = null, [WorkflowExpression] Func<positionSensitivityInput> positionSensitivity = null, [WorkflowExpression] Func<bool> supervisoryStatus = null, [WorkflowExpression] Func<int> datePosted = null, [WorkflowExpression] Func<string> jobGradeCode = null, [WorkflowExpression] Func<string> whoMayApply = null, [WorkflowExpression] Func<string> salaryBucket = null, [WorkflowExpression] Func<string> gradeBucket = null, [WorkflowExpression] Func<string> hiringPath = null, [WorkflowExpression] Func<string> missionCriticalTags = null, [WorkflowExpression] Func<string> postingChannel = null, [WorkflowExpression] Func<fieldsInput> fields = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> resultsPerPage = null)
        {
            SourceExpression.Validate(keyword, nameof(keyword), required: false);
            SourceExpression.Validate(positionTitle, nameof(positionTitle), required: false);
            SourceExpression.Validate(remunerationMinimumAmount, nameof(remunerationMinimumAmount), required: false);
            SourceExpression.Validate(remunerationMaximumAmount, nameof(remunerationMaximumAmount), required: false);
            SourceExpression.Validate(payGradeHigh, nameof(payGradeHigh), required: false);
            SourceExpression.Validate(payGradeLow, nameof(payGradeLow), required: false);
            SourceExpression.Validate(jobCategoryCode, nameof(jobCategoryCode), required: false);
            SourceExpression.Validate(remoteIndicator, nameof(remoteIndicator), required: false);
            SourceExpression.Validate(locationName, nameof(locationName), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            SourceExpression.Validate(relocationIndicator, nameof(relocationIndicator), required: false);
            SourceExpression.Validate(travelPercentage, nameof(travelPercentage), required: false);
            SourceExpression.Validate(organization, nameof(organization), required: false);
            SourceExpression.Validate(positionOfferingTypeCode, nameof(positionOfferingTypeCode), required: false);
            SourceExpression.Validate(positionScheduleTypeCode, nameof(positionScheduleTypeCode), required: false);
            SourceExpression.Validate(securityClearanceRequired, nameof(securityClearanceRequired), required: false);
            SourceExpression.Validate(positionSensitivity, nameof(positionSensitivity), required: false);
            SourceExpression.Validate(supervisoryStatus, nameof(supervisoryStatus), required: false);
            SourceExpression.Validate(datePosted, nameof(datePosted), required: false);
            SourceExpression.Validate(jobGradeCode, nameof(jobGradeCode), required: false);
            SourceExpression.Validate(whoMayApply, nameof(whoMayApply), required: false);
            SourceExpression.Validate(salaryBucket, nameof(salaryBucket), required: false);
            SourceExpression.Validate(gradeBucket, nameof(gradeBucket), required: false);
            SourceExpression.Validate(hiringPath, nameof(hiringPath), required: false);
            SourceExpression.Validate(missionCriticalTags, nameof(missionCriticalTags), required: false);
            SourceExpression.Validate(postingChannel, nameof(postingChannel), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sortField, nameof(sortField), required: false);
            SourceExpression.Validate(sortDirection, nameof(sortDirection), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (keyword != null)
                    callPayload.Queries["Keyword"] = SourceExpressionConverter.ConvertO(keyword);
                if (positionTitle != null)
                    callPayload.Queries["PositionTitle"] = SourceExpressionConverter.ConvertO(positionTitle);
                if (remunerationMinimumAmount != null)
                    callPayload.Queries["RemunerationMinimumAmount"] = SourceExpressionConverter.ConvertO(remunerationMinimumAmount);
                if (remunerationMaximumAmount != null)
                    callPayload.Queries["RemunerationMaximumAmount"] = SourceExpressionConverter.ConvertO(remunerationMaximumAmount);
                if (payGradeHigh != null)
                    callPayload.Queries["PayGradeHigh"] = SourceExpressionConverter.ConvertO(payGradeHigh);
                if (payGradeLow != null)
                    callPayload.Queries["PayGradeLow"] = SourceExpressionConverter.ConvertO(payGradeLow);
                if (jobCategoryCode != null)
                    callPayload.Queries["JobCategoryCode"] = SourceExpressionConverter.ConvertO(jobCategoryCode);
                if (remoteIndicator != null)
                    callPayload.Queries["RemoteIndicator"] = SourceExpressionConverter.ConvertO(remoteIndicator);
                if (locationName != null)
                    callPayload.Queries["LocationName"] = SourceExpressionConverter.ConvertO(locationName);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                if (relocationIndicator != null)
                    callPayload.Queries["RelocationIndicator"] = SourceExpressionConverter.ConvertO(relocationIndicator);
                if (travelPercentage != null)
                    callPayload.Queries["TravelPercentage"] = SourceExpressionConverter.ConvertO(travelPercentage);
                if (organization != null)
                    callPayload.Queries["Organization"] = SourceExpressionConverter.ConvertO(organization);
                if (positionOfferingTypeCode != null)
                    callPayload.Queries["PositionOfferingTypeCode"] = SourceExpressionConverter.ConvertO(positionOfferingTypeCode);
                if (positionScheduleTypeCode != null)
                    callPayload.Queries["PositionScheduleTypeCode"] = SourceExpressionConverter.ConvertO(positionScheduleTypeCode);
                if (securityClearanceRequired != null)
                    callPayload.Queries["SecurityClearanceRequired"] = SourceExpressionConverter.ConvertO(securityClearanceRequired);
                if (positionSensitivity != null)
                    callPayload.Queries["PositionSensitivity"] = SourceExpressionConverter.Convert(positionSensitivity);
                if (supervisoryStatus != null)
                    callPayload.Queries["SupervisoryStatus"] = SourceExpressionConverter.ConvertO(supervisoryStatus);
                if (datePosted != null)
                    callPayload.Queries["DatePosted"] = SourceExpressionConverter.ConvertO(datePosted);
                if (jobGradeCode != null)
                    callPayload.Queries["JobGradeCode"] = SourceExpressionConverter.ConvertO(jobGradeCode);
                if (whoMayApply != null)
                    callPayload.Queries["WhoMayApply"] = SourceExpressionConverter.ConvertO(whoMayApply);
                if (salaryBucket != null)
                    callPayload.Queries["SalaryBucket"] = SourceExpressionConverter.ConvertO(salaryBucket);
                if (gradeBucket != null)
                    callPayload.Queries["GradeBucket"] = SourceExpressionConverter.ConvertO(gradeBucket);
                if (hiringPath != null)
                    callPayload.Queries["HiringPath"] = SourceExpressionConverter.ConvertO(hiringPath);
                if (missionCriticalTags != null)
                    callPayload.Queries["MissionCriticalTags"] = SourceExpressionConverter.ConvertO(missionCriticalTags);
                if (postingChannel != null)
                    callPayload.Queries["PostingChannel"] = SourceExpressionConverter.ConvertO(postingChannel);
                if (fields != null)
                    callPayload.Queries["Fields"] = SourceExpressionConverter.Convert(fields);
                if (sortField != null)
                    callPayload.Queries["SortField"] = SourceExpressionConverter.Convert(sortField);
                if (sortDirection != null)
                    callPayload.Queries["SortDirection"] = SourceExpressionConverter.Convert(sortDirection);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (resultsPerPage != null)
                    callPayload.Queries["ResultsPerPage"] = SourceExpressionConverter.ConvertO(resultsPerPage);
                return callPayload;
            }

            return new ApiConnectionAction<SearchJobsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicHonorsResponse> ListAcademicHonors([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/academichonors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListAcademicHonorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAcademicLevelsResponse> ListAcademicLevels([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/academiclevels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListAcademicLevelsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListActionCodesResponse> ListActionCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/actioncodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListActionCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAgencySubelementsResponse> ListAgencySubelements([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/agencysubelements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListAgencySubelementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListAnnouncementClosingTypesResponse> ListAnnouncementClosingTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/announcementclosingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListAnnouncementClosingTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicantSuppliersResponse> ListApplicantSuppliers([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/applicantsuppliers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListApplicantSuppliersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListApplicationStatusesResponse> ListApplicationStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/applicationstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListApplicationStatusesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListCountriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCountrySubdivisionsResponse> ListCountrySubdivisions([WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(country, nameof(country), required: false);
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/countrysubdivisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListCountrySubdivisionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkGroupingsResponse> ListCyberWorkGroupings([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/cyberworkgroupings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListCyberWorkGroupingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListCyberWorkRolesResponse> ListCyberWorkRoles([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/cyberworkroles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListCyberWorkRolesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDegreeTypeCodesResponse> ListDegreeTypeCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/degreetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListDegreeTypeCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDisabilitiesResponse> ListDisabilities([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/disabilities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListDisabilitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentationsResponse> ListDocumentations([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/documentations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListDocumentFormatsResponse> ListDocumentFormats([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/documentformats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentFormatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListEthnicitiesResponse> ListEthnicities([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/ethnicities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListEthnicitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListFederalEmploymentStatusesResponse> ListFederalEmploymentStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/federalemploymentstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListFederalEmploymentStatusesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGeolocCodesResponse> ListGeolocCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/geoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListGeolocCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListGsaGeolocCodesResponse> ListGsaGeolocCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/gsageoloccodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListGsaGeolocCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListHiringPathsResponse> ListHiringPaths([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/hiringpaths";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListHiringPathsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListKeyStandardRequirementsResponse> ListKeyStandardRequirements([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/keystandardrequirements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListKeyStandardRequirementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageCodesResponse> ListLanguageCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/languagecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListLanguageCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLanguageProficienciesResponse> ListLanguageProficiencies([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/languageproficiencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListLanguageProficienciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListLocationExpansionsResponse> ListLocationExpansions([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/locationexpansions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListLocationExpansionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMilitaryStatusCodesResponse> ListMilitaryStatusCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/militarystatuscodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListMilitaryStatusCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListMissionCriticalCodesResponse> ListMissionCriticalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/missioncriticalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListMissionCriticalCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListOccupationalSeriesResponse> ListOccupationalSeries([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/occupationalseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListOccupationalSeriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPayPlansResponse> ListPayPlans([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/payplans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListPayPlansResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOfferingTypesResponse> ListPositionOfferingTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/positionofferingtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListPositionOfferingTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionOpeningStatusesResponse> ListPositionOpeningStatuses([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/positionopeningstatuses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListPositionOpeningStatusesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPositionScheduleTypesResponse> ListPositionScheduleTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/positionscheduletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListPositionScheduleTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListPostalCodesResponse> ListPostalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/postalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListPostalCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRaceCodesResponse> ListRaceCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/racecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListRaceCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRefereeTypeCodesResponse> ListRefereeTypeCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/refereetypecodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListRefereeTypeCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRemunerationRateIntervalCodesResponse> ListRemunerationRateIntervalCodes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/remunerationrateintervalcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListRemunerationRateIntervalCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListRequiredStandardDocumentsResponse> ListRequiredStandardDocuments([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/requiredstandarddocuments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListRequiredStandardDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSecurityClearancesResponse> ListSecurityClearances([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/securityclearances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListSecurityClearancesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListServiceTypesResponse> ListServiceTypes([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/servicetypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListServiceTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListSpecialHiringsResponse> ListSpecialHirings([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/specialhirings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListSpecialHiringsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListTravelPercentagesResponse> ListTravelPercentages([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/travelpercentages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListTravelPercentagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "usajobs")]
        public IBodyWorkflowAction<ListWhoMayApplyResponse> ListWhoMayApply([WorkflowExpression] Func<string> lastmodified = null)
        {
            SourceExpression.Validate(lastmodified, nameof(lastmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codelist/whomayapply";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastmodified != null)
                    callPayload.Queries["lastmodified"] = SourceExpressionConverter.ConvertO(lastmodified);
                return callPayload;
            }

            return new ApiConnectionAction<ListWhoMayApplyResponse>(BuildSourceInput);
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