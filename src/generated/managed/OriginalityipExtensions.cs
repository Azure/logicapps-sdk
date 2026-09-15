//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Originalityip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OriginalityipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "originalityip")]
        public IBodyWorkflowAction<GetCreditBalanceResponse> GetCreditBalance(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1/account/credits/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetCreditBalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "originalityip")]
        public IBodyWorkflowAction<GetCreditUsageResponse> GetCreditUsage(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1/account/credits/content_scan_usage";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetCreditUsageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "originalityip")]
        public IBodyWorkflowAction<GetPaymentResponse> GetPayment(Expression<Func<string>> accept)
        {
            var apiCallPath = "/api/v1/account/credits/payments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction<GetPaymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "originalityip")]
        public IBodyWorkflowAction<PostAIDetectionResponse> PostAIDetection(Expression<Func<string>> bodycontent = null)
        {
            var apiCallPath = "/api/v1/scan/ai";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontent != null)
            {
                body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostAIDetectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "originalityip")]
        public IBodyWorkflowAction<PostUrlAIDetectionResponse> PostUrlAIDetection(Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = "/api/v1/scan/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyurl != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostUrlAIDetectionResponse>(callPayload);
        }
    }

    public class OriginalityipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCreditBalanceResponse
    {
        [JsonProperty("balance")]
        public int Balance { get; set; }
    }

    public class GetCreditUsageResponse
    {
        [JsonProperty("usage")]
        public GetCreditUsageResponseUsageTypeItem[] Usage { get; set; }
    }

    public class GetCreditUsageResponseUsageTypeItem
    {
        [JsonProperty("contentID")]
        public string ContentID { get; set; }

        [JsonProperty("credits_used")]
        public int CreditsUsed { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class GetPaymentResponse
    {
        [JsonProperty("payments")]
        public GetPaymentResponsePaymentsTypeItem[] Payments { get; set; }
    }

    public class GetPaymentResponsePaymentsTypeItem
    {
        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PostAIDetectionResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("score")]
        public PostAIDetectionResponseScoreType Score { get; set; }

        [JsonProperty("credits_used")]
        public int CreditsUsed { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class PostAIDetectionResponseScoreType
    {
        [JsonProperty("original")]
        public double Original { get; set; }

        [JsonProperty("ai")]
        public double Ai { get; set; }
    }

    public class PostUrlAIDetectionResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_code")]
        public int UrlCode { get; set; }

        [JsonProperty("credits_used")]
        public int CreditsUsed { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("word_count")]
        public int WordCount { get; set; }

        [JsonProperty("score")]
        public PostUrlAIDetectionResponseScoreType Score { get; set; }

        [JsonProperty("score_breakdown")]
        public PostUrlAIDetectionResponseScoreBreakdownTypeItem[] ScoreBreakdown { get; set; }

        [JsonProperty("results")]
        public PostUrlAIDetectionResponseResultsType Results { get; set; }
    }

    public class PostUrlAIDetectionResponseScoreType
    {
        [JsonProperty("original")]
        public double Original { get; set; }

        [JsonProperty("ai")]
        public double Ai { get; set; }
    }

    public class PostUrlAIDetectionResponseScoreBreakdownTypeItem
    {
        [JsonProperty("original")]
        public double Original { get; set; }

        [JsonProperty("ai")]
        public double Ai { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsType
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("totalAIResults")]
        public PostUrlAIDetectionResponseResultsTypeTotalAIResultsType TotalAIResults { get; set; }

        [JsonProperty("blocks")]
        public PostUrlAIDetectionResponseResultsTypeBlocksTypeItem[] Blocks { get; set; }

        [JsonProperty("results")]
        public PostUrlAIDetectionResponseResultsTypeResultsType Results { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeTotalAIResultsType
    {
        [JsonProperty("real")]
        public double Real { get; set; }

        [JsonProperty("fake")]
        public double Fake { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeBlocksTypeItem
    {
        [JsonProperty("original")]
        public double Original { get; set; }

        [JsonProperty("ai")]
        public double Ai { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeResultsType
    {
        [JsonProperty("pageID")]
        public int PageID { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("aiResults")]
        public PostUrlAIDetectionResponseResultsTypeResultsTypeAiResultsType AiResults { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("aiTextBlocks")]
        public PostUrlAIDetectionResponseResultsTypeResultsTypeAiTextBlocksTypeItem[] AiTextBlocks { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeResultsTypeAiResultsType
    {
        [JsonProperty("real")]
        public double Real { get; set; }

        [JsonProperty("fake")]
        public double Fake { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeResultsTypeAiTextBlocksTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public PostUrlAIDetectionResponseResultsTypeResultsTypeAiTextBlocksTypeItemResultType Result { get; set; }
    }

    public class PostUrlAIDetectionResponseResultsTypeResultsTypeAiTextBlocksTypeItemResultType
    {
        [JsonProperty("fake")]
        public double Fake { get; set; }

        [JsonProperty("real")]
        public double Real { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Originalityip;

    public partial class WorkflowManagedActions
    {
        public OriginalityipActions Originalityip(string connectionId) => new OriginalityipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OriginalityipTriggers Originalityip(string connectionId) => new OriginalityipTriggers(connectionId);
    }
}