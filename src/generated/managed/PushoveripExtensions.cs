//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushoverip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushoveripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodydevice = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodyhtmlInput> bodyhtml = null, [WorkflowExpression] Func<string> bodysound = null, [WorkflowExpression] Func<string> bodytimestamp = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyurlTitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowExpression<string> bodyuser, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodydevice = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<bodyhtmlInput> bodyhtml = null, WorkflowExpression<string> bodysound = null, WorkflowExpression<string> bodytimestamp = null, WorkflowExpression<string> bodyurl = null, WorkflowExpression<string> bodyurlTitle = null)
        {
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodydevice, nameof(bodydevice), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: false);
            WorkflowExpression.Validate(bodysound, nameof(bodysound), required: false);
            WorkflowExpression.Validate(bodytimestamp, nameof(bodytimestamp), required: false);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowExpression.Validate(bodyurlTitle, nameof(bodyurlTitle), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = "/1/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = ExpressionConverter.ConvertO(bodyuser);
                if (bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(bodydevice);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyhtml != null)
                {
                    body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodysound != null)
                {
                    body["sound"] = ExpressionConverter.ConvertO(bodysound);
                    bodypropCount++;
                }

                if (bodytimestamp != null)
                {
                    body["timestamp"] = ExpressionConverter.ConvertO(bodytimestamp);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodyurlTitle != null)
                {
                    body["url_title"] = ExpressionConverter.ConvertO(bodyurlTitle);
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
        [WorkflowExpressionFactory(nameof(__BuildValidateKey))]
        public IBodyWorkflowAction<ValidateKeyResponse> ValidateKey([WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<string> bodydevice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushoverip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateKeyResponse> __BuildValidateKey(WorkflowExpression<string> bodyuser, WorkflowExpression<string> bodydevice = null)
        {
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: true);
            WorkflowExpression.Validate(bodydevice, nameof(bodydevice), required: false);
            return new DeferredBodyAction<ValidateKeyResponse>(() =>
            {
                var apiCallPath = "/1/users/validate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user"] = ExpressionConverter.ConvertO(bodyuser);
                if (bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(bodydevice);
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