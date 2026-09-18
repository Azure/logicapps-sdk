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
        public IBodyWorkflowAction<ImagesPostResponse> Images([WorkflowExpression] Func<string> bodytemplate, [WorkflowExpression] Func<bodyformatInput> bodyformat = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/images/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ImageGetResponse>(callPayload);
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
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyParams = null, [WorkflowExpression] Func<int> bodywidth = null, [WorkflowExpression] Func<int> bodyheight = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "supportivekoalaip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateGetResponse>(callPayload);
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