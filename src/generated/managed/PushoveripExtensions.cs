//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushoverip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushoveripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<GetSoundsResponse, ApiConnectionActionConfiguration> GetSounds()
        {
            return new DeferredBodyAction<GetSoundsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/sounds.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSoundsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<ValidateKeyResponse, ApiConnectionActionConfiguration> ValidateKey(Expression<Func<ValidateKeyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ValidateKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/users/validate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<LimitsResponse, ApiConnectionActionConfiguration> Limits()
        {
            return new DeferredBodyAction<LimitsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/apps/limits.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LimitsResponse>(callPayload);
            });
        }
    }

    public class PushoveripTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendMessageResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }
    }

    public class SendMessageInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; } = "";

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("priority")]
        public SendMessageInputPriorityType? Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("html")]
        public SendMessageInputHtmlType? Html { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("sound")]
        public string Sound { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_title")]
        public string UrlTitle { get; set; }
    }

    public enum SendMessageInputPriorityType
    {
        Negative2 = -2,
        Negative1 = -1,
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum SendMessageInputHtmlType
    {
        _1 = 1
    }

    public class GetSoundsResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("soundsArray")]
        public GetSoundsResponseSoundsArrayTypeItem[] SoundsArray { get; set; }
    }

    public class GetSoundsResponseSoundsArrayTypeItem
    {
        [JsonProperty("sound")]
        public string Sound { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ValidateKeyResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("group")]
        public int Group { get; set; }

        [JsonProperty("devices")]
        public string[] Devices { get; set; }

        [JsonProperty("licenses")]
        public string[] Licenses { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }
    }

    public class ValidateKeyInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; } = "";

        [JsonProperty("device")]
        public string Device { get; set; }
    }

    public class LimitsResponse
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset")]
        public int Reset { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pushoverip;

    public partial class WorkflowManagedActions
    {
        public PushoveripActions Pushoverip(string connectionId) => new PushoveripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PushoveripTriggers Pushoverip(string connectionId) => new PushoveripTriggers(connectionId);
    }
}