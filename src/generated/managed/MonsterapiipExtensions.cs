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
        public IBodyWorkflowAction<TextImageAddPostResponse> TextImageAdd([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasamples = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<string> bodydataaspectRatio = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            SourceExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            SourceExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            SourceExpression.Validate(bodydatasamples, nameof(bodydatasamples), required: false);
            SourceExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            SourceExpression.Validate(bodydataaspectRatio, nameof(bodydataaspectRatio), required: false);
            SourceExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            SourceExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    dataObject["prompt"] = SourceExpressionConverter.ConvertToken(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = SourceExpressionConverter.ConvertToken(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasamples != null)
                {
                    dataObject["samples"] = SourceExpressionConverter.ConvertToken(bodydatasamples);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = SourceExpressionConverter.ConvertToken(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataaspectRatio != null)
                {
                    dataObject["aspect_ratio"] = SourceExpressionConverter.ConvertToken(bodydataaspectRatio);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = SourceExpressionConverter.ConvertToken(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = SourceExpressionConverter.ConvertToken(bodydataseed);
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
                return callPayload;
            }

            return new ApiConnectionAction<TextImageAddPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<TextImageStatusPostResponse> TextImageStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            SourceExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task-text-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TextImageStatusPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageAddPostResponse> ImageImageAdd([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<string> bodydatainitImageUrl = null, [WorkflowExpression] Func<double> bodydatastrength = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            SourceExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            SourceExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            SourceExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            SourceExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            SourceExpression.Validate(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            SourceExpression.Validate(bodydatastrength, nameof(bodydatastrength), required: false);
            SourceExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    dataObject["prompt"] = SourceExpressionConverter.ConvertToken(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = SourceExpressionConverter.ConvertToken(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = SourceExpressionConverter.ConvertToken(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = SourceExpressionConverter.ConvertToken(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = SourceExpressionConverter.ConvertToken(bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (bodydatastrength != null)
                {
                    dataObject["strength"] = SourceExpressionConverter.ConvertToken(bodydatastrength);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = SourceExpressionConverter.ConvertToken(bodydataseed);
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
                return callPayload;
            }

            return new ApiConnectionAction<ImageImageAddPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageImageStatusPostResponse> ImageImageStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            SourceExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task-image-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageImageStatusPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditPostResponse> ImageEdit([WorkflowExpression] Func<string> bodydataprompt = null, [WorkflowExpression] Func<string> bodydatanegprompt = null, [WorkflowExpression] Func<int> bodydatasteps = null, [WorkflowExpression] Func<double> bodydataguidanceScale = null, [WorkflowExpression] Func<string> bodydatainitImageUrl = null, [WorkflowExpression] Func<double> bodydataimageGuidanceScale = null, [WorkflowExpression] Func<int> bodydataseed = null)
        {
            SourceExpression.Validate(bodydataprompt, nameof(bodydataprompt), required: false);
            SourceExpression.Validate(bodydatanegprompt, nameof(bodydatanegprompt), required: false);
            SourceExpression.Validate(bodydatasteps, nameof(bodydatasteps), required: false);
            SourceExpression.Validate(bodydataguidanceScale, nameof(bodydataguidanceScale), required: false);
            SourceExpression.Validate(bodydatainitImageUrl, nameof(bodydatainitImageUrl), required: false);
            SourceExpression.Validate(bodydataimageGuidanceScale, nameof(bodydataimageGuidanceScale), required: false);
            SourceExpression.Validate(bodydataseed, nameof(bodydataseed), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    dataObject["prompt"] = SourceExpressionConverter.ConvertToken(bodydataprompt);
                    dataObjectpropCount++;
                }

                if (bodydatanegprompt != null)
                {
                    dataObject["negprompt"] = SourceExpressionConverter.ConvertToken(bodydatanegprompt);
                    dataObjectpropCount++;
                }

                if (bodydatasteps != null)
                {
                    dataObject["steps"] = SourceExpressionConverter.ConvertToken(bodydatasteps);
                    dataObjectpropCount++;
                }

                if (bodydataguidanceScale != null)
                {
                    dataObject["guidance_scale"] = SourceExpressionConverter.ConvertToken(bodydataguidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydatainitImageUrl != null)
                {
                    dataObject["init_image_url"] = SourceExpressionConverter.ConvertToken(bodydatainitImageUrl);
                    dataObjectpropCount++;
                }

                if (bodydataimageGuidanceScale != null)
                {
                    dataObject["image_guidance_scale"] = SourceExpressionConverter.ConvertToken(bodydataimageGuidanceScale);
                    dataObjectpropCount++;
                }

                if (bodydataseed != null)
                {
                    dataObject["seed"] = SourceExpressionConverter.ConvertToken(bodydataseed);
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
                return callPayload;
            }

            return new ApiConnectionAction<ImageEditPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<ImageEditStatusPostResponse> ImageEditStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            SourceExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task-edit-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageEditStatusPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioPostResponse> Audio([WorkflowExpression] Func<string> bodydataFile = null, [WorkflowExpression] Func<bodydatatranscriptionFormatInput> bodydatatranscriptionFormat = null)
        {
            SourceExpression.Validate(bodydataFile, nameof(bodydataFile), required: false);
            SourceExpression.Validate(bodydatatranscriptionFormat, nameof(bodydatatranscriptionFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodydataFile != null)
                {
                    dataObject["file"] = SourceExpressionConverter.ConvertToken(bodydataFile);
                    dataObjectpropCount++;
                }

                if (bodydatatranscriptionFormat != null)
                {
                    if (bodydatatranscriptionFormat != null)
                    {
                        dataObject["transcription_format"] = SourceExpressionConverter.Convert(bodydatatranscriptionFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<AudioPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "monsterapiip")]
        public IBodyWorkflowAction<AudioStatusPostResponse> AudioStatus([WorkflowExpression] Func<string> bodyprocessId)
        {
            SourceExpression.Validate(bodyprocessId, nameof(bodyprocessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task-audio-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["process_id"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AudioStatusPostResponse>(BuildSourceInput);
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