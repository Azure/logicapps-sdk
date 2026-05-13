//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Monsterapiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MonsterapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageAddPostResponse> TextImageAdd(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasamples = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<string>> bodydataaspectRatio = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<int>> bodydataseed = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageStatusPostResponse> TextImageStatus(Expression<Func<string>> bodyprocessId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageAddPostResponse> ImageImageAdd(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<string>> bodydatainitImageUrl = null, Expression<Func<double>> bodydatastrength = null, Expression<Func<int>> bodydataseed = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageStatusPostResponse> ImageImageStatus(Expression<Func<string>> bodyprocessId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditPostResponse> ImageEdit(Expression<Func<string>> bodydataprompt = null, Expression<Func<string>> bodydatanegprompt = null, Expression<Func<int>> bodydatasteps = null, Expression<Func<double>> bodydataguidanceScale = null, Expression<Func<string>> bodydatainitImageUrl = null, Expression<Func<double>> bodydataimageGuidanceScale = null, Expression<Func<int>> bodydataseed = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditStatusPostResponse> ImageEditStatus(Expression<Func<string>> bodyprocessId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioPostResponse> Audio(Expression<Func<string>> bodydatafile = null, Expression<Func<bodydatatranscriptionFormatInput>> bodydatatranscriptionFormat = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioStatusPostResponse> AudioStatus(Expression<Func<string>> bodyprocessId)
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