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
        public IBodyWorkflowAction<string> AudioConvertToMp3([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(bitRate, nameof(bitRate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/mp3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = SourceExpressionConverter.ConvertO(bitRate);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToM4a([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(bitRate, nameof(bitRate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/m4a";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = SourceExpressionConverter.ConvertO(bitRate);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToAac([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(bitRate, nameof(bitRate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/aac";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = SourceExpressionConverter.ConvertO(bitRate);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> AudioConvertToWav([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<double> sampleRate = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(sampleRate, nameof(sampleRate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/wav";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (sampleRate != null)
                    callPayload.Headers["sampleRate"] = SourceExpressionConverter.ConvertO(sampleRate);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<MediaInformation> VideoGetInfo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/get-info";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                return callPayload;
            }

            return new ApiConnectionAction<MediaInformation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToWebm([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(quality, nameof(quality), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/webm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (preserveAspectRatio != null)
                    callPayload.Headers["preserveAspectRatio"] = SourceExpressionConverter.ConvertO(preserveAspectRatio);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (quality != null)
                    callPayload.Headers["quality"] = SourceExpressionConverter.ConvertO(quality);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToMov([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(quality, nameof(quality), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/mov";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (preserveAspectRatio != null)
                    callPayload.Headers["preserveAspectRatio"] = SourceExpressionConverter.ConvertO(preserveAspectRatio);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (quality != null)
                    callPayload.Headers["quality"] = SourceExpressionConverter.ConvertO(quality);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToMp4([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(quality, nameof(quality), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/mp4";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (preserveAspectRatio != null)
                    callPayload.Headers["preserveAspectRatio"] = SourceExpressionConverter.ConvertO(preserveAspectRatio);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (quality != null)
                    callPayload.Headers["quality"] = SourceExpressionConverter.ConvertO(quality);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoConvertToGif([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/gif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (preserveAspectRatio != null)
                    callPayload.Headers["preserveAspectRatio"] = SourceExpressionConverter.ConvertO(preserveAspectRatio);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (startTime != null)
                    callPayload.Headers["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (timeSpan != null)
                    callPayload.Headers["timeSpan"] = SourceExpressionConverter.ConvertO(timeSpan);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoResizeVideo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null, [WorkflowExpression] Func<string> extension = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(quality, nameof(quality), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/resize/preserveAspectRatio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (quality != null)
                    callPayload.Headers["quality"] = SourceExpressionConverter.ConvertO(quality);
                if (extension != null)
                    callPayload.Headers["extension"] = SourceExpressionConverter.ConvertO(extension);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoResizeVideoSimple([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null, [WorkflowExpression] Func<string> extension = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(frameRate, nameof(frameRate), required: false);
            SourceExpression.Validate(quality, nameof(quality), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/resize/target";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (frameRate != null)
                    callPayload.Headers["frameRate"] = SourceExpressionConverter.ConvertO(frameRate);
                if (quality != null)
                    callPayload.Headers["quality"] = SourceExpressionConverter.ConvertO(quality);
                if (extension != null)
                    callPayload.Headers["extension"] = SourceExpressionConverter.ConvertO(extension);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<string> VideoCutVideo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/cut";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (startTime != null)
                    callPayload.Headers["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (timeSpan != null)
                    callPayload.Headers["timeSpan"] = SourceExpressionConverter.ConvertO(timeSpan);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<SplitVideoResult> VideoSplitVideo([WorkflowExpression] Func<string> splitTime, [WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            SourceExpression.Validate(splitTime, nameof(splitTime), required: true);
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                callPayload.Headers["splitTime"] = SourceExpressionConverter.ConvertO(splitTime);
                if (timeSpan != null)
                    callPayload.Headers["timeSpan"] = SourceExpressionConverter.ConvertO(timeSpan);
                return callPayload;
            }

            return new ApiConnectionAction<SplitVideoResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<StillFramesResult> VideoConvertToStillFrames([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<double> framesPerSecond = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            SourceExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            SourceExpression.Validate(framesPerSecond, nameof(framesPerSecond), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/convert/to/still-frames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (maxWidth != null)
                    callPayload.Headers["maxWidth"] = SourceExpressionConverter.ConvertO(maxWidth);
                if (maxHeight != null)
                    callPayload.Headers["maxHeight"] = SourceExpressionConverter.ConvertO(maxHeight);
                if (framesPerSecond != null)
                    callPayload.Headers["framesPerSecond"] = SourceExpressionConverter.ConvertO(framesPerSecond);
                return callPayload;
            }

            return new ApiConnectionAction<StillFramesResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        public IBodyWorkflowAction<NsfwResult> VideoScanForNsfw([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<double> framesPerSecond = null)
        {
            SourceExpression.Validate(inputFile, nameof(inputFile), required: false);
            SourceExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            SourceExpression.Validate(framesPerSecond, nameof(framesPerSecond), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/video/scan/nsfw";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = SourceExpressionConverter.ConvertO(fileUrl);
                if (framesPerSecond != null)
                    callPayload.Headers["framesPerSecond"] = SourceExpressionConverter.ConvertO(framesPerSecond);
                return callPayload;
            }

            return new ApiConnectionAction<NsfwResult>(BuildSourceInput);
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