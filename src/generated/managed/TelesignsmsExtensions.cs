//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telesignsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelesignsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telesignsms")]
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<string>> bodyphoneNumber, Expression<Func<string>> bodymessageText, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodymessageType = null, Expression<Func<string>> bodysenderId = null)
        {
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: true);
            var __workflow_bodymessageText = WorkflowExpression.Compile(bodymessageText, nameof(bodymessageText), required: true);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodymessageType = WorkflowExpression.Compile(bodymessageType, nameof(bodymessageType), required: false);
            var __workflow_bodysenderId = WorkflowExpression.Compile(bodysenderId, nameof(bodysenderId), required: false);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SMS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                if (__workflow_bodyexternalId != null)
                {
                    body["ExternalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["MessageText"] = ExpressionConverter.ConvertO(__workflow_bodymessageText);
                if (__workflow_bodymessageType != null)
                {
                    body["MessageType"] = ExpressionConverter.ConvertO(__workflow_bodymessageType);
                    bodypropCount++;
                }

                if (__workflow_bodysenderId != null)
                {
                    body["SenderId"] = ExpressionConverter.ConvertO(__workflow_bodysenderId);
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
