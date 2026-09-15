//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicesqnamaker
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicesqnamakerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        public IBodyWorkflowAction<GenerateAnswerResponse> GenerateAnswer(Expression<Func<string>> knowledgeBaseId, Expression<Func<string>> serviceHost, Expression<Func<string>> endpointKey, Expression<Func<string>> bodyquestion, Expression<Func<int>> bodytop = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/knowledgebases/{0}/generateAnswer", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeBaseId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ServiceHost"] = CSharpExpressionConverter.ConvertO(serviceHost);
            callPayload.Headers["EndpointKey"] = CSharpExpressionConverter.ConvertO(endpointKey);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["question"] = CSharpExpressionConverter.ConvertToken(bodyquestion);
            if (bodytop != null)
            {
                if (bodytop != null)
                {
                    body["top"] = CSharpExpressionConverter.ConvertToken(bodytop);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        public IBodyWorkflowAction<DownloadKnowledgeBaseResponse> DownloadKnowledgeBaseOld(Expression<Func<string>> knowledgeBaseId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/qnamaker/v4.0/knowledgebases/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeBaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DownloadKnowledgeBaseResponse>(callPayload);
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