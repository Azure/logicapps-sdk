//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Linkedinv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ListCompaniesResponseV2Item[], ApiConnectionActionConfiguration> ListCompanies()
        {
            return new DeferredBodyAction<ListCompaniesResponseV2Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/listCompanies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListCompaniesResponseV2Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2, ApiConnectionActionConfiguration> PostCompanyUpdate(Expression<Func<PostCompanyUpdateV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ShareResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/company/rest/posts/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ShareResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2, ApiConnectionActionConfiguration> PostUpdate(Expression<Func<PostUpdateV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ShareResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/people/rest/posts/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ShareResponseV2>(callPayload);
            });
        }
    }

    public class Linkedinv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class ListCompaniesResponseV2Item
    {
        [JsonProperty("companyUrn")]
        public string CompanyUrn { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }

    public class ShareResponseV2
    {
        [JsonProperty("id")]
        public string UpdateId { get; set; }
    }

    public class PostCompanyUpdateV2Input
    {
        [JsonProperty("author", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Company { get; set; }

        [JsonProperty("commentary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Commentary { get; set; }

        [JsonProperty("visibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostCompanyUpdateV2InputVisibilityType Visibility { get; set; }

        [JsonProperty("lifecycleState", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LifecycleState { get; set; } = "PUBLISHED";

        [JsonProperty("isReshareDisabledByAuthor", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsReshareDisabledByAuthor { get; set; } = false;

        [JsonProperty("distribution", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostCompanyUpdateV2InputDistributionType Distribution { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostCompanyUpdateV2InputContentType Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostCompanyUpdateV2InputVisibilityType
    {
        Public,
        [EnumMember(Value = "Logged in members only")]
        LoggedInMembersOnly
    }

    public class PostCompanyUpdateV2InputDistributionType
    {
        [JsonProperty("feedDistribution", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FeedDistribution { get; set; } = "MAIN_FEED";
    }

    public class PostCompanyUpdateV2InputContentType
    {
        [JsonProperty("article")]
        public PostCompanyUpdateV2InputContentTypeArticleType Article { get; set; }
    }

    public class PostCompanyUpdateV2InputContentTypeArticleType
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; } = "";

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string URLOfTheArticle { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("thumbnail")]
        public string ThumbnailURL { get; set; }
    }

    public class PostUpdateV2Input
    {
        [JsonProperty("commentary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Commentary { get; set; }

        [JsonProperty("visibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostUpdateV2InputVisibilityType Visibility { get; set; }

        [JsonProperty("lifecycleState", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LifecycleState { get; set; } = "PUBLISHED";

        [JsonProperty("isReshareDisabledByAuthor", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsReshareDisabledByAuthor { get; set; } = false;

        [JsonProperty("distribution", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostUpdateV2InputDistributionType Distribution { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostUpdateV2InputContentType Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostUpdateV2InputVisibilityType
    {
        Public,
        [EnumMember(Value = "Connections Only")]
        ConnectionsOnly,
        [EnumMember(Value = "Logged in members only")]
        LoggedInMembersOnly
    }

    public class PostUpdateV2InputDistributionType
    {
        [JsonProperty("feedDistribution", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FeedDistribution { get; set; } = "MAIN_FEED";
    }

    public class PostUpdateV2InputContentType
    {
        [JsonProperty("article")]
        public PostUpdateV2InputContentTypeArticleType Article { get; set; }
    }

    public class PostUpdateV2InputContentTypeArticleType
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; } = "";

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string URLOfTheArticle { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("thumbnail")]
        public string ThumbnailURL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2;

    public partial class WorkflowManagedActions
    {
        public Linkedinv2Actions Linkedinv2(string connectionId) => new Linkedinv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Linkedinv2Triggers Linkedinv2(string connectionId) => new Linkedinv2Triggers(connectionId);
    }
}