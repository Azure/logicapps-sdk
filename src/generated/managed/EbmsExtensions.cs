//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EbmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> CreateProduct(Expression<Func<string>> bodytREEID, Expression<Func<string>> bodyiD = null, Expression<Func<double>> bodycTYPE = null, Expression<Func<string>> bodydESCR1 = null, Expression<Func<string>> bodydESCR2 = null, Expression<Func<string>> bodydESCR3 = null, Expression<Func<string>> bodytYPE = null, Expression<Func<string>> bodymEMO = null, Expression<Func<string>> bodyuPC = null, Expression<Func<string>> bodymFG = null, Expression<Func<string>> bodymFGPART = null, Expression<Func<string>> bodypRIVENDOR = null, Expression<Func<string>> bodyeACHUNIT = null, Expression<Func<double>> bodywEIGHT = null, Expression<Func<double>> bodycOST = null, Expression<Func<double>> bodybASE = null, Expression<Func<string>> bodyeXTERNALID = null)
        {
            var __workflow_bodytREEID = bodytREEID == null ? null : WorkflowExpression.Compile(bodytREEID);
            WorkflowExpression.Validate(__workflow_bodytREEID, nameof(bodytREEID), required: true);
            var __workflow_bodyiD = bodyiD == null ? null : WorkflowExpression.Compile(bodyiD);
            WorkflowExpression.Validate(__workflow_bodyiD, nameof(bodyiD), required: false);
            var __workflow_bodycTYPE = bodycTYPE == null ? null : WorkflowExpression.Compile(bodycTYPE);
            WorkflowExpression.Validate(__workflow_bodycTYPE, nameof(bodycTYPE), required: false);
            var __workflow_bodydESCR1 = bodydESCR1 == null ? null : WorkflowExpression.Compile(bodydESCR1);
            WorkflowExpression.Validate(__workflow_bodydESCR1, nameof(bodydESCR1), required: false);
            var __workflow_bodydESCR2 = bodydESCR2 == null ? null : WorkflowExpression.Compile(bodydESCR2);
            WorkflowExpression.Validate(__workflow_bodydESCR2, nameof(bodydESCR2), required: false);
            var __workflow_bodydESCR3 = bodydESCR3 == null ? null : WorkflowExpression.Compile(bodydESCR3);
            WorkflowExpression.Validate(__workflow_bodydESCR3, nameof(bodydESCR3), required: false);
            var __workflow_bodytYPE = bodytYPE == null ? null : WorkflowExpression.Compile(bodytYPE);
            WorkflowExpression.Validate(__workflow_bodytYPE, nameof(bodytYPE), required: false);
            var __workflow_bodymEMO = bodymEMO == null ? null : WorkflowExpression.Compile(bodymEMO);
            WorkflowExpression.Validate(__workflow_bodymEMO, nameof(bodymEMO), required: false);
            var __workflow_bodyuPC = bodyuPC == null ? null : WorkflowExpression.Compile(bodyuPC);
            WorkflowExpression.Validate(__workflow_bodyuPC, nameof(bodyuPC), required: false);
            var __workflow_bodymFG = bodymFG == null ? null : WorkflowExpression.Compile(bodymFG);
            WorkflowExpression.Validate(__workflow_bodymFG, nameof(bodymFG), required: false);
            var __workflow_bodymFGPART = bodymFGPART == null ? null : WorkflowExpression.Compile(bodymFGPART);
            WorkflowExpression.Validate(__workflow_bodymFGPART, nameof(bodymFGPART), required: false);
            var __workflow_bodypRIVENDOR = bodypRIVENDOR == null ? null : WorkflowExpression.Compile(bodypRIVENDOR);
            WorkflowExpression.Validate(__workflow_bodypRIVENDOR, nameof(bodypRIVENDOR), required: false);
            var __workflow_bodyeACHUNIT = bodyeACHUNIT == null ? null : WorkflowExpression.Compile(bodyeACHUNIT);
            WorkflowExpression.Validate(__workflow_bodyeACHUNIT, nameof(bodyeACHUNIT), required: false);
            var __workflow_bodywEIGHT = bodywEIGHT == null ? null : WorkflowExpression.Compile(bodywEIGHT);
            WorkflowExpression.Validate(__workflow_bodywEIGHT, nameof(bodywEIGHT), required: false);
            var __workflow_bodycOST = bodycOST == null ? null : WorkflowExpression.Compile(bodycOST);
            WorkflowExpression.Validate(__workflow_bodycOST, nameof(bodycOST), required: false);
            var __workflow_bodybASE = bodybASE == null ? null : WorkflowExpression.Compile(bodybASE);
            WorkflowExpression.Validate(__workflow_bodybASE, nameof(bodybASE), required: false);
            var __workflow_bodyeXTERNALID = bodyeXTERNALID == null ? null : WorkflowExpression.Compile(bodyeXTERNALID);
            WorkflowExpression.Validate(__workflow_bodyeXTERNALID, nameof(bodyeXTERNALID), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/INVENTRY";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyiD != null)
                {
                    body["ID"] = ExpressionConverter.ConvertO(__workflow_bodyiD);
                    bodypropCount++;
                }

                bodypropCount++;
                body["TREE_ID"] = ExpressionConverter.ConvertO(__workflow_bodytREEID);
                if (__workflow_bodycTYPE != null)
                {
                    body["C_TYPE"] = ExpressionConverter.ConvertO(__workflow_bodycTYPE);
                    bodypropCount++;
                }

                if (__workflow_bodydESCR1 != null)
                {
                    body["DESCR_1"] = ExpressionConverter.ConvertO(__workflow_bodydESCR1);
                    bodypropCount++;
                }

                if (__workflow_bodydESCR2 != null)
                {
                    body["DESCR_2"] = ExpressionConverter.ConvertO(__workflow_bodydESCR2);
                    bodypropCount++;
                }

                if (__workflow_bodydESCR3 != null)
                {
                    body["DESCR_3"] = ExpressionConverter.ConvertO(__workflow_bodydESCR3);
                    bodypropCount++;
                }

                if (__workflow_bodytYPE != null)
                {
                    body["TYPE"] = ExpressionConverter.ConvertO(__workflow_bodytYPE);
                    bodypropCount++;
                }

                if (__workflow_bodymEMO != null)
                {
                    body["MEMO"] = ExpressionConverter.ConvertO(__workflow_bodymEMO);
                    bodypropCount++;
                }

                if (__workflow_bodyuPC != null)
                {
                    body["UPC"] = ExpressionConverter.ConvertO(__workflow_bodyuPC);
                    bodypropCount++;
                }

                if (__workflow_bodymFG != null)
                {
                    body["MFG"] = ExpressionConverter.ConvertO(__workflow_bodymFG);
                    bodypropCount++;
                }

                if (__workflow_bodymFGPART != null)
                {
                    body["MFG_PART"] = ExpressionConverter.ConvertO(__workflow_bodymFGPART);
                    bodypropCount++;
                }

                if (__workflow_bodypRIVENDOR != null)
                {
                    body["PRI_VENDOR"] = ExpressionConverter.ConvertO(__workflow_bodypRIVENDOR);
                    bodypropCount++;
                }

                if (__workflow_bodyeACHUNIT != null)
                {
                    body["EACH_UNIT"] = ExpressionConverter.ConvertO(__workflow_bodyeACHUNIT);
                    bodypropCount++;
                }

                if (__workflow_bodywEIGHT != null)
                {
                    body["WEIGHT"] = ExpressionConverter.ConvertO(__workflow_bodywEIGHT);
                    bodypropCount++;
                }

                if (__workflow_bodycOST != null)
                {
                    body["COST"] = ExpressionConverter.ConvertO(__workflow_bodycOST);
                    bodypropCount++;
                }

                if (__workflow_bodybASE != null)
                {
                    body["BASE"] = ExpressionConverter.ConvertO(__workflow_bodybASE);
                    bodypropCount++;
                }

                if (__workflow_bodyeXTERNALID != null)
                {
                    body["EXTERNALID"] = ExpressionConverter.ConvertO(__workflow_bodyeXTERNALID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> UpdateProduct(Expression<Func<string>> productId, Expression<Func<string>> bodydESCR1 = null, Expression<Func<string>> bodydESCR2 = null, Expression<Func<string>> bodydESCR3 = null, Expression<Func<string>> bodytYPE = null, Expression<Func<string>> bodymEMO = null, Expression<Func<string>> bodyuPC = null, Expression<Func<string>> bodymFG = null, Expression<Func<string>> bodymFGPART = null, Expression<Func<string>> bodypRIVENDOR = null, Expression<Func<string>> bodyeACHUNIT = null, Expression<Func<double>> bodywEIGHT = null, Expression<Func<double>> bodycOST = null, Expression<Func<double>> bodybASE = null, Expression<Func<string>> bodyeXTERNALID = null)
        {
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            var __workflow_bodydESCR1 = bodydESCR1 == null ? null : WorkflowExpression.Compile(bodydESCR1);
            WorkflowExpression.Validate(__workflow_bodydESCR1, nameof(bodydESCR1), required: false);
            var __workflow_bodydESCR2 = bodydESCR2 == null ? null : WorkflowExpression.Compile(bodydESCR2);
            WorkflowExpression.Validate(__workflow_bodydESCR2, nameof(bodydESCR2), required: false);
            var __workflow_bodydESCR3 = bodydESCR3 == null ? null : WorkflowExpression.Compile(bodydESCR3);
            WorkflowExpression.Validate(__workflow_bodydESCR3, nameof(bodydESCR3), required: false);
            var __workflow_bodytYPE = bodytYPE == null ? null : WorkflowExpression.Compile(bodytYPE);
            WorkflowExpression.Validate(__workflow_bodytYPE, nameof(bodytYPE), required: false);
            var __workflow_bodymEMO = bodymEMO == null ? null : WorkflowExpression.Compile(bodymEMO);
            WorkflowExpression.Validate(__workflow_bodymEMO, nameof(bodymEMO), required: false);
            var __workflow_bodyuPC = bodyuPC == null ? null : WorkflowExpression.Compile(bodyuPC);
            WorkflowExpression.Validate(__workflow_bodyuPC, nameof(bodyuPC), required: false);
            var __workflow_bodymFG = bodymFG == null ? null : WorkflowExpression.Compile(bodymFG);
            WorkflowExpression.Validate(__workflow_bodymFG, nameof(bodymFG), required: false);
            var __workflow_bodymFGPART = bodymFGPART == null ? null : WorkflowExpression.Compile(bodymFGPART);
            WorkflowExpression.Validate(__workflow_bodymFGPART, nameof(bodymFGPART), required: false);
            var __workflow_bodypRIVENDOR = bodypRIVENDOR == null ? null : WorkflowExpression.Compile(bodypRIVENDOR);
            WorkflowExpression.Validate(__workflow_bodypRIVENDOR, nameof(bodypRIVENDOR), required: false);
            var __workflow_bodyeACHUNIT = bodyeACHUNIT == null ? null : WorkflowExpression.Compile(bodyeACHUNIT);
            WorkflowExpression.Validate(__workflow_bodyeACHUNIT, nameof(bodyeACHUNIT), required: false);
            var __workflow_bodywEIGHT = bodywEIGHT == null ? null : WorkflowExpression.Compile(bodywEIGHT);
            WorkflowExpression.Validate(__workflow_bodywEIGHT, nameof(bodywEIGHT), required: false);
            var __workflow_bodycOST = bodycOST == null ? null : WorkflowExpression.Compile(bodycOST);
            WorkflowExpression.Validate(__workflow_bodycOST, nameof(bodycOST), required: false);
            var __workflow_bodybASE = bodybASE == null ? null : WorkflowExpression.Compile(bodybASE);
            WorkflowExpression.Validate(__workflow_bodybASE, nameof(bodybASE), required: false);
            var __workflow_bodyeXTERNALID = bodyeXTERNALID == null ? null : WorkflowExpression.Compile(bodyeXTERNALID);
            WorkflowExpression.Validate(__workflow_bodyeXTERNALID, nameof(bodyeXTERNALID), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/INVENTRY(ID='{0}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydESCR1 != null)
                {
                    body["DESCR_1"] = ExpressionConverter.ConvertO(__workflow_bodydESCR1);
                    bodypropCount++;
                }

                if (__workflow_bodydESCR2 != null)
                {
                    body["DESCR_2"] = ExpressionConverter.ConvertO(__workflow_bodydESCR2);
                    bodypropCount++;
                }

                if (__workflow_bodydESCR3 != null)
                {
                    body["DESCR_3"] = ExpressionConverter.ConvertO(__workflow_bodydESCR3);
                    bodypropCount++;
                }

                if (__workflow_bodytYPE != null)
                {
                    body["TYPE"] = ExpressionConverter.ConvertO(__workflow_bodytYPE);
                    bodypropCount++;
                }

                if (__workflow_bodymEMO != null)
                {
                    body["MEMO"] = ExpressionConverter.ConvertO(__workflow_bodymEMO);
                    bodypropCount++;
                }

                if (__workflow_bodyuPC != null)
                {
                    body["UPC"] = ExpressionConverter.ConvertO(__workflow_bodyuPC);
                    bodypropCount++;
                }

                if (__workflow_bodymFG != null)
                {
                    body["MFG"] = ExpressionConverter.ConvertO(__workflow_bodymFG);
                    bodypropCount++;
                }

                if (__workflow_bodymFGPART != null)
                {
                    body["MFG_PART"] = ExpressionConverter.ConvertO(__workflow_bodymFGPART);
                    bodypropCount++;
                }

                if (__workflow_bodypRIVENDOR != null)
                {
                    body["PRI_VENDOR"] = ExpressionConverter.ConvertO(__workflow_bodypRIVENDOR);
                    bodypropCount++;
                }

                if (__workflow_bodyeACHUNIT != null)
                {
                    body["EACH_UNIT"] = ExpressionConverter.ConvertO(__workflow_bodyeACHUNIT);
                    bodypropCount++;
                }

                if (__workflow_bodywEIGHT != null)
                {
                    body["WEIGHT"] = ExpressionConverter.ConvertO(__workflow_bodywEIGHT);
                    bodypropCount++;
                }

                if (__workflow_bodycOST != null)
                {
                    body["COST"] = ExpressionConverter.ConvertO(__workflow_bodycOST);
                    bodypropCount++;
                }

                if (__workflow_bodybASE != null)
                {
                    body["BASE"] = ExpressionConverter.ConvertO(__workflow_bodybASE);
                    bodypropCount++;
                }

                if (__workflow_bodyeXTERNALID != null)
                {
                    body["EXTERNALID"] = ExpressionConverter.ConvertO(__workflow_bodyeXTERNALID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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
