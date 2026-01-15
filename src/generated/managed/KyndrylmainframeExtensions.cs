//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Kyndrylmainframe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KyndrylmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<GetPolicyResponse200> GetPolicy(Expression<Func<string>> cUSTOMERNUMBER)
        {
            var apiCallPath = "/cb12-policy/getpolicy";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["CUSTOMERNUMBER"] = ExpressionConverter.Convert(cUSTOMERNUMBER);
            return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200> PostCustomerDetailsupd(Expression<Func<int>> postCustomerdetailsupdRequestLGCMAREACARETURNCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERNUM = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAFIRSTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCALASTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCADOB = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENAME = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENUM = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOSTCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCANUMPOLICIES = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEHOME = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS = null, Expression<Func<string>> postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOLICYDATA = null)
        {
            var apiCallPath = "/customernumber/Custdetailadd";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postCustomerdetailsupdRequest = new JObject();
            var postCustomerdetailsupdRequestpropCount = 0;
            var LGCMAREAObject = new JObject();
            var LGCMAREAObjectpropCount = 0;
            if (postCustomerdetailsupdRequestLGCMAREACARETURNCODE != null)
            {
                LGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACARETURNCODE);
                LGCMAREAObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERNUM != null)
            {
                LGCMAREAObject["CA_CUSTOMER_NUM"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERNUM);
                LGCMAREAObjectpropCount++;
            }

            var CA_CUSTOMER_REQUESTObject = new JObject();
            var CA_CUSTOMER_REQUESTObjectpropCount = 0;
            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAFIRSTNAME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_FIRST_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAFIRSTNAME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCALASTNAME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCALASTNAME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCADOB != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCADOB);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENAME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENAME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENUM != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAHOUSENUM);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOSTCODE != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOSTCODE);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCANUMPOLICIES != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCANUMPOLICIES);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEHOME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPHONEHOME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOLICYDATA != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestLGCMAREACACUSTOMERREQUESTCAPOLICYDATA);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (CA_CUSTOMER_REQUESTObjectpropCount > 0)
            {
                LGCMAREAObject["CA_CUSTOMER_REQUEST"] = CA_CUSTOMER_REQUESTObject;
                LGCMAREAObjectpropCount++;
            }

            if (LGCMAREAObjectpropCount > 0)
            {
                postCustomerdetailsupdRequest["LGCMAREA"] = LGCMAREAObject;
                postCustomerdetailsupdRequestpropCount++;
            }

            if (postCustomerdetailsupdRequestpropCount > 0)
            {
                callPayload.Body = postCustomerdetailsupdRequest;
            }

            return new ApiConnectionAction<PostCustomerdetailsupdResponse200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PutCustomerdetailResponse200> PutCustomerDetail(Expression<Func<string>> num, Expression<Func<string>> firstname, Expression<Func<int>> bodyLGCMAREACARETURNCODE = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCALASTNAME = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCADOB = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAHOUSENAME = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAHOUSENUM = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAPOSTCODE = null, Expression<Func<int>> bodyLGCMAREACACUSTOMERREQUESTCANUMPOLICIES = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAPHONEHOME = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS = null, Expression<Func<string>> bodyLGCMAREACACUSTOMERREQUESTCAPOLICYDATA = null)
        {
            var apiCallPath = String.Format("/customernumber/Custdetailupd/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(num, 1), ExpressionConverter.ConvertWithUrlEncoding(firstname, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var LGCMAREAObject = new JObject();
            var LGCMAREAObjectpropCount = 0;
            if (bodyLGCMAREACARETURNCODE != null)
            {
                LGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(bodyLGCMAREACARETURNCODE);
                LGCMAREAObjectpropCount++;
            }

            var CA_CUSTOMER_REQUESTObject = new JObject();
            var CA_CUSTOMER_REQUESTObjectpropCount = 0;
            if (bodyLGCMAREACACUSTOMERREQUESTCALASTNAME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCALASTNAME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCADOB != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCADOB);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAHOUSENAME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAHOUSENAME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAHOUSENUM != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAHOUSENUM);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAPOSTCODE != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAPOSTCODE);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCANUMPOLICIES != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCANUMPOLICIES);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAPHONEMOBILE);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAPHONEHOME != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAPHONEHOME);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAEMAILADDRESS);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (bodyLGCMAREACACUSTOMERREQUESTCAPOLICYDATA != null)
            {
                CA_CUSTOMER_REQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(bodyLGCMAREACACUSTOMERREQUESTCAPOLICYDATA);
                CA_CUSTOMER_REQUESTObjectpropCount++;
            }

            if (CA_CUSTOMER_REQUESTObjectpropCount > 0)
            {
                LGCMAREAObject["CA_CUSTOMER_REQUEST"] = CA_CUSTOMER_REQUESTObject;
                LGCMAREAObjectpropCount++;
            }

            if (LGCMAREAObjectpropCount > 0)
            {
                body["LGCMAREA"] = LGCMAREAObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PutCustomerdetailResponse200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<GetCustomerDetailResponse> GetCustomerDetail(Expression<Func<string>> num)
        {
            var apiCallPath = String.Format("/customernumber/custnum/{0}", ExpressionConverter.ConvertWithUrlEncoding(num, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCustomerDetailResponse>(callPayload);
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
        public string BROKERID { get; set; }
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

    public class PutCustomerdetailResponse200
    {
        public PutCustomerdetailResponse200LGCMAREAType LGCMAREA { get; set; }
    }

    public class PutCustomerdetailResponse200LGCMAREAType
    {
        [JsonProperty("CA_REQUEST_ID")]
        public string CAREQUESTID { get; set; }

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
        public string CAREQUESTID { get; set; }

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
        public int CABROKERID { get; set; }

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
    using Microsoft.Azure.Workflows.Sdk.Kyndrylmainframe;

    public partial class WorkflowManagedActions
    {
        public KyndrylmainframeActions Kyndrylmainframe(string connectionId) => new KyndrylmainframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KyndrylmainframeTriggers Kyndrylmainframe(string connectionId) => new KyndrylmainframeTriggers(connectionId);
    }
}