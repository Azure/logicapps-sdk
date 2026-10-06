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
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodydevice = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodyhtmlInput> bodyhtml = null, [WorkflowExpression] Func<string> bodysound = null, [WorkflowExpression] Func<string> bodytimestamp = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyurlTitle = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodydevice != null)
                {
                    body["device"] = SourceExpressionConverter.ConvertToken(bodydevice);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyhtml != null)
                {
                    body["html"] = SourceExpressionConverter.Convert(bodyhtml);
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodysound != null)
                {
                    body["sound"] = SourceExpressionConverter.ConvertToken(bodysound);
                    bodypropCount++;
                }

                if (bodytimestamp != null)
                {
                    body["timestamp"] = SourceExpressionConverter.ConvertToken(bodytimestamp);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodyurlTitle != null)
                {
                    body["url_title"] = SourceExpressionConverter.ConvertToken(bodyurlTitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<GetSoundsResponse> GetSounds()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/sounds.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSoundsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<ValidateKeyResponse> ValidateKey([WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<string> bodydevice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/users/validate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodydevice != null)
                {
                    body["device"] = SourceExpressionConverter.ConvertToken(bodydevice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ValidateKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        public IBodyWorkflowAction<LimitsResponse> Limits()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/apps/limits.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LimitsResponse>(BuildSourceInput);
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