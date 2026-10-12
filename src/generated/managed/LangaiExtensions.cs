//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Langai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LangaiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyze))]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyprojectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnalyzeResponse> __BuildAnalyze(WorkflowExpression<string> bodytext, WorkflowExpression<string> bodyprojectId)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = "/api/v1/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        [WorkflowExpressionFactory(nameof(__BuildDocuments))]
        public IBodyWorkflowAction<DocumentsResponse> Documents([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentsResponse> __BuildDocuments(WorkflowExpression<string> bodytext, WorkflowExpression<string> bodyprojectId, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodydate = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<DocumentsResponse>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<ProjectsResponseItem[]> Projects()
        {
            var apiCallPath = "/api/v1/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ProjectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        [WorkflowExpressionFactory(nameof(__BuildTags))]
        public IBodyWorkflowAction<TagsResponse> Tags([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagsResponse> __BuildTags(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TagsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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