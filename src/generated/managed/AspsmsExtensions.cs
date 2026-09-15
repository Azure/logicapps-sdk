//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aspsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AspsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aspsms")]
        public IBodyWorkflowAction<SendSimpleSMSResponse> SendSimpleSMS(Expression<Func<string>> mSISDN, Expression<Func<string>> messageData, Expression<Func<string>> originator = null, Expression<Func<int>> lifeTime = null, Expression<Func<string>> deferredDeliveryTime = null, Expression<Func<string>> transactionReferenceNumber = null)
        {
            var apiCallPath = "/SendSimpleSMS";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["MSISDN"] = CSharpExpressionConverter.ConvertO(mSISDN);
            callPayload.Queries["Operation"] = Convert.ToString("SendTextSMS");
            callPayload.Queries["MessageData"] = CSharpExpressionConverter.ConvertO(messageData);
            if (originator != null)
                callPayload.Queries["Originator"] = CSharpExpressionConverter.ConvertO(originator);
            if (lifeTime != null)
                callPayload.Queries["LifeTime"] = CSharpExpressionConverter.ConvertO(lifeTime);
            if (deferredDeliveryTime != null)
                callPayload.Queries["DeferredDeliveryTime"] = CSharpExpressionConverter.ConvertO(deferredDeliveryTime);
            if (transactionReferenceNumber != null)
                callPayload.Queries["TransactionReferenceNumber"] = CSharpExpressionConverter.ConvertO(transactionReferenceNumber);
            return new ApiConnectionAction<SendSimpleSMSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aspsms")]
        public IBodyWorkflowAction<JToken> ASPSMSCredits()
        {
            var apiCallPath = "/ASPSMSCredits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AspsmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSimpleSMSResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aspsms;

    public partial class WorkflowManagedActions
    {
        public AspsmsActions Aspsms(string connectionId) => new AspsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AspsmsTriggers Aspsms(string connectionId) => new AspsmsTriggers(connectionId);
    }
}