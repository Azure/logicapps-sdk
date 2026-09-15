//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushoverip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushoveripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> bodyuser, Expression<Func<string>> bodymessage, Expression<Func<string>> bodydevice = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodyhtmlInput>> bodyhtml = null, Expression<Func<string>> bodysound = null, Expression<Func<string>> bodytimestamp = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyurlTitle = null)
        {
            var apiCallPath = "/1/messages.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["user"] = CSharpExpressionConverter.ConvertToken(bodyuser);
            if (bodydevice != null)
            {
                body["device"] = CSharpExpressionConverter.ConvertToken(bodydevice);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyhtml != null)
            {
                body["html"] = CSharpExpressionConverter.Convert(bodyhtml);
                bodypropCount++;
            }

            bodypropCount++;
            body["message"] = CSharpExpressionConverter.ConvertToken(bodymessage);
            if (bodysound != null)
            {
                body["sound"] = CSharpExpressionConverter.ConvertToken(bodysound);
                bodypropCount++;
            }

            if (bodytimestamp != null)
            {
                body["timestamp"] = CSharpExpressionConverter.ConvertToken(bodytimestamp);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
            }

            if (bodyurlTitle != null)
            {
                body["url_title"] = CSharpExpressionConverter.ConvertToken(bodyurlTitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
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
            var apiCallPath = "/1/users/validate.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["user"] = CSharpExpressionConverter.ConvertToken(bodyuser);
            if (bodydevice != null)
            {
                body["device"] = CSharpExpressionConverter.ConvertToken(bodydevice);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ValidateKeyResponse>(callPayload);
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