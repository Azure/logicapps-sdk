//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Universalprint
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UniversalprintActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "universalprint")]
        public IBodyWorkflowAction<PrintFileResponse> PrintFile(Expression<Func<string>> printer, Expression<Func<string>> fileName, Expression<Func<string>> body = null, Expression<Func<int>> configurationCopies = null, Expression<Func<configurationOrientationInput>> configurationOrientation = null, Expression<Func<configurationColorModeInput>> configurationColorMode = null, Expression<Func<string>> configurationMediaSize = null, Expression<Func<configurationDuplexModeInput>> configurationDuplexMode = null, Expression<Func<int>> configurationPagesPerSheet = null, Expression<Func<int>> configurationDpi = null, Expression<Func<configurationQualityInput>> configurationQuality = null, Expression<Func<string>> configurationMediaType = null, Expression<Func<configurationFinishingsInputItem[]>> configurationFinishings = null)
        {
            var apiCallPath = "/v1.0/print/shares";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["printer"] = ExpressionConverter.Convert(printer);
            callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Queries["configuration_copies"] = Convert.ToString(1);
            if (configurationCopies != null)
                callPayload.Queries["configuration_copies"] = ExpressionConverter.Convert(configurationCopies);
            if (configurationOrientation != null)
                callPayload.Queries["configuration_orientation"] = ExpressionConverter.Convert(configurationOrientation);
            if (configurationColorMode != null)
                callPayload.Queries["configuration_colorMode"] = ExpressionConverter.Convert(configurationColorMode);
            if (configurationMediaSize != null)
                callPayload.Queries["configuration_mediaSize"] = ExpressionConverter.Convert(configurationMediaSize);
            if (configurationDuplexMode != null)
                callPayload.Queries["configuration_duplexMode"] = ExpressionConverter.Convert(configurationDuplexMode);
            if (configurationPagesPerSheet != null)
                callPayload.Queries["configuration_pagesPerSheet"] = ExpressionConverter.Convert(configurationPagesPerSheet);
            if (configurationDpi != null)
                callPayload.Queries["configuration_dpi"] = ExpressionConverter.Convert(configurationDpi);
            if (configurationQuality != null)
                callPayload.Queries["configuration_quality"] = ExpressionConverter.Convert(configurationQuality);
            if (configurationMediaType != null)
                callPayload.Queries["configuration_mediaType"] = ExpressionConverter.Convert(configurationMediaType);
            if (configurationFinishings != null)
                callPayload.Queries["configuration_finishings"] = ExpressionConverter.Convert(configurationFinishings);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PrintFileResponse>(callPayload);
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

    public enum configurationOrientationInput
    {
        Landscape,
        Portrait,
        [EnumMember(Value = "Reverse landscape")]
        ReverseLandscape,
        [EnumMember(Value = "Reverse portrait")]
        ReversePortrait
    }

    public enum configurationColorModeInput
    {
        Color,
        [EnumMember(Value = "Black and white")]
        BlackAndWhite,
        Grayscale,
        Auto
    }

    public enum configurationDuplexModeInput
    {
        [EnumMember(Value = "One sided")]
        OneSided,
        [EnumMember(Value = "Flip on long edge")]
        FlipOnLongEdge,
        [EnumMember(Value = "Flip on short edge")]
        FlipOnShortEdge
    }

    public enum configurationQualityInput
    {
        Low,
        Medium,
        High
    }

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