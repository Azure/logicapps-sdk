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
        public IBodyWorkflowAction<GetPolicyResponse200> GetPolicy(Expression<Func<string>> cUSTOMERNUMBER)
        {
            var __workflow_cUSTOMERNUMBER = WorkflowExpression.Compile(cUSTOMERNUMBER, nameof(cUSTOMERNUMBER), required: true);
            return new DeferredBodyAction<GetPolicyResponse200>(() =>
            {
                var apiCallPath = "/cb12-policy/getpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CUSTOMERNUMBER"] = ExpressionConverter.Convert(__workflow_cUSTOMERNUMBER);
                return new ApiConnectionAction<GetPolicyResponse200>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PostCustomerdetailsupdResponse200> PostCustomerDetailsupd(Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcARETURNCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, Expression<Func<int>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, Expression<Func<string>> postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcARETURNCODE = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE, nameof(postCustomerdetailsupdRequestlGCMAREAcARETURNCODE), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS), required: false);
            var __workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = WorkflowExpression.Compile(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA, nameof(postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA), required: false);
            return new DeferredBodyAction<PostCustomerdetailsupdResponse200>(() =>
            {
                var apiCallPath = "/customernumber/Custdetailadd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postCustomerdetailsupdRequest = new JObject();
                var postCustomerdetailsupdRequestpropCount = 0;
                var lGCMAREAObject = new JObject();
                var lGCMAREAObjectpropCount = 0;
                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcARETURNCODE != null)
                {
                    lGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcARETURNCODE);
                    lGCMAREAObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM != null)
                {
                    lGCMAREAObject["CA_CUSTOMER_NUM"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERNUM);
                    lGCMAREAObjectpropCount++;
                }

                var cACUSTOMERREQUESTObject = new JObject();
                var cACUSTOMERREQUESTObjectpropCount = 0;
                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_FIRST_NAME"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAFIRSTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcALASTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB != null)
                {
                    cACUSTOMERREQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcADOB);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
                {
                    cACUSTOMERREQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
                {
                    cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
                {
                    cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
                {
                    cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(__workflow_postCustomerdetailsupdRequestlGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<PutCustomerdetailResponse200> PutCustomerDetail(Expression<Func<string>> num, Expression<Func<string>> firstname, Expression<Func<int>> bodylGCMAREAcARETURNCODE = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcALASTNAME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcADOB = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE = null, Expression<Func<int>> bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = null, Expression<Func<string>> bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = null)
        {
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: true);
            var __workflow_firstname = WorkflowExpression.Compile(firstname, nameof(firstname), required: true);
            var __workflow_bodylGCMAREAcARETURNCODE = WorkflowExpression.Compile(bodylGCMAREAcARETURNCODE, nameof(bodylGCMAREAcARETURNCODE), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcALASTNAME = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME, nameof(bodylGCMAREAcACUSTOMERREQUESTcALASTNAME), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcADOB = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcADOB, nameof(bodylGCMAREAcACUSTOMERREQUESTcADOB), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME, nameof(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM, nameof(bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES, nameof(bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS, nameof(bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS), required: false);
            var __workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA = WorkflowExpression.Compile(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA, nameof(bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA), required: false);
            return new DeferredBodyAction<PutCustomerdetailResponse200>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customernumber/Custdetailupd/{0}/{1}", __workflow_num.WithUrlEncoding(1), __workflow_firstname.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var lGCMAREAObject = new JObject();
                var lGCMAREAObjectpropCount = 0;
                if (__workflow_bodylGCMAREAcARETURNCODE != null)
                {
                    lGCMAREAObject["CA_RETURN_CODE"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcARETURNCODE);
                    lGCMAREAObjectpropCount++;
                }

                var cACUSTOMERREQUESTObject = new JObject();
                var cACUSTOMERREQUESTObjectpropCount = 0;
                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcALASTNAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcALASTNAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcADOB != null)
                {
                    cACUSTOMERREQUESTObject["CA_DOB"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcADOB);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NAME"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENAME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM != null)
                {
                    cACUSTOMERREQUESTObject["CA_HOUSE_NUM"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAHOUSENUM);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE != null)
                {
                    cACUSTOMERREQUESTObject["CA_POSTCODE"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOSTCODE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES != null)
                {
                    cACUSTOMERREQUESTObject["CA_NUM_POLICIES"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcANUMPOLICIES);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_MOBILE"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEMOBILE);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME != null)
                {
                    cACUSTOMERREQUESTObject["CA_PHONE_HOME"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPHONEHOME);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS != null)
                {
                    cACUSTOMERREQUESTObject["CA_EMAIL_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAEMAILADDRESS);
                    cACUSTOMERREQUESTObjectpropCount++;
                }

                if (__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA != null)
                {
                    cACUSTOMERREQUESTObject["CA_POLICY_DATA"] = ExpressionConverter.ConvertO(__workflow_bodylGCMAREAcACUSTOMERREQUESTcAPOLICYDATA);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kyndrylmainframe")]
        public IBodyWorkflowAction<GetCustomerDetailResponse> GetCustomerDetail(Expression<Func<string>> num)
        {
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: true);
            return new DeferredBodyAction<GetCustomerDetailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customernumber/custnum/{0}", __workflow_num.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCustomerDetailResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
