//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Soft1
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Soft1Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [WorkflowExpressionFactory(nameof(__BuildMicroservice))]
        public IWorkflowAction Microservice([WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyendpoint)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMicroservice(WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyendpoint)
        {
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyendpoint, nameof(bodyendpoint), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("microservice");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["endpoint"] = ExpressionConverter.ConvertO(bodyendpoint);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [WorkflowExpressionFactory(nameof(__BuildGetCFNCUSDOC))]
        public IBodyWorkflowAction<GetCFNCUSDOCResponse> GetCFNCUSDOC([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCFNCUSDOCResponse> __BuildGetCFNCUSDOC(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCFNCUSDOCResponse>(() =>
            {
                var apiCallPath = "/getCFNCUSDOC";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCfnsupdoc))]
        public IBodyWorkflowAction<GetCfnsupdocResponse> GetCfnsupdoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCfnsupdocResponse> __BuildGetCfnsupdoc(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCfnsupdocResponse>(() =>
            {
                var apiCallPath = "/getCfnsupdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCheque))]
        public IBodyWorkflowAction<GetChequeResponse> GetCheque([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChequeResponse> __BuildGetCheque(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetChequeResponse>(() =>
            {
                var apiCallPath = "/getCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetContact))]
        public IBodyWorkflowAction<GetContactResponse> GetContact([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactResponse> __BuildGetContact(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetContactResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCustomer))]
        public IBodyWorkflowAction<GetCustomerResponse> GetCustomer([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCustomerResponse> __BuildGetCustomer(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetCustomerResponse>(() =>
            {
                var apiCallPath = "/getCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDraftEntry))]
        public IBodyWorkflowAction<GetDraftEntryResponse> GetDraftEntry([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDraftEntryResponse> __BuildGetDraftEntry(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetDraftEntryResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetExpense))]
        public IBodyWorkflowAction<GetExpenseResponse> GetExpense([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExpenseResponse> __BuildGetExpense(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetExpenseResponse>(() =>
            {
                var apiCallPath = "/getExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetExpensesDoc))]
        public IBodyWorkflowAction<GetExpensesDocResponse> GetExpensesDoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodylOCATEINFO = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExpensesDocResponse> __BuildGetExpensesDoc(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodylOCATEINFO = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: false);
            return new DeferredBodyAction<GetExpensesDocResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                if (bodylOCATEINFO != null)
                {
                    if (bodylOCATEINFO != null)
                    {
                        body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetItedoc))]
        public IBodyWorkflowAction<GetItedocResponse> GetItedoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItedocResponse> __BuildGetItedoc(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetItedocResponse>(() =>
            {
                var apiCallPath = "/getItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemResponse> __BuildGetItem(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetItemResponse>(() =>
            {
                var apiCallPath = "/getItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectResponse> __BuildGetProject(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetProjectResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetPurdoc))]
        public IBodyWorkflowAction<GetPurdocResponse> GetPurdoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPurdocResponse> __BuildGetPurdoc(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetPurdocResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSaldoc))]
        public IBodyWorkflowAction<GetSaldocResponse> GetSaldoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSaldocResponse> __BuildGetSaldoc(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSaldocResponse>(() =>
            {
                var apiCallPath = "/getSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetService))]
        public IBodyWorkflowAction<GetServiceResponse> GetService([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetServiceResponse> __BuildGetService(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetServiceResponse>(() =>
            {
                var apiCallPath = "/getService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSOEMAIL))]
        public IBodyWorkflowAction<GetSOEMAILResponse> GetSOEMAIL([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSOEMAILResponse> __BuildGetSOEMAIL(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSOEMAILResponse>(() =>
            {
                var apiCallPath = "/getSoemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetMeeting))]
        public IBodyWorkflowAction<GetMeetingResponse> GetMeeting([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMeetingResponse> __BuildGetMeeting(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetMeetingResponse>(() =>
            {
                var apiCallPath = "/getSomeeting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSOTASK))]
        public IBodyWorkflowAction<GetSOTASKResponse> GetSOTASK([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSOTASKResponse> __BuildGetSOTASK(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSOTASKResponse>(() =>
            {
                var apiCallPath = "/getSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSupplier))]
        public IBodyWorkflowAction<GetSupplierResponse> GetSupplier([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSupplierResponse> __BuildGetSupplier(WorkflowExpression<string> bodykEY, WorkflowExpression<string> bodylOCATEINFO, WorkflowExpression<string> bodyfORM = null)
        {
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: true);
            WorkflowExpression.Validate(bodylOCATEINFO, nameof(bodylOCATEINFO), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            return new DeferredBodyAction<GetSupplierResponse>(() =>
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = ExpressionConverter.ConvertO(bodylOCATEINFO);
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
        [WorkflowExpressionFactory(nameof(__BuildSetCFNCUSDOC))]
        public IBodyWorkflowAction<SetData200response> SetCFNCUSDOC([WorkflowExpression] Func<string> bodyvaluecFNCUSDOCsERIES, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCtRDR, [WorkflowExpression] Func<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, [WorkflowExpression] Func<bodyvaluecASHLINESInputItem[]> bodyvaluecASHLINES = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCcOLLECTOR = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCcOMMENTS = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCproject = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCsALESMAN = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetCFNCUSDOC(WorkflowExpression<string> bodyvaluecFNCUSDOCsERIES, WorkflowExpression<string> bodyvaluecFNCUSDOCtRDR, WorkflowExpression<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, WorkflowExpression<bodyvaluecASHLINESInputItem[]> bodyvaluecASHLINES = null, WorkflowExpression<string> bodyvaluecFNCUSDOCcOLLECTOR = null, WorkflowExpression<string> bodyvaluecFNCUSDOCcOMMENTS = null, WorkflowExpression<string> bodyvaluecFNCUSDOCproject = null, WorkflowExpression<string> bodyvaluecFNCUSDOCsALESMAN = null, WorkflowExpression<string> bodyvaluecFNCUSDOCtRNDATE = null, WorkflowExpression<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCsERIES, nameof(bodyvaluecFNCUSDOCsERIES), required: true);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCtRDR, nameof(bodyvaluecFNCUSDOCtRDR), required: true);
            WorkflowExpression.Validate(bodyvaluecARDLINES, nameof(bodyvaluecARDLINES), required: false);
            WorkflowExpression.Validate(bodyvaluecASHLINES, nameof(bodyvaluecASHLINES), required: false);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCcOLLECTOR, nameof(bodyvaluecFNCUSDOCcOLLECTOR), required: false);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCcOMMENTS, nameof(bodyvaluecFNCUSDOCcOMMENTS), required: false);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCproject, nameof(bodyvaluecFNCUSDOCproject), required: false);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCsALESMAN, nameof(bodyvaluecFNCUSDOCsALESMAN), required: false);
            WorkflowExpression.Validate(bodyvaluecFNCUSDOCtRNDATE, nameof(bodyvaluecFNCUSDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUELINES, nameof(bodyvaluecHEQUELINES), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    dATAObject["CARDLINES"] = ExpressionConverter.ConvertO(bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = ExpressionConverter.ConvertO(bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNCUSDOCObject = new JObject();
                var cFNCUSDOCObjectpropCount = 0;
                if (bodyvaluecFNCUSDOCcOLLECTOR != null)
                {
                    cFNCUSDOCObject["COLLECTOR"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCcOLLECTOR);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCcOMMENTS != null)
                {
                    cFNCUSDOCObject["COMMENTS"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCcOMMENTS);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCproject != null)
                {
                    cFNCUSDOCObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCproject);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCsALESMAN != null)
                {
                    cFNCUSDOCObject["SALESMAN"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCsALESMAN);
                    cFNCUSDOCObjectpropCount++;
                }

                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCsERIES);
                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["TRDR"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCtRDR);
                if (bodyvaluecFNCUSDOCtRNDATE != null)
                {
                    cFNCUSDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluecFNCUSDOCtRNDATE);
                    cFNCUSDOCObjectpropCount++;
                }

                if (cFNCUSDOCObjectpropCount > 0)
                {
                    dATAObject["CFNCUSDOC"] = cFNCUSDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = ExpressionConverter.ConvertO(bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetCfnsupdoc))]
        public IBodyWorkflowAction<SetData200response> SetCfnsupdoc([WorkflowExpression] Func<string> bodyvaluecFNSUPDOCsERIES, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCtRDR, [WorkflowExpression] Func<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, [WorkflowExpression] Func<bodyvaluecASHLINESInputItem2[]> bodyvaluecASHLINES = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCpRJC = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetCfnsupdoc(WorkflowExpression<string> bodyvaluecFNSUPDOCsERIES, WorkflowExpression<string> bodyvaluecFNSUPDOCtRDR, WorkflowExpression<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, WorkflowExpression<bodyvaluecASHLINESInputItem2[]> bodyvaluecASHLINES = null, WorkflowExpression<string> bodyvaluecFNSUPDOCpRJC = null, WorkflowExpression<string> bodyvaluecFNSUPDOCrEMARKS = null, WorkflowExpression<string> bodyvaluecFNSUPDOCtRNDATE = null, WorkflowExpression<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluecFNSUPDOCsERIES, nameof(bodyvaluecFNSUPDOCsERIES), required: true);
            WorkflowExpression.Validate(bodyvaluecFNSUPDOCtRDR, nameof(bodyvaluecFNSUPDOCtRDR), required: true);
            WorkflowExpression.Validate(bodyvaluecARDLINES, nameof(bodyvaluecARDLINES), required: false);
            WorkflowExpression.Validate(bodyvaluecASHLINES, nameof(bodyvaluecASHLINES), required: false);
            WorkflowExpression.Validate(bodyvaluecFNSUPDOCpRJC, nameof(bodyvaluecFNSUPDOCpRJC), required: false);
            WorkflowExpression.Validate(bodyvaluecFNSUPDOCrEMARKS, nameof(bodyvaluecFNSUPDOCrEMARKS), required: false);
            WorkflowExpression.Validate(bodyvaluecFNSUPDOCtRNDATE, nameof(bodyvaluecFNSUPDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUELINES, nameof(bodyvaluecHEQUELINES), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    dATAObject["CARDLINES"] = ExpressionConverter.ConvertO(bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = ExpressionConverter.ConvertO(bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNSUPDOCObject = new JObject();
                var cFNSUPDOCObjectpropCount = 0;
                if (bodyvaluecFNSUPDOCpRJC != null)
                {
                    cFNSUPDOCObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluecFNSUPDOCpRJC);
                    cFNSUPDOCObjectpropCount++;
                }

                if (bodyvaluecFNSUPDOCrEMARKS != null)
                {
                    cFNSUPDOCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluecFNSUPDOCrEMARKS);
                    cFNSUPDOCObjectpropCount++;
                }

                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluecFNSUPDOCsERIES);
                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["TRDR"] = ExpressionConverter.ConvertO(bodyvaluecFNSUPDOCtRDR);
                if (bodyvaluecFNSUPDOCtRNDATE != null)
                {
                    cFNSUPDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluecFNSUPDOCtRNDATE);
                    cFNSUPDOCObjectpropCount++;
                }

                if (cFNSUPDOCObjectpropCount > 0)
                {
                    dATAObject["CFNSUPDOC"] = cFNSUPDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = ExpressionConverter.ConvertO(bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetCheque))]
        public IBodyWorkflowAction<SetData200response> SetCheque([WorkflowExpression] Func<string> bodyvaluecHEQUEbalance, [WorkflowExpression] Func<string> bodyvaluecHEQUEchequeNumber, [WorkflowExpression] Func<string> bodyvaluecHEQUEstatus, [WorkflowExpression] Func<string> bodyvaluecHEQUEvalue, [WorkflowExpression] Func<string> bodyvaluecHEQUEissueDate, [WorkflowExpression] Func<string> bodyvaluecHEQUEdueDate, [WorkflowExpression] Func<string> bodyvaluecHEQUEseries, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEbank = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerAddress = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerName = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerTelephone = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEreceiptDate = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEholderAddress = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEholderName = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerTRNo = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEcomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetCheque(WorkflowExpression<string> bodyvaluecHEQUEbalance, WorkflowExpression<string> bodyvaluecHEQUEchequeNumber, WorkflowExpression<string> bodyvaluecHEQUEstatus, WorkflowExpression<string> bodyvaluecHEQUEvalue, WorkflowExpression<string> bodyvaluecHEQUEissueDate, WorkflowExpression<string> bodyvaluecHEQUEdueDate, WorkflowExpression<string> bodyvaluecHEQUEseries, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluecHEQUEbank = null, WorkflowExpression<string> bodyvaluecHEQUEissuerAddress = null, WorkflowExpression<string> bodyvaluecHEQUEissuerName = null, WorkflowExpression<string> bodyvaluecHEQUEissuerTelephone = null, WorkflowExpression<string> bodyvaluecHEQUEreceiptDate = null, WorkflowExpression<string> bodyvaluecHEQUEholderAddress = null, WorkflowExpression<string> bodyvaluecHEQUEholderName = null, WorkflowExpression<string> bodyvaluecHEQUEissuerTRNo = null, WorkflowExpression<string> bodyvaluecHEQUEcomments = null)
        {
            WorkflowExpression.Validate(bodyvaluecHEQUEbalance, nameof(bodyvaluecHEQUEbalance), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEchequeNumber, nameof(bodyvaluecHEQUEchequeNumber), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEstatus, nameof(bodyvaluecHEQUEstatus), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEvalue, nameof(bodyvaluecHEQUEvalue), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEissueDate, nameof(bodyvaluecHEQUEissueDate), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEdueDate, nameof(bodyvaluecHEQUEdueDate), required: true);
            WorkflowExpression.Validate(bodyvaluecHEQUEseries, nameof(bodyvaluecHEQUEseries), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEbank, nameof(bodyvaluecHEQUEbank), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEissuerAddress, nameof(bodyvaluecHEQUEissuerAddress), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEissuerName, nameof(bodyvaluecHEQUEissuerName), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEissuerTelephone, nameof(bodyvaluecHEQUEissuerTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEreceiptDate, nameof(bodyvaluecHEQUEreceiptDate), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEholderAddress, nameof(bodyvaluecHEQUEholderAddress), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEholderName, nameof(bodyvaluecHEQUEholderName), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEissuerTRNo, nameof(bodyvaluecHEQUEissuerTRNo), required: false);
            WorkflowExpression.Validate(bodyvaluecHEQUEcomments, nameof(bodyvaluecHEQUEcomments), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    cHEQUEObject["BANK"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEbank);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEBAL"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEbalance);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUENUMBER"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEchequeNumber);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUESTATES"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEstatus);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEVAL"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEvalue);
                if (bodyvaluecHEQUEissuerAddress != null)
                {
                    cHEQUEObject["CREATORADDR"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEissuerAddress);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerName != null)
                {
                    cHEQUEObject["CREATORNAME"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEissuerName);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerTelephone != null)
                {
                    cHEQUEObject["CREATORPHONE"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEissuerTelephone);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEreceiptDate != null)
                {
                    cHEQUEObject["CRTDATE"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEreceiptDate);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["DATEOFS"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEissueDate);
                cHEQUEObjectpropCount++;
                cHEQUEObject["FINALDATE"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEdueDate);
                if (bodyvaluecHEQUEholderAddress != null)
                {
                    cHEQUEObject["HOLDERADDR"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEholderAddress);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEholderName != null)
                {
                    cHEQUEObject["HOLDERNAME"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEholderName);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerTRNo != null)
                {
                    cHEQUEObject["PUBLISHERAFM"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEissuerTRNo);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEcomments != null)
                {
                    cHEQUEObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEcomments);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluecHEQUEseries);
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
        [WorkflowExpressionFactory(nameof(__BuildSetContact))]
        public IBodyWorkflowAction<SetData200response> SetContact([WorkflowExpression] Func<string> bodyvaluepRSNOUTcode, [WorkflowExpression] Func<string> bodyvaluepRSNOUTname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTaddress = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtRNo = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTgeographicalAreas = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTbIRTHDATE = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcity = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcountry = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTarea = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTprefecture = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTeducationLevel = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTemail = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTemail2 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTfax = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTiDCardNo = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtaxOffice = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTmobileTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTsurname = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTfatherSName = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTmotherSName = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTnameOfSpouse = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTnationality = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtel1 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtel2 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTinternalTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTpersonalTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcomments = null, [WorkflowExpression] Func<bodyvaluepRSNOUTgenderInput> bodyvaluepRSNOUTgender = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTwebPage = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTzip = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetContact(WorkflowExpression<string> bodyvaluepRSNOUTcode, WorkflowExpression<string> bodyvaluepRSNOUTname, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluepRSNOUTaddress = null, WorkflowExpression<string> bodyvaluepRSNOUTtRNo = null, WorkflowExpression<string> bodyvaluepRSNOUTgeographicalAreas = null, WorkflowExpression<string> bodyvaluepRSNOUTbIRTHDATE = null, WorkflowExpression<string> bodyvaluepRSNOUTcity = null, WorkflowExpression<string> bodyvaluepRSNOUTcountry = null, WorkflowExpression<string> bodyvaluepRSNOUTarea = null, WorkflowExpression<string> bodyvaluepRSNOUTprefecture = null, WorkflowExpression<string> bodyvaluepRSNOUTeducationLevel = null, WorkflowExpression<string> bodyvaluepRSNOUTemail = null, WorkflowExpression<string> bodyvaluepRSNOUTemail2 = null, WorkflowExpression<string> bodyvaluepRSNOUTfax = null, WorkflowExpression<string> bodyvaluepRSNOUTiDCardNo = null, WorkflowExpression<string> bodyvaluepRSNOUTtaxOffice = null, WorkflowExpression<string> bodyvaluepRSNOUTmobileTelephone = null, WorkflowExpression<string> bodyvaluepRSNOUTsurname = null, WorkflowExpression<string> bodyvaluepRSNOUTfatherSName = null, WorkflowExpression<string> bodyvaluepRSNOUTmotherSName = null, WorkflowExpression<string> bodyvaluepRSNOUTnameOfSpouse = null, WorkflowExpression<string> bodyvaluepRSNOUTnationality = null, WorkflowExpression<string> bodyvaluepRSNOUTtel1 = null, WorkflowExpression<string> bodyvaluepRSNOUTtel2 = null, WorkflowExpression<string> bodyvaluepRSNOUTinternalTelephone = null, WorkflowExpression<string> bodyvaluepRSNOUTpersonalTelephone = null, WorkflowExpression<string> bodyvaluepRSNOUTcomments = null, WorkflowExpression<bodyvaluepRSNOUTgenderInput> bodyvaluepRSNOUTgender = null, WorkflowExpression<string> bodyvaluepRSNOUTwebPage = null, WorkflowExpression<string> bodyvaluepRSNOUTzip = null, WorkflowExpression<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            WorkflowExpression.Validate(bodyvaluepRSNOUTcode, nameof(bodyvaluepRSNOUTcode), required: true);
            WorkflowExpression.Validate(bodyvaluepRSNOUTname, nameof(bodyvaluepRSNOUTname), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTaddress, nameof(bodyvaluepRSNOUTaddress), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTtRNo, nameof(bodyvaluepRSNOUTtRNo), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTgeographicalAreas, nameof(bodyvaluepRSNOUTgeographicalAreas), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTbIRTHDATE, nameof(bodyvaluepRSNOUTbIRTHDATE), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTcity, nameof(bodyvaluepRSNOUTcity), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTcountry, nameof(bodyvaluepRSNOUTcountry), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTarea, nameof(bodyvaluepRSNOUTarea), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTprefecture, nameof(bodyvaluepRSNOUTprefecture), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTeducationLevel, nameof(bodyvaluepRSNOUTeducationLevel), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTemail, nameof(bodyvaluepRSNOUTemail), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTemail2, nameof(bodyvaluepRSNOUTemail2), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTfax, nameof(bodyvaluepRSNOUTfax), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTiDCardNo, nameof(bodyvaluepRSNOUTiDCardNo), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTtaxOffice, nameof(bodyvaluepRSNOUTtaxOffice), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTmobileTelephone, nameof(bodyvaluepRSNOUTmobileTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTsurname, nameof(bodyvaluepRSNOUTsurname), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTfatherSName, nameof(bodyvaluepRSNOUTfatherSName), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTmotherSName, nameof(bodyvaluepRSNOUTmotherSName), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTnameOfSpouse, nameof(bodyvaluepRSNOUTnameOfSpouse), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTnationality, nameof(bodyvaluepRSNOUTnationality), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTtel1, nameof(bodyvaluepRSNOUTtel1), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTtel2, nameof(bodyvaluepRSNOUTtel2), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTinternalTelephone, nameof(bodyvaluepRSNOUTinternalTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTpersonalTelephone, nameof(bodyvaluepRSNOUTpersonalTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTcomments, nameof(bodyvaluepRSNOUTcomments), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTgender, nameof(bodyvaluepRSNOUTgender), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTwebPage, nameof(bodyvaluepRSNOUTwebPage), required: false);
            WorkflowExpression.Validate(bodyvaluepRSNOUTzip, nameof(bodyvaluepRSNOUTzip), required: false);
            WorkflowExpression.Validate(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    pRSNOUTObject["ADDRESS"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTaddress);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtRNo != null)
                {
                    pRSNOUTObject["AFM"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTtRNo);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTgeographicalAreas != null)
                {
                    pRSNOUTObject["AREAS"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTgeographicalAreas);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTbIRTHDATE != null)
                {
                    pRSNOUTObject["BIRTHDATE"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTbIRTHDATE);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTcity != null)
                {
                    pRSNOUTObject["CITY"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTcity);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTcode);
                if (bodyvaluepRSNOUTcountry != null)
                {
                    pRSNOUTObject["COUNTRY"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTcountry);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTarea != null)
                {
                    pRSNOUTObject["DISTRICT"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTarea);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTprefecture != null)
                {
                    pRSNOUTObject["DISTRICT1"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTprefecture);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTeducationLevel != null)
                {
                    pRSNOUTObject["EDUCAT"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTeducationLevel);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTemail != null)
                {
                    pRSNOUTObject["EMAIL"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTemail);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTemail2 != null)
                {
                    pRSNOUTObject["EMAIL1"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTemail2);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTfax != null)
                {
                    pRSNOUTObject["FAX"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTfax);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTiDCardNo != null)
                {
                    pRSNOUTObject["IDENTITYNUM"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTiDCardNo);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtaxOffice != null)
                {
                    pRSNOUTObject["IRSDATA"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTtaxOffice);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTmobileTelephone != null)
                {
                    pRSNOUTObject["MOBILEPHONE"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTmobileTelephone);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTname);
                if (bodyvaluepRSNOUTsurname != null)
                {
                    pRSNOUTObject["NAME2"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTsurname);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTfatherSName != null)
                {
                    pRSNOUTObject["NAME3"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTfatherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTmotherSName != null)
                {
                    pRSNOUTObject["NAME4"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTmotherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTnameOfSpouse != null)
                {
                    pRSNOUTObject["NAME5"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTnameOfSpouse);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTnationality != null)
                {
                    pRSNOUTObject["NATIONALITY"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTnationality);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtel1 != null)
                {
                    pRSNOUTObject["PHONE1"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTtel1);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtel2 != null)
                {
                    pRSNOUTObject["PHONE2"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTtel2);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTinternalTelephone != null)
                {
                    pRSNOUTObject["PHONEEXT"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTinternalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTpersonalTelephone != null)
                {
                    pRSNOUTObject["PHONELOCAL"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTpersonalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTcomments != null)
                {
                    pRSNOUTObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTcomments);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTgender != null)
                {
                    pRSNOUTObject["SOSEX"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTgender);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTwebPage != null)
                {
                    pRSNOUTObject["WEBPAGE"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTwebPage);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTzip != null)
                {
                    pRSNOUTObject["ZIP"] = ExpressionConverter.ConvertO(bodyvaluepRSNOUTzip);
                    pRSNOUTObjectpropCount++;
                }

                if (pRSNOUTObjectpropCount > 0)
                {
                    dataObject["PRSNOUT"] = pRSNOUTObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodyvaluexTRDOCDATA);
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
        [WorkflowExpressionFactory(nameof(__BuildSetCustomer))]
        public IBodyWorkflowAction<SetData200response> SetCustomer([WorkflowExpression] Func<string> bodyvaluecUSTOMERcode, [WorkflowExpression] Func<string> bodyvaluecUSTOMERname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprimaryAddress = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERtRNo = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERgeographicalAreas = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERcity = null, [WorkflowExpression] Func<int> bodyvaluecUSTOMERdiscount = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERlocationArea = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMEReMail = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERfax = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERtaxOffice = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprofession = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprimaryTelephone = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERcomments = null, [WorkflowExpression] Func<bodyvaluecUSTOMERtaxCategoryInput> bodyvaluecUSTOMERtaxCategory = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERzip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetCustomer(WorkflowExpression<string> bodyvaluecUSTOMERcode, WorkflowExpression<string> bodyvaluecUSTOMERname, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluecUSTOMERprimaryAddress = null, WorkflowExpression<string> bodyvaluecUSTOMERtRNo = null, WorkflowExpression<string> bodyvaluecUSTOMERgeographicalAreas = null, WorkflowExpression<string> bodyvaluecUSTOMERcity = null, WorkflowExpression<int> bodyvaluecUSTOMERdiscount = null, WorkflowExpression<string> bodyvaluecUSTOMERlocationArea = null, WorkflowExpression<string> bodyvaluecUSTOMEReMail = null, WorkflowExpression<string> bodyvaluecUSTOMERfax = null, WorkflowExpression<string> bodyvaluecUSTOMERtaxOffice = null, WorkflowExpression<string> bodyvaluecUSTOMERprofession = null, WorkflowExpression<string> bodyvaluecUSTOMERprimaryTelephone = null, WorkflowExpression<string> bodyvaluecUSTOMERcomments = null, WorkflowExpression<bodyvaluecUSTOMERtaxCategoryInput> bodyvaluecUSTOMERtaxCategory = null, WorkflowExpression<string> bodyvaluecUSTOMERzip = null)
        {
            WorkflowExpression.Validate(bodyvaluecUSTOMERcode, nameof(bodyvaluecUSTOMERcode), required: true);
            WorkflowExpression.Validate(bodyvaluecUSTOMERname, nameof(bodyvaluecUSTOMERname), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERprimaryAddress, nameof(bodyvaluecUSTOMERprimaryAddress), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERtRNo, nameof(bodyvaluecUSTOMERtRNo), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERgeographicalAreas, nameof(bodyvaluecUSTOMERgeographicalAreas), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERcity, nameof(bodyvaluecUSTOMERcity), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERdiscount, nameof(bodyvaluecUSTOMERdiscount), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERlocationArea, nameof(bodyvaluecUSTOMERlocationArea), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMEReMail, nameof(bodyvaluecUSTOMEReMail), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERfax, nameof(bodyvaluecUSTOMERfax), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERtaxOffice, nameof(bodyvaluecUSTOMERtaxOffice), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERprofession, nameof(bodyvaluecUSTOMERprofession), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERprimaryTelephone, nameof(bodyvaluecUSTOMERprimaryTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERcomments, nameof(bodyvaluecUSTOMERcomments), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERtaxCategory, nameof(bodyvaluecUSTOMERtaxCategory), required: false);
            WorkflowExpression.Validate(bodyvaluecUSTOMERzip, nameof(bodyvaluecUSTOMERzip), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    cUSTOMERObject["ADDRESS"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERprimaryAddress);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtRNo != null)
                {
                    cUSTOMERObject["AFM"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERtRNo);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERgeographicalAreas != null)
                {
                    cUSTOMERObject["AREAS"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERgeographicalAreas);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERcity != null)
                {
                    cUSTOMERObject["CITY"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERcity);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERcode);
                if (bodyvaluecUSTOMERdiscount != null)
                {
                    cUSTOMERObject["DISCOUNT"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERdiscount);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERlocationArea != null)
                {
                    cUSTOMERObject["DISTRICT"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERlocationArea);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMEReMail != null)
                {
                    cUSTOMERObject["EMAIL"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMEReMail);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERfax != null)
                {
                    cUSTOMERObject["FAX"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERfax);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtaxOffice != null)
                {
                    cUSTOMERObject["IRSDATA"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERtaxOffice);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERprofession != null)
                {
                    cUSTOMERObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERprofession);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERname);
                if (bodyvaluecUSTOMERprimaryTelephone != null)
                {
                    cUSTOMERObject["PHONE01"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERprimaryTelephone);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERcomments != null)
                {
                    cUSTOMERObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERcomments);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtaxCategory != null)
                {
                    cUSTOMERObject["VATSTS"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERtaxCategory);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERzip != null)
                {
                    cUSTOMERObject["ZIP"] = ExpressionConverter.ConvertO(bodyvaluecUSTOMERzip);
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
        [WorkflowExpressionFactory(nameof(__BuildSetDraftEntry))]
        public IBodyWorkflowAction<SetData200response> SetDraftEntry([WorkflowExpression] Func<string> bodyvaluesODRAFTcode, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTaddress = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTtRNo = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcity = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcountry = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTarea = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTprefecture = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcategory = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcompanyEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTbusinessEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTpersonalEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTiDCardNo = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTactivity = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTmobileTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTnameTitle = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTfirstName = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTsurname = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTzip = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTbusinessTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTinternalTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTpersonalTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcomments = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTtitle = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTwebPage = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTzip2 = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKbranch = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKbusinessUnit = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKdepartment = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKproject = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKsource = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetDraftEntry(WorkflowExpression<string> bodyvaluesODRAFTcode, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluesODRAFTaddress = null, WorkflowExpression<string> bodyvaluesODRAFTtRNo = null, WorkflowExpression<string> bodyvaluesODRAFTcity = null, WorkflowExpression<string> bodyvaluesODRAFTcountry = null, WorkflowExpression<string> bodyvaluesODRAFTarea = null, WorkflowExpression<string> bodyvaluesODRAFTprefecture = null, WorkflowExpression<string> bodyvaluesODRAFTcategory = null, WorkflowExpression<string> bodyvaluesODRAFTcompanyEmail = null, WorkflowExpression<string> bodyvaluesODRAFTbusinessEmail = null, WorkflowExpression<string> bodyvaluesODRAFTpersonalEmail = null, WorkflowExpression<string> bodyvaluesODRAFTiDCardNo = null, WorkflowExpression<string> bodyvaluesODRAFTactivity = null, WorkflowExpression<string> bodyvaluesODRAFTmobileTelephone = null, WorkflowExpression<string> bodyvaluesODRAFTnameTitle = null, WorkflowExpression<string> bodyvaluesODRAFTfirstName = null, WorkflowExpression<string> bodyvaluesODRAFTsurname = null, WorkflowExpression<string> bodyvaluesODRAFTzip = null, WorkflowExpression<string> bodyvaluesODRAFTbusinessTelephone = null, WorkflowExpression<string> bodyvaluesODRAFTinternalTelephone = null, WorkflowExpression<string> bodyvaluesODRAFTpersonalTelephone = null, WorkflowExpression<string> bodyvaluesODRAFTcomments = null, WorkflowExpression<string> bodyvaluesODRAFTtitle = null, WorkflowExpression<string> bodyvaluesODRAFTwebPage = null, WorkflowExpression<string> bodyvaluesODRAFTzip2 = null, WorkflowExpression<string> bodyvaluesODRAFTLNKbranch = null, WorkflowExpression<string> bodyvaluesODRAFTLNKbusinessUnit = null, WorkflowExpression<string> bodyvaluesODRAFTLNKdepartment = null, WorkflowExpression<string> bodyvaluesODRAFTLNKproject = null, WorkflowExpression<string> bodyvaluesODRAFTLNKsource = null)
        {
            WorkflowExpression.Validate(bodyvaluesODRAFTcode, nameof(bodyvaluesODRAFTcode), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTaddress, nameof(bodyvaluesODRAFTaddress), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTtRNo, nameof(bodyvaluesODRAFTtRNo), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTcity, nameof(bodyvaluesODRAFTcity), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTcountry, nameof(bodyvaluesODRAFTcountry), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTarea, nameof(bodyvaluesODRAFTarea), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTprefecture, nameof(bodyvaluesODRAFTprefecture), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTcategory, nameof(bodyvaluesODRAFTcategory), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTcompanyEmail, nameof(bodyvaluesODRAFTcompanyEmail), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTbusinessEmail, nameof(bodyvaluesODRAFTbusinessEmail), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTpersonalEmail, nameof(bodyvaluesODRAFTpersonalEmail), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTiDCardNo, nameof(bodyvaluesODRAFTiDCardNo), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTactivity, nameof(bodyvaluesODRAFTactivity), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTmobileTelephone, nameof(bodyvaluesODRAFTmobileTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTnameTitle, nameof(bodyvaluesODRAFTnameTitle), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTfirstName, nameof(bodyvaluesODRAFTfirstName), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTsurname, nameof(bodyvaluesODRAFTsurname), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTzip, nameof(bodyvaluesODRAFTzip), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTbusinessTelephone, nameof(bodyvaluesODRAFTbusinessTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTinternalTelephone, nameof(bodyvaluesODRAFTinternalTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTpersonalTelephone, nameof(bodyvaluesODRAFTpersonalTelephone), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTcomments, nameof(bodyvaluesODRAFTcomments), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTtitle, nameof(bodyvaluesODRAFTtitle), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTwebPage, nameof(bodyvaluesODRAFTwebPage), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTzip2, nameof(bodyvaluesODRAFTzip2), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTLNKbranch, nameof(bodyvaluesODRAFTLNKbranch), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTLNKbusinessUnit, nameof(bodyvaluesODRAFTLNKbusinessUnit), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTLNKdepartment, nameof(bodyvaluesODRAFTLNKdepartment), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTLNKproject, nameof(bodyvaluesODRAFTLNKproject), required: false);
            WorkflowExpression.Validate(bodyvaluesODRAFTLNKsource, nameof(bodyvaluesODRAFTLNKsource), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    sODRAFTObject["ADDRESS"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTaddress);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTtRNo != null)
                {
                    sODRAFTObject["AFM"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTtRNo);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcity != null)
                {
                    sODRAFTObject["CITY"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcity);
                    sODRAFTObjectpropCount++;
                }

                sODRAFTObjectpropCount++;
                sODRAFTObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcode);
                if (bodyvaluesODRAFTcountry != null)
                {
                    sODRAFTObject["COUNTRY"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcountry);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTarea != null)
                {
                    sODRAFTObject["DISTRICT"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTarea);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTprefecture != null)
                {
                    sODRAFTObject["DISTRICT1"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTprefecture);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcategory != null)
                {
                    sODRAFTObject["DRAFTTYPE"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcategory);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcompanyEmail != null)
                {
                    sODRAFTObject["EMAIL"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcompanyEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTbusinessEmail != null)
                {
                    sODRAFTObject["EMAIL1"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTbusinessEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTpersonalEmail != null)
                {
                    sODRAFTObject["EMAIL2"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTpersonalEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTiDCardNo != null)
                {
                    sODRAFTObject["IDENTITYNUM"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTiDCardNo);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTactivity != null)
                {
                    sODRAFTObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTactivity);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTmobileTelephone != null)
                {
                    sODRAFTObject["MOBILEPHONE"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTmobileTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTnameTitle != null)
                {
                    sODRAFTObject["NAMEC"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTnameTitle);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTfirstName != null)
                {
                    sODRAFTObject["NAMEF"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTfirstName);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTsurname != null)
                {
                    sODRAFTObject["NAMEL"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTsurname);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTzip != null)
                {
                    sODRAFTObject["NUMCG"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTzip);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTbusinessTelephone != null)
                {
                    sODRAFTObject["PHONE1"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTbusinessTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTinternalTelephone != null)
                {
                    sODRAFTObject["PHONEEXT"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTinternalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTpersonalTelephone != null)
                {
                    sODRAFTObject["PHONELOCAL"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTpersonalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcomments != null)
                {
                    sODRAFTObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTcomments);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTtitle != null)
                {
                    sODRAFTObject["SOTITLENAME"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTtitle);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTwebPage != null)
                {
                    sODRAFTObject["WEBPAGE"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTwebPage);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTzip2 != null)
                {
                    sODRAFTObject["ZIP"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTzip2);
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
                    sODRAFTLNKObject["BRANCH"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTLNKbranch);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKbusinessUnit != null)
                {
                    sODRAFTLNKObject["BUSUNITS"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTLNKbusinessUnit);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKdepartment != null)
                {
                    sODRAFTLNKObject["DEPART"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTLNKdepartment);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKproject != null)
                {
                    sODRAFTLNKObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTLNKproject);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKsource != null)
                {
                    sODRAFTLNKObject["PRJCLEAD"] = ExpressionConverter.ConvertO(bodyvaluesODRAFTLNKsource);
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
        [WorkflowExpressionFactory(nameof(__BuildSetExpense))]
        public IBodyWorkflowAction<SetData200response> SetExpense([WorkflowExpression] Func<string> bodyvaluelINEITEMcode, [WorkflowExpression] Func<bodyvaluelINEITEMinvoicingCategoryInput> bodyvaluelINEITEMinvoicingCategory, [WorkflowExpression] Func<string> bodyvaluelINEITEMname, [WorkflowExpression] Func<string> bodyvaluelINEITEMvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluelINEITEMcommercialCategory = null, [WorkflowExpression] Func<bodyvaluelINEITEMtypeInput> bodyvaluelINEITEMtype = null, [WorkflowExpression] Func<string> bodyvaluelINEITEMcomments = null, [WorkflowExpression] Func<bodyvaluelINEITEMfeeValueInput> bodyvaluelINEITEMfeeValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetExpense(WorkflowExpression<string> bodyvaluelINEITEMcode, WorkflowExpression<bodyvaluelINEITEMinvoicingCategoryInput> bodyvaluelINEITEMinvoicingCategory, WorkflowExpression<string> bodyvaluelINEITEMname, WorkflowExpression<string> bodyvaluelINEITEMvatGroup, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluelINEITEMcommercialCategory = null, WorkflowExpression<bodyvaluelINEITEMtypeInput> bodyvaluelINEITEMtype = null, WorkflowExpression<string> bodyvaluelINEITEMcomments = null, WorkflowExpression<bodyvaluelINEITEMfeeValueInput> bodyvaluelINEITEMfeeValue = null)
        {
            WorkflowExpression.Validate(bodyvaluelINEITEMcode, nameof(bodyvaluelINEITEMcode), required: true);
            WorkflowExpression.Validate(bodyvaluelINEITEMinvoicingCategory, nameof(bodyvaluelINEITEMinvoicingCategory), required: true);
            WorkflowExpression.Validate(bodyvaluelINEITEMname, nameof(bodyvaluelINEITEMname), required: true);
            WorkflowExpression.Validate(bodyvaluelINEITEMvatGroup, nameof(bodyvaluelINEITEMvatGroup), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluelINEITEMcommercialCategory, nameof(bodyvaluelINEITEMcommercialCategory), required: false);
            WorkflowExpression.Validate(bodyvaluelINEITEMtype, nameof(bodyvaluelINEITEMtype), required: false);
            WorkflowExpression.Validate(bodyvaluelINEITEMcomments, nameof(bodyvaluelINEITEMcomments), required: false);
            WorkflowExpression.Validate(bodyvaluelINEITEMfeeValue, nameof(bodyvaluelINEITEMfeeValue), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                lINEITEMObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMcode);
                lINEITEMObjectpropCount++;
                lINEITEMObject["LISOURCETYPE"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMinvoicingCategory);
                if (bodyvaluelINEITEMcommercialCategory != null)
                {
                    lINEITEMObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMcommercialCategory);
                    lINEITEMObjectpropCount++;
                }

                if (bodyvaluelINEITEMtype != null)
                {
                    lINEITEMObject["MTRTYPE"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMtype);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMname);
                if (bodyvaluelINEITEMcomments != null)
                {
                    lINEITEMObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMcomments);
                    lINEITEMObjectpropCount++;
                }

                if (bodyvaluelINEITEMfeeValue != null)
                {
                    lINEITEMObject["SOPAYVALUE"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMfeeValue);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["VAT"] = ExpressionConverter.ConvertO(bodyvaluelINEITEMvatGroup);
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
        [WorkflowExpressionFactory(nameof(__BuildSetExpensesDoc))]
        public IBodyWorkflowAction<SetData200response> SetExpensesDoc([WorkflowExpression] Func<string> bodyvaluelINSUPDOCseries, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCsupplier, [WorkflowExpression] Func<bodyvalueunnamedInputItem[]> bodyvalueunnamed = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCproject = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCcomments = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCtRNDATE = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetExpensesDoc(WorkflowExpression<string> bodyvaluelINSUPDOCseries, WorkflowExpression<string> bodyvaluelINSUPDOCsupplier, WorkflowExpression<bodyvalueunnamedInputItem[]> bodyvalueunnamed = null, WorkflowExpression<string> bodyvaluelINSUPDOCproject = null, WorkflowExpression<string> bodyvaluelINSUPDOCcomments = null, WorkflowExpression<string> bodyvaluelINSUPDOCtRNDATE = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluelINSUPDOCseries, nameof(bodyvaluelINSUPDOCseries), required: true);
            WorkflowExpression.Validate(bodyvaluelINSUPDOCsupplier, nameof(bodyvaluelINSUPDOCsupplier), required: true);
            WorkflowExpression.Validate(bodyvalueunnamed, nameof(bodyvalueunnamed), required: false);
            WorkflowExpression.Validate(bodyvaluelINSUPDOCproject, nameof(bodyvaluelINSUPDOCproject), required: false);
            WorkflowExpression.Validate(bodyvaluelINSUPDOCcomments, nameof(bodyvaluelINSUPDOCcomments), required: false);
            WorkflowExpression.Validate(bodyvaluelINSUPDOCtRNDATE, nameof(bodyvaluelINSUPDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    dATAObject["LINLINES"] = ExpressionConverter.ConvertO(bodyvalueunnamed);
                    dATAObjectpropCount++;
                }

                var lINSUPDOCObject = new JObject();
                var lINSUPDOCObjectpropCount = 0;
                if (bodyvaluelINSUPDOCproject != null)
                {
                    lINSUPDOCObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluelINSUPDOCproject);
                    lINSUPDOCObjectpropCount++;
                }

                if (bodyvaluelINSUPDOCcomments != null)
                {
                    lINSUPDOCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluelINSUPDOCcomments);
                    lINSUPDOCObjectpropCount++;
                }

                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluelINSUPDOCseries);
                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["TRDR"] = ExpressionConverter.ConvertO(bodyvaluelINSUPDOCsupplier);
                if (bodyvaluelINSUPDOCtRNDATE != null)
                {
                    lINSUPDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluelINSUPDOCtRNDATE);
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetItedoc))]
        public IBodyWorkflowAction<SetData200response> SetItedoc([WorkflowExpression] Func<string> bodyvalueiTEDOCseries, [WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCreason = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCtRNDATE = null, [WorkflowExpression] Func<bodyvalueiTELINESInputItem[]> bodyvalueiTELINES = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetItedoc(WorkflowExpression<string> bodyvalueiTEDOCseries, WorkflowExpression<string> bodyvaluemTRDOCwarehouse, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvalueiTEDOCreason = null, WorkflowExpression<string> bodyvalueiTEDOCrEMARKS = null, WorkflowExpression<string> bodyvalueiTEDOCtRNDATE = null, WorkflowExpression<bodyvalueiTELINESInputItem[]> bodyvalueiTELINES = null)
        {
            WorkflowExpression.Validate(bodyvalueiTEDOCseries, nameof(bodyvalueiTEDOCseries), required: true);
            WorkflowExpression.Validate(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvalueiTEDOCreason, nameof(bodyvalueiTEDOCreason), required: false);
            WorkflowExpression.Validate(bodyvalueiTEDOCrEMARKS, nameof(bodyvalueiTEDOCrEMARKS), required: false);
            WorkflowExpression.Validate(bodyvalueiTEDOCtRNDATE, nameof(bodyvalueiTEDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    iTEDOCObject["COMMENTS"] = ExpressionConverter.ConvertO(bodyvalueiTEDOCreason);
                    iTEDOCObjectpropCount++;
                }

                if (bodyvalueiTEDOCrEMARKS != null)
                {
                    iTEDOCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvalueiTEDOCrEMARKS);
                    iTEDOCObjectpropCount++;
                }

                iTEDOCObjectpropCount++;
                iTEDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvalueiTEDOCseries);
                if (bodyvalueiTEDOCtRNDATE != null)
                {
                    iTEDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvalueiTEDOCtRNDATE);
                    iTEDOCObjectpropCount++;
                }

                if (iTEDOCObjectpropCount > 0)
                {
                    dataObject["ITEDOC"] = iTEDOCObject;
                    dataObjectpropCount++;
                }

                if (bodyvalueiTELINES != null)
                {
                    dataObject["ITELINES"] = ExpressionConverter.ConvertO(bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(bodyvaluemTRDOCwarehouse);
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
        [WorkflowExpressionFactory(nameof(__BuildSetItem))]
        public IBodyWorkflowAction<SetData200response> SetItem([WorkflowExpression] Func<string> bodyvalueiTEMcode, [WorkflowExpression] Func<string> bodyvalueiTEMbaseUnitOfMeasure, [WorkflowExpression] Func<string> bodyvalueiTEMname, [WorkflowExpression] Func<string> bodyvalueiTEMvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvalueiTEMcommercialCategory = null, [WorkflowExpression] Func<string> bodyvalueiTEMitemGroup = null, [WorkflowExpression] Func<string> bodyvalueiTEMretailPrice = null, [WorkflowExpression] Func<string> bodyvalueiTEMwholesalePrice = null, [WorkflowExpression] Func<string> bodyvalueiTEMcomments = null, [WorkflowExpression] Func<string> bodyvalueiTEMdiscount1 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetItem(WorkflowExpression<string> bodyvalueiTEMcode, WorkflowExpression<string> bodyvalueiTEMbaseUnitOfMeasure, WorkflowExpression<string> bodyvalueiTEMname, WorkflowExpression<string> bodyvalueiTEMvatGroup, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvalueiTEMcommercialCategory = null, WorkflowExpression<string> bodyvalueiTEMitemGroup = null, WorkflowExpression<string> bodyvalueiTEMretailPrice = null, WorkflowExpression<string> bodyvalueiTEMwholesalePrice = null, WorkflowExpression<string> bodyvalueiTEMcomments = null, WorkflowExpression<string> bodyvalueiTEMdiscount1 = null)
        {
            WorkflowExpression.Validate(bodyvalueiTEMcode, nameof(bodyvalueiTEMcode), required: true);
            WorkflowExpression.Validate(bodyvalueiTEMbaseUnitOfMeasure, nameof(bodyvalueiTEMbaseUnitOfMeasure), required: true);
            WorkflowExpression.Validate(bodyvalueiTEMname, nameof(bodyvalueiTEMname), required: true);
            WorkflowExpression.Validate(bodyvalueiTEMvatGroup, nameof(bodyvalueiTEMvatGroup), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMcommercialCategory, nameof(bodyvalueiTEMcommercialCategory), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMitemGroup, nameof(bodyvalueiTEMitemGroup), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMretailPrice, nameof(bodyvalueiTEMretailPrice), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMwholesalePrice, nameof(bodyvalueiTEMwholesalePrice), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMcomments, nameof(bodyvalueiTEMcomments), required: false);
            WorkflowExpression.Validate(bodyvalueiTEMdiscount1, nameof(bodyvalueiTEMdiscount1), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                iTEMObject["CODE"] = ExpressionConverter.ConvertO(bodyvalueiTEMcode);
                if (bodyvalueiTEMcommercialCategory != null)
                {
                    iTEMObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(bodyvalueiTEMcommercialCategory);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMitemGroup != null)
                {
                    iTEMObject["MTRGROUP"] = ExpressionConverter.ConvertO(bodyvalueiTEMitemGroup);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["MTRUNIT1"] = ExpressionConverter.ConvertO(bodyvalueiTEMbaseUnitOfMeasure);
                iTEMObjectpropCount++;
                iTEMObject["NAME"] = ExpressionConverter.ConvertO(bodyvalueiTEMname);
                if (bodyvalueiTEMretailPrice != null)
                {
                    iTEMObject["PRICER"] = ExpressionConverter.ConvertO(bodyvalueiTEMretailPrice);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMwholesalePrice != null)
                {
                    iTEMObject["PRICEW"] = ExpressionConverter.ConvertO(bodyvalueiTEMwholesalePrice);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMcomments != null)
                {
                    iTEMObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvalueiTEMcomments);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMdiscount1 != null)
                {
                    iTEMObject["SODISCOUNT"] = ExpressionConverter.ConvertO(bodyvalueiTEMdiscount1);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["VAT"] = ExpressionConverter.ConvertO(bodyvalueiTEMvatGroup);
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
        [WorkflowExpressionFactory(nameof(__BuildSetProject))]
        public IBodyWorkflowAction<SetData200response> SetProject([WorkflowExpression] Func<string> bodyvaluepRJCcode, [WorkflowExpression] Func<string> bodyvaluepRJCname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<bodyvaluepRJCaCTSTATUSInput> bodyvaluepRJCaCTSTATUS = null, [WorkflowExpression] Func<string> bodyvaluepRJCfINALDATE = null, [WorkflowExpression] Func<string> bodyvaluepRJCfROMDATE = null, [WorkflowExpression] Func<bodyvaluepRJCpRJCRMInput> bodyvaluepRJCpRJCRM = null, [WorkflowExpression] Func<string> bodyvaluepRJCcomments = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetProject(WorkflowExpression<string> bodyvaluepRJCcode, WorkflowExpression<string> bodyvaluepRJCname, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<bodyvaluepRJCaCTSTATUSInput> bodyvaluepRJCaCTSTATUS = null, WorkflowExpression<string> bodyvaluepRJCfINALDATE = null, WorkflowExpression<string> bodyvaluepRJCfROMDATE = null, WorkflowExpression<bodyvaluepRJCpRJCRMInput> bodyvaluepRJCpRJCRM = null, WorkflowExpression<string> bodyvaluepRJCcomments = null, WorkflowExpression<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            WorkflowExpression.Validate(bodyvaluepRJCcode, nameof(bodyvaluepRJCcode), required: true);
            WorkflowExpression.Validate(bodyvaluepRJCname, nameof(bodyvaluepRJCname), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluepRJCaCTSTATUS, nameof(bodyvaluepRJCaCTSTATUS), required: false);
            WorkflowExpression.Validate(bodyvaluepRJCfINALDATE, nameof(bodyvaluepRJCfINALDATE), required: false);
            WorkflowExpression.Validate(bodyvaluepRJCfROMDATE, nameof(bodyvaluepRJCfROMDATE), required: false);
            WorkflowExpression.Validate(bodyvaluepRJCpRJCRM, nameof(bodyvaluepRJCpRJCRM), required: false);
            WorkflowExpression.Validate(bodyvaluepRJCcomments, nameof(bodyvaluepRJCcomments), required: false);
            WorkflowExpression.Validate(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    pRJCObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodyvaluepRJCaCTSTATUS);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluepRJCcode);
                if (bodyvaluepRJCfINALDATE != null)
                {
                    pRJCObject["FINALDATE"] = ExpressionConverter.ConvertO(bodyvaluepRJCfINALDATE);
                    pRJCObjectpropCount++;
                }

                if (bodyvaluepRJCfROMDATE != null)
                {
                    pRJCObject["FROMDATE"] = ExpressionConverter.ConvertO(bodyvaluepRJCfROMDATE);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluepRJCname);
                if (bodyvaluepRJCpRJCRM != null)
                {
                    pRJCObject["PRJCRM"] = ExpressionConverter.ConvertO(bodyvaluepRJCpRJCRM);
                    pRJCObjectpropCount++;
                }

                if (bodyvaluepRJCcomments != null)
                {
                    pRJCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluepRJCcomments);
                    pRJCObjectpropCount++;
                }

                if (pRJCObjectpropCount > 0)
                {
                    dataObject["PRJC"] = pRJCObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodyvaluexTRDOCDATA);
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
        [WorkflowExpressionFactory(nameof(__BuildSetPurdoc))]
        public IBodyWorkflowAction<SetData200response> SetPurdoc([WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyvaluepURDOCsERIES, [WorkflowExpression] Func<string> bodyvaluepURDOCsOCURRENCY, [WorkflowExpression] Func<string> bodyvaluepURDOCtRDR, [WorkflowExpression] Func<bodyvalueiTELINESInputItem2[]> bodyvalueiTELINES = null, [WorkflowExpression] Func<string> bodyvaluepURDOCdISC1PRC = null, [WorkflowExpression] Func<string> bodyvaluepURDOCpAYMENT = null, [WorkflowExpression] Func<string> bodyvaluepURDOCpRJC = null, [WorkflowExpression] Func<string> bodyvaluepURDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluepURDOCsUMAMNT = null, [WorkflowExpression] Func<string> bodyvaluepURDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluesRVLINESInputItem[]> bodyvaluesRVLINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetPurdoc(WorkflowExpression<string> bodyvaluemTRDOCwarehouse, WorkflowExpression<string> bodyvaluepURDOCsERIES, WorkflowExpression<string> bodyvaluepURDOCsOCURRENCY, WorkflowExpression<string> bodyvaluepURDOCtRDR, WorkflowExpression<bodyvalueiTELINESInputItem2[]> bodyvalueiTELINES = null, WorkflowExpression<string> bodyvaluepURDOCdISC1PRC = null, WorkflowExpression<string> bodyvaluepURDOCpAYMENT = null, WorkflowExpression<string> bodyvaluepURDOCpRJC = null, WorkflowExpression<string> bodyvaluepURDOCrEMARKS = null, WorkflowExpression<string> bodyvaluepURDOCsUMAMNT = null, WorkflowExpression<string> bodyvaluepURDOCtRNDATE = null, WorkflowExpression<bodyvaluesRVLINESInputItem[]> bodyvaluesRVLINES = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            WorkflowExpression.Validate(bodyvaluepURDOCsERIES, nameof(bodyvaluepURDOCsERIES), required: true);
            WorkflowExpression.Validate(bodyvaluepURDOCsOCURRENCY, nameof(bodyvaluepURDOCsOCURRENCY), required: true);
            WorkflowExpression.Validate(bodyvaluepURDOCtRDR, nameof(bodyvaluepURDOCtRDR), required: true);
            WorkflowExpression.Validate(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCdISC1PRC, nameof(bodyvaluepURDOCdISC1PRC), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCpAYMENT, nameof(bodyvaluepURDOCpAYMENT), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCpRJC, nameof(bodyvaluepURDOCpRJC), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCrEMARKS, nameof(bodyvaluepURDOCrEMARKS), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCsUMAMNT, nameof(bodyvaluepURDOCsUMAMNT), required: false);
            WorkflowExpression.Validate(bodyvaluepURDOCtRNDATE, nameof(bodyvaluepURDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvaluesRVLINES, nameof(bodyvaluesRVLINES), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    dATAObject["ITELINES"] = ExpressionConverter.ConvertO(bodyvalueiTELINES);
                    dATAObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dATAObject["MTRDOC"] = mTRDOCObject;
                    dATAObjectpropCount++;
                }

                var pURDOCObject = new JObject();
                var pURDOCObjectpropCount = 0;
                if (bodyvaluepURDOCdISC1PRC != null)
                {
                    pURDOCObject["DISC1PRC"] = ExpressionConverter.ConvertO(bodyvaluepURDOCdISC1PRC);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCpAYMENT != null)
                {
                    pURDOCObject["PAYMENT"] = ExpressionConverter.ConvertO(bodyvaluepURDOCpAYMENT);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCpRJC != null)
                {
                    pURDOCObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluepURDOCpRJC);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCrEMARKS != null)
                {
                    pURDOCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluepURDOCrEMARKS);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluepURDOCsERIES);
                pURDOCObjectpropCount++;
                pURDOCObject["SOCURRENCY"] = ExpressionConverter.ConvertO(bodyvaluepURDOCsOCURRENCY);
                if (bodyvaluepURDOCsUMAMNT != null)
                {
                    pURDOCObject["SUMAMNT"] = ExpressionConverter.ConvertO(bodyvaluepURDOCsUMAMNT);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["TRDR"] = ExpressionConverter.ConvertO(bodyvaluepURDOCtRDR);
                if (bodyvaluepURDOCtRNDATE != null)
                {
                    pURDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluepURDOCtRNDATE);
                    pURDOCObjectpropCount++;
                }

                if (pURDOCObjectpropCount > 0)
                {
                    dATAObject["PURDOC"] = pURDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluesRVLINES != null)
                {
                    dATAObject["SRVLINES"] = ExpressionConverter.ConvertO(bodyvaluesRVLINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetSaldoc))]
        public IBodyWorkflowAction<SetData200response> SetSaldoc([WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyvaluesALDOCpayment, [WorkflowExpression] Func<string> bodyvaluesALDOCseries, [WorkflowExpression] Func<string> bodyvaluesALDOCcurrency, [WorkflowExpression] Func<string> bodyvaluesALDOCcustomer, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<bodyvalueiTELINESInputItem22[]> bodyvalueiTELINES = null, [WorkflowExpression] Func<string> bodyvaluesALDOCdiscount = null, [WorkflowExpression] Func<string> bodyvaluesALDOCdiscountValue = null, [WorkflowExpression] Func<string> bodyvaluesALDOCnetAmount = null, [WorkflowExpression] Func<string> bodyvaluesALDOCproject = null, [WorkflowExpression] Func<string> bodyvaluesALDOCcomments = null, [WorkflowExpression] Func<string> bodyvaluesALDOCtotal = null, [WorkflowExpression] Func<string> bodyvaluesALDOCtRNDATE = null, [WorkflowExpression] Func<string> bodyvaluesALDOCvAT = null, [WorkflowExpression] Func<bodyvaluesRVLINESInputItem2[]> bodyvaluesRVLINES = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetSaldoc(WorkflowExpression<string> bodyvaluemTRDOCwarehouse, WorkflowExpression<string> bodyvaluesALDOCpayment, WorkflowExpression<string> bodyvaluesALDOCseries, WorkflowExpression<string> bodyvaluesALDOCcurrency, WorkflowExpression<string> bodyvaluesALDOCcustomer, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<bodyvalueiTELINESInputItem22[]> bodyvalueiTELINES = null, WorkflowExpression<string> bodyvaluesALDOCdiscount = null, WorkflowExpression<string> bodyvaluesALDOCdiscountValue = null, WorkflowExpression<string> bodyvaluesALDOCnetAmount = null, WorkflowExpression<string> bodyvaluesALDOCproject = null, WorkflowExpression<string> bodyvaluesALDOCcomments = null, WorkflowExpression<string> bodyvaluesALDOCtotal = null, WorkflowExpression<string> bodyvaluesALDOCtRNDATE = null, WorkflowExpression<string> bodyvaluesALDOCvAT = null, WorkflowExpression<bodyvaluesRVLINESInputItem2[]> bodyvaluesRVLINES = null)
        {
            WorkflowExpression.Validate(bodyvaluemTRDOCwarehouse, nameof(bodyvaluemTRDOCwarehouse), required: true);
            WorkflowExpression.Validate(bodyvaluesALDOCpayment, nameof(bodyvaluesALDOCpayment), required: true);
            WorkflowExpression.Validate(bodyvaluesALDOCseries, nameof(bodyvaluesALDOCseries), required: true);
            WorkflowExpression.Validate(bodyvaluesALDOCcurrency, nameof(bodyvaluesALDOCcurrency), required: true);
            WorkflowExpression.Validate(bodyvaluesALDOCcustomer, nameof(bodyvaluesALDOCcustomer), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvalueiTELINES, nameof(bodyvalueiTELINES), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCdiscount, nameof(bodyvaluesALDOCdiscount), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCdiscountValue, nameof(bodyvaluesALDOCdiscountValue), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCnetAmount, nameof(bodyvaluesALDOCnetAmount), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCproject, nameof(bodyvaluesALDOCproject), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCcomments, nameof(bodyvaluesALDOCcomments), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCtotal, nameof(bodyvaluesALDOCtotal), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCtRNDATE, nameof(bodyvaluesALDOCtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvaluesALDOCvAT, nameof(bodyvaluesALDOCvAT), required: false);
            WorkflowExpression.Validate(bodyvaluesRVLINES, nameof(bodyvaluesRVLINES), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                    dataObject["ITELINES"] = ExpressionConverter.ConvertO(bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = ExpressionConverter.ConvertO(bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dataObject["MTRDOC"] = mTRDOCObject;
                    dataObjectpropCount++;
                }

                var sALDOCObject = new JObject();
                var sALDOCObjectpropCount = 0;
                if (bodyvaluesALDOCdiscount != null)
                {
                    sALDOCObject["DISC1PRC"] = ExpressionConverter.ConvertO(bodyvaluesALDOCdiscount);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCdiscountValue != null)
                {
                    sALDOCObject["DISC1VAL"] = ExpressionConverter.ConvertO(bodyvaluesALDOCdiscountValue);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCnetAmount != null)
                {
                    sALDOCObject["NETAMNT"] = ExpressionConverter.ConvertO(bodyvaluesALDOCnetAmount);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["PAYMENT"] = ExpressionConverter.ConvertO(bodyvaluesALDOCpayment);
                if (bodyvaluesALDOCproject != null)
                {
                    sALDOCObject["PRJC"] = ExpressionConverter.ConvertO(bodyvaluesALDOCproject);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCcomments != null)
                {
                    sALDOCObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluesALDOCcomments);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluesALDOCseries);
                sALDOCObjectpropCount++;
                sALDOCObject["SOCURRENCY"] = ExpressionConverter.ConvertO(bodyvaluesALDOCcurrency);
                if (bodyvaluesALDOCtotal != null)
                {
                    sALDOCObject["SUMAMNT"] = ExpressionConverter.ConvertO(bodyvaluesALDOCtotal);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["TRDR"] = ExpressionConverter.ConvertO(bodyvaluesALDOCcustomer);
                if (bodyvaluesALDOCtRNDATE != null)
                {
                    sALDOCObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluesALDOCtRNDATE);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCvAT != null)
                {
                    sALDOCObject["VATAMNT"] = ExpressionConverter.ConvertO(bodyvaluesALDOCvAT);
                    sALDOCObjectpropCount++;
                }

                if (sALDOCObjectpropCount > 0)
                {
                    dataObject["SALDOC"] = sALDOCObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluesRVLINES != null)
                {
                    dataObject["SRVLINES"] = ExpressionConverter.ConvertO(bodyvaluesRVLINES);
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
        [WorkflowExpressionFactory(nameof(__BuildSetService))]
        public IBodyWorkflowAction<SetData200response> SetService([WorkflowExpression] Func<string> bodyvaluesERVICEcode, [WorkflowExpression] Func<string> bodyvaluesERVICEbaseUnitOfMeasure, [WorkflowExpression] Func<string> bodyvaluesERVICEname, [WorkflowExpression] Func<string> bodyvaluesERVICEvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluesERVICEcommercialCategory = null, [WorkflowExpression] Func<string> bodyvaluesERVICEserviceGroup = null, [WorkflowExpression] Func<string> bodyvaluesERVICEretailPrice = null, [WorkflowExpression] Func<string> bodyvaluesERVICEwholesalePrice = null, [WorkflowExpression] Func<string> bodyvaluesERVICEcomments = null, [WorkflowExpression] Func<string> bodyvaluesERVICEdiscount1 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetService(WorkflowExpression<string> bodyvaluesERVICEcode, WorkflowExpression<string> bodyvaluesERVICEbaseUnitOfMeasure, WorkflowExpression<string> bodyvaluesERVICEname, WorkflowExpression<string> bodyvaluesERVICEvatGroup, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null, WorkflowExpression<string> bodyvaluesERVICEcommercialCategory = null, WorkflowExpression<string> bodyvaluesERVICEserviceGroup = null, WorkflowExpression<string> bodyvaluesERVICEretailPrice = null, WorkflowExpression<string> bodyvaluesERVICEwholesalePrice = null, WorkflowExpression<string> bodyvaluesERVICEcomments = null, WorkflowExpression<string> bodyvaluesERVICEdiscount1 = null)
        {
            WorkflowExpression.Validate(bodyvaluesERVICEcode, nameof(bodyvaluesERVICEcode), required: true);
            WorkflowExpression.Validate(bodyvaluesERVICEbaseUnitOfMeasure, nameof(bodyvaluesERVICEbaseUnitOfMeasure), required: true);
            WorkflowExpression.Validate(bodyvaluesERVICEname, nameof(bodyvaluesERVICEname), required: true);
            WorkflowExpression.Validate(bodyvaluesERVICEvatGroup, nameof(bodyvaluesERVICEvatGroup), required: true);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEcommercialCategory, nameof(bodyvaluesERVICEcommercialCategory), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEserviceGroup, nameof(bodyvaluesERVICEserviceGroup), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEretailPrice, nameof(bodyvaluesERVICEretailPrice), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEwholesalePrice, nameof(bodyvaluesERVICEwholesalePrice), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEcomments, nameof(bodyvaluesERVICEcomments), required: false);
            WorkflowExpression.Validate(bodyvaluesERVICEdiscount1, nameof(bodyvaluesERVICEdiscount1), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
            {
                var apiCallPath = "/setService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
                sERVICEObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluesERVICEcode);
                if (bodyvaluesERVICEcommercialCategory != null)
                {
                    sERVICEObject["MTRCATEGORY"] = ExpressionConverter.ConvertO(bodyvaluesERVICEcommercialCategory);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEserviceGroup != null)
                {
                    sERVICEObject["MTRGROUP"] = ExpressionConverter.ConvertO(bodyvaluesERVICEserviceGroup);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["MTRUNIT1"] = ExpressionConverter.ConvertO(bodyvaluesERVICEbaseUnitOfMeasure);
                sERVICEObjectpropCount++;
                sERVICEObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluesERVICEname);
                if (bodyvaluesERVICEretailPrice != null)
                {
                    sERVICEObject["PRICER"] = ExpressionConverter.ConvertO(bodyvaluesERVICEretailPrice);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEwholesalePrice != null)
                {
                    sERVICEObject["PRICEW"] = ExpressionConverter.ConvertO(bodyvaluesERVICEwholesalePrice);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEcomments != null)
                {
                    sERVICEObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluesERVICEcomments);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEdiscount1 != null)
                {
                    sERVICEObject["SODISCOUNT"] = ExpressionConverter.ConvertO(bodyvaluesERVICEdiscount1);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["VAT"] = ExpressionConverter.ConvertO(bodyvaluesERVICEvatGroup);
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
        [WorkflowExpressionFactory(nameof(__BuildSetSOEMAIL))]
        public IBodyWorkflowAction<SetData200response> SetSOEMAIL([WorkflowExpression] Func<string> bodyvaluesOACTIONsERIES, [WorkflowExpression] Func<bodyvaluesOACTIONaCTSTATUSInput> bodyvaluesOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodyvaluesOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodyvaluesOACTIONtRNDATE = null, [WorkflowExpression] Func<string> bodyvaluesOMAILfROMADDRESS = null, [WorkflowExpression] Func<string> bodyvaluesOMAILfROMNAME = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOBCC = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOBODY = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOCC = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOTO = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetSOEMAIL(WorkflowExpression<string> bodyvaluesOACTIONsERIES, WorkflowExpression<bodyvaluesOACTIONaCTSTATUSInput> bodyvaluesOACTIONaCTSTATUS = null, WorkflowExpression<string> bodyvaluesOACTIONcOMMENTS = null, WorkflowExpression<string> bodyvaluesOACTIONtRNDATE = null, WorkflowExpression<string> bodyvaluesOMAILfROMADDRESS = null, WorkflowExpression<string> bodyvaluesOMAILfROMNAME = null, WorkflowExpression<string> bodyvaluesOMAILsOBCC = null, WorkflowExpression<string> bodyvaluesOMAILsOBODY = null, WorkflowExpression<string> bodyvaluesOMAILsOCC = null, WorkflowExpression<string> bodyvaluesOMAILsOTO = null, WorkflowExpression<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluesOACTIONsERIES, nameof(bodyvaluesOACTIONsERIES), required: true);
            WorkflowExpression.Validate(bodyvaluesOACTIONaCTSTATUS, nameof(bodyvaluesOACTIONaCTSTATUS), required: false);
            WorkflowExpression.Validate(bodyvaluesOACTIONcOMMENTS, nameof(bodyvaluesOACTIONcOMMENTS), required: false);
            WorkflowExpression.Validate(bodyvaluesOACTIONtRNDATE, nameof(bodyvaluesOACTIONtRNDATE), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILfROMADDRESS, nameof(bodyvaluesOMAILfROMADDRESS), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILfROMNAME, nameof(bodyvaluesOMAILfROMNAME), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILsOBCC, nameof(bodyvaluesOMAILsOBCC), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILsOBODY, nameof(bodyvaluesOMAILsOBODY), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILsOCC, nameof(bodyvaluesOMAILsOCC), required: false);
            WorkflowExpression.Validate(bodyvaluesOMAILsOTO, nameof(bodyvaluesOMAILsOTO), required: false);
            WorkflowExpression.Validate(bodyvaluexTRDOCDATA, nameof(bodyvaluexTRDOCDATA), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodyvaluesOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodyvaluesOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(bodyvaluesOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(bodyvaluesOACTIONsERIES);
                if (bodyvaluesOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(bodyvaluesOACTIONtRNDATE);
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
                    sOMAILObject["FROMADDRESS"] = ExpressionConverter.ConvertO(bodyvaluesOMAILfROMADDRESS);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILfROMNAME != null)
                {
                    sOMAILObject["FROMNAME"] = ExpressionConverter.ConvertO(bodyvaluesOMAILfROMNAME);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOBCC != null)
                {
                    sOMAILObject["SOBCC"] = ExpressionConverter.ConvertO(bodyvaluesOMAILsOBCC);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOBODY != null)
                {
                    sOMAILObject["SOBODY"] = ExpressionConverter.ConvertO(bodyvaluesOMAILsOBODY);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOCC != null)
                {
                    sOMAILObject["SOCC"] = ExpressionConverter.ConvertO(bodyvaluesOMAILsOCC);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOTO != null)
                {
                    sOMAILObject["SOTO"] = ExpressionConverter.ConvertO(bodyvaluesOMAILsOTO);
                    sOMAILObjectpropCount++;
                }

                if (sOMAILObjectpropCount > 0)
                {
                    dATAObject["SOMAIL"] = sOMAILObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodyvaluexTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetMeeting))]
        public IBodyWorkflowAction<SetData200response> SetMeeting([WorkflowExpression] Func<string> bodydATAsOACTIONsERIES, [WorkflowExpression] Func<string> bodydATAsOACTIONoperator = null, [WorkflowExpression] Func<string> bodydATAsOACTIONoperatorContact = null, [WorkflowExpression] Func<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfINALDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfROMDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedBy = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedByContact = null, [WorkflowExpression] Func<string> bodydATAsOACTIONpriority = null, [WorkflowExpression] Func<string> bodydATAsOACTIONproject = null, [WorkflowExpression] Func<string> bodydATAsOACTIONrEMARKS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRDR = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRNDATE = null, [WorkflowExpression] Func<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetMeeting(WorkflowExpression<string> bodydATAsOACTIONsERIES, WorkflowExpression<string> bodydATAsOACTIONoperator = null, WorkflowExpression<string> bodydATAsOACTIONoperatorContact = null, WorkflowExpression<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, WorkflowExpression<string> bodydATAsOACTIONcOMMENTS = null, WorkflowExpression<string> bodydATAsOACTIONfINALDATE = null, WorkflowExpression<string> bodydATAsOACTIONfROMDATE = null, WorkflowExpression<string> bodydATAsOACTIONorderedBy = null, WorkflowExpression<string> bodydATAsOACTIONorderedByContact = null, WorkflowExpression<string> bodydATAsOACTIONpriority = null, WorkflowExpression<string> bodydATAsOACTIONproject = null, WorkflowExpression<string> bodydATAsOACTIONrEMARKS = null, WorkflowExpression<string> bodydATAsOACTIONtRDR = null, WorkflowExpression<string> bodydATAsOACTIONtRNDATE = null, WorkflowExpression<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodydATAsOACTIONsERIES, nameof(bodydATAsOACTIONsERIES), required: true);
            WorkflowExpression.Validate(bodydATAsOACTIONoperator, nameof(bodydATAsOACTIONoperator), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONoperatorContact, nameof(bodydATAsOACTIONoperatorContact), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONaCTSTATUS, nameof(bodydATAsOACTIONaCTSTATUS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONcOMMENTS, nameof(bodydATAsOACTIONcOMMENTS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONfINALDATE, nameof(bodydATAsOACTIONfINALDATE), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONfROMDATE, nameof(bodydATAsOACTIONfROMDATE), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONorderedBy, nameof(bodydATAsOACTIONorderedBy), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONorderedByContact, nameof(bodydATAsOACTIONorderedByContact), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONpriority, nameof(bodydATAsOACTIONpriority), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONproject, nameof(bodydATAsOACTIONproject), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONrEMARKS, nameof(bodydATAsOACTIONrEMARKS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONtRDR, nameof(bodydATAsOACTIONtRDR), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONtRNDATE, nameof(bodydATAsOACTIONtRNDATE), required: false);
            WorkflowExpression.Validate(bodydATAxTRDOCDATA, nameof(bodydATAxTRDOCDATA), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperator);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(bodydATAsOACTIONsERIES);
                if (bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetSOTASK))]
        public IBodyWorkflowAction<SetData200response> SetSOTASK([WorkflowExpression] Func<string> bodydATAsOACTIONsERIES, [WorkflowExpression] Func<string> bodydATAsOACTIONoperator = null, [WorkflowExpression] Func<string> bodydATAsOACTIONoperatorContact = null, [WorkflowExpression] Func<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfINALDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfROMDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedBy = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedByContact = null, [WorkflowExpression] Func<string> bodydATAsOACTIONpriority = null, [WorkflowExpression] Func<string> bodydATAsOACTIONproject = null, [WorkflowExpression] Func<string> bodydATAsOACTIONrEMARKS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRDR = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRNDATE = null, [WorkflowExpression] Func<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetSOTASK(WorkflowExpression<string> bodydATAsOACTIONsERIES, WorkflowExpression<string> bodydATAsOACTIONoperator = null, WorkflowExpression<string> bodydATAsOACTIONoperatorContact = null, WorkflowExpression<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, WorkflowExpression<string> bodydATAsOACTIONcOMMENTS = null, WorkflowExpression<string> bodydATAsOACTIONfINALDATE = null, WorkflowExpression<string> bodydATAsOACTIONfROMDATE = null, WorkflowExpression<string> bodydATAsOACTIONorderedBy = null, WorkflowExpression<string> bodydATAsOACTIONorderedByContact = null, WorkflowExpression<string> bodydATAsOACTIONpriority = null, WorkflowExpression<string> bodydATAsOACTIONproject = null, WorkflowExpression<string> bodydATAsOACTIONrEMARKS = null, WorkflowExpression<string> bodydATAsOACTIONtRDR = null, WorkflowExpression<string> bodydATAsOACTIONtRNDATE = null, WorkflowExpression<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodydATAsOACTIONsERIES, nameof(bodydATAsOACTIONsERIES), required: true);
            WorkflowExpression.Validate(bodydATAsOACTIONoperator, nameof(bodydATAsOACTIONoperator), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONoperatorContact, nameof(bodydATAsOACTIONoperatorContact), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONaCTSTATUS, nameof(bodydATAsOACTIONaCTSTATUS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONcOMMENTS, nameof(bodydATAsOACTIONcOMMENTS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONfINALDATE, nameof(bodydATAsOACTIONfINALDATE), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONfROMDATE, nameof(bodydATAsOACTIONfROMDATE), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONorderedBy, nameof(bodydATAsOACTIONorderedBy), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONorderedByContact, nameof(bodydATAsOACTIONorderedByContact), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONpriority, nameof(bodydATAsOACTIONpriority), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONproject, nameof(bodydATAsOACTIONproject), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONrEMARKS, nameof(bodydATAsOACTIONrEMARKS), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONtRDR, nameof(bodydATAsOACTIONtRDR), required: false);
            WorkflowExpression.Validate(bodydATAsOACTIONtRNDATE, nameof(bodydATAsOACTIONtRNDATE), required: false);
            WorkflowExpression.Validate(bodydATAxTRDOCDATA, nameof(bodydATAxTRDOCDATA), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    sOACTIONObject["ACTOR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperator);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = ExpressionConverter.ConvertO(bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = ExpressionConverter.ConvertO(bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = ExpressionConverter.ConvertO(bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = ExpressionConverter.ConvertO(bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = ExpressionConverter.ConvertO(bodydATAsOACTIONsERIES);
                if (bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = ExpressionConverter.ConvertO(bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = ExpressionConverter.ConvertO(bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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
        [WorkflowExpressionFactory(nameof(__BuildSetSupplier))]
        public IBodyWorkflowAction<SetData200response> SetSupplier([WorkflowExpression] Func<string> bodyvaluesUPPLIERcODE, [WorkflowExpression] Func<string> bodyvaluesUPPLIERnAME, [WorkflowExpression] Func<bodyvaluesUPBANKACCInputItem[]> bodyvaluesUPBANKACC = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERaDDRESS = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERaFM = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERcITY = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERdISTRICT = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIEReMAIL = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERfAX = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERiRSDATA = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERjOBTYPETRD = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERpHONE01 = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERzIP = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetData200response> __BuildSetSupplier(WorkflowExpression<string> bodyvaluesUPPLIERcODE, WorkflowExpression<string> bodyvaluesUPPLIERnAME, WorkflowExpression<bodyvaluesUPBANKACCInputItem[]> bodyvaluesUPBANKACC = null, WorkflowExpression<string> bodyvaluesUPPLIERaDDRESS = null, WorkflowExpression<string> bodyvaluesUPPLIERaFM = null, WorkflowExpression<string> bodyvaluesUPPLIERcITY = null, WorkflowExpression<string> bodyvaluesUPPLIERdISTRICT = null, WorkflowExpression<string> bodyvaluesUPPLIEReMAIL = null, WorkflowExpression<string> bodyvaluesUPPLIERfAX = null, WorkflowExpression<string> bodyvaluesUPPLIERiRSDATA = null, WorkflowExpression<string> bodyvaluesUPPLIERjOBTYPETRD = null, WorkflowExpression<string> bodyvaluesUPPLIERpHONE01 = null, WorkflowExpression<string> bodyvaluesUPPLIERrEMARKS = null, WorkflowExpression<string> bodyvaluesUPPLIERzIP = null, WorkflowExpression<string> bodyfORM = null, WorkflowExpression<string> bodykEY = null)
        {
            WorkflowExpression.Validate(bodyvaluesUPPLIERcODE, nameof(bodyvaluesUPPLIERcODE), required: true);
            WorkflowExpression.Validate(bodyvaluesUPPLIERnAME, nameof(bodyvaluesUPPLIERnAME), required: true);
            WorkflowExpression.Validate(bodyvaluesUPBANKACC, nameof(bodyvaluesUPBANKACC), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERaDDRESS, nameof(bodyvaluesUPPLIERaDDRESS), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERaFM, nameof(bodyvaluesUPPLIERaFM), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERcITY, nameof(bodyvaluesUPPLIERcITY), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERdISTRICT, nameof(bodyvaluesUPPLIERdISTRICT), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIEReMAIL, nameof(bodyvaluesUPPLIEReMAIL), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERfAX, nameof(bodyvaluesUPPLIERfAX), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERiRSDATA, nameof(bodyvaluesUPPLIERiRSDATA), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERjOBTYPETRD, nameof(bodyvaluesUPPLIERjOBTYPETRD), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERpHONE01, nameof(bodyvaluesUPPLIERpHONE01), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERrEMARKS, nameof(bodyvaluesUPPLIERrEMARKS), required: false);
            WorkflowExpression.Validate(bodyvaluesUPPLIERzIP, nameof(bodyvaluesUPPLIERzIP), required: false);
            WorkflowExpression.Validate(bodyfORM, nameof(bodyfORM), required: false);
            WorkflowExpression.Validate(bodykEY, nameof(bodykEY), required: false);
            return new DeferredBodyAction<SetData200response>(() =>
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
                    dATAObject["SUPBANKACC"] = ExpressionConverter.ConvertO(bodyvaluesUPBANKACC);
                    dATAObjectpropCount++;
                }

                var sUPPLIERObject = new JObject();
                var sUPPLIERObjectpropCount = 0;
                if (bodyvaluesUPPLIERaDDRESS != null)
                {
                    sUPPLIERObject["ADDRESS"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERaDDRESS);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERaFM != null)
                {
                    sUPPLIERObject["AFM"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERaFM);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERcITY != null)
                {
                    sUPPLIERObject["CITY"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERcITY);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["CODE"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERcODE);
                if (bodyvaluesUPPLIERdISTRICT != null)
                {
                    sUPPLIERObject["DISTRICT"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERdISTRICT);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIEReMAIL != null)
                {
                    sUPPLIERObject["EMAIL"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIEReMAIL);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERfAX != null)
                {
                    sUPPLIERObject["FAX"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERfAX);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERiRSDATA != null)
                {
                    sUPPLIERObject["IRSDATA"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERiRSDATA);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERjOBTYPETRD != null)
                {
                    sUPPLIERObject["JOBTYPETRD"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERjOBTYPETRD);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["NAME"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERnAME);
                if (bodyvaluesUPPLIERpHONE01 != null)
                {
                    sUPPLIERObject["PHONE01"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERpHONE01);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERrEMARKS != null)
                {
                    sUPPLIERObject["REMARKS"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERrEMARKS);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERzIP != null)
                {
                    sUPPLIERObject["ZIP"] = ExpressionConverter.ConvertO(bodyvaluesUPPLIERzIP);
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
                    body["FORM"] = ExpressionConverter.ConvertO(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = ExpressionConverter.ConvertO(bodykEY);
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

        [WorkflowExpressionFactory(nameof(__BuildWebhook))]
        public IWorkflowTrigger Webhook([WorkflowExpression] Func<bodyObjectInput> bodyObject,[WorkflowExpression] Func<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhook(WorkflowExpression<bodyObjectInput> bodyObject,WorkflowExpression<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyObject, nameof(bodyObject), required: true);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(bodycondition);
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
                body["object"] = ExpressionConverter.ConvertO(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookOnDelete))]
        public IWorkflowTrigger WebhookOnDelete([WorkflowExpression] Func<bodyObjectInput> bodyObject,[WorkflowExpression] Func<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookOnDelete(WorkflowExpression<bodyObjectInput> bodyObject,WorkflowExpression<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyObject, nameof(bodyObject), required: true);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhook/onDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(bodycondition);
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
                body["object"] = ExpressionConverter.ConvertO(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookOnInsert))]
        public IWorkflowTrigger WebhookOnInsert([WorkflowExpression] Func<bodyObjectInput> bodyObject,[WorkflowExpression] Func<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookOnInsert(WorkflowExpression<bodyObjectInput> bodyObject,WorkflowExpression<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyObject, nameof(bodyObject), required: true);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhook/onInsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(bodycondition);
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
                body["object"] = ExpressionConverter.ConvertO(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookOnUpdate))]
        public IWorkflowTrigger WebhookOnUpdate([WorkflowExpression] Func<bodyObjectInput> bodyObject,[WorkflowExpression] Func<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookOnUpdate(WorkflowExpression<bodyObjectInput> bodyObject,WorkflowExpression<string> bodycondition = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyObject, nameof(bodyObject), required: true);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhook/onUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(bodycondition);
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
                body["object"] = ExpressionConverter.ConvertO(bodyObject);
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