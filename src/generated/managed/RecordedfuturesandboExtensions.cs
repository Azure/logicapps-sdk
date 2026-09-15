//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturesandbo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RecordedfuturesandboActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetReportResponse> GetReport(Expression<Func<string>> sandboxToken, Expression<Func<string>> sampleID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/samples/{0}/overview.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SandboxToken"] = CSharpExpressionConverter.ConvertO(sandboxToken);
            return new ApiConnectionAction<GetReportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetSummaryResponse> GetSummary(Expression<Func<string>> sandboxToken, Expression<Func<string>> sampleID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/samples/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SandboxToken"] = CSharpExpressionConverter.ConvertO(sandboxToken);
            return new ApiConnectionAction<GetSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitUrlSampleResponse> SubmitUrlSample(Expression<Func<string>> sandboxToken, Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = "/samples/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SandboxToken"] = CSharpExpressionConverter.ConvertO(sandboxToken);
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

            return new ApiConnectionAction<SubmitUrlSampleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitFileSampleResponse> SubmitFileSample(Expression<Func<string>> sandboxToken, Expression<Func<object>> file, Expression<Func<string>> password = null, Expression<Func<string>> userTags = null)
        {
            var apiCallPath = "/samples/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SandboxToken"] = CSharpExpressionConverter.ConvertO(sandboxToken);
            return new ApiConnectionAction<SubmitFileSampleResponse>(callPayload);
        }
    }

    public class RecordedfuturesandboTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetReportResponse
    {
        [JsonProperty("analysis")]
        public GetReportResponseAnalysisType Analysis { get; set; }

        [JsonProperty("html_report")]
        public string HtmlReport { get; set; }

        [JsonProperty("sample")]
        public GetReportResponseSampleType Sample { get; set; }

        [JsonProperty("signatures")]
        public GetReportResponseSignaturesTypeItem[] Signatures { get; set; }

        [JsonProperty("targets")]
        public GetReportResponseTargetsTypeItem[] Targets { get; set; }

        [JsonProperty("tasks")]
        public JToken Tasks { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class GetReportResponseAnalysisType
    {
        [JsonProperty("score")]
        public int Score { get; set; }
    }

    public class GetReportResponseSampleType
    {
        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }
    }

    public class GetReportResponseSignaturesTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("ttp")]
        public string[] Ttp { get; set; }
    }

    public class GetReportResponseTargetsTypeItem
    {
        [JsonProperty("iocs")]
        public GetReportResponseTargetsTypeItemIocsType Iocs { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("signatures")]
        public GetReportResponseTargetsTypeItemSignaturesTypeItem[] Signatures { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("tasks")]
        public string[] Tasks { get; set; }
    }

    public class GetReportResponseTargetsTypeItemIocsType
    {
        [JsonProperty("domains")]
        public string[] Domains { get; set; }

        [JsonProperty("ips")]
        public string[] Ips { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }
    }

    public class GetReportResponseTargetsTypeItemSignaturesTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("ttp")]
        public string[] Ttp { get; set; }
    }

    public class GetSummaryResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitted")]
        public string Submitted { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SubmitUrlSampleResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitted")]
        public string Submitted { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SubmitFileSampleResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitted")]
        public string Submitted { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturesandbo;

    public partial class WorkflowManagedActions
    {
        public RecordedfuturesandboActions Recordedfuturesandbo(string connectionId) => new RecordedfuturesandboActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RecordedfuturesandboTriggers Recordedfuturesandbo(string connectionId) => new RecordedfuturesandboTriggers(connectionId);
    }
}