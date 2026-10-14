//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Quickchartip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class QuickchartipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartPostResponse> Chart(Expression<Func<string>> bodychart, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null, Expression<Func<string>> bodydevicePixelRatio = null, Expression<Func<string>> bodybackgroundColor = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyversion = null)
        {
            var __workflow_bodychart = bodychart == null ? null : WorkflowExpression.Compile(bodychart);
            WorkflowExpression.Validate(__workflow_bodychart, nameof(bodychart), required: true);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodydevicePixelRatio = bodydevicePixelRatio == null ? null : WorkflowExpression.Compile(bodydevicePixelRatio);
            WorkflowExpression.Validate(__workflow_bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            var __workflow_bodybackgroundColor = bodybackgroundColor == null ? null : WorkflowExpression.Compile(bodybackgroundColor);
            WorkflowExpression.Validate(__workflow_bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            var __workflow_bodyformat = bodyformat == null ? null : WorkflowExpression.Compile(bodyformat);
            WorkflowExpression.Validate(__workflow_bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyencoding = bodyencoding == null ? null : WorkflowExpression.Compile(bodyencoding);
            WorkflowExpression.Validate(__workflow_bodyencoding, nameof(bodyencoding), required: false);
            var __workflow_bodyversion = bodyversion == null ? null : WorkflowExpression.Compile(bodyversion);
            WorkflowExpression.Validate(__workflow_bodyversion, nameof(bodyversion), required: false);
            return new DeferredBodyAction<ChartPostResponse>(() =>
            {
                var apiCallPath = "/chart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = ExpressionConverter.ConvertO(__workflow_bodychart);
                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = ExpressionConverter.ConvertO(__workflow_bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (__workflow_bodybackgroundColor != null)
                {
                    body["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_bodybackgroundColor);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    if (__workflow_bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "png";
                    bodypropCount++;
                }

                if (__workflow_bodyencoding != null)
                {
                    if (__workflow_bodyencoding != null)
                    {
                        body["encoding"] = ExpressionConverter.ConvertO(__workflow_bodyencoding);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["encoding"] = "url";
                    bodypropCount++;
                }

                if (__workflow_bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
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
        public IBodyWorkflowAction<ChartURLResponse> ChartURL(Expression<Func<string>> bodychart, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null, Expression<Func<string>> bodydevicePixelRatio = null, Expression<Func<string>> bodybackgroundColor = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyversion = null)
        {
            var __workflow_bodychart = bodychart == null ? null : WorkflowExpression.Compile(bodychart);
            WorkflowExpression.Validate(__workflow_bodychart, nameof(bodychart), required: true);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            var __workflow_bodydevicePixelRatio = bodydevicePixelRatio == null ? null : WorkflowExpression.Compile(bodydevicePixelRatio);
            WorkflowExpression.Validate(__workflow_bodydevicePixelRatio, nameof(bodydevicePixelRatio), required: false);
            var __workflow_bodybackgroundColor = bodybackgroundColor == null ? null : WorkflowExpression.Compile(bodybackgroundColor);
            WorkflowExpression.Validate(__workflow_bodybackgroundColor, nameof(bodybackgroundColor), required: false);
            var __workflow_bodyformat = bodyformat == null ? null : WorkflowExpression.Compile(bodyformat);
            WorkflowExpression.Validate(__workflow_bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyencoding = bodyencoding == null ? null : WorkflowExpression.Compile(bodyencoding);
            WorkflowExpression.Validate(__workflow_bodyencoding, nameof(bodyencoding), required: false);
            var __workflow_bodyversion = bodyversion == null ? null : WorkflowExpression.Compile(bodyversion);
            WorkflowExpression.Validate(__workflow_bodyversion, nameof(bodyversion), required: false);
            return new DeferredBodyAction<ChartURLResponse>(() =>
            {
                var apiCallPath = "/chart/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["chart"] = ExpressionConverter.ConvertO(__workflow_bodychart);
                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                    bodypropCount++;
                }

                if (__workflow_bodydevicePixelRatio != null)
                {
                    body["devicePixelRatio"] = ExpressionConverter.ConvertO(__workflow_bodydevicePixelRatio);
                    bodypropCount++;
                }

                if (__workflow_bodybackgroundColor != null)
                {
                    body["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_bodybackgroundColor);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    if (__workflow_bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "png";
                    bodypropCount++;
                }

                if (__workflow_bodyencoding != null)
                {
                    if (__workflow_bodyencoding != null)
                    {
                        body["encoding"] = ExpressionConverter.ConvertO(__workflow_bodyencoding);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["encoding"] = "url";
                    bodypropCount++;
                }

                if (__workflow_bodyversion != null)
                {
                    body["version"] = ExpressionConverter.ConvertO(__workflow_bodyversion);
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
        public IBodyWorkflowAction<ChartTemplateResponse> ChartTemplate(Expression<Func<string>> chartId, Expression<Func<string>> title = null, Expression<Func<string>> labels = null, Expression<Func<string>> data1 = null, Expression<Func<string>> data2 = null)
        {
            var __workflow_chartId = chartId == null ? null : WorkflowExpression.Compile(chartId);
            WorkflowExpression.Validate(__workflow_chartId, nameof(chartId), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_labels = labels == null ? null : WorkflowExpression.Compile(labels);
            WorkflowExpression.Validate(__workflow_labels, nameof(labels), required: false);
            var __workflow_data1 = data1 == null ? null : WorkflowExpression.Compile(data1);
            WorkflowExpression.Validate(__workflow_data1, nameof(data1), required: false);
            var __workflow_data2 = data2 == null ? null : WorkflowExpression.Compile(data2);
            WorkflowExpression.Validate(__workflow_data2, nameof(data2), required: false);
            return new DeferredBodyAction<ChartTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chart/render/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_chartId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(__workflow_labels);
                if (__workflow_data1 != null)
                    callPayload.Queries["data1"] = ExpressionConverter.Convert(__workflow_data1);
                if (__workflow_data2 != null)
                    callPayload.Queries["data2"] = ExpressionConverter.Convert(__workflow_data2);
                return new ApiConnectionAction<ChartTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<QRCodeResponse> QRCode(Expression<Func<string>> text = null, Expression<Func<int>> margin = null, Expression<Func<int>> size = null, Expression<Func<string>> dark = null, Expression<Func<string>> light = null, Expression<Func<ecLevelInput>> ecLevel = null, Expression<Func<formatInput>> format = null, Expression<Func<string>> centerImageUrl = null, Expression<Func<double>> centerImageSizeRatio = null, Expression<Func<int>> centerImageWidth = null, Expression<Func<int>> centerImageHeight = null)
        {
            var __workflow_text = text == null ? null : WorkflowExpression.Compile(text);
            WorkflowExpression.Validate(__workflow_text, nameof(text), required: false);
            var __workflow_margin = margin == null ? null : WorkflowExpression.Compile(margin);
            WorkflowExpression.Validate(__workflow_margin, nameof(margin), required: false);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: false);
            var __workflow_dark = dark == null ? null : WorkflowExpression.Compile(dark);
            WorkflowExpression.Validate(__workflow_dark, nameof(dark), required: false);
            var __workflow_light = light == null ? null : WorkflowExpression.Compile(light);
            WorkflowExpression.Validate(__workflow_light, nameof(light), required: false);
            var __workflow_ecLevel = ecLevel == null ? null : WorkflowExpression.Compile(ecLevel);
            WorkflowExpression.Validate(__workflow_ecLevel, nameof(ecLevel), required: false);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_centerImageUrl = centerImageUrl == null ? null : WorkflowExpression.Compile(centerImageUrl);
            WorkflowExpression.Validate(__workflow_centerImageUrl, nameof(centerImageUrl), required: false);
            var __workflow_centerImageSizeRatio = centerImageSizeRatio == null ? null : WorkflowExpression.Compile(centerImageSizeRatio);
            WorkflowExpression.Validate(__workflow_centerImageSizeRatio, nameof(centerImageSizeRatio), required: false);
            var __workflow_centerImageWidth = centerImageWidth == null ? null : WorkflowExpression.Compile(centerImageWidth);
            WorkflowExpression.Validate(__workflow_centerImageWidth, nameof(centerImageWidth), required: false);
            var __workflow_centerImageHeight = centerImageHeight == null ? null : WorkflowExpression.Compile(centerImageHeight);
            WorkflowExpression.Validate(__workflow_centerImageHeight, nameof(centerImageHeight), required: false);
            return new DeferredBodyAction<QRCodeResponse>(() =>
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                callPayload.Queries["margin"] = Convert.ToString(4);
                if (__workflow_margin != null)
                    callPayload.Queries["margin"] = ExpressionConverter.Convert(__workflow_margin);
                callPayload.Queries["size"] = Convert.ToString(150);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_dark != null)
                    callPayload.Queries["dark"] = ExpressionConverter.Convert(__workflow_dark);
                callPayload.Queries["light"] = Convert.ToString("ffffff");
                if (__workflow_light != null)
                    callPayload.Queries["light"] = ExpressionConverter.Convert(__workflow_light);
                callPayload.Queries["ecLevel"] = Convert.ToString("M");
                if (__workflow_ecLevel != null)
                    callPayload.Queries["ecLevel"] = ExpressionConverter.Convert(__workflow_ecLevel);
                callPayload.Queries["format"] = Convert.ToString("png");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_centerImageUrl != null)
                    callPayload.Queries["centerImageUrl"] = ExpressionConverter.Convert(__workflow_centerImageUrl);
                callPayload.Queries["centerImageSizeRatio"] = Convert.ToString(0.3);
                if (__workflow_centerImageSizeRatio != null)
                    callPayload.Queries["centerImageSizeRatio"] = ExpressionConverter.Convert(__workflow_centerImageSizeRatio);
                if (__workflow_centerImageWidth != null)
                    callPayload.Queries["centerImageWidth"] = ExpressionConverter.Convert(__workflow_centerImageWidth);
                if (__workflow_centerImageHeight != null)
                    callPayload.Queries["centerImageHeight"] = ExpressionConverter.Convert(__workflow_centerImageHeight);
                return new ApiConnectionAction<QRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<GraphVizResponse> GraphViz(Expression<Func<string>> bodygraph, Expression<Func<bodylayoutInput>> bodylayout = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null)
        {
            var __workflow_bodygraph = bodygraph == null ? null : WorkflowExpression.Compile(bodygraph);
            WorkflowExpression.Validate(__workflow_bodygraph, nameof(bodygraph), required: true);
            var __workflow_bodylayout = bodylayout == null ? null : WorkflowExpression.Compile(bodylayout);
            WorkflowExpression.Validate(__workflow_bodylayout, nameof(bodylayout), required: false);
            var __workflow_bodyformat = bodyformat == null ? null : WorkflowExpression.Compile(bodyformat);
            WorkflowExpression.Validate(__workflow_bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodywidth = bodywidth == null ? null : WorkflowExpression.Compile(bodywidth);
            WorkflowExpression.Validate(__workflow_bodywidth, nameof(bodywidth), required: false);
            var __workflow_bodyheight = bodyheight == null ? null : WorkflowExpression.Compile(bodyheight);
            WorkflowExpression.Validate(__workflow_bodyheight, nameof(bodyheight), required: false);
            return new DeferredBodyAction<GraphVizResponse>(() =>
            {
                var apiCallPath = "/graphviz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["graph"] = ExpressionConverter.ConvertO(__workflow_bodygraph);
                if (__workflow_bodylayout != null)
                {
                    if (__workflow_bodylayout != null)
                    {
                        body["layout"] = ExpressionConverter.ConvertO(__workflow_bodylayout);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["layout"] = "dot";
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    if (__workflow_bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "svg";
                    bodypropCount++;
                }

                if (__workflow_bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                    bodypropCount++;
                }

                if (__workflow_bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
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
        public IBodyWorkflowAction<WordCloudResponse> WordCloud(Expression<Func<string>> text = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> backgroundColor = null, Expression<Func<formatInput>> format = null, Expression<Func<string>> fontFamily = null, Expression<Func<string>> loadGoogleFonts = null, Expression<Func<int>> fontScale = null, Expression<Func<scaleInput>> scale = null, Expression<Func<int>> padding = null, Expression<Func<int>> rotation = null, Expression<Func<int>> maxNumWords = null, Expression<Func<int>> minWordLength = null, Expression<Func<@caseInput>> @case = null, Expression<Func<string>> colors = null, Expression<Func<bool>> removeStopwords = null, Expression<Func<string>> language = null, Expression<Func<bool>> useWordList = null)
        {
            var __workflow_text = text == null ? null : WorkflowExpression.Compile(text);
            WorkflowExpression.Validate(__workflow_text, nameof(text), required: false);
            var __workflow_width = width == null ? null : WorkflowExpression.Compile(width);
            WorkflowExpression.Validate(__workflow_width, nameof(width), required: false);
            var __workflow_height = height == null ? null : WorkflowExpression.Compile(height);
            WorkflowExpression.Validate(__workflow_height, nameof(height), required: false);
            var __workflow_backgroundColor = backgroundColor == null ? null : WorkflowExpression.Compile(backgroundColor);
            WorkflowExpression.Validate(__workflow_backgroundColor, nameof(backgroundColor), required: false);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_fontFamily = fontFamily == null ? null : WorkflowExpression.Compile(fontFamily);
            WorkflowExpression.Validate(__workflow_fontFamily, nameof(fontFamily), required: false);
            var __workflow_loadGoogleFonts = loadGoogleFonts == null ? null : WorkflowExpression.Compile(loadGoogleFonts);
            WorkflowExpression.Validate(__workflow_loadGoogleFonts, nameof(loadGoogleFonts), required: false);
            var __workflow_fontScale = fontScale == null ? null : WorkflowExpression.Compile(fontScale);
            WorkflowExpression.Validate(__workflow_fontScale, nameof(fontScale), required: false);
            var __workflow_scale = scale == null ? null : WorkflowExpression.Compile(scale);
            WorkflowExpression.Validate(__workflow_scale, nameof(scale), required: false);
            var __workflow_padding = padding == null ? null : WorkflowExpression.Compile(padding);
            WorkflowExpression.Validate(__workflow_padding, nameof(padding), required: false);
            var __workflow_rotation = rotation == null ? null : WorkflowExpression.Compile(rotation);
            WorkflowExpression.Validate(__workflow_rotation, nameof(rotation), required: false);
            var __workflow_maxNumWords = maxNumWords == null ? null : WorkflowExpression.Compile(maxNumWords);
            WorkflowExpression.Validate(__workflow_maxNumWords, nameof(maxNumWords), required: false);
            var __workflow_minWordLength = minWordLength == null ? null : WorkflowExpression.Compile(minWordLength);
            WorkflowExpression.Validate(__workflow_minWordLength, nameof(minWordLength), required: false);
            var __workflow_case = @case == null ? null : WorkflowExpression.Compile(@case);
            WorkflowExpression.Validate(__workflow_case, nameof(@case), required: false);
            var __workflow_colors = colors == null ? null : WorkflowExpression.Compile(colors);
            WorkflowExpression.Validate(__workflow_colors, nameof(colors), required: false);
            var __workflow_removeStopwords = removeStopwords == null ? null : WorkflowExpression.Compile(removeStopwords);
            WorkflowExpression.Validate(__workflow_removeStopwords, nameof(removeStopwords), required: false);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            var __workflow_useWordList = useWordList == null ? null : WorkflowExpression.Compile(useWordList);
            WorkflowExpression.Validate(__workflow_useWordList, nameof(useWordList), required: false);
            return new DeferredBodyAction<WordCloudResponse>(() =>
            {
                var apiCallPath = "/wordcloud";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                if (__workflow_backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(__workflow_backgroundColor);
                callPayload.Queries["format"] = Convert.ToString("svg");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["fontFamily"] = Convert.ToString("serif");
                if (__workflow_fontFamily != null)
                    callPayload.Queries["fontFamily"] = ExpressionConverter.Convert(__workflow_fontFamily);
                if (__workflow_loadGoogleFonts != null)
                    callPayload.Queries["loadGoogleFonts"] = ExpressionConverter.Convert(__workflow_loadGoogleFonts);
                callPayload.Queries["fontScale"] = Convert.ToString(25);
                if (__workflow_fontScale != null)
                    callPayload.Queries["fontScale"] = ExpressionConverter.Convert(__workflow_fontScale);
                callPayload.Queries["scale"] = Convert.ToString("linear");
                if (__workflow_scale != null)
                    callPayload.Queries["scale"] = ExpressionConverter.Convert(__workflow_scale);
                callPayload.Queries["padding"] = Convert.ToString(1);
                if (__workflow_padding != null)
                    callPayload.Queries["padding"] = ExpressionConverter.Convert(__workflow_padding);
                callPayload.Queries["rotation"] = Convert.ToString(20);
                if (__workflow_rotation != null)
                    callPayload.Queries["rotation"] = ExpressionConverter.Convert(__workflow_rotation);
                callPayload.Queries["maxNumWords"] = Convert.ToString(200);
                if (__workflow_maxNumWords != null)
                    callPayload.Queries["maxNumWords"] = ExpressionConverter.Convert(__workflow_maxNumWords);
                callPayload.Queries["minWordLength"] = Convert.ToString(1);
                if (__workflow_minWordLength != null)
                    callPayload.Queries["minWordLength"] = ExpressionConverter.Convert(__workflow_minWordLength);
                callPayload.Queries["case"] = Convert.ToString("lower");
                if (__workflow_case != null)
                    callPayload.Queries["case"] = ExpressionConverter.Convert(__workflow_case);
                callPayload.Queries["colors"] = Convert.ToString("random");
                if (__workflow_colors != null)
                    callPayload.Queries["colors"] = ExpressionConverter.Convert(__workflow_colors);
                callPayload.Queries["removeStopwords"] = Convert.ToString(false);
                if (__workflow_removeStopwords != null)
                    callPayload.Queries["removeStopwords"] = ExpressionConverter.Convert(__workflow_removeStopwords);
                callPayload.Queries["language"] = Convert.ToString("en");
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["useWordList"] = Convert.ToString(false);
                if (__workflow_useWordList != null)
                    callPayload.Queries["useWordList"] = ExpressionConverter.Convert(__workflow_useWordList);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyformatInput
    {
        [EnumMember(Value = "svg")]
        Svg,
        [EnumMember(Value = "png")]
        Png
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ecLevelInput
    {
        L,
        M,
        Q,
        G
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum scaleInput
    {
        [EnumMember(Value = "linear")]
        Linear,
        [EnumMember(Value = "sqrt")]
        Sqrt,
        [EnumMember(Value = "log")]
        Log
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
