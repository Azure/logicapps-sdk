//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Houdinio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HoudinioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houdinio")]
        public IBodyWorkflowAction<ScanResponse> LaunchScan(Expression<Func<string>> bodyartifact, Expression<Func<string[]>> bodyscanOn = null)
        {
            var __workflow_bodyartifact = WorkflowExpression.Compile(bodyartifact, nameof(bodyartifact), required: true);
            var __workflow_bodyscanOn = WorkflowExpression.Compile(bodyscanOn, nameof(bodyscanOn), required: false);
            return new DeferredBodyAction<ScanResponse>(() =>
            {
                var apiCallPath = "/scan/launch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["artifact"] = ExpressionConverter.ConvertO(__workflow_bodyartifact);
                if (__workflow_bodyscanOn != null)
                {
                    body["scanOn"] = ExpressionConverter.ConvertO(__workflow_bodyscanOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houdinio")]
        public IBodyWorkflowAction<ScanResult> RetrieveScan(Expression<Func<string>> scanID)
        {
            var __workflow_scanID = WorkflowExpression.Compile(scanID, nameof(scanID), required: true);
            return new DeferredBodyAction<ScanResult>(() =>
            {
                var apiCallPath = "/scan/result";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scanID"] = ExpressionConverter.Convert(__workflow_scanID);
                return new ApiConnectionAction<ScanResult>(callPayload);
            });
        }
    }

    public class HoudinioTriggers([ConnectionName] string connectionId)
    {
    }

    public class ScanResponse
    {
        [JsonProperty("scanID")]
        public string ScanID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ScanResult
    {
        [JsonProperty("scanID")]
        public string ScanID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("artifact")]
        public string Artifact { get; set; }

        [JsonProperty("scanOn")]
        public string[] ScanOn { get; set; }

        [JsonProperty("scanResults")]
        public ScanResultScanResultsType ScanResults { get; set; }

        [JsonProperty("scanTime")]
        public string ScanTime { get; set; }

        [JsonProperty("expiresAfter")]
        public string ExpiresAfter { get; set; }
    }

    public class ScanResultScanResultsType
    {
        [JsonProperty("mesmer")]
        public ScanResultScanResultsTypeMesmerType Mesmer { get; set; }

        [JsonProperty("vt")]
        public JToken Vt { get; set; }

        [JsonProperty("urlscan")]
        public JToken Urlscan { get; set; }

        [JsonProperty("alienvault")]
        public JToken Alienvault { get; set; }

        [JsonProperty("abuseipdb")]
        public JToken Abuseipdb { get; set; }
    }

    public class ScanResultScanResultsTypeMesmerType
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("globalScore")]
        public string GlobalScore { get; set; }

        [JsonProperty("relatedIOCs")]
        public string[] RelatedIOCs { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Houdinio;

    public partial class WorkflowManagedActions
    {
        public HoudinioActions Houdinio(string connectionId) => new HoudinioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HoudinioTriggers Houdinio(string connectionId) => new HoudinioTriggers(connectionId);
    }
}
