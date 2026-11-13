//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kyndrylmainframe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KyndrylmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<GetPolicyResponse200, ApiConnectionActionConfiguration> GetPolicy(Expression<Func<string>> customernumber)
        {
            var __workflow_customernumber = WorkflowExpression.Compile(customernumber, nameof(customernumber), required: true);
            return new DeferredBodyAction<GetPolicyResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cb12-policy/getpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CUSTOMERNUMBER"] = ExpressionConverter.Convert(__workflow_customernumber);
                return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200, ApiConnectionActionConfiguration> PostCustomerDetailsupd(Expression<Func<PostCustomerdetailsupdRequestInput>> postCustomerdetailsupdRequest)
        {
            var __workflow_postCustomerdetailsupdRequest = WorkflowExpression.Compile(postCustomerdetailsupdRequest, nameof(postCustomerdetailsupdRequest), required: true);
            return new DeferredBodyAction<PostCustomerdetailsupdResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customernumber/Custdetailadd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequest);
                return new ApiConnectionAction<PostCustomerdetailsupdResponse200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PutCustomerdetailResponse200, ApiConnectionActionConfiguration> PutCustomerDetail(Expression<Func<string>> num, Expression<Func<string>> firstname, Expression<Func<BodyInput>> body)
        {
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: true);
            var __workflow_firstname = WorkflowExpression.Compile(firstname, nameof(firstname), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PutCustomerdetailResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customernumber/Custdetailupd/{0}/{1}", __workflow_num.WithUrlEncoding(1), __workflow_firstname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutCustomerdetailResponse200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<GetCustomerDetailResponse, ApiConnectionActionConfiguration> GetCustomerDetail(Expression<Func<string>> num)
        {
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: true);
            return new DeferredBodyAction<GetCustomerDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customernumber/custnum/{0}", __workflow_num.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCustomerDetailResponse>(callPayload);
            });
        }
    }

    public class KyndrylmainframeTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetPolicyResponse200
    {
        public int Affected { get; set; }
        public int TotRecs { get; set; }
        public int Skipped { get; set; }
        public int NumRecs { get; set; }
        public int NumFields { get; set; }
        public GetPolicyResponse200RecordsTypeItem[] Records { get; set; }
        public int Result { get; set; }
    }

    public class GetPolicyResponse200RecordsTypeItem
    {
        [JsonProperty("COMMISSION")]
        public double Commission { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("ISSUEDATE")]
        public string Issuedate { get; set; }

        [JsonProperty("POLICYNUMBER")]
        public string Policynumber { get; set; }

        [JsonProperty("POLICYTYPE")]
        public string Policytype { get; set; }

        [JsonProperty("BROKERID")]
        public string Brokerid { get; set; }

        [JsonProperty("LASTCHANGED")]
        public string Lastchanged { get; set; }

        [JsonProperty("EXPIRYDATE")]
        public string Expirydate { get; set; }

        [JsonProperty("CUSTOMERNUMBER")]
        public string Customernumber { get; set; }

        [JsonProperty("BROKERSREFERENCE")]
        public string Brokersreference { get; set; }
    }

    public class PostCustomerdetailsupdResponse200
    {
        [JsonProperty("LGCMAREA")]
        public PostCustomerdetailsupdResponse200LgcmareaType Lgcmarea { get; set; }
    }

    public class PostCustomerdetailsupdResponse200LgcmareaType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int CaReturnCode { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CaCustomerNum { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PostCustomerdetailsupdResponse200LgcmareaTypeCaCustomerRequestType CaCustomerRequest { get; set; }
    }

    public class PostCustomerdetailsupdResponse200LgcmareaTypeCaCustomerRequestType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CaFirstName { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CaLastName { get; set; }

        [JsonProperty("CA_DOB")]
        public string CaDob { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CaHouseName { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CaHouseNum { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CaPostcode { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CaNumPolicies { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CaPhoneMobile { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CaPhoneHome { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CaEmailAddress { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CaPolicyData { get; set; }
    }

    public class PostCustomerdetailsupdRequestInput
    {
        [JsonProperty("LGCMAREA")]
        public PostCustomerdetailsupdRequestInputLgcmareaType Lgcmarea { get; set; }
    }

    public class PostCustomerdetailsupdRequestInputLgcmareaType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int? CaReturnCode { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int? CaCustomerNum { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PostCustomerdetailsupdRequestInputLgcmareaTypeCaCustomerRequestType CaCustomerRequest { get; set; }
    }

    public class PostCustomerdetailsupdRequestInputLgcmareaTypeCaCustomerRequestType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CaFirstName { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CaLastName { get; set; }

        [JsonProperty("CA_DOB")]
        public string CaDob { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CaHouseName { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CaHouseNum { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CaPostcode { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int? CaNumPolicies { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CaPhoneMobile { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CaPhoneHome { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CaEmailAddress { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CaPolicyData { get; set; }
    }

    public class PutCustomerdetailResponse200
    {
        [JsonProperty("LGCMAREA")]
        public PutCustomerdetailResponse200LgcmareaType Lgcmarea { get; set; }
    }

    public class PutCustomerdetailResponse200LgcmareaType
    {
        [JsonProperty("CA_REQUEST_ID")]
        public string CaRequestId { get; set; }

        [JsonProperty("CA_RETURN_CODE")]
        public int CaReturnCode { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CaCustomerNum { get; set; }

        [JsonProperty("CA_REQUEST_SPECIFIC")]
        public string CaRequestSpecific { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PutCustomerdetailResponse200LgcmareaTypeCaCustomerRequestType CaCustomerRequest { get; set; }
    }

    public class PutCustomerdetailResponse200LgcmareaTypeCaCustomerRequestType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CaFirstName { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CaLastName { get; set; }

        [JsonProperty("CA_DOB")]
        public string CaDob { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CaHouseName { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CaHouseNum { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CaPostcode { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CaNumPolicies { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CaPhoneMobile { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CaPhoneHome { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CaEmailAddress { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CaPolicyData { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("LGCMAREA")]
        public BodyInputLgcmareaType Lgcmarea { get; set; }
    }

    public class BodyInputLgcmareaType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int? CaReturnCode { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public BodyInputLgcmareaTypeCaCustomerRequestType CaCustomerRequest { get; set; }
    }

    public class BodyInputLgcmareaTypeCaCustomerRequestType
    {
        [JsonProperty("CA_LAST_NAME")]
        public string CaLastName { get; set; }

        [JsonProperty("CA_DOB")]
        public string CaDob { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CaHouseName { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CaHouseNum { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CaPostcode { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int? CaNumPolicies { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CaPhoneMobile { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CaPhoneHome { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CaEmailAddress { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CaPolicyData { get; set; }
    }

    public class GetCustomerDetailResponse
    {
        [JsonProperty("LGCMAREA")]
        public GetCustomerDetailResponseLgcmareaType Lgcmarea { get; set; }
    }

    public class GetCustomerDetailResponseLgcmareaType
    {
        [JsonProperty("CA_CUSTSECR_REQUEST")]
        public GetCustomerDetailResponseLgcmareaTypeCaCustsecrRequestType CaCustsecrRequest { get; set; }

        [JsonProperty("CA_REQUEST_SPECIFIC")]
        public string CaRequestSpecific { get; set; }

        [JsonProperty("CA_REQUEST_ID")]
        public string CaRequestId { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public GetCustomerDetailResponseLgcmareaTypeCaCustomerRequestType CaCustomerRequest { get; set; }

        [JsonProperty("CA_POLICY_REQUEST")]
        public GetCustomerDetailResponseLgcmareaTypeCaPolicyRequestType CaPolicyRequest { get; set; }

        [JsonProperty("CA_RETURN_CODE")]
        public int CaReturnCode { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CaCustomerNum { get; set; }
    }

    public class GetCustomerDetailResponseLgcmareaTypeCaCustsecrRequestType
    {
        [JsonProperty("CA_CUSTSECR_DATA")]
        public string CaCustsecrData { get; set; }

        [JsonProperty("CA_CUSTSECR_STATE")]
        public string CaCustsecrState { get; set; }

        [JsonProperty("CA_CUSTSECR_COUNT")]
        public string CaCustsecrCount { get; set; }

        [JsonProperty("CA_CUSTSECR_PASS")]
        public string CaCustsecrPass { get; set; }
    }

    public class GetCustomerDetailResponseLgcmareaTypeCaCustomerRequestType
    {
        [JsonProperty("CA_PHONE_MOBILE")]
        public string CaPhoneMobile { get; set; }

        [JsonProperty("CA_DOB")]
        public string CaDob { get; set; }

        [JsonProperty("CA_FIRST_NAME")]
        public string CaFirstName { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CaPhoneHome { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CaEmailAddress { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CaPolicyData { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CaLastName { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CaHouseName { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CaNumPolicies { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CaHouseNum { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CaPostcode { get; set; }
    }

    public class GetCustomerDetailResponseLgcmareaTypeCaPolicyRequestType
    {
        [JsonProperty("CA_POLICY_SPECIFIC")]
        public string CaPolicySpecific { get; set; }

        [JsonProperty("CA_POLICY_NUM")]
        public int CaPolicyNum { get; set; }

        [JsonProperty("CA_POLICY_COMMON")]
        public GetCustomerDetailResponseLgcmareaTypeCaPolicyRequestTypeCaPolicyCommonType CaPolicyCommon { get; set; }
    }

    public class GetCustomerDetailResponseLgcmareaTypeCaPolicyRequestTypeCaPolicyCommonType
    {
        [JsonProperty("CA_ISSUE_DATE")]
        public string CaIssueDate { get; set; }

        [JsonProperty("CA_PAYMENT")]
        public int CaPayment { get; set; }

        [JsonProperty("CA_BROKERID")]
        public int CaBrokerid { get; set; }

        [JsonProperty("CA_EXPIRY_DATE")]
        public string CaExpiryDate { get; set; }

        [JsonProperty("CA_LASTCHANGED")]
        public string CaLastchanged { get; set; }

        [JsonProperty("CA_BROKERSREF")]
        public string CaBrokersref { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kyndrylmainframe;

    public partial class WorkflowManagedActions
    {
        public KyndrylmainframeActions Kyndrylmainframe(string connectionId) => new KyndrylmainframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KyndrylmainframeTriggers Kyndrylmainframe(string connectionId) => new KyndrylmainframeTriggers(connectionId);
    }
}