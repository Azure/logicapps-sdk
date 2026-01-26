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
        public IBodyWorkflowAction<ConstituentDetailResponseDto[]> ConstituentSearch(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> lastModifiedDate = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortDirection = null)
        {
            var apiCallPath = "/api/v2/constituents/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["Offset"] = ExpressionConverter.Convert(offset);
            if (lastModifiedDate != null)
                callPayload.Queries["LastModifiedDate"] = ExpressionConverter.Convert(lastModifiedDate);
            callPayload.Queries["SortBy"] = Convert.ToString("HeadLastName");
            if (sortBy != null)
                callPayload.Queries["SortBy"] = ExpressionConverter.Convert(sortBy);
            callPayload.Queries["SortDirection"] = Convert.ToString("asc");
            if (sortDirection != null)
                callPayload.Queries["SortDirection"] = ExpressionConverter.Convert(sortDirection);
            return new ApiConnectionAction<ConstituentDetailResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<ConstituentDetailResponseDto> ConstituentDetail(Expression<Func<string>> sDioceseId)
        {
            var apiCallPath = String.Format("/api/v2/constituents/detail/{0}", ExpressionConverter.ConvertWithUrlEncoding(sDioceseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentDetailResponseDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto[]> FamilySearch(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyfamilyId = null, Expression<Func<int>> bodydioceseId = null, Expression<Func<bool>> bodymembershipStatus = null, Expression<Func<int>> bodyfamilyGroupId = null, Expression<Func<int[]>> bodyorganizations = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bool>> bodyhasAFamilyEmailAddress = null, Expression<Func<bool>> bodysendContributionEnvelopes = null, Expression<Func<string>> bodyregistrationStart = null, Expression<Func<string>> bodyregistrationEnd = null, Expression<Func<string>> bodystreetAddress = null, Expression<Func<string>> bodyaddressCity = null, Expression<Func<string>> bodyaddressState = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodysendNoMail = null, Expression<Func<bool>> bodydoNotPublish = null, Expression<Func<bool>> bodyhasEmail = null, Expression<Func<string>> bodyfamilyGroupName = null, Expression<Func<string>> bodyenvelopeNumber = null, Expression<Func<string>> bodyprimaryAddressPhoneNumber = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<int>> bodyregisteredOrganizationId = null, Expression<Func<string>> bodylastModified = null)
        {
            var apiCallPath = "/api/v2/families/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
            bodypropCount++;
            body["pageSize"] = ExpressionConverter.ConvertO(bodypageSize);
            if (bodyfamilyId != null)
            {
                body["familyID"] = ExpressionConverter.ConvertO(bodyfamilyId);
                bodypropCount++;
            }

            if (bodydioceseId != null)
            {
                body["familyDUID"] = ExpressionConverter.ConvertO(bodydioceseId);
                bodypropCount++;
            }

            if (bodymembershipStatus != null)
            {
                body["memberShipStatus"] = ExpressionConverter.ConvertO(bodymembershipStatus);
                bodypropCount++;
            }

            if (bodyfamilyGroupId != null)
            {
                body["familyGroupID"] = ExpressionConverter.ConvertO(bodyfamilyGroupId);
                bodypropCount++;
            }

            if (bodyorganizations != null)
            {
                body["organizationIDs"] = ExpressionConverter.ConvertO(bodyorganizations);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodyhasAFamilyEmailAddress != null)
            {
                body["hasEmail"] = ExpressionConverter.ConvertO(bodyhasAFamilyEmailAddress);
                bodypropCount++;
            }

            if (bodysendContributionEnvelopes != null)
            {
                body["envelopes"] = ExpressionConverter.ConvertO(bodysendContributionEnvelopes);
                bodypropCount++;
            }

            if (bodyregistrationStart != null)
            {
                body["registrationDateFrom"] = ExpressionConverter.ConvertO(bodyregistrationStart);
                bodypropCount++;
            }

            if (bodyregistrationEnd != null)
            {
                body["registrationDateTo"] = ExpressionConverter.ConvertO(bodyregistrationEnd);
                bodypropCount++;
            }

            if (bodystreetAddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodystreetAddress);
                bodypropCount++;
            }

            if (bodyaddressCity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodyaddressCity);
                bodypropCount++;
            }

            if (bodyaddressState != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodyaddressState);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postalCode"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodysendNoMail != null)
            {
                body["sendNoMail"] = ExpressionConverter.ConvertO(bodysendNoMail);
                bodypropCount++;
            }

            if (bodydoNotPublish != null)
            {
                body["doNotPublish"] = ExpressionConverter.ConvertO(bodydoNotPublish);
                bodypropCount++;
            }

            if (bodyhasEmail != null)
            {
                body["familiesWithEmail"] = ExpressionConverter.ConvertO(bodyhasEmail);
                bodypropCount++;
            }

            if (bodyfamilyGroupName != null)
            {
                body["familyGroupName"] = ExpressionConverter.ConvertO(bodyfamilyGroupName);
                bodypropCount++;
            }

            if (bodyenvelopeNumber != null)
            {
                body["envelopeNumber"] = ExpressionConverter.ConvertO(bodyenvelopeNumber);
                bodypropCount++;
            }

            if (bodyprimaryAddressPhoneNumber != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyprimaryAddressPhoneNumber);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["eMailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyregisteredOrganizationId != null)
            {
                body["registeredOrganizationID"] = ExpressionConverter.ConvertO(bodyregisteredOrganizationId);
                bodypropCount++;
            }

            if (bodylastModified != null)
            {
                body["dateModified"] = ExpressionConverter.ConvertO(bodylastModified);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FamilySearchResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto> FamilyDetail(Expression<Func<int>> familyId)
        {
            var apiCallPath = String.Format("/api/v2/families/{0}", ExpressionConverter.ConvertWithUrlEncoding(familyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FamilySearchResponseDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMemberResponseDto[]> FamilyMemberList(Expression<Func<int>> familyId)
        {
            var apiCallPath = String.Format("/api/v2/families/{0}/member/list", ExpressionConverter.ConvertWithUrlEncoding(familyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FamilyMemberResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMinistryResponseDto[]> FamilyMinistriesList(Expression<Func<int>> familyId)
        {
            var apiCallPath = String.Format("/api/v2/families/{0}/ministry/list", ExpressionConverter.ConvertWithUrlEncoding(familyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FamilyMinistryResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyGroupResponseDto[]> FamilyGroupLookupList()
        {
            var apiCallPath = "/api/v2/families/group/lookup/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FamilyGroupResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyWorkGroupResponseDto[]> FamilyWorkGroupList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/families/workgroup/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<FamilyWorkGroupResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> FamilyUpdateContactInfo(Expression<Func<int>> familyId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymailingName = null, Expression<Func<string>> bodyinformalMailingName = null, Expression<Func<string>> bodyformalSalutation = null, Expression<Func<string>> bodyinformalSalutation = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyprimaryPhone = null, Expression<Func<string>> bodyemergencyPhone = null, Expression<Func<string>> bodyprimaryAddress = null, Expression<Func<string>> bodyhomeStreetAddress = null, Expression<Func<string>> bodyhomeStreetAddress2 = null, Expression<Func<string>> bodyhomeAddressCity = null, Expression<Func<string>> bodyhomeAddressState = null, Expression<Func<string>> bodyhomeAddressCountry = null, Expression<Func<string>> bodyhomeAddressPostalCode = null, Expression<Func<string>> bodyhomeAddressPostalCodeExtension = null, Expression<Func<string>> bodyhomeAddressPhone = null, Expression<Func<string>> bodymailingStreetAddress = null, Expression<Func<string>> bodymailingStreetAddress2 = null, Expression<Func<string>> bodymailingAddressCity = null, Expression<Func<string>> bodymailingAddressState = null, Expression<Func<string>> bodymailingAddressCountry = null, Expression<Func<string>> bodymailingAddressPostalCode = null, Expression<Func<string>> bodymailingAddressPostalCodeExtension = null, Expression<Func<string>> bodymailingAddressPhone = null, Expression<Func<string>> bodyotherStreetAddress = null, Expression<Func<string>> bodyotherStreetAddress2 = null, Expression<Func<string>> bodyotherAddressCity = null, Expression<Func<string>> bodyotherAddressState = null, Expression<Func<string>> bodyotherAddressCountry = null, Expression<Func<string>> bodyotherAddressPostalCode = null, Expression<Func<string>> bodyotherAddressPostalCodeExtension = null, Expression<Func<string>> bodyotherAddressPhone = null, Expression<Func<string>> bodyotherAddressFromDate = null, Expression<Func<string>> bodyotherAddressToDate = null, Expression<Func<string>> bodysDiocesanId = null)
        {
            var apiCallPath = String.Format("/api/v2/families/{0}/contact", ExpressionConverter.ConvertWithUrlEncoding(familyId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodymailingName != null)
            {
                body["mailingName"] = ExpressionConverter.ConvertO(bodymailingName);
                bodypropCount++;
            }

            if (bodyinformalMailingName != null)
            {
                body["informalMailingName"] = ExpressionConverter.ConvertO(bodyinformalMailingName);
                bodypropCount++;
            }

            if (bodyformalSalutation != null)
            {
                body["formalSalutation"] = ExpressionConverter.ConvertO(bodyformalSalutation);
                bodypropCount++;
            }

            if (bodyinformalSalutation != null)
            {
                body["informalSalutation"] = ExpressionConverter.ConvertO(bodyinformalSalutation);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["emailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyprimaryPhone != null)
            {
                body["primaryPhone"] = ExpressionConverter.ConvertO(bodyprimaryPhone);
                bodypropCount++;
            }

            if (bodyemergencyPhone != null)
            {
                body["emergencyPhone"] = ExpressionConverter.ConvertO(bodyemergencyPhone);
                bodypropCount++;
            }

            if (bodyprimaryAddress != null)
            {
                body["primaryAddress"] = ExpressionConverter.ConvertO(bodyprimaryAddress);
                bodypropCount++;
            }

            if (bodyhomeStreetAddress != null)
            {
                body["homeAddressLine1"] = ExpressionConverter.ConvertO(bodyhomeStreetAddress);
                bodypropCount++;
            }

            if (bodyhomeStreetAddress2 != null)
            {
                body["homeAddressLine2"] = ExpressionConverter.ConvertO(bodyhomeStreetAddress2);
                bodypropCount++;
            }

            if (bodyhomeAddressCity != null)
            {
                body["homeCity"] = ExpressionConverter.ConvertO(bodyhomeAddressCity);
                bodypropCount++;
            }

            if (bodyhomeAddressState != null)
            {
                body["homeState"] = ExpressionConverter.ConvertO(bodyhomeAddressState);
                bodypropCount++;
            }

            if (bodyhomeAddressCountry != null)
            {
                body["homeCountry"] = ExpressionConverter.ConvertO(bodyhomeAddressCountry);
                bodypropCount++;
            }

            if (bodyhomeAddressPostalCode != null)
            {
                body["homePostalCode"] = ExpressionConverter.ConvertO(bodyhomeAddressPostalCode);
                bodypropCount++;
            }

            if (bodyhomeAddressPostalCodeExtension != null)
            {
                body["homePostalCodePlus4"] = ExpressionConverter.ConvertO(bodyhomeAddressPostalCodeExtension);
                bodypropCount++;
            }

            if (bodyhomeAddressPhone != null)
            {
                body["homeAddressPhone"] = ExpressionConverter.ConvertO(bodyhomeAddressPhone);
                bodypropCount++;
            }

            if (bodymailingStreetAddress != null)
            {
                body["mailingAddressLine1"] = ExpressionConverter.ConvertO(bodymailingStreetAddress);
                bodypropCount++;
            }

            if (bodymailingStreetAddress2 != null)
            {
                body["mailingAddressLine2"] = ExpressionConverter.ConvertO(bodymailingStreetAddress2);
                bodypropCount++;
            }

            if (bodymailingAddressCity != null)
            {
                body["mailingCity"] = ExpressionConverter.ConvertO(bodymailingAddressCity);
                bodypropCount++;
            }

            if (bodymailingAddressState != null)
            {
                body["mailingState"] = ExpressionConverter.ConvertO(bodymailingAddressState);
                bodypropCount++;
            }

            if (bodymailingAddressCountry != null)
            {
                body["mailingCountry"] = ExpressionConverter.ConvertO(bodymailingAddressCountry);
                bodypropCount++;
            }

            if (bodymailingAddressPostalCode != null)
            {
                body["mailingPostalCode"] = ExpressionConverter.ConvertO(bodymailingAddressPostalCode);
                bodypropCount++;
            }

            if (bodymailingAddressPostalCodeExtension != null)
            {
                body["mailingPostalCodePlus4"] = ExpressionConverter.ConvertO(bodymailingAddressPostalCodeExtension);
                bodypropCount++;
            }

            if (bodymailingAddressPhone != null)
            {
                body["mailingAddressPhone"] = ExpressionConverter.ConvertO(bodymailingAddressPhone);
                bodypropCount++;
            }

            if (bodyotherStreetAddress != null)
            {
                body["otherAddressLine1"] = ExpressionConverter.ConvertO(bodyotherStreetAddress);
                bodypropCount++;
            }

            if (bodyotherStreetAddress2 != null)
            {
                body["otherAddressLine2"] = ExpressionConverter.ConvertO(bodyotherStreetAddress2);
                bodypropCount++;
            }

            if (bodyotherAddressCity != null)
            {
                body["otherCity"] = ExpressionConverter.ConvertO(bodyotherAddressCity);
                bodypropCount++;
            }

            if (bodyotherAddressState != null)
            {
                body["otherState"] = ExpressionConverter.ConvertO(bodyotherAddressState);
                bodypropCount++;
            }

            if (bodyotherAddressCountry != null)
            {
                body["otherCountry"] = ExpressionConverter.ConvertO(bodyotherAddressCountry);
                bodypropCount++;
            }

            if (bodyotherAddressPostalCode != null)
            {
                body["otherPostalCode"] = ExpressionConverter.ConvertO(bodyotherAddressPostalCode);
                bodypropCount++;
            }

            if (bodyotherAddressPostalCodeExtension != null)
            {
                body["otherPostalCodePlus4"] = ExpressionConverter.ConvertO(bodyotherAddressPostalCodeExtension);
                bodypropCount++;
            }

            if (bodyotherAddressPhone != null)
            {
                body["otherAddressPhone"] = ExpressionConverter.ConvertO(bodyotherAddressPhone);
                bodypropCount++;
            }

            if (bodyotherAddressFromDate != null)
            {
                body["otherAddressFromDate"] = ExpressionConverter.ConvertO(bodyotherAddressFromDate);
                bodypropCount++;
            }

            if (bodyotherAddressToDate != null)
            {
                body["otherAddressToDate"] = ExpressionConverter.ConvertO(bodyotherAddressToDate);
                bodypropCount++;
            }

            if (bodysDiocesanId != null)
            {
                body["sdiocesanId"] = ExpressionConverter.ConvertO(bodysDiocesanId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> FamilyUpdateAutoFill(Expression<Func<int>> familyId, Expression<Func<int>> bodyorganizationId)
        {
            var apiCallPath = String.Format("/api/v2/families/{0}/autofill", ExpressionConverter.ConvertWithUrlEncoding(familyId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["organizationID"] = ExpressionConverter.ConvertO(bodyorganizationId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyChangeListResponseDto[]> FamilyChangeList(Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var apiCallPath = "/api/v2/families/change/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<FamilyChangeListResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto[]> MemberSearch(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<string>> bodysearchText = null, Expression<Func<bool>> bodyincludeDeletedMembers = null, Expression<Func<int[]>> bodyorganizationIdS = null, Expression<Func<int>> bodymemberAgeFrom = null, Expression<Func<int>> bodymemberAgeTo = null, Expression<Func<string>> bodylastModified = null, Expression<Func<int>> bodyfamilyRegistrationStatus = null, Expression<Func<string>> bodymemberStatusName = null, Expression<Func<int>> bodysearchByContains = null, Expression<Func<bool>> bodyincludeFamilyDioceseId = null, Expression<Func<bool>> bodyincludeMemberDioceseId = null, Expression<Func<bool>> bodyincludeFamilyLastName = null, Expression<Func<bool>> bodyincludeFamilyAddress = null, Expression<Func<bool>> bodyincludeFamilyAddressCity = null, Expression<Func<bool>> bodyincludeFamilyAddressState = null, Expression<Func<bool>> bodyincludeFamilyAddressPostalCode = null, Expression<Func<bool>> bodyincludeFamilyAddressZipPlus = null, Expression<Func<bool>> bodyincludeMemberName = null, Expression<Func<bool>> bodyincludeMemberType = null, Expression<Func<bool>> bodyincludeMemberGender = null, Expression<Func<bool>> bodyincludeMemberAge = null, Expression<Func<bool>> bodyincludeEnvelopeNumber = null, Expression<Func<bool>> bodyincludeEmailAddress = null, Expression<Func<bool>> bodyincludeHomePhone = null, Expression<Func<bool>> bodyincludeMobilePhone = null, Expression<Func<bool>> bodyincludeWorkPhone = null)
        {
            var apiCallPath = "/api/v2/members/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["startRowIndex"] = ExpressionConverter.ConvertO(bodypageNumber);
            bodypropCount++;
            body["maximumRows"] = ExpressionConverter.ConvertO(bodypageSize);
            if (bodysearchText != null)
            {
                body["fuzzy_SearchText"] = ExpressionConverter.ConvertO(bodysearchText);
                bodypropCount++;
            }

            if (bodyincludeDeletedMembers != null)
            {
                body["showDeletedMembers"] = ExpressionConverter.ConvertO(bodyincludeDeletedMembers);
                bodypropCount++;
            }

            if (bodyorganizationIdS != null)
            {
                body["organizationIDs"] = ExpressionConverter.ConvertO(bodyorganizationIdS);
                bodypropCount++;
            }

            if (bodymemberAgeFrom != null)
            {
                body["filter_MemberAgeRange_From"] = ExpressionConverter.ConvertO(bodymemberAgeFrom);
                bodypropCount++;
            }

            if (bodymemberAgeTo != null)
            {
                body["filter_MemberAgeRange_To"] = ExpressionConverter.ConvertO(bodymemberAgeTo);
                bodypropCount++;
            }

            if (bodylastModified != null)
            {
                body["filter_DateModified"] = ExpressionConverter.ConvertO(bodylastModified);
                bodypropCount++;
            }

            if (bodyfamilyRegistrationStatus != null)
            {
                body["filter_FamilyRegistrationStatus"] = ExpressionConverter.ConvertO(bodyfamilyRegistrationStatus);
                bodypropCount++;
            }

            if (bodymemberStatusName != null)
            {
                body["filter_MemberStatus"] = ExpressionConverter.ConvertO(bodymemberStatusName);
                bodypropCount++;
            }

            if (bodysearchByContains != null)
            {
                body["searchByContains"] = ExpressionConverter.ConvertO(bodysearchByContains);
                bodypropCount++;
            }

            if (bodyincludeFamilyDioceseId != null)
            {
                body["fuzzy_FamilyDUID"] = ExpressionConverter.ConvertO(bodyincludeFamilyDioceseId);
                bodypropCount++;
            }

            if (bodyincludeMemberDioceseId != null)
            {
                body["fuzzy_MemberDUID"] = ExpressionConverter.ConvertO(bodyincludeMemberDioceseId);
                bodypropCount++;
            }

            if (bodyincludeFamilyLastName != null)
            {
                body["fuzzy_FamilyLastName"] = ExpressionConverter.ConvertO(bodyincludeFamilyLastName);
                bodypropCount++;
            }

            if (bodyincludeFamilyAddress != null)
            {
                body["fuzzy_FamilyAddress_PrimaryAddressFull"] = ExpressionConverter.ConvertO(bodyincludeFamilyAddress);
                bodypropCount++;
            }

            if (bodyincludeFamilyAddressCity != null)
            {
                body["fuzzy_FamilyAddress_PrimaryCity"] = ExpressionConverter.ConvertO(bodyincludeFamilyAddressCity);
                bodypropCount++;
            }

            if (bodyincludeFamilyAddressState != null)
            {
                body["fuzzy_FamilyAddress_PrimaryState"] = ExpressionConverter.ConvertO(bodyincludeFamilyAddressState);
                bodypropCount++;
            }

            if (bodyincludeFamilyAddressPostalCode != null)
            {
                body["fuzzy_FamilyAddress_PrimaryPostalCode"] = ExpressionConverter.ConvertO(bodyincludeFamilyAddressPostalCode);
                bodypropCount++;
            }

            if (bodyincludeFamilyAddressZipPlus != null)
            {
                body["fuzzy_FamilyAddres_PrimaryZipPlus"] = ExpressionConverter.ConvertO(bodyincludeFamilyAddressZipPlus);
                bodypropCount++;
            }

            if (bodyincludeMemberName != null)
            {
                body["fuzzy_Display_MemberName"] = ExpressionConverter.ConvertO(bodyincludeMemberName);
                bodypropCount++;
            }

            if (bodyincludeMemberType != null)
            {
                body["fuzzy_MemberType"] = ExpressionConverter.ConvertO(bodyincludeMemberType);
                bodypropCount++;
            }

            if (bodyincludeMemberGender != null)
            {
                body["fuzzy_Sex"] = ExpressionConverter.ConvertO(bodyincludeMemberGender);
                bodypropCount++;
            }

            if (bodyincludeMemberAge != null)
            {
                body["fuzzy_Age"] = ExpressionConverter.ConvertO(bodyincludeMemberAge);
                bodypropCount++;
            }

            if (bodyincludeEnvelopeNumber != null)
            {
                body["fuzzy_EnvelopeNumber"] = ExpressionConverter.ConvertO(bodyincludeEnvelopeNumber);
                bodypropCount++;
            }

            if (bodyincludeEmailAddress != null)
            {
                body["fuzzy_EmailAddress"] = ExpressionConverter.ConvertO(bodyincludeEmailAddress);
                bodypropCount++;
            }

            if (bodyincludeHomePhone != null)
            {
                body["fuzzy_HomePhone"] = ExpressionConverter.ConvertO(bodyincludeHomePhone);
                bodypropCount++;
            }

            if (bodyincludeMobilePhone != null)
            {
                body["fuzzy_MobilePhone"] = ExpressionConverter.ConvertO(bodyincludeMobilePhone);
                bodypropCount++;
            }

            if (bodyincludeWorkPhone != null)
            {
                body["fuzzy_WorkPhone"] = ExpressionConverter.ConvertO(bodyincludeWorkPhone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MemberSearchResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto> MemberDetail(Expression<Func<int>> memberId)
        {
            var apiCallPath = String.Format("/api/v2/members/{0}", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberSearchResponseDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<SacramentDto[]> MemberSacramentList(Expression<Func<int>> memberId, Expression<Func<int>> type)
        {
            var apiCallPath = String.Format("/api/v2/members/{0}/sacrament/{1}/list", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1), ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SacramentDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberStatusListResponseDto[]> MemberStatusLookupList()
        {
            var apiCallPath = "/api/v2/members/memberstatus/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberStatusListResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[]> MemberTypeLookupList()
        {
            var apiCallPath = "/api/v2/members/membertype/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[]> MemberWorkGroupLookupList()
        {
            var apiCallPath = "/api/v2/members/workgroup/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberContactListResponseDto[]> MemberContactList(Expression<Func<int>> bodypageSize, Expression<Func<int>> bodypageNumber, Expression<Func<string>> bodymemberFirstName = null, Expression<Func<string>> bodymemberLastName = null, Expression<Func<string>> bodymemberEmailAddress = null, Expression<Func<string>> bodymemberMobilePhone = null, Expression<Func<int[]>> bodyorganizationIdS = null)
        {
            var apiCallPath = "/api/v2/members/contact/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["limit"] = ExpressionConverter.ConvertO(bodypageSize);
            bodypropCount++;
            body["offset"] = ExpressionConverter.ConvertO(bodypageNumber);
            if (bodymemberFirstName != null)
            {
                body["memberFirstName"] = ExpressionConverter.ConvertO(bodymemberFirstName);
                bodypropCount++;
            }

            if (bodymemberLastName != null)
            {
                body["memberLastName"] = ExpressionConverter.ConvertO(bodymemberLastName);
                bodypropCount++;
            }

            if (bodymemberEmailAddress != null)
            {
                body["emailAddress"] = ExpressionConverter.ConvertO(bodymemberEmailAddress);
                bodypropCount++;
            }

            if (bodymemberMobilePhone != null)
            {
                body["cellPhone"] = ExpressionConverter.ConvertO(bodymemberMobilePhone);
                bodypropCount++;
            }

            if (bodyorganizationIdS != null)
            {
                body["organizationIDs"] = ExpressionConverter.ConvertO(bodyorganizationIdS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MemberContactListResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IWorkflowAction MemberUpdateContact(Expression<Func<int>> memberId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodynickName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydateOfDeath = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyhomePhone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyworkPhone = null, Expression<Func<string>> bodypager = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodygender = null)
        {
            var apiCallPath = String.Format("/api/v2/members/{0}/contact", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodynickName != null)
            {
                body["nickName"] = ExpressionConverter.ConvertO(bodynickName);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodymaidenName != null)
            {
                body["maidenName"] = ExpressionConverter.ConvertO(bodymaidenName);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["dateOfBirth"] = ExpressionConverter.ConvertO(bodybirthday);
                bodypropCount++;
            }

            if (bodydateOfDeath != null)
            {
                body["dateOfDeath"] = ExpressionConverter.ConvertO(bodydateOfDeath);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["emailAddress"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyhomePhone != null)
            {
                body["homePhone"] = ExpressionConverter.ConvertO(bodyhomePhone);
                bodypropCount++;
            }

            if (bodymobilePhone != null)
            {
                body["cellPhone"] = ExpressionConverter.ConvertO(bodymobilePhone);
                bodypropCount++;
            }

            if (bodyworkPhone != null)
            {
                body["workPhone"] = ExpressionConverter.ConvertO(bodyworkPhone);
                bodypropCount++;
            }

            if (bodypager != null)
            {
                body["pager"] = ExpressionConverter.ConvertO(bodypager);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FundListResponseDto[]> OfferingFundList(Expression<Func<int>> organizationId)
        {
            var apiCallPath = String.Format("/api/v2/offering/{0}/funds", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FundListResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<GiverListResponseDto[]> OfferingGiverList(Expression<Func<int>> organizationId)
        {
            var apiCallPath = String.Format("/api/v2/offering/{0}/givers", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiverListResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyContributionSummaryResponseDto[]> OfferingFamilyContributionSearch(Expression<Func<int>> organizationId, Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<int[]>> bodyfamilyIdS = null, Expression<Func<int[]>> bodyfundIdS = null, Expression<Func<int>> bodygroupId = null, Expression<Func<bool>> bodyregisteredFamilies = null, Expression<Func<string>> bodycontributionStartDate = null, Expression<Func<string>> bodycontributionEndDate = null, Expression<Func<double>> bodycontributionLowAmount = null, Expression<Func<double>> bodycontributionHighAmount = null, Expression<Func<double>> bodytotalContributionLowAmount = null, Expression<Func<double>> bodytotalContributionHighAmount = null, Expression<Func<bool>> bodyincludeDeleted = null, Expression<Func<bool>> bodyincludeZeroContributions = null, Expression<Func<bool>> bodyincludeNonGivers = null)
        {
            var apiCallPath = String.Format("/api/v2/offering/{0}/contribution/summary/list", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["startRowIndex"] = ExpressionConverter.ConvertO(bodypageNumber);
            bodypropCount++;
            body["maximumRows"] = ExpressionConverter.ConvertO(bodypageSize);
            if (bodyfamilyIdS != null)
            {
                body["familyDUIDs"] = ExpressionConverter.ConvertO(bodyfamilyIdS);
                bodypropCount++;
            }

            if (bodyfundIdS != null)
            {
                body["fundsDUIDs"] = ExpressionConverter.ConvertO(bodyfundIdS);
                bodypropCount++;
            }

            if (bodygroupId != null)
            {
                body["familyGroupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyregisteredFamilies != null)
            {
                body["registeredFamilies"] = ExpressionConverter.ConvertO(bodyregisteredFamilies);
                bodypropCount++;
            }

            if (bodycontributionStartDate != null)
            {
                body["postDate_Low"] = ExpressionConverter.ConvertO(bodycontributionStartDate);
                bodypropCount++;
            }

            if (bodycontributionEndDate != null)
            {
                body["postDate_High"] = ExpressionConverter.ConvertO(bodycontributionEndDate);
                bodypropCount++;
            }

            if (bodycontributionLowAmount != null)
            {
                body["amount_Low"] = ExpressionConverter.ConvertO(bodycontributionLowAmount);
                bodypropCount++;
            }

            if (bodycontributionHighAmount != null)
            {
                body["amount_High"] = ExpressionConverter.ConvertO(bodycontributionHighAmount);
                bodypropCount++;
            }

            if (bodytotalContributionLowAmount != null)
            {
                body["totalAmount_Low"] = ExpressionConverter.ConvertO(bodytotalContributionLowAmount);
                bodypropCount++;
            }

            if (bodytotalContributionHighAmount != null)
            {
                body["totalAmount_High"] = ExpressionConverter.ConvertO(bodytotalContributionHighAmount);
                bodypropCount++;
            }

            if (bodyincludeDeleted != null)
            {
                body["familyDeleted"] = ExpressionConverter.ConvertO(bodyincludeDeleted);
                bodypropCount++;
            }

            if (bodyincludeZeroContributions != null)
            {
                body["includeZeroDollarContributions"] = ExpressionConverter.ConvertO(bodyincludeZeroContributions);
                bodypropCount++;
            }

            if (bodyincludeNonGivers != null)
            {
                body["includeNonGivers"] = ExpressionConverter.ConvertO(bodyincludeNonGivers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FamilyContributionSummaryResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto[]> OrganizationSearch(Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodyorganizationTypeList = null, Expression<Func<string>> bodyvicariate = null)
        {
            var apiCallPath = "/api/v2/organizations/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyorganizationTypeList != null)
            {
                body["types"] = ExpressionConverter.ConvertO(bodyorganizationTypeList);
                bodypropCount++;
            }

            if (bodyvicariate != null)
            {
                body["vicariate"] = ExpressionConverter.ConvertO(bodyvicariate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrganizationDetailResponseDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto> OrganizationDetail(Expression<Func<int>> organizationId)
        {
            var apiCallPath = String.Format("/api/v2/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrganizationDetailResponseDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string> Test()
        {
            var apiCallPath = "/api/v2/test";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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