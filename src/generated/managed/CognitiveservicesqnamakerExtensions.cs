//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesqnamaker
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicesqnamakerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        public IBodyWorkflowAction<GenerateAnswerResponse, ApiConnectionActionConfiguration> GenerateAnswer(Expression<Func<string>> knowledgeBaseId, Expression<Func<string>> serviceHost, Expression<Func<string>> endpointKey, Expression<Func<string>> bodyquestion, Expression<Func<int>> bodytop = null)
        {
            var __workflow_knowledgeBaseId = WorkflowExpression.Compile(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            var __workflow_serviceHost = WorkflowExpression.Compile(serviceHost, nameof(serviceHost), required: true);
            var __workflow_endpointKey = WorkflowExpression.Compile(endpointKey, nameof(endpointKey), required: true);
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            var __workflow_bodytop = WorkflowExpression.Compile(bodytop, nameof(bodytop), required: false);
            return new DeferredBodyAction<GenerateAnswerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/knowledgebases/{0}/generateAnswer", __workflow_knowledgeBaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ServiceHost"] = ExpressionConverter.Convert(__workflow_serviceHost);
                callPayload.Headers["EndpointKey"] = ExpressionConverter.Convert(__workflow_endpointKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                if (__workflow_bodytop != null)
                {
                    if (__workflow_bodytop != null)
                    {
                        body["top"] = ExpressionConverter.ConvertO(__workflow_bodytop);
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
        public IBodyWorkflowAction<DownloadKnowledgeBaseResponse, ApiConnectionActionConfiguration> DownloadKnowledgeBaseOld(Expression<Func<string>> subdomainName, Expression<Func<string>> knowledgeBaseId)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_knowledgeBaseId = WorkflowExpression.Compile(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            return new DeferredBodyAction<DownloadKnowledgeBaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/subdomain/{0}/qnamaker/v4.0/knowledgebases/{1}", __workflow_subdomainName.WithUrlEncoding(2), __workflow_knowledgeBaseId.WithUrlEncoding(1)));
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