//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Supportivekoalaip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SupportivekoalaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        [WorkflowExpressionFactory(nameof(__BuildImages))]
        public IBodyWorkflowAction<ImagesPostResponse> Images([WorkflowExpression] Func<string> bodytemplate, [WorkflowExpression] Func<bodyformatInput> bodyformat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImagesPostResponse> __BuildImages(WorkflowValue<string> bodytemplate, WorkflowValue<bodyformatInput> bodyformat = null)
        {
            WorkflowValue.Validate(bodytemplate, nameof(bodytemplate), required: true);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            return new DeferredBodyAction<ImagesPostResponse>(() =>
            {
                var apiCallPath = "/images/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    body["params"] = @paramsObject;
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "png";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImagesPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        [WorkflowExpressionFactory(nameof(__BuildImageGet))]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageGetResponse> __BuildImageGet(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ImageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/images/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<ImagesGetResponseItem[]> ImagesGet()
        {
            var apiCallPath = "/images";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ImagesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplate))]
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyParams = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePostResponse> __BuildTemplate(WorkflowValue<string> bodyname, WorkflowValue<string> bodyParams = null, WorkflowValue<int> bodywidth = null, WorkflowValue<int> bodyheight = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyParams, nameof(bodyParams), required: false);
            WorkflowValue.Validate(bodywidth, nameof(bodywidth), required: false);
            WorkflowValue.Validate(bodyheight, nameof(bodyheight), required: false);
            return new DeferredBodyAction<TemplatePostResponse>(() =>
            {
                var apiCallPath = "/templates/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyParams != null)
                {
                    body["params"] = ExpressionConverter.ConvertO(bodyParams);
                    bodypropCount++;
                }

                if (bodywidth != null)
                {
                    body["width"] = ExpressionConverter.ConvertO(bodywidth);
                    bodypropCount++;
                }

                if (bodyheight != null)
                {
                    body["height"] = ExpressionConverter.ConvertO(bodyheight);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateGetResponse> __BuildTemplateGet(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<TemplatesGetResponseItem[]> TemplatesGet()
        {
            var apiCallPath = "/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplatesGetResponseItem[]>(callPayload);
        }
    }

    public class SupportivekoalaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImagesPostResponse
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

    public enum bodyformatInput
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

    public class TemplatePostResponse
    {
        [JsonProperty("generatedImages")]
        public TemplatePostResponseGeneratedImagesTypeItem[] GeneratedImages { get; set; }

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

    public class TemplatePostResponseGeneratedImagesTypeItem
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
