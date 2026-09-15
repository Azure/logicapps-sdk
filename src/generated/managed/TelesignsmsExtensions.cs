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
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> bodyphoneNumber, Expression<Func<string>> bodymessageText, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodymessageType = null, Expression<Func<string>> bodysenderId = null)
        {
            var apiCallPath = "/api/SMS";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["PhoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
            if (bodyexternalId != null)
            {
                body["ExternalId"] = CSharpExpressionConverter.ConvertToken(bodyexternalId);
                bodypropCount++;
            }

            bodypropCount++;
            body["MessageText"] = CSharpExpressionConverter.ConvertToken(bodymessageText);
            if (bodymessageType != null)
            {
                body["MessageType"] = CSharpExpressionConverter.ConvertToken(bodymessageType);
                bodypropCount++;
            }

            if (bodysenderId != null)
            {
                body["SenderId"] = CSharpExpressionConverter.ConvertToken(bodysenderId);
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