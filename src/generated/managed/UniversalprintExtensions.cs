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
        public IBodyWorkflowAction<PrintFileResponse> PrintFile([WorkflowExpression] Func<string> printer, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<int> configurationCopies = null, [WorkflowExpression] Func<configurationOrientationInput> configurationOrientation = null, [WorkflowExpression] Func<configurationColorModeInput> configurationColorMode = null, [WorkflowExpression] Func<string> configurationMediaSize = null, [WorkflowExpression] Func<configurationDuplexModeInput> configurationDuplexMode = null, [WorkflowExpression] Func<int> configurationPagesPerSheet = null, [WorkflowExpression] Func<int> configurationDpi = null, [WorkflowExpression] Func<configurationQualityInput> configurationQuality = null, [WorkflowExpression] Func<string> configurationMediaType = null, [WorkflowExpression] Func<configurationFinishingsInputItem[]> configurationFinishings = null)
        {
            SourceExpression.Validate(printer, nameof(printer), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(configurationCopies, nameof(configurationCopies), required: false);
            SourceExpression.Validate(configurationOrientation, nameof(configurationOrientation), required: false);
            SourceExpression.Validate(configurationColorMode, nameof(configurationColorMode), required: false);
            SourceExpression.Validate(configurationMediaSize, nameof(configurationMediaSize), required: false);
            SourceExpression.Validate(configurationDuplexMode, nameof(configurationDuplexMode), required: false);
            SourceExpression.Validate(configurationPagesPerSheet, nameof(configurationPagesPerSheet), required: false);
            SourceExpression.Validate(configurationDpi, nameof(configurationDpi), required: false);
            SourceExpression.Validate(configurationQuality, nameof(configurationQuality), required: false);
            SourceExpression.Validate(configurationMediaType, nameof(configurationMediaType), required: false);
            SourceExpression.Validate(configurationFinishings, nameof(configurationFinishings), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/print/shares";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["printer"] = SourceExpressionConverter.ConvertO(printer);
                callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Queries["configuration_copies"] = Convert.ToString(1);
                if (configurationCopies != null)
                    callPayload.Queries["configuration_copies"] = SourceExpressionConverter.ConvertO(configurationCopies);
                if (configurationOrientation != null)
                    callPayload.Queries["configuration_orientation"] = SourceExpressionConverter.Convert(configurationOrientation);
                if (configurationColorMode != null)
                    callPayload.Queries["configuration_colorMode"] = SourceExpressionConverter.Convert(configurationColorMode);
                if (configurationMediaSize != null)
                    callPayload.Queries["configuration_mediaSize"] = SourceExpressionConverter.ConvertO(configurationMediaSize);
                if (configurationDuplexMode != null)
                    callPayload.Queries["configuration_duplexMode"] = SourceExpressionConverter.Convert(configurationDuplexMode);
                if (configurationPagesPerSheet != null)
                    callPayload.Queries["configuration_pagesPerSheet"] = SourceExpressionConverter.ConvertO(configurationPagesPerSheet);
                if (configurationDpi != null)
                    callPayload.Queries["configuration_dpi"] = SourceExpressionConverter.ConvertO(configurationDpi);
                if (configurationQuality != null)
                    callPayload.Queries["configuration_quality"] = SourceExpressionConverter.Convert(configurationQuality);
                if (configurationMediaType != null)
                    callPayload.Queries["configuration_mediaType"] = SourceExpressionConverter.ConvertO(configurationMediaType);
                if (configurationFinishings != null)
                    callPayload.Queries["configuration_finishings"] = SourceExpressionConverter.ConvertO(configurationFinishings);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PrintFileResponse>(BuildSourceInput);
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