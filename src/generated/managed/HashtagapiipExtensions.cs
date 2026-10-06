//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashtagapiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashtagapiipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [WorkflowExpressionFactory(nameof(__BuildHashtagsSimilarGet))]
        public IBodyWorkflowAction<HashtagsSimilarGetResponse> HashtagsSimilarGet([WorkflowExpression] Func<string> keyword)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HashtagsSimilarGetResponse> __BuildHashtagsSimilarGet(WorkflowExpression<string> keyword)
        {
            WorkflowExpression.Validate(keyword, nameof(keyword), required: true);
            return new DeferredBodyAction<HashtagsSimilarGetResponse>(() =>
            {
                var apiCallPath = "/tag/predict";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(keyword);
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
        [WorkflowExpressionFactory(nameof(__BuildPostCountGet))]
        public IBodyWorkflowAction<PostCountGetResponse> PostCountGet([WorkflowExpression] Func<string> tag)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCountGetResponse> __BuildPostCountGet(WorkflowExpression<string> tag)
        {
            WorkflowExpression.Validate(tag, nameof(tag), required: true);
            return new DeferredBodyAction<PostCountGetResponse>(() =>
            {
                var apiCallPath = "/tag/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                return new ApiConnectionAction<PostCountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [WorkflowExpressionFactory(nameof(__BuildImageHashtags))]
        public IBodyWorkflowAction<ImageHashtagsPostResponse> ImageHashtags([WorkflowExpression] Func<string> bodyimage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageHashtagsPostResponse> __BuildImageHashtags(WorkflowExpression<string> bodyimage)
        {
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: true);
            return new DeferredBodyAction<ImageHashtagsPostResponse>(() =>
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
        [WorkflowExpressionFactory(nameof(__BuildCategoryGet))]
        public IBodyWorkflowAction<CategoryGetResponse> CategoryGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoryGetResponse> __BuildCategoryGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [WorkflowExpressionFactory(nameof(__BuildCategoryTagsGet))]
        public IBodyWorkflowAction<CategoryTagsGetResponse> CategoryTagsGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoryTagsGetResponse> __BuildCategoryTagsGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/categories/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildCountryTagsGet))]
        public IBodyWorkflowAction<CountryTagsGetResponse> CountryTagsGet([WorkflowExpression] Func<string> countryName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountryTagsGetResponse> __BuildCountryTagsGet(WorkflowExpression<string> countryName)
        {
            WorkflowExpression.Validate(countryName, nameof(countryName), required: true);
            return new DeferredBodyAction<CountryTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trending/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(countryName, 1));
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