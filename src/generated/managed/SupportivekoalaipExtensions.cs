//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Supportivekoalaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SupportivekoalaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<ImagesResponse, ApiConnectionActionConfiguration> Images(Expression<Func<ImagesBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/images/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<ImageGetResponse, ApiConnectionActionConfiguration> ImageGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ImageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/images/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<ImagesGetResponseItem[], ApiConnectionActionConfiguration> ImagesGet()
        {
            return new DeferredBodyAction<ImagesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/images";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<TemplateResponse, ApiConnectionActionConfiguration> Template(Expression<Func<TemplateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<TemplateGetResponse, ApiConnectionActionConfiguration> TemplateGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TemplateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<TemplatesGetResponseItem[], ApiConnectionActionConfiguration> TemplatesGet()
        {
            return new DeferredBodyAction<TemplatesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplatesGetResponseItem[]>(callPayload);
            });
        }
    }

    public class SupportivekoalaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImagesResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class ImagesBodyInput
    {
        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFormatType? Format { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Supportivekoalaip.BodyInputFormatType.Png;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormatType
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "webp")]
        Webp
    }

    public class ImageGetResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class ImagesGetResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplateResponse
    {
        [JsonProperty("generatedImages")]
        public TemplateResponseGeneratedImagesTypeItem[] GeneratedImages { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("params")]
        public string[] Params { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplateResponseGeneratedImagesTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplateBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("generatedImages")]
        public TemplateGetResponseGeneratedImagesTypeItem[] GeneratedImages { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("params")]
        public JToken[] Params { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplateGetResponseGeneratedImagesTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplatesGetResponseItem
    {
        [JsonProperty("generatedImages")]
        public TemplatesGetResponseItemGeneratedImagesTypeItem[] GeneratedImages { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("params")]
        public string[] Params { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }

    public class TemplatesGetResponseItemGeneratedImagesTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Supportivekoalaip;

    public partial class WorkflowManagedActions
    {
        public SupportivekoalaipActions Supportivekoalaip(string connectionId) => new SupportivekoalaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SupportivekoalaipTriggers Supportivekoalaip(string connectionId) => new SupportivekoalaipTriggers(connectionId);
    }
}