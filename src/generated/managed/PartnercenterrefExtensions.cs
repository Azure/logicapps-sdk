//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercenterrefActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<GetAllReferralsResponse, ApiConnectionActionConfiguration> GetAllReferrals(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<GetAllReferralsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<GetAllReferralsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> CreateReferral(Expression<Func<ReferralInput>> referral, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> GetReferralById(Expression<Func<string>> id, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> UpdateReferralById(Expression<Func<string>> id, Expression<Func<ODataReferralInput>> oDataReferral, Expression<Func<string>> ifMatch, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_oDataReferral = WorkflowExpression.Compile(oDataReferral, nameof(oDataReferral), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["if-match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_oDataReferral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> PatchReferralById(Expression<Func<string>> id, Expression<Func<PatchReferralByIdReferralInputItem[]>> referral, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> CreateDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<CreateDealRegistrationByReferralIdReferralInputItem[]>> referral, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> PatchDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<PatchDealRegistrationByReferralIdReferralInputItem[]>> referral, Expression<Func<string>> msCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_msCorrelationId = WorkflowExpression.Compile(msCorrelationId, nameof(msCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}//", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_msCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_msCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }
    }

    public class PartnercenterrefTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllReferralsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3Referral[] Value { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3Referral
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsType Details { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inviteContext")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }

        [JsonProperty("referralProgram")]
        public string ReferralProgram { get; set; }

        [JsonProperty("salesStage")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralSalesStageType SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItem[] Registrations { get; set; }

        [JsonProperty("registrationStatus")]
        public string RegistrationStatus { get; set; }

        [JsonProperty("callToAction")]
        public string CallToAction { get; set; }

        [JsonProperty("referralSource")]
        public string ReferralSource { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("isSpam")]
        public bool IsSpam { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralConsentType
    {
        [JsonProperty("consentToContact")]
        public bool ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileType
    {
        [JsonProperty("address")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsType
    {
        [JsonProperty("closingDateTime")]
        public string ClosingDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customerAction")]
        public string CustomerAction { get; set; }

        [JsonProperty("customerRequestedContact")]
        public bool CustomerRequestedContact { get; set; }

        [JsonProperty("dealValue")]
        public double DealValue { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("requirements")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeAssistanceRequestCodeType AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksType
    {
        [JsonProperty("relatedReferrals")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeSelfType Self { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MicrosoftPartnerServicePartnerReferralsContractsV3ReferralSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemContractType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class ReferralInput
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public ReferralInputConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public ReferralInputCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public ReferralInputDetailsType Details { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("favorite")]
        public bool? Favorite { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inviteContext")]
        public ReferralInputInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public ReferralInputLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }

        [JsonProperty("referralProgram")]
        public string ReferralProgram { get; set; }

        [JsonProperty("salesStage")]
        public ReferralInputSalesStageType? SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public ReferralInputTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public ReferralInputTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public ReferralInputTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public ReferralInputRegistrationsTypeItem[] Registrations { get; set; }

        [JsonProperty("registrationStatus")]
        public string RegistrationStatus { get; set; }

        [JsonProperty("callToAction")]
        public string CallToAction { get; set; }

        [JsonProperty("referralSource")]
        public string ReferralSource { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("isSpam")]
        public bool? IsSpam { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("tags")]
        public ReferralInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class ReferralInputConsentType
    {
        [JsonProperty("consentToContact")]
        public bool? ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool? ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool? ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class ReferralInputCustomerProfileType
    {
        [JsonProperty("address")]
        public ReferralInputCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public ReferralInputCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class ReferralInputCustomerProfileTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class ReferralInputCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public ReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class ReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ReferralInputDetailsType
    {
        [JsonProperty("closingDateTime")]
        public string ClosingDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customerAction")]
        public string CustomerAction { get; set; }

        [JsonProperty("customerRequestedContact")]
        public bool? CustomerRequestedContact { get; set; }

        [JsonProperty("dealValue")]
        public double? DealValue { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("requirements")]
        public ReferralInputDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class ReferralInputDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public ReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public ReferralInputDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public ReferralInputDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class ReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReferralInputDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReferralInputDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReferralInputInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public ReferralInputInviteContextTypeAssistanceRequestCodeType? AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public ReferralInputInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class ReferralInputInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class ReferralInputLinksType
    {
        [JsonProperty("relatedReferrals")]
        public ReferralInputLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public ReferralInputLinksTypeSelfType Self { get; set; }
    }

    public class ReferralInputLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ReferralInputLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class ReferralInputTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReferralInputTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public ReferralInputTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class ReferralInputTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ReferralInputTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class ReferralInputRegistrationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public ReferralInputRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public ReferralInputRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public ReferralInputRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class ReferralInputRegistrationsTypeItemContractType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class ReferralInputRegistrationsTypeItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool? IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public ReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class ReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool? IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class ReferralInputRegistrationsTypeItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class ReferralInputTagsTypeItem
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class ODataReferralInput
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public ODataReferralInputConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public ODataReferralInputCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public ODataReferralInputDetailsType Details { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("favorite")]
        public bool? Favorite { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inviteContext")]
        public ODataReferralInputInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public ODataReferralInputLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }

        [JsonProperty("referralProgram")]
        public string ReferralProgram { get; set; }

        [JsonProperty("salesStage")]
        public ODataReferralInputSalesStageType? SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public ODataReferralInputTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public ODataReferralInputTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public ODataReferralInputTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public ODataReferralInputRegistrationsTypeItem[] Registrations { get; set; }

        [JsonProperty("registrationStatus")]
        public string RegistrationStatus { get; set; }

        [JsonProperty("callToAction")]
        public string CallToAction { get; set; }

        [JsonProperty("referralSource")]
        public string ReferralSource { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("isSpam")]
        public bool? IsSpam { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("tags")]
        public ODataReferralInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class ODataReferralInputConsentType
    {
        [JsonProperty("consentToContact")]
        public bool? ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool? ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool? ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class ODataReferralInputCustomerProfileType
    {
        [JsonProperty("address")]
        public ODataReferralInputCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public ODataReferralInputCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class ODataReferralInputCustomerProfileTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class ODataReferralInputCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public ODataReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class ODataReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ODataReferralInputDetailsType
    {
        [JsonProperty("closingDateTime")]
        public string ClosingDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customerAction")]
        public string CustomerAction { get; set; }

        [JsonProperty("customerRequestedContact")]
        public bool? CustomerRequestedContact { get; set; }

        [JsonProperty("dealValue")]
        public double? DealValue { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("requirements")]
        public ODataReferralInputDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class ODataReferralInputDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public ODataReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public ODataReferralInputDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public ODataReferralInputDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class ODataReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ODataReferralInputDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ODataReferralInputDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ODataReferralInputInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public ODataReferralInputInviteContextTypeAssistanceRequestCodeType? AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public ODataReferralInputInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ODataReferralInputInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class ODataReferralInputInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class ODataReferralInputLinksType
    {
        [JsonProperty("relatedReferrals")]
        public ODataReferralInputLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public ODataReferralInputLinksTypeSelfType Self { get; set; }
    }

    public class ODataReferralInputLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ODataReferralInputLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ODataReferralInputSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class ODataReferralInputTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ODataReferralInputTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public ODataReferralInputTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class ODataReferralInputTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ODataReferralInputTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class ODataReferralInputRegistrationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public ODataReferralInputRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public ODataReferralInputRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public ODataReferralInputRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class ODataReferralInputRegistrationsTypeItemContractType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class ODataReferralInputRegistrationsTypeItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool? IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public ODataReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class ODataReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool? IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class ODataReferralInputRegistrationsTypeItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class ODataReferralInputTagsTypeItem
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PatchReferralByIdReferralInputItem
    {
        [JsonProperty("op", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemUpdateOperationType? UpdateOperation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref.ReferralInputItemUpdateOperationType.Replace;

        [JsonProperty("path")]
        public PatchReferralByIdReferralInputItemFieldPathType? FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemUpdateOperationType
    {
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PatchReferralByIdReferralInputItemFieldPathType
    {
        [EnumMember(Value = "/campaignId")]
        CampaignId,
        [EnumMember(Value = "/consent/consentToShareReferralWithMicrosoftSellers")]
        ConsentConsentToShareReferralWithMicrosoftSellers,
        [EnumMember(Value = "/customerProfile/team")]
        CustomerProfileTeam,
        [EnumMember(Value = "/customerProfile/team/-")]
        CustomerProfileTeam2,
        [EnumMember(Value = "/details/closingDateTime")]
        DetailsClosingDateTime,
        [EnumMember(Value = "/details/currency")]
        DetailsCurrency,
        [EnumMember(Value = "/details/dealValue")]
        DetailsDealValue,
        [EnumMember(Value = "/details/notes")]
        DetailsNotes,
        [EnumMember(Value = "/details/requirements/solutions")]
        DetailsRequirementsSolutions,
        [EnumMember(Value = "/details/requirements/solutions/-")]
        DetailsRequirementsSolutions2,
        [EnumMember(Value = "/details/requirements/additionalRequirements")]
        DetailsRequirementsAdditionalRequirements,
        [EnumMember(Value = "/details/requirements/additionalRequirements/attributes")]
        DetailsRequirementsAdditionalRequirementsAttributes,
        [EnumMember(Value = "/details/requirements/additionalRequirements/attributes/-")]
        DetailsRequirementsAdditionalRequirementsAttributes2,
        [EnumMember(Value = "/externalReferenceId")]
        ExternalReferenceId,
        [EnumMember(Value = "/referralProgram")]
        ReferralProgram,
        [EnumMember(Value = "/salesStage")]
        SalesStage,
        [EnumMember(Value = "/status")]
        Status,
        [EnumMember(Value = "/substatus")]
        Substatus,
        [EnumMember(Value = "/statusReason")]
        StatusReason,
        [EnumMember(Value = "/team")]
        Team,
        [EnumMember(Value = "/team/-")]
        Team2
    }

    public class CreateDealRegistrationByReferralIdReferralInputItem
    {
        [JsonProperty("op", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemOpType? Op { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref.ReferralInputItemOpType.Add;

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemPathType? Path { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref.ReferralInputItemPathType.Registrations;

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemValueType Value { get; set; } = new ReferralInputItemValueType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemPathType
    {
        [EnumMember(Value = "/registrations/-")]
        Registrations
    }

    public class ReferralInputItemValueType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemValueTypeTypeType? Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref.ReferralInputItemValueTypeTypeType.AzureIPCoSell;

        [JsonProperty("solutionDetails")]
        public ReferralInputItemValueTypeSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("contract")]
        public ReferralInputItemValueTypeContractType Contract { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemValueTypeTypeType
    {
        AzureIPCoSell
    }

    public class ReferralInputItemValueTypeSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool? IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public ReferralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType? PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public ReferralInputItemValueTypeSolutionDetailsTypeItemPricingModelType? PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public ReferralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType
    {
        Customer,
        Partner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemValueTypeSolutionDetailsTypeItemPricingModelType
    {
        PayAsYouGo,
        Other
    }

    public class ReferralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool? IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class ReferralInputItemValueTypeContractType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("term")]
        public ReferralInputItemValueTypeContractTypeTermType? Term { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReferralInputItemValueTypeContractTypeTermType
    {
        Perpetual,
        Finite
    }

    public class PatchDealRegistrationByReferralIdReferralInputItem
    {
        [JsonProperty("op", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReferralInputItemUpdateOperationType? UpdateOperation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref.ReferralInputItemUpdateOperationType.Replace;

        [JsonProperty("path")]
        public PatchDealRegistrationByReferralIdReferralInputItemFieldPathType? FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PatchDealRegistrationByReferralIdReferralInputItemFieldPathType
    {
        [EnumMember(Value = "/registrations/0/contract/startDateTime")]
        Registrations0ContractStartDateTime,
        [EnumMember(Value = "/registrations/0/contract/endDateTime")]
        Registrations0ContractEndDateTime,
        [EnumMember(Value = "/registrations/0/contract/signDateTime")]
        Registrations0ContractSignDateTime,
        [EnumMember(Value = "/registrations/0/contract/term")]
        Registrations0ContractTerm,
        [EnumMember(Value = "/registrations/0/contract/value")]
        Registrations0ContractValue,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/value")]
        Registrations0SolutionDetails0Value,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/currency")]
        Registrations0SolutionDetails0Currency,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/isDeployedOnAzure")]
        Registrations0SolutionDetails0IsDeployedOnAzure,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/primaryDeploymentOn")]
        Registrations0SolutionDetails0PrimaryDeploymentOn,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/pricingModel")]
        Registrations0SolutionDetails0PricingModel,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/marketplaceTransactionDetails/isMarketplaceTransacted")]
        Registrations0SolutionDetails0MarketplaceTransactionDetailsIsMarketplaceTransacted,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/marketplaceTransactionDetails/marketplaceTransactionDateTime")]
        Registrations0SolutionDetails0MarketplaceTransactionDetailsMarketplaceTransactionDateTime
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref;

    public partial class WorkflowManagedActions
    {
        public PartnercenterrefActions Partnercenterref(string connectionId) => new PartnercenterrefActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PartnercenterrefTriggers Partnercenterref(string connectionId) => new PartnercenterrefTriggers(connectionId);
    }
}