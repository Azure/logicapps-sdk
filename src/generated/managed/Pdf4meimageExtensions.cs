//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meimage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Pdf4meimageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> CompressImage(Expression<Func<string>> bodydocContent, Expression<Func<bodyimageTypeInput>> bodyimageType, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodycompressionLevelInput>> bodycompressionLevel = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyimageType = bodyimageType == null ? null : WorkflowExpression.Compile(bodyimageType);
            WorkflowExpression.Validate(__workflow_bodyimageType, nameof(bodyimageType), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodycompressionLevel = bodycompressionLevel == null ? null : WorkflowExpression.Compile(bodycompressionLevel);
            WorkflowExpression.Validate(__workflow_bodycompressionLevel, nameof(bodycompressionLevel), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageType"] = ExpressionConverter.ConvertO(__workflow_bodyimageType);
                if (__workflow_bodycompressionLevel != null)
                {
                    body["compressionLevel"] = ExpressionConverter.ConvertO(__workflow_bodycompressionLevel);
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
        public IBodyWorkflowAction<string> ConvertImageFormat(Expression<Func<string>> bodydocContent, Expression<Func<bodycurrentImageFormatInput>> bodycurrentImageFormat, Expression<Func<bodynewImageFormatInput>> bodynewImageFormat, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodycurrentImageFormat = bodycurrentImageFormat == null ? null : WorkflowExpression.Compile(bodycurrentImageFormat);
            WorkflowExpression.Validate(__workflow_bodycurrentImageFormat, nameof(bodycurrentImageFormat), required: true);
            var __workflow_bodynewImageFormat = bodynewImageFormat == null ? null : WorkflowExpression.Compile(bodynewImageFormat);
            WorkflowExpression.Validate(__workflow_bodynewImageFormat, nameof(bodynewImageFormat), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertImageFormat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["currentImageFormat"] = ExpressionConverter.ConvertO(__workflow_bodycurrentImageFormat);
                bodypropCount++;
                body["newImageFormat"] = ExpressionConverter.ConvertO(__workflow_bodynewImageFormat);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> CropImage(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = schemaVal == null ? null : WorkflowExpression.Compile(schemaVal);
            WorkflowExpression.Validate(__workflow_schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = operation == null ? null : WorkflowExpression.Compile(operation);
            WorkflowExpression.Validate(__workflow_operation, nameof(operation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Border");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IWorkflowAction CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = featurePath == null ? null : WorkflowExpression.Compile(featurePath);
            WorkflowExpression.Validate(__workflow_featurePath, nameof(featurePath), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> FlipImage(Expression<Func<string>> bodydocContent, Expression<Func<bodyorientationTypeInput>> bodyorientationType, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyorientationType = bodyorientationType == null ? null : WorkflowExpression.Compile(bodyorientationType);
            WorkflowExpression.Validate(__workflow_bodyorientationType, nameof(bodyorientationType), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlipImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["orientationType"] = ExpressionConverter.ConvertO(__workflow_bodyorientationType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<ImageExtractTextV1Response> ImageExtractText(Expression<Func<string>> bodydocContent, Expression<Func<bodyimageTypeExtractInput>> bodyimageTypeExtract, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyimageTypeExtract = bodyimageTypeExtract == null ? null : WorkflowExpression.Compile(bodyimageTypeExtract);
            WorkflowExpression.Validate(__workflow_bodyimageTypeExtract, nameof(bodyimageTypeExtract), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<ImageExtractTextV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ImageExtractText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageTypeExtract"] = ExpressionConverter.ConvertO(__workflow_bodyimageTypeExtract);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageExtractTextV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> RemoveExifTagsFromImage(Expression<Func<string>> bodydocContent, Expression<Func<bodyimageTypeInput>> bodyimageType, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyimageType = bodyimageType == null ? null : WorkflowExpression.Compile(bodyimageType);
            WorkflowExpression.Validate(__workflow_bodyimageType, nameof(bodyimageType), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RemoveEXIFTagsFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageType"] = ExpressionConverter.ConvertO(__workflow_bodyimageType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> ResizeImage(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = schemaVal == null ? null : WorkflowExpression.Compile(schemaVal);
            WorkflowExpression.Validate(__workflow_schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = operation == null ? null : WorkflowExpression.Compile(operation);
            WorkflowExpression.Validate(__workflow_operation, nameof(operation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Pdf4meimageTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimageTypeInput
    {
        JPG,
        PNG
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycompressionLevelInput
    {
        Max,
        Medium,
        Low
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurrentImageFormatInput
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodynewImageFormatInput
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum schemaValInput
    {
        Percentage,
        Specific
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
