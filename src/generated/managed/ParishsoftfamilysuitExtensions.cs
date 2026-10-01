//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parishsoftfamilysuit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParishsoftfamilysuitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<ConstituentDetailResponseDto[]> ConstituentSearch([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> offset, [WorkflowExpression] Func<string> lastModifiedDate = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["Offset"] = SourceExpressionConverter.ConvertO(offset);
                if (lastModifiedDate != null)
                    callPayload.Queries["LastModifiedDate"] = SourceExpressionConverter.ConvertO(lastModifiedDate);
                callPayload.Queries["SortBy"] = Convert.ToString("HeadLastName");
                if (sortBy != null)
                    callPayload.Queries["SortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                callPayload.Queries["SortDirection"] = Convert.ToString("asc");
                if (sortDirection != null)
                    callPayload.Queries["SortDirection"] = SourceExpressionConverter.ConvertO(sortDirection);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentDetailResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<ConstituentDetailResponseDto> ConstituentDetail([WorkflowExpression] Func<string> sDioceseId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/constituents/detail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sDioceseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentDetailResponseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto[]> FamilySearch([WorkflowExpression] Func<int> bodypageNumber, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyfamilyId = null, [WorkflowExpression] Func<int> bodydioceseId = null, [WorkflowExpression] Func<bool> bodymembershipStatus = null, [WorkflowExpression] Func<int> bodyfamilyGroupId = null, [WorkflowExpression] Func<int[]> bodyorganizations = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodyhasAFamilyEmailAddress = null, [WorkflowExpression] Func<bool> bodysendContributionEnvelopes = null, [WorkflowExpression] Func<string> bodyregistrationStart = null, [WorkflowExpression] Func<string> bodyregistrationEnd = null, [WorkflowExpression] Func<string> bodystreetAddress = null, [WorkflowExpression] Func<string> bodyaddressCity = null, [WorkflowExpression] Func<string> bodyaddressState = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodysendNoMail = null, [WorkflowExpression] Func<bool> bodydoNotPublish = null, [WorkflowExpression] Func<bool> bodyhasEmail = null, [WorkflowExpression] Func<string> bodyfamilyGroupName = null, [WorkflowExpression] Func<string> bodyenvelopeNumber = null, [WorkflowExpression] Func<string> bodyprimaryAddressPhoneNumber = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<int> bodyregisteredOrganizationId = null, [WorkflowExpression] Func<string> bodylastModified = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/families/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pageNumber"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
                body["pageSize"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                if (bodyfamilyId != null)
                {
                    body["familyID"] = SourceExpressionConverter.ConvertToken(bodyfamilyId);
                    bodypropCount++;
                }

                if (bodydioceseId != null)
                {
                    body["familyDUID"] = SourceExpressionConverter.ConvertToken(bodydioceseId);
                    bodypropCount++;
                }

                if (bodymembershipStatus != null)
                {
                    body["memberShipStatus"] = SourceExpressionConverter.ConvertToken(bodymembershipStatus);
                    bodypropCount++;
                }

                if (bodyfamilyGroupId != null)
                {
                    body["familyGroupID"] = SourceExpressionConverter.ConvertToken(bodyfamilyGroupId);
                    bodypropCount++;
                }

                if (bodyorganizations != null)
                {
                    body["organizationIDs"] = SourceExpressionConverter.ConvertToken(bodyorganizations);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyhasAFamilyEmailAddress != null)
                {
                    body["hasEmail"] = SourceExpressionConverter.ConvertToken(bodyhasAFamilyEmailAddress);
                    bodypropCount++;
                }

                if (bodysendContributionEnvelopes != null)
                {
                    body["envelopes"] = SourceExpressionConverter.ConvertToken(bodysendContributionEnvelopes);
                    bodypropCount++;
                }

                if (bodyregistrationStart != null)
                {
                    body["registrationDateFrom"] = SourceExpressionConverter.ConvertToken(bodyregistrationStart);
                    bodypropCount++;
                }

                if (bodyregistrationEnd != null)
                {
                    body["registrationDateTo"] = SourceExpressionConverter.ConvertToken(bodyregistrationEnd);
                    bodypropCount++;
                }

                if (bodystreetAddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodystreetAddress);
                    bodypropCount++;
                }

                if (bodyaddressCity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodyaddressCity);
                    bodypropCount++;
                }

                if (bodyaddressState != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodyaddressState);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postalCode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodysendNoMail != null)
                {
                    body["sendNoMail"] = SourceExpressionConverter.ConvertToken(bodysendNoMail);
                    bodypropCount++;
                }

                if (bodydoNotPublish != null)
                {
                    body["doNotPublish"] = SourceExpressionConverter.ConvertToken(bodydoNotPublish);
                    bodypropCount++;
                }

                if (bodyhasEmail != null)
                {
                    body["familiesWithEmail"] = SourceExpressionConverter.ConvertToken(bodyhasEmail);
                    bodypropCount++;
                }

                if (bodyfamilyGroupName != null)
                {
                    body["familyGroupName"] = SourceExpressionConverter.ConvertToken(bodyfamilyGroupName);
                    bodypropCount++;
                }

                if (bodyenvelopeNumber != null)
                {
                    body["envelopeNumber"] = SourceExpressionConverter.ConvertToken(bodyenvelopeNumber);
                    bodypropCount++;
                }

                if (bodyprimaryAddressPhoneNumber != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddressPhoneNumber);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["eMailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyregisteredOrganizationId != null)
                {
                    body["registeredOrganizationID"] = SourceExpressionConverter.ConvertToken(bodyregisteredOrganizationId);
                    bodypropCount++;
                }

                if (bodylastModified != null)
                {
                    body["dateModified"] = SourceExpressionConverter.ConvertToken(bodylastModified);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FamilySearchResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto> FamilyDetail([WorkflowExpression] Func<int> familyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/families/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(familyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FamilySearchResponseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMemberResponseDto[]> FamilyMemberList([WorkflowExpression] Func<int> familyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/families/{0}/member/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(familyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FamilyMemberResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMinistryResponseDto[]> FamilyMinistriesList([WorkflowExpression] Func<int> familyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/families/{0}/ministry/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(familyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FamilyMinistryResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyGroupResponseDto[]> FamilyGroupLookupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/families/group/lookup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FamilyGroupResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyWorkGroupResponseDto[]> FamilyWorkGroupList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/families/workgroup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<FamilyWorkGroupResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> FamilyUpdateContactInfo([WorkflowExpression] Func<int> familyId, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymailingName = null, [WorkflowExpression] Func<string> bodyinformalMailingName = null, [WorkflowExpression] Func<string> bodyformalSalutation = null, [WorkflowExpression] Func<string> bodyinformalSalutation = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyprimaryPhone = null, [WorkflowExpression] Func<string> bodyemergencyPhone = null, [WorkflowExpression] Func<string> bodyprimaryAddress = null, [WorkflowExpression] Func<string> bodyhomeStreetAddress = null, [WorkflowExpression] Func<string> bodyhomeStreetAddress2 = null, [WorkflowExpression] Func<string> bodyhomeAddressCity = null, [WorkflowExpression] Func<string> bodyhomeAddressState = null, [WorkflowExpression] Func<string> bodyhomeAddressCountry = null, [WorkflowExpression] Func<string> bodyhomeAddressPostalCode = null, [WorkflowExpression] Func<string> bodyhomeAddressPostalCodeExtension = null, [WorkflowExpression] Func<string> bodyhomeAddressPhone = null, [WorkflowExpression] Func<string> bodymailingStreetAddress = null, [WorkflowExpression] Func<string> bodymailingStreetAddress2 = null, [WorkflowExpression] Func<string> bodymailingAddressCity = null, [WorkflowExpression] Func<string> bodymailingAddressState = null, [WorkflowExpression] Func<string> bodymailingAddressCountry = null, [WorkflowExpression] Func<string> bodymailingAddressPostalCode = null, [WorkflowExpression] Func<string> bodymailingAddressPostalCodeExtension = null, [WorkflowExpression] Func<string> bodymailingAddressPhone = null, [WorkflowExpression] Func<string> bodyotherStreetAddress = null, [WorkflowExpression] Func<string> bodyotherStreetAddress2 = null, [WorkflowExpression] Func<string> bodyotherAddressCity = null, [WorkflowExpression] Func<string> bodyotherAddressState = null, [WorkflowExpression] Func<string> bodyotherAddressCountry = null, [WorkflowExpression] Func<string> bodyotherAddressPostalCode = null, [WorkflowExpression] Func<string> bodyotherAddressPostalCodeExtension = null, [WorkflowExpression] Func<string> bodyotherAddressPhone = null, [WorkflowExpression] Func<string> bodyotherAddressFromDate = null, [WorkflowExpression] Func<string> bodyotherAddressToDate = null, [WorkflowExpression] Func<string> bodysDiocesanId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/families/{0}/contact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(familyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodymailingName != null)
                {
                    body["mailingName"] = SourceExpressionConverter.ConvertToken(bodymailingName);
                    bodypropCount++;
                }

                if (bodyinformalMailingName != null)
                {
                    body["informalMailingName"] = SourceExpressionConverter.ConvertToken(bodyinformalMailingName);
                    bodypropCount++;
                }

                if (bodyformalSalutation != null)
                {
                    body["formalSalutation"] = SourceExpressionConverter.ConvertToken(bodyformalSalutation);
                    bodypropCount++;
                }

                if (bodyinformalSalutation != null)
                {
                    body["informalSalutation"] = SourceExpressionConverter.ConvertToken(bodyinformalSalutation);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["emailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyprimaryPhone != null)
                {
                    body["primaryPhone"] = SourceExpressionConverter.ConvertToken(bodyprimaryPhone);
                    bodypropCount++;
                }

                if (bodyemergencyPhone != null)
                {
                    body["emergencyPhone"] = SourceExpressionConverter.ConvertToken(bodyemergencyPhone);
                    bodypropCount++;
                }

                if (bodyprimaryAddress != null)
                {
                    body["primaryAddress"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddress);
                    bodypropCount++;
                }

                if (bodyhomeStreetAddress != null)
                {
                    body["homeAddressLine1"] = SourceExpressionConverter.ConvertToken(bodyhomeStreetAddress);
                    bodypropCount++;
                }

                if (bodyhomeStreetAddress2 != null)
                {
                    body["homeAddressLine2"] = SourceExpressionConverter.ConvertToken(bodyhomeStreetAddress2);
                    bodypropCount++;
                }

                if (bodyhomeAddressCity != null)
                {
                    body["homeCity"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressCity);
                    bodypropCount++;
                }

                if (bodyhomeAddressState != null)
                {
                    body["homeState"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressState);
                    bodypropCount++;
                }

                if (bodyhomeAddressCountry != null)
                {
                    body["homeCountry"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressCountry);
                    bodypropCount++;
                }

                if (bodyhomeAddressPostalCode != null)
                {
                    body["homePostalCode"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressPostalCode);
                    bodypropCount++;
                }

                if (bodyhomeAddressPostalCodeExtension != null)
                {
                    body["homePostalCodePlus4"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (bodyhomeAddressPhone != null)
                {
                    body["homeAddressPhone"] = SourceExpressionConverter.ConvertToken(bodyhomeAddressPhone);
                    bodypropCount++;
                }

                if (bodymailingStreetAddress != null)
                {
                    body["mailingAddressLine1"] = SourceExpressionConverter.ConvertToken(bodymailingStreetAddress);
                    bodypropCount++;
                }

                if (bodymailingStreetAddress2 != null)
                {
                    body["mailingAddressLine2"] = SourceExpressionConverter.ConvertToken(bodymailingStreetAddress2);
                    bodypropCount++;
                }

                if (bodymailingAddressCity != null)
                {
                    body["mailingCity"] = SourceExpressionConverter.ConvertToken(bodymailingAddressCity);
                    bodypropCount++;
                }

                if (bodymailingAddressState != null)
                {
                    body["mailingState"] = SourceExpressionConverter.ConvertToken(bodymailingAddressState);
                    bodypropCount++;
                }

                if (bodymailingAddressCountry != null)
                {
                    body["mailingCountry"] = SourceExpressionConverter.ConvertToken(bodymailingAddressCountry);
                    bodypropCount++;
                }

                if (bodymailingAddressPostalCode != null)
                {
                    body["mailingPostalCode"] = SourceExpressionConverter.ConvertToken(bodymailingAddressPostalCode);
                    bodypropCount++;
                }

                if (bodymailingAddressPostalCodeExtension != null)
                {
                    body["mailingPostalCodePlus4"] = SourceExpressionConverter.ConvertToken(bodymailingAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (bodymailingAddressPhone != null)
                {
                    body["mailingAddressPhone"] = SourceExpressionConverter.ConvertToken(bodymailingAddressPhone);
                    bodypropCount++;
                }

                if (bodyotherStreetAddress != null)
                {
                    body["otherAddressLine1"] = SourceExpressionConverter.ConvertToken(bodyotherStreetAddress);
                    bodypropCount++;
                }

                if (bodyotherStreetAddress2 != null)
                {
                    body["otherAddressLine2"] = SourceExpressionConverter.ConvertToken(bodyotherStreetAddress2);
                    bodypropCount++;
                }

                if (bodyotherAddressCity != null)
                {
                    body["otherCity"] = SourceExpressionConverter.ConvertToken(bodyotherAddressCity);
                    bodypropCount++;
                }

                if (bodyotherAddressState != null)
                {
                    body["otherState"] = SourceExpressionConverter.ConvertToken(bodyotherAddressState);
                    bodypropCount++;
                }

                if (bodyotherAddressCountry != null)
                {
                    body["otherCountry"] = SourceExpressionConverter.ConvertToken(bodyotherAddressCountry);
                    bodypropCount++;
                }

                if (bodyotherAddressPostalCode != null)
                {
                    body["otherPostalCode"] = SourceExpressionConverter.ConvertToken(bodyotherAddressPostalCode);
                    bodypropCount++;
                }

                if (bodyotherAddressPostalCodeExtension != null)
                {
                    body["otherPostalCodePlus4"] = SourceExpressionConverter.ConvertToken(bodyotherAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (bodyotherAddressPhone != null)
                {
                    body["otherAddressPhone"] = SourceExpressionConverter.ConvertToken(bodyotherAddressPhone);
                    bodypropCount++;
                }

                if (bodyotherAddressFromDate != null)
                {
                    body["otherAddressFromDate"] = SourceExpressionConverter.ConvertToken(bodyotherAddressFromDate);
                    bodypropCount++;
                }

                if (bodyotherAddressToDate != null)
                {
                    body["otherAddressToDate"] = SourceExpressionConverter.ConvertToken(bodyotherAddressToDate);
                    bodypropCount++;
                }

                if (bodysDiocesanId != null)
                {
                    body["sdiocesanId"] = SourceExpressionConverter.ConvertToken(bodysDiocesanId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> FamilyUpdateAutoFill([WorkflowExpression] Func<int> familyId, [WorkflowExpression] Func<int> bodyorganizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/families/{0}/autofill", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(familyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["organizationID"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyChangeListResponseDto[]> FamilyChangeList([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/families/change/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<FamilyChangeListResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto[]> MemberSearch([WorkflowExpression] Func<int> bodypageNumber, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<string> bodysearchText = null, [WorkflowExpression] Func<bool> bodyincludeDeletedMembers = null, [WorkflowExpression] Func<int[]> bodyorganizationIdS = null, [WorkflowExpression] Func<int> bodymemberAgeFrom = null, [WorkflowExpression] Func<int> bodymemberAgeTo = null, [WorkflowExpression] Func<string> bodylastModified = null, [WorkflowExpression] Func<int> bodyfamilyRegistrationStatus = null, [WorkflowExpression] Func<string> bodymemberStatusName = null, [WorkflowExpression] Func<int> bodysearchByContains = null, [WorkflowExpression] Func<bool> bodyincludeFamilyDioceseId = null, [WorkflowExpression] Func<bool> bodyincludeMemberDioceseId = null, [WorkflowExpression] Func<bool> bodyincludeFamilyLastName = null, [WorkflowExpression] Func<bool> bodyincludeFamilyAddress = null, [WorkflowExpression] Func<bool> bodyincludeFamilyAddressCity = null, [WorkflowExpression] Func<bool> bodyincludeFamilyAddressState = null, [WorkflowExpression] Func<bool> bodyincludeFamilyAddressPostalCode = null, [WorkflowExpression] Func<bool> bodyincludeFamilyAddressZipPlus = null, [WorkflowExpression] Func<bool> bodyincludeMemberName = null, [WorkflowExpression] Func<bool> bodyincludeMemberType = null, [WorkflowExpression] Func<bool> bodyincludeMemberGender = null, [WorkflowExpression] Func<bool> bodyincludeMemberAge = null, [WorkflowExpression] Func<bool> bodyincludeEnvelopeNumber = null, [WorkflowExpression] Func<bool> bodyincludeEmailAddress = null, [WorkflowExpression] Func<bool> bodyincludeHomePhone = null, [WorkflowExpression] Func<bool> bodyincludeMobilePhone = null, [WorkflowExpression] Func<bool> bodyincludeWorkPhone = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/members/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startRowIndex"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
                body["maximumRows"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                if (bodysearchText != null)
                {
                    body["fuzzy_SearchText"] = SourceExpressionConverter.ConvertToken(bodysearchText);
                    bodypropCount++;
                }

                if (bodyincludeDeletedMembers != null)
                {
                    body["showDeletedMembers"] = SourceExpressionConverter.ConvertToken(bodyincludeDeletedMembers);
                    bodypropCount++;
                }

                if (bodyorganizationIdS != null)
                {
                    body["organizationIDs"] = SourceExpressionConverter.ConvertToken(bodyorganizationIdS);
                    bodypropCount++;
                }

                if (bodymemberAgeFrom != null)
                {
                    body["filter_MemberAgeRange_From"] = SourceExpressionConverter.ConvertToken(bodymemberAgeFrom);
                    bodypropCount++;
                }

                if (bodymemberAgeTo != null)
                {
                    body["filter_MemberAgeRange_To"] = SourceExpressionConverter.ConvertToken(bodymemberAgeTo);
                    bodypropCount++;
                }

                if (bodylastModified != null)
                {
                    body["filter_DateModified"] = SourceExpressionConverter.ConvertToken(bodylastModified);
                    bodypropCount++;
                }

                if (bodyfamilyRegistrationStatus != null)
                {
                    body["filter_FamilyRegistrationStatus"] = SourceExpressionConverter.ConvertToken(bodyfamilyRegistrationStatus);
                    bodypropCount++;
                }

                if (bodymemberStatusName != null)
                {
                    body["filter_MemberStatus"] = SourceExpressionConverter.ConvertToken(bodymemberStatusName);
                    bodypropCount++;
                }

                if (bodysearchByContains != null)
                {
                    body["searchByContains"] = SourceExpressionConverter.ConvertToken(bodysearchByContains);
                    bodypropCount++;
                }

                if (bodyincludeFamilyDioceseId != null)
                {
                    body["fuzzy_FamilyDUID"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyDioceseId);
                    bodypropCount++;
                }

                if (bodyincludeMemberDioceseId != null)
                {
                    body["fuzzy_MemberDUID"] = SourceExpressionConverter.ConvertToken(bodyincludeMemberDioceseId);
                    bodypropCount++;
                }

                if (bodyincludeFamilyLastName != null)
                {
                    body["fuzzy_FamilyLastName"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyLastName);
                    bodypropCount++;
                }

                if (bodyincludeFamilyAddress != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryAddressFull"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyAddress);
                    bodypropCount++;
                }

                if (bodyincludeFamilyAddressCity != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryCity"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyAddressCity);
                    bodypropCount++;
                }

                if (bodyincludeFamilyAddressState != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryState"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyAddressState);
                    bodypropCount++;
                }

                if (bodyincludeFamilyAddressPostalCode != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryPostalCode"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyAddressPostalCode);
                    bodypropCount++;
                }

                if (bodyincludeFamilyAddressZipPlus != null)
                {
                    body["fuzzy_FamilyAddres_PrimaryZipPlus"] = SourceExpressionConverter.ConvertToken(bodyincludeFamilyAddressZipPlus);
                    bodypropCount++;
                }

                if (bodyincludeMemberName != null)
                {
                    body["fuzzy_Display_MemberName"] = SourceExpressionConverter.ConvertToken(bodyincludeMemberName);
                    bodypropCount++;
                }

                if (bodyincludeMemberType != null)
                {
                    body["fuzzy_MemberType"] = SourceExpressionConverter.ConvertToken(bodyincludeMemberType);
                    bodypropCount++;
                }

                if (bodyincludeMemberGender != null)
                {
                    body["fuzzy_Sex"] = SourceExpressionConverter.ConvertToken(bodyincludeMemberGender);
                    bodypropCount++;
                }

                if (bodyincludeMemberAge != null)
                {
                    body["fuzzy_Age"] = SourceExpressionConverter.ConvertToken(bodyincludeMemberAge);
                    bodypropCount++;
                }

                if (bodyincludeEnvelopeNumber != null)
                {
                    body["fuzzy_EnvelopeNumber"] = SourceExpressionConverter.ConvertToken(bodyincludeEnvelopeNumber);
                    bodypropCount++;
                }

                if (bodyincludeEmailAddress != null)
                {
                    body["fuzzy_EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyincludeEmailAddress);
                    bodypropCount++;
                }

                if (bodyincludeHomePhone != null)
                {
                    body["fuzzy_HomePhone"] = SourceExpressionConverter.ConvertToken(bodyincludeHomePhone);
                    bodypropCount++;
                }

                if (bodyincludeMobilePhone != null)
                {
                    body["fuzzy_MobilePhone"] = SourceExpressionConverter.ConvertToken(bodyincludeMobilePhone);
                    bodypropCount++;
                }

                if (bodyincludeWorkPhone != null)
                {
                    body["fuzzy_WorkPhone"] = SourceExpressionConverter.ConvertToken(bodyincludeWorkPhone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MemberSearchResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto> MemberDetail([WorkflowExpression] Func<int> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberSearchResponseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<SacramentDto[]> MemberSacramentList([WorkflowExpression] Func<int> memberId, [WorkflowExpression] Func<int> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/members/{0}/sacrament/{1}/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(memberId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(type, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SacramentDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberStatusListResponseDto[]> MemberStatusLookupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/members/memberstatus/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberStatusListResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[]> MemberTypeLookupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/members/membertype/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[]> MemberWorkGroupLookupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/members/workgroup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberContactListResponseDto[]> MemberContactList([WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodypageNumber, [WorkflowExpression] Func<string> bodymemberFirstName = null, [WorkflowExpression] Func<string> bodymemberLastName = null, [WorkflowExpression] Func<string> bodymemberEmailAddress = null, [WorkflowExpression] Func<string> bodymemberMobilePhone = null, [WorkflowExpression] Func<int[]> bodyorganizationIdS = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/members/contact/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["limit"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                bodypropCount++;
                body["offset"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                if (bodymemberFirstName != null)
                {
                    body["memberFirstName"] = SourceExpressionConverter.ConvertToken(bodymemberFirstName);
                    bodypropCount++;
                }

                if (bodymemberLastName != null)
                {
                    body["memberLastName"] = SourceExpressionConverter.ConvertToken(bodymemberLastName);
                    bodypropCount++;
                }

                if (bodymemberEmailAddress != null)
                {
                    body["emailAddress"] = SourceExpressionConverter.ConvertToken(bodymemberEmailAddress);
                    bodypropCount++;
                }

                if (bodymemberMobilePhone != null)
                {
                    body["cellPhone"] = SourceExpressionConverter.ConvertToken(bodymemberMobilePhone);
                    bodypropCount++;
                }

                if (bodyorganizationIdS != null)
                {
                    body["organizationIDs"] = SourceExpressionConverter.ConvertToken(bodyorganizationIdS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MemberContactListResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IWorkflowAction MemberUpdateContact([WorkflowExpression] Func<int> memberId, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodynickName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodymaidenName = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodydateOfDeath = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyhomePhone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyworkPhone = null, [WorkflowExpression] Func<string> bodypager = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodygender = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/members/{0}/contact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(memberId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodynickName != null)
                {
                    body["nickName"] = SourceExpressionConverter.ConvertToken(bodynickName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodymaidenName != null)
                {
                    body["maidenName"] = SourceExpressionConverter.ConvertToken(bodymaidenName);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["dateOfBirth"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodydateOfDeath != null)
                {
                    body["dateOfDeath"] = SourceExpressionConverter.ConvertToken(bodydateOfDeath);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["emailAddress"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyhomePhone != null)
                {
                    body["homePhone"] = SourceExpressionConverter.ConvertToken(bodyhomePhone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["cellPhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyworkPhone != null)
                {
                    body["workPhone"] = SourceExpressionConverter.ConvertToken(bodyworkPhone);
                    bodypropCount++;
                }

                if (bodypager != null)
                {
                    body["pager"] = SourceExpressionConverter.ConvertToken(bodypager);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FundListResponseDto[]> OfferingFundList([WorkflowExpression] Func<int> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/offering/{0}/funds", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundListResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<GiverListResponseDto[]> OfferingGiverList([WorkflowExpression] Func<int> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/offering/{0}/givers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiverListResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyContributionSummaryResponseDto[]> OfferingFamilyContributionSearch([WorkflowExpression] Func<int> organizationId, [WorkflowExpression] Func<int> bodypageNumber, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int[]> bodyfamilyIdS = null, [WorkflowExpression] Func<int[]> bodyfundIdS = null, [WorkflowExpression] Func<int> bodygroupId = null, [WorkflowExpression] Func<bool> bodyregisteredFamilies = null, [WorkflowExpression] Func<string> bodycontributionStartDate = null, [WorkflowExpression] Func<string> bodycontributionEndDate = null, [WorkflowExpression] Func<double> bodycontributionLowAmount = null, [WorkflowExpression] Func<double> bodycontributionHighAmount = null, [WorkflowExpression] Func<double> bodytotalContributionLowAmount = null, [WorkflowExpression] Func<double> bodytotalContributionHighAmount = null, [WorkflowExpression] Func<bool> bodyincludeDeleted = null, [WorkflowExpression] Func<bool> bodyincludeZeroContributions = null, [WorkflowExpression] Func<bool> bodyincludeNonGivers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/offering/{0}/contribution/summary/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startRowIndex"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
                bodypropCount++;
                body["maximumRows"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                if (bodyfamilyIdS != null)
                {
                    body["familyDUIDs"] = SourceExpressionConverter.ConvertToken(bodyfamilyIdS);
                    bodypropCount++;
                }

                if (bodyfundIdS != null)
                {
                    body["fundsDUIDs"] = SourceExpressionConverter.ConvertToken(bodyfundIdS);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["familyGroupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyregisteredFamilies != null)
                {
                    body["registeredFamilies"] = SourceExpressionConverter.ConvertToken(bodyregisteredFamilies);
                    bodypropCount++;
                }

                if (bodycontributionStartDate != null)
                {
                    body["postDate_Low"] = SourceExpressionConverter.ConvertToken(bodycontributionStartDate);
                    bodypropCount++;
                }

                if (bodycontributionEndDate != null)
                {
                    body["postDate_High"] = SourceExpressionConverter.ConvertToken(bodycontributionEndDate);
                    bodypropCount++;
                }

                if (bodycontributionLowAmount != null)
                {
                    body["amount_Low"] = SourceExpressionConverter.ConvertToken(bodycontributionLowAmount);
                    bodypropCount++;
                }

                if (bodycontributionHighAmount != null)
                {
                    body["amount_High"] = SourceExpressionConverter.ConvertToken(bodycontributionHighAmount);
                    bodypropCount++;
                }

                if (bodytotalContributionLowAmount != null)
                {
                    body["totalAmount_Low"] = SourceExpressionConverter.ConvertToken(bodytotalContributionLowAmount);
                    bodypropCount++;
                }

                if (bodytotalContributionHighAmount != null)
                {
                    body["totalAmount_High"] = SourceExpressionConverter.ConvertToken(bodytotalContributionHighAmount);
                    bodypropCount++;
                }

                if (bodyincludeDeleted != null)
                {
                    body["familyDeleted"] = SourceExpressionConverter.ConvertToken(bodyincludeDeleted);
                    bodypropCount++;
                }

                if (bodyincludeZeroContributions != null)
                {
                    body["includeZeroDollarContributions"] = SourceExpressionConverter.ConvertToken(bodyincludeZeroContributions);
                    bodypropCount++;
                }

                if (bodyincludeNonGivers != null)
                {
                    body["includeNonGivers"] = SourceExpressionConverter.ConvertToken(bodyincludeNonGivers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FamilyContributionSummaryResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto[]> OrganizationSearch([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string[]> bodyorganizationTypeList = null, [WorkflowExpression] Func<string> bodyvicariate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/organizations/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyorganizationTypeList != null)
                {
                    body["types"] = SourceExpressionConverter.ConvertToken(bodyorganizationTypeList);
                    bodypropCount++;
                }

                if (bodyvicariate != null)
                {
                    body["vicariate"] = SourceExpressionConverter.ConvertToken(bodyvicariate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationDetailResponseDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto> OrganizationDetail([WorkflowExpression] Func<int> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationDetailResponseDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> Test()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/test";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class ParishsoftfamilysuitTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentDetailResponseDto
    {
        [JsonProperty("parishID")]
        public int OrganizationId { get; set; }

        [JsonProperty("parishName")]
        public string OrganizationName { get; set; }

        [JsonProperty("familyGroup")]
        public string FamilyGroupName { get; set; }

        [JsonProperty("headTitle")]
        public string FamilyHeadTitle { get; set; }

        [JsonProperty("headFirstName")]
        public string FamilyHeadFirstName { get; set; }

        [JsonProperty("headMiddleName")]
        public string FamilyHeadMiddleName { get; set; }

        [JsonProperty("headLastName")]
        public string FamilyHeadLastName { get; set; }

        [JsonProperty("headSuffix")]
        public string FamilyHeadSuffix { get; set; }

        [JsonProperty("headDateofBirth")]
        public string FamilyHeadBirthday { get; set; }

        [JsonProperty("headDateofDeath")]
        public string FamilyHeadDateOfDeath { get; set; }

        [JsonProperty("spouseTitle")]
        public string FamilySpouseTitle { get; set; }

        [JsonProperty("spouseFirstName")]
        public string FamilySpouseFirstName { get; set; }

        [JsonProperty("spouseMiddleName")]
        public string FamilySpouseMiddleName { get; set; }

        [JsonProperty("spouseLastName")]
        public string FamilySpouseLastName { get; set; }

        [JsonProperty("spouseSuffix")]
        public string FamilySpouseSuffix { get; set; }

        [JsonProperty("spouseDateofBirth")]
        public string FamilySpouseBirthday { get; set; }

        [JsonProperty("spouseDateofDeath")]
        public string FamilySpouseDateOfDeath { get; set; }

        [JsonProperty("addressLine1")]
        public string FamilyStreetAddress { get; set; }

        [JsonProperty("addressLine2")]
        public string FamilyStreetAddress2 { get; set; }

        [JsonProperty("city")]
        public string FamilyAddressCity { get; set; }

        [JsonProperty("state")]
        public string FamilyAddressState { get; set; }

        [JsonProperty("zip")]
        public string FamilyAddressPostalCode { get; set; }

        [JsonProperty("phoneType1")]
        public string FamilyPrimaryPhoneType { get; set; }

        [JsonProperty("phoneNumber1")]
        public string FamilyPrimaryPhoneNumber { get; set; }

        [JsonProperty("phoneType3")]
        public string FamilyAlternatePhoneType { get; set; }

        [JsonProperty("phoneNumber3")]
        public string FamilyAlternatePhoneNumber { get; set; }
    }

    public class FamilySearchResponseDto
    {
        [JsonProperty("totalResults")]
        public int TotalMatchingRecords { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("eMailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("familyHomePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("envelopeNumber")]
        public int EnvelopeNumber { get; set; }

        [JsonProperty("diocesanID")]
        public int DiocesanId { get; set; }

        [JsonProperty("famGroupID")]
        public int GroupId { get; set; }

        [JsonProperty("mapCode")]
        public string MapCode { get; set; }

        [JsonProperty("sDiocesanID")]
        public string DiocesanStringId { get; set; }

        [JsonProperty("familyDUID")]
        public int DioceseId { get; set; }

        [JsonProperty("familyID")]
        public int FamilyId { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("primaryPhone")]
        public string PrimaryAddressPhoneNumber { get; set; }

        [JsonProperty("primaryAddressFull")]
        public string PrimaryFullAddress { get; set; }

        [JsonProperty("primaryAddress1")]
        public string PrimaryStreetAddress { get; set; }

        [JsonProperty("primaryAddress2")]
        public string PrimaryStreetAddress2 { get; set; }

        [JsonProperty("primaryAddress3")]
        public string PrimaryStreetAddress3 { get; set; }

        [JsonProperty("primaryCity")]
        public string PrimaryAddressCity { get; set; }

        [JsonProperty("primaryState")]
        public string PrimaryAddressState { get; set; }

        [JsonProperty("primaryPostalCode")]
        public string PrimaryPostalCode { get; set; }

        [JsonProperty("primaryZipPlus")]
        public string PrimaryZipPlus { get; set; }

        [JsonProperty("familyParticipationStatus")]
        public string ParticipationStatus { get; set; }

        [JsonProperty("hasSuspense")]
        public bool HasSuspense { get; set; }

        [JsonProperty("ownedMap")]
        public bool HasOwnedMap { get; set; }

        [JsonProperty("registeredOrganizationID")]
        public int RegisteredOrganizationId { get; set; }

        [JsonProperty("registeredOrganizationNameAndCity")]
        public string RegisteredOrganizationNameAndCity { get; set; }

        [JsonProperty("strength")]
        public int FamilyStrength { get; set; }

        [JsonProperty("hasMembers")]
        public int HasActiveMembers { get; set; }

        [JsonProperty("publish_Photo")]
        public bool PublishPhoto { get; set; }

        [JsonProperty("publish_Email")]
        public bool PublishEmail { get; set; }

        [JsonProperty("publish_Phone")]
        public bool PublishPhone { get; set; }

        [JsonProperty("publish_Address")]
        public bool PublishAddress { get; set; }

        [JsonProperty("sendNoMail")]
        public bool SendNoMail { get; set; }

        [JsonProperty("primaryPublishAddress")]
        public bool PublishPrimaryAddress { get; set; }

        [JsonProperty("primaryPublishEMail")]
        public bool PublishPrimaryEmail { get; set; }

        [JsonProperty("primaryPublishPhone")]
        public bool PublishPrimaryPhone { get; set; }

        [JsonProperty("dateModified")]
        public string LastModified { get; set; }

        [JsonProperty("rowNumber")]
        public int RowNumber { get; set; }
    }

    public class FamilyMemberResponseDto
    {
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("suspenseMemberID")]
        public int SuspenseMemberId { get; set; }

        [JsonProperty("memberDUID")]
        public int MemberDioceseId { get; set; }

        [JsonProperty("familyDUID")]
        public int FamilyDioceseId { get; set; }

        [JsonProperty("salutation")]
        public string MemberSalutation { get; set; }

        [JsonProperty("suffix")]
        public string MemberSuffix { get; set; }

        [JsonProperty("nickName")]
        public string MemberNickName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("birthdate")]
        public string Birthday { get; set; }

        [JsonProperty("birthPlaceID")]
        public int BirthPlaceId { get; set; }

        [JsonProperty("birthPlaceText")]
        public string BirthPlaceDescription { get; set; }

        [JsonProperty("sex")]
        public string MemberGender { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("cellPhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("school")]
        public string SchoolName { get; set; }

        [JsonProperty("gradYear")]
        public string GraduationYear { get; set; }

        [JsonProperty("educationID")]
        public int EducationId { get; set; }

        [JsonProperty("education")]
        public string EducationDescription { get; set; }

        [JsonProperty("careerType")]
        public string CareerType { get; set; }

        [JsonProperty("careerDesc")]
        public string CareerTypeDescription { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("ethnicID")]
        public int EthnicId { get; set; }

        [JsonProperty("ethnicOrigin")]
        public string EthnicOrigin { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("publish_Photo")]
        public bool PublishPhoto { get; set; }

        [JsonProperty("maritalStatusID")]
        public int MaritalStatusId { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("motherMaidenName")]
        public string MotherMaidenName { get; set; }

        [JsonProperty("ownerOrganizationID")]
        public int OwnerOrganizationId { get; set; }

        [JsonProperty("maidenName")]
        public string MaidenName { get; set; }

        [JsonProperty("memberStatus")]
        public string MemberStatus { get; set; }

        [JsonProperty("mapRecordClosed")]
        public bool MapClosed { get; set; }

        [JsonProperty("mappedOrganizationID")]
        public int MappedOrganizationId { get; set; }

        [JsonProperty("memberLastnameFirstName")]
        public string MemberLastNameFirstName { get; set; }

        [JsonProperty("memberCasualName")]
        public string CasualName { get; set; }

        [JsonProperty("memberFullName")]
        public string FullName { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationId { get; set; }

        [JsonProperty("memberTypeOrder")]
        public int MemberTypeOrder { get; set; }
    }

    public class FamilyMinistryResponseDto
    {
        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("rowNum")]
        public int RowNumber { get; set; }

        [JsonProperty("familyDUID")]
        public int FamilyDioceseId { get; set; }

        [JsonProperty("ministryTypeDUID")]
        public int MinistryTypeDioceseId { get; set; }

        [JsonProperty("ministryTypeID")]
        public int MinistryTypeId { get; set; }

        [JsonProperty("ministryGroupDUID")]
        public int MinistryGroupDioceseId { get; set; }

        [JsonProperty("ministryGroupID")]
        public int MinistryGroupId { get; set; }

        [JsonProperty("ministryRoleDUID")]
        public int MinistryRoleDioceseId { get; set; }

        [JsonProperty("ministryRoleID")]
        public int MinistryRoleId { get; set; }

        [JsonProperty("eventTypeDUID")]
        public int EventTypeDioceseId { get; set; }

        [JsonProperty("eventTypeID")]
        public int EventTypeId { get; set; }

        [JsonProperty("ministryDescription")]
        public string MinistryDescription { get; set; }

        [JsonProperty("ministryGroupDescription")]
        public string MinistryGroupDescription { get; set; }

        [JsonProperty("ministryRoleDescription")]
        public string MinistryRoleDescription { get; set; }

        [JsonProperty("eventTypeDescription")]
        public string EventTypeDescription { get; set; }

        [JsonProperty("preferenceType")]
        public string PreferenceType { get; set; }
    }

    public class FamilyGroupResponseDto
    {
        [JsonProperty("famGroupID")]
        public int FamilyGroupId { get; set; }

        [JsonProperty("famGroup")]
        public string FamilyGroupName { get; set; }
    }

    public class FamilyWorkGroupResponseDto
    {
        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("rowNum")]
        public int RowNumber { get; set; }

        [JsonProperty("workgroupID")]
        public int WorkGroupId { get; set; }

        [JsonProperty("workgroupName")]
        public string WorkGroupName { get; set; }

        [JsonProperty("workgroupDescription")]
        public string WorkGroupDescription { get; set; }

        [JsonProperty("workgroupDate")]
        public string WorkGroupDate { get; set; }

        [JsonProperty("isDiocesanWorkgroup")]
        public bool IsDiocesanWorkGroup { get; set; }

        [JsonProperty("ownerOrganizationID")]
        public int OwnerOrganizationId { get; set; }

        [JsonProperty("sourceOrganizationID")]
        public int SourceOrganizationId { get; set; }

        [JsonProperty("workgroupDUID")]
        public int WorkGroupDioceseId { get; set; }
    }

    public class FamilyChangeListResponseDto
    {
        [JsonProperty("logDate")]
        public string LogDate { get; set; }

        [JsonProperty("family_DUID")]
        public int FamilyDioceseId { get; set; }

        [JsonProperty("famGroup")]
        public string FamilyGroup { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("tag_name")]
        public string FirstName { get; set; }

        [JsonProperty("currentAddress")]
        public string CurrentStreetAddress { get; set; }

        [JsonProperty("currentAddress2")]
        public string CurrentStreetAddress2 { get; set; }

        [JsonProperty("currentCity")]
        public string CurrentAddressCity { get; set; }

        [JsonProperty("currentState")]
        public string CurrentAddressState { get; set; }

        [JsonProperty("currentPostalCode")]
        public string CurrentAddressPostalCode { get; set; }

        [JsonProperty("currentPhone")]
        public string CurrentPhone { get; set; }

        [JsonProperty("currentEmail")]
        public string CurrentEmailAddress { get; set; }

        [JsonProperty("previousAddress")]
        public string PreviousStreetAddress { get; set; }

        [JsonProperty("previousAddress2")]
        public string PreviousStreetAddress2 { get; set; }

        [JsonProperty("previousCity")]
        public string PreviousAddressCity { get; set; }

        [JsonProperty("previousState")]
        public string PreviousAddressState { get; set; }

        [JsonProperty("previousPostalCode")]
        public string PreviousAddressPostalCode { get; set; }

        [JsonProperty("previousPhone")]
        public string PreviousPhoneNumber { get; set; }

        [JsonProperty("previousEmailAddress")]
        public string PreviousEmailAddress { get; set; }

        [JsonProperty("currentParishID")]
        public int CurrentOrganizationId { get; set; }

        [JsonProperty("currentRegisteredParish")]
        public string CurrentRegisteredOrganizationId { get; set; }

        [JsonProperty("address1_Changed")]
        public string Address1Changed { get; set; }

        [JsonProperty("address2_Changed")]
        public string Address2Changed { get; set; }

        [JsonProperty("city_Changed")]
        public string AddressCityChanged { get; set; }

        [JsonProperty("state_Changed")]
        public string AddressStateChanged { get; set; }

        [JsonProperty("postalCode_Changed")]
        public string AddressPostalCodeChanged { get; set; }

        [JsonProperty("homePhone_Changed")]
        public string PrimaryPhoneChanged { get; set; }

        [JsonProperty("email_Changed")]
        public string EmailAddressChanged { get; set; }
    }

    public class MemberSearchResponseDto
    {
        [JsonProperty("rowNum")]
        public int RowNumber { get; set; }

        [JsonProperty("auxID")]
        public string AuxId { get; set; }

        [JsonProperty("registeredOrganizationID")]
        public int OrganizationId { get; set; }

        [JsonProperty("memberDUID")]
        public int MemberId { get; set; }

        [JsonProperty("ownerOrganizationID")]
        public int OwnerOrganizationId { get; set; }

        [JsonProperty("familyDUID")]
        public int FamilyId { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("display_MemberName")]
        public string DisplayName { get; set; }

        [JsonProperty("display_MemberFullName")]
        public string MemberDisplayFullName { get; set; }

        [JsonProperty("display_FullName")]
        public string DisplayFullName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("familyLastName")]
        public string FamilyLastName { get; set; }

        [JsonProperty("birthdate")]
        public string Birthday { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("family_HomePhone")]
        public string FamilyHomePhone { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("maritalStatusID")]
        public int MaritalStatusId { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("sex")]
        public string Gender { get; set; }

        [JsonProperty("memberStatus")]
        public string MemberStatus { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("careerType")]
        public string CareerType { get; set; }

        [JsonProperty("envelopes")]
        public int HasEnvelopes { get; set; }

        [JsonProperty("envelopeNumber")]
        public int EnvelopeNumber { get; set; }

        [JsonProperty("gradYear")]
        public int GraduationYear { get; set; }

        [JsonProperty("school")]
        public string SchoolName { get; set; }

        [JsonProperty("education")]
        public string Education { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("ethnicOrigin")]
        public string EthnicOrigin { get; set; }

        [JsonProperty("memberDeleted")]
        public int MemberDeleted { get; set; }

        [JsonProperty("maidenName")]
        public string MaidenName { get; set; }

        [JsonProperty("family_RegistrationStatus")]
        public bool FamilyRegistrationStatus { get; set; }

        [JsonProperty("familyDeleted")]
        public int FamilyDeleted { get; set; }

        [JsonProperty("family_SendNoMail")]
        public bool SendNoMail { get; set; }

        [JsonProperty("family_PublishAddress")]
        public bool PublishAddress { get; set; }

        [JsonProperty("family_PublishPhoto")]
        public bool PublishPhoto { get; set; }

        [JsonProperty("family_PublishEMail")]
        public bool PublishEmail { get; set; }

        [JsonProperty("family_PublishPhone")]
        public bool PublishPhone { get; set; }

        [JsonProperty("family_ParticipationStatus")]
        public string ParticipationStatus { get; set; }

        [JsonProperty("familyAddres_PrimaryAddressFull")]
        public string FamilyFullAddress { get; set; }

        [JsonProperty("familyAddres_PrimaryCity")]
        public string FamilyAddressCity { get; set; }

        [JsonProperty("familyAddres_PrimaryState")]
        public string FamilyAddressState { get; set; }

        [JsonProperty("familyAddres_PrimaryPostalCode")]
        public string FamilyAddressPostalCode { get; set; }

        [JsonProperty("familyAddres_PrimaryZipPlus")]
        public string FamilyAddressZipPlus { get; set; }

        [JsonProperty("familyAddres_PrimaryFullPostalCode")]
        public string FamilyAddressFullPostalCode { get; set; }

        [JsonProperty("registeredOrganizationNameAndCity")]
        public string OrganizationName { get; set; }

        [JsonProperty("birthdate_Year")]
        public int BirthdayYear { get; set; }

        [JsonProperty("birthdate_Month")]
        public int BirthdayMonth { get; set; }

        [JsonProperty("birthdate_Day")]
        public int BirthdayDay { get; set; }

        [JsonProperty("dateModified")]
        public string LastModified { get; set; }

        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }
    }

    public class SacramentDto
    {
        [JsonProperty("memberDUID")]
        public int MemberId { get; set; }

        [JsonProperty("memberTitle")]
        public string MemberTitle { get; set; }

        [JsonProperty("memberFirstName")]
        public string MemberFirstName { get; set; }

        [JsonProperty("memberMiddleName")]
        public string MemberMiddleName { get; set; }

        [JsonProperty("memberGender")]
        public string MemberGender { get; set; }

        [JsonProperty("memberLastName")]
        public string MemberLastName { get; set; }

        [JsonProperty("memberSuffix")]
        public string MemberSuffix { get; set; }

        [JsonProperty("sacBaptismID")]
        public int SacramentBaptismId { get; set; }

        [JsonProperty("memberGUID")]
        public string MemberUniqueIdentifier { get; set; }

        [JsonProperty("isComplete")]
        public bool SacramentIsComplete { get; set; }

        [JsonProperty("dateCompleted")]
        public string SacramentCompletedDate { get; set; }

        [JsonProperty("parishID")]
        public int SacramentOrganizationId { get; set; }

        [JsonProperty("parishText")]
        public string SacramentOrganizationName { get; set; }

        [JsonProperty("celebrantDUID")]
        public int CelebrantId { get; set; }

        [JsonProperty("celebrantText")]
        public string CelebrantName { get; set; }

        [JsonProperty("sponsor1DUID")]
        public int SponsorId { get; set; }

        [JsonProperty("sponsor1Text")]
        public string SponsorName { get; set; }

        [JsonProperty("sponsor2DUID")]
        public int Sponsor2Id { get; set; }

        [JsonProperty("sponsor2Text")]
        public string Sponsor2Name { get; set; }

        [JsonProperty("witness1DUID")]
        public int WitnessId { get; set; }

        [JsonProperty("witness1Text")]
        public string WitnessName { get; set; }

        [JsonProperty("witness2DUID")]
        public int Witness2Id { get; set; }

        [JsonProperty("witness2Text")]
        public string Witness2Name { get; set; }

        [JsonProperty("baptismalName")]
        public string BaptismalName { get; set; }

        [JsonProperty("isCatholic")]
        public bool IsCatholic { get; set; }

        [JsonProperty("faithOfBaptismText")]
        public string FaithOfBaptism { get; set; }

        [JsonProperty("prepYear")]
        public string PreparationYear { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("registryVolume")]
        public string RegistryVolume { get; set; }

        [JsonProperty("registryPage")]
        public string RegistryPage { get; set; }

        [JsonProperty("registryNumber")]
        public string RegistryNumber { get; set; }

        [JsonProperty("ownerOrganizationID")]
        public int OwnerOrganization { get; set; }

        [JsonProperty("sourceOrganizationID")]
        public int SourceOrganization { get; set; }

        [JsonProperty("dioUniqueID")]
        public int SacramentId { get; set; }

        [JsonProperty("sacMemberTitle")]
        public string SacramentMemberTitle { get; set; }

        [JsonProperty("sacMemberFirstName")]
        public string SacramentFirstName { get; set; }

        [JsonProperty("sacMemberMiddleName")]
        public string SacramentMemberMiddleName { get; set; }

        [JsonProperty("sacMemberLastName")]
        public string SacramentMemberLastName { get; set; }

        [JsonProperty("sacMemberMaidenName")]
        public string SacramentMemberMaidenName { get; set; }

        [JsonProperty("sacMemberSuffix")]
        public string SacramentMemberSuffix { get; set; }

        [JsonProperty("executorUserID")]
        public int ExecutorUserId { get; set; }

        [JsonProperty("rn")]
        public int RecordNumber { get; set; }
    }

    public class MemberStatusListResponseDto
    {
        [JsonProperty("memberStatusID")]
        public int MemberStatusId { get; set; }

        [JsonProperty("memberStatusName")]
        public string MemberStatusName { get; set; }
    }

    public class MemberContactListResponseDto
    {
        [JsonProperty("memberDUID")]
        public int MemberId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("maidenName")]
        public string MaidenName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string Birthday { get; set; }

        [JsonProperty("dateOfDeath")]
        public string DateOfDeath { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("cellPhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("ownerOrganizationID")]
        public int OrganizationId { get; set; }
    }

    public class FundListResponseDto
    {
        [JsonProperty("name")]
        public string FundName { get; set; }

        [JsonProperty("fundId")]
        public int FundId { get; set; }

        [JsonProperty("accountNumber")]
        public string FundAccountNumber { get; set; }

        [JsonProperty("externalId")]
        public string FundExternalId { get; set; }

        [JsonProperty("diocesanId")]
        public string FundDiocesanId { get; set; }

        [JsonProperty("revenueAccountId")]
        public int RevenueAccountId { get; set; }

        [JsonProperty("revenueAccountDescription")]
        public string RevenueAccountDescription { get; set; }

        [JsonProperty("revenueAccountShortcut")]
        public string RevenueAccountShortcut { get; set; }

        [JsonProperty("revenueAccountCode")]
        public string RevenueAccountCode { get; set; }

        [JsonProperty("fundProjectId")]
        public int FundProjectId { get; set; }

        [JsonProperty("fundProjectDescription")]
        public string FundProjectDescription { get; set; }

        [JsonProperty("active")]
        public bool IsFundActive { get; set; }

        [JsonProperty("fundStartDate")]
        public string FundStartDate { get; set; }

        [JsonProperty("fundEndDate")]
        public string FundEndDate { get; set; }

        [JsonProperty("requiresPledges")]
        public bool FundRequirePledges { get; set; }

        [JsonProperty("acceptSustainingGifts")]
        public bool FundAcceptSustainingGifts { get; set; }

        [JsonProperty("includesTaxDeductibleGifts")]
        public bool FundIncludeTaxDeductibleGifts { get; set; }
    }

    public class GiverListResponseDto
    {
        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("rowNum")]
        public int RowNumber { get; set; }

        [JsonProperty("family_DUID")]
        public int FamilyDioceseId { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("familyEMailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("primaryAddress")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("envelopeID")]
        public int EnvelopeId { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationId { get; set; }

        [JsonProperty("family_TotalContributions")]
        public int TotalContributionAmount { get; set; }

        [JsonProperty("numberOfFunds")]
        public int NumberOfFunds { get; set; }

        [JsonProperty("fundsDescription")]
        public string FundDescription { get; set; }
    }

    public class FamilyContributionSummaryResponseDto
    {
        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("rowNum")]
        public int RowNumber { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationId { get; set; }

        [JsonProperty("family_DUID")]
        public int FamilyDioceseId { get; set; }

        [JsonProperty("famGroupID")]
        public int FamilyGroupId { get; set; }

        [JsonProperty("registrationStatus")]
        public bool RegistrationStatus { get; set; }

        [JsonProperty("envelopeID")]
        public int EnvelopeId { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("tag_name")]
        public string FirstName { get; set; }

        [JsonProperty("address_1")]
        public string StreetAddress { get; set; }

        [JsonProperty("address_2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("region")]
        public string AddressRegion { get; set; }

        [JsonProperty("postalCode")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("sendNoMail")]
        public bool SendNoMail { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("membership_Date")]
        public string MembershipDate { get; set; }

        [JsonProperty("recordDeleted")]
        public bool RecordDeleted { get; set; }

        [JsonProperty("numberOfContributions")]
        public int ContributionCount { get; set; }

        [JsonProperty("totalContributions")]
        public int TotalContributionAmount { get; set; }

        [JsonProperty("averageContribution")]
        public int AverageContributionAmount { get; set; }
    }

    public class OrganizationDetailResponseDto
    {
        [JsonProperty("organizationID")]
        public int OrganizationId { get; set; }

        [JsonProperty("organizationTypeID")]
        public int TypeId { get; set; }

        [JsonProperty("organizationType")]
        public string TypeName { get; set; }

        [JsonProperty("organizationName")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zip")]
        public string PostalCode { get; set; }

        [JsonProperty("childOf")]
        public int ParentOrganizationId { get; set; }

        [JsonProperty("childOfName")]
        public string ParentOrganizationName { get; set; }

        [JsonProperty("entityTypeID")]
        public int EntityTypeId { get; set; }

        [JsonProperty("address_1")]
        public string StreetAddress { get; set; }

        [JsonProperty("address_2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("zipExt")]
        public string PostalCodeExtension { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("organizationWebSite")]
        public string WebSite { get; set; }

        [JsonProperty("organizationEmail")]
        public string EmailAddress { get; set; }

        [JsonProperty("vicariateId")]
        public int VicariateId { get; set; }

        [JsonProperty("regionID")]
        public int RegionId { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("vicariate")]
        public string VicariateName { get; set; }

        [JsonProperty("schoolID")]
        public int SchoolId { get; set; }

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("localOrgID")]
        public string LocalId { get; set; }

        [JsonProperty("organizationReportName")]
        public string ReportName { get; set; }

        [JsonProperty("addressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("religiousEducation_GradeChangeOver")]
        public string GradeChangeOver { get; set; }

        [JsonProperty("enrollmentCutOff")]
        public string EnrollmentCutOff { get; set; }

        [JsonProperty("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastModified { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Parishsoftfamilysuit;

    public partial class WorkflowManagedActions
    {
        public ParishsoftfamilysuitActions Parishsoftfamilysuit(string connectionId) => new ParishsoftfamilysuitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ParishsoftfamilysuitTriggers Parishsoftfamilysuit(string connectionId) => new ParishsoftfamilysuitTriggers(connectionId);
    }
}