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
        public IBodyWorkflowAction<GetReportResponse> GetReport([WorkflowExpression] Func<string> sandboxToken, [WorkflowExpression] Func<string> sampleID)
        {
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: true);
            SourceExpression.Validate(sampleID, nameof(sampleID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/samples/{0}/overview.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                return callPayload;
            }

            return new ApiConnectionAction<GetReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<GetSummaryResponse> GetSummary([WorkflowExpression] Func<string> sandboxToken, [WorkflowExpression] Func<string> sampleID)
        {
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: true);
            SourceExpression.Validate(sampleID, nameof(sampleID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/samples/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                return callPayload;
            }

            return new ApiConnectionAction<GetSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitUrlSampleResponse> SubmitUrlSample([WorkflowExpression] Func<string> sandboxToken, [WorkflowExpression] Func<string> bodyurl = null)
        {
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/samples/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturesandbo")]
        public IBodyWorkflowAction<SubmitFileSampleResponse> SubmitFileSample([WorkflowExpression] Func<string> sandboxToken, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> userTags = null)
        {
            SourceExpression.Validate(sandboxToken, nameof(sandboxToken), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(password, nameof(password), required: false);
            SourceExpression.Validate(userTags, nameof(userTags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/samples/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SandboxToken"] = SourceExpressionConverter.ConvertO(sandboxToken);
                return callPayload;
            }

            return new ApiConnectionAction<SubmitFileSampleResponse>(BuildSourceInput);
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