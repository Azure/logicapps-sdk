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
        public IBodyWorkflowAction<JToken> CreateProduct(Expression<Func<string>> bodyTREEID, Expression<Func<string>> bodyID = null, Expression<Func<double>> bodyCTYPE = null, Expression<Func<string>> bodyDESCR1 = null, Expression<Func<string>> bodyDESCR2 = null, Expression<Func<string>> bodyDESCR3 = null, Expression<Func<string>> bodyTYPE = null, Expression<Func<string>> bodyMEMO = null, Expression<Func<string>> bodyUPC = null, Expression<Func<string>> bodyMFG = null, Expression<Func<string>> bodyMFGPART = null, Expression<Func<string>> bodyPRIVENDOR = null, Expression<Func<string>> bodyEACHUNIT = null, Expression<Func<double>> bodyWEIGHT = null, Expression<Func<double>> bodyCOST = null, Expression<Func<double>> bodyBASE = null, Expression<Func<string>> bodyEXTERNALID = null)
        {
            var apiCallPath = "/INVENTRY";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyID != null)
            {
                body["ID"] = ExpressionConverter.ConvertO(bodyID);
                bodypropCount++;
            }

            bodypropCount++;
            body["TREE_ID"] = ExpressionConverter.ConvertO(bodyTREEID);
            if (bodyCTYPE != null)
            {
                body["C_TYPE"] = ExpressionConverter.ConvertO(bodyCTYPE);
                bodypropCount++;
            }

            if (bodyDESCR1 != null)
            {
                body["DESCR_1"] = ExpressionConverter.ConvertO(bodyDESCR1);
                bodypropCount++;
            }

            if (bodyDESCR2 != null)
            {
                body["DESCR_2"] = ExpressionConverter.ConvertO(bodyDESCR2);
                bodypropCount++;
            }

            if (bodyDESCR3 != null)
            {
                body["DESCR_3"] = ExpressionConverter.ConvertO(bodyDESCR3);
                bodypropCount++;
            }

            if (bodyTYPE != null)
            {
                body["TYPE"] = ExpressionConverter.ConvertO(bodyTYPE);
                bodypropCount++;
            }

            if (bodyMEMO != null)
            {
                body["MEMO"] = ExpressionConverter.ConvertO(bodyMEMO);
                bodypropCount++;
            }

            if (bodyUPC != null)
            {
                body["UPC"] = ExpressionConverter.ConvertO(bodyUPC);
                bodypropCount++;
            }

            if (bodyMFG != null)
            {
                body["MFG"] = ExpressionConverter.ConvertO(bodyMFG);
                bodypropCount++;
            }

            if (bodyMFGPART != null)
            {
                body["MFG_PART"] = ExpressionConverter.ConvertO(bodyMFGPART);
                bodypropCount++;
            }

            if (bodyPRIVENDOR != null)
            {
                body["PRI_VENDOR"] = ExpressionConverter.ConvertO(bodyPRIVENDOR);
                bodypropCount++;
            }

            if (bodyEACHUNIT != null)
            {
                body["EACH_UNIT"] = ExpressionConverter.ConvertO(bodyEACHUNIT);
                bodypropCount++;
            }

            if (bodyWEIGHT != null)
            {
                body["WEIGHT"] = ExpressionConverter.ConvertO(bodyWEIGHT);
                bodypropCount++;
            }

            if (bodyCOST != null)
            {
                body["COST"] = ExpressionConverter.ConvertO(bodyCOST);
                bodypropCount++;
            }

            if (bodyBASE != null)
            {
                body["BASE"] = ExpressionConverter.ConvertO(bodyBASE);
                bodypropCount++;
            }

            if (bodyEXTERNALID != null)
            {
                body["EXTERNALID"] = ExpressionConverter.ConvertO(bodyEXTERNALID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken> UpdateProduct(Expression<Func<string>> productId, Expression<Func<string>> bodyDESCR1 = null, Expression<Func<string>> bodyDESCR2 = null, Expression<Func<string>> bodyDESCR3 = null, Expression<Func<string>> bodyTYPE = null, Expression<Func<string>> bodyMEMO = null, Expression<Func<string>> bodyUPC = null, Expression<Func<string>> bodyMFG = null, Expression<Func<string>> bodyMFGPART = null, Expression<Func<string>> bodyPRIVENDOR = null, Expression<Func<string>> bodyEACHUNIT = null, Expression<Func<double>> bodyWEIGHT = null, Expression<Func<double>> bodyCOST = null, Expression<Func<double>> bodyBASE = null, Expression<Func<string>> bodyEXTERNALID = null)
        {
            var apiCallPath = String.Format("/INVENTRY(ID='{0}')", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDESCR1 != null)
            {
                body["DESCR_1"] = ExpressionConverter.ConvertO(bodyDESCR1);
                bodypropCount++;
            }

            if (bodyDESCR2 != null)
            {
                body["DESCR_2"] = ExpressionConverter.ConvertO(bodyDESCR2);
                bodypropCount++;
            }

            if (bodyDESCR3 != null)
            {
                body["DESCR_3"] = ExpressionConverter.ConvertO(bodyDESCR3);
                bodypropCount++;
            }

            if (bodyTYPE != null)
            {
                body["TYPE"] = ExpressionConverter.ConvertO(bodyTYPE);
                bodypropCount++;
            }

            if (bodyMEMO != null)
            {
                body["MEMO"] = ExpressionConverter.ConvertO(bodyMEMO);
                bodypropCount++;
            }

            if (bodyUPC != null)
            {
                body["UPC"] = ExpressionConverter.ConvertO(bodyUPC);
                bodypropCount++;
            }

            if (bodyMFG != null)
            {
                body["MFG"] = ExpressionConverter.ConvertO(bodyMFG);
                bodypropCount++;
            }

            if (bodyMFGPART != null)
            {
                body["MFG_PART"] = ExpressionConverter.ConvertO(bodyMFGPART);
                bodypropCount++;
            }

            if (bodyPRIVENDOR != null)
            {
                body["PRI_VENDOR"] = ExpressionConverter.ConvertO(bodyPRIVENDOR);
                bodypropCount++;
            }

            if (bodyEACHUNIT != null)
            {
                body["EACH_UNIT"] = ExpressionConverter.ConvertO(bodyEACHUNIT);
                bodypropCount++;
            }

            if (bodyWEIGHT != null)
            {
                body["WEIGHT"] = ExpressionConverter.ConvertO(bodyWEIGHT);
                bodypropCount++;
            }

            if (bodyCOST != null)
            {
                body["COST"] = ExpressionConverter.ConvertO(bodyCOST);
                bodypropCount++;
            }

            if (bodyBASE != null)
            {
                body["BASE"] = ExpressionConverter.ConvertO(bodyBASE);
                bodypropCount++;
            }

            if (bodyEXTERNALID != null)
            {
                body["EXTERNALID"] = ExpressionConverter.ConvertO(bodyEXTERNALID);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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