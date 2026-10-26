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
        public IBodyWorkflowAction<FamilySearchResponseDto[], ApiConnectionActionConfiguration> FamilySearch(Expression<Func<FamilySearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FamilySearchResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/families/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FamilyUpdateContactInfo(Expression<Func<int>> familyId, Expression<Func<FamilyUpdateContactInfoInput>> body = null)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/contact", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FamilyUpdateAutoFill(Expression<Func<int>> familyId, Expression<Func<FamilyUpdateAutoFillInput>> body)
        {
            var __workflow_familyId = WorkflowExpression.Compile(familyId, nameof(familyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/families/{0}/autofill", __workflow_familyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<MemberSearchResponseDto[], ApiConnectionActionConfiguration> MemberSearch(Expression<Func<MemberSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MemberSearchResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<MemberContactListResponseDto[], ApiConnectionActionConfiguration> MemberContactList(Expression<Func<MemberContactListInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MemberContactListResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/members/contact/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MemberContactListResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MemberUpdateContact(Expression<Func<int>> memberId, Expression<Func<MemberUpdateContactInput>> body)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/members/{0}/contact", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<FamilyContributionSummaryResponseDto[], ApiConnectionActionConfiguration> OfferingFamilyContributionSearch(Expression<Func<int>> organizationId, Expression<Func<OfferingFamilyContributionSearchInput>> body)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FamilyContributionSummaryResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/offering/{0}/contribution/summary/list", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FamilyContributionSummaryResponseDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parishsoftfamilysuit")]
        public IBodyWorkflowAction<OrganizationDetailResponseDto[], ApiConnectionActionConfiguration> OrganizationSearch(Expression<Func<OrganizationSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrganizationDetailResponseDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/organizations/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class FamilySearchInput
    {
        [JsonProperty("pageNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; } = 1;

        [JsonProperty("pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; } = 100;

        [JsonProperty("familyID")]
        public int? FamilyId { get; set; }

        [JsonProperty("familyDUID")]
        public int? DioceseId { get; set; }

        [JsonProperty("memberShipStatus")]
        public bool? MembershipStatus { get; set; }

        [JsonProperty("familyGroupID")]
        public int? FamilyGroupId { get; set; }

        [JsonProperty("organizationIDs")]
        public int[] Organizations { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("hasEmail")]
        public bool? HasAFamilyEmailAddress { get; set; }

        [JsonProperty("envelopes")]
        public bool? SendContributionEnvelopes { get; set; }

        [JsonProperty("registrationDateFrom")]
        public string RegistrationStart { get; set; }

        [JsonProperty("registrationDateTo")]
        public string RegistrationEnd { get; set; }

        [JsonProperty("address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("sendNoMail")]
        public bool? SendNoMail { get; set; }

        [JsonProperty("doNotPublish")]
        public bool? DoNotPublish { get; set; }

        [JsonProperty("familiesWithEmail")]
        public bool? HasEmail { get; set; }

        [JsonProperty("familyGroupName")]
        public string FamilyGroupName { get; set; }

        [JsonProperty("envelopeNumber")]
        public string EnvelopeNumber { get; set; }

        [JsonProperty("phone")]
        public string PrimaryAddressPhoneNumber { get; set; }

        [JsonProperty("eMailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("registeredOrganizationID")]
        public int? RegisteredOrganizationId { get; set; }

        [JsonProperty("dateModified")]
        public string LastModified { get; set; }
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

    public class FamilyUpdateContactInfoInput
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("mailingName")]
        public string MailingName { get; set; }

        [JsonProperty("informalMailingName")]
        public string InformalMailingName { get; set; }

        [JsonProperty("formalSalutation")]
        public string FormalSalutation { get; set; }

        [JsonProperty("informalSalutation")]
        public string InformalSalutation { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("primaryPhone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty("emergencyPhone")]
        public string EmergencyPhone { get; set; }

        [JsonProperty("primaryAddress")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("homeAddressLine1")]
        public string HomeStreetAddress { get; set; }

        [JsonProperty("homeAddressLine2")]
        public string HomeStreetAddress2 { get; set; }

        [JsonProperty("homeCity")]
        public string HomeAddressCity { get; set; }

        [JsonProperty("homeState")]
        public string HomeAddressState { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeAddressCountry { get; set; }

        [JsonProperty("homePostalCode")]
        public string HomeAddressPostalCode { get; set; }

        [JsonProperty("homePostalCodePlus4")]
        public string HomeAddressPostalCodeExtension { get; set; }

        [JsonProperty("homeAddressPhone")]
        public string HomeAddressPhone { get; set; }

        [JsonProperty("mailingAddressLine1")]
        public string MailingStreetAddress { get; set; }

        [JsonProperty("mailingAddressLine2")]
        public string MailingStreetAddress2 { get; set; }

        [JsonProperty("mailingCity")]
        public string MailingAddressCity { get; set; }

        [JsonProperty("mailingState")]
        public string MailingAddressState { get; set; }

        [JsonProperty("mailingCountry")]
        public string MailingAddressCountry { get; set; }

        [JsonProperty("mailingPostalCode")]
        public string MailingAddressPostalCode { get; set; }

        [JsonProperty("mailingPostalCodePlus4")]
        public string MailingAddressPostalCodeExtension { get; set; }

        [JsonProperty("mailingAddressPhone")]
        public string MailingAddressPhone { get; set; }

        [JsonProperty("otherAddressLine1")]
        public string OtherStreetAddress { get; set; }

        [JsonProperty("otherAddressLine2")]
        public string OtherStreetAddress2 { get; set; }

        [JsonProperty("otherCity")]
        public string OtherAddressCity { get; set; }

        [JsonProperty("otherState")]
        public string OtherAddressState { get; set; }

        [JsonProperty("otherCountry")]
        public string OtherAddressCountry { get; set; }

        [JsonProperty("otherPostalCode")]
        public string OtherAddressPostalCode { get; set; }

        [JsonProperty("otherPostalCodePlus4")]
        public string OtherAddressPostalCodeExtension { get; set; }

        [JsonProperty("otherAddressPhone")]
        public string OtherAddressPhone { get; set; }

        [JsonProperty("otherAddressFromDate")]
        public string OtherAddressFromDate { get; set; }

        [JsonProperty("otherAddressToDate")]
        public string OtherAddressToDate { get; set; }

        [JsonProperty("sdiocesanId")]
        public string SDiocesanId { get; set; }
    }

    public class FamilyUpdateAutoFillInput
    {
        [JsonProperty("organizationID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int OrganizationId { get; set; }
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

    public class MemberSearchInput
    {
        [JsonProperty("startRowIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; } = 0;

        [JsonProperty("maximumRows", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; } = 100;

        [JsonProperty("fuzzy_SearchText")]
        public string SearchText { get; set; }

        [JsonProperty("showDeletedMembers")]
        public bool? IncludeDeletedMembers { get; set; }

        [JsonProperty("organizationIDs")]
        public int[] OrganizationIdS { get; set; }

        [JsonProperty("filter_MemberAgeRange_From")]
        public int? MemberAgeFrom { get; set; }

        [JsonProperty("filter_MemberAgeRange_To")]
        public int? MemberAgeTo { get; set; }

        [JsonProperty("filter_DateModified")]
        public string LastModified { get; set; }

        [JsonProperty("filter_FamilyRegistrationStatus")]
        public int? FamilyRegistrationStatus { get; set; }

        [JsonProperty("filter_MemberStatus")]
        public string MemberStatusName { get; set; }

        [JsonProperty("searchByContains")]
        public int? SearchByContains { get; set; }

        [JsonProperty("fuzzy_FamilyDUID")]
        public bool? IncludeFamilyDioceseId { get; set; }

        [JsonProperty("fuzzy_MemberDUID")]
        public bool? IncludeMemberDioceseId { get; set; }

        [JsonProperty("fuzzy_FamilyLastName")]
        public bool? IncludeFamilyLastName { get; set; }

        [JsonProperty("fuzzy_FamilyAddress_PrimaryAddressFull")]
        public bool? IncludeFamilyAddress { get; set; }

        [JsonProperty("fuzzy_FamilyAddress_PrimaryCity")]
        public bool? IncludeFamilyAddressCity { get; set; }

        [JsonProperty("fuzzy_FamilyAddress_PrimaryState")]
        public bool? IncludeFamilyAddressState { get; set; }

        [JsonProperty("fuzzy_FamilyAddress_PrimaryPostalCode")]
        public bool? IncludeFamilyAddressPostalCode { get; set; }

        [JsonProperty("fuzzy_FamilyAddres_PrimaryZipPlus")]
        public bool? IncludeFamilyAddressZipPlus { get; set; }

        [JsonProperty("fuzzy_Display_MemberName")]
        public bool? IncludeMemberName { get; set; }

        [JsonProperty("fuzzy_MemberType")]
        public bool? IncludeMemberType { get; set; }

        [JsonProperty("fuzzy_Sex")]
        public bool? IncludeMemberGender { get; set; }

        [JsonProperty("fuzzy_Age")]
        public bool? IncludeMemberAge { get; set; }

        [JsonProperty("fuzzy_EnvelopeNumber")]
        public bool? IncludeEnvelopeNumber { get; set; }

        [JsonProperty("fuzzy_EmailAddress")]
        public bool? IncludeEmailAddress { get; set; }

        [JsonProperty("fuzzy_HomePhone")]
        public bool? IncludeHomePhone { get; set; }

        [JsonProperty("fuzzy_MobilePhone")]
        public bool? IncludeMobilePhone { get; set; }

        [JsonProperty("fuzzy_WorkPhone")]
        public bool? IncludeWorkPhone { get; set; }
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

    public class MemberContactListInput
    {
        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; } = 100;

        [JsonProperty("offset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; } = 0;

        [JsonProperty("memberFirstName")]
        public string MemberFirstName { get; set; }

        [JsonProperty("memberLastName")]
        public string MemberLastName { get; set; }

        [JsonProperty("emailAddress")]
        public string MemberEmailAddress { get; set; }

        [JsonProperty("cellPhone")]
        public string MemberMobilePhone { get; set; }

        [JsonProperty("organizationIDs")]
        public int[] OrganizationIdS { get; set; }
    }

    public class MemberUpdateContactInput
    {
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

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("cellPhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
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

    public class OfferingFamilyContributionSearchInput
    {
        [JsonProperty("startRowIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; } = 0;

        [JsonProperty("maximumRows", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; } = 100;

        [JsonProperty("familyDUIDs")]
        public int[] FamilyIdS { get; set; }

        [JsonProperty("fundsDUIDs")]
        public int[] FundIdS { get; set; }

        [JsonProperty("familyGroupId")]
        public int? GroupId { get; set; }

        [JsonProperty("registeredFamilies")]
        public bool? RegisteredFamilies { get; set; }

        [JsonProperty("postDate_Low")]
        public string ContributionStartDate { get; set; }

        [JsonProperty("postDate_High")]
        public string ContributionEndDate { get; set; }

        [JsonProperty("amount_Low")]
        public double? ContributionLowAmount { get; set; }

        [JsonProperty("amount_High")]
        public double? ContributionHighAmount { get; set; }

        [JsonProperty("totalAmount_Low")]
        public double? TotalContributionLowAmount { get; set; }

        [JsonProperty("totalAmount_High")]
        public double? TotalContributionHighAmount { get; set; }

        [JsonProperty("familyDeleted")]
        public bool? IncludeDeleted { get; set; }

        [JsonProperty("includeZeroDollarContributions")]
        public bool? IncludeZeroContributions { get; set; }

        [JsonProperty("includeNonGivers")]
        public bool? IncludeNonGivers { get; set; }
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

    public class OrganizationSearchInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("types")]
        public string[] OrganizationTypeList { get; set; }

        [JsonProperty("vicariate")]
        public string Vicariate { get; set; }
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