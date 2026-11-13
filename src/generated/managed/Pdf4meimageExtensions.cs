//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meimage
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meimageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CompressImage(Expression<Func<CompressImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertImageFormat(Expression<Func<ConvertImageFormatBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertImageFormat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CropImage(Expression<Func<CropImageSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Border");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomApi(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = ("{\"docContent\":\"\"}").ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlipImage(Expression<Func<FlipImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlipImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<ImageExtractTextResponse, ApiConnectionActionConfiguration> ImageExtractText(Expression<Func<ImageExtractTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageExtractTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ImageExtractText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageExtractTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RemoveExifTagsFromImage(Expression<Func<RemoveExifTagsFromImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RemoveEXIFTagsFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ResizeImage(Expression<Func<ResizeImageSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Pdf4meimageTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompressImageBodyInput
    {
        public CompressImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document, BodyInputImageTypeType imageType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.ImageType = imageType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeType ImageType { get; set; }

        [JsonProperty("compressionLevel")]
        public BodyInputCompressionLevelType? CompressionLevel { get; set; }
    }

    public class BodyInputDocumentType
    {
        public BodyInputDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImageTypeType
    {
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "PNG")]
        Png
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCompressionLevelType
    {
        Max,
        Medium,
        Low
    }

    public class ConvertImageFormatBodyInput
    {
        public ConvertImageFormatBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document, BodyInputCurrentImageFormatType currentImageFormat, BodyInputNewImageFormatType newImageFormat)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.CurrentImageFormat = currentImageFormat;
            this.NewImageFormat = newImageFormat;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("currentImageFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCurrentImageFormatType CurrentImageFormat { get; set; }

        [JsonProperty("newImageFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputNewImageFormatType NewImageFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCurrentImageFormatType
    {
        [EnumMember(Value = "BMP")]
        Bmp,
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "GIF")]
        Gif,
        [EnumMember(Value = "PNG")]
        Png,
        [EnumMember(Value = "TIF")]
        Tif
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputNewImageFormatType
    {
        [EnumMember(Value = "BMP")]
        Bmp,
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "GIF")]
        Gif,
        [EnumMember(Value = "PNG")]
        Png,
        [EnumMember(Value = "TIF")]
        Tif
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CropImageSchemaValInput
    {
        Border,
        Rectangle
    }

    public class FlipImageBodyInput
    {
        public FlipImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document, BodyInputOrientationTypeType orientationType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.OrientationType = orientationType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("orientationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOrientationTypeType OrientationType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOrientationTypeType
    {
        Horizontal,
        Vertical,
        HorizontalAndVertical
    }

    public class ImageExtractTextResponse
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("docText")]
        public string DocText { get; set; }
    }

    public class ImageExtractTextBodyInput
    {
        public ImageExtractTextBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("imageTypeExtract", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeExtractType ImageTypeExtract { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meimage.BodyInputImageTypeExtractType.Jpg;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImageTypeExtractType
    {
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "PNG")]
        Png,
        [EnumMember(Value = "TIFF")]
        Tiff,
        [EnumMember(Value = "BMP")]
        Bmp
    }

    public class RemoveExifTagsFromImageBodyInput
    {
        public RemoveExifTagsFromImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document, BodyInputImageTypeType imageType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.ImageType = imageType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeType ImageType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResizeImageSchemaValInput
    {
        Percentage,
        Specific
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