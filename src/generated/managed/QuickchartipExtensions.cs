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
        public IBodyWorkflowAction<ChartPostResponse> ChartPost(Expression<Func<string>> bodychart, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null, Expression<Func<string>> bodydevicePixelRatio = null, Expression<Func<string>> bodybackgroundColor = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyversion = null)
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
                body["format"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodyencoding != null)
            {
                body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartURLResponse> ChartURL(Expression<Func<string>> bodychart, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null, Expression<Func<string>> bodydevicePixelRatio = null, Expression<Func<string>> bodybackgroundColor = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<bodyencodingInput>> bodyencoding = null, Expression<Func<string>> bodyversion = null)
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
                body["format"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodyencoding != null)
            {
                body["encoding"] = ExpressionConverter.ConvertO(bodyencoding);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<ChartTemplateResponse> ChartTemplate(Expression<Func<string>> chartId, Expression<Func<string>> title = null, Expression<Func<string>> labels = null, Expression<Func<string>> data1 = null, Expression<Func<string>> data2 = null)
        {
            var apiCallPath = String.Format("/chart/render/{0}", ExpressionConverter.ConvertWithUrlEncoding(chartId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<QRCodeResponse> QRCode(Expression<Func<string>> text = null, Expression<Func<int>> margin = null, Expression<Func<int>> size = null, Expression<Func<string>> dark = null, Expression<Func<string>> light = null, Expression<Func<ecLevelInput>> ecLevel = null, Expression<Func<formatInput>> format = null, Expression<Func<string>> centerImageUrl = null, Expression<Func<double>> centerImageSizeRatio = null, Expression<Func<int>> centerImageWidth = null, Expression<Func<int>> centerImageHeight = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<GraphVizResponse> GraphViz(Expression<Func<string>> bodygraph, Expression<Func<bodylayoutInput>> bodylayout = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<int>> bodywidth = null, Expression<Func<int>> bodyheight = null)
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
                body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["format"] = ExpressionConverter.ConvertO(bodyformat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "quickchartip")]
        public IBodyWorkflowAction<WordCloudResponse> WordCloud(Expression<Func<string>> text = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> backgroundColor = null, Expression<Func<formatInput>> format = null, Expression<Func<string>> fontFamily = null, Expression<Func<string>> loadGoogleFonts = null, Expression<Func<int>> fontScale = null, Expression<Func<scaleInput>> scale = null, Expression<Func<int>> padding = null, Expression<Func<int>> rotation = null, Expression<Func<int>> maxNumWords = null, Expression<Func<int>> minWordLength = null, Expression<Func<@caseInput>> @case = null, Expression<Func<string>> colors = null, Expression<Func<bool>> removeStopwords = null, Expression<Func<string>> language = null, Expression<Func<bool>> useWordList = null)
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