//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Soft1
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Soft1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IWorkflowAction Microservice(Expression<Func<string>> bodybody, Expression<Func<string>> bodyendpoint)
        {
            var apiCallPath = "/custom";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("microservice");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
            bodypropCount++;
            body["endpoint"] = CSharpExpressionConverter.ConvertToken(bodyendpoint);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCFNCUSDOCResponse> GetCFNCUSDOC(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getCFNCUSDOC";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CFNCUSDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetCFNCUSDOCResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfnsupdocResponse> GetCfnsupdoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getCfnsupdoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CFNSUPDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetCfnsupdocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetChequeResponse> GetCheque(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getCheque";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CHEQUE";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetChequeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetContactResponse> GetContact(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRSNOUT";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCustomerResponse> GetCustomer(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getCustomer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CUSTOMER";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetDraftEntryResponse> GetDraftEntry(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getDraftEntry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SODRAFT";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetDraftEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpenseResponse> GetExpense(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getExpense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "LINEITEM";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetExpenseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpensesDocResponse> GetExpensesDoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodylOCATEINFO = null)
        {
            var apiCallPath = "/getExpensesDoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = "702";
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            if (bodylOCATEINFO != null)
            {
                if (bodylOCATEINFO != null)
                {
                    body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["LOCATEINFO"] = "LINLINES:LINENUM,LINEVAL,MTRL,MTRL_LINEITEM_CODE,MTRL_LINEITEM_NAME,VAT,VATAMNT;LINSUPDOC:COMPANY,ACNMSK,APPRV,BRANCH,BUSUNITS,CASHDEVICE,CBANK,CBANKBRANCH,CMPFINCODE,FINCODE,CMPSERIESNUM,COMMENTS,COMMENTS1,CRCONTROL,EXPN,FINSTATES,FPRMS,GSISFLG,GSISMD,GSISNET,GSISPACKAGES,GSISQTY,GSISVAT,INPAYVAT,INST,INST_INST_CODE,INST_INST_NAME,INTDATE,INTEXPN,INTFDOCTYPE,INTRATE,INTSHIPMENT,INTVAL,INTVAT,ISCANCEL,ISPRINT,ISTRIG,KEPYOHANDMD,KEPYOMD,KEPYOQT,LEXPN,LKEPYOVAL,LNETAMNT,LRATE,LVATAMNT,NETAMNT,NOINTRASTAT,PAYMENT,PRJC,PRJC_PRJC_CODE,PRJC_PRJC_NAME,REMARKS,RSRC,RSRC_RSRC_CODE,RSRC_RSRC_NAME,SALESMAN,SALESMAN_PRSNIN_CODE,SALESMAN_PRSNIN_NAME2,SERIES,SHIPKIND,SHIPMENT,SOCURRENCY,SOPAYCODE,SUMAMNT,SUMLAMNT,SUMTAMNT,TEXPN,TNETAMNT,TRDBRANCH,TRDBRANCH_TRDBRANCH_CODE,TRDBRANCH_TRDBRANCH_NAME,TRDBRANCHS,TRDBRANCHS_TRDBRANCH_CODE,TRDBRANCHS_TRDBRANCH_NAME,TRDR,TRDR_SUPPLIER_AFM,TRDR_SUPPLIER_CHKAFM,TRDR_SUPPLIER_CODE,TRDR_SUPPLIER_NAME,TRDRRATE,TRDRS,TRDRS_TRDR_CODE,TRDRS_TRDR_NAME,TRNDATE,TVATAMNT,VATAMNT,VATPROVISIONS,VATSTS;MTRDOC:RECEIPTCARD,TRUCKS,TRUCKSNO;SUPPLIER:BANK";
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "LINSUPDOC";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetExpensesDocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItedocResponse> GetItedoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getItedoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "ITEDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetItedocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItemResponse> GetItem(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "ITEM";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRJC";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetPurdocResponse> GetPurdoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getPurdoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PURDOC";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetPurdocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSaldocResponse> GetSaldoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getSaldoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SALDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSaldocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetServiceResponse> GetService(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getService";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SERVICE";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetServiceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOEMAILResponse> GetSOEMAIL(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getSoemail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOEMAIL";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSOEMAILResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetMeetingResponse> GetMeeting(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getSomeeting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOMEETING";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetMeetingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOTASKResponse> GetSOTASK(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getSotask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOTASK";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSOTASKResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSupplierResponse> GetSupplier(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var apiCallPath = "/getSupplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            bodypropCount++;
            body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
            bodypropCount++;
            body["LOCATEINFO"] = CSharpExpressionConverter.ConvertToken(bodylOCATEINFO);
            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SUPPLIER";
            bodypropCount++;
            body["SERVICE"] = "getData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSupplierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSystemParamsResponse> GetSystemParams()
        {
            var apiCallPath = "/getSystemParams";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["appId"] = "702";
            bodypropCount++;
            body["service"] = "getSystemParams";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSystemParamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCFNCUSDOC(Expression<Func<string>> bodyvaluecFNCUSDOCsERIES, Expression<Func<string>> bodyvaluecFNCUSDOCtRDR, Expression<Func<bodyvaluecARDLINESInputItem[]>> bodyvaluecARDLINES = null, Expression<Func<bodyvaluecASHLINESInputItem[]>> bodyvaluecASHLINES = null, Expression<Func<string>> bodyvaluecFNCUSDOCcOLLECTOR = null, Expression<Func<string>> bodyvaluecFNCUSDOCcOMMENTS = null, Expression<Func<string>> bodyvaluecFNCUSDOCproject = null, Expression<Func<string>> bodyvaluecFNCUSDOCsALESMAN = null, Expression<Func<string>> bodyvaluecFNCUSDOCtRNDATE = null, Expression<Func<bodyvaluecHEQUELINESInputItem[]>> bodyvaluecHEQUELINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setCfncusdoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            if (bodyvaluecARDLINES != null)
            {
                dATAObject["CARDLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecARDLINES);
                dATAObjectpropCount++;
            }

            if (bodyvaluecASHLINES != null)
            {
                dATAObject["CASHLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecASHLINES);
                dATAObjectpropCount++;
            }

            var cFNCUSDOCObject = new JObject();
            var cFNCUSDOCObjectpropCount = 0;
            if (bodyvaluecFNCUSDOCcOLLECTOR != null)
            {
                cFNCUSDOCObject["COLLECTOR"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCcOLLECTOR);
                cFNCUSDOCObjectpropCount++;
            }

            if (bodyvaluecFNCUSDOCcOMMENTS != null)
            {
                cFNCUSDOCObject["COMMENTS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCcOMMENTS);
                cFNCUSDOCObjectpropCount++;
            }

            if (bodyvaluecFNCUSDOCproject != null)
            {
                cFNCUSDOCObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCproject);
                cFNCUSDOCObjectpropCount++;
            }

            if (bodyvaluecFNCUSDOCsALESMAN != null)
            {
                cFNCUSDOCObject["SALESMAN"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCsALESMAN);
                cFNCUSDOCObjectpropCount++;
            }

            cFNCUSDOCObjectpropCount++;
            cFNCUSDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCsERIES);
            cFNCUSDOCObjectpropCount++;
            cFNCUSDOCObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCtRDR);
            if (bodyvaluecFNCUSDOCtRNDATE != null)
            {
                cFNCUSDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCtRNDATE);
                cFNCUSDOCObjectpropCount++;
            }

            if (cFNCUSDOCObjectpropCount > 0)
            {
                dATAObject["CFNCUSDOC"] = cFNCUSDOCObject;
                dATAObjectpropCount++;
            }

            if (bodyvaluecHEQUELINES != null)
            {
                dATAObject["CHEQUELINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUELINES);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CFNCUSDOC";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCfnsupdoc(Expression<Func<string>> bodyvaluecFNSUPDOCsERIES, Expression<Func<string>> bodyvaluecFNSUPDOCtRDR, Expression<Func<bodyvaluecARDLINESInputItem[]>> bodyvaluecARDLINES = null, Expression<Func<bodyvaluecASHLINESInputItem2[]>> bodyvaluecASHLINES = null, Expression<Func<string>> bodyvaluecFNSUPDOCpRJC = null, Expression<Func<string>> bodyvaluecFNSUPDOCrEMARKS = null, Expression<Func<string>> bodyvaluecFNSUPDOCtRNDATE = null, Expression<Func<bodyvaluecHEQUELINESInputItem[]>> bodyvaluecHEQUELINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setCfnsupdoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            if (bodyvaluecARDLINES != null)
            {
                dATAObject["CARDLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecARDLINES);
                dATAObjectpropCount++;
            }

            if (bodyvaluecASHLINES != null)
            {
                dATAObject["CASHLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecASHLINES);
                dATAObjectpropCount++;
            }

            var cFNSUPDOCObject = new JObject();
            var cFNSUPDOCObjectpropCount = 0;
            if (bodyvaluecFNSUPDOCpRJC != null)
            {
                cFNSUPDOCObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCpRJC);
                cFNSUPDOCObjectpropCount++;
            }

            if (bodyvaluecFNSUPDOCrEMARKS != null)
            {
                cFNSUPDOCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCrEMARKS);
                cFNSUPDOCObjectpropCount++;
            }

            cFNSUPDOCObjectpropCount++;
            cFNSUPDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCsERIES);
            cFNSUPDOCObjectpropCount++;
            cFNSUPDOCObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCtRDR);
            if (bodyvaluecFNSUPDOCtRNDATE != null)
            {
                cFNSUPDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCtRNDATE);
                cFNSUPDOCObjectpropCount++;
            }

            if (cFNSUPDOCObjectpropCount > 0)
            {
                dATAObject["CFNSUPDOC"] = cFNSUPDOCObject;
                dATAObjectpropCount++;
            }

            if (bodyvaluecHEQUELINES != null)
            {
                dATAObject["CHEQUELINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUELINES);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CFNSUPDOC";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCheque(Expression<Func<string>> bodyvaluecHEQUEbalance, Expression<Func<string>> bodyvaluecHEQUEchequeNumber, Expression<Func<string>> bodyvaluecHEQUEstatus, Expression<Func<string>> bodyvaluecHEQUEvalue, Expression<Func<string>> bodyvaluecHEQUEissueDate, Expression<Func<string>> bodyvaluecHEQUEdueDate, Expression<Func<string>> bodyvaluecHEQUEseries, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluecHEQUEbank = null, Expression<Func<string>> bodyvaluecHEQUEissuerAddress = null, Expression<Func<string>> bodyvaluecHEQUEissuerName = null, Expression<Func<string>> bodyvaluecHEQUEissuerTelephone = null, Expression<Func<string>> bodyvaluecHEQUEreceiptDate = null, Expression<Func<string>> bodyvaluecHEQUEholderAddress = null, Expression<Func<string>> bodyvaluecHEQUEholderName = null, Expression<Func<string>> bodyvaluecHEQUEissuerTRNo = null, Expression<Func<string>> bodyvaluecHEQUEcomments = null)
        {
            var apiCallPath = "/setCheque";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CHEQUE";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var cHEQUEObject = new JObject();
            var cHEQUEObjectpropCount = 0;
            if (bodyvaluecHEQUEbank != null)
            {
                cHEQUEObject["BANK"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEbank);
                cHEQUEObjectpropCount++;
            }

            cHEQUEObjectpropCount++;
            cHEQUEObject["CHEQUEBAL"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEbalance);
            cHEQUEObjectpropCount++;
            cHEQUEObject["CHEQUENUMBER"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEchequeNumber);
            cHEQUEObjectpropCount++;
            cHEQUEObject["CHEQUESTATES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEstatus);
            cHEQUEObjectpropCount++;
            cHEQUEObject["CHEQUEVAL"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEvalue);
            if (bodyvaluecHEQUEissuerAddress != null)
            {
                cHEQUEObject["CREATORADDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerAddress);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEissuerName != null)
            {
                cHEQUEObject["CREATORNAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerName);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEissuerTelephone != null)
            {
                cHEQUEObject["CREATORPHONE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerTelephone);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEreceiptDate != null)
            {
                cHEQUEObject["CRTDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEreceiptDate);
                cHEQUEObjectpropCount++;
            }

            cHEQUEObjectpropCount++;
            cHEQUEObject["DATEOFS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEissueDate);
            cHEQUEObjectpropCount++;
            cHEQUEObject["FINALDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEdueDate);
            if (bodyvaluecHEQUEholderAddress != null)
            {
                cHEQUEObject["HOLDERADDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEholderAddress);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEholderName != null)
            {
                cHEQUEObject["HOLDERNAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEholderName);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEissuerTRNo != null)
            {
                cHEQUEObject["PUBLISHERAFM"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerTRNo);
                cHEQUEObjectpropCount++;
            }

            if (bodyvaluecHEQUEcomments != null)
            {
                cHEQUEObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEcomments);
                cHEQUEObjectpropCount++;
            }

            cHEQUEObjectpropCount++;
            cHEQUEObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluecHEQUEseries);
            if (cHEQUEObjectpropCount > 0)
            {
                dataObject["CHEQUE"] = cHEQUEObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetContact(Expression<Func<string>> bodyvaluepRSNOUTcode, Expression<Func<string>> bodyvaluepRSNOUTname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluepRSNOUTaddress = null, Expression<Func<string>> bodyvaluepRSNOUTtRNo = null, Expression<Func<string>> bodyvaluepRSNOUTgeographicalAreas = null, Expression<Func<string>> bodyvaluepRSNOUTbIRTHDATE = null, Expression<Func<string>> bodyvaluepRSNOUTcity = null, Expression<Func<string>> bodyvaluepRSNOUTcountry = null, Expression<Func<string>> bodyvaluepRSNOUTarea = null, Expression<Func<string>> bodyvaluepRSNOUTprefecture = null, Expression<Func<string>> bodyvaluepRSNOUTeducationLevel = null, Expression<Func<string>> bodyvaluepRSNOUTemail = null, Expression<Func<string>> bodyvaluepRSNOUTemail2 = null, Expression<Func<string>> bodyvaluepRSNOUTfax = null, Expression<Func<string>> bodyvaluepRSNOUTiDCardNo = null, Expression<Func<string>> bodyvaluepRSNOUTtaxOffice = null, Expression<Func<string>> bodyvaluepRSNOUTmobileTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTsurname = null, Expression<Func<string>> bodyvaluepRSNOUTfatherSName = null, Expression<Func<string>> bodyvaluepRSNOUTmotherSName = null, Expression<Func<string>> bodyvaluepRSNOUTnameOfSpouse = null, Expression<Func<string>> bodyvaluepRSNOUTnationality = null, Expression<Func<string>> bodyvaluepRSNOUTtel1 = null, Expression<Func<string>> bodyvaluepRSNOUTtel2 = null, Expression<Func<string>> bodyvaluepRSNOUTinternalTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTpersonalTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTcomments = null, Expression<Func<bodyvaluepRSNOUTgenderInput>> bodyvaluepRSNOUTgender = null, Expression<Func<string>> bodyvaluepRSNOUTwebPage = null, Expression<Func<string>> bodyvaluepRSNOUTzip = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null)
        {
            var apiCallPath = "/setContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRSNOUT";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var pRSNOUTObject = new JObject();
            var pRSNOUTObjectpropCount = 0;
            if (bodyvaluepRSNOUTaddress != null)
            {
                pRSNOUTObject["ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTaddress);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTtRNo != null)
            {
                pRSNOUTObject["AFM"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTtRNo);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTgeographicalAreas != null)
            {
                pRSNOUTObject["AREAS"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTgeographicalAreas);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTbIRTHDATE != null)
            {
                pRSNOUTObject["BIRTHDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTbIRTHDATE);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTcity != null)
            {
                pRSNOUTObject["CITY"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTcity);
                pRSNOUTObjectpropCount++;
            }

            pRSNOUTObjectpropCount++;
            pRSNOUTObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTcode);
            if (bodyvaluepRSNOUTcountry != null)
            {
                pRSNOUTObject["COUNTRY"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTcountry);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTarea != null)
            {
                pRSNOUTObject["DISTRICT"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTarea);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTprefecture != null)
            {
                pRSNOUTObject["DISTRICT1"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTprefecture);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTeducationLevel != null)
            {
                pRSNOUTObject["EDUCAT"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTeducationLevel);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTemail != null)
            {
                pRSNOUTObject["EMAIL"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTemail);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTemail2 != null)
            {
                pRSNOUTObject["EMAIL1"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTemail2);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTfax != null)
            {
                pRSNOUTObject["FAX"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTfax);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTiDCardNo != null)
            {
                pRSNOUTObject["IDENTITYNUM"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTiDCardNo);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTtaxOffice != null)
            {
                pRSNOUTObject["IRSDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTtaxOffice);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTmobileTelephone != null)
            {
                pRSNOUTObject["MOBILEPHONE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTmobileTelephone);
                pRSNOUTObjectpropCount++;
            }

            pRSNOUTObjectpropCount++;
            pRSNOUTObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTname);
            if (bodyvaluepRSNOUTsurname != null)
            {
                pRSNOUTObject["NAME2"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTsurname);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTfatherSName != null)
            {
                pRSNOUTObject["NAME3"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTfatherSName);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTmotherSName != null)
            {
                pRSNOUTObject["NAME4"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTmotherSName);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTnameOfSpouse != null)
            {
                pRSNOUTObject["NAME5"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTnameOfSpouse);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTnationality != null)
            {
                pRSNOUTObject["NATIONALITY"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTnationality);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTtel1 != null)
            {
                pRSNOUTObject["PHONE1"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTtel1);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTtel2 != null)
            {
                pRSNOUTObject["PHONE2"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTtel2);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTinternalTelephone != null)
            {
                pRSNOUTObject["PHONEEXT"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTinternalTelephone);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTpersonalTelephone != null)
            {
                pRSNOUTObject["PHONELOCAL"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTpersonalTelephone);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTcomments != null)
            {
                pRSNOUTObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTcomments);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTgender != null)
            {
                pRSNOUTObject["SOSEX"] = CSharpExpressionConverter.Convert(bodyvaluepRSNOUTgender);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTwebPage != null)
            {
                pRSNOUTObject["WEBPAGE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTwebPage);
                pRSNOUTObjectpropCount++;
            }

            if (bodyvaluepRSNOUTzip != null)
            {
                pRSNOUTObject["ZIP"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRSNOUTzip);
                pRSNOUTObjectpropCount++;
            }

            if (pRSNOUTObjectpropCount > 0)
            {
                dataObject["PRSNOUT"] = pRSNOUTObject;
                dataObjectpropCount++;
            }

            if (bodyvaluexTRDOCDATA != null)
            {
                dataObject["XTRDOCDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCustomer(Expression<Func<string>> bodyvaluecUSTOMERcode, Expression<Func<string>> bodyvaluecUSTOMERname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluecUSTOMERprimaryAddress = null, Expression<Func<string>> bodyvaluecUSTOMERtRNo = null, Expression<Func<string>> bodyvaluecUSTOMERgeographicalAreas = null, Expression<Func<string>> bodyvaluecUSTOMERcity = null, Expression<Func<int>> bodyvaluecUSTOMERdiscount = null, Expression<Func<string>> bodyvaluecUSTOMERlocationArea = null, Expression<Func<string>> bodyvaluecUSTOMEReMail = null, Expression<Func<string>> bodyvaluecUSTOMERfax = null, Expression<Func<string>> bodyvaluecUSTOMERtaxOffice = null, Expression<Func<string>> bodyvaluecUSTOMERprofession = null, Expression<Func<string>> bodyvaluecUSTOMERprimaryTelephone = null, Expression<Func<string>> bodyvaluecUSTOMERcomments = null, Expression<Func<bodyvaluecUSTOMERtaxCategoryInput>> bodyvaluecUSTOMERtaxCategory = null, Expression<Func<string>> bodyvaluecUSTOMERzip = null)
        {
            var apiCallPath = "/setCustomer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "CUSTOMER";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var cUSTOMERObject = new JObject();
            var cUSTOMERObjectpropCount = 0;
            if (bodyvaluecUSTOMERprimaryAddress != null)
            {
                cUSTOMERObject["ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERprimaryAddress);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERtRNo != null)
            {
                cUSTOMERObject["AFM"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERtRNo);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERgeographicalAreas != null)
            {
                cUSTOMERObject["AREAS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERgeographicalAreas);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERcity != null)
            {
                cUSTOMERObject["CITY"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERcity);
                cUSTOMERObjectpropCount++;
            }

            cUSTOMERObjectpropCount++;
            cUSTOMERObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERcode);
            if (bodyvaluecUSTOMERdiscount != null)
            {
                cUSTOMERObject["DISCOUNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERdiscount);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERlocationArea != null)
            {
                cUSTOMERObject["DISTRICT"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERlocationArea);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMEReMail != null)
            {
                cUSTOMERObject["EMAIL"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMEReMail);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERfax != null)
            {
                cUSTOMERObject["FAX"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERfax);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERtaxOffice != null)
            {
                cUSTOMERObject["IRSDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERtaxOffice);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERprofession != null)
            {
                cUSTOMERObject["JOBTYPETRD"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERprofession);
                cUSTOMERObjectpropCount++;
            }

            cUSTOMERObjectpropCount++;
            cUSTOMERObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERname);
            if (bodyvaluecUSTOMERprimaryTelephone != null)
            {
                cUSTOMERObject["PHONE01"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERprimaryTelephone);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERcomments != null)
            {
                cUSTOMERObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERcomments);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERtaxCategory != null)
            {
                cUSTOMERObject["VATSTS"] = CSharpExpressionConverter.Convert(bodyvaluecUSTOMERtaxCategory);
                cUSTOMERObjectpropCount++;
            }

            if (bodyvaluecUSTOMERzip != null)
            {
                cUSTOMERObject["ZIP"] = CSharpExpressionConverter.ConvertToken(bodyvaluecUSTOMERzip);
                cUSTOMERObjectpropCount++;
            }

            if (cUSTOMERObjectpropCount > 0)
            {
                dataObject["CUSTOMER"] = cUSTOMERObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetDraftEntry(Expression<Func<string>> bodyvaluesODRAFTcode, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluesODRAFTaddress = null, Expression<Func<string>> bodyvaluesODRAFTtRNo = null, Expression<Func<string>> bodyvaluesODRAFTcity = null, Expression<Func<string>> bodyvaluesODRAFTcountry = null, Expression<Func<string>> bodyvaluesODRAFTarea = null, Expression<Func<string>> bodyvaluesODRAFTprefecture = null, Expression<Func<string>> bodyvaluesODRAFTcategory = null, Expression<Func<string>> bodyvaluesODRAFTcompanyEmail = null, Expression<Func<string>> bodyvaluesODRAFTbusinessEmail = null, Expression<Func<string>> bodyvaluesODRAFTpersonalEmail = null, Expression<Func<string>> bodyvaluesODRAFTiDCardNo = null, Expression<Func<string>> bodyvaluesODRAFTactivity = null, Expression<Func<string>> bodyvaluesODRAFTmobileTelephone = null, Expression<Func<string>> bodyvaluesODRAFTnameTitle = null, Expression<Func<string>> bodyvaluesODRAFTfirstName = null, Expression<Func<string>> bodyvaluesODRAFTsurname = null, Expression<Func<string>> bodyvaluesODRAFTzip = null, Expression<Func<string>> bodyvaluesODRAFTbusinessTelephone = null, Expression<Func<string>> bodyvaluesODRAFTinternalTelephone = null, Expression<Func<string>> bodyvaluesODRAFTpersonalTelephone = null, Expression<Func<string>> bodyvaluesODRAFTcomments = null, Expression<Func<string>> bodyvaluesODRAFTtitle = null, Expression<Func<string>> bodyvaluesODRAFTwebPage = null, Expression<Func<string>> bodyvaluesODRAFTzip2 = null, Expression<Func<string>> bodyvaluesODRAFTLNKbranch = null, Expression<Func<string>> bodyvaluesODRAFTLNKbusinessUnit = null, Expression<Func<string>> bodyvaluesODRAFTLNKdepartment = null, Expression<Func<string>> bodyvaluesODRAFTLNKproject = null, Expression<Func<string>> bodyvaluesODRAFTLNKsource = null)
        {
            var apiCallPath = "/setDraftEntry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SODRAFT";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var sODRAFTObject = new JObject();
            var sODRAFTObjectpropCount = 0;
            if (bodyvaluesODRAFTaddress != null)
            {
                sODRAFTObject["ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTaddress);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTtRNo != null)
            {
                sODRAFTObject["AFM"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTtRNo);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTcity != null)
            {
                sODRAFTObject["CITY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcity);
                sODRAFTObjectpropCount++;
            }

            sODRAFTObjectpropCount++;
            sODRAFTObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcode);
            if (bodyvaluesODRAFTcountry != null)
            {
                sODRAFTObject["COUNTRY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcountry);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTarea != null)
            {
                sODRAFTObject["DISTRICT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTarea);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTprefecture != null)
            {
                sODRAFTObject["DISTRICT1"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTprefecture);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTcategory != null)
            {
                sODRAFTObject["DRAFTTYPE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcategory);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTcompanyEmail != null)
            {
                sODRAFTObject["EMAIL"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcompanyEmail);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTbusinessEmail != null)
            {
                sODRAFTObject["EMAIL1"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTbusinessEmail);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTpersonalEmail != null)
            {
                sODRAFTObject["EMAIL2"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTpersonalEmail);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTiDCardNo != null)
            {
                sODRAFTObject["IDENTITYNUM"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTiDCardNo);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTactivity != null)
            {
                sODRAFTObject["JOBTYPETRD"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTactivity);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTmobileTelephone != null)
            {
                sODRAFTObject["MOBILEPHONE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTmobileTelephone);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTnameTitle != null)
            {
                sODRAFTObject["NAMEC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTnameTitle);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTfirstName != null)
            {
                sODRAFTObject["NAMEF"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTfirstName);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTsurname != null)
            {
                sODRAFTObject["NAMEL"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTsurname);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTzip != null)
            {
                sODRAFTObject["NUMCG"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTzip);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTbusinessTelephone != null)
            {
                sODRAFTObject["PHONE1"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTbusinessTelephone);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTinternalTelephone != null)
            {
                sODRAFTObject["PHONEEXT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTinternalTelephone);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTpersonalTelephone != null)
            {
                sODRAFTObject["PHONELOCAL"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTpersonalTelephone);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTcomments != null)
            {
                sODRAFTObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTcomments);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTtitle != null)
            {
                sODRAFTObject["SOTITLENAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTtitle);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTwebPage != null)
            {
                sODRAFTObject["WEBPAGE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTwebPage);
                sODRAFTObjectpropCount++;
            }

            if (bodyvaluesODRAFTzip2 != null)
            {
                sODRAFTObject["ZIP"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTzip2);
                sODRAFTObjectpropCount++;
            }

            if (sODRAFTObjectpropCount > 0)
            {
                dataObject["SODRAFT"] = sODRAFTObject;
                dataObjectpropCount++;
            }

            var sODRAFTLNKObject = new JObject();
            var sODRAFTLNKObjectpropCount = 0;
            if (bodyvaluesODRAFTLNKbranch != null)
            {
                sODRAFTLNKObject["BRANCH"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKbranch);
                sODRAFTLNKObjectpropCount++;
            }

            if (bodyvaluesODRAFTLNKbusinessUnit != null)
            {
                sODRAFTLNKObject["BUSUNITS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKbusinessUnit);
                sODRAFTLNKObjectpropCount++;
            }

            if (bodyvaluesODRAFTLNKdepartment != null)
            {
                sODRAFTLNKObject["DEPART"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKdepartment);
                sODRAFTLNKObjectpropCount++;
            }

            if (bodyvaluesODRAFTLNKproject != null)
            {
                sODRAFTLNKObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKproject);
                sODRAFTLNKObjectpropCount++;
            }

            if (bodyvaluesODRAFTLNKsource != null)
            {
                sODRAFTLNKObject["PRJCLEAD"] = CSharpExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKsource);
                sODRAFTLNKObjectpropCount++;
            }

            if (sODRAFTLNKObjectpropCount > 0)
            {
                dataObject["SODRAFTLNK"] = sODRAFTLNKObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetExpense(Expression<Func<string>> bodyvaluelINEITEMcode, Expression<Func<bodyvaluelINEITEMinvoicingCategoryInput>> bodyvaluelINEITEMinvoicingCategory, Expression<Func<string>> bodyvaluelINEITEMname, Expression<Func<string>> bodyvaluelINEITEMvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluelINEITEMcommercialCategory = null, Expression<Func<bodyvaluelINEITEMtypeInput>> bodyvaluelINEITEMtype = null, Expression<Func<string>> bodyvaluelINEITEMcomments = null, Expression<Func<bodyvaluelINEITEMfeeValueInput>> bodyvaluelINEITEMfeeValue = null)
        {
            var apiCallPath = "/setExpense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "LINEITEM";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var lINEITEMObject = new JObject();
            var lINEITEMObjectpropCount = 0;
            lINEITEMObjectpropCount++;
            lINEITEMObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINEITEMcode);
            lINEITEMObjectpropCount++;
            lINEITEMObject["LISOURCETYPE"] = CSharpExpressionConverter.Convert(bodyvaluelINEITEMinvoicingCategory);
            if (bodyvaluelINEITEMcommercialCategory != null)
            {
                lINEITEMObject["MTRCATEGORY"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINEITEMcommercialCategory);
                lINEITEMObjectpropCount++;
            }

            if (bodyvaluelINEITEMtype != null)
            {
                lINEITEMObject["MTRTYPE"] = CSharpExpressionConverter.Convert(bodyvaluelINEITEMtype);
                lINEITEMObjectpropCount++;
            }

            lINEITEMObjectpropCount++;
            lINEITEMObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINEITEMname);
            if (bodyvaluelINEITEMcomments != null)
            {
                lINEITEMObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINEITEMcomments);
                lINEITEMObjectpropCount++;
            }

            if (bodyvaluelINEITEMfeeValue != null)
            {
                lINEITEMObject["SOPAYVALUE"] = CSharpExpressionConverter.Convert(bodyvaluelINEITEMfeeValue);
                lINEITEMObjectpropCount++;
            }

            lINEITEMObjectpropCount++;
            lINEITEMObject["VAT"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINEITEMvatGroup);
            if (lINEITEMObjectpropCount > 0)
            {
                dataObject["LINEITEM"] = lINEITEMObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetExpensesDoc(Expression<Func<string>> bodyvaluelINSUPDOCseries, Expression<Func<string>> bodyvaluelINSUPDOCsupplier, Expression<Func<bodyvalueunnamedInputItem[]>> bodyvalueunnamed = null, Expression<Func<string>> bodyvaluelINSUPDOCproject = null, Expression<Func<string>> bodyvaluelINSUPDOCcomments = null, Expression<Func<string>> bodyvaluelINSUPDOCtRNDATE = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setExpensesDoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = "702";
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            if (bodyvalueunnamed != null)
            {
                dATAObject["LINLINES"] = CSharpExpressionConverter.ConvertToken(bodyvalueunnamed);
                dATAObjectpropCount++;
            }

            var lINSUPDOCObject = new JObject();
            var lINSUPDOCObjectpropCount = 0;
            if (bodyvaluelINSUPDOCproject != null)
            {
                lINSUPDOCObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINSUPDOCproject);
                lINSUPDOCObjectpropCount++;
            }

            if (bodyvaluelINSUPDOCcomments != null)
            {
                lINSUPDOCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINSUPDOCcomments);
                lINSUPDOCObjectpropCount++;
            }

            lINSUPDOCObjectpropCount++;
            lINSUPDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINSUPDOCseries);
            lINSUPDOCObjectpropCount++;
            lINSUPDOCObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINSUPDOCsupplier);
            if (bodyvaluelINSUPDOCtRNDATE != null)
            {
                lINSUPDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluelINSUPDOCtRNDATE);
                lINSUPDOCObjectpropCount++;
            }

            if (lINSUPDOCObjectpropCount > 0)
            {
                dATAObject["LINSUPDOC"] = lINSUPDOCObject;
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "LINSUPDOC";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetItedoc(Expression<Func<string>> bodyvalueiTEDOCseries, Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvalueiTEDOCreason = null, Expression<Func<string>> bodyvalueiTEDOCrEMARKS = null, Expression<Func<string>> bodyvalueiTEDOCtRNDATE = null, Expression<Func<bodyvalueiTELINESInputItem[]>> bodyvalueiTELINES = null)
        {
            var apiCallPath = "/setItedoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "ITEDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var iTEDOCObject = new JObject();
            var iTEDOCObjectpropCount = 0;
            if (bodyvalueiTEDOCreason != null)
            {
                iTEDOCObject["COMMENTS"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEDOCreason);
                iTEDOCObjectpropCount++;
            }

            if (bodyvalueiTEDOCrEMARKS != null)
            {
                iTEDOCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEDOCrEMARKS);
                iTEDOCObjectpropCount++;
            }

            iTEDOCObjectpropCount++;
            iTEDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEDOCseries);
            if (bodyvalueiTEDOCtRNDATE != null)
            {
                iTEDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEDOCtRNDATE);
                iTEDOCObjectpropCount++;
            }

            if (iTEDOCObjectpropCount > 0)
            {
                dataObject["ITEDOC"] = iTEDOCObject;
                dataObjectpropCount++;
            }

            if (bodyvalueiTELINES != null)
            {
                dataObject["ITELINES"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTELINES);
                dataObjectpropCount++;
            }

            var mTRDOCObject = new JObject();
            var mTRDOCObjectpropCount = 0;
            mTRDOCObjectpropCount++;
            mTRDOCObject["WHOUSE"] = CSharpExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
            if (mTRDOCObjectpropCount > 0)
            {
                dataObject["MTRDOC"] = mTRDOCObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetItem(Expression<Func<string>> bodyvalueiTEMcode, Expression<Func<string>> bodyvalueiTEMbaseUnitOfMeasure, Expression<Func<string>> bodyvalueiTEMname, Expression<Func<string>> bodyvalueiTEMvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvalueiTEMcommercialCategory = null, Expression<Func<string>> bodyvalueiTEMitemGroup = null, Expression<Func<string>> bodyvalueiTEMretailPrice = null, Expression<Func<string>> bodyvalueiTEMwholesalePrice = null, Expression<Func<string>> bodyvalueiTEMcomments = null, Expression<Func<string>> bodyvalueiTEMdiscount1 = null)
        {
            var apiCallPath = "/setItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "ITEM";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var iTEMObject = new JObject();
            var iTEMObjectpropCount = 0;
            iTEMObjectpropCount++;
            iTEMObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMcode);
            if (bodyvalueiTEMcommercialCategory != null)
            {
                iTEMObject["MTRCATEGORY"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMcommercialCategory);
                iTEMObjectpropCount++;
            }

            if (bodyvalueiTEMitemGroup != null)
            {
                iTEMObject["MTRGROUP"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMitemGroup);
                iTEMObjectpropCount++;
            }

            iTEMObjectpropCount++;
            iTEMObject["MTRUNIT1"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMbaseUnitOfMeasure);
            iTEMObjectpropCount++;
            iTEMObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMname);
            if (bodyvalueiTEMretailPrice != null)
            {
                iTEMObject["PRICER"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMretailPrice);
                iTEMObjectpropCount++;
            }

            if (bodyvalueiTEMwholesalePrice != null)
            {
                iTEMObject["PRICEW"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMwholesalePrice);
                iTEMObjectpropCount++;
            }

            if (bodyvalueiTEMcomments != null)
            {
                iTEMObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMcomments);
                iTEMObjectpropCount++;
            }

            if (bodyvalueiTEMdiscount1 != null)
            {
                iTEMObject["SODISCOUNT"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMdiscount1);
                iTEMObjectpropCount++;
            }

            iTEMObjectpropCount++;
            iTEMObject["VAT"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTEMvatGroup);
            if (iTEMObjectpropCount > 0)
            {
                dataObject["ITEM"] = iTEMObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetProject(Expression<Func<string>> bodyvaluepRJCcode, Expression<Func<string>> bodyvaluepRJCname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<bodyvaluepRJCaCTSTATUSInput>> bodyvaluepRJCaCTSTATUS = null, Expression<Func<string>> bodyvaluepRJCfINALDATE = null, Expression<Func<string>> bodyvaluepRJCfROMDATE = null, Expression<Func<bodyvaluepRJCpRJCRMInput>> bodyvaluepRJCpRJCRM = null, Expression<Func<string>> bodyvaluepRJCcomments = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null)
        {
            var apiCallPath = "/setProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PRJC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var pRJCObject = new JObject();
            var pRJCObjectpropCount = 0;
            if (bodyvaluepRJCaCTSTATUS != null)
            {
                pRJCObject["ACTSTATUS"] = CSharpExpressionConverter.Convert(bodyvaluepRJCaCTSTATUS);
                pRJCObjectpropCount++;
            }

            pRJCObjectpropCount++;
            pRJCObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRJCcode);
            if (bodyvaluepRJCfINALDATE != null)
            {
                pRJCObject["FINALDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRJCfINALDATE);
                pRJCObjectpropCount++;
            }

            if (bodyvaluepRJCfROMDATE != null)
            {
                pRJCObject["FROMDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRJCfROMDATE);
                pRJCObjectpropCount++;
            }

            pRJCObjectpropCount++;
            pRJCObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRJCname);
            if (bodyvaluepRJCpRJCRM != null)
            {
                pRJCObject["PRJCRM"] = CSharpExpressionConverter.Convert(bodyvaluepRJCpRJCRM);
                pRJCObjectpropCount++;
            }

            if (bodyvaluepRJCcomments != null)
            {
                pRJCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluepRJCcomments);
                pRJCObjectpropCount++;
            }

            if (pRJCObjectpropCount > 0)
            {
                dataObject["PRJC"] = pRJCObject;
                dataObjectpropCount++;
            }

            if (bodyvaluexTRDOCDATA != null)
            {
                dataObject["XTRDOCDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetPurdoc(Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyvaluepURDOCsERIES, Expression<Func<string>> bodyvaluepURDOCsOCURRENCY, Expression<Func<string>> bodyvaluepURDOCtRDR, Expression<Func<bodyvalueiTELINESInputItem2[]>> bodyvalueiTELINES = null, Expression<Func<string>> bodyvaluepURDOCdISC1PRC = null, Expression<Func<string>> bodyvaluepURDOCpAYMENT = null, Expression<Func<string>> bodyvaluepURDOCpRJC = null, Expression<Func<string>> bodyvaluepURDOCrEMARKS = null, Expression<Func<string>> bodyvaluepURDOCsUMAMNT = null, Expression<Func<string>> bodyvaluepURDOCtRNDATE = null, Expression<Func<bodyvaluesRVLINESInputItem[]>> bodyvaluesRVLINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setPurdoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            if (bodyvalueiTELINES != null)
            {
                dATAObject["ITELINES"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTELINES);
                dATAObjectpropCount++;
            }

            var mTRDOCObject = new JObject();
            var mTRDOCObjectpropCount = 0;
            mTRDOCObjectpropCount++;
            mTRDOCObject["WHOUSE"] = CSharpExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
            if (mTRDOCObjectpropCount > 0)
            {
                dATAObject["MTRDOC"] = mTRDOCObject;
                dATAObjectpropCount++;
            }

            var pURDOCObject = new JObject();
            var pURDOCObjectpropCount = 0;
            if (bodyvaluepURDOCdISC1PRC != null)
            {
                pURDOCObject["DISC1PRC"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCdISC1PRC);
                pURDOCObjectpropCount++;
            }

            if (bodyvaluepURDOCpAYMENT != null)
            {
                pURDOCObject["PAYMENT"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCpAYMENT);
                pURDOCObjectpropCount++;
            }

            if (bodyvaluepURDOCpRJC != null)
            {
                pURDOCObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCpRJC);
                pURDOCObjectpropCount++;
            }

            if (bodyvaluepURDOCrEMARKS != null)
            {
                pURDOCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCrEMARKS);
                pURDOCObjectpropCount++;
            }

            pURDOCObjectpropCount++;
            pURDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCsERIES);
            pURDOCObjectpropCount++;
            pURDOCObject["SOCURRENCY"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCsOCURRENCY);
            if (bodyvaluepURDOCsUMAMNT != null)
            {
                pURDOCObject["SUMAMNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCsUMAMNT);
                pURDOCObjectpropCount++;
            }

            pURDOCObjectpropCount++;
            pURDOCObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCtRDR);
            if (bodyvaluepURDOCtRNDATE != null)
            {
                pURDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluepURDOCtRNDATE);
                pURDOCObjectpropCount++;
            }

            if (pURDOCObjectpropCount > 0)
            {
                dATAObject["PURDOC"] = pURDOCObject;
                dATAObjectpropCount++;
            }

            if (bodyvaluesRVLINES != null)
            {
                dATAObject["SRVLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluesRVLINES);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "PURDOC";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSaldoc(Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyvaluesALDOCpayment, Expression<Func<string>> bodyvaluesALDOCseries, Expression<Func<string>> bodyvaluesALDOCcurrency, Expression<Func<string>> bodyvaluesALDOCcustomer, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<bodyvalueiTELINESInputItem22[]>> bodyvalueiTELINES = null, Expression<Func<string>> bodyvaluesALDOCdiscount = null, Expression<Func<string>> bodyvaluesALDOCdiscountValue = null, Expression<Func<string>> bodyvaluesALDOCnetAmount = null, Expression<Func<string>> bodyvaluesALDOCproject = null, Expression<Func<string>> bodyvaluesALDOCcomments = null, Expression<Func<string>> bodyvaluesALDOCtotal = null, Expression<Func<string>> bodyvaluesALDOCtRNDATE = null, Expression<Func<string>> bodyvaluesALDOCvAT = null, Expression<Func<bodyvaluesRVLINESInputItem2[]>> bodyvaluesRVLINES = null)
        {
            var apiCallPath = "/setSaldoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SALDOC";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodyvalueiTELINES != null)
            {
                dataObject["ITELINES"] = CSharpExpressionConverter.ConvertToken(bodyvalueiTELINES);
                dataObjectpropCount++;
            }

            var mTRDOCObject = new JObject();
            var mTRDOCObjectpropCount = 0;
            mTRDOCObjectpropCount++;
            mTRDOCObject["WHOUSE"] = CSharpExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
            if (mTRDOCObjectpropCount > 0)
            {
                dataObject["MTRDOC"] = mTRDOCObject;
                dataObjectpropCount++;
            }

            var sALDOCObject = new JObject();
            var sALDOCObjectpropCount = 0;
            if (bodyvaluesALDOCdiscount != null)
            {
                sALDOCObject["DISC1PRC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCdiscount);
                sALDOCObjectpropCount++;
            }

            if (bodyvaluesALDOCdiscountValue != null)
            {
                sALDOCObject["DISC1VAL"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCdiscountValue);
                sALDOCObjectpropCount++;
            }

            if (bodyvaluesALDOCnetAmount != null)
            {
                sALDOCObject["NETAMNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCnetAmount);
                sALDOCObjectpropCount++;
            }

            sALDOCObjectpropCount++;
            sALDOCObject["PAYMENT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCpayment);
            if (bodyvaluesALDOCproject != null)
            {
                sALDOCObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCproject);
                sALDOCObjectpropCount++;
            }

            if (bodyvaluesALDOCcomments != null)
            {
                sALDOCObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCcomments);
                sALDOCObjectpropCount++;
            }

            sALDOCObjectpropCount++;
            sALDOCObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCseries);
            sALDOCObjectpropCount++;
            sALDOCObject["SOCURRENCY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCcurrency);
            if (bodyvaluesALDOCtotal != null)
            {
                sALDOCObject["SUMAMNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCtotal);
                sALDOCObjectpropCount++;
            }

            sALDOCObjectpropCount++;
            sALDOCObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCcustomer);
            if (bodyvaluesALDOCtRNDATE != null)
            {
                sALDOCObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCtRNDATE);
                sALDOCObjectpropCount++;
            }

            if (bodyvaluesALDOCvAT != null)
            {
                sALDOCObject["VATAMNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesALDOCvAT);
                sALDOCObjectpropCount++;
            }

            if (sALDOCObjectpropCount > 0)
            {
                dataObject["SALDOC"] = sALDOCObject;
                dataObjectpropCount++;
            }

            if (bodyvaluesRVLINES != null)
            {
                dataObject["SRVLINES"] = CSharpExpressionConverter.ConvertToken(bodyvaluesRVLINES);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetService(Expression<Func<string>> bodyvaluesERVICEcode, Expression<Func<string>> bodyvaluesERVICEbaseUnitOfMeasure, Expression<Func<string>> bodyvaluesERVICEname, Expression<Func<string>> bodyvaluesERVICEvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluesERVICEcommercialCategory = null, Expression<Func<string>> bodyvaluesERVICEserviceGroup = null, Expression<Func<string>> bodyvaluesERVICEretailPrice = null, Expression<Func<string>> bodyvaluesERVICEwholesalePrice = null, Expression<Func<string>> bodyvaluesERVICEcomments = null, Expression<Func<string>> bodyvaluesERVICEdiscount1 = null)
        {
            var apiCallPath = "/setService";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SERVICE";
            bodypropCount++;
            body["appId"] = "702";
            bodypropCount++;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            var sERVICEObject = new JObject();
            var sERVICEObjectpropCount = 0;
            sERVICEObjectpropCount++;
            sERVICEObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEcode);
            if (bodyvaluesERVICEcommercialCategory != null)
            {
                sERVICEObject["MTRCATEGORY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEcommercialCategory);
                sERVICEObjectpropCount++;
            }

            if (bodyvaluesERVICEserviceGroup != null)
            {
                sERVICEObject["MTRGROUP"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEserviceGroup);
                sERVICEObjectpropCount++;
            }

            sERVICEObjectpropCount++;
            sERVICEObject["MTRUNIT1"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEbaseUnitOfMeasure);
            sERVICEObjectpropCount++;
            sERVICEObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEname);
            if (bodyvaluesERVICEretailPrice != null)
            {
                sERVICEObject["PRICER"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEretailPrice);
                sERVICEObjectpropCount++;
            }

            if (bodyvaluesERVICEwholesalePrice != null)
            {
                sERVICEObject["PRICEW"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEwholesalePrice);
                sERVICEObjectpropCount++;
            }

            if (bodyvaluesERVICEcomments != null)
            {
                sERVICEObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEcomments);
                sERVICEObjectpropCount++;
            }

            if (bodyvaluesERVICEdiscount1 != null)
            {
                sERVICEObject["SODISCOUNT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEdiscount1);
                sERVICEObjectpropCount++;
            }

            sERVICEObjectpropCount++;
            sERVICEObject["VAT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesERVICEvatGroup);
            if (sERVICEObjectpropCount > 0)
            {
                dataObject["SERVICE"] = sERVICEObject;
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            body["service"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSOEMAIL(Expression<Func<string>> bodyvaluesOACTIONsERIES, Expression<Func<bodyvaluesOACTIONaCTSTATUSInput>> bodyvaluesOACTIONaCTSTATUS = null, Expression<Func<string>> bodyvaluesOACTIONcOMMENTS = null, Expression<Func<string>> bodyvaluesOACTIONtRNDATE = null, Expression<Func<string>> bodyvaluesOMAILfROMADDRESS = null, Expression<Func<string>> bodyvaluesOMAILfROMNAME = null, Expression<Func<string>> bodyvaluesOMAILsOBCC = null, Expression<Func<string>> bodyvaluesOMAILsOBODY = null, Expression<Func<string>> bodyvaluesOMAILsOCC = null, Expression<Func<string>> bodyvaluesOMAILsOTO = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSomail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            var sOACTIONObject = new JObject();
            var sOACTIONObjectpropCount = 0;
            if (bodyvaluesOACTIONaCTSTATUS != null)
            {
                sOACTIONObject["ACTSTATUS"] = CSharpExpressionConverter.Convert(bodyvaluesOACTIONaCTSTATUS);
                sOACTIONObjectpropCount++;
            }

            if (bodyvaluesOACTIONcOMMENTS != null)
            {
                sOACTIONObject["COMMENTS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOACTIONcOMMENTS);
                sOACTIONObjectpropCount++;
            }

            sOACTIONObjectpropCount++;
            sOACTIONObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOACTIONsERIES);
            if (bodyvaluesOACTIONtRNDATE != null)
            {
                sOACTIONObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOACTIONtRNDATE);
                sOACTIONObjectpropCount++;
            }

            if (sOACTIONObjectpropCount > 0)
            {
                dATAObject["SOACTION"] = sOACTIONObject;
                dATAObjectpropCount++;
            }

            var sOMAILObject = new JObject();
            var sOMAILObjectpropCount = 0;
            if (bodyvaluesOMAILfROMADDRESS != null)
            {
                sOMAILObject["FROMADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILfROMADDRESS);
                sOMAILObjectpropCount++;
            }

            if (bodyvaluesOMAILfROMNAME != null)
            {
                sOMAILObject["FROMNAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILfROMNAME);
                sOMAILObjectpropCount++;
            }

            if (bodyvaluesOMAILsOBCC != null)
            {
                sOMAILObject["SOBCC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILsOBCC);
                sOMAILObjectpropCount++;
            }

            if (bodyvaluesOMAILsOBODY != null)
            {
                sOMAILObject["SOBODY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILsOBODY);
                sOMAILObjectpropCount++;
            }

            if (bodyvaluesOMAILsOCC != null)
            {
                sOMAILObject["SOCC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILsOCC);
                sOMAILObjectpropCount++;
            }

            if (bodyvaluesOMAILsOTO != null)
            {
                sOMAILObject["SOTO"] = CSharpExpressionConverter.ConvertToken(bodyvaluesOMAILsOTO);
                sOMAILObjectpropCount++;
            }

            if (sOMAILObjectpropCount > 0)
            {
                dATAObject["SOMAIL"] = sOMAILObject;
                dATAObjectpropCount++;
            }

            if (bodyvaluexTRDOCDATA != null)
            {
                dATAObject["XTRDOCDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOEMAIL";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetMeeting(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONoperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSomeeting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            var sOACTIONObject = new JObject();
            var sOACTIONObjectpropCount = 0;
            if (bodydATAsOACTIONoperator != null)
            {
                sOACTIONObject["ACTOR"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONoperator);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONoperatorContact != null)
            {
                sOACTIONObject["ACTPRSN"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONoperatorContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONaCTSTATUS != null)
            {
                sOACTIONObject["ACTSTATUS"] = CSharpExpressionConverter.Convert(bodydATAsOACTIONaCTSTATUS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONcOMMENTS != null)
            {
                sOACTIONObject["COMMENTS"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONcOMMENTS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfINALDATE != null)
            {
                sOACTIONObject["FINALDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONfINALDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfROMDATE != null)
            {
                sOACTIONObject["FROMDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONfROMDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedBy != null)
            {
                sOACTIONObject["ORDEREDBY"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONorderedBy);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedByContact != null)
            {
                sOACTIONObject["ORDPRSN"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONorderedByContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONpriority != null)
            {
                sOACTIONObject["PRIORITY"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONpriority);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONproject != null)
            {
                sOACTIONObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONproject);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONrEMARKS != null)
            {
                sOACTIONObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONrEMARKS);
                sOACTIONObjectpropCount++;
            }

            sOACTIONObjectpropCount++;
            sOACTIONObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONsERIES);
            if (bodydATAsOACTIONtRDR != null)
            {
                sOACTIONObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONtRDR);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONtRNDATE != null)
            {
                sOACTIONObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONtRNDATE);
                sOACTIONObjectpropCount++;
            }

            if (sOACTIONObjectpropCount > 0)
            {
                dATAObject["SOACTION"] = sOACTIONObject;
                dATAObjectpropCount++;
            }

            if (bodydATAxTRDOCDATA != null)
            {
                dATAObject["XTRDOCDATA"] = CSharpExpressionConverter.ConvertToken(bodydATAxTRDOCDATA);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOMEETING";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSOTASK(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONoperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSotask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            var sOACTIONObject = new JObject();
            var sOACTIONObjectpropCount = 0;
            if (bodydATAsOACTIONoperator != null)
            {
                sOACTIONObject["ACTOR"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONoperator);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONoperatorContact != null)
            {
                sOACTIONObject["ACTPRSN"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONoperatorContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONaCTSTATUS != null)
            {
                sOACTIONObject["ACTSTATUS"] = CSharpExpressionConverter.Convert(bodydATAsOACTIONaCTSTATUS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONcOMMENTS != null)
            {
                sOACTIONObject["COMMENTS"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONcOMMENTS);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfINALDATE != null)
            {
                sOACTIONObject["FINALDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONfINALDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONfROMDATE != null)
            {
                sOACTIONObject["FROMDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONfROMDATE);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedBy != null)
            {
                sOACTIONObject["ORDEREDBY"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONorderedBy);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONorderedByContact != null)
            {
                sOACTIONObject["ORDPRSN"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONorderedByContact);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONpriority != null)
            {
                sOACTIONObject["PRIORITY"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONpriority);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONproject != null)
            {
                sOACTIONObject["PRJC"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONproject);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONrEMARKS != null)
            {
                sOACTIONObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONrEMARKS);
                sOACTIONObjectpropCount++;
            }

            sOACTIONObjectpropCount++;
            sOACTIONObject["SERIES"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONsERIES);
            if (bodydATAsOACTIONtRDR != null)
            {
                sOACTIONObject["TRDR"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONtRDR);
                sOACTIONObjectpropCount++;
            }

            if (bodydATAsOACTIONtRNDATE != null)
            {
                sOACTIONObject["TRNDATE"] = CSharpExpressionConverter.ConvertToken(bodydATAsOACTIONtRNDATE);
                sOACTIONObjectpropCount++;
            }

            if (sOACTIONObjectpropCount > 0)
            {
                dATAObject["SOACTION"] = sOACTIONObject;
                dATAObjectpropCount++;
            }

            if (bodydATAxTRDOCDATA != null)
            {
                dATAObject["XTRDOCDATA"] = CSharpExpressionConverter.ConvertToken(bodydATAxTRDOCDATA);
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SOTASK";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSupplier(Expression<Func<string>> bodyvaluesUPPLIERcODE, Expression<Func<string>> bodyvaluesUPPLIERnAME, Expression<Func<bodyvaluesUPBANKACCInputItem[]>> bodyvaluesUPBANKACC = null, Expression<Func<string>> bodyvaluesUPPLIERaDDRESS = null, Expression<Func<string>> bodyvaluesUPPLIERaFM = null, Expression<Func<string>> bodyvaluesUPPLIERcITY = null, Expression<Func<string>> bodyvaluesUPPLIERdISTRICT = null, Expression<Func<string>> bodyvaluesUPPLIEReMAIL = null, Expression<Func<string>> bodyvaluesUPPLIERfAX = null, Expression<Func<string>> bodyvaluesUPPLIERiRSDATA = null, Expression<Func<string>> bodyvaluesUPPLIERjOBTYPETRD = null, Expression<Func<string>> bodyvaluesUPPLIERpHONE01 = null, Expression<Func<string>> bodyvaluesUPPLIERrEMARKS = null, Expression<Func<string>> bodyvaluesUPPLIERzIP = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var apiCallPath = "/setSupplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("s1service");
            var body = new JObject();
            var bodypropCount = 0;
            body["APPID"] = 702;
            bodypropCount++;
            var dATAObject = new JObject();
            var dATAObjectpropCount = 0;
            if (bodyvaluesUPBANKACC != null)
            {
                dATAObject["SUPBANKACC"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPBANKACC);
                dATAObjectpropCount++;
            }

            var sUPPLIERObject = new JObject();
            var sUPPLIERObjectpropCount = 0;
            if (bodyvaluesUPPLIERaDDRESS != null)
            {
                sUPPLIERObject["ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERaDDRESS);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERaFM != null)
            {
                sUPPLIERObject["AFM"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERaFM);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERcITY != null)
            {
                sUPPLIERObject["CITY"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERcITY);
                sUPPLIERObjectpropCount++;
            }

            sUPPLIERObjectpropCount++;
            sUPPLIERObject["CODE"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERcODE);
            if (bodyvaluesUPPLIERdISTRICT != null)
            {
                sUPPLIERObject["DISTRICT"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERdISTRICT);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIEReMAIL != null)
            {
                sUPPLIERObject["EMAIL"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIEReMAIL);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERfAX != null)
            {
                sUPPLIERObject["FAX"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERfAX);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERiRSDATA != null)
            {
                sUPPLIERObject["IRSDATA"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERiRSDATA);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERjOBTYPETRD != null)
            {
                sUPPLIERObject["JOBTYPETRD"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERjOBTYPETRD);
                sUPPLIERObjectpropCount++;
            }

            sUPPLIERObjectpropCount++;
            sUPPLIERObject["NAME"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERnAME);
            if (bodyvaluesUPPLIERpHONE01 != null)
            {
                sUPPLIERObject["PHONE01"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERpHONE01);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERrEMARKS != null)
            {
                sUPPLIERObject["REMARKS"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERrEMARKS);
                sUPPLIERObjectpropCount++;
            }

            if (bodyvaluesUPPLIERzIP != null)
            {
                sUPPLIERObject["ZIP"] = CSharpExpressionConverter.ConvertToken(bodyvaluesUPPLIERzIP);
                sUPPLIERObjectpropCount++;
            }

            if (sUPPLIERObjectpropCount > 0)
            {
                dATAObject["SUPPLIER"] = sUPPLIERObject;
                dATAObjectpropCount++;
            }

            if (dATAObjectpropCount > 0)
            {
                body["DATA"] = dATAObject;
                bodypropCount++;
            }

            if (bodyfORM != null)
            {
                body["FORM"] = CSharpExpressionConverter.ConvertToken(bodyfORM);
                bodypropCount++;
            }

            if (bodykEY != null)
            {
                body["KEY"] = CSharpExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
            }

            body["MODE"] = "1";
            bodypropCount++;
            body["OBJECT"] = "SUPPLIER";
            bodypropCount++;
            body["SERVICE"] = "setData";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetData200response>(callPayload);
        }
    }

    public class Soft1Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Webhook(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = CSharpExpressionConverter.ConvertToken(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONPOST";
            bodypropCount++;
            bodypropCount++;
            body["object"] = CSharpExpressionConverter.Convert(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnDelete(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onDelete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = CSharpExpressionConverter.ConvertToken(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONDELETE";
            bodypropCount++;
            bodypropCount++;
            body["object"] = CSharpExpressionConverter.Convert(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnInsert(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onInsert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = CSharpExpressionConverter.ConvertToken(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONINSERT";
            bodypropCount++;
            bodypropCount++;
            body["object"] = CSharpExpressionConverter.Convert(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnUpdate(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/onUpdate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["op"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycondition != null)
            {
                body["condition"] = CSharpExpressionConverter.ConvertToken(bodycondition);
                bodypropCount++;
            }

            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                body["config"] = configObject;
                bodypropCount++;
            }

            body["event"] = "ONUPDATE";
            bodypropCount++;
            bodypropCount++;
            body["object"] = CSharpExpressionConverter.Convert(bodyObject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class GetCFNCUSDOCResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCFNCUSDOCResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCFNCUSDOCResponseValueType
    {
        public GetCFNCUSDOCResponseValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public GetCFNCUSDOCResponseValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty("CFNCUSDOC")]
        public GetCFNCUSDOCResponseValueTypeCollectionsDocumentType CollectionsDocument { get; set; }
        public GetCFNCUSDOCResponseValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public string CREDITCARDS { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCASHLINESTypeItem
    {
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string SOCURRENCY { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCollectionsDocumentType
    {
        public string COLLECTOR { get; set; }

        [JsonProperty("COLLECTOR_PRSNIN_NAME2")]
        public string COLLECTORPRSNINNAME2 { get; set; }
        public string COMPANY { get; set; }
        public string FINCODE { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }
        public string REMARKS { get; set; }
        public string SALESMAN { get; set; }

        [JsonProperty("SALESMAN_PRSNIN_NAME2")]
        public string SALESMANPRSNINNAME2 { get; set; }
        public string SERIES { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TRDRTRDRCODE { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TRDRTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetCFNCUSDOCResponseValueTypeCHEQUELINESTypeItem
    {
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public string CSERIES { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string TPRMS { get; set; }
    }

    public class GetCfnsupdocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCfnsupdocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCfnsupdocResponseValueType
    {
        public GetCfnsupdocResponseValueTypeCARDLINESTypeItem[] CARDLINES { get; set; }
        public GetCfnsupdocResponseValueTypeCASHLINESTypeItem[] CASHLINES { get; set; }

        [JsonProperty("CFNSUPDOC")]
        public GetCfnsupdocResponseValueTypePaymentsDocumentType PaymentsDocument { get; set; }
        public GetCfnsupdocResponseValueTypeCHEQUELINESTypeItem[] CHEQUELINES { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCARDLINESTypeItem
    {
        public string CRDCARDNUM { get; set; }
        public string CREDITCARDS { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCASHLINESTypeItem
    {
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string SOCURRENCY { get; set; }
    }

    public class GetCfnsupdocResponseValueTypePaymentsDocumentType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }
        public string COMPANY { get; set; }
        public string FINCODE { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }
        public string SERIES { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_TRDR_ADDRESS")]
        public string TRDRTRDRADDRESS { get; set; }

        [JsonProperty("TRDR_TRDR_AFM")]
        public string TRDRTRDRAFM { get; set; }

        [JsonProperty("TRDR_TRDR_CODE")]
        public string TRDRTRDRCODE { get; set; }

        [JsonProperty("TRDR_TRDR_IRSDATA")]
        public string TRDRTRDRIRSDATA { get; set; }

        [JsonProperty("TRDR_TRDR_NAME")]
        public string TRDRTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetCfnsupdocResponseValueTypeCHEQUELINESTypeItem
    {
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public string CSERIES { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string TPRMS { get; set; }
    }

    public class GetChequeResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetChequeResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetChequeResponseValueType
    {
        [JsonProperty("CHEQUE")]
        public GetChequeResponseValueTypeChequeType Cheque { get; set; }
    }

    public class GetChequeResponseValueTypeChequeType
    {
        [JsonProperty("BANK")]
        public string Bank { get; set; }

        [JsonProperty("BANK_BANK_CODE")]
        public string BankCode { get; set; }

        [JsonProperty("BANK_BANK_NAME")]
        public string BankName { get; set; }

        [JsonProperty("CHEQUEBAL")]
        public string Balance { get; set; }

        [JsonProperty("CHEQUENUMBER")]
        public string Number { get; set; }

        [JsonProperty("CHEQUESTATES")]
        public string State { get; set; }

        [JsonProperty("CHEQUEVAL")]
        public string Value { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("CREATORADDR")]
        public string IssuerAddress { get; set; }

        [JsonProperty("CREATORNAME")]
        public string IssuerName { get; set; }
        public string CREATORPHONE { get; set; }

        [JsonProperty("CRTDATE")]
        public string ReceiptDate { get; set; }

        [JsonProperty("DATEOFS")]
        public string IssueDate { get; set; }

        [JsonProperty("FINALDATE")]
        public string DueDate { get; set; }

        [JsonProperty("HOLDERADDR")]
        public string HolderAddress { get; set; }

        [JsonProperty("HOLDERNAME")]
        public string HolderName { get; set; }

        [JsonProperty("PUBLISHERAFM")]
        public string IssuerTRNo { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("TRDRPOSSESSOR_TRDR_CODE")]
        public string HolderCode { get; set; }

        [JsonProperty("TRDRPUBLISHER_TRDR_CODE")]
        public string IssuerCode { get; set; }
    }

    public class GetContactResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetContactResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetContactResponseDataType
    {
        [JsonProperty("PRSNOUT")]
        public GetContactResponseDataTypeContactType Contact { get; set; }
        public GetContactResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetContactResponseDataTypeContactType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalArea { get; set; }

        [JsonProperty("BIRTHDATE")]
        public string DateOfBirth { get; set; }

        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("EMAIL")]
        public string FirstEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string SecondEmail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IDCardNo { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NAME2")]
        public string Surname { get; set; }

        [JsonProperty("NATIONALITY")]
        public string Nationality { get; set; }

        [JsonProperty("PHONE1")]
        public string Tel1 { get; set; }

        [JsonProperty("PHONE2")]
        public string Tel2 { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOSEX")]
        public string Gender { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetContactResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetCustomerResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetCustomerResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetCustomerResponseValueType
    {
        [JsonProperty("CUSTOMER")]
        public GetCustomerResponseValueTypeCustomerType Customer { get; set; }
    }

    public class GetCustomerResponseValueTypeCustomerType
    {
        [JsonProperty("ADDRESS")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("AREAS")]
        public string GeographicalArea { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("DISCOUNT")]
        public string Discount { get; set; }

        [JsonProperty("DISTRICT")]
        public string LocationArea { get; set; }

        [JsonProperty("EMAIL")]
        public string EMail { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("IRSDATA")]
        public string TaxOffice { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Profession { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("PHONE01")]
        public string PrimaryTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("VATSTS")]
        public string TaxCategory { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    public class GetDraftEntryResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetDraftEntryResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetDraftEntryResponseValueType
    {
        public GetDraftEntryResponseValueTypeSODRAFTType SODRAFT { get; set; }
        public GetDraftEntryResponseValueTypeSODRAFTLNKType SODRAFTLNK { get; set; }
    }

    public class GetDraftEntryResponseValueTypeSODRAFTType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("AFM")]
        public string TRNo { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("COUNTRY")]
        public string Country { get; set; }

        [JsonProperty("DISTRICT")]
        public string Area { get; set; }

        [JsonProperty("DISTRICT1")]
        public string Prefecture { get; set; }

        [JsonProperty("DRAFTTYPE")]
        public string Category { get; set; }

        [JsonProperty("EMAIL")]
        public string CompanyEmail { get; set; }

        [JsonProperty("EMAIL1")]
        public string BusinessEmail { get; set; }

        [JsonProperty("EMAIL2")]
        public string PersonalEmail { get; set; }

        [JsonProperty("IDENTITYNUM")]
        public string IDCardNo { get; set; }

        [JsonProperty("JOBTYPETRD")]
        public string Activity { get; set; }

        [JsonProperty("MOBILEPHONE")]
        public string MobileTelephone { get; set; }

        [JsonProperty("NAMEC")]
        public string NameTitle { get; set; }

        [JsonProperty("NAMEF")]
        public string FirstName { get; set; }

        [JsonProperty("NAMEL")]
        public string Surname { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }

        [JsonProperty("PHONE1")]
        public string BusinessTelephone { get; set; }

        [JsonProperty("PHONEEXT")]
        public string InternalTelephone { get; set; }

        [JsonProperty("PHONELOCAL")]
        public string PersonalTelephone { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOTITLENAME")]
        public string Title { get; set; }

        [JsonProperty("WEBPAGE")]
        public string WebPage { get; set; }
    }

    public class GetDraftEntryResponseValueTypeSODRAFTLNKType
    {
        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("BUSUNITS")]
        public string BusinessUnit { get; set; }

        [JsonProperty("DEPART")]
        public string Department { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }

        [JsonProperty("PRJCLEAD")]
        public string Source { get; set; }
    }

    public class GetExpenseResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetExpenseResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetExpenseResponseValueType
    {
        [JsonProperty("LINEITEM")]
        public GetExpenseResponseValueTypeExpenseType Expense { get; set; }
    }

    public class GetExpenseResponseValueTypeExpenseType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("LISOURCETYPE")]
        public string InvoicingCategory { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRTYPE")]
        public string Type { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SOPAYVALUE")]
        public string FeeValue { get; set; }

        [JsonProperty("VAT")]
        public string VATGroup { get; set; }
    }

    public class GetExpensesDocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetExpensesDocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetExpensesDocResponseValueType
    {
        public GetExpensesDocResponseValueTypeLINLINESTypeItem[] LINLINES { get; set; }

        [JsonProperty("LINSUPDOC")]
        public GetExpensesDocResponseValueTypeExpensesDocumentType ExpensesDocument { get; set; }
    }

    public class GetExpensesDocResponseValueTypeLINLINESTypeItem
    {
        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("VAT")]
        public string VATID { get; set; }

        [JsonProperty("VATAMNT")]
        public string VATAmount { get; set; }
    }

    public class GetExpensesDocResponseValueTypeExpensesDocumentType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string SumAmount { get; set; }

        [JsonProperty("TRDR")]
        public string SupplierID { get; set; }

        [JsonProperty("TRDR_SUPPLIER_AFM")]
        public string SupplierTRNo { get; set; }

        [JsonProperty("TRDR_SUPPLIER_NAME")]
        public string SupplierName { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }

        [JsonProperty("VATAMNT")]
        public string VATAmount { get; set; }
    }

    public class GetItedocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetItedocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetItedocResponseValueType
    {
        public GetItedocResponseValueTypeITEDOCType ITEDOC { get; set; }
        public GetItedocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetItedocResponseValueTypeMTRDOCType MTRDOC { get; set; }
    }

    public class GetItedocResponseValueTypeITEDOCType
    {
        [JsonProperty("COMMENTS")]
        public string Reason { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }
    }

    public class GetItedocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public string QTY { get; set; }
    }

    public class GetItedocResponseValueTypeMTRDOCType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetItemResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetItemResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetItemResponseValueType
    {
        [JsonProperty("ITEM")]
        public GetItemResponseValueTypeItemType Item { get; set; }
    }

    public class GetItemResponseValueTypeItemType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ItemGroup { get; set; }

        [JsonProperty("MTRUNIT1")]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
        public string SODISCOUNT { get; set; }

        [JsonProperty("VAT")]
        public string VATGroup { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("data")]
        public GetProjectResponseDataType Data { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetProjectResponseDataType
    {
        [JsonProperty("PRJC")]
        public GetProjectResponseDataTypeProjectType Project { get; set; }
        public GetProjectResponseDataTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetProjectResponseDataTypeProjectType
    {
        public string ACTSTATUS { get; set; }

        [JsonProperty("CODE")]
        public string Code { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("PRJC")]
        public string Name { get; set; }
        public string PRJCRM { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
    }

    public class GetProjectResponseDataTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetPurdocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetPurdocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetPurdocResponseValueType
    {
        public GetPurdocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetPurdocResponseValueTypeMTRDOCType MTRDOC { get; set; }

        [JsonProperty("PURDOC")]
        public GetPurdocResponseValueTypePurchasesDocumentType PurchasesDocument { get; set; }
        public GetPurdocResponseValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
        public GetPurdocResponseValueTypeVATANALTypeItem[] VATANAL { get; set; }
    }

    public class GetPurdocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string MTRLITEMCODE { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string MTRLITEMNAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetPurdocResponseValueTypeMTRDOCType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetPurdocResponseValueTypePurchasesDocumentType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }
        public string DISC1PRC { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("FPRMS")]
        public string Type { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }
        public string PAYMENT { get; set; }
        public string PRJC { get; set; }

        [JsonProperty("PRJC_PRJC_CODE")]
        public string PRJCPRJCCODE { get; set; }

        [JsonProperty("PRJC_PRJC_NAME")]
        public string PRJCPRJCNAME { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
        public string SERIES { get; set; }

        [JsonProperty("SHIPKIND")]
        public string PurposeOfDelivery { get; set; }
        public string SOCURRENCY { get; set; }
        public string SUMAMNT { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_SUPPLIER_ADDRESS")]
        public string SupplierAddress { get; set; }

        [JsonProperty("TRDR_SUPPLIER_AFM")]
        public string TRDRSUPPLIERAFM { get; set; }

        [JsonProperty("TRDR_SUPPLIER_CODE")]
        public string TRDRSUPPLIERCODE { get; set; }

        [JsonProperty("TRDR_SUPPLIER_IRSDATA")]
        public string SupplierTaxOffice { get; set; }

        [JsonProperty("TRDR_SUPPLIER_JOBTYPETRD")]
        public string SupplierProfession { get; set; }

        [JsonProperty("TRDR_SUPPLIER_NAME")]
        public string TRDRSUPPLIERNAME { get; set; }

        [JsonProperty("TRDR_SUPPLIER_PHONE01")]
        public string SupplierPhone { get; set; }
        public string TRNDATE { get; set; }
        public string VATAMNT { get; set; }
    }

    public class GetPurdocResponseValueTypeSRVLINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MTRLSERVICECODE { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MTRLSERVICENAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetPurdocResponseValueTypeVATANALTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVAT { get; set; }

        [JsonProperty("VAT")]
        public string IDAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetSaldocResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSaldocResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSaldocResponseValueType
    {
        public GetSaldocResponseValueTypeITELINESTypeItem[] ITELINES { get; set; }
        public GetSaldocResponseValueTypeMTRDOCType MTRDOC { get; set; }
        public GetSaldocResponseValueTypeSALDOCType SALDOC { get; set; }
        public GetSaldocResponseValueTypeSRVLINESTypeItem[] SRVLINES { get; set; }
        public GetSaldocResponseValueTypeVATANALTypeItem[] VATANAL { get; set; }
    }

    public class GetSaldocResponseValueTypeITELINESTypeItem
    {
        public string DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNumber { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_ITEM_CODE")]
        public string Code { get; set; }

        [JsonProperty("MTRL_ITEM_NAME")]
        public string ItemName { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public string QTY { get; set; }
    }

    public class GetSaldocResponseValueTypeMTRDOCType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DELIVDATE")]
        public string DeliveryDate { get; set; }

        [JsonProperty("SHIPPINGADDR")]
        public string ShippingAddress { get; set; }

        [JsonProperty("WHOUSE")]
        public string Warehouse { get; set; }
    }

    public class GetSaldocResponseValueTypeSALDOCType
    {
        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("DISC1PRC")]
        public string Disc1prc { get; set; }

        [JsonProperty("DISC1VAL")]
        public string DiscountValue { get; set; }

        [JsonProperty("EXPN")]
        public string Expenses { get; set; }
        public string FINCODE { get; set; }

        [JsonProperty("FPRMS")]
        public string Type { get; set; }

        [JsonProperty("NETAMNT")]
        public string NetAmount { get; set; }

        [JsonProperty("PAYMENT")]
        public string Payment { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }

        [JsonProperty("SERIES")]
        public string Series { get; set; }

        [JsonProperty("SHIPKIND")]
        public string PurposeOfDelivery { get; set; }

        [JsonProperty("SOCURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("SUMAMNT")]
        public string SumAmount { get; set; }

        [JsonProperty("TRDR")]
        public string CustomerID { get; set; }

        [JsonProperty("TRDR_CUSTOMER_ADDRESS")]
        public string CustomerAddress { get; set; }

        [JsonProperty("TRDR_CUSTOMER_AFM")]
        public string CustomerTRNo { get; set; }

        [JsonProperty("TRDR_CUSTOMER_CODE")]
        public string CustomerCode { get; set; }

        [JsonProperty("TRDR_CUSTOMER_IRSDATA")]
        public string CustomerTaxOffice { get; set; }

        [JsonProperty("TRDR_CUSTOMER_JOBTYPETRD")]
        public string CustomerProfession { get; set; }

        [JsonProperty("TRDR_CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [JsonProperty("TRDR_CUSTOMER_PHONE01")]
        public string CustomerPhone { get; set; }

        [JsonProperty("TRNDATE")]
        public string Date { get; set; }

        [JsonProperty("VATAMNT")]
        public string VATAmount { get; set; }
    }

    public class GetSaldocResponseValueTypeSRVLINESTypeItem
    {
        public string DISC1PRC { get; set; }
        public string LINENUM { get; set; }
        public string LINEVAL { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("MTRL_SERVICE_CODE")]
        public string MTRLSERVICECODE { get; set; }

        [JsonProperty("MTRL_SERVICE_NAME")]
        public string MTRLSERVICENAME { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
    }

    public class GetSaldocResponseValueTypeVATANALTypeItem
    {
        [JsonProperty("SUBVAL")]
        public string ValueSubjectToVAT { get; set; }

        [JsonProperty("VAT")]
        public string IDAndCategory { get; set; }

        [JsonProperty("VATVAL")]
        public string Value { get; set; }

        [JsonProperty("VAT_VAT_PERCNT")]
        public string Percent { get; set; }
    }

    public class GetServiceResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetServiceResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetServiceResponseValueType
    {
        [JsonProperty("SERVICE")]
        public GetServiceResponseValueTypeServiceType Service { get; set; }
    }

    public class GetServiceResponseValueTypeServiceType
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }

        [JsonProperty("MTRCATEGORY")]
        public string CommercialCategory { get; set; }

        [JsonProperty("MTRGROUP")]
        public string ServiceGroup { get; set; }

        [JsonProperty("MTRUNIT1")]
        public string BaseUnitOfMeasure { get; set; }

        [JsonProperty("NAME")]
        public string Description { get; set; }

        [JsonProperty("PRICER")]
        public string RetailPrice { get; set; }

        [JsonProperty("PRICEW")]
        public string WholesalePrice { get; set; }

        [JsonProperty("REMARKS")]
        public string Comments { get; set; }
        public string SODISCOUNT { get; set; }

        [JsonProperty("VAT")]
        public string VATGroup { get; set; }
    }

    public class GetSOEMAILResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSOEMAILResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSOEMAILResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSOEMAILResponseValueTypeEmailTaskType EmailTask { get; set; }
        public GetSOEMAILResponseValueTypeSOMAILType SOMAIL { get; set; }
        public GetSOEMAILResponseValueTypeXTRDOCDATATypeItem[] XTRDOCDATA { get; set; }
    }

    public class GetSOEMAILResponseValueTypeEmailTaskType
    {
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetSOEMAILResponseValueTypeSOMAILType
    {
        public string FROMADDRESS { get; set; }
        public string FROMNAME { get; set; }
        public string MAILDATE { get; set; }
        public string SOBCC { get; set; }
        public string SOBODY { get; set; }
        public string SOCC { get; set; }
        public string SOTO { get; set; }
    }

    public class GetSOEMAILResponseValueTypeXTRDOCDATATypeItem
    {
        public string LINENUM { get; set; }
        public string NAME { get; set; }
        public string SOFNAME { get; set; }
    }

    public class GetMeetingResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetMeetingResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetMeetingResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetMeetingResponseValueTypeMeetingType Meeting { get; set; }
    }

    public class GetMeetingResponseValueTypeMeetingType
    {
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetSOTASKResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSOTASKResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSOTASKResponseValueType
    {
        [JsonProperty("SOACTION")]
        public GetSOTASKResponseValueTypeTaskObjectType TaskObject { get; set; }
    }

    public class GetSOTASKResponseValueTypeTaskObjectType
    {
        public string ACTOR { get; set; }

        [JsonProperty("ACTPRSN")]
        public string OperatorContact { get; set; }
        public string ACTSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FINALDATE { get; set; }
        public string FROMDATE { get; set; }
        public string ORDEREDBY { get; set; }

        [JsonProperty("ORDPRSN")]
        public string OrderedByContact { get; set; }

        [JsonProperty("PRIORITY")]
        public string Priority { get; set; }

        [JsonProperty("PRJC")]
        public string Project { get; set; }
        public string REMARKS { get; set; }
        public string SERIES { get; set; }
        public string TASKCOMPLETE { get; set; }
        public string TRDR { get; set; }

        [JsonProperty("TRDR_GENTRDR_NAME")]
        public string TRDRGENTRDRNAME { get; set; }
        public string TRNDATE { get; set; }
    }

    public class GetSupplierResponse
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("remoteKey")]
        public string RemoteKey { get; set; }

        [JsonProperty("data")]
        public GetSupplierResponseValueType Value { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSupplierResponseValueType
    {
        public GetSupplierResponseValueTypeSUPBANKACCTypeItem[] SUPBANKACC { get; set; }
        public GetSupplierResponseValueTypeSUPPLIERType SUPPLIER { get; set; }
    }

    public class GetSupplierResponseValueTypeSUPBANKACCTypeItem
    {
        public string BANK { get; set; }

        [JsonProperty("BANK_BANK_CODE")]
        public string BANKBANKCODE { get; set; }
        public string IBAN { get; set; }
        public string LINENUM { get; set; }
        public string REMARKS { get; set; }
    }

    public class GetSupplierResponseValueTypeSUPPLIERType
    {
        public string ADDRESS { get; set; }
        public string AFM { get; set; }
        public string CITY { get; set; }
        public string CODE { get; set; }
        public string DISTRICT { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string IRSDATA { get; set; }

        [JsonProperty("ISACTIVE")]
        public string Active { get; set; }
        public string JOBTYPETRD { get; set; }
        public string NAME { get; set; }
        public string PHONE01 { get; set; }
        public string REMARKS { get; set; }
        public string VATSTS { get; set; }
        public string ZIP { get; set; }
    }

    public class GetSystemParamsResponse
    {
        [JsonProperty("companyinfo")]
        public GetSystemParamsResponseCompanyType Company { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetSystemParamsResponseCompanyType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("afm")]
        public string TRNo { get; set; }

        [JsonProperty("branch")]
        public GetSystemParamsResponseCompanyTypeBranchType Branch { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Logo { get; set; }

        [JsonProperty("irsdata")]
        public string TaxOffice { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class GetSystemParamsResponseCompanyTypeBranchType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("district")]
        public string LocationArea { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class SetData200response
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorcode")]
        public int ErrorCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class bodyvaluecARDLINESInputItem
    {
        public string CRDCARDNUM { get; set; }
        public int CREDITCARDS { get; set; }
        public int LINENUM { get; set; }
        public int LINEVAL { get; set; }
    }

    public class bodyvaluecASHLINESInputItem
    {
        public int LINENUM { get; set; }
        public int LINEVAL { get; set; }
    }

    public class bodyvaluecHEQUELINESInputItem
    {
        public string CCHEQUENUMBER { get; set; }
        public string CFINALDATE { get; set; }
        public string CODE { get; set; }
        public int CSERIES { get; set; }

        [JsonProperty("LINENUM")]
        public int ChequeLineNumber { get; set; }
        public int LINEVAL { get; set; }

        [JsonProperty("TPRMS")]
        public int ChequeTransactionType { get; set; }
    }

    public class bodyvaluecASHLINESInputItem2
    {
        [JsonProperty("LINENUM")]
        public int CashLineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public int CashLineValue { get; set; }
    }

    public enum bodyvaluepRSNOUTgenderInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class bodyvaluexTRDOCDATAInputItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public enum bodyvaluecUSTOMERtaxCategoryInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public enum bodyvaluelINEITEMinvoicingCategoryInput
    {
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16
    }

    public enum bodyvaluelINEITEMtypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public enum bodyvaluelINEITEMfeeValueInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public class bodyvalueunnamedInputItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Expense { get; set; }

        [JsonProperty("VAT")]
        public string Item { get; set; }
    }

    public class bodyvalueiTELINESInputItem
    {
        [JsonProperty("DISC1PRC")]
        public string Discount { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Item { get; set; }
        public string PRICE { get; set; }

        [JsonProperty("QTY")]
        public string Quantity { get; set; }
    }

    public enum bodyvaluepRJCaCTSTATUSInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public enum bodyvaluepRJCpRJCRMInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class bodyvalueiTELINESInputItem2
    {
        public int DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }
        public string PRICE { get; set; }
        public int QTY { get; set; }
    }

    public class bodyvaluesRVLINESInputItem
    {
        public int DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }
        public string PRICE { get; set; }
        public int QTY { get; set; }
    }

    public class bodyvalueiTELINESInputItem22
    {
        [JsonProperty("DISC1PRC")]
        public string Discount { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }

        [JsonProperty("MTRL")]
        public string Item { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }

        [JsonProperty("QTY")]
        public string Quantity { get; set; }
    }

    public class bodyvaluesRVLINESInputItem2
    {
        public int DISC1PRC { get; set; }

        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("LINEVAL")]
        public string LineValue { get; set; }
        public string MTRL { get; set; }

        [JsonProperty("PRICE")]
        public string Price { get; set; }
        public int QTY { get; set; }
    }

    public enum bodyvaluesOACTIONaCTSTATUSInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public enum bodydATAsOACTIONaCTSTATUSInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public class bodydATAxTRDOCDATAInputItem
    {
        [JsonProperty("LINENUM")]
        public string LineNo { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("SOFNAME")]
        public string Url { get; set; }
    }

    public class bodyvaluesUPBANKACCInputItem
    {
        public string BANK { get; set; }
        public string IBAN { get; set; }
        public string REMARKS { get; set; }
    }

    public enum bodyObjectInput
    {
        Cheque,
        [EnumMember(Value = "Collections document")]
        CollectionsDocument,
        Contacts,
        Customer,
        [EnumMember(Value = "Draft entry")]
        DraftEntry,
        Email,
        Expenses,
        [EnumMember(Value = "Expenses document")]
        ExpensesDocument,
        Meeting,
        Item,
        [EnumMember(Value = "Payments document")]
        PaymentsDocument,
        Projects,
        [EnumMember(Value = "Purchases document")]
        PurchasesDocument,
        [EnumMember(Value = "Sales document")]
        SalesDocument,
        Services,
        [EnumMember(Value = "Stock document")]
        StockDocument,
        Supplier,
        [EnumMember(Value = "Task")]
        TaskObject
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Soft1;

    public partial class WorkflowManagedActions
    {
        public Soft1Actions Soft1(string connectionId) => new Soft1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Soft1Triggers Soft1(string connectionId) => new Soft1Triggers(connectionId);
    }
}