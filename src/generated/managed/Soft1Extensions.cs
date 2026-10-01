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
        public IWorkflowAction Microservice([WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyendpoint)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("microservice");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["endpoint"] = SourceExpressionConverter.ConvertToken(bodyendpoint);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCFNCUSDOCResponse> GetCFNCUSDOC([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCFNCUSDOC";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetCFNCUSDOCResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCfnsupdocResponse> GetCfnsupdoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCfnsupdoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetCfnsupdocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetChequeResponse> GetCheque([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetChequeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetContactResponse> GetContact([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetCustomerResponse> GetCustomer([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetDraftEntryResponse> GetDraftEntry([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetDraftEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpenseResponse> GetExpense([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetExpenseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetExpensesDocResponse> GetExpensesDoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodylOCATEINFO = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                if (bodylOCATEINFO != null)
                {
                    if (bodylOCATEINFO != null)
                    {
                        body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetExpensesDocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItedocResponse> GetItedoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetItedocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetPurdocResponse> GetPurdoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetPurdocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSaldocResponse> GetSaldoc([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetSaldocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetServiceResponse> GetService([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetServiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOEMAILResponse> GetSOEMAIL([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getSoemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetSOEMAILResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetMeetingResponse> GetMeeting([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getSomeeting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetMeetingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSOTASKResponse> GetSOTASK([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getSotask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetSOTASKResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSupplierResponse> GetSupplier([WorkflowExpression] Func<string> bodykEY, [WorkflowExpression] Func<string> bodylOCATEINFO, [WorkflowExpression] Func<string> bodyfORM = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                bodypropCount++;
                body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
                bodypropCount++;
                body["LOCATEINFO"] = SourceExpressionConverter.ConvertToken(bodylOCATEINFO);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetSupplierResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<GetSystemParamsResponse> GetSystemParams()
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionAction<GetSystemParamsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCFNCUSDOC([WorkflowExpression] Func<string> bodyvaluecFNCUSDOCsERIES, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCtRDR, [WorkflowExpression] Func<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, [WorkflowExpression] Func<bodyvaluecASHLINESInputItem[]> bodyvaluecASHLINES = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCcOLLECTOR = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCcOMMENTS = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCproject = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCsALESMAN = null, [WorkflowExpression] Func<string> bodyvaluecFNCUSDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    dATAObject["CARDLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNCUSDOCObject = new JObject();
                var cFNCUSDOCObjectpropCount = 0;
                if (bodyvaluecFNCUSDOCcOLLECTOR != null)
                {
                    cFNCUSDOCObject["COLLECTOR"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCcOLLECTOR);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCcOMMENTS != null)
                {
                    cFNCUSDOCObject["COMMENTS"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCcOMMENTS);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCproject != null)
                {
                    cFNCUSDOCObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCproject);
                    cFNCUSDOCObjectpropCount++;
                }

                if (bodyvaluecFNCUSDOCsALESMAN != null)
                {
                    cFNCUSDOCObject["SALESMAN"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCsALESMAN);
                    cFNCUSDOCObjectpropCount++;
                }

                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCsERIES);
                cFNCUSDOCObjectpropCount++;
                cFNCUSDOCObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCtRDR);
                if (bodyvaluecFNCUSDOCtRNDATE != null)
                {
                    cFNCUSDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNCUSDOCtRNDATE);
                    cFNCUSDOCObjectpropCount++;
                }

                if (cFNCUSDOCObjectpropCount > 0)
                {
                    dATAObject["CFNCUSDOC"] = cFNCUSDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCfnsupdoc([WorkflowExpression] Func<string> bodyvaluecFNSUPDOCsERIES, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCtRDR, [WorkflowExpression] Func<bodyvaluecARDLINESInputItem[]> bodyvaluecARDLINES = null, [WorkflowExpression] Func<bodyvaluecASHLINESInputItem2[]> bodyvaluecASHLINES = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCpRJC = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluecFNSUPDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluecHEQUELINESInputItem[]> bodyvaluecHEQUELINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    dATAObject["CARDLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecARDLINES);
                    dATAObjectpropCount++;
                }

                if (bodyvaluecASHLINES != null)
                {
                    dATAObject["CASHLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecASHLINES);
                    dATAObjectpropCount++;
                }

                var cFNSUPDOCObject = new JObject();
                var cFNSUPDOCObjectpropCount = 0;
                if (bodyvaluecFNSUPDOCpRJC != null)
                {
                    cFNSUPDOCObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCpRJC);
                    cFNSUPDOCObjectpropCount++;
                }

                if (bodyvaluecFNSUPDOCrEMARKS != null)
                {
                    cFNSUPDOCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCrEMARKS);
                    cFNSUPDOCObjectpropCount++;
                }

                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCsERIES);
                cFNSUPDOCObjectpropCount++;
                cFNSUPDOCObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCtRDR);
                if (bodyvaluecFNSUPDOCtRNDATE != null)
                {
                    cFNSUPDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluecFNSUPDOCtRNDATE);
                    cFNSUPDOCObjectpropCount++;
                }

                if (cFNSUPDOCObjectpropCount > 0)
                {
                    dATAObject["CFNSUPDOC"] = cFNSUPDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluecHEQUELINES != null)
                {
                    dATAObject["CHEQUELINES"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUELINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCheque([WorkflowExpression] Func<string> bodyvaluecHEQUEbalance, [WorkflowExpression] Func<string> bodyvaluecHEQUEchequeNumber, [WorkflowExpression] Func<string> bodyvaluecHEQUEstatus, [WorkflowExpression] Func<string> bodyvaluecHEQUEvalue, [WorkflowExpression] Func<string> bodyvaluecHEQUEissueDate, [WorkflowExpression] Func<string> bodyvaluecHEQUEdueDate, [WorkflowExpression] Func<string> bodyvaluecHEQUEseries, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEbank = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerAddress = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerName = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerTelephone = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEreceiptDate = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEholderAddress = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEholderName = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEissuerTRNo = null, [WorkflowExpression] Func<string> bodyvaluecHEQUEcomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setCheque";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    cHEQUEObject["BANK"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEbank);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEBAL"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEbalance);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUENUMBER"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEchequeNumber);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUESTATES"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEstatus);
                cHEQUEObjectpropCount++;
                cHEQUEObject["CHEQUEVAL"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEvalue);
                if (bodyvaluecHEQUEissuerAddress != null)
                {
                    cHEQUEObject["CREATORADDR"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerAddress);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerName != null)
                {
                    cHEQUEObject["CREATORNAME"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerName);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerTelephone != null)
                {
                    cHEQUEObject["CREATORPHONE"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerTelephone);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEreceiptDate != null)
                {
                    cHEQUEObject["CRTDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEreceiptDate);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["DATEOFS"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEissueDate);
                cHEQUEObjectpropCount++;
                cHEQUEObject["FINALDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEdueDate);
                if (bodyvaluecHEQUEholderAddress != null)
                {
                    cHEQUEObject["HOLDERADDR"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEholderAddress);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEholderName != null)
                {
                    cHEQUEObject["HOLDERNAME"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEholderName);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEissuerTRNo != null)
                {
                    cHEQUEObject["PUBLISHERAFM"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEissuerTRNo);
                    cHEQUEObjectpropCount++;
                }

                if (bodyvaluecHEQUEcomments != null)
                {
                    cHEQUEObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEcomments);
                    cHEQUEObjectpropCount++;
                }

                cHEQUEObjectpropCount++;
                cHEQUEObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluecHEQUEseries);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetContact([WorkflowExpression] Func<string> bodyvaluepRSNOUTcode, [WorkflowExpression] Func<string> bodyvaluepRSNOUTname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTaddress = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtRNo = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTgeographicalAreas = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTbIRTHDATE = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcity = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcountry = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTarea = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTprefecture = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTeducationLevel = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTemail = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTemail2 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTfax = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTidCardNo = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtaxOffice = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTmobileTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTsurname = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTfatherSName = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTmotherSName = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTnameOfSpouse = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTnationality = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtel1 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTtel2 = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTinternalTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTpersonalTelephone = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTcomments = null, [WorkflowExpression] Func<bodyvaluepRSNOUTgenderInput> bodyvaluepRSNOUTgender = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTwebPage = null, [WorkflowExpression] Func<string> bodyvaluepRSNOUTzip = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    pRSNOUTObject["ADDRESS"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTaddress);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtRNo != null)
                {
                    pRSNOUTObject["AFM"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTtRNo);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTgeographicalAreas != null)
                {
                    pRSNOUTObject["AREAS"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTgeographicalAreas);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTbIRTHDATE != null)
                {
                    pRSNOUTObject["BIRTHDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTbIRTHDATE);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTcity != null)
                {
                    pRSNOUTObject["CITY"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTcity);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTcode);
                if (bodyvaluepRSNOUTcountry != null)
                {
                    pRSNOUTObject["COUNTRY"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTcountry);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTarea != null)
                {
                    pRSNOUTObject["DISTRICT"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTarea);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTprefecture != null)
                {
                    pRSNOUTObject["DISTRICT1"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTprefecture);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTeducationLevel != null)
                {
                    pRSNOUTObject["EDUCAT"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTeducationLevel);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTemail != null)
                {
                    pRSNOUTObject["EMAIL"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTemail);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTemail2 != null)
                {
                    pRSNOUTObject["EMAIL1"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTemail2);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTfax != null)
                {
                    pRSNOUTObject["FAX"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTfax);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTidCardNo != null)
                {
                    pRSNOUTObject["IDENTITYNUM"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTidCardNo);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtaxOffice != null)
                {
                    pRSNOUTObject["IRSDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTtaxOffice);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTmobileTelephone != null)
                {
                    pRSNOUTObject["MOBILEPHONE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTmobileTelephone);
                    pRSNOUTObjectpropCount++;
                }

                pRSNOUTObjectpropCount++;
                pRSNOUTObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTname);
                if (bodyvaluepRSNOUTsurname != null)
                {
                    pRSNOUTObject["NAME2"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTsurname);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTfatherSName != null)
                {
                    pRSNOUTObject["NAME3"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTfatherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTmotherSName != null)
                {
                    pRSNOUTObject["NAME4"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTmotherSName);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTnameOfSpouse != null)
                {
                    pRSNOUTObject["NAME5"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTnameOfSpouse);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTnationality != null)
                {
                    pRSNOUTObject["NATIONALITY"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTnationality);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtel1 != null)
                {
                    pRSNOUTObject["PHONE1"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTtel1);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTtel2 != null)
                {
                    pRSNOUTObject["PHONE2"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTtel2);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTinternalTelephone != null)
                {
                    pRSNOUTObject["PHONEEXT"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTinternalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTpersonalTelephone != null)
                {
                    pRSNOUTObject["PHONELOCAL"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTpersonalTelephone);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTcomments != null)
                {
                    pRSNOUTObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTcomments);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTgender != null)
                {
                    pRSNOUTObject["SOSEX"] = SourceExpressionConverter.Convert(bodyvaluepRSNOUTgender);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTwebPage != null)
                {
                    pRSNOUTObject["WEBPAGE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTwebPage);
                    pRSNOUTObjectpropCount++;
                }

                if (bodyvaluepRSNOUTzip != null)
                {
                    pRSNOUTObject["ZIP"] = SourceExpressionConverter.ConvertToken(bodyvaluepRSNOUTzip);
                    pRSNOUTObjectpropCount++;
                }

                if (pRSNOUTObjectpropCount > 0)
                {
                    dataObject["PRSNOUT"] = pRSNOUTObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetCustomer([WorkflowExpression] Func<string> bodyvaluecUSTOMERcode, [WorkflowExpression] Func<string> bodyvaluecUSTOMERname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprimaryAddress = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERtRNo = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERgeographicalAreas = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERcity = null, [WorkflowExpression] Func<int> bodyvaluecUSTOMERdiscount = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERlocationArea = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMEReMail = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERfax = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERtaxOffice = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprofession = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERprimaryTelephone = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERcomments = null, [WorkflowExpression] Func<bodyvaluecUSTOMERtaxCategoryInput> bodyvaluecUSTOMERtaxCategory = null, [WorkflowExpression] Func<string> bodyvaluecUSTOMERzip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setCustomer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    cUSTOMERObject["ADDRESS"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERprimaryAddress);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtRNo != null)
                {
                    cUSTOMERObject["AFM"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERtRNo);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERgeographicalAreas != null)
                {
                    cUSTOMERObject["AREAS"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERgeographicalAreas);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERcity != null)
                {
                    cUSTOMERObject["CITY"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERcity);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERcode);
                if (bodyvaluecUSTOMERdiscount != null)
                {
                    cUSTOMERObject["DISCOUNT"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERdiscount);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERlocationArea != null)
                {
                    cUSTOMERObject["DISTRICT"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERlocationArea);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMEReMail != null)
                {
                    cUSTOMERObject["EMAIL"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMEReMail);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERfax != null)
                {
                    cUSTOMERObject["FAX"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERfax);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtaxOffice != null)
                {
                    cUSTOMERObject["IRSDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERtaxOffice);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERprofession != null)
                {
                    cUSTOMERObject["JOBTYPETRD"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERprofession);
                    cUSTOMERObjectpropCount++;
                }

                cUSTOMERObjectpropCount++;
                cUSTOMERObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERname);
                if (bodyvaluecUSTOMERprimaryTelephone != null)
                {
                    cUSTOMERObject["PHONE01"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERprimaryTelephone);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERcomments != null)
                {
                    cUSTOMERObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERcomments);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERtaxCategory != null)
                {
                    cUSTOMERObject["VATSTS"] = SourceExpressionConverter.Convert(bodyvaluecUSTOMERtaxCategory);
                    cUSTOMERObjectpropCount++;
                }

                if (bodyvaluecUSTOMERzip != null)
                {
                    cUSTOMERObject["ZIP"] = SourceExpressionConverter.ConvertToken(bodyvaluecUSTOMERzip);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetDraftEntry([WorkflowExpression] Func<string> bodyvaluesODRAFTcode, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTaddress = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTtRNo = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcity = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcountry = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTarea = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTprefecture = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcategory = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcompanyEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTbusinessEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTpersonalEmail = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTidCardNo = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTactivity = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTmobileTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTnameTitle = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTfirstName = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTsurname = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTzip = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTbusinessTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTinternalTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTpersonalTelephone = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTcomments = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTtitle = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTwebPage = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTzip2 = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKbranch = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKbusinessUnit = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKdepartment = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKproject = null, [WorkflowExpression] Func<string> bodyvaluesODRAFTLNKsource = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setDraftEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    sODRAFTObject["ADDRESS"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTaddress);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTtRNo != null)
                {
                    sODRAFTObject["AFM"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTtRNo);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcity != null)
                {
                    sODRAFTObject["CITY"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcity);
                    sODRAFTObjectpropCount++;
                }

                sODRAFTObjectpropCount++;
                sODRAFTObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcode);
                if (bodyvaluesODRAFTcountry != null)
                {
                    sODRAFTObject["COUNTRY"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcountry);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTarea != null)
                {
                    sODRAFTObject["DISTRICT"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTarea);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTprefecture != null)
                {
                    sODRAFTObject["DISTRICT1"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTprefecture);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcategory != null)
                {
                    sODRAFTObject["DRAFTTYPE"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcategory);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcompanyEmail != null)
                {
                    sODRAFTObject["EMAIL"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcompanyEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTbusinessEmail != null)
                {
                    sODRAFTObject["EMAIL1"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTbusinessEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTpersonalEmail != null)
                {
                    sODRAFTObject["EMAIL2"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTpersonalEmail);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTidCardNo != null)
                {
                    sODRAFTObject["IDENTITYNUM"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTidCardNo);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTactivity != null)
                {
                    sODRAFTObject["JOBTYPETRD"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTactivity);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTmobileTelephone != null)
                {
                    sODRAFTObject["MOBILEPHONE"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTmobileTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTnameTitle != null)
                {
                    sODRAFTObject["NAMEC"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTnameTitle);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTfirstName != null)
                {
                    sODRAFTObject["NAMEF"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTfirstName);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTsurname != null)
                {
                    sODRAFTObject["NAMEL"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTsurname);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTzip != null)
                {
                    sODRAFTObject["NUMCG"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTzip);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTbusinessTelephone != null)
                {
                    sODRAFTObject["PHONE1"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTbusinessTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTinternalTelephone != null)
                {
                    sODRAFTObject["PHONEEXT"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTinternalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTpersonalTelephone != null)
                {
                    sODRAFTObject["PHONELOCAL"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTpersonalTelephone);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTcomments != null)
                {
                    sODRAFTObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTcomments);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTtitle != null)
                {
                    sODRAFTObject["SOTITLENAME"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTtitle);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTwebPage != null)
                {
                    sODRAFTObject["WEBPAGE"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTwebPage);
                    sODRAFTObjectpropCount++;
                }

                if (bodyvaluesODRAFTzip2 != null)
                {
                    sODRAFTObject["ZIP"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTzip2);
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
                    sODRAFTLNKObject["BRANCH"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKbranch);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKbusinessUnit != null)
                {
                    sODRAFTLNKObject["BUSUNITS"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKbusinessUnit);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKdepartment != null)
                {
                    sODRAFTLNKObject["DEPART"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKdepartment);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKproject != null)
                {
                    sODRAFTLNKObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKproject);
                    sODRAFTLNKObjectpropCount++;
                }

                if (bodyvaluesODRAFTLNKsource != null)
                {
                    sODRAFTLNKObject["PRJCLEAD"] = SourceExpressionConverter.ConvertToken(bodyvaluesODRAFTLNKsource);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetExpense([WorkflowExpression] Func<string> bodyvaluelINEITEMcode, [WorkflowExpression] Func<bodyvaluelINEITEMinvoicingCategoryInput> bodyvaluelINEITEMinvoicingCategory, [WorkflowExpression] Func<string> bodyvaluelINEITEMname, [WorkflowExpression] Func<string> bodyvaluelINEITEMvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluelINEITEMcommercialCategory = null, [WorkflowExpression] Func<bodyvaluelINEITEMtypeInput> bodyvaluelINEITEMtype = null, [WorkflowExpression] Func<string> bodyvaluelINEITEMcomments = null, [WorkflowExpression] Func<bodyvaluelINEITEMfeeValueInput> bodyvaluelINEITEMfeeValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setExpense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                lINEITEMObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluelINEITEMcode);
                lINEITEMObjectpropCount++;
                lINEITEMObject["LISOURCETYPE"] = SourceExpressionConverter.Convert(bodyvaluelINEITEMinvoicingCategory);
                if (bodyvaluelINEITEMcommercialCategory != null)
                {
                    lINEITEMObject["MTRCATEGORY"] = SourceExpressionConverter.ConvertToken(bodyvaluelINEITEMcommercialCategory);
                    lINEITEMObjectpropCount++;
                }

                if (bodyvaluelINEITEMtype != null)
                {
                    lINEITEMObject["MTRTYPE"] = SourceExpressionConverter.Convert(bodyvaluelINEITEMtype);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluelINEITEMname);
                if (bodyvaluelINEITEMcomments != null)
                {
                    lINEITEMObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluelINEITEMcomments);
                    lINEITEMObjectpropCount++;
                }

                if (bodyvaluelINEITEMfeeValue != null)
                {
                    lINEITEMObject["SOPAYVALUE"] = SourceExpressionConverter.Convert(bodyvaluelINEITEMfeeValue);
                    lINEITEMObjectpropCount++;
                }

                lINEITEMObjectpropCount++;
                lINEITEMObject["VAT"] = SourceExpressionConverter.ConvertToken(bodyvaluelINEITEMvatGroup);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetExpensesDoc([WorkflowExpression] Func<string> bodyvaluelINSUPDOCseries, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCsupplier, [WorkflowExpression] Func<bodyvalueunnamedInputItem[]> bodyvalueunnamed = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCproject = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCcomments = null, [WorkflowExpression] Func<string> bodyvaluelINSUPDOCtRNDATE = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    dATAObject["LINLINES"] = SourceExpressionConverter.ConvertToken(bodyvalueunnamed);
                    dATAObjectpropCount++;
                }

                var lINSUPDOCObject = new JObject();
                var lINSUPDOCObjectpropCount = 0;
                if (bodyvaluelINSUPDOCproject != null)
                {
                    lINSUPDOCObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluelINSUPDOCproject);
                    lINSUPDOCObjectpropCount++;
                }

                if (bodyvaluelINSUPDOCcomments != null)
                {
                    lINSUPDOCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluelINSUPDOCcomments);
                    lINSUPDOCObjectpropCount++;
                }

                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluelINSUPDOCseries);
                lINSUPDOCObjectpropCount++;
                lINSUPDOCObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodyvaluelINSUPDOCsupplier);
                if (bodyvaluelINSUPDOCtRNDATE != null)
                {
                    lINSUPDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluelINSUPDOCtRNDATE);
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetItedoc([WorkflowExpression] Func<string> bodyvalueiTEDOCseries, [WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCreason = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvalueiTEDOCtRNDATE = null, [WorkflowExpression] Func<bodyvalueiTELINESInputItem[]> bodyvalueiTELINES = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setItedoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    iTEDOCObject["COMMENTS"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEDOCreason);
                    iTEDOCObjectpropCount++;
                }

                if (bodyvalueiTEDOCrEMARKS != null)
                {
                    iTEDOCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEDOCrEMARKS);
                    iTEDOCObjectpropCount++;
                }

                iTEDOCObjectpropCount++;
                iTEDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEDOCseries);
                if (bodyvalueiTEDOCtRNDATE != null)
                {
                    iTEDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEDOCtRNDATE);
                    iTEDOCObjectpropCount++;
                }

                if (iTEDOCObjectpropCount > 0)
                {
                    dataObject["ITEDOC"] = iTEDOCObject;
                    dataObjectpropCount++;
                }

                if (bodyvalueiTELINES != null)
                {
                    dataObject["ITELINES"] = SourceExpressionConverter.ConvertToken(bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = SourceExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetItem([WorkflowExpression] Func<string> bodyvalueiTEMcode, [WorkflowExpression] Func<string> bodyvalueiTEMbaseUnitOfMeasure, [WorkflowExpression] Func<string> bodyvalueiTEMname, [WorkflowExpression] Func<string> bodyvalueiTEMvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvalueiTEMcommercialCategory = null, [WorkflowExpression] Func<string> bodyvalueiTEMitemGroup = null, [WorkflowExpression] Func<string> bodyvalueiTEMretailPrice = null, [WorkflowExpression] Func<string> bodyvalueiTEMwholesalePrice = null, [WorkflowExpression] Func<string> bodyvalueiTEMcomments = null, [WorkflowExpression] Func<string> bodyvalueiTEMdiscount1 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                iTEMObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMcode);
                if (bodyvalueiTEMcommercialCategory != null)
                {
                    iTEMObject["MTRCATEGORY"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMcommercialCategory);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMitemGroup != null)
                {
                    iTEMObject["MTRGROUP"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMitemGroup);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["MTRUNIT1"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMbaseUnitOfMeasure);
                iTEMObjectpropCount++;
                iTEMObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMname);
                if (bodyvalueiTEMretailPrice != null)
                {
                    iTEMObject["PRICER"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMretailPrice);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMwholesalePrice != null)
                {
                    iTEMObject["PRICEW"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMwholesalePrice);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMcomments != null)
                {
                    iTEMObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMcomments);
                    iTEMObjectpropCount++;
                }

                if (bodyvalueiTEMdiscount1 != null)
                {
                    iTEMObject["SODISCOUNT"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMdiscount1);
                    iTEMObjectpropCount++;
                }

                iTEMObjectpropCount++;
                iTEMObject["VAT"] = SourceExpressionConverter.ConvertToken(bodyvalueiTEMvatGroup);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetProject([WorkflowExpression] Func<string> bodyvaluepRJCcode, [WorkflowExpression] Func<string> bodyvaluepRJCname, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<bodyvaluepRJCaCTSTATUSInput> bodyvaluepRJCaCTSTATUS = null, [WorkflowExpression] Func<string> bodyvaluepRJCfINALDATE = null, [WorkflowExpression] Func<string> bodyvaluepRJCfROMDATE = null, [WorkflowExpression] Func<bodyvaluepRJCpRJCRMInput> bodyvaluepRJCpRJCRM = null, [WorkflowExpression] Func<string> bodyvaluepRJCcomments = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    pRJCObject["ACTSTATUS"] = SourceExpressionConverter.Convert(bodyvaluepRJCaCTSTATUS);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRJCcode);
                if (bodyvaluepRJCfINALDATE != null)
                {
                    pRJCObject["FINALDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRJCfINALDATE);
                    pRJCObjectpropCount++;
                }

                if (bodyvaluepRJCfROMDATE != null)
                {
                    pRJCObject["FROMDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluepRJCfROMDATE);
                    pRJCObjectpropCount++;
                }

                pRJCObjectpropCount++;
                pRJCObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluepRJCname);
                if (bodyvaluepRJCpRJCRM != null)
                {
                    pRJCObject["PRJCRM"] = SourceExpressionConverter.Convert(bodyvaluepRJCpRJCRM);
                    pRJCObjectpropCount++;
                }

                if (bodyvaluepRJCcomments != null)
                {
                    pRJCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluepRJCcomments);
                    pRJCObjectpropCount++;
                }

                if (pRJCObjectpropCount > 0)
                {
                    dataObject["PRJC"] = pRJCObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dataObject["XTRDOCDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetPurdoc([WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyvaluepURDOCsERIES, [WorkflowExpression] Func<string> bodyvaluepURDOCsOCURRENCY, [WorkflowExpression] Func<string> bodyvaluepURDOCtRDR, [WorkflowExpression] Func<bodyvalueiTELINESInputItem2[]> bodyvalueiTELINES = null, [WorkflowExpression] Func<string> bodyvaluepURDOCdISC1PRC = null, [WorkflowExpression] Func<string> bodyvaluepURDOCpAYMENT = null, [WorkflowExpression] Func<string> bodyvaluepURDOCpRJC = null, [WorkflowExpression] Func<string> bodyvaluepURDOCrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluepURDOCsUMAMNT = null, [WorkflowExpression] Func<string> bodyvaluepURDOCtRNDATE = null, [WorkflowExpression] Func<bodyvaluesRVLINESInputItem[]> bodyvaluesRVLINES = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    dATAObject["ITELINES"] = SourceExpressionConverter.ConvertToken(bodyvalueiTELINES);
                    dATAObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = SourceExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dATAObject["MTRDOC"] = mTRDOCObject;
                    dATAObjectpropCount++;
                }

                var pURDOCObject = new JObject();
                var pURDOCObjectpropCount = 0;
                if (bodyvaluepURDOCdISC1PRC != null)
                {
                    pURDOCObject["DISC1PRC"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCdISC1PRC);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCpAYMENT != null)
                {
                    pURDOCObject["PAYMENT"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCpAYMENT);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCpRJC != null)
                {
                    pURDOCObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCpRJC);
                    pURDOCObjectpropCount++;
                }

                if (bodyvaluepURDOCrEMARKS != null)
                {
                    pURDOCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCrEMARKS);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCsERIES);
                pURDOCObjectpropCount++;
                pURDOCObject["SOCURRENCY"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCsOCURRENCY);
                if (bodyvaluepURDOCsUMAMNT != null)
                {
                    pURDOCObject["SUMAMNT"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCsUMAMNT);
                    pURDOCObjectpropCount++;
                }

                pURDOCObjectpropCount++;
                pURDOCObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCtRDR);
                if (bodyvaluepURDOCtRNDATE != null)
                {
                    pURDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluepURDOCtRNDATE);
                    pURDOCObjectpropCount++;
                }

                if (pURDOCObjectpropCount > 0)
                {
                    dATAObject["PURDOC"] = pURDOCObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluesRVLINES != null)
                {
                    dATAObject["SRVLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluesRVLINES);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSaldoc([WorkflowExpression] Func<string> bodyvaluemTRDOCwarehouse, [WorkflowExpression] Func<string> bodyvaluesALDOCpayment, [WorkflowExpression] Func<string> bodyvaluesALDOCseries, [WorkflowExpression] Func<string> bodyvaluesALDOCcurrency, [WorkflowExpression] Func<string> bodyvaluesALDOCcustomer, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<bodyvalueiTELINESInputItem22[]> bodyvalueiTELINES = null, [WorkflowExpression] Func<string> bodyvaluesALDOCdiscount = null, [WorkflowExpression] Func<string> bodyvaluesALDOCdiscountValue = null, [WorkflowExpression] Func<string> bodyvaluesALDOCnetAmount = null, [WorkflowExpression] Func<string> bodyvaluesALDOCproject = null, [WorkflowExpression] Func<string> bodyvaluesALDOCcomments = null, [WorkflowExpression] Func<string> bodyvaluesALDOCtotal = null, [WorkflowExpression] Func<string> bodyvaluesALDOCtRNDATE = null, [WorkflowExpression] Func<string> bodyvaluesALDOCvAT = null, [WorkflowExpression] Func<bodyvaluesRVLINESInputItem2[]> bodyvaluesRVLINES = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setSaldoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                    dataObject["ITELINES"] = SourceExpressionConverter.ConvertToken(bodyvalueiTELINES);
                    dataObjectpropCount++;
                }

                var mTRDOCObject = new JObject();
                var mTRDOCObjectpropCount = 0;
                mTRDOCObjectpropCount++;
                mTRDOCObject["WHOUSE"] = SourceExpressionConverter.ConvertToken(bodyvaluemTRDOCwarehouse);
                if (mTRDOCObjectpropCount > 0)
                {
                    dataObject["MTRDOC"] = mTRDOCObject;
                    dataObjectpropCount++;
                }

                var sALDOCObject = new JObject();
                var sALDOCObjectpropCount = 0;
                if (bodyvaluesALDOCdiscount != null)
                {
                    sALDOCObject["DISC1PRC"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCdiscount);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCdiscountValue != null)
                {
                    sALDOCObject["DISC1VAL"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCdiscountValue);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCnetAmount != null)
                {
                    sALDOCObject["NETAMNT"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCnetAmount);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["PAYMENT"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCpayment);
                if (bodyvaluesALDOCproject != null)
                {
                    sALDOCObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCproject);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCcomments != null)
                {
                    sALDOCObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCcomments);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCseries);
                sALDOCObjectpropCount++;
                sALDOCObject["SOCURRENCY"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCcurrency);
                if (bodyvaluesALDOCtotal != null)
                {
                    sALDOCObject["SUMAMNT"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCtotal);
                    sALDOCObjectpropCount++;
                }

                sALDOCObjectpropCount++;
                sALDOCObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCcustomer);
                if (bodyvaluesALDOCtRNDATE != null)
                {
                    sALDOCObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCtRNDATE);
                    sALDOCObjectpropCount++;
                }

                if (bodyvaluesALDOCvAT != null)
                {
                    sALDOCObject["VATAMNT"] = SourceExpressionConverter.ConvertToken(bodyvaluesALDOCvAT);
                    sALDOCObjectpropCount++;
                }

                if (sALDOCObjectpropCount > 0)
                {
                    dataObject["SALDOC"] = sALDOCObject;
                    dataObjectpropCount++;
                }

                if (bodyvaluesRVLINES != null)
                {
                    dataObject["SRVLINES"] = SourceExpressionConverter.ConvertToken(bodyvaluesRVLINES);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetService([WorkflowExpression] Func<string> bodyvaluesERVICEcode, [WorkflowExpression] Func<string> bodyvaluesERVICEbaseUnitOfMeasure, [WorkflowExpression] Func<string> bodyvaluesERVICEname, [WorkflowExpression] Func<string> bodyvaluesERVICEvatGroup, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null, [WorkflowExpression] Func<string> bodyvaluesERVICEcommercialCategory = null, [WorkflowExpression] Func<string> bodyvaluesERVICEserviceGroup = null, [WorkflowExpression] Func<string> bodyvaluesERVICEretailPrice = null, [WorkflowExpression] Func<string> bodyvaluesERVICEwholesalePrice = null, [WorkflowExpression] Func<string> bodyvaluesERVICEcomments = null, [WorkflowExpression] Func<string> bodyvaluesERVICEdiscount1 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("s1service");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                sERVICEObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEcode);
                if (bodyvaluesERVICEcommercialCategory != null)
                {
                    sERVICEObject["MTRCATEGORY"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEcommercialCategory);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEserviceGroup != null)
                {
                    sERVICEObject["MTRGROUP"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEserviceGroup);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["MTRUNIT1"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEbaseUnitOfMeasure);
                sERVICEObjectpropCount++;
                sERVICEObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEname);
                if (bodyvaluesERVICEretailPrice != null)
                {
                    sERVICEObject["PRICER"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEretailPrice);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEwholesalePrice != null)
                {
                    sERVICEObject["PRICEW"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEwholesalePrice);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEcomments != null)
                {
                    sERVICEObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEcomments);
                    sERVICEObjectpropCount++;
                }

                if (bodyvaluesERVICEdiscount1 != null)
                {
                    sERVICEObject["SODISCOUNT"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEdiscount1);
                    sERVICEObjectpropCount++;
                }

                sERVICEObjectpropCount++;
                sERVICEObject["VAT"] = SourceExpressionConverter.ConvertToken(bodyvaluesERVICEvatGroup);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSOEMAIL([WorkflowExpression] Func<string> bodyvaluesOACTIONsERIES, [WorkflowExpression] Func<bodyvaluesOACTIONaCTSTATUSInput> bodyvaluesOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodyvaluesOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodyvaluesOACTIONtRNDATE = null, [WorkflowExpression] Func<string> bodyvaluesOMAILfROMADDRESS = null, [WorkflowExpression] Func<string> bodyvaluesOMAILfROMNAME = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOBCC = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOBODY = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOCC = null, [WorkflowExpression] Func<string> bodyvaluesOMAILsOTO = null, [WorkflowExpression] Func<bodyvaluexTRDOCDATAInputItem[]> bodyvaluexTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    sOACTIONObject["ACTSTATUS"] = SourceExpressionConverter.Convert(bodyvaluesOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodyvaluesOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = SourceExpressionConverter.ConvertToken(bodyvaluesOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodyvaluesOACTIONsERIES);
                if (bodyvaluesOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodyvaluesOACTIONtRNDATE);
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
                    sOMAILObject["FROMADDRESS"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILfROMADDRESS);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILfROMNAME != null)
                {
                    sOMAILObject["FROMNAME"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILfROMNAME);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOBCC != null)
                {
                    sOMAILObject["SOBCC"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILsOBCC);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOBODY != null)
                {
                    sOMAILObject["SOBODY"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILsOBODY);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOCC != null)
                {
                    sOMAILObject["SOCC"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILsOCC);
                    sOMAILObjectpropCount++;
                }

                if (bodyvaluesOMAILsOTO != null)
                {
                    sOMAILObject["SOTO"] = SourceExpressionConverter.ConvertToken(bodyvaluesOMAILsOTO);
                    sOMAILObjectpropCount++;
                }

                if (sOMAILObjectpropCount > 0)
                {
                    dATAObject["SOMAIL"] = sOMAILObject;
                    dATAObjectpropCount++;
                }

                if (bodyvaluexTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluexTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetMeeting([WorkflowExpression] Func<string> bodydATAsOACTIONsERIES, [WorkflowExpression] Func<string> bodydATAsOACTIONOperator = null, [WorkflowExpression] Func<string> bodydATAsOACTIONoperatorContact = null, [WorkflowExpression] Func<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfINALDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfROMDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedBy = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedByContact = null, [WorkflowExpression] Func<string> bodydATAsOACTIONpriority = null, [WorkflowExpression] Func<string> bodydATAsOACTIONproject = null, [WorkflowExpression] Func<string> bodydATAsOACTIONrEMARKS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRDR = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRNDATE = null, [WorkflowExpression] Func<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodydATAsOACTIONOperator != null)
                {
                    sOACTIONObject["ACTOR"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONOperator);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = SourceExpressionConverter.Convert(bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONsERIES);
                if (bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = SourceExpressionConverter.ConvertToken(bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSOTASK([WorkflowExpression] Func<string> bodydATAsOACTIONsERIES, [WorkflowExpression] Func<string> bodydATAsOACTIONOperator = null, [WorkflowExpression] Func<string> bodydATAsOACTIONoperatorContact = null, [WorkflowExpression] Func<bodydATAsOACTIONaCTSTATUSInput> bodydATAsOACTIONaCTSTATUS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONcOMMENTS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfINALDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONfROMDATE = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedBy = null, [WorkflowExpression] Func<string> bodydATAsOACTIONorderedByContact = null, [WorkflowExpression] Func<string> bodydATAsOACTIONpriority = null, [WorkflowExpression] Func<string> bodydATAsOACTIONproject = null, [WorkflowExpression] Func<string> bodydATAsOACTIONrEMARKS = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRDR = null, [WorkflowExpression] Func<string> bodydATAsOACTIONtRNDATE = null, [WorkflowExpression] Func<bodydATAxTRDOCDATAInputItem[]> bodydATAxTRDOCDATA = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodydATAsOACTIONOperator != null)
                {
                    sOACTIONObject["ACTOR"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONOperator);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONoperatorContact != null)
                {
                    sOACTIONObject["ACTPRSN"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONoperatorContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONaCTSTATUS != null)
                {
                    sOACTIONObject["ACTSTATUS"] = SourceExpressionConverter.Convert(bodydATAsOACTIONaCTSTATUS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONcOMMENTS != null)
                {
                    sOACTIONObject["COMMENTS"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONcOMMENTS);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfINALDATE != null)
                {
                    sOACTIONObject["FINALDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONfINALDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONfROMDATE != null)
                {
                    sOACTIONObject["FROMDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONfROMDATE);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedBy != null)
                {
                    sOACTIONObject["ORDEREDBY"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONorderedBy);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONorderedByContact != null)
                {
                    sOACTIONObject["ORDPRSN"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONorderedByContact);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONpriority != null)
                {
                    sOACTIONObject["PRIORITY"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONpriority);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONproject != null)
                {
                    sOACTIONObject["PRJC"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONproject);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONrEMARKS != null)
                {
                    sOACTIONObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONrEMARKS);
                    sOACTIONObjectpropCount++;
                }

                sOACTIONObjectpropCount++;
                sOACTIONObject["SERIES"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONsERIES);
                if (bodydATAsOACTIONtRDR != null)
                {
                    sOACTIONObject["TRDR"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONtRDR);
                    sOACTIONObjectpropCount++;
                }

                if (bodydATAsOACTIONtRNDATE != null)
                {
                    sOACTIONObject["TRNDATE"] = SourceExpressionConverter.ConvertToken(bodydATAsOACTIONtRNDATE);
                    sOACTIONObjectpropCount++;
                }

                if (sOACTIONObjectpropCount > 0)
                {
                    dATAObject["SOACTION"] = sOACTIONObject;
                    dATAObjectpropCount++;
                }

                if (bodydATAxTRDOCDATA != null)
                {
                    dATAObject["XTRDOCDATA"] = SourceExpressionConverter.ConvertToken(bodydATAxTRDOCDATA);
                    dATAObjectpropCount++;
                }

                if (dATAObjectpropCount > 0)
                {
                    body["DATA"] = dATAObject;
                    bodypropCount++;
                }

                if (bodyfORM != null)
                {
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "soft1")]
        public IBodyWorkflowAction<SetData200response> SetSupplier([WorkflowExpression] Func<string> bodyvaluesUPPLIERcODE, [WorkflowExpression] Func<string> bodyvaluesUPPLIERnAME, [WorkflowExpression] Func<bodyvaluesUPBANKACCInputItem[]> bodyvaluesUPBANKACC = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERaDDRESS = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERaFM = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERcITY = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERdISTRICT = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIEReMAIL = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERfAX = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERiRSDATA = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERjOBTYPETRD = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERpHONE01 = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERrEMARKS = null, [WorkflowExpression] Func<string> bodyvaluesUPPLIERzIP = null, [WorkflowExpression] Func<string> bodyfORM = null, [WorkflowExpression] Func<string> bodykEY = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    dATAObject["SUPBANKACC"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPBANKACC);
                    dATAObjectpropCount++;
                }

                var sUPPLIERObject = new JObject();
                var sUPPLIERObjectpropCount = 0;
                if (bodyvaluesUPPLIERaDDRESS != null)
                {
                    sUPPLIERObject["ADDRESS"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERaDDRESS);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERaFM != null)
                {
                    sUPPLIERObject["AFM"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERaFM);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERcITY != null)
                {
                    sUPPLIERObject["CITY"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERcITY);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["CODE"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERcODE);
                if (bodyvaluesUPPLIERdISTRICT != null)
                {
                    sUPPLIERObject["DISTRICT"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERdISTRICT);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIEReMAIL != null)
                {
                    sUPPLIERObject["EMAIL"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIEReMAIL);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERfAX != null)
                {
                    sUPPLIERObject["FAX"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERfAX);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERiRSDATA != null)
                {
                    sUPPLIERObject["IRSDATA"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERiRSDATA);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERjOBTYPETRD != null)
                {
                    sUPPLIERObject["JOBTYPETRD"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERjOBTYPETRD);
                    sUPPLIERObjectpropCount++;
                }

                sUPPLIERObjectpropCount++;
                sUPPLIERObject["NAME"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERnAME);
                if (bodyvaluesUPPLIERpHONE01 != null)
                {
                    sUPPLIERObject["PHONE01"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERpHONE01);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERrEMARKS != null)
                {
                    sUPPLIERObject["REMARKS"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERrEMARKS);
                    sUPPLIERObjectpropCount++;
                }

                if (bodyvaluesUPPLIERzIP != null)
                {
                    sUPPLIERObject["ZIP"] = SourceExpressionConverter.ConvertToken(bodyvaluesUPPLIERzIP);
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
                    body["FORM"] = SourceExpressionConverter.ConvertToken(bodyfORM);
                    bodypropCount++;
                }

                if (bodykEY != null)
                {
                    body["KEY"] = SourceExpressionConverter.ConvertToken(bodykEY);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetData200response>(BuildSourceInput);
        }
    }

    public class Soft1Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Webhook([WorkflowExpression] Func<bodyObjectInput> bodyObject, [WorkflowExpression] Func<string> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = SourceExpressionConverter.ConvertToken(bodycondition);
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
                body["object"] = SourceExpressionConverter.Convert(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnDelete([WorkflowExpression] Func<bodyObjectInput> bodyObject, [WorkflowExpression] Func<string> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/onDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = SourceExpressionConverter.ConvertToken(bodycondition);
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
                body["object"] = SourceExpressionConverter.Convert(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnInsert([WorkflowExpression] Func<bodyObjectInput> bodyObject, [WorkflowExpression] Func<string> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/onInsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = SourceExpressionConverter.ConvertToken(bodycondition);
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
                body["object"] = SourceExpressionConverter.Convert(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookOnUpdate([WorkflowExpression] Func<bodyObjectInput> bodyObject, [WorkflowExpression] Func<string> bodycondition = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/onUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["op"] = Convert.ToString("create");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycondition != null)
                {
                    body["condition"] = SourceExpressionConverter.ConvertToken(bodycondition);
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
                body["object"] = SourceExpressionConverter.Convert(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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