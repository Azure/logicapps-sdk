//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Firetext
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FiretextActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "firetext")]
        public IBodyWorkflowAction<SendsmsResponse, ApiConnectionActionConfiguration> Sendsms(Expression<Func<SendsmsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendsmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sendsms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendsmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "firetext")]
        public IBodyWorkflowAction<SubscribeResponse, ApiConnectionActionConfiguration> Subscribe(Expression<Func<SubscribeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubscribeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscribeResponse>(callPayload);
            });
        }
    }

    public class FiretextTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendsmsResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }
    }

    public class SendsmsInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
    }

    public class SubscribeResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }
    }

    public class SubscribeInput
    {
        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("mobile", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mobile { get; set; }

        [JsonProperty("update", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeInputUpdateType? Update { get; set; } = SubscribeInputUpdateType._0;
    }

    public enum SubscribeInputUpdateType
    {
        _0 = 0,
        _1 = 1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Firetext;

    public partial class WorkflowManagedActions
    {
        public FiretextActions Firetext(string connectionId) => new FiretextActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FiretextTriggers Firetext(string connectionId) => new FiretextTriggers(connectionId);
    }
}