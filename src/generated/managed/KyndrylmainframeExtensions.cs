//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kyndrylmainframe
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
            callPayload.Queries["CUSTOMERNUMBER"] = CSharpExpressionConverter.ConvertO(cUSTOMERNUMBER);
            return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200> PostCustomerDetailsupd(Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcARETURNCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            var apiCallPath = "/customernumber/Custdetailadd";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postCustomerdetailsupdRequest = new JObject();
            var postCustomerdetailsupdRequestpropCount = 0;
            var lGCMAREAObject = new JObject();
            var lGCMAREAObjectpropCount = 0;
            if (postCustomerdetailsupdRequestlGCMAREAcARETURNCODE != null)
            {
                lGCMAREAObject["CA_RETURN_CODE"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE);
                lGCMAREAObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM != null)
            {
                lGCMAREAObject["CA_CUSTOMER_NUM"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM);
                lGCMAREAObjectpropCount++;
            }

            var cACUSTOMERREQUESTObject = new JObject();
            var cACUSTOMERREQUESTObjectpropCount = 0;
            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME != null)
            {
                cACUSTOMERREQUESTObject["CA_FIRST_NAME"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
            {
                cACUSTOMERREQUESTObject["CA_LAST_NAME"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB != null)
            {
                cACUSTOMERREQUESTObject["CA_DOB"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
            {
                cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
            {
                cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
            {
                cACUSTOMERREQUESTObject["CA_POSTCODE"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
            {
                cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
            {
                cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
            {
                cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
            {
                cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
            {
                cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = CSharpExpressionConverter.ConvertToken(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (cACUSTOMERREQUESTObjectpropCount > 0)
            {
                lGCMAREAObject["CA_CUSTOMER_REQUEST"] = cACUSTOMERREQUESTObject;
                lGCMAREAObjectpropCount++;
            }

            if (lGCMAREAObjectpropCount > 0)
            {
                postCustomerdetailsupdRequest["LGCMAREA"] = lGCMAREAObject;
                postCustomerdetailsupdRequestpropCount++;
            }

            if (postCustomerdetailsupdRequestpropCount > 0)
            {
                callPayload.Body = postCustomerdetailsupdRequest;
            }

            return new ApiConnectionAction<PostCustomerdetailsupdResponse200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PutCustomerdetailResponse200> PutCustomerDetail(Expression<Func<string>> num, Expression<Func<string>> firstname, Expression<Func<int>> bodylGCMAREAcARETURNCODE = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcALASTNAME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcADOB = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, Expression<Func<int>> bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/customernumber/Custdetailupd/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(num, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(firstname, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var lGCMAREAObject = new JObject();
            var lGCMAREAObjectpropCount = 0;
            if (bodylGCMAREAcARETURNCODE != null)
            {
                lGCMAREAObject["CA_RETURN_CODE"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcARETURNCODE);
                lGCMAREAObjectpropCount++;
            }

            var cACUSTOMERREQUESTObject = new JObject();
            var cACUSTOMERREQUESTObjectpropCount = 0;
            if (bodylGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
            {
                cACUSTOMERREQUESTObject["CA_LAST_NAME"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcADOB != null)
            {
                cACUSTOMERREQUESTObject["CA_DOB"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcADOB);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
            {
                cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
            {
                cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
            {
                cACUSTOMERREQUESTObject["CA_POSTCODE"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
            {
                cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
            {
                cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
            {
                cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
            {
                cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
            {
                cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = CSharpExpressionConverter.ConvertToken(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
                cACUSTOMERREQUESTObjectpropCount++;
            }

            if (cACUSTOMERREQUESTObjectpropCount > 0)
            {
                lGCMAREAObject["CA_CUSTOMER_REQUEST"] = cACUSTOMERREQUESTObject;
                lGCMAREAObjectpropCount++;
            }

            if (lGCMAREAObjectpropCount > 0)
            {
                body["LGCMAREA"] = lGCMAREAObject;
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/customernumber/custnum/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(num, 1));
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