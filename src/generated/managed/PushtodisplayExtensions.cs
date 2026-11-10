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
        public IBodyWorkflowAction<UpdateResponse, ApiConnectionActionConfiguration> SendUpdate(Expression<Func<BodyInput>> body)
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

    public class BodyInput
    {
        public BodyInput(DisplayMessageBlock[] blocks)
        {
            this.Blocks = blocks;
        }

        [JsonProperty("boardId")]
        public string BoardId { get; set; }

        [JsonProperty("blocks", DefaultValueHandling = DefaultValueHandling.Include)]
        public DisplayMessageBlock[] Blocks { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTargetPanelType? TargetPanel { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay.BodyInputTargetPanelType._1;

        [JsonProperty("fullPanel", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FullPanelMode { get; set; } = false;

        [JsonProperty("density", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputContentSpacingType? ContentSpacing { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay.BodyInputContentSpacingType.Standard;

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputHorizontalAlignmentType? HorizontalAlignment { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay.BodyInputHorizontalAlignmentType.Center;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputVerticalAlignmentType? VerticalAlignment { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pushtodisplay.BodyInputVerticalAlignmentType.Center;

        [JsonProperty("background")]
        public string BackgroundColor { get; set; }
    }

    public class DisplayMessageBlock
    {
        public DisplayMessageBlock(string message)
        {
            this.Message = message;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("size")]
        public DisplayMessageBlockTextSizeType? TextSize { get; set; }

        [JsonProperty("weight")]
        public DisplayMessageBlockFontWeightType? FontWeight { get; set; }

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

    public enum BodyInputTargetPanelType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContentSpacingType
    {
        [EnumMember(Value = "compact")]
        Compact,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "spacious")]
        Spacious
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputHorizontalAlignmentType
    {
        [EnumMember(Value = "start")]
        Start,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "end")]
        End
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputVerticalAlignmentType
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