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
        public IBodyWorkflowAction<SendSimpleSMSResponse> SendSimpleSMS([WorkflowExpression] Func<string> mSISDN, [WorkflowExpression] Func<string> messageData, [WorkflowExpression] Func<string> originator = null, [WorkflowExpression] Func<int> lifeTime = null, [WorkflowExpression] Func<string> deferredDeliveryTime = null, [WorkflowExpression] Func<string> transactionReferenceNumber = null)
        {
            SourceExpression.Validate(mSISDN, nameof(mSISDN), required: true);
            SourceExpression.Validate(messageData, nameof(messageData), required: true);
            SourceExpression.Validate(originator, nameof(originator), required: false);
            SourceExpression.Validate(lifeTime, nameof(lifeTime), required: false);
            SourceExpression.Validate(deferredDeliveryTime, nameof(deferredDeliveryTime), required: false);
            SourceExpression.Validate(transactionReferenceNumber, nameof(transactionReferenceNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SendSimpleSMS";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MSISDN"] = SourceExpressionConverter.ConvertO(mSISDN);
                callPayload.Queries["Operation"] = Convert.ToString("SendTextSMS");
                callPayload.Queries["MessageData"] = SourceExpressionConverter.ConvertO(messageData);
                if (originator != null)
                    callPayload.Queries["Originator"] = SourceExpressionConverter.ConvertO(originator);
                if (lifeTime != null)
                    callPayload.Queries["LifeTime"] = SourceExpressionConverter.ConvertO(lifeTime);
                if (deferredDeliveryTime != null)
                    callPayload.Queries["DeferredDeliveryTime"] = SourceExpressionConverter.ConvertO(deferredDeliveryTime);
                if (transactionReferenceNumber != null)
                    callPayload.Queries["TransactionReferenceNumber"] = SourceExpressionConverter.ConvertO(transactionReferenceNumber);
                return callPayload;
            }

            return new ApiConnectionAction<SendSimpleSMSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aspsms")]
        public IBodyWorkflowAction<JToken> ASPSMSCredits()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ASPSMSCredits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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