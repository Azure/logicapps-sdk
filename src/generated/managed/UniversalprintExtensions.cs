//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Universalprint
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UniversalprintActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "universalprint")]
        public IBodyWorkflowAction<PrintFileResponse, ApiConnectionActionConfiguration> PrintFile(Expression<Func<string>> printer, Expression<Func<string>> body, Expression<Func<string>> fileName, Expression<Func<int>> configurationCopies = null, Expression<Func<configurationOrientationInput>> configurationOrientation = null, Expression<Func<configurationColorModeInput>> configurationColorMode = null, Expression<Func<string>> configurationMediaSize = null, Expression<Func<configurationDuplexModeInput>> configurationDuplexMode = null, Expression<Func<int>> configurationPagesPerSheet = null, Expression<Func<int>> configurationDpi = null, Expression<Func<configurationQualityInput>> configurationQuality = null, Expression<Func<string>> configurationMediaType = null, Expression<Func<configurationFinishingsInputItem[]>> configurationFinishings = null)
        {
            var __workflow_printer = WorkflowExpression.Compile(printer, nameof(printer), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_configurationCopies = WorkflowExpression.Compile(configurationCopies, nameof(configurationCopies), required: false);
            var __workflow_configurationOrientation = WorkflowExpression.Compile(configurationOrientation, nameof(configurationOrientation), required: false);
            var __workflow_configurationColorMode = WorkflowExpression.Compile(configurationColorMode, nameof(configurationColorMode), required: false);
            var __workflow_configurationMediaSize = WorkflowExpression.Compile(configurationMediaSize, nameof(configurationMediaSize), required: false);
            var __workflow_configurationDuplexMode = WorkflowExpression.Compile(configurationDuplexMode, nameof(configurationDuplexMode), required: false);
            var __workflow_configurationPagesPerSheet = WorkflowExpression.Compile(configurationPagesPerSheet, nameof(configurationPagesPerSheet), required: false);
            var __workflow_configurationDpi = WorkflowExpression.Compile(configurationDpi, nameof(configurationDpi), required: false);
            var __workflow_configurationQuality = WorkflowExpression.Compile(configurationQuality, nameof(configurationQuality), required: false);
            var __workflow_configurationMediaType = WorkflowExpression.Compile(configurationMediaType, nameof(configurationMediaType), required: false);
            var __workflow_configurationFinishings = WorkflowExpression.Compile(configurationFinishings, nameof(configurationFinishings), required: false);
            return new DeferredBodyAction<PrintFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/print/shares";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["printer"] = ExpressionConverter.Convert(__workflow_printer);
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["configuration_copies"] = Convert.ToString(1);
                if (__workflow_configurationCopies != null)
                    callPayload.Queries["configuration_copies"] = ExpressionConverter.Convert(__workflow_configurationCopies);
                if (__workflow_configurationOrientation != null)
                    callPayload.Queries["configuration_orientation"] = ExpressionConverter.Convert(__workflow_configurationOrientation);
                if (__workflow_configurationColorMode != null)
                    callPayload.Queries["configuration_colorMode"] = ExpressionConverter.Convert(__workflow_configurationColorMode);
                if (__workflow_configurationMediaSize != null)
                    callPayload.Queries["configuration_mediaSize"] = ExpressionConverter.Convert(__workflow_configurationMediaSize);
                if (__workflow_configurationDuplexMode != null)
                    callPayload.Queries["configuration_duplexMode"] = ExpressionConverter.Convert(__workflow_configurationDuplexMode);
                if (__workflow_configurationPagesPerSheet != null)
                    callPayload.Queries["configuration_pagesPerSheet"] = ExpressionConverter.Convert(__workflow_configurationPagesPerSheet);
                if (__workflow_configurationDpi != null)
                    callPayload.Queries["configuration_dpi"] = ExpressionConverter.Convert(__workflow_configurationDpi);
                if (__workflow_configurationQuality != null)
                    callPayload.Queries["configuration_quality"] = ExpressionConverter.Convert(__workflow_configurationQuality);
                if (__workflow_configurationMediaType != null)
                    callPayload.Queries["configuration_mediaType"] = ExpressionConverter.Convert(__workflow_configurationMediaType);
                if (__workflow_configurationFinishings != null)
                    callPayload.Queries["configuration_finishings"] = ExpressionConverter.Convert(__workflow_configurationFinishings);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrintFileResponse>(callPayload);
            });
        }
    }

    public class UniversalprintTriggers([ConnectionName] string connectionId)
    {
    }

    public class PrintFileResponse
    {
        [JsonProperty("statusCode")]
        public int PrintPDFStatusCode { get; set; }

        [JsonProperty("status")]
        public string PrintPDFActionStatus { get; set; }

        [JsonProperty("message")]
        public string PrintPDFStatusMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum configurationOrientationInput
    {
        Landscape,
        Portrait,
        [EnumMember(Value = "Reverse landscape")]
        ReverseLandscape,
        [EnumMember(Value = "Reverse portrait")]
        ReversePortrait
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum configurationColorModeInput
    {
        Color,
        [EnumMember(Value = "Black and white")]
        BlackAndWhite,
        Grayscale,
        Auto
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum configurationDuplexModeInput
    {
        [EnumMember(Value = "One sided")]
        OneSided,
        [EnumMember(Value = "Flip on long edge")]
        FlipOnLongEdge,
        [EnumMember(Value = "Flip on short edge")]
        FlipOnShortEdge
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum configurationQualityInput
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum configurationFinishingsInputItem
    {
        None,
        Punch,
        Cover,
        Bind,
        Staple,
        [EnumMember(Value = "Staple top left")]
        StapleTopLeft,
        [EnumMember(Value = "Staple bottom left")]
        StapleBottomLeft,
        [EnumMember(Value = "Staple top right")]
        StapleTopRight,
        [EnumMember(Value = "Staple bottom right")]
        StapleBottomRight,
        [EnumMember(Value = "Staple dual left")]
        StapleDualLeft,
        [EnumMember(Value = "Staple dual top")]
        StapleDualTop,
        [EnumMember(Value = "Staple dual right")]
        StapleDualRight,
        [EnumMember(Value = "Staple dual bottom")]
        StapleDualBottom,
        [EnumMember(Value = "Saddle stitch")]
        SaddleStitch,
        [EnumMember(Value = "Stitch edge")]
        StitchEdge,
        [EnumMember(Value = "Stitch left edge")]
        StitchLeftEdge,
        [EnumMember(Value = "Stitch top edge")]
        StitchTopEdge,
        [EnumMember(Value = "Stitch right edge")]
        StitchRightEdge,
        [EnumMember(Value = "Stitch bottom edge")]
        StitchBottomEdge
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Universalprint;

    public partial class WorkflowManagedActions
    {
        public UniversalprintActions Universalprint(string connectionId) => new UniversalprintActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UniversalprintTriggers Universalprint(string connectionId) => new UniversalprintTriggers(connectionId);
    }
}