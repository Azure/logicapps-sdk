//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Quickchartip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QuickchartipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartPostResponse> Chart([WorkflowExpression] Func<string> bodychart, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<string> bodydevicePixelRatio = null, [WorkflowExpression] Func<string> bodybackgroundColor = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyversion = null)
        {
            SourceExpression.Validate(bodychart, nameof(bodychart), required: true);
            SourceExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            SourceExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            SourceExpression.Validate(bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            SourceExpression.Validate(bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            SourceExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = SourceExpressionConverter.ConvertToken(bodychart);
                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = SourceExpressionConverter.ConvertToken(bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (bodybackgroundColor != null)
                {
                    body["backgroundColor"] = SourceExpressionConverter.ConvertToken(bodybackgroundColor);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = SourceExpressionConverter.Convert(bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "png";
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    if (bodyencoding != null)
                    {
                        body["encoding"] = SourceExpressionConverter.Convert(bodyencoding);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["encoding"] = "url";
                    bodypropCount++;
                }

                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChartPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartURLResponse> ChartURL([WorkflowExpression] Func<string> bodychart, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<string> bodydevicePixelRatio = null, [WorkflowExpression] Func<string> bodybackgroundColor = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyversion = null)
        {
            SourceExpression.Validate(bodychart, nameof(bodychart), required: true);
            SourceExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            SourceExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            SourceExpression.Validate(bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            SourceExpression.Validate(bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyencoding, nameof(bodyencoding), required: false);
            SourceExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chart/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = SourceExpressionConverter.ConvertToken(bodychart);
                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = SourceExpressionConverter.ConvertToken(bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (bodybackgroundColor != null)
                {
                    body["backgroundColor"] = SourceExpressionConverter.ConvertToken(bodybackgroundColor);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = SourceExpressionConverter.Convert(bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "png";
                    bodypropCount++;
                }

                if (bodyencoding != null)
                {
                    if (bodyencoding != null)
                    {
                        body["encoding"] = SourceExpressionConverter.Convert(bodyencoding);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["encoding"] = "url";
                    bodypropCount++;
                }

                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChartURLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartTemplateResponse> ChartTemplate([WorkflowExpression] Func<string> chartId, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> labels = null, [WorkflowExpression] Func<string> data1 = null, [WorkflowExpression] Func<string> data2 = null)
        {
            SourceExpression.Validate(chartId, nameof(chartId), required: true);
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(labels, nameof(labels), required: false);
            SourceExpression.Validate(data1, nameof(data1), required: false);
            SourceExpression.Validate(data2, nameof(data2), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chart/render/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chartId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (labels != null)
                    callPayload.Queries["labels"] = SourceExpressionConverter.ConvertO(labels);
                if (data1 != null)
                    callPayload.Queries["data1"] = SourceExpressionConverter.ConvertO(data1);
                if (data2 != null)
                    callPayload.Queries["data2"] = SourceExpressionConverter.ConvertO(data2);
                return callPayload;
            }

            return new ApiConnectionAction<ChartTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<QRCodeResponse> QRCode([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> margin = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> dark = null, [WorkflowExpression] Func<string> light = null, [WorkflowExpression] Func<ecLevelInput> ecLevel = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> centerImageUrl = null, [WorkflowExpression] Func<double> centerImageSizeRatio = null, [WorkflowExpression] Func<int> centerImageWidth = null, [WorkflowExpression] Func<int> centerImageHeight = null)
        {
            SourceExpression.Validate(text, nameof(text), required: false);
            SourceExpression.Validate(margin, nameof(margin), required: false);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(dark, nameof(dark), required: false);
            SourceExpression.Validate(light, nameof(light), required: false);
            SourceExpression.Validate(ecLevel, nameof(ecLevel), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(centerImageUrl, nameof(centerImageUrl), required: false);
            SourceExpression.Validate(centerImageSizeRatio, nameof(centerImageSizeRatio), required: false);
            SourceExpression.Validate(centerImageWidth, nameof(centerImageWidth), required: false);
            SourceExpression.Validate(centerImageHeight, nameof(centerImageHeight), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                callPayload.Queries["margin"] = Convert.ToString(4);
                if (margin != null)
                    callPayload.Queries["margin"] = SourceExpressionConverter.ConvertO(margin);
                callPayload.Queries["size"] = Convert.ToString(150);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (dark != null)
                    callPayload.Queries["dark"] = SourceExpressionConverter.ConvertO(dark);
                callPayload.Queries["light"] = Convert.ToString("ffffff");
                if (light != null)
                    callPayload.Queries["light"] = SourceExpressionConverter.ConvertO(light);
                callPayload.Queries["ecLevel"] = Convert.ToString("M");
                if (ecLevel != null)
                    callPayload.Queries["ecLevel"] = SourceExpressionConverter.Convert(ecLevel);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (centerImageUrl != null)
                    callPayload.Queries["centerImageUrl"] = SourceExpressionConverter.ConvertO(centerImageUrl);
                callPayload.Queries["centerImageSizeRatio"] = Convert.ToString(0.3);
                if (centerImageSizeRatio != null)
                    callPayload.Queries["centerImageSizeRatio"] = SourceExpressionConverter.ConvertO(centerImageSizeRatio);
                if (centerImageWidth != null)
                    callPayload.Queries["centerImageWidth"] = SourceExpressionConverter.ConvertO(centerImageWidth);
                if (centerImageHeight != null)
                    callPayload.Queries["centerImageHeight"] = SourceExpressionConverter.ConvertO(centerImageHeight);
                return callPayload;
            }

            return new ApiConnectionAction<QRCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<GraphVizResponse> GraphViz([WorkflowExpression] Func<string> bodygraph, [WorkflowExpression] Func<bodylayoutInput> bodylayout = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null)
        {
            SourceExpression.Validate(bodygraph, nameof(bodygraph), required: true);
            SourceExpression.Validate(bodylayout, nameof(bodylayout), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodywidth, nameof(bodywidth), required: false);
            SourceExpression.Validate(bodyheight, nameof(bodyheight), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/graphviz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["graph"] = SourceExpressionConverter.ConvertToken(bodygraph);
                if (bodylayout != null)
                {
                    if (bodylayout != null)
                    {
                        body["layout"] = SourceExpressionConverter.Convert(bodylayout);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["layout"] = "dot";
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = SourceExpressionConverter.Convert(bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "svg";
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GraphVizResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<WordCloudResponse> WordCloud([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> fontFamily = null, [WorkflowExpression] Func<string> loadGoogleFonts = null, [WorkflowExpression] Func<int> fontScale = null, [WorkflowExpression] Func<scaleInput> scale = null, [WorkflowExpression] Func<int> padding = null, [WorkflowExpression] Func<int> rotation = null, [WorkflowExpression] Func<int> maxNumWords = null, [WorkflowExpression] Func<int> minWordLength = null, [WorkflowExpression] Func<@caseInput> @case = null, [WorkflowExpression] Func<string> colors = null, [WorkflowExpression] Func<bool> removeStopwords = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> useWordList = null)
        {
            SourceExpression.Validate(text, nameof(text), required: false);
            SourceExpression.Validate(width, nameof(width), required: false);
            SourceExpression.Validate(height, nameof(height), required: false);
            SourceExpression.Validate(backgroundColor, nameof(backgroundColor), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(fontFamily, nameof(fontFamily), required: false);
            SourceExpression.Validate(loadGoogleFonts, nameof(loadGoogleFonts), required: false);
            SourceExpression.Validate(fontScale, nameof(fontScale), required: false);
            SourceExpression.Validate(scale, nameof(scale), required: false);
            SourceExpression.Validate(padding, nameof(padding), required: false);
            SourceExpression.Validate(rotation, nameof(rotation), required: false);
            SourceExpression.Validate(maxNumWords, nameof(maxNumWords), required: false);
            SourceExpression.Validate(minWordLength, nameof(minWordLength), required: false);
            SourceExpression.Validate(@case, nameof(@case), required: false);
            SourceExpression.Validate(colors, nameof(colors), required: false);
            SourceExpression.Validate(removeStopwords, nameof(removeStopwords), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(useWordList, nameof(useWordList), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/wordcloud";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (width != null)
                    callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                if (height != null)
                    callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                if (backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = SourceExpressionConverter.ConvertO(backgroundColor);
                callPayload.Queries["format"] = Convert.ToString("svg");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["fontFamily"] = Convert.ToString("serif");
                if (fontFamily != null)
                    callPayload.Queries["fontFamily"] = SourceExpressionConverter.ConvertO(fontFamily);
                if (loadGoogleFonts != null)
                    callPayload.Queries["loadGoogleFonts"] = SourceExpressionConverter.ConvertO(loadGoogleFonts);
                callPayload.Queries["fontScale"] = Convert.ToString(25);
                if (fontScale != null)
                    callPayload.Queries["fontScale"] = SourceExpressionConverter.ConvertO(fontScale);
                callPayload.Queries["scale"] = Convert.ToString("linear");
                if (scale != null)
                    callPayload.Queries["scale"] = SourceExpressionConverter.Convert(scale);
                callPayload.Queries["padding"] = Convert.ToString(1);
                if (padding != null)
                    callPayload.Queries["padding"] = SourceExpressionConverter.ConvertO(padding);
                callPayload.Queries["rotation"] = Convert.ToString(20);
                if (rotation != null)
                    callPayload.Queries["rotation"] = SourceExpressionConverter.ConvertO(rotation);
                callPayload.Queries["maxNumWords"] = Convert.ToString(200);
                if (maxNumWords != null)
                    callPayload.Queries["maxNumWords"] = SourceExpressionConverter.ConvertO(maxNumWords);
                callPayload.Queries["minWordLength"] = Convert.ToString(1);
                if (minWordLength != null)
                    callPayload.Queries["minWordLength"] = SourceExpressionConverter.ConvertO(minWordLength);
                callPayload.Queries["case"] = Convert.ToString("lower");
                if (@case != null)
                    callPayload.Queries["case"] = SourceExpressionConverter.Convert(@case);
                callPayload.Queries["colors"] = Convert.ToString("random");
                if (colors != null)
                    callPayload.Queries["colors"] = SourceExpressionConverter.ConvertO(colors);
                callPayload.Queries["removeStopwords"] = Convert.ToString(false);
                if (removeStopwords != null)
                    callPayload.Queries["removeStopwords"] = SourceExpressionConverter.ConvertO(removeStopwords);
                callPayload.Queries["language"] = Convert.ToString("en");
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["useWordList"] = Convert.ToString(false);
                if (useWordList != null)
                    callPayload.Queries["useWordList"] = SourceExpressionConverter.ConvertO(useWordList);
                return callPayload;
            }

            return new ApiConnectionAction<WordCloudResponse>(BuildSourceInput);
        }
    }

    public class QuickchartipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChartPostResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum bodyformatInput
    {
        [EnumMember(Value = "svg")]
        Svg,
        [EnumMember(Value = "png")]
        Png
    }

    public enum bodyencodingInput
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "base64")]
        Base64
    }

    public class ChartURLResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ChartTemplateResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class QRCodeResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum ecLevelInput
    {
        L,
        M,
        Q,
        G
    }

    public enum formatInput
    {
        [EnumMember(Value = "svg")]
        Svg,
        [EnumMember(Value = "png")]
        Png
    }

    public class GraphVizResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum bodylayoutInput
    {
        [EnumMember(Value = "dot")]
        Dot,
        [EnumMember(Value = "fdp")]
        Fdp,
        [EnumMember(Value = "neato")]
        Neato,
        [EnumMember(Value = "circo")]
        Circo,
        [EnumMember(Value = "twopi")]
        Twopi,
        [EnumMember(Value = "osage")]
        Osage
    }

    public class WordCloudResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum scaleInput
    {
        [EnumMember(Value = "linear")]
        Linear,
        [EnumMember(Value = "sqrt")]
        Sqrt,
        [EnumMember(Value = "log")]
        Log
    }

    public enum @caseInput
    {
        [EnumMember(Value = "lower")]
        Lower,
        [EnumMember(Value = "upper")]
        Upper,
        [EnumMember(Value = "none")]
        None
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Quickchartip;

    public partial class WorkflowManagedActions
    {
        public QuickchartipActions Quickchartip(string connectionId) => new QuickchartipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public QuickchartipTriggers Quickchartip(string connectionId) => new QuickchartipTriggers(connectionId);
    }
}