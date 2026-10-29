//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushtodisplayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushtodisplay")]
        public IBodyWorkflowAction<UpdateResponse, ApiConnectionActionConfiguration> SendUpdate(Expression<Func<SendUpdateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/updates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateResponse>(callPayload);
            });
        }
    }

    public class PushtodisplayTriggers([ConnectionName] string connectionId)
    {
    }

    public class UpdateResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("enqueuedAtUtc")]
        public string SentAt { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class SendUpdateInput
    {
        [JsonProperty("boardId")]
        public string BoardId { get; set; }

        [JsonProperty("blocks", DefaultValueHandling = DefaultValueHandling.Include)]
        public DisplayMessageBlock[] Blocks { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendUpdateInputTargetPanelType? TargetPanel { get; set; } = SendUpdateInputTargetPanelType._1;

        [JsonProperty("fullPanel", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FullPanelMode { get; set; } = false;

        [JsonProperty("density", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendUpdateInputContentSpacingType? ContentSpacing { get; set; } = SendUpdateInputContentSpacingType.Standard;

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendUpdateInputHorizontalAlignmentType? HorizontalAlignment { get; set; } = SendUpdateInputHorizontalAlignmentType.Center;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendUpdateInputVerticalAlignmentType? VerticalAlignment { get; set; } = SendUpdateInputVerticalAlignmentType.Center;

        [JsonProperty("background")]
        public string BackgroundColor { get; set; }
    }

    public class DisplayMessageBlock
    {
        [JsonProperty("text")]
        public string Message { get; set; }

        [JsonProperty("size")]
        public DisplayMessageBlockTextSizeType TextSize { get; set; }

        [JsonProperty("weight")]
        public DisplayMessageBlockFontWeightType FontWeight { get; set; }

        [JsonProperty("color")]
        public string TextColor { get; set; }

        [JsonProperty("background")]
        public string TextBackgroundColor { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DisplayMessageBlockTextSizeType
    {
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "large")]
        Large
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DisplayMessageBlockFontWeightType
    {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "semibold")]
        Semibold,
        [EnumMember(Value = "bold")]
        Bold
    }

    public enum SendUpdateInputTargetPanelType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendUpdateInputContentSpacingType
    {
        [EnumMember(Value = "compact")]
        Compact,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "spacious")]
        Spacious
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendUpdateInputHorizontalAlignmentType
    {
        [EnumMember(Value = "start")]
        Start,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "end")]
        End
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendUpdateInputVerticalAlignmentType
    {
        [EnumMember(Value = "start")]
        Start,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "end")]
        End
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay;

    public partial class WorkflowManagedActions
    {
        public PushtodisplayActions Pushtodisplay(string connectionId) => new PushtodisplayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PushtodisplayTriggers Pushtodisplay(string connectionId) => new PushtodisplayTriggers(connectionId);
    }
}