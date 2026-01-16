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
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> bodyPhoneNumber, Expression<Func<string>> bodyMessageText, Expression<Func<string>> bodyExternalId = null, Expression<Func<string>> bodyMessageType = null, Expression<Func<string>> bodySenderId = null)
        {
            var apiCallPath = "/api/SMS";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyPhoneNumber);
            if (bodyExternalId != null)
            {
                body["ExternalId"] = ExpressionConverter.ConvertO(bodyExternalId);
                bodypropCount++;
            }

            bodypropCount++;
            body["MessageText"] = ExpressionConverter.ConvertO(bodyMessageText);
            if (bodyMessageType != null)
            {
                body["MessageType"] = ExpressionConverter.ConvertO(bodyMessageType);
                bodypropCount++;
            }

            if (bodySenderId != null)
            {
                body["SenderId"] = ExpressionConverter.ConvertO(bodySenderId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSMSResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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