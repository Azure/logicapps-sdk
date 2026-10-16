//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Everyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EveryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<BrowseResponse> Browse(Expression<Func<string>> cause, Expression<Func<int>> take = null, Expression<Func<int>> page = null)
        {
            var __workflow_cause = WorkflowExpression.Compile(cause, nameof(cause), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<BrowseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/browse/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cause, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<BrowseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> term, Expression<Func<int>> take = null, Expression<Func<string>> cause = null)
        {
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_cause = WorkflowExpression.Compile(cause, nameof(cause), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/search/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_term, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_cause != null)
                    callPayload.Queries["cause"] = ExpressionConverter.Convert(__workflow_cause);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "everyip")]
        public IBodyWorkflowAction<DetailsResponse> Details(Expression<Func<string>> identifier)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<DetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/nonprofit/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_identifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetailsResponse>(callPayload);
            });
        }
    }

    public class EveryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BrowseResponse
    {
        [JsonProperty("nonprofits")]
        public BrowseResponseNonprofitsTypeItem[] Nonprofits { get; set; }
    }

    public class BrowseResponseNonprofitsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("nonprofits")]
        public SearchResponseNonprofitsTypeItem[] Nonprofits { get; set; }
    }

    public class SearchResponseNonprofitsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }

    public class DetailsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("logoCloudinaryId")]
        public string LogoCloudinaryId { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("matchedTerms")]
        public string[] MatchedTerms { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Everyip;

    public partial class WorkflowManagedActions
    {
        public EveryipActions Everyip(string connectionId) => new EveryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EveryipTriggers Everyip(string connectionId) => new EveryipTriggers(connectionId);
    }
}
