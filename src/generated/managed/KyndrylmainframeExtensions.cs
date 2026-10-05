//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kyndrylmainframe
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KyndrylmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildGetPolicy))]
        public IBodyWorkflowAction<GetPolicyResponse200> GetPolicy([WorkflowExpression] Func<string> cUSTOMERNUMBER)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPolicyResponse200> __BuildGetPolicy(WorkflowValue<string> cUSTOMERNUMBER)
        {
            WorkflowValue.Validate(cUSTOMERNUMBER, nameof(cUSTOMERNUMBER), required: true);
            return new DeferredBodyAction<GetPolicyResponse200>(() =>
            {
                var apiCallPath = "/cb12-policy/getpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CUSTOMERNUMBER"] = ExpressionConverter.Convert(cUSTOMERNUMBER);
                return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildPostCustomerDetailsupd))]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200> PostCustomerDetailsupd([WorkflowExpression] Func<int> postCustomerdetailsupdRequestlGCMAREAcARETURNCODE = null, [WorkflowExpression] Func<int> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, [WorkflowExpression] Func<int> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, [WorkflowExpression] Func<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200> __BuildPostCustomerDetailsupd(WorkflowValue<int> postCustomerdetailsupdRequestlGCMAREAcARETURNCODE = null, WorkflowValue<int> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, WorkflowValue<int> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, WorkflowValue<string> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE, nameof(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS), required: false);
            WorkflowValue.Validate(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA), required: false);
            return new DeferredBodyAction<PostCustomerdetailsupdResponse200>(() =>
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
                    lGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE);
                    lGCMAREAObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM != null)
                {
                    lGCMAREAObject["CA_CUSTOMER_NUM"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM);
                    lGCMAREAObjectpropCount++;
                }

                var cACUSTOMERREQUESTObject = new JObject();
                var cACUSTOMERREQUESTObjectpropCount = 0;
                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_FIRST_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB != null)
                {
                    cACUSTOMERREQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
                {
                    cACUSTOMERREQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
                {
                    cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
                {
                    cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
                {
                    cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildPutCustomerDetail))]
        public IBodyWorkflowAction<PutCustomerdetailResponse200> PutCustomerDetail([WorkflowExpression] Func<string> num, [WorkflowExpression] Func<string> firstname, [WorkflowExpression] Func<int> bodylGCMAREAcARETURNCODE = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcALASTNAME = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcADOB = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, [WorkflowExpression] Func<int> bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, [WorkflowExpression] Func<string> bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutCustomerdetailResponse200> __BuildPutCustomerDetail(WorkflowValue<string> num, WorkflowValue<string> firstname, WorkflowValue<int> bodylGCMAREAcARETURNCODE = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcALASTNAME = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcADOB = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, WorkflowValue<int> bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, WorkflowValue<string> bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            WorkflowValue.Validate(num, nameof(num), required: true);
            WorkflowValue.Validate(firstname, nameof(firstname), required: true);
            WorkflowValue.Validate(bodylGCMAREAcARETURNCODE, nameof(bodylGCMAREAcARETURNCODE), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME, nameof(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcADOB, nameof(bodylGCMAREAcACUSTOMERREQUESTcADOB), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME, nameof(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM, nameof(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES, nameof(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS, nameof(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS), required: false);
            WorkflowValue.Validate(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA), required: false);
            return new DeferredBodyAction<PutCustomerdetailResponse200>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/customernumber/Custdetailupd/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(num, 1), ExpressionConverter.ConvertWithUrlEncoding(firstname, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var lGCMAREAObject = new JObject();
                var lGCMAREAObjectpropCount = 0;
                if (bodylGCMAREAcARETURNCODE != null)
                {
                    lGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(bodylGCMAREAcARETURNCODE);
                    lGCMAREAObjectpropCount++;
                }

                var cACUSTOMERREQUESTObject = new JObject();
                var cACUSTOMERREQUESTObjectpropCount = 0;
                if (bodylGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcADOB != null)
                {
                    cACUSTOMERREQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcADOB);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
                {
                    cACUSTOMERREQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
                {
                    cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
                {
                    cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
                {
                    cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildGetCustomerDetail))]
        public IBodyWorkflowAction<GetCustomerDetailResponse> GetCustomerDetail([WorkflowExpression] Func<string> num)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCustomerDetailResponse> __BuildGetCustomerDetail(WorkflowValue<string> num)
        {
            WorkflowValue.Validate(num, nameof(num), required: true);
            return new DeferredBodyAction<GetCustomerDetailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/customernumber/custnum/{0}", ExpressionConverter.ConvertWithUrlEncoding(num, 1));
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
