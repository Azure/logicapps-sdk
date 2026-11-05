//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcrossActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergePDF(Expression<Func<FilesInput>> files)
        {
            var __workflow_files = WorkflowExpression.Compile(files, nameof(files), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_files);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddWatermarkText(Expression<Func<AddWatermarkTextFileInput>> @file)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/watermark_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_file);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddPassword(Expression<Func<AddPasswordFileInput>> @file)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_file);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddImage(Expression<Func<AddImageFileInput>> @file)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_file);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PdfcrossTriggers([ConnectionName] string connectionId)
    {
    }

    public class FilesInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent[] FileContent { get; set; }
    }

    public class AddWatermarkTextFileInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("watermarkText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkText { get; set; }
    }

    public class AddPasswordFileInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class AddImageFileInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("imageContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageContent { get; set; }

        [JsonProperty("positionX", DefaultValueHandling = DefaultValueHandling.Include)]
        public double PositionX { get; set; }

        [JsonProperty("positionY", DefaultValueHandling = DefaultValueHandling.Include)]
        public double PositionY { get; set; }

        [JsonProperty("addType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddType { get; set; }

        [JsonProperty("fromPage")]
        public double? FromPage { get; set; }

        [JsonProperty("toPage")]
        public double? ToPage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross;

    public partial class WorkflowManagedActions
    {
        public PdfcrossActions Pdfcross(string connectionId) => new PdfcrossActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfcrossTriggers Pdfcross(string connectionId) => new PdfcrossTriggers(connectionId);
    }
}