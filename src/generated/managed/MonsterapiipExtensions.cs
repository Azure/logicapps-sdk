//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monsterapiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MonsterapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageAddPostResponse, ApiConnectionActionConfiguration> TextImageAdd(Expression<Func<TextImageAddPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextImageAddPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-text-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextImageAddPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageStatusPostResponse, ApiConnectionActionConfiguration> TextImageStatus(Expression<Func<TextImageStatusPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextImageStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-text-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageAddPostResponse, ApiConnectionActionConfiguration> ImageImageAdd(Expression<Func<ImageImageAddPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ImageImageAddPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-image-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageImageAddPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageStatusPostResponse, ApiConnectionActionConfiguration> ImageImageStatus(Expression<Func<ImageImageStatusPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ImageImageStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-image-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditPostResponse, ApiConnectionActionConfiguration> ImageEdit(Expression<Func<ImageEditPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ImageEditPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-edit-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageEditPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditStatusPostResponse, ApiConnectionActionConfiguration> ImageEditStatus(Expression<Func<ImageEditStatusPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ImageEditStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-edit-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageEditStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioPostResponse, ApiConnectionActionConfiguration> Audio(Expression<Func<AudioPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AudioPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-audio-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudioPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioStatusPostResponse, ApiConnectionActionConfiguration> AudioStatus(Expression<Func<AudioStatusPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AudioStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-audio-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudioStatusPostResponse>(callPayload);
            });
        }
    }

    public class MonsterapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TextImageAddPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class TextImageAddPostInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "txt2img";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextImageAddPostInputDataType Data { get; set; }
    }

    public class TextImageAddPostInputDataType
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("negprompt")]
        public string Negprompt { get; set; }

        [JsonProperty("samples")]
        public int? Samples { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }

        [JsonProperty("aspect_ratio")]
        public string AspectRatio { get; set; }

        [JsonProperty("guidance_scale")]
        public double? GuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }
    }

    public class TextImageStatusPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public TextImageStatusPostResponseResponseDataType ResponseData { get; set; }
    }

    public class TextImageStatusPostResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public TextImageStatusPostResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class TextImageStatusPostResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class TextImageStatusPostInput
    {
        [JsonProperty("process_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }

    public class ImageImageAddPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class ImageImageAddPostInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "img2img";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageImageAddPostInputDataType Data { get; set; }
    }

    public class ImageImageAddPostInputDataType
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("negprompt")]
        public string Negprompt { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }

        [JsonProperty("guidance_scale")]
        public double? GuidanceScale { get; set; }

        [JsonProperty("init_image_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImageUrl { get; set; }

        [JsonProperty("strength")]
        public double? Strength { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }
    }

    public class ImageImageStatusPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public ImageImageStatusPostResponseResponseDataType ResponseData { get; set; }
    }

    public class ImageImageStatusPostResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public ImageImageStatusPostResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class ImageImageStatusPostResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class ImageImageStatusPostInput
    {
        [JsonProperty("process_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }

    public class ImageEditPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class ImageEditPostInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "pix2pix";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageEditPostInputDataType Data { get; set; }
    }

    public class ImageEditPostInputDataType
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("negprompt")]
        public string Negprompt { get; set; }

        [JsonProperty("steps")]
        public int? Steps { get; set; }

        [JsonProperty("guidance_scale")]
        public double? GuidanceScale { get; set; }

        [JsonProperty("init_image_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitImageUrl { get; set; }

        [JsonProperty("image_guidance_scale")]
        public double? ImageGuidanceScale { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }
    }

    public class ImageEditStatusPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public ImageEditStatusPostResponseResponseDataType ResponseData { get; set; }
    }

    public class ImageEditStatusPostResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public ImageEditStatusPostResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class ImageEditStatusPostResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class ImageEditStatusPostInput
    {
        [JsonProperty("process_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }

    public class AudioPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class AudioPostInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "whisper";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AudioPostInputDataType Data { get; set; }
    }

    public class AudioPostInputDataType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }

        [JsonProperty("transcription_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public AudioPostInputDataTypeTranscriptionFormatType TranscriptionFormat { get; set; } = AudioPostInputDataTypeTranscriptionFormatType.Text;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AudioPostInputDataTypeTranscriptionFormatType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "srt")]
        Srt,
        [EnumMember(Value = "word")]
        Word
    }

    public class AudioStatusPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public AudioStatusPostResponseResponseDataType ResponseData { get; set; }
    }

    public class AudioStatusPostResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public AudioStatusPostResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class AudioStatusPostResponseResponseDataTypeResultType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AudioStatusPostInput
    {
        [JsonProperty("process_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Monsterapiip;

    public partial class WorkflowManagedActions
    {
        public MonsterapiipActions Monsterapiip(string connectionId) => new MonsterapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MonsterapiipTriggers Monsterapiip(string connectionId) => new MonsterapiipTriggers(connectionId);
    }
}