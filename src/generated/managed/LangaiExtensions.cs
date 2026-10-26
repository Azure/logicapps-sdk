//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Langai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LangaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<AnalyzeResponse, ApiConnectionActionConfiguration> Analyze(Expression<Func<AnalyzeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AnalyzeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<DocumentsResponse, ApiConnectionActionConfiguration> Documents(Expression<Func<DocumentsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<ProjectsResponseItem[], ApiConnectionActionConfiguration> Projects()
        {
            return new DeferredBodyAction<ProjectsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ProjectsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<TagsResponse, ApiConnectionActionConfiguration> Tags(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<TagsResponse>(callPayload);
            });
        }
    }

    public class LangaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class AnalyzeResponse
    {
        [JsonProperty("tags")]
        public AnalyzeResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("intents")]
        public AnalyzeResponseIntentsTypeItem[] Intents { get; set; }
    }

    public class AnalyzeResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AnalyzeResponseIntentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }
    }

    public class AnalyzeInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }
    }

    public class DocumentsResponse
    {
        [JsonProperty("tags")]
        public DocumentsResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("intents")]
        public DocumentsResponseIntentsTypeItem[] Intents { get; set; }
    }

    public class DocumentsResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DocumentsResponseIntentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }
    }

    public class DocumentsInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ProjectsResponseItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class TagsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("tags")]
        public TagsResponseTagsTypeItem[] Tags { get; set; }
    }

    public class TagsResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Langai;

    public partial class WorkflowManagedActions
    {
        public LangaiActions Langai(string connectionId) => new LangaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LangaiTriggers Langai(string connectionId) => new LangaiTriggers(connectionId);
    }
}