//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushoverip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PushoveripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> bodyuser, Expression<Func<string>> bodymessage, Expression<Func<string>> bodydevice = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodyhtmlInput>> bodyhtml = null, Expression<Func<string>> bodysound = null, Expression<Func<string>> bodytimestamp = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyurlTitle = null)
        {
            var __workflow_bodyuser = bodyuser == null ? null : WorkflowExpression.Compile(bodyuser);
            WorkflowExpression.Validate(__workflow_bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodydevice = bodydevice == null ? null : WorkflowExpression.Compile(bodydevice);
            WorkflowExpression.Validate(__workflow_bodydevice, nameof(bodydevice), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyhtml = bodyhtml == null ? null : WorkflowExpression.Compile(bodyhtml);
            WorkflowExpression.Validate(__workflow_bodyhtml, nameof(bodyhtml), required: false);
            var __workflow_bodysound = bodysound == null ? null : WorkflowExpression.Compile(bodysound);
            WorkflowExpression.Validate(__workflow_bodysound, nameof(bodysound), required: false);
            var __workflow_bodytimestamp = bodytimestamp == null ? null : WorkflowExpression.Compile(bodytimestamp);
            WorkflowExpression.Validate(__workflow_bodytimestamp, nameof(bodytimestamp), required: false);
            var __workflow_bodyurl = bodyurl == null ? null : WorkflowExpression.Compile(bodyurl);
            WorkflowExpression.Validate(__workflow_bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyurlTitle = bodyurlTitle == null ? null : WorkflowExpression.Compile(bodyurlTitle);
            WorkflowExpression.Validate(__workflow_bodyurlTitle, nameof(bodyurlTitle), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
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
        public IBodyWorkflowAction<GetSoundsResponse> GetSounds()
        {
            var apiCallPath = "/1/sounds.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSoundsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<ValidateKeyResponse> ValidateKey(Expression<Func<string>> bodyuser, Expression<Func<string>> bodydevice = null)
        {
            var __workflow_bodyuser = bodyuser == null ? null : WorkflowExpression.Compile(bodyuser);
            WorkflowExpression.Validate(__workflow_bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodydevice = bodydevice == null ? null : WorkflowExpression.Compile(bodydevice);
            WorkflowExpression.Validate(__workflow_bodydevice, nameof(bodydevice), required: false);
            return new DeferredBodyAction<ValidateKeyResponse>(() =>
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
        public IBodyWorkflowAction<LimitsResponse> Limits()
        {
            var apiCallPath = "/1/apps/limits.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LimitsResponse>(callPayload);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypriorityInput
    {
        [EnumMember(Value = "-2")]
        Negative2,
        [EnumMember(Value = "-1")]
        Negative1,
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyhtmlInput
    {
        [EnumMember(Value = "1")]
        _1
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
