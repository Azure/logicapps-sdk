//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telesignsms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelesignsmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telesignsms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMS))]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> bodyphoneNumber, [WorkflowExpression] Func<string> bodymessageText, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodymessageType = null, [WorkflowExpression] Func<string> bodysenderId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telesignsms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSMSResponse> __BuildSendSMS(WorkflowExpression<string> bodyphoneNumber, WorkflowExpression<string> bodymessageText, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodymessageType = null, WorkflowExpression<string> bodysenderId = null)
        {
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            WorkflowExpression.Validate(bodymessageText, nameof(bodymessageText), required: true);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodymessageType, nameof(bodymessageType), required: false);
            WorkflowExpression.Validate(bodysenderId, nameof(bodysenderId), required: false);
            return new DeferredBodyAction<SendSMSResponse>(() =>
            {
                var apiCallPath = "/api/SMS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                if (bodyexternalId != null)
                {
                    body["ExternalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MessageText"] = ExpressionConverter.ConvertO(bodymessageText);
                if (bodymessageType != null)
                {
                    body["MessageType"] = ExpressionConverter.ConvertO(bodymessageType);
                    bodypropCount++;
                }

                if (bodysenderId != null)
                {
                    body["SenderId"] = ExpressionConverter.ConvertO(bodysenderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
        }
    }

    public class TelesignsmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSMSResponse
    {
        public string ReferenceId { get; set; }
        public string Status { get; set; }

        [JsonProperty("Status Code")]
        public string StatusCode { get; set; }
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Telesignsms;

    public partial class WorkflowManagedActions
    {
        public TelesignsmsActions Telesignsms(string connectionId) => new TelesignsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TelesignsmsTriggers Telesignsms(string connectionId) => new TelesignsmsTriggers(connectionId);
    }
}