//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meimage
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meimageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildCompressImage))]
        public IBodyWorkflowAction<string> CompressImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeInput> bodyimageType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCompressImage(WorkflowValue<string> bodydocContent, WorkflowValue<bodyimageTypeInput> bodyimageType, WorkflowValue<string> bodydocumentname = null, WorkflowValue<bodycompressionLevelInput> bodycompressionLevel = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyimageType, nameof(bodyimageType), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageType"] = ExpressionConverter.ConvertO(bodyimageType);
                if (bodycompressionLevel != null)
                {
                    body["compressionLevel"] = ExpressionConverter.ConvertO(bodycompressionLevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildConvertImageFormat))]
        public IBodyWorkflowAction<string> ConvertImageFormat([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodycurrentImageFormatInput> bodycurrentImageFormat, [WorkflowExpression] Func<bodynewImageFormatInput> bodynewImageFormat, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertImageFormat(WorkflowValue<string> bodydocContent, WorkflowValue<bodycurrentImageFormatInput> bodycurrentImageFormat, WorkflowValue<bodynewImageFormatInput> bodynewImageFormat, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodycurrentImageFormat, nameof(bodycurrentImageFormat), required: true);
            WorkflowValue.Validate(bodynewImageFormat, nameof(bodynewImageFormat), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertImageFormat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["currentImageFormat"] = ExpressionConverter.ConvertO(bodycurrentImageFormat);
                bodypropCount++;
                body["newImageFormat"] = ExpressionConverter.ConvertO(bodynewImageFormat);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildCropImage))]
        public IBodyWorkflowAction<string> CropImage([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCropImage(WorkflowValue<schemaValInput> schemaVal = null, WorkflowValue<object> operation = null)
        {
            WorkflowValue.Validate(schemaVal, nameof(schemaVal), required: false);
            WorkflowValue.Validate(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Border");
                if (schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildCustomAPI))]
        public IWorkflowAction CustomAPI([WorkflowExpression] Func<string> featurePath, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCustomAPI(WorkflowValue<string> featurePath, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(featurePath, nameof(featurePath), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildFlipImage))]
        public IBodyWorkflowAction<string> FlipImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyorientationTypeInput> bodyorientationType, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFlipImage(WorkflowValue<string> bodydocContent, WorkflowValue<bodyorientationTypeInput> bodyorientationType, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyorientationType, nameof(bodyorientationType), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlipImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["orientationType"] = ExpressionConverter.ConvertO(bodyorientationType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildImageExtractText))]
        public IBodyWorkflowAction<ImageExtractTextV1Response> ImageExtractText([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeExtractInput> bodyimageTypeExtract, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageExtractTextV1Response> __BuildImageExtractText(WorkflowValue<string> bodydocContent, WorkflowValue<bodyimageTypeExtractInput> bodyimageTypeExtract, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyimageTypeExtract, nameof(bodyimageTypeExtract), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<ImageExtractTextV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ImageExtractText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageTypeExtract"] = ExpressionConverter.ConvertO(bodyimageTypeExtract);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageExtractTextV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveExifTagsFromImage))]
        public IBodyWorkflowAction<string> RemoveExifTagsFromImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeInput> bodyimageType, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRemoveExifTagsFromImage(WorkflowValue<string> bodydocContent, WorkflowValue<bodyimageTypeInput> bodyimageType, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyimageType, nameof(bodyimageType), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RemoveEXIFTagsFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageType"] = ExpressionConverter.ConvertO(bodyimageType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        [WorkflowExpressionFactory(nameof(__BuildResizeImage))]
        public IBodyWorkflowAction<string> ResizeImage([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildResizeImage(WorkflowValue<schemaValInput> schemaVal = null, WorkflowValue<object> operation = null)
        {
            WorkflowValue.Validate(schemaVal, nameof(schemaVal), required: false);
            WorkflowValue.Validate(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
                if (schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Pdf4meimageTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodyimageTypeInput
    {
        JPG,
        PNG
    }

    public enum bodycompressionLevelInput
    {
        Max,
        Medium,
        Low
    }

    public enum bodycurrentImageFormatInput
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    public enum bodynewImageFormatInput
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    public enum schemaValInput
    {
        Percentage,
        Specific
    }

    public enum bodyorientationTypeInput
    {
        Horizontal,
        Vertical,
        HorizontalAndVertical
    }

    public class ImageExtractTextV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("docText")]
        public string DocText { get; set; }
    }

    public enum bodyimageTypeExtractInput
    {
        JPG,
        PNG,
        TIFF,
        BMP
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meimage;

    public partial class WorkflowManagedActions
    {
        public Pdf4meimageActions Pdf4meimage(string connectionId) => new Pdf4meimageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meimageTriggers Pdf4meimage(string connectionId) => new Pdf4meimageTriggers(connectionId);
    }
}
