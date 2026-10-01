//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> CreateProduct([WorkflowExpression] Func<string> bodytREEId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<double> bodycTYPE = null, [WorkflowExpression] Func<string> bodydESCR1 = null, [WorkflowExpression] Func<string> bodydESCR2 = null, [WorkflowExpression] Func<string> bodydESCR3 = null, [WorkflowExpression] Func<string> bodytYPE = null, [WorkflowExpression] Func<string> bodymEMO = null, [WorkflowExpression] Func<string> bodyuPC = null, [WorkflowExpression] Func<string> bodymFG = null, [WorkflowExpression] Func<string> bodymFGPART = null, [WorkflowExpression] Func<string> bodypRIVENDOR = null, [WorkflowExpression] Func<string> bodyeACHUNIT = null, [WorkflowExpression] Func<double> bodywEIGHT = null, [WorkflowExpression] Func<double> bodycOST = null, [WorkflowExpression] Func<double> bodybASE = null, [WorkflowExpression] Func<string> bodyeXTERNALId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/INVENTRY";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["ID"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["TREE_ID"] = SourceExpressionConverter.ConvertToken(bodytREEId);
                if (bodycTYPE != null)
                {
                    body["C_TYPE"] = SourceExpressionConverter.ConvertToken(bodycTYPE);
                    bodypropCount++;
                }

                if (bodydESCR1 != null)
                {
                    body["DESCR_1"] = SourceExpressionConverter.ConvertToken(bodydESCR1);
                    bodypropCount++;
                }

                if (bodydESCR2 != null)
                {
                    body["DESCR_2"] = SourceExpressionConverter.ConvertToken(bodydESCR2);
                    bodypropCount++;
                }

                if (bodydESCR3 != null)
                {
                    body["DESCR_3"] = SourceExpressionConverter.ConvertToken(bodydESCR3);
                    bodypropCount++;
                }

                if (bodytYPE != null)
                {
                    body["TYPE"] = SourceExpressionConverter.ConvertToken(bodytYPE);
                    bodypropCount++;
                }

                if (bodymEMO != null)
                {
                    body["MEMO"] = SourceExpressionConverter.ConvertToken(bodymEMO);
                    bodypropCount++;
                }

                if (bodyuPC != null)
                {
                    body["UPC"] = SourceExpressionConverter.ConvertToken(bodyuPC);
                    bodypropCount++;
                }

                if (bodymFG != null)
                {
                    body["MFG"] = SourceExpressionConverter.ConvertToken(bodymFG);
                    bodypropCount++;
                }

                if (bodymFGPART != null)
                {
                    body["MFG_PART"] = SourceExpressionConverter.ConvertToken(bodymFGPART);
                    bodypropCount++;
                }

                if (bodypRIVENDOR != null)
                {
                    body["PRI_VENDOR"] = SourceExpressionConverter.ConvertToken(bodypRIVENDOR);
                    bodypropCount++;
                }

                if (bodyeACHUNIT != null)
                {
                    body["EACH_UNIT"] = SourceExpressionConverter.ConvertToken(bodyeACHUNIT);
                    bodypropCount++;
                }

                if (bodywEIGHT != null)
                {
                    body["WEIGHT"] = SourceExpressionConverter.ConvertToken(bodywEIGHT);
                    bodypropCount++;
                }

                if (bodycOST != null)
                {
                    body["COST"] = SourceExpressionConverter.ConvertToken(bodycOST);
                    bodypropCount++;
                }

                if (bodybASE != null)
                {
                    body["BASE"] = SourceExpressionConverter.ConvertToken(bodybASE);
                    bodypropCount++;
                }

                if (bodyeXTERNALId != null)
                {
                    body["EXTERNALID"] = SourceExpressionConverter.ConvertToken(bodyeXTERNALId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> UpdateProduct([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> bodydESCR1 = null, [WorkflowExpression] Func<string> bodydESCR2 = null, [WorkflowExpression] Func<string> bodydESCR3 = null, [WorkflowExpression] Func<string> bodytYPE = null, [WorkflowExpression] Func<string> bodymEMO = null, [WorkflowExpression] Func<string> bodyuPC = null, [WorkflowExpression] Func<string> bodymFG = null, [WorkflowExpression] Func<string> bodymFGPART = null, [WorkflowExpression] Func<string> bodypRIVENDOR = null, [WorkflowExpression] Func<string> bodyeACHUNIT = null, [WorkflowExpression] Func<double> bodywEIGHT = null, [WorkflowExpression] Func<double> bodycOST = null, [WorkflowExpression] Func<double> bodybASE = null, [WorkflowExpression] Func<string> bodyeXTERNALId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/INVENTRY(ID='{0}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydESCR1 != null)
                {
                    body["DESCR_1"] = SourceExpressionConverter.ConvertToken(bodydESCR1);
                    bodypropCount++;
                }

                if (bodydESCR2 != null)
                {
                    body["DESCR_2"] = SourceExpressionConverter.ConvertToken(bodydESCR2);
                    bodypropCount++;
                }

                if (bodydESCR3 != null)
                {
                    body["DESCR_3"] = SourceExpressionConverter.ConvertToken(bodydESCR3);
                    bodypropCount++;
                }

                if (bodytYPE != null)
                {
                    body["TYPE"] = SourceExpressionConverter.ConvertToken(bodytYPE);
                    bodypropCount++;
                }

                if (bodymEMO != null)
                {
                    body["MEMO"] = SourceExpressionConverter.ConvertToken(bodymEMO);
                    bodypropCount++;
                }

                if (bodyuPC != null)
                {
                    body["UPC"] = SourceExpressionConverter.ConvertToken(bodyuPC);
                    bodypropCount++;
                }

                if (bodymFG != null)
                {
                    body["MFG"] = SourceExpressionConverter.ConvertToken(bodymFG);
                    bodypropCount++;
                }

                if (bodymFGPART != null)
                {
                    body["MFG_PART"] = SourceExpressionConverter.ConvertToken(bodymFGPART);
                    bodypropCount++;
                }

                if (bodypRIVENDOR != null)
                {
                    body["PRI_VENDOR"] = SourceExpressionConverter.ConvertToken(bodypRIVENDOR);
                    bodypropCount++;
                }

                if (bodyeACHUNIT != null)
                {
                    body["EACH_UNIT"] = SourceExpressionConverter.ConvertToken(bodyeACHUNIT);
                    bodypropCount++;
                }

                if (bodywEIGHT != null)
                {
                    body["WEIGHT"] = SourceExpressionConverter.ConvertToken(bodywEIGHT);
                    bodypropCount++;
                }

                if (bodycOST != null)
                {
                    body["COST"] = SourceExpressionConverter.ConvertToken(bodycOST);
                    bodypropCount++;
                }

                if (bodybASE != null)
                {
                    body["BASE"] = SourceExpressionConverter.ConvertToken(bodybASE);
                    bodypropCount++;
                }

                if (bodyeXTERNALId != null)
                {
                    body["EXTERNALID"] = SourceExpressionConverter.ConvertToken(bodyeXTERNALId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class EbmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ebms;

    public partial class WorkflowManagedActions
    {
        public EbmsActions Ebms(string connectionId) => new EbmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EbmsTriggers Ebms(string connectionId) => new EbmsTriggers(connectionId);
    }
}