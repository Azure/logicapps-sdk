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
        public IBodyWorkflowAction<string> CompressImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeInput> bodyimageType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodycompressionLevelInput> bodycompressionLevel = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> ConvertImageFormat([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodycurrentImageFormatInput> bodycurrentImageFormat, [WorkflowExpression] Func<bodynewImageFormatInput> bodynewImageFormat, [WorkflowExpression] Func<string> bodydocumentname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> CropImage([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/CropImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("Border");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IWorkflowAction CustomAPI([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> featurePath, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> FlipImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyorientationTypeInput> bodyorientationType, [WorkflowExpression] Func<string> bodydocumentname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<ImageExtractTextV1Response> ImageExtractText([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeExtractInput> bodyimageTypeExtract, [WorkflowExpression] Func<string> bodydocumentname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> RemoveExifTagsFromImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyimageTypeInput> bodyimageType, [WorkflowExpression] Func<string> bodydocumentname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meimage")]
        public IBodyWorkflowAction<string> ResizeImage([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/ResizeImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
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