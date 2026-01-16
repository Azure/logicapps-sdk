//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivevideoandmedia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivevideoandmediaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToMp3(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> bitRate = null)
        {
            var apiCallPath = "/video/convert/to/mp3";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (bitRate != null)
                callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToM4a(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> bitRate = null)
        {
            var apiCallPath = "/video/convert/to/m4a";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (bitRate != null)
                callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToAac(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> bitRate = null)
        {
            var apiCallPath = "/video/convert/to/aac";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (bitRate != null)
                callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToWav(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<double>> sampleRate = null)
        {
            var apiCallPath = "/video/convert/to/wav";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (sampleRate != null)
                callPayload.Headers["sampleRate"] = ExpressionConverter.Convert(sampleRate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<MediaInformation> VideoGetInfo(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null)
        {
            var apiCallPath = "/video/convert/get-info";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            return new ApiConnectionAction<MediaInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToWebm(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<bool>> preserveAspectRatio = null, Expression<Func<int>> frameRate = null, Expression<Func<int>> quality = null)
        {
            var apiCallPath = "/video/convert/to/webm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (preserveAspectRatio != null)
                callPayload.Headers["preserveAspectRatio"] = ExpressionConverter.Convert(preserveAspectRatio);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (quality != null)
                callPayload.Headers["quality"] = ExpressionConverter.Convert(quality);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToMov(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<bool>> preserveAspectRatio = null, Expression<Func<int>> frameRate = null, Expression<Func<int>> quality = null)
        {
            var apiCallPath = "/video/convert/to/mov";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (preserveAspectRatio != null)
                callPayload.Headers["preserveAspectRatio"] = ExpressionConverter.Convert(preserveAspectRatio);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (quality != null)
                callPayload.Headers["quality"] = ExpressionConverter.Convert(quality);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToMp4(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<bool>> preserveAspectRatio = null, Expression<Func<int>> frameRate = null, Expression<Func<int>> quality = null)
        {
            var apiCallPath = "/video/convert/to/mp4";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (preserveAspectRatio != null)
                callPayload.Headers["preserveAspectRatio"] = ExpressionConverter.Convert(preserveAspectRatio);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (quality != null)
                callPayload.Headers["quality"] = ExpressionConverter.Convert(quality);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToGif(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<bool>> preserveAspectRatio = null, Expression<Func<int>> frameRate = null, Expression<Func<string>> startTime = null, Expression<Func<string>> timeSpan = null)
        {
            var apiCallPath = "/video/convert/to/gif";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (preserveAspectRatio != null)
                callPayload.Headers["preserveAspectRatio"] = ExpressionConverter.Convert(preserveAspectRatio);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (startTime != null)
                callPayload.Headers["startTime"] = ExpressionConverter.Convert(startTime);
            if (timeSpan != null)
                callPayload.Headers["timeSpan"] = ExpressionConverter.Convert(timeSpan);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoResizeVideo(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<int>> frameRate = null, Expression<Func<int>> quality = null, Expression<Func<string>> extension = null)
        {
            var apiCallPath = "/video/resize/preserveAspectRatio";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (quality != null)
                callPayload.Headers["quality"] = ExpressionConverter.Convert(quality);
            if (extension != null)
                callPayload.Headers["extension"] = ExpressionConverter.Convert(extension);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoResizeVideoSimple(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<int>> frameRate = null, Expression<Func<int>> quality = null, Expression<Func<string>> extension = null)
        {
            var apiCallPath = "/video/resize/target";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (frameRate != null)
                callPayload.Headers["frameRate"] = ExpressionConverter.Convert(frameRate);
            if (quality != null)
                callPayload.Headers["quality"] = ExpressionConverter.Convert(quality);
            if (extension != null)
                callPayload.Headers["extension"] = ExpressionConverter.Convert(extension);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoCutVideo(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<string>> startTime = null, Expression<Func<string>> timeSpan = null)
        {
            var apiCallPath = "/video/cut";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (startTime != null)
                callPayload.Headers["startTime"] = ExpressionConverter.Convert(startTime);
            if (timeSpan != null)
                callPayload.Headers["timeSpan"] = ExpressionConverter.Convert(timeSpan);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<SplitVideoResult> VideoSplitVideo(Expression<Func<string>> splitTime, Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<string>> timeSpan = null)
        {
            var apiCallPath = "/video/split";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            callPayload.Headers["splitTime"] = ExpressionConverter.Convert(splitTime);
            if (timeSpan != null)
                callPayload.Headers["timeSpan"] = ExpressionConverter.Convert(timeSpan);
            return new ApiConnectionAction<SplitVideoResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<StillFramesResult> VideoConvertToStillFrames(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<int>> maxWidth = null, Expression<Func<int>> maxHeight = null, Expression<Func<double>> framesPerSecond = null)
        {
            var apiCallPath = "/video/convert/to/still-frames";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (maxWidth != null)
                callPayload.Headers["maxWidth"] = ExpressionConverter.Convert(maxWidth);
            if (maxHeight != null)
                callPayload.Headers["maxHeight"] = ExpressionConverter.Convert(maxHeight);
            if (framesPerSecond != null)
                callPayload.Headers["framesPerSecond"] = ExpressionConverter.Convert(framesPerSecond);
            return new ApiConnectionAction<StillFramesResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<NsfwResult> VideoScanForNsfw(Expression<Func<object>> inputFile = null, Expression<Func<string>> fileUrl = null, Expression<Func<double>> framesPerSecond = null)
        {
            var apiCallPath = "/video/scan/nsfw";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fileUrl != null)
                callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
            if (framesPerSecond != null)
                callPayload.Headers["framesPerSecond"] = ExpressionConverter.Convert(framesPerSecond);
            return new ApiConnectionAction<NsfwResult>(callPayload);
        }
    }

    public class CloudmersivevideoandmediaTriggers([ConnectionName] string connectionId)
    {
    }

    public class MediaInformation
    {
        public bool Successful { get; set; }
        public string FileFormat { get; set; }
        public string FileFormatFull { get; set; }
        public string[] ValidFileFormats { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int BitRate { get; set; }
        public double Duration { get; set; }
        public double StartTime { get; set; }
    }

    public class SplitVideoResult
    {
        public bool Successful { get; set; }
        public VideoFile[] Videos { get; set; }
    }

    public class VideoFile
    {
        public int VideoNumber { get; set; }
        public string Content { get; set; }
    }

    public class StillFramesResult
    {
        public bool Successful { get; set; }
        public int TotalFrames { get; set; }
        public StillFrame[] StillFrames { get; set; }
    }

    public class StillFrame
    {
        public int FrameNumber { get; set; }
        public string TimeStamp { get; set; }
        public string Content { get; set; }
    }

    public class NsfwResult
    {
        public bool Successful { get; set; }
        public string HighestClassificationResult { get; set; }
        public double HighestScore { get; set; }
        public int TotalRacyFrames { get; set; }
        public int TotalNsfwFrames { get; set; }
        public int TotalFrames { get; set; }
        public NsfwScannedFrame[] NsfwScannedFrames { get; set; }
    }

    public class NsfwScannedFrame
    {
        public int FrameNumber { get; set; }
        public string TimeStamp { get; set; }
        public string Content { get; set; }
        public string ClassificationResult { get; set; }
        public double Score { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivevideoandmedia;

    public partial class WorkflowManagedActions
    {
        public CloudmersivevideoandmediaActions Cloudmersivevideoandmedia(string connectionId) => new CloudmersivevideoandmediaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivevideoandmediaTriggers Cloudmersivevideoandmedia(string connectionId) => new CloudmersivevideoandmediaTriggers(connectionId);
    }
}