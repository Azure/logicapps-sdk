//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivevideoandmedia
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivevideoandmediaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildAudioConvertToMp3))]
        public IBodyWorkflowAction<string> AudioConvertToMp3([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudioConvertToMp3(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> bitRate = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(bitRate, nameof(bitRate), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/video/convert/to/mp3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildAudioConvertToM4a))]
        public IBodyWorkflowAction<string> AudioConvertToM4a([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudioConvertToM4a(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> bitRate = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(bitRate, nameof(bitRate), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/video/convert/to/m4a";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildAudioConvertToAac))]
        public IBodyWorkflowAction<string> AudioConvertToAac([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> bitRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudioConvertToAac(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> bitRate = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(bitRate, nameof(bitRate), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/video/convert/to/aac";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                if (bitRate != null)
                    callPayload.Headers["bitRate"] = ExpressionConverter.Convert(bitRate);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildAudioConvertToWav))]
        public IBodyWorkflowAction<string> AudioConvertToWav([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<double> sampleRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudioConvertToWav(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<double> sampleRate = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(sampleRate, nameof(sampleRate), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/video/convert/to/wav";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                if (sampleRate != null)
                    callPayload.Headers["sampleRate"] = ExpressionConverter.Convert(sampleRate);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoGetInfo))]
        public IBodyWorkflowAction<MediaInformation> VideoGetInfo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MediaInformation> __BuildVideoGetInfo(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            return new DeferredBodyAction<MediaInformation>(() =>
            {
                var apiCallPath = "/video/convert/get-info";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                return new ApiConnectionAction<MediaInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoConvertToWebm))]
        public IBodyWorkflowAction<string> VideoConvertToWebm([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoConvertToWebm(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<bool> preserveAspectRatio = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<int> quality = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(quality, nameof(quality), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoConvertToMov))]
        public IBodyWorkflowAction<string> VideoConvertToMov([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoConvertToMov(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<bool> preserveAspectRatio = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<int> quality = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(quality, nameof(quality), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoConvertToMp4))]
        public IBodyWorkflowAction<string> VideoConvertToMp4([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoConvertToMp4(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<bool> preserveAspectRatio = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<int> quality = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(quality, nameof(quality), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoConvertToGif))]
        public IBodyWorkflowAction<string> VideoConvertToGif([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<bool> preserveAspectRatio = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoConvertToGif(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<bool> preserveAspectRatio = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<string> startTime = null, WorkflowExpression<string> timeSpan = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(preserveAspectRatio, nameof(preserveAspectRatio), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoResizeVideo))]
        public IBodyWorkflowAction<string> VideoResizeVideo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null, [WorkflowExpression] Func<string> extension = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoResizeVideo(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<int> quality = null, WorkflowExpression<string> extension = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(quality, nameof(quality), required: false);
            WorkflowExpression.Validate(extension, nameof(extension), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoResizeVideoSimple))]
        public IBodyWorkflowAction<string> VideoResizeVideoSimple([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<int> frameRate = null, [WorkflowExpression] Func<int> quality = null, [WorkflowExpression] Func<string> extension = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoResizeVideoSimple(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<int> frameRate = null, WorkflowExpression<int> quality = null, WorkflowExpression<string> extension = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(frameRate, nameof(frameRate), required: false);
            WorkflowExpression.Validate(quality, nameof(quality), required: false);
            WorkflowExpression.Validate(extension, nameof(extension), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoCutVideo))]
        public IBodyWorkflowAction<string> VideoCutVideo([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVideoCutVideo(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<string> startTime = null, WorkflowExpression<string> timeSpan = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoSplitVideo))]
        public IBodyWorkflowAction<SplitVideoResult> VideoSplitVideo([WorkflowExpression] Func<string> splitTime, [WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<string> timeSpan = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SplitVideoResult> __BuildVideoSplitVideo(WorkflowExpression<string> splitTime, WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<string> timeSpan = null)
        {
            WorkflowExpression.Validate(splitTime, nameof(splitTime), required: true);
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(timeSpan, nameof(timeSpan), required: false);
            return new DeferredBodyAction<SplitVideoResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoConvertToStillFrames))]
        public IBodyWorkflowAction<StillFramesResult> VideoConvertToStillFrames([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<int> maxWidth = null, [WorkflowExpression] Func<int> maxHeight = null, [WorkflowExpression] Func<double> framesPerSecond = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StillFramesResult> __BuildVideoConvertToStillFrames(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<int> maxWidth = null, WorkflowExpression<int> maxHeight = null, WorkflowExpression<double> framesPerSecond = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(maxWidth, nameof(maxWidth), required: false);
            WorkflowExpression.Validate(maxHeight, nameof(maxHeight), required: false);
            WorkflowExpression.Validate(framesPerSecond, nameof(framesPerSecond), required: false);
            return new DeferredBodyAction<StillFramesResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivevideoandmedia")]
        [WorkflowExpressionFactory(nameof(__BuildVideoScanForNsfw))]
        public IBodyWorkflowAction<NsfwResult> VideoScanForNsfw([WorkflowExpression] Func<object> inputFile = null, [WorkflowExpression] Func<string> fileUrl = null, [WorkflowExpression] Func<double> framesPerSecond = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NsfwResult> __BuildVideoScanForNsfw(WorkflowExpression<object> inputFile = null, WorkflowExpression<string> fileUrl = null, WorkflowExpression<double> framesPerSecond = null)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: false);
            WorkflowExpression.Validate(fileUrl, nameof(fileUrl), required: false);
            WorkflowExpression.Validate(framesPerSecond, nameof(framesPerSecond), required: false);
            return new DeferredBodyAction<NsfwResult>(() =>
            {
                var apiCallPath = "/video/scan/nsfw";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fileUrl != null)
                    callPayload.Headers["fileUrl"] = ExpressionConverter.Convert(fileUrl);
                if (framesPerSecond != null)
                    callPayload.Headers["framesPerSecond"] = ExpressionConverter.Convert(framesPerSecond);
                return new ApiConnectionAction<NsfwResult>(callPayload);
            });
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