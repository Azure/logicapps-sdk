//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parishsoftfamilysuit
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParishsoftfamilysuitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<ConstituentDetailResponseDto[], ApiConnectionActionConfiguration> ConstituentSearch(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> lastModifiedDate = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortDirection = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: true);
            var __workflow_lastModifiedDate = WorkflowExpression.Compile(lastModifiedDate, nameof(lastModifiedDate), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ConstituentDetailResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_lastModifiedDate != null)
                    callPayload.Queries["LastModifiedDate"] = ExpressionConverter.Convert(__workflow_lastModifiedDate);
                callPayload.Queries["SortBy"] = Convert.ToString("HeadLastName");
                if (__workflow_sortBy != null)
                    callPayload.Queries["SortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["SortDirection"] = Convert.ToString("asc");
                if (__workflow_sortDirection != null)
                    callPayload.Queries["SortDirection"] = ExpressionConverter.Convert(__workflow_sortDirection);
                return new ApiConnectionAction<ConstituentDetailResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<ConstituentDetailResponseDto, ApiConnectionActionConfiguration> ConstituentDetail(Expression<Func<string>> sDioceseId)
        {
            var __workflow_sDioceseId = WorkflowExpression.Compile(sDioceseId, nameof(sDioceseId), required: true);
            return new DeferredBodyAction<ConstituentDetailResponseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/constituents/detail/{0}", __workflow_sDioceseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentDetailResponseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto[], ApiConnectionActionConfiguration> FamilySearch(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyfamilyId = null, Expression<Func<int>> bodydioceseId = null, Expression<Func<bool>> bodymembershipStatus = null, Expression<Func<int>> bodyfamilyGroupId = null, Expression<Func<int[]>> bodyorganizations = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bool>> bodyhasAFamilyEmailAddress = null, Expression<Func<bool>> bodysendContributionEnvelopes = null, Expression<Func<string>> bodyregistrationStart = null, Expression<Func<string>> bodyregistrationEnd = null, Expression<Func<string>> bodystreetAddress = null, Expression<Func<string>> bodyaddressCity = null, Expression<Func<string>> bodyaddressState = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodysendNoMail = null, Expression<Func<bool>> bodydoNotPublish = null, Expression<Func<bool>> bodyhasEmail = null, Expression<Func<string>> bodyfamilyGroupName = null, Expression<Func<string>> bodyenvelopeNumber = null, Expression<Func<string>> bodyprimaryAddressPhoneNumber = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<int>> bodyregisteredOrganizationId = null, Expression<Func<string>> bodylastModified = null)
        {
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyfamilyId = WorkflowExpression.Compile(bodyfamilyId, nameof(bodyfamilyId), required: false);
            var __workflow_bodydioceseId = WorkflowExpression.Compile(bodydioceseId, nameof(bodydioceseId), required: false);
            var __workflow_bodymembershipStatus = WorkflowExpression.Compile(bodymembershipStatus, nameof(bodymembershipStatus), required: false);
            var __workflow_bodyfamilyGroupId = WorkflowExpression.Compile(bodyfamilyGroupId, nameof(bodyfamilyGroupId), required: false);
            var __workflow_bodyorganizations = WorkflowExpression.Compile(bodyorganizations, nameof(bodyorganizations), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyhasAFamilyEmailAddress = WorkflowExpression.Compile(bodyhasAFamilyEmailAddress, nameof(bodyhasAFamilyEmailAddress), required: false);
            var __workflow_bodysendContributionEnvelopes = WorkflowExpression.Compile(bodysendContributionEnvelopes, nameof(bodysendContributionEnvelopes), required: false);
            var __workflow_bodyregistrationStart = WorkflowExpression.Compile(bodyregistrationStart, nameof(bodyregistrationStart), required: false);
            var __workflow_bodyregistrationEnd = WorkflowExpression.Compile(bodyregistrationEnd, nameof(bodyregistrationEnd), required: false);
            var __workflow_bodystreetAddress = WorkflowExpression.Compile(bodystreetAddress, nameof(bodystreetAddress), required: false);
            var __workflow_bodyaddressCity = WorkflowExpression.Compile(bodyaddressCity, nameof(bodyaddressCity), required: false);
            var __workflow_bodyaddressState = WorkflowExpression.Compile(bodyaddressState, nameof(bodyaddressState), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodysendNoMail = WorkflowExpression.Compile(bodysendNoMail, nameof(bodysendNoMail), required: false);
            var __workflow_bodydoNotPublish = WorkflowExpression.Compile(bodydoNotPublish, nameof(bodydoNotPublish), required: false);
            var __workflow_bodyhasEmail = WorkflowExpression.Compile(bodyhasEmail, nameof(bodyhasEmail), required: false);
            var __workflow_bodyfamilyGroupName = WorkflowExpression.Compile(bodyfamilyGroupName, nameof(bodyfamilyGroupName), required: false);
            var __workflow_bodyenvelopeNumber = WorkflowExpression.Compile(bodyenvelopeNumber, nameof(bodyenvelopeNumber), required: false);
            var __workflow_bodyprimaryAddressPhoneNumber = WorkflowExpression.Compile(bodyprimaryAddressPhoneNumber, nameof(bodyprimaryAddressPhoneNumber), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyregisteredOrganizationId = WorkflowExpression.Compile(bodyregisteredOrganizationId, nameof(bodyregisteredOrganizationId), required: false);
            var __workflow_bodylastModified = WorkflowExpression.Compile(bodylastModified, nameof(bodylastModified), required: false);
            return new DeferredBodyAction<FamilySearchResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/families/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                bodypropCount++;
                body["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                if (__workflow_bodyfamilyId != null)
                {
                    body["familyID"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyId);
                    bodypropCount++;
                }

                if (__workflow_bodydioceseId != null)
                {
                    body["familyDUID"] = ExpressionConverter.ConvertO(__workflow_bodydioceseId);
                    bodypropCount++;
                }

                if (__workflow_bodymembershipStatus != null)
                {
                    body["memberShipStatus"] = ExpressionConverter.ConvertO(__workflow_bodymembershipStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyfamilyGroupId != null)
                {
                    body["familyGroupID"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizations != null)
                {
                    body["organizationIDs"] = ExpressionConverter.ConvertO(__workflow_bodyorganizations);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyhasAFamilyEmailAddress != null)
                {
                    body["hasEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhasAFamilyEmailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodysendContributionEnvelopes != null)
                {
                    body["envelopes"] = ExpressionConverter.ConvertO(__workflow_bodysendContributionEnvelopes);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationStart != null)
                {
                    body["registrationDateFrom"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationStart);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationEnd != null)
                {
                    body["registrationDateTo"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationEnd);
                    bodypropCount++;
                }

                if (__workflow_bodystreetAddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodystreetAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressState != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressState);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysendNoMail != null)
                {
                    body["sendNoMail"] = ExpressionConverter.ConvertO(__workflow_bodysendNoMail);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotPublish != null)
                {
                    body["doNotPublish"] = ExpressionConverter.ConvertO(__workflow_bodydoNotPublish);
                    bodypropCount++;
                }

                if (__workflow_bodyhasEmail != null)
                {
                    body["familiesWithEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhasEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyfamilyGroupName != null)
                {
                    body["familyGroupName"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyGroupName);
                    bodypropCount++;
                }

                if (__workflow_bodyenvelopeNumber != null)
                {
                    body["envelopeNumber"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopeNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryAddressPhoneNumber != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddressPhoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["eMailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyregisteredOrganizationId != null)
                {
                    body["registeredOrganizationID"] = ExpressionConverter.ConvertO(__workflow_bodyregisteredOrganizationId);
                    bodypropCount++;
                }

                if (__workflow_bodylastModified != null)
                {
                    body["dateModified"] = ExpressionConverter.ConvertO(__workflow_bodylastModified);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FamilySearchResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilySearchResponseDto, ApiConnectionActionConfiguration> FamilyDetail(Expression<Func<int>> familyId)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            return new DeferredBodyAction<FamilySearchResponseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FamilySearchResponseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMemberResponseDto[], ApiConnectionActionConfiguration> FamilyMemberList(Expression<Func<int>> familyId)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            return new DeferredBodyAction<FamilyMemberResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/member/list", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FamilyMemberResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyMinistryResponseDto[], ApiConnectionActionConfiguration> FamilyMinistriesList(Expression<Func<int>> familyId)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            return new DeferredBodyAction<FamilyMinistryResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/ministry/list", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FamilyMinistryResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyGroupResponseDto[], ApiConnectionActionConfiguration> FamilyGroupLookupList()
        {
            return new DeferredBodyAction<FamilyGroupResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/families/group/lookup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FamilyGroupResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyWorkGroupResponseDto[], ApiConnectionActionConfiguration> FamilyWorkGroupList(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FamilyWorkGroupResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/families/workgroup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FamilyWorkGroupResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FamilyUpdateContactInfo(Expression<Func<int>> familyId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymailingName = null, Expression<Func<string>> bodyinformalMailingName = null, Expression<Func<string>> bodyformalSalutation = null, Expression<Func<string>> bodyinformalSalutation = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyprimaryPhone = null, Expression<Func<string>> bodyemergencyPhone = null, Expression<Func<string>> bodyprimaryAddress = null, Expression<Func<string>> bodyhomeStreetAddress = null, Expression<Func<string>> bodyhomeStreetAddress2 = null, Expression<Func<string>> bodyhomeAddressCity = null, Expression<Func<string>> bodyhomeAddressState = null, Expression<Func<string>> bodyhomeAddressCountry = null, Expression<Func<string>> bodyhomeAddressPostalCode = null, Expression<Func<string>> bodyhomeAddressPostalCodeExtension = null, Expression<Func<string>> bodyhomeAddressPhone = null, Expression<Func<string>> bodymailingStreetAddress = null, Expression<Func<string>> bodymailingStreetAddress2 = null, Expression<Func<string>> bodymailingAddressCity = null, Expression<Func<string>> bodymailingAddressState = null, Expression<Func<string>> bodymailingAddressCountry = null, Expression<Func<string>> bodymailingAddressPostalCode = null, Expression<Func<string>> bodymailingAddressPostalCodeExtension = null, Expression<Func<string>> bodymailingAddressPhone = null, Expression<Func<string>> bodyotherStreetAddress = null, Expression<Func<string>> bodyotherStreetAddress2 = null, Expression<Func<string>> bodyotherAddressCity = null, Expression<Func<string>> bodyotherAddressState = null, Expression<Func<string>> bodyotherAddressCountry = null, Expression<Func<string>> bodyotherAddressPostalCode = null, Expression<Func<string>> bodyotherAddressPostalCodeExtension = null, Expression<Func<string>> bodyotherAddressPhone = null, Expression<Func<string>> bodyotherAddressFromDate = null, Expression<Func<string>> bodyotherAddressToDate = null, Expression<Func<string>> bodysDiocesanId = null)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymailingName = WorkflowExpression.Compile(bodymailingName, nameof(bodymailingName), required: false);
            var __workflow_bodyinformalMailingName = WorkflowExpression.Compile(bodyinformalMailingName, nameof(bodyinformalMailingName), required: false);
            var __workflow_bodyformalSalutation = WorkflowExpression.Compile(bodyformalSalutation, nameof(bodyformalSalutation), required: false);
            var __workflow_bodyinformalSalutation = WorkflowExpression.Compile(bodyinformalSalutation, nameof(bodyinformalSalutation), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyprimaryPhone = WorkflowExpression.Compile(bodyprimaryPhone, nameof(bodyprimaryPhone), required: false);
            var __workflow_bodyemergencyPhone = WorkflowExpression.Compile(bodyemergencyPhone, nameof(bodyemergencyPhone), required: false);
            var __workflow_bodyprimaryAddress = WorkflowExpression.Compile(bodyprimaryAddress, nameof(bodyprimaryAddress), required: false);
            var __workflow_bodyhomeStreetAddress = WorkflowExpression.Compile(bodyhomeStreetAddress, nameof(bodyhomeStreetAddress), required: false);
            var __workflow_bodyhomeStreetAddress2 = WorkflowExpression.Compile(bodyhomeStreetAddress2, nameof(bodyhomeStreetAddress2), required: false);
            var __workflow_bodyhomeAddressCity = WorkflowExpression.Compile(bodyhomeAddressCity, nameof(bodyhomeAddressCity), required: false);
            var __workflow_bodyhomeAddressState = WorkflowExpression.Compile(bodyhomeAddressState, nameof(bodyhomeAddressState), required: false);
            var __workflow_bodyhomeAddressCountry = WorkflowExpression.Compile(bodyhomeAddressCountry, nameof(bodyhomeAddressCountry), required: false);
            var __workflow_bodyhomeAddressPostalCode = WorkflowExpression.Compile(bodyhomeAddressPostalCode, nameof(bodyhomeAddressPostalCode), required: false);
            var __workflow_bodyhomeAddressPostalCodeExtension = WorkflowExpression.Compile(bodyhomeAddressPostalCodeExtension, nameof(bodyhomeAddressPostalCodeExtension), required: false);
            var __workflow_bodyhomeAddressPhone = WorkflowExpression.Compile(bodyhomeAddressPhone, nameof(bodyhomeAddressPhone), required: false);
            var __workflow_bodymailingStreetAddress = WorkflowExpression.Compile(bodymailingStreetAddress, nameof(bodymailingStreetAddress), required: false);
            var __workflow_bodymailingStreetAddress2 = WorkflowExpression.Compile(bodymailingStreetAddress2, nameof(bodymailingStreetAddress2), required: false);
            var __workflow_bodymailingAddressCity = WorkflowExpression.Compile(bodymailingAddressCity, nameof(bodymailingAddressCity), required: false);
            var __workflow_bodymailingAddressState = WorkflowExpression.Compile(bodymailingAddressState, nameof(bodymailingAddressState), required: false);
            var __workflow_bodymailingAddressCountry = WorkflowExpression.Compile(bodymailingAddressCountry, nameof(bodymailingAddressCountry), required: false);
            var __workflow_bodymailingAddressPostalCode = WorkflowExpression.Compile(bodymailingAddressPostalCode, nameof(bodymailingAddressPostalCode), required: false);
            var __workflow_bodymailingAddressPostalCodeExtension = WorkflowExpression.Compile(bodymailingAddressPostalCodeExtension, nameof(bodymailingAddressPostalCodeExtension), required: false);
            var __workflow_bodymailingAddressPhone = WorkflowExpression.Compile(bodymailingAddressPhone, nameof(bodymailingAddressPhone), required: false);
            var __workflow_bodyotherStreetAddress = WorkflowExpression.Compile(bodyotherStreetAddress, nameof(bodyotherStreetAddress), required: false);
            var __workflow_bodyotherStreetAddress2 = WorkflowExpression.Compile(bodyotherStreetAddress2, nameof(bodyotherStreetAddress2), required: false);
            var __workflow_bodyotherAddressCity = WorkflowExpression.Compile(bodyotherAddressCity, nameof(bodyotherAddressCity), required: false);
            var __workflow_bodyotherAddressState = WorkflowExpression.Compile(bodyotherAddressState, nameof(bodyotherAddressState), required: false);
            var __workflow_bodyotherAddressCountry = WorkflowExpression.Compile(bodyotherAddressCountry, nameof(bodyotherAddressCountry), required: false);
            var __workflow_bodyotherAddressPostalCode = WorkflowExpression.Compile(bodyotherAddressPostalCode, nameof(bodyotherAddressPostalCode), required: false);
            var __workflow_bodyotherAddressPostalCodeExtension = WorkflowExpression.Compile(bodyotherAddressPostalCodeExtension, nameof(bodyotherAddressPostalCodeExtension), required: false);
            var __workflow_bodyotherAddressPhone = WorkflowExpression.Compile(bodyotherAddressPhone, nameof(bodyotherAddressPhone), required: false);
            var __workflow_bodyotherAddressFromDate = WorkflowExpression.Compile(bodyotherAddressFromDate, nameof(bodyotherAddressFromDate), required: false);
            var __workflow_bodyotherAddressToDate = WorkflowExpression.Compile(bodyotherAddressToDate, nameof(bodyotherAddressToDate), required: false);
            var __workflow_bodysDiocesanId = WorkflowExpression.Compile(bodysDiocesanId, nameof(bodysDiocesanId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/contact", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodymailingName != null)
                {
                    body["mailingName"] = ExpressionConverter.ConvertO(__workflow_bodymailingName);
                    bodypropCount++;
                }

                if (__workflow_bodyinformalMailingName != null)
                {
                    body["informalMailingName"] = ExpressionConverter.ConvertO(__workflow_bodyinformalMailingName);
                    bodypropCount++;
                }

                if (__workflow_bodyformalSalutation != null)
                {
                    body["formalSalutation"] = ExpressionConverter.ConvertO(__workflow_bodyformalSalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyinformalSalutation != null)
                {
                    body["informalSalutation"] = ExpressionConverter.ConvertO(__workflow_bodyinformalSalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["emailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryPhone != null)
                {
                    body["primaryPhone"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyPhone != null)
                {
                    body["emergencyPhone"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryAddress != null)
                {
                    body["primaryAddress"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeStreetAddress != null)
                {
                    body["homeAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyhomeStreetAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeStreetAddress2 != null)
                {
                    body["homeAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyhomeStreetAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressCity != null)
                {
                    body["homeCity"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressState != null)
                {
                    body["homeState"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressCountry != null)
                {
                    body["homeCountry"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressPostalCode != null)
                {
                    body["homePostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressPostalCodeExtension != null)
                {
                    body["homePostalCodePlus4"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (__workflow_bodyhomeAddressPhone != null)
                {
                    body["homeAddressPhone"] = ExpressionConverter.ConvertO(__workflow_bodyhomeAddressPhone);
                    bodypropCount++;
                }

                if (__workflow_bodymailingStreetAddress != null)
                {
                    body["mailingAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodymailingStreetAddress);
                    bodypropCount++;
                }

                if (__workflow_bodymailingStreetAddress2 != null)
                {
                    body["mailingAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodymailingStreetAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressCity != null)
                {
                    body["mailingCity"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressState != null)
                {
                    body["mailingState"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressCountry != null)
                {
                    body["mailingCountry"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressPostalCode != null)
                {
                    body["mailingPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressPostalCodeExtension != null)
                {
                    body["mailingPostalCodePlus4"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (__workflow_bodymailingAddressPhone != null)
                {
                    body["mailingAddressPhone"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyotherStreetAddress != null)
                {
                    body["otherAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyotherStreetAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyotherStreetAddress2 != null)
                {
                    body["otherAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyotherStreetAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressCity != null)
                {
                    body["otherCity"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressState != null)
                {
                    body["otherState"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressCountry != null)
                {
                    body["otherCountry"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressPostalCode != null)
                {
                    body["otherPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressPostalCodeExtension != null)
                {
                    body["otherPostalCodePlus4"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressPostalCodeExtension);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressPhone != null)
                {
                    body["otherAddressPhone"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressFromDate != null)
                {
                    body["otherAddressFromDate"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressFromDate);
                    bodypropCount++;
                }

                if (__workflow_bodyotherAddressToDate != null)
                {
                    body["otherAddressToDate"] = ExpressionConverter.ConvertO(__workflow_bodyotherAddressToDate);
                    bodypropCount++;
                }

                if (__workflow_bodysDiocesanId != null)
                {
                    body["sdiocesanId"] = ExpressionConverter.ConvertO(__workflow_bodysDiocesanId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FamilyUpdateAutoFill(Expression<Func<int>> familyId, Expression<Func<int>> bodyorganizationId)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/autofill", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["organizationID"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyChangeListResponseDto[], ApiConnectionActionConfiguration> FamilyChangeList(Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<FamilyChangeListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/families/change/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<FamilyChangeListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto[], ApiConnectionActionConfiguration> MemberSearch(Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<string>> bodysearchText = null, Expression<Func<bool>> bodyincludeDeletedMembers = null, Expression<Func<int[]>> bodyorganizationIdS = null, Expression<Func<int>> bodymemberAgeFrom = null, Expression<Func<int>> bodymemberAgeTo = null, Expression<Func<string>> bodylastModified = null, Expression<Func<int>> bodyfamilyRegistrationStatus = null, Expression<Func<string>> bodymemberStatusName = null, Expression<Func<int>> bodysearchByContains = null, Expression<Func<bool>> bodyincludeFamilyDioceseId = null, Expression<Func<bool>> bodyincludeMemberDioceseId = null, Expression<Func<bool>> bodyincludeFamilyLastName = null, Expression<Func<bool>> bodyincludeFamilyAddress = null, Expression<Func<bool>> bodyincludeFamilyAddressCity = null, Expression<Func<bool>> bodyincludeFamilyAddressState = null, Expression<Func<bool>> bodyincludeFamilyAddressPostalCode = null, Expression<Func<bool>> bodyincludeFamilyAddressZipPlus = null, Expression<Func<bool>> bodyincludeMemberName = null, Expression<Func<bool>> bodyincludeMemberType = null, Expression<Func<bool>> bodyincludeMemberGender = null, Expression<Func<bool>> bodyincludeMemberAge = null, Expression<Func<bool>> bodyincludeEnvelopeNumber = null, Expression<Func<bool>> bodyincludeEmailAddress = null, Expression<Func<bool>> bodyincludeHomePhone = null, Expression<Func<bool>> bodyincludeMobilePhone = null, Expression<Func<bool>> bodyincludeWorkPhone = null)
        {
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodysearchText = WorkflowExpression.Compile(bodysearchText, nameof(bodysearchText), required: false);
            var __workflow_bodyincludeDeletedMembers = WorkflowExpression.Compile(bodyincludeDeletedMembers, nameof(bodyincludeDeletedMembers), required: false);
            var __workflow_bodyorganizationIdS = WorkflowExpression.Compile(bodyorganizationIdS, nameof(bodyorganizationIdS), required: false);
            var __workflow_bodymemberAgeFrom = WorkflowExpression.Compile(bodymemberAgeFrom, nameof(bodymemberAgeFrom), required: false);
            var __workflow_bodymemberAgeTo = WorkflowExpression.Compile(bodymemberAgeTo, nameof(bodymemberAgeTo), required: false);
            var __workflow_bodylastModified = WorkflowExpression.Compile(bodylastModified, nameof(bodylastModified), required: false);
            var __workflow_bodyfamilyRegistrationStatus = WorkflowExpression.Compile(bodyfamilyRegistrationStatus, nameof(bodyfamilyRegistrationStatus), required: false);
            var __workflow_bodymemberStatusName = WorkflowExpression.Compile(bodymemberStatusName, nameof(bodymemberStatusName), required: false);
            var __workflow_bodysearchByContains = WorkflowExpression.Compile(bodysearchByContains, nameof(bodysearchByContains), required: false);
            var __workflow_bodyincludeFamilyDioceseId = WorkflowExpression.Compile(bodyincludeFamilyDioceseId, nameof(bodyincludeFamilyDioceseId), required: false);
            var __workflow_bodyincludeMemberDioceseId = WorkflowExpression.Compile(bodyincludeMemberDioceseId, nameof(bodyincludeMemberDioceseId), required: false);
            var __workflow_bodyincludeFamilyLastName = WorkflowExpression.Compile(bodyincludeFamilyLastName, nameof(bodyincludeFamilyLastName), required: false);
            var __workflow_bodyincludeFamilyAddress = WorkflowExpression.Compile(bodyincludeFamilyAddress, nameof(bodyincludeFamilyAddress), required: false);
            var __workflow_bodyincludeFamilyAddressCity = WorkflowExpression.Compile(bodyincludeFamilyAddressCity, nameof(bodyincludeFamilyAddressCity), required: false);
            var __workflow_bodyincludeFamilyAddressState = WorkflowExpression.Compile(bodyincludeFamilyAddressState, nameof(bodyincludeFamilyAddressState), required: false);
            var __workflow_bodyincludeFamilyAddressPostalCode = WorkflowExpression.Compile(bodyincludeFamilyAddressPostalCode, nameof(bodyincludeFamilyAddressPostalCode), required: false);
            var __workflow_bodyincludeFamilyAddressZipPlus = WorkflowExpression.Compile(bodyincludeFamilyAddressZipPlus, nameof(bodyincludeFamilyAddressZipPlus), required: false);
            var __workflow_bodyincludeMemberName = WorkflowExpression.Compile(bodyincludeMemberName, nameof(bodyincludeMemberName), required: false);
            var __workflow_bodyincludeMemberType = WorkflowExpression.Compile(bodyincludeMemberType, nameof(bodyincludeMemberType), required: false);
            var __workflow_bodyincludeMemberGender = WorkflowExpression.Compile(bodyincludeMemberGender, nameof(bodyincludeMemberGender), required: false);
            var __workflow_bodyincludeMemberAge = WorkflowExpression.Compile(bodyincludeMemberAge, nameof(bodyincludeMemberAge), required: false);
            var __workflow_bodyincludeEnvelopeNumber = WorkflowExpression.Compile(bodyincludeEnvelopeNumber, nameof(bodyincludeEnvelopeNumber), required: false);
            var __workflow_bodyincludeEmailAddress = WorkflowExpression.Compile(bodyincludeEmailAddress, nameof(bodyincludeEmailAddress), required: false);
            var __workflow_bodyincludeHomePhone = WorkflowExpression.Compile(bodyincludeHomePhone, nameof(bodyincludeHomePhone), required: false);
            var __workflow_bodyincludeMobilePhone = WorkflowExpression.Compile(bodyincludeMobilePhone, nameof(bodyincludeMobilePhone), required: false);
            var __workflow_bodyincludeWorkPhone = WorkflowExpression.Compile(bodyincludeWorkPhone, nameof(bodyincludeWorkPhone), required: false);
            return new DeferredBodyAction<MemberSearchResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startRowIndex"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                bodypropCount++;
                body["maximumRows"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                if (__workflow_bodysearchText != null)
                {
                    body["fuzzy_SearchText"] = ExpressionConverter.ConvertO(__workflow_bodysearchText);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeDeletedMembers != null)
                {
                    body["showDeletedMembers"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDeletedMembers);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationIdS != null)
                {
                    body["organizationIDs"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationIdS);
                    bodypropCount++;
                }

                if (__workflow_bodymemberAgeFrom != null)
                {
                    body["filter_MemberAgeRange_From"] = ExpressionConverter.ConvertO(__workflow_bodymemberAgeFrom);
                    bodypropCount++;
                }

                if (__workflow_bodymemberAgeTo != null)
                {
                    body["filter_MemberAgeRange_To"] = ExpressionConverter.ConvertO(__workflow_bodymemberAgeTo);
                    bodypropCount++;
                }

                if (__workflow_bodylastModified != null)
                {
                    body["filter_DateModified"] = ExpressionConverter.ConvertO(__workflow_bodylastModified);
                    bodypropCount++;
                }

                if (__workflow_bodyfamilyRegistrationStatus != null)
                {
                    body["filter_FamilyRegistrationStatus"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyRegistrationStatus);
                    bodypropCount++;
                }

                if (__workflow_bodymemberStatusName != null)
                {
                    body["filter_MemberStatus"] = ExpressionConverter.ConvertO(__workflow_bodymemberStatusName);
                    bodypropCount++;
                }

                if (__workflow_bodysearchByContains != null)
                {
                    body["searchByContains"] = ExpressionConverter.ConvertO(__workflow_bodysearchByContains);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyDioceseId != null)
                {
                    body["fuzzy_FamilyDUID"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyDioceseId);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMemberDioceseId != null)
                {
                    body["fuzzy_MemberDUID"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMemberDioceseId);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyLastName != null)
                {
                    body["fuzzy_FamilyLastName"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyLastName);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyAddress != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryAddressFull"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyAddressCity != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryCity"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyAddressState != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryState"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyAddressPostalCode != null)
                {
                    body["fuzzy_FamilyAddress_PrimaryPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeFamilyAddressZipPlus != null)
                {
                    body["fuzzy_FamilyAddres_PrimaryZipPlus"] = ExpressionConverter.ConvertO(__workflow_bodyincludeFamilyAddressZipPlus);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMemberName != null)
                {
                    body["fuzzy_Display_MemberName"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMemberName);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMemberType != null)
                {
                    body["fuzzy_MemberType"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMemberType);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMemberGender != null)
                {
                    body["fuzzy_Sex"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMemberGender);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMemberAge != null)
                {
                    body["fuzzy_Age"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMemberAge);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeEnvelopeNumber != null)
                {
                    body["fuzzy_EnvelopeNumber"] = ExpressionConverter.ConvertO(__workflow_bodyincludeEnvelopeNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeEmailAddress != null)
                {
                    body["fuzzy_EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyincludeEmailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeHomePhone != null)
                {
                    body["fuzzy_HomePhone"] = ExpressionConverter.ConvertO(__workflow_bodyincludeHomePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMobilePhone != null)
                {
                    body["fuzzy_MobilePhone"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeWorkPhone != null)
                {
                    body["fuzzy_WorkPhone"] = ExpressionConverter.ConvertO(__workflow_bodyincludeWorkPhone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MemberSearchResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberSearchResponseDto, ApiConnectionActionConfiguration> MemberDetail(Expression<Func<int>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<MemberSearchResponseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/members/{0}", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberSearchResponseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<SacramentDto[], ApiConnectionActionConfiguration> MemberSacramentList(Expression<Func<int>> memberId, Expression<Func<int>> type)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<SacramentDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/members/{0}/sacrament/{1}/list", __workflow_memberId.WithUrlEncoding(1), __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SacramentDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberStatusListResponseDto[], ApiConnectionActionConfiguration> MemberStatusLookupList()
        {
            return new DeferredBodyAction<MemberStatusListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/memberstatus/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberStatusListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> MemberTypeLookupList()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/membertype/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> MemberWorkGroupLookupList()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/workgroup/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<MemberContactListResponseDto[], ApiConnectionActionConfiguration> MemberContactList(Expression<Func<int>> bodypageSize, Expression<Func<int>> bodypageNumber, Expression<Func<string>> bodymemberFirstName = null, Expression<Func<string>> bodymemberLastName = null, Expression<Func<string>> bodymemberEmailAddress = null, Expression<Func<string>> bodymemberMobilePhone = null, Expression<Func<int[]>> bodyorganizationIdS = null)
        {
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: true);
            var __workflow_bodymemberFirstName = WorkflowExpression.Compile(bodymemberFirstName, nameof(bodymemberFirstName), required: false);
            var __workflow_bodymemberLastName = WorkflowExpression.Compile(bodymemberLastName, nameof(bodymemberLastName), required: false);
            var __workflow_bodymemberEmailAddress = WorkflowExpression.Compile(bodymemberEmailAddress, nameof(bodymemberEmailAddress), required: false);
            var __workflow_bodymemberMobilePhone = WorkflowExpression.Compile(bodymemberMobilePhone, nameof(bodymemberMobilePhone), required: false);
            var __workflow_bodyorganizationIdS = WorkflowExpression.Compile(bodyorganizationIdS, nameof(bodyorganizationIdS), required: false);
            return new DeferredBodyAction<MemberContactListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/contact/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["limit"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                bodypropCount++;
                body["offset"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                if (__workflow_bodymemberFirstName != null)
                {
                    body["memberFirstName"] = ExpressionConverter.ConvertO(__workflow_bodymemberFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodymemberLastName != null)
                {
                    body["memberLastName"] = ExpressionConverter.ConvertO(__workflow_bodymemberLastName);
                    bodypropCount++;
                }

                if (__workflow_bodymemberEmailAddress != null)
                {
                    body["emailAddress"] = ExpressionConverter.ConvertO(__workflow_bodymemberEmailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodymemberMobilePhone != null)
                {
                    body["cellPhone"] = ExpressionConverter.ConvertO(__workflow_bodymemberMobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationIdS != null)
                {
                    body["organizationIDs"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationIdS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MemberContactListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MemberUpdateContact(Expression<Func<int>> memberId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodynickName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydateOfDeath = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyhomePhone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyworkPhone = null, Expression<Func<string>> bodypager = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodygender = null)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodynickName = WorkflowExpression.Compile(bodynickName, nameof(bodynickName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodymaidenName = WorkflowExpression.Compile(bodymaidenName, nameof(bodymaidenName), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodydateOfDeath = WorkflowExpression.Compile(bodydateOfDeath, nameof(bodydateOfDeath), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyhomePhone = WorkflowExpression.Compile(bodyhomePhone, nameof(bodyhomePhone), required: false);
            var __workflow_bodymobilePhone = WorkflowExpression.Compile(bodymobilePhone, nameof(bodymobilePhone), required: false);
            var __workflow_bodyworkPhone = WorkflowExpression.Compile(bodyworkPhone, nameof(bodyworkPhone), required: false);
            var __workflow_bodypager = WorkflowExpression.Compile(bodypager, nameof(bodypager), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/members/{0}/contact", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodynickName != null)
                {
                    body["nickName"] = ExpressionConverter.ConvertO(__workflow_bodynickName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodymaidenName != null)
                {
                    body["maidenName"] = ExpressionConverter.ConvertO(__workflow_bodymaidenName);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["dateOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodydateOfDeath != null)
                {
                    body["dateOfDeath"] = ExpressionConverter.ConvertO(__workflow_bodydateOfDeath);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["emailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyhomePhone != null)
                {
                    body["homePhone"] = ExpressionConverter.ConvertO(__workflow_bodyhomePhone);
                    bodypropCount++;
                }

                if (__workflow_bodymobilePhone != null)
                {
                    body["cellPhone"] = ExpressionConverter.ConvertO(__workflow_bodymobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyworkPhone != null)
                {
                    body["workPhone"] = ExpressionConverter.ConvertO(__workflow_bodyworkPhone);
                    bodypropCount++;
                }

                if (__workflow_bodypager != null)
                {
                    body["pager"] = ExpressionConverter.ConvertO(__workflow_bodypager);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FundListResponseDto[], ApiConnectionActionConfiguration> OfferingFundList(Expression<Func<int>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<FundListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/offering/{0}/funds", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<GiverListResponseDto[], ApiConnectionActionConfiguration> OfferingGiverList(Expression<Func<int>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GiverListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/offering/{0}/givers", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiverListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<FamilyContributionSummaryResponseDto[], ApiConnectionActionConfiguration> OfferingFamilyContributionSearch(Expression<Func<int>> organizationId, Expression<Func<int>> bodypageNumber, Expression<Func<int>> bodypageSize, Expression<Func<int[]>> bodyfamilyIdS = null, Expression<Func<int[]>> bodyfundIdS = null, Expression<Func<int>> bodygroupId = null, Expression<Func<bool>> bodyregisteredFamilies = null, Expression<Func<string>> bodycontributionStartDate = null, Expression<Func<string>> bodycontributionEndDate = null, Expression<Func<double>> bodycontributionLowAmount = null, Expression<Func<double>> bodycontributionHighAmount = null, Expression<Func<double>> bodytotalContributionLowAmount = null, Expression<Func<double>> bodytotalContributionHighAmount = null, Expression<Func<bool>> bodyincludeDeleted = null, Expression<Func<bool>> bodyincludeZeroContributions = null, Expression<Func<bool>> bodyincludeNonGivers = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyfamilyIdS = WorkflowExpression.Compile(bodyfamilyIdS, nameof(bodyfamilyIdS), required: false);
            var __workflow_bodyfundIdS = WorkflowExpression.Compile(bodyfundIdS, nameof(bodyfundIdS), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyregisteredFamilies = WorkflowExpression.Compile(bodyregisteredFamilies, nameof(bodyregisteredFamilies), required: false);
            var __workflow_bodycontributionStartDate = WorkflowExpression.Compile(bodycontributionStartDate, nameof(bodycontributionStartDate), required: false);
            var __workflow_bodycontributionEndDate = WorkflowExpression.Compile(bodycontributionEndDate, nameof(bodycontributionEndDate), required: false);
            var __workflow_bodycontributionLowAmount = WorkflowExpression.Compile(bodycontributionLowAmount, nameof(bodycontributionLowAmount), required: false);
            var __workflow_bodycontributionHighAmount = WorkflowExpression.Compile(bodycontributionHighAmount, nameof(bodycontributionHighAmount), required: false);
            var __workflow_bodytotalContributionLowAmount = WorkflowExpression.Compile(bodytotalContributionLowAmount, nameof(bodytotalContributionLowAmount), required: false);
            var __workflow_bodytotalContributionHighAmount = WorkflowExpression.Compile(bodytotalContributionHighAmount, nameof(bodytotalContributionHighAmount), required: false);
            var __workflow_bodyincludeDeleted = WorkflowExpression.Compile(bodyincludeDeleted, nameof(bodyincludeDeleted), required: false);
            var __workflow_bodyincludeZeroContributions = WorkflowExpression.Compile(bodyincludeZeroContributions, nameof(bodyincludeZeroContributions), required: false);
            var __workflow_bodyincludeNonGivers = WorkflowExpression.Compile(bodyincludeNonGivers, nameof(bodyincludeNonGivers), required: false);
            return new DeferredBodyAction<FamilyContributionSummaryResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/offering/{0}/contribution/summary/list", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startRowIndex"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                bodypropCount++;
                body["maximumRows"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                if (__workflow_bodyfamilyIdS != null)
                {
                    body["familyDUIDs"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyIdS);
                    bodypropCount++;
                }

                if (__workflow_bodyfundIdS != null)
                {
                    body["fundsDUIDs"] = ExpressionConverter.ConvertO(__workflow_bodyfundIdS);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["familyGroupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyregisteredFamilies != null)
                {
                    body["registeredFamilies"] = ExpressionConverter.ConvertO(__workflow_bodyregisteredFamilies);
                    bodypropCount++;
                }

                if (__workflow_bodycontributionStartDate != null)
                {
                    body["postDate_Low"] = ExpressionConverter.ConvertO(__workflow_bodycontributionStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontributionEndDate != null)
                {
                    body["postDate_High"] = ExpressionConverter.ConvertO(__workflow_bodycontributionEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontributionLowAmount != null)
                {
                    body["amount_Low"] = ExpressionConverter.ConvertO(__workflow_bodycontributionLowAmount);
                    bodypropCount++;
                }

                if (__workflow_bodycontributionHighAmount != null)
                {
                    body["amount_High"] = ExpressionConverter.ConvertO(__workflow_bodycontributionHighAmount);
                    bodypropCount++;
                }

                if (__workflow_bodytotalContributionLowAmount != null)
                {
                    body["totalAmount_Low"] = ExpressionConverter.ConvertO(__workflow_bodytotalContributionLowAmount);
                    bodypropCount++;
                }

                if (__workflow_bodytotalContributionHighAmount != null)
                {
                    body["totalAmount_High"] = ExpressionConverter.ConvertO(__workflow_bodytotalContributionHighAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeDeleted != null)
                {
                    body["familyDeleted"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDeleted);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeZeroContributions != null)
                {
                    body["includeZeroDollarContributions"] = ExpressionConverter.ConvertO(__workflow_bodyincludeZeroContributions);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeNonGivers != null)
                {
                    body["includeNonGivers"] = ExpressionConverter.ConvertO(__workflow_bodyincludeNonGivers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FamilyContributionSummaryResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto[], ApiConnectionActionConfiguration> OrganizationSearch(Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodyorganizationTypeList = null, Expression<Func<string>> bodyvicariate = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyorganizationTypeList = WorkflowExpression.Compile(bodyorganizationTypeList, nameof(bodyorganizationTypeList), required: false);
            var __workflow_bodyvicariate = WorkflowExpression.Compile(bodyvicariate, nameof(bodyvicariate), required: false);
            return new DeferredBodyAction<OrganizationDetailResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/organizations/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationTypeList != null)
                {
                    body["types"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationTypeList);
                    bodypropCount++;
                }

                if (__workflow_bodyvicariate != null)
                {
                    body["vicariate"] = ExpressionConverter.ConvertO(__workflow_bodyvicariate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OrganizationDetailResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto, ApiConnectionActionConfiguration> OrganizationDetail(Expression<Func<int>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<OrganizationDetailResponseDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/organizations/{0}", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganizationDetailResponseDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Test()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/test";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
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