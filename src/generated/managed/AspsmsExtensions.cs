//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aspsms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AspsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aspsms")]
        public IBodyWorkflowAction<SendSimpleSMSResponse> SendSimpleSMS(Expression<Func<string>> mSISDN, Expression<Func<string>> messageData, Expression<Func<string>> originator = null, Expression<Func<int>> lifeTime = null, Expression<Func<string>> deferredDeliveryTime = null, Expression<Func<string>> transactionReferenceNumber = null)
        {
            var __workflow_mSISDN = WorkflowExpression.Compile(mSISDN, nameof(mSISDN), required: true);
            var __workflow_messageData = WorkflowExpression.Compile(messageData, nameof(messageData), required: true);
            var __workflow_originator = WorkflowExpression.Compile(originator, nameof(originator), required: false);
            var __workflow_lifeTime = WorkflowExpression.Compile(lifeTime, nameof(lifeTime), required: false);
            var __workflow_deferredDeliveryTime = WorkflowExpression.Compile(deferredDeliveryTime, nameof(deferredDeliveryTime), required: false);
            var __workflow_transactionReferenceNumber = WorkflowExpression.Compile(transactionReferenceNumber, nameof(transactionReferenceNumber), required: false);
            return new DeferredBodyAction<SendSimpleSMSResponse>(() =>
            {
                var apiCallPath = "/SendSimpleSMS";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MSISDN"] = ExpressionConverter.Convert(__workflow_mSISDN);
                callPayload.Queries["Operation"] = Convert.ToString("SendTextSMS");
                callPayload.Queries["MessageData"] = ExpressionConverter.Convert(__workflow_messageData);
                if (__workflow_originator != null)
                    callPayload.Queries["Originator"] = ExpressionConverter.Convert(__workflow_originator);
                if (__workflow_lifeTime != null)
                    callPayload.Queries["LifeTime"] = ExpressionConverter.Convert(__workflow_lifeTime);
                if (__workflow_deferredDeliveryTime != null)
                    callPayload.Queries["DeferredDeliveryTime"] = ExpressionConverter.Convert(__workflow_deferredDeliveryTime);
                if (__workflow_transactionReferenceNumber != null)
                    callPayload.Queries["TransactionReferenceNumber"] = ExpressionConverter.Convert(__workflow_transactionReferenceNumber);
                return new ApiConnectionAction<SendSimpleSMSResponse>(callPayload);
            });
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
