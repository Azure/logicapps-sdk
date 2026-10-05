//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aspsms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AspsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aspsms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSimpleSMS))]
        public IBodyWorkflowAction<SendSimpleSMSResponse> SendSimpleSMS([WorkflowExpression] Func<string> mSISDN, [WorkflowExpression] Func<string> messageData, [WorkflowExpression] Func<string> originator = null, [WorkflowExpression] Func<int> lifeTime = null, [WorkflowExpression] Func<string> deferredDeliveryTime = null, [WorkflowExpression] Func<string> transactionReferenceNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSimpleSMSResponse> __BuildSendSimpleSMS(WorkflowValue<string> mSISDN, WorkflowValue<string> messageData, WorkflowValue<string> originator = null, WorkflowValue<int> lifeTime = null, WorkflowValue<string> deferredDeliveryTime = null, WorkflowValue<string> transactionReferenceNumber = null)
        {
            WorkflowValue.Validate(mSISDN, nameof(mSISDN), required: true);
            WorkflowValue.Validate(messageData, nameof(messageData), required: true);
            WorkflowValue.Validate(originator, nameof(originator), required: false);
            WorkflowValue.Validate(lifeTime, nameof(lifeTime), required: false);
            WorkflowValue.Validate(deferredDeliveryTime, nameof(deferredDeliveryTime), required: false);
            WorkflowValue.Validate(transactionReferenceNumber, nameof(transactionReferenceNumber), required: false);
            return new DeferredBodyAction<SendSimpleSMSResponse>(() =>
            {
                var apiCallPath = "/SendSimpleSMS";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MSISDN"] = ExpressionConverter.Convert(mSISDN);
                callPayload.Queries["Operation"] = Convert.ToString("SendTextSMS");
                callPayload.Queries["MessageData"] = ExpressionConverter.Convert(messageData);
                if (originator != null)
                    callPayload.Queries["Originator"] = ExpressionConverter.Convert(originator);
                if (lifeTime != null)
                    callPayload.Queries["LifeTime"] = ExpressionConverter.Convert(lifeTime);
                if (deferredDeliveryTime != null)
                    callPayload.Queries["DeferredDeliveryTime"] = ExpressionConverter.Convert(deferredDeliveryTime);
                if (transactionReferenceNumber != null)
                    callPayload.Queries["TransactionReferenceNumber"] = ExpressionConverter.Convert(transactionReferenceNumber);
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
