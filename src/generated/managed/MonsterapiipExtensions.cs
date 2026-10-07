//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monsterapiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MonsterapiipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildTextImageAdd))]
        public IBodyWorkflowAction<TextImageAddPostResponse> TextImageAdd([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasamples = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<string> bodydataaspectRatio = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextImageAddPostResponse> __BuildTextImageAdd(WorkflowExpression<string> bodydataprompt = null, WorkflowExpression<string> bodydatanegprompt = null, WorkflowExpression<int> bodydatasamples = null, WorkflowExpression<int> bodydatasteps = null, WorkflowExpression<string> bodydataaspectRatio = null, WorkflowExpression<double> bodydataguidanceScale = null, WorkflowExpression<int> bodydataseed = null)
        {
            WorkflowExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            WorkflowExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            WorkflowExpression.Validate(bodydatasamples, nameof(bodydatasamples), required: false);
            WorkflowExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            WorkflowExpression.Validate(bodydataaspectRatio, nameof(bodydataaspectRatio), required: false);
            WorkflowExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            WorkflowExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<TextImageAddPostResponse>(() =>
            {
                var apiCallPath = "/add-text-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["model"] = "txt2img";
                bodypropCount++;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasamples != null)
                {
                    dataObject["samples"] = ExpressionConverter.ConvertO(bodydatasamples);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataaspectRatio != null)
                {
                    dataObject["aspect_ratio"] = ExpressionConverter.ConvertO(bodydataaspectRatio);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(bodydataseed);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TextImageAddPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildTextImageStatus))]
        public IBodyWorkflowAction<TextImageStatusPostResponse> TextImageStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextImageStatusPostResponse> __BuildTextImageStatus(WorkflowExpression<string> bodyprocessId)
        {
            WorkflowExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<TextImageStatusPostResponse>(() =>
            {
                var apiCallPath = "/task-text-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TextImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageImageAdd))]
        public IBodyWorkflowAction<ImageImageAddPostResponse> ImageImageAdd([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<string> bodydatainitImageUrl = null, [WorkflowExpression] Func<double> bodydatastrength = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageImageAddPostResponse> __BuildImageImageAdd(WorkflowExpression<string> bodydataprompt = null, WorkflowExpression<string> bodydatanegprompt = null, WorkflowExpression<int> bodydatasteps = null, WorkflowExpression<double> bodydataguidanceScale = null, WorkflowExpression<string> bodydatainitImageUrl = null, WorkflowExpression<double> bodydatastrength = null, WorkflowExpression<int> bodydataseed = null)
        {
            WorkflowExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            WorkflowExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            WorkflowExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            WorkflowExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            WorkflowExpression.Validate(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            WorkflowExpression.Validate(bodydatastrength, nameof(bodydatastrength), required: false);
            WorkflowExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<ImageImageAddPostResponse>(() =>
            {
                var apiCallPath = "/add-image-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["model"] = "img2img";
                bodypropCount++;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = ExpressionConverter.ConvertO(bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (bodydatastrength != null)
                {
                    dataObject["strength"] = ExpressionConverter.ConvertO(bodydatastrength);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(bodydataseed);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageImageAddPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageImageStatus))]
        public IBodyWorkflowAction<ImageImageStatusPostResponse> ImageImageStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageImageStatusPostResponse> __BuildImageImageStatus(WorkflowExpression<string> bodyprocessId)
        {
            WorkflowExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<ImageImageStatusPostResponse>(() =>
            {
                var apiCallPath = "/task-image-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageEdit))]
        public IBodyWorkflowAction<ImageEditPostResponse> ImageEdit([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<string> bodydatainitImageUrl = null, [WorkflowExpression] Func<double> bodydataimageGuidanceScale = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageEditPostResponse> __BuildImageEdit(WorkflowExpression<string> bodydataprompt = null, WorkflowExpression<string> bodydatanegprompt = null, WorkflowExpression<int> bodydatasteps = null, WorkflowExpression<double> bodydataguidanceScale = null, WorkflowExpression<string> bodydatainitImageUrl = null, WorkflowExpression<double> bodydataimageGuidanceScale = null, WorkflowExpression<int> bodydataseed = null)
        {
            WorkflowExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            WorkflowExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            WorkflowExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            WorkflowExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            WorkflowExpression.Validate(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            WorkflowExpression.Validate(bodydataimageGuidanceScale, nameof(bodydataimageGuidanceScale), required: false);
            WorkflowExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<ImageEditPostResponse>(() =>
            {
                var apiCallPath = "/add-edit-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["model"] = "pix2pix";
                bodypropCount++;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = ExpressionConverter.ConvertO(bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (bodydataimageGuidanceScale != null)
                {
                    dataObject["image_guidance_scale"] = ExpressionConverter.ConvertO(bodydataimageGuidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(bodydataseed);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageEditPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageEditStatus))]
        public IBodyWorkflowAction<ImageEditStatusPostResponse> ImageEditStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageEditStatusPostResponse> __BuildImageEditStatus(WorkflowExpression<string> bodyprocessId)
        {
            WorkflowExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<ImageEditStatusPostResponse>(() =>
            {
                var apiCallPath = "/task-edit-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageEditStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildAudio))]
        public IBodyWorkflowAction<AudioPostResponse> Audio([WorkflowExpression] Func<string> bodydatafile = null, [WorkflowExpression] Func<bodydatatranscriptionFormatInput> bodydatatranscriptionFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudioPostResponse> __BuildAudio(WorkflowExpression<string> bodydatafile = null, WorkflowExpression<bodydatatranscriptionFormatInput> bodydatatranscriptionFormat = null)
        {
            WorkflowExpression.Validate(bodydatafile, nameof(bodydatafile), required: false);
            WorkflowExpression.Validate(bodydatatranscriptionFormat, nameof(bodydatatranscriptionFormat), required: false);
            return new DeferredBodyAction<AudioPostResponse>(() =>
            {
                var apiCallPath = "/add-audio-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["model"] = "whisper";
                bodypropCount++;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatafile != null)
                {
                    dataObject["file"] = ExpressionConverter.ConvertO(bodydatafile);
                    dataObjectpropCount++;
                }

                if (bodydatatranscriptionFormat != null)
                {
                    if (bodydatatranscriptionFormat != null)
                    {
                        dataObject["transcription_format"] = ExpressionConverter.ConvertO(bodydatatranscriptionFormat);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["transcription_format"] = "text";
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AudioPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [WorkflowExpressionFactory(nameof(__BuildAudioStatus))]
        public IBodyWorkflowAction<AudioStatusPostResponse> AudioStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudioStatusPostResponse> __BuildAudioStatus(WorkflowExpression<string> bodyprocessId)
        {
            WorkflowExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<AudioStatusPostResponse>(() =>
            {
                var apiCallPath = "/task-audio-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class ImageImageAddPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
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

    public class ImageEditPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
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

    public class AudioPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydatatranscriptionFormatInput
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