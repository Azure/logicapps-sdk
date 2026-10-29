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
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> bodyuser, Expression<Func<string>> bodymessage, Expression<Func<string>> bodydevice = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodyhtmlInput>> bodyhtml = null, Expression<Func<string>> bodysound = null, Expression<Func<string>> bodytimestamp = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyurlTitle = null)
        {
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodydevice = WorkflowExpression.Compile(bodydevice, nameof(bodydevice), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyhtml = WorkflowExpression.Compile(bodyhtml, nameof(bodyhtml), required: false);
            var __workflow_bodysound = WorkflowExpression.Compile(bodysound, nameof(bodysound), required: false);
            var __workflow_bodytimestamp = WorkflowExpression.Compile(bodytimestamp, nameof(bodytimestamp), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyurlTitle = WorkflowExpression.Compile(bodyurlTitle, nameof(bodyurlTitle), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                if (__workflow_bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(__workflow_bodydevice);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyhtml != null)
                {
                    body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodysound != null)
                {
                    body["sound"] = ExpressionConverter.ConvertO(__workflow_bodysound);
                    bodypropCount++;
                }

                if (__workflow_bodytimestamp != null)
                {
                    body["timestamp"] = ExpressionConverter.ConvertO(__workflow_bodytimestamp);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyurlTitle != null)
                {
                    body["url_title"] = ExpressionConverter.ConvertO(__workflow_bodyurlTitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<ValidateKeyResponse, ApiConnectionActionConfiguration> ValidateKey(Expression<Func<string>> bodyuser, Expression<Func<string>> bodydevice = null)
        {
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodydevice = WorkflowExpression.Compile(bodydevice, nameof(bodydevice), required: false);
            return new DeferredBodyAction<ValidateKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/users/validate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                if (__workflow_bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(__workflow_bodydevice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public enum bodypriorityInput
    {
        Negative2 = -2,
        Negative1 = -1,
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum bodyhtmlInput
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