//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linemessageip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinemessageipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linemessageip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/bot/message/push";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LinemessageipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendMessageInput
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("messages")]
        public SendMessageInputMessagesTypeItem[] Messages { get; set; }
    }

    public class SendMessageInputMessagesTypeItem
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageInputMessagesTypeItemTypeType? Type { get; set; } = SendMessageInputMessagesTypeItemTypeType.Text;

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("stickerId")]
        public string StickerId { get; set; }

        [JsonProperty("originalContentUrl")]
        public string OriginalContentUrl { get; set; }

        [JsonProperty("previewImageUrl")]
        public string PreviewImageUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageInputMessagesTypeItemTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "sticker")]
        Sticker,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "location")]
        Location
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linemessageip;

    public partial class WorkflowManagedActions
    {
        public LinemessageipActions Linemessageip(string connectionId) => new LinemessageipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LinemessageipTriggers Linemessageip(string connectionId) => new LinemessageipTriggers(connectionId);
    }
}