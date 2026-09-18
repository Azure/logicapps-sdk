//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Langai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LangaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<AnalyzeResponse> Analyze([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyprojectId)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AnalyzeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<DocumentsResponse> Documents([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodydate = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
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
                return callPayload;
            }

            return new ApiConnectionAction<DocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<ProjectsResponseItem[]> Projects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ProjectsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "langai")]
        public IBodyWorkflowAction<TagsResponse> Tags([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<TagsResponse>(BuildSourceInput);
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