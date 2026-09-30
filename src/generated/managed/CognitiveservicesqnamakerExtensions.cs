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
        public IBodyWorkflowAction<GenerateAnswerResponse> GenerateAnswer([WorkflowExpression] Func<string> knowledgeBaseId, [WorkflowExpression] Func<string> serviceHost, [WorkflowExpression] Func<string> endpointKey, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<int> bodytop = null)
        {
            SourceExpression.Validate(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            SourceExpression.Validate(serviceHost, nameof(serviceHost), required: true);
            SourceExpression.Validate(endpointKey, nameof(endpointKey), required: true);
            SourceExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            SourceExpression.Validate(bodytop, nameof(bodytop), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/knowledgebases/{0}/generateAnswer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeBaseId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ServiceHost"] = SourceExpressionConverter.ConvertO(serviceHost);
                callPayload.Headers["EndpointKey"] = SourceExpressionConverter.ConvertO(endpointKey);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                if (bodytop != null)
                {
                    if (bodytop != null)
                    {
                        body["top"] = SourceExpressionConverter.ConvertToken(bodytop);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateAnswerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicesqnamaker")]
        public IBodyWorkflowAction<DownloadKnowledgeBaseResponse> DownloadKnowledgeBaseOld([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<string> knowledgeBaseId)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(knowledgeBaseId, nameof(knowledgeBaseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/subdomain/{0}/qnamaker/v4.0/knowledgebases/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeBaseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DownloadKnowledgeBaseResponse>(BuildSourceInput);
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