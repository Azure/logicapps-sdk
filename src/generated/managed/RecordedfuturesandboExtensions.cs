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
        public IBodyWorkflowAction<GetReportResponse> GetReport([WorkflowExpression] Func<string> sampleId, [WorkflowExpression] Func<string> sandboxToken = null, [WorkflowExpression] Func<regionInput> region = null)
        {
            SourceExpression.Validate(sampleId, nameof(sampleId), required: true);
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/samples/{0}/overview.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (region != null)
                    callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                return callPayload;
            }

            return new ApiConnectionAction<GetReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetSummaryResponse> GetSummary([WorkflowExpression] Func<string> sampleId, [WorkflowExpression] Func<string> sandboxToken = null, [WorkflowExpression] Func<regionInput> region = null)
        {
            SourceExpression.Validate(sampleId, nameof(sampleId), required: true);
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/samples/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (region != null)
                    callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                return callPayload;
            }

            return new ApiConnectionAction<GetSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitUrlSampleResponse> SubmitUrlSample([WorkflowExpression] Func<string> sandboxToken = null, [WorkflowExpression] Func<regionInput> region = null, [WorkflowExpression] Func<string> bodyurl = null)
        {
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/samples/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sandboxToken != null)
                    callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                callPayload.Headers["Region"] = Convert.ToString("eu");
                if (region != null)
                    callPayload.Headers["Region"] = SourceExpressionConverter.Convert(region);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubmitUrlSampleResponse>(BuildSourceInput);
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