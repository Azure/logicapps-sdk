//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> CreateProduct([WorkflowExpression] Func<string> bodytREEID, [WorkflowExpression] Func<string> bodyiD = null, [WorkflowExpression] Func<double> bodycTYPE = null, [WorkflowExpression] Func<string> bodydESCR1 = null, [WorkflowExpression] Func<string> bodydESCR2 = null, [WorkflowExpression] Func<string> bodydESCR3 = null, [WorkflowExpression] Func<string> bodytYPE = null, [WorkflowExpression] Func<string> bodymEMO = null, [WorkflowExpression] Func<string> bodyuPC = null, [WorkflowExpression] Func<string> bodymFG = null, [WorkflowExpression] Func<string> bodymFGPART = null, [WorkflowExpression] Func<string> bodypRIVENDOR = null, [WorkflowExpression] Func<string> bodyeACHUNIT = null, [WorkflowExpression] Func<double> bodywEIGHT = null, [WorkflowExpression] Func<double> bodycOST = null, [WorkflowExpression] Func<double> bodybASE = null, [WorkflowExpression] Func<string> bodyeXTERNALID = null)
        {
            var apiCallPath = "/INVENTRY";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyiD != null)
            {
                body["ID"] = ExpressionConverter.ConvertO(bodyiD);
                bodypropCount++;
            }

            bodypropCount++;
            body["TREE_ID"] = ExpressionConverter.ConvertO(bodytREEID);
            if (bodycTYPE != null)
            {
                body["C_TYPE"] = ExpressionConverter.ConvertO(bodycTYPE);
                bodypropCount++;
            }

            if (bodydESCR1 != null)
            {
                body["DESCR_1"] = ExpressionConverter.ConvertO(bodydESCR1);
                bodypropCount++;
            }

            if (bodydESCR2 != null)
            {
                body["DESCR_2"] = ExpressionConverter.ConvertO(bodydESCR2);
                bodypropCount++;
            }

            if (bodydESCR3 != null)
            {
                body["DESCR_3"] = ExpressionConverter.ConvertO(bodydESCR3);
                bodypropCount++;
            }

            if (bodytYPE != null)
            {
                body["TYPE"] = ExpressionConverter.ConvertO(bodytYPE);
                bodypropCount++;
            }

            if (bodymEMO != null)
            {
                body["MEMO"] = ExpressionConverter.ConvertO(bodymEMO);
                bodypropCount++;
            }

            if (bodyuPC != null)
            {
                body["UPC"] = ExpressionConverter.ConvertO(bodyuPC);
                bodypropCount++;
            }

            if (bodymFG != null)
            {
                body["MFG"] = ExpressionConverter.ConvertO(bodymFG);
                bodypropCount++;
            }

            if (bodymFGPART != null)
            {
                body["MFG_PART"] = ExpressionConverter.ConvertO(bodymFGPART);
                bodypropCount++;
            }

            if (bodypRIVENDOR != null)
            {
                body["PRI_VENDOR"] = ExpressionConverter.ConvertO(bodypRIVENDOR);
                bodypropCount++;
            }

            if (bodyeACHUNIT != null)
            {
                body["EACH_UNIT"] = ExpressionConverter.ConvertO(bodyeACHUNIT);
                bodypropCount++;
            }

            if (bodywEIGHT != null)
            {
                body["WEIGHT"] = ExpressionConverter.ConvertO(bodywEIGHT);
                bodypropCount++;
            }

            if (bodycOST != null)
            {
                body["COST"] = ExpressionConverter.ConvertO(bodycOST);
                bodypropCount++;
            }

            if (bodybASE != null)
            {
                body["BASE"] = ExpressionConverter.ConvertO(bodybASE);
                bodypropCount++;
            }

            if (bodyeXTERNALID != null)
            {
                body["EXTERNALID"] = ExpressionConverter.ConvertO(bodyeXTERNALID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> UpdateProduct([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> productId, [WorkflowExpression] Func<string> bodydESCR1 = null, [WorkflowExpression] Func<string> bodydESCR2 = null, [WorkflowExpression] Func<string> bodydESCR3 = null, [WorkflowExpression] Func<string> bodytYPE = null, [WorkflowExpression] Func<string> bodymEMO = null, [WorkflowExpression] Func<string> bodyuPC = null, [WorkflowExpression] Func<string> bodymFG = null, [WorkflowExpression] Func<string> bodymFGPART = null, [WorkflowExpression] Func<string> bodypRIVENDOR = null, [WorkflowExpression] Func<string> bodyeACHUNIT = null, [WorkflowExpression] Func<double> bodywEIGHT = null, [WorkflowExpression] Func<double> bodycOST = null, [WorkflowExpression] Func<double> bodybASE = null, [WorkflowExpression] Func<string> bodyeXTERNALID = null)
        {
            var apiCallPath = String.Format("/INVENTRY(ID='{0}')", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydESCR1 != null)
            {
                body["DESCR_1"] = ExpressionConverter.ConvertO(bodydESCR1);
                bodypropCount++;
            }

            if (bodydESCR2 != null)
            {
                body["DESCR_2"] = ExpressionConverter.ConvertO(bodydESCR2);
                bodypropCount++;
            }

            if (bodydESCR3 != null)
            {
                body["DESCR_3"] = ExpressionConverter.ConvertO(bodydESCR3);
                bodypropCount++;
            }

            if (bodytYPE != null)
            {
                body["TYPE"] = ExpressionConverter.ConvertO(bodytYPE);
                bodypropCount++;
            }

            if (bodymEMO != null)
            {
                body["MEMO"] = ExpressionConverter.ConvertO(bodymEMO);
                bodypropCount++;
            }

            if (bodyuPC != null)
            {
                body["UPC"] = ExpressionConverter.ConvertO(bodyuPC);
                bodypropCount++;
            }

            if (bodymFG != null)
            {
                body["MFG"] = ExpressionConverter.ConvertO(bodymFG);
                bodypropCount++;
            }

            if (bodymFGPART != null)
            {
                body["MFG_PART"] = ExpressionConverter.ConvertO(bodymFGPART);
                bodypropCount++;
            }

            if (bodypRIVENDOR != null)
            {
                body["PRI_VENDOR"] = ExpressionConverter.ConvertO(bodypRIVENDOR);
                bodypropCount++;
            }

            if (bodyeACHUNIT != null)
            {
                body["EACH_UNIT"] = ExpressionConverter.ConvertO(bodyeACHUNIT);
                bodypropCount++;
            }

            if (bodywEIGHT != null)
            {
                body["WEIGHT"] = ExpressionConverter.ConvertO(bodywEIGHT);
                bodypropCount++;
            }

            if (bodycOST != null)
            {
                body["COST"] = ExpressionConverter.ConvertO(bodycOST);
                bodypropCount++;
            }

            if (bodybASE != null)
            {
                body["BASE"] = ExpressionConverter.ConvertO(bodybASE);
                bodypropCount++;
            }

            if (bodyeXTERNALID != null)
            {
                body["EXTERNALID"] = ExpressionConverter.ConvertO(bodyeXTERNALID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
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