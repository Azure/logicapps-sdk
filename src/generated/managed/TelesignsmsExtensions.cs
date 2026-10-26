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
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<SendSMSInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SMS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class SendSMSInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }
        public string ExternalId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageText { get; set; }
        public string MessageType { get; set; }
        public string SenderId { get; set; }
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