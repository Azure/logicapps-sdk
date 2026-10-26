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
        public IBodyWorkflowAction<GetAllReferralsResponse, ApiConnectionActionConfiguration> GetAllReferrals(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
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
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<GetAllReferralsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> CreateReferral(Expression<Func<CreateReferralInput>> referral, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> GetReferralById(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> UpdateReferralById(Expression<Func<string>> id, Expression<Func<UpdateReferralByIdInput>> odataReferral, Expression<Func<string>> ifMatch, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_odataReferral = WorkflowExpression.Compile(odataReferral, nameof(odataReferral), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["if-match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_odataReferral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> PatchReferralById(Expression<Func<string>> id, Expression<Func<referralInputItem[]>> referral, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> CreateDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<referralInputItem2[]>> referral, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration> PatchDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<referralInputItem22[]>> referral, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/referrals/{0}//", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
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

    public class CreateReferralInput
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public CreateReferralInputConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public CreateReferralInputCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public CreateReferralInputDetailsType Details { get; set; }

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
        public CreateReferralInputInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public CreateReferralInputLinksType Links { get; set; }

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
        public CreateReferralInputSalesStageType? SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public CreateReferralInputTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public CreateReferralInputTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public CreateReferralInputTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public CreateReferralInputRegistrationsTypeItem[] Registrations { get; set; }

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
        public CreateReferralInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class CreateReferralInputConsentType
    {
        [JsonProperty("consentToContact")]
        public bool? ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool? ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool? ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class CreateReferralInputCustomerProfileType
    {
        [JsonProperty("address")]
        public CreateReferralInputCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public CreateReferralInputCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class CreateReferralInputCustomerProfileTypeAddressType
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

    public class CreateReferralInputCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public CreateReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class CreateReferralInputCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class CreateReferralInputDetailsType
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
        public CreateReferralInputDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class CreateReferralInputDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public CreateReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public CreateReferralInputDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public CreateReferralInputDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class CreateReferralInputDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateReferralInputDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateReferralInputDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateReferralInputInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public CreateReferralInputInviteContextTypeAssistanceRequestCodeType? AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public CreateReferralInputInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateReferralInputInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class CreateReferralInputInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class CreateReferralInputLinksType
    {
        [JsonProperty("relatedReferrals")]
        public CreateReferralInputLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public CreateReferralInputLinksTypeSelfType Self { get; set; }
    }

    public class CreateReferralInputLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CreateReferralInputLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateReferralInputSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class CreateReferralInputTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateReferralInputTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public CreateReferralInputTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class CreateReferralInputTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class CreateReferralInputTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class CreateReferralInputRegistrationsTypeItem
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
        public CreateReferralInputRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public CreateReferralInputRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public CreateReferralInputRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class CreateReferralInputRegistrationsTypeItemContractType
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

    public class CreateReferralInputRegistrationsTypeItemSolutionDetailsTypeItem
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
        public CreateReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class CreateReferralInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool? IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class CreateReferralInputRegistrationsTypeItemStatusHistoryType
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

    public class CreateReferralInputTagsTypeItem
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class UpdateReferralByIdInput
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public UpdateReferralByIdInputConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public UpdateReferralByIdInputCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public UpdateReferralByIdInputDetailsType Details { get; set; }

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
        public UpdateReferralByIdInputInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public UpdateReferralByIdInputLinksType Links { get; set; }

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
        public UpdateReferralByIdInputSalesStageType? SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public UpdateReferralByIdInputTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public UpdateReferralByIdInputTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public UpdateReferralByIdInputTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public UpdateReferralByIdInputRegistrationsTypeItem[] Registrations { get; set; }

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
        public UpdateReferralByIdInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class UpdateReferralByIdInputConsentType
    {
        [JsonProperty("consentToContact")]
        public bool? ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool? ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool? ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class UpdateReferralByIdInputCustomerProfileType
    {
        [JsonProperty("address")]
        public UpdateReferralByIdInputCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public UpdateReferralByIdInputCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class UpdateReferralByIdInputCustomerProfileTypeAddressType
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

    public class UpdateReferralByIdInputCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public UpdateReferralByIdInputCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class UpdateReferralByIdInputCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class UpdateReferralByIdInputDetailsType
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
        public UpdateReferralByIdInputDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class UpdateReferralByIdInputDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public UpdateReferralByIdInputDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public UpdateReferralByIdInputDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public UpdateReferralByIdInputDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class UpdateReferralByIdInputDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateReferralByIdInputDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateReferralByIdInputDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateReferralByIdInputInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public UpdateReferralByIdInputInviteContextTypeAssistanceRequestCodeType? AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public UpdateReferralByIdInputInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateReferralByIdInputInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class UpdateReferralByIdInputInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class UpdateReferralByIdInputLinksType
    {
        [JsonProperty("relatedReferrals")]
        public UpdateReferralByIdInputLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public UpdateReferralByIdInputLinksTypeSelfType Self { get; set; }
    }

    public class UpdateReferralByIdInputLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UpdateReferralByIdInputLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateReferralByIdInputSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class UpdateReferralByIdInputTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateReferralByIdInputTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public UpdateReferralByIdInputTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class UpdateReferralByIdInputTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool? DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class UpdateReferralByIdInputTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class UpdateReferralByIdInputRegistrationsTypeItem
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
        public UpdateReferralByIdInputRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public UpdateReferralByIdInputRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public UpdateReferralByIdInputRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class UpdateReferralByIdInputRegistrationsTypeItemContractType
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

    public class UpdateReferralByIdInputRegistrationsTypeItemSolutionDetailsTypeItem
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
        public UpdateReferralByIdInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class UpdateReferralByIdInputRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool? IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class UpdateReferralByIdInputRegistrationsTypeItemStatusHistoryType
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

    public class UpdateReferralByIdInputTagsTypeItem
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class referralInputItem
    {
        [JsonProperty("op")]
        public referralInputItemUpdateOperationType UpdateOperation { get; set; }

        [JsonProperty("path")]
        public referralInputItemFieldPathType FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemUpdateOperationType
    {
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemFieldPathType
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

    public class referralInputItem2
    {
        [JsonProperty("op")]
        public referralInputItemOpType Op { get; set; }

        [JsonProperty("path")]
        public referralInputItemPathType Path { get; set; }

        [JsonProperty("value")]
        public referralInputItemValueType Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemPathType
    {
        [EnumMember(Value = "/registrations/-")]
        Registrations
    }

    public class referralInputItemValueType
    {
        [JsonProperty("type")]
        public referralInputItemValueTypeTypeType Type { get; set; }

        [JsonProperty("solutionDetails")]
        public referralInputItemValueTypeSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("contract")]
        public referralInputItemValueTypeContractType Contract { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemValueTypeTypeType
    {
        AzureIPCoSell
    }

    public class referralInputItemValueTypeSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public referralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public referralInputItemValueTypeSolutionDetailsTypeItemPricingModelType PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public referralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType
    {
        Customer,
        Partner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemValueTypeSolutionDetailsTypeItemPricingModelType
    {
        PayAsYouGo,
        Other
    }

    public class referralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class referralInputItemValueTypeContractType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("term")]
        public referralInputItemValueTypeContractTypeTermType Term { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemValueTypeContractTypeTermType
    {
        Perpetual,
        Finite
    }

    public class referralInputItem22
    {
        [JsonProperty("op")]
        public referralInputItemUpdateOperationType UpdateOperation { get; set; }

        [JsonProperty("path")]
        public referralInputItemFieldPathType FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
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