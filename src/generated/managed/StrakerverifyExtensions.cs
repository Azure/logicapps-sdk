//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Strakerverify
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StrakerverifyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildGetFile))]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFile(WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/file/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetKeysResponse> GetKeys()
        {
            var apiCallPath = "/key";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetKeysResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildCreateKey))]
        public IBodyWorkflowAction<GetKeyResponse> CreateKey([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetKeyResponse> __BuildCreateKey(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<GetKeyResponse>(() =>
            {
                var apiCallPath = "/key";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    if (bodydescription != null)
                    {
                        body["description"] = ExpressionConverter.ConvertO(bodydescription);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["description"] = "";
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildGetKey))]
        public IBodyWorkflowAction<GetKeyResponse> GetKey([WorkflowExpression] Func<string> keyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetKeyResponse> __BuildGetKey(WorkflowExpression<string> keyId)
        {
            WorkflowExpression.Validate(keyId, nameof(keyId), required: true);
            return new DeferredBodyAction<GetKeyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/key/{0}", ExpressionConverter.ConvertWithUrlEncoding(keyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<object> files, [WorkflowExpression] Func<string[]> languages, [WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> callbackUri)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectResponse> __BuildCreateProject(WorkflowExpression<object> files, WorkflowExpression<string[]> languages, WorkflowExpression<string> workflowId, WorkflowExpression<string> title, WorkflowExpression<string> callbackUri)
        {
            WorkflowExpression.Validate(files, nameof(files), required: true);
            WorkflowExpression.Validate(languages, nameof(languages), required: true);
            WorkflowExpression.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: true);
            WorkflowExpression.Validate(callbackUri, nameof(callbackUri), required: true);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["app_source"] = Convert.ToString("powerautomate");
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectResponse> __BuildGetProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildGetSegments))]
        public IBodyWorkflowAction<GetSegmentResponse> GetSegments([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> languageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSegmentResponse> __BuildGetSegments(WorkflowExpression<string> projectId, WorkflowExpression<string> fileId, WorkflowExpression<string> languageId, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(languageId, nameof(languageId), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetSegmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/project/{0}/segments/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(languageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<GetSegmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildConfirmProject))]
        public IWorkflowAction ConfirmProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConfirmProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/project/confirm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetTokenBalanceResponse> GetTokenBalance()
        {
            var apiCallPath = "/user/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTokenBalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkflow))]
        public IBodyWorkflowAction<GetWorkflowResponse> GetWorkflow([WorkflowExpression] Func<string> workflowId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWorkflowResponse> __BuildGetWorkflow(WorkflowExpression<string> workflowId)
        {
            WorkflowExpression.Validate(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<GetWorkflowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWorkflowResponse>(callPayload);
            });
        }
    }

    public class StrakerverifyTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetKeysResponse
    {
        [JsonProperty("api_keys")]
        public APIKeySchema[] ApiKeys { get; set; }
    }

    public class APIKeySchema
    {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetKeyResponse
    {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateProjectResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("data")]
        public Project Data { get; set; }
    }

    public class Project
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("callback_uri")]
        public JToken CallbackUri { get; set; }

        [JsonProperty("client_uuid")]
        public string ClientUuid { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("modified_at")]
        public string ModifiedAt { get; set; }

        [JsonProperty("source_files")]
        public SourceFile[] SourceFiles { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("target_languages")]
        public TargetLanguage[] TargetLanguages { get; set; }

        [JsonProperty("title")]
        public JToken Title { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SourceFile
    {
        [JsonProperty("file_uuid")]
        public string FileUuid { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("report")]
        public JToken Report { get; set; }

        [JsonProperty("target_files")]
        public TargetFile[] TargetFiles { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TargetFile
    {
        [JsonProperty("language_uuid")]
        public string LanguageUuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("target_file_uuid")]
        public string TargetFileUuid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TargetLanguage
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("site_shortname")]
        public string SiteShortname { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class GetSegmentResponse
    {
        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("language_id")]
        public string LanguageId { get; set; }

        [JsonProperty("segments")]
        public SrcProjectSchemasSegment[] Segments { get; set; }
    }

    public class SrcProjectSchemasSegment
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("source_text")]
        public string SourceText { get; set; }

        [JsonProperty("translation")]
        public SrcProjectSchemasTranslation Translation { get; set; }
    }

    public class SrcProjectSchemasTranslation
    {
        [JsonProperty("language_id")]
        public string LanguageId { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("score")]
        public JToken Score { get; set; }

        [JsonProperty("target_text")]
        public string TargetText { get; set; }

        [JsonProperty("translation_memory_matched")]
        public bool TranslationMemoryMatched { get; set; }
    }

    public class GetTokenBalanceResponse
    {
        [JsonProperty("balance")]
        public int Balance { get; set; }
    }

    public class GetWorkflowResponse
    {
        [JsonProperty("workflow")]
        public WorkflowDetail Workflow { get; set; }
    }

    public class WorkflowDetail
    {
        [JsonProperty("actions")]
        public WorkflowAction[] Actions { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WorkflowAction
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Strakerverify;

    public partial class WorkflowManagedActions
    {
        public StrakerverifyActions Strakerverify(string connectionId) => new StrakerverifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StrakerverifyTriggers Strakerverify(string connectionId) => new StrakerverifyTriggers(connectionId);
    }
}