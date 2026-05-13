//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashtagapiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashtagapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsSimilarGetResponse> HashtagsSimilarGet(Expression<Func<string>> keyword)
        {
            var apiCallPath = "/tag/predict";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["keyword"] = ExpressionConverter.Convert(keyword);
            return new ApiConnectionAction<HashtagsSimilarGetResponse>(callPayload);
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
            var apiCallPath = "/tag/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            return new ApiConnectionAction<PostCountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<ImageHashtagsPostResponse> ImageHashtags(Expression<Func<string>> bodyimage)
        {
            var apiCallPath = "/tag/generate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["image"] = ExpressionConverter.ConvertO(bodyimage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImageHashtagsPostResponse>(callPayload);
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
            var apiCallPath = String.Format("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CategoryGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryTagsGetResponse> CategoryTagsGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/categories/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CategoryTagsGetResponse>(callPayload);
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
            var apiCallPath = String.Format("/trending/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(countryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CountryTagsGetResponse>(callPayload);
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