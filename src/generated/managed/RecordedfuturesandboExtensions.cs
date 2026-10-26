//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturesandbo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RecordedfuturesandboActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetReportResponse, ApiConnectionActionConfiguration> GetReport(Expression<Func<string>> sampleId, Expression<Func<string>> sandboxToken = null, Expression<Func<regionInput>> region = null)
        {
            var __workflow_sampleId = WorkflowExpression.Compile(sampleId, nameof(sampleId), required: true);
            var __workflow_sandboxToken = WorkflowExpression.Compile(sandboxToken, nameof(sandboxToken), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            return new DeferredBodyAction<GetReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/samples/{0}/overview.json", __workflow_sampleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = ExpressionConverter.Convert(__workflow_sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (__workflow_region != null)
                    callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<GetReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetSummaryResponse, ApiConnectionActionConfiguration> GetSummary(Expression<Func<string>> sampleId, Expression<Func<string>> sandboxToken = null, Expression<Func<regionInput>> region = null)
        {
            var __workflow_sampleId = WorkflowExpression.Compile(sampleId, nameof(sampleId), required: true);
            var __workflow_sandboxToken = WorkflowExpression.Compile(sandboxToken, nameof(sandboxToken), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            return new DeferredBodyAction<GetSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/samples/{0}", __workflow_sampleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = ExpressionConverter.Convert(__workflow_sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (__workflow_region != null)
                    callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<GetSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitUrlSampleResponse, ApiConnectionActionConfiguration> SubmitUrlSample(Expression<Func<string>> sandboxToken = null, Expression<Func<regionInput>> region = null, Expression<Func<SubmitUrlSampleInput>> body = null)
        {
            var __workflow_sandboxToken = WorkflowExpression.Compile(sandboxToken, nameof(sandboxToken), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubmitUrlSampleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/samples/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = ExpressionConverter.Convert(__workflow_sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (__workflow_region != null)
                    callPayload.Headers["Region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubmitUrlSampleResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum regionInput
    {
        [EnumMember(Value = "us")]
        Us,
        [EnumMember(Value = "eu")]
        Eu,
        [EnumMember(Value = "apj")]
        Apj
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

    public class SubmitUrlSampleInput
    {
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