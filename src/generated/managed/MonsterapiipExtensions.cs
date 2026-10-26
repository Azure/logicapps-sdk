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
        public IBodyWorkflowAction<TextImageAddPostResponse, ApiConnectionActionConfiguration> TextImageAdd(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasamples = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<string>> bodydataaspectRatio = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<int>> bodydataseed = null)
        {
            var __workflow_bodydataprompt = WorkflowExpression.Compile(bodydataprompt, nameof(bodydataprompt), required: false);
            var __workflow_bodydatanegprompt = WorkflowExpression.Compile(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            var __workflow_bodydatasamples = WorkflowExpression.Compile(bodydatasamples, nameof(bodydatasamples), required: false);
            var __workflow_bodydatasteps = WorkflowExpression.Compile(bodydatasteps, nameof(bodydatasteps), required: false);
            var __workflow_bodydataaspectRatio = WorkflowExpression.Compile(bodydataaspectRatio, nameof(bodydataaspectRatio), required: false);
            var __workflow_bodydataguidanceScale = WorkflowExpression.Compile(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            var __workflow_bodydataseed = WorkflowExpression.Compile(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<TextImageAddPostResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(__workflow_bodydataprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(__workflow_bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatasamples != null)
                {
                    dataObject["samples"] = ExpressionConverter.ConvertO(__workflow_bodydatasamples);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(__workflow_bodydatasteps);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataaspectRatio != null)
                {
                    dataObject["aspect_ratio"] = ExpressionConverter.ConvertO(__workflow_bodydataaspectRatio);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(__workflow_bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(__workflow_bodydataseed);
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
        public IBodyWorkflowAction<TextImageStatusPostResponse, ApiConnectionActionConfiguration> TextImageStatus(Expression<Func<string>> bodyprocessId)
        {
            var __workflow_bodyprocessId = WorkflowExpression.Compile(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<TextImageStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-text-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(__workflow_bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TextImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageAddPostResponse, ApiConnectionActionConfiguration> ImageImageAdd(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<string>> bodydatainitImageUrl = null, Expression<Func<double>> bodydatastrength = null, Expression<Func<int>> bodydataseed = null)
        {
            var __workflow_bodydataprompt = WorkflowExpression.Compile(bodydataprompt, nameof(bodydataprompt), required: false);
            var __workflow_bodydatanegprompt = WorkflowExpression.Compile(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            var __workflow_bodydatasteps = WorkflowExpression.Compile(bodydatasteps, nameof(bodydatasteps), required: false);
            var __workflow_bodydataguidanceScale = WorkflowExpression.Compile(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            var __workflow_bodydatainitImageUrl = WorkflowExpression.Compile(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            var __workflow_bodydatastrength = WorkflowExpression.Compile(bodydatastrength, nameof(bodydatastrength), required: false);
            var __workflow_bodydataseed = WorkflowExpression.Compile(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<ImageImageAddPostResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(__workflow_bodydataprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(__workflow_bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(__workflow_bodydatasteps);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(__workflow_bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = ExpressionConverter.ConvertO(__workflow_bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatastrength != null)
                {
                    dataObject["strength"] = ExpressionConverter.ConvertO(__workflow_bodydatastrength);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(__workflow_bodydataseed);
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
        public IBodyWorkflowAction<ImageImageStatusPostResponse, ApiConnectionActionConfiguration> ImageImageStatus(Expression<Func<string>> bodyprocessId)
        {
            var __workflow_bodyprocessId = WorkflowExpression.Compile(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<ImageImageStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-image-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(__workflow_bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageImageStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditPostResponse, ApiConnectionActionConfiguration> ImageEdit(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<string>> bodydatainitImageUrl = null, Expression<Func<double>> bodydataimageGuidanceScale = null, Expression<Func<int>> bodydataseed = null)
        {
            var __workflow_bodydataprompt = WorkflowExpression.Compile(bodydataprompt, nameof(bodydataprompt), required: false);
            var __workflow_bodydatanegprompt = WorkflowExpression.Compile(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            var __workflow_bodydatasteps = WorkflowExpression.Compile(bodydatasteps, nameof(bodydatasteps), required: false);
            var __workflow_bodydataguidanceScale = WorkflowExpression.Compile(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            var __workflow_bodydatainitImageUrl = WorkflowExpression.Compile(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            var __workflow_bodydataimageGuidanceScale = WorkflowExpression.Compile(bodydataimageGuidanceScale, nameof(bodydataimageGuidanceScale), required: false);
            var __workflow_bodydataseed = WorkflowExpression.Compile(bodydataseed, nameof(bodydataseed), required: false);
            return new DeferredBodyAction<ImageEditPostResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydataprompt != null)
                {
                    dataObject["prompt"] = ExpressionConverter.ConvertO(__workflow_bodydataprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = ExpressionConverter.ConvertO(__workflow_bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatasteps != null)
                {
                    dataObject["steps"] = ExpressionConverter.ConvertO(__workflow_bodydatasteps);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = ExpressionConverter.ConvertO(__workflow_bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = ExpressionConverter.ConvertO(__workflow_bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataimageGuidanceScale != null)
                {
                    dataObject["image_guidance_scale"] = ExpressionConverter.ConvertO(__workflow_bodydataimageGuidanceScale);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataseed != null)
                {
                    dataObject["seed"] = ExpressionConverter.ConvertO(__workflow_bodydataseed);
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
        public IBodyWorkflowAction<ImageEditStatusPostResponse, ApiConnectionActionConfiguration> ImageEditStatus(Expression<Func<string>> bodyprocessId)
        {
            var __workflow_bodyprocessId = WorkflowExpression.Compile(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<ImageEditStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-edit-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(__workflow_bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageEditStatusPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioPostResponse, ApiConnectionActionConfiguration> Audio(Expression<Func<string>> bodydataFile = null, Expression<Func<bodydatatranscriptionFormatInput>> bodydatatranscriptionFormat = null)
        {
            var __workflow_bodydataFile = WorkflowExpression.Compile(bodydataFile, nameof(bodydataFile), required: false);
            var __workflow_bodydatatranscriptionFormat = WorkflowExpression.Compile(bodydatatranscriptionFormat, nameof(bodydatatranscriptionFormat), required: false);
            return new DeferredBodyAction<AudioPostResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodydataFile != null)
                {
                    dataObject["file"] = ExpressionConverter.ConvertO(__workflow_bodydataFile);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatatranscriptionFormat != null)
                {
                    if (__workflow_bodydatatranscriptionFormat != null)
                    {
                        dataObject["transcription_format"] = ExpressionConverter.ConvertO(__workflow_bodydatatranscriptionFormat);
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
        public IBodyWorkflowAction<AudioStatusPostResponse, ApiConnectionActionConfiguration> AudioStatus(Expression<Func<string>> bodyprocessId)
        {
            var __workflow_bodyprocessId = WorkflowExpression.Compile(bodyprocessId, nameof(bodyprocessId), required: true);
            return new DeferredBodyAction<AudioStatusPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/task-audio-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = ExpressionConverter.ConvertO(__workflow_bodyprocessId);
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