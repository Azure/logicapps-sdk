//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Strakerverify
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StrakerverifyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/file/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetKeysResponse> GetKeys()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/key";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetKeysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetKeyResponse> CreateKey([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetKeyResponse> GetKey([WorkflowExpression] Func<string> keyId)
        {
            SourceExpression.Validate(keyId, nameof(keyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/key/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetSegmentResponse> GetSegments([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> languageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(languageId, nameof(languageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/project/{0}/segments/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(languageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetSegmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetTokenBalanceResponse> GetTokenBalance()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTokenBalanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strakerverify")]
        public IBodyWorkflowAction<GetWorkflowResponse> GetWorkflow([WorkflowExpression] Func<string> workflowId)
        {
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWorkflowResponse>(BuildSourceInput);
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