//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesqnamaker
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicesqnamakerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateAnswer))]
        public IBodyWorkflowAction<GenerateAnswerResponse> GenerateAnswer([WorkflowExpression] Func<string> knowledgeBaseId, [WorkflowExpression] Func<string> serviceHost, [WorkflowExpression] Func<string> endpointKey, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<int> bodytop = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateAnswerResponse> __BuildGenerateAnswer(WorkflowExpression<string> knowledgeBaseId, WorkflowExpression<string> serviceHost, WorkflowExpression<string> endpointKey, WorkflowExpression<string> bodyquestion, WorkflowExpression<int> bodytop = null)
        {
            WorkflowExpression.Validate(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            WorkflowExpression.Validate(serviceHost, nameof(serviceHost), required: true);
            WorkflowExpression.Validate(endpointKey, nameof(endpointKey), required: true);
            WorkflowExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            WorkflowExpression.Validate(bodytop, nameof(bodytop), required: false);
            return new DeferredBodyAction<GenerateAnswerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/knowledgebases/{0}/generateAnswer", ExpressionConverter.ConvertWithUrlEncoding(knowledgeBaseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ServiceHost"] = ExpressionConverter.Convert(serviceHost);
                callPayload.Headers["EndpointKey"] = ExpressionConverter.Convert(endpointKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                if (bodytop != null)
                {
                    if (bodytop != null)
                    {
                        body["top"] = ExpressionConverter.ConvertO(bodytop);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["top"] = 1;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateAnswerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadKnowledgeBaseOld))]
        public IBodyWorkflowAction<DownloadKnowledgeBaseResponse> DownloadKnowledgeBaseOld([WorkflowExpression] Func<string> knowledgeBaseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DownloadKnowledgeBaseResponse> __BuildDownloadKnowledgeBaseOld(WorkflowExpression<string> knowledgeBaseId)
        {
            WorkflowExpression.Validate(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            return new DeferredBodyAction<DownloadKnowledgeBaseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/qnamaker/v4.0/knowledgebases/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeBaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DownloadKnowledgeBaseResponse>(callPayload);
            });
        }
    }

    public class CognitiveservicesqnamakerTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateAnswerResponse
    {
        [JsonProperty("answers")]
        public GenerateAnswerResponseAnswersTypeItem[] Answers { get; set; }
    }

    public class GenerateAnswerResponseAnswersTypeItem
    {
        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class DownloadKnowledgeBaseResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hostName")]
        public string HostName { get; set; }

        [JsonProperty("lastAccessedTimestamp")]
        public string LastAccessedTimestamp { get; set; }

        [JsonProperty("lastChangedTimestamp")]
        public string LastChangedTimestamp { get; set; }

        [JsonProperty("lastPublishedTimestamp")]
        public string LastPublishedTimestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("sources")]
        public string[] Sources { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesqnamaker;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicesqnamakerActions Cognitiveservicesqnamaker(string connectionId) => new CognitiveservicesqnamakerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicesqnamakerTriggers Cognitiveservicesqnamaker(string connectionId) => new CognitiveservicesqnamakerTriggers(connectionId);
    }
}