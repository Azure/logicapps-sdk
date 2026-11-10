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
        public IBodyWorkflowAction<TextImageAddResponse, ApiConnectionActionConfiguration> TextImageAdd(Expression<Func<TextImageAddBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TextImageAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-text-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextImageAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageStatusResponse, ApiConnectionActionConfiguration> TextImageStatus(Expression<Func<AudioStatusBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TextImageStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-text-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextImageStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageAddResponse, ApiConnectionActionConfiguration> ImageImageAdd(Expression<Func<ImageImageAddBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageImageAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-image-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageImageAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageStatusResponse, ApiConnectionActionConfiguration> ImageImageStatus(Expression<Func<AudioStatusBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageImageStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-image-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageImageStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditResponse, ApiConnectionActionConfiguration> ImageEdit(Expression<Func<ImageEditBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageEditResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-edit-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageEditResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditStatusResponse, ApiConnectionActionConfiguration> ImageEditStatus(Expression<Func<AudioStatusBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageEditStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-edit-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageEditStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioResponse, ApiConnectionActionConfiguration> Audio(Expression<Func<AudioBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AudioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add-audio-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioStatusResponse, ApiConnectionActionConfiguration> AudioStatus(Expression<Func<AudioStatusBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AudioStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-audio-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudioStatusResponse>(callPayload);
            });
        }
    }

    public class MonsterapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TextImageAddResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class TextImageAddBodyInput
    {
        public TextImageAddBodyInput(TextImageAddBodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "txt2img";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextImageAddBodyInputDataType Data { get; set; }
    }

    public class TextImageAddBodyInputDataType
    {
        public TextImageAddBodyInputDataType(string prompt)
        {
            this.Prompt = prompt;
        }

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

    public class TextImageStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public TextImageStatusResponseResponseDataType ResponseData { get; set; }
    }

    public class TextImageStatusResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public TextImageStatusResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class TextImageStatusResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class AudioStatusBodyInput
    {
        public AudioStatusBodyInput(string processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty("process_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }

    public class ImageImageAddResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class ImageImageAddBodyInput
    {
        public ImageImageAddBodyInput(ImageImageAddBodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "img2img";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageImageAddBodyInputDataType Data { get; set; }
    }

    public class ImageImageAddBodyInputDataType
    {
        public ImageImageAddBodyInputDataType(string prompt, string initImageUrl)
        {
            this.Prompt = prompt;
            this.InitImageUrl = initImageUrl;
        }

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

    public class ImageImageStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public ImageImageStatusResponseResponseDataType ResponseData { get; set; }
    }

    public class ImageImageStatusResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public ImageImageStatusResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class ImageImageStatusResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class ImageEditResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class ImageEditBodyInput
    {
        public ImageEditBodyInput(ImageEditBodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "pix2pix";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageEditBodyInputDataType Data { get; set; }
    }

    public class ImageEditBodyInputDataType
    {
        public ImageEditBodyInputDataType(string prompt, string initImageUrl)
        {
            this.Prompt = prompt;
            this.InitImageUrl = initImageUrl;
        }

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

    public class ImageEditStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public ImageEditStatusResponseResponseDataType ResponseData { get; set; }
    }

    public class ImageEditStatusResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public ImageEditStatusResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class ImageEditStatusResponseResponseDataTypeResultType
    {
        [JsonProperty("output")]
        public string[] Output { get; set; }
    }

    public class AudioResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    public class AudioBodyInput
    {
        public AudioBodyInput(AudioBodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Model { get; set; } = "whisper";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AudioBodyInputDataType Data { get; set; }
    }

    public class AudioBodyInputDataType
    {
        public AudioBodyInputDataType(string @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }

        [JsonProperty("transcription_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataTypeTranscriptionFormatType TranscriptionFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Monsterapiip.BodyInputDataTypeTranscriptionFormatType.Text;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDataTypeTranscriptionFormatType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "srt")]
        Srt,
        [EnumMember(Value = "word")]
        Word
    }

    public class AudioStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response_data")]
        public AudioStatusResponseResponseDataType ResponseData { get; set; }
    }

    public class AudioStatusResponseResponseDataType
    {
        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public AudioStatusResponseResponseDataTypeResultType Result { get; set; }

        [JsonProperty("credit_used")]
        public int CreditUsed { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class AudioStatusResponseResponseDataTypeResultType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
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