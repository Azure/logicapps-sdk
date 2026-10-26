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
        public IBodyWorkflowAction<GetPolicyResponse200, ApiConnectionActionConfiguration> GetPolicy(Expression<Func<string>> cUSTOMERNUMBER)
        {
            var __workflow_cUSTOMERNUMBER = WorkflowExpression.Compile(cUSTOMERNUMBER, nameof(cUSTOMERNUMBER), required: true);
            return new DeferredBodyAction<GetPolicyResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cb12-policy/getpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CUSTOMERNUMBER"] = ExpressionConverter.Convert(__workflow_cUSTOMERNUMBER);
                return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200, ApiConnectionActionConfiguration> PostCustomerDetailsupd(Expression<Func<PostCustomerDetailsupdInput>> postCustomerdetailsupdRequest)
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
        public IBodyWorkflowAction<PutCustomerdetailResponse200, ApiConnectionActionConfiguration> PutCustomerDetail(Expression<Func<string>> num, Expression<Func<string>> firstname, Expression<Func<PutCustomerDetailInput>> body)
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
        public double COMMISSION { get; set; }
        public string PAYMENT { get; set; }
        public string ISSUEDATE { get; set; }
        public string POLICYNUMBER { get; set; }
        public string POLICYTYPE { get; set; }

        [JsonProperty("BROKERID")]
        public string BROKERId { get; set; }
        public string LASTCHANGED { get; set; }
        public string EXPIRYDATE { get; set; }
        public string CUSTOMERNUMBER { get; set; }
        public string BROKERSREFERENCE { get; set; }
    }

    public class PostCustomerdetailsupdResponse200
    {
        public PostCustomerdetailsupdResponse200LGCMAREAType LGCMAREA { get; set; }
    }

    public class PostCustomerdetailsupdResponse200LGCMAREAType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int CARETURNCODE { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CACUSTOMERNUM { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PostCustomerdetailsupdResponse200LGCMAREATypeCACUSTOMERREQUESTType CACUSTOMERREQUEST { get; set; }
    }

    public class PostCustomerdetailsupdResponse200LGCMAREATypeCACUSTOMERREQUESTType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CAFIRSTNAME { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CALASTNAME { get; set; }

        [JsonProperty("CA_DOB")]
        public string CADOB { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CAHOUSENAME { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CAHOUSENUM { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CAPOSTCODE { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CANUMPOLICIES { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CAPHONEMOBILE { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CAPHONEHOME { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CAEMAILADDRESS { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CAPOLICYDATA { get; set; }
    }

    public class PostCustomerDetailsupdInput
    {
        public PostCustomerDetailsupdInputLGCMAREAType LGCMAREA { get; set; }
    }

    public class PostCustomerDetailsupdInputLGCMAREAType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int? CARETURNCODE { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int? CACUSTOMERNUM { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PostCustomerDetailsupdInputLGCMAREATypeCACUSTOMERREQUESTType CACUSTOMERREQUEST { get; set; }
    }

    public class PostCustomerDetailsupdInputLGCMAREATypeCACUSTOMERREQUESTType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CAFIRSTNAME { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CALASTNAME { get; set; }

        [JsonProperty("CA_DOB")]
        public string CADOB { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CAHOUSENAME { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CAHOUSENUM { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CAPOSTCODE { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int? CANUMPOLICIES { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CAPHONEMOBILE { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CAPHONEHOME { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CAEMAILADDRESS { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CAPOLICYDATA { get; set; }
    }

    public class PutCustomerdetailResponse200
    {
        public PutCustomerdetailResponse200LGCMAREAType LGCMAREA { get; set; }
    }

    public class PutCustomerdetailResponse200LGCMAREAType
    {
        [JsonProperty("CA_REQUEST_ID")]
        public string CAREQUESTId { get; set; }

        [JsonProperty("CA_RETURN_CODE")]
        public int CARETURNCODE { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CACUSTOMERNUM { get; set; }

        [JsonProperty("CA_REQUEST_SPECIFIC")]
        public string CAREQUESTSPECIFIC { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PutCustomerdetailResponse200LGCMAREATypeCACUSTOMERREQUESTType CACUSTOMERREQUEST { get; set; }
    }

    public class PutCustomerdetailResponse200LGCMAREATypeCACUSTOMERREQUESTType
    {
        [JsonProperty("CA_FIRST_NAME")]
        public string CAFIRSTNAME { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CALASTNAME { get; set; }

        [JsonProperty("CA_DOB")]
        public string CADOB { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CAHOUSENAME { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CAHOUSENUM { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CAPOSTCODE { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CANUMPOLICIES { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CAPHONEMOBILE { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CAPHONEHOME { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CAEMAILADDRESS { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CAPOLICYDATA { get; set; }
    }

    public class PutCustomerDetailInput
    {
        public PutCustomerDetailInputLGCMAREAType LGCMAREA { get; set; }
    }

    public class PutCustomerDetailInputLGCMAREAType
    {
        [JsonProperty("CA_RETURN_CODE")]
        public int? CARETURNCODE { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public PutCustomerDetailInputLGCMAREATypeCACUSTOMERREQUESTType CACUSTOMERREQUEST { get; set; }
    }

    public class PutCustomerDetailInputLGCMAREATypeCACUSTOMERREQUESTType
    {
        [JsonProperty("CA_LAST_NAME")]
        public string CALASTNAME { get; set; }

        [JsonProperty("CA_DOB")]
        public string CADOB { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CAHOUSENAME { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CAHOUSENUM { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CAPOSTCODE { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int? CANUMPOLICIES { get; set; }

        [JsonProperty("CA_PHONE_MOBILE")]
        public string CAPHONEMOBILE { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CAPHONEHOME { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CAEMAILADDRESS { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CAPOLICYDATA { get; set; }
    }

    public class GetCustomerDetailResponse
    {
        public GetCustomerDetailResponseLGCMAREAType LGCMAREA { get; set; }
    }

    public class GetCustomerDetailResponseLGCMAREAType
    {
        [JsonProperty("CA_CUSTSECR_REQUEST")]
        public GetCustomerDetailResponseLGCMAREATypeCACUSTSECRREQUESTType CACUSTSECRREQUEST { get; set; }

        [JsonProperty("CA_REQUEST_SPECIFIC")]
        public string CAREQUESTSPECIFIC { get; set; }

        [JsonProperty("CA_REQUEST_ID")]
        public string CAREQUESTId { get; set; }

        [JsonProperty("CA_CUSTOMER_REQUEST")]
        public GetCustomerDetailResponseLGCMAREATypeCACUSTOMERREQUESTType CACUSTOMERREQUEST { get; set; }

        [JsonProperty("CA_POLICY_REQUEST")]
        public GetCustomerDetailResponseLGCMAREATypeCAPOLICYREQUESTType CAPOLICYREQUEST { get; set; }

        [JsonProperty("CA_RETURN_CODE")]
        public int CARETURNCODE { get; set; }

        [JsonProperty("CA_CUSTOMER_NUM")]
        public int CACUSTOMERNUM { get; set; }
    }

    public class GetCustomerDetailResponseLGCMAREATypeCACUSTSECRREQUESTType
    {
        [JsonProperty("CA_CUSTSECR_DATA")]
        public string CACUSTSECRDATA { get; set; }

        [JsonProperty("CA_CUSTSECR_STATE")]
        public string CACUSTSECRSTATE { get; set; }

        [JsonProperty("CA_CUSTSECR_COUNT")]
        public string CACUSTSECRCOUNT { get; set; }

        [JsonProperty("CA_CUSTSECR_PASS")]
        public string CACUSTSECRPASS { get; set; }
    }

    public class GetCustomerDetailResponseLGCMAREATypeCACUSTOMERREQUESTType
    {
        [JsonProperty("CA_PHONE_MOBILE")]
        public string CAPHONEMOBILE { get; set; }

        [JsonProperty("CA_DOB")]
        public string CADOB { get; set; }

        [JsonProperty("CA_FIRST_NAME")]
        public string CAFIRSTNAME { get; set; }

        [JsonProperty("CA_PHONE_HOME")]
        public string CAPHONEHOME { get; set; }

        [JsonProperty("CA_EMAIL_ADDRESS")]
        public string CAEMAILADDRESS { get; set; }

        [JsonProperty("CA_POLICY_DATA")]
        public string CAPOLICYDATA { get; set; }

        [JsonProperty("CA_LAST_NAME")]
        public string CALASTNAME { get; set; }

        [JsonProperty("CA_HOUSE_NAME")]
        public string CAHOUSENAME { get; set; }

        [JsonProperty("CA_NUM_POLICIES")]
        public int CANUMPOLICIES { get; set; }

        [JsonProperty("CA_HOUSE_NUM")]
        public string CAHOUSENUM { get; set; }

        [JsonProperty("CA_POSTCODE")]
        public string CAPOSTCODE { get; set; }
    }

    public class GetCustomerDetailResponseLGCMAREATypeCAPOLICYREQUESTType
    {
        [JsonProperty("CA_POLICY_SPECIFIC")]
        public string CAPOLICYSPECIFIC { get; set; }

        [JsonProperty("CA_POLICY_NUM")]
        public int CAPOLICYNUM { get; set; }

        [JsonProperty("CA_POLICY_COMMON")]
        public GetCustomerDetailResponseLGCMAREATypeCAPOLICYREQUESTTypeCAPOLICYCOMMONType CAPOLICYCOMMON { get; set; }
    }

    public class GetCustomerDetailResponseLGCMAREATypeCAPOLICYREQUESTTypeCAPOLICYCOMMONType
    {
        [JsonProperty("CA_ISSUE_DATE")]
        public string CAISSUEDATE { get; set; }

        [JsonProperty("CA_PAYMENT")]
        public int CAPAYMENT { get; set; }

        [JsonProperty("CA_BROKERID")]
        public int CABROKERId { get; set; }

        [JsonProperty("CA_EXPIRY_DATE")]
        public string CAEXPIRYDATE { get; set; }

        [JsonProperty("CA_LASTCHANGED")]
        public string CALASTCHANGED { get; set; }

        [JsonProperty("CA_BROKERSREF")]
        public string CABROKERSREF { get; set; }
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