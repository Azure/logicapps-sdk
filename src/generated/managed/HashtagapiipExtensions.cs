//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashtagapiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashtagapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsSimilarGetResponse, ApiConnectionActionConfiguration> HashtagsSimilarGet(Expression<Func<string>> keyword)
        {
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: true);
            return new DeferredBodyAction<HashtagsSimilarGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tag/predict";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                return new ApiConnectionAction<HashtagsSimilarGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTrendingGetResponse, ApiConnectionActionConfiguration> HashtagsTrendingGet()
        {
            return new DeferredBodyAction<HashtagsTrendingGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tag/trending";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HashtagsTrendingGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTopGetResponse, ApiConnectionActionConfiguration> HashtagsTopGet()
        {
            return new DeferredBodyAction<HashtagsTopGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tag/top";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HashtagsTopGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<PostCountGetResponse, ApiConnectionActionConfiguration> PostCountGet(Expression<Func<string>> tag)
        {
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: true);
            return new DeferredBodyAction<PostCountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tag/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                return new ApiConnectionAction<PostCountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<ImageHashtagsPostResponse, ApiConnectionActionConfiguration> ImageHashtags(Expression<Func<string>> bodyimage)
        {
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: true);
            return new DeferredBodyAction<ImageHashtagsPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tag/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImageHashtagsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoriesGetResponse, ApiConnectionActionConfiguration> CategoriesGet()
        {
            return new DeferredBodyAction<CategoriesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoriesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryGetResponse, ApiConnectionActionConfiguration> CategoryGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryTagsGetResponse, ApiConnectionActionConfiguration> CategoryTagsGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryTagsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/categories/{0}/tags", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryTagsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountriesGetResponse, ApiConnectionActionConfiguration> CountriesGet()
        {
            return new DeferredBodyAction<CountriesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/trending/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CountriesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountryTagsGetResponse, ApiConnectionActionConfiguration> CountryTagsGet(Expression<Func<string>> countryName)
        {
            var __workflow_countryName = WorkflowExpression.Compile(countryName, nameof(countryName), required: true);
            return new DeferredBodyAction<CountryTagsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trending/{0}/tags", __workflow_countryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CountryTagsGetResponse>(callPayload);
            });
        }
    }

    public class HashtagapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class HashtagsSimilarGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class HashtagsTrendingGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class HashtagsTopGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class PostCountGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ImageHashtagsPostResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class CategoriesGetResponse
    {
        [JsonProperty("categories")]
        public CategoriesGetResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class CategoriesGetResponseCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CategoryGetResponse
    {
        [JsonProperty("category")]
        public CategoryGetResponseCategoryType Category { get; set; }
    }

    public class CategoryGetResponseCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CategoryTagsGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class CountriesGetResponse
    {
        [JsonProperty("countries")]
        public string[] Countries { get; set; }
    }

    public class CountryTagsGetResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hashtagapiip;

    public partial class WorkflowManagedActions
    {
        public HashtagapiipActions Hashtagapiip(string connectionId) => new HashtagapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HashtagapiipTriggers Hashtagapiip(string connectionId) => new HashtagapiipTriggers(connectionId);
    }
}