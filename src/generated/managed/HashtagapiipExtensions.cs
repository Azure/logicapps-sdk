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
        public IBodyWorkflowAction<HashtagsSimilarGetResponse> HashtagsSimilarGet([WorkflowExpression] Func<string> keyword)
        {
            SourceExpression.Validate(keyword, nameof(keyword), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tag/predict";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                return callPayload;
            }

            return new ApiConnectionAction<HashtagsSimilarGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTrendingGetResponse> HashtagsTrendingGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tag/trending";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HashtagsTrendingGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<HashtagsTopGetResponse> HashtagsTopGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tag/top";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HashtagsTopGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<PostCountGetResponse> PostCountGet([WorkflowExpression] Func<string> tag)
        {
            SourceExpression.Validate(tag, nameof(tag), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tag/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = SourceExpressionConverter.ConvertO(tag);
                return callPayload;
            }

            return new ApiConnectionAction<PostCountGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<ImageHashtagsPostResponse> ImageHashtags([WorkflowExpression] Func<string> bodyimage)
        {
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tag/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageHashtagsPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoriesGetResponse> CategoriesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CategoriesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryGetResponse> CategoryGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CategoryGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CategoryTagsGetResponse> CategoryTagsGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/categories/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CategoryTagsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountriesGetResponse> CountriesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trending/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountriesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashtagapiip")]
        public IBodyWorkflowAction<CountryTagsGetResponse> CountryTagsGet([WorkflowExpression] Func<string> countryName)
        {
            SourceExpression.Validate(countryName, nameof(countryName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trending/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountryTagsGetResponse>(BuildSourceInput);
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