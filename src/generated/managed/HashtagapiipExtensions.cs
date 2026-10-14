//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashtagapiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HashtagapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsSimilarGetResponse> HashtagsSimilarGet(Expression<Func<string>> keyword)
        {
            var __workflow_keyword = keyword == null ? null : WorkflowExpression.Compile(keyword);
            WorkflowExpression.Validate(__workflow_keyword, nameof(keyword), required: true);
            return new DeferredBodyAction<HashtagsSimilarGetResponse>(() =>
            {
                var apiCallPath = "/tag/predict";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                return new ApiConnectionAction<HashtagsSimilarGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTrendingGetResponse> HashtagsTrendingGet()
        {
            var apiCallPath = "/tag/trending";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HashtagsTrendingGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTopGetResponse> HashtagsTopGet()
        {
            var apiCallPath = "/tag/top";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HashtagsTopGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<PostCountGetResponse> PostCountGet(Expression<Func<string>> tag)
        {
            var __workflow_tag = tag == null ? null : WorkflowExpression.Compile(tag);
            WorkflowExpression.Validate(__workflow_tag, nameof(tag), required: true);
            return new DeferredBodyAction<PostCountGetResponse>(() =>
            {
                var apiCallPath = "/tag/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                return new ApiConnectionAction<PostCountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<ImageHashtagsPostResponse> ImageHashtags(Expression<Func<string>> bodyimage)
        {
            var __workflow_bodyimage = bodyimage == null ? null : WorkflowExpression.Compile(bodyimage);
            WorkflowExpression.Validate(__workflow_bodyimage, nameof(bodyimage), required: true);
            return new DeferredBodyAction<ImageHashtagsPostResponse>(() =>
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
        public IBodyWorkflowAction<CategoriesGetResponse> CategoriesGet()
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CategoriesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryGetResponse> CategoryGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryTagsGetResponse> CategoryTagsGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/categories/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryTagsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountriesGetResponse> CountriesGet()
        {
            var apiCallPath = "/trending/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CountriesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountryTagsGetResponse> CountryTagsGet(Expression<Func<string>> countryName)
        {
            var __workflow_countryName = countryName == null ? null : WorkflowExpression.Compile(countryName);
            WorkflowExpression.Validate(__workflow_countryName, nameof(countryName), required: true);
            return new DeferredBodyAction<CountryTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trending/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_countryName, 1));
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
