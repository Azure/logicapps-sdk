//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telesignsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelesignsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telesignsms")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> bodyphoneNumber, [WorkflowExpression] Func<string> bodymessageText, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodymessageType = null, [WorkflowExpression] Func<string> bodysenderId = null)
        {
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            SourceExpression.Validate(bodymessageText, nameof(bodymessageText), required: true);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodymessageType, nameof(bodymessageType), required: false);
            SourceExpression.Validate(bodysenderId, nameof(bodysenderId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/SMS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                if (bodyexternalId != null)
                {
                    body["ExternalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MessageText"] = SourceExpressionConverter.ConvertToken(bodymessageText);
                if (bodymessageType != null)
                {
                    body["MessageType"] = SourceExpressionConverter.ConvertToken(bodymessageType);
                    bodypropCount++;
                }

                if (bodysenderId != null)
                {
                    body["SenderId"] = SourceExpressionConverter.ConvertToken(bodysenderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSResponse>(BuildSourceInput);
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