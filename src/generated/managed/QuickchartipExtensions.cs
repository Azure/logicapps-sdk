//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Quickchartip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QuickchartipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildChart))]
        public IBodyWorkflowAction<ChartPostResponse> Chart([WorkflowExpression] Func<string> bodychart, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<string> bodydevicePixelRatio = null, [WorkflowExpression] Func<string> bodybackgroundColor = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyversion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChartPostResponse> __BuildChart(WorkflowValue<string> bodychart, WorkflowValue<int> bodywidth = null, WorkflowValue<int> bodyheight = null, WorkflowValue<string> bodydevicePixelRatio = null, WorkflowValue<string> bodybackgroundColor = null, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<bodyencodingInput> bodyencoding = null, WorkflowValue<string> bodyversion = null)
        {
            WorkflowValue.Validate(bodychart, nameof(bodychart), required: true);
            WorkflowValue.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowValue.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowValue.Validate(bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            WorkflowValue.Validate(bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowValue.Validate(bodyversion, nameof(bodyversion), required: false);
            return new DeferredBodyAction<ChartPostResponse>(() =>
            {
                var apiCallPath = "/chart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = ExpressionConverter.ConvertO(bodychart);
                if (bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyheight);
                    bodypropCount++;
                }

                if (bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = ExpressionConverter.ConvertO(bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (bodybackgroundColor != null)
                {
                    body["backgroundColor"] = ExpressionConverter.ConvertO(bodybackgroundColor);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(bodyformat);
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
                        body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
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
                    body["version"] = ExpressionConverter.ConvertO(bodyversion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChartPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildChartURL))]
        public IBodyWorkflowAction<ChartURLResponse> ChartURL([WorkflowExpression] Func<string> bodychart, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null, [WorkflowExpression] Func<string> bodydevicePixelRatio = null, [WorkflowExpression] Func<string> bodybackgroundColor = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bodyencodingInput> bodyencoding = null, [WorkflowExpression] Func<string> bodyversion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChartURLResponse> __BuildChartURL(WorkflowValue<string> bodychart, WorkflowValue<int> bodywidth = null, WorkflowValue<int> bodyheight = null, WorkflowValue<string> bodydevicePixelRatio = null, WorkflowValue<string> bodybackgroundColor = null, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<bodyencodingInput> bodyencoding = null, WorkflowValue<string> bodyversion = null)
        {
            WorkflowValue.Validate(bodychart, nameof(bodychart), required: true);
            WorkflowValue.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowValue.Validate(bodyheight, nameof(bodyheight), required: false);
            WorkflowValue.Validate(bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            WorkflowValue.Validate(bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodyencoding, nameof(bodyencoding), required: false);
            WorkflowValue.Validate(bodyversion, nameof(bodyversion), required: false);
            return new DeferredBodyAction<ChartURLResponse>(() =>
            {
                var apiCallPath = "/chart/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = ExpressionConverter.ConvertO(bodychart);
                if (bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyheight);
                    bodypropCount++;
                }

                if (bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = ExpressionConverter.ConvertO(bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (bodybackgroundColor != null)
                {
                    body["backgroundColor"] = ExpressionConverter.ConvertO(bodybackgroundColor);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(bodyformat);
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
                        body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
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
                    body["version"] = ExpressionConverter.ConvertO(bodyversion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChartURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildChartTemplate))]
        public IBodyWorkflowAction<ChartTemplateResponse> ChartTemplate([WorkflowExpression] Func<string> chartId, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> labels = null, [WorkflowExpression] Func<string> data1 = null, [WorkflowExpression] Func<string> data2 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChartTemplateResponse> __BuildChartTemplate(WorkflowValue<string> chartId, WorkflowValue<string> title = null, WorkflowValue<string> labels = null, WorkflowValue<string> data1 = null, WorkflowValue<string> data2 = null)
        {
            WorkflowValue.Validate(chartId, nameof(chartId), required: true);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(labels, nameof(labels), required: false);
            WorkflowValue.Validate(data1, nameof(data1), required: false);
            WorkflowValue.Validate(data2, nameof(data2), required: false);
            return new DeferredBodyAction<ChartTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chart/render/{0}", ExpressionConverter.ConvertWithUrlEncoding(chartId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                if (labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(labels);
                if (data1 != null)
                    callPayload.Queries["data1"] = ExpressionConverter.Convert(data1);
                if (data2 != null)
                    callPayload.Queries["data2"] = ExpressionConverter.Convert(data2);
                return new ApiConnectionAction<ChartTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildQRCode))]
        public IBodyWorkflowAction<QRCodeResponse> QRCode([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> margin = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> dark = null, [WorkflowExpression] Func<string> light = null, [WorkflowExpression] Func<ecLevelInput> ecLevel = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> centerImageUrl = null, [WorkflowExpression] Func<double> centerImageSizeRatio = null, [WorkflowExpression] Func<int> centerImageWidth = null, [WorkflowExpression] Func<int> centerImageHeight = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRCodeResponse> __BuildQRCode(WorkflowValue<string> text = null, WorkflowValue<int> margin = null, WorkflowValue<int> size = null, WorkflowValue<string> dark = null, WorkflowValue<string> light = null, WorkflowValue<ecLevelInput> ecLevel = null, WorkflowValue<formatInput> format = null, WorkflowValue<string> centerImageUrl = null, WorkflowValue<double> centerImageSizeRatio = null, WorkflowValue<int> centerImageWidth = null, WorkflowValue<int> centerImageHeight = null)
        {
            WorkflowValue.Validate(text, nameof(text), required: false);
            WorkflowValue.Validate(margin, nameof(margin), required: false);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(dark, nameof(dark), required: false);
            WorkflowValue.Validate(light, nameof(light), required: false);
            WorkflowValue.Validate(ecLevel, nameof(ecLevel), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(centerImageUrl, nameof(centerImageUrl), required: false);
            WorkflowValue.Validate(centerImageSizeRatio, nameof(centerImageSizeRatio), required: false);
            WorkflowValue.Validate(centerImageWidth, nameof(centerImageWidth), required: false);
            WorkflowValue.Validate(centerImageHeight, nameof(centerImageHeight), required: false);
            return new DeferredBodyAction<QRCodeResponse>(() =>
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                callPayload.Queries["margin"] = Convert.ToString(4);
                if (margin != null)
                    callPayload.Queries["margin"] = ExpressionConverter.Convert(margin);
                callPayload.Queries["size"] = Convert.ToString(150);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                if (dark != null)
                    callPayload.Queries["dark"] = ExpressionConverter.Convert(dark);
                callPayload.Queries["light"] = Convert.ToString("ffffff");
                if (light != null)
                    callPayload.Queries["light"] = ExpressionConverter.Convert(light);
                callPayload.Queries["ecLevel"] = Convert.ToString("M");
                if (ecLevel != null)
                    callPayload.Queries["ecLevel"] = ExpressionConverter.Convert(ecLevel);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (centerImageUrl != null)
                    callPayload.Queries["centerImageUrl"] = ExpressionConverter.Convert(centerImageUrl);
                callPayload.Queries["centerImageSizeRatio"] = Convert.ToString(0.3);
                if (centerImageSizeRatio != null)
                    callPayload.Queries["centerImageSizeRatio"] = ExpressionConverter.Convert(centerImageSizeRatio);
                if (centerImageWidth != null)
                    callPayload.Queries["centerImageWidth"] = ExpressionConverter.Convert(centerImageWidth);
                if (centerImageHeight != null)
                    callPayload.Queries["centerImageHeight"] = ExpressionConverter.Convert(centerImageHeight);
                return new ApiConnectionAction<QRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildGraphViz))]
        public IBodyWorkflowAction<GraphVizResponse> GraphViz([WorkflowExpression] Func<string> bodygraph, [WorkflowExpression] Func<bodylayoutInput> bodylayout = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphVizResponse> __BuildGraphViz(WorkflowValue<string> bodygraph, WorkflowValue<bodylayoutInput> bodylayout = null, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<int> bodywidth = null, WorkflowValue<int> bodyheight = null)
        {
            WorkflowValue.Validate(bodygraph, nameof(bodygraph), required: true);
            WorkflowValue.Validate(bodylayout, nameof(bodylayout), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowValue.Validate(bodyheight, nameof(bodyheight), required: false);
            return new DeferredBodyAction<GraphVizResponse>(() =>
            {
                var apiCallPath = "/graphviz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["graph"] = ExpressionConverter.ConvertO(bodygraph);
                if (bodylayout != null)
                {
                    if (bodylayout != null)
                    {
                        body["layout"] = ExpressionConverter.ConvertO(bodylayout);
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
                        body["format"] = ExpressionConverter.ConvertO(bodyformat);
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
                    body["width"] = ExpressionConverter.ConvertO(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyheight);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GraphVizResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        [WorkflowExpressionFactory(nameof(__BuildWordCloud))]
        public IBodyWorkflowAction<WordCloudResponse> WordCloud([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> fontFamily = null, [WorkflowExpression] Func<string> loadGoogleFonts = null, [WorkflowExpression] Func<int> fontScale = null, [WorkflowExpression] Func<scaleInput> scale = null, [WorkflowExpression] Func<int> padding = null, [WorkflowExpression] Func<int> rotation = null, [WorkflowExpression] Func<int> maxNumWords = null, [WorkflowExpression] Func<int> minWordLength = null, [WorkflowExpression] Func<@caseInput> @case = null, [WorkflowExpression] Func<string> colors = null, [WorkflowExpression] Func<bool> removeStopwords = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> useWordList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WordCloudResponse> __BuildWordCloud(WorkflowValue<string> text = null, WorkflowValue<int> width = null, WorkflowValue<int> height = null, WorkflowValue<string> backgroundColor = null, WorkflowValue<formatInput> format = null, WorkflowValue<string> fontFamily = null, WorkflowValue<string> loadGoogleFonts = null, WorkflowValue<int> fontScale = null, WorkflowValue<scaleInput> scale = null, WorkflowValue<int> padding = null, WorkflowValue<int> rotation = null, WorkflowValue<int> maxNumWords = null, WorkflowValue<int> minWordLength = null, WorkflowValue<@caseInput> @case = null, WorkflowValue<string> colors = null, WorkflowValue<bool> removeStopwords = null, WorkflowValue<string> language = null, WorkflowValue<bool> useWordList = null)
        {
            WorkflowValue.Validate(text, nameof(text), required: false);
            WorkflowValue.Validate(width, nameof(width), required: false);
            WorkflowValue.Validate(height, nameof(height), required: false);
            WorkflowValue.Validate(backgroundColor, nameof(backgroundColor), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(fontFamily, nameof(fontFamily), required: false);
            WorkflowValue.Validate(loadGoogleFonts, nameof(loadGoogleFonts), required: false);
            WorkflowValue.Validate(fontScale, nameof(fontScale), required: false);
            WorkflowValue.Validate(scale, nameof(scale), required: false);
            WorkflowValue.Validate(padding, nameof(padding), required: false);
            WorkflowValue.Validate(rotation, nameof(rotation), required: false);
            WorkflowValue.Validate(maxNumWords, nameof(maxNumWords), required: false);
            WorkflowValue.Validate(minWordLength, nameof(minWordLength), required: false);
            WorkflowValue.Validate(@case, nameof(@case), required: false);
            WorkflowValue.Validate(colors, nameof(colors), required: false);
            WorkflowValue.Validate(removeStopwords, nameof(removeStopwords), required: false);
            WorkflowValue.Validate(language, nameof(language), required: false);
            WorkflowValue.Validate(useWordList, nameof(useWordList), required: false);
            return new DeferredBodyAction<WordCloudResponse>(() =>
            {
                var apiCallPath = "/wordcloud";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                if (width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(width);
                if (height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(height);
                if (backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(backgroundColor);
                callPayload.Queries["format"] = Convert.ToString("svg");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Queries["fontFamily"] = Convert.ToString("serif");
                if (fontFamily != null)
                    callPayload.Queries["fontFamily"] = ExpressionConverter.Convert(fontFamily);
                if (loadGoogleFonts != null)
                    callPayload.Queries["loadGoogleFonts"] = ExpressionConverter.Convert(loadGoogleFonts);
                callPayload.Queries["fontScale"] = Convert.ToString(25);
                if (fontScale != null)
                    callPayload.Queries["fontScale"] = ExpressionConverter.Convert(fontScale);
                callPayload.Queries["scale"] = Convert.ToString("linear");
                if (scale != null)
                    callPayload.Queries["scale"] = ExpressionConverter.Convert(scale);
                callPayload.Queries["padding"] = Convert.ToString(1);
                if (padding != null)
                    callPayload.Queries["padding"] = ExpressionConverter.Convert(padding);
                callPayload.Queries["rotation"] = Convert.ToString(20);
                if (rotation != null)
                    callPayload.Queries["rotation"] = ExpressionConverter.Convert(rotation);
                callPayload.Queries["maxNumWords"] = Convert.ToString(200);
                if (maxNumWords != null)
                    callPayload.Queries["maxNumWords"] = ExpressionConverter.Convert(maxNumWords);
                callPayload.Queries["minWordLength"] = Convert.ToString(1);
                if (minWordLength != null)
                    callPayload.Queries["minWordLength"] = ExpressionConverter.Convert(minWordLength);
                callPayload.Queries["case"] = Convert.ToString("lower");
                if (@case != null)
                    callPayload.Queries["case"] = ExpressionConverter.Convert(@case);
                callPayload.Queries["colors"] = Convert.ToString("random");
                if (colors != null)
                    callPayload.Queries["colors"] = ExpressionConverter.Convert(colors);
                callPayload.Queries["removeStopwords"] = Convert.ToString(false);
                if (removeStopwords != null)
                    callPayload.Queries["removeStopwords"] = ExpressionConverter.Convert(removeStopwords);
                callPayload.Queries["language"] = Convert.ToString("en");
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["useWordList"] = Convert.ToString(false);
                if (useWordList != null)
                    callPayload.Queries["useWordList"] = ExpressionConverter.Convert(useWordList);
                return new ApiConnectionAction<WordCloudResponse>(callPayload);
            });
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
