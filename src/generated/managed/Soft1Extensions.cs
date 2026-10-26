//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Soft1
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Soft1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Microservice(Expression<Func<string>> bodybody, Expression<Func<string>> bodyendpoint)
        {
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: true);
            var __workflow_bodyendpoint = WorkflowExpression.Compile(bodyendpoint, nameof(bodyendpoint), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("microservice");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                bodypropCount++;
                body["endpoint"] = ExpressionConverter.ConvertO(__workflow_bodyendpoint);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCFNCUSDOCResponse, ApiConnectionActionConfiguration> GetCFNCUSDOC(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCFNCUSDOCResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCFNCUSDOC";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfnsupdocResponse, ApiConnectionActionConfiguration> GetCfnsupdoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCfnsupdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCfnsupdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetChequeResponse, ApiConnectionActionConfiguration> GetCheque(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetChequeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetContactResponse, ApiConnectionActionConfiguration> GetContact(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = 702;
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCustomerResponse, ApiConnectionActionConfiguration> GetCustomer(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetDraftEntryResponse, ApiConnectionActionConfiguration> GetDraftEntry(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetDraftEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = 702;
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpenseResponse, ApiConnectionActionConfiguration> GetExpense(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetExpenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpensesDocResponse, ApiConnectionActionConfiguration> GetExpensesDoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodylOCATEINFO = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: false);
            return new DeferredBodyAction<GetExpensesDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getExpensesDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = "702";
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                if (__workflow_bodylOCATEINFO != null)
                {
                    if (__workflow_bodylOCATEINFO != null)
                    {
                        body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItedocResponse, ApiConnectionActionConfiguration> GetItedoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetItedocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItemResponse, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = 702;
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetPurdocResponse, ApiConnectionActionConfiguration> GetPurdoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetPurdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getPurdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = 702;
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSaldocResponse, ApiConnectionActionConfiguration> GetSaldoc(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSaldocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetServiceResponse, ApiConnectionActionConfiguration> GetService(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetServiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOEMAILResponse, ApiConnectionActionConfiguration> GetSOEMAIL(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSOEMAILResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSoemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetMeetingResponse, ApiConnectionActionConfiguration> GetMeeting(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSomeeting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOTASKResponse, ApiConnectionActionConfiguration> GetSOTASK(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSOTASKResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSupplierResponse, ApiConnectionActionConfiguration> GetSupplier(Expression<Func<string>> bodykEY, Expression<Func<string>> bodylOCATEINFO, Expression<Func<string>> bodyfORM = null)
        {
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: true);
            var __workflow_bodylOCATEINFO = WorkflowExpression.Compile(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSupplierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getSupplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                body["APPID"] = 702;
                bodypropCount++;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATEINFO);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSystemParamsResponse, ApiConnectionActionConfiguration> GetSystemParams()
        {
            return new DeferredBodyAction<GetSystemParamsResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCFNCUSDOC(Expression<Func<string>> bodyvaluecFNCUSDOCsERIES, Expression<Func<string>> bodyvaluecFNCUSDOCtRDR, Expression<Func<bodyvaluecARDLINESInputItem[]>> bodyvaluecARDLINES = null, Expression<Func<bodyvaluecASHLINESInputItem[]>> bodyvaluecASHLINES = null, Expression<Func<string>> bodyvaluecFNCUSDOCcOLLECTOR = null, Expression<Func<string>> bodyvaluecFNCUSDOCcOMMENTS = null, Expression<Func<string>> bodyvaluecFNCUSDOCproject = null, Expression<Func<string>> bodyvaluecFNCUSDOCsALESMAN = null, Expression<Func<string>> bodyvaluecFNCUSDOCtRNDATE = null, Expression<Func<bodyvaluecHEQUELINESInputItem[]>> bodyvaluecHEQUELINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluecFNCUSDOCsERIES = WorkflowExpression.Compile(bodyvaluecFNCUSDOCsERIES, nameof(bodyvaluecFNCUSDOCsERIES), required: true);
            var __workflow_bodyvaluecFNCUSDOCtRDR = WorkflowExpression.Compile(bodyvaluecFNCUSDOCtRDR, nameof(bodyvaluecFNCUSDOCtRDR), required: true);
            var __workflow_bodyvaluecARDLINES = WorkflowExpression.Compile(bodyvaluecARDLINES, nameof(bodyvaluecARDLINES), required: false);
            var __workflow_bodyvaluecASHLINES = WorkflowExpression.Compile(bodyvaluecASHLINES, nameof(bodyvaluecASHLINES), required: false);
            var __workflow_bodyvaluecFNCUSDOCcOLLECTOR = WorkflowExpression.Compile(bodyvaluecFNCUSDOCcOLLECTOR, nameof(bodyvaluecFNCUSDOCcOLLECTOR), required: false);
            var __workflow_bodyvaluecFNCUSDOCcOMMENTS = WorkflowExpression.Compile(bodyvaluecFNCUSDOCcOMMENTS, nameof(bodyvaluecFNCUSDOCcOMMENTS), required: false);
            var __workflow_bodyvaluecFNCUSDOCproject = WorkflowExpression.Compile(bodyvaluecFNCUSDOCproject, nameof(bodyvaluecFNCUSDOCproject), required: false);
            var __workflow_bodyvaluecFNCUSDOCsALESMAN = WorkflowExpression.Compile(bodyvaluecFNCUSDOCsALESMAN, nameof(bodyvaluecFNCUSDOCsALESMAN), required: false);
            var __workflow_bodyvaluecFNCUSDOCtRNDATE = WorkflowExpression.Compile(bodyvaluecFNCUSDOCtRNDATE, nameof(bodyvaluecFNCUSDOCtRNDATE), required: false);
            var __workflow_bodyvaluecHEQUELINES = WorkflowExpression.Compile(bodyvaluecHEQUELINES, nameof(bodyvaluecHEQUELINES), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvaluecARDLINES != null)
                {
                    dATAObject["CARDLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNCUSDOCObject = new JObject();
                var cFNCUSDOCObjectpropCount = 0;
                if (__workflow_bodyvaluecFNCUSDOCcOLLECTOR != null)
                {
                    cFNCUSDOCObject["COLLECTOR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCcOLLECTOR);
                    cFNCUSDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluecFNCUSDOCcOMMENTS != null)
                {
                    cFNCUSDOCObject["COMMENTS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCcOMMENTS);
                    cFNCUSDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluecFNCUSDOCproject != null)
                {
                    cFNCUSDOCObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCproject);
                    cFNCUSDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluecFNCUSDOCsALESMAN != null)
                {
                    cFNCUSDOCObject["SALESMAN"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCsALESMAN);
                    cFNCUSDOCObjectpropCount++;
                }

                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCsERIES);
                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCtRDR);
                if (__workflow_bodyvaluecFNCUSDOCtRNDATE != null)
                {
                    cFNCUSDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNCUSDOCtRNDATE);
                    cFNCUSDOCObjectpropCount++;
                }

                if (cFNCUSDOCObjectpropCount > 0)
                {
                    dATAObject["CFNCUSDOC"] = cFNCUSDOCObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCfnsupdoc(Expression<Func<string>> bodyvaluecFNSUPDOCsERIES, Expression<Func<string>> bodyvaluecFNSUPDOCtRDR, Expression<Func<bodyvaluecARDLINESInputItem[]>> bodyvaluecARDLINES = null, Expression<Func<bodyvaluecASHLINESInputItem2[]>> bodyvaluecASHLINES = null, Expression<Func<string>> bodyvaluecFNSUPDOCpRJC = null, Expression<Func<string>> bodyvaluecFNSUPDOCrEMARKS = null, Expression<Func<string>> bodyvaluecFNSUPDOCtRNDATE = null, Expression<Func<bodyvaluecHEQUELINESInputItem[]>> bodyvaluecHEQUELINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluecFNSUPDOCsERIES = WorkflowExpression.Compile(bodyvaluecFNSUPDOCsERIES, nameof(bodyvaluecFNSUPDOCsERIES), required: true);
            var __workflow_bodyvaluecFNSUPDOCtRDR = WorkflowExpression.Compile(bodyvaluecFNSUPDOCtRDR, nameof(bodyvaluecFNSUPDOCtRDR), required: true);
            var __workflow_bodyvaluecARDLINES = WorkflowExpression.Compile(bodyvaluecARDLINES, nameof(bodyvaluecARDLINES), required: false);
            var __workflow_bodyvaluecASHLINES = WorkflowExpression.Compile(bodyvaluecASHLINES, nameof(bodyvaluecASHLINES), required: false);
            var __workflow_bodyvaluecFNSUPDOCpRJC = WorkflowExpression.Compile(bodyvaluecFNSUPDOCpRJC, nameof(bodyvaluecFNSUPDOCpRJC), required: false);
            var __workflow_bodyvaluecFNSUPDOCrEMARKS = WorkflowExpression.Compile(bodyvaluecFNSUPDOCrEMARKS, nameof(bodyvaluecFNSUPDOCrEMARKS), required: false);
            var __workflow_bodyvaluecFNSUPDOCtRNDATE = WorkflowExpression.Compile(bodyvaluecFNSUPDOCtRNDATE, nameof(bodyvaluecFNSUPDOCtRNDATE), required: false);
            var __workflow_bodyvaluecHEQUELINES = WorkflowExpression.Compile(bodyvaluecHEQUELINES, nameof(bodyvaluecHEQUELINES), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvaluecARDLINES != null)
                {
                    dATAObject["CARDLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNSUPDOCObject = new JObject();
                var cFNSUPDOCObjectpropCount = 0;
                if (__workflow_bodyvaluecFNSUPDOCpRJC != null)
                {
                    cFNSUPDOCObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNSUPDOCpRJC);
                    cFNSUPDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluecFNSUPDOCrEMARKS != null)
                {
                    cFNSUPDOCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNSUPDOCrEMARKS);
                    cFNSUPDOCObjectpropCount++;
                }

                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNSUPDOCsERIES);
                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNSUPDOCtRDR);
                if (__workflow_bodyvaluecFNSUPDOCtRNDATE != null)
                {
                    cFNSUPDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecFNSUPDOCtRNDATE);
                    cFNSUPDOCObjectpropCount++;
                }

                if (cFNSUPDOCObjectpropCount > 0)
                {
                    dATAObject["CFNSUPDOC"] = cFNSUPDOCObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCheque(Expression<Func<string>> bodyvaluecHEQUEbalance, Expression<Func<string>> bodyvaluecHEQUEchequeNumber, Expression<Func<string>> bodyvaluecHEQUEstatus, Expression<Func<string>> bodyvaluecHEQUEvalue, Expression<Func<string>> bodyvaluecHEQUEissueDate, Expression<Func<string>> bodyvaluecHEQUEdueDate, Expression<Func<string>> bodyvaluecHEQUEseries, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluecHEQUEbank = null, Expression<Func<string>> bodyvaluecHEQUEissuerAddress = null, Expression<Func<string>> bodyvaluecHEQUEissuerName = null, Expression<Func<string>> bodyvaluecHEQUEissuerTelephone = null, Expression<Func<string>> bodyvaluecHEQUEreceiptDate = null, Expression<Func<string>> bodyvaluecHEQUEholderAddress = null, Expression<Func<string>> bodyvaluecHEQUEholderName = null, Expression<Func<string>> bodyvaluecHEQUEissuerTRNo = null, Expression<Func<string>> bodyvaluecHEQUEcomments = null)
        {
            var __workflow_bodyvaluecHEQUEbalance = WorkflowExpression.Compile(bodyvaluecHEQUEbalance, nameof(bodyvaluecHEQUEbalance), required: true);
            var __workflow_bodyvaluecHEQUEchequeNumber = WorkflowExpression.Compile(bodyvaluecHEQUEchequeNumber, nameof(bodyvaluecHEQUEchequeNumber), required: true);
            var __workflow_bodyvaluecHEQUEstatus = WorkflowExpression.Compile(bodyvaluecHEQUEstatus, nameof(bodyvaluecHEQUEstatus), required: true);
            var __workflow_bodyvaluecHEQUEvalue = WorkflowExpression.Compile(bodyvaluecHEQUEvalue, nameof(bodyvaluecHEQUEvalue), required: true);
            var __workflow_bodyvaluecHEQUEissueDate = WorkflowExpression.Compile(bodyvaluecHEQUEissueDate, nameof(bodyvaluecHEQUEissueDate), required: true);
            var __workflow_bodyvaluecHEQUEdueDate = WorkflowExpression.Compile(bodyvaluecHEQUEdueDate, nameof(bodyvaluecHEQUEdueDate), required: true);
            var __workflow_bodyvaluecHEQUEseries = WorkflowExpression.Compile(bodyvaluecHEQUEseries, nameof(bodyvaluecHEQUEseries), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluecHEQUEbank = WorkflowExpression.Compile(bodyvaluecHEQUEbank, nameof(bodyvaluecHEQUEbank), required: false);
            var __workflow_bodyvaluecHEQUEissuerAddress = WorkflowExpression.Compile(bodyvaluecHEQUEissuerAddress, nameof(bodyvaluecHEQUEissuerAddress), required: false);
            var __workflow_bodyvaluecHEQUEissuerName = WorkflowExpression.Compile(bodyvaluecHEQUEissuerName, nameof(bodyvaluecHEQUEissuerName), required: false);
            var __workflow_bodyvaluecHEQUEissuerTelephone = WorkflowExpression.Compile(bodyvaluecHEQUEissuerTelephone, nameof(bodyvaluecHEQUEissuerTelephone), required: false);
            var __workflow_bodyvaluecHEQUEreceiptDate = WorkflowExpression.Compile(bodyvaluecHEQUEreceiptDate, nameof(bodyvaluecHEQUEreceiptDate), required: false);
            var __workflow_bodyvaluecHEQUEholderAddress = WorkflowExpression.Compile(bodyvaluecHEQUEholderAddress, nameof(bodyvaluecHEQUEholderAddress), required: false);
            var __workflow_bodyvaluecHEQUEholderName = WorkflowExpression.Compile(bodyvaluecHEQUEholderName, nameof(bodyvaluecHEQUEholderName), required: false);
            var __workflow_bodyvaluecHEQUEissuerTRNo = WorkflowExpression.Compile(bodyvaluecHEQUEissuerTRNo, nameof(bodyvaluecHEQUEissuerTRNo), required: false);
            var __workflow_bodyvaluecHEQUEcomments = WorkflowExpression.Compile(bodyvaluecHEQUEcomments, nameof(bodyvaluecHEQUEcomments), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvaluecHEQUEbank != null)
                {
                    cHEQUEObject["BANK"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEbank);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEBAL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEbalance);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUENUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEchequeNumber);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUESTATES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEstatus);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEVAL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEvalue);
                if (__workflow_bodyvaluecHEQUEissuerAddress != null)
                {
                    cHEQUEObject["CREATORADDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEissuerAddress);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEissuerName != null)
                {
                    cHEQUEObject["CREATORNAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEissuerName);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEissuerTelephone != null)
                {
                    cHEQUEObject["CREATORPHONE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEissuerTelephone);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEreceiptDate != null)
                {
                    cHEQUEObject["CRTDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEreceiptDate);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["DATEOFS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEissueDate);
                cHEQUEObjectpropCount++;
                cHEQUEObject["FINALDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEdueDate);
                if (__workflow_bodyvaluecHEQUEholderAddress != null)
                {
                    cHEQUEObject["HOLDERADDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEholderAddress);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEholderName != null)
                {
                    cHEQUEObject["HOLDERNAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEholderName);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEissuerTRNo != null)
                {
                    cHEQUEObject["PUBLISHERAFM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEissuerTRNo);
                    cHEQUEObjectpropCount++;
                }

                if (__workflow_bodyvaluecHEQUEcomments != null)
                {
                    cHEQUEObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEcomments);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecHEQUEseries);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetContact(Expression<Func<string>> bodyvaluepRSNOUTcode, Expression<Func<string>> bodyvaluepRSNOUTname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluepRSNOUTaddress = null, Expression<Func<string>> bodyvaluepRSNOUTtRNo = null, Expression<Func<string>> bodyvaluepRSNOUTgeographicalAreas = null, Expression<Func<string>> bodyvaluepRSNOUTbIRTHDATE = null, Expression<Func<string>> bodyvaluepRSNOUTcity = null, Expression<Func<string>> bodyvaluepRSNOUTcountry = null, Expression<Func<string>> bodyvaluepRSNOUTarea = null, Expression<Func<string>> bodyvaluepRSNOUTprefecture = null, Expression<Func<string>> bodyvaluepRSNOUTeducationLevel = null, Expression<Func<string>> bodyvaluepRSNOUTemail = null, Expression<Func<string>> bodyvaluepRSNOUTemail2 = null, Expression<Func<string>> bodyvaluepRSNOUTfax = null, Expression<Func<string>> bodyvaluepRSNOUTidCardNo = null, Expression<Func<string>> bodyvaluepRSNOUTtaxOffice = null, Expression<Func<string>> bodyvaluepRSNOUTmobileTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTsurname = null, Expression<Func<string>> bodyvaluepRSNOUTfatherSName = null, Expression<Func<string>> bodyvaluepRSNOUTmotherSName = null, Expression<Func<string>> bodyvaluepRSNOUTnameOfSpouse = null, Expression<Func<string>> bodyvaluepRSNOUTnationality = null, Expression<Func<string>> bodyvaluepRSNOUTtel1 = null, Expression<Func<string>> bodyvaluepRSNOUTtel2 = null, Expression<Func<string>> bodyvaluepRSNOUTinternalTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTpersonalTelephone = null, Expression<Func<string>> bodyvaluepRSNOUTcomments = null, Expression<Func<bodyvaluepRSNOUTgenderInput>> bodyvaluepRSNOUTgender = null, Expression<Func<string>> bodyvaluepRSNOUTwebPage = null, Expression<Func<string>> bodyvaluepRSNOUTzip = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null)
        {
            var __workflow_bodyvaluepRSNOUTcode = WorkflowExpression.Compile(bodyvaluepRSNOUTcode, nameof(bodyvaluepRSNOUTcode), required: true);
            var __workflow_bodyvaluepRSNOUTname = WorkflowExpression.Compile(bodyvaluepRSNOUTname, nameof(bodyvaluepRSNOUTname), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluepRSNOUTaddress = WorkflowExpression.Compile(bodyvaluepRSNOUTaddress, nameof(bodyvaluepRSNOUTaddress), required: false);
            var __workflow_bodyvaluepRSNOUTtRNo = WorkflowExpression.Compile(bodyvaluepRSNOUTtRNo, nameof(bodyvaluepRSNOUTtRNo), required: false);
            var __workflow_bodyvaluepRSNOUTgeographicalAreas = WorkflowExpression.Compile(bodyvaluepRSNOUTgeographicalAreas, nameof(bodyvaluepRSNOUTgeographicalAreas), required: false);
            var __workflow_bodyvaluepRSNOUTbIRTHDATE = WorkflowExpression.Compile(bodyvaluepRSNOUTbIRTHDATE, nameof(bodyvaluepRSNOUTbIRTHDATE), required: false);
            var __workflow_bodyvaluepRSNOUTcity = WorkflowExpression.Compile(bodyvaluepRSNOUTcity, nameof(bodyvaluepRSNOUTcity), required: false);
            var __workflow_bodyvaluepRSNOUTcountry = WorkflowExpression.Compile(bodyvaluepRSNOUTcountry, nameof(bodyvaluepRSNOUTcountry), required: false);
            var __workflow_bodyvaluepRSNOUTarea = WorkflowExpression.Compile(bodyvaluepRSNOUTarea, nameof(bodyvaluepRSNOUTarea), required: false);
            var __workflow_bodyvaluepRSNOUTprefecture = WorkflowExpression.Compile(bodyvaluepRSNOUTprefecture, nameof(bodyvaluepRSNOUTprefecture), required: false);
            var __workflow_bodyvaluepRSNOUTeducationLevel = WorkflowExpression.Compile(bodyvaluepRSNOUTeducationLevel, nameof(bodyvaluepRSNOUTeducationLevel), required: false);
            var __workflow_bodyvaluepRSNOUTemail = WorkflowExpression.Compile(bodyvaluepRSNOUTemail, nameof(bodyvaluepRSNOUTemail), required: false);
            var __workflow_bodyvaluepRSNOUTemail2 = WorkflowExpression.Compile(bodyvaluepRSNOUTemail2, nameof(bodyvaluepRSNOUTemail2), required: false);
            var __workflow_bodyvaluepRSNOUTfax = WorkflowExpression.Compile(bodyvaluepRSNOUTfax, nameof(bodyvaluepRSNOUTfax), required: false);
            var __workflow_bodyvaluepRSNOUTidCardNo = WorkflowExpression.Compile(bodyvaluepRSNOUTidCardNo, nameof(bodyvaluepRSNOUTidCardNo), required: false);
            var __workflow_bodyvaluepRSNOUTtaxOffice = WorkflowExpression.Compile(bodyvaluepRSNOUTtaxOffice, nameof(bodyvaluepRSNOUTtaxOffice), required: false);
            var __workflow_bodyvaluepRSNOUTmobileTelephone = WorkflowExpression.Compile(bodyvaluepRSNOUTmobileTelephone, nameof(bodyvaluepRSNOUTmobileTelephone), required: false);
            var __workflow_bodyvaluepRSNOUTsurname = WorkflowExpression.Compile(bodyvaluepRSNOUTsurname, nameof(bodyvaluepRSNOUTsurname), required: false);
            var __workflow_bodyvaluepRSNOUTfatherSName = WorkflowExpression.Compile(bodyvaluepRSNOUTfatherSName, nameof(bodyvaluepRSNOUTfatherSName), required: false);
            var __workflow_bodyvaluepRSNOUTmotherSName = WorkflowExpression.Compile(bodyvaluepRSNOUTmotherSName, nameof(bodyvaluepRSNOUTmotherSName), required: false);
            var __workflow_bodyvaluepRSNOUTnameOfSpouse = WorkflowExpression.Compile(bodyvaluepRSNOUTnameOfSpouse, nameof(bodyvaluepRSNOUTnameOfSpouse), required: false);
            var __workflow_bodyvaluepRSNOUTnationality = WorkflowExpression.Compile(bodyvaluepRSNOUTnationality, nameof(bodyvaluepRSNOUTnationality), required: false);
            var __workflow_bodyvaluepRSNOUTtel1 = WorkflowExpression.Compile(bodyvaluepRSNOUTtel1, nameof(bodyvaluepRSNOUTtel1), required: false);
            var __workflow_bodyvaluepRSNOUTtel2 = WorkflowExpression.Compile(bodyvaluepRSNOUTtel2, nameof(bodyvaluepRSNOUTtel2), required: false);
            var __workflow_bodyvaluepRSNOUTinternalTelephone = WorkflowExpression.Compile(bodyvaluepRSNOUTinternalTelephone, nameof(bodyvaluepRSNOUTinternalTelephone), required: false);
            var __workflow_bodyvaluepRSNOUTpersonalTelephone = WorkflowExpression.Compile(bodyvaluepRSNOUTpersonalTelephone, nameof(bodyvaluepRSNOUTpersonalTelephone), required: false);
            var __workflow_bodyvaluepRSNOUTcomments = WorkflowExpression.Compile(bodyvaluepRSNOUTcomments, nameof(bodyvaluepRSNOUTcomments), required: false);
            var __workflow_bodyvaluepRSNOUTgender = WorkflowExpression.Compile(bodyvaluepRSNOUTgender, nameof(bodyvaluepRSNOUTgender), required: false);
            var __workflow_bodyvaluepRSNOUTwebPage = WorkflowExpression.Compile(bodyvaluepRSNOUTwebPage, nameof(bodyvaluepRSNOUTwebPage), required: false);
            var __workflow_bodyvaluepRSNOUTzip = WorkflowExpression.Compile(bodyvaluepRSNOUTzip, nameof(bodyvaluepRSNOUTzip), required: false);
            var __workflow_bodyvaluexTRDOCDATA = WorkflowExpression.Compile(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvaluepRSNOUTaddress != null)
                {
                    pRSNOUTObject["ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTaddress);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTtRNo != null)
                {
                    pRSNOUTObject["AFM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTtRNo);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTgeographicalAreas != null)
                {
                    pRSNOUTObject["AREAS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTgeographicalAreas);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTbIRTHDATE != null)
                {
                    pRSNOUTObject["BIRTHDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTbIRTHDATE);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTcity != null)
                {
                    pRSNOUTObject["CITY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTcity);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTcode);
                if (__workflow_bodyvaluepRSNOUTcountry != null)
                {
                    pRSNOUTObject["COUNTRY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTcountry);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTarea != null)
                {
                    pRSNOUTObject["DISTRICT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTarea);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTprefecture != null)
                {
                    pRSNOUTObject["DISTRICT1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTprefecture);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTeducationLevel != null)
                {
                    pRSNOUTObject["EDUCAT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTeducationLevel);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTemail != null)
                {
                    pRSNOUTObject["EMAIL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTemail);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTemail2 != null)
                {
                    pRSNOUTObject["EMAIL1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTemail2);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTfax != null)
                {
                    pRSNOUTObject["FAX"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTfax);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTidCardNo != null)
                {
                    pRSNOUTObject["IDENTITYNUM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTidCardNo);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTtaxOffice != null)
                {
                    pRSNOUTObject["IRSDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTtaxOffice);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTmobileTelephone != null)
                {
                    pRSNOUTObject["MOBILEPHONE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTmobileTelephone);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTname);
                if (__workflow_bodyvaluepRSNOUTsurname != null)
                {
                    pRSNOUTObject["NAME2"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTsurname);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTfatherSName != null)
                {
                    pRSNOUTObject["NAME3"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTfatherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTmotherSName != null)
                {
                    pRSNOUTObject["NAME4"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTmotherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTnameOfSpouse != null)
                {
                    pRSNOUTObject["NAME5"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTnameOfSpouse);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTnationality != null)
                {
                    pRSNOUTObject["NATIONALITY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTnationality);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTtel1 != null)
                {
                    pRSNOUTObject["PHONE1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTtel1);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTtel2 != null)
                {
                    pRSNOUTObject["PHONE2"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTtel2);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTinternalTelephone != null)
                {
                    pRSNOUTObject["PHONEEXT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTinternalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTpersonalTelephone != null)
                {
                    pRSNOUTObject["PHONELOCAL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTpersonalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTcomments != null)
                {
                    pRSNOUTObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTcomments);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTgender != null)
                {
                    pRSNOUTObject["SOSEX"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTgender);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTwebPage != null)
                {
                    pRSNOUTObject["WEBPAGE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTwebPage);
                    pRSNOUTObjectpropCount++;
                }

                if (__workflow_bodyvaluepRSNOUTzip != null)
                {
                    pRSNOUTObject["ZIP"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRSNOUTzip);
                    pRSNOUTObjectpropCount++;
                }

                if (pRSNOUTObjectpropCount > 0)
                {
                    dataObject["PRSNOUT"] = pRSNOUTObject;
                    dataObjectpropCount++;
                }

                if (__workflow_bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluexTRDOCDATA);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetCustomer(Expression<Func<string>> bodyvaluecUSTOMERcode, Expression<Func<string>> bodyvaluecUSTOMERname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluecUSTOMERprimaryAddress = null, Expression<Func<string>> bodyvaluecUSTOMERtRNo = null, Expression<Func<string>> bodyvaluecUSTOMERgeographicalAreas = null, Expression<Func<string>> bodyvaluecUSTOMERcity = null, Expression<Func<int>> bodyvaluecUSTOMERdiscount = null, Expression<Func<string>> bodyvaluecUSTOMERlocationArea = null, Expression<Func<string>> bodyvaluecUSTOMEReMail = null, Expression<Func<string>> bodyvaluecUSTOMERfax = null, Expression<Func<string>> bodyvaluecUSTOMERtaxOffice = null, Expression<Func<string>> bodyvaluecUSTOMERprofession = null, Expression<Func<string>> bodyvaluecUSTOMERprimaryTelephone = null, Expression<Func<string>> bodyvaluecUSTOMERcomments = null, Expression<Func<bodyvaluecUSTOMERtaxCategoryInput>> bodyvaluecUSTOMERtaxCategory = null, Expression<Func<string>> bodyvaluecUSTOMERzip = null)
        {
            var __workflow_bodyvaluecUSTOMERcode = WorkflowExpression.Compile(bodyvaluecUSTOMERcode, nameof(bodyvaluecUSTOMERcode), required: true);
            var __workflow_bodyvaluecUSTOMERname = WorkflowExpression.Compile(bodyvaluecUSTOMERname, nameof(bodyvaluecUSTOMERname), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluecUSTOMERprimaryAddress = WorkflowExpression.Compile(bodyvaluecUSTOMERprimaryAddress, nameof(bodyvaluecUSTOMERprimaryAddress), required: false);
            var __workflow_bodyvaluecUSTOMERtRNo = WorkflowExpression.Compile(bodyvaluecUSTOMERtRNo, nameof(bodyvaluecUSTOMERtRNo), required: false);
            var __workflow_bodyvaluecUSTOMERgeographicalAreas = WorkflowExpression.Compile(bodyvaluecUSTOMERgeographicalAreas, nameof(bodyvaluecUSTOMERgeographicalAreas), required: false);
            var __workflow_bodyvaluecUSTOMERcity = WorkflowExpression.Compile(bodyvaluecUSTOMERcity, nameof(bodyvaluecUSTOMERcity), required: false);
            var __workflow_bodyvaluecUSTOMERdiscount = WorkflowExpression.Compile(bodyvaluecUSTOMERdiscount, nameof(bodyvaluecUSTOMERdiscount), required: false);
            var __workflow_bodyvaluecUSTOMERlocationArea = WorkflowExpression.Compile(bodyvaluecUSTOMERlocationArea, nameof(bodyvaluecUSTOMERlocationArea), required: false);
            var __workflow_bodyvaluecUSTOMEReMail = WorkflowExpression.Compile(bodyvaluecUSTOMEReMail, nameof(bodyvaluecUSTOMEReMail), required: false);
            var __workflow_bodyvaluecUSTOMERfax = WorkflowExpression.Compile(bodyvaluecUSTOMERfax, nameof(bodyvaluecUSTOMERfax), required: false);
            var __workflow_bodyvaluecUSTOMERtaxOffice = WorkflowExpression.Compile(bodyvaluecUSTOMERtaxOffice, nameof(bodyvaluecUSTOMERtaxOffice), required: false);
            var __workflow_bodyvaluecUSTOMERprofession = WorkflowExpression.Compile(bodyvaluecUSTOMERprofession, nameof(bodyvaluecUSTOMERprofession), required: false);
            var __workflow_bodyvaluecUSTOMERprimaryTelephone = WorkflowExpression.Compile(bodyvaluecUSTOMERprimaryTelephone, nameof(bodyvaluecUSTOMERprimaryTelephone), required: false);
            var __workflow_bodyvaluecUSTOMERcomments = WorkflowExpression.Compile(bodyvaluecUSTOMERcomments, nameof(bodyvaluecUSTOMERcomments), required: false);
            var __workflow_bodyvaluecUSTOMERtaxCategory = WorkflowExpression.Compile(bodyvaluecUSTOMERtaxCategory, nameof(bodyvaluecUSTOMERtaxCategory), required: false);
            var __workflow_bodyvaluecUSTOMERzip = WorkflowExpression.Compile(bodyvaluecUSTOMERzip, nameof(bodyvaluecUSTOMERzip), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvaluecUSTOMERprimaryAddress != null)
                {
                    cUSTOMERObject["ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERprimaryAddress);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERtRNo != null)
                {
                    cUSTOMERObject["AFM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERtRNo);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERgeographicalAreas != null)
                {
                    cUSTOMERObject["AREAS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERgeographicalAreas);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERcity != null)
                {
                    cUSTOMERObject["CITY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERcity);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERcode);
                if (__workflow_bodyvaluecUSTOMERdiscount != null)
                {
                    cUSTOMERObject["DISCOUNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERdiscount);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERlocationArea != null)
                {
                    cUSTOMERObject["DISTRICT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERlocationArea);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMEReMail != null)
                {
                    cUSTOMERObject["EMAIL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMEReMail);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERfax != null)
                {
                    cUSTOMERObject["FAX"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERfax);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERtaxOffice != null)
                {
                    cUSTOMERObject["IRSDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERtaxOffice);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERprofession != null)
                {
                    cUSTOMERObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERprofession);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERname);
                if (__workflow_bodyvaluecUSTOMERprimaryTelephone != null)
                {
                    cUSTOMERObject["PHONE01"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERprimaryTelephone);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERcomments != null)
                {
                    cUSTOMERObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERcomments);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERtaxCategory != null)
                {
                    cUSTOMERObject["VATSTS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERtaxCategory);
                    cUSTOMERObjectpropCount++;
                }

                if (__workflow_bodyvaluecUSTOMERzip != null)
                {
                    cUSTOMERObject["ZIP"] = ExpressionConverter.ConvertO(__workflow_bodyvaluecUSTOMERzip);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetDraftEntry(Expression<Func<string>> bodyvaluesODRAFTcode, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluesODRAFTaddress = null, Expression<Func<string>> bodyvaluesODRAFTtRNo = null, Expression<Func<string>> bodyvaluesODRAFTcity = null, Expression<Func<string>> bodyvaluesODRAFTcountry = null, Expression<Func<string>> bodyvaluesODRAFTarea = null, Expression<Func<string>> bodyvaluesODRAFTprefecture = null, Expression<Func<string>> bodyvaluesODRAFTcategory = null, Expression<Func<string>> bodyvaluesODRAFTcompanyEmail = null, Expression<Func<string>> bodyvaluesODRAFTbusinessEmail = null, Expression<Func<string>> bodyvaluesODRAFTpersonalEmail = null, Expression<Func<string>> bodyvaluesODRAFTidCardNo = null, Expression<Func<string>> bodyvaluesODRAFTactivity = null, Expression<Func<string>> bodyvaluesODRAFTmobileTelephone = null, Expression<Func<string>> bodyvaluesODRAFTnameTitle = null, Expression<Func<string>> bodyvaluesODRAFTfirstName = null, Expression<Func<string>> bodyvaluesODRAFTsurname = null, Expression<Func<string>> bodyvaluesODRAFTzip = null, Expression<Func<string>> bodyvaluesODRAFTbusinessTelephone = null, Expression<Func<string>> bodyvaluesODRAFTinternalTelephone = null, Expression<Func<string>> bodyvaluesODRAFTpersonalTelephone = null, Expression<Func<string>> bodyvaluesODRAFTcomments = null, Expression<Func<string>> bodyvaluesODRAFTtitle = null, Expression<Func<string>> bodyvaluesODRAFTwebPage = null, Expression<Func<string>> bodyvaluesODRAFTzip2 = null, Expression<Func<string>> bodyvaluesODRAFTLNKbranch = null, Expression<Func<string>> bodyvaluesODRAFTLNKbusinessUnit = null, Expression<Func<string>> bodyvaluesODRAFTLNKdepartment = null, Expression<Func<string>> bodyvaluesODRAFTLNKproject = null, Expression<Func<string>> bodyvaluesODRAFTLNKsource = null)
        {
            var __workflow_bodyvaluesODRAFTcode = WorkflowExpression.Compile(bodyvaluesODRAFTcode, nameof(bodyvaluesODRAFTcode), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluesODRAFTaddress = WorkflowExpression.Compile(bodyvaluesODRAFTaddress, nameof(bodyvaluesODRAFTaddress), required: false);
            var __workflow_bodyvaluesODRAFTtRNo = WorkflowExpression.Compile(bodyvaluesODRAFTtRNo, nameof(bodyvaluesODRAFTtRNo), required: false);
            var __workflow_bodyvaluesODRAFTcity = WorkflowExpression.Compile(bodyvaluesODRAFTcity, nameof(bodyvaluesODRAFTcity), required: false);
            var __workflow_bodyvaluesODRAFTcountry = WorkflowExpression.Compile(bodyvaluesODRAFTcountry, nameof(bodyvaluesODRAFTcountry), required: false);
            var __workflow_bodyvaluesODRAFTarea = WorkflowExpression.Compile(bodyvaluesODRAFTarea, nameof(bodyvaluesODRAFTarea), required: false);
            var __workflow_bodyvaluesODRAFTprefecture = WorkflowExpression.Compile(bodyvaluesODRAFTprefecture, nameof(bodyvaluesODRAFTprefecture), required: false);
            var __workflow_bodyvaluesODRAFTcategory = WorkflowExpression.Compile(bodyvaluesODRAFTcategory, nameof(bodyvaluesODRAFTcategory), required: false);
            var __workflow_bodyvaluesODRAFTcompanyEmail = WorkflowExpression.Compile(bodyvaluesODRAFTcompanyEmail, nameof(bodyvaluesODRAFTcompanyEmail), required: false);
            var __workflow_bodyvaluesODRAFTbusinessEmail = WorkflowExpression.Compile(bodyvaluesODRAFTbusinessEmail, nameof(bodyvaluesODRAFTbusinessEmail), required: false);
            var __workflow_bodyvaluesODRAFTpersonalEmail = WorkflowExpression.Compile(bodyvaluesODRAFTpersonalEmail, nameof(bodyvaluesODRAFTpersonalEmail), required: false);
            var __workflow_bodyvaluesODRAFTidCardNo = WorkflowExpression.Compile(bodyvaluesODRAFTidCardNo, nameof(bodyvaluesODRAFTidCardNo), required: false);
            var __workflow_bodyvaluesODRAFTactivity = WorkflowExpression.Compile(bodyvaluesODRAFTactivity, nameof(bodyvaluesODRAFTactivity), required: false);
            var __workflow_bodyvaluesODRAFTmobileTelephone = WorkflowExpression.Compile(bodyvaluesODRAFTmobileTelephone, nameof(bodyvaluesODRAFTmobileTelephone), required: false);
            var __workflow_bodyvaluesODRAFTnameTitle = WorkflowExpression.Compile(bodyvaluesODRAFTnameTitle, nameof(bodyvaluesODRAFTnameTitle), required: false);
            var __workflow_bodyvaluesODRAFTfirstName = WorkflowExpression.Compile(bodyvaluesODRAFTfirstName, nameof(bodyvaluesODRAFTfirstName), required: false);
            var __workflow_bodyvaluesODRAFTsurname = WorkflowExpression.Compile(bodyvaluesODRAFTsurname, nameof(bodyvaluesODRAFTsurname), required: false);
            var __workflow_bodyvaluesODRAFTzip = WorkflowExpression.Compile(bodyvaluesODRAFTzip, nameof(bodyvaluesODRAFTzip), required: false);
            var __workflow_bodyvaluesODRAFTbusinessTelephone = WorkflowExpression.Compile(bodyvaluesODRAFTbusinessTelephone, nameof(bodyvaluesODRAFTbusinessTelephone), required: false);
            var __workflow_bodyvaluesODRAFTinternalTelephone = WorkflowExpression.Compile(bodyvaluesODRAFTinternalTelephone, nameof(bodyvaluesODRAFTinternalTelephone), required: false);
            var __workflow_bodyvaluesODRAFTpersonalTelephone = WorkflowExpression.Compile(bodyvaluesODRAFTpersonalTelephone, nameof(bodyvaluesODRAFTpersonalTelephone), required: false);
            var __workflow_bodyvaluesODRAFTcomments = WorkflowExpression.Compile(bodyvaluesODRAFTcomments, nameof(bodyvaluesODRAFTcomments), required: false);
            var __workflow_bodyvaluesODRAFTtitle = WorkflowExpression.Compile(bodyvaluesODRAFTtitle, nameof(bodyvaluesODRAFTtitle), required: false);
            var __workflow_bodyvaluesODRAFTwebPage = WorkflowExpression.Compile(bodyvaluesODRAFTwebPage, nameof(bodyvaluesODRAFTwebPage), required: false);
            var __workflow_bodyvaluesODRAFTzip2 = WorkflowExpression.Compile(bodyvaluesODRAFTzip2, nameof(bodyvaluesODRAFTzip2), required: false);
            var __workflow_bodyvaluesODRAFTLNKbranch = WorkflowExpression.Compile(bodyvaluesODRAFTLNKbranch, nameof(bodyvaluesODRAFTLNKbranch), required: false);
            var __workflow_bodyvaluesODRAFTLNKbusinessUnit = WorkflowExpression.Compile(bodyvaluesODRAFTLNKbusinessUnit, nameof(bodyvaluesODRAFTLNKbusinessUnit), required: false);
            var __workflow_bodyvaluesODRAFTLNKdepartment = WorkflowExpression.Compile(bodyvaluesODRAFTLNKdepartment, nameof(bodyvaluesODRAFTLNKdepartment), required: false);
            var __workflow_bodyvaluesODRAFTLNKproject = WorkflowExpression.Compile(bodyvaluesODRAFTLNKproject, nameof(bodyvaluesODRAFTLNKproject), required: false);
            var __workflow_bodyvaluesODRAFTLNKsource = WorkflowExpression.Compile(bodyvaluesODRAFTLNKsource, nameof(bodyvaluesODRAFTLNKsource), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvaluesODRAFTaddress != null)
                {
                    sODRAFTObject["ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTaddress);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTtRNo != null)
                {
                    sODRAFTObject["AFM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTtRNo);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTcity != null)
                {
                    sODRAFTObject["CITY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcity);
                    sODRAFTObjectpropCount++;
                }

                sODRAFTObjectpropCount++;
                sODRAFTObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcode);
                if (__workflow_bodyvaluesODRAFTcountry != null)
                {
                    sODRAFTObject["COUNTRY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcountry);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTarea != null)
                {
                    sODRAFTObject["DISTRICT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTarea);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTprefecture != null)
                {
                    sODRAFTObject["DISTRICT1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTprefecture);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTcategory != null)
                {
                    sODRAFTObject["DRAFTTYPE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcategory);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTcompanyEmail != null)
                {
                    sODRAFTObject["EMAIL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcompanyEmail);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTbusinessEmail != null)
                {
                    sODRAFTObject["EMAIL1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTbusinessEmail);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTpersonalEmail != null)
                {
                    sODRAFTObject["EMAIL2"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTpersonalEmail);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTidCardNo != null)
                {
                    sODRAFTObject["IDENTITYNUM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTidCardNo);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTactivity != null)
                {
                    sODRAFTObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTactivity);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTmobileTelephone != null)
                {
                    sODRAFTObject["MOBILEPHONE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTmobileTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTnameTitle != null)
                {
                    sODRAFTObject["NAMEC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTnameTitle);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTfirstName != null)
                {
                    sODRAFTObject["NAMEF"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTfirstName);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTsurname != null)
                {
                    sODRAFTObject["NAMEL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTsurname);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTzip != null)
                {
                    sODRAFTObject["NUMCG"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTzip);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTbusinessTelephone != null)
                {
                    sODRAFTObject["PHONE1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTbusinessTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTinternalTelephone != null)
                {
                    sODRAFTObject["PHONEEXT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTinternalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTpersonalTelephone != null)
                {
                    sODRAFTObject["PHONELOCAL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTpersonalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTcomments != null)
                {
                    sODRAFTObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTcomments);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTtitle != null)
                {
                    sODRAFTObject["SOTITLENAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTtitle);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTwebPage != null)
                {
                    sODRAFTObject["WEBPAGE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTwebPage);
                    sODRAFTObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTzip2 != null)
                {
                    sODRAFTObject["ZIP"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTzip2);
                    sODRAFTObjectpropCount++;
                }

                if (sODRAFTObjectpropCount > 0)
                {
                    dataObject["SODRAFT"] = sODRAFTObject;
                    dataObjectpropCount++;
                }

                var sODRAFTLNKObject = new JObject();
                var sODRAFTLNKObjectpropCount = 0;
                if (__workflow_bodyvaluesODRAFTLNKbranch != null)
                {
                    sODRAFTLNKObject["BRANCH"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTLNKbranch);
                    sODRAFTLNKObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTLNKbusinessUnit != null)
                {
                    sODRAFTLNKObject["BUSUNITS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTLNKbusinessUnit);
                    sODRAFTLNKObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTLNKdepartment != null)
                {
                    sODRAFTLNKObject["DEPART"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTLNKdepartment);
                    sODRAFTLNKObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTLNKproject != null)
                {
                    sODRAFTLNKObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTLNKproject);
                    sODRAFTLNKObjectpropCount++;
                }

                if (__workflow_bodyvaluesODRAFTLNKsource != null)
                {
                    sODRAFTLNKObject["PRJCLEAD"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesODRAFTLNKsource);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpense(Expression<Func<string>> bodyvaluelINEITEMcode, Expression<Func<bodyvaluelINEITEMinvoicingCategoryInput>> bodyvaluelINEITEMinvoicingCategory, Expression<Func<string>> bodyvaluelINEITEMname, Expression<Func<string>> bodyvaluelINEITEMvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluelINEITEMcommercialCategory = null, Expression<Func<bodyvaluelINEITEMtypeInput>> bodyvaluelINEITEMtype = null, Expression<Func<string>> bodyvaluelINEITEMcomments = null, Expression<Func<bodyvaluelINEITEMfeeValueInput>> bodyvaluelINEITEMfeeValue = null)
        {
            var __workflow_bodyvaluelINEITEMcode = WorkflowExpression.Compile(bodyvaluelINEITEMcode, nameof(bodyvaluelINEITEMcode), required: true);
            var __workflow_bodyvaluelINEITEMinvoicingCategory = WorkflowExpression.Compile(bodyvaluelINEITEMinvoicingCategory, nameof(bodyvaluelINEITEMinvoicingCategory), required: true);
            var __workflow_bodyvaluelINEITEMname = WorkflowExpression.Compile(bodyvaluelINEITEMname, nameof(bodyvaluelINEITEMname), required: true);
            var __workflow_bodyvaluelINEITEMvatGroup = WorkflowExpression.Compile(bodyvaluelINEITEMvatGroup, nameof(bodyvaluelINEITEMvatGroup), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluelINEITEMcommercialCategory = WorkflowExpression.Compile(bodyvaluelINEITEMcommercialCategory, nameof(bodyvaluelINEITEMcommercialCategory), required: false);
            var __workflow_bodyvaluelINEITEMtype = WorkflowExpression.Compile(bodyvaluelINEITEMtype, nameof(bodyvaluelINEITEMtype), required: false);
            var __workflow_bodyvaluelINEITEMcomments = WorkflowExpression.Compile(bodyvaluelINEITEMcomments, nameof(bodyvaluelINEITEMcomments), required: false);
            var __workflow_bodyvaluelINEITEMfeeValue = WorkflowExpression.Compile(bodyvaluelINEITEMfeeValue, nameof(bodyvaluelINEITEMfeeValue), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                lINEITEMObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMcode);
                lINEITEMObjectpropCount++;
                lINEITEMObject["LISOURCETYPE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMinvoicingCategory);
                if (__workflow_bodyvaluelINEITEMcommercialCategory != null)
                {
                    lINEITEMObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMcommercialCategory);
                    lINEITEMObjectpropCount++;
                }

                if (__workflow_bodyvaluelINEITEMtype != null)
                {
                    lINEITEMObject["MTRTYPE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMtype);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMname);
                if (__workflow_bodyvaluelINEITEMcomments != null)
                {
                    lINEITEMObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMcomments);
                    lINEITEMObjectpropCount++;
                }

                if (__workflow_bodyvaluelINEITEMfeeValue != null)
                {
                    lINEITEMObject["SOPAYVALUE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMfeeValue);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["VAT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINEITEMvatGroup);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetExpensesDoc(Expression<Func<string>> bodyvaluelINSUPDOCseries, Expression<Func<string>> bodyvaluelINSUPDOCsupplier, Expression<Func<bodyvalueunnamedInputItem[]>> bodyvalueunnamed = null, Expression<Func<string>> bodyvaluelINSUPDOCproject = null, Expression<Func<string>> bodyvaluelINSUPDOCcomments = null, Expression<Func<string>> bodyvaluelINSUPDOCtRNDATE = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluelINSUPDOCseries = WorkflowExpression.Compile(bodyvaluelINSUPDOCseries, nameof(bodyvaluelINSUPDOCseries), required: true);
            var __workflow_bodyvaluelINSUPDOCsupplier = WorkflowExpression.Compile(bodyvaluelINSUPDOCsupplier, nameof(bodyvaluelINSUPDOCsupplier), required: true);
            var __workflow_bodyvalueunnamed = WorkflowExpression.Compile(bodyvalueunnamed, nameof(bodyvalueunnamed), required: false);
            var __workflow_bodyvaluelINSUPDOCproject = WorkflowExpression.Compile(bodyvaluelINSUPDOCproject, nameof(bodyvaluelINSUPDOCproject), required: false);
            var __workflow_bodyvaluelINSUPDOCcomments = WorkflowExpression.Compile(bodyvaluelINSUPDOCcomments, nameof(bodyvaluelINSUPDOCcomments), required: false);
            var __workflow_bodyvaluelINSUPDOCtRNDATE = WorkflowExpression.Compile(bodyvaluelINSUPDOCtRNDATE, nameof(bodyvaluelINSUPDOCtRNDATE), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvalueunnamed != null)
                {
                    dATAObject["LINLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvalueunnamed);
                    dATAObjectpropCount++;
                }

                var lINSUPDOCObject = new JObject();
                var lINSUPDOCObjectpropCount = 0;
                if (__workflow_bodyvaluelINSUPDOCproject != null)
                {
                    lINSUPDOCObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINSUPDOCproject);
                    lINSUPDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluelINSUPDOCcomments != null)
                {
                    lINSUPDOCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINSUPDOCcomments);
                    lINSUPDOCObjectpropCount++;
                }

                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINSUPDOCseries);
                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINSUPDOCsupplier);
                if (__workflow_bodyvaluelINSUPDOCtRNDATE != null)
                {
                    lINSUPDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluelINSUPDOCtRNDATE);
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

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItedoc(Expression<Func<string>> bodyvalueiTEDOCseries, Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvalueiTEDOCreason = null, Expression<Func<string>> bodyvalueiTEDOCrEMARKS = null, Expression<Func<string>> bodyvalueiTEDOCtRNDATE = null, Expression<Func<bodyvalueiTELINESInputItem[]>> bodyvalueiTELINES = null)
        {
            var __workflow_bodyvalueiTEDOCseries = WorkflowExpression.Compile(bodyvalueiTEDOCseries, nameof(bodyvalueiTEDOCseries), required: true);
            var __workflow_bodyvaluemTRDOCwarehouse = WorkflowExpression.Compile(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvalueiTEDOCreason = WorkflowExpression.Compile(bodyvalueiTEDOCreason, nameof(bodyvalueiTEDOCreason), required: false);
            var __workflow_bodyvalueiTEDOCrEMARKS = WorkflowExpression.Compile(bodyvalueiTEDOCrEMARKS, nameof(bodyvalueiTEDOCrEMARKS), required: false);
            var __workflow_bodyvalueiTEDOCtRNDATE = WorkflowExpression.Compile(bodyvalueiTEDOCtRNDATE, nameof(bodyvalueiTEDOCtRNDATE), required: false);
            var __workflow_bodyvalueiTELINES = WorkflowExpression.Compile(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvalueiTEDOCreason != null)
                {
                    iTEDOCObject["COMMENTS"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEDOCreason);
                    iTEDOCObjectpropCount++;
                }

                if (__workflow_bodyvalueiTEDOCrEMARKS != null)
                {
                    iTEDOCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEDOCrEMARKS);
                    iTEDOCObjectpropCount++;
                }

                iTEDOCObjectpropCount++;
                iTEDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEDOCseries);
                if (__workflow_bodyvalueiTEDOCtRNDATE != null)
                {
                    iTEDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEDOCtRNDATE);
                    iTEDOCObjectpropCount++;
                }

                if (iTEDOCObjectpropCount > 0)
                {
                    dataObject["ITEDOC"] = iTEDOCObject;
                    dataObjectpropCount++;
                }

                if (__workflow_bodyvalueiTELINES != null)
                {
                    dataObject["ITELINES"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluemTRDOCwarehouse);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetItem(Expression<Func<string>> bodyvalueiTEMcode, Expression<Func<string>> bodyvalueiTEMbaseUnitOfMeasure, Expression<Func<string>> bodyvalueiTEMname, Expression<Func<string>> bodyvalueiTEMvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvalueiTEMcommercialCategory = null, Expression<Func<string>> bodyvalueiTEMitemGroup = null, Expression<Func<string>> bodyvalueiTEMretailPrice = null, Expression<Func<string>> bodyvalueiTEMwholesalePrice = null, Expression<Func<string>> bodyvalueiTEMcomments = null, Expression<Func<string>> bodyvalueiTEMdiscount1 = null)
        {
            var __workflow_bodyvalueiTEMcode = WorkflowExpression.Compile(bodyvalueiTEMcode, nameof(bodyvalueiTEMcode), required: true);
            var __workflow_bodyvalueiTEMbaseUnitOfMeasure = WorkflowExpression.Compile(bodyvalueiTEMbaseUnitOfMeasure, nameof(bodyvalueiTEMbaseUnitOfMeasure), required: true);
            var __workflow_bodyvalueiTEMname = WorkflowExpression.Compile(bodyvalueiTEMname, nameof(bodyvalueiTEMname), required: true);
            var __workflow_bodyvalueiTEMvatGroup = WorkflowExpression.Compile(bodyvalueiTEMvatGroup, nameof(bodyvalueiTEMvatGroup), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvalueiTEMcommercialCategory = WorkflowExpression.Compile(bodyvalueiTEMcommercialCategory, nameof(bodyvalueiTEMcommercialCategory), required: false);
            var __workflow_bodyvalueiTEMitemGroup = WorkflowExpression.Compile(bodyvalueiTEMitemGroup, nameof(bodyvalueiTEMitemGroup), required: false);
            var __workflow_bodyvalueiTEMretailPrice = WorkflowExpression.Compile(bodyvalueiTEMretailPrice, nameof(bodyvalueiTEMretailPrice), required: false);
            var __workflow_bodyvalueiTEMwholesalePrice = WorkflowExpression.Compile(bodyvalueiTEMwholesalePrice, nameof(bodyvalueiTEMwholesalePrice), required: false);
            var __workflow_bodyvalueiTEMcomments = WorkflowExpression.Compile(bodyvalueiTEMcomments, nameof(bodyvalueiTEMcomments), required: false);
            var __workflow_bodyvalueiTEMdiscount1 = WorkflowExpression.Compile(bodyvalueiTEMdiscount1, nameof(bodyvalueiTEMdiscount1), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                iTEMObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMcode);
                if (__workflow_bodyvalueiTEMcommercialCategory != null)
                {
                    iTEMObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMcommercialCategory);
                    iTEMObjectpropCount++;
                }

                if (__workflow_bodyvalueiTEMitemGroup != null)
                {
                    iTEMObject["MTRGROUP"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMitemGroup);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["MTRUNIT1"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMbaseUnitOfMeasure);
                iTEMObjectpropCount++;
                iTEMObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMname);
                if (__workflow_bodyvalueiTEMretailPrice != null)
                {
                    iTEMObject["PRICER"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMretailPrice);
                    iTEMObjectpropCount++;
                }

                if (__workflow_bodyvalueiTEMwholesalePrice != null)
                {
                    iTEMObject["PRICEW"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMwholesalePrice);
                    iTEMObjectpropCount++;
                }

                if (__workflow_bodyvalueiTEMcomments != null)
                {
                    iTEMObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMcomments);
                    iTEMObjectpropCount++;
                }

                if (__workflow_bodyvalueiTEMdiscount1 != null)
                {
                    iTEMObject["SODISCOUNT"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMdiscount1);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["VAT"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTEMvatGroup);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetProject(Expression<Func<string>> bodyvaluepRJCcode, Expression<Func<string>> bodyvaluepRJCname, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<bodyvaluepRJCaCTSTATUSInput>> bodyvaluepRJCaCTSTATUS = null, Expression<Func<string>> bodyvaluepRJCfINALDATE = null, Expression<Func<string>> bodyvaluepRJCfROMDATE = null, Expression<Func<bodyvaluepRJCpRJCRMInput>> bodyvaluepRJCpRJCRM = null, Expression<Func<string>> bodyvaluepRJCcomments = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null)
        {
            var __workflow_bodyvaluepRJCcode = WorkflowExpression.Compile(bodyvaluepRJCcode, nameof(bodyvaluepRJCcode), required: true);
            var __workflow_bodyvaluepRJCname = WorkflowExpression.Compile(bodyvaluepRJCname, nameof(bodyvaluepRJCname), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluepRJCaCTSTATUS = WorkflowExpression.Compile(bodyvaluepRJCaCTSTATUS, nameof(bodyvaluepRJCaCTSTATUS), required: false);
            var __workflow_bodyvaluepRJCfINALDATE = WorkflowExpression.Compile(bodyvaluepRJCfINALDATE, nameof(bodyvaluepRJCfINALDATE), required: false);
            var __workflow_bodyvaluepRJCfROMDATE = WorkflowExpression.Compile(bodyvaluepRJCfROMDATE, nameof(bodyvaluepRJCfROMDATE), required: false);
            var __workflow_bodyvaluepRJCpRJCRM = WorkflowExpression.Compile(bodyvaluepRJCpRJCRM, nameof(bodyvaluepRJCpRJCRM), required: false);
            var __workflow_bodyvaluepRJCcomments = WorkflowExpression.Compile(bodyvaluepRJCcomments, nameof(bodyvaluepRJCcomments), required: false);
            var __workflow_bodyvaluexTRDOCDATA = WorkflowExpression.Compile(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvaluepRJCaCTSTATUS != null)
                {
                    pRJCObject["ACTSTATUS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCaCTSTATUS);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCcode);
                if (__workflow_bodyvaluepRJCfINALDATE != null)
                {
                    pRJCObject["FINALDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCfINALDATE);
                    pRJCObjectpropCount++;
                }

                if (__workflow_bodyvaluepRJCfROMDATE != null)
                {
                    pRJCObject["FROMDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCfROMDATE);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCname);
                if (__workflow_bodyvaluepRJCpRJCRM != null)
                {
                    pRJCObject["PRJCRM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCpRJCRM);
                    pRJCObjectpropCount++;
                }

                if (__workflow_bodyvaluepRJCcomments != null)
                {
                    pRJCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepRJCcomments);
                    pRJCObjectpropCount++;
                }

                if (pRJCObjectpropCount > 0)
                {
                    dataObject["PRJC"] = pRJCObject;
                    dataObjectpropCount++;
                }

                if (__workflow_bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluexTRDOCDATA);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetPurdoc(Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyvaluepURDOCsERIES, Expression<Func<string>> bodyvaluepURDOCsOCURRENCY, Expression<Func<string>> bodyvaluepURDOCtRDR, Expression<Func<bodyvalueiTELINESInputItem2[]>> bodyvalueiTELINES = null, Expression<Func<string>> bodyvaluepURDOCdISC1PRC = null, Expression<Func<string>> bodyvaluepURDOCpAYMENT = null, Expression<Func<string>> bodyvaluepURDOCpRJC = null, Expression<Func<string>> bodyvaluepURDOCrEMARKS = null, Expression<Func<string>> bodyvaluepURDOCsUMAMNT = null, Expression<Func<string>> bodyvaluepURDOCtRNDATE = null, Expression<Func<bodyvaluesRVLINESInputItem[]>> bodyvaluesRVLINES = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluemTRDOCwarehouse = WorkflowExpression.Compile(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            var __workflow_bodyvaluepURDOCsERIES = WorkflowExpression.Compile(bodyvaluepURDOCsERIES, nameof(bodyvaluepURDOCsERIES), required: true);
            var __workflow_bodyvaluepURDOCsOCURRENCY = WorkflowExpression.Compile(bodyvaluepURDOCsOCURRENCY, nameof(bodyvaluepURDOCsOCURRENCY), required: true);
            var __workflow_bodyvaluepURDOCtRDR = WorkflowExpression.Compile(bodyvaluepURDOCtRDR, nameof(bodyvaluepURDOCtRDR), required: true);
            var __workflow_bodyvalueiTELINES = WorkflowExpression.Compile(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            var __workflow_bodyvaluepURDOCdISC1PRC = WorkflowExpression.Compile(bodyvaluepURDOCdISC1PRC, nameof(bodyvaluepURDOCdISC1PRC), required: false);
            var __workflow_bodyvaluepURDOCpAYMENT = WorkflowExpression.Compile(bodyvaluepURDOCpAYMENT, nameof(bodyvaluepURDOCpAYMENT), required: false);
            var __workflow_bodyvaluepURDOCpRJC = WorkflowExpression.Compile(bodyvaluepURDOCpRJC, nameof(bodyvaluepURDOCpRJC), required: false);
            var __workflow_bodyvaluepURDOCrEMARKS = WorkflowExpression.Compile(bodyvaluepURDOCrEMARKS, nameof(bodyvaluepURDOCrEMARKS), required: false);
            var __workflow_bodyvaluepURDOCsUMAMNT = WorkflowExpression.Compile(bodyvaluepURDOCsUMAMNT, nameof(bodyvaluepURDOCsUMAMNT), required: false);
            var __workflow_bodyvaluepURDOCtRNDATE = WorkflowExpression.Compile(bodyvaluepURDOCtRNDATE, nameof(bodyvaluepURDOCtRNDATE), required: false);
            var __workflow_bodyvaluesRVLINES = WorkflowExpression.Compile(bodyvaluesRVLINES, nameof(bodyvaluesRVLINES), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvalueiTELINES != null)
                {
                    dATAObject["ITELINES"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTELINES);
                    dATAObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dATAObject["MTRDOC"] = mTRDOCObject;
                    dATAObjectpropCount++;
                }

                var pURDOCObject = new JObject();
                var pURDOCObjectpropCount = 0;
                if (__workflow_bodyvaluepURDOCdISC1PRC != null)
                {
                    pURDOCObject["DISC1PRC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCdISC1PRC);
                    pURDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluepURDOCpAYMENT != null)
                {
                    pURDOCObject["PAYMENT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCpAYMENT);
                    pURDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluepURDOCpRJC != null)
                {
                    pURDOCObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCpRJC);
                    pURDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluepURDOCrEMARKS != null)
                {
                    pURDOCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCrEMARKS);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCsERIES);
                pURDOCObjectpropCount++;
                pURDOCObject["SOCURRENCY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCsOCURRENCY);
                if (__workflow_bodyvaluepURDOCsUMAMNT != null)
                {
                    pURDOCObject["SUMAMNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCsUMAMNT);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCtRDR);
                if (__workflow_bodyvaluepURDOCtRNDATE != null)
                {
                    pURDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluepURDOCtRNDATE);
                    pURDOCObjectpropCount++;
                }

                if (pURDOCObjectpropCount > 0)
                {
                    dATAObject["PURDOC"] = pURDOCObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluesRVLINES != null)
                {
                    dATAObject["SRVLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesRVLINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSaldoc(Expression<Func<string>> bodyvaluemTRDOCwarehouse, Expression<Func<string>> bodyvaluesALDOCpayment, Expression<Func<string>> bodyvaluesALDOCseries, Expression<Func<string>> bodyvaluesALDOCcurrency, Expression<Func<string>> bodyvaluesALDOCcustomer, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<bodyvalueiTELINESInputItem22[]>> bodyvalueiTELINES = null, Expression<Func<string>> bodyvaluesALDOCdiscount = null, Expression<Func<string>> bodyvaluesALDOCdiscountValue = null, Expression<Func<string>> bodyvaluesALDOCnetAmount = null, Expression<Func<string>> bodyvaluesALDOCproject = null, Expression<Func<string>> bodyvaluesALDOCcomments = null, Expression<Func<string>> bodyvaluesALDOCtotal = null, Expression<Func<string>> bodyvaluesALDOCtRNDATE = null, Expression<Func<string>> bodyvaluesALDOCvAT = null, Expression<Func<bodyvaluesRVLINESInputItem2[]>> bodyvaluesRVLINES = null)
        {
            var __workflow_bodyvaluemTRDOCwarehouse = WorkflowExpression.Compile(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            var __workflow_bodyvaluesALDOCpayment = WorkflowExpression.Compile(bodyvaluesALDOCpayment, nameof(bodyvaluesALDOCpayment), required: true);
            var __workflow_bodyvaluesALDOCseries = WorkflowExpression.Compile(bodyvaluesALDOCseries, nameof(bodyvaluesALDOCseries), required: true);
            var __workflow_bodyvaluesALDOCcurrency = WorkflowExpression.Compile(bodyvaluesALDOCcurrency, nameof(bodyvaluesALDOCcurrency), required: true);
            var __workflow_bodyvaluesALDOCcustomer = WorkflowExpression.Compile(bodyvaluesALDOCcustomer, nameof(bodyvaluesALDOCcustomer), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvalueiTELINES = WorkflowExpression.Compile(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            var __workflow_bodyvaluesALDOCdiscount = WorkflowExpression.Compile(bodyvaluesALDOCdiscount, nameof(bodyvaluesALDOCdiscount), required: false);
            var __workflow_bodyvaluesALDOCdiscountValue = WorkflowExpression.Compile(bodyvaluesALDOCdiscountValue, nameof(bodyvaluesALDOCdiscountValue), required: false);
            var __workflow_bodyvaluesALDOCnetAmount = WorkflowExpression.Compile(bodyvaluesALDOCnetAmount, nameof(bodyvaluesALDOCnetAmount), required: false);
            var __workflow_bodyvaluesALDOCproject = WorkflowExpression.Compile(bodyvaluesALDOCproject, nameof(bodyvaluesALDOCproject), required: false);
            var __workflow_bodyvaluesALDOCcomments = WorkflowExpression.Compile(bodyvaluesALDOCcomments, nameof(bodyvaluesALDOCcomments), required: false);
            var __workflow_bodyvaluesALDOCtotal = WorkflowExpression.Compile(bodyvaluesALDOCtotal, nameof(bodyvaluesALDOCtotal), required: false);
            var __workflow_bodyvaluesALDOCtRNDATE = WorkflowExpression.Compile(bodyvaluesALDOCtRNDATE, nameof(bodyvaluesALDOCtRNDATE), required: false);
            var __workflow_bodyvaluesALDOCvAT = WorkflowExpression.Compile(bodyvaluesALDOCvAT, nameof(bodyvaluesALDOCvAT), required: false);
            var __workflow_bodyvaluesRVLINES = WorkflowExpression.Compile(bodyvaluesRVLINES, nameof(bodyvaluesRVLINES), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                if (__workflow_bodyvalueiTELINES != null)
                {
                    dataObject["ITELINES"] = ExpressionConverter.ConvertO(__workflow_bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dataObject["MTRDOC"] = mTRDOCObject;
                    dataObjectpropCount++;
                }

                var sALDOCObject = new JObject();
                var sALDOCObjectpropCount = 0;
                if (__workflow_bodyvaluesALDOCdiscount != null)
                {
                    sALDOCObject["DISC1PRC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCdiscount);
                    sALDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluesALDOCdiscountValue != null)
                {
                    sALDOCObject["DISC1VAL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCdiscountValue);
                    sALDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluesALDOCnetAmount != null)
                {
                    sALDOCObject["NETAMNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCnetAmount);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["PAYMENT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCpayment);
                if (__workflow_bodyvaluesALDOCproject != null)
                {
                    sALDOCObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCproject);
                    sALDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluesALDOCcomments != null)
                {
                    sALDOCObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCcomments);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCseries);
                sALDOCObjectpropCount++;
                sALDOCObject["SOCURRENCY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCcurrency);
                if (__workflow_bodyvaluesALDOCtotal != null)
                {
                    sALDOCObject["SUMAMNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCtotal);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCcustomer);
                if (__workflow_bodyvaluesALDOCtRNDATE != null)
                {
                    sALDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCtRNDATE);
                    sALDOCObjectpropCount++;
                }

                if (__workflow_bodyvaluesALDOCvAT != null)
                {
                    sALDOCObject["VATAMNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesALDOCvAT);
                    sALDOCObjectpropCount++;
                }

                if (sALDOCObjectpropCount > 0)
                {
                    dataObject["SALDOC"] = sALDOCObject;
                    dataObjectpropCount++;
                }

                if (__workflow_bodyvaluesRVLINES != null)
                {
                    dataObject["SRVLINES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesRVLINES);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetService(Expression<Func<string>> bodyvaluesERVICEcode, Expression<Func<string>> bodyvaluesERVICEbaseUnitOfMeasure, Expression<Func<string>> bodyvaluesERVICEname, Expression<Func<string>> bodyvaluesERVICEvatGroup, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null, Expression<Func<string>> bodyvaluesERVICEcommercialCategory = null, Expression<Func<string>> bodyvaluesERVICEserviceGroup = null, Expression<Func<string>> bodyvaluesERVICEretailPrice = null, Expression<Func<string>> bodyvaluesERVICEwholesalePrice = null, Expression<Func<string>> bodyvaluesERVICEcomments = null, Expression<Func<string>> bodyvaluesERVICEdiscount1 = null)
        {
            var __workflow_bodyvaluesERVICEcode = WorkflowExpression.Compile(bodyvaluesERVICEcode, nameof(bodyvaluesERVICEcode), required: true);
            var __workflow_bodyvaluesERVICEbaseUnitOfMeasure = WorkflowExpression.Compile(bodyvaluesERVICEbaseUnitOfMeasure, nameof(bodyvaluesERVICEbaseUnitOfMeasure), required: true);
            var __workflow_bodyvaluesERVICEname = WorkflowExpression.Compile(bodyvaluesERVICEname, nameof(bodyvaluesERVICEname), required: true);
            var __workflow_bodyvaluesERVICEvatGroup = WorkflowExpression.Compile(bodyvaluesERVICEvatGroup, nameof(bodyvaluesERVICEvatGroup), required: true);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            var __workflow_bodyvaluesERVICEcommercialCategory = WorkflowExpression.Compile(bodyvaluesERVICEcommercialCategory, nameof(bodyvaluesERVICEcommercialCategory), required: false);
            var __workflow_bodyvaluesERVICEserviceGroup = WorkflowExpression.Compile(bodyvaluesERVICEserviceGroup, nameof(bodyvaluesERVICEserviceGroup), required: false);
            var __workflow_bodyvaluesERVICEretailPrice = WorkflowExpression.Compile(bodyvaluesERVICEretailPrice, nameof(bodyvaluesERVICEretailPrice), required: false);
            var __workflow_bodyvaluesERVICEwholesalePrice = WorkflowExpression.Compile(bodyvaluesERVICEwholesalePrice, nameof(bodyvaluesERVICEwholesalePrice), required: false);
            var __workflow_bodyvaluesERVICEcomments = WorkflowExpression.Compile(bodyvaluesERVICEcomments, nameof(bodyvaluesERVICEcomments), required: false);
            var __workflow_bodyvaluesERVICEdiscount1 = WorkflowExpression.Compile(bodyvaluesERVICEdiscount1, nameof(bodyvaluesERVICEdiscount1), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
                sERVICEObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEcode);
                if (__workflow_bodyvaluesERVICEcommercialCategory != null)
                {
                    sERVICEObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEcommercialCategory);
                    sERVICEObjectpropCount++;
                }

                if (__workflow_bodyvaluesERVICEserviceGroup != null)
                {
                    sERVICEObject["MTRGROUP"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEserviceGroup);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["MTRUNIT1"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEbaseUnitOfMeasure);
                sERVICEObjectpropCount++;
                sERVICEObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEname);
                if (__workflow_bodyvaluesERVICEretailPrice != null)
                {
                    sERVICEObject["PRICER"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEretailPrice);
                    sERVICEObjectpropCount++;
                }

                if (__workflow_bodyvaluesERVICEwholesalePrice != null)
                {
                    sERVICEObject["PRICEW"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEwholesalePrice);
                    sERVICEObjectpropCount++;
                }

                if (__workflow_bodyvaluesERVICEcomments != null)
                {
                    sERVICEObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEcomments);
                    sERVICEObjectpropCount++;
                }

                if (__workflow_bodyvaluesERVICEdiscount1 != null)
                {
                    sERVICEObject["SODISCOUNT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEdiscount1);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["VAT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesERVICEvatGroup);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSOEMAIL(Expression<Func<string>> bodyvaluesOACTIONsERIES, Expression<Func<bodyvaluesOACTIONaCTSTATUSInput>> bodyvaluesOACTIONaCTSTATUS = null, Expression<Func<string>> bodyvaluesOACTIONcOMMENTS = null, Expression<Func<string>> bodyvaluesOACTIONtRNDATE = null, Expression<Func<string>> bodyvaluesOMAILfROMADDRESS = null, Expression<Func<string>> bodyvaluesOMAILfROMNAME = null, Expression<Func<string>> bodyvaluesOMAILsOBCC = null, Expression<Func<string>> bodyvaluesOMAILsOBODY = null, Expression<Func<string>> bodyvaluesOMAILsOCC = null, Expression<Func<string>> bodyvaluesOMAILsOTO = null, Expression<Func<bodyvaluexTRDOCDATAInputItem[]>> bodyvaluexTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluesOACTIONsERIES = WorkflowExpression.Compile(bodyvaluesOACTIONsERIES, nameof(bodyvaluesOACTIONsERIES), required: true);
            var __workflow_bodyvaluesOACTIONaCTSTATUS = WorkflowExpression.Compile(bodyvaluesOACTIONaCTSTATUS, nameof(bodyvaluesOACTIONaCTSTATUS), required: false);
            var __workflow_bodyvaluesOACTIONcOMMENTS = WorkflowExpression.Compile(bodyvaluesOACTIONcOMMENTS, nameof(bodyvaluesOACTIONcOMMENTS), required: false);
            var __workflow_bodyvaluesOACTIONtRNDATE = WorkflowExpression.Compile(bodyvaluesOACTIONtRNDATE, nameof(bodyvaluesOACTIONtRNDATE), required: false);
            var __workflow_bodyvaluesOMAILfROMADDRESS = WorkflowExpression.Compile(bodyvaluesOMAILfROMADDRESS, nameof(bodyvaluesOMAILfROMADDRESS), required: false);
            var __workflow_bodyvaluesOMAILfROMNAME = WorkflowExpression.Compile(bodyvaluesOMAILfROMNAME, nameof(bodyvaluesOMAILfROMNAME), required: false);
            var __workflow_bodyvaluesOMAILsOBCC = WorkflowExpression.Compile(bodyvaluesOMAILsOBCC, nameof(bodyvaluesOMAILsOBCC), required: false);
            var __workflow_bodyvaluesOMAILsOBODY = WorkflowExpression.Compile(bodyvaluesOMAILsOBODY, nameof(bodyvaluesOMAILsOBODY), required: false);
            var __workflow_bodyvaluesOMAILsOCC = WorkflowExpression.Compile(bodyvaluesOMAILsOCC, nameof(bodyvaluesOMAILsOCC), required: false);
            var __workflow_bodyvaluesOMAILsOTO = WorkflowExpression.Compile(bodyvaluesOMAILsOTO, nameof(bodyvaluesOMAILsOTO), required: false);
            var __workflow_bodyvaluexTRDOCDATA = WorkflowExpression.Compile(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvaluesOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodyvaluesOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOACTIONsERIES);
                if (__workflow_bodyvaluesOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                var sOMAILObject = new JObject();
                var sOMAILObjectpropCount = 0;
                if (__workflow_bodyvaluesOMAILfROMADDRESS != null)
                {
                    sOMAILObject["FROMADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILfROMADDRESS);
                    sOMAILObjectpropCount++;
                }

                if (__workflow_bodyvaluesOMAILfROMNAME != null)
                {
                    sOMAILObject["FROMNAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILfROMNAME);
                    sOMAILObjectpropCount++;
                }

                if (__workflow_bodyvaluesOMAILsOBCC != null)
                {
                    sOMAILObject["SOBCC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILsOBCC);
                    sOMAILObjectpropCount++;
                }

                if (__workflow_bodyvaluesOMAILsOBODY != null)
                {
                    sOMAILObject["SOBODY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILsOBODY);
                    sOMAILObjectpropCount++;
                }

                if (__workflow_bodyvaluesOMAILsOCC != null)
                {
                    sOMAILObject["SOCC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILsOCC);
                    sOMAILObjectpropCount++;
                }

                if (__workflow_bodyvaluesOMAILsOTO != null)
                {
                    sOMAILObject["SOTO"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesOMAILsOTO);
                    sOMAILObjectpropCount++;
                }

                if (sOMAILObjectpropCount > 0)
                {
                    dATAObject["SOMAIL"] = sOMAILObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodyvaluexTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluexTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetMeeting(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONOperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodydATAsOACTIONsERIES = WorkflowExpression.Compile(bodydATAsOACTIONsERIES, nameof(bodydATAsOACTIONsERIES), required: true);
            var __workflow_bodydATAsOACTIONOperator = WorkflowExpression.Compile(bodydATAsOACTIONOperator, nameof(bodydATAsOACTIONOperator), required: false);
            var __workflow_bodydATAsOACTIONoperatorContact = WorkflowExpression.Compile(bodydATAsOACTIONoperatorContact, nameof(bodydATAsOACTIONoperatorContact), required: false);
            var __workflow_bodydATAsOACTIONaCTSTATUS = WorkflowExpression.Compile(bodydATAsOACTIONaCTSTATUS, nameof(bodydATAsOACTIONaCTSTATUS), required: false);
            var __workflow_bodydATAsOACTIONcOMMENTS = WorkflowExpression.Compile(bodydATAsOACTIONcOMMENTS, nameof(bodydATAsOACTIONcOMMENTS), required: false);
            var __workflow_bodydATAsOACTIONfINALDATE = WorkflowExpression.Compile(bodydATAsOACTIONfINALDATE, nameof(bodydATAsOACTIONfINALDATE), required: false);
            var __workflow_bodydATAsOACTIONfROMDATE = WorkflowExpression.Compile(bodydATAsOACTIONfROMDATE, nameof(bodydATAsOACTIONfROMDATE), required: false);
            var __workflow_bodydATAsOACTIONorderedBy = WorkflowExpression.Compile(bodydATAsOACTIONorderedBy, nameof(bodydATAsOACTIONorderedBy), required: false);
            var __workflow_bodydATAsOACTIONorderedByContact = WorkflowExpression.Compile(bodydATAsOACTIONorderedByContact, nameof(bodydATAsOACTIONorderedByContact), required: false);
            var __workflow_bodydATAsOACTIONpriority = WorkflowExpression.Compile(bodydATAsOACTIONpriority, nameof(bodydATAsOACTIONpriority), required: false);
            var __workflow_bodydATAsOACTIONproject = WorkflowExpression.Compile(bodydATAsOACTIONproject, nameof(bodydATAsOACTIONproject), required: false);
            var __workflow_bodydATAsOACTIONrEMARKS = WorkflowExpression.Compile(bodydATAsOACTIONrEMARKS, nameof(bodydATAsOACTIONrEMARKS), required: false);
            var __workflow_bodydATAsOACTIONtRDR = WorkflowExpression.Compile(bodydATAsOACTIONtRDR, nameof(bodydATAsOACTIONtRDR), required: false);
            var __workflow_bodydATAsOACTIONtRNDATE = WorkflowExpression.Compile(bodydATAsOACTIONtRNDATE, nameof(bodydATAsOACTIONtRNDATE), required: false);
            var __workflow_bodydATAxTRDOCDATA = WorkflowExpression.Compile(bodydATAxTRDOCDATA, nameof(bodydATAxTRDOCDATA), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydATAsOACTIONOperator != null)
                {
                    sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONOperator);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONsERIES);
                if (__workflow_bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(__workflow_bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSOTASK(Expression<Func<string>> bodydATAsOACTIONsERIES, Expression<Func<string>> bodydATAsOACTIONOperator = null, Expression<Func<string>> bodydATAsOACTIONoperatorContact = null, Expression<Func<bodydATAsOACTIONaCTSTATUSInput>> bodydATAsOACTIONaCTSTATUS = null, Expression<Func<string>> bodydATAsOACTIONcOMMENTS = null, Expression<Func<string>> bodydATAsOACTIONfINALDATE = null, Expression<Func<string>> bodydATAsOACTIONfROMDATE = null, Expression<Func<string>> bodydATAsOACTIONorderedBy = null, Expression<Func<string>> bodydATAsOACTIONorderedByContact = null, Expression<Func<string>> bodydATAsOACTIONpriority = null, Expression<Func<string>> bodydATAsOACTIONproject = null, Expression<Func<string>> bodydATAsOACTIONrEMARKS = null, Expression<Func<string>> bodydATAsOACTIONtRDR = null, Expression<Func<string>> bodydATAsOACTIONtRNDATE = null, Expression<Func<bodydATAxTRDOCDATAInputItem[]>> bodydATAxTRDOCDATA = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodydATAsOACTIONsERIES = WorkflowExpression.Compile(bodydATAsOACTIONsERIES, nameof(bodydATAsOACTIONsERIES), required: true);
            var __workflow_bodydATAsOACTIONOperator = WorkflowExpression.Compile(bodydATAsOACTIONOperator, nameof(bodydATAsOACTIONOperator), required: false);
            var __workflow_bodydATAsOACTIONoperatorContact = WorkflowExpression.Compile(bodydATAsOACTIONoperatorContact, nameof(bodydATAsOACTIONoperatorContact), required: false);
            var __workflow_bodydATAsOACTIONaCTSTATUS = WorkflowExpression.Compile(bodydATAsOACTIONaCTSTATUS, nameof(bodydATAsOACTIONaCTSTATUS), required: false);
            var __workflow_bodydATAsOACTIONcOMMENTS = WorkflowExpression.Compile(bodydATAsOACTIONcOMMENTS, nameof(bodydATAsOACTIONcOMMENTS), required: false);
            var __workflow_bodydATAsOACTIONfINALDATE = WorkflowExpression.Compile(bodydATAsOACTIONfINALDATE, nameof(bodydATAsOACTIONfINALDATE), required: false);
            var __workflow_bodydATAsOACTIONfROMDATE = WorkflowExpression.Compile(bodydATAsOACTIONfROMDATE, nameof(bodydATAsOACTIONfROMDATE), required: false);
            var __workflow_bodydATAsOACTIONorderedBy = WorkflowExpression.Compile(bodydATAsOACTIONorderedBy, nameof(bodydATAsOACTIONorderedBy), required: false);
            var __workflow_bodydATAsOACTIONorderedByContact = WorkflowExpression.Compile(bodydATAsOACTIONorderedByContact, nameof(bodydATAsOACTIONorderedByContact), required: false);
            var __workflow_bodydATAsOACTIONpriority = WorkflowExpression.Compile(bodydATAsOACTIONpriority, nameof(bodydATAsOACTIONpriority), required: false);
            var __workflow_bodydATAsOACTIONproject = WorkflowExpression.Compile(bodydATAsOACTIONproject, nameof(bodydATAsOACTIONproject), required: false);
            var __workflow_bodydATAsOACTIONrEMARKS = WorkflowExpression.Compile(bodydATAsOACTIONrEMARKS, nameof(bodydATAsOACTIONrEMARKS), required: false);
            var __workflow_bodydATAsOACTIONtRDR = WorkflowExpression.Compile(bodydATAsOACTIONtRDR, nameof(bodydATAsOACTIONtRDR), required: false);
            var __workflow_bodydATAsOACTIONtRNDATE = WorkflowExpression.Compile(bodydATAsOACTIONtRNDATE, nameof(bodydATAsOACTIONtRNDATE), required: false);
            var __workflow_bodydATAxTRDOCDATA = WorkflowExpression.Compile(bodydATAxTRDOCDATA, nameof(bodydATAxTRDOCDATA), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydATAsOACTIONOperator != null)
                {
                    sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONOperator);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONsERIES);
                if (__workflow_bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (__workflow_bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(__workflow_bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (__workflow_bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(__workflow_bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response, ApiConnectionActionConfiguration> SetSupplier(Expression<Func<string>> bodyvaluesUPPLIERcODE, Expression<Func<string>> bodyvaluesUPPLIERnAME, Expression<Func<bodyvaluesUPBANKACCInputItem[]>> bodyvaluesUPBANKACC = null, Expression<Func<string>> bodyvaluesUPPLIERaDDRESS = null, Expression<Func<string>> bodyvaluesUPPLIERaFM = null, Expression<Func<string>> bodyvaluesUPPLIERcITY = null, Expression<Func<string>> bodyvaluesUPPLIERdISTRICT = null, Expression<Func<string>> bodyvaluesUPPLIEReMAIL = null, Expression<Func<string>> bodyvaluesUPPLIERfAX = null, Expression<Func<string>> bodyvaluesUPPLIERiRSDATA = null, Expression<Func<string>> bodyvaluesUPPLIERjOBTYPETRD = null, Expression<Func<string>> bodyvaluesUPPLIERpHONE01 = null, Expression<Func<string>> bodyvaluesUPPLIERrEMARKS = null, Expression<Func<string>> bodyvaluesUPPLIERzIP = null, Expression<Func<string>> bodyfORM = null, Expression<Func<string>> bodykEY = null)
        {
            var __workflow_bodyvaluesUPPLIERcODE = WorkflowExpression.Compile(bodyvaluesUPPLIERcODE, nameof(bodyvaluesUPPLIERcODE), required: true);
            var __workflow_bodyvaluesUPPLIERnAME = WorkflowExpression.Compile(bodyvaluesUPPLIERnAME, nameof(bodyvaluesUPPLIERnAME), required: true);
            var __workflow_bodyvaluesUPBANKACC = WorkflowExpression.Compile(bodyvaluesUPBANKACC, nameof(bodyvaluesUPBANKACC), required: false);
            var __workflow_bodyvaluesUPPLIERaDDRESS = WorkflowExpression.Compile(bodyvaluesUPPLIERaDDRESS, nameof(bodyvaluesUPPLIERaDDRESS), required: false);
            var __workflow_bodyvaluesUPPLIERaFM = WorkflowExpression.Compile(bodyvaluesUPPLIERaFM, nameof(bodyvaluesUPPLIERaFM), required: false);
            var __workflow_bodyvaluesUPPLIERcITY = WorkflowExpression.Compile(bodyvaluesUPPLIERcITY, nameof(bodyvaluesUPPLIERcITY), required: false);
            var __workflow_bodyvaluesUPPLIERdISTRICT = WorkflowExpression.Compile(bodyvaluesUPPLIERdISTRICT, nameof(bodyvaluesUPPLIERdISTRICT), required: false);
            var __workflow_bodyvaluesUPPLIEReMAIL = WorkflowExpression.Compile(bodyvaluesUPPLIEReMAIL, nameof(bodyvaluesUPPLIEReMAIL), required: false);
            var __workflow_bodyvaluesUPPLIERfAX = WorkflowExpression.Compile(bodyvaluesUPPLIERfAX, nameof(bodyvaluesUPPLIERfAX), required: false);
            var __workflow_bodyvaluesUPPLIERiRSDATA = WorkflowExpression.Compile(bodyvaluesUPPLIERiRSDATA, nameof(bodyvaluesUPPLIERiRSDATA), required: false);
            var __workflow_bodyvaluesUPPLIERjOBTYPETRD = WorkflowExpression.Compile(bodyvaluesUPPLIERjOBTYPETRD, nameof(bodyvaluesUPPLIERjOBTYPETRD), required: false);
            var __workflow_bodyvaluesUPPLIERpHONE01 = WorkflowExpression.Compile(bodyvaluesUPPLIERpHONE01, nameof(bodyvaluesUPPLIERpHONE01), required: false);
            var __workflow_bodyvaluesUPPLIERrEMARKS = WorkflowExpression.Compile(bodyvaluesUPPLIERrEMARKS, nameof(bodyvaluesUPPLIERrEMARKS), required: false);
            var __workflow_bodyvaluesUPPLIERzIP = WorkflowExpression.Compile(bodyvaluesUPPLIERzIP, nameof(bodyvaluesUPPLIERzIP), required: false);
            var __workflow_bodyfORM = WorkflowExpression.Compile(bodyfORM, nameof(bodyfORM), required: false);
            var __workflow_bodykEY = WorkflowExpression.Compile(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyvaluesUPBANKACC != null)
                {
                    dATAObject["SUPBANKACC"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPBANKACC);
                    dATAObjectpropCount++;
                }

                var sUPPLIERObject = new JObject();
                var sUPPLIERObjectpropCount = 0;
                if (__workflow_bodyvaluesUPPLIERaDDRESS != null)
                {
                    sUPPLIERObject["ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERaDDRESS);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERaFM != null)
                {
                    sUPPLIERObject["AFM"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERaFM);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERcITY != null)
                {
                    sUPPLIERObject["CITY"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERcITY);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["CODE"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERcODE);
                if (__workflow_bodyvaluesUPPLIERdISTRICT != null)
                {
                    sUPPLIERObject["DISTRICT"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERdISTRICT);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIEReMAIL != null)
                {
                    sUPPLIERObject["EMAIL"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIEReMAIL);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERfAX != null)
                {
                    sUPPLIERObject["FAX"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERfAX);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERiRSDATA != null)
                {
                    sUPPLIERObject["IRSDATA"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERiRSDATA);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERjOBTYPETRD != null)
                {
                    sUPPLIERObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERjOBTYPETRD);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["NAME"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERnAME);
                if (__workflow_bodyvaluesUPPLIERpHONE01 != null)
                {
                    sUPPLIERObject["PHONE01"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERpHONE01);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERrEMARKS != null)
                {
                    sUPPLIERObject["REMARKS"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERrEMARKS);
                    sUPPLIERObjectpropCount++;
                }

                if (__workflow_bodyvaluesUPPLIERzIP != null)
                {
                    sUPPLIERObject["ZIP"] = ExpressionConverter.ConvertO(__workflow_bodyvaluesUPPLIERzIP);
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

                if (__workflow_bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(__workflow_bodyfORM);
                    bodypropCount++;
                }

                if (__workflow_bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(__workflow_bodykEY);
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
            });
        }
    }

    public class Soft1Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Webhook(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyObject = WorkflowExpression.Compile(bodyObject, nameof(bodyObject), required: true);
            var __workflow_bodycondition = WorkflowExpression.Compile(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(__workflow_bodycondition);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                body["event"] = "ONPOST";
                bodypropCount++;
                bodypropCount++;
                body["object"] = ExpressionConverter.ConvertO(__workflow_bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnDelete(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyObject = WorkflowExpression.Compile(bodyObject, nameof(bodyObject), required: true);
            var __workflow_bodycondition = WorkflowExpression.Compile(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(__workflow_bodycondition);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                body["event"] = "ONDELETE";
                bodypropCount++;
                bodypropCount++;
                body["object"] = ExpressionConverter.ConvertO(__workflow_bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnInsert(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyObject = WorkflowExpression.Compile(bodyObject, nameof(bodyObject), required: true);
            var __workflow_bodycondition = WorkflowExpression.Compile(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onInsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(__workflow_bodycondition);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                body["event"] = "ONINSERT";
                bodypropCount++;
                bodypropCount++;
                body["object"] = ExpressionConverter.ConvertO(__workflow_bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookOnUpdate(Expression<Func<bodyObjectInput>> bodyObject, Expression<Func<string>> bodycondition = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyObject = WorkflowExpression.Compile(bodyObject, nameof(bodyObject), required: true);
            var __workflow_bodycondition = WorkflowExpression.Compile(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/onUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(__workflow_bodycondition);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                body["event"] = "ONUPDATE";
                bodypropCount++;
                bodypropCount++;
                body["object"] = ExpressionConverter.ConvertO(__workflow_bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
        public string IdCardNo { get; set; }

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
        public string IdCardNo { get; set; }

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
        public string VATId { get; set; }

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
        public string SupplierId { get; set; }

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
        public string IdAndCategory { get; set; }

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
        public string CustomerId { get; set; }

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
        public string IdAndCategory { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvaluecUSTOMERtaxCategoryInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvaluelINEITEMtypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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